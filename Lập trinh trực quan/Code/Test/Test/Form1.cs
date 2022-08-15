using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test
{
    public partial class Form1 : Form
    {
        SqlConnection lk = null;
        DataTable dttable;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*dttable = Red("select NHANVIEN.MaNV, Ten, NgaySinh, DiaChi, SDT, TenCV from NHANVIEN inner join CT_CHUCVU on NHANVIEN.MaNV = CT_CHUCVU.MaNV inner join CHUCVU on CHUCVU.MaCV = CT_CHUCVU.MaCV");
            dataGridView1.DataSource = dttable;*/
            DateTime a = DateTime.Now;
            MessageBox.Show(a.ToString() + "\n" + a.ToString("yyyy-MM-dd"));
        }
        public void OpenCon()
        {
            lk = new SqlConnection(@"Data Source=LAPTOP-4IC7347M;Initial Catalog=QLCuaHangSieuThi;Integrated Security=True");
            if (lk.State == ConnectionState.Closed)
            {
                lk.Open();
                
            }
        }
        public void CloseCon()
        {
            if (lk.State == ConnectionState.Open)
            {
                lk.Close();
                lk.Dispose(); //giải phóng bộ nhớ
                lk = null;
            }
        }
        public Boolean Exe(string cmd) // truy van insert, update, delete
        {
            OpenCon();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                sc.ExecuteNonQuery();
                sc.Dispose();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }

            CloseCon();
            return check;
        }
        public DataTable Red(string cmd)  // truy van select
        {
            OpenCon();
            System.Data.DataTable check = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, lk);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(check);
                sc.Dispose();
            }
            catch (Exception)
            {
                check = null;
            }
            CloseCon();
            return check;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            
        }
    }
}
