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
        public ThanhToanHoaDon()
        {
            InitializeComponent();
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

        private void txt_khachdua_KeyUp(object sender, KeyEventArgs e)
        {
            double tiendu = 0;
            if (!string.IsNullOrEmpty(txt_khachdua.Text))
            {
                tiendu = (double.Parse(txt_khachdua.Text) - double.Parse(txt_tongtien.Text));
                txt_tralai.Text = tiendu.ToString();
            }
            else
            {
                txt_tralai.Clear();
            }
        }
        string matt;
        string mahd;
        string ma_cthd;
        string tentt;
        double tienphong;
        double tiendv;
        string matp;
        double tongtien;
        DataSet ds;
        SqlDataAdapter da;
        connect conn = new connect();

        public void get_thongtin_thanhtoan(string _tentt, double _tienphong, double _tiendv, string _matp, double _tongtien)
        {
            tentt = _tentt;
            tienphong = _tienphong;
            tiendv = _tiendv;
            matp = _matp;
            tongtien = _tongtien;
        }

        private void create_matt()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from THANHTOAN", conn.cnn);
            da.Fill(ds, "THANHTOAN");
            int max_matt = 0;
            foreach (DataRow row in ds.Tables["THANHTOAN"].Rows)
            {
                int stt = int.Parse(row["matt"].ToString().Substring(2));
                if (max_matt < stt)
                {
                    max_matt = stt;
                }
            }
            if (max_matt < 10)
                matt = "TT00" + (max_matt + 1).ToString();
            else
                matt = "TT0" + (max_matt + 1).ToString();
        }

        private void luu_thanhtoan()
        {
            DataRow insert_New = ds.Tables["THANHTOAN"].NewRow();
            insert_New["MATT"] = matt;
            insert_New["TENTT"] = tentt;

            ds.Tables["THANHTOAN"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "THANHTOAN");
        }

        private void create_mahd()
        {
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
            if (max_mahd < 10)
                mahd = "HD00" + (max_mahd + 1).ToString();
            else
                mahd = "HD0" + (max_mahd + 1).ToString();
        }
        private void luu_hoadon()
        {
            DataRow insert_New = ds.Tables["HOADON"].NewRow();
            insert_New["MAHD"] = mahd;
            insert_New["MATT"] = matt;
            insert_New["TONGTIEN"] = tongtien;

            ds.Tables["HOADON"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "HOADON");
        }

        private void create_macthd()
        {
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
            if (max_macthd < 10)
                ma_cthd = "CTHD00" + (max_macthd + 1).ToString();
            else
                ma_cthd = "CTHD0" + (max_macthd + 1).ToString();
        }
        private void luu_chitiethoadon()
        {
            DataRow insert_New = ds.Tables["CT_HD"].NewRow();
            insert_New["MACT_HD"] = ma_cthd;
            insert_New["MAHD"] = mahd;
            insert_New["MATP"] = matp;
            insert_New["TIEN_PH"] = tienphong;
            insert_New["TIEN_DV"] = tiendv;

            ds.Tables["CT_HD"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "CT_HD");
        }
        private void luu_thongtin_thanhtoan()
        {
            chuyen_trang_thai_phong();
            create_matt();
            luu_thanhtoan();
            create_mahd();
            luu_hoadon();
            create_macthd();
            luu_chitiethoadon();
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
        }

        private void chuyen_trangthai_phieuthue()
        {
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
        }

        private void btn_luukhongin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_khachdua.Text))
                {
                    MessageBox.Show("Chưa nhập số tiền khách đưa");
                    txt_khachdua.Focus();
                }
                else
                {
                    chuyen_trangthai_phieuthue();
                    luu_thongtin_thanhtoan();
                    MessageBox.Show("Lập hóa đơn thành công");
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_luuvain_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_khachdua.Text))
                {
                    MessageBox.Show("Chưa nhập số tiền khách đưa");
                    txt_khachdua.Focus();
                }
                else
                {
                    chuyen_trangthai_phieuthue();
                    luu_thongtin_thanhtoan();
                    MessageBox.Show("Lập hóa đơn thành công");
                    Program.frm_tt.Close();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}
