using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class FillinTheBlanks : Form
    {
        string correct;
        public FillinTheBlanks(string part1, string part2, string _correct)
        {
            InitializeComponent();
            label1.Text = "Fill in the blank";
            label2.Text = part1;
            label4.Text = part2;
            correct = _correct;
            button1.Text = "Check";

        }

        private void FillinTheBlanks_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == correct)
            {
                Hide();
                new CorrectForm().Show();
            }
            else
            {
                Hide();
                new IncorrectForm().Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
