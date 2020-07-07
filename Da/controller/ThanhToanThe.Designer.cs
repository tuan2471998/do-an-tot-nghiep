namespace Da.controller
{
    partial class ThanhToanThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThanhToanThe));
            this.lb_solanin = new System.Windows.Forms.Label();
            this.btn_thanhtoanthe = new DevExpress.XtraEditors.SimpleButton();
            this.txt_tralai = new System.Windows.Forms.TextBox();
            this.txt_khachdua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.lb_nguon = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_solanin
            // 
            this.lb_solanin.AutoSize = true;
            this.lb_solanin.Location = new System.Drawing.Point(24, 230);
            this.lb_solanin.Name = "lb_solanin";
            this.lb_solanin.Size = new System.Drawing.Size(73, 19);
            this.lb_solanin.TabIndex = 20;
            this.lb_solanin.Text = "Số lần in:";
            // 
            // btn_thanhtoanthe
            // 
            this.btn_thanhtoanthe.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoanthe.Appearance.Options.UseFont = true;
            this.btn_thanhtoanthe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thanhtoanthe.ImageOptions.Image")));
            this.btn_thanhtoanthe.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_thanhtoanthe.Location = new System.Drawing.Point(265, 192);
            this.btn_thanhtoanthe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_thanhtoanthe.Name = "btn_thanhtoanthe";
            this.btn_thanhtoanthe.Size = new System.Drawing.Size(216, 68);
            this.btn_thanhtoanthe.TabIndex = 19;
            this.btn_thanhtoanthe.Text = "In hóa đơn";
            this.btn_thanhtoanthe.Click += new System.EventHandler(this.btn_thanhtoanthe_Click);
            // 
            // txt_tralai
            // 
            this.txt_tralai.BackColor = System.Drawing.Color.White;
            this.txt_tralai.Enabled = false;
            this.txt_tralai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tralai.Location = new System.Drawing.Point(174, 149);
            this.txt_tralai.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tralai.Name = "txt_tralai";
            this.txt_tralai.ReadOnly = true;
            this.txt_tralai.Size = new System.Drawing.Size(448, 34);
            this.txt_tralai.TabIndex = 17;
            // 
            // txt_khachdua
            // 
            this.txt_khachdua.BackColor = System.Drawing.Color.White;
            this.txt_khachdua.Enabled = false;
            this.txt_khachdua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khachdua.Location = new System.Drawing.Point(174, 91);
            this.txt_khachdua.Margin = new System.Windows.Forms.Padding(5);
            this.txt_khachdua.Name = "txt_khachdua";
            this.txt_khachdua.ReadOnly = true;
            this.txt_khachdua.Size = new System.Drawing.Size(448, 34);
            this.txt_khachdua.TabIndex = 16;
            this.txt_khachdua.TextChanged += new System.EventHandler(this.txt_khachdua_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Còn lại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Khách đưa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền:";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.BackColor = System.Drawing.Color.White;
            this.txt_tongtien.Enabled = false;
            this.txt_tongtien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongtien.Location = new System.Drawing.Point(174, 32);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(5);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(448, 34);
            this.txt_tongtien.TabIndex = 12;
            this.txt_tongtien.TextChanged += new System.EventHandler(this.txt_tongtien_TextChanged);
            // 
            // lb_nguon
            // 
            this.lb_nguon.AutoSize = true;
            this.lb_nguon.Location = new System.Drawing.Point(556, 241);
            this.lb_nguon.Name = "lb_nguon";
            this.lb_nguon.Size = new System.Drawing.Size(50, 19);
            this.lb_nguon.TabIndex = 21;
            this.lb_nguon.Text = "nguồn";
            this.lb_nguon.Visible = false;
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(91, 230);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(18, 19);
            this.lb_count.TabIndex = 22;
            this.lb_count.Text = "0";
            // 
            // ThanhToanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 288);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.lb_nguon);
            this.Controls.Add(this.lb_solanin);
            this.Controls.Add(this.btn_thanhtoanthe);
            this.Controls.Add(this.txt_tralai);
            this.Controls.Add(this.txt_khachdua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongtien);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThanhToanThe";
            this.Text = "ThanhToanThe";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThanhToanThe_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_solanin;
        private DevExpress.XtraEditors.SimpleButton btn_thanhtoanthe;
        private System.Windows.Forms.TextBox txt_tralai;
        private System.Windows.Forms.TextBox txt_khachdua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label lb_nguon;
        private System.Windows.Forms.Label lb_count;
    }
}