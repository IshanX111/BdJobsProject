using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-R0A0RGV;Initial Catalog=test;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO book values (@title, @publisher_name, @publisher_age,@ page_no, @publish_date,@ publish_type)");
            cmd.Parameters.AddWithValue("@title",textBox1.Text);
            cmd.Parameters.AddWithValue("@publisher_name", textBox2.Text);
            cmd.Parameters.AddWithValue("@publisher_age",comboBox1.SelectedItem);
            cmd.Parameters.AddWithValue("@publish_date", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@publish_type", radioButton1.Checked);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
