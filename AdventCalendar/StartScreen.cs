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

namespace AdventCalendar
{
    public partial class Form1 : Form
    {
        public bool valid;
        string[] readDetails = File.ReadAllLines("Userpass.txt");
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        public bool UserPass(string username, string password)
        {
            /*FileStream fileStream = new FileStream("UserPass.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Ben");
            streamWriter.WriteLine("1819");
            streamWriter.Close();
            fileStream.Close();*/
            /*username = File.ReadLines("Username.txt").ToArray()[0];
            password = File.ReadLines("Password.txt").ToArray()[0];
            */return valid;
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] login = readDetails[0].Split(", ");

            if (textBox1.Text == login[0] && textBox2.Text == login[1])
            {
                MessageBox.Show("Login Successful");
                Hide();
                new Userform3().Show();
            }

            else
            {
                MessageBox.Show("Username or password incorrect");
            }
            
        }
    }
}
