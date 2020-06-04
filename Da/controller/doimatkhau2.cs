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
        public doimatkhau2()
        {
            InitializeComponent();
        }
        connect conn = new connect();
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

            if (string.Compare(txtmatkhaucu.Text, ds.Tables["MK"].Rows[0]["MK"].ToString()) != 0)
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

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            try
            {
                int kt = kiemtra_thongtin();
                if (kt == 1)
                {
                    if (String.Compare(txtmatkhaucu.Text, txtmatkhaumoi.Text, true) != 0)
                    {
                        if (String.Compare(txtnhaplai.Text, txtmatkhaumoi.Text, true) == 0)
                        {
                            string sel = "update TAIKHOAN set MK='" + txtmatkhaumoi.Text + "' where TENTK='" + tkcu + "' and MK='" + txtmatkhaucu.Text + "'";
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
            }
            catch
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
            }
        }
    }
}
