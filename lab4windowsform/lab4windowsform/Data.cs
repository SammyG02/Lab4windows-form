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


namespace lab4windowsform
{
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @" Data source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = C#1; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                MessageBox.Show("Connected");
            }
            catch
            {
                MessageBox.Show("Not Connected");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = C#1; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "Select * from Products";
            SqlCommand cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteReader();
            List<Product> temp = new List<Product>();

            while (result.Read())
            {
                Product p = new Product();
                p.Obj_name = result["objName"].ToString();
                p.Date = result["Date"].ToString();

                MessageBox.Show(result["objName"].ToString());  
                temp.Add(p);

                
            }
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @" Data source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = C#1; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "insert into Products values (1,'2020,2,2',1,'one',1,10);";
            MessageBox.Show("Inserted Successfully");
            SqlCommand cmd = new SqlCommand(query, con);
            var result = cmd.ExecuteNonQuery();
            
        }
    }
}