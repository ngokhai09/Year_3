
namespace Bai10_GiaiPT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SoA = new System.Windows.Forms.TextBox();
            this.SoB = new System.Windows.Forms.TextBox();
            this.SoC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GiaiPT = new System.Windows.Forms.Button();
            this.LamLai = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.KetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SoA
            // 
            this.SoA.Location = new System.Drawing.Point(279, 57);
            this.SoA.Margin = new System.Windows.Forms.Padding(4);
            this.SoA.Name = "SoA";
            this.SoA.Size = new System.Drawing.Size(292, 27);
            this.SoA.TabIndex = 1;
            // 
            // SoB
            // 
            this.SoB.Location = new System.Drawing.Point(279, 107);
            this.SoB.Margin = new System.Windows.Forms.Padding(4);
            this.SoB.Name = "SoB";
            this.SoB.Size = new System.Drawing.Size(292, 27);
            this.SoB.TabIndex = 1;
            // 
            // SoC
            // 
            this.SoC.Location = new System.Drawing.Point(279, 165);
            this.SoC.Margin = new System.Windows.Forms.Padding(4);
            this.SoC.Name = "SoC";
            this.SoC.Size = new System.Drawing.Size(292, 27);
            this.SoC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kết quả";
            // 
            // GiaiPT
            // 
            this.GiaiPT.Location = new System.Drawing.Point(30, 395);
            this.GiaiPT.Margin = new System.Windows.Forms.Padding(4);
            this.GiaiPT.Name = "GiaiPT";
            this.GiaiPT.Size = new System.Drawing.Size(181, 43);
            this.GiaiPT.TabIndex = 4;
            this.GiaiPT.Text = "&Giải phương trình";
            this.GiaiPT.UseVisualStyleBackColor = true;
            this.GiaiPT.Click += new System.EventHandler(this.GiaiPT_Click);
            // 
            // LamLai
            // 
            this.LamLai.Location = new System.Drawing.Point(279, 395);
            this.LamLai.Margin = new System.Windows.Forms.Padding(4);
            this.LamLai.Name = "LamLai";
            this.LamLai.Size = new System.Drawing.Size(195, 43);
            this.LamLai.TabIndex = 4;
            this.LamLai.Text = "&Làm lại";
            this.LamLai.UseVisualStyleBackColor = true;
            this.LamLai.Click += new System.EventHandler(this.LamLai_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(543, 395);
            this.Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(195, 43);
            this.Thoat.TabIndex = 4;
            this.Thoat.Text = "&Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // KetQua
            // 
            this.KetQua.Location = new System.Drawing.Point(279, 220);
            this.KetQua.Margin = new System.Windows.Forms.Padding(4);
            this.KetQua.Multiline = true;
            this.KetQua.Name = "KetQua";
            this.KetQua.ReadOnly = true;
            this.KetQua.Size = new System.Drawing.Size(292, 107);
            this.KetQua.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 595);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.LamLai);
            this.Controls.Add(this.GiaiPT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KetQua);
            this.Controls.Add(this.SoC);
            this.Controls.Add(this.SoB);
            this.Controls.Add(this.SoA);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SoA;
        private System.Windows.Forms.TextBox SoB;
        private System.Windows.Forms.TextBox SoC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GiaiPT;
        private System.Windows.Forms.Button LamLai;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox KetQua;
    }
}

