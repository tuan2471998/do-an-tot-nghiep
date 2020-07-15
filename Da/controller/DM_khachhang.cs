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
    public partial class DM_khachhang : DevExpress.XtraEditors.XtraUserControl
    {
        public connect conn;

        public DM_khachhang(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        public void clear_row()
        {
            foreach (DataGridViewRow row in datakhachhang.Rows)
            {
                row.Selected = false;
            }
        }

        private void clear_txt()
        {
            txtmkh.Clear();
            txttenkh.Clear();
            txtcmnd.Clear();
            txtsdt.Clear();
            txtquoctich.Clear();
        }

        public void loadData()
        {
            da = new SqlDataAdapter(" select * from KHACHHANG", conn.cnn);
            da.Fill(ds, "KHACHHANG");
            datakhachhang.DataSource = ds.Tables["KHACHHANG"];
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;

            for (int i = 0; i < datakhachhang.Rows.Count; i++)
            {
                txtmkh.AutoCompleteCustomSource.Add(ds.Tables["KHACHHANG"].Rows[i][0].ToString());
                txttenkh.AutoCompleteCustomSource.Add(ds.Tables["KHACHHANG"].Rows[i][1].ToString());
            }

            txttenkh.AutoCompleteMode = AutoCompleteMode.Append;
            txttenkh.AutoCompleteSource = AutoCompleteSource.CustomSource;

            conn.cnn.Close();
        }

        private void clear_gridview()
        {
            foreach (DataGridViewRow row in datakhachhang.Rows)
            {
                datakhachhang.Rows.Remove(row);
            }
        }

        public void loadData_makh(string ma)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where MAKH like'" + ma +"%'", conn.cnn);
            da.Fill(ds, "KHACHHANG_ma");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_ma"];
            key[0] = ds.Tables["KHACHHANG_ma"].Columns[0];
            ds.Tables["KHACHHANG_ma"].PrimaryKey = key;

            conn.cnn.Close();
        }

        public void loadData_tenkh(string ten)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where HOTEN like'" + ten + "%'", conn.cnn);
            da.Fill(ds, "KHACHHANG_tenkh");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_tenkh"];
            key[0] = ds.Tables["KHACHHANG_tenkh"].Columns[0];
            ds.Tables["KHACHHANG_tenkh"].PrimaryKey = key;

            conn.cnn.Close();
        }

        public void loadData_cmnd(string cmnd)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where SOCMND like '" + cmnd +"%'", conn.cnn);
            da.Fill(ds, "KHACHHANG_cmnd");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_cmnd"];
            key[0] = ds.Tables["KHACHHANG_cmnd"].Columns[0];
            ds.Tables["KHACHHANG_cmnd"].PrimaryKey = key;

            conn.cnn.Close();
        }

        public void loadData_sdt(string sdt)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where SDT like '" + sdt + "%'", conn.cnn);
            da.Fill(ds, "KHACHHANG_sdt");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_sdt"];
            key[0] = ds.Tables["KHACHHANG_sdt"].Columns[0];
            ds.Tables["KHACHHANG_sdt"].PrimaryKey = key;

            conn.cnn.Close();
        }

        public void loadData_quoctich(string quoctich)
        {
            da = new SqlDataAdapter("select * from KHACHHANG where QUOCTICH like " + quoctich + "%'", conn.cnn);
            da.Fill(ds, "KHACHHANG_quoctich");
            datakhachhang.DataSource = ds.Tables["KHACHHANG_quoctich"];
            key[0] = ds.Tables["KHACHHANG_quoctich"].Columns[0];
            ds.Tables["KHACHHANG_quoctich"].PrimaryKey = key;

            conn.cnn.Close();
        }

        public void DM_khachhang_Load(object sender, EventArgs e)
        {
            loadData();           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {           
            try 
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    DataRow dr_xoa = ds.Tables["KHACHHANG"].Rows.Find(txtmkh.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da);
                        da.Update(ds, "KHACHHANG");

                        ds.Tables["KHACHHANG"].Clear();
                        MessageBox.Show("Xóa thành công !");

                        loadData();
                        clear_row();
                        clear_txt();
                        datakhachhang.Rows[0].Selected = true;

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false; ;
                    }
                    else
                        MessageBox.Show("Vui lòng chọn mã khách hàng ");
                }
            }
            catch
            {
                MessageBox.Show("Khách hàng có trong dữ liệu thuê phòng.\nKhông thể xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {           
            try 
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                string makh = datakhachhang.CurrentRow.Cells[0].Value.ToString();
                DataRow update_New = ds.Tables["KHACHHANG"].Rows.Find(makh);
                if (update_New != null)
                {
                    string sql = "update KHACHHANG set HOTEN = N'" + txttenkh.Text + "', SOCMND = '" + txtcmnd.Text + "', SDT = '" + txtsdt.Text + "', QUOCTICH = N'" + txtquoctich.Text + "' where MAKH = '" + makh + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(" Cập nhật Thành công");

                    loadData();
                    clear_row();
                    clear_txt();
                    datakhachhang.Rows[0].Selected = true;

                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show(" Cập nhật không thành công");
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            clear_gridview();
            //tìm theo mã khách hàng
            if (string.IsNullOrEmpty(txtmkh.Text) == false)
            {
                loadData_makh(txtmkh.Text.TrimEnd());
            }
            //tìm theo tên khách hàng
            else if (string.IsNullOrEmpty(txttenkh.Text) == false)
            {
                loadData_tenkh(txttenkh.Text.TrimEnd());
            }
            //tìm theo số căn cước/cmnd
            else if (string.IsNullOrEmpty(txtcmnd.Text) == false)
            {
                loadData_cmnd(txtcmnd.Text.TrimEnd());
            }
            //tìm theo số điện thoại
            else if (string.IsNullOrEmpty(txtsdt.Text) == false)
            {
                loadData_sdt(txtsdt.Text.TrimEnd());
            }
            // tìm theo quốc tịch
            else if (string.IsNullOrEmpty(txtquoctich.Text) == false)
            {
                loadData_quoctich(txtquoctich.Text.TrimEnd());
            }
            else
                MessageBox.Show("Thông tin khách hàng không chính xác");
        }

        public void btn_lammoi_Click(object sender, EventArgs e)
        {           
            loadData();
            clear_row();
            clear_txt();
            datakhachhang.Rows[0].Selected = true;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void datakhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmkh.Text = datakhachhang.CurrentRow.Cells[0].Value.ToString();
            txttenkh.Text = datakhachhang.CurrentRow.Cells[1].Value.ToString();
            txtcmnd.Text = datakhachhang.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = datakhachhang.CurrentRow.Cells[3].Value.ToString();
            txtquoctich.Text = datakhachhang.CurrentRow.Cells[4].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them_khachhang themkh = new them_khachhang(this, conn);
            themkh.StartPosition = FormStartPosition.CenterScreen;
            themkh.Show();
        }       

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}


