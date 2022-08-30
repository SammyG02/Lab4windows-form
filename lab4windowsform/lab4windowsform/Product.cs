using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4windowsform
{
    internal class Product
    {
        static private List<Product> list = new List<Product>();
        public int Number { get; set; }
        public string Date { get; set; }
        public int Inv_Num { get; set; }
        public string Obj_name { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }
        public Boolean isAvailable { get; set; }
        public void save()
        {
            list.Add(this);
            try
            {
                string connectionString = @" Data source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = C#1; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "insert into Products values('" + this.Number + "', '" + this.Date + "', " +
                    "'" + this.Inv_Num + "', '" + this.Obj_name +
                    "', '" + this.Count + "', '" + this.Price +
                    "', '" + this.isAvailable + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static public List<Product> GetAllProducts()
        {
            List<Product> temp = new List<Product>();
            try
            {

                string connectionString = @" Data source = LAPTOP-T60OO29F\SQLEXPRESS; Initial Catalog = C#1; Integrated Security = True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "Select * from Products";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Product p = new Product();
                    p.Number = (int)sdr["Number"];
                    p.Date = (string)sdr["Date"];
                    p.Inv_Num = (int)sdr["Inventory_Number"];
                    p.Obj_name = (string)sdr["Object_Name"];
                    p.Count = (int)sdr["Count"];
                    p.Price = (double)sdr["Price"];
                    p.isAvailable = Convert.ToBoolean(sdr["Availability"]);
                    
                    temp.Add(p);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temp;
        }
        public static Product findOne(string name)
        {
            return list.Find(list => list.Obj_name == name);
        }




    }
 }

