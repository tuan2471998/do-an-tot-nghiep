namespace Da.controller
{
    partial class frm_phieuthue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_phieuthue));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dtp_ngaytra = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaydat = new System.Windows.Forms.DateTimePicker();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxsl = new System.Windows.Forms.TextBox();
            this.textBoxtiencoc = new System.Windows.Forms.TextBox();
            this.textBoxmanhanvien = new System.Windows.Forms.TextBox();
            this.textBoxmathuephong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MATP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chb_loai = new System.Windows.Forms.CheckBox();
            this.chb_tang = new System.Windows.Forms.CheckBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.cbb_tang = new System.Windows.Forms.ComboBox();
            this.panel_ph = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer_phieuthue = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.dtp_ngaytra);
            this.groupBox1.Controls.Add(this.dtp_ngaydat);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.textBoxsl);
            this.groupBox1.Controls.Add(this.textBoxtiencoc);
            this.groupBox1.Controls.Add(this.textBoxmanhanvien);
            this.groupBox1.Controls.Add(this.textBoxmathuephong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1632, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu thuê";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.LightBlue;
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(177, 153);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(309, 34);
            this.txtMaKH.TabIndex = 39;
            this.txtMaKH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaKH_KeyDown);
            this.txtMaKH.Leave += new System.EventHandler(this.txtMaKH_Leave);
            // 
            // dtp_ngaytra
            // 
            this.dtp_ngaytra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaytra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaytra.Location = new System.Drawing.Point(690, 93);
            this.dtp_ngaytra.Name = "dtp_ngaytra";
            this.dtp_ngaytra.Size = new System.Drawing.Size(309, 34);
            this.dtp_ngaytra.TabIndex = 38;
            // 
            // dtp_ngaydat
            // 
            this.dtp_ngaydat.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaydat.Location = new System.Drawing.Point(690, 34);
            this.dtp_ngaydat.Name = "dtp_ngaydat";
            this.dtp_ngaydat.Size = new System.Drawing.Size(309, 34);
            this.dtp_ngaydat.TabIndex = 37;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimkiem.Appearance.Options.UseFont = true;
            this.btnTimkiem.Appearance.Options.UseForeColor = true;
            this.btnTimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.ImageOptions.Image")));
            this.btnTimkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(1108, 107);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(162, 62);
            this.btnTimkiem.TabIndex = 36;
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
            this.btnxoa.Location = new System.Drawing.Point(1276, 107);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(162, 62);
            this.btnxoa.TabIndex = 35;
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
            this.btnLuu.Location = new System.Drawing.Point(1444, 107);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(162, 62);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // textBoxsl
            // 
            this.textBoxsl.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxsl.Enabled = false;
            this.textBoxsl.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsl.Location = new System.Drawing.Point(1109, 34);
            this.textBoxsl.Name = "textBoxsl";
            this.textBoxsl.Size = new System.Drawing.Size(309, 34);
            this.textBoxsl.TabIndex = 19;
            // 
            // textBoxtiencoc
            // 
            this.textBoxtiencoc.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxtiencoc.Enabled = false;
            this.textBoxtiencoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtiencoc.Location = new System.Drawing.Point(690, 153);
            this.textBoxtiencoc.Name = "textBoxtiencoc";
            this.textBoxtiencoc.Size = new System.Drawing.Size(309, 34);
            this.textBoxtiencoc.TabIndex = 18;
            this.textBoxtiencoc.TextChanged += new System.EventHandler(this.textBoxtiencoc_TextChanged);
            // 
            // textBoxmanhanvien
            // 
            this.textBoxmanhanvien.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxmanhanvien.Enabled = false;
            this.textBoxmanhanvien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmanhanvien.Location = new System.Drawing.Point(177, 92);
            this.textBoxmanhanvien.Name = "textBoxmanhanvien";
            this.textBoxmanhanvien.Size = new System.Drawing.Size(309, 34);
            this.textBoxmanhanvien.TabIndex = 17;
            // 
            // textBoxmathuephong
            // 
            this.textBoxmathuephong.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxmathuephong.Enabled = false;
            this.textBoxmathuephong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmathuephong.Location = new System.Drawing.Point(177, 33);
            this.textBoxmathuephong.Name = "textBoxmathuephong";
            this.textBoxmathuephong.Size = new System.Drawing.Size(309, 34);
            this.textBoxmathuephong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(1019, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(530, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tiền cọc trước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(530, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày trả phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(530, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày nhận phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã thuê phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(3, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 540);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu thuê";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATP,
            this.MAPH});
            this.dataGridView2.Location = new System.Drawing.Point(6, 33);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(506, 501);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView2_CellPainting);
            // 
            // MATP
            // 
            this.MATP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATP.DataPropertyName = "MATP";
            this.MATP.FillWeight = 200F;
            this.MATP.HeaderText = "Mã thuê phòng";
            this.MATP.MinimumWidth = 6;
            this.MATP.Name = "MATP";
            // 
            // MAPH
            // 
            this.MAPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPH.DataPropertyName = "MAPH";
            this.MAPH.FillWeight = 200F;
            this.MAPH.HeaderText = "Mã phòng";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chb_loai);
            this.groupBox3.Controls.Add(this.chb_tang);
            this.groupBox3.Controls.Add(this.cbb_loai);
            this.groupBox3.Controls.Add(this.cbb_tang);
            this.groupBox3.Controls.Add(this.panel_ph);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(527, 223);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1111, 540);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phòng";
            // 
            // chb_loai
            // 
            this.chb_loai.AutoSize = true;
            this.chb_loai.Location = new System.Drawing.Point(429, 33);
            this.chb_loai.Name = "chb_loai";
            this.chb_loai.Size = new System.Drawing.Size(150, 30);
            this.chb_loai.TabIndex = 24;
            this.chb_loai.Text = "Loại phòng";
            this.chb_loai.UseVisualStyleBackColor = true;
            this.chb_loai.CheckedChanged += new System.EventHandler(this.chb_loai_CheckedChanged);
            // 
            // chb_tang
            // 
            this.chb_tang.AutoSize = true;
            this.chb_tang.Location = new System.Drawing.Point(50, 33);
            this.chb_tang.Name = "chb_tang";
            this.chb_tang.Size = new System.Drawing.Size(86, 30);
            this.chb_tang.TabIndex = 23;
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
            this.cbb_loai.Location = new System.Drawing.Point(585, 32);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(273, 33);
            this.cbb_loai.TabIndex = 22;
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
            this.cbb_tang.Location = new System.Drawing.Point(142, 32);
            this.cbb_tang.Name = "cbb_tang";
            this.cbb_tang.Size = new System.Drawing.Size(273, 33);
            this.cbb_tang.TabIndex = 21;
            // 
            // panel_ph
            // 
            this.panel_ph.BackColor = System.Drawing.Color.White;
            this.panel_ph.Location = new System.Drawing.Point(6, 71);
            this.panel_ph.Name = "panel_ph";
            this.panel_ph.Size = new System.Drawing.Size(1099, 463);
            this.panel_ph.TabIndex = 0;
            // 
            // timer_phieuthue
            // 
            this.timer_phieuthue.Enabled = true;
            this.timer_phieuthue.Tick += new System.EventHandler(this.timer_phieuthue_Tick);
            // 
            // frm_phieuthue
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_phieuthue";
            this.Size = new System.Drawing.Size(1641, 775);
            this.Load += new System.EventHandler(this.frm_phieuthue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxsl;
        private System.Windows.Forms.TextBox textBoxtiencoc;
        private System.Windows.Forms.TextBox textBoxmanhanvien;
        private System.Windows.Forms.TextBox textBoxmathuephong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.Panel panel_ph;
        private System.Windows.Forms.CheckBox chb_loai;
        private System.Windows.Forms.CheckBox chb_tang;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.ComboBox cbb_tang;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.DateTimePicker dtp_ngaytra;
        private System.Windows.Forms.DateTimePicker dtp_ngaydat;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Timer timer_phieuthue;
    }
}
