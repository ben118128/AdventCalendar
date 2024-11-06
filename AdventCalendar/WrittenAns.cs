using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class WrittenAns : Form
    {
        string correct;
        public WrittenAns(string question, string _correct)
        {
            InitializeComponent();
            correct = _correct;
            label1.Text = question;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            if(textBox1.Text == correct){
                new CorrectForm().Show(); 
            }
            else{
                new IncorrectForm().Show();
            }
        }
    }
}
