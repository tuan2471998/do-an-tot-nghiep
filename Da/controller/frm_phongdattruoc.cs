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
    public partial class frm_phongdattruoc : UserControl
    {
        public frm_phongdattruoc()
        {
            InitializeComponent();
        }

        connect conn = new connect();
        private frm_danhsachphong _frm_danhsachphong;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        public frm_phongdattruoc(string sophong, frm_danhsachphong danhsachphong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
            _frm_danhsachphong = danhsachphong;
        }

        private void lb_sophong_TextChanged(object sender, EventArgs e)
        {
            string sql = "select MADP from CT_PHIEUDAT where MAPH = '" + lb_sophong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            lb_maphieudat.Text = (string)cmd.ExecuteScalar();
        }

        private void xoaphong(string maphong)
        {
            string sql = "delete from CT_PHIEUDAT where MAPH = '" + maphong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
        }

        private void xoaphieudat(string maphieudat)
        {
            string sql = "delete from PHIEUDAT where MADP = '" + maphieudat + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
        }

        private void update_phong(string maphong)
        {
            string sql = "update PHONG set TINHTRANG = 0 where MAPH = '" + maphong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
        }

        private void update_soluong_phieudat(string maphieudat)
        {
            string sql = "update PHIEUDAT set SL_PHONG = SL_PHONG - 1 where MADP = '" + maphieudat + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
        }

        private void hủyĐặtToànBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ phòng trong phiếu đặt " + lb_maphieudat.Text + " không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                try
                {
                    da = new SqlDataAdapter(" select * from CT_PHIEUDAT where MADP = '" + lb_maphieudat.Text + "'", conn.cnn);
                    da.Fill(ds, "CT_PHIEUDAT");
                    foreach (DataRow row in ds.Tables["CT_PHIEUDAT"].Rows)
                    {
                        xoaphong(row["MAPH"].ToString());
                        update_phong(row["MAPH"].ToString());
                    }
                    xoaphieudat(lb_maphieudat.Text);
                    MessageBox.Show("Cập nhật thành công");
                    _frm_danhsachphong.Load_control_all();
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            }
        }

        private void hủyĐặtPhòngĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                xoaphong(lb_sophong.Text);
                update_soluong_phieudat(lb_maphieudat.Text);
                update_phong(lb_sophong.Text);

                string sql1 = "select count(*) from CT_PHIEUDAT where MADP='" + lb_maphieudat.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn.cnn);
                int kt = (int)cmd1.ExecuteScalar();
                if (kt == 0)
                {
                    xoaphieudat(lb_maphieudat.Text);
                }
                MessageBox.Show("Cập nhật thành công");
                _frm_danhsachphong.Load_control_all();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }

        }
    }
}
