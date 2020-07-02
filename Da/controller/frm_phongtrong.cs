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
    public partial class frm_phongtrong : UserControl
    {
        connect conn = new connect();
        private frm_danhsachphong _frm_danhsachphong;

        public frm_phongtrong()
        {
            InitializeComponent();
        }

        public frm_phongtrong(string sophong, frm_danhsachphong danhsachphong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
            _frm_danhsachphong = danhsachphong;
        }

        private void dọnDẹpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "update PHONG set TINHTRANG = 3, TIME_DONDEP_KT = '" + DateTime.Now.AddHours(2) + "' where MAPH = '" + lb_sophong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            conn.cnn.Close();
            _frm_danhsachphong.Load_control_all();
        }

        private void sửaChữaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "update PHONG set TINHTRANG = 4 where MAPH = '" + lb_sophong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
            if (kq == 1)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            conn.cnn.Close();
            _frm_danhsachphong.Load_control_all();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_thuephongtrong thuephong = new frm_thuephongtrong(_frm_danhsachphong);
            thuephong.get_maphong(lb_sophong.Text);
            thuephong.get_giaphong(lb_sophong.Text);
            thuephong.get_maphieuthue();
            thuephong.StartPosition = FormStartPosition.CenterScreen;
            thuephong.ShowDialog();
        }
    }
}
