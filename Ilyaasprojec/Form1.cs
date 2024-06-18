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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GEG2ALP\SQLEXPRESS;Initial Catalog=master;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            username = textBox1.Text;
            password = textBox2.Text;
            try
            {
                conn.Open();
                string query = "select * from registration where username = '" + textBox1.Text + "'and password = '" + textBox2.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                
                if (dtable.Rows.Count>0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;
                   MDIParent1 mid = new MDIParent1();
                    mid.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("username or password is incorrect");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to authenticate. Please try again later.");
                // Log the exception for debugging purposes
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
          
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
