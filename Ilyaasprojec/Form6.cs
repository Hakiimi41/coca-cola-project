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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("fill the customer_id");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("fill the customer_name");
                textBox1.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("fill the address");
                textBox1.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("fill the phone_number ");
                textBox1.Focus();
                return;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("fill the email_address ");
                textBox1.Focus();
                return;
            }
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Customers values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
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
            cmd.CommandText = " select * from Customers   ";
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
            textBox5.Text = "";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.masterDataSet2.Customers);
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Customers  where customer_id= '" + textBox1.Text + "'";
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
            cmd.CommandText = " update Customers set customer_name='" + textBox2.Text + "',address='" + textBox3.Text + "',phone_number='" + textBox4.Text + "',email_address='" + textBox5.Text + "' where customer_id ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from Customers where customer_id= '" + textBox8.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from Customers where customer_id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while (sdr.Read())
            {
                textBox1.Text = sdr.GetValue(0).ToString();
                textBox2.Text = sdr.GetValue(1).ToString();
                textBox3.Text = sdr.GetValue(2).ToString();
                textBox4.Text = sdr.GetValue(3).ToString();
                textBox5.Text = sdr.GetValue(4).ToString();
                
                

            }
            conn.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cleartext();
        }
    }
}
