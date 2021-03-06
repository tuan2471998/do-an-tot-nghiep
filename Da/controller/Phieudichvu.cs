﻿using System;
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
using DevExpress.CodeParser.Diagnostics;
using DevExpress.XtraBars.Painters;

namespace Da.controller
{
    public partial class Phieudichvu : DevExpress.XtraEditors.XtraUserControl
    {
        public connect conn;

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataSet ds_1 = new DataSet();

        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[2];

        public Phieudichvu(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }
        private void load_ct_thuephong()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "select ct.MATP, ct.MAPH from CT_THUEPHONG ct\n";
                sql += "inner join PHIEUTHUE pt on ct.MATP = pt.MATP\n";
                sql += "where TINHTRANG = 1";
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "CT_THUEPHONG");
                dgv_dsphieuthue.DataSource = ds.Tables["CT_THUEPHONG"];
                key1[0] = ds.Tables["CT_THUEPHONG"].Columns[0];
                key1[1] = ds.Tables["CT_THUEPHONG"].Columns[1];
                ds.Tables["CT_THUEPHONG"].PrimaryKey = key1;

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void load_ct_thuephong(string maph)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }

                string sql = "select cttp.*\n";
                sql += "from ct_thuephong cttp, phieuthue pt\n";
                sql += "where cttp.matp = pt.matp\n";
                sql += "and pt.tinhtrang = 1\n";
                sql += "and maph = '" + maph + "'";

                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "CT_THUEPHONG");
                dgv_dsphieuthue.DataSource = ds.Tables["CT_THUEPHONG"];
                key1[0] = ds.Tables["CT_THUEPHONG"].Columns[0];
                key1[1] = ds.Tables["CT_THUEPHONG"].Columns[1];
                ds.Tables["CT_THUEPHONG"].PrimaryKey = key1;

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        public void load_hd_dichvu()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                da = new SqlDataAdapter(" select * from HD_DICHVU where MATP='" + txt_matp.Text + "' and MAPH ='" + txt_maph.Text + "' ", conn.cnn);
                da.Fill(ds, "HD_DICHVU");
                dgv_phieudichvu.DataSource = ds.Tables["HD_DICHVU"];
                key[0] = ds.Tables["HD_DICHVU"].Columns[0];
                ds.Tables["HD_DICHVU"].PrimaryKey = key;

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void delete_dgv()
        {
            ds.Tables["HD_DICHVU"].Clear();
        }

        private void Phieudichvu_Load(object sender, EventArgs e)
        {
            txt_ngaylap.Text = DateTime.Now.ToString();
            load_ct_thuephong();
            load_hd_dichvu();
            sinhtudongMaHOADON();
            dgv_phieudichvu.Columns[4].DefaultCellStyle.Format = "N0";
        }

        private void btn_lap_Click(object sender, EventArgs e)
        {
            txt_maphdv.Text = sinhtudongMaHOADON();
            if (string.IsNullOrEmpty(txt_maphdv.Text))
            {
                MessageBox.Show("Chưa chọn mã phiếu thuê cần lập");
            }
            else
            {
                try
                {
                    if (conn.cnn.State == ConnectionState.Closed)
                    {
                        conn.cnn.Open();
                    }
                    DataRow insert_New = ds.Tables["HD_DICHVU"].NewRow();
                    insert_New["MAHD_DICHVU"] = txt_maphdv.Text;
                    insert_New["MATP"] = txt_matp.Text;
                    insert_New["MAPH"] = txt_maph.Text;
                    insert_New["NGAYSUDUNG"] = DateTime.Now;
                    insert_New["TONGTIEN"] = 0;
                    ds.Tables["HD_DICHVU"].Rows.Add(insert_New);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "HD_DICHVU");

                    conn.cnn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.cnn.Close();
                }
            }
            btn_lap.Enabled = false;
        }
        private string sinhtudongMaHOADON()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from HD_DICHVU", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "HD_DICHVU");
            DataTable dt1 = ds_ph.Tables["HD_DICHVU"];
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
            conn.cnn.Close();
            return "HDV" + bien2.ToString().Substring(1, 3);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            themchitietdichvu ctdv = new themchitietdichvu(this, conn);
            ctdv.get_mahddv(txt_maphdv.Text);
            simpleButton2.Enabled = false;
            txt_maphdv.Clear();
            ctdv.StartPosition = FormStartPosition.CenterScreen;
            ctdv.Show();
        }

        public void dgv_dsphieuthue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphdv.Clear();
            txt_matp.Text = dgv_dsphieuthue.CurrentRow.Cells[0].Value.ToString();
            txt_maph.Text = dgv_dsphieuthue.CurrentRow.Cells[1].Value.ToString();
            delete_dgv();
            load_hd_dichvu();
            btn_lap.Enabled = true;
        }

        private void clear_row_dgv_ctphieuthue()
        {
            foreach (DataGridViewRow row in dgv_dsphieuthue.Rows)
            {
                dgv_dsphieuthue.Rows.Remove(row);
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            clear_row_dgv_ctphieuthue();
            ds.Tables["CT_THUEPHONG"].Clear();
            load_ct_thuephong(txt_maphieuthue.Text);
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            clear_row_dgv_ctphieuthue();
            txt_maphieuthue.Clear();
            ds.Tables["CT_THUEPHONG"].Clear();
            load_ct_thuephong();
        }

        private void dgv_phieudichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maphdv.Text = dgv_phieudichvu.CurrentRow.Cells[0].Value.ToString();
            txt_maph.Text = dgv_phieudichvu.CurrentRow.Cells[2].Value.ToString();
            txt_ngaylap.Text = dgv_phieudichvu.CurrentRow.Cells[3].Value.ToString();

            if (double.Parse(dgv_phieudichvu.CurrentRow.Cells[4].Value.ToString()) != 0)
            {
                btn_xemchitiet.Enabled = true;
                simpleButton2.Enabled = false;
            }
            else
            {
                btn_xemchitiet.Enabled = false;
                simpleButton2.Enabled = true;
            }

        }

        private void btn_xemchitiet_Click(object sender, EventArgs e)
        {
            chitiet_hoadon_dichvu ct = new chitiet_hoadon_dichvu(conn);
            ct.get_mahddv(txt_maphdv.Text);
            ct.StartPosition = FormStartPosition.CenterScreen;
            ct.Show();
        }

        private void txt_maphieuthue_Click(object sender, EventArgs e)
        {
            txt_maphieuthue.Clear();
        }
    }
    
}
