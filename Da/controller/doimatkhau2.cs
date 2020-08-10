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
    public partial class doimatkhau2 : Form
    {
        public doimatkhau2(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }
        public connect conn;
        DataSet ds = new DataSet();
        SqlDataAdapter da;

        string tkcu = Properties.Settings.Default.MaNV;
        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int kiemtra_thongtin()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select MK from TAIKHOAN where TENTK ='" + tkcu + "'", conn.cnn);
            da.Fill(ds, "MK");

            if (string.Compare(txtmatkhaucu.Text, Base64Decode(ds.Tables["MK"].Rows[0]["MK"].ToString())) != 0)
            {
                MessageBox.Show("Nhập sai mật khẩu cũ");
                txtmatkhaucu.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txtmatkhaucu.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu cũ");
                txtmatkhaucu.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txtmatkhaumoi.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                txtmatkhaumoi.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txtnhaplai.Text))
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                txtnhaplai.Focus();
                return 0;
            }
            else
                return 1;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();
                int kt = kiemtra_thongtin();
                if (kt == 1)
                {
                    if (String.Compare(txtmatkhaucu.Text, txtmatkhaumoi.Text, true) != 0)
                    {
                        if (String.Compare(txtnhaplai.Text, txtmatkhaumoi.Text, true) == 0)
                        {
                            string sel = "update TAIKHOAN set MK='" + Base64Encode(txtmatkhaumoi.Text) + "' where TENTK='" + tkcu + "' and MK='" + Base64Encode(txtmatkhaucu.Text) + "'";
                            SqlCommand cmd = new SqlCommand(sel, conn.cnn);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đổi  mật khẩu thành công !");
                        }
                        else
                        {
                            MessageBox.Show("Nhập lại mật khẩu không trùng khớp !");
                        }
                    }
                    else

                    {
                        MessageBox.Show("Mật khẩu mới trùng mật khẩu cũ !");
                    }
                }
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
        }
    }
}
