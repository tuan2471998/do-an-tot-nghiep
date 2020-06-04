namespace Da.controller
{
    partial class DM_khachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_khachhang));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datakhachhang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupThongTinKhachHang = new DevExpress.XtraEditors.GroupControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_lammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtquoctich = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtcmnd = new System.Windows.Forms.TextBox();
            this.txttenkh = new System.Windows.Forms.TextBox();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).BeginInit();
            this.groupThongTinKhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.datakhachhang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupThongTinKhachHang, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1590, 680);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // datakhachhang
            // 
            this.datakhachhang.AllowUserToAddRows = false;
            this.datakhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datakhachhang.BackgroundColor = System.Drawing.Color.White;
            this.datakhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datakhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.datakhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datakhachhang.Location = new System.Drawing.Point(4, 208);
            this.datakhachhang.Margin = new System.Windows.Forms.Padding(4);
            this.datakhachhang.Name = "datakhachhang";
            this.datakhachhang.RowHeadersVisible = false;
            this.datakhachhang.RowHeadersWidth = 51;
            this.datakhachhang.RowTemplate.Height = 24;
            this.datakhachhang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datakhachhang.Size = new System.Drawing.Size(1582, 468);
            this.datakhachhang.TabIndex = 48;
            this.datakhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakhachhang_CellContentClick);
            this.datakhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datakhachhang_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAKH";
            this.Column1.HeaderText = "Mã khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HOTEN";
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOCMND";
            this.Column3.HeaderText = "Căn cước/CMND";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Sô điện thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "QUOCTICH";
            this.Column5.HeaderText = "Quốc tịch";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // groupThongTinKhachHang
            // 
            this.groupThongTinKhachHang.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.groupThongTinKhachHang.Appearance.Options.UseBackColor = true;
            this.groupThongTinKhachHang.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTinKhachHang.AppearanceCaption.Options.UseFont = true;
            this.groupThongTinKhachHang.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupThongTinKhachHang.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupThongTinKhachHang.Controls.Add(this.panel5);
            this.groupThongTinKhachHang.Controls.Add(this.panel3);
            this.groupThongTinKhachHang.Controls.Add(this.panel2);
            this.groupThongTinKhachHang.Controls.Add(this.panel1);
            this.groupThongTinKhachHang.Controls.Add(this.panel4);
            this.groupThongTinKhachHang.Controls.Add(this.btn_lammoi);
            this.groupThongTinKhachHang.Controls.Add(this.btn_timkiem);
            this.groupThongTinKhachHang.Controls.Add(this.txtquoctich);
            this.groupThongTinKhachHang.Controls.Add(this.txtsdt);
            this.groupThongTinKhachHang.Controls.Add(this.txtcmnd);
            this.groupThongTinKhachHang.Controls.Add(this.txttenkh);
            this.groupThongTinKhachHang.Controls.Add(this.txtmkh);
            this.groupThongTinKhachHang.Controls.Add(this.btnXoa);
            this.groupThongTinKhachHang.Controls.Add(this.btn_them);
            this.groupThongTinKhachHang.Controls.Add(this.btnSua);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl5);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl3);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl6);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl2);
            this.groupThongTinKhachHang.Controls.Add(this.labelControl1);
            this.groupThongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupThongTinKhachHang.Location = new System.Drawing.Point(4, 5);
            this.groupThongTinKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupThongTinKhachHang.Name = "groupThongTinKhachHang";
            this.groupThongTinKhachHang.Size = new System.Drawing.Size(1582, 194);
            this.groupThongTinKhachHang.TabIndex = 42;
            this.groupThongTinKhachHang.Text = "Thông tin";
            this.groupThongTinKhachHang.UseWaitCursor = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(1240, 55);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 2);
            this.panel5.TabIndex = 242;
            this.panel5.UseWaitCursor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(747, 57);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 2);
            this.panel3.TabIndex = 241;
            this.panel3.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(747, 102);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 2);
            this.panel2.TabIndex = 240;
            this.panel2.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(245, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 2);
            this.panel1.TabIndex = 239;
            this.panel1.UseWaitCursor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(245, 55);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 2);
            this.panel4.TabIndex = 238;
            this.panel4.UseWaitCursor = true;
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
            this.btn_lammoi.Location = new System.Drawing.Point(286, 120);
            this.btn_lammoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lammoi.Name = "btn_lammoi";
            this.btn_lammoi.Size = new System.Drawing.Size(308, 60);
            this.btn_lammoi.TabIndex = 47;
            this.btn_lammoi.Text = "Làm mới danh sách";
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
            this.btn_timkiem.Location = new System.Drawing.Point(1338, 120);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(150, 60);
            this.btn_timkiem.TabIndex = 45;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseWaitCursor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txtquoctich
            // 
            this.txtquoctich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtquoctich.BackColor = System.Drawing.Color.LightBlue;
            this.txtquoctich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquoctich.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquoctich.ForeColor = System.Drawing.Color.DimGray;
            this.txtquoctich.Location = new System.Drawing.Point(1240, 25);
            this.txtquoctich.Margin = new System.Windows.Forms.Padding(4);
            this.txtquoctich.Name = "txtquoctich";
            this.txtquoctich.Size = new System.Drawing.Size(258, 27);
            this.txtquoctich.TabIndex = 44;
            this.txtquoctich.UseWaitCursor = true;
            // 
            // txtsdt
            // 
            this.txtsdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsdt.BackColor = System.Drawing.Color.LightBlue;
            this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.ForeColor = System.Drawing.Color.DimGray;
            this.txtsdt.Location = new System.Drawing.Point(747, 27);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(258, 27);
            this.txtsdt.TabIndex = 43;
            this.txtsdt.UseWaitCursor = true;
            this.txtsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txtcmnd
            // 
            this.txtcmnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcmnd.BackColor = System.Drawing.Color.LightBlue;
            this.txtcmnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcmnd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcmnd.ForeColor = System.Drawing.Color.DimGray;
            this.txtcmnd.Location = new System.Drawing.Point(747, 76);
            this.txtcmnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtcmnd.Name = "txtcmnd";
            this.txtcmnd.Size = new System.Drawing.Size(258, 27);
            this.txtcmnd.TabIndex = 42;
            this.txtcmnd.UseWaitCursor = true;
            this.txtcmnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsdt_KeyPress);
            // 
            // txttenkh
            // 
            this.txttenkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttenkh.BackColor = System.Drawing.Color.LightBlue;
            this.txttenkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttenkh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttenkh.ForeColor = System.Drawing.Color.DimGray;
            this.txttenkh.Location = new System.Drawing.Point(245, 77);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.Size = new System.Drawing.Size(258, 27);
            this.txttenkh.TabIndex = 41;
            this.txttenkh.UseWaitCursor = true;
            // 
            // txtmkh
            // 
            this.txtmkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmkh.BackColor = System.Drawing.Color.LightBlue;
            this.txtmkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmkh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkh.ForeColor = System.Drawing.Color.DimGray;
            this.txtmkh.Location = new System.Drawing.Point(245, 24);
            this.txtmkh.Margin = new System.Windows.Forms.Padding(4);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(258, 27);
            this.txtmkh.TabIndex = 40;
            this.txtmkh.UseWaitCursor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseBorderColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(911, 119);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(150, 60);
            this.btnXoa.TabIndex = 37;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseWaitCursor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_them.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btn_them.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Appearance.Options.UseBackColor = true;
            this.btn_them.Appearance.Options.UseBorderColor = true;
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.ImageOptions.Image")));
            this.btn_them.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_them.Location = new System.Drawing.Point(1133, 119);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(150, 60);
            this.btn_them.TabIndex = 38;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseWaitCursor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseBorderColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Enabled = false;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(682, 119);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(150, 60);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.UseWaitCursor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 26);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(166, 25);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Mã khách hàng:";
            this.labelControl5.UseWaitCursor = true;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1087, 28);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(115, 26);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Quốc Tịch:";
            this.labelControl3.UseWaitCursor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(603, 26);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(141, 26);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Số điện thoại:";
            this.labelControl6.UseWaitCursor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(49, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(169, 25);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Tên khách hàng:";
            this.labelControl2.UseWaitCursor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(553, 77);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(186, 26);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Căn cước/CMND:";
            this.labelControl1.UseWaitCursor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // DM_khachhang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DM_khachhang";
            this.Size = new System.Drawing.Size(1590, 680);
            this.Load += new System.EventHandler(this.DM_khachhang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datakhachhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTinKhachHang)).EndInit();
            this.groupThongTinKhachHang.ResumeLayout(false);
            this.groupThongTinKhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private DevExpress.XtraEditors.GroupControl groupThongTinKhachHang;
        private DevExpress.XtraEditors.SimpleButton btn_lammoi;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private System.Windows.Forms.TextBox txtquoctich;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtcmnd;
        private System.Windows.Forms.TextBox txttenkh;
        private System.Windows.Forms.TextBox txtmkh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView datakhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}
