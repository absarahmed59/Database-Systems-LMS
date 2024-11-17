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
    public partial class Student_Profile : Form
    {
        string user;
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        public Student_Profile(string u)
        {
            InitializeComponent();
            user = u;
            string q = "SELECT * FROM Profiles WHERE Username = '" + u + "'";
            SqlCommand cmd = new SqlCommand(q, c);
            c.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            try
            {
                rdr.Read();
                textBox1.Text = rdr["Name"].ToString();
                textBox2.Text = rdr["Roll_Number"].ToString();
                textBox3.Text = rdr["Contact"].ToString();
                textBox4.Text = rdr["Address"].ToString();
                textBox5.Text = rdr["Last_Education"].ToString();
                textBox7.Text = rdr["Experience"].ToString();
                comboBox1.Text = rdr["Grade"].ToString();
            }
            catch
            {
            }
            c.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Student_Interface f = new Student_Interface(user);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Delete From Profiles Where Username = '"+ user +"'", c);
            SqlCommand cmd2 = new SqlCommand("Insert Into Profiles(Username, Roll_Number, Name, Contact, Address, Last_Education, Grade, Experience) Values('" + user + "','" + Convert.ToInt16(textBox2.Text) + "','" + textBox1.Text + "' ,'" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "','" + comboBox1.Text + "', '" + Convert.ToInt16(textBox7.Text) + "')", c);
            c.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            c.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Login Set Password = '" + textBox6.Text + "' WHERE Username = '" + user + "'");
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();
        }
    }
}
