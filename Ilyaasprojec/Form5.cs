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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("fill the product_id");
                textBox1.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("fill the contact_person");
                textBox1.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("fill the phone_number ");
                textBox1.Focus();
                return;
            }
           
            
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into shcedule(product_id,start_date,end_date) values('" + textBox2.SelectedValue + "','" + textBox3.Value + "','" + textBox4.Value + "')";
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
            cmd.CommandText = " select * from shcedule  ";
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
            textBox3.Text = "";
            textBox4.Text = "";
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            conn.Open();


            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update shcedule set product_id='" + textBox2.Text + "',start_date='" + textBox3.Text + "',end_date='" + textBox4.Text + "', where schedule_id ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from shcedule where schedule_id= '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is deleted");
            conn.Close();
            cleartext();
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from shcedule where schedule_id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                textBox1.Text = sdr.GetValue(0).ToString();
                textBox2.Text = sdr.GetValue(1).ToString();
                textBox3.Text = sdr.GetValue(2).ToString();
                textBox4.Text = sdr.GetValue(3).ToString();
              
              

            }
            conn.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from shcedule   where schedule_id= '" + textBox8.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void textBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet13.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.masterDataSet13.Products);

        }
    }
}
