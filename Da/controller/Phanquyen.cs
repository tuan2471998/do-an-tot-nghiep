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
using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;
using System.Web.UI;

namespace Da.controller
{
    public partial class Phanquyen : DevExpress.XtraEditors.XtraUserControl
    {
        connect conn = new connect();
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        string nhomquyen;

        public Phanquyen()
        {
            InitializeComponent();
        }

        private void lay_nhomquyen()
        {
            if (cbb_nhomquyen.SelectedIndex == 1)
                nhomquyen = "ADMIN";
            else if (cbb_nhomquyen.SelectedIndex == 2)
                nhomquyen = "NVIEN";
        }

        private void LoadTK()
        {
            ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN");
            dgv_taikhoan.DataSource = ds.Tables["TAIKHOAN"];
            key[0] = ds.Tables["TAIKHOAN"].Columns[0];
            ds.Tables["TAIKHOAN"].PrimaryKey = key;

            for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
            {
                txttentk.AutoCompleteCustomSource.Add(ds.Tables["TAIKHOAN"].Rows[i][0].ToString());
                txttennv.AutoCompleteCustomSource.Add(ds.Tables["TAIKHOAN"].Rows[i][2].ToString());
            }

            txttentk.AutoCompleteMode = AutoCompleteMode.Append;
            txttentk.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txttennv.AutoCompleteMode = AutoCompleteMode.Append;
            txttennv.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LoadTK_nhomquyen()
        {
            lay_nhomquyen();

            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND QUYEN = '" + nhomquyen + "'"; 
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;
        }

        private void LoadTK_nhomquyen(string nhomquyen)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND QUYEN = '" + nhomquyen + "'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;
        }

        private void LoadTK_nhomquyen_tentk(string tentk)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND TENTK like '" + tentk + "%'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;
        }

        private void LoadTK_nhomquyen_tennv(string tennv)
        {
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND HOTEN like N'" + tennv + "%'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;
        }

        private void Phanquyen_Load(object sender, EventArgs e)
        {
            LoadTK();
            cbb_nhomquyen.SelectedIndex = 0;
            btnlammoi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
        }

        private void btn_xoaquyen_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_capquyen_Click(object sender, EventArgs e)
        {
            
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttentk.Text) == false)
            {
                clear_row_tk();
                clear_row_tknhomquyen();
                for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
                {
                    LoadTK_nhomquyen_tentk(txttentk.Text);
                    //if (string.Compare(txttentk.Text, dgv_taikhoan.Rows[i].Cells[0].Value.ToString()) == 0)
                    //{
                    //    dgv_taikhoan.Rows[i].Selected = true;                        
                    //}
                }
            }
            else if (string.IsNullOrEmpty(txttennv.Text) == false)
            {
                clear_row_tk();
                for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
                {
                    LoadTK_nhomquyen_tennv(txttennv.Text);
                    //if (string.Compare(txttennv.Text, dgv_taikhoan.Rows[i].Cells[2].Value.ToString()) == 0)
                    //{
                    //    dgv_taikhoan.Rows[i].Selected = true;                       
                    //}
                }
            }
            else if (cbb_nhomquyen.SelectedIndex != 0)
            {
                LoadTK_nhomquyen();
            }
            else
            {
                MessageBox.Show("Thông tin tìm kiếm không chính xác");
            }
        }

        private void clear_row_tk()
        {
            for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
            {
                if (dgv_taikhoan.Rows[i].Selected == true)
                    dgv_taikhoan.Rows[i].Selected = false;
            }
        }

        private void clear_row_tknhomquyen()
        {
            for (int i = 0; i < dgv_tktheonhomquyen.Rows.Count; i++)
            {
                if (dgv_tktheonhomquyen.Rows[i].Selected == true)
                    dgv_tktheonhomquyen.Rows[i].Selected = false;
            }
        }

        private void dgv_taikhoan_SelectionChanged(object sender, EventArgs e)
        {
            clear_row_tknhomquyen();

            //for (int i = 0; i < dgv_tktheonhomquyen.Rows.Count; i++)
            //{
            //    if (string.Compare(dgv_taikhoan.CurrentRow.Cells[0].Value.ToString(), dgv_tktheonhomquyen.Rows[i].Cells[0].Value.ToString()) == 0)
            //        dgv_tktheonhomquyen.Rows[i].Selected = true;
            //}
        }

        private void txttennv_Click(object sender, EventArgs e)
        {
            txttennv.Clear();
        }

        private void txttentk_Click(object sender, EventArgs e)
        {
            txttentk.Clear();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            dgv_tktheonhomquyen.DataSource = null;
            txttentk.Clear();
            txttennv.Clear();
            cbb_nhomquyen.SelectedIndex = 0;
        }

        private void btncapquyen_Click(object sender, EventArgs e)
        {
            if (dgv_tktheonhomquyen.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn nhóm quyền");
            }
            else
            {
                try
                {
                    lay_nhomquyen();

                    for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
                    {
                        if (dgv_taikhoan.Rows[i].Selected == true)
                            lb_tentk.Text = dgv_taikhoan.Rows[i].Cells[1].Value.ToString();
                    }

                    string sql = "UPDATE TAIKHOAN SET QUYEN = '" + nhomquyen + "' WHERE TENTK = '" + lb_tentk.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    int kq = cmd.ExecuteNonQuery();

                    if (kq != 0)
                        MessageBox.Show("Cấp quyền thành công");

                    LoadTK();
                    LoadTK_nhomquyen();
                    cbb_nhomquyen.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Tài khoản chọn không phù hợp");
                }
            }
        }

        private void btnxoaquyen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_tktheonhomquyen.Rows.Count; i++)
            {
                if (dgv_tktheonhomquyen.Rows[i].Selected == true)
                    lb_tentk.Text = dgv_tktheonhomquyen.Rows[i].Cells[1].Value.ToString();
            }

            try
            {
                string sql = "UPDATE TAIKHOAN SET QUYEN = NULL WHERE TENTK = '" + lb_tentk.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = cmd.ExecuteNonQuery();

                if (kq != 0)
                    MessageBox.Show("Xóa quyền thành công");

                LoadTK();
                LoadTK_nhomquyen();
                cbb_nhomquyen.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
            }
        }

        private void btncapquyen_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btncapquyen.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnxoaquyen_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnxoaquyen.ClientRectangle,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLightLight, 5, ButtonBorderStyle.Outset);
        }

       
    }
}
