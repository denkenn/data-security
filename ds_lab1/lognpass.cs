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
using System.Runtime;
using static System.Random;

namespace ds_lab1
{
    public partial class lognpass : Form
    {
        Dictionary<string, int> tries = new Dictionary<string, int>(Program.count);
        //Текущий пользователь
        public user current;

        public static bool flenter_click = false;

        public lognpass()
        {
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subs = line.Split('|');
                    if (!tries.ContainsKey(subs[0]))
                    {
                        tries.Add(subs[0], 3);
                    }
                }
            }
            InitializeComponent();
            error.Hide();
            password.PasswordChar = '*';
            flenter_click = false;
        }

        private void enter_Click(object sender, EventArgs e)
        {
            if (password.Text.Contains(' '))
            {
                error.Text = "Недопустимые символы";
                error.Show();
                return;
            }
            bool file_fl = false, middle = false, fl_error = false;
            string file_before = "";
            string file_after = "";
            string new_pass = "";
            error.Hide();
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subs = line.Split('|');
                    if (login.Text == subs[0])
                    {
                        middle = true;
                        if (subs[2] == "1")
                        {
                            error.Text = "Аккаунт заблокирован";
                            fl_error = true;
                            break;
                        }
                        if (subs[1] == "^")
                        {
                            error.Text = "Пароль еще не был задан, введите новый";
                            fl_error = true;
                            break;
                        }
                        //-----------------------------------------------расшифровка
                        string[] cipher_arr = subs[1].Split(' ');
                        int seed = 0;
                        int tmp = 0;
                        string pass = password.Text;
                        for (int i = 0; i < pass.Length; i++)
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
                        char recipher;
                        string recipher_string = "";
                        for (int i = 0; i < Math.Min(cipher_arr.Length, key.Length); ++i)
                        {
                            recipher = (char)(Convert.ToInt32(cipher_arr[i]) ^ (int)key[i]);
                            recipher_string += recipher;
                        }
                        //-------------------------------------------------------
                        if (recipher_string != password.Text)
                        {
                            fl_error = true;
                            if (tries[subs[0]] > 0)
                            {
                                --tries[subs[0]];
                                error.Text = "Неверный пароль. Осталось попыток: " + tries[subs[0]].ToString();
                            }
                            else
                            {
                                error.Text = "Аккаунт заблокирован";
                                break;
                            }
                        }
                        else
                        {
                            current.name = subs[0];
                            current.password = subs[1];
                            current.blocked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                            current.bounded = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                            error.Hide();
                        }

                        if (tries[subs[0]] == 0)
                        {
                            error.Text = "Аккаунт заблокирован";
                            fl_error = true;
                            subs[2] = "1";
                            for (int i = 0; i < subs.Length - 1; ++i)
                            {
                                subs[i] += "|";
                            }
                            new_pass = String.Concat(subs);
                            file_fl = true;
                        }
                    }
                    else
                    {
                        if (!middle)
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
            if (file_fl)
            {
                using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                {
                    file_before += new_pass;
                    file_before += file_after;
                    file_before = file_before.Substring(0, file_before.Length - 1);
                    sw.WriteLine(file_before);
                }
            }
            if (!fl_error && middle)
            {
                login.Text = "";
                password.Text = "";
                tries[login.Text] = 3;
                data.value = current;
                flenter_click = true;
                this.Close();
            }
            else if (!middle)
            {
                error.Text = "Пользователя с таким именем нет в базе";
                error.Show();
            }
            else
            {
                error.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            first form1 = new first();
            form1.ShowDialog();
            this.Show();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            error.Hide();
        }

        private void lognpass_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!flenter_click)
            {
                Program.WriteInFile();
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newpassphrase form = new newpassphrase();
            form.Show();
        }
    }
}
