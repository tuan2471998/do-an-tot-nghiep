using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Viewer_HoaDon : Form
    {
        private ThanhToanHoaDon tthd;
        private ThanhToanThe ttt;

        string matp;
        SqlDataAdapter da;
        DataSet ds;

        public connect conn;

        public Viewer_HoaDon(ThanhToanHoaDon _thanhtoan, connect _conn)
        {
            InitializeComponent();
            tthd = _thanhtoan;
            conn = _conn;
        }

        public Viewer_HoaDon(ThanhToanThe _thanhtoan, connect _conn)
        {
            InitializeComponent();
            ttt = _thanhtoan;
            conn = _conn;
        }

        public void get_matp(string _matp)
        {
            matp = _matp;
        }

        private void Viewer_HoaDon_Load(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string clear = "drop view if exists inhoadon\n";
            SqlCommand cmd = new SqlCommand(clear, conn.cnn);
            int kq_clear = cmd.ExecuteNonQuery();

            string sql = "create view inhoadon\n";
            sql += "as\n";
            sql += "select hd.MAHD, cthd.MATP, nv.HOTEN, kh.HOTEN as [ten kh], pt.NGAYNHAN, hd.NGAYLAP, pt.TIENCOC, cttp.MAPH, ph.GIAPHONG, hd.TONGTIEN, hd.TIENMAT, hd.TIENTHE\n";
            sql += "from hoadon hd, ct_hd cthd, nhanvien nv, khachhang kh, phieuthue pt, ct_thuephong cttp, phong ph\n";
            sql += "where hd.MAHD = cthd.MAHD\n";
            sql += "and hd.MANV_LAPPHIEU = nv.MANV\n";
            sql += "and cthd.MATP = pt.MATP\n";
            sql += "and pt.MAKH = kh.MAKH\n";
            sql += "and cttp.MATP = pt.MATP\n";
            sql += "and ph.MAPH = cttp.MAPH\n";

            SqlCommand cmd1 = new SqlCommand(sql, conn.cnn);
            int kq = cmd1.ExecuteNonQuery();

            string sql1 = "select * from inhoadon where MATP = '" + matp + "'";

            da = new SqlDataAdapter(sql1, conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "HOADON");

            Report_HoaDon report = new Report_HoaDon();
            report.SetDataSource(ds.Tables["HOADON"]);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
            conn.cnn.Close();
        }
    }
}
