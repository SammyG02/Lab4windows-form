﻿using System;
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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(this.ActiveMdiChild != null) { 
              
                ActiveMdiChild.Close();


            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();



        }
    }
}