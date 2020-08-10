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
    public partial class matkhau_baocaonhaphang : Form
    {
        public connect conn;
        frm_khachsan khachsan;

        public matkhau_baocaonhaphang(connect _conn, frm_khachsan _khachsan)
        {
            InitializeComponent();
            conn = _conn;
            khachsan = _khachsan;
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        private string get_matkhau(string tentk)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MK from TAIKHOAN where TENTK = '" + tentk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private string get_quyen(string tentk)
        {

            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select QUYEN from TAIKHOAN where TENTK = '" + tentk + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);

            return (string)cmd.ExecuteScalar();
        }

        int kq;

        public void kiemtra()
        {
            if (Base64Decode(get_matkhau(txt_taikhoan.Text)) == txt_matkhau.Text.Trim() && get_quyen(txt_taikhoan.Text).Trim() == "ADMIN")
            {
                kq = 1;
            }
            else
            {
                kq = 0;
            }
        }

        private void dangnhap()
        {
            kiemtra();
            if (kq == 1)
            {
                khachsan.show_baocaonhaphang();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi xác minh");
            }
        }

        private void btn_xacminh_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void txt_taikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap();
            }
        }
    }
}
