using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Student_Interface : Form
    {
        public Student_Interface(string u)
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Profile f = new Student_Profile(u);
            f.Show();
        }
    }
}
