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
        string user;
        public HOD(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Result f = new Result(user);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attandence f = new Attandence(user);
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
 
        }
    }
}
