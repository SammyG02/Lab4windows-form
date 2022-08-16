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
                ProductCardTemplate pc = new ProductCardTemplate();
                pc.propNum = item.Number;
                pc.propDate = item.Date;
                pc.propInvNum = item.Inv_Num;
                pc.propObjName = item.Obj_name;
                pc._propCount = item.Count;
                pc._propPrice = item.Price;
                flowLayoutPanel1.Controls.Add(pc);
            }
        }
    }
}
