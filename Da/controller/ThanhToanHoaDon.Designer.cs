﻿namespace Da
{
    partial class ThanhToanHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToanHoaDon));
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_khachdua = new System.Windows.Forms.TextBox();
            this.txt_tralai = new System.Windows.Forms.TextBox();
            this.btn_luuvain = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luukhongin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton_thanhtoan = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.White;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Location = new System.Drawing.Point(186, 30);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(434, 34);
            this.txt_tongtien.TabIndex = 0;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khách đưa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Còn lại:";
            // 
            // txt_khachdua
            // 
            this.txt_khachdua.Location = new System.Drawing.Point(186, 89);
            this.txt_khachdua.Margin = new System.Windows.Forms.Padding(5);
            this.txt_khachdua.Name = "txt_khachdua";
            this.txt_khachdua.Size = new System.Drawing.Size(434, 34);
            this.txt_khachdua.TabIndex = 4;
            this.txt_khachdua.TextChanged += new System.EventHandler(this.txt_khachdua_TextChanged);
            this.txt_khachdua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_khachdua_KeyPress);
            this.txt_khachdua.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_khachdua_KeyUp);
            // 
            // txt_tralai
            // 
            this.txt_tralai.BackColor = System.Drawing.Color.White;
            this.txt_tralai.Enabled = false;
            this.txt_tralai.Location = new System.Drawing.Point(186, 147);
            this.txt_tralai.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tralai.Name = "txt_tralai";
            this.txt_tralai.ReadOnly = true;
            this.txt_tralai.Size = new System.Drawing.Size(434, 34);
            this.txt_tralai.TabIndex = 5;
            this.txt_tralai.TextChanged += new System.EventHandler(this.txt_tralai_TextChanged);
            // 
            // btn_luuvain
            // 
            this.btn_luuvain.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuvain.Appearance.Options.UseFont = true;
            this.btn_luuvain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuvain.ImageOptions.Image")));
            this.btn_luuvain.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luuvain.Location = new System.Drawing.Point(469, 211);
            this.btn_luuvain.Name = "btn_luuvain";
            this.btn_luuvain.Size = new System.Drawing.Size(151, 60);
            this.btn_luuvain.TabIndex = 8;
            this.btn_luuvain.Text = "Lưu và in";
            this.btn_luuvain.Click += new System.EventHandler(this.btn_luuvain_Click);
            // 
            // btn_luukhongin
            // 
            this.btn_luukhongin.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luukhongin.Appearance.Options.UseFont = true;
            this.btn_luukhongin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luukhongin.ImageOptions.Image")));
            this.btn_luukhongin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luukhongin.Location = new System.Drawing.Point(262, 211);
            this.btn_luukhongin.Name = "btn_luukhongin";
            this.btn_luukhongin.Size = new System.Drawing.Size(189, 60);
            this.btn_luukhongin.TabIndex = 9;
            this.btn_luukhongin.Text = "Lưu không in";
            this.btn_luukhongin.Click += new System.EventHandler(this.btn_luukhongin_Click);
            // 
            // simpleButton_thanhtoan
            // 
            this.simpleButton_thanhtoan.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton_thanhtoan.Appearance.Options.UseFont = true;
            this.simpleButton_thanhtoan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton_thanhtoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton_thanhtoan.Location = new System.Drawing.Point(63, 211);
            this.simpleButton_thanhtoan.Name = "simpleButton_thanhtoan";
            this.simpleButton_thanhtoan.Size = new System.Drawing.Size(174, 60);
            this.simpleButton_thanhtoan.TabIndex = 10;
            this.simpleButton_thanhtoan.Text = "TT Thẻ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lần in: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(530, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 34);
            this.textBox1.TabIndex = 12;
            // 
            // ThanhToanHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 332);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton_thanhtoan);
            this.Controls.Add(this.btn_luukhongin);
            this.Controls.Add(this.btn_luuvain);
            this.Controls.Add(this.txt_tralai);
            this.Controls.Add(this.txt_khachdua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongtien);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ThanhToanHoaDon";
            this.Text = "ThanhToanHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_khachdua;
        private System.Windows.Forms.TextBox txt_tralai;
        private DevExpress.XtraEditors.SimpleButton btn_luuvain;
        private DevExpress.XtraEditors.SimpleButton btn_luukhongin;
        private DevExpress.XtraEditors.SimpleButton simpleButton_thanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}