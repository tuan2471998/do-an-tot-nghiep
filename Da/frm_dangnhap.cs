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
        connect conn = new connect();
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

        private void btndn_Click(object sender, EventArgs e)
        {
            //lưu nhân viên đang xài chương trình !!!cấm xóa  
            Properties.Settings.Default.MaNV = txtten.Text;

            //kiểm tra đăng nhập

           try
            {
                connect conn = new connect();
                string selsql = "select * from TAIKHOAN where TENTK='" + txtten.Text + "' and MK='" + txtmk.Text + "'";
                SqlCommand cmd = new SqlCommand(selsql, conn.cnn);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.Read() == true)
                {

                    if (Program.frm_khachsan == null || Program.frm_khachsan.IsDisposed)
                    {
                        Program.frm_khachsan = new frm_khachsan();
                        this.Hide();
                        Program.frm_khachsan.Show();
                    }
                    else
                    {
                        this.Hide();
                        Program.frm_khachsan.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }
    }
    

}



