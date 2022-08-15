using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToaDo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Double.Parse(txtX1.Text);
            double x2 = Double.Parse(txtX2.Text);
            double y1 = Double.Parse(txtY1.Text);
            double y2 = Double.Parse(txtY2.Text);
            double hsg = (y2 - y1) / (x2 - x1);
            double kc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            txtHSG.Text = hsg.ToString();
            txtKC.Text = kc.ToString();
        }
    }
}
