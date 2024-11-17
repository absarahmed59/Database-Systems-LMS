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
    public partial class Head_Moderation : Form
    {
        string user;
        public Head_Moderation(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Head_Interface f = new Head_Interface(user);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Schedule f = new Class_Schedule(user);
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
