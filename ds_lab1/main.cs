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
    public partial class main : Form
    {
        user current = data.value;
        public main()
        {
            Program.count = 1;
            InitializeComponent();
            phrase form1 = new phrase();
            form1.ShowDialog();
            if (phrase.FormClosedOK)
            {
                lognpass form = new lognpass();
                form.ShowDialog();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info dlg1 = new info();
            dlg1.ShowDialog();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            lognpass form_change = new lognpass();
            form_change.ShowDialog();
            this.Show();
        }

        private void change_pass_Click(object sender, EventArgs e)
        {
            this.Hide();
            password_change form_change = new password_change();
            form_change.ShowDialog();
            this.Show();
        }


        private void новыйАккаунтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = data.value;
            if (current.name == "admin")
            {
                this.Hide();
                new_user form_new = new new_user();
                form_new.ShowDialog();
                this.Show();
            }
        }

        private void просмотрСпискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current = data.value;
            if (current.name == "admin")
            {
                this.Hide();
                list form = new list();
                form.ShowDialog();
                this.Show();
            }
        }

        private void шифрованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("43. Шифрование гаммированием на ключе, образованном с помощью " +
                "нескольких вызовов стандартной функции random(256) или аналогичной, начальное " +
                "значение датчика псевдослучайных чисел выбирается равным сумме кодов символов пароля " +
                "с четными номерами по модулю 256 ");
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (lognpass.flenter_click)
                Program.WriteInFile();
        }
    }
}
