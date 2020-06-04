namespace Da.controller
{
    partial class frm_danhsachphong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_danhsachphong));
            this.groupbox_timkiem = new System.Windows.Forms.GroupBox();
            this.chb_tinhtrang = new System.Windows.Forms.CheckBox();
            this.panel_tinhtrang = new System.Windows.Forms.Panel();
            this.rdb_dangsudung = new System.Windows.Forms.RadioButton();
            this.rdb_trong = new System.Windows.Forms.RadioButton();
            this.rdb_duocdat = new System.Windows.Forms.RadioButton();
            this.rdb_dangdondep = new System.Windows.Forms.RadioButton();
            this.rdb_dangsuachua = new System.Windows.Forms.RadioButton();
            this.chb_loai = new System.Windows.Forms.CheckBox();
            this.chb_tang = new System.Windows.Forms.CheckBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.panelphong = new System.Windows.Forms.Panel();
            this.groupbox_timkiem.SuspendLayout();
            this.panel_tinhtrang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_timkiem
            // 
            this.groupbox_timkiem.BackColor = System.Drawing.Color.LightBlue;
            this.groupbox_timkiem.Controls.Add(this.chb_tinhtrang);
            this.groupbox_timkiem.Controls.Add(this.panel_tinhtrang);
            this.groupbox_timkiem.Controls.Add(this.chb_loai);
            this.groupbox_timkiem.Controls.Add(this.chb_tang);
            this.groupbox_timkiem.Controls.Add(this.cbb_loai);
            this.groupbox_timkiem.Controls.Add(this.cbb_tang);
            this.groupbox_timkiem.Controls.Add(this.btn_timkiem);
            this.groupbox_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_timkiem.Location = new System.Drawing.Point(3, 3);
            this.groupbox_timkiem.Name = "groupbox_timkiem";
            this.groupbox_timkiem.Size = new System.Drawing.Size(1695, 132);
            this.groupbox_timkiem.TabIndex = 0;
            this.groupbox_timkiem.TabStop = false;
            this.groupbox_timkiem.Text = "Thông tin tìm kiếm";
            // 
            // chb_tinhtrang
            // 
            this.chb_tinhtrang.AutoSize = true;
            this.chb_tinhtrang.Location = new System.Drawing.Point(719, 34);
            this.chb_tinhtrang.Name = "chb_tinhtrang";
            this.chb_tinhtrang.Size = new System.Drawing.Size(213, 30);
            this.chb_tinhtrang.TabIndex = 17;
            this.chb_tinhtrang.Text = "Tình trạng phòng";
            this.chb_tinhtrang.UseVisualStyleBackColor = true;
            this.chb_tinhtrang.CheckedChanged += new System.EventHandler(this.chb_tinhtrang_CheckedChanged);
            // 
            // panel_tinhtrang
            // 
            this.panel_tinhtrang.Controls.Add(this.rdb_dangsudung);
            this.panel_tinhtrang.Controls.Add(this.rdb_trong);
            this.panel_tinhtrang.Controls.Add(this.rdb_duocdat);
            this.panel_tinhtrang.Controls.Add(this.rdb_dangdondep);
            this.panel_tinhtrang.Controls.Add(this.rdb_dangsuachua);
            this.panel_tinhtrang.Enabled = false;
            this.panel_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_tinhtrang.Location = new System.Drawing.Point(719, 62);
            this.panel_tinhtrang.Name = "panel_tinhtrang";
            this.panel_tinhtrang.Size = new System.Drawing.Size(777, 41);
            this.panel_tinhtrang.TabIndex = 2;
            // 
            // rdb_dangsudung
            // 
            this.rdb_dangsudung.AutoSize = true;
            this.rdb_dangsudung.ForeColor = System.Drawing.Color.Blue;
            this.rdb_dangsudung.Location = new System.Drawing.Point(100, 8);
            this.rdb_dangsudung.Name = "rdb_dangsudung";
            this.rdb_dangsudung.Size = new System.Drawing.Size(173, 30);
            this.rdb_dangsudung.TabIndex = 4;
            this.rdb_dangsudung.TabStop = true;
            this.rdb_dangsudung.Text = "Đang sử dụng";
            this.rdb_dangsudung.UseVisualStyleBackColor = true;
            // 
            // rdb_trong
            // 
            this.rdb_trong.AutoSize = true;
            this.rdb_trong.ForeColor = System.Drawing.Color.LightCoral;
            this.rdb_trong.Location = new System.Drawing.Point(0, 8);
            this.rdb_trong.Name = "rdb_trong";
            this.rdb_trong.Size = new System.Drawing.Size(94, 30);
            this.rdb_trong.TabIndex = 3;
            this.rdb_trong.TabStop = true;
            this.rdb_trong.Text = "Trống";
            this.rdb_trong.UseVisualStyleBackColor = true;
            // 
            // rdb_duocdat
            // 
            this.rdb_duocdat.AutoSize = true;
            this.rdb_duocdat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rdb_duocdat.Location = new System.Drawing.Point(279, 8);
            this.rdb_duocdat.Name = "rdb_duocdat";
            this.rdb_duocdat.Size = new System.Drawing.Size(127, 30);
            this.rdb_duocdat.TabIndex = 5;
            this.rdb_duocdat.TabStop = true;
            this.rdb_duocdat.Text = "Được đặt";
            this.rdb_duocdat.UseVisualStyleBackColor = true;
            // 
            // rdb_dangdondep
            // 
            this.rdb_dangdondep.AutoSize = true;
            this.rdb_dangdondep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdb_dangdondep.Location = new System.Drawing.Point(412, 8);
            this.rdb_dangdondep.Name = "rdb_dangdondep";
            this.rdb_dangdondep.Size = new System.Drawing.Size(174, 30);
            this.rdb_dangdondep.TabIndex = 6;
            this.rdb_dangdondep.TabStop = true;
            this.rdb_dangdondep.Text = "Đang dọn dẹp";
            this.rdb_dangdondep.UseVisualStyleBackColor = true;
            // 
            // rdb_dangsuachua
            // 
            this.rdb_dangsuachua.AutoSize = true;
            this.rdb_dangsuachua.ForeColor = System.Drawing.Color.Yellow;
            this.rdb_dangsuachua.Location = new System.Drawing.Point(592, 8);
            this.rdb_dangsuachua.Name = "rdb_dangsuachua";
            this.rdb_dangsuachua.Size = new System.Drawing.Size(184, 30);
            this.rdb_dangsuachua.TabIndex = 7;
            this.rdb_dangsuachua.TabStop = true;
            this.rdb_dangsuachua.Text = "Đang sửa chữa";
            this.rdb_dangsuachua.UseVisualStyleBackColor = true;
            // 
            // chb_loai
            // 
            this.chb_loai.AutoSize = true;
            this.chb_loai.Location = new System.Drawing.Point(392, 34);
            this.chb_loai.Name = "chb_loai";
            this.chb_loai.Size = new System.Drawing.Size(150, 30);
            this.chb_loai.TabIndex = 16;
            this.chb_loai.Text = "Loại phòng";
            this.chb_loai.UseVisualStyleBackColor = true;
            this.chb_loai.CheckedChanged += new System.EventHandler(this.chb_loai_CheckedChanged);
            // 
            // chb_tang
            // 
            this.chb_tang.AutoSize = true;
            this.chb_tang.Location = new System.Drawing.Point(77, 33);
            this.chb_tang.Name = "chb_tang";
            this.chb_tang.Size = new System.Drawing.Size(86, 30);
            this.chb_tang.TabIndex = 15;
            this.chb_tang.Text = "Tầng";
            this.chb_tang.UseVisualStyleBackColor = true;
            this.chb_tang.CheckedChanged += new System.EventHandler(this.chb_tang_CheckedChanged);
            // 
            // cbb_loai
            // 
            this.cbb_loai.BackColor = System.Drawing.Color.LightBlue;
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
            this.cbb_loai.Location = new System.Drawing.Point(392, 70);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(273, 33);
            this.cbb_loai.TabIndex = 14;
            // 
            // cbb_tang
            // 
            this.cbb_tang.BackColor = System.Drawing.Color.LightBlue;
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
            this.cbb_tang.Location = new System.Drawing.Point(77, 70);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(273, 33);
            this.cbb_tang.TabIndex = 12;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Appearance.Options.UseBackColor = true;
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.ImageOptions.Image")));
            this.btn_timkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_timkiem.Location = new System.Drawing.Point(1521, 49);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(156, 54);
            this.btn_timkiem.TabIndex = 1;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // panelphong
            // 
            this.panelphong.AutoScroll = true;
            this.panelphong.BackColor = System.Drawing.Color.White;
            this.panelphong.Location = new System.Drawing.Point(0, 141);
            this.panelphong.Name = "panelphong";
            this.panelphong.Size = new System.Drawing.Size(1705, 609);
            this.panelphong.TabIndex = 1;
            // 
            // frm_danhsachphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.panelphong);
            this.Controls.Add(this.groupbox_timkiem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_danhsachphong";
            this.Size = new System.Drawing.Size(1708, 750);
            this.Load += new System.EventHandler(this.frm_danhsachphong_Load);
            this.groupbox_timkiem.ResumeLayout(false);
            this.groupbox_timkiem.PerformLayout();
            this.panel_tinhtrang.ResumeLayout(false);
            this.panel_tinhtrang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_timkiem;
        private System.Windows.Forms.RadioButton rdb_dangsuachua;
        private System.Windows.Forms.RadioButton rdb_dangdondep;
        private System.Windows.Forms.RadioButton rdb_duocdat;
        private System.Windows.Forms.RadioButton rdb_dangsudung;
        private System.Windows.Forms.RadioButton rdb_trong;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private System.Windows.Forms.Panel panelphong;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.ComboBox cbb_tang;
        private System.Windows.Forms.CheckBox chb_loai;
        private System.Windows.Forms.CheckBox chb_tang;
        private System.Windows.Forms.Panel panel_tinhtrang;
        private System.Windows.Forms.CheckBox chb_tinhtrang;
    }
}
