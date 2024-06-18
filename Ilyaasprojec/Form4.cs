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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet23.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.masterDataSet23.Products);
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("fill the product_name");
                textBox1.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("fill the product_description");
                textBox1.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("fill the product_price");
                textBox1.Focus();
                return;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("fill the quantity_in_stock ");
                textBox1.Focus();
                return;
            }
           
          
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Products (product_name,description,price,quantity_in_stock)values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data inserted");
            conn.Close();
            cleartext();
            display();
        }
        public void cleartext()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
         
        }

        private void button6_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }
        public void display()
        {   conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from Products";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             conn.Open();
           
           
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " update Products set product_name='" + textBox2.Text + "',description='" + textBox3.Text + "',price='" + textBox4.Text + "',quantity_in_stock='" + textBox5.Text + "' where product_id ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
              conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Products where product_id = '" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is deleted");
            conn.Close();
            cleartext();
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
             conn.Open();
            SqlCommand com = new SqlCommand("select * from Products where product_id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while(sdr.Read())
            {
                textBox1.Text = sdr.GetValue(0).ToString();
                textBox2.Text = sdr.GetValue(1).ToString();
                textBox3.Text = sdr.GetValue(2).ToString();
               textBox4.Text = sdr.GetValue(3).ToString();
                textBox5.Text = sdr.GetValue(4).ToString();
                
              
                
            }
            conn.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
              conn.Open();
            SqlCommand com = new SqlCommand("select * from Products where  product_id= '" + textBox8.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
