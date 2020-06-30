using Da.controller;
using DevExpress.Data.Mask;
using DevExpress.XtraEditors;
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

        connect conn = new connect();
        DataSet ds;
        SqlDataAdapter da;

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

        private void frm_tt_Load(object sender, EventArgs e)
        {
            cbb_hinhthuc.SelectedIndex = 0;
            string ngaytra = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss tt");
            txt_ngaytra.Text = ngaytra;

            get_thongtin_dichvu(txt_mathuephong.Text);
            dgv_thongtin_dichvu.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_thongtin_dichvu.Columns[3].DefaultCellStyle.Format = "N0";

            get_thongtin_phong(txt_mathuephong.Text);
            dgv_thongtin_phong.Columns[1].DefaultCellStyle.Format = "N0";
            dgv_thongtin_phong.Columns[2].DefaultCellStyle.Format = "N0";
        }

        private DateTime get_ngaynhan(string matp)
        {
            string sql = "select ngaynhan from phieuthue where matp = '" + matp + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (DateTime)cmd.ExecuteScalar();
        }

        DateTime ngaynhan;
        double giatien;
        double tienphong;

        private void get_thongtin_dichvu(string matp)
        {
            string sql = "select tendv, soluong, dongia, thanhtien from ct_hd_dichvu ct\n";
            sql += "inner join hd_dichvu hd on ct.MAHD_DICHVU = hd.MAHD_DICHVU\n";
            sql += "inner join dichvu dv on dv.madv = ct.madv\n";
            sql += "where hd.matp = '" + matp + "'";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "DICHVU");

            dgv_thongtin_dichvu.DataSource = ds.Tables["DICHVU"];
        }

        private void get_thongtin_phong(string matp)
        {
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
                    else if(time.Hours < 8)
                        giatien = time.Days * tienphong + (tienphong * 0.4);
                    else
                        giatien = time.Days * tienphong + (tienphong * 0.5);
                    newrow["maph"] = row["maph"];
                    newrow["giaphong"] = tienphong;
                    newrow["thanhtien"] = giatien;
                    phong.Rows.Add(newrow);
                }
            }

            dgv_thongtin_phong.DataSource = phong;
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
        }

        private void get_thanhtoan()
        {
            
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
                double tientratruoc = double.Parse(txt_tientratruoc.Text);
                double tongtien;
                if (chb_phuthu.Checked && !string.IsNullOrEmpty(txt_phuthu.Text))
                    tienphuthu = double.Parse(txt_phuthu.Text.Replace(",", ""));
                else
                    tienphuthu = 0;
                ThanhToanHoaDon thanhtoan = new ThanhToanHoaDon();
                foreach (DataGridViewRow row in dgv_thongtin_dichvu.Rows)
                {
                    tiendichvu += double.Parse(row.Cells[3].Value.ToString());
                }
                foreach (DataGridViewRow row1 in dgv_thongtin_phong.Rows)
                {
                    tienthuephong += double.Parse(row1.Cells[2].Value.ToString());
                }
                tongtien = tiendichvu + tienthuephong - tientratruoc + tienphuthu;
                thanhtoan.get_tongtien(tongtien);
                thanhtoan.get_thongtin_thanhtoan(tentt, tienthuephong, tiendichvu, txt_mathuephong.Text, tongtien);
                thanhtoan.get_maphieuthue(txt_mathuephong.Text);
                thanhtoan.StartPosition = FormStartPosition.CenterScreen;
                thanhtoan.ShowDialog();
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
    }
}
