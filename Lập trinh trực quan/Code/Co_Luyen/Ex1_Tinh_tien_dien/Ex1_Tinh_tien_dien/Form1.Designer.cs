
namespace Ex1_Tinh_tien_dien
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grb = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThemds = new System.Windows.Forms.Button();
            this.txtPresent = new System.Windows.Forms.TextBox();
            this.txtPre = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblNhap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbox = new System.Windows.Forms.ListBox();
            this.lblDS = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb
            // 
            this.grb.Controls.Add(this.btnThem);
            this.grb.Controls.Add(this.btnThemds);
            this.grb.Controls.Add(this.txtPresent);
            this.grb.Controls.Add(this.txtPre);
            this.grb.Controls.Add(this.txtNgay);
            this.grb.Controls.Add(this.txtDiachi);
            this.grb.Controls.Add(this.txtTen);
            this.grb.Controls.Add(this.txtMa);
            this.grb.Controls.Add(this.lblPresent);
            this.grb.Controls.Add(this.lblPre);
            this.grb.Controls.Add(this.lblNgay);
            this.grb.Controls.Add(this.lblDiachi);
            this.grb.Controls.Add(this.lblTen);
            this.grb.Controls.Add(this.lblMa);
            this.grb.Controls.Add(this.lblNhap);
            this.grb.Location = new System.Drawing.Point(16, 19);
            this.grb.Name = "grb";
            this.grb.Size = new System.Drawing.Size(319, 412);
            this.grb.TabIndex = 0;
            this.grb.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(179, 259);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm &mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThemds
            // 
            this.btnThemds.Location = new System.Drawing.Point(50, 259);
            this.btnThemds.Name = "btnThemds";
            this.btnThemds.Size = new System.Drawing.Size(92, 23);
            this.btnThemds.TabIndex = 0;
            this.btnThemds.Text = "Thêm vào DS";
            this.btnThemds.UseVisualStyleBackColor = true;
            this.btnThemds.Click += new System.EventHandler(this.btnThemds_Click);
            // 
            // txtPresent
            // 
            this.txtPresent.Location = new System.Drawing.Point(99, 199);
            this.txtPresent.Name = "txtPresent";
            this.txtPresent.Size = new System.Drawing.Size(200, 20);
            this.txtPresent.TabIndex = 2;
            this.txtPresent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(99, 173);
            this.txtPre.Name = "txtPre";
            this.txtPre.Size = new System.Drawing.Size(200, 20);
            this.txtPre.TabIndex = 2;
            this.txtPre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(99, 147);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(200, 20);
            this.txtNgay.TabIndex = 2;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(99, 121);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(200, 20);
            this.txtDiachi.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(99, 95);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(200, 20);
            this.txtTen.TabIndex = 2;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(99, 69);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(200, 20);
            this.txtMa.TabIndex = 2;
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Location = new System.Drawing.Point(17, 202);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(70, 13);
            this.lblPresent.TabIndex = 1;
            this.lblPresent.Text = "Số tháng này";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(11, 176);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(77, 13);
            this.lblPre.TabIndex = 1;
            this.lblPre.Text = "Số tháng trước";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(18, 150);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(70, 13);
            this.lblNgay.TabIndex = 1;
            this.lblNgay.Text = "Ngày chốt số";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(47, 124);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(40, 13);
            this.lblDiachi.TabIndex = 1;
            this.lblDiachi.Text = "Địa chỉ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(31, 102);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(57, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Họ tên KH";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(47, 72);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(40, 13);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã KH";
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new System.Drawing.Point(34, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(202, 13);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập thông tin khách hàng sử dụng điện";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbox);
            this.groupBox2.Controls.Add(this.lblDS);
            this.groupBox2.Location = new System.Drawing.Point(332, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(445, 381);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(7, 21);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(437, 355);
            this.lbox.TabIndex = 1;
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Location = new System.Drawing.Point(9, 0);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(119, 13);
            this.lblDS.TabIndex = 0;
            this.lblDS.Text = "Danh sách khách hàng";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(406, 408);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(573, 408);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grb.ResumeLayout(false);
            this.grb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grb;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThemds;
        private System.Windows.Forms.TextBox txtPresent;
        private System.Windows.Forms.TextBox txtPre;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnThoat;
    }
}

