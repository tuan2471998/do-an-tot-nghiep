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
    public partial class frm_phongdattruoc : UserControl
    {
        public frm_phongdattruoc()
        {
            InitializeComponent();
        }

        public frm_phongdattruoc(string sophong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
        }

        private void hủyĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
