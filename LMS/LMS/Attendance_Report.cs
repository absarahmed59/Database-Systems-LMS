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
    public partial class Attendance_Report : Form
    {
        string user;
        public Attendance_Report(string s, string u)
        {

            InitializeComponent();
            textBox1.Text = s;
            user = u;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance_Panel f = new Attendance_Panel(user);
            f.Show();
        }

        private void Attendance_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet7.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.lMSDataSet7.Attendance);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attendanceTableAdapter.FillBy(this.lMSDataSet7.Attendance);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
