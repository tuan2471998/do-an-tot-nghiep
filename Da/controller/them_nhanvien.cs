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
using System.IO;

namespace Da.controller
{
    public partial class them_nhanvien : Form
    {
        public them_nhanvien()
        {
            InitializeComponent();
        }

        connect conn = new connect();

        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataColumn[] key = new DataColumn[1];

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string url = "";

        private void btn_chon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG picture(*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                url = ofd.FileName.ToString();
            }
        }

        public string ImageToBase64(string path)
        {
            using (System.Drawing.Image image = System.Drawing.Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    return base64String;
                }
            }
        }

        int kiemtra_thongtin()
        {
            if (string.IsNullOrEmpty(txt_hoten.Text))
            {
                MessageBox.Show("Chưa nhập họ và tên nhân viên");
                txt_hoten.Focus();
                return 0;
            }
            else if (!txt_email.Text.Contains('@') || !txt_email.Text.Contains('.'))
            {
                MessageBox.Show("Email không hợp lệ");
                txt_email.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_cmnd.Text))
            {
                MessageBox.Show("Chưa nhập số căn cước/chứng minh nhân viên");
                txt_cmnd.Focus();
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_diachi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ nhân viên");
                txt_diachi.Focus();
                return 0;
            }
            else if (txt_sdt.Text.Length < 10 || txt_sdt.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ");
                txt_sdt.Focus();
                return 0;
            }
            else if (txt_cmnd.Text.Length < 10 || txt_cmnd.Text.Length > 12)
            {
                MessageBox.Show("Số CMND không hợp lệ");
                txt_sdt.Focus();
                return 0;
            }
            else if (cbb_bangcap.SelectedIndex == 0)
            {
                MessageBox.Show("Chưa chọn bằng cấp nhân viên");
                return 0;
            }
            else if (string.IsNullOrEmpty(txt_sdt.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại nhân viên");
                txt_sdt.Focus();
                return 0;
            }
            else if (pictureBox1.Image == null)
            {
                MessageBox.Show("Chưa chọn hình ảnh nhân viên");
                return 0;
            }
            else
                return 1;
        }

        private void them_thong_tin_nhan_vien()
        {
            da = new SqlDataAdapter(" select * from NHANVIEN", conn.cnn);
            ds = new DataSet();
            da.Fill(ds, "NHANVIEN");
            key[0] = ds.Tables["NHANVIEN"].Columns[0];
            ds.Tables["NHANVIEN"].PrimaryKey = key;

            // tự động tạo mã nhân viên
            int max = 0;
            foreach (DataRow row in ds.Tables["NHANVIEN"].Rows)
            {
                int stt = int.Parse(row["MANV"].ToString().Substring(2));
                if (max < stt)
                    max = stt;
            }
            string manv;
            if (max > 0 && max < 10)
            {
                manv = "NV00" + (max + 1).ToString();
            }
            else if (max >= 10 && max < 100)
            {
                manv = "NV0" + (max + 1).ToString();
            }
            else
            {
                manv = "NV" + (max + 1).ToString();
            }
            string image = ImageToBase64(url);

            // kết quả thêm thông tin vào bảng NHANVIEN: 1 = thêm thành công, 0 = thêm thất bại
            int kq = 0;
            int kq_kt = kiemtra_thongtin();
            if (kq_kt == 1)
            {
                string gioitinh;
                if (rdb_nam.Checked)
                    gioitinh = rdb_nam.Text;
                else
                    gioitinh = rdb_nu.Text;

                DataRow insert_New = ds.Tables["NHANVIEN"].NewRow();
                insert_New["MANV"] = manv;
                insert_New["HOTEN"] = txt_hoten.Text;
                insert_New["SOCMND"] = txt_cmnd.Text;
                insert_New["SDT"] = txt_sdt.Text;
                insert_New["EMAIL"] = txt_email.Text;
                insert_New["GIOITINH"] = gioitinh;
                insert_New["DIACHI"] = txt_diachi.Text;
                insert_New["BANGCAP"] = cbb_bangcap.SelectedItem.ToString();
                insert_New["NGAYVAOLAM"] = dateTimePicker_ngayvaolam.Text;
                insert_New["NGAYSINH"] = dateTimePicker_ngaysinh.Text;
                insert_New["HINHANH"] = image;

                ds.Tables["NHANVIEN"].Rows.Add(insert_New);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "NHANVIEN");

                ds.Tables["NHANVIEN"].Clear();

                kq = 1;
            }
            else
                kq = 0;

            //tự động cấp tài khoản cho nhân viên vừa thêm
            if (kq == 1)
            {
                da = new SqlDataAdapter(" select * from TAIKHOAN", conn.cnn);
                ds = new DataSet();
                da.Fill(ds, "TAIKHOAN");
                key[0] = ds.Tables["TAIKHOAN"].Columns[0];
                ds.Tables["TAIKHOAN"].PrimaryKey = key;

                DataRow insert_New_tk = ds.Tables["TAIKHOAN"].NewRow();
                insert_New_tk["TENTK"] = manv;
                insert_New_tk["MANV"] = manv;
                insert_New_tk["MK"] = "123";
                insert_New_tk["QUYEN"] = "NVIEN";

                ds.Tables["TAIKHOAN"].Rows.Add(insert_New_tk);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.Update(ds, "TAIKHOAN");
                ds.Tables["TAIKHOAN"].Clear();

                MessageBox.Show("Thêm Thành công");
            }
            try
            {

            }
            catch
            {
                MessageBox.Show("Lỗi");
            }

        }

        private void them_nhanvien_Load(object sender, EventArgs e)
        {
            rdb_nam.Checked = true;
            cbb_bangcap.SelectedIndex = 0;
        }

        private void btn_luuvathem_Click(object sender, EventArgs e)
        {
            int kt = kiemtra_thongtin();
            if (kt == 1)
            {
                them_thong_tin_nhan_vien();
                rdb_nam.Checked = true;
                txt_cmnd.Clear();
                txt_diachi.Clear();
                txt_hoten.Clear();
                txt_sdt.Clear();
                txt_hoten.Focus();
                txt_email.Clear();
                cbb_bangcap.SelectedIndex = 0;

                dateTimePicker_ngaysinh.Text = "";
                dateTimePicker_ngayvaolam.Text = "";
                rdb_nam.Checked = rdb_nu.Checked = false;
                

                dateTimePicker_ngaysinh.Value = new DateTime(1990, 01, 01);
                dateTimePicker_ngayvaolam.Value = DateTime.Today;
                pictureBox1.Image = null;

            }           
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        private void btn_luuvadong_Click(object sender, EventArgs e)
        {
            int kt = kiemtra_thongtin();
            if (kt == 1)
            {
                them_thong_tin_nhan_vien();
                this.Close();
            }
        }        
    }
}
