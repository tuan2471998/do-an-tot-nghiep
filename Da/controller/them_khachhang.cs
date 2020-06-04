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
    public partial class them_khachhang : Form
    {
        private DM_khachhang _dm_khachhang;
        public them_khachhang(DM_khachhang khachhang)
        {
            InitializeComponent();
            _dm_khachhang = khachhang;
        }
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            _dm_khachhang.loadData();
            this.Close();
        }

        public void loadData_themkh()
        {
            da = new SqlDataAdapter(" select * from KHACHHANG", conn.cnn);
            da.Fill(ds, "KHACHHANG");
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;
        }

        int kiemtra_thongtin()
        {
            loadData_themkh();
            foreach (DataRow row in ds.Tables["KHACHHANG"].Rows)
            {
                if (string.Compare(txt_sdt.Text, row["SDT"].ToString()) == 0)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại");
                    txt_tenkh.Focus();
                    return 0;
                }
            }
            if (string.IsNullOrEmpty(txt_tenkh.Text))
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_cmnd.Text))
            {
                MessageBox.Show("Chưa nhập số chứng minh khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại khách hàng");
                txt_tenkh.Focus();
                return 0;
            }
            else if (cbb_quoctich.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa chọn quốc tịch khách hàng");
                return 0;
            }
            else
                return 1;
        }

        void them_thong_tin_kh()
        {
            da = new SqlDataAdapter(" select * from KHACHHANG", conn.cnn);
            da.Fill(ds, "KHACHHANG");
            key[0] = ds.Tables["KHACHHANG"].Columns[0];
            ds.Tables["KHACHHANG"].PrimaryKey = key;

            int max = 0;
            foreach (DataRow row in ds.Tables["KHACHHANG"].Rows)
            {
                int stt;
                stt = int.Parse(row["MAKH"].ToString().Substring(2));
                if (max < stt)
                    max = stt;
            }
            string makh;
            // tự động tạo mã khách hàng
            if(max >0 && max < 10)
                makh = "KH00" + (max + 1).ToString();
            if (max < 100)
                makh = "KH0" + (max + 1).ToString();
            else
                makh = "KH" + (max + 1).ToString();
            try
            {
                DataRow insert_New = ds.Tables["KHACHHANG"].NewRow();
                insert_New["MAKH"] = makh;
                insert_New["HOTEN"] = txt_tenkh.Text;
                insert_New["SOCMND"] = txt_cmnd.Text;
                insert_New["SDT"] = txt_sdt.Text;
                insert_New["QUOCTICH"] = cbb_quoctich.Text;
                ds.Tables["KHACHHANG"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "KHACHHANG");
                MessageBox.Show(" Thêm Thành công");
                loadData_themkh();
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            int kq = kiemtra_thongtin();
            if (kq == 1)
            {
                them_thong_tin_kh();
                txt_tenkh.Clear();
                txt_sdt.Clear();
                txt_cmnd.Clear();
                cbb_quoctich.SelectedIndex = 0;
                txt_tenkh.Focus();
                _dm_khachhang.loadData();
            }
        }

        private void btn_luuvadong_Click(object sender, EventArgs e)
        {
            int kq = kiemtra_thongtin();
            if (kq == 1)
            {
                them_thong_tin_kh();
                _dm_khachhang.loadData();
                this.Close();
            }
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void them_khachhang_Load(object sender, EventArgs e)
        {
            cbb_quoctich.SelectedIndex = 0;
            loadData_themkh();
        }
    }
}
