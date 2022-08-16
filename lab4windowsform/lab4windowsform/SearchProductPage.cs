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
    public partial class SearchProductPage : Form
    {
        public SearchProductPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var pro = Setter.findOne(textBox1.Text);
            if (pro == null)
            {
                MessageBox.Show("Not Found!");
            }
            else
            {
                MessageBox.Show("Found");
            }
        }
    }
}
