namespace Da.report
{
    partial class Viewer_DichVu
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
            this.reportviewer_dichvu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportviewer_dichvu
            // 
            this.reportviewer_dichvu.ActiveViewIndex = -1;
            this.reportviewer_dichvu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportviewer_dichvu.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportviewer_dichvu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportviewer_dichvu.Location = new System.Drawing.Point(0, 0);
            this.reportviewer_dichvu.Name = "reportviewer_dichvu";
            this.reportviewer_dichvu.Size = new System.Drawing.Size(1429, 730);
            this.reportviewer_dichvu.TabIndex = 0;
            // 
            // Viewer_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 730);
            this.Controls.Add(this.reportviewer_dichvu);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Viewer_DichVu";
            this.Text = "Hóa đơn dịch vụ";
            this.Load += new System.EventHandler(this.Viewer_DichVu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportviewer_dichvu;
    }
}