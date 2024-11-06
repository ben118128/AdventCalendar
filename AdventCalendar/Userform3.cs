using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class Userform3 : Form
    {
        public Userform3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("What is Santas surname?", "Clause", "Clease", "Claus", "Claws", 3).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueOrFalse("Christmas is in December", "True", "False", 1).Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("How many times a year does christmas happen", "1").Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            new DragAndDrop("What can you not give to Santa?", "Milk", "Cookies", "Water", "Hot Chocolate", "Water").Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("What year did all I want for Christmas is you come out?", "2000", "1990", "1994", "1984", 3).Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueFalseOptionBox("Santa is not real", false);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("What is not a Christmas food", "Turkey", "Christmas pudding", "Cranberry Jam", "Burgers", 4).Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueOrFalse("Eggnog is a christmas drink", "True", "False", 1).Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Hide();
            new FillinTheBlanks("Twas the night before Christmas", "not a creature was stirring", "when all through the house").Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("What is the first gift given suring the 12 days of Christmas?", "A partridge in a pear tree").Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueOrFalse("Krampus is a demon", "True", "False", 1).Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("Where does Santa come from originally", "Germany", "Austria", "China", "USA", 1).Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueFalseOptionBox("Candy canes are not a Christmas sweet", false).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("What is the period leading up to Christmas known as?", "Advent").Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("When did home alone come out", "1990", "1995", "1989", "1999", 1).Show();
        }

        private void Userform3_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueFalseOptionBox("Isaac Newton was born on Christmas day", true);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            new FillinTheBlanks("On the first day of Christmas", "gave to me", "my true love").Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("How many reindeer does Santa have?", "9").Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueOrFalse("Rudolph has a brown nose", "true", "false", 2).Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("What changed Santa's colours to red", "Coke").Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new Denton().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Hide();
            new WrittenAns("What was Santa's original colour", "Green").Show(); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Hide();
            new MultipleChoice("How much did home alone make in the box office", "500 Million", "450 Million", "475 Million", "400 Million", 3).Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            new TrueFalseOptionBox("Santa comes though the front door", false);
        }
    }
}
