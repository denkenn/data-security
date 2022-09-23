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
    public partial class list : Form
    {
        public user current;
        public list()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line = sr.ReadLine();
                string[] subs = line.Split('|');
                name_text.Text = subs[0];
                blocked.Checked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                bounded.Checked = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                if ((line = sr.ReadLine()) == null)
                {
                    ahead.Enabled = false;
                }
            }
            back.Enabled = false;
        }

        int i = 0;
        private void ahead_Click(object sender, EventArgs e)
        {
            back.Enabled = true;
            ++i;
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line, tmp;
                int j = 0;
                while (((line = sr.ReadLine()) != null) && (j != i))
                    ++j;

                if (line != null)
                {
                    string[] subs = line.Split('|');
                    name_text.Text = subs[0];
                    blocked.Checked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                    bounded.Checked = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                    if ((tmp = sr.ReadLine()) == null)
                    {
                        ahead.Enabled = false;
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            ahead.Enabled = true;
            --i;
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                int j = 0;
                while (((line = sr.ReadLine()) != null) && (j != i))
                    ++j;
                if (j >= 0)
                {
                    string[] subs = line.Split('|');
                    name_text.Text = subs[0];
                    blocked.Checked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                    bounded.Checked = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                    if (i==0)
                    {
                        back.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blocked_CheckedChanged_1(object sender, EventArgs e)
        {
            string file_before = "", file_after = "", new_info = "";
            bool middle = false;
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subs = line.Split('|');
                    if (name_text.Text == subs[0])
                    {
                        middle = true;
                        if (subs[2] == "0")
                            subs[2] = "1";
                        else
                            subs[2] = "0";
                        current.name = subs[0];
                        current.password = subs[1];
                        current.blocked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                        current.bounded = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                        data.value = current;
                        for (int i = 0; i < subs.Length - 1; ++i)
                        {
                            subs[i] += "|";
                        }
                        new_info = String.Concat(subs);
                        new_info += '\n';
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
            try
            {
                using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                {
                    file_before += new_info;
                    file_before += file_after;
                    file_before = file_before.Substring(0, file_before.Length - 1);
                    sw.WriteLine(file_before);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void bounded_CheckedChanged(object sender, EventArgs e)
        {
            string file_before = "", file_after = "", new_info = "";
            bool middle = false;
            using (StreamReader sr = new StreamReader(Program.path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] subs = line.Split('|');
                    if (name_text.Text == subs[0])
                    {
                        middle = true;
                        if (subs[3] == "0")
                            subs[3] = "1";
                        else
                            subs[3] = "0";
                        current.name = subs[0];
                        current.password = subs[1];
                        current.blocked = Convert.ToBoolean(Convert.ToInt32(subs[2]));
                        current.bounded = Convert.ToBoolean(Convert.ToInt32(subs[3]));
                        data.value = current;
                        for (int i = 0; i < subs.Length - 1; ++i)
                        {
                            subs[i] += "|";
                        }
                        new_info = String.Concat(subs);
                        new_info += '\n';
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
            try
            {
                using (StreamWriter sw = new StreamWriter(Program.path, false, System.Text.Encoding.Default))
                {
                    file_before += new_info;
                    file_before += file_after;
                    file_before = file_before.Substring(0, file_before.Length - 1);
                    sw.WriteLine(file_before);
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
