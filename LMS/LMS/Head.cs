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
    public partial class HOD : Form
    {
        public HOD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classes f = new Classes();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result f = new Result();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attandence f = new Attandence();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
