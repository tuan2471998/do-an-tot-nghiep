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
using DevExpress.Data.Mask;

namespace Da.controller
{
    public partial class frm_phongsudung : UserControl
    {
        public connect conn;

        private frm_danhsachphong dsphong;

        public frm_phongsudung(frm_danhsachphong _frm_danhsachphong, connect _conn)
        {
            InitializeComponent();
            dsphong = _frm_danhsachphong;
            conn = _conn;
        }

        string sophong;

        public void get_sophong(string _sophong)
        {
            sophong = _sophong;
        }

        DataSet ds;
        SqlDataAdapter da;
        string mathuephong;
        string tenkh;
        string sdt;
        string tientratruoc;
        decimal tiendichvu;
        DateTime ngayvao;
        string thoigian;
        public TimeSpan time;

        private void get_thongtin()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            mathuephong = lb_maphieudat.Text;
            string sql = "select hoten, sdt, ngaynhan, ngaytra, tiencoc from khachhang kh";
            sql += " inner join phieuthue pt on kh.makh = pt.makh";
            sql += " where pt.matp = '" + lb_maphieudat.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                tenkh = rd["hoten"].ToString();
                sdt = rd["sdt"].ToString();
                tientratruoc = rd["tiencoc"].ToString();
                ngayvao = rd.GetDateTime(2);
                time = DateTime.Now.Subtract(ngayvao);
                thoigian = time.Days.ToString() + " ngày " + time.Hours.ToString() + " giờ " + time.Minutes.ToString() + " phút";
            }
            rd.Close();
            conn.cnn.Close();
        }

        private void get_dichvu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select tongtien from hd_dichvu where matp = '" + mathuephong + "'", conn.cnn);
            da.Fill(ds, "TONGTIEN");
            foreach (DataRow row in ds.Tables["TONGTIEN"].Rows)
            {
                tiendichvu += decimal.Parse(row["tongtien"].ToString());
            }
            conn.cnn.Close();
        }

        private void get_tratruoc()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select tiencoc from phieuthue where matp = '" + mathuephong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (string.IsNullOrEmpty(rd["tiencoc"].ToString()))
                    tientratruoc = "0";
                else
                    tientratruoc = rd["tiencoc"].ToString();
            }
            rd.Close();
            conn.cnn.Close();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_thongtin();
            get_dichvu();
            get_tratruoc();
            Program.frm_tt = new frm_tt(dsphong, conn);
            Program.frm_tt.get_thongtinphong(mathuephong, tenkh, sdt, ngayvao.ToString("dd/MM/yyyy - hh:mm:ss tt"), thoigian);
            Program.frm_tt.get_tiendichvu(tiendichvu.ToString());
            Program.frm_tt.get_tientratruoc(tientratruoc);
            Program.frm_tt.StartPosition = FormStartPosition.CenterScreen;
            Program.frm_tt.ShowDialog();
        }

        private void lb_sophong_TextChanged(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select ctpt.matp from CT_THUEPHONG ctpt\n";
            sql += "inner join phieuthue pt on ctpt.MATP = pt.MATP\n";
            sql += "where maph = '" + lb_sophong.Text + "'\n";
            sql += "and tinhtrang = 1";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            lb_maphieudat.Text = ((string)cmd.ExecuteScalar()).Trim();

            conn.cnn.Close();
        }

        private void frm_phongsudung_Load(object sender, EventArgs e)
        {
            lb_sophong.Text = sophong;
        }

        private void chuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_chuyenphong frm = new frm_chuyenphong(conn, dsphong);
            frm.get_matp_cu(lb_maphieudat.Text, lb_sophong.Text);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }
    }
}
