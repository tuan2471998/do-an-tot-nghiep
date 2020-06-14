namespace Da.controller
{
    partial class frm_phieudatphong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phieudatphong));
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.textBoxtiencoc = new System.Windows.Forms.TextBox();
            this.labelkhachhang = new System.Windows.Forms.Label();
            this.textBoxsoluong = new System.Windows.Forms.TextBox();
            this.textBoxmanhanvien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmaphieudat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.dataGridViewchitiet = new System.Windows.Forms.DataGridView();
            this.MAPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxphong = new System.Windows.Forms.GroupBox();
            this.chb_loai = new System.Windows.Forms.CheckBox();
            this.chb_tang = new System.Windows.Forms.CheckBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.panelphong = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBoxphong.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1164, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.dtp_ngaytra);
            this.groupBox1.Controls.Add(this.dtp_ngaydat);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.textBoxtiencoc);
            this.groupBox1.Controls.Add(this.labelkhachhang);
            this.groupBox1.Controls.Add(this.textBoxsoluong);
            this.groupBox1.Controls.Add(this.textBoxmanhanvien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxmaphieudat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1714, 199);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu đặt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(617, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tiền đặt cọc:";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimkiem.Appearance.Options.UseFont = true;
            this.btnTimkiem.Appearance.Options.UseForeColor = true;
            this.btnTimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.ImageOptions.Image")));
            this.btnTimkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(1169, 112);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(162, 62);
            this.btnTimkiem.TabIndex = 33;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnxoa.Appearance.Options.UseFont = true;
            this.btnxoa.Appearance.Options.UseForeColor = true;
            this.btnxoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.ImageOptions.Image")));
            this.btnxoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnxoa.Location = new System.Drawing.Point(1337, 112);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(162, 62);
            this.btnxoa.TabIndex = 32;
            this.btnxoa.Text = "Xóa phòng";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Appearance.Options.UseForeColor = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuu.Location = new System.Drawing.Point(1505, 112);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(162, 62);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaytra.Location = new System.Drawing.Point(768, 91);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(309, 34);
            this.dtp_ngaytra.TabIndex = 30;
            // 
            // dtp_ngaydat
            // 
            this.dtp_ngaydat.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaydat.Location = new System.Drawing.Point(768, 45);
            this.dtp_ngaydat.Name = "dtp_ngaydat";
            this.dtp_ngaydat.Size = new System.Drawing.Size(309, 34);
            this.dtp_ngaydat.TabIndex = 29;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.LightBlue;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(209, 143);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(309, 34);
            this.txtMaKH.TabIndex = 28;
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // textBoxtiencoc
            // 
            this.textBoxtiencoc.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxtiencoc.Enabled = false;
            this.textBoxtiencoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtiencoc.Location = new System.Drawing.Point(768, 140);
            this.textBoxtiencoc.Name = "textBoxtiencoc";
            this.textBoxtiencoc.Size = new System.Drawing.Size(309, 34);
            this.textBoxtiencoc.TabIndex = 27;
            this.textBoxtiencoc.TextChanged += new System.EventHandler(this.textBoxtiencoc_TextChanged);
            // 
            // labelkhachhang
            // 
            this.labelkhachhang.AutoSize = true;
            this.labelkhachhang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkhachhang.Location = new System.Drawing.Point(24, 143);
            this.labelkhachhang.Name = "labelkhachhang";
            this.labelkhachhang.Size = new System.Drawing.Size(179, 26);
            this.labelkhachhang.TabIndex = 22;
            this.labelkhachhang.Text = "Mã khách hàng:";
            // 
            // textBoxsoluong
            // 
            this.textBoxsoluong.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxsoluong.Enabled = false;
            this.textBoxsoluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsoluong.Location = new System.Drawing.Point(1280, 49);
            this.textBoxsoluong.Name = "textBoxsoluong";
            this.textBoxsoluong.Size = new System.Drawing.Size(309, 34);
            this.textBoxsoluong.TabIndex = 20;
            // 
            // textBoxmanhanvien
            // 
            this.textBoxmanhanvien.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxmanhanvien.Enabled = false;
            this.textBoxmanhanvien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmanhanvien.Location = new System.Drawing.Point(209, 94);
            this.textBoxmanhanvien.Name = "textBoxmanhanvien";
            this.textBoxmanhanvien.Size = new System.Drawing.Size(309, 34);
            this.textBoxmanhanvien.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(617, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(617, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ngày đặt:";
            // 
            // textBoxmaphieudat
            // 
            this.textBoxmaphieudat.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxmaphieudat.Enabled = false;
            this.textBoxmaphieudat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmaphieudat.Location = new System.Drawing.Point(209, 46);
            this.textBoxmaphieudat.Name = "textBoxmaphieudat";
            this.textBoxmaphieudat.Size = new System.Drawing.Size(309, 34);
            this.textBoxmaphieudat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã phiếu đặt:";
            // 
            // dataGridViewchitiet
            // 
            this.dataGridViewchitiet.AllowUserToAddRows = false;
            this.dataGridViewchitiet.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPD,
            this.MAPH});
            this.dataGridViewchitiet.Location = new System.Drawing.Point(10, 33);
            this.dataGridViewchitiet.Name = "dataGridViewchitiet";
            this.dataGridViewchitiet.RowHeadersVisible = false;
            this.dataGridViewchitiet.RowHeadersWidth = 51;
            this.dataGridViewchitiet.RowTemplate.Height = 24;
            this.dataGridViewchitiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewchitiet.Size = new System.Drawing.Size(505, 487);
            this.dataGridViewchitiet.TabIndex = 9;
            this.dataGridViewchitiet.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridViewchitiet_CellPainting);
            // 
            // MAPD
            // 
            this.MAPD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPD.DataPropertyName = "MADP";
            this.MAPD.HeaderText = "Mã Phiếu Đặt";
            this.MAPD.MinimumWidth = 6;
            this.MAPD.Name = "MAPD";
            // 
            // MAPH
            // 
            this.MAPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPH.DataPropertyName = "MAPH";
            this.MAPH.HeaderText = "Mã Phòng";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewchitiet);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 533);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu đặt";
            // 
            // groupBoxphong
            // 
            this.groupBoxphong.Controls.Add(this.chb_loai);
            this.groupBoxphong.Controls.Add(this.chb_tang);
            this.groupBoxphong.Controls.Add(this.cbb_loai);
            this.groupBoxphong.Controls.Add(this.cbb_tang);
            this.groupBoxphong.Controls.Add(this.panelphong);
            this.groupBoxphong.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBoxphong.Location = new System.Drawing.Point(521, 208);
            this.groupBoxphong.Name = "groupBoxphong";
            this.groupBoxphong.Size = new System.Drawing.Size(1196, 533);
            this.groupBoxphong.TabIndex = 12;
            this.groupBoxphong.TabStop = false;
            this.groupBoxphong.Text = "Danh sách phòng";
            // 
            // chb_loai
            // 
            this.chb_loai.AutoSize = true;
            this.chb_loai.Location = new System.Drawing.Point(409, 33);
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
            this.chb_tang.Location = new System.Drawing.Point(30, 33);
            this.chb_tang.Name = "chb_tang";
            this.chb_tang.Size = new System.Drawing.Size(86, 30);
            this.chb_tang.TabIndex = 19;
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
            this.cbb_loai.Location = new System.Drawing.Point(565, 32);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(273, 33);
            this.cbb_loai.TabIndex = 18;
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
            this.cbb_tang.Location = new System.Drawing.Point(122, 32);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(273, 33);
            this.cbb_tang.TabIndex = 17;
            // 
            // panelphong
            // 
            this.panelphong.AutoScroll = true;
            this.panelphong.BackColor = System.Drawing.Color.White;
            this.panelphong.Location = new System.Drawing.Point(3, 80);
            this.panelphong.Name = "panelphong";
            this.panelphong.Size = new System.Drawing.Size(1187, 440);
            this.panelphong.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_phieudatphong
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxphong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_phieudatphong";
            this.Size = new System.Drawing.Size(1720, 745);
            this.Load += new System.EventHandler(this.frm_phieudatphong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewchitiet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxphong.ResumeLayout(false);
            this.groupBoxphong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmaphieudat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private System.Windows.Forms.DataGridView dataGridViewchitiet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxphong;
        private System.Windows.Forms.Panel panelphong;
        private System.Windows.Forms.TextBox textBoxsoluong;
        private System.Windows.Forms.TextBox textBoxmanhanvien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.Label labelkhachhang;
        private System.Windows.Forms.TextBox textBoxtiencoc;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.DateTimePicker dtp_ngaydat;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.CheckBox chb_loai;
        private System.Windows.Forms.CheckBox chb_tang;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.ComboBox cbb_tang;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private System.Windows.Forms.Label label6;
    }
}

