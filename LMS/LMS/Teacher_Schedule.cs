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
    public partial class Teacher_Schedule : Form
    {
        string user;
        public Teacher_Schedule(string u)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Teacher_Schedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet1.Registration_Requests' table. You can move, or remove it, as needed.
            this.registration_RequestsTableAdapter.Fill(this.lMSDataSet1.Registration_Requests);

        }
    }
}
