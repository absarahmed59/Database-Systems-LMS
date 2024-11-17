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
    public partial class Class_Schedule : Form
    {
        string user;
        public Class_Schedule(string u)
        {
            InitializeComponent();
            user = u;
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=Fareeha;Integrated Security=True");
        private void Class_Schedule_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Head_Moderation f = new Head_Moderation(user);
            f.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lec1_1 = comboBox1.Text + comboBox2.Text;
            string lec2_1 = comboBox4.Text + comboBox3.Text;
            string lec3_1 = comboBox6.Text + comboBox5.Text;
            string lec4_1 = comboBox8.Text + comboBox7.Text;
            string lec5_1 = comboBox10.Text + comboBox9.Text;
            string lec6_1 = comboBox12.Text + comboBox11.Text;

            string lec1_3 = comboBox24.Text + comboBox23.Text;
            string lec2_3 = comboBox22.Text + comboBox21.Text;
            string lec3_3 = comboBox20.Text + comboBox19.Text;
            string lec4_3 = comboBox18.Text + comboBox17.Text;
            string lec5_3 = comboBox16.Text + comboBox15.Text;
            string lec6_3 = comboBox14.Text + comboBox13.Text;
            
            string lec1_5 = comboBox36.Text + comboBox35.Text;
            string lec2_5 = comboBox34.Text + comboBox33.Text;
            string lec3_5 = comboBox32.Text + comboBox31.Text;
            string lec4_5 = comboBox30.Text + comboBox29.Text;
            string lec5_5 = comboBox28.Text + comboBox27.Text;
            string lec6_5 = comboBox26.Text + comboBox25.Text;
            
            string lec1_7 = comboBox48.Text + comboBox47.Text;
            string lec2_7 = comboBox46.Text + comboBox45.Text;
            string lec3_7 = comboBox44.Text + comboBox43.Text;
            string lec4_7 = comboBox42.Text + comboBox41.Text;
            string lec5_7 = comboBox40.Text + comboBox39.Text;
            string lec6_7 = comboBox38.Text + comboBox37.Text;

          
            
            





















        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
