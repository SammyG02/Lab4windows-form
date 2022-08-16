using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4windowsform
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
          
            if (string.IsNullOrEmpty(numberBox.Text))
            {
                errorProvider1.SetError(numberBox, "Number is required");
            }
            else if (string.IsNullOrEmpty(inventoryNumBox.Text))
            {
                errorProvider1.SetError(inventoryNumBox, "Inventory Number is required");
            }
            else if (string.IsNullOrEmpty(objectNameBox.Text))
            {
                errorProvider1.SetError(objectNameBox, "Object name is required");
            }
            else if (string.IsNullOrEmpty(countBox.Text))
            {
                errorProvider1.SetError(countBox, "Count is required");
            }
            else if (string.IsNullOrEmpty(priceBox.Text))
            {
                errorProvider1.SetError(priceBox, "Price is required");
            }
         
            else
            {
                try
                {
                    Setter p = new Setter
                    {
                        Number = int.Parse(numberBox.Text),
                        Date = dtp.Text,
                        Inv_Num = int.Parse(inventoryNumBox.Text),
                        Obj_name = objectNameBox.Text,
                        Count = int.Parse(countBox.Text),
                        Price = double.Parse(priceBox.Text),
                        isAvailable = (checkBox1.Checked)
                    };
                    p.save();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Setter.GetAllProducts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Type mismatch");
                };
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String checkeditem = "";
            if (checkBox1.Checked)
            {
                foreach (var item in checkedListBox1.Items)
                {
                    checkeditem += item.ToString()+" ";  
                }

            }
            MessageBox.Show(checkeditem);
        }

    }
}
