﻿using System;
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
    public partial class Admin_Requests : Form
    {
        string user;
        public Admin_Requests(string u)
        {
            InitializeComponent();
            user=u;
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Head_Interface f = new Head_Interface(user);
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Approved")
            {
                SqlCommand cmd1 = new SqlCommand("Insert Into Login(Username, Password, Type)Values('" + textBox1.Text + "', '" + textBox2.Text + "', '"+textBox3.Text+"')", c);
                SqlCommand cmd2 = new SqlCommand("Delete From Registration_Requests Where Username = '" + textBox1.Text + "' ", c);
                c.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                c.Close();
            }
            if (comboBox1.Text == "Reject")
            {
                SqlCommand cmd = new SqlCommand("Delete From Registration_Requests Where Username = '" + textBox1.Text + "' ", c);
                c.Open();
                cmd.ExecuteNonQuery();
                c.Close();
            }
            
        }

        private void Admin_Requests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet4.Registration_Requests' table. You can move, or remove it, as needed.
            this.registration_RequestsTableAdapter3.Fill(this.lMSDataSet4.Registration_Requests);
            // TODO: This line of code loads data into the 'lMSDataSet1.Registration_Requests' table. You can move, or remove it, as needed.
            //this.registration_RequestsTableAdapter2.Fill(this.lMSDataSet1.Registration_Requests);
            // TODO: This line of code loads data into the 'lMSDataSet2.Registration_Requests' table. You can move, or remove it, as needed.
            //this.registration_RequestsTableAdapter1.Fill(this.lMSDataSet2.Registration_Requests);
            // TODO: This line of code loads data into the 'lMSDataSet.Registration_Requests' table. You can move, or remove it, as needed.
            //this.registration_RequestsTableAdapter.Fill(this.lMSDataSet.Registration_Requests);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentCell.Value.ToString();
        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                i++;

            }
            catch
            {
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                i--;
                textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            }
            catch
            {
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
