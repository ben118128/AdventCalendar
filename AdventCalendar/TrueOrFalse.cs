using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class TrueOrFalse : Form
    {
        public int correct;
        public TrueOrFalse(string question, string Ans1, string Ans2, int _correct)
        {
            InitializeComponent();
            correct = _correct;
            label3.Text = question;
            button1.Text = Ans1;
            button2.Text = Ans2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            if (correct == 1){
                new CorrectForm().Show();
            }
            else{
                new IncorrectForm().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            if (correct == 2){
                new CorrectForm().Show();
            }
            else{
                new IncorrectForm().Show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TrueOrFalse_Load(object sender, EventArgs e)
        {

        }
    }
}
