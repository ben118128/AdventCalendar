using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class DragAndDrop : Form
    {
        string correct;
        public DragAndDrop(string Question, string Ans1, string Ans2, string Ans3, string Ans4, string _correct)
        {
            InitializeComponent();
            label1.Text = Question;
            label2.Text = Ans1;
            label3.Text = Ans2;
            label4.Text = Ans3;
            label5.Text = Ans4;
            correct = _correct;
            pictureBox1.AllowDrop = true;
        }

        private void LabelSelected(object sender, MouseEventArgs e)
        {
            Label selectedLabel = (Label)sender;
            selectedLabel.DoDragDrop(selectedLabel.Text,
                DragDropEffects.Copy);
        }

        private void DataDropCheck(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void CheckCorrectLabel(object sender, DragEventArgs e)
        {
            string droppedText = e.Data.GetData(DataFormats.Text).ToString();
            if (droppedText == correct)
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
