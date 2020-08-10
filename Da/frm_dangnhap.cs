using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Da
{
    public partial class frm_dangnhap : DevExpress.XtraEditors.XtraForm
    {
        public connect conn = new connect();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            this.SetDesktopLocation(650, 250);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frm_dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        DataSet ds;
        SqlDataAdapter da;
        private void dangnhap()
        {
            //lưu nhân viên đang xài chương trình !!!cấm xóa  
            Properties.Settings.Default.MaNV = txtten.Text;

            //kiểm tra đăng nhập

            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string selsql = "select * from TAIKHOAN where TENTK='" + txtten.Text + "' and MK='" + Base64Encode(txtmk.Text) + "'";
                ds = new DataSet();
                da = new SqlDataAdapter(selsql, conn.cnn);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    frm_khachsan frm_ks = new frm_khachsan(conn);
                    this.Hide();
                    frm_ks.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }               
                conn.cnn.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void frm_dangnhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dangnhap();
            }
        }
    }
    

}



