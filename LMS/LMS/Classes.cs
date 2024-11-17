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
    public partial class Classes : Form
    {
        string user;
        public Classes(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student_Profile f = new Student_Profile(user);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
