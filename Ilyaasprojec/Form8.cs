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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //if (dateTimePicker1.Trim() == "")
            //{
               // MessageBox.Show("fill the category_name");
                //textBox1.Focus();
                //return;
            //}
           /* if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("fill the customer_id");
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("fill the product_id");
                textBox1.Focus();
                return;
            }*/
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into Orders(order_date,customer_id,product_id) values('" + dateTimePicker1.Text + "','" + comboBox2.SelectedValue.ToString() + "','" + comboBox3.SelectedValue.ToString() +"')";
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
            cmd.CommandText = " select * from Orders ";
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
            textBox1.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from Orders  where order_id = '" + textBox8.Text + "'";
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
            cmd.CommandText = " update  Orders set order_date='" + dateTimePicker1.Text + "',customer_id= '" + comboBox2.SelectedValue.ToString() + "', product_id= '" + comboBox3.SelectedValue.ToString() +"' where  order_id='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet22.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.masterDataSet22.Products);
            // TODO: This line of code loads data into the 'masterDataSet21.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.masterDataSet21.Customers);
            // TODO: This line of code loads data into the 'masterDataSet20.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.masterDataSet20.Orders);
            // TODO: This line of code loads data into the 'masterDataSet19.Orders' table. You can move, or remove it, as needed.
     
 

        }

        private void button7_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand com = new SqlCommand("select * from Orders where order_id= '" + textBox8.Text + "'", conn);
            SqlDataAdapter sd = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
             conn.Open();
            SqlCommand com = new SqlCommand("select * from Orders where order_id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while(sdr.Read())
            {
             textBox1.Text = sdr.GetValue(0).ToString();
             dateTimePicker1.Text = sdr.GetValue(1).ToString();
             comboBox2.SelectedValue = sdr.GetValue(2).ToString();

            }
            conn.Close();
        }

       
    }
}
