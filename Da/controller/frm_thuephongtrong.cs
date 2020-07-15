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
    public partial class frm_thuephongtrong : Form
    {
        public connect conn;
        DataSet ds;
        SqlDataAdapter da;
        private frm_danhsachphong _frm_danhsachphong;
        public frm_thuephongtrong(frm_danhsachphong danhsachphong, connect _conn)
        {
            InitializeComponent();
            _frm_danhsachphong = danhsachphong;
            conn = _conn;
        }

        public void get_maphong(string maphong)
        {
            txt_maphong.Text = maphong;
        }

        public void get_giaphong(string maphong)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select GIAPHONG from PHONG where MAPH = '" + maphong + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            txt_giathue.Text = string.Format("{0:0,0}", (decimal)cmd.ExecuteScalar());
            conn.cnn.Close();
        }

        public void get_maphieuthue()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            int max = 0;
            ds = new DataSet();
            da = new SqlDataAdapter("select MATP from PHIEUTHUE", conn.cnn);
            da.Fill(ds, "MATP");
            foreach (DataRow row in ds.Tables["MATP"].Rows)
            {
                int stt = int.Parse(row["MATP"].ToString().Substring(2));
                if (max < stt)
                    max = stt;
            }
            if (max >= 0 && max <= 8)
                txt_maphieuthue.Text = "TP00" + (max + 1).ToString();
            else if (max >= 9 && max <= 99)
                txt_maphieuthue.Text = "TP0" + (max + 1).ToString();
            else
                txt_maphieuthue.Text = "TP" + (max + 1).ToString();

            conn.cnn.Close();
        }

        private void frm_thuephongtrong_Load(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            da = new SqlDataAdapter("select * from KHACHHANG", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "KHACHHANG");

            foreach (DataRow row in ds.Tables["KHACHHANG"].Rows)
            {
                txt_cmnd.AutoCompleteCustomSource.Add(row["SOCMND"].ToString());
                txt_sdt.AutoCompleteCustomSource.Add(row["SDT"].ToString());
            }

            txt_cmnd.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_cmnd.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_sdt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_sdt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            conn.cnn.Close();
        }

        private void TimTenKH()
        {          
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                if (string.IsNullOrEmpty(txt_cmnd.Text))
                {
                    string sql = "select HOTEN, SOCMND from KHACHHANG where SDT = '" + txt_sdt.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txt_hoten.Text = (string)rd["HOTEN"];
                        txt_cmnd.Text = (string)rd["SOCMND"];
                    }
                    rd.Close();
                    btn_thuephong.Enabled = true;
                }
                else if (string.IsNullOrEmpty(txt_sdt.Text))
                {
                    string sql = "select HOTEN, SDt from KHACHHANG where SOCMND = '" + txt_cmnd.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        txt_hoten.Text = (string)rd["HOTEN"];
                        txt_sdt.Text = (string)rd["SDT"];
                    }
                    rd.Close();
                    btn_thuephong.Enabled = true;
                }
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Thông tin khách hàng không chính xác.\nVui lòng bổ sung thêm tại danh mục khách hàng");
                btn_thuephong.Enabled = false;
                conn.cnn.Close();
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int kiemtra()
        {
            DateTime ngaydat = Convert.ToDateTime(dtp_ngaythue.Value.ToShortDateString());
            DateTime ngaytra = Convert.ToDateTime(dtp_ngaytra.Value.ToShortDateString());
            DateTime hientai = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            if (!string.IsNullOrEmpty(txt_cmnd.Text) && !string.IsNullOrEmpty(txt_sdt.Text))
            {
                return 1;
            }
            else if (ngaydat > ngaytra || hientai < ngaydat || hientai < ngaytra)
            {
                return 1;
            }
            else
            {
                MessageBox.Show("Thông tin khách hàng không chính xác");
                return 0;
            }
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimTenKH();
            }
        }

        private string get_makh(string cmnd)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select MAKH from KHACHHANG where SOCMND = '" + cmnd + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private void themPhieuThue()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string manv = Properties.Settings.Default.MaNV.ToString();
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "PhieuThem");

            DataRow newRow = ds.Tables["PhieuThem"].NewRow();
            newRow[0] = txt_maphieuthue.Text;
            newRow[1] = manv;
            newRow[2] = get_makh(txt_cmnd.Text);
            newRow[4] = dtp_ngaythue.Value;
            newRow[5] = dtp_ngaytra.Value;
            newRow[6] = 1;
            newRow[7] = 1;
            newRow[8] = 0;

            ds.Tables["PhieuThem"].Rows.Add(newRow);
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuThem");

            conn.cnn.Close();
        }
        private void themChiTietPhieuTHUE()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from CT_THUEPHONG", conn.cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "CTPhieuThem");

            DataRow row = ds.Tables["CTPhieuThem"].NewRow();
            row[0] = txt_maphieuthue.Text;
            row[1] = txt_maphong.Text;

            ds.Tables["CTPhieuThem"].Rows.Add(row);
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTPhieuThem");

            conn.cnn.Close();
        }

        private void update_tinhtrang_phong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "update PHONG set TINHTRANG = 1 where MAPH = '" + txt_maphong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private string tao_makh()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string makh;
            int max = 0;
            ds = new DataSet();
            da = new SqlDataAdapter("select MAKH from KHACHHANG", conn.cnn);
            da.Fill(ds, "MAKH");
            foreach (DataRow row in ds.Tables["MAKH"].Rows)
            {
                int stt = int.Parse(row["MAKH"].ToString().Substring(2));
                if (max < stt)
                    max = stt;
            }
            if (max >= 0 && max <= 8)
                makh = "KH00" + (max + 1).ToString();
            else if (max >= 9 && max <= 98)
                makh = "KH0" + (max + 1).ToString();
            else
                makh = "KH" + (max + 1).ToString();
            return makh;
        }

        private void kiemtra_tenkh()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            if (string.IsNullOrEmpty(txt_hoten.Text))
            {
                string sql = "insert into KHACHHANG (MAKH, SOCMND, SDT) values ('" + tao_makh() + "','" + txt_cmnd.Text + "','" + txt_sdt.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = cmd.ExecuteNonQuery();
            }
            conn.cnn.Close();
        }

        private void btn_thuephong_Click(object sender, EventArgs e)
        {
            int kt = kiemtra();
            if (kt == 1)
            {
                string ngaythue = dtp_ngaythue.Value.ToString("dd/MM/yyyy");
                string ngaytra = dtp_ngaytra.Value.ToString("dd/MM/yyyy");
                kiemtra_tenkh();
                themPhieuThue();
                themChiTietPhieuTHUE();
                update_tinhtrang_phong();
                MessageBox.Show("Lập phiếu thuê thành công cho phòng " + txt_maphong.Text.Trim() + " từ ngày " + ngaythue + " đến ngày " + ngaytra);
                this.Close();
                _frm_danhsachphong.Load_control_all();
            }
        }
    }
}
