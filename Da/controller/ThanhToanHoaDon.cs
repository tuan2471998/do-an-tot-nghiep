using Da.controller;
using Da.report;
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

namespace Da
{
    public partial class ThanhToanHoaDon : Form
    {
        private frm_tt tt;

        string matt;
        string mahd;
        string ma_cthd;
        string tentt;
        double tienphong;
        double tiendv;
        double tienphuthu;
        string ghichu_phuthu;
        string matp;
        double tienmat;
        double tienthe;
        double tongtien;
        string thanhtoan;
        int dem = 0;
        DataSet ds;
        SqlDataAdapter da;
        public connect conn;

        public ThanhToanHoaDon(frm_tt _frm_tt, connect _conn)
        {
            InitializeComponent();
            tt = _frm_tt;
            conn = _conn;
        }

        public void get_tongtien(double tongtien)
        {
            txt_tongtien.Text = tongtien.ToString();
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

        private void txt_tralai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tralai.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tralai.Text, System.Globalization.NumberStyles.Any);
                txt_tralai.Text = String.Format(culture, "{0:N0}", value);
                txt_tralai.Select(txt_tralai.Text.Length, 0);
            }
        }

        private void txt_khachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        double tiendu = 0;
        private void txt_khachdua_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_khachdua.Text))
            {
                tiendu = (double.Parse(txt_khachdua.Text) - double.Parse(txt_tongtien.Text));
                txt_tralai.Text = tiendu.ToString();
                if (tiendu >= 0)
                {
                    btn_luuvain.Enabled = true;
                    btn_thanhtoanthe.Enabled = false;
                }
                else
                {
                    btn_luuvain.Enabled = false;
                    btn_thanhtoanthe.Enabled = true;
                }
            }
            else
            {
                txt_tralai.Clear();
                btn_thanhtoanthe.Enabled = false;
            }
        }

        private void btn_thanhtoanthe_Click(object sender, EventArgs e)
        {
            dem = 1;
            tienthe = double.Parse(txt_tongtien.Text) - double.Parse(txt_khachdua.Text);
            tienmat = double.Parse(txt_khachdua.Text);
            txt_khachdua.Text = (tienmat + tienthe).ToString();
            txt_tralai.Text = "0";
            btn_thanhtoanthe.Enabled = false;
            btn_luuvain.Enabled = true;
        }


        public void get_thongtin_thanhtoan(string _tentt, double _tienphong, double _tiendv, string _matp, double _tongtien, double _tienphuthu, string _ghichu)
        {
            tentt = _tentt;
            tienphong = _tienphong;
            tiendv = _tiendv;
            matp = _matp;
            tongtien = _tongtien;
            tienphuthu = _tienphuthu;
            ghichu_phuthu = _ghichu;
        }

        private void create_mahd()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        public void get_thanhtoan(string _thanhtoan)
        {
            thanhtoan = _thanhtoan;
        }

        private void get_mathanhtoan()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select MATT from THANHTOAN where TENTT like N'%" + thanhtoan + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                matt = (string)cmd.ExecuteScalar();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void luu_hoadon()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                get_mathanhtoan();
                DataRow insert_New = ds.Tables["HOADON"].NewRow();
                insert_New["MAHD"] = mahd;
                insert_New["MATT"] = matt;
                insert_New["MANV_LAPPHIEU"] = Properties.Settings.Default.MaNV;
                if (dem == 0)
                {
                    insert_New["TIENMAT"] = double.Parse(txt_khachdua.Text);
                    insert_New["TIENTHE"] = 0;
                }
                else
                {
                    insert_New["TIENMAT"] = tienmat;
                    insert_New["TIENTHE"] = tienthe;
                }
                insert_New["TONGTIEN"] = tongtien;
                insert_New["SOLANIN"] = 1;
                insert_New["NGAYLAP"] = DateTime.Now;

                ds.Tables["HOADON"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "HOADON");

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void create_macthd()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }
        private void luu_chitiethoadon()
        {
            try
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
                insert_New["GHICHU_PHUTHU"] = ghichu_phuthu;

                ds.Tables["CT_HD"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "CT_HD");

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void update_solanin()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
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

        string maphieuthue;
        public void get_maphieuthue(string _maphieuthue)
        {
            maphieuthue = _maphieuthue;
        }

        DataSet ds_ph;
        SqlDataAdapter da_ph;
        DataColumn[] key = new DataColumn[1];

        private void chuyen_trang_thai_phong()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select MAPH from CT_THUEPHONG where MATP = '" + maphieuthue + "'", conn.cnn);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void chuyen_trangthai_phieuthue()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select * from PHIEUTHUE where MATP = '" + maphieuthue + "'", conn.cnn);
                da.Fill(ds, "PHIEUTHUE");
                key[0] = ds.Tables["PHIEUTHUE"].Columns[0];
                ds.Tables["PHIEUTHUE"].PrimaryKey = key;
                DataRow update_New = ds.Tables["PHIEUTHUE"].Rows.Find(maphieuthue);
                if (update_New != null)
                {
                    update_New["TINHTRANG"] = 0;

                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "PHIEUTHUE");
                }

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
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

        private void btn_luuvain_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                if (string.IsNullOrEmpty(txt_khachdua.Text))
                {
                    MessageBox.Show("Chưa nhập số tiền khách đưa");
                    txt_khachdua.Focus();
                }
                else
                {
                    luu_thongtin_thanhtoan();
                    lb_count.Text = get_solanin().ToString();
                    chuyen_trang_thai_phong();
                    chuyen_trangthai_phieuthue();
                    //kiemtra();
                    //if (!string.IsNullOrEmpty(kt))
                    //{
                    //    Viewer_DichVu dichvu = new Viewer_DichVu(this, conn);
                    //    dichvu.get_matp(maphieuthue);
                    //    dichvu.StartPosition = FormStartPosition.CenterScreen;
                    //    dichvu.Show();
                    //}
                    Viewer_Tong viewer = new Viewer_Tong(this, conn);
                    viewer.get_matp(maphieuthue);
                    viewer.StartPosition = FormStartPosition.CenterScreen;
                    viewer.Show();
                }
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void ThanhToanHoaDon_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason != CloseReason.FormOwnerClosing)
                tt.Close();
        }
    }
}
