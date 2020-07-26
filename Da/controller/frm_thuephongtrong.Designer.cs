namespace Da.controller
{
    partial class frm_thuephongtrong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thuephongtrong));
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thuephong = new DevExpress.XtraEditors.SimpleButton();
            this.txt_maphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngaythue = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.txt_giathue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_maphieuthue = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Location = new System.Drawing.Point(181, 187);
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(267, 34);
            this.txt_cmnd.TabIndex = 14;
            this.txt_cmnd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyDown);
            this.txt_cmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Enabled = false;
            this.txt_hoten.Location = new System.Drawing.Point(181, 129);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.ReadOnly = true;
            this.txt_hoten.Size = new System.Drawing.Size(267, 34);
            this.txt_hoten.TabIndex = 13;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(181, 244);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(267, 34);
            this.txt_sdt.TabIndex = 15;
            this.txt_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_sdt_KeyDown);
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // btn_dong
            // 
            this.btn_dong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_dong.Appearance.Options.UseFont = true;
            this.btn_dong.Appearance.Options.UseForeColor = true;
            this.btn_dong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_dong.ImageOptions.Image")));
            this.btn_dong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_dong.Location = new System.Drawing.Point(459, 296);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(179, 60);
            this.btn_dong.TabIndex = 17;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_thuephong
            // 
            this.btn_thuephong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thuephong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_thuephong.Appearance.Options.UseFont = true;
            this.btn_thuephong.Appearance.Options.UseForeColor = true;
            this.btn_thuephong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thuephong.ImageOptions.Image")));
            this.btn_thuephong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_thuephong.Location = new System.Drawing.Point(269, 296);
            this.btn_thuephong.Name = "btn_thuephong";
            this.btn_thuephong.Size = new System.Drawing.Size(179, 60);
            this.btn_thuephong.TabIndex = 16;
            this.btn_thuephong.Text = "Thuê phòng";
            this.btn_thuephong.Click += new System.EventHandler(this.btn_thuephong_Click);
            // 
            // txt_maphong
            // 
            this.txt_maphong.Enabled = false;
            this.txt_maphong.Location = new System.Drawing.Point(584, 74);
            this.txt_maphong.Name = "txt_maphong";
            this.txt_maphong.ReadOnly = true;
            this.txt_maphong.Size = new System.Drawing.Size(267, 34);
            this.txt_maphong.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày thuê:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày trả:";
            // 
            // dtp_ngaythue
            // 
            this.dtp_ngaythue.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaythue.Enabled = false;
            this.dtp_ngaythue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaythue.Location = new System.Drawing.Point(584, 183);
            this.dtp_ngaythue.Name = "dtp_ngaythue";
            this.dtp_ngaythue.Size = new System.Drawing.Size(267, 34);
            this.dtp_ngaythue.TabIndex = 22;
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaytra.Location = new System.Drawing.Point(584, 240);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(267, 34);
            this.dtp_ngaytra.TabIndex = 23;
            // 
            // txt_giathue
            // 
            this.txt_giathue.Enabled = false;
            this.txt_giathue.Location = new System.Drawing.Point(584, 129);
            this.txt_giathue.Name = "txt_giathue";
            this.txt_giathue.ReadOnly = true;
            this.txt_giathue.Size = new System.Drawing.Size(267, 34);
            this.txt_giathue.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Giá thuê:";
            // 
            // txt_maphieuthue
            // 
            this.txt_maphieuthue.Enabled = false;
            this.txt_maphieuthue.Location = new System.Drawing.Point(181, 74);
            this.txt_maphieuthue.Name = "txt_maphieuthue";
            this.txt_maphieuthue.ReadOnly = true;
            this.txt_maphieuthue.Size = new System.Drawing.Size(267, 34);
            this.txt_maphieuthue.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã phiếu thuê:";
            // 
            // frm_thuephongtrong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 395);
            this.Controls.Add(this.txt_maphieuthue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_giathue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtp_ngaytra);
            this.Controls.Add(this.dtp_ngaythue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_maphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_thuephong);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_thuephongtrong";
            this.Text = "Thuê phòng trống";
            this.Load += new System.EventHandler(this.frm_thuephongtrong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_dong;
        private DevExpress.XtraEditors.SimpleButton btn_thuephong;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ngaythue;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.TextBox txt_giathue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_maphieuthue;
        private System.Windows.Forms.Label label9;
    }
}