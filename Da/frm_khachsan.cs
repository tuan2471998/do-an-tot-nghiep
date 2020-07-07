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
using DevExpress.CodeParser;


using DevExpress.XtraTab;
using Da.controller;
using System.Data.SqlClient;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.Utils.Extensions;

namespace Da
{
    public partial class frm_khachsan : DevExpress.XtraEditors.XtraForm
    {

        public DataSet ds_ph = new DataSet();
        public SqlDataAdapter da_ph;
        connect conn = new connect();
        public frm_khachsan()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;
        }
        public void AddTab(XtraTabControl XtraTabCha, string TabNameAdd, UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage)
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab (Đây là tên nhé)
            TAbAdd.Name = "Tab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            TAbAdd.Controls.Add(UserControl);
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            // Quăng nó lên TAb Cha (XtraTabCha là đối số thứ nhất như đã nói ở trên)
            XtraTabCha.TabPages.Add(TAbAdd);
        }


        private void AddTabControl(UserControl userControl, string itemTabName)
        {
            pictureBox3.Visible = false;
            hienthi.Visible = true;
            bool isExists = false;
            foreach (XtraTabPage tabItem in hienthi.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    hienthi.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab(hienthi, itemTabName, userControl);
            }
        }
        private void barButtonItem_qlnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DM_NhanVien nv = new DM_NhanVien();
            hienthi.TabPages.Clear();
            AddTabControl(nv, "Thông tin nhân viên");

        }

        private void barButtonItem_doimatkhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_thongtinnhanvien frm = new frm_thongtinnhanvien();
            hienthi.TabPages.Clear();
            AddTabControl(frm, "Thông tin nhân viên");
        }
        //DataTable dt;
        //int flag = 0;
        private void navBarItemphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frm_phieudatphong frm = new frm_phieudatphong();
            hienthi.TabPages.Clear();
            AddTabControl(frm, "Đặt phòng");
        }

        private void frm_khachsan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
                Program.frm_dangnhap.Show();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void barButtonItem_qlkhachhang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DM_khachhang nv = new DM_khachhang();
            hienthi.TabPages.Clear();
            AddTabControl(nv, "Thông tin khách hàng");
        }

        private void navBarchuyenphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //hienthi.TabPages.Clear();
            //frm_phieuchuyen frm = new frm_phieuchuyen();

            //AddTabControl(frm, "Chuyển phiếu phòng");

            hienthi.TabPages.Clear();
            frm_phieuchuyen frm = new frm_phieuchuyen();

            AddTabControl(frm, "Phiếu chuyển phòng");
        }

        private void navBarthuephong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hienthi.TabPages.Clear();
            frm_phieuthue frm = new frm_phieuthue();

            AddTabControl(frm, "Thuê phòng");
        }

        private void barButtonItem_qlphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            DM_phong frm = new DM_phong();

            AddTabControl(frm, "Phòng");
        }

        private void barButtonItem_qldichvu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            DM_dichvu2 frm = new DM_dichvu2();

            AddTabControl(frm, "Danh mục dịch vụ");
        }

        private void navBarItemdichvu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hienthi.TabPages.Clear();
            Phieudichvu frm = new Phieudichvu();

            AddTabControl(frm, "Phiếu dịch vụ");
        }

        private void barButtonItem_phanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            Phanquyen frm = new Phanquyen();

            AddTabControl(frm, "Phân quyền");

        }

        //private void barButtonItem_baocaodanhthu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    hienthi.TabPages.Clear();
        //   BAOCAO frm = new BAOCAO();

        //    AddTabControl(frm, "Thống kê");
        //}

        private void barButtonItem_hoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_hoadon_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //hienthi.TabPages.Clear();
            //frm_thongke frm = new frm_thongke();

            //AddTabControl(frm, "tk");
            hienthi.TabPages.Clear();
            HoaDonTong frm = new HoaDonTong();

            AddTabControl(frm, "Hóa đơn");
        }

        private void navBar_danhsachphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            hienthi.TabPages.Clear();
            frm_danhsachphong frm = new frm_danhsachphong();

            AddTabControl(frm, "Danh sách phòng");
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            qlthietbi frm = new qlthietbi();

            AddTabControl(frm, "Quản lý thiết bị");
        }

        string quyen;
        string tennv;
        public void get_thongtin(string manv)
        {
            string sql = "select hoten, quyen from nhanvien nv\n";
            sql += "inner join taikhoan tk on tk.manv = nv.manv\n";
            sql += "where nv.manv = '" + manv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                quyen = rd["quyen"].ToString();
                tennv = rd["hoten"].ToString();
            }
            rd.Close();
        }

        private void frm_khachsan_Load(object sender, EventArgs e)
        {
            get_thongtin(Properties.Settings.Default.MaNV);
            barStaticItem1.Caption = tennv;
            if (quyen == "NVIEN")
            {
                ribbonPage1.Visible = false;
                barButtonItem_qlnhanvien.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem_qlphong.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }
        

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            frm_Nhaphang frm = new frm_Nhaphang();
            AddTabControl(frm, "Quản lý nhập hàng");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            DS_NHAPHANG frm = new DS_NHAPHANG();
            AddTabControl(frm, "Danh sách nhập hàng");
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            DS_HOADON frm = new DS_HOADON();
            AddTabControl(frm, "Danh sách hóa đơn");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hienthi.TabPages.Clear();
            BAOCAOTONGHOP frm = new BAOCAOTONGHOP();
            AddTabControl(frm, "Báo cáo tổng hợp");
        }
    }
}