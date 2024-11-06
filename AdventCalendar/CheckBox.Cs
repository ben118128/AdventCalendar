using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class OptionBox : Form
    {
        public OptionBox(string question, string ans1, string ans2, string ans3, string ans4)
        {
            InitializeComponent();
            label1.Text = question;
            checkBox1.Text = ans1;
            checkBox2.Text = ans2;
            checkBox3.Text = ans3;
            checkBox4.Text = ans4;
        }

        private void OptionBox_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            if (checkBox1.Checked && checkBox2.Checked && checkBox4.Checked)
            {
                new CorrectForm().Show();
            }
            else
            {
                new IncorrectForm().Show();
            }
        }
    }
}
