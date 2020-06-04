namespace Da.controller
{
    partial class frm_phongdondep
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_sophong = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hoànThànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_giay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_phut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_gio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Da.Properties.Resources.chổi3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_sophong
            // 
            this.lb_sophong.AutoSize = true;
            this.lb_sophong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophong.Location = new System.Drawing.Point(180, 0);
            this.lb_sophong.Name = "lb_sophong";
            this.lb_sophong.Size = new System.Drawing.Size(75, 32);
            this.lb_sophong.TabIndex = 6;
            this.lb_sophong.Text = "P101";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoànThànhToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 28);
            // 
            // hoànThànhToolStripMenuItem
            // 
            this.hoànThànhToolStripMenuItem.Name = "hoànThànhToolStripMenuItem";
            this.hoànThànhToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.hoànThànhToolStripMenuItem.Text = "Hoàn thành";
            this.hoànThànhToolStripMenuItem.Click += new System.EventHandler(this.hoànThànhToolStripMenuItem_Click);
            // 
            // lb_giay
            // 
            this.lb_giay.AutoSize = true;
            this.lb_giay.Location = new System.Drawing.Point(219, 197);
            this.lb_giay.Name = "lb_giay";
            this.lb_giay.Size = new System.Drawing.Size(36, 27);
            this.lb_giay.TabIndex = 8;
            this.lb_giay.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = ":";
            // 
            // lb_phut
            // 
            this.lb_phut.AutoSize = true;
            this.lb_phut.Location = new System.Drawing.Point(177, 197);
            this.lb_phut.Name = "lb_phut";
            this.lb_phut.Size = new System.Drawing.Size(36, 27);
            this.lb_phut.TabIndex = 10;
            this.lb_phut.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 27);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // lb_gio
            // 
            this.lb_gio.AutoSize = true;
            this.lb_gio.Location = new System.Drawing.Point(135, 197);
            this.lb_gio.Name = "lb_gio";
            this.lb_gio.Size = new System.Drawing.Size(36, 27);
            this.lb_gio.TabIndex = 12;
            this.lb_gio.Text = "00";
            // 
            // frm_phongdondep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lb_gio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_phut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_giay);
            this.Controls.Add(this.lb_sophong);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_phongdondep";
            this.Size = new System.Drawing.Size(255, 224);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_sophong;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoànThànhToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_giay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_phut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_gio;
    }
}
