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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.IO;
using DevExpress.DataAccess.DataFederation;

namespace Da.controller
{
    public partial class DS_NHAPHANG : UserControl
    {
        public connect conn;
        DataSet ds_menu;
        SqlDataAdapter da_menu;
        DataSet ds_tb;
        SqlDataAdapter da_tb;
        public DS_NHAPHANG()
        {
            InitializeComponent();
        }
        public DS_NHAPHANG(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void button_today_Click(object sender, EventArgs e)
        {
            dtp_denngay.Value = dtp_tungay.Value = DateTime.Now;
        }

        private void get_nhaphang_menu()
        {

            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string tungay = dtp_tungay.Value.ToString("yyyy-MM-dd");
            string denngay = dtp_denngay.Value.ToString("yyyy-MM-dd");

            string sql = "select ngaynhaphang, manv, hn.tenhangnhap, menu.tenmenu as 'tenhang', soluong_nhap, dongia_nhap, thanhtien_hang, h.mahangnhap, ctnh.mahang\n";
            sql += "from nhaphang nh, ct_nhaphang ctnh, hang h, menu, hangnhap hn\n";
            sql += "where nh.MANHAPHANG = ctnh.MANHAPHANG\n";
            sql += "and h.mahang = ctnh.mahang\n";
            sql += "and menu.idmenu = tenhang\n";
            sql += "and hn.mahangnhap = h.mahangnhap\n";
            sql += "and h.mahangnhap = 'ML002     '\n";
            sql += "and convert(date, ngaynhaphang) between '" + tungay + "' and '" + denngay + "'";

            ds_menu = new DataSet();
            da_menu = new SqlDataAdapter(sql, conn.cnn);
            da_menu.Fill(ds_menu, "MENU");

            conn.cnn.Close();   
        }

        private void get_nhaphang_thietbi()
        {

            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string tungay = dtp_tungay.Value.ToString("yyyy-MM-dd");
            string denngay = dtp_denngay.Value.ToString("yyyy-MM-dd");

            string sql = "select ngaynhaphang, manv, hn.tenhangnhap, tb.tentb as 'tenhang', soluong_nhap, dongia_nhap, thanhtien_hang, h.mahangnhap, ctnh.mahang\n";
            sql += "from nhaphang nh, ct_nhaphang ctnh, hang h, thietbi tb, hangnhap hn\n";
            sql += "where nh.MANHAPHANG = ctnh.MANHAPHANG\n";
            sql += "and h.mahang = ctnh.mahang\n";
            sql += "and tb.matb = tenhang\n";
            sql += "and hn.mahangnhap = h.mahangnhap\n";
            sql += "and h.mahangnhap = 'ML001     '\n";
            sql += "and convert(date, ngaynhaphang) between '" + tungay + "' and '" + denngay + "'";

            ds_tb = new DataSet();
            da_tb = new SqlDataAdapter(sql, conn.cnn);
            da_tb.Fill(ds_tb, "THIETBI");

            conn.cnn.Close();
        }
        System.Data.DataTable dt;
        private string saveExcelFile;

        private void gopbang()
        {
            dt = new System.Data.DataTable();

            dt.Columns.Add("ngaynhaphang");
            dt.Columns.Add("manv");
            dt.Columns.Add("tenhangnhap");
            dt.Columns.Add("tenhang");
            dt.Columns.Add("soluong_nhap");
            dt.Columns.Add("dongia_nhap");
            dt.Columns.Add("thanhtien_hang");
            dt.Columns.Add("mahangnhap");
            dt.Columns.Add("mahang");

            DataRow newrow;

            foreach (DataRow row1 in ds_menu.Tables["MENU"].Rows)
            {
                newrow = dt.NewRow();
                newrow["ngaynhaphang"] = row1["ngaynhaphang"].ToString();
                newrow["manv"] = row1["manv"].ToString();
                newrow["tenhangnhap"] = row1["tenhangnhap"].ToString();
                newrow["tenhang"] = row1["tenhang"].ToString();
                newrow["soluong_nhap"] = row1["soluong_nhap"].ToString();
                newrow["dongia_nhap"] = decimal.Parse(row1["dongia_nhap"].ToString()).ToString("###,##");
                newrow["thanhtien_hang"] = decimal.Parse(row1["thanhtien_hang"].ToString()).ToString("###,##");
                newrow["mahangnhap"] = row1["mahangnhap"].ToString();
                newrow["mahang"] = row1["mahang"].ToString();

                dt.Rows.Add(newrow);
            }

            foreach (DataRow row in ds_tb.Tables["THIETBI"].Rows)
            {
                newrow = dt.NewRow();

                newrow["ngaynhaphang"] = row["ngaynhaphang"].ToString();
                newrow["manv"] = row["manv"].ToString();
                newrow["tenhangnhap"] = row["tenhangnhap"].ToString();
                newrow["tenhang"] = row["tenhang"].ToString();
                newrow["soluong_nhap"] = row["soluong_nhap"].ToString();
                newrow["dongia_nhap"] = decimal.Parse(row["dongia_nhap"].ToString()).ToString("###,##");
                newrow["thanhtien_hang"] = decimal.Parse(row["thanhtien_hang"].ToString()).ToString("###,##");
                newrow["mahangnhap"] = row["mahangnhap"].ToString();
                newrow["mahang"] = row["mahang"].ToString();

                dt.Rows.Add(newrow);
            }

            dgv_baocaonhaphang.DataSource = dt;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            get_nhaphang_menu();
            get_nhaphang_thietbi();
            gopbang();

            double tongtien = 0;
            foreach (DataGridViewRow row in dgv_baocaonhaphang.Rows)
            {
                tongtien += double.Parse(row.Cells[6].Value.ToString());
            }
            txt_tongtien.Text = tongtien.ToString();

            btn_Xuatbaocao.Enabled = true;
        }

        private void DS_NHAPHANG_Load(object sender, EventArgs e)
        {
            dgv_baocaonhaphang.Columns[5].DefaultCellStyle.Format = "N0";
            dgv_baocaonhaphang.Columns[6].DefaultCellStyle.Format = "N0";
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tongtien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tongtien.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_tongtien.Text = String.Format(culture, "{0:N0}", value);
                txt_tongtien.Select(txt_tongtien.Text.Length, 0);
            }
        }

        private void btn_Xuatbaocao_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    saveExcelFile = sfd.FileName + ".xlsx";
                }

                Excel.Application xlApp = new Excel.Application();

                if (xlApp == null)
                {
                    MessageBox.Show("Lỗi không thể sử dụng được thư viện EXCEL");
                    return;
                }
                xlApp.Visible = false;

                object misValue = System.Reflection.Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 26;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                Range row_TieuDe_ThongKeHoaDon = ws.get_Range("A1", "H1");
                row_TieuDe_ThongKeHoaDon.Merge();
                row_TieuDe_ThongKeHoaDon.Font.Size = fontSizeTieuDe;
                row_TieuDe_ThongKeHoaDon.Font.Name = fontName;
                row_TieuDe_ThongKeHoaDon.Font.Bold = true;
                row_TieuDe_ThongKeHoaDon.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_TieuDe_ThongKeHoaDon.Value2 = "Thống kê nhập hàng";

                Range row_tungay = ws.get_Range("B2", "C2");
                row_tungay.Merge();
                row_tungay.Font.Size = fontSizeTenTruong;
                row_tungay.Font.Name = fontName;
                row_tungay.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tungay.Value2 = "Từ ngày: " + dtp_tungay.Value.ToString("dd/MM/yyyy");

                Range row_denngay = ws.get_Range("D2", "E2");
                row_denngay.Merge();
                row_denngay.Font.Size = fontSizeTenTruong;
                row_denngay.Font.Name = fontName;
                row_denngay.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_denngay.Value2 = "Đến ngày: " + dtp_denngay.Value.ToString("dd/MM/yyyy");

                Range row_tongtien = ws.get_Range("F2", "G2");
                row_tongtien.Merge();
                row_tongtien.Font.Size = fontSizeTenTruong;
                row_tongtien.Font.Name = fontName;
                row_tongtien.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tongtien.Value2 = "Tổng tiền nhập hàng: " + txt_tongtien.Text;

                Range row_STT = ws.get_Range("A4");
                row_STT.Font.Size = fontSizeTenTruong;
                row_STT.Font.Name = fontName;
                row_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_STT.Value2 = "STT";

                Range row_ngaynhap = ws.get_Range("B4");
                row_ngaynhap.Font.Size = fontSizeTenTruong;
                row_ngaynhap.Font.Name = fontName;
                row_ngaynhap.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_ngaynhap.Value2 = "Ngày nhập hàng";

                Range row_MaNV = ws.get_Range("C4");
                row_MaNV.Font.Size = fontSizeTenTruong;
                row_MaNV.Font.Name = fontName;
                row_MaNV.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_MaNV.Value2 = "Mã nhân viên";

                Range row_tenhangnhap = ws.get_Range("D4");
                row_tenhangnhap.Font.Size = fontSizeTenTruong;
                row_tenhangnhap.Font.Name = fontName;
                row_tenhangnhap.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_tenhangnhap.Value2 = "Tên hàng nhập";

                Range row_Tenhang = ws.get_Range("E4");
                row_Tenhang.Font.Size = fontSizeTenTruong;
                row_Tenhang.Font.Name = fontName;
                row_Tenhang.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_Tenhang.Value2 = "Tên hàng";

                Range row_soluong = ws.get_Range("F4");
                row_soluong.Font.Size = fontSizeTenTruong;
                row_soluong.Font.Name = fontName;
                row_soluong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_soluong.Value2 = "Số lượng nhập";

                Range row_dongia = ws.get_Range("G4");
                row_dongia.Font.Size = fontSizeTenTruong;
                row_dongia.Font.Name = fontName;
                row_dongia.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_dongia.Value2 = "Đơn giá";

                Range row_thanhtien = ws.get_Range("H4");
                row_thanhtien.Font.Size = fontSizeTenTruong;
                row_thanhtien.Font.Name = fontName;
                row_thanhtien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_thanhtien.Value2 = "Thành tiền";


                //Tô nền vàng các cột tiêu đề:
                Range row_CotTieuDe = ws.get_Range("A4", "H4");
                //nền vàng
                row_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row_CotTieuDe.Font.Bold = true;
                //chữ đen
                row_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 4;//dữ liệu xuất bắt đầu từ dòng số 3 trong file Excel (khai báo 2 để vào vòng lặp nó ++ thành 4)

                foreach (DataRow datarow in dt.Rows)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, datarow["ngaynhaphang"], datarow["manv"], datarow["tenhangnhap"], datarow["tenhang"], datarow["soluong_nhap"], datarow["dongia_nhap"], datarow["thanhtien_hang"] };
                    Range rowData = ws.get_Range("A" + row, "H" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Columns.AutoFit();

                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A4", "H" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);

                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                releaseObject(ws);
                releaseObject(wb);
                releaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                System.Diagnostics.Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }
        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                obj = null;
            }
            finally
            { GC.Collect(); }
        }
    }
}
