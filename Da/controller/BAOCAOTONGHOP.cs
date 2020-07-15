using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.CodeParser;

namespace Da.controller
{
    public partial class BAOCAOTONGHOP : UserControl
    {
        public connect conn;

        public BAOCAOTONGHOP(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }
        DataSet ds;
        SqlDataAdapter da;

        private void load_nhanvien()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select MANV, HOTEN from NHANVIEN";
            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "NHANVIEN");

            cbb_manhanvien.DisplayMember = "HOTEN";
            cbb_manhanvien.ValueMember = "MANV";
            cbb_manhanvien.DataSource = ds.Tables["NHANVIEN"];

            DataRow row = ds.Tables["NHANVIEN"].NewRow();
            row[1] = "Tất cả";
            ds.Tables["NHANVIEN"].Rows.InsertAt(row, 0);

            conn.cnn.Close();
        }

        DataTable dt_thuvao_15ngay;
        DataTable dt_chira_15ngay;
        DataTable dt_gop_15ngay;

        private void get_tienthuvao_15ngay()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            dt_thuvao_15ngay = new DataTable();
            dt_thuvao_15ngay.Columns.Add("ngaylap");
            dt_thuvao_15ngay.Columns.Add("tongtien");
            dt_thuvao_15ngay.Columns.Add("tiencoc");
            DataRow newrow;

            for (int i = 0; i < 15; i++)
            {
                DateTime a = DateTime.Now.AddDays(-14);
                a = a.AddDays(i);
                string temp = a.ToString("yyyy-MM-dd");

                string sql = "select hd.ngaylap, hd.tongtien, pt.tiencoc\n";
                sql += "from hoadon hd, ct_hd cthd, phieuthue pt\n";
                sql += "where hd.mahd = cthd.mahd\n";
                sql += "and cthd.matp = pt.matp\n";
                sql += "and convert(date, hd.ngaylap) = '" + temp + "'";

                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "thuvao_15ngay");

                newrow = dt_thuvao_15ngay.NewRow();
                newrow["ngaylap"] = a.ToString("dd-MM-yyyy");
                if (ds.Tables["thuvao_15ngay"].Rows.Count == 0)
                {
                    newrow["tongtien"] = 0;
                    newrow["tiencoc"] = 0;
                }
                else
                {
                    newrow["tongtien"] = decimal.Parse(ds.Tables["thuvao_15ngay"].Rows[0]["tongtien"].ToString()).ToString("###,##");
                    newrow["tiencoc"] = ds.Tables["thuvao_15ngay"].Rows[0]["tiencoc"];
                }

                dt_thuvao_15ngay.Rows.Add(newrow);

                ds.Tables["thuvao_15ngay"].Clear();
            }

            conn.cnn.Close();
        }

        private void get_tienchira_15ngay()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            dt_chira_15ngay = new DataTable();
            dt_chira_15ngay.Columns.Add("ngaynhaphang");
            dt_chira_15ngay.Columns.Add("tongtien");
            DataRow newrow;

            for (int i = 0; i < 15; i++)
            {
                DateTime a = DateTime.Now.AddDays(-14);
                a = a.AddDays(i);
                string temp = a.ToString("yyyy-MM-dd");

                string sql = "select ngaynhaphang, tongtien\n";
                sql += "from nhaphang\n";
                sql += "where convert(date, ngaynhaphang) =  '" + temp + "'";

                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "chira_15ngay");

                newrow = dt_chira_15ngay.NewRow();

                newrow["ngaynhaphang"] = a.ToString("dd-MM-yyyy");

                if (ds.Tables["chira_15ngay"].Rows.Count == 0)
                {
                    newrow["tongtien"] = 0;
                }
                else
                {
                    newrow["tongtien"] = decimal.Parse(ds.Tables["chira_15ngay"].Rows[0]["tongtien"].ToString()).ToString("###,##");
                }

                dt_chira_15ngay.Rows.Add(newrow);

                ds.Tables["chira_15ngay"].Clear();
            }

            conn.cnn.Close();
        }

        private void gopbang_15ngay()
        {
            dt_gop_15ngay = new DataTable();
            dt_gop_15ngay.Columns.Add("ngaylap");
            dt_gop_15ngay.Columns.Add("tongtien");
            dt_gop_15ngay.Columns.Add("tiencoc");
            dt_gop_15ngay.Columns.Add("tongthu");
            dt_gop_15ngay.Columns.Add("tiennhaphang");
            dt_gop_15ngay.Columns.Add("thucthu");
            DataRow newrow1;

            foreach (DataRow row in dt_thuvao_15ngay.Rows)
            {
                decimal tongtien = decimal.Parse(row["tongtien"].ToString().Replace(",", ""));
                decimal tiencoc = decimal.Parse(row["tiencoc"].ToString().Replace(",", ""));
                newrow1 = dt_gop_15ngay.NewRow();

                newrow1["ngaylap"] = row["ngaylap"];
                newrow1["tongtien"] = row["tongtien"];
                newrow1["tiencoc"] = row["tiencoc"];
                string tongthu = decimal.Parse((tongtien + tiencoc).ToString()).ToString("###,##");
                if (string.IsNullOrEmpty(tongthu))
                {
                    newrow1["tongthu"] = 0;
                }
                else
                {
                    newrow1["tongthu"] = tongthu;
                }

                dt_gop_15ngay.Rows.Add(newrow1);
            }

            foreach (DataRow row in dt_gop_15ngay.Rows)
            {
                foreach (DataRow row1 in dt_chira_15ngay.Rows)
                {
                    if (row["ngaylap"].ToString() == row1["ngaynhaphang"].ToString())
                    {
                        row["tiennhaphang"] = row1["tongtien"];
                    }
                }

                decimal thucthu = decimal.Parse(row["tongthu"].ToString().Replace(",","")) - decimal.Parse(row["tiennhaphang"].ToString().Replace(",", ""));
                if (thucthu == 0)
                {
                    row["thucthu"] = 0;
                }
                else
                {
                    row["thucthu"] = thucthu.ToString("###,##");
                }
            }

            dgv_baocaotonghop.DataSource = dt_gop_15ngay;
        }

        DataSet ds_thuvao;
        SqlDataAdapter da_thuvao;
        DataSet ds_chira;
        SqlDataAdapter da_chira;

        private void get_tienthuvao(string _tungay, string _denngay)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select hd.ngaylap, hd.tongtien, pt.tiencoc\n";
            sql += "from hoadon hd, ct_hd cthd, phieuthue pt\n";
            sql += "where hd.mahd = cthd.mahd\n";
            sql += "and cthd.matp = pt.matp\n";
            sql += "and convert(date, hd.ngaylap) between '" + _tungay + "' and '" + _denngay + "'\n";
            if (cbb_manhanvien.SelectedIndex > 0)
            {
                sql += "and hd.MANV_LAPPHIEU = '" + cbb_manhanvien.SelectedValue.ToString() + "'";
            }

            ds_thuvao = new DataSet();
            da_thuvao = new SqlDataAdapter(sql, conn.cnn);
            da_thuvao.Fill(ds_thuvao, "THUVAO");

            conn.cnn.Close();
        }

        private void get_tienchira(string _tungay, string _denngay)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select distinct tongtien\n";
            sql += "from nhaphang\n";
            sql += "where convert(date, ngaynhaphang) between '" + _tungay + "' and '" + _denngay + "'";
            if (cbb_manhanvien.SelectedIndex > 0)
            {
                sql += "and MANV = '" + cbb_manhanvien.SelectedValue.ToString() + "'";
            }

            ds_chira = new DataSet();
            da_chira = new SqlDataAdapter(sql, conn.cnn);
            da_chira.Fill(ds_chira, "CHIRA");

            conn.cnn.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgv_baocaotonghop.Columns)
            {
                if (col.Name == "Column1")
                {
                    col.Visible = false;
                }
            }

            string tungay = dtp_tungay.Value.ToString("yyyy-MM-dd");
            string denngay = dtp_denngay.Value.ToString("yyyy-MM-dd");
            get_tienthuvao(tungay, denngay);
            get_tienchira(tungay, denngay);

            double _tongtien = 0;
            double _tiencoc = 0;
            double _tongthu = 0;
            double _tiennhaphang = 0;
            double _thucthu = 0;

            foreach (DataRow row in ds_thuvao.Tables["THUVAO"].Rows)
            {
                _tongtien += double.Parse(row["tongtien"].ToString());
                _tiencoc += double.Parse(row["tiencoc"].ToString());
            }
            _tongthu = _tongtien + _tiencoc;

            foreach (DataRow row in ds_chira.Tables["CHIRA"].Rows)
            {
                _tiennhaphang += double.Parse(row["tongtien"].ToString());
            }
            _thucthu = _tongthu - _tiennhaphang;

            txt_tienhoadon.Text = _tongtien.ToString("###,##");
            txt_tiencoc.Text = _tiencoc.ToString("###,##");
            txt_tongthu.Text = _tongthu.ToString("###,##");
            txt_tiennhaphang.Text = _tiennhaphang.ToString("###,##");
            txt_thucthu.Text = _thucthu.ToString("###,##");

            DataTable dt = new DataTable();
            dt.Columns.Add("tongtien");
            dt.Columns.Add("tiencoc");
            dt.Columns.Add("tongthu");
            dt.Columns.Add("tiennhaphang");
            dt.Columns.Add("thucthu");

            dgv_baocaotonghop.DataSource = dt;

            DataRow dr = dt.NewRow();
            dr["tongtien"] = txt_tienhoadon.Text;
            dr["tiencoc"] = txt_tiencoc.Text;
            dr["tongthu"] = txt_tongthu.Text;
            dr["tiennhaphang"] = txt_tiennhaphang.Text;
            dr["thucthu"] = txt_thucthu.Text;

            dt.Rows.Add(dr);

            dgv_baocaotonghop.DataSource = dt;

        }

        private void BAOCAOTONGHOP_Load(object sender, EventArgs e)
        {
            get_tienthuvao_15ngay();
            get_tienchira_15ngay();
            gopbang_15ngay();
            load_nhanvien();
            cbb_manhanvien.SelectedIndex = 0;

            double tongtien = 0;
            double tiencoc = 0;
            double tongthu = 0;
            double tiennhaphang = 0;
            double thucthu = 0;
            foreach (DataGridViewRow row in dgv_baocaotonghop.Rows)
            {
                tongtien += double.Parse(row.Cells[1].Value.ToString());
                tiencoc += double.Parse(row.Cells[2].Value.ToString());
                tongthu += double.Parse(row.Cells[3].Value.ToString());
                tiennhaphang += double.Parse(row.Cells[4].Value.ToString());
                thucthu += double.Parse(row.Cells[5].Value.ToString());
            }

            txt_tienhoadon.Text = tongtien.ToString("###,##");
            txt_tiencoc.Text = tiencoc.ToString("###,##");
            txt_tongthu.Text = tongthu.ToString("###,##");
            txt_tiennhaphang.Text = tiennhaphang.ToString("###,##");
            txt_thucthu.Text = thucthu.ToString("###,##");
        }
    }
}
