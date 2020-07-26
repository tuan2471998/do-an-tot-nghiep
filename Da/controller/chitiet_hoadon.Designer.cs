namespace Da.controller
{
    partial class chitiet_hoadon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgv_phong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tienthe = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_tienmat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_tienthucdon = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tienphuthu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_tiencoc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tiendichvu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tienphong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_ngayra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txt_ngayvao = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_khachhang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 274);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1282, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_phong);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1274, 316);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_phong
            // 
            this.dgv_phong.AllowUserToAddRows = false;
            this.dgv_phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv_phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phong.Location = new System.Drawing.Point(3, 3);
            this.dgv_phong.Name = "dgv_phong";
            this.dgv_phong.RowHeadersVisible = false;
            this.dgv_phong.RowHeadersWidth = 51;
            this.dgv_phong.RowTemplate.Height = 24;
            this.dgv_phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phong.Size = new System.Drawing.Size(1268, 310);
            this.dgv_phong.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPH";
            this.Column1.HeaderText = "Mã phòng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GIAPHONG";
            this.Column2.HeaderText = "Giá phòng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgv_dichvu);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1274, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách dịch vụ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.AllowUserToAddRows = false;
            this.dgv_dichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6});
            this.dgv_dichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dichvu.Location = new System.Drawing.Point(3, 3);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.RowHeadersVisible = false;
            this.dgv_dichvu.RowHeadersWidth = 51;
            this.dgv_dichvu.RowTemplate.Height = 24;
            this.dgv_dichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dichvu.Size = new System.Drawing.Size(1268, 310);
            this.dgv_dichvu.TabIndex = 1;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MAPH";
            this.Column7.HeaderText = "Phòng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENDV";
            this.Column3.HeaderText = "Tên dịch vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DONGIA";
            this.Column5.HeaderText = "Đơn giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "THANHTIEN";
            this.Column6.HeaderText = "Thành tiền";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // txt_tienthe
            // 
            this.txt_tienthe.BackColor = System.Drawing.Color.Silver;
            this.txt_tienthe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tienthe.Enabled = false;
            this.txt_tienthe.ForeColor = System.Drawing.Color.Black;
            this.txt_tienthe.Location = new System.Drawing.Point(1048, 152);
            this.txt_tienthe.Name = "txt_tienthe";
            this.txt_tienthe.ReadOnly = true;
            this.txt_tienthe.Size = new System.Drawing.Size(223, 27);
            this.txt_tienthe.TabIndex = 309;
            this.txt_tienthe.TextChanged += new System.EventHandler(this.txt_tienthe_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(919, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 26);
            this.label11.TabIndex = 308;
            this.label11.Text = "Tiền thẻ:";
            // 
            // panel9
            // 
            this.panel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel9.Location = new System.Drawing.Point(1048, 179);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(223, 2);
            this.panel9.TabIndex = 307;
            this.panel9.UseWaitCursor = true;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Location = new System.Drawing.Point(1048, 54);
            this.panel8.Margin = new System.Windows.Forms.Padding(4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(223, 2);
            this.panel8.TabIndex = 305;
            this.panel8.UseWaitCursor = true;
            // 
            // txt_tienmat
            // 
            this.txt_tienmat.BackColor = System.Drawing.Color.Silver;
            this.txt_tienmat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tienmat.Enabled = false;
            this.txt_tienmat.ForeColor = System.Drawing.Color.Black;
            this.txt_tienmat.Location = new System.Drawing.Point(1048, 91);
            this.txt_tienmat.Name = "txt_tienmat";
            this.txt_tienmat.ReadOnly = true;
            this.txt_tienmat.Size = new System.Drawing.Size(223, 27);
            this.txt_tienmat.TabIndex = 306;
            this.txt_tienmat.TextChanged += new System.EventHandler(this.txt_tienmat_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(919, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 26);
            this.label10.TabIndex = 304;
            this.label10.Text = "Tiền mặt:";
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Location = new System.Drawing.Point(1048, 118);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(223, 2);
            this.panel7.TabIndex = 302;
            this.panel7.UseWaitCursor = true;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.Silver;
            this.txt_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.ForeColor = System.Drawing.Color.Black;
            this.txt_tongtien.Location = new System.Drawing.Point(1048, 29);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(223, 27);
            this.txt_tongtien.TabIndex = 303;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(919, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 26);
            this.label9.TabIndex = 301;
            this.label9.Text = "Tổng tiền:";
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Location = new System.Drawing.Point(643, 177);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(223, 2);
            this.panel6.TabIndex = 294;
            this.panel6.UseWaitCursor = true;
            // 
            // txt_tienthucdon
            // 
            this.txt_tienthucdon.BackColor = System.Drawing.Color.Silver;
            this.txt_tienthucdon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tienthucdon.Enabled = false;
            this.txt_tienthucdon.ForeColor = System.Drawing.Color.Black;
            this.txt_tienthucdon.Location = new System.Drawing.Point(644, 151);
            this.txt_tienthucdon.Name = "txt_tienthucdon";
            this.txt_tienthucdon.ReadOnly = true;
            this.txt_tienthucdon.Size = new System.Drawing.Size(223, 27);
            this.txt_tienthucdon.TabIndex = 297;
            this.txt_tienthucdon.TextChanged += new System.EventHandler(this.txt_tienthucdon_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel5.Location = new System.Drawing.Point(642, 238);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(223, 2);
            this.panel5.TabIndex = 299;
            this.panel5.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(458, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 26);
            this.label8.TabIndex = 291;
            this.label8.Text = "Tiền thực đơn:";
            // 
            // txt_tienphuthu
            // 
            this.txt_tienphuthu.BackColor = System.Drawing.Color.Silver;
            this.txt_tienphuthu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tienphuthu.Enabled = false;
            this.txt_tienphuthu.ForeColor = System.Drawing.Color.Black;
            this.txt_tienphuthu.Location = new System.Drawing.Point(642, 213);
            this.txt_tienphuthu.Name = "txt_tienphuthu";
            this.txt_tienphuthu.ReadOnly = true;
            this.txt_tienphuthu.Size = new System.Drawing.Size(223, 27);
            this.txt_tienphuthu.TabIndex = 300;
            this.txt_tienphuthu.TextChanged += new System.EventHandler(this.txt_tienphuthu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(458, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 26);
            this.label3.TabIndex = 298;
            this.label3.Text = "Tiền phụ thu:";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Location = new System.Drawing.Point(1050, 241);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 2);
            this.panel4.TabIndex = 293;
            this.panel4.UseWaitCursor = true;
            // 
            // txt_tiencoc
            // 
            this.txt_tiencoc.BackColor = System.Drawing.Color.Silver;
            this.txt_tiencoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tiencoc.Enabled = false;
            this.txt_tiencoc.ForeColor = System.Drawing.Color.Black;
            this.txt_tiencoc.Location = new System.Drawing.Point(1050, 213);
            this.txt_tiencoc.Name = "txt_tiencoc";
            this.txt_tiencoc.ReadOnly = true;
            this.txt_tiencoc.Size = new System.Drawing.Size(221, 27);
            this.txt_tiencoc.TabIndex = 296;
            this.txt_tiencoc.TextChanged += new System.EventHandler(this.txt_tiencoc_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(643, 118);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 2);
            this.panel2.TabIndex = 292;
            this.panel2.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(919, 212);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 26);
            this.label7.TabIndex = 290;
            this.label7.Text = "Tiền cọc:";
            // 
            // txt_tiendichvu
            // 
            this.txt_tiendichvu.BackColor = System.Drawing.Color.Silver;
            this.txt_tiendichvu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tiendichvu.Enabled = false;
            this.txt_tiendichvu.ForeColor = System.Drawing.Color.Black;
            this.txt_tiendichvu.Location = new System.Drawing.Point(644, 91);
            this.txt_tiendichvu.Name = "txt_tiendichvu";
            this.txt_tiendichvu.ReadOnly = true;
            this.txt_tiendichvu.Size = new System.Drawing.Size(223, 27);
            this.txt_tiendichvu.TabIndex = 295;
            this.txt_tiendichvu.TextChanged += new System.EventHandler(this.txt_tiendichvu_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(646, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 2);
            this.panel1.TabIndex = 287;
            this.panel1.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(458, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 26);
            this.label6.TabIndex = 289;
            this.label6.Text = "Tiền dịch vụ:";
            // 
            // txt_tienphong
            // 
            this.txt_tienphong.BackColor = System.Drawing.Color.Silver;
            this.txt_tienphong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tienphong.Enabled = false;
            this.txt_tienphong.ForeColor = System.Drawing.Color.Black;
            this.txt_tienphong.Location = new System.Drawing.Point(645, 37);
            this.txt_tienphong.Name = "txt_tienphong";
            this.txt_tienphong.ReadOnly = true;
            this.txt_tienphong.Size = new System.Drawing.Size(222, 27);
            this.txt_tienphong.TabIndex = 288;
            this.txt_tienphong.TextChanged += new System.EventHandler(this.txt_tienphong_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(458, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 286;
            this.label5.Text = "Tiền phòng:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(172, 237);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 2);
            this.panel3.TabIndex = 304;
            this.panel3.UseWaitCursor = true;
            // 
            // txt_ngayra
            // 
            this.txt_ngayra.BackColor = System.Drawing.Color.Silver;
            this.txt_ngayra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ngayra.Enabled = false;
            this.txt_ngayra.ForeColor = System.Drawing.Color.Black;
            this.txt_ngayra.Location = new System.Drawing.Point(173, 211);
            this.txt_ngayra.Name = "txt_ngayra";
            this.txt_ngayra.ReadOnly = true;
            this.txt_ngayra.Size = new System.Drawing.Size(223, 27);
            this.txt_ngayra.TabIndex = 306;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 302;
            this.label1.Text = "Ngày ra:";
            // 
            // panel10
            // 
            this.panel10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel10.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel10.Location = new System.Drawing.Point(174, 179);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(223, 2);
            this.panel10.TabIndex = 303;
            this.panel10.UseWaitCursor = true;
            // 
            // txt_ngayvao
            // 
            this.txt_ngayvao.BackColor = System.Drawing.Color.Silver;
            this.txt_ngayvao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ngayvao.Enabled = false;
            this.txt_ngayvao.ForeColor = System.Drawing.Color.Black;
            this.txt_ngayvao.Location = new System.Drawing.Point(175, 152);
            this.txt_ngayvao.Name = "txt_ngayvao";
            this.txt_ngayvao.ReadOnly = true;
            this.txt_ngayvao.Size = new System.Drawing.Size(223, 27);
            this.txt_ngayvao.TabIndex = 305;
            // 
            // panel11
            // 
            this.panel11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel11.Location = new System.Drawing.Point(175, 60);
            this.panel11.Margin = new System.Windows.Forms.Padding(4);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(221, 2);
            this.panel11.TabIndex = 299;
            this.panel11.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 26);
            this.label2.TabIndex = 301;
            this.label2.Text = "Ngày vào:";
            // 
            // txt_mahd
            // 
            this.txt_mahd.BackColor = System.Drawing.Color.Silver;
            this.txt_mahd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mahd.Enabled = false;
            this.txt_mahd.ForeColor = System.Drawing.Color.Black;
            this.txt_mahd.Location = new System.Drawing.Point(174, 33);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.ReadOnly = true;
            this.txt_mahd.Size = new System.Drawing.Size(222, 27);
            this.txt_mahd.TabIndex = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 298;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // panel12
            // 
            this.panel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel12.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel12.Location = new System.Drawing.Point(175, 123);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(221, 2);
            this.panel12.TabIndex = 290;
            this.panel12.UseWaitCursor = true;
            // 
            // txt_khachhang
            // 
            this.txt_khachhang.BackColor = System.Drawing.Color.Silver;
            this.txt_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_khachhang.Enabled = false;
            this.txt_khachhang.ForeColor = System.Drawing.Color.Black;
            this.txt_khachhang.Location = new System.Drawing.Point(174, 96);
            this.txt_khachhang.Name = "txt_khachhang";
            this.txt_khachhang.ReadOnly = true;
            this.txt_khachhang.Size = new System.Drawing.Size(222, 27);
            this.txt_khachhang.TabIndex = 291;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(24, 92);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 26);
            this.label12.TabIndex = 289;
            this.label12.Text = "Khách hàng:";
            // 
            // chitiet_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1289, 629);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.txt_khachhang);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_tienthe);
            this.Controls.Add(this.txt_ngayra);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txt_ngayvao);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.txt_tienmat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txt_tienthucdon);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_tienphuthu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txt_tiencoc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tiendichvu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tienphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "chitiet_hoadon";
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.chitiet_hoadon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgv_phong;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgv_dichvu;
        private System.Windows.Forms.TextBox txt_tienthe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_tienmat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_tienthucdon;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tienphuthu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_tiencoc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tiendichvu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tienphong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_ngayra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txt_ngayvao;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txt_khachhang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}