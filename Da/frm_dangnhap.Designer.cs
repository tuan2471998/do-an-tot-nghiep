namespace Da
{
    partial class frm_dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dangnhap));
            this.lblten = new DevExpress.XtraEditors.LabelControl();
            this.lblmk = new DevExpress.XtraEditors.LabelControl();
            this.btndn = new DevExpress.XtraEditors.SimpleButton();
            this.btnthoat = new DevExpress.XtraEditors.SimpleButton();
            this.txtten = new DevExpress.XtraEditors.TextEdit();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblten.Appearance.Options.UseFont = true;
            this.lblten.Appearance.Options.UseForeColor = true;
            this.lblten.Location = new System.Drawing.Point(12, 197);
            this.lblten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(175, 31);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "Tên đăng nhập";
            // 
            // lblmk
            // 
            this.lblmk.Appearance.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmk.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblmk.Appearance.Options.UseFont = true;
            this.lblmk.Appearance.Options.UseForeColor = true;
            this.lblmk.Location = new System.Drawing.Point(22, 245);
            this.lblmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(114, 31);
            this.lblmk.TabIndex = 2;
            this.lblmk.Text = "Mật khẩu";
            // 
            // btndn
            // 
            this.btndn.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btndn.Appearance.Options.UseFont = true;
            this.btndn.Appearance.Options.UseForeColor = true;
            this.btndn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndn.ImageOptions.Image")));
            this.btndn.Location = new System.Drawing.Point(157, 290);
            this.btndn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(153, 52);
            this.btndn.TabIndex = 5;
            this.btndn.Text = "Đăng nhập";
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Appearance.Options.UseFont = true;
            this.btnthoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnthoat.ImageOptions.Image")));
            this.btnthoat.Location = new System.Drawing.Point(343, 290);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(147, 52);
            this.btnthoat.TabIndex = 6;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtten
            // 
            this.txtten.EditValue = "NV001     ";
            this.txtten.Location = new System.Drawing.Point(203, 199);
            this.txtten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtten.Name = "txtten";
            this.txtten.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtten.Properties.Appearance.Options.UseFont = true;
            this.txtten.Properties.Appearance.Options.UseForeColor = true;
            this.txtten.Size = new System.Drawing.Size(287, 32);
            this.txtten.TabIndex = 7;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(203, 250);
            this.txtmk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Properties.Appearance.Options.UseFont = true;
            this.txtmk.Properties.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(287, 32);
            this.txtmk.TabIndex = 8;
            // 
            // frm_dangnhap
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Da.Properties.Resources.DN;
            this.ClientSize = new System.Drawing.Size(567, 353);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lblten);
            this.DoubleBuffered = true;
            this.Name = "frm_dangnhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_dangnhap_FormClosing);
            this.Load += new System.EventHandler(this.frm_dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtten.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblten;
        private DevExpress.XtraEditors.LabelControl lblmk;
        private DevExpress.XtraEditors.SimpleButton btndn;
        private DevExpress.XtraEditors.SimpleButton btnthoat;
        private DevExpress.XtraEditors.TextEdit txtten;
        private DevExpress.XtraEditors.TextEdit txtmk;
    }
}