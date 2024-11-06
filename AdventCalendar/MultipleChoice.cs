using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class MultipleChoice : Form
    {
        public int correct;
        public MultipleChoice(string question, string Ans1, string Ans2, string Ans3, string Ans4, int _correct)
        {
            InitializeComponent();
            correct = _correct;
            label1.Text = question;
            button1.Text = Ans1;
            button2.Text = Ans2;
            button3.Text = Ans3;
            button4.Text = Ans4;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            if (correct == 4)
                new CorrectForm().Show();
            else
                new IncorrectForm().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();

            if (correct == 3)
                new CorrectForm().Show();
            else
                new IncorrectForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();

            if (correct == 2)
                new CorrectForm().Show();
            else
                new IncorrectForm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            if (correct == 1)
                new CorrectForm().Show();
            else
                new IncorrectForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
