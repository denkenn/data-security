using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds_lab1
{
    public partial class newpassphrase : Form
    {
        public newpassphrase()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != phrase.pass)
            {
                MessageBox.Show("Неправильная старая парольная фраза",
                        "Ошибка", MessageBoxButtons.OK);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Пароли не совпадают",
                        "Ошибка", MessageBoxButtons.OK);
            }
            else
            {
                phrase.pass = textBox3.Text;
                this.Close();
            }
        }
    }
}
