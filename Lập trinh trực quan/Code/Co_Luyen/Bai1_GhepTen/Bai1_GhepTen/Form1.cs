using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_GhepTen
{
    public partial class Form1 : Form
    {
        Dictionary<String, String> Conu_Cap = new Dictionary<String, String>(){
            {"France", "Paris" }, { "Japan","Tokyo" }, { "Hungary", "Budapset"}, { "Spain","Madrid" },
            { "Turkey","Ankara"},{ "The UK","London"},{ "Italia","Rome"},{ "Argentina","Buenos Aires"},{ "Brazil","Brazil"},{ "The USA","Washington"} };
        String nuoc = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == System.Windows.Forms.DialogResult.Yes) Application.Exit();
        }
       
        private String getNotification(String country)
        {
            
            return "Hãy chọn thành phố " + country;
        }

        private void France_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton check = sender as RadioButton;
            if (check.Checked)
            {
                Thong_bao.Text = getNotification(check.Text);
                Thong_bao.Visible = true;
                nuoc = check.Text;
            }
        }

        private void Buenos_Aires_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton c = sender as RadioButton;
            if (c.Checked && nuoc!="")
            {
                if(c.Text == Conu_Cap[nuoc])
                {
                    MessageBox.Show("Chúc mừng bạn, thủ đô của "+nuoc +" là "+c.Text);
                }
                else
                {
                    MessageBox.Show("Bạn sai rồi, thủ đô của " + nuoc + " không phải là " + c.Text);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            Paris.Checked = false;
            France.Checked = false;
            Japan.Checked = false;
            Hungary.Checked = false;
            Spain.Checked = false;
            Turkey.Checked = false;
            The_UK.Checked = false;
            Italia.Checked = false;
            Argentina.Checked = false;
            Brazil.Checked = false;
            The_USA.Checked = false;
            Buenos_Aires.Checked = false;
            Capital_Brazil.Checked = false;
            Tokyo.Checked = false;
            Rome.Checked = false;
            Washington.Checked = false;
            Madrid.Checked = false;
            London.Checked = false;
            Ankara.Checked = false;
            Budapest.Checked = false;
          

        }
    }
}
