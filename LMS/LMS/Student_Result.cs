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
    public partial class Student_Result : Form
    {
        string user;
        public Student_Result(string u)
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

        private void Student_Result_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet71.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter.Fill(this.lMSDataSet71.Results);
            // TODO: This line of code loads data into the 'lMSDataSet71.Registration_Requests' table. You can move, or remove it, as needed.
            this.registration_RequestsTableAdapter.Fill(this.lMSDataSet71.Registration_Requests);
            // TODO: This line of code loads data into the 'lMSDataSet7.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter.Fill(this.lMSDataSet7.Results);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy(this.lMSDataSet7.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.lMSDataSet7.Results, userToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter.FillBy1(this.lMSDataSet7.Results, userToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
