namespace Da.controller
{
    partial class chitiet_hoadon_dichvu
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
            this.txt_mahddv = new System.Windows.Forms.TextBox();
            this.dgv_cthddv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tendichvu = new System.Windows.Forms.TextBox();
            this.txt_madichvu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mahddv
            // 
            this.txt_mahddv.BackColor = System.Drawing.Color.Silver;
            this.txt_mahddv.Enabled = false;
            this.txt_mahddv.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mahddv.Location = new System.Drawing.Point(196, 28);
            this.txt_mahddv.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahddv.Name = "txt_mahddv";
            this.txt_mahddv.ReadOnly = true;
            this.txt_mahddv.Size = new System.Drawing.Size(324, 34);
            this.txt_mahddv.TabIndex = 45;
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
            this.dgv_cthddv.Location = new System.Drawing.Point(11, 170);
            this.dgv_cthddv.Margin = new System.Windows.Forms.Padding(6);
            this.dgv_cthddv.Name = "dgv_cthddv";
            this.dgv_cthddv.RowHeadersVisible = false;
            this.dgv_cthddv.RowHeadersWidth = 51;
            this.dgv_cthddv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_cthddv.Size = new System.Drawing.Size(964, 322);
            this.dgv_cthddv.TabIndex = 39;
            this.dgv_cthddv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cthddv_CellContentClick);
            this.dgv_cthddv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cthddv_CellContentClick);
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
            // txt_thanhtien
            // 
            this.txt_thanhtien.BackColor = System.Drawing.Color.Silver;
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.Location = new System.Drawing.Point(650, 114);
            this.txt_thanhtien.Margin = new System.Windows.Forms.Padding(6);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(324, 34);
            this.txt_thanhtien.TabIndex = 42;
            // 
            // txt_dongia
            // 
            this.txt_dongia.BackColor = System.Drawing.Color.Silver;
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.Location = new System.Drawing.Point(650, 72);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(6);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(324, 34);
            this.txt_dongia.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(530, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 40;
            this.label4.Text = "Thành tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(530, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(530, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Đơn giá:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.Silver;
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.Location = new System.Drawing.Point(650, 28);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(6);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ReadOnly = true;
            this.txt_soluong.Size = new System.Drawing.Size(324, 34);
            this.txt_soluong.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã hóa đơn dịch vụ:";
            // 
            // txt_tendichvu
            // 
            this.txt_tendichvu.BackColor = System.Drawing.Color.Silver;
            this.txt_tendichvu.Enabled = false;
            this.txt_tendichvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendichvu.Location = new System.Drawing.Point(196, 114);
            this.txt_tendichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tendichvu.Name = "txt_tendichvu";
            this.txt_tendichvu.ReadOnly = true;
            this.txt_tendichvu.Size = new System.Drawing.Size(324, 34);
            this.txt_tendichvu.TabIndex = 46;
            // 
            // txt_madichvu
            // 
            this.txt_madichvu.BackColor = System.Drawing.Color.Silver;
            this.txt_madichvu.Enabled = false;
            this.txt_madichvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madichvu.Location = new System.Drawing.Point(196, 72);
            this.txt_madichvu.Margin = new System.Windows.Forms.Padding(4);
            this.txt_madichvu.Name = "txt_madichvu";
            this.txt_madichvu.ReadOnly = true;
            this.txt_madichvu.Size = new System.Drawing.Size(324, 34);
            this.txt_madichvu.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "Mã dịch vụ";
            // 
            // chitiet_hoadon_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(991, 512);
            this.Controls.Add(this.txt_madichvu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tendichvu);
            this.Controls.Add(this.txt_mahddv);
            this.Controls.Add(this.dgv_cthddv);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "chitiet_hoadon_dichvu";
            this.Text = "Chi tiết hóa đơn dịch vụ";
            this.Load += new System.EventHandler(this.chitiet_hoadon_dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cthddv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mahddv;
        private System.Windows.Forms.DataGridView dgv_cthddv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tendichvu;
        private System.Windows.Forms.TextBox txt_madichvu;
        private System.Windows.Forms.Label label6;
    }
}