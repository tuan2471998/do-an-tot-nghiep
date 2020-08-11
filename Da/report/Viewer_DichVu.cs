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
    public partial class Viewer_DichVu : Form
    {
        private ThanhToanHoaDon tthd;
        private ThanhToanThe ttt;
        string matp;

        public Viewer_DichVu(ThanhToanHoaDon _tthd, connect _conn)
        {
            InitializeComponent();
            tthd = _tthd;
            conn = _conn;
        }

        public Viewer_DichVu(ThanhToanThe _ttt, connect _conn)
        {
            InitializeComponent();
            ttt = _ttt;
            conn = _conn;
        }

        public void get_matp(string _matp)
        {
            matp = _matp;
        }


        public connect conn;
        DataSet ds_dv;
        SqlDataAdapter da_dv;

        private void Viewer_DichVu_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string clear = "drop view if exists indichvu";
                SqlCommand cmd = new SqlCommand(clear, conn.cnn);
                int kq = cmd.ExecuteNonQuery();

                string sql = "create view indichvu\n";
                sql += "as\n";
                sql += "select hddv.MATP, hddv.MAPH, dv.TENDV, cthddv.DONGIA, cthddv.SOLUONG, cthddv.THANHTIEN ";
                sql += "from dichvu dv, ct_hd_dichvu cthddv, hd_dichvu hddv, phieuthue pt ";
                sql += "where cthddv.MADV = dv.MADV ";
                sql += "and hddv.MAHD_DICHVU = cthddv.MAHD_DICHVU ";
                sql += "and pt.MATP = hddv.MATP ";

                SqlCommand cmd1 = new SqlCommand(sql, conn.cnn);
                int kq1 = cmd1.ExecuteNonQuery();

                string sql1 = "select * from indichvu where MATP = '" + matp + "'";

                da_dv = new SqlDataAdapter(sql1, conn.cnn);
                ds_dv = new DataSet();
                da_dv.Fill(ds_dv, "DICHVU");

                Report_DichVu report = new Report_DichVu();
                report.SetDataSource(ds_dv.Tables["DICHVU"]);

                reportviewer_dichvu.ReportSource = report;
                reportviewer_dichvu.Refresh();

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
