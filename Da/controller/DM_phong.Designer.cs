namespace Da.controller
{
    partial class DM_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_phong));
            this.dgv_ph = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_giatheotang = new DevExpress.XtraEditors.TextEdit();
            this.btn_Suaphong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoaphong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themphong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maph = new DevExpress.XtraEditors.TextEdit();
            this.txt_vitri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.qL_KHACHSANDataSet = new Da.QL_KHACHSANDataSet();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new Da.QL_KHACHSANDataSetTableAdapters.PHONGTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLammoiloaiphong = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Sualoaiphong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoaloaiphong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Themloaiphong = new DevExpress.XtraEditors.SimpleButton();
            this.txt_ghichu = new DevExpress.XtraEditors.TextEdit();
            this.txt_gia = new DevExpress.XtraEditors.TextEdit();
            this.dgv_loaiph = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tenloai = new DevExpress.XtraEditors.TextEdit();
            this.txt_maloai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giatheotang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maph.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vitri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ph
            // 
            this.dgv_ph.AllowUserToAddRows = false;
            this.dgv_ph.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.colum1,
            this.Column1});
            this.dgv_ph.Location = new System.Drawing.Point(6, 325);
            this.dgv_ph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ph.Name = "dgv_ph";
            this.dgv_ph.RowHeadersVisible = false;
            this.dgv_ph.RowHeadersWidth = 51;
            this.dgv_ph.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ph.Size = new System.Drawing.Size(840, 377);
            this.dgv_ph.TabIndex = 5;
            this.dgv_ph.EditModeChanged += new System.EventHandler(this.DM_phong_Load);
            this.dgv_ph.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ph_CellContentClick);
            this.dgv_ph.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ph_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "MAPH";
            this.Column6.HeaderText = "Mã phòng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "VTPHONG";
            this.Column7.HeaderText = "Vị trí ( tầng )";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "TINHTRANG";
            this.Column8.HeaderText = "Tình trạng";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // colum1
            // 
            this.colum1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colum1.DataPropertyName = "GIAPHONG";
            this.colum1.HeaderText = "Giá theo tầng (VNĐ)";
            this.colum1.MinimumWidth = 6;
            this.colum1.Name = "colum1";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAI";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.cbb_tinhtrang);
            this.groupBox3.Controls.Add(this.txt_giatheotang);
            this.groupBox3.Controls.Add(this.btn_Suaphong);
            this.groupBox3.Controls.Add(this.btn_Xoaphong);
            this.groupBox3.Controls.Add(this.btn_Themphong);
            this.groupBox3.Controls.Add(this.dgv_ph);
            this.groupBox3.Controls.Add(this.labelControl8);
            this.groupBox3.Controls.Add(this.labelControl5);
            this.groupBox3.Controls.Add(this.txt_maph);
            this.groupBox3.Controls.Add(this.txt_vitri);
            this.groupBox3.Controls.Add(this.labelControl7);
            this.groupBox3.Controls.Add(this.labelControl6);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(873, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(855, 733);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phòng";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(244, 73);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(534, 2);
            this.panel7.TabIndex = 243;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(244, 118);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(534, 2);
            this.panel6.TabIndex = 243;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(244, 218);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(534, 2);
            this.panel5.TabIndex = 243;
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.BackColor = System.Drawing.Color.LightBlue;
            this.cbb_tinhtrang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_tinhtrang.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Items.AddRange(new object[] {
            "Trống",
            "Đang sử dụng",
            "Được đặt",
            "Đang dọn dẹp",
            "Sửa chữa"});
            this.cbb_tinhtrang.Location = new System.Drawing.Point(244, 138);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(534, 33);
            this.cbb_tinhtrang.TabIndex = 56;
            // 
            // txt_giatheotang
            // 
            this.txt_giatheotang.Enabled = false;
            this.txt_giatheotang.Location = new System.Drawing.Point(244, 188);
            this.txt_giatheotang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_giatheotang.Name = "txt_giatheotang";
            this.txt_giatheotang.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_giatheotang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giatheotang.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_giatheotang.Properties.Appearance.Options.UseBackColor = true;
            this.txt_giatheotang.Properties.Appearance.Options.UseFont = true;
            this.txt_giatheotang.Properties.Appearance.Options.UseForeColor = true;
            this.txt_giatheotang.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_giatheotang.Size = new System.Drawing.Size(534, 30);
            this.txt_giatheotang.TabIndex = 55;
            // 
            // btn_Suaphong
            // 
            this.btn_Suaphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Suaphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suaphong.Appearance.Options.UseBackColor = true;
            this.btn_Suaphong.Appearance.Options.UseBorderColor = true;
            this.btn_Suaphong.Appearance.Options.UseFont = true;
            this.btn_Suaphong.Enabled = false;
            this.btn_Suaphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suaphong.ImageOptions.Image")));
            this.btn_Suaphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Suaphong.Location = new System.Drawing.Point(634, 238);
            this.btn_Suaphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Suaphong.Name = "btn_Suaphong";
            this.btn_Suaphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Suaphong.TabIndex = 54;
            this.btn_Suaphong.Text = "Cập nhật";
            this.btn_Suaphong.Click += new System.EventHandler(this.btn_Suaphong_Click);
            // 
            // btn_Xoaphong
            // 
            this.btn_Xoaphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoaphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoaphong.Appearance.Options.UseBackColor = true;
            this.btn_Xoaphong.Appearance.Options.UseBorderColor = true;
            this.btn_Xoaphong.Appearance.Options.UseFont = true;
            this.btn_Xoaphong.Enabled = false;
            this.btn_Xoaphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoaphong.ImageOptions.Image")));
            this.btn_Xoaphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Xoaphong.Location = new System.Drawing.Point(482, 238);
            this.btn_Xoaphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoaphong.Name = "btn_Xoaphong";
            this.btn_Xoaphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Xoaphong.TabIndex = 53;
            this.btn_Xoaphong.Text = "Xóa";
            this.btn_Xoaphong.Click += new System.EventHandler(this.btn_Xoaphong_Click);
            // 
            // btn_Themphong
            // 
            this.btn_Themphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Themphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themphong.Appearance.Options.UseBackColor = true;
            this.btn_Themphong.Appearance.Options.UseBorderColor = true;
            this.btn_Themphong.Appearance.Options.UseFont = true;
            this.btn_Themphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themphong.ImageOptions.Image")));
            this.btn_Themphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Themphong.Location = new System.Drawing.Point(330, 238);
            this.btn_Themphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Themphong.Name = "btn_Themphong";
            this.btn_Themphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Themphong.TabIndex = 52;
            this.btn_Themphong.Text = "Thêm";
            this.btn_Themphong.Click += new System.EventHandler(this.btn_Themphong_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(92, 44);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(114, 25);
            this.labelControl8.TabIndex = 4;
            this.labelControl8.Text = "Mã Phòng:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(92, 191);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(146, 26);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Giá theo tầng:";
            // 
            // txt_maph
            // 
            this.txt_maph.Enabled = false;
            this.txt_maph.Location = new System.Drawing.Point(244, 43);
            this.txt_maph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maph.Name = "txt_maph";
            this.txt_maph.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_maph.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maph.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_maph.Properties.Appearance.Options.UseBackColor = true;
            this.txt_maph.Properties.Appearance.Options.UseFont = true;
            this.txt_maph.Properties.Appearance.Options.UseForeColor = true;
            this.txt_maph.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_maph.Size = new System.Drawing.Size(534, 30);
            this.txt_maph.TabIndex = 16;
            // 
            // txt_vitri
            // 
            this.txt_vitri.Enabled = false;
            this.txt_vitri.Location = new System.Drawing.Point(247, 90);
            this.txt_vitri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_vitri.Name = "txt_vitri";
            this.txt_vitri.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_vitri.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vitri.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_vitri.Properties.Appearance.Options.UseBackColor = true;
            this.txt_vitri.Properties.Appearance.Options.UseFont = true;
            this.txt_vitri.Properties.Appearance.Options.UseForeColor = true;
            this.txt_vitri.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_vitri.Size = new System.Drawing.Size(534, 30);
            this.txt_vitri.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(92, 91);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 26);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Vị trí:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(92, 141);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(118, 26);
            this.labelControl6.TabIndex = 6;
            this.labelControl6.Text = "Tình trạng:";
            // 
            // qL_KHACHSANDataSet
            // 
            this.qL_KHACHSANDataSet.DataSetName = "QL_KHACHSANDataSet";
            this.qL_KHACHSANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.qL_KHACHSANDataSet;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnLammoiloaiphong);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btn_Sualoaiphong);
            this.groupBox1.Controls.Add(this.btn_Xoaloaiphong);
            this.groupBox1.Controls.Add(this.btn_Themloaiphong);
            this.groupBox1.Controls.Add(this.txt_ghichu);
            this.groupBox1.Controls.Add(this.txt_gia);
            this.groupBox1.Controls.Add(this.dgv_loaiph);
            this.groupBox1.Controls.Add(this.txt_tenloai);
            this.groupBox1.Controls.Add(this.txt_maloai);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(864, 732);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại phòng";
            // 
            // btnLammoiloaiphong
            // 
            this.btnLammoiloaiphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnLammoiloaiphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoiloaiphong.Appearance.Options.UseBackColor = true;
            this.btnLammoiloaiphong.Appearance.Options.UseBorderColor = true;
            this.btnLammoiloaiphong.Appearance.Options.UseFont = true;
            this.btnLammoiloaiphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiloaiphong.ImageOptions.Image")));
            this.btnLammoiloaiphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLammoiloaiphong.Location = new System.Drawing.Point(155, 237);
            this.btnLammoiloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnLammoiloaiphong.Name = "btnLammoiloaiphong";
            this.btnLammoiloaiphong.Size = new System.Drawing.Size(144, 60);
            this.btnLammoiloaiphong.TabIndex = 244;
            this.btnLammoiloaiphong.Text = "Làm mới";
            this.btnLammoiloaiphong.Click += new System.EventHandler(this.btnLammoiloaiphong_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(179, 67);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 2);
            this.panel4.TabIndex = 243;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(179, 119);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 2);
            this.panel3.TabIndex = 243;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(179, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 2);
            this.panel1.TabIndex = 242;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(179, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 2);
            this.panel2.TabIndex = 242;
            // 
            // btn_Sualoaiphong
            // 
            this.btn_Sualoaiphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Sualoaiphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sualoaiphong.Appearance.Options.UseBackColor = true;
            this.btn_Sualoaiphong.Appearance.Options.UseBorderColor = true;
            this.btn_Sualoaiphong.Appearance.Options.UseFont = true;
            this.btn_Sualoaiphong.Enabled = false;
            this.btn_Sualoaiphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sualoaiphong.ImageOptions.Image")));
            this.btn_Sualoaiphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Sualoaiphong.Location = new System.Drawing.Point(611, 237);
            this.btn_Sualoaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sualoaiphong.Name = "btn_Sualoaiphong";
            this.btn_Sualoaiphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Sualoaiphong.TabIndex = 54;
            this.btn_Sualoaiphong.Text = "Cập nhật";
            this.btn_Sualoaiphong.Click += new System.EventHandler(this.btn_Sualoaiphong_Click);
            // 
            // btn_Xoaloaiphong
            // 
            this.btn_Xoaloaiphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Xoaloaiphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoaloaiphong.Appearance.Options.UseBackColor = true;
            this.btn_Xoaloaiphong.Appearance.Options.UseBorderColor = true;
            this.btn_Xoaloaiphong.Appearance.Options.UseFont = true;
            this.btn_Xoaloaiphong.Enabled = false;
            this.btn_Xoaloaiphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoaloaiphong.ImageOptions.Image")));
            this.btn_Xoaloaiphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Xoaloaiphong.Location = new System.Drawing.Point(459, 237);
            this.btn_Xoaloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoaloaiphong.Name = "btn_Xoaloaiphong";
            this.btn_Xoaloaiphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Xoaloaiphong.TabIndex = 53;
            this.btn_Xoaloaiphong.Text = "Xóa";
            this.btn_Xoaloaiphong.Click += new System.EventHandler(this.btn_Xoaloaiphong_Click);
            // 
            // btn_Themloaiphong
            // 
            this.btn_Themloaiphong.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Themloaiphong.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Themloaiphong.Appearance.Options.UseBackColor = true;
            this.btn_Themloaiphong.Appearance.Options.UseBorderColor = true;
            this.btn_Themloaiphong.Appearance.Options.UseFont = true;
            this.btn_Themloaiphong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Themloaiphong.ImageOptions.Image")));
            this.btn_Themloaiphong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_Themloaiphong.Location = new System.Drawing.Point(307, 237);
            this.btn_Themloaiphong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Themloaiphong.Name = "btn_Themloaiphong";
            this.btn_Themloaiphong.Size = new System.Drawing.Size(144, 60);
            this.btn_Themloaiphong.TabIndex = 52;
            this.btn_Themloaiphong.Text = "Thêm";
            this.btn_Themloaiphong.Click += new System.EventHandler(this.btn_Themloaiphong_Click);
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(179, 187);
            this.txt_ghichu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_ghichu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ghichu.Properties.Appearance.Options.UseBackColor = true;
            this.txt_ghichu.Properties.Appearance.Options.UseFont = true;
            this.txt_ghichu.Properties.Appearance.Options.UseForeColor = true;
            this.txt_ghichu.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_ghichu.Size = new System.Drawing.Size(588, 30);
            this.txt_ghichu.TabIndex = 15;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(179, 137);
            this.txt_gia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_gia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_gia.Properties.Appearance.Options.UseBackColor = true;
            this.txt_gia.Properties.Appearance.Options.UseFont = true;
            this.txt_gia.Properties.Appearance.Options.UseForeColor = true;
            this.txt_gia.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_gia.Size = new System.Drawing.Size(588, 30);
            this.txt_gia.TabIndex = 14;
            this.txt_gia.TextChanged += new System.EventHandler(this.txt_gia_TextChanged);
            this.txt_gia.Click += new System.EventHandler(this.txt_gia_Click);
            // 
            // dgv_loaiph
            // 
            this.dgv_loaiph.AllowUserToAddRows = false;
            this.dgv_loaiph.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiph.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiph.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_loaiph.Location = new System.Drawing.Point(2, 324);
            this.dgv_loaiph.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_loaiph.Name = "dgv_loaiph";
            this.dgv_loaiph.RowHeadersVisible = false;
            this.dgv_loaiph.RowHeadersWidth = 51;
            this.dgv_loaiph.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiph.Size = new System.Drawing.Size(855, 377);
            this.dgv_loaiph.TabIndex = 0;
            this.dgv_loaiph.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiph_CellClick);
            this.dgv_loaiph.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_loaiph_CellClick);
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MALOAI";
            this.Column2.HeaderText = "Mã loại phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "TENLOAI";
            this.Column3.HeaderText = "Tên loại phòng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "GIAPH";
            this.Column4.HeaderText = "Giá ( VNĐ )";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "GHICHU";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(179, 89);
            this.txt_tenloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_tenloai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenloai.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenloai.Properties.Appearance.Options.UseBackColor = true;
            this.txt_tenloai.Properties.Appearance.Options.UseFont = true;
            this.txt_tenloai.Properties.Appearance.Options.UseForeColor = true;
            this.txt_tenloai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_tenloai.Size = new System.Drawing.Size(588, 30);
            this.txt_tenloai.TabIndex = 13;
            // 
            // txt_maloai
            // 
            this.txt_maloai.Enabled = false;
            this.txt_maloai.Location = new System.Drawing.Point(179, 37);
            this.txt_maloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_maloai.Name = "txt_maloai";
            this.txt_maloai.Properties.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.txt_maloai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maloai.Properties.Appearance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_maloai.Properties.Appearance.Options.UseBackColor = true;
            this.txt_maloai.Properties.Appearance.Options.UseFont = true;
            this.txt_maloai.Properties.Appearance.Options.UseForeColor = true;
            this.txt_maloai.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.txt_maloai.Size = new System.Drawing.Size(588, 30);
            this.txt_maloai.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(80, 190);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(87, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Ghi chú:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 140);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Giá:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 26);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên loại:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(80, 40);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 26);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã loại:";
            // 
            // DM_phong
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "DM_phong";
            this.Size = new System.Drawing.Size(1743, 741);
            this.Load += new System.EventHandler(this.DM_phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ph)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giatheotang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maph.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vitri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_KHACHSANDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ghichu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tenloai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maloai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ph;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QL_KHACHSANDataSet qL_KHACHSANDataSet;
        private QL_KHACHSANDataSetTableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btn_Xoaphong;
        private DevExpress.XtraEditors.SimpleButton btn_Themphong;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_Sualoaiphong;
        private DevExpress.XtraEditors.SimpleButton btn_Xoaloaiphong;
        private DevExpress.XtraEditors.SimpleButton btn_Themloaiphong;
        private DevExpress.XtraEditors.TextEdit txt_ghichu;
        private DevExpress.XtraEditors.TextEdit txt_gia;
        private System.Windows.Forms.DataGridView dgv_loaiph;
        private DevExpress.XtraEditors.TextEdit txt_tenloai;
        private DevExpress.XtraEditors.TextEdit txt_maloai;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevExpress.XtraEditors.TextEdit txt_giatheotang;
        private DevExpress.XtraEditors.TextEdit txt_vitri;
        private DevExpress.XtraEditors.TextEdit txt_maph;
        private System.Windows.Forms.ComboBox cbb_tinhtrang;
        private DevExpress.XtraEditors.SimpleButton btn_Suaphong;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnLammoiloaiphong;
    }
}
