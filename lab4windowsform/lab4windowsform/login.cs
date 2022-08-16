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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            String username = textBox1.Text;
            String password = textBox2.Text;
            if ((textBox1.Text == textBox2.Text) && (textBox1.Text)== "Admin")
            {
                
                MainWindow screen = new MainWindow();
                screen.Show();
                this.Hide();

            }
            
            

        }
    }
}
