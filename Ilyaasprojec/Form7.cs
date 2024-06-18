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

namespace Ilyaasprojec
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            display();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("fill the category_id");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("fill the category_name");
                textBox1.Focus();
                return;
            }
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Categories values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data inserted");
            conn.Close();
            cleartext();
            display();

        }
        public void display()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Categories ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void cleartext()
        {
            textBox1.Text = "";
            textBox2.Text = "";
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Categories where category_id = '" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is deleted");
            conn.Close();
            cleartext();
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             conn.Open();
           
           
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update Categories set category_id= '" + textBox1.Text + "',category_name='" + textBox2.Text + "'where category_id='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.masterDataSet3.Categories);
            display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from Categories where category_id= '" + textBox8.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from Categories where category_id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while(sdr.Read())
            {
                textBox1.Text = sdr.GetValue(0).ToString();
                textBox2.Text = sdr.GetValue(1).ToString();

            }
            conn.Close();
        }
    }
}
