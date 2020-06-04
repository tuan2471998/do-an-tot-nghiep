namespace Da
{
    partial class HDTONG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HDTONG));
            this.btn_lap = new DevExpress.XtraEditors.SimpleButton();
            this.txt_mahd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_mapt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_lap
            // 
            this.btn_lap.Appearance.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btn_lap.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btn_lap.Appearance.Options.UseFont = true;
            this.btn_lap.Appearance.Options.UseForeColor = true;
            this.btn_lap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_lap.ImageOptions.SvgImage")));
            this.btn_lap.Location = new System.Drawing.Point(374, 240);
            this.btn_lap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_lap.Name = "btn_lap";
            this.btn_lap.Size = new System.Drawing.Size(161, 84);
            this.btn_lap.TabIndex = 9;
            this.btn_lap.Text = "Lập";
            this.btn_lap.Click += new System.EventHandler(this.btn_lap_Click_1);
            // 
            // txt_mahd
            // 
            this.txt_mahd.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txt_mahd.Location = new System.Drawing.Point(199, 158);
            this.txt_mahd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.Size = new System.Drawing.Size(515, 36);
            this.txt_mahd.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label2.Location = new System.Drawing.Point(8, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.label1.Location = new System.Drawing.Point(20, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn phiếu thuê";
            // 
            // cbo_mapt
            // 
            this.cbo_mapt.Font = new System.Drawing.Font("Tahoma", 14F);
            this.cbo_mapt.FormattingEnabled = true;
            this.cbo_mapt.Location = new System.Drawing.Point(199, 88);
            this.cbo_mapt.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_mapt.Name = "cbo_mapt";
            this.cbo_mapt.Size = new System.Drawing.Size(515, 36);
            this.cbo_mapt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(359, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "LẬP HÓA ĐƠN TỔNG";
            // 
            // HDTONG
            // 
            this.Appearance.BackColor = System.Drawing.Color.MistyRose;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 339);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_lap);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_mapt);
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.Name = "HDTONG";
            this.Text = "HDTONG";
            this.Load += new System.EventHandler(this.HDTONG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_lap;
        private System.Windows.Forms.TextBox txt_mahd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_mapt;
        private System.Windows.Forms.Label label3;
    }
}