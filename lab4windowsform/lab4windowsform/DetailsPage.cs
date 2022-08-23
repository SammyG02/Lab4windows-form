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
    public partial class DetailsPage : Form
    {
        public DetailsPage(int num, string date, int inv, string obj, int c, double p)
        {
            InitializeComponent();
            label2.Text = num.ToString();
            label4.Text = date;
            label6.Text = inv.ToString();
            label8.Text = obj;
            label10.Text = c.ToString();
            label12.Text = p.ToString();
        }

        private void DetailsPage_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
