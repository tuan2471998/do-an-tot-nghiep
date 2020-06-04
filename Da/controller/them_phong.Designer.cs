namespace Da.controller
{
    partial class them_phong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(them_phong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_maloai = new System.Windows.Forms.ComboBox();
            this.txtgiaphong = new System.Windows.Forms.TextBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuvadong = new DevExpress.XtraEditors.SimpleButton();
            this.btn_luuvathem = new DevExpress.XtraEditors.SimpleButton();
            this.cbb_vitri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(133, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vị trí:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá phòng:";
            // 
            // cbb_maloai
            // 
            this.cbb_maloai.BackColor = System.Drawing.Color.Silver;
            this.cbb_maloai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_maloai.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_maloai.FormattingEnabled = true;
            this.cbb_maloai.Location = new System.Drawing.Point(179, 123);
            this.cbb_maloai.Name = "cbb_maloai";
            this.cbb_maloai.Size = new System.Drawing.Size(486, 33);
            this.cbb_maloai.TabIndex = 4;
            this.cbb_maloai.SelectedIndexChanged += new System.EventHandler(this.cbb_maloai_SelectedIndexChanged);
            // 
            // txtgiaphong
            // 
            this.txtgiaphong.BackColor = System.Drawing.Color.Silver;
            this.txtgiaphong.Enabled = false;
            this.txtgiaphong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaphong.ForeColor = System.Drawing.Color.DimGray;
            this.txtgiaphong.Location = new System.Drawing.Point(179, 226);
            this.txtgiaphong.Name = "txtgiaphong";
            this.txtgiaphong.Size = new System.Drawing.Size(486, 34);
            this.txtgiaphong.TabIndex = 6;
            this.txtgiaphong.TextChanged += new System.EventHandler(this.txtgiaphong_TextChanged);
            this.txtgiaphong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiaphong_KeyPress);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.Appearance.Options.UseForeColor = true;
            this.btn_thoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.ImageOptions.Image")));
            this.btn_thoat.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_thoat.Location = new System.Drawing.Point(483, 289);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(182, 62);
            this.btn_thoat.TabIndex = 29;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_luuvadong
            // 
            this.btn_luuvadong.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuvadong.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_luuvadong.Appearance.Options.UseFont = true;
            this.btn_luuvadong.Appearance.Options.UseForeColor = true;
            this.btn_luuvadong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuvadong.ImageOptions.Image")));
            this.btn_luuvadong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luuvadong.Location = new System.Drawing.Point(259, 289);
            this.btn_luuvadong.Name = "btn_luuvadong";
            this.btn_luuvadong.Size = new System.Drawing.Size(201, 62);
            this.btn_luuvadong.TabIndex = 28;
            this.btn_luuvadong.Text = "Lưu và đóng";
            this.btn_luuvadong.Click += new System.EventHandler(this.btn_luuvadong_Click);
            // 
            // btn_luuvathem
            // 
            this.btn_luuvathem.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luuvathem.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_luuvathem.Appearance.Options.UseFont = true;
            this.btn_luuvathem.Appearance.Options.UseForeColor = true;
            this.btn_luuvathem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_luuvathem.ImageOptions.Image")));
            this.btn_luuvathem.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_luuvathem.Location = new System.Drawing.Point(35, 289);
            this.btn_luuvathem.Name = "btn_luuvathem";
            this.btn_luuvathem.Size = new System.Drawing.Size(200, 62);
            this.btn_luuvathem.TabIndex = 27;
            this.btn_luuvathem.Text = "Lưu và thêm";
            this.btn_luuvathem.Click += new System.EventHandler(this.btn_luuvathem_Click);
            // 
            // cbb_vitri
            // 
            this.cbb_vitri.BackColor = System.Drawing.Color.Silver;
            this.cbb_vitri.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_vitri.ForeColor = System.Drawing.Color.DimGray;
            this.cbb_vitri.FormattingEnabled = true;
            this.cbb_vitri.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4",
            "Tầng 5",
            "Tầng 6",
            "Tầng 7",
            "Tầng 8"});
            this.cbb_vitri.Location = new System.Drawing.Point(179, 176);
            this.cbb_vitri.Name = "cbb_vitri";
            this.cbb_vitri.Size = new System.Drawing.Size(486, 33);
            this.cbb_vitri.TabIndex = 30;
            this.cbb_vitri.SelectedIndexChanged += new System.EventHandler(this.cbb_vitri_SelectedIndexChanged);
            // 
            // them_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(697, 363);
            this.Controls.Add(this.cbb_vitri);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_luuvadong);
            this.Controls.Add(this.btn_luuvathem);
            this.Controls.Add(this.txtgiaphong);
            this.Controls.Add(this.cbb_maloai);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "them_phong";
            this.Text = "them_phong";
            this.Load += new System.EventHandler(this.them_phong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_maloai;
        private System.Windows.Forms.TextBox txtgiaphong;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_luuvadong;
        private DevExpress.XtraEditors.SimpleButton btn_luuvathem;
        private System.Windows.Forms.ComboBox cbb_vitri;
    }
}