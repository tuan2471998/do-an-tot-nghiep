using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class frm_thongke : UserControl
    {
        public frm_thongke()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           BAOCAOTHONGKE a = new BAOCAOTHONGKE();
            crystalReportViewer1.ReportSource = a;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
