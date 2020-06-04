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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_cthddv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.textBoxthanhtien = new System.Windows.Forms.TextBox();
            this.textBoxdongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_ma_hd_dv = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_dichvu = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_cthddv);
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 467);
            this.panel1.TabIndex = 0;
            // 
            // dgv_cthddv
            // 
            this.dgv_cthddv.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgv_cthddv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cthddv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.DONGIA,
            this.THANHTIEN});
            this.dgv_cthddv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_cthddv.Location = new System.Drawing.Point(451, 0);
            this.dgv_cthddv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_cthddv.Name = "dgv_cthddv";
            this.dgv_cthddv.Size = new System.Drawing.Size(792, 467);
            this.dgv_cthddv.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "MAHD_DICHVU";
            this.Column1.HeaderText = "Mã phiếu sử dụng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MADV";
            this.Column2.HeaderText = "Mã dịch vụ";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số lượng";
            this.Column4.Name = "Column4";
            // 
            // DONGIA
            // 
            this.DONGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.THANHTIEN.DataPropertyName = "THANHTIEN";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.textBoxthanhtien);
            this.groupControl1.Controls.Add(this.textBoxdongia);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.cbo_ma_hd_dv);
            this.groupControl1.Controls.Add(this.txt_soluong);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbo_dichvu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(451, 467);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "Thông tin dịch vụ";
            // 
            // textBoxthanhtien
            // 
            this.textBoxthanhtien.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxthanhtien.Location = new System.Drawing.Point(195, 286);
            this.textBoxthanhtien.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxthanhtien.Name = "textBoxthanhtien";
            this.textBoxthanhtien.Size = new System.Drawing.Size(246, 32);
            this.textBoxthanhtien.TabIndex = 15;
            // 
            // textBoxdongia
            // 
            this.textBoxdongia.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBoxdongia.Location = new System.Drawing.Point(195, 237);
            this.textBoxdongia.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxdongia.Name = "textBoxdongia";
            this.textBoxdongia.Size = new System.Drawing.Size(246, 32);
            this.textBoxdongia.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Thành tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Đơn giá";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(313, 356);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 69);
            this.simpleButton1.TabIndex = 11;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn dịch vụ";
            // 
            // cbo_ma_hd_dv
            // 
            this.cbo_ma_hd_dv.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbo_ma_hd_dv.FormattingEnabled = true;
            this.cbo_ma_hd_dv.Location = new System.Drawing.Point(195, 80);
            this.cbo_ma_hd_dv.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_ma_hd_dv.Name = "cbo_ma_hd_dv";
            this.cbo_ma_hd_dv.Size = new System.Drawing.Size(246, 32);
            this.cbo_ma_hd_dv.TabIndex = 10;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_soluong.Location = new System.Drawing.Point(195, 184);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(246, 32);
            this.txt_soluong.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dịch vụ";
            // 
            // cbo_dichvu
            // 
            this.cbo_dichvu.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cbo_dichvu.FormattingEnabled = true;
            this.cbo_dichvu.Location = new System.Drawing.Point(197, 132);
            this.cbo_dichvu.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_dichvu.Name = "cbo_dichvu";
            this.cbo_dichvu.Size = new System.Drawing.Size(246, 32);
            this.cbo_dichvu.TabIndex = 7;
            // 
            // themchitietdichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 467);
            this.Controls.Add(this.panel1);
            this.Name = "themchitietdichvu";
            this.Text = "themchitietdichvu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_cthddv;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_ma_hd_dv;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_dichvu;
        private System.Windows.Forms.TextBox textBoxthanhtien;
        private System.Windows.Forms.TextBox textBoxdongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}