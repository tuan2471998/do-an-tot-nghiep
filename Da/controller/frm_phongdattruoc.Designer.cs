namespace Da.controller
{
    partial class frm_phongdattruoc
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hủyĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyĐặtToànBộToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_sophong = new System.Windows.Forms.Label();
            this.lb_maphieudat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Da.Properties.Resources.hinhcaigiuong;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hủyĐặtToolStripMenuItem,
            this.thuêPhòngToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // hủyĐặtToolStripMenuItem
            // 
            this.hủyĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hủyĐặtToànBộToolStripMenuItem,
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem});
            this.hủyĐặtToolStripMenuItem.Name = "hủyĐặtToolStripMenuItem";
            this.hủyĐặtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.hủyĐặtToolStripMenuItem.Text = "Hủy đặt phòng";
            // 
            // hủyĐặtToànBộToolStripMenuItem
            // 
            this.hủyĐặtToànBộToolStripMenuItem.Name = "hủyĐặtToànBộToolStripMenuItem";
            this.hủyĐặtToànBộToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.hủyĐặtToànBộToolStripMenuItem.Text = "Hủy đặt toàn bộ";
            this.hủyĐặtToànBộToolStripMenuItem.Click += new System.EventHandler(this.hủyĐặtToànBộToolStripMenuItem_Click);
            // 
            // hủyĐặtPhòngĐangChọnToolStripMenuItem
            // 
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem.Name = "hủyĐặtPhòngĐangChọnToolStripMenuItem";
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem.Text = "Hủy đặt phòng đang chọn";
            this.hủyĐặtPhòngĐangChọnToolStripMenuItem.Click += new System.EventHandler(this.hủyĐặtPhòngĐangChọnToolStripMenuItem_Click);
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            this.thuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.thuêPhòngToolStripMenuItem_Click);
            // 
            // lb_sophong
            // 
            this.lb_sophong.AutoSize = true;
            this.lb_sophong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophong.Location = new System.Drawing.Point(188, 0);
            this.lb_sophong.Name = "lb_sophong";
            this.lb_sophong.Size = new System.Drawing.Size(75, 32);
            this.lb_sophong.TabIndex = 5;
            this.lb_sophong.Text = "P101";
            this.lb_sophong.TextChanged += new System.EventHandler(this.lb_sophong_TextChanged);
            // 
            // lb_maphieudat
            // 
            this.lb_maphieudat.AutoSize = true;
            this.lb_maphieudat.Location = new System.Drawing.Point(3, 197);
            this.lb_maphieudat.Name = "lb_maphieudat";
            this.lb_maphieudat.Size = new System.Drawing.Size(65, 27);
            this.lb_maphieudat.TabIndex = 6;
            this.lb_maphieudat.Text = "mapd";
            // 
            // frm_phongdattruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lb_maphieudat);
            this.Controls.Add(this.lb_sophong);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_phongdattruoc";
            this.Size = new System.Drawing.Size(266, 224);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hủyĐặtToolStripMenuItem;
        private System.Windows.Forms.Label lb_sophong;
        private System.Windows.Forms.ToolStripMenuItem hủyĐặtToànBộToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hủyĐặtPhòngĐangChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.Label lb_maphieudat;
    }
}
