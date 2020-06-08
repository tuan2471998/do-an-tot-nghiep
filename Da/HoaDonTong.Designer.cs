namespace Da.controller
{
    partial class HoaDonTong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDonTong));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_timkiem = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_matp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.hóaĐơnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcHóaĐơnToolStripMenuItem,
            this.lậpHóaĐơnThanhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1641, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcHóaĐơnToolStripMenuItem
            // 
            this.danhMụcHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.danhMụcHóaĐơnToolStripMenuItem.Name = "danhMụcHóaĐơnToolStripMenuItem";
            this.danhMụcHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(309, 42);
            this.danhMụcHóaĐơnToolStripMenuItem.Text = "Danh mục hóa đơn";
            // 
            // lậpHóaĐơnThanhToánToolStripMenuItem
            // 
            this.lậpHóaĐơnThanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHóaĐơnToolStripMenuItem,
            this.inHóaĐơnToolStripMenuItem});
            this.lậpHóaĐơnThanhToánToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lậpHóaĐơnThanhToánToolStripMenuItem.Name = "lậpHóaĐơnThanhToánToolStripMenuItem";
            this.lậpHóaĐơnThanhToánToolStripMenuItem.Size = new System.Drawing.Size(383, 42);
            this.lậpHóaĐơnThanhToánToolStripMenuItem.Text = "Lập hóa đơn thanh toán";
            // 
            // thêmHóaĐơnToolStripMenuItem
            // 
            this.thêmHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.thêmHóaĐơnToolStripMenuItem.Name = "thêmHóaĐơnToolStripMenuItem";
            this.thêmHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(266, 36);
            this.thêmHóaĐơnToolStripMenuItem.Text = "Thêm hóa đơn";
            this.thêmHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.thêmHóaĐơnToolStripMenuItem_Click);
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnPhòngToolStripMenuItem,
            this.hóaĐơnDịchVụToolStripMenuItem});
            this.inHóaĐơnToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(266, 36);
            this.inHóaĐơnToolStripMenuItem.Text = "In hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_timkiem);
            this.groupBox1.Controls.Add(this.cbo_matp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1641, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.btn_timkiem.Appearance.Options.UseFont = true;
            this.btn_timkiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_timkiem.ImageOptions.SvgImage")));
            this.btn_timkiem.Location = new System.Drawing.Point(780, 17);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(127, 38);
            this.btn_timkiem.TabIndex = 9;
            this.btn_timkiem.Text = "Tìm";
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // cbo_matp
            // 
            this.cbo_matp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_matp.FormattingEnabled = true;
            this.cbo_matp.Location = new System.Drawing.Point(257, 25);
            this.cbo_matp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbo_matp.Name = "cbo_matp";
            this.cbo_matp.Size = new System.Drawing.Size(483, 30);
            this.cbo_matp.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn mã phiếu để tìm kiếm";
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hoadon.Location = new System.Drawing.Point(0, 99);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hoadon.Size = new System.Drawing.Size(1641, 676);
            this.dgv_hoadon.TabIndex = 9;
            this.dgv_hoadon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellContentClick);
            // 
            // hóaĐơnPhòngToolStripMenuItem
            // 
            this.hóaĐơnPhòngToolStripMenuItem.Name = "hóaĐơnPhòngToolStripMenuItem";
            this.hóaĐơnPhòngToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.hóaĐơnPhòngToolStripMenuItem.Text = "Hóa đơn phòng";
            this.hóaĐơnPhòngToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnPhòngToolStripMenuItem_Click);
            // 
            // hóaĐơnDịchVụToolStripMenuItem
            // 
            this.hóaĐơnDịchVụToolStripMenuItem.Name = "hóaĐơnDịchVụToolStripMenuItem";
            this.hóaĐơnDịchVụToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.hóaĐơnDịchVụToolStripMenuItem.Text = "Hóa đơn dịch vụ";
            this.hóaĐơnDịchVụToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnDịchVụToolStripMenuItem_Click);
            // 
            // HoaDonTong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_hoadon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HoaDonTong";
            this.Size = new System.Drawing.Size(1641, 775);
            this.Load += new System.EventHandler(this.HoaDonTong_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnThanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_timkiem;
        private System.Windows.Forms.ComboBox cbo_matp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnDịchVụToolStripMenuItem;
    }
}
