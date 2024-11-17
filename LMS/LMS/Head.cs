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
        public HOD(string u)
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Classes f = new Classes(u);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result f = new Result(u);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attandence f = new Attandence(u);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
