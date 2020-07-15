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
using DevExpress.DataAccess.UI.Native.Sql.DataConnectionControls;

namespace Da.controller
{
    public partial class Phanquyen : DevExpress.XtraEditors.XtraUserControl
    {
        public connect conn;
        DataSet ds;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        string nhomquyen;

        public Phanquyen(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
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
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
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

            conn.cnn.Close();
        }

        private void LoadTK_nhomquyen()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            lay_nhomquyen();

            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND QUYEN = '" + nhomquyen + "'"; 
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;

            conn.cnn.Close();
        }

        private void LoadTK_nhomquyen(string nhomquyen)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND QUYEN = '" + nhomquyen + "'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;

            conn.cnn.Close();
        }

        private void LoadTK_nhomquyen_tentk(string tentk)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND TENTK like '" + tentk + "%'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;
            conn.cnn.Close();
        }

        private void LoadTK_nhomquyen_tennv(string tennv)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds = new DataSet();
            string sql = "SELECT TENTK, TAIKHOAN.MANV, HOTEN, QUYEN FROM TAIKHOAN, NHANVIEN WHERE TAIKHOAN.MANV = NHANVIEN.MANV AND HOTEN like N'" + tennv + "%'";
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "TAIKHOAN_nhomquyen");
            dgv_tktheonhomquyen.DataSource = ds.Tables["TAIKHOAN_nhomquyen"];
            key[0] = ds.Tables["TAIKHOAN_nhomquyen"].Columns[0];
            ds.Tables["TAIKHOAN_nhomquyen"].PrimaryKey = key;

            conn.cnn.Close();
        }

        private void Phanquyen_Load(object sender, EventArgs e)
        {
            LoadTK();
            cbb_nhomquyen.SelectedIndex = 0;
            btnlammoi.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
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

        string manv;
        private void btncapquyen_Click(object sender, EventArgs e)
        {
            manv = Properties.Settings.Default.MaNV;
            if (dgv_tktheonhomquyen.Rows.Count == 0)
            {
                MessageBox.Show("Chưa chọn nhóm quyền");
            }
            else
            {
                try
                {
                    if (conn.cnn.State == ConnectionState.Closed)
                    {
                        conn.cnn.Open();
                    }
                    lay_nhomquyen();

                    for (int i = 0; i < dgv_taikhoan.Rows.Count; i++)
                    {
                        if (dgv_taikhoan.Rows[i].Selected == true)
                            lb_tentk.Text = dgv_taikhoan.Rows[i].Cells[1].Value.ToString();
                    }

                    if (lb_tentk.Text.Trim() == manv.Trim())
                    {
                        MessageBox.Show("Mã nhân viên không hợp lệ");
                    }

                    else
                    {
                        string sql = "UPDATE TAIKHOAN SET QUYEN = '" + nhomquyen + "' WHERE TENTK = '" + lb_tentk.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                        int kq = cmd.ExecuteNonQuery();

                        if (kq != 0)
                            MessageBox.Show("Cấp quyền thành công");

                        LoadTK();
                        LoadTK_nhomquyen();
                        cbb_nhomquyen.SelectedIndex = 0;
                    }
                    conn.cnn.Close();
                    
                }
                catch
                {
                    MessageBox.Show("Tài khoản chọn không phù hợp");
                    conn.cnn.Close();
                }
            }
        }

        private void btnxoaquyen_Click(object sender, EventArgs e)
        {
            manv = Properties.Settings.Default.MaNV;
            for (int i = 0; i < dgv_tktheonhomquyen.Rows.Count; i++)
            {
                if (dgv_tktheonhomquyen.Rows[i].Selected == true)
                    lb_tentk.Text = dgv_tktheonhomquyen.Rows[i].Cells[1].Value.ToString();
            }
            
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                if (lb_tentk.Text.Trim() == manv.Trim())
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ");
                }
                else
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
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại");
                conn.cnn.Close();
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
