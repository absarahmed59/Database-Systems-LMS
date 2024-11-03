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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
               
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register f = new Register();
            f.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string q = "SELECT * FROM Login WHERE Username = '"+textBox1.Text+"' AND Password = '"+textBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(q, c);
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            
            if (rdr.Read())
            {
                string t = rdr["Type"].ToString().Trim();
                string u = rdr["Username"].ToString().Trim();
                string p = rdr["Password"].ToString().Trim();

                if (t == "Head")
                {
                    if (u == textBox1.Text)
                    {
                        if (p == textBox2.Text)
                        {
                            this.Hide();
                            Head_Interface f = new Head_Interface();
                            f.Show();
                        }
                    }

                }
                else if (t == "Teacher")
                {
                    if (u == textBox1.Text)
                    {
                        if (p == textBox2.Text)
                        {
                            this.Hide();
                            Teacher_Interface f = new Teacher_Interface();
                            f.Show();
                        }
                    }

                }
                else if (t == "Student")
                {
                    if (u == textBox1.Text)
                    {
                        if (p == textBox2.Text)
                        {
                            this.Hide();
                            Student_Interface f = new Student_Interface();
                            f.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Cedentials");
                }
            }
            c.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
