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
    public partial class Attandence : Form
    {
        public Attandence(string u)
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Attandence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet7.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.lMSDataSet7.Attendance);

        }
        //int Semester = Convert.ToInt16(textBox1.Text);
        
        private void button1_Click(object sender, EventArgs e)
        {
            int roll = Convert.ToInt16(textBox4.Text);
            string date = dateBox.Text + "-" + monthBox.Text + "-" + yearBox.Text;
            SqlCommand cmd = new SqlCommand("Insert Into Attendance(Roll, Session, Semester, Lecture, Date, Status) Values ('"+roll+"', '"+textBox3.Text+"', '"+Convert.ToInt16(textBox1.Text)+"', '"+textBox2.Text+"', '"+date+"', '"+comboBox1.Text+"')", c);
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
            roll++;
            textBox4.Text = roll.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance_Panel f = new Attendance_Panel();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
