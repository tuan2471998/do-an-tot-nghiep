using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Da
{
    public partial class Hoadon_dichvu : DevExpress.XtraEditors.XtraForm
    {
        public Hoadon_dichvu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HOADONDICHVU d = new HOADONDICHVU();
            crystalReportViewer1.ReportSource = d;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}