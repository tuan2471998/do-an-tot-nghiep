﻿using System;
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
    public partial class frm_phongdattruoc : UserControl
    {
        public connect conn;
        private frm_danhsachphong _frm_danhsachphong;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        string sophong;

        public frm_phongdattruoc(frm_danhsachphong danhsachphong, connect _conn)
        {
            InitializeComponent();
            _frm_danhsachphong = danhsachphong;
            conn = _conn;
        }

        public void get_sophong(string _sophong)
        {
            sophong = _sophong;
        }

        private void lb_sophong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "select MADP from CT_PHIEUDAT where MAPH = '" + lb_sophong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                lb_maphieudat.Text = ((string)cmd.ExecuteScalar()).Trim();
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void xoaphong(string maphong, string mapd)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "delete from CT_PHIEUDAT where MAPH = '" + maphong + "' and MADP = '" + mapd + "'";
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

        private void xoaphieudat(string maphieudat)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "delete from PHIEUDAT where MADP = '" + maphieudat + "'";
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

        private void update_phong(string maphong, int tinhtrang)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "update PHONG set TINHTRANG = " + tinhtrang + " where MAPH = '" + maphong + "'";
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

        private void update_soluong_phieudat(string maphieudat)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "update PHIEUDAT set SL_PHONG = SL_PHONG - 1 where MADP = '" + maphieudat + "'";
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

        private void hủyĐặtToànBộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ phòng trong phiếu đặt " + lb_maphieudat.Text + " không ?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                try
                {
                    if (conn.cnn.State == ConnectionState.Closed)
                    {
                        conn.cnn.Open();
                    }
                    da = new SqlDataAdapter(" select * from CT_PHIEUDAT where MADP = '" + lb_maphieudat.Text + "'", conn.cnn);
                    da.Fill(ds, "CT_PHIEUDAT");
                    foreach (DataRow row in ds.Tables["CT_PHIEUDAT"].Rows)
                    {
                        xoaphong(row["MAPH"].ToString(), lb_maphieudat.Text);
                        update_phong(row["MAPH"].ToString(),0);
                    }
                    xoaphieudat(lb_maphieudat.Text);
                    MessageBox.Show("Cập nhật thành công");
                    _frm_danhsachphong.Load_control_all();
                    conn.cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.cnn.Close();
                }
            }
        }

        private void hủyĐặtPhòngĐangChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            try
            {
                xoaphong(lb_sophong.Text, lb_maphieudat.Text);
                update_soluong_phieudat(lb_maphieudat.Text);
                update_phong(lb_sophong.Text, 0);

                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }

                string sql1 = "select count(*) from CT_PHIEUDAT where MADP='" + lb_maphieudat.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, conn.cnn);
                int kt = (int)cmd1.ExecuteScalar();
                if (kt == 0)
                {
                    xoaphieudat(lb_maphieudat.Text);
                }
                MessageBox.Show("Cập nhật thành công");
                _frm_danhsachphong.Load_control_all();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }

        }

        private string sinhtudongMaphieuthue()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHIEUTHUE");
            DataTable dt1 = ds_ph.Tables["PHIEUTHUE"];
            int bien1;
            int bien2;
            int bien3 = 1;
            if (dt1 == null)
            {
                bien1 = 1;
                bien2 = bien1;
                bien3 = 1;
            }
            if (dt1.Rows.Count == 0)
            {
                return "TP001";
            }
            else
            {
                bien1 = dt1.Rows.Count + 1;
                bien2 = bien1;
                bien3 = 1;
            }

            while (bien2 < 999)
            {
                bien2 = bien1 + bien3;
                bien3 *= 10;
            }
            conn.cnn.Close();
            return "TP" + bien2.ToString().Substring(1, 3);
        }

        string manv;
        string makh;
        string madp;
        DateTime ngaynhan = DateTime.Now;
        string ngaytra;
        int soluong;
        string tinhtrang;

        public void themPhieuThue()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select * from PHIEUDAT where MADP = '" + lb_maphieudat.Text + "'", conn.cnn);
                da.Fill(ds, "PHIEUDAT");

                foreach (DataRow row in ds.Tables["PHIEUDAT"].Rows)
                {
                    manv = row["MANV"].ToString();
                    makh = row["MAKH"].ToString();
                    madp = row["MADP"].ToString();
                    ngaytra = row["NGAYTRA_DUKIEN"].ToString();
                    soluong = int.Parse(row["SL_PHONG"].ToString());
                    tinhtrang = row["TINHTRANG"].ToString();
                }
                string sql1 = "INSERT INTO PHIEUTHUE VALUES('" + maphieuthue + "','" + manv + "','" + makh + "','" + madp + "','" + ngaynhan + "','" + ngaytra + "'," + soluong + ",1,'" + tinhtrang + "', null)";
                SqlCommand cmd1 = new SqlCommand(sql1, conn.cnn);
                int kq = (int)cmd1.ExecuteNonQuery();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void themChiTietThue()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select MAPH from CT_PHIEUDAT where MADP = '" + lb_maphieudat.Text + "'", conn.cnn);
                da.Fill(ds, "DS_PHONG");
                foreach (DataRow row in ds.Tables["DS_PHONG"].Rows)
                {
                    string sql = "insert into CT_THUEPHONG values ('" + maphieuthue + "','" + row["MAPH"].ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    int kq = cmd.ExecuteNonQuery();
                }
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        string maphieuthue;
        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                maphieuthue = sinhtudongMaphieuthue();
                themPhieuThue();
                themChiTietThue();
                da = new SqlDataAdapter(" select * from CT_PHIEUDAT where MADP = '" + lb_maphieudat.Text + "'", conn.cnn);
                da.Fill(ds, "CT_PHIEUDAT");
                foreach (DataRow row in ds.Tables["CT_PHIEUDAT"].Rows)
                {
                    update_phong(row["MAPH"].ToString(), 1);
                    xoaphong(row["MAPH"].ToString(), lb_maphieudat.Text);
                }
                xoaphieudat(lb_maphieudat.Text);
                _frm_danhsachphong.Load_control_all();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void frm_phongdattruoc_Load(object sender, EventArgs e)
        {
            lb_sophong.Text = sophong;
        }
    }
}
