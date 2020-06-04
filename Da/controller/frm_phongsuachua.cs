using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Da.controller
{
    public partial class frm_phongsuachua : UserControl
    {
        public frm_phongsuachua()
        {
            InitializeComponent();
        }
        private frm_danhsachphong _frm_danhsachphong;
        connect conn = new connect();
        public frm_phongsuachua(string sophong, frm_danhsachphong danhsachphong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
            _frm_danhsachphong = danhsachphong;
        }

        private void hoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "update PHONG set TINHTRANG = 0 where MAPH = '" + lb_sophong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            _frm_danhsachphong.Load_control_all();
        }
    }
}
