using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Da.controller
{
    public partial class frm_phong : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_phong()
        {
            InitializeComponent();
        }
        public frm_phong(string pSoPhong)
        {

            InitializeComponent();
            labelmaphong.Text = pSoPhong;
        }

        private void frm_phong_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.value = labelmaphong.Text;
        }
    }
}
