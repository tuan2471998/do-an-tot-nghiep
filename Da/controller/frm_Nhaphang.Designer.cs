namespace Da.controller
{
    partial class frm_Nhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nhaphang));
            this.groupBox_bangnhaphang = new System.Windows.Forms.GroupBox();
            this.dgv_nhaphang = new System.Windows.Forms.DataGridView();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_ngaynhap = new System.Windows.Forms.Label();
            this.tungay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_loainhap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenhang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_loaihang = new System.Windows.Forms.ComboBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.txt_nhanvien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_diachincc = new System.Windows.Forms.TextBox();
            this.groupBox_thongtinnhaphang = new System.Windows.Forms.GroupBox();
            this.btn_nhaphang = new DevExpress.XtraEditors.SimpleButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sdtncc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_bangnhaphang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).BeginInit();
            this.groupBox_thongtinnhaphang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_bangnhaphang
            // 
            this.groupBox_bangnhaphang.Controls.Add(this.dgv_nhaphang);
            this.groupBox_bangnhaphang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_bangnhaphang.Location = new System.Drawing.Point(4, 315);
            this.groupBox_bangnhaphang.Name = "groupBox_bangnhaphang";
            this.groupBox_bangnhaphang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_bangnhaphang.Size = new System.Drawing.Size(1955, 427);
            this.groupBox_bangnhaphang.TabIndex = 2;
            this.groupBox_bangnhaphang.TabStop = false;
            this.groupBox_bangnhaphang.Text = "Quản lý nhập hàng";
            // 
            // dgv_nhaphang
            // 
            this.dgv_nhaphang.AllowUserToAddRows = false;
            this.dgv_nhaphang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NGAYNHAP,
            this.Column1,
            this.Column2,
            this.Nhanvien,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgv_nhaphang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhaphang.Location = new System.Drawing.Point(3, 30);
            this.dgv_nhaphang.Name = "dgv_nhaphang";
            this.dgv_nhaphang.RowHeadersVisible = false;
            this.dgv_nhaphang.RowHeadersWidth = 51;
            this.dgv_nhaphang.RowTemplate.Height = 24;
            this.dgv_nhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhaphang.Size = new System.Drawing.Size(1949, 394);
            this.dgv_nhaphang.TabIndex = 0;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYNHAP.HeaderText = "Ngày Nhập";
            this.NGAYNHAP.MinimumWidth = 6;
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Hàng Nhập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Loại Hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Nhanvien
            // 
            this.Nhanvien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nhanvien.HeaderText = "Nhân Viên";
            this.Nhanvien.MinimumWidth = 6;
            this.Nhanvien.Name = "Nhanvien";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Tên Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Đơn Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Số lượng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Thành Tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Ghi Chú";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // label_ngaynhap
            // 
            this.label_ngaynhap.AutoSize = true;
            this.label_ngaynhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngaynhap.Location = new System.Drawing.Point(31, 39);
            this.label_ngaynhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ngaynhap.Name = "label_ngaynhap";
            this.label_ngaynhap.Size = new System.Drawing.Size(130, 26);
            this.label_ngaynhap.TabIndex = 0;
            this.label_ngaynhap.Text = "Ngày nhập:";
            // 
            // tungay
            // 
            this.tungay.CustomFormat = "dd/MM/yyyy";
            this.tungay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tungay.Location = new System.Drawing.Point(176, 36);
            this.tungay.Margin = new System.Windows.Forms.Padding(4);
            this.tungay.Name = "tungay";
            this.tungay.Size = new System.Drawing.Size(280, 34);
            this.tungay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1506, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tổng tiền phiếu nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 240;
            this.label1.Text = "Hàng nhập:";
            // 
            // cbb_loainhap
            // 
            this.cbb_loainhap.BackColor = System.Drawing.Color.White;
            this.cbb_loainhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loainhap.FormattingEnabled = true;
            this.cbb_loainhap.Location = new System.Drawing.Point(173, 100);
            this.cbb_loainhap.Name = "cbb_loainhap";
            this.cbb_loainhap.Size = new System.Drawing.Size(283, 33);
            this.cbb_loainhap.TabIndex = 243;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 26);
            this.label4.TabIndex = 244;
            this.label4.Text = "Tên hàng:";
            // 
            // txt_tenhang
            // 
            this.txt_tenhang.BackColor = System.Drawing.Color.LightBlue;
            this.txt_tenhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tenhang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenhang.Location = new System.Drawing.Point(701, 226);
            this.txt_tenhang.Name = "txt_tenhang";
            this.txt_tenhang.Size = new System.Drawing.Size(280, 27);
            this.txt_tenhang.TabIndex = 251;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 26);
            this.label5.TabIndex = 247;
            this.label5.Text = "Loại hàng:";
            // 
            // cbb_loaihang
            // 
            this.cbb_loaihang.BackColor = System.Drawing.Color.White;
            this.cbb_loaihang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_loaihang.FormattingEnabled = true;
            this.cbb_loaihang.Location = new System.Drawing.Point(173, 166);
            this.cbb_loaihang.Name = "cbb_loaihang";
            this.cbb_loaihang.Size = new System.Drawing.Size(284, 33);
            this.cbb_loaihang.TabIndex = 249;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.LightBlue;
            this.txt_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(1636, 85);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(280, 27);
            this.txt_tongtien.TabIndex = 260;
            // 
            // txt_nhanvien
            // 
            this.txt_nhanvien.BackColor = System.Drawing.Color.LightBlue;
            this.txt_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nhanvien.Enabled = false;
            this.txt_nhanvien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhanvien.Location = new System.Drawing.Point(177, 230);
            this.txt_nhanvien.Name = "txt_nhanvien";
            this.txt_nhanvien.ReadOnly = true;
            this.txt_nhanvien.Size = new System.Drawing.Size(280, 27);
            this.txt_nhanvien.TabIndex = 261;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(526, 39);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 26);
            this.label10.TabIndex = 262;
            this.label10.Text = "Nhà cung cấp:";
            // 
            // cbb_nhacungcap
            // 
            this.cbb_nhacungcap.BackColor = System.Drawing.Color.White;
            this.cbb_nhacungcap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_nhacungcap.FormattingEnabled = true;
            this.cbb_nhacungcap.Location = new System.Drawing.Point(704, 38);
            this.cbb_nhacungcap.Name = "cbb_nhacungcap";
            this.cbb_nhacungcap.Size = new System.Drawing.Size(277, 33);
            this.cbb_nhacungcap.TabIndex = 263;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(526, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 26);
            this.label11.TabIndex = 264;
            this.label11.Text = "Địa chỉ:";
            // 
            // txt_diachincc
            // 
            this.txt_diachincc.BackColor = System.Drawing.Color.LightBlue;
            this.txt_diachincc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_diachincc.Enabled = false;
            this.txt_diachincc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diachincc.Location = new System.Drawing.Point(704, 99);
            this.txt_diachincc.Name = "txt_diachincc";
            this.txt_diachincc.ReadOnly = true;
            this.txt_diachincc.Size = new System.Drawing.Size(280, 27);
            this.txt_diachincc.TabIndex = 265;
            // 
            // groupBox_thongtinnhaphang
            // 
            this.groupBox_thongtinnhaphang.Controls.Add(this.btn_nhaphang);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel9);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel8);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel7);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel6);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel5);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel4);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel3);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel2);
            this.groupBox_thongtinnhaphang.Controls.Add(this.panel1);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_sdtncc);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label12);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_diachincc);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label11);
            this.groupBox_thongtinnhaphang.Controls.Add(this.cbb_nhacungcap);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label10);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_nhanvien);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_tongtien);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_ghichu);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label9);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_thanhtien);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label8);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_soluong);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label7);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_dongia);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label6);
            this.groupBox_thongtinnhaphang.Controls.Add(this.cbb_loaihang);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label5);
            this.groupBox_thongtinnhaphang.Controls.Add(this.txt_tenhang);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label4);
            this.groupBox_thongtinnhaphang.Controls.Add(this.cbb_loainhap);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label1);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label3);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label2);
            this.groupBox_thongtinnhaphang.Controls.Add(this.tungay);
            this.groupBox_thongtinnhaphang.Controls.Add(this.label_ngaynhap);
            this.groupBox_thongtinnhaphang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_thongtinnhaphang.Location = new System.Drawing.Point(4, 16);
            this.groupBox_thongtinnhaphang.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_thongtinnhaphang.Name = "groupBox_thongtinnhaphang";
            this.groupBox_thongtinnhaphang.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_thongtinnhaphang.Size = new System.Drawing.Size(1954, 292);
            this.groupBox_thongtinnhaphang.TabIndex = 1;
            this.groupBox_thongtinnhaphang.TabStop = false;
            this.groupBox_thongtinnhaphang.Text = "Thông tin";
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.Appearance.Options.UseFont = true;
            this.btn_nhaphang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaphang.ImageOptions.Image")));
            this.btn_nhaphang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_nhaphang.Location = new System.Drawing.Point(1511, 192);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(209, 61);
            this.btn_nhaphang.TabIndex = 270;
            this.btn_nhaphang.Text = "Nhập hàng";
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(1636, 125);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(280, 2);
            this.panel9.TabIndex = 269;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(1171, 269);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 2);
            this.panel8.TabIndex = 269;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(1171, 212);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 2);
            this.panel7.TabIndex = 269;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(1171, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 2);
            this.panel6.TabIndex = 269;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(1171, 85);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 2);
            this.panel5.TabIndex = 269;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(704, 266);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 2);
            this.panel4.TabIndex = 269;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(704, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 2);
            this.panel3.TabIndex = 269;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(704, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 2);
            this.panel2.TabIndex = 269;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(177, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 2);
            this.panel1.TabIndex = 268;
            // 
            // txt_sdtncc
            // 
            this.txt_sdtncc.BackColor = System.Drawing.Color.LightBlue;
            this.txt_sdtncc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sdtncc.Enabled = false;
            this.txt_sdtncc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdtncc.Location = new System.Drawing.Point(704, 165);
            this.txt_sdtncc.Name = "txt_sdtncc";
            this.txt_sdtncc.ReadOnly = true;
            this.txt_sdtncc.Size = new System.Drawing.Size(280, 27);
            this.txt_sdtncc.TabIndex = 267;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(526, 164);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 26);
            this.label12.TabIndex = 266;
            this.label12.Text = "Số điện thoại:";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.BackColor = System.Drawing.Color.LightBlue;
            this.txt_ghichu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ghichu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(1171, 229);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(280, 27);
            this.txt_ghichu.TabIndex = 254;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1026, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 26);
            this.label9.TabIndex = 256;
            this.label9.Text = "Ghi chú:";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.BackColor = System.Drawing.Color.LightBlue;
            this.txt_thanhtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Location = new System.Drawing.Point(1171, 168);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(280, 27);
            this.txt_thanhtien.TabIndex = 255;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1024, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 26);
            this.label8.TabIndex = 253;
            this.label8.Text = "Thành tiền:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.LightBlue;
            this.txt_soluong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_soluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(1171, 99);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(280, 27);
            this.txt_soluong.TabIndex = 253;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1026, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 26);
            this.label7.TabIndex = 247;
            this.label7.Text = "Số lượng:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.BackColor = System.Drawing.Color.LightBlue;
            this.txt_dongia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dongia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.Location = new System.Drawing.Point(1171, 43);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(280, 27);
            this.txt_dongia.TabIndex = 252;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1024, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 250;
            this.label6.Text = "Đơn giá:";
            // 
            // frm_Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.groupBox_bangnhaphang);
            this.Controls.Add(this.groupBox_thongtinnhaphang);
            this.Name = "frm_Nhaphang";
            this.Size = new System.Drawing.Size(1962, 745);
            this.groupBox_bangnhaphang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).EndInit();
            this.groupBox_thongtinnhaphang.ResumeLayout(false);
            this.groupBox_thongtinnhaphang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_bangnhaphang;
        private System.Windows.Forms.DataGridView dgv_nhaphang;
        private System.Windows.Forms.Label label_ngaynhap;
        private System.Windows.Forms.DateTimePicker tungay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_loainhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenhang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_loaihang;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.TextBox txt_nhanvien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbb_nhacungcap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_diachincc;
        private System.Windows.Forms.GroupBox groupBox_thongtinnhaphang;
        private System.Windows.Forms.TextBox txt_sdtncc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevExpress.XtraEditors.SimpleButton btn_nhaphang;
    }
}
