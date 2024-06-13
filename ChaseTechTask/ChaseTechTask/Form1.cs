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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
namespace ChaseTechTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Student; Integrated Security = True; Pooling = False;");
            con .Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Student(ID,NAME,COLLEGE,COURSE) VALUES (@ID,@NAME,@COLLEGE, @COURSE)", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME",(textBox2.Text));
            cmd.Parameters.AddWithValue("@COLLEGE", (textBox3.Text));
            cmd.Parameters.AddWithValue("@COURSE", (textBox4.Text));
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            cmd.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY CREATED!!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Student; Integrated Security = True; Pooling = False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("Update Student SET NAME=@NAME, COLLEGE=@COLLEGE, COURSE=@COURSE WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME", (textBox2.Text));
            cmd.Parameters.AddWithValue("@COLLEGE", (textBox3.Text));
            cmd.Parameters.AddWithValue("@COURSE", (textBox4.Text));
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            cmd.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY UPDATED!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Student; Integrated Security = True; Pooling = False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = Student; Integrated Security = True; Pooling = False;");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Student WHERE ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@NAME", (textBox2.Text));
            cmd.Parameters.AddWithValue("@COLLEGE", (textBox3.Text));
            cmd.Parameters.AddWithValue("@COURSE", (textBox4.Text));
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            cmd.ExecuteNonQuery();

            MessageBox.Show("SUCCESSFULLY DELETED!!");
        }
    }
}
