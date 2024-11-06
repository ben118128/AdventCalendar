using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdventCalendar
{
    public partial class IncorrectForm : Form
    {
        public IncorrectForm()
        {
            InitializeComponent();
        }

        private void IncorrectForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Userform3().Show();
        }
    }
}
