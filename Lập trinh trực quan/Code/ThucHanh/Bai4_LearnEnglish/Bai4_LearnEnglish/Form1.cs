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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bai1_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();
            bt.Debai = "My grandfather was born in China.He came from a very poor family and was (1)______ of seven children.His parents lived (2) ______a small farm. He didn't " +
                "have a very good education. At the age of 17 he (3) _____ home. First he went to Shanghai and(4)______he went to Hong Kong. " +
                "He worked (5)_____ a waiter and then as a cook. When he was 21,he (6)_____ my grandmother and had four children." +
                "My mother was(7)______ oldest.My grandmother died recently, and my grandfather lives alone now. He is almost 80,(8)______ he is still very active " +
                "and interested in everything (9)______ is going on.He reads the newpapers and (10)______ television even though his eyesight is fairly poor.";
            bt.Dapan = "My grandfather was born in China.He came from a very poor family and was (1) one of seven children.His parents lived (2) on a small farm. He didn't " +
                "have a very good education. At the age of 17 he (3) left home. First he went to Shanghai and(4) then he went to Hong Kong. " +
                "He worked (5) as a waiter and then as a cook. When he was 21,he (6) married my grandmother and had four children." +
                "My mother was(7) the oldest.My grandmother died recently, and my grandfather lives alone now. He is almost 80,(8) but he is still very active " +
                "and interested in everything (9) that is going on.He reads the newpapers and (10) watches television even though his eyesight is fairly poor.";

            List<string> lists = new List<string>();
            lists.Add("one");
            lists.Add("on");
            lists.Add("left");
            lists.Add("then");
            lists.Add("as");
            lists.Add("married");
            lists.Add("the");
            lists.Add("but");
            lists.Add("that");
            lists.Add("watches");
            bt.Dapantungcau = lists;


            Form2 form2 = new Form2(bt);
            form2.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel);
            if (rs == DialogResult.OK)
            {
                Close();
            }
        }
    }
}
