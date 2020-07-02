using Da.controller;
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
    public partial class themchitietdichvu : Form
    {
        connect conn = new connect();
        DataSet ds_hd_dv = new DataSet();
        SqlDataAdapter da_hd_dv;
        DataSet ds_cthd = new DataSet();
        SqlDataAdapter da_cthd;
        DataSet ds_dv = new DataSet();
        SqlDataAdapter da_dv;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[2];
        private Phieudichvu _phieudichvu;

        public themchitietdichvu(Phieudichvu phieudichvu)
        {
            InitializeComponent();
            _phieudichvu = phieudichvu;
        }
        private void Themchitietdichvu_Load(object sender, EventArgs e)
        {
            Load_CT_HD_DV();
            load_cbo_dichvu();
            dgv_cthddv.Columns[3].DefaultCellStyle.Format = "N0";
            dgv_cthddv.Columns[4].DefaultCellStyle.Format = "N0";
        }

        private void Load_CT_HD_DV()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            da_cthd = new SqlDataAdapter(" select * from CT_HD_DICHVU where MAHD_DICHVU = '" + txt_mahddv.Text + "'", conn.cnn);
            da_cthd.Fill(ds_cthd, "CT_HD_DICHVU");
            dgv_cthddv.DataSource = ds_cthd.Tables["CT_HD_DICHVU"];
            key1[0] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[0];
            key1[1] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[1];
            ds_cthd.Tables["CT_HD_DICHVU"].PrimaryKey = key1;

            conn.cnn.Close();
        }

        private void Load_HD_DV()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds_hd_dv = new DataSet();
            da_hd_dv = new SqlDataAdapter("select * from HD_DICHVU", conn.cnn);
            da_hd_dv.Fill(ds_hd_dv, "HD_DICHVU");
            dgv_cthddv.DataSource = ds_hd_dv.Tables["HD_DICHVU"];
            key[0] = ds_hd_dv.Tables["HD_DICHVU"].Columns[0];
            ds_hd_dv.Tables["HD_DICHVU"].PrimaryKey = key;

            conn.cnn.Close();
        }

        private void load_cbo_dichvu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            da_dv = new SqlDataAdapter(" select * from DICHVU", conn.cnn);
            da_dv.Fill(ds_dv, "DICHVU");
            key[0] = ds_dv.Tables["DICHVU"].Columns[0];
            ds_dv.Tables["DICHVU"].PrimaryKey = key;

            cbo_dichvu.ValueMember = "MADV";
            cbo_dichvu.DisplayMember = "TENDV";
            cbo_dichvu.DataSource = ds_dv.Tables["DICHVU"];

            conn.cnn.Close();
        }

        public void get_mahddv(string mahddv)
        {
            txt_mahddv.Text = mahddv;
        }

        public double capnhat_dongia()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select GIADV_HIENTAI from DICHVU where MADV = '" + cbo_dichvu.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (double)((decimal)cmd.ExecuteScalar());
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void cbo_dichvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_dongia.Text = capnhat_dongia().ToString();
            if (!string.IsNullOrEmpty(txt_soluong.Text))
            {
                txt_thanhtien.Text = (double.Parse(txt_soluong.Text) * capnhat_dongia()).ToString();
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

        private void luu_thong_tin()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                DataRow insert_New = ds_cthd.Tables["CT_HD_DICHVU"].NewRow();
                insert_New["MAHD_DICHVU"] = txt_mahddv.Text;
                insert_New["MADV"] = cbo_dichvu.SelectedValue.ToString();
                insert_New["SOLUONG"] = txt_soluong.Text;
                insert_New["DONGIA"] = txt_dongia.Text;
                insert_New["THANHTIEN"] = txt_thanhtien.Text;

                ds_cthd.Tables["CT_HD_DICHVU"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_cthd);
                da_cthd.Update(ds_cthd, "CT_HD_DICHVU");

                conn.cnn.Close();
                //MessageBox.Show("Thêm Thành công");

            }
            catch
            {
                MessageBox.Show("Lỗi");
                conn.cnn.Close();
            }
        }

        double thanhtien;
        private void update_tongtien()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            thanhtien = 0;
            foreach (DataGridViewRow row in dgv_cthddv.Rows)
            {
                thanhtien += double.Parse(row.Cells[4].Value.ToString());
            }

            Load_HD_DV();
            dgv_cthddv.DataSource = ds_hd_dv.Tables["HD_DICHVU"];
            key[0] = ds_hd_dv.Tables["HD_DICHVU"].Columns[0];
            ds_hd_dv.Tables["HD_DICHVU"].PrimaryKey = key;

            DataRow update_New = ds_hd_dv.Tables["HD_DICHVU"].Rows.Find(txt_mahddv.Text);
            if (update_New != null)
            {
                update_New["TONGTIEN"] = thanhtien;

                SqlCommandBuilder cmb = new SqlCommandBuilder(da_hd_dv);
                da_hd_dv.Update(ds_hd_dv, "HD_DICHVU");
            }

            conn.cnn.Close();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            luu_thong_tin();
        }

        private void themchitietdichvu_FormClosing(object sender, FormClosingEventArgs e)
        {
            update_tongtien();
            _phieudichvu.load_hd_dichvu();
        }
    }
}
