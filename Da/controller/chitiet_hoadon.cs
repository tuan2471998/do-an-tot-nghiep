using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class chitiet_hoadon : Form
    {
        public connect conn;
        string mahd;
        string matp;
        DataSet ds;
        SqlDataAdapter da;

        public chitiet_hoadon(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        public void get_mahd(string _mahd)
        {
            mahd = _mahd;
        }

        private void get_matp(string _mahd)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MATP from CT_HD where MAHD = '" + _mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            matp = (string)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        private void get_thongtin_phong(string _matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select tp.maph, giaphong from ct_thuephong tp\n";
            sql += "inner join phong ph on tp.maph = ph.maph\n";
            sql += "where tp.matp = '" + _matp + "'";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "PHONG");

            dgv_phong.DataSource = ds.Tables["PHONG"];

            conn.cnn.Close();
        }

        private void get_thongtin_dichvu(string _matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select hddv.MAPH, dv.TENDV, cthddv.DONGIA, cthddv.SOLUONG, cthddv.THANHTIEN ";
            sql += "from dichvu dv, ct_hd_dichvu cthddv, hd_dichvu hddv, phieuthue pt ";
            sql += "where cthddv.MADV = dv.MADV ";
            sql += "and hddv.MAHD_DICHVU = cthddv.MAHD_DICHVU ";
            sql += "and pt.MATP = hddv.MATP\n";
            sql += "and hddv.MATP = '" + _matp + "'";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "DICHVU");

            dgv_dichvu.DataSource = ds.Tables["DICHVU"];

            conn.cnn.Close();
        }

        private void get_thongtin_chitiet_hoadon(string _matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select distinct hd.MAHD, pt.MAKH, kh.HOTEN, pt.NGAYNHAN, hd.NGAYLAP, cthd.TIEN_PH, cthd.TIEN_DV, cthd.TIEN_MENU, cthd.TIEN_PHUTHU, hd.TONGTIEN, hd.TIENMAT, hd.TIENTHE, pt.TIENCOC\n";
            sql += "from hoadon hd, phieuthue pt, ct_thuephong cttp, ct_hd cthd, khachhang kh\n";
            sql += "where cthd.MAHD = hd.MAHD\n";
            sql += "and kh.MAKH = pt.MAKH\n";
            sql += "and pt.MATP = cthd.MATP\n";
            sql += "and pt.MATP = '" + _matp + "'";

            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_mahd.Text = dr["MAHD"].ToString();
                txt_khachhang.Text = dr["HOTEN"].ToString();
                txt_ngayvao.Text = Convert.ToDateTime(dr["NGAYNHAN"]).ToString("dd/MM/yyyy");
                txt_ngayra.Text = Convert.ToDateTime(dr["NGAYLAP"]).ToString("dd/MM/yyyy");
                txt_tienphong.Text = dr["TIEN_PH"].ToString();
                txt_tiendichvu.Text = dr["TIEN_DV"].ToString();
                txt_tienthucdon.Text = dr["TIEN_MENU"].ToString();
                txt_tienphuthu.Text = dr["TIEN_PHUTHU"].ToString();
                txt_tongtien.Text = dr["TONGTIEN"].ToString();
                txt_tienmat.Text = dr["TIENMAT"].ToString();
                txt_tienthe.Text = dr["TIENTHE"].ToString();
                txt_tiencoc.Text = dr["TIENCOC"].ToString();
            }

            dr.Close();
            conn.cnn.Close();
        }

        private void chitiet_hoadon_Load(object sender, EventArgs e)
        {
            get_matp(mahd);
            get_thongtin_phong(matp);
            get_thongtin_dichvu(matp);
            get_thongtin_chitiet_hoadon(matp);

            dgv_phong.Columns[1].DefaultCellStyle.Format = "N0";
            dgv_dichvu.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_dichvu.Columns[4].DefaultCellStyle.Format = "N0";
        }

        private void txt_tienphong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienphong.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienphong.Text, System.Globalization.NumberStyles.Any);
                txt_tienphong.Text = String.Format(culture, "{0:N0}", value);
                txt_tienphong.Select(txt_tienphong.Text.Length, 0);
            }
        }

        private void txt_tiendichvu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tiendichvu.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tiendichvu.Text, System.Globalization.NumberStyles.Any);
                txt_tiendichvu.Text = String.Format(culture, "{0:N0}", value);
                txt_tiendichvu.Select(txt_tiendichvu.Text.Length, 0);
            }
        }

        private void txt_tienthucdon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthucdon.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienthucdon.Text, System.Globalization.NumberStyles.Any);
                txt_tienthucdon.Text = String.Format(culture, "{0:N0}", value);
                txt_tienthucdon.Select(txt_tienthucdon.Text.Length, 0);
            }
        }

        private void txt_tienphuthu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienphuthu.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienphuthu.Text, System.Globalization.NumberStyles.Any);
                txt_tienphuthu.Text = String.Format(culture, "{0:N0}", value);
                txt_tienphuthu.Select(txt_tienphuthu.Text.Length, 0);
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tongtien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tongtien.Text, System.Globalization.NumberStyles.Any);
                txt_tongtien.Text = String.Format(culture, "{0:N0}", value);
                txt_tongtien.Select(txt_tongtien.Text.Length, 0);
            }
        }

        private void txt_tienmat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienmat.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienmat.Text, System.Globalization.NumberStyles.Any);
                txt_tienmat.Text = String.Format(culture, "{0:N0}", value);
                txt_tienmat.Select(txt_tienmat.Text.Length, 0);
            }
        }

        private void txt_tienthe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthe.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienthe.Text, System.Globalization.NumberStyles.Any);
                txt_tienthe.Text = String.Format(culture, "{0:N0}", value);
                txt_tienthe.Select(txt_tienthe.Text.Length, 0);
            }
        }

        private void txt_tiencoc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tiencoc.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tiencoc.Text, System.Globalization.NumberStyles.Any);
                txt_tiencoc.Text = String.Format(culture, "{0:N0}", value);
                txt_tiencoc.Select(txt_tiencoc.Text.Length, 0);
            }
        }
    }
}
