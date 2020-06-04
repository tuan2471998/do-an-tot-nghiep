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

namespace Da.controller
{
   
    public partial class HoaDonTong : UserControl
    {
        connect conn = new connect();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataSet ds;
        public HoaDonTong()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HoaDonTong_Load(object sender, EventArgs e)
        {
            load_ct_hd();
            load_cbo_matp();
        }
        private void load_cbo_matp()
        {


        

    
            da = new SqlDataAdapter(" select * from CT_HD", conn.cnn);
            da.Fill(ds, "CT_HD");
            cbo_matp.DataSource = ds.Tables["CT_HD"];
            cbo_matp.ValueMember = "MATP";
            cbo_matp.DisplayMember = "MATP";
        }
        private void load_ct_hd()
        {
            ds = new DataSet();
            da = new SqlDataAdapter(" select * from CT_HD", conn.cnn);
            da.Fill(ds, "CT_HD");
            dgv_hoadon.DataSource = ds.Tables["CT_HD"];
            key[0] = ds.Tables["CT_HD"].Columns[0];
            ds.Tables["CT_HD"].PrimaryKey = key;
        }

        private void hóaĐơnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon_phong ctdv = new Hoadon_phong();
            ctdv.Show();
        }

        private void hóaĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hoadon_dichvu ctdv = new Hoadon_dichvu();
            ctdv.Show();
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDTONG rpt_hd = new HDTONG();
            rpt_hd.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
