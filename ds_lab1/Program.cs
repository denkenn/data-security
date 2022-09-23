using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace ds_lab1
{
    public struct user
    {
        public string name;
        public string password;
        public bool blocked;
        public bool bounded;
    }
    public static class data
    {
        public static user value { get; set; }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static main form3;
        public static bool CryptFileEmpty;
        public static string path = @"data.txt";
        public static string cryptpath = @"cryptdata.txt";
        public static int count;
        [STAThread]
        static void Main()
        {
            if (File.Exists(cryptpath))
            {
                var fi = new FileInfo(cryptpath);
                if (fi.Length == 0)
                    CryptFileEmpty = true;
                else
                    CryptFileEmpty = false;
            }
            else
            {
                File.Create(cryptpath).Close();
                CryptFileEmpty = true;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form3 = new main());
        }
        public static void WriteInFile()
        {
            try
            {
                string text = File.ReadAllText(path);
                File.Delete(path);
                using (StreamWriter sw = new StreamWriter(cryptpath, false, System.Text.Encoding.Default))
                {
                    string encrypt = TripleDes.Encrypt(text);
                    sw.WriteLine(encrypt);
                }
            } catch
            {

            }
        }
    }
}
