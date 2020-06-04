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
    public partial class them_loaiphong : Form
    {
        private DM_phong _dm_phong;
        public them_loaiphong(DM_phong phong)
        {
            InitializeComponent();
            _dm_phong = phong;
        }

        connect conn = new connect();

        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        private void txtgialoaiphong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtgialoaiphong.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txtgialoaiphong.Text, System.Globalization.NumberStyles.AllowThousands);
                txtgialoaiphong.Text = String.Format(culture, "{0:N0}", value);
                txtgialoaiphong.Select(txtgialoaiphong.Text.Length, 0);
            }
        }

        private int kiem_tra_thong_tin()
        {
            if (string.IsNullOrEmpty(txttenloaiphong.Text))
            {
                MessageBox.Show("Chưa nhập tên loại phòng");
                txttenloaiphong.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txtgialoaiphong.Text))
            {
                MessageBox.Show("Chưa nhập giá loại phòng");
                txttenloaiphong.Focus();
                return 0;
            }
            else
                return 1;
        }

        private void save_data()
        {
            int kt = kiem_tra_thong_tin();
            if (kt == 1)
            {
                try
                {

                    DataSet ds = new DataSet();
                    da = new SqlDataAdapter(" select * from LOAIPHONG", conn.cnn);
                    da.Fill(ds, "LOAIPHONG");
                    key[0] = ds.Tables["LOAIPHONG"].Columns[0];
                    ds.Tables["LOAIPHONG"].PrimaryKey = key;

                    int max = 0;
                    foreach (DataRow row in ds.Tables["LOAIPHONG"].Rows)
                    {
                        int stt = int.Parse(row["MALOAI"].ToString().Substring(2));
                        if (max < stt)
                            max = stt;
                    }

                    string maloai = "LP0" + (max + 1).ToString(); ;

                    DataRow insert_New = ds.Tables["LOAIPHONG"].NewRow();
                    insert_New["MALOAI"] = maloai;
                    insert_New["TENLOAI"] = txttenloaiphong.Text;
                    insert_New["GIAPH"] = txtgialoaiphong.Text;
                    if (string.IsNullOrEmpty(txtghichu.Text) == false)
                        insert_New["GHICHU"] = txtghichu.Text;

                    ds.Tables["LOAIPHONG"].Rows.Add(insert_New);
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                    da.Update(ds, "LOAIPHONG");

                    MessageBox.Show("Thêm thành công");

                    ds.Tables["LOAIPHONG"].Clear();
                }
                catch
                {
                    MessageBox.Show("Đã xảy ra lỗi");
                }
            }
        }

        private void txtgialoaiphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnLuuvathem_Click(object sender, EventArgs e)
        {
            save_data();
            txtghichu.Clear();
            txtgialoaiphong.Clear();
            txttenloaiphong.Clear();
            txttenloaiphong.Focus();
            _dm_phong.Load_LoaiPH();
        }

        private void btnLuuvadong_Click(object sender, EventArgs e)
        {
            save_data();
            _dm_phong.Load_LoaiPH();
            this.Close();
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            _dm_phong.Load_LoaiPH();
            this.Close();
        }
    }
}
