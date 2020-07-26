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
using DevExpress.DataAccess.UI.Native.Sql.DataConnectionControls;
using DevExpress.XtraGrid.Views.BandedGrid.Drawing;
using DevExpress.DataAccess.DataFederation;

namespace Da.controller
{
    public partial class frm_Nhaphang : UserControl
    {
        public connect conn;
        DataSet ds;
        SqlDataAdapter da;

        public frm_Nhaphang(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void get_thongtin_thietbi()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select tb.matb, tb.tentb, h.soluonghang\n";
            sql += "from thietbi tb, hang h\n";
            sql += "where tb.MATB = h.TENHANG";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "THIETBI");

            conn.cnn.Close();
        }

        private void get_thongtin_menu()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select menu.idmenu, menu.tenmenu, h.soluonghang\n";
            sql += "from menu, hang h\n";
            sql += "where menu.idmenu = h.tenhang";

            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "MENU");

            conn.cnn.Close();
        }

        DataTable dt;
        DataRow newrow;
        public void gop_data()
        {
            dt = new DataTable();
            dt.Columns.Add("loaihang");
            dt.Columns.Add("mahang");
            dt.Columns.Add("tenhang");
            dt.Columns.Add("soluong");

            get_thongtin_thietbi();
            foreach (DataRow row in ds.Tables["THIETBI"].Rows)
            {
                newrow = dt.NewRow();

                newrow["loaihang"] = "Thiết bị";
                newrow["mahang"] = row["matb"].ToString();
                newrow["tenhang"] = row["tentb"].ToString();
                newrow["soluong"] = row["soluonghang"].ToString();

                dt.Rows.Add(newrow);
            }

            get_thongtin_menu();
            foreach (DataRow row in ds.Tables["MENU"].Rows)
            {
                newrow = dt.NewRow();

                newrow["loaihang"] = "Menu";
                newrow["mahang"] = row["idmenu"].ToString();
                newrow["tenhang"] = row["tenmenu"].ToString();
                newrow["soluong"] = row["soluonghang"].ToString();

                dt.Rows.Add(newrow);
            }

            dgv_nhaphang.DataSource = dt;
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            them_nhaphang nhaphang = new them_nhaphang(conn, this);
            nhaphang.StartPosition = FormStartPosition.CenterScreen;
            nhaphang.Show();
        }

        private void frm_Nhaphang_Load(object sender, EventArgs e)
        {          
            gop_data();
        }
    }
}
