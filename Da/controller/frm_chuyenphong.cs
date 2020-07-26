using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frm_chuyenphong : Form
    {
        public connect conn;
        frm_danhsachphong dsph;
        public frm_chuyenphong(connect _conn, frm_danhsachphong _dsph)
        {
            InitializeComponent();
            conn = _conn;
            dsph = _dsph;
        }

        DataSet ds;
        SqlDataAdapter da;
        DataSet ds_ph;
        SqlDataAdapter da_ph;

        private void load_cbb_loai()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da.Fill(ds, "LOAIPHONG");

            cbb_loai.DisplayMember = "TENLOAI";
            cbb_loai.ValueMember = "MALOAI";
            cbb_loai.DataSource = ds.Tables["LOAIPHONG"];

            conn.cnn.Close();
        }

        private void frm_chuyenphong_Load(object sender, EventArgs e)
        {
            load_cbb_loai();
            Loadctroldong();
        }

        private void chb_tang_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_tang.Checked)
                cbb_tang.Enabled = true;
            else
            {
                cbb_tang.SelectedIndex = 0;
                cbb_tang.Enabled = false;
            }
        }

        private void chb_loai_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_loai.Checked)
                cbb_loai.Enabled = true;
            else
            {
                cbb_loai.SelectedIndex = 0;
                cbb_loai.Enabled = false;
            }
        }

        private bool kiemtra(DataRow drPhong)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select MAPH from PHONG where TINHTRANG = 0", conn.cnn);

            da_phCT.Fill(ds_ph, "PHONG1");
            DataTable dt1 = ds_ph.Tables["PHONG1"];

            foreach (DataRow dr in dt1.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return true;
                }
            }
            conn.cnn.Close();
            return false;
        }

        private void Load_hinhanh()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            panelphong.Controls.Clear();
            DataTable dtPHONG = ds_ph.Tables["PHONG"];
            int x = 0;
            int y = 0;
            int bac = 0;
            foreach (DataRow drPhong in dtPHONG.Rows)
            {
                bool kq = kiemtra(drPhong);
                if (kq)
                {
                    //tạo control động cho các phòng
                    frm_phongchuyen frm = new frm_phongchuyen(this, drPhong[0].ToString());

                    frm.Location = new Point(x, y);
                    panelphong.Controls.Add(frm);
                    x += 150;
                    if (bac >= 5)
                    {
                        y += 150;
                        x = 0;
                        bac = 0;

                    }
                    else
                    {
                        bac++;
                    }
                }
            }
            conn.cnn.Close();
        }

        private void Loadctroldong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            if (chb_tang.Checked && !chb_loai.Checked)
            {
                ds_ph = new DataSet();
                int index = cbb_tang.SelectedIndex + 1;
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG WHERE VTPHONG = '" + index + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && !chb_tang.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG WHERE PHONG.MALOAI='" + cbb_loai.SelectedValue + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && chb_tang.Checked)
            {
                ds_ph = new DataSet();
                int index = cbb_tang.SelectedIndex + 1;
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG WHERE VTPHONG = '" + index + "' AND MALOAI= '" + cbb_loai.SelectedValue + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            conn.cnn.Close();
        }

        string maph_cu;
        string maph_moi;
        string matp_cu;
        string matp_moi;

        public void get_matp_cu(string _matp_cu, string _maph_cu)
        {
            matp_cu = _matp_cu;
            maph_cu = _maph_cu;
        }

        public void get_maph_moi(string _maph_moi)
        {
            maph_moi = _maph_moi;
        }

        public void enable_button()
        {
            btn_chuyen.Enabled = true;
        }

        private void create_matp()
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
                matp_moi = "TP00" + (max + 1).ToString();
            else if (max >= 9 && max <= 99)
                matp_moi = "TP0" + (max + 1).ToString();
            else
                matp_moi = "TP" + (max + 1).ToString();

            conn.cnn.Close();
        }

        DataSet ds_phieuthue_cu;
        SqlDataAdapter da_phieuthue_cu;

        private void luu_phieuthue_moi()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            da_phieuthue_cu = new SqlDataAdapter("select * from PHIEUTHUE where MATP = '" + matp_cu + "'", conn.cnn);
            ds_phieuthue_cu = new DataSet();
            da_phieuthue_cu.Fill(ds_phieuthue_cu, "PHIEUTHUECU");

            string manv = Properties.Settings.Default.MaNV.ToString();
            da = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "PhieuThem");

            foreach (DataRow row in ds_phieuthue_cu.Tables["PHIEUTHUECU"].Rows)
            {
                DataRow newRow = ds.Tables["PhieuThem"].NewRow();
                newRow[0] = matp_moi;
                newRow[1] = manv;
                newRow[2] = row["MAKH"].ToString();
                newRow[4] = DateTime.Now;
                newRow[5] = row["NGAYTRA"].ToString();
                newRow[6] = row["SOLUONG"].ToString();
                newRow[7] = 1;
                newRow[8] = row["TIENCOC"].ToString();
                newRow[9] = matp_cu;

                ds.Tables["PhieuThem"].Rows.Add(newRow);
                SqlCommandBuilder builda = new SqlCommandBuilder(da);
                da.Update(ds, "PhieuThem");

            }

            conn.cnn.Close();
        }

        private void luu_ct_phieuthue_moi()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            da = new SqlDataAdapter("select * from CT_THUEPHONG", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "CTTP");

            DataRow newRow = ds.Tables["CTTP"].NewRow();
            newRow[0] = matp_moi;
            newRow[1] = maph_moi;

            ds.Tables["CTTP"].Rows.Add(newRow);
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTTP");

            conn.cnn.Close();
        }

        private void chuyen_trangthai_phong_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "update PHONG set TINHTRANG = 0 where MAPH = '" + maph_cu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void chuyen_trangthai_phong_moi()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "update PHONG set TINHTRANG = 1 where MAPH = '" + maph_moi + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void chuyen_trangthai_phieuthue_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "update PHIEUTHUE set TINHTRANG = 0, NGAYTRA = '" + DateTime.Now + "' where MATP = '" + matp_cu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            Loadctroldong();
        }

        private void btn_chuyen_Click(object sender, EventArgs e)
        {
            create_matp();
            luu_phieuthue_moi();
            luu_ct_phieuthue_moi();
            chuyen_trangthai_phong_cu();
            chuyen_trangthai_phong_moi();
            chuyen_trangthai_phieuthue_cu();
            MessageBox.Show("Chuyển phòng thành công");
            this.Close();
        }

        private void frm_chuyenphong_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsph.Load_control_all();
        }
    }
}
