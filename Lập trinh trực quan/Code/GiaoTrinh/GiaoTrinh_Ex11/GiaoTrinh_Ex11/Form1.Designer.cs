
namespace GiaoTrinh_Ex11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbSell = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCard = new System.Windows.Forms.RadioButton();
            this.rbtnSec = new System.Windows.Forms.RadioButton();
            this.rbtnMoney = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBuy = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFax = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách các mặt hàng: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số điện thoại: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(80, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(446, 46);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // lbSell
            // 
            this.lbSell.FormattingEnabled = true;
            this.lbSell.HorizontalScrollbar = true;
            this.lbSell.Items.AddRange(new object[] {
            "Kỹ thuật lập trình C#",
            "Tự học Visual C# trong 21 ngày",
            ".NET toàn tập-tập 1",
            ".NET toàn tập-tập 2",
            ".NET toàn tập-tập 3",
            ".NET toàn tập-tập 4",
            ".NET toàn tập-tập 5",
            ".NET toàn tập-tập 6",
            "Tin học căn bản SQL Sever"});
            this.lbSell.Location = new System.Drawing.Point(34, 164);
            this.lbSell.Name = "lbSell";
            this.lbSell.Size = new System.Drawing.Size(246, 147);
            this.lbSell.TabIndex = 3;
            this.lbSell.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSell_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCard);
            this.groupBox1.Controls.Add(this.rbtnSec);
            this.groupBox1.Controls.Add(this.rbtnMoney);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(56, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // rbtnCard
            // 
            this.rbtnCard.AutoSize = true;
            this.rbtnCard.Location = new System.Drawing.Point(37, 75);
            this.rbtnCard.Name = "rbtnCard";
            this.rbtnCard.Size = new System.Drawing.Size(87, 17);
            this.rbtnCard.TabIndex = 7;
            this.rbtnCard.Text = "Thẻ tín dụng";
            this.rbtnCard.UseVisualStyleBackColor = true;
            // 
            // rbtnSec
            // 
            this.rbtnSec.AutoSize = true;
            this.rbtnSec.Location = new System.Drawing.Point(37, 54);
            this.rbtnSec.Name = "rbtnSec";
            this.rbtnSec.Size = new System.Drawing.Size(44, 17);
            this.rbtnSec.TabIndex = 6;
            this.rbtnSec.Text = "Séc";
            this.rbtnSec.UseVisualStyleBackColor = true;
            // 
            // rbtnMoney
            // 
            this.rbtnMoney.AutoSize = true;
            this.rbtnMoney.Location = new System.Drawing.Point(37, 31);
            this.rbtnMoney.Name = "rbtnMoney";
            this.rbtnMoney.Size = new System.Drawing.Size(66, 17);
            this.rbtnMoney.TabIndex = 5;
            this.rbtnMoney.Text = "Tiền mặt";
            this.rbtnMoney.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phương thức thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hàng đặt mua:";
            // 
            // lbBuy
            // 
            this.lbBuy.FormattingEnabled = true;
            this.lbBuy.Location = new System.Drawing.Point(366, 164);
            this.lbBuy.Name = "lbBuy";
            this.lbBuy.Size = new System.Drawing.Size(246, 147);
            this.lbBuy.TabIndex = 4;
            this.lbBuy.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbBuy_MouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbFax);
            this.groupBox2.Controls.Add(this.cbPhone);
            this.groupBox2.Location = new System.Drawing.Point(401, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 122);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(43, 75);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(51, 17);
            this.cbEmail.TabIndex = 10;
            this.cbEmail.Text = "Email";
            this.cbEmail.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hình thức liên lạc";
            // 
            // cbFax
            // 
            this.cbFax.AutoSize = true;
            this.cbFax.Location = new System.Drawing.Point(43, 52);
            this.cbFax.Name = "cbFax";
            this.cbFax.Size = new System.Drawing.Size(43, 17);
            this.cbFax.TabIndex = 9;
            this.cbFax.Text = "Fax";
            this.cbFax.UseVisualStyleBackColor = true;
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(43, 29);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(74, 17);
            this.cbPhone.TabIndex = 8;
            this.cbPhone.Text = "Điện thoại";
            this.cbPhone.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 471);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "&Đồng ý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(328, 471);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 33);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "&Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 528);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbBuy);
            this.Controls.Add(this.lbSell);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ListBox lbSell;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCard;
        private System.Windows.Forms.RadioButton rbtnSec;
        private System.Windows.Forms.RadioButton rbtnMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbBuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbFax;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
    }
}

