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

namespace ds_lab1
{
    public partial class new_user : Form
    {
        public new_user()
        {
            InitializeComponent();
            label2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                bool fl = true;
                using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] subs = line.Split('|');
                        if (textBox1.Text == subs[0])
                        {
                            fl = false;
                        }
                    }
                }
                if (fl)
                {
                    using (StreamWriter sw = new StreamWriter(Program.path, true, System.Text.Encoding.Default))
                    {
                        string pass = textBox1.Text + "|^|0|0";
                        sw.WriteLine(pass);
                    }
                    ++Program.count;
                    this.Close();
                }
                else
                {
                    label2.Text = "Пользователь с таким именем уже существует";
                    label2.Show();
                }
            }
            else
            {
                label2.Text = "Нельзя задать пустое имя пользователя";
                label2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
