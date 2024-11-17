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
    public partial class Attendance_Panel : Form
    {
        string user;
        public Attendance_Panel(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Interface f = new Teacher_Interface(user);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attandence f = new Attandence(user);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance_Report f = new Attendance_Report(user);
            f.Show();
        }
    }
}
