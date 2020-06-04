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
using DevExpress.XtraTab;
using System.Data.SqlClient;
using DevExpress.Charts.Native;

namespace Da.controller
{
    public partial class frm_phieudatphong : DevExpress.XtraEditors.XtraUserControl
    {

        DataSet ds;
        SqlDataAdapter da;
        DataSet ds_ph;
        SqlDataAdapter da_ph;
        connect conn = new connect();
        DataColumn[] key = new DataColumn[1];
        public frm_phieudatphong()
        {
            InitializeComponent();
        }

        private void frm_phieudatphong_Load(object sender, EventArgs e)
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

        private void load_cbb_loai()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da.Fill(ds, "LOAIPHONG");

            cbb_loai.DisplayMember = "TENLOAI";
            cbb_loai.ValueMember = "MALOAI";
            cbb_loai.DataSource = ds.Tables["LOAIPHONG"];
        }

        private void Loadctroldong()
        {
 
            if (chb_tang.Checked && !chb_loai.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && !chb_tang.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else if (chb_loai.Checked && chb_tang.Checked)
            {
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                //load danh sach
                Load_hinhanh();
            }
            else
            {
                DataSet ds_ph = new DataSet();
                SqlDataAdapter da_ph = new SqlDataAdapter("select MAPH from PHONG", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");                                                                

                //load danh sach
                Load_hinhanh();
            }

        }

        private void Load_hinhanh()
        {
            panelphong.Controls.Clear();
            
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_ph = new SqlDataAdapter("select MAPH from PHONG", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_ph.Fill(ds_ph, "PHONG1");
            DataTable dtPHONG = ds_ph.Tables["PHONG1"];
            int x = 0;
            int y = 0;
            int bac = 0;
            foreach (DataRow drPhong in dtPHONG.Rows)
            {
                bool kq = kiemtra(drPhong);
                if (kq)
                {
                    //tạo control động cho các phòng
                    frm_phong frm = new frm_phong(drPhong[0].ToString());

                    frm.Location = new Point(x, y);
                    panelphong.Controls.Add(frm);
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

        private bool kiemtra(DataRow drPhong)
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHONG");
            DataTable dt1 = ds_ph.Tables["PHONG"];

            foreach (DataRow dr in dt1.Rows)
            {
                if (drPhong["MAPH"].ToString() == dr["MAPH"].ToString())
                {
                    return false;
                }
            }
            SqlDataAdapter da_phCTThue = new SqlDataAdapter("select PHONG.MAPH from PHONG,CT_PHIEUDAT,PHIEUDAT WHERE PHONG.MAPH=CT_PHIEUDAT.MAPH AND CT_PHIEUDAT.MADP=PHIEUDAT.MADP AND NGAYNHAN_DUKIEN<='" + dtp_ngaytra.Value + "' AND NGAYTRA_DUKIEN>='" + dtp_ngaydat.Value + "'", conn.cnn);
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
        DataTable dt1chitiet;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.value != 0.ToString() && Properties.Settings.Default.value != null)
            {
                if (kiemtratrongdatagridview(Properties.Settings.Default.value.ToString().Trim().ToString()))
                {
                    SqlDataAdapter da_phCT = new SqlDataAdapter("select * from CT_PHIEUDAT where MADP ='999999'", conn.cnn);
                    da_phCT.Fill(ds_phchitiet, "CHITIET");
                    dt1chitiet = ds_phchitiet.Tables["CHITIET"];

                    DataRow dr = dt1chitiet.NewRow();
                    dr[0] = sinhtudongMaPhieuDat();
                    dr[1] = Properties.Settings.Default.value.ToString().Trim().ToString();

                    Properties.Settings.Default.value = 0.ToString();
                    dt1chitiet.Rows.Add(dr);
                    dataGridViewchitiet.DataSource = dt1chitiet;
                }
                else
                {

                    Properties.Settings.Default.value = 0.ToString();
                    MessageBox.Show("Phòng này đã chọn! Vui lòng chọn phòng khác!");
                }
            }

        }

        private bool kiemtratrongdatagridview(string v)
        {
            foreach (DataGridViewRow dr in dataGridViewchitiet.Rows)
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

        private string sinhtudongMaPhieuDat()
        {
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHIEUDAT");
            DataTable dt1 = ds_ph.Tables["PHIEUDAT"];
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
            return "DP" + bien2.ToString().Substring(1, 3);
        }

        private void reload()
        {
            textBoxmanhanvien.Text = "";
            textBoxmaphieudat.Text = "";
            dtp_ngaydat.Value = dtp_ngaytra.Value = DateTime.Now.Date;
            panelphong.Controls.Clear();
            textBoxsoluong.Text = "";
            textBoxtiencoc.Text = "";
            dt1chitiet.Clear();
            dataGridViewchitiet.DataSource = null;
        }

        private void themChiTietPhieuDat()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from CT_PHIEUDAT", conn.cnn);

            // Tạo và lấp đầy DataSet
            DataSet ds = new DataSet();
            da.Fill(ds, "CTPhieuThem");

            foreach (DataGridViewRow dr in dataGridViewchitiet.Rows)
            {
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null)
                {
                    DataRow row = ds.Tables["CTPhieuThem"].NewRow();
                    row[0] = dr.Cells[0].Value.ToString();
                    row[1] = dr.Cells[1].Value.ToString();
                    ds.Tables["CTPhieuThem"].Rows.Add(row);
                }
            }
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "CTPhieuThem");
        }

        private void themPhieuDAt()
        {
            // Tạo Adapter
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);


            // Tạo và lấp đầy DataSet
            ds = new DataSet();
            da.Fill(ds, "PhieuThem");
            // Lấy thông tin Table vào DataTable
            // DataTable dt = ds.Tables["PhieuThem"];

            // Tạo thêm row mới
            DataRow newRow = ds.Tables["PhieuThem"].NewRow();
            newRow[0] = textBoxmaphieudat.Text;
            newRow[1] = textBoxmanhanvien.Text;
            newRow[2] = txtMaKH.Text;
            newRow[3] = dtp_ngaydat.Value;
            newRow[4] = dtp_ngaytra.Value;
            newRow[5] = int.Parse(textBoxsoluong.Text);
            newRow[6] = textBoxtiencoc.Text;
            //dt.Rows.Add(newRow);

            ds.Tables["PhieuThem"].Rows.Add(newRow);
            // Tiến hành insert vào database Source
            SqlCommandBuilder builda = new SqlCommandBuilder(da);
            da.Update(ds, "PhieuThem");
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewchitiet.CurrentRow != null)
            {
                dataGridViewchitiet.Rows.RemoveAt(dataGridViewchitiet.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
            }
        }

        double tien;

        private double tinhtien()
        {
            tien = 0;
            if (dataGridViewchitiet.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewchitiet.Rows)
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

            if (Properties.Settings.Default.MaNV != null && dataGridViewchitiet.Rows.Count > 0 && dataGridViewchitiet.Rows[0].Cells[0].Value != null)
            {
                textBoxmanhanvien.Text = Properties.Settings.Default.MaNV.ToString();
                textBoxmaphieudat.Text = dataGridViewchitiet.Rows[0].Cells[0].Value.ToString();
                textBoxsoluong.Text = dataGridViewchitiet.Rows.Count.ToString();
                textBoxtiencoc.Text = (tiencoc / 2).ToString();
            }
            else
            {
                textBoxmanhanvien.Text = "";
                textBoxmaphieudat.Text = "";
                textBoxsoluong.Text = "";
                textBoxtiencoc.Text = "";
            }
        }

        private void dataGridViewchitiet_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            loadtextbox();
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

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewchitiet.CurrentRow != null)
            {
                dataGridViewchitiet.Rows.RemoveAt(dataGridViewchitiet.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết cần xóa");
            }
        }

        private void chuyenTrangThaiPhong()
        {
            DataSet ds_phong = new DataSet();
            SqlDataAdapter da_phong = new SqlDataAdapter("select * from PHONG", conn.cnn);
            da_phong.Fill(ds_phong, "PHONG");
            key[0] = ds_phong.Tables["PHONG"].Columns[0];
            ds_phong.Tables["PHONG"].PrimaryKey = key;

            foreach (DataGridViewRow row in dataGridViewchitiet.Rows)
            {
                DataRow update = ds_phong.Tables["PHONG"].Rows.Find(row.Cells[1].Value.ToString());
                if (update != null)
                {
                    update["TINHTRANG"] = 2;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_phong);
                    da_phong.Update(ds_phong, "PHONG");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (textBoxmanhanvien.Text.Length > 0 && string.IsNullOrEmpty(txtMaKH.Text) == false && textBoxtiencoc.Text.Length > 0 && textBoxmaphieudat.Text.Length > 0 && textBoxsoluong.Text.Length > 0)
                {
                    try
                    {
                        chuyenTrangThaiPhong();
                        themPhieuDAt();
                        themChiTietPhieuDat();                       
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
                string a= dtp_ngaytra.ToString();
                string b = dtp_ngaydat.ToString();
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
