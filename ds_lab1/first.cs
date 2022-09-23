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
using static System.Random;

namespace ds_lab1
{
    public partial class first : Form
    {
        public first()
        {
            InitializeComponent();
            gif.Hide();
            pass2.Hide();
            label3.Hide();
            error.Hide();
            accept.Enabled = false;
            password.PasswordChar = '*';
            pass2.PasswordChar = '*';
        }

        bool fl_login = false, fl_pass = false;
        private void login_TextChanged(object sender, EventArgs e)
        {
            if (login.Text != "")
            {
                i = 0;
                gif.Hide();
                error.Hide();
                label3.Hide();
                pass2.Hide();
                accept.Enabled = false;
                fl_login = true;
                timer1.Start();
            }
        }

        int i = 0;

        private void pass2_TextChanged_1(object sender, EventArgs e)
        {

            i = 0;
            gif.Hide();
            error.Hide();
            accept.Enabled = false;
            fl_pass = true;
            timer1.Start();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string file_before = "";
            string file_after = "";
            string new_pass = "";
            bool fl2 = true;
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subs = line.Split('|');
                    if (login.Text == subs[0])
                    {
                        if (subs[1] == "^")
                        {
                            if (subs[3] == "1")
                            {
                                Regex regex = new Regex(@"[а-яa-z][,.;!?:\-\(\)\[\]]+[0-9]+[а-яa-z]");
                                MatchCollection matches = regex.Matches(password.Text);
                                if (matches.Count == 0)
                                {
                                    error.Text = "Пароль должен содержать: Чередование букв, \nзнаков препинания, цифр и снова букв";
                                    error.Show();
                                    break;
                                }
                            }
                            //----------------------------шифровка
                            //начальное значение датчика псевдослучайных чисел
                            //выбирается равным сумме кодов символов пароля с четными номерами по модулю 256
                            int seed = 0;
                            int tmp = 0;
                            string pass = password.Text;
                            for (int i = 0; i < pass.Length; i++) {
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
                            int cipher;
                            string cipher_string = "";
                            for (int i = 0; i < pass.Length; ++i)
                            {
                                cipher = pass[i] ^ key[i];
                                cipher_string += cipher;
                                cipher_string += " ";
                            }
                            cipher_string = cipher_string.Substring(0, cipher_string.Length - 1);
                            subs[1] = cipher_string;
                            //-----------------------------------------------
                            //-----------------------------------------------
                            for (int i = 0; i < subs.Length - 1; ++i)
                            {
                                subs[i] += "|";
                            }
                            new_pass = String.Concat(subs);
                            new_pass += "\n";
                        }
                        else
                        {
                            MessageBox.Show("Отказано в запросе\nПароль не пустой", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                        fl2 = false;
                    }
                    else
                    {
                        if (fl2)
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
            if (!fl2)
            {
                using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                {
                    file_before += new_pass;
                    file_before += file_after;
                    file_before = file_before.Substring(0, file_before.Length - 1);
                    sw.WriteLine(file_before);
                }
                this.Close();
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            accept.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
                gif.Show();
            if (i == 2)
            {
                gif.Hide();
                timer1.Stop();
                if (fl_login)
                {
                    bool fl = false;
                    using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] subs = line.Split('|');
                            if (login.Text == subs[0])
                            {
                                fl = true;
                                label3.Show();
                                pass2.Show();
                                break;
                            }
                        }
                    }
                    if (!fl)
                    {
                        error.Text = "Пользователь с таким именем отсутствует в базе";
                        error.Show();
                    }
                    fl_login = false;
                }
                if (fl_pass)
                {
                    if (password.Text != pass2.Text)
                    {
                        error.Text = "Пароли не совпадают";
                        error.Show();
                    }
                    else
                    accept.Enabled = true;
                    fl_pass = false;
                }
            }
        }
    }
}