using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10_GiaiPT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == System.Windows.Forms.DialogResult.Yes) Application.Exit();
        }

        private void LamLai_Click(object sender, EventArgs e)
        {
            SoA.Text = ""; SoA.Focus();
            SoB.Text = "";
            SoC.Text = "";
            KetQua.Text = "";
        }
        private bool checkPoint(ref String mess)
        {
            bool check = true;
            double num = 0;
            if (SoA.Text == "") { mess += "Bạn chưa nhập số a\n"; check = false; }
            else if(!double.TryParse(SoA.Text, out num)) { mess += "Số a phải là số thực\n"; check = false; }
            if (SoB.Text == "") { mess += "Bạn chưa nhập số b\n"; check = false; }
            else if (!double.TryParse(SoB.Text, out num)) { mess += "Số b phải là số thực\n"; check = false; }
            if (SoC.Text == "") { mess += "Bạn chưa nhập số c\n"; check = false; }
            else if (!double.TryParse(SoA.Text, out num)) { mess += "Số c phải là số thực\n"; check = false; }
            return check;
        }
        private void G_PTB2(double a, double b, double c)
        {
            if (a == 0) 
            {
                if (b == 0 && c == 0) KetQua.Text = "PT vô số nghiệm";
                else if (b == 0 && c != 0) KetQua.Text = "PT vô nghiệm";
                else
                {
                    KetQua.Text = "PT có 1 nghiệm x = " + Math.Round((Decimal)(-c / b), 2).ToString();
                }
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0) KetQua.Text = "PT vô nghiệm";
                if (d == 0) KetQua.Text = "PT có 1 nghiệm x = " + Math.Round((Decimal)(-b /2/ a), 2).ToString();
                if (d > 0) {
                    double x1 = (-b - Math.Sqrt(d)) / 2 / a;
                    double x2 = (-b + Math.Sqrt(d)) / 2 / a;
                    KetQua.Text = "PT có 2 nghiệm phân biệt:\n x1 = " + Math.Round((Decimal)(x1), 2).ToString() + " và x2 = " + Math.Round((Decimal)(x2), 2).ToString();
                }
            }
        }
        private void GiaiPT_Click(object sender, EventArgs e)
        {
            String mess = "";
            if (!checkPoint(ref mess)) MessageBox.Show(mess, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                G_PTB2(Double.Parse(SoA.Text), Double.Parse(SoB.Text), Double.Parse(SoC.Text));
            }
        }

 
    }
}
