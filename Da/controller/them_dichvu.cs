using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace Da.controller
{
    public partial class them_dichvu : Form
    {
        private DM_dichvu2 _dm_dichvu;
        public them_dichvu(DM_dichvu2 dichvu)
        {
            InitializeComponent();
            _dm_dichvu = dichvu;
        }

        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        private int kiem_tra_thong_tin()
        {
            if (string.IsNullOrEmpty(txtTendichvu.Text))
            {
                MessageBox.Show("Chưa nhập tên dịch vụ");
                txtTendichvu.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txtGiatien.Text))
            {
                MessageBox.Show("Chưa nhập giá tiền dịch vụ");
                txtGiatien.Focus();
                return 0;
            }
            else
                return 1;
        }

        private void luu_thong_tin()
        {
            try
            {
                DataSet ds = new DataSet();
                da = new SqlDataAdapter(" select * from DICHVU", conn.cnn);
                da.Fill(ds, "DICHVU");
                key[0] = ds.Tables["DICHVU"].Columns[0];
                ds.Tables["DICHVU"].PrimaryKey = key;

                int max = 0;
                foreach (DataRow row in ds.Tables["DICHVU"].Rows)
                {
                    int stt = int.Parse(row["MADV"].ToString().Substring(2));
                    if (max < stt)
                        max = stt;
                }

                string madv = "";
                if (max > 0 && max < 10)
                    madv = "DV00" + (max + 1).ToString();
                else if (max < 100)
                    madv = "DV0" + (max + 1).ToString();
                else
                    madv = "DV" + (max + 1).ToString();

                DataRow insert_New = ds.Tables["DICHVU"].NewRow();
                insert_New["MADV"] = madv;
                insert_New["TENDV"] = txtTendichvu.Text;
                insert_New["GIADV_HIENTAI"] = txtGiatien.Text;

                ds.Tables["DICHVU"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "DICHVU");

                MessageBox.Show("Thêm thành công");

                ds.Tables["DICHVU"].Clear();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi");
            }
        }
        private void txtGiatien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGiatien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txtGiatien.Text, System.Globalization.NumberStyles.AllowThousands);
                txtGiatien.Text = String.Format(culture, "{0:N0}", value);
                txtGiatien.Select(txtGiatien.Text.Length, 0);
            }
        }

        private void txtGiatien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            _dm_dichvu.Load_DGV_Dichvu();
            this.Close();
        }

        private void btnLuuvathem_Click(object sender, EventArgs e)
        {
            int kt = kiem_tra_thong_tin();
            if (kt == 1)
            {
                luu_thong_tin();
                txtGiatien.Clear();
                txtTendichvu.Clear();
                txtTendichvu.Focus();
                _dm_dichvu.Load_DGV_Dichvu();
            }
        }

        private void btnLuuvadong_Click(object sender, EventArgs e)
        {
            int kt = kiem_tra_thong_tin();
            if (kt == 1)
            {
                luu_thong_tin();
                _dm_dichvu.Load_DGV_Dichvu();
                this.Close();
            }
        }
    }
}
