using Da.controller;
using Da.report;
using DevExpress.Data.Mask;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Data;
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
    public partial class frm_tt : Form
    {
        public frm_tt()
        {
            InitializeComponent();
        }

        public frm_tt(frm_danhsachphong _frm_danhsachphong, connect _conn)
        {
            InitializeComponent();
            dsphong = _frm_danhsachphong;
            conn = _conn;
        }

        public connect conn;
        DataSet ds;
        SqlDataAdapter da;
        private frm_danhsachphong dsphong;

        private void chb_phuthu_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_phuthu.Checked)
            {
                txt_phuthu.Visible = lb_ghichu.Visible = txt_ghichu.Visible = true;
            }
            else
            {
                txt_phuthu.Visible = lb_ghichu.Visible = txt_ghichu.Visible = false;
            }
        }

        public void get_thongtinphong(string mathuephong, string tenkh, string sdt, string ngayvao, string thoigian)
        {
            txt_mathuephong.Text = mathuephong;
            txt_tenkhachhang.Text = tenkh;
            txt_sdt.Text = sdt;
            txt_ngayvao.Text = ngayvao;
            txt_thoigian.Text = thoigian;
        }

        public void get_tiendichvu(string tiendichvu)
        {
            if (string.IsNullOrEmpty(tiendichvu))
            {
                txt_tiendichvu.Text = "0";
            }
            else
            {
                txt_tiendichvu.Text = string.Format("{0:0,0}", double.Parse(tiendichvu));
            }
        }

        public void get_tientratruoc(string tientratruoc)
        {
            if (string.IsNullOrEmpty(tientratruoc))
            {
                txt_tientratruoc.Text = "0";
            }
            else
            {
                txt_tientratruoc.Text = string.Format("{0:0,0}", double.Parse(tientratruoc));
            }
        }
        int kq_phieuthue_cha;
        private void kt_phieuthue_cha()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select count(matp_cha) from phieuthue where matp = '" + txt_mathuephong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            kq_phieuthue_cha = (int)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        string matp_cu;
        private void get_matp_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select matp_cha from phieuthue where matp = '" + txt_mathuephong.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            matp_cu = (string)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        DataSet ds_cu;
        SqlDataAdapter da_cu;
        double tiendv_cu = 0;
        double tienph_cu = 0;
        DateTime ngayvao_cu;
        DateTime ngayra_cu;

        private decimal get_tienphong(string maph)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select GIAPHONG from PHONG where MAPH = '" + maph + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (decimal)cmd.ExecuteScalar();
        }

        private void get_thoigian_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select NGAYNHAN, NGAYTRA from PHIEUTHUE where MATP = '" + matp_cu + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ngayvao_cu = Convert.ToDateTime(dr["NGAYNHAN"].ToString());
                ngayra_cu = Convert.ToDateTime(dr["NGAYTRA"].ToString());
            }
            dr.Close();

            conn.cnn.Close();
        }

        private void get_tien_dichvu_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select TONGTIEN from HD_DICHVU where MATP = '" + matp_cu + "'";

            ds_cu = new DataSet();
            da_cu = new SqlDataAdapter(sql, conn.cnn);
            da_cu.Fill(ds_cu, "DICHVU");

            foreach (DataRow row in ds_cu.Tables["DICHVU"].Rows)
            {
                tiendv_cu += double.Parse(row["TONGTIEN"].ToString());
            }

            conn.cnn.Close();
        }

        private void get_tien_phong_cu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select MAPH from CT_THUEPHONG where MATP = '" + matp_cu + "'";

            ds_cu = new DataSet();
            da_cu = new SqlDataAdapter(sql, conn.cnn);
            da_cu.Fill(ds_cu, "PHONG");

            TimeSpan time = ngayra_cu.Subtract(ngayvao_cu);

            foreach (DataRow row in ds_cu.Tables["PHONG"].Rows)
            {
                int songay;
                if (time.Days < 1)
                    songay = 1;
                else
                    songay = time.Days;
                tienph_cu += ( songay * double.Parse((get_tienphong(row["MAPH"].ToString())).ToString()) );
            }

            conn.cnn.Close();
        }

        private void frm_tt_Load(object sender, EventArgs e)
        {
            cbb_hinhthuc.SelectedIndex = 0;
            string ngaytra = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
            txt_ngaytra.Text = ngaytra;

            kt_phieuthue_cha();

            if (kq_phieuthue_cha == 0)
            {
                get_thongtin_dichvu(txt_mathuephong.Text);
                dgv_thongtin_dichvu.Columns[2].DefaultCellStyle.Format = "N0";
                dgv_thongtin_dichvu.Columns[3].DefaultCellStyle.Format = "N0";

                get_thongtin_phong(txt_mathuephong.Text);
            }
            else
            {
                get_matp_cu();
                lb_tienthuephongcu.Visible = true;
                txt_tienthuephongcu.Visible = true;

                get_thoigian_cu();
                get_tien_phong_cu();
                get_tien_dichvu_cu();
                txt_tienthuephongcu.Text = (tiendv_cu + tienph_cu).ToString("###,##");

                get_thongtin_dichvu(txt_mathuephong.Text);
                dgv_thongtin_dichvu.Columns[2].DefaultCellStyle.Format = "N0";
                dgv_thongtin_dichvu.Columns[3].DefaultCellStyle.Format = "N0";

                get_thongtin_phong(txt_mathuephong.Text);
            }
        }

        private DateTime get_ngaynhan(string matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select ngaynhan from phieuthue where matp = '" + matp + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (DateTime)cmd.ExecuteScalar();
        }

        DateTime ngaynhan;
        double giatien;
        double tienphong;

        private void get_thongtin_dichvu(string matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select tendv, soluong, dongia, thanhtien from ct_hd_dichvu ct\n";
            sql += "inner join hd_dichvu hd on ct.MAHD_DICHVU = hd.MAHD_DICHVU\n";
            sql += "inner join dichvu dv on dv.madv = ct.madv\n";
            sql += "where hd.matp = '" + matp + "'";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "DICHVU");

            dgv_thongtin_dichvu.DataSource = ds.Tables["DICHVU"];

            conn.cnn.Close();
        }

        DataTable menu;
        public void get_thongtin_menu(DataTable _menu)
        {
            menu = new DataTable();
            menu.Columns.Add("tentd");
            menu.Columns.Add("soluong");
            menu.Columns.Add("dongia");
            menu.Columns.Add("thanhtien");

            DataRow newrow;

            foreach (DataRow row in _menu.Rows)
            {
                newrow = menu.NewRow();
                newrow["tentd"] = row["tentd"].ToString();
                newrow["soluong"] = row["soluong"].ToString();
                newrow["dongia"] = row["dongia"].ToString();
                newrow["thanhtien"] = row["thanhtien"].ToString();

                menu.Rows.Add(newrow);
            }

            dgv_thongtin_thucdon.DataSource = menu;
        }

        private void get_thongtin_phong(string matp)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select tp.maph, giaphong from ct_thuephong tp\n";
            sql += "inner join phong ph on tp.maph = ph.maph\n";
            sql += "where tp.matp = '" + matp + "'";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "PHONG");

            DataTable phong = new DataTable();
            phong.Columns.Add("maph");
            phong.Columns.Add("giaphong");
            phong.Columns.Add("thanhtien");

            DataRow newrow;

            ngaynhan = get_ngaynhan(matp);
            TimeSpan time = DateTime.Now.Subtract(ngaynhan);

            foreach (DataRow row in ds.Tables["PHONG"].Rows)
            {
                if (time.Days == 0)
                {
                    newrow = phong.NewRow();
                    giatien = double.Parse(row["giaphong"].ToString());
                    newrow["maph"] = row["maph"];
                    newrow["giaphong"] = giatien;
                    newrow["thanhtien"] = giatien;
                    phong.Rows.Add(newrow);
                }
                else
                {
                    newrow = phong.NewRow();
                    tienphong = double.Parse(row["giaphong"].ToString());
                    if (time.Hours < 1)
                        giatien = time.Days * tienphong + 30000;
                    else if (time.Hours < 2)
                        giatien = time.Days * tienphong + 60000;
                    else if (time.Hours < 4)
                        giatien = time.Days * tienphong + 100000;
                    else if (time.Hours < 6)
                        giatien = time.Days * tienphong + (tienphong * 0.3);
                    else if (time.Hours < 8)
                        giatien = time.Days * tienphong + (tienphong * 0.4);
                    else
                        giatien = time.Days * tienphong + (tienphong * 0.5);
                    newrow["maph"] = row["maph"];
                    newrow["giaphong"] = tienphong.ToString("###,##");
                    newrow["thanhtien"] = giatien.ToString("###,##");
                    phong.Rows.Add(newrow);
                }
            }

            dgv_thongtin_phong.DataSource = phong;

            conn.cnn.Close();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(this, conn);
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
        }

        double tien_menu = 0;

        public void get_tienmenu()
        {
            foreach (DataGridViewRow row in dgv_thongtin_thucdon.Rows)
            {
                tien_menu += double.Parse(row.Cells[3].Value.ToString().Replace(",",""));
            }

            txt_tienthucdon.Text = string.Format("{0:0,0}", double.Parse(tien_menu.ToString()));
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (cbb_hinhthuc.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa chọn hình thức thanh toán");
            }
            else
            {
                string tentt = cbb_hinhthuc.Text;
                double tiendichvu = 0;
                double tienthuephong = 0;
                double tienphuthu;
                double tienmenu;
                double tientratruoc = double.Parse(txt_tientratruoc.Text);
                double tongtien;
                double tienphongcu = 0;
                
                if (chb_phuthu.Checked && !string.IsNullOrEmpty(txt_phuthu.Text))
                    tienphuthu = double.Parse(txt_phuthu.Text.Replace(",", ""));
                else
                    tienphuthu = 0;

                if (txt_tienthucdon.Visible == false)
                    tienmenu = 0;
                else
                    tienmenu = double.Parse(txt_tienthucdon.Text.Replace(",",""));

                if (txt_tienthuephongcu.Visible == true)
                {
                    tienphongcu = double.Parse(txt_tienthuephongcu.Text.Replace(",", ""));
                }

                foreach (DataGridViewRow row in dgv_thongtin_dichvu.Rows)
                {
                    tiendichvu += double.Parse(row.Cells[3].Value.ToString());
                }
                foreach (DataGridViewRow row1 in dgv_thongtin_phong.Rows)
                {
                    tienthuephong += double.Parse(row1.Cells[2].Value.ToString());
                }
                tongtien = tiendichvu + tienthuephong - tientratruoc + tienphuthu + tienmenu + tienphongcu;

                if (cbb_hinhthuc.SelectedIndex == 1)
                {
                    ThanhToanHoaDon thanhtoan = new ThanhToanHoaDon(this, conn);
                    thanhtoan.get_tongtien(tongtien);
                    thanhtoan.get_thongtin_thanhtoan(tentt, tienthuephong, tiendichvu, txt_mathuephong.Text, tongtien, tienphuthu, tienmenu, txt_ghichu.Text);
                    thanhtoan.get_maphieuthue(txt_mathuephong.Text);
                    thanhtoan.get_thanhtoan(cbb_hinhthuc.Text);
                    thanhtoan.get_thongtin_menu(menu);
                    thanhtoan.StartPosition = FormStartPosition.CenterScreen;
                    thanhtoan.ShowDialog();
                }
                else if (cbb_hinhthuc.SelectedIndex == 2)
                {
                    ThanhToanThe the = new ThanhToanThe(this, conn);
                    the.nguon("frm_thanhtoan");
                    the.get_matp_from_frmThanhtoan(txt_mathuephong.Text);
                    the.get_tien(tienthuephong, tiendichvu, tienmenu, tienphuthu, txt_ghichu.Text);
                    the.get_thongtin_thanhtoan(tongtien);
                    the.get_thongtin_menu(menu);
                    the.get_thanhtoan(cbb_hinhthuc.Text);
                    the.StartPosition = FormStartPosition.CenterScreen;
                    the.ShowDialog();
                }
            }
        }

        private void txt_phuthu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_phuthu.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_phuthu.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_phuthu.Text = String.Format(culture, "{0:N0}", value);
                txt_phuthu.Select(txt_phuthu.Text.Length, 0);
            }
        }      

        private void frm_tt_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsphong.Load_control_all();
        }

        public void enable_menu()
        {
            lb_tienthucdon.Visible = true;
            txt_tienthucdon.Visible = true;
        }
    }
}
