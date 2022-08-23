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
    public partial class DisplayProductsPage : Form
    {
        public DisplayProductsPage()
        {
            InitializeComponent();
        }

        private void DisplayProductsPage_Load(object sender, EventArgs e)
        {
            foreach (var item in Setter.GetAllProducts())
            {
                ProductCardTemplate productCard = new ProductCardTemplate();
                productCard.propNum = item.Number;
                productCard.propDate = item.Date;
                productCard.propInvNum = item.Inv_Num;
                productCard.propObjName = item.Obj_name;
                productCard.propCount = item.Count;
                productCard.propPrice = item.Price;
                productCard.Click += (object o, EventArgs ea) =>
                {
                   DetailsPage dp = new DetailsPage(item.Number, item.Date, item.Inv_Num, item.Obj_name, item.Count, item.Price);
                    dp.Show();
                    
                   /* MessageBox.Show(item.Obj_name+'\n'+item.Number.ToString()+
                        '\n' + item.Inv_Num.ToString() + '\n' + item.Date+
                        '\n' + item.Price.ToString() +
                        '\n' + item.Count.ToString() +
                        '\n' + item.isAvailable.ToString());
                   */
                    
                };
                flowLayoutPanel1.Controls.Add(productCard);
            }
        }
    }
}
