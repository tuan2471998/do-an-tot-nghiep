using Da.report;
using DevExpress.PivotGrid.QueryMode;
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
    public partial class ThanhToanThe : Form
    {
        private frm_tt tt;
        public connect conn;
        public ThanhToanThe(frm_tt _frm_tt, connect _conn)
        {
            InitializeComponent();
            tt = _frm_tt;
            conn = _conn;
        }

        DataSet ds;
        SqlDataAdapter da;

        public void get_thongtin_hoadon(double tien)
        {
            txt_khachdua.Text = txt_tongtien.Text = tien.ToString();
            txt_tralai.Text = "0";
        }

        public void nguon(string _nguon)
        {
            lb_nguon.Text = _nguon;
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tongtien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tongtien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_tongtien.Text = String.Format(culture, "{0:N0}", value);
                txt_tongtien.Select(txt_tongtien.Text.Length, 0);
            }
        }

        private void txt_khachdua_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_khachdua.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_khachdua.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_khachdua.Text = String.Format(culture, "{0:N0}", value);
                txt_khachdua.Select(txt_khachdua.Text.Length, 0);
            }
        }

        string matt;
        string mahd;
        string ma_cthd;
        string matp;
        string thanhtoan;

        private void create_mahd()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select * from HOADON", conn.cnn);
            da.Fill(ds, "HOADON");
            int max_mahd = 0;
            foreach (DataRow row in ds.Tables["HOADON"].Rows)
            {
                int stt = int.Parse(row["mahd"].ToString().Substring(2));
                if (max_mahd < stt)
                {
                    max_mahd = stt;
                }
            }
            if (max_mahd <= 8)
                mahd = "HD00" + (max_mahd + 1).ToString();
            else
                mahd = "HD0" + (max_mahd + 1).ToString();
            conn.cnn.Close();
        }

        public void get_thanhtoan(string _thanhtoan)
        {
            thanhtoan = _thanhtoan;
        }
        private void get_mathanhtoan()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MATT from THANHTOAN where TENTT like N'%" + thanhtoan + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            matt = (string)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        private void luu_hoadon()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            get_mathanhtoan();
            string tongtien = txt_tongtien.Text.Replace(",", "");
            tongtien = tongtien.Replace(" VNĐ", "");
            DataRow insert_New = ds.Tables["HOADON"].NewRow();
            insert_New["MAHD"] = mahd;
            insert_New["MATT"] = matt;
            insert_New["MANV_LAPPHIEU"] = Properties.Settings.Default.MaNV;
            insert_New["TIENMAT"] = 0;
            insert_New["TIENTHE"] = double.Parse(tongtien);
            insert_New["TONGTIEN"] = double.Parse(tongtien);
            insert_New["KHACHDUA"] = double.Parse(tongtien);
            insert_New["SOLANIN"] = 1;
            insert_New["NGAYLAP"] = DateTime.Now;

            ds.Tables["HOADON"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "HOADON");

            conn.cnn.Close();
        }

        private void create_macthd()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select * from CT_HD", conn.cnn);
            da.Fill(ds, "CT_HD");
            int max_macthd = 0;
            foreach (DataRow row in ds.Tables["CT_HD"].Rows)
            {
                int stt = int.Parse(row["mact_hd"].ToString().Substring(4));
                if (max_macthd < stt)
                {
                    max_macthd = stt;
                }
            }
            if (max_macthd <= 8)
                ma_cthd = "CTHD00" + (max_macthd + 1).ToString();
            else
                ma_cthd = "CTHD0" + (max_macthd + 1).ToString();

            conn.cnn.Close();
        }

        public void get_matp_from_frmTienmat(string _matp)
        {
            matp = _matp;
        }

        public void get_matp_from_frmThanhtoan(string _matp)
        {
            matp = _matp;
        }

        private void luu_chitiethoadon()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataRow insert_New = ds.Tables["CT_HD"].NewRow();
            insert_New["MACT_HD"] = ma_cthd;
            insert_New["MAHD"] = mahd;
            insert_New["MATP"] = matp;
            insert_New["TIEN_PH"] = tienphong;
            insert_New["TIEN_DV"] = tiendv;
            insert_New["TIEN_PHUTHU"] = tienphuthu;
            insert_New["GHICHU_PHUTHU"] = ghichu;

            ds.Tables["CT_HD"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "CT_HD");

            conn.cnn.Close();
        }

        double tienphong;
        double tiendv;
        double tienphuthu;
        string ghichu;

        public void get_tien(double _tienphong, double _tiendv, double _tienphuthu, string _ghichu)
        {
            tienphong = _tienphong;
            tiendv = _tiendv;
            tienphuthu = _tienphuthu;
            ghichu = _ghichu;
        }

        private void update_solanin()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "update HOADON set SOLANIN = SOLANIN + 1 where MAHD = '" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void luu_thongtin_thanhtoan()
        {
            if (lb_count.Text == "0")
            {
                create_mahd();
                luu_hoadon();
                create_macthd();
                luu_chitiethoadon();
            }
            else
            {
                update_solanin();
            }
        }

        public void get_thongtin_thanhtoan(double tongtien)
        {
            txt_khachdua.Text = tongtien.ToString();
            txt_tongtien.Text = tongtien.ToString();
            txt_tralai.Text = "0";
        }

        DataSet ds_ph;
        SqlDataAdapter da_ph;
        DataColumn[] key = new DataColumn[1];

        private void chuyen_trang_thai_phong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select MAPH from CT_THUEPHONG where MATP = '" + matp + "'", conn.cnn);
            da.Fill(ds, "MAPH");

            ds_ph = new DataSet();
            da_ph = new SqlDataAdapter("select * from PHONG", conn.cnn);
            da_ph.Fill(ds_ph, "PHONG");
            key[0] = ds_ph.Tables["PHONG"].Columns[0];
            ds_ph.Tables["PHONG"].PrimaryKey = key;
            foreach (DataRow row in ds.Tables["MAPH"].Rows)
            {
                string maph = row["MAPH"].ToString();
                DataRow update_New = ds_ph.Tables["PHONG"].Rows.Find(maph);
                if (update_New != null)
                {
                    update_New["TINHTRANG"] = 3;
                    update_New["TIME_DONDEP_KT"] = DateTime.Now.AddHours(2);

                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_ph);
                    da_ph.Update(ds_ph, "PHONG");
                }
            }
            conn.cnn.Close();
        }

        private void chuyen_trangthai_phieuthue()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHIEUTHUE where MATP = '" + matp + "'", conn.cnn);
            da.Fill(ds, "PHIEUTHUE");
            key[0] = ds.Tables["PHIEUTHUE"].Columns[0];
            ds.Tables["PHIEUTHUE"].PrimaryKey = key;
            DataRow update_New = ds.Tables["PHIEUTHUE"].Rows.Find(matp);
            if (update_New != null)
            {
                update_New["TINHTRANG"] = 0;

                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "PHIEUTHUE");
            }

            conn.cnn.Close();
        }

        private int get_solanin()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select SOLANIN from HOADON where MAHD = '" + mahd + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (int)cmd.ExecuteScalar();
        }

        string kt;

        private void kiemtra()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MAHD_DICHVU from hd_dichvu where matp = '" + matp + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            kt = (string)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        DataTable menu;

        public void get_thongtin_menu(DataTable _menu)
        {
            menu = new DataTable();
            menu.Columns.Add("tentd");
            menu.Columns.Add("soluong");
            menu.Columns.Add("dongia");
            menu.Columns.Add("thanhtien");

            DataRow newrow;
            foreach (DataRow row in _menu.Rows)
            {
                newrow = menu.NewRow();
                newrow["tentd"] = row["tentd"].ToString();
                newrow["soluong"] = row["soluong"].ToString();
                newrow["dongia"] = row["dongia"].ToString();
                newrow["thanhtien"] = row["thanhtien"].ToString();

                menu.Rows.Add(newrow);
            }
        }

        private string get_mamenu(string tenmenu)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select IDMENU from MENU where TENMENU like N'%" + tenmenu + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private void luu_ct_menu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            ds = new DataSet();
            da = new SqlDataAdapter(" select * from CT_MENU", conn.cnn);
            da.Fill(ds, "CT_MENU");

            foreach (DataRow row in menu.Rows)
            {
                DataRow insert_New = ds.Tables["CT_MENU"].NewRow();
                insert_New["MAHD"] = mahd;
                insert_New["IDMENU"] = get_mamenu(row["tentd"].ToString());
                insert_New["SOLUONG"] = int.Parse(row["soluong"].ToString());

                ds.Tables["CT_MENU"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "CT_MENU");
            }

            conn.cnn.Close();
        }

        private void btn_thanhtoanthe_Click(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            luu_thongtin_thanhtoan();
            luu_ct_menu();
            lb_count.Text = get_solanin().ToString();
            chuyen_trangthai_phieuthue();
            chuyen_trang_thai_phong();          
            kiemtra();
            if (!string.IsNullOrEmpty(kt))
            {
                Viewer_DichVu dichvu = new Viewer_DichVu(this, conn);
                dichvu.get_matp(matp);
                dichvu.StartPosition = FormStartPosition.CenterScreen;
                dichvu.Show();
            }
            Viewer_HoaDon viewer = new Viewer_HoaDon(this, conn);
            viewer.get_matp(matp);
            viewer.StartPosition = FormStartPosition.CenterScreen;
            viewer.Show();
            conn.cnn.Close();
        }

        private void ThanhToanThe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                tt.Close();
        }
    }
}
