using System;
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

namespace Da.controller
{
    public partial class Phieudichvu : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataSet ds_1 = new DataSet();
       
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[2];
        public Phieudichvu()
        {

            InitializeComponent();
            load_ct_thuephong();
            load_hd_dichvu();
        }
        private void load_ct_thuephong()
        {
            da = new SqlDataAdapter(" select * from CT_THUEPHONG", conn.cnn);
            da.Fill(ds, "CT_THUEPHONG");
            dgv_1.DataSource = ds.Tables["CT_THUEPHONG"];
            key1[0] = ds.Tables["CT_THUEPHONG"].Columns[0];
            key1[1] = ds.Tables["CT_THUEPHONG"].Columns[1];
            ds.Tables["CT_THUEPHONG"].PrimaryKey = key1;
        }
        private void load_hd_dichvu()
        {
            da = new SqlDataAdapter(" select * from HD_DICHVU where MATP='" + txt_matp.Text + "' and MAPH ='" + txt_maph.Text + "' ", conn.cnn);
            da.Fill(ds, "HD_DICHVU");
            dgv_2.DataSource = ds.Tables["HD_DICHVU"];
            key[0] = ds.Tables["HD_DICHVU"].Columns[0];
            ds.Tables["HD_DICHVU"].PrimaryKey = key;
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void delete_dgv()
        {
            ds.Tables["HD_DICHVU"].Clear();
        }

        private void Phieudichvu_Load(object sender, EventArgs e)
        {
            txt_ngaylap.Text = DateTime.Now.ToString();
            sinhtudongMaHOADON();
        }

        private void dgv_1_Click(object sender, EventArgs e)
        {
            txt_matp.Text = dgv_1.CurrentRow.Cells[0].Value.ToString();
            txt_maph.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
            delete_dgv();
            load_hd_dichvu();
            txt_maphdv.Text = sinhtudongMaHOADON();
        }

        //private void simpleButton2_Click(object sender, EventArgs e)
        //{
        //    Themctdichvu tdv = new Themctdichvu();
        //    tdv.Show();
        //}

        private void btn_lap_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow insert_New = ds.Tables["HD_DICHVU"].NewRow();
                insert_New["MAHD_DICHVU"] = txt_maphdv.Text;
                insert_New["MATP"] = txt_matp.Text;
                insert_New["MAPH"] = txt_maph.Text;
                insert_New["NGAYSUDUNG"] = txt_ngaylap.Text;
                insert_New["TONGTIEN"] = 0;
                ds.Tables["HD_DICHVU"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "HD_DICHVU");
                MessageBox.Show(" Lập phiếu hóa đơn thành công");

            }
            catch
            {
                MessageBox.Show("Thao tác của bạn đã bị lỗi");
            }
        }
        private string sinhtudongMaHOADON()
        {
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
            return "HDV" + bien2.ToString().Substring(1, 3);
        }


        private void dgv_2_Click(object sender, EventArgs e)
        {

        }

        private void dgv_1_MouseClick(object sender, MouseEventArgs e)
        {
            sinhtudongMaHOADON();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {


            themchitietdichvu ctdv = new themchitietdichvu();
            ctdv.Show();
        }   
    }
    
}
