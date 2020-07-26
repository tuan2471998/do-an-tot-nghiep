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
using DevExpress.XtraEditors;
using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;
using DevExpress.DataProcessing;
using System.Web.UI.WebControls;

namespace Da.controller
{
    public partial class qlthietbi : DevExpress.XtraEditors.XtraUserControl
    {
        DataSet ds;
        SqlDataAdapter da;
        public connect conn;
        DataColumn[] key = new DataColumn[1];

        public qlthietbi(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }


        private void load_cbb_loaiphong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da.Fill(ds, "LOAIPHONG");

            cbb_loai.DisplayMember = "TENLOAI";
            cbb_loai.ValueMember = "MALOAI";
            cbb_loai.DataSource = ds.Tables["LOAIPHONG"];

            DataRow row = ds.Tables["LOAIPHONG"].NewRow();
            row[1] = "[Chọn loại phòng]";
            ds.Tables["LOAIPHONG"].Rows.InsertAt(row, 0);
            conn.cnn.Close();
        }

        private void qlthietbi_Load(object sender, EventArgs e)
        {
            load_cbb_loaiphong();
            cbb_loai.SelectedIndex = 0;
        }

        private void giuongdoi_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox && control.Name == "groupBox2")
                {
                    foreach (Control chb in control.Controls)
                    {
                        if ((chb is System.Windows.Forms.CheckBox) && ((System.Windows.Forms.CheckBox)chb).Checked)
                        {
                            foreach (Control num in control.Controls)
                            {
                                if ((num is NumericUpDown) && ((NumericUpDown)num).Name == "numeric_" + chb.Name)
                                    num.Enabled = true;
                            }
                        }
                        else if ((chb is System.Windows.Forms.CheckBox) && !((System.Windows.Forms.CheckBox)chb).Checked)
                        {
                            foreach (Control num in control.Controls)
                            {
                                if ((num is NumericUpDown) && ((NumericUpDown)num).Name == "numeric_" + chb.Name)
                                {
                                    num.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
        }

        DataTable chitiet = new DataTable();
        DataSet ds_chitiet = new DataSet();
        SqlDataAdapter da_chitiet;

        private void numeric_giuongdoi_ValueChanged(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            lay_tentb((sender as NumericUpDown).Name);
            if ((sender as NumericUpDown).Enabled)
            {
                da_chitiet = new SqlDataAdapter("select MALOAI, TENTB, SOLUONGTB, CT_THIETBI.MATB from CT_THIETBI, THIETBI where CT_THIETBI.MATB = THIETBI.MATB and MALOAI = '0'", conn.cnn);
                da_chitiet.Fill(ds_chitiet, "CHITIET");
                chitiet = ds_chitiet.Tables["CHITIET"];

                DataRow dr = chitiet.NewRow();
                dr[0] = cbb_loai.SelectedValue.ToString();
                dr[1] = tentb;
                dr[2] = (sender as NumericUpDown).Value;
                dr[3] = get_matb(tentb);

                clear_gridview(dr[0].ToString(), dr[1].ToString());

                chitiet.Rows.Add(dr);
                dgv_danhsachloaiphong.DataSource = chitiet;
            }
            conn.cnn.Close();
        }

        private void clear_gridview()
        {
            chitiet.Clear();
            while (dgv_danhsachloaiphong.Rows.Count > 0)
            {
                dgv_danhsachloaiphong.Rows.RemoveAt(0);
            }
        }

        private void clear_control()
        {
            cbb_loai.SelectedIndex = 0;
            clear_gridview();
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox && control.Name == "groupBox2")
                {
                    foreach (Control num in control.Controls)
                    {
                        if (num is NumericUpDown)
                        {
                            num.Enabled = false;
                            ((NumericUpDown)num).Value = 0;
                        }
                        else if (num is System.Windows.Forms.CheckBox)
                        {
                            ((System.Windows.Forms.CheckBox)num).Checked = false;
                        }
                    }
                }
            }
        }

        private void clear_gridview(string loaiphong, string tentb)
        {
            foreach (DataGridViewRow row in dgv_danhsachloaiphong.Rows)
            {
                if (row.Cells[0].Value.ToString() == loaiphong && row.Cells[1].Value.ToString() == tentb)
                    dgv_danhsachloaiphong.Rows.Remove(row);
            }
        }

        //kiểm tra xem thiết bị đã có trong bảng CT_THIETBI chưa
        private int kiemtra_data(string maloai, string tentb)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select count(*) from CT_THIETBI where MALOAI = '" + maloai + "' and MATB = '" + get_matb(tentb) + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (int)cmd.ExecuteScalar();
        }

        private string get_matb(string tentb)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MATB from THIETBI where TENTB like N'%" + tentb + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private void insert_ct_thietbi(string maloai, string tentb, int soluong)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select * from CT_THIETBI", conn.cnn);
            da.Fill(ds, "INSERT_CT_THIETBI");

            DataRow insert_New = ds.Tables["INSERT_CT_THIETBI"].NewRow();
            insert_New["MALOAI"] = maloai;
            insert_New["MATB"] = get_matb(tentb);
            insert_New["SOLUONGTB"] = soluong;

            ds.Tables["INSERT_CT_THIETBI"].Rows.Add(insert_New);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            da.Update(ds, "INSERT_CT_THIETBI");

            ds.Tables["INSERT_CT_THIETBI"].Clear();

            conn.cnn.Close();
        }

        private void update_ct_thietbi(string loaiphong, string tentb, int slmoi)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "update CT_THIETBI set SOLUONGTB = " + slmoi + "  where MALOAI = '" + loaiphong + "' and MATB = '" + get_matb(tentb) + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void xoa_ct_thietbi(string loaiphong, string tentb)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "delete from CT_THIETBI where MALOAI = '" + loaiphong + "' and MATB = '" + get_matb(tentb) + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private int get_soluong_hang(string mahang)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select SOLUONGHANG from HANG where TENHANG = '" + mahang + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (int)cmd.ExecuteScalar();
        }

        private void update_soluong_hang(string mahang, int soluong)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "update HANG set SOLUONGHANG = SOLUONGHANG - " + soluong + " where TENHANG = '" + mahang + "' ";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        int soluongphong = 0;
        private void get_soluongphong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }

            string sql = "select count(MAPH) from PHONG where MALOAI = '" + cbb_loai.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            soluongphong = (int)cmd.ExecuteScalar();

            conn.cnn.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            get_soluongphong();

            foreach (DataGridViewRow row in dgv_danhsachloaiphong.Rows)
            {
                int sltb = soluongphong * int.Parse(row.Cells[2].Value.ToString());
                if (kiemtra_data(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()) != 0)
                {
                    if (int.Parse(row.Cells[2].Value.ToString()) == 0)
                    {
                        xoa_ct_thietbi(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                    }
                    else
                    {                       
                        if (get_soluong_hang(get_matb(row.Cells[1].Value.ToString())) < sltb)
                        {
                            MessageBox.Show("Số lượng " + row.Cells[1].Value.ToString() + " trong kho không đủ");
                        }
                        else
                        {
                            update_ct_thietbi(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), sltb);
                            update_soluong_hang(get_matb(row.Cells[1].Value.ToString()), sltb);
                            MessageBox.Show("Cập nhật số lượng " + row.Cells[1].Value.ToString() + " trong " + soluongphong + " phòng loại " + cbb_loai.Text.Trim() + " thành công");
                        }
                    }
                }
                else
                {
                    if (get_soluong_hang(get_matb(row.Cells[1].Value.ToString())) < sltb)
                    {
                        MessageBox.Show("Số lượng " + row.Cells[1].Value.ToString() + " trong kho không đủ");
                    }
                    else
                    {
                        insert_ct_thietbi(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), sltb);
                        update_soluong_hang(get_matb(row.Cells[1].Value.ToString()), sltb);
                        MessageBox.Show("Thêm thành công " + sltb + " " + row.Cells[1].Value.ToString() + " vào " + soluongphong + " phòng loại " + cbb_loai.Text.Trim());
                    }
                }
            }

            clear_control();

            conn.cnn.Close();
        }

        string tentb;

        private void lay_tentb(string ten_num)
        {
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox && control.Name == "groupBox2")
                {
                    foreach (Control num in control.Controls)
                    {
                        if (num is NumericUpDown)
                        {
                            foreach (Control chb in control.Controls)
                            {
                                if (chb is System.Windows.Forms.CheckBox && chb.Name == ten_num.Substring(8))
                                {
                                    tentb = chb.Text;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void load_data_ct_thietbi()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            ds = new DataSet();
            da = new SqlDataAdapter("select MALOAI, TENTB, SOLUONGTB, CT_THIETBI.MATB from CT_THIETBI, THIETBI where CT_THIETBI.MATB = THIETBI.MATB and MALOAI = '" + cbb_loai.SelectedValue + "'", conn.cnn);
            da.Fill(ds, "CT_THIETBI");

            dgv_danhsachloaiphong.DataSource = ds.Tables["CT_THIETBI"];

            conn.cnn.Close();
        }

        private void cbb_loai_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clear_gridview();           
            foreach (Control control in this.Controls)
            {
                if (control is GroupBox && control.Name == "groupBox2")
                {
                    foreach (Control chb in control.Controls)
                    {
                        if (chb is System.Windows.Forms.CheckBox && !((System.Windows.Forms.CheckBox)chb).Checked)
                        {
                            chb.Enabled = true;
                        }
                    }
                }
            }
            load_data_ct_thietbi();
        }

        private void cbb_loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_loai.SelectedIndex != 0)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox && control.Name == "groupBox2")
                    {
                        foreach (Control num in control.Controls)
                        {
                            if (num is NumericUpDown)
                            {
                                num.Enabled = false;
                                ((NumericUpDown)num).Value = 0;
                                foreach (Control chb in control.Controls)
                                {
                                    if (chb is System.Windows.Forms.CheckBox && num.Name == "numeric_" + ((System.Windows.Forms.CheckBox)chb).Name)
                                    {
                                        if (conn.cnn.State == ConnectionState.Closed)
                                        {
                                            conn.cnn.Open();
                                        }
                                        foreach (DataGridViewRow row in dgv_danhsachloaiphong.Rows)
                                        {
                                            if (((System.Windows.Forms.CheckBox)chb).Text == row.Cells[1].Value.ToString())
                                            {
                                                string sql = "select SOLUONGTB from CT_THIETBI where MALOAI = '" + row.Cells[0].Value.ToString() + "' and MATB = '" + get_matb(row.Cells[1].Value.ToString()) + "'";
                                                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                                                ((NumericUpDown)num).Value = (int)cmd.ExecuteScalar();
                                            }
                                        }
                                        conn.cnn.Close();
                                    }
                                }
                            }
                            else if (num is System.Windows.Forms.CheckBox)
                            {
                                ((System.Windows.Forms.CheckBox)num).Checked = false;
                            }
                        }
                    }
                }
            }
            else
            {
                clear_gridview();
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox && control.Name == "groupBox2")
                    {
                        foreach (Control chb in control.Controls)
                        {
                            if (chb is System.Windows.Forms.CheckBox && ((System.Windows.Forms.CheckBox)chb).Enabled == true)
                                chb.Enabled = false;
                            foreach (Control num in control.Controls)
                            {
                                if (num is NumericUpDown && num.Name == "numeric_" + chb.Name)
                                {
                                    num.Enabled = false;
                                    ((NumericUpDown)num).Value = 0;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cbb_loai.SelectedIndex = 0;
        }
    }
    
}
