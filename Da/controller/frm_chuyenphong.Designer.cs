namespace Da.controller
{
    partial class frm_chuyenphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_chuyenphong));
            this.groupBoxphong = new System.Windows.Forms.GroupBox();
            this.btn_chuyen = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.chb_loai = new System.Windows.Forms.CheckBox();
            this.chb_tang = new System.Windows.Forms.CheckBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.panelphong = new System.Windows.Forms.Panel();
            this.groupBoxphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxphong
            // 
            this.groupBoxphong.Controls.Add(this.btn_chuyen);
            this.groupBoxphong.Controls.Add(this.btnTimkiem);
            this.groupBoxphong.Controls.Add(this.chb_loai);
            this.groupBoxphong.Controls.Add(this.chb_tang);
            this.groupBoxphong.Controls.Add(this.cbb_loai);
            this.groupBoxphong.Controls.Add(this.cbb_tang);
            this.groupBoxphong.Controls.Add(this.panelphong);
            this.groupBoxphong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxphong.Location = new System.Drawing.Point(12, 12);
            this.groupBoxphong.Name = "groupBoxphong";
            this.groupBoxphong.Size = new System.Drawing.Size(1253, 569);
            this.groupBoxphong.TabIndex = 13;
            this.groupBoxphong.TabStop = false;
            this.groupBoxphong.Text = "Danh sách phòng";
            // 
            // btn_chuyen
            // 
            this.btn_chuyen.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chuyen.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_chuyen.Appearance.Options.UseFont = true;
            this.btn_chuyen.Appearance.Options.UseForeColor = true;
            this.btn_chuyen.Enabled = false;
            this.btn_chuyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_chuyen.ImageOptions.Image")));
            this.btn_chuyen.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_chuyen.Location = new System.Drawing.Point(1054, 22);
            this.btn_chuyen.Name = "btn_chuyen";
            this.btn_chuyen.Size = new System.Drawing.Size(162, 50);
            this.btn_chuyen.TabIndex = 35;
            this.btn_chuyen.Text = "Chuyển";
            this.btn_chuyen.Click += new System.EventHandler(this.btn_chuyen_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimkiem.Appearance.Options.UseFont = true;
            this.btnTimkiem.Appearance.Options.UseForeColor = true;
            this.btnTimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.ImageOptions.Image")));
            this.btnTimkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(880, 22);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(162, 50);
            this.btnTimkiem.TabIndex = 34;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // chb_loai
            // 
            this.chb_loai.AutoSize = true;
            this.chb_loai.Location = new System.Drawing.Point(445, 33);
            this.chb_loai.Name = "chb_loai";
            this.chb_loai.Size = new System.Drawing.Size(150, 30);
            this.chb_loai.TabIndex = 20;
            this.chb_loai.Text = "Loại phòng";
            this.chb_loai.UseVisualStyleBackColor = true;
            this.chb_loai.CheckedChanged += new System.EventHandler(this.chb_loai_CheckedChanged);
            // 
            // chb_tang
            // 
            this.chb_tang.AutoSize = true;
            this.chb_tang.Location = new System.Drawing.Point(66, 33);
            this.chb_tang.Name = "chb_tang";
            this.chb_tang.Size = new System.Drawing.Size(86, 30);
            this.chb_tang.TabIndex = 19;
            this.chb_tang.Text = "Tầng";
            this.chb_tang.UseVisualStyleBackColor = true;
            this.chb_tang.CheckedChanged += new System.EventHandler(this.chb_tang_CheckedChanged);
            // 
            // cbb_loai
            // 
            this.cbb_loai.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_loai.Enabled = false;
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Items.AddRange(new object[] {
            "Tất cả",
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4",
            "Tầng 5",
            "Tầng 6",
            "Tầng 7",
            "Tầng 8"});
            this.cbb_loai.Location = new System.Drawing.Point(601, 32);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(273, 33);
            this.cbb_loai.TabIndex = 18;
            // 
            // cbb_tang
            // 
            this.cbb_tang.BackColor = System.Drawing.SystemColors.Control;
            this.cbb_tang.Enabled = false;
            this.cbb_tang.FormattingEnabled = true;
            this.cbb_tang.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4",
            "Tầng 5",
            "Tầng 6",
            "Tầng 7",
            "Tầng 8"});
            this.cbb_tang.Location = new System.Drawing.Point(158, 32);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(273, 33);
            this.cbb_tang.TabIndex = 17;
            // 
            // panelphong
            // 
            this.panelphong.AutoScroll = true;
            this.panelphong.BackColor = System.Drawing.Color.White;
            this.panelphong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelphong.Location = new System.Drawing.Point(6, 78);
            this.panelphong.Name = "panelphong";
            this.panelphong.Size = new System.Drawing.Size(1241, 467);
            this.panelphong.TabIndex = 0;
            // 
            // frm_chuyenphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 594);
            this.Controls.Add(this.groupBoxphong);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_chuyenphong";
            this.Text = "Chuyển phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_chuyenphong_FormClosing);
            this.Load += new System.EventHandler(this.frm_chuyenphong_Load);
            this.groupBoxphong.ResumeLayout(false);
            this.groupBoxphong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxphong;
        private System.Windows.Forms.CheckBox chb_loai;
        private System.Windows.Forms.CheckBox chb_tang;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.ComboBox cbb_tang;
        private System.Windows.Forms.Panel panelphong;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraEditors.SimpleButton btn_chuyen;
    }
}