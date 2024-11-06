using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class TrueFalseOptionBox : Form
    {
        public bool correct;
        
        public TrueFalseOptionBox(string question, bool _correct)
        {
            InitializeComponent();
            label1.Text = question;
            correct = _correct;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == correct && radioButton2.Checked != correct )
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
    }
}
