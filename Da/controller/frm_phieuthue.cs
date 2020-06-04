using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Da.controller
{
    public partial class frm_phieuthue : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet ds;
        SqlDataAdapter da;
        DataSet ds_ph;
        SqlDataAdapter da_ph;
        connect conn = new connect();
        public frm_phieuthue()
        {

            InitializeComponent();
            dataGridView2.Controls.Clear();
        }

        private void load_cbb_loai()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da.Fill(ds, "LOAIPHONG");

            cbb_loai.DisplayMember = "TENLOAI";
            cbb_loai.ValueMember = "MALOAI";
            cbb_loai.DataSource = ds.Tables["LOAIPHONG"];
        }

        private void frm_phieuthue_Load(object sender, EventArgs e)
        {
            load_cbb_loai();

            cbb_loai.SelectedIndex = cbb_tang.SelectedIndex = 0;
            da = new SqlDataAdapter("select * from KHACHHANG", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "KHACHHANG");

            foreach (DataRow row in ds.Tables["KHACHHANG"].Rows)
            {
                txtMaKH.AutoCompleteCustomSource.Add(row["MAKH"].ToString());
                txtMaKH.AutoCompleteCustomSource.Add(row["SDT"].ToString());
            }
            txtMaKH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMaKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void Load_hinhanh()
        {
            panel_ph.Controls.Clear();
            int x = 0;
            int y = 0;
            int bac = 0;
            foreach (DataRow drPhong in ds_ph.Tables["PHONG"].Rows)
            {
                bool kq = kiemtra(drPhong);
                if (kq)
                {
                    //tạo control động cho các phòng , tạo user controll tương ứng cho mổi nút
                    frm_phong2 frm = new frm_phong2(drPhong[0].ToString());

                    frm.Location = new Point(x, y);
                    panel_ph.Controls.Add(frm);
                    x += 183;
                    if (bac >= 5)
                    {
                        y += 183;
                        x = 0;
                        bac = 0;

                    }
                    else
                    {
                        bac++;
                    }
                }
            }
        }

        private void Loadctroldong()
        {
            if (chb_tang.Checked && !chb_loai.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select MAPH from PHONG where TINHTRANG = 0 and VTPHONG = " + (cbb_tang.SelectedIndex + 1), conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && !chb_tang.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select MAPH from PHONG where TINHTRANG = 0 and MALOAI = '" + cbb_loai.SelectedValue.ToString() + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && chb_tang.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select MAPH from PHONG where TINHTRANG = 0 and MALOAI = '" + cbb_loai.SelectedValue.ToString() + "' and VTPHONG = " + (cbb_tang.SelectedIndex + 1), conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select MAPH from PHONG where TINHTRANG = 0", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
        }
        private string sinhtudongMaPhieuthue()
        {
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
            else
            {
                bien1 = dt1.Rows.Count + 2;
                bien2 = bien1;
                bien3 = 1;
            }

            while (bien2 < 999)
            {
                bien2 = bien1 + bien3;
                bien3 *= 10;
            }
            return "TP" + bien2.ToString().Substring(1, 3);
        }
        private bool kiemtra(DataRow drPhong)
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" +dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHONG1");
            DataTable dt1 = ds_ph.Tables["PHONG1"];

            foreach (DataRow dr in dt1.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return false;
                }
            }
            SqlDataAdapter da_phCTThue = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_THUEPHONG,PHIEUTHUE WHERE PHONG.MAPH=CT_THUEPHONG.MAPH AND CT_THUEPHONG.MATP=PHIEUTHUE.MATP AND NGAYNHAN<='" + dtp_ngaytra.Value + "' AND NGAYTRA >='" + dtp_ngaydat.Value + "'", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCTThue.Fill(ds_ph, "PHONG2");
            DataTable dt2 = ds_ph.Tables["PHONG2"];

            foreach (DataRow dr in dt2.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return false;
                }
            }
            return true;
        }
        DataSet ds_phchitiet = new DataSet();
        DataTable dt2chitiet;

        private void timer_phieuthue_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.value2 != 0.ToString() && Properties.Settings.Default.value2 != null)
            {
                if (kiemtratrongdatagridview(Properties.Settings.Default.value2.ToString().Trim().ToString()))
                {
                    SqlDataAdapter da_phCT = new SqlDataAdapter("select * from CT_THUEPHONG where MATP ='999999'", conn.cnn);
                    // Ánh xạ dữ liệu từ DB vào dataset
                    da_phCT.Fill(ds_phchitiet, "CHITIETTHUE");
                    dt2chitiet = ds_phchitiet.Tables["CHITIETTHUE"];

                    DataRow dr = dt2chitiet.NewRow();
                    dr[0] = sinhtudongMaPhieuthue();
                    dr[1] = Properties.Settings.Default.value2.ToString().Trim().ToString();

                    Properties.Settings.Default.value2 = 0.ToString();
                    dt2chitiet.Rows.Add(dr);

                    dataGridView2.DataSource = dt2chitiet;
                }
                else
                {

                    Properties.Settings.Default.value2 = 0.ToString();
                    MessageBox.Show("Phòng này đã chọn! Vui lòng chọn phòng khác!");
                }
            }
        }

        private bool kiemtratrongdatagridview(string v)
        {
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                if (dr.Cells[1].Value != null)
                {
                    if (dr.Cells[1].Value.ToString() == v)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            loadtextbox();
        }

        double tien;

        private double tinhtien()
        {
            tien = 0;
            if (dataGridView2.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter("select GIAPHONG from PHONG where MAPH = '" + row.Cells[1].Value.ToString() + "'", conn.cnn);
                    da.Fill(ds, "GIAPHONG");

                    tien += double.Parse(ds.Tables["GIAPHONG"].Rows[0]["GIAPHONG"].ToString());
                }
            }

            return tien;
        }

        private void loadtextbox()
        {
            double tiencoc = tinhtien();

            if (Properties.Settings.Default.MaNV != null && dataGridView2.Rows.Count > 0 && dataGridView2.Rows[0].Cells[0].Value != null)
            {

                textBoxmanhanvien.Text = Properties.Settings.Default.MaNV.ToString();
                textBoxmathuephong.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
                textBoxsl.Text = (dataGridView2.Rows.Count).ToString();
                textBoxtiencoc.Text = (tiencoc / 2).ToString();
            }
            else
            {
                textBoxmanhanvien.Text = "";
                textBoxmathuephong.Text = "";
                textBoxsl.Text = "";

                textBoxtiencoc.Text = "";
            }
        }
      
        private void reload()
        {

            textBoxmanhanvien.Text = "";
            textBoxmathuephong.Text = "";
            dtp_ngaydat.Value = dtp_ngaytra.Value = DateTime.Now.Date;
            textBoxsl.Text = ""; 
            panel_ph.Controls.Clear();
            textBoxtiencoc.Text = "";
            dt2chitiet.Clear();
            try
            {
                try
                {
                    for (int i = dataGridView2.Rows.Count - 2; i >= 0; i--)
                    {
                        dataGridView2.Rows.RemoveAt(i);
                    }

                }
                catch
                {
                    try
                    {
                        dataGridView2.Rows.Clear();
                    }
                    catch
                    {
                        dataGridView2.Controls.Clear();
                    }
                }
            }
            catch
            {
                dataGridView2.DataSource = null;
            }


        }
        private void themChiTietPhieuTHUE()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from CT_THUEPHONG", conn.cnn);


            // Tạo và lấp đầy DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "CTPhieuThem1");
           
            foreach (DataGridViewRow dr in dataGridView2.Rows)
            {
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                {
                    DataRow row = ds.Tables["CTPhieuThem1"].NewRow();
                    row[0] = dr.Cells[0].Value.ToString();
                    row[1] = dr.Cells[1].Value.ToString();
                    ds.Tables["CTPhieuThem1"].Rows.Add(row);
                }
            }
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTPhieuThem1");



        }

        private void themPhieuThue()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);


            // Tạo và lấp đầy DataSet
            ds = new DataSet();
            da.Fill(ds, "PhieuThem1");
            // Lấy thông tin Table vào DataTable
            // DataTable dt = ds.Tables["PhieuThem"];

            // Tạo thêm row mới
            DataRow newRow = ds.Tables["PhieuThem1"].NewRow();
            newRow[0] = textBoxmathuephong.Text;
            newRow[1] = textBoxmanhanvien.Text;
            newRow[2] = txtMaKH.Text;
            newRow[4] = dtp_ngaydat.Value;
            newRow[5] = dtp_ngaytra.Value;
            newRow[6] = int.Parse(textBoxsl.Text);
            newRow[7] = textBoxtiencoc.Text;
            //dt.Rows.Add(newRow);

            ds.Tables["PhieuThem1"].Rows.Add(newRow);
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuThem1");


        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (textBoxmanhanvien.Text.Length > 0 && string.IsNullOrEmpty(txtMaKH.Text) == false && textBoxtiencoc.Text.Length > 0 && textBoxmathuephong.Text.Length > 0 && textBoxsl.Text.Length > 0 )
            {
                try
                {
                    themPhieuThue();
                    themChiTietPhieuTHUE();

                    MessageBox.Show("Bạn đã thêm thành công !!!!!!");
                    reload();

                }
                catch
                {
                    MessageBox.Show("Bạn đã thêm thất bại !!!!!!");
                }

            }
            else
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ dữ liệu !!!!!");
            }

        }

        private void textBoxtiencoc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxtiencoc.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(textBoxtiencoc.Text, System.Globalization.NumberStyles.AllowThousands);
                textBoxtiencoc.Text = String.Format(culture, "{0:N0}", value);
                textBoxtiencoc.Select(textBoxtiencoc.Text.Length, 0);
            }
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

        private int kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaKH.Text) == true)
            {
                MessageBox.Show("Chưa nhập mã khách hàng");
                txtMaKH.Focus();
                return 0;
            }
            else if (dtp_ngaydat.Value >= dtp_ngaytra.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày đặt phòng");
                return 0;
            }
            else
                return 1;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            int kt = kiemtra();
            if (kt == 1)
            {
                Loadctroldong();
            }
        }

        DataSet ds_makh;
        SqlDataAdapter da_makh;

        private void TimMAKH()
        {
            ds_makh = new DataSet();
            da_makh = new SqlDataAdapter("select MAKH from KHACHHANG where SDT = '" + txtMaKH.Text + "'", conn.cnn);
            da_makh.Fill(ds_makh, "MAKH");

            if (ds_makh.Tables["MAKH"].Rows.Count != 0)
            {
                foreach (DataRow row in ds_makh.Tables["MAKH"].Rows)
                {
                    txtMaKH.Text = row["MAKH"].ToString();
                }
            }
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            TimMAKH();
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TimMAKH();
            }
        }

        
    }
}
