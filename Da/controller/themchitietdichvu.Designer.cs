namespace Da
{
    partial class themchitietdichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themchitietdichvu));
            this.txt_mahddv = new System.Windows.Forms.TextBox();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_cthddv = new System.Windows.Forms.DataGridView();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.cbo_dichvu = new System.Windows.Forms.ComboBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mahddv
            // 
            this.txt_mahddv.Enabled = false;
            this.txt_mahddv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahddv.Location = new System.Drawing.Point(201, 14);
            this.txt_mahddv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahddv.Name = "txt_mahddv";
            this.txt_mahddv.Size = new System.Drawing.Size(324, 34);
            this.txt_mahddv.TabIndex = 32;
            // 
            // btndong
            // 
            this.btndong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndong.Appearance.Options.UseFont = true;
            this.btndong.Appearance.Options.UseForeColor = true;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndong.Location = new System.Drawing.Point(367, 101);
            this.btndong.Margin = new System.Windows.Forms.Padding(4);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(158, 63);
            this.btndong.TabIndex = 31;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // dgv_cthddv
            // 
            this.dgv_cthddv.AllowUserToAddRows = false;
            this.dgv_cthddv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cthddv.BackgroundColor = System.Drawing.Color.White;
            this.dgv_cthddv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthddv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.DONGIA,
            this.Column3});
            this.dgv_cthddv.Location = new System.Drawing.Point(15, 174);
            this.dgv_cthddv.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_cthddv.Name = "dgv_cthddv";
            this.dgv_cthddv.RowHeadersVisible = false;
            this.dgv_cthddv.RowHeadersWidth = 51;
            this.dgv_cthddv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cthddv.Size = new System.Drawing.Size(964, 322);
            this.dgv_cthddv.TabIndex = 26;
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.Appearance.Options.UseForeColor = true;
            this.btn_luu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.ImageOptions.Image")));
            this.btn_luu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luu.Location = new System.Drawing.Point(201, 101);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(158, 63);
            this.btn_luu.TabIndex = 30;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Location = new System.Drawing.Point(655, 104);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(6);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(324, 34);
            this.txt_thanhtien.TabIndex = 29;
            this.txt_thanhtien.TextChanged += new System.EventHandler(this.txt_thanhtien_TextChanged);
            // 
            // cbo_dichvu
            // 
            this.cbo_dichvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_dichvu.FormattingEnabled = true;
            this.cbo_dichvu.Location = new System.Drawing.Point(201, 58);
            this.cbo_dichvu.Margin = new System.Windows.Forms.Padding(6);
            this.cbo_dichvu.Name = "cbo_dichvu";
            this.cbo_dichvu.Size = new System.Drawing.Size(324, 33);
            this.cbo_dichvu.TabIndex = 24;
            this.cbo_dichvu.SelectedIndexChanged += new System.EventHandler(this.cbo_dichvu_SelectedIndexChanged);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.Location = new System.Drawing.Point(655, 58);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(6);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(324, 34);
            this.txt_dongia.TabIndex = 28;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(535, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(535, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(535, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Đơn giá:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(655, 14);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(6);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(324, 34);
            this.txt_soluong.TabIndex = 23;
            this.txt_soluong.TextChanged += new System.EventHandler(this.cbo_dichvu_SelectedIndexChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã hóa đơn dịch vụ:";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHD_DICHVU";
            this.Column1.HeaderText = "Mã phiếu sử dụng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MADV";
            this.Column2.HeaderText = "Mã dịch vụ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "THANHTIEN";
            this.Column3.HeaderText = "Thành tiền";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // themchitietdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 524);
            this.Controls.Add(this.txt_mahddv);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.dgv_cthddv);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.cbo_dichvu);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "themchitietdichvu";
            this.Text = "themchitietdichvu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.themchitietdichvu_FormClosing);
            this.Load += new System.EventHandler(this.Themchitietdichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mahddv;
        private DevExpress.XtraEditors.SimpleButton btndong;
        private System.Windows.Forms.DataGridView dgv_cthddv;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.ComboBox cbo_dichvu;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}