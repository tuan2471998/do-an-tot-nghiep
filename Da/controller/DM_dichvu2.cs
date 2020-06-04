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
    public partial class DM_dichvu2 : UserControl
    {
        connect conn = new connect();

        DataSet ds_loaiph = new DataSet();
        SqlDataAdapter da;
        DataSet ds;

        DataColumn[] key = new DataColumn[1];
        public DM_dichvu2()
        {
            InitializeComponent();
        }
        public void loadData_madv(string ma)
        {
            da = new SqlDataAdapter("select * from DICHVU where MADV like'" + ma + "%'", conn.cnn);
            da.Fill(ds, "DICHVU_madv");
            dgv_dichvu.DataSource = ds.Tables["DICHVU_madv"];
            key[0] = ds.Tables["DICHVU_madv"].Columns[0];
            ds.Tables["DICHVU_madv"].PrimaryKey = key;
        }

        public void loadData_tendv(string ten)
        {
            da = new SqlDataAdapter("select * from DICHVU where TENDV like'" + ten + "%'", conn.cnn);
            da.Fill(ds, "DICHVU_tendv");
            dgv_dichvu.DataSource = ds.Tables["DICHVU_tendv"];
            key[0] = ds.Tables["DICHVU_tendv"].Columns[0];
            ds.Tables["DICHVU_tendv"].PrimaryKey = key;
        }

        public void Load_DGV_Dichvu()
        {
            ds = new DataSet();
            da = new SqlDataAdapter(" select * from DICHVU", conn.cnn);
            da.Fill(ds, "DICHVU");
            dgv_dichvu.DataSource = ds.Tables["DICHVU"];
            key[0] = ds.Tables["DICHVU"].Columns[0];
            ds.Tables["DICHVU"].PrimaryKey = key;

            for (int i = 0; i < dgv_dichvu.Rows.Count; i++)
            {
                txt_madv.AutoCompleteCustomSource.Add(ds.Tables["DICHVU"].Rows[i][0].ToString());
                txt_tendv.AutoCompleteCustomSource.Add(ds.Tables["DICHVU"].Rows[i][1].ToString());
            }

            txt_madv.AutoCompleteMode = AutoCompleteMode.Append;
            txt_madv.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_tendv.AutoCompleteMode = AutoCompleteMode.Append;
            txt_tendv.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Clear_txt()
        {
            txt_madv.Text = null;
            txt_tendv.Text = null;
            txt_giadv.Text = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    DataRow dr_xoa = ds.Tables["DICHVU"].Rows.Find(txt_madv.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da);
                        da.Update(ds, "DICHVU");

                        ds.Tables["DICHVU"].Clear();
                        MessageBox.Show("Xóa thành công !");

                        Load_DGV_Dichvu();
                        Clear_txt();
                        btnSua.Enabled = btnXoa.Enabled = false;
                    }
                    else

                        MessageBox.Show("Vui lòng chọn một dịch vụ");
                }
            }
            catch
            {
                MessageBox.Show("Thao tác thực hiện của bạn không thành công! Bạn hãy thao tác lại");
            }
        }

        private void DM_dichvu_Load(object sender, EventArgs e)
        {
            Load_DGV_Dichvu();
            dgv_dichvu.Columns[2].DefaultCellStyle.Format = "N0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            them_dichvu themdichvu = new them_dichvu(this);
            themdichvu.StartPosition = FormStartPosition.CenterScreen;
            themdichvu.Show();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            Load_DGV_Dichvu();
            btnSua.Enabled = btnXoa.Enabled = false;
            Clear_txt();
        }

        private void dgv_dichvu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_madv.Text = dgv_dichvu.CurrentRow.Cells[0].Value.ToString();
            txt_tendv.Text = dgv_dichvu.CurrentRow.Cells[1].Value.ToString();
            txt_giadv.Text = string.Format("{0:0,0}", dgv_dichvu.CurrentRow.Cells[2].Value) + " VNĐ";
            btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_madv.Text) == false)
            {
                loadData_madv(txt_madv.Text);
            }
            else if (string.IsNullOrEmpty(txt_tendv.Text) == false)
            {
                loadData_tendv(txt_tendv.Text);
            }
            else
                MessageBox.Show("Thông tin tìm kiếm không chính xác");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();
                Load_DGV_Dichvu();
                DataRow update_New = ds.Tables["DICHVU"].Rows.Find(txt_madv.Text);
                if (update_New != null)
                {
                    string[] giatien = txt_giadv.Text.Split(' ');
                    update_New["TENDV"] = txt_tendv.Text;
                    update_New["GIADV_HIENTAI"] = double.Parse(giatien[0]);

                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "DICHVU");
                    MessageBox.Show(" Cập nhật thành công");

                    Load_DGV_Dichvu();
                    Clear_txt();
                    btnSua.Enabled = btnXoa.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void txt_giadv_Click(object sender, EventArgs e)
        {
            txt_giadv.Clear();
        }
    }
}
