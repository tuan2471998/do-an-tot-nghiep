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
    public partial class themchitietdichvu : Form
    {
        connect conn = new connect();
        DataSet ds_hd_dv = new DataSet();
        SqlDataAdapter da_hd_dv;
        DataSet ds_cthd = new DataSet();
        SqlDataAdapter da_cthd;
        DataSet ds_dv = new DataSet();
        SqlDataAdapter da_dv;
        DataColumn[] key = new DataColumn[1];
        DataColumn[] key1 = new DataColumn[2];
        public themchitietdichvu()
        {
            InitializeComponent();
            Load_Table_Dichvu();
            Load_Table_HD_DICHVU();
            Load_CT_HD_DV();
            load_cbo_dichvu();
            load_cbo_mahddv();
        }
        private void Themchitietdichvu_Load(object sender, EventArgs e)
        {
            load_cbo_dichvu();
            load_cbo_mahddv();
        }
        private void Load_Table_Dichvu()
        {
            da_dv = new SqlDataAdapter(" select * from DICHVU", conn.cnn);
            da_dv.Fill(ds_dv, "DICHVU");
            key[0] = ds_dv.Tables["DICHVU"].Columns[0];
            ds_dv.Tables["DICHVU"].PrimaryKey = key;
        }
        private void Load_Table_HD_DICHVU()
        {
            da_hd_dv = new SqlDataAdapter(" select * from HD_DICHVU ", conn.cnn);
            da_hd_dv.Fill(ds_hd_dv, "HD_DICHVU");
            key[0] = ds_hd_dv.Tables["HD_DICHVU"].Columns[0];
            ds_hd_dv.Tables["HD_DICHVU"].PrimaryKey = key;
        }

        private void Load_CT_HD_DV()
        {
            da_cthd = new SqlDataAdapter(" select * from CT_HD_DICHVU", conn.cnn);
            da_cthd.Fill(ds_cthd, "CT_HD_DICHVU");
            dgv_cthddv.DataSource = ds_cthd.Tables["CT_HD_DICHVU"];
            key1[0] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[0];
            key1[1] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[1];
            ds_cthd.Tables["CT_HD_DICHVU"].PrimaryKey = key1;
        }

        private void load_cbo_mahddv()
        {
            cbo_ma_hd_dv.DataSource = ds_hd_dv.Tables["HD_DICHVU"];
            cbo_ma_hd_dv.ValueMember = "MAHD_DICHVU";
        }

        private void load_cbo_dichvu()
        {
            cbo_dichvu.DataSource = ds_dv.Tables["DICHVU"];
            cbo_dichvu.ValueMember = "MADV";
            cbo_dichvu.DisplayMember = "TENDV";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow insert_New = ds_cthd.Tables["CT_HD_DICHVU"].NewRow();
                insert_New["MAHD_DICHVU"] = cbo_ma_hd_dv.SelectedValue.ToString();
                insert_New["MADV"] = cbo_dichvu.SelectedValue.ToString();
                insert_New["SOLUONG"] = txt_soluong.Text;
                insert_New["DONGIA"] = textBoxdongia.Text;
                insert_New["THANHTIEN"] = textBoxthanhtien.Text;

                ds_cthd.Tables["CT_HD_DICHVU"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_cthd);
                da_cthd.Update(ds_cthd, "CT_HD_DICHVU");
                MessageBox.Show(" Thêm Thành công");

            }
            catch 
            {
                MessageBox.Show("Lỗi");
            }
        }
        public void Capnhat_tongtien()
        {
            //DataRow update_New = ds_hd_dv.Tables["HD_DICHVU"].Rows.Find(cbo_ma_hd_dv.SelectedValue.ToString());
            //if (update_New != null)
            //{
            //update_New["TONGTIEN"] = tinhtongtien();

            //SqlCommandBuilder cmb = new SqlCommandBuilder(da_hd_dv);
            //da_hd_dv.Update(ds_hd_dv, "LOAIPHONG");

        }
    }
}
