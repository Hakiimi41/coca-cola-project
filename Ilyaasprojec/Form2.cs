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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(textBox1.Text.Trim()=="")
            {
                MessageBox.Show("fill the fiist name");
                textBox1.Focus();
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("fill the last name");
                textBox1.Focus();
                return;
            }
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("fill the user name");
                textBox1.Focus();
                return;
            }
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("fill the password ");
                textBox1.Focus();
                return;
            }
            if (textBox5.Text.Trim() == "")
            {
                MessageBox.Show("fill the email ");
                textBox1.Focus();
                return;
            }
            if (textBox6.Text.Trim() == "")
            {
                MessageBox.Show("fill the phone");
                textBox1.Focus();
                return;
            }
            if (textBox7.Text.Trim() == "")
            {
                MessageBox.Show("fill the address");
                textBox1.Focus();
                return;
            }
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into registration values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
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
            textBox6.Text = "";
            textBox7.Text = "";
        }
        public void display()
        {
         conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " select * from registration ";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet5.registration' table. You can move, or remove it, as needed.
            this.registrationTableAdapter.Fill(this.masterDataSet5.registration);
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " delete from registration where id = '" + textBox8.Text + "'";
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
            cmd.CommandText = " update registration set fistname= '" + textBox1.Text + "',lastname='" + textBox2.Text + "',username='" + textBox3.Text + "',password='" + textBox4.Text + "',email='" + textBox5.Text + "',phone='" + textBox6.Text + "',address='" + textBox7.Text + "' where id='" + textBox8.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("data is updated");
            conn.Close();
            cleartext();
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand com = new SqlCommand("select * from registration where id= '" + textBox8.Text + "'", conn);

            SqlDataReader sdr = com.ExecuteReader();
            while(sdr.Read())
            {
                textBox1.Text = sdr.GetValue(1).ToString();
                textBox2.Text = sdr.GetValue(2).ToString();
                textBox3.Text = sdr.GetValue(3).ToString();
               textBox4.Text = sdr.GetValue(4).ToString();
                textBox5.Text = sdr.GetValue(5).ToString();
                textBox6.Text = sdr.GetValue(6).ToString();
                textBox7.Text = sdr.GetValue(7).ToString();
                
            }
            conn.Close();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           conn.Open();
            SqlCommand com = new SqlCommand("select * from registration where id= '" + textBox8.Text + "'", conn);
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
