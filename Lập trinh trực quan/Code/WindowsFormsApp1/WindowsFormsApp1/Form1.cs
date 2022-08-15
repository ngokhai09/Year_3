using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<int> a = new List<int>();
        Random ran = new Random();
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtNhap.Text);
            for(int i = 0; i < n; i++)
            {
                int b = ran.Next(1, 100);
                a.Add(b);
                txtDay.Text += b + " ";
            }

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
            {
                Sum += a[i];
            }
            txtTong.Text += Sum;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(a[i] > a[j])
                    {
                        a[i] += a[j];
                        a[j] = a[i] - a[j];
                        a[i] -= a[j];
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                txtSort.Text += a[i] + " ";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDay.Text = "";
            txtNhap.Text = "";
            txtSort.Text = "";
            txtTong.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
