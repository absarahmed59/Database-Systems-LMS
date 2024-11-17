using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS
{
    public partial class Student_Attendance : Form
    {
        string user;
        public Student_Attendance(string u)
        {
            InitializeComponent();
            user = u;
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Interface f = new Student_Interface(user);
            f.Show();
        }
    }
}
