using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Da
{
    public partial class HDTONG : DevExpress.XtraEditors.XtraForm
    {
        connect conn = new connect();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataSet ds;
        public HDTONG()
        {
            InitializeComponent();
        }

        private void HDTONG_Load(object sender, EventArgs e)
        {

        }
        private void load_phieuthue()
        {
            ds = new DataSet();
            da = new SqlDataAdapter(" select MATP from PHIEUTHUE where MATP NOT IN (Select MATP from CT_HD)", conn.cnn);
            da.Fill(ds, "PH");
            key[0] = ds.Tables["PH"].Columns[0];
            ds.Tables["PH"].PrimaryKey = key;
        }

        private void load_cbo_phieuthue()
        {
            cbo_mapt.DataSource = ds.Tables["PH"];
            cbo_mapt.ValueMember = "MATP";
        }

        private void load_hd()
        {
            da = new SqlDataAdapter(" select * from HOADON", conn.cnn);
            da.Fill(ds, "HOADON");
            key[0] = ds.Tables["HOADON"].Columns[0];
            ds.Tables["HOADON"].PrimaryKey = key;
        }

      
        private void btn_lap_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataRow insert_New = ds.Tables["HOADON"].NewRow();
                insert_New["MAHD"] = txt_mahd.Text;
                insert_New["MATT"] = "";
                insert_New["TONGTIEN"] = "";

                ds.Tables["HOADON"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "HOADON");
                MessageBox.Show(" Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }
    }
}