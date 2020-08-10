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
    public partial class frm_phieuchuyen : DevExpress.XtraEditors.XtraUserControl
    {
        public connect conn;
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];
        DataSet ds;
        public frm_phieuchuyen()
        {
            InitializeComponent();
        }

        public frm_phieuchuyen(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        public void loadcbxMaKH()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from PHIEUDAT", conn.cnn);

            ds = new DataSet();
            da.Fill(ds, "PHIEUDAT");
            comboBox_madatphong.DataSource = ds.Tables["PHIEUDAT"];
            comboBox_madatphong.DisplayMember = "MADP";
            comboBox_madatphong.ValueMember = "MADP";
            comboBox_madatphong.SelectedIndex = -1;

            conn.cnn.Close();
        }
        public void load_dgvPD()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select * from PHIEUDAT where MADP = '" + comboBox_madatphong.SelectedValue.ToString() + "'", conn.cnn);
                da.Fill(ds, "PHIEUDAT");
                dataGridView_thongtinchitietchuyen.DataSource = ds.Tables["PHIEUDAT"];
                key[0] = ds.Tables["PHIEUDAT"].Columns[0];
                ds.Tables["PHIEUDAT"].PrimaryKey = key;
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Hãy thao tác lại !");
            }
            
        }

        private string sinhtudongMaphieuthue()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds_ph = new DataSet();
            SqlDataAdapter da_phCT = new SqlDataAdapter("select * from PHIEUTHUE", conn.cnn);
            // Ánh xạ dữ liệu từ DB vào dataset, đặt tên Sach
            da_phCT.Fill(ds_ph, "PHIEUTHUE");
            DataTable dt1 = ds_ph.Tables["PHIEUTHUE"];
            int bien1;
            int bien2;
            int bien3 = 1;
            if (dt1 == null)
            {
                bien1 = 1;
                bien2 = bien1;
                bien3 = 1;
            }
            if (dt1.Rows.Count == 0)
            {
                return "TP001";
            }
            else
            {
                bien1 = dt1.Rows.Count + 1;
                bien2 = bien1;
                bien3 = 1;
            }

            while (bien2 < 999)
            {
                bien2 = bien1 + bien3;
                bien3 *= 10;
            }
            conn.cnn.Close();
            return "TP" + bien2.ToString().Substring(1, 3);
        }


        private void frm_phieuchuyen_Load(object sender, EventArgs e)
        {
            loadcbxMaKH();
            textBox_MANV.Text = Properties.Settings.Default.MaNV;
            dtp_ngaychuyen.Value = DateTime.Now;
            textBoxmkh.Clear();
            textBox_MANV.Enabled = false;
            textBox_MATP.Clear();
            comboBox_madatphong.SelectedText = "";
            dtp_ngaytra.Value = DateTime.Now;
            textBox_tiencoc.Clear();
            textBoxsl.Clear();
        }

        private void dataGridView_thongtinchitietchuyen_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dtp_ngaytra.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[4].Value.ToString();
                textBoxsl.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[5].Value.ToString();
                textBoxmkh.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[2].Value.ToString();
                textBox_tiencoc.Text = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[6].Value.ToString();
                comboBox_madatphong.SelectedValue = dataGridView_thongtinchitietchuyen.CurrentRow.Cells[0].Value.ToString();
                textBox_MATP.Text = sinhtudongMaphieuthue();
            }
            catch (Exception)
            {

            }
        }

        public void themPhieuThue()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                int sl = int.Parse(textBoxsl.Text);
                string sql = "INSERT INTO PHIEUTHUE VALUES('" + textBox_MATP.Text + "','" + textBox_MANV.Text + "','" + textBoxmkh.Text + "','" + comboBox_madatphong.SelectedValue.ToString() + "','" + DateTime.Now + "','" + dtp_ngaytra.Value + "'," + sl + ",1,'" + textBox_tiencoc.Text + "', null)";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                cmd.ExecuteNonQuery();
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại thao tác chuyển phòng!");
                conn.cnn.Close();
            }
        }

        private void themChiTietThue()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                ds = new DataSet();
                da = new SqlDataAdapter("select MAPH from CT_PHIEUDAT where MADP = '" + comboBox_madatphong.SelectedValue + "'", conn.cnn);
                da.Fill(ds, "DS_PHONG");
                foreach (DataRow row in ds.Tables["DS_PHONG"].Rows)
                {
                    string sql = "insert into CT_THUEPHONG values ('" + textBox_MATP.Text + "','" + row["MAPH"].ToString() + "')";
                    SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                    int kq = cmd.ExecuteNonQuery();
                }
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng thực hiện lại thao tác chuyển phòng!");
                conn.cnn.Close();
            }
        }

        private void xoaCTPhieuDat()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "delete from CT_PHIEUDAT where MADP = '" + comboBox_madatphong.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            int kq = (int)cmd.ExecuteNonQuery();

            conn.cnn.Close();
        }

        private void xoaPhieuDat()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "delete from PHIEUDAT where MADP = '" + comboBox_madatphong.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = (int)cmd.ExecuteNonQuery();
                if (kq != 0)
                    MessageBox.Show("Lập phiếu thành công");
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi");
                conn.cnn.Close();
            }
        }

        private void chuyenTrangThaiPhong()
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            DataSet ds_ctphieudat = new DataSet();
            SqlDataAdapter da_ctphieudat = new SqlDataAdapter("select * from CT_PHIEUDAT where MADP = '" + comboBox_madatphong.SelectedValue.ToString() + "'", conn.cnn);
            da_ctphieudat.Fill(ds_ctphieudat, "CT_PHIEUDAT");

            DataSet ds_phong = new DataSet();
            SqlDataAdapter da_phong = new SqlDataAdapter("select * from PHONG", conn.cnn);
            da_phong.Fill(ds_phong, "PHONG");
            key[0] = ds_phong.Tables["PHONG"].Columns[0];
            ds_phong.Tables["PHONG"].PrimaryKey = key;

            foreach (DataRow row in ds_ctphieudat.Tables["CT_PHIEUDAT"].Rows)
            {
                DataRow update = ds_phong.Tables["PHONG"].Rows.Find(row["MAPH"].ToString());
                if (update != null)
                {
                    update["TINHTRANG"] = 1;
                    SqlCommandBuilder cmb = new SqlCommandBuilder(da_phong);
                    da_phong.Update(ds_phong, "PHONG");
                }
            }
            conn.cnn.Close();
        }

        private void comboBox_madatphong_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox_MATP.Text = sinhtudongMaphieuthue();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            load_dgvPD();
        }

        private void clear_control()
        {
            textBox_MATP.Clear();
            dtp_ngaychuyen.Value = dtp_ngaytra.Value = DateTime.Now;
            textBoxsl.Clear();
            textBoxmkh.Clear();
            textBox_MATP.Clear();
            textBox_tiencoc.Clear();
            ds.Tables["PHIEUDAT"].Clear();
            dataGridView_thongtinchitietchuyen.DataSource = ds.Tables["PHIEUDAT"];
        }

        private void btnLapphieu_Click(object sender, EventArgs e)
        {
            chuyenTrangThaiPhong();
            themPhieuThue();
            themChiTietThue();
            xoaCTPhieuDat();
            xoaPhieuDat();
            loadcbxMaKH();
            clear_control();
        }
    }
}
