using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoTrinh_Ex11
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void lbSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool ok = false;
            if (lbBuy.Items.Contains(lbSell.SelectedItem))
            {
                ok = true;
                MessageBox.Show("Bạn đã chọn mua cuốn " + lbSell.SelectedItem + " rồi!", "Thông báo");
            }
            if(ok == false)
                lbBuy.Items.Add(lbSell.SelectedItem);
        }

        private void lbBuy_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa " + lbBuy.SelectedItem + " không?", "Thông báo", MessageBoxButtons.YesNo);
            if(res == DialogResult.Yes)
            {
                lbBuy.Items.Remove(lbBuy.SelectedItem);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "Họ tên khách hàng: " + txtName.Text + "\nSố điện thoại: " + txtPhone.Text;
            foreach (var item in lbBuy.Items)
            {
                str += "\n - " + item.ToString();
            }
            RadioButton check = sender as RadioButton;
            str += "\nPhương thức thanh toán: " + check.Text.ToString();
            MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK);
        }
    }
}
