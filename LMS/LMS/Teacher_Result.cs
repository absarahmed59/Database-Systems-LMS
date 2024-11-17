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
    public partial class Teacher_Result : Form
    {
        string user;
        public Teacher_Result(string u)
        {
            InitializeComponent();
            user = u;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Interface f = new Teacher_Interface(user);
            f.Show();
        }
    }
}
