namespace Da.controller
{
    partial class Phieudichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phieudichvu));
            this.btn_lap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maph = new System.Windows.Forms.TextBox();
            this.txt_matp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_maphdv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_xemchitiet = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_phieudichvu = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSUDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maphieuthue = new System.Windows.Forms.TextBox();
            this.dgv_dsphieuthue = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudichvu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieuthue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_lap
            // 
            this.btn_lap.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btn_lap.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_lap.Appearance.Options.UseFont = true;
            this.btn_lap.Appearance.Options.UseForeColor = true;
            this.btn_lap.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_lap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_lap.ImageOptions.SvgImage")));
            this.btn_lap.Location = new System.Drawing.Point(6, 111);
            this.btn_lap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_lap.Name = "btn_lap";
            this.btn_lap.Size = new System.Drawing.Size(319, 60);
            this.btn_lap.TabIndex = 10;
            this.btn_lap.Text = "Lập hóa đơn dịch vụ";
            this.btn_lap.Click += new System.EventHandler(this.btn_lap_Click);
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.BackColor = System.Drawing.SystemColors.Control;
            this.txt_ngaylap.Enabled = false;
            this.txt_ngaylap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaylap.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ngaylap.Location = new System.Drawing.Point(647, 74);
            this.txt_ngaylap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(319, 30);
            this.txt_ngaylap.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(541, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày lập:";
            // 
            // txt_maph
            // 
            this.txt_maph.BackColor = System.Drawing.SystemColors.Control;
            this.txt_maph.Enabled = false;
            this.txt_maph.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maph.ForeColor = System.Drawing.Color.DimGray;
            this.txt_maph.Location = new System.Drawing.Point(647, 32);
            this.txt_maph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Size = new System.Drawing.Size(319, 30);
            this.txt_maph.TabIndex = 7;
            // 
            // txt_matp
            // 
            this.txt_matp.BackColor = System.Drawing.SystemColors.Control;
            this.txt_matp.Enabled = false;
            this.txt_matp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matp.ForeColor = System.Drawing.Color.DimGray;
            this.txt_matp.Location = new System.Drawing.Point(216, 73);
            this.txt_matp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_matp.Name = "txt_matp";
            this.txt_matp.Size = new System.Drawing.Size(319, 30);
            this.txt_matp.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(541, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(55, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã phiếu thuê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã phiếu dịch vụ:";
            // 
            // txt_maphdv
            // 
            this.txt_maphdv.BackColor = System.Drawing.SystemColors.Control;
            this.txt_maphdv.Enabled = false;
            this.txt_maphdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maphdv.ForeColor = System.Drawing.Color.DimGray;
            this.txt_maphdv.Location = new System.Drawing.Point(216, 34);
            this.txt_maphdv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maphdv.Name = "txt_maphdv";
            this.txt_maphdv.ReadOnly = true;
            this.txt_maphdv.Size = new System.Drawing.Size(319, 30);
            this.txt_maphdv.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_xemchitiet);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.dgv_phieudichvu);
            this.groupBox1.Controls.Add(this.btn_lap);
            this.groupBox1.Controls.Add(this.txt_matp);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_ngaylap);
            this.groupBox1.Controls.Add(this.txt_maphdv);
            this.groupBox1.Controls.Add(this.txt_maph);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(693, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 731);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu sử dụng dịch vụ";
            // 
            // btn_xemchitiet
            // 
            this.btn_xemchitiet.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.btn_xemchitiet.Appearance.Options.UseFont = true;
            this.btn_xemchitiet.Enabled = false;
            this.btn_xemchitiet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemchitiet.ImageOptions.Image")));
            this.btn_xemchitiet.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_xemchitiet.Location = new System.Drawing.Point(697, 112);
            this.btn_xemchitiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xemchitiet.Name = "btn_xemchitiet";
            this.btn_xemchitiet.Size = new System.Drawing.Size(319, 59);
            this.btn_xemchitiet.TabIndex = 11;
            this.btn_xemchitiet.Text = "Xem chi tiết hóa đơn";
            this.btn_xemchitiet.Click += new System.EventHandler(this.btn_xemchitiet_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(351, 112);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(319, 59);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Thêm chi tiết sử dụng";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // dgv_phieudichvu
            // 
            this.dgv_phieudichvu.AllowUserToAddRows = false;
            this.dgv_phieudichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phieudichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieudichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column6,
            this.MAPH,
            this.NGAYSUDUNG,
            this.Column5});
            this.dgv_phieudichvu.Location = new System.Drawing.Point(6, 179);
            this.dgv_phieudichvu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_phieudichvu.Name = "dgv_phieudichvu";
            this.dgv_phieudichvu.RowHeadersVisible = false;
            this.dgv_phieudichvu.RowHeadersWidth = 51;
            this.dgv_phieudichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phieudichvu.Size = new System.Drawing.Size(1010, 545);
            this.dgv_phieudichvu.TabIndex = 1;
            this.dgv_phieudichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieudichvu_CellContentClick);
            this.dgv_phieudichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieudichvu_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "MAHD_DICHVU";
            this.Column3.HeaderText = "Mã phiếu dịch vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "MATP";
            this.Column6.HeaderText = "Mã phiếu thuê";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // MAPH
            // 
            this.MAPH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAPH.DataPropertyName = "MAPH";
            this.MAPH.HeaderText = "Mã phòng";
            this.MAPH.MinimumWidth = 6;
            this.MAPH.Name = "MAPH";
            // 
            // NGAYSUDUNG
            // 
            this.NGAYSUDUNG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYSUDUNG.DataPropertyName = "NGAYSUDUNG";
            this.NGAYSUDUNG.HeaderText = "Ngày lập";
            this.NGAYSUDUNG.MinimumWidth = 6;
            this.NGAYSUDUNG.Name = "NGAYSUDUNG";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "TONGTIEN";
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_lammoi);
            this.groupBox2.Controls.Add(this.btn_timkiem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_maphieuthue);
            this.groupBox2.Controls.Add(this.dgv_dsphieuthue);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 731);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu thuê";
            // 
            // btn_lammoi
            // 
            this.btn_lammoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_lammoi.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_lammoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lammoi.Appearance.Options.UseBackColor = true;
            this.btn_lammoi.Appearance.Options.UseBorderColor = true;
            this.btn_lammoi.Appearance.Options.UseFont = true;
            this.btn_lammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lammoi.ImageOptions.Image")));
            this.btn_lammoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_lammoi.Location = new System.Drawing.Point(527, 20);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(150, 60);
            this.btn_lammoi.TabIndex = 48;
            this.btn_lammoi.Text = "Làm mới";
            this.btn_lammoi.UseWaitCursor = true;
            this.btn_lammoi.Click += new System.EventHandler(this.btn_lammoi_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_timkiem.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Appearance.Options.UseBackColor = true;
            this.btn_timkiem.Appearance.Options.UseBorderColor = true;
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_timkiem.ImageOptions.Image")));
            this.btn_timkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_timkiem.Location = new System.Drawing.Point(369, 20);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(150, 60);
            this.btn_timkiem.TabIndex = 46;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseWaitCursor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã phiếu thuê:";
            // 
            // txt_maphieuthue
            // 
            this.txt_maphieuthue.BackColor = System.Drawing.SystemColors.Control;
            this.txt_maphieuthue.Location = new System.Drawing.Point(148, 34);
            this.txt_maphieuthue.Name = "txt_maphieuthue";
            this.txt_maphieuthue.Size = new System.Drawing.Size(214, 30);
            this.txt_maphieuthue.TabIndex = 2;
            this.txt_maphieuthue.Click += new System.EventHandler(this.txt_maphieuthue_Click);
            // 
            // dgv_dsphieuthue
            // 
            this.dgv_dsphieuthue.AllowUserToAddRows = false;
            this.dgv_dsphieuthue.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dsphieuthue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsphieuthue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_dsphieuthue.Location = new System.Drawing.Point(3, 88);
            this.dgv_dsphieuthue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_dsphieuthue.Name = "dgv_dsphieuthue";
            this.dgv_dsphieuthue.RowHeadersVisible = false;
            this.dgv_dsphieuthue.RowHeadersWidth = 51;
            this.dgv_dsphieuthue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dsphieuthue.Size = new System.Drawing.Size(681, 636);
            this.dgv_dsphieuthue.TabIndex = 1;
            this.dgv_dsphieuthue.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsphieuthue_CellContentClick);
            this.dgv_dsphieuthue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsphieuthue_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MATP";
            this.Column1.HeaderText = "Mã phiếu thuê";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MAPH";
            this.Column2.HeaderText = "Mã phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Phieudichvu
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Phieudichvu";
            this.Size = new System.Drawing.Size(1720, 745);
            this.Load += new System.EventHandler(this.Phieudichvu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieudichvu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsphieuthue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_lap;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maph;
        private System.Windows.Forms.TextBox txt_matp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maphdv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_phieudichvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSUDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dsphieuthue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maphieuthue;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
        private DevExpress.XtraEditors.SimpleButton btn_xemchitiet;
    }
}
