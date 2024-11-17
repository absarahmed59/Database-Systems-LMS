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
    public partial class Teacher_Interface : Form
    {
        public Teacher_Interface(string u)
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login f = new Login(u);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Profile f = new Teacher_Profile(u);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Schedule f = new Teacher_Schedule(u);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Result f = new Result(u);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance_Panel f = new Attendance_Panel(u);
            f.Show();
        }
    }
}
