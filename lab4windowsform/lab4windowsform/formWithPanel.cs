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
    public partial class formWithPanel : Form
    {
        public formWithPanel()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Location = new Point(20,46);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Yellow;
            panel3.Location = new Point(20, 82);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Blue;
            panel3.Location = new Point(20, 122);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
            panel3.Location = new Point(20, 160);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formWithPanel_Load(object sender, EventArgs e)
        {
            foreach (var item in Setter.GetAllProducts())
            {
                ProductCardTemplate p = new ProductCardTemplate();
              //  p.propLabel1 = item;
               // flowLayoutPanel1.Controls.Add(p);

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productCardTemplate1_Load(object sender, EventArgs e)
        {

        }
    }
}
