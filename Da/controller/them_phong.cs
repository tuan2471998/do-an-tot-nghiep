using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class them_phong : Form
    {
        connect conn = new connect();

        DataSet ds_loaiph;
        SqlDataAdapter da_loaiph;
        DataSet ds_ph;
        SqlDataAdapter da_ph;
        DataColumn[] key = new DataColumn[1];

        double giaphong;
        double gialoaiphong;

        private DM_phong _dm_phong;
        public them_phong(DM_phong phong)
        {
            InitializeComponent();
            _dm_phong = phong;
        }

        private void Load_LoaiPH()
        {
            ds_loaiph = new DataSet();
            da_loaiph = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da_loaiph.Fill(ds_loaiph, "LOAIPHONG");
            key[0] = ds_loaiph.Tables["LOAIPHONG"].Columns[0];
            ds_loaiph.Tables["LOAIPHONG"].PrimaryKey = key;
        }

        private void Load_combobox_maloai()
        {
            Load_LoaiPH();
            cbb_maloai.DataSource = ds_loaiph.Tables["LOAIPHONG"];
            cbb_maloai.ValueMember = "MALOAI";
            cbb_maloai.DisplayMember = "TENLOAI";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            _dm_phong.Load_PH();
            this.Close();
        }

        private void them_phong_Load(object sender, EventArgs e)
        {
            Load_combobox_maloai();
            cbb_maloai.SelectedIndex = 0;
            cbb_vitri.SelectedIndex = 0;
        }

        private double gia_loai_phong(string loaiphong)
        {
            string sql_cmd = "select GIAPH from LOAIPHONG where MALOAI = '" + loaiphong + "'";
            SqlCommand cmd = new SqlCommand(sql_cmd, conn.cnn);
            DbDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                gialoaiphong = (double)rd.GetDecimal(0);
            }
            rd.Close();
            rd.Dispose();
            return gialoaiphong;
        }

        private void txtgiaphong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtgiaphong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtgiaphong.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txtgiaphong.Text, System.Globalization.NumberStyles.AllowThousands);
                txtgiaphong.Text = String.Format(culture, "{0:N0}", value);
                txtgiaphong.Select(txtgiaphong.Text.Length, 0);
            }
        }

        private void save_data()
        {
            try
            {
                ds_ph = new DataSet();
                string ma = "P" + cbb_vitri.Text.Substring(cbb_vitri.Text.Length - 1, 1);
                da_ph = new SqlDataAdapter("select * from PHONG where MAPH like '" + ma + "%'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");

                int max = 0;
                foreach (DataRow row in ds_ph.Tables["PHONG"].Rows)
                {
                    int stt;
                    stt = int.Parse(row["MAPH"].ToString().Substring(2));
                    if (max < stt)
                        max = stt;
                }
                ma += "0" + (max + 1).ToString();

                DataRow insert_New = ds_ph.Tables["PHONG"].NewRow();
                insert_New["MAPH"] = ma;
                insert_New["MALOAI"] = cbb_maloai.SelectedValue.ToString();
                insert_New["VTPHONG"] = int.Parse(cbb_vitri.Text.Substring(cbb_vitri.Text.Length - 1, 1));
                insert_New["TINHTRANG"] = 0;
                insert_New["GIAPHONG"] = giaphong;
                ds_ph.Tables["PHONG"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da_ph);
                da_ph.Update(ds_ph, "PHONG");
                MessageBox.Show(" Thêm Thành công");
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void update_txtgiatien()
        {
            if (string.IsNullOrEmpty(cbb_vitri.Text) == false && string.IsNullOrEmpty(cbb_maloai.Text) == false )
            {
                string vitri = cbb_vitri.Text;
                giaphong = gia_loai_phong(cbb_maloai.SelectedValue.ToString());
                txtgiaphong.Text = (giaphong + (double.Parse(vitri.Substring(vitri.Length - 1, 1)) - 1) * 50000).ToString();
            }
        }

        private void cbb_maloai_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_txtgiatien();
        }

        private void cbb_vitri_SelectedIndexChanged(object sender, EventArgs e)
        {
            update_txtgiatien();
        }

        private void btn_luuvadong_Click(object sender, EventArgs e)
        {
            save_data();
            _dm_phong.Load_PH();
            this.Close();
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            save_data();
            _dm_phong.Load_PH();
            cbb_maloai.SelectedIndex = cbb_vitri.SelectedIndex = 0;
        }
    }
}
