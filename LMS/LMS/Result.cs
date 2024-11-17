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
    public partial class Result : Form
    {
        public Result(string u)
        {
            InitializeComponent();
        }
        public string grade(Int32 marks, Int32 h)
        {
            if (marks / h >= 18)
            {
                return "A+";
            }
            else if (marks / h >= 17)
            {
                return "A";
            }
            else if (marks / h >= 16)
            {
                return "A-";
            }
            else if (marks / h >= 15)
            {
                return "B+";
            }
            else if (marks / h >= 14)
            {
                return "B";
            }
            else if (marks / h >= 13)
            {
                return "B-";
            }
            else if (marks / h >= 12)
            {
                return "C+";
            }
            else if (marks / h >= 11)
            {
                return "C";
            }
            else if (marks / h >= 10)
            {
                return "C-";
            }
            else if (marks / h >= 9)
            {
                return "D+";
            }
            else if (marks / h >= 8)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        public Double gpa(string g, Double h)
        {
            if (g == "A+")
            {
                return h * 4.3;
            }
            else if (g == "A")
            {
                return h * 4.00;
            }
            else if (g == "A-")
            {
                return h * 3.70;
            }
            else if (g == "B+")
            {
                return h * 3.3;
            }
            else if (g == "B")
            {
                return h * 3.00;
            }
            else if (g == "B-")
            {
                return h * 2.70;
            }
            else if (g == "C+")
            {
                return h * 2.3;
            }
            else if (g == "C")
            {
                return h * 2.00;
            }
            else if (g == "C-")
            {
                return h * 1.70;
            }
            else if (g == "D+")
            {
                return h * 1.3;
            }
            else if (g == "D")
            {
                return h * 1.00;
            }
            else
            {
                return 0.00;
            }
        }
        private Double calGPA(string g, int h)
        {
            switch (g)
            {
                case "A": return h * 4.0;
                case "A-": return h * 3.7;
                case "B+": return h * 3.3;
                case "B": return h * 3.0;
                case "B-": return h * 2.7;
                case "C+": return h * 2.3;
                case "C": return h * 2.0;
                case "C-": return h * 1.7;
                case "D": return h * 1.0;
                case "f": return h * 0;
            }
            return 0.0;
        }

        private string get_grade(int m, int h)
        {
            switch(h)
            {
                case 1:
                    if(m>=17)       return "A";
                    else if(m>=16)  return "A-";
                    else if(m>=14)  return "B+";
                    else if(m>=13)  return "B";
                    else if(m>=12)  return "B-";
                    else if(m>=11)  return "C+";
                    else if(m>=10)  return "C";
                    else if(m>=9)   return "C-";
                    else if(m>=8)   return "D";
                    else return "F";
                case 2:
                    if(m>=34)       return "A";
                    else if(m>=32)  return "A-";
                    else if(m>=28)  return "B+";
                    else if(m>=26)  return "B";
                    else if(m>=24)  return "B-";
                    else if(m>=22)  return "C+";
                    else if(m>=20)  return "C";
                    else if(m>28)  return "C-";
                    else if(m>=16)  return "D";
                    else return "F";
                case 3:
                    if(m>=51)       return "A";
                    else if(m>=48)  return "A-";
                    else if(m>=42)  return "B+";
                    else if(m>=39)  return "B";
                    else if(m>=36)  return "B-";
                    else if(m>=33)  return "C+";
                    else if(m>=30)  return "C";
                    else if(m>=27)  return "C-";
                    else if(m>=24)  return "D";
                    else return "F";
                case 4:
                    if(m>=68)       return "A";
                    else if(m>=64)  return "A-";
                    else if(m>=56)  return "B+";
                    else if(m>=52)  return "B";
                    else if(m>=48)  return "B-";
                    else if(m>=44)  return "C+";
                    else if(m>=40)  return "C";
                    else if(m>=36)  return "C-";
                    else if(m>32)  return "D";
                    else return "F";
            }
            return "";
        }
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-F3UNILV\SQLEXPRESS;Initial Catalog=LMS;Integrated Security=True");
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lMSDataSet5.Results' table. You can move, or remove it, as needed.
            this.resultsTableAdapter1.Fill(this.lMSDataSet5.Results);
            // TODO: This line of code loads data into the 'lMSDataSet3.Results' table. You can move, or remove it, as needed.
            //this.resultsTableAdapter.Fill(this.LMSDataSet5.Results);

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Teacher_Interface f = new Teacher_Interface(u);
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            Int16 roll = Convert.ToInt16(textBox2.Text);
            string sesss = textBox3.Text;
            string session = sesss[2].ToString()+sesss[3].ToString();
            Int16 sem = Convert.ToInt16(textBox4.Text);
            string depart = comboBox1.Text;
            string id = roll.ToString()+"-"+depart+"-"+session;
            textBox23.Text = id;
            string sub1 = textBox30.Text;
            string sub2 = textBox29.Text;
            string sub3 = textBox28.Text;
            string sub4 = textBox27.Text;
            string sub5 = textBox26.Text;
            string sub6 = textBox25.Text;
            Int16 ch1 = Convert.ToInt16(textBox5.Text);
            Int16 m1 = Convert.ToInt16(textBox16.Text);
            Int16 ch2 = Convert.ToInt16(textBox6.Text);
            Int16 m2 = Convert.ToInt16(textBox15.Text);
            Int16 ch3 = Convert.ToInt16(textBox7.Text);
            Int16 m3 = Convert.ToInt16(textBox14.Text);
            Int16 ch4 = Convert.ToInt16(textBox8.Text);
            Int16 m4 = Convert.ToInt16(textBox13.Text);
            Int16 ch5 = Convert.ToInt16(textBox9.Text);
            Int16 m5 = Convert.ToInt16(textBox12.Text);
            Int16 ch6 = Convert.ToInt16(textBox10.Text);
            Int16 m6 = Convert.ToInt16(textBox11.Text);
            string g1 = grade(m1, ch1);
            string g2 = grade(m2, ch2);
            string g3 = grade(m3, ch3);
            string g4 = grade(m4, ch4);
            string g5 = grade(m5, ch5);
            string g6 = grade(m6, ch6);
            textBox22.Text = g1;
            textBox21.Text = g2;
            textBox20.Text = g3;
            textBox19.Text = g4;
            textBox18.Text = g5;
            textBox17.Text = g6;
            Double gpa1 = gpa(g1, ch1);
            Double gpa2 = gpa(g2, ch2);
            Double gpa3 = gpa(g3, ch3);
            Double gpa4 = gpa(g4, ch4);
            Double gpa5 = gpa(g5, ch5);
            Double gpa6 = gpa(g6, ch6);
            Double ch = ch1+ch2+ch3+ch4+ch5+ch6;
            Double cgpa = gpa1+gpa2+gpa3+gpa4+gpa5+gpa6;
            Double GPA = cgpa/ch;
            SqlCommand cmd2 = new SqlCommand("Insert Into Results(ID, Name, RollNo, Session, Department, Semester, Subject1, Hours1, Marks1, Grade1, Subject2, Hours2, Marks2, Grade2, Subject3, Hours3, Marks3, Grade3, Subject4, Hours4 , Marks4, Grade4, Subject5, Hours5, Marks5, Grade5, Subject6, Hours6, Marks6, Grade6, GPA)Values(@id,@name,@roll,@sess,@dept,@sem,@sub1,@h1,@m1,@g1,@sub2,@h2,@m2,@g2,@sub3,@h3,@m3,@g3,@sub4,@h4,@m4,@g4,@sub5,@h5,@m5,@g5,@sub6,@h6,@m6,@g6,@gpa)", c);
            cmd2.Parameters.AddWithValue("id", id);
            cmd2.Parameters.AddWithValue("name", name);
            cmd2.Parameters.AddWithValue("roll", roll);
            cmd2.Parameters.AddWithValue("sess", sesss);
            cmd2.Parameters.AddWithValue("dept", depart);
            cmd2.Parameters.AddWithValue("sem", sem);
            cmd2.Parameters.AddWithValue("h1", ch1);
            cmd2.Parameters.AddWithValue("m1", m1);
            cmd2.Parameters.AddWithValue("h2", ch2);
            cmd2.Parameters.AddWithValue("m2", m2);
            cmd2.Parameters.AddWithValue("h3", ch3);
            cmd2.Parameters.AddWithValue("m3", m3);
            cmd2.Parameters.AddWithValue("h4", ch4);
            cmd2.Parameters.AddWithValue("m4", m4);
            cmd2.Parameters.AddWithValue("h5", ch5);
            cmd2.Parameters.AddWithValue("m5", m5);
            cmd2.Parameters.AddWithValue("h6", ch6);
            cmd2.Parameters.AddWithValue("m6", m6);
            cmd2.Parameters.AddWithValue("sub1", sub1);
            cmd2.Parameters.AddWithValue("g1", g1);
            cmd2.Parameters.AddWithValue("sub2", sub2);
            cmd2.Parameters.AddWithValue("g2", g2);
            cmd2.Parameters.AddWithValue("sub3", sub3);
            cmd2.Parameters.AddWithValue("g3", g3);
            cmd2.Parameters.AddWithValue("sub4", sub4);
            cmd2.Parameters.AddWithValue("g4", g4);
            cmd2.Parameters.AddWithValue("sub5", sub5);
            cmd2.Parameters.AddWithValue("g5", g5);
            cmd2.Parameters.AddWithValue("sub6", sub6);
            cmd2.Parameters.AddWithValue("g6", g6);
            cmd2.Parameters.AddWithValue("gpa", GPA);
            c.Open();
            cmd2.ExecuteNonQuery();
            c.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("DELETE FROM Results WHERE ID='" + textBox23.Text + "'", c);
            c.Open();
            cmd2.ExecuteNonQuery();
            c.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox23.Text;
            string sub1 = textBox30.Text;
            string sub2 = textBox29.Text;
            string sub3 = textBox28.Text;
            string sub4 = textBox27.Text;
            string sub5 = textBox26.Text;
            string sub6 = textBox25.Text;
            Int16 ch1 = Convert.ToInt16(textBox5.Text);
            Int16 m1 = Convert.ToInt16(textBox16.Text);
            Int16 ch2 = Convert.ToInt16(textBox6.Text);
            Int16 m2 = Convert.ToInt16(textBox15.Text);
            Int16 ch3 = Convert.ToInt16(textBox7.Text);
            Int16 m3 = Convert.ToInt16(textBox14.Text);
            Int16 ch4 = Convert.ToInt16(textBox8.Text);
            Int16 m4 = Convert.ToInt16(textBox13.Text);
            Int16 ch5 = Convert.ToInt16(textBox9.Text);
            Int16 m5 = Convert.ToInt16(textBox12.Text);
            Int16 ch6 = Convert.ToInt16(textBox10.Text);
            Int16 m6 = Convert.ToInt16(textBox11.Text);
            string g1 = grade(m1, ch1);
            string g2 = grade(m2, ch2);
            string g3 = grade(m3, ch3);
            string g4 = grade(m4, ch4);
            string g5 = grade(m5, ch5);
            string g6 = grade(m6, ch6);
            textBox22.Text = g1;
            textBox21.Text = g2;
            textBox20.Text = g3;
            textBox19.Text = g4;
            textBox18.Text = g5;
            textBox17.Text = g6;
            Double gpa1 = gpa(g1, ch1);
            Double gpa2 = gpa(g2, ch2);
            Double gpa3 = gpa(g3, ch3);
            Double gpa4 = gpa(g4, ch4);
            Double gpa5 = gpa(g5, ch5);
            Double gpa6 = gpa(g6, ch6);
            Double ch = ch1 + ch2 + ch3 + ch4 + ch5 + ch6;
            Double cgpa = gpa1 + gpa2 + gpa3 + gpa4 + gpa5 + gpa6;
            Double GPA = cgpa / ch;
            SqlCommand cmd2 = new SqlCommand("Update Results Set Subject1=@sub1, Hours1=@h1, Marks1=@m1, Grade1=@g1, Subject2=@sub2, Hours2=@h2, Marks2=@m2, Grade2=@g2, Subject3=@sub3, Hours3=@h3, Marks3=@m3, Grade3=@g3, Subject4=@sub4, Hours4=@h4, Marks4=@m4, Grade4=@g4, Subject5=@sub5, Hours5=@h5, Marks5=@m5, Grade5=@g5, Subjec6=@sub6, Hours6=@h6, Marks6=@m6, Grade=@g6, GPA=@gpa WHERE ID='"+textBox23.Text+"'", c);
            cmd2.Parameters.AddWithValue("id", id);
            cmd2.Parameters.AddWithValue("h1", ch1);
            cmd2.Parameters.AddWithValue("m1", m1);
            cmd2.Parameters.AddWithValue("h2", ch2);
            cmd2.Parameters.AddWithValue("m2", m2);
            cmd2.Parameters.AddWithValue("h3", ch3);
            cmd2.Parameters.AddWithValue("m3", m3);
            cmd2.Parameters.AddWithValue("h4", ch4);
            cmd2.Parameters.AddWithValue("m4", m4);
            cmd2.Parameters.AddWithValue("h5", ch5);
            cmd2.Parameters.AddWithValue("m5", m5);
            cmd2.Parameters.AddWithValue("h6", ch6);
            cmd2.Parameters.AddWithValue("m6", m6);
            cmd2.Parameters.AddWithValue("sub1", sub1);
            cmd2.Parameters.AddWithValue("g1", g1);
            cmd2.Parameters.AddWithValue("sub2", sub2);
            cmd2.Parameters.AddWithValue("g2", g2);
            cmd2.Parameters.AddWithValue("sub3", sub3);
            cmd2.Parameters.AddWithValue("g3", g3);
            cmd2.Parameters.AddWithValue("sub4", sub4);
            cmd2.Parameters.AddWithValue("g4", g4);
            cmd2.Parameters.AddWithValue("sub5", sub5);
            cmd2.Parameters.AddWithValue("g5", g5);
            cmd2.Parameters.AddWithValue("sub6", sub6);
            cmd2.Parameters.AddWithValue("g6", g6);
            cmd2.Parameters.AddWithValue("gpa", GPA);
            c.Open();
            cmd2.ExecuteNonQuery();
            c.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.resultsTableAdapter1.FillBy(this.lMSDataSet5.Results);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

