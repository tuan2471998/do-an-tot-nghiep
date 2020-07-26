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
    public partial class frm_phongchuyen : UserControl
    {
        frm_chuyenphong chuyenphong;
        public frm_phongchuyen(frm_chuyenphong _chuyenphong, string pSoPhong)
        {
            InitializeComponent();
            chuyenphong = _chuyenphong;
            labelmaphong.Text = pSoPhong;
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            chuyenphong.get_maph_moi(labelmaphong.Text);
            chuyenphong.enable_button();
        }
    }
}
