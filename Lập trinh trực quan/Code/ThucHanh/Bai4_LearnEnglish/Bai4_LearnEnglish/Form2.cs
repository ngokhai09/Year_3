using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_LearnEnglish
{
    public partial class Form2 : Form
    {
        BaiTapDienTu bt = new BaiTapDienTu();
        public Form2(BaiTapDienTu baitap)
        {
            InitializeComponent();
            bt = baitap;
            rtxtDe.Text = (bt.Debai);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int diem = 0;
            List<TextBox> list = new List<TextBox>();
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    list.Add((TextBox)c);                    
                }
            }
            for (int i = 0; i < 10; i++)
            {
                if (bt.Dapantungcau[i].Equals(list[i].Text))
                {
                    list[i].BackColor = Color.Green;
                    diem++;
                }
                else list[i].BackColor = Color.Pink;
            }
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            rtxtDe.Text = (bt.Dapan);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                    ((TextBox)c).BackColor = Color.White;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if(rs == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
