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

namespace Da.report
{
    public partial class Viewer_Tong : Form
    {
        public connect conn;
        private ThanhToanHoaDon tthd;
        private ThanhToanThe ttt;

        string matp;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataAdapter da_hd;
        DataSet ds_hd;
        SqlDataAdapter da_dv;
        DataSet ds_dv;
        public Viewer_Tong(ThanhToanHoaDon _thanhtoan, connect _conn)
        {
            InitializeComponent();
            tthd = _thanhtoan;
            conn = _conn;
        }

        public Viewer_Tong(ThanhToanThe _thanhtoan, connect _conn)
        {
            InitializeComponent();
            ttt = _thanhtoan;
            conn = _conn;
        }

        public void get_matp(string _matp)
        {
            matp = _matp;
        }

        private void Viewer_Tong_Load(object sender, EventArgs e)
        {          
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string clear_tt = "drop view if exists thongtinhoadon\n";
                SqlCommand cmd_tt = new SqlCommand(clear_tt, conn.cnn);
                int kq_clear_tt = cmd_tt.ExecuteNonQuery();

                string sql_tt = "create view thongtinhoadon\n";
                sql_tt += "as\n";
                sql_tt += "select pt.matp, hd.mahd, nv.HOTEN as 'thu ngan', kh.hoten as 'khach hang', pt.ngaynhan, hd.ngaylap, hd.tongtien, pt.tiencoc, hd.tienmat, hd.tienthe\n";
                sql_tt += "from hoadon hd, ct_hd cthd, khachhang kh, phieuthue pt, nhanvien nv\n";
                sql_tt += "where hd.MAHD = cthd.MAHD\n";
                sql_tt += "and pt.MAKH = kh.MAKH\n";
                sql_tt += "and nv.MANV = MANV_LAPPHIEU\n";
                sql_tt += "and cthd.MATP = pt.MATP\n";

                SqlCommand cmd_intt = new SqlCommand(sql_tt, conn.cnn);
                int kq_intt = cmd_intt.ExecuteNonQuery();

                string sql_matptt = "select * from thongtinhoadon where matp = '" + matp + "'";

                da = new SqlDataAdapter(sql_matptt, conn.cnn);
                ds = new DataSet();
                da.Fill(ds, "THONGTIN");

                /*=================================================================*/

                string clear_hd = "drop view if exists inhoadon\n";
                SqlCommand cmd_hd = new SqlCommand(clear_hd, conn.cnn);
                int kq_clear_hd = cmd_hd.ExecuteNonQuery();

                string sql_hd = "create view inhoadon\n";
                sql_hd += "as\n";
                sql_hd += "select pt.matp, cttp.maph, ph.giaphong\n";
                sql_hd += "from ct_thuephong cttp, phieuthue pt, phong ph\n";
                sql_hd += "where cttp.MAPH = ph.MAPH\n";
                sql_hd += "and cttp.MATP = pt.MATP\n";

                SqlCommand cmd_inhd = new SqlCommand(sql_hd, conn.cnn);
                int kq_inhd = cmd_inhd.ExecuteNonQuery();

                string sql_matp = "select * from inhoadon where matp = '" + matp + "'";

                da_hd = new SqlDataAdapter(sql_matp, conn.cnn);
                ds_hd = new DataSet();
                da_hd.Fill(ds_hd, "HOADON");

                Report_HoaDon report_hd = new Report_HoaDon();
                report_hd.SetDataSource(ds_hd.Tables["HOADON"]);

                /*=================================================================*/

                string clear_dv = "drop view if exists indichvu";
                SqlCommand cmd_dv = new SqlCommand(clear_dv, conn.cnn);
                int kq_clear_dv = cmd_dv.ExecuteNonQuery();

                string sql_dv = "create view indichvu\n";
                sql_dv += "as\n";
                sql_dv += "select pt.matp, hddv.maph, dv.tendv, cthddv.soluong, cthddv.dongia, cthddv.thanhtien\n";
                sql_dv += "from phieuthue pt, hd_dichvu hddv, ct_hd_dichvu cthddv, dichvu dv \n";
                sql_dv += "where pt.MATP = hddv.MATP\n";
                sql_dv += "and hddv.MAHD_DICHVU = cthddv.MAHD_DICHVU\n";
                sql_dv += "and cthddv.MADV = dv.MADV\n";

                SqlCommand cmd_indv = new SqlCommand(sql_dv, conn.cnn);
                int kq_indv = cmd_indv.ExecuteNonQuery();

                string sql_matp_dv = "select * from indichvu where matp = '" + matp + "'";

                da_dv = new SqlDataAdapter(sql_matp_dv, conn.cnn);
                ds_dv = new DataSet();
                da_dv.Fill(ds_dv, "DICHVU");

                Report_DichVu report_dv = new Report_DichVu();
                report_dv.SetDataSource(ds_dv.Tables["DICHVU"]);

                /*-----------------------------------------------------------------*/
                Report_Tong report_tong = new Report_Tong();

                report_tong.Database.Tables["thongtinhoadon"].SetDataSource(ds.Tables["THONGTIN"]);
                report_tong.Database.Tables["inhoadon"].SetDataSource(ds_hd.Tables["HOADON"]);
                report_tong.Database.Tables["indichvu"].SetDataSource(ds_dv.Tables["DICHVU"]);

                crystalReportViewer1.ReportSource = report_tong;
                crystalReportViewer1.Refresh();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }
    }
}
