namespace Da.controller
{
    partial class DM_dichvu2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DM_dichvu2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_dichvu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_giadv = new System.Windows.Forms.TextBox();
            this.txt_tendv = new System.Windows.Forms.TextBox();
            this.txt_madv = new System.Windows.Forms.TextBox();
            this.btnLammoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimkiem = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_dichvu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1725, 745);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_dichvu
            // 
            this.dgv_dichvu.AllowUserToAddRows = false;
            this.dgv_dichvu.BackgroundColor = System.Drawing.Color.White;
            this.dgv_dichvu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dichvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_dichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dichvu.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgv_dichvu.Location = new System.Drawing.Point(4, 228);
            this.dgv_dichvu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_dichvu.Name = "dgv_dichvu";
            this.dgv_dichvu.ReadOnly = true;
            this.dgv_dichvu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_dichvu.RowHeadersVisible = false;
            this.dgv_dichvu.RowHeadersWidth = 51;
            this.dgv_dichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dichvu.Size = new System.Drawing.Size(1717, 512);
            this.dgv_dichvu.TabIndex = 5;
            this.dgv_dichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dichvu_CellContentClick);
            this.dgv_dichvu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dichvu_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MADV";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Mã dịch vụ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 538;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "TENDV";
            this.Column2.HeaderText = "Tên dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 538;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "GIADV_HIENTAI";
            this.Column3.HeaderText = "Giá ( VNĐ )";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txt_giadv);
            this.groupBox1.Controls.Add(this.txt_tendv);
            this.groupBox1.Controls.Add(this.txt_madv);
            this.groupBox1.Controls.Add(this.btnLammoi);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1719, 217);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(139, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 2);
            this.panel3.TabIndex = 239;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(630, 109);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 2);
            this.panel1.TabIndex = 238;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(1116, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 2);
            this.panel2.TabIndex = 237;
            // 
            // txt_giadv
            // 
            this.txt_giadv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_giadv.BackColor = System.Drawing.Color.LightBlue;
            this.txt_giadv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_giadv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_giadv.ForeColor = System.Drawing.Color.DimGray;
            this.txt_giadv.Location = new System.Drawing.Point(1116, 76);
            this.txt_giadv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giadv.Name = "txt_giadv";
            this.txt_giadv.Size = new System.Drawing.Size(311, 27);
            this.txt_giadv.TabIndex = 83;
            this.txt_giadv.Click += new System.EventHandler(this.txt_giadv_Click);
            // 
            // txt_tendv
            // 
            this.txt_tendv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tendv.BackColor = System.Drawing.Color.LightBlue;
            this.txt_tendv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tendv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendv.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tendv.Location = new System.Drawing.Point(630, 79);
            this.txt_tendv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendv.Name = "txt_tendv";
            this.txt_tendv.Size = new System.Drawing.Size(241, 27);
            this.txt_tendv.TabIndex = 82;
            // 
            // txt_madv
            // 
            this.txt_madv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_madv.BackColor = System.Drawing.Color.LightBlue;
            this.txt_madv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_madv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madv.ForeColor = System.Drawing.Color.DimGray;
            this.txt_madv.Location = new System.Drawing.Point(139, 79);
            this.txt_madv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madv.Name = "txt_madv";
            this.txt_madv.Size = new System.Drawing.Size(241, 27);
            this.txt_madv.TabIndex = 81;
            // 
            // btnLammoi
            // 
            this.btnLammoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLammoi.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnLammoi.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLammoi.Appearance.Options.UseBackColor = true;
            this.btnLammoi.Appearance.Options.UseBorderColor = true;
            this.btnLammoi.Appearance.Options.UseFont = true;
            this.btnLammoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoi.ImageOptions.Image")));
            this.btnLammoi.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLammoi.Location = new System.Drawing.Point(1359, 146);
            this.btnLammoi.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(306, 61);
            this.btnLammoi.TabIndex = 80;
            this.btnLammoi.Text = "Làm mới danh sách";
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimkiem.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnTimkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Appearance.Options.UseBackColor = true;
            this.btnTimkiem.Appearance.Options.UseBorderColor = true;
            this.btnTimkiem.Appearance.Options.UseFont = true;
            this.btnTimkiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.ImageOptions.Image")));
            this.btnTimkiem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTimkiem.Location = new System.Drawing.Point(1453, 57);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(150, 61);
            this.btnTimkiem.TabIndex = 79;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnThem.Appearance.Options.UseBackColor = true;
            this.btnThem.Appearance.Options.UseBorderColor = true;
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Appearance.Options.UseForeColor = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnThem.Location = new System.Drawing.Point(757, 146);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(149, 61);
            this.btnThem.TabIndex = 78;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseBackColor = true;
            this.btnXoa.Appearance.Options.UseBorderColor = true;
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Enabled = false;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXoa.Location = new System.Drawing.Point(948, 146);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(149, 61);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseBackColor = true;
            this.btnSua.Appearance.Options.UseBorderColor = true;
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Enabled = false;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSua.Location = new System.Drawing.Point(1144, 146);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(149, 61);
            this.btnSua.TabIndex = 76;
            this.btnSua.Text = "Cập nhật";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(948, 84);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(125, 26);
            this.labelControl4.TabIndex = 75;
            this.labelControl4.Text = "Giá dịch vụ:";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(480, 84);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(127, 26);
            this.labelControl3.TabIndex = 74;
            this.labelControl3.Text = "Tên dịch vụ:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(8, 76);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(123, 26);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "Mã dịch vụ:";
            // 
            // DM_dichvu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DM_dichvu2";
            this.Size = new System.Drawing.Size(1731, 751);
            this.Load += new System.EventHandler(this.DM_dichvu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dichvu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgv_dichvu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_giadv;
        private System.Windows.Forms.TextBox txt_tendv;
        private System.Windows.Forms.TextBox txt_madv;
        private DevExpress.XtraEditors.SimpleButton btnLammoi;
        private DevExpress.XtraEditors.SimpleButton btnTimkiem;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
