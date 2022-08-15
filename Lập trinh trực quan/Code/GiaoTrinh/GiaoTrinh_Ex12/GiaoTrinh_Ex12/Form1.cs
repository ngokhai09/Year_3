using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoTrinh_Ex12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            {
                Close();
            }
        }

        private void btnGPT_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(nudA.Text);
            double b = Double.Parse(nudB.Text);
            string str = "A = " + a.ToString() + ", B = " + b.ToString();
            if(a == 0)
            {
                if (b == 0)
                {
                    str += ". Phương trình có vô số nghiệm.";
                }
                else str += ". Phương trình vô nghiệm.";
            }
            else
            {
                double x = (double)-b / a;
                str += ". Phương trình có 1 nghiệm là: " + x.ToString();
            }
            txtGPT.Text = str;
        }
    }
}
