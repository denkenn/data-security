using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace ds_lab1
{
    public partial class phrase : Form
    {
        static public byte[] key;
        static public string pass = "";
        int tries = 3;
        static public bool FormClosedOK;
        public phrase()
        {
            InitializeComponent();
            if (!Program.CryptFileEmpty)
            {
                label2.Hide();
            }
            FormClosedOK = false;
            text_phrase.PasswordChar = '*';
        }
        private void OK_Click(object sender, EventArgs e)
        {
            pass = text_phrase.Text;
            bool isOkay = false;
            if (Program.CryptFileEmpty && text_phrase.Text != "")
            {
                File.Create(Program.path).Close();
                using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine("admin|^|0|0");
                }
                isOkay = true;
                FormClosedOK = true;
            }
            else
            {
                if (text_phrase.Text == "")
                {
                    --tries;
                    DialogResult result = MessageBox.Show("Пустая парольная фраза, оставшиеся попытки: " + Convert.ToString(tries),
                        "Ошибка", MessageBoxButtons.OK);
                    if (tries == 0)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    //Задание по варианту: 3DES
                    //                     Обратная связь по шифротексту
                    //                     Добавление к ключу случайного значения - Да
                    //                     MD4
                    string text = File.ReadAllText(Program.cryptpath);
                    string descr = TripleDes.Decrypt(text);
                    if (descr.Substring(0, 5) != "admin")
                    {
                        --tries;
                        DialogResult result = MessageBox.Show("Неправильная парольная фраза, оставшиеся попытки: " + Convert.ToString(tries),
                            "Ошибка", MessageBoxButtons.OK);
                        if (tries == 0)
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        File.Create(Program.path).Close();
                        using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(descr);
                        }
                        string Cleaned = "";
                        using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line != "" && line != "\n")
                                {
                                    string[] subs = line.Split('|');
                                    if (subs.Length != 1)
                                    {
                                        if (subs[3].Length != 1)
                                        {
                                            subs[3] = subs[3].Substring(0, 1);
                                        }
                                        for (int i = 0; i < subs.Length - 1; ++i)
                                        {
                                            subs[i] += "|";
                                        }
                                        line = String.Concat(subs);
                                        Cleaned += line;
                                        Cleaned += '\n';
                                    }
                                }
                            }
                        }
                        Cleaned = Cleaned.Substring(0, Cleaned.Length - 1);
                        using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                        {
                            sw.WriteLine(Cleaned);
                        }
                        isOkay = true;
                        FormClosedOK = true;
                    }
                }
            }
            if (isOkay) this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закрыть приложение?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void phrase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!FormClosedOK)
            {
                Application.Exit();
            }
        }
    }
    static class MD4
    {
        public static byte[] MD4Hash(this string input)
        {
            List<byte> bytes = UTF8Encoding.UTF8.GetBytes(input).ToList();
            uint bitCount = (uint)(bytes.Count) * 8;
            bytes.Add(128);
            while (bytes.Count % 64 != 56) bytes.Add(0);
            var uints = new List<uint>();
            for (int i = 0; i + 3 < bytes.Count; i += 4)
                uints.Add(bytes[i] | (uint)bytes[i + 1] << 8 | (uint)bytes[i + 2] << 16 | (uint)bytes[i + 3] << 24);
            uints.Add(bitCount);
            uints.Add(0);


            uint a = 0x67452301, b = 0xefcdab89, c = 0x98badcfe, d = 0x10325476;
            Func<uint, uint, uint> rol = (x, y) => x << (int)y | x >> 32 - (int)y;
            for (int q = 0; q + 15 < uints.Count; q += 16)
            {
                var chunk = uints.GetRange(q, 16);
                uint aa = a, bb = b, cc = c, dd = d;
                Action<Func<uint, uint, uint, uint>, uint[]> round = (f, y) =>
                {
                    foreach (uint i in new[] { y[0], y[1], y[2], y[3] })
                    {
                        a = rol(a + f(b, c, d) + chunk[(int)(i + y[4])] + y[12], y[8]);
                        d = rol(d + f(a, b, c) + chunk[(int)(i + y[5])] + y[12], y[9]);
                        c = rol(c + f(d, a, b) + chunk[(int)(i + y[6])] + y[12], y[10]);
                        b = rol(b + f(c, d, a) + chunk[(int)(i + y[7])] + y[12], y[11]);
                    }
                };
                round((x, y, z) => (x & y) | (~x & z), new uint[] { 0, 4, 8, 12, 0, 1, 2, 3, 3, 7, 11, 19, 0 });
                round((x, y, z) => (x & y) | (x & z) | (y & z), new uint[] { 0, 1, 2, 3, 0, 4, 8, 12, 3, 5, 9, 13, 0x5a827999 });
                round((x, y, z) => x ^ y ^ z, new uint[] { 0, 2, 1, 3, 0, 8, 4, 12, 3, 9, 11, 15, 0x6ed9eba1 });
                a += aa; b += bb; c += cc; d += dd;
            }

            byte[] outBytes = new[] { a, b, c, d }.SelectMany(BitConverter.GetBytes).ToArray();
            return outBytes;
        }
    }
    static class TripleDes
    {
        public static string Encrypt(String text)
        {
            string phr = phrase.pass;
            byte[] salt = new byte[8];
            new RNGCryptoServiceProvider().GetBytes(salt);
            string phrase_with_salt = phr + Encoding.ASCII.GetString(salt);
            //функция хеширования реализована ниже
            byte[] key = MD4.MD4Hash(phrase_with_salt);

            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] savedIV = new byte[8];
            byte[] cipherBytes;
            using (TripleDESCryptoServiceProvider trDes = new TripleDESCryptoServiceProvider())
            {
                trDes.BlockSize = 64;
                trDes.Mode = CipherMode.CFB;
                trDes.FeedbackSize = 8; 
                trDes.Padding = PaddingMode.Zeros;
                trDes.Key = key;

                trDes.GenerateIV();

                trDes.IV.CopyTo(savedIV, 0);

                using (var encryptor = trDes.CreateEncryptor())
                using (var msEncrypt = new MemoryStream())
                using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (var bw = new BinaryWriter(csEncrypt, Encoding.UTF8))
                {
                    bw.Write(textBytes);
                    bw.Close();

                    cipherBytes = msEncrypt.ToArray();
                }
            }
            return Convert.ToBase64String(salt) + Convert.ToBase64String(savedIV)
                + Convert.ToBase64String(cipherBytes);
        }
        public static string Decrypt(String text)
        {
            byte[] cipherBytes = Convert.FromBase64String(text.Substring(24, text.Length - 24));

            byte[] savedIV = Convert.FromBase64String(text.Substring(12, 12));

            byte[] savedSalt = Convert.FromBase64String(text.Substring(0, 12));

            string phrase_with_salt = phrase.pass + Encoding.ASCII.GetString(savedSalt);

            byte[] key = MD4.MD4Hash(phrase_with_salt);

            byte[] plainBytes;
            using (TripleDESCryptoServiceProvider trDes = new TripleDESCryptoServiceProvider())
            {
                trDes.BlockSize = 64;
                trDes.KeySize = 128;
                trDes.Mode = CipherMode.CFB;
                trDes.FeedbackSize = 8;
                trDes.Padding = PaddingMode.Zeros;

                trDes.Key = key;
                trDes.IV = savedIV;

                using (var decryptor = trDes.CreateDecryptor())
                using (var msEncrypt = new MemoryStream(cipherBytes))
                using (var csEncrypt = new CryptoStream(msEncrypt, decryptor, CryptoStreamMode.Read))
                using (var br = new BinaryReader(csEncrypt, Encoding.UTF8))
                {
                    plainBytes = br.ReadBytes(cipherBytes.Length);
                }
            }
            string result = Encoding.UTF8.GetString(plainBytes);
            return result;
        }
    }
}
