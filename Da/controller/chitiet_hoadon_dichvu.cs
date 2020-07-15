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

namespace Da.controller
{
    public partial class chitiet_hoadon_dichvu : Form
    {
        public chitiet_hoadon_dichvu(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        public connect conn;
        DataSet ds_cthd = new DataSet();
        SqlDataAdapter da_cthd;
        DataColumn[] key = new DataColumn[2];

        public void get_mahddv(string mahddv)
        {
            txt_mahddv.Text = mahddv;
        }
        private void Load_CT_HD_DV()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            da_cthd = new SqlDataAdapter(" select * from CT_HD_DICHVU where MAHD_DICHVU = '" + txt_mahddv.Text + "'", conn.cnn);
            da_cthd.Fill(ds_cthd, "CT_HD_DICHVU");
            dgv_cthddv.DataSource = ds_cthd.Tables["CT_HD_DICHVU"];
            key[0] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[0];
            key[1] = ds_cthd.Tables["CT_HD_DICHVU"].Columns[1];
            ds_cthd.Tables["CT_HD_DICHVU"].PrimaryKey = key;

            conn.cnn.Close();
        }

        private string get_tendichvu(string madv)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select TENDV from DICHVU where MADV = '" + madv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private void dgv_cthddv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mahddv.Text = dgv_cthddv.CurrentRow.Cells[0].Value.ToString();
            txt_madichvu.Text = dgv_cthddv.CurrentRow.Cells[1].Value.ToString();
            txt_tendichvu.Text = get_tendichvu(dgv_cthddv.CurrentRow.Cells[1].Value.ToString());
            txt_soluong.Text = dgv_cthddv.CurrentRow.Cells[2].Value.ToString();
            txt_dongia.Text = string.Format("{0:0,0}", dgv_cthddv.CurrentRow.Cells[3].Value) + " VNĐ";
            txt_thanhtien.Text = string.Format("{0:0,0}", dgv_cthddv.CurrentRow.Cells[4].Value) + " VNĐ";
        }

        private void chitiet_hoadon_dichvu_Load(object sender, EventArgs e)
        {
            Load_CT_HD_DV();
            dgv_cthddv.Columns[3].DefaultCellStyle.Format = "N0";
            dgv_cthddv.Columns[4].DefaultCellStyle.Format = "N0";
        }
    }
}
