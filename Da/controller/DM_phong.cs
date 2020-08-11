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
    public partial class DM_phong : DevExpress.XtraEditors.XtraUserControl
    {
        public connect conn;

        DataSet ds_loaiph = new DataSet();
        SqlDataAdapter da_loaiph;
        DataSet ds_ph = new DataSet();
        SqlDataAdapter da_ph;
        DataColumn[] key = new DataColumn[1];

        public DM_phong(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        public void Load_LoaiPH()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                da_loaiph = new SqlDataAdapter(" select * from LOAIPHONG", conn.cnn);
                da_loaiph.Fill(ds_loaiph, "LOAIPHONG");
                dgv_loaiph.DataSource = ds_loaiph.Tables["LOAIPHONG"];
                key[0] = ds_loaiph.Tables["LOAIPHONG"].Columns[0];
                ds_loaiph.Tables["LOAIPHONG"].PrimaryKey = key;

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }
        public void Load_PH()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                da_ph = new SqlDataAdapter(" select * from PHONG where MALOAI = '" + txt_maloai.Text + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");
                dgv_ph.DataSource = ds_ph.Tables["PHONG"];
                key[0] = ds_ph.Tables["PHONG"].Columns[0];
                ds_ph.Tables["PHONG"].PrimaryKey = key;

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void clear_txt_phong()
        {
            txt_maph.Text = txt_vitri.Text = txt_giatheotang.Text = null;
            txt_tinhtrang.Text = "";
        }

        private void clear_txt_loaiphong()
        {
            txt_maloai.Text = txt_tenloai.Text = txt_gia.Text = txt_ghichu.Text = null;
        }

        private void clear_row_phong()
        {
            for (int i = 0; i < dgv_ph.Rows.Count; i++)
            {
                if (dgv_ph.Rows[i].Selected == true)
                    dgv_ph.Rows[i].Selected = false;
            }
        }

        private void clear_row_loaiphong()
        {
            for (int i = 0; i < dgv_loaiph.Rows.Count; i++)
            {
                if (dgv_loaiph.Rows[i].Selected == true)
                    dgv_loaiph.Rows[i].Selected = false;
            }
        }

        private void DM_phong_Load(object sender, EventArgs e)
        {
            Load_LoaiPH();
            Load_PH();
            dgv_loaiph.Columns[2].DefaultCellStyle.Format = "N0";
            dgv_ph.Columns[4].DefaultCellStyle.Format = "N0";
        }

        private void dgv_loaiph_Click(object sender, EventArgs e)
        {
            txt_maloai.Text = dgv_loaiph.CurrentRow.Cells[0].Value.ToString();
            txt_tenloai.Text = dgv_loaiph.CurrentRow.Cells[1].Value.ToString();
            txt_gia.Text = dgv_loaiph.CurrentRow.Cells[2].Value.ToString();
            txt_ghichu.Text = dgv_loaiph.CurrentRow.Cells[3].Value.ToString();
            delete_dgv();
            Load_PH();
        }
        private void delete_dgv()
        {
            ds_ph.Tables["PHONG"].Clear();
        }

        private void dgv_loaiph_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maloai.Text = dgv_loaiph.CurrentRow.Cells[0].Value.ToString();
            txt_tenloai.Text = dgv_loaiph.CurrentRow.Cells[1].Value.ToString();
            txt_gia.Text = string.Format("{0:0,0}", dgv_loaiph.CurrentRow.Cells[2].Value) + " VNĐ";
            txt_ghichu.Text = dgv_loaiph.CurrentRow.Cells[3].Value.ToString();
            btn_Xoaloaiphong.Enabled = btn_Sualoaiphong.Enabled = true;
            ds_ph.Tables["PHONG"].Clear();
            Load_PH();
        }

        private void txt_gia_Click(object sender, EventArgs e)
        {
            txt_gia.Text = null;
        }

        private void btn_Themloaiphong_Click(object sender, EventArgs e)
        {
            them_loaiphong themloaiphong = new them_loaiphong(this, conn);
            themloaiphong.StartPosition = FormStartPosition.CenterScreen;
            themloaiphong.Show();
        }

        private void btn_Themphong_Click(object sender, EventArgs e)
        {
            them_phong themphong = new them_phong(this, conn);
            themphong.StartPosition = FormStartPosition.CenterScreen;
            themphong.Show();
        }

        private string tinhtrang(string _tinhtrang)
        {
            if (_tinhtrang == "0")
                return "Trống";
            else if (_tinhtrang == "1")
                return "Đang sử dụng";
            else if (_tinhtrang == "2")
                return "Được đặt";
            else if (_tinhtrang == "3")
                return "Đang dọn dẹp";
            else
                return "Đang sửa chữa";
        }

        private void dgv_ph_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maph.Text = dgv_ph.CurrentRow.Cells[0].Value.ToString();
            txt_vitri.Text = "Tầng " + dgv_ph.CurrentRow.Cells[2].Value.ToString();
            txt_tinhtrang.Text = tinhtrang(dgv_ph.CurrentRow.Cells[3].Value.ToString());
            txt_giatheotang.Text = string.Format("{0:0,0}", dgv_ph.CurrentRow.Cells[4].Value) + " VNĐ";

            if(txt_tinhtrang.Text == "Đang sử dụng" || txt_tinhtrang.Text == "Được đặt")
                btn_Xoaphong.Enabled = false;
            else
                btn_Xoaphong.Enabled = true;
        }

        private void btn_Xoaphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {

                    DataRow dr_xoa = ds_ph.Tables["PHONG"].Rows.Find(txt_maph.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da_ph);
                        da_ph.Update(ds_ph, "PHONG");

                        ds_ph.Tables["PHONG"].Clear();
                        MessageBox.Show("Xóa thành công !");

                        Load_PH();
                        clear_txt_phong();
                        clear_row_phong();

                        btn_Xoaphong.Enabled = false;
                    }
                    else
                        MessageBox.Show("Vui lòng chọn mã khách hàng ");
                }
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xoaphong()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter(" select * from PHONG where MALOAI = '" + txt_maloai.Text + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");
                key[0] = ds_ph.Tables["PHONG"].Columns[0];
                ds_ph.Tables["PHONG"].PrimaryKey = key;

                while (ds_ph.Tables["PHONG"].Rows.Count > 0)
                {
                    DataRow dr_xoa = ds_ph.Tables["PHONG"].Rows.Find(ds_ph.Tables["PHONG"].Rows[0]["MAPH"].ToString());
                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da_ph);
                        da_ph.Update(ds_ph, "PHONG");
                    }
                };

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void btn_Xoaloaiphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                DialogResult r;
                r = MessageBox.Show("Nếu xóa loại phòng bạn cũng sẽ xóa toàn bộ phòng của loại phòng này.\nBạn có chắc muốn xóa không?", "Thông báo xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (r == DialogResult.Yes)
                {
                    xoaphong();

                    ds_loaiph = new DataSet();
                    da_loaiph = new SqlDataAdapter(" select * from LOAIPHONG", conn.cnn);
                    da_loaiph.Fill(ds_loaiph, "LOAIPHONG");
                    key[0] = ds_loaiph.Tables["LOAIPHONG"].Columns[0];
                    ds_loaiph.Tables["LOAIPHONG"].PrimaryKey = key;

                    DataRow dr_xoa = ds_loaiph.Tables["LOAIPHONG"].Rows.Find(txt_maloai.Text);

                    if (dr_xoa != null)
                    {
                        dr_xoa.Delete();
                        SqlCommandBuilder db = new SqlCommandBuilder(da_loaiph);
                        da_loaiph.Update(ds_loaiph, "LOAIPHONG");

                        ds_loaiph.Tables["LOAIPHONG"].Clear();
                        MessageBox.Show("Xóa thành công !");

                        Load_LoaiPH();
                        Load_PH();
                        clear_txt_loaiphong();
                        clear_row_loaiphong();
                        btn_Xoaloaiphong.Enabled = btn_Sualoaiphong.Enabled = false;
                    }
                    else
                        MessageBox.Show("Vui lòng chọn một dịch vụ");
                }
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLammoiloaiphong_Click(object sender, EventArgs e)
        {
            Load_LoaiPH();
            clear_row_loaiphong();
            clear_txt_loaiphong();
            btn_Xoaloaiphong.Enabled = btn_Sualoaiphong.Enabled = false;
        }

        private void cap_nhat_gia_phong()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                ds_ph = new DataSet();
                da_ph = new SqlDataAdapter(" select * from PHONG where MALOAI = '" + txt_maloai.Text + "'", conn.cnn);
                da_ph.Fill(ds_ph, "PHONG");
                key[0] = ds_ph.Tables["PHONG"].Columns[0];
                ds_ph.Tables["PHONG"].PrimaryKey = key;

                foreach (DataRow row in ds_ph.Tables["PHONG"].Rows)
                {
                    DataRow dr_update_giaphong = ds_ph.Tables["PHONG"].Rows.Find(row["MAPH"].ToString());
                    if (dr_update_giaphong != null)
                    {
                        string giaphong = txt_gia.Text.Replace(",", "");
                        double gialoaiph = double.Parse(giaphong.Replace(" VNĐ", ""));
                        int vitri = int.Parse(row["VTPHONG"].ToString());
                        dr_update_giaphong["GIAPHONG"] = gialoaiph + (vitri - 1) * 50000;
                        SqlCommandBuilder db = new SqlCommandBuilder(da_ph);
                        da_ph.Update(ds_ph, "PHONG");
                    }
                }
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void btn_Sualoaiphong_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                DataRow update_New = ds_loaiph.Tables["LOAIPHONG"].Rows.Find(txt_maloai.Text);
                if (update_New != null)
                {
                    string giaphong = txt_gia.Text.Replace(",", "");
                    update_New["TENLOAI"] = txt_tenloai.Text;
                    update_New["GIAPH"] = giaphong.Replace(" VNĐ", "");
                    update_New["GHICHU"] = txt_ghichu.Text;

                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_loaiph);
                    da_loaiph.Update(ds_loaiph, "LOAIPHONG");
                    cap_nhat_gia_phong();

                    MessageBox.Show(" Cập nhật Thành công");

                    Load_LoaiPH();
                    Load_PH();
                    clear_txt_loaiphong();
                    clear_row_loaiphong();

                    btn_Sualoaiphong.Enabled = false;
                    btn_Xoaloaiphong.Enabled = false;
                }
                //if (string.IsNullOrEmpty(txt_tenloai.Text) || string.IsNullOrEmpty(txt_gia.Text) || string.IsNullOrEmpty(txt_ghichu.Text))
                //{
                //    MessageBox.Show("Thông tin loại phòng không chính xác");
                //}
                //else
                //{
                //    try
                //    {

                //    }
                //    catch
                //    {
                //        MessageBox.Show(" Cập nhật không thành công");
                //    }
                //}

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txt_gia.Text) == false)
            //{
            //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //    double value = double.Parse(txt_gia.Text, System.Globalization.NumberStyles.AllowThousands);
            //    txt_gia.Text = String.Format(culture, "{0:N0}", value);
            //    txt_gia.Select(txt_gia.Text.Length, 0);
            //}
        }

        private void txt_gia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}














    

       

        

      

        

       
    
