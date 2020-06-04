namespace Da.controller
{
    partial class them_dichvu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(them_dichvu));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendichvu = new System.Windows.Forms.TextBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.btnLuuvathem = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuuvadong = new DevExpress.XtraEditors.SimpleButton();
            this.btndong = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN DỊCH VỤ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền:";
            // 
            // txtTendichvu
            // 
            this.txtTendichvu.BackColor = System.Drawing.Color.Silver;
            this.txtTendichvu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendichvu.Location = new System.Drawing.Point(194, 95);
            this.txtTendichvu.Name = "txtTendichvu";
            this.txtTendichvu.Size = new System.Drawing.Size(360, 34);
            this.txtTendichvu.TabIndex = 3;
            // 
            // txtGiatien
            // 
            this.txtGiatien.BackColor = System.Drawing.Color.Silver;
            this.txtGiatien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(194, 157);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(360, 34);
            this.txtGiatien.TabIndex = 4;
            this.txtGiatien.TextChanged += new System.EventHandler(this.txtGiatien_TextChanged);
            this.txtGiatien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiatien_KeyPress);
            // 
            // btnLuuvathem
            // 
            this.btnLuuvathem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuvathem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuuvathem.Appearance.Options.UseFont = true;
            this.btnLuuvathem.Appearance.Options.UseForeColor = true;
            this.btnLuuvathem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuvathem.ImageOptions.Image")));
            this.btnLuuvathem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuuvathem.Location = new System.Drawing.Point(12, 225);
            this.btnLuuvathem.Name = "btnLuuvathem";
            this.btnLuuvathem.Size = new System.Drawing.Size(171, 62);
            this.btnLuuvathem.TabIndex = 5;
            this.btnLuuvathem.Text = "Lưu và thêm";
            this.btnLuuvathem.Click += new System.EventHandler(this.btnLuuvathem_Click);
            // 
            // btnLuuvadong
            // 
            this.btnLuuvadong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuvadong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuuvadong.Appearance.Options.UseFont = true;
            this.btnLuuvadong.Appearance.Options.UseForeColor = true;
            this.btnLuuvadong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuvadong.ImageOptions.Image")));
            this.btnLuuvadong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLuuvadong.Location = new System.Drawing.Point(210, 225);
            this.btnLuuvadong.Name = "btnLuuvadong";
            this.btnLuuvadong.Size = new System.Drawing.Size(178, 62);
            this.btnLuuvadong.TabIndex = 6;
            this.btnLuuvadong.Text = "Lưu và đóng";
            this.btnLuuvadong.Click += new System.EventHandler(this.btnLuuvadong_Click);
            // 
            // btndong
            // 
            this.btndong.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndong.Appearance.Options.UseFont = true;
            this.btndong.Appearance.Options.UseForeColor = true;
            this.btndong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndong.ImageOptions.Image")));
            this.btndong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btndong.Location = new System.Drawing.Point(410, 225);
            this.btndong.Name = "btndong";
            this.btndong.Size = new System.Drawing.Size(144, 62);
            this.btndong.TabIndex = 7;
            this.btndong.Text = "Đóng";
            this.btndong.Click += new System.EventHandler(this.btndong_Click);
            // 
            // them_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(590, 299);
            this.Controls.Add(this.btndong);
            this.Controls.Add(this.btnLuuvadong);
            this.Controls.Add(this.btnLuuvathem);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtTendichvu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "them_dichvu";
            this.Text = "them_dichvu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendichvu;
        private System.Windows.Forms.TextBox txtGiatien;
        private DevExpress.XtraEditors.SimpleButton btnLuuvathem;
        private DevExpress.XtraEditors.SimpleButton btnLuuvadong;
        private DevExpress.XtraEditors.SimpleButton btndong;
    }
}