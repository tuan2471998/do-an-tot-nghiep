namespace Da.controller
{
    partial class frm_Nhaphang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Nhaphang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox_bangnhaphang = new System.Windows.Forms.GroupBox();
            this.dgv_nhaphang = new System.Windows.Forms.DataGridView();
            this.groupBox_thongtinnhaphang = new System.Windows.Forms.GroupBox();
            this.btn_nhaphang = new DevExpress.XtraEditors.SimpleButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_bangnhaphang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).BeginInit();
            this.groupBox_thongtinnhaphang.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_bangnhaphang
            // 
            this.groupBox_bangnhaphang.Controls.Add(this.dgv_nhaphang);
            this.groupBox_bangnhaphang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_bangnhaphang.Location = new System.Drawing.Point(4, 117);
            this.groupBox_bangnhaphang.Name = "groupBox_bangnhaphang";
            this.groupBox_bangnhaphang.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_bangnhaphang.Size = new System.Drawing.Size(1955, 625);
            this.groupBox_bangnhaphang.TabIndex = 2;
            this.groupBox_bangnhaphang.TabStop = false;
            this.groupBox_bangnhaphang.Text = "Quản lý nhập hàng";
            // 
            // dgv_nhaphang
            // 
            this.dgv_nhaphang.AllowUserToAddRows = false;
            this.dgv_nhaphang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nhaphang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_nhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_nhaphang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nhaphang.Location = new System.Drawing.Point(3, 30);
            this.dgv_nhaphang.Name = "dgv_nhaphang";
            this.dgv_nhaphang.RowHeadersVisible = false;
            this.dgv_nhaphang.RowHeadersWidth = 51;
            this.dgv_nhaphang.RowTemplate.Height = 24;
            this.dgv_nhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_nhaphang.Size = new System.Drawing.Size(1949, 592);
            this.dgv_nhaphang.TabIndex = 0;
            // 
            // groupBox_thongtinnhaphang
            // 
            this.groupBox_thongtinnhaphang.Controls.Add(this.btn_nhaphang);
            this.groupBox_thongtinnhaphang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_thongtinnhaphang.Location = new System.Drawing.Point(4, 16);
            this.groupBox_thongtinnhaphang.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_thongtinnhaphang.Name = "groupBox_thongtinnhaphang";
            this.groupBox_thongtinnhaphang.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_thongtinnhaphang.Size = new System.Drawing.Size(1954, 122);
            this.groupBox_thongtinnhaphang.TabIndex = 1;
            this.groupBox_thongtinnhaphang.TabStop = false;
            this.groupBox_thongtinnhaphang.Text = "Thông tin";
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhaphang.Appearance.Options.UseFont = true;
            this.btn_nhaphang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhaphang.ImageOptions.Image")));
            this.btn_nhaphang.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_nhaphang.Location = new System.Drawing.Point(7, 34);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(209, 61);
            this.btn_nhaphang.TabIndex = 270;
            this.btn_nhaphang.Text = "Nhập hàng";
            this.btn_nhaphang.Click += new System.EventHandler(this.btn_nhaphang_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "loaihang";
            this.Column1.HeaderText = "Loại hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "mahang";
            this.Column2.HeaderText = "Mã hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenhang";
            this.Column3.HeaderText = "Tên hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "soluong";
            dataGridViewCellStyle1.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Số lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // frm_Nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.groupBox_bangnhaphang);
            this.Controls.Add(this.groupBox_thongtinnhaphang);
            this.Name = "frm_Nhaphang";
            this.Size = new System.Drawing.Size(1962, 745);
            this.Load += new System.EventHandler(this.frm_Nhaphang_Load);
            this.groupBox_bangnhaphang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaphang)).EndInit();
            this.groupBox_thongtinnhaphang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox_bangnhaphang;
        private System.Windows.Forms.DataGridView dgv_nhaphang;
        private System.Windows.Forms.GroupBox groupBox_thongtinnhaphang;
        private DevExpress.XtraEditors.SimpleButton btn_nhaphang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
