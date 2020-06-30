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
        public frm_phongsudung()
        {
            InitializeComponent();
        }
        connect conn = new connect();

        public frm_phongsudung(string sophong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
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
        }

        private void get_dichvu()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select tongtien from hd_dichvu where matp = '" + mathuephong + "'", conn.cnn);
            da.Fill(ds, "TONGTIEN");
            foreach (DataRow row in ds.Tables["TONGTIEN"].Rows)
            {
                tiendichvu += decimal.Parse(row["tongtien"].ToString());
            }
        }

        private void get_tratruoc()
        {
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
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            get_thongtin();
            get_dichvu();
            get_tratruoc();
            Program.frm_tt = new frm_tt();
            Program.frm_tt.get_thongtinphong(mathuephong, tenkh, sdt, ngayvao.ToString("dd/MM/yyyy - hh:mm:ss tt"), thoigian);
            Program.frm_tt.get_tiendichvu(tiendichvu.ToString());
            Program.frm_tt.get_tientratruoc(tientratruoc);
            Program.frm_tt.StartPosition = FormStartPosition.CenterScreen;
            Program.frm_tt.ShowDialog();
        }

        private void lb_sophong_TextChanged(object sender, EventArgs e)
        {
            string sql = "select ctpt.matp from CT_THUEPHONG ctpt\n";
            sql += "inner join phieuthue pt on ctpt.MATP = pt.MATP\n";
            sql += "where maph = '" + lb_sophong.Text + "'\n";
            sql += "and tinhtrang = 1";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            lb_maphieudat.Text = ((string)cmd.ExecuteScalar()).Trim();
        }
    }
}
