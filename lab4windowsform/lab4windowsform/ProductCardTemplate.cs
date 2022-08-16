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
    public partial class ProductCardTemplate : UserControl
    {
        private string _propLabel1;

        public string propDate
        {
            get { return _propLabel1; }
            set { _propLabel1 = value; label1.Text = value; }
        }
        private String _label2;

        public string propObjName
        {
            get { return _label2; }
            set { _label2 = value; label2.Text = value; }
        }

        private int proplabel3;

        public int propNum
        {
            get { return proplabel3; }
            set { proplabel3 = value; label3.Text = value.ToString(); }
        }
        private int myVar;

        public int propInvNum
        {
            get { return myVar; }
            set { myVar = value; label4.Text = value.ToString(); }
        }

        private int propCount;
        public int _propCount
        {
            get { return propCount; }
            set { propCount = value; label5.Text = value.ToString(); }
        }
        private double propPrice;

        public double _propPrice
        {
            get { return propPrice; }
            set { propPrice = value; label6.Text = value.ToString(); }
        }







        //public int MyProperty { get; set; }

        public ProductCardTemplate()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ProductCardTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
