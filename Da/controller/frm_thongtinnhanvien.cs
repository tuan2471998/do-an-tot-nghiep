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
using System.IO;

namespace Da.controller
{
    public partial class frm_thongtinnhanvien : UserControl
    {
        public frm_thongtinnhanvien()
        {
            InitializeComponent();
        }
        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string tk = Properties.Settings.Default.MaNV;

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            doimatkhau2 doimk = new doimatkhau2();
            doimk.StartPosition = FormStartPosition.CenterScreen;
            doimk.Show();
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        public void loadNhanVien()
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(" select * from NHANVIEN", conn.cnn);
            da.Fill(ds, "NHANVIEN");
        }

        private void frm_thongtinnhanvien_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            da = new SqlDataAdapter("select * from NHANVIEN where MANV = '" + tk + "'", conn.cnn);
            da.Fill(ds, "NHANVIEN");

            txtmanv.Text = tk;
            txthoten.Text += ds.Tables["NHANVIEN"].Rows[0]["HOTEN"].ToString();
            txtcmnd.Text += ds.Tables["NHANVIEN"].Rows[0]["SOCMND"].ToString();
            txtsdt.Text += ds.Tables["NHANVIEN"].Rows[0]["SDT"].ToString();
            txtdiachi.Text += ds.Tables["NHANVIEN"].Rows[0]["DIACHI"].ToString();
            txtgioitinh.Text += ds.Tables["NHANVIEN"].Rows[0]["GIOITINH"].ToString();
            txtemail.Text += ds.Tables["NHANVIEN"].Rows[0]["EMAIL"].ToString();
            txtngayvaolam.Text += DateTime.Parse(ds.Tables["NHANVIEN"].Rows[0]["NGAYVAOLAM"].ToString()).ToString("dd/MM/yyyy");
            txtbangcap.Text += ds.Tables["NHANVIEN"].Rows[0]["BANGCAP"].ToString();
            txtngaysinh.Text += DateTime.Parse(ds.Tables["NHANVIEN"].Rows[0]["NGAYSINH"].ToString()).ToString("dd/MM/yyyy");

            pictureBox_avatar.Image = Base64ToImage(ds.Tables["NHANVIEN"].Rows[0]["HINHANH"].ToString());
        }
    }
}
