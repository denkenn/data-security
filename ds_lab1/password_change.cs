using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ds_lab1
{
    public partial class password_change : Form
    {
        user current = data.value;
        public password_change()
        {
            InitializeComponent();
            error.Hide();
            old.PasswordChar = '*';
            newpas.PasswordChar = '*';
            newpass2.PasswordChar = '*';
            if (current.bounded)
            {
                error.Text = "Пароль должен содержать:\nЧередование букв, знаков препинания, цифр и снова букв";
                error.Show();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            error.Text = "";
            string file_before = "";
            string file_after = "";
            string new_info = "";
            bool fl = false;
            if (newpas.Text != newpass2.Text)
            {
                error.Text = "Пароли не совпадают";
            }
            else
            {
                using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] subs = line.Split('|');
                        if (subs[0] == current.name)
                        {
                            if (current.bounded)
                            {
                                Regex regex = new Regex(@"[а-яa-z][,.;!?:\-\(\)\[\]]+[0-9]+[а-яa-z]");
                                MatchCollection matches = regex.Matches(newpas.Text);
                                if (matches.Count == 0)
                                {
                                    error.Text = "Пароль должен содержать:\nЧередование букв, знаков препинания, цифр и снова букв";
                                    break;
                                }
                            }
                            fl = true;
                            //-----------------------------------------------------
                            int seed = 0;
                            int tmp = 0;
                            string pass = old.Text;
                            for (int i = 1; i < pass.Length; i = i + 2)
                            {
                                tmp = (int)pass[i];
                                if (tmp % 2 == 0)
                                    seed += tmp;
                            }
                            seed = seed % 256;
                            var rand = new Random(seed);
                            for (int i = 0; i < 3; ++i)
                            {
                                rand.Next();
                            }
                            string key = Convert.ToString(rand.Next());
                            while (key.Length < pass.Length)
                            {
                                key += key;
                            }
                            key = key.Substring(0, pass.Length);
                            int cipher1;
                            string cipher_string1 = "";
                            for (int i = 0; i < pass.Length; ++i)
                            {
                                cipher1 = pass[i] ^ key[i];
                                cipher_string1 += cipher1;
                                cipher_string1 += " ";
                            }
                            cipher_string1 = cipher_string1.Substring(0, cipher_string1.Length - 1);
                            if (current.password != cipher_string1)
                            {
                                error.Text = "Неверный старый пароль";
                                error.Show();
                                return;
                            }
                            //------------------------------------------------------
                            seed = 0;
                            pass = newpas.Text;
                            for (int i = 1; i < pass.Length; i = i + 2)
                            {
                                seed += (int)pass[i];
                            }
                            seed = seed % 256;
                            Random rand2 = new Random(seed);
                            for (int i = 0; i < 3; ++i)
                            {
                                rand2.Next();
                            }
                            string key2 = Convert.ToString(rand2.Next());
                            while (key2.Length < pass.Length)
                            {
                                key2 += key2;
                            }
                            key2 = key2.Substring(0, pass.Length);
                            int cipher;
                            string cipher_string = "";
                            for (int i = 0; i < key2.Length; ++i)
                            {
                                cipher = pass[i] ^ key2[i];
                                cipher_string += cipher;
                                cipher_string += " ";
                            }
                            cipher_string = cipher_string.Substring(0, cipher_string.Length - 1);
                            //--------------------------------------------------------------
                            subs[1] = cipher_string;
                            current.password = cipher_string;
                            data.value = current;
                            for (int i = 0; i < subs.Length-1; ++i)
                            {
                                subs[i] += "|";
                            }
                            new_info = string.Concat(subs);
                            new_info += '\n';
                        }
                        else
                        {
                            if (!fl)
                            {
                                file_before += line;
                                file_before += '\n';
                            }
                            else
                            {
                                file_after += line;
                                file_after += '\n';
                            }
                        }
                    }
                }
                if (fl)
                {
                    using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                    {
                        current.password = newpas.Text;
                        file_before += new_info;
                        file_before += file_after;
                        file_before = file_before.Substring(0, file_before.Length - 1);
                        sw.WriteLine(file_before);
                    }
                    this.Close();
                }
            }
            error.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newpas_TextChanged(object sender, EventArgs e)
        {
            error.Hide();
        }
    }
}
