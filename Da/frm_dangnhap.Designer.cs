﻿namespace Da
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.lblten = new DevExpress.XtraEditors.LabelControl();
            this.lblmk = new DevExpress.XtraEditors.LabelControl();
            this.btndn = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblten.Appearance.Options.UseFont = true;
            this.lblten.Appearance.Options.UseForeColor = true;
            this.lblten.Location = new System.Drawing.Point(31, 177);
            this.lblten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(175, 31);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "Tên đăng nhập";
            // 
            // lblmk
            // 
            this.lblmk.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmk.Appearance.ForeColor = System.Drawing.Color.Black;
            this.lblmk.Appearance.Options.UseFont = true;
            this.lblmk.Appearance.Options.UseForeColor = true;
            this.lblmk.Location = new System.Drawing.Point(31, 228);
            this.lblmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(114, 31);
            this.lblmk.TabIndex = 2;
            this.lblmk.Text = "Mật khẩu";
            // 
            // btndn
            // 
            this.btndn.Appearance.BackColor = System.Drawing.Color.DarkGreen;
            this.btndn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndn.Appearance.Options.UseBackColor = true;
            this.btndn.Appearance.Options.UseFont = true;
            this.btndn.Appearance.Options.UseForeColor = true;
            this.btndn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndn.ImageOptions.Image")));
            this.btndn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndn.Location = new System.Drawing.Point(102, 281);
            this.btndn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(153, 52);
            this.btndn.TabIndex = 5;
            this.btndn.Text = "Đăng nhập";
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.BackColor = System.Drawing.Color.DarkGreen;
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Appearance.Options.UseBackColor = true;
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnthoat.Location = new System.Drawing.Point(288, 281);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(147, 52);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtten
            // 
            this.txtten.EditValue = "";
            this.txtten.Location = new System.Drawing.Point(222, 179);
            this.txtten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtten.Name = "txtten";
            this.txtten.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtten.Properties.Appearance.Options.UseFont = true;
            this.txtten.Properties.Appearance.Options.UseForeColor = true;
            this.txtten.Size = new System.Drawing.Size(287, 32);
            this.txtten.TabIndex = 7;
            this.txtten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dangnhap_KeyDown);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(222, 230);
            this.txtmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Properties.Appearance.Options.UseFont = true;
            this.txtmk.Properties.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(287, 32);
            this.txtmk.TabIndex = 8;
            this.txtmk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dangnhap_KeyDown);
            // 
            // frm_dangnhap
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Da.Properties.Resources.Untitled;
            this.ClientSize = new System.Drawing.Size(547, 366);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lblten);
            this.DoubleBuffered = true;
            this.Name = "frm_dangnhap";
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_dangnhap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblten;
        private DevExpress.XtraEditors.LabelControl lblmk;
        private DevExpress.XtraEditors.SimpleButton btndn;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtmk;
    }
}