using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1_Tinh_tien_dien
{
    public partial class Form1 : Form
    {
        private List<KhachHang> lists_KH = new List<KhachHang>();
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckCondition()
        {
            if (txtMa.Text.Count() < 6)
            {
                MessageBox.Show("Mã khách hàng phải đủ 6 ký tự", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return false;
            }
            if(txtTen.Text == "")
            {
                MessageBox.Show("Bạn phải nhập họ tên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(txtDiachi.Text == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            DateTime dt;
            if(DateTime.TryParse(txtNgay.Text, out dt) == false)
            {
                MessageBox.Show("Bạn nhập sai ngày tháng năm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }  
            if(Int16.Parse(txtPre.Text) > Int16.Parse(txtPresent.Text))
            {
                MessageBox.Show("Số tháng trc phải nhỏ hơn số tháng này", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }
        private void btnThemds_Click(object sender, EventArgs e)
        {
            if(CheckCondition() == true)
            {
                KhachHang KH = new KhachHang(Int16.Parse(txtMa.Text), txtTen.Text, txtDiachi.Text, DateTime.Parse(txtNgay.Text), Int16.Parse(txtPre.Text), Int16.Parse(txtPresent.Text));
                lists_KH.Add(KH);
                lbox.Items.Add(KH);
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtDiachi.Text = "";
            txtNgay.Text = "";
            txtPre.Text = "";
            txtPresent.Text = "";
        }
        private void Exit()
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool Ok = false;
            string name = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên khách hàng ", "Tìm kiếm");
            foreach(KhachHang items in lists_KH)
            {
                if(items.Ten == name)
                {
                    MessageBox.Show(items.Print());
                    Ok = true;
                }
            }
            if(Ok == false)
            {
                MessageBox.Show("Khách hàng " + name + " hiện chưa có trong danh sách", "Khách hàng");
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.H)
            {
                Exit();
            }
            else if(e.Alt && e.KeyCode == Keys.M)
            {
                btnThem_Click(sender, e);
            }
            else if(e.Alt && e.KeyCode == Keys.T)
            {
                btnThemds_Click(sender, e);
            }
        }
    }
}
