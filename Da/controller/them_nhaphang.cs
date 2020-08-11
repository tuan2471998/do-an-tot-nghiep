using DevExpress.XtraGrid.Views.BandedGrid.Drawing;
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
    public partial class them_nhaphang : Form
    {
        public connect conn;
        frm_Nhaphang nhaphang;

        public them_nhaphang(connect _conn, frm_Nhaphang _nhaphang)
        {
            InitializeComponent();
            conn = _conn;
            nhaphang = _nhaphang;
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        double thanhtien;

        private void load_cbb_loainhap()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select * from HANGNHAP";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "HANGNHAP");

                cbb_loainhap.ValueMember = "MAHANGNHAP";
                cbb_loainhap.DisplayMember = "TENHANGNHAP";
                cbb_loainhap.DataSource = ds.Tables["HANGNHAP"];

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void load_cbb_nhacungcap()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select * from NHACC";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "NHACC");

                cbb_nhacungcap.ValueMember = "MANCC";
                cbb_nhacungcap.DisplayMember = "TENNCC";
                cbb_nhacungcap.DataSource = ds.Tables["NHACC"];

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void load_cbb_loaihang_thietbi()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select * from THIETBI";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "THIETBI");

                cbb_loaihang.ValueMember = "MATB";
                cbb_loaihang.DisplayMember = "TENTB";
                cbb_loaihang.DataSource = ds.Tables["THIETBI"];

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void load_cbb_loaihang_menu()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select * from MENU";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "MENU");

                cbb_loaihang.ValueMember = "IDMENU";
                cbb_loaihang.DisplayMember = "TENMENU";
                cbb_loaihang.DataSource = ds.Tables["MENU"];

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void get_tennhanvien(string manv)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select HOTEN from NHANVIEN where MANV = '" + manv + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                txt_nhanvien.Text = (string)cmd.ExecuteScalar();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void get_thongtin_nhacc(string mancc)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select DIACHI_NCC, SDT from NHACC where MANCC = '" + mancc + "'";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "NHACC");

                foreach (DataRow row in ds.Tables["NHACC"].Rows)
                {
                    txt_diachincc.Text = row["DIACHI_NCC"].ToString();
                    txt_sdtncc.Text = row["SDT"].ToString();
                }

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        int stt = 0;
        int max = 0;
        string manhaphang;

        private void create_table_nhaphang()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from NHAPHANG", conn.cnn);
            da.Fill(ds, "NHAPHANG");
            key[0] = ds.Tables["NHAPHANG"].Columns[0];
            ds.Tables["NHAPHANG"].PrimaryKey = key;
        }
        private void create_table_ctnhaphang()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from CT_NHAPHANG", conn.cnn);
            da.Fill(ds, "CT_NHAPHANG");
            key[0] = ds.Tables["CT_NHAPHANG"].Columns[0];
            ds.Tables["CT_NHAPHANG"].PrimaryKey = key;
        }

        private void create_table_hang()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from HANG", conn.cnn);
            da.Fill(ds, "HANG");
            key[0] = ds.Tables["HANG"].Columns[0];
            ds.Tables["HANG"].PrimaryKey = key;
        }

        private void create_manhaphang()
        {
            create_table_nhaphang();

            foreach (DataRow row in ds.Tables["NHAPHANG"].Rows)
            {
                max = int.Parse(row["MANHAPHANG"].ToString().Substring(2));
                if (stt < max)
                {
                    stt = max;
                }
            }

            if (stt >= 0 && stt <= 8)
            {
                manhaphang = "NH00" + (stt + 1).ToString();
            }
            else if (stt >= 9 && stt <= 98)
            {
                manhaphang = "NH0" + (stt + 1).ToString();
            }
            else
            {
                manhaphang = "NH" + (stt + 1).ToString();
            }
        }

        private decimal get_tongtien_nhaphang(string ngaynhaphang)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select TONGTIEN from NHAPHANG where convert(date,NGAYNHAPHANG) = '" + ngaynhaphang + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (decimal)cmd.ExecuteScalar();
        }

        private void update_tongtien()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "update NHAPHANG set TONGTIEN = TONGTIEN + " + double.Parse(txt_thanhtien.Text.Replace(",", "")) + " where convert(date,NGAYNHAPHANG) = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();
        }

        private void luu_thongtin_nhaphang()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                DataRow insert_New = ds.Tables["NHAPHANG"].NewRow();
                insert_New["MANHAPHANG"] = manhaphang;
                insert_New["MANCC"] = cbb_nhacungcap.SelectedValue;
                insert_New["MANV"] = Properties.Settings.Default.MaNV;
                insert_New["NGAYNHAPHANG"] = DateTime.Now;
                if (kiemtra(DateTime.Now.ToString("yyyy-MM-dd")) == 0)
                {
                    insert_New["TONGTIEN"] = thanhtien;
                }
                else
                {
                    insert_New["TONGTIEN"] = get_tongtien_nhaphang(DateTime.Now.ToString("yyyy-MM-dd"));
                }


                ds.Tables["NHAPHANG"].Rows.Add(insert_New);

                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NHAPHANG");

                ds.Tables["NHAPHANG"].Clear();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void luu_thongtin_ctnhaphang()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                create_table_ctnhaphang();

                DataRow insert_New = ds.Tables["CT_NHAPHANG"].NewRow();
                insert_New["MANHAPHANG"] = manhaphang;
                insert_New["MAHANG"] = get_mahang(cbb_loaihang.SelectedValue.ToString());
                insert_New["SOLUONG_NHAP"] = int.Parse(txt_soluong.Text);
                insert_New["DONGIA_NHAP"] = int.Parse(txt_dongia.Text.Replace(",", ""));
                insert_New["THANHTIEN_HANG"] = thanhtien;

                ds.Tables["CT_NHAPHANG"].Rows.Add(insert_New);

                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "CT_NHAPHANG");

                ds.Tables["CT_NHAPHANG"].Clear();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void them_nhaphang_Load(object sender, EventArgs e)
        {
            tungay.Value = DateTime.Now;
            load_cbb_loainhap();
            load_cbb_nhacungcap();
            get_tennhanvien(Properties.Settings.Default.MaNV);
            create_table_gridview();
        }

        private void cbb_loainhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_loaihang.DataSource = null;
            if (cbb_loainhap.SelectedIndex == 0)
            {
                load_cbb_loaihang_thietbi();
            }
            else
            {
                load_cbb_loaihang_menu();
            }
        }

        private void cbb_nhacungcap_SelectedIndexChanged(object sender, EventArgs e)
        {
            get_thongtin_nhacc(cbb_nhacungcap.SelectedValue.ToString());
        }

        private void txt_dongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_dongia_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_soluong.Text) && !string.IsNullOrEmpty(txt_dongia.Text))
            {
                thanhtien = double.Parse(txt_soluong.Text.Replace(",", "")) * double.Parse(txt_dongia.Text);
                txt_thanhtien.Text = thanhtien.ToString();
            }
            else
            {
                txt_thanhtien.Clear();
            }
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_dongia.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_dongia.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_dongia.Text = String.Format(culture, "{0:N0}", value);
                txt_dongia.Select(txt_dongia.Text.Length, 0);
            }
        }

        private void txt_thanhtien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_thanhtien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_thanhtien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_thanhtien.Text = String.Format(culture, "{0:N0}", value);
                txt_thanhtien.Select(txt_thanhtien.Text.Length, 0);
            }
        }

        private int get_soluong(string tenhang)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select SOLUONGHANG from HANG where TENHANG = '" + tenhang + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (int)cmd.ExecuteScalar();
        }

        private string get_mahang(string tenhang)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MAHANG from HANG where TENHANG = '" + tenhang + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private int kiemtra()
        {
            if (string.IsNullOrEmpty(txt_soluong.Text))
            {
                MessageBox.Show("Chưa nhập số lượng hàng");
                return 0;
            }
            else if(string.IsNullOrEmpty(txt_dongia.Text))
            {
                MessageBox.Show("Chưa nhập đơn giá nhập hàng");
                return 0;
            }
            else
                return 1;
        }

        private void update_soluong_hang()
        {
            try
            {

                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                create_table_hang();

                DataRow update_New = ds.Tables["HANG"].Rows.Find(get_mahang(cbb_loaihang.SelectedValue.ToString()));
                if (update_New != null)
                {
                    update_New["SOLUONGHANG"] = get_soluong(cbb_loaihang.SelectedValue.ToString()) + int.Parse(txt_soluong.Text);

                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "HANG");
                }

                ds.Tables["HANG"].Clear();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private int kiemtra(string ngaynhaphang)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select count(*) from NHAPHANG where convert(date,NGAYNHAPHANG) = '" + ngaynhaphang + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (int)cmd.ExecuteScalar();
        }

        DataTable dt;

        private void create_table_gridview()
        {
            dt = new DataTable();
            dt.Columns.Add("ngaynhap");
            dt.Columns.Add("hangnhap");
            dt.Columns.Add("loaihang");
            dt.Columns.Add("nhanvien");
            dt.Columns.Add("dongia");
            dt.Columns.Add("soluong");
            dt.Columns.Add("thanhtien");
            dt.Columns.Add("ghichu");
        }

        DataRow dr;

        private void them_gridview()      
        {
            dr = dt.NewRow();

            dr["ngaynhap"] = tungay.Value.ToString();
            dr["hangnhap"] = cbb_loainhap.Text;
            dr["loaihang"] = cbb_loaihang.Text;
            dr["nhanvien"] = txt_nhanvien.Text;
            dr["dongia"] = txt_dongia.Text;
            dr["soluong"] = txt_soluong.Text;
            dr["thanhtien"] = txt_thanhtien.Text;
            dr["ghichu"] = txt_ghichu.Text;

            dt.Rows.Add(dr);

            dgv_nhaphang.DataSource = dt;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (kiemtra() == 1)
                {
                    update_soluong_hang();
                    if (kiemtra(DateTime.Now.ToString("yyyy-MM-dd")) > 0)
                    {
                        update_tongtien();
                    }
                    create_manhaphang();
                    luu_thongtin_nhaphang();
                    luu_thongtin_ctnhaphang();
                    them_gridview();

                    MessageBox.Show("Nhập hàng thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void them_nhaphang_FormClosing(object sender, FormClosingEventArgs e)
        {
            nhaphang.gop_data();
        }
    }
}
