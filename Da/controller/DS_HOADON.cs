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
    public partial class DS_HOADON : UserControl
    {
        public connect conn;

        public DS_HOADON(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        DataSet ds;
        SqlDataAdapter da;

        private void load_cbb_nhanvien()
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select MANV from NHANVIEN";
            ds = new DataSet();
            da = new SqlDataAdapter(sql, conn.cnn);
            da.Fill(ds, "MANV");

            cbb_nhanvien.DisplayMember = cbb_nhanvien.ValueMember = "MANV"; ;
            
            cbb_nhanvien.DataSource = ds.Tables["MANV"];

            DataRow row = ds.Tables["MANV"].NewRow();
            row["MANV"] = "Tất cả";
            ds.Tables["MANV"].Rows.InsertAt(row, 0);

            conn.cnn.Close();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            conn.cnn.Close();
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                    conn.cnn.Open();

                string sql = "select distinct hd.MAHD, hd.MANV_LAPPHIEU, pt.MAKH, pt.NGAYNHAN, hd.NGAYLAP, cthd.TIEN_PH, cthd.TIEN_DV, cthd.TIEN_MENU, cthd.TIEN_PHUTHU, cthd.GHICHU_PHUTHU, hd.TONGTIEN, hd.TIENMAT, hd.TIENTHE, pt.TIENCOC, kh.HOTEN\n";
                sql += "from hoadon hd, phieuthue pt, ct_thuephong cttp, ct_hd cthd, khachhang kh\n";
                sql += "where cthd.MAHD = hd.MAHD\n";
                sql += "and kh.MAKH = pt.MAKH\n";
                sql += "and pt.MATP = cthd.MATP\n";
                sql += "and convert(date,hd.NGAYLAP) between '" + dtp_tungay.Value.ToString("yyyy-MM-dd") + "' and '" + dtp_denngay.Value.ToString("yyyy-MM-dd") + "'\n";

                if (cbb_nhanvien.SelectedIndex >= 1)
                {
                    sql += "and MANV_LAPPHIEU = '" + cbb_nhanvien.SelectedValue.ToString() + "'";
                }

                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "BAOCAO");

                double tienphong = 0;
                double tiendv = 0;
                double tienphuthu = 0;
                double tienthucdon = 0;
                double tongtien = 0;
                double tienmat = 0;
                double tienthe = 0;
                double tiencoc = 0;

                foreach (DataRow row in ds.Tables["BAOCAO"].Rows)
                {
                    tienphong += double.Parse(row["TIEN_PH"].ToString());
                    tiendv += double.Parse(row["TIEN_DV"].ToString());
                    tienphuthu += double.Parse(row["TIEN_PHUTHU"].ToString());
                    tienthucdon += double.Parse(row["TIEN_MENU"].ToString());
                    tongtien += double.Parse(row["TONGTIEN"].ToString());
                    tienmat += double.Parse(row["TIENMAT"].ToString());
                    tienthe += double.Parse(row["TIENTHE"].ToString());
                    tiencoc += double.Parse(row["TIENCOC"].ToString());
                }

                txt_tienphong.Text = tienphong.ToString();
                txt_tiendichvu.Text = tiendv.ToString();
                txt_tienphuthu.Text = tienphuthu.ToString();
                txt_tienthucdon.Text = tienthucdon.ToString();
                txt_tongtien.Text = tongtien.ToString();
                txt_tienmat.Text = tienmat.ToString();
                txt_tienthe.Text = tienthe.ToString();
                txt_tiencoc.Text = tiencoc.ToString();

                dgv_thongkehoadon.DataSource = ds.Tables["BAOCAO"];
                btn_Xuatbaocao.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Lỗi");
                conn.cnn.Close();
            }
        }

        private void DS_HOADON_Load(object sender, EventArgs e)
        {
            for (int i = 5; i <= 13; i++)
            {
                dgv_thongkehoadon.Columns[i].DefaultCellStyle.Format = "N0";
            }
            load_cbb_nhanvien();
            cbb_nhanvien.SelectedIndex = 0;
        }

        private void txt_tienphong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienphong.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienphong.Text, System.Globalization.NumberStyles.Any);
                txt_tienphong.Text = String.Format(culture, "{0:N0}", value);
                txt_tienphong.Select(txt_tienphong.Text.Length, 0);
            }
        }

        private void txt_tiendichvu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tiendichvu.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tiendichvu.Text, System.Globalization.NumberStyles.Any);
                txt_tiendichvu.Text = String.Format(culture, "{0:N0}", value);
                txt_tiendichvu.Select(txt_tiendichvu.Text.Length, 0);
            }
        }

        private void txt_tienthucdon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthucdon.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienthucdon.Text, System.Globalization.NumberStyles.Any);
                txt_tienthucdon.Text = String.Format(culture, "{0:N0}", value);
                txt_tienthucdon.Select(txt_tienthucdon.Text.Length, 0);
            }
        }

        private void txt_tienphuthu_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienphuthu.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienphuthu.Text, System.Globalization.NumberStyles.Any);
                txt_tienphuthu.Text = String.Format(culture, "{0:N0}", value);
                txt_tienphuthu.Select(txt_tienphuthu.Text.Length, 0);
            }
        }

        private void txt_tongtien_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tongtien.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tongtien.Text, System.Globalization.NumberStyles.Any);
                txt_tongtien.Text = String.Format(culture, "{0:N0}", value);
                txt_tongtien.Select(txt_tongtien.Text.Length, 0);
            }
        }

        private void txt_tienmat_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienmat.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienmat.Text, System.Globalization.NumberStyles.Any);
                txt_tienmat.Text = String.Format(culture, "{0:N0}", value);
                txt_tienmat.Select(txt_tienmat.Text.Length, 0);
            }
        }

        private void txt_tienthe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tienthe.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tienthe.Text, System.Globalization.NumberStyles.Any);
                txt_tienthe.Text = String.Format(culture, "{0:N0}", value);
                txt_tienthe.Select(txt_tienthe.Text.Length, 0);
            }
        }

        private void txt_tiencoc_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tiencoc.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tiencoc.Text, System.Globalization.NumberStyles.Any);
                txt_tiencoc.Text = String.Format(culture, "{0:N0}", value);
                txt_tiencoc.Select(txt_tiencoc.Text.Length, 0);
            }
        }

        private string get_tennhanvien(string manv)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select HOTEN from NHANVIEN where MANV = '" + manv + "'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        string saveExcelFile;
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

                Range row_TieuDe_ThongKeHoaDon = ws.get_Range("A1", "P1");
                row_TieuDe_ThongKeHoaDon.Merge();
                row_TieuDe_ThongKeHoaDon.Font.Size = fontSizeTieuDe;
                row_TieuDe_ThongKeHoaDon.Font.Name = fontName;
                row_TieuDe_ThongKeHoaDon.Font.Bold = true;
                row_TieuDe_ThongKeHoaDon.Cells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                row_TieuDe_ThongKeHoaDon.Value2 = "Thống kê hóa đơn";

                Range row_tungay = ws.get_Range("B2", "C2");
                row_tungay.Merge();
                row_tungay.Font.Size = fontSizeTenTruong;
                row_tungay.Font.Name = fontName;
                row_tungay.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tungay.Value2 = "Từ ngày: " + dtp_tungay.Value.ToString("dd/MM/yyyy");

                Range row_denngay = ws.get_Range("B3", "C3");
                row_denngay.Merge();
                row_denngay.Font.Size = fontSizeTenTruong;
                row_denngay.Font.Name = fontName;
                row_denngay.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_denngay.Value2 = "Đến ngày: " + dtp_denngay.Value.ToString("dd/MM/yyyy");

                Range row_nhanvien = ws.get_Range("B4", "C4");
                row_nhanvien.Merge();
                row_nhanvien.Font.Size = fontSizeTenTruong;
                row_nhanvien.Font.Name = fontName;
                row_nhanvien.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                if (cbb_nhanvien.SelectedIndex >= 1)
                {
                    row_nhanvien.Value2 = "Nhân viên: " + cbb_nhanvien.SelectedValue.ToString().Trim() + " - " + get_tennhanvien(cbb_nhanvien.SelectedValue.ToString());
                }
                else
                {
                    row_nhanvien.Value2 = "Tất cả nhân viên";
                }

                Range row_tienphong = ws.get_Range("D2", "E2");
                row_tienphong.Merge();
                row_tienphong.Font.Size = fontSizeTenTruong;
                row_tienphong.Font.Name = fontName;
                row_tienphong.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tienphong.Value2 = "Tiền phòng: " + txt_tienphong.Text;

                Range row_tiendv = ws.get_Range("D3", "E3");
                row_tiendv.Merge();
                row_tiendv.Font.Size = fontSizeTenTruong;
                row_tiendv.Font.Name = fontName;
                row_tiendv.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tiendv.Value2 = "Tiền dịch vụ: " + txt_tiendichvu.Text;


                Range row_tienthucdon = ws.get_Range("D4", "E4");
                row_tienthucdon.Merge();
                row_tienthucdon.Font.Size = fontSizeTenTruong;
                row_tienthucdon.Font.Name = fontName;
                row_tienthucdon.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tienthucdon.Value2 = "Tiền thực đơn: " + txt_tienthucdon.Text;

                Range row_tienphuthu = ws.get_Range("F2", "G2");
                row_tienphuthu.Merge();
                row_tienphuthu.Font.Size = fontSizeTenTruong;
                row_tienphuthu.Font.Name = fontName;
                row_tienphuthu.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tienphuthu.Value2 = "Tiền phụ thu: " + txt_tienphuthu.Text;

                Range row_tongtien = ws.get_Range("F3", "G3");
                row_tongtien.Merge();
                row_tongtien.Font.Size = fontSizeTenTruong;
                row_tongtien.Font.Name = fontName;
                row_tongtien.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tongtien.Value2 = "Tổng tiền: " + txt_tongtien.Text;

                Range row_tienmat = ws.get_Range("H2", "I2");
                row_tienmat.Merge();
                row_tienmat.Font.Size = fontSizeTenTruong;
                row_tienmat.Font.Name = fontName;
                row_tienmat.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tienmat.Value2 = "Tiền mặt: " + txt_tienmat.Text;

                Range row_tienthe = ws.get_Range("H3", "I3");
                row_tienthe.Merge();
                row_tienthe.Font.Size = fontSizeTenTruong;
                row_tienthe.Font.Name = fontName;
                row_tienthe.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tienthe.Value2 = "Tiền thẻ: " + txt_tienthe.Text;

                Range row_tiencoc = ws.get_Range("H4", "I4");
                row_tiencoc.Merge();
                row_tiencoc.Font.Size = fontSizeTenTruong;
                row_tiencoc.Font.Name = fontName;
                row_tiencoc.Cells.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                row_tiencoc.Value2 = "Tiền cọc: " + txt_tiencoc.Text;

                Range row_trong = ws.get_Range("F4", "G4");
                row_trong.Merge();

                Range row_STT = ws.get_Range("A6");
                row_STT.Font.Size = fontSizeTenTruong;
                row_STT.Font.Name = fontName;
                row_STT.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_STT.Value2 = "STT";

                Range row_MaHD = ws.get_Range("B6");
                row_MaHD.Font.Size = fontSizeTenTruong;
                row_MaHD.Font.Name = fontName;
                row_MaHD.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_MaHD.Value2 = "Mã hóa đơn";

                Range row_MaNV = ws.get_Range("C6");
                row_MaNV.Font.Size = fontSizeTenTruong;
                row_MaNV.Font.Name = fontName;
                row_MaNV.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_MaNV.Value2 = "Mã nhân viên";

                Range row_MaKH = ws.get_Range("D6");
                row_MaKH.Font.Size = fontSizeTenTruong;
                row_MaKH.Font.Name = fontName;
                row_MaKH.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_MaKH.Value2 = "Mã khách hàng";

                Range row_TenKH = ws.get_Range("E6");
                row_TenKH.Font.Size = fontSizeTenTruong;
                row_TenKH.Font.Name = fontName;
                row_TenKH.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TenKH.Value2 = "Tên khách hàng";

                Range row_NgayVao = ws.get_Range("F6");
                row_NgayVao.Font.Size = fontSizeTenTruong;
                row_NgayVao.Font.Name = fontName;
                row_NgayVao.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_NgayVao.Value2 = "Ngày vào";

                Range row_NgayRa = ws.get_Range("G6");
                row_NgayRa.Font.Size = fontSizeTenTruong;
                row_NgayRa.Font.Name = fontName;
                row_NgayRa.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_NgayRa.Value2 = "Ngày ra";

                Range row_TienPhong = ws.get_Range("H6");
                row_TienPhong.Font.Size = fontSizeTenTruong;
                row_TienPhong.Font.Name = fontName;
                row_TienPhong.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienPhong.Value2 = "Tiền phòng";

                Range row_TienDichVu = ws.get_Range("I6");
                row_TienDichVu.Font.Size = fontSizeTenTruong;
                row_TienDichVu.Font.Name = fontName;
                row_TienDichVu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienDichVu.Value2 = "Tiền dịch vụ";

                Range row_TienThucDon = ws.get_Range("J6");
                row_TienThucDon.Font.Size = fontSizeTenTruong;
                row_TienThucDon.Font.Name = fontName;
                row_TienThucDon.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienThucDon.Value2 = "Tiền thực đơn";

                Range row_TienPhuThu = ws.get_Range("K6");
                row_TienPhuThu.Font.Size = fontSizeTenTruong;
                row_TienPhuThu.Font.Name = fontName;
                row_TienPhuThu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienPhuThu.Value2 = "Tiền phụ thu";

                Range row_GhiChu = ws.get_Range("L6");
                row_GhiChu.Font.Size = fontSizeTenTruong;
                row_GhiChu.Font.Name = fontName;
                row_GhiChu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_GhiChu.Value2 = "Ghi chú phụ thu";

                Range row_TongTien = ws.get_Range("M6");
                row_TongTien.Font.Size = fontSizeTenTruong;
                row_TongTien.Font.Name = fontName;
                row_TongTien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TongTien.Value2 = "Tổng tiền";

                Range row_TienMat = ws.get_Range("N6");
                row_TienMat.Font.Size = fontSizeTenTruong;
                row_TienMat.Font.Name = fontName;
                row_TienMat.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienMat.Value2 = "Tiền mặt";

                Range row_TienThe = ws.get_Range("O6");
                row_TienThe.Font.Size = fontSizeTenTruong;
                row_TienThe.Font.Name = fontName;
                row_TienThe.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienThe.Value2 = "Tiền thẻ";

                Range row_TienCoc = ws.get_Range("P6");
                row_TienCoc.Font.Size = fontSizeTenTruong;
                row_TienCoc.Font.Name = fontName;
                row_TienCoc.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row_TienCoc.Value2 = "Tiền đặt cọc";


                //Tô nền vàng các cột tiêu đề:
                Range row_CotTieuDe = ws.get_Range("A6", "P6");
                //nền vàng
                row_CotTieuDe.Interior.Color = ColorTranslator.ToOle(System.Drawing.Color.Yellow);
                //in đậm
                row_CotTieuDe.Font.Bold = true;
                //chữ đen
                row_CotTieuDe.Font.Color = ColorTranslator.ToOle(System.Drawing.Color.Black);

                int stt = 0;
                row = 6;//dữ liệu xuất bắt đầu từ dòng số 3 trong file Excel (khai báo 2 để vào vòng lặp nó ++ thành 4)

                foreach (DataRow datarow in ds.Tables["BAOCAO"].Rows)
                {
                    stt++;
                    row++;
                    dynamic[] arr = { stt, datarow["MAHD"], datarow["MANV_LAPPHIEU"], datarow["MAKH"], datarow["HOTEN"], datarow["NGAYNHAN"], datarow["NGAYLAP"], datarow["TIEN_PH"], datarow["TIEN_DV"], datarow["TIEN_MENU"], datarow["TIEN_PHUTHU"], datarow["GHICHU_PHUTHU"], datarow["TONGTIEN"], datarow["TIENMAT"], datarow["TIENTHE"], datarow["TIENCOC"] };
                    Range rowData = ws.get_Range("A" + row, "P" + row);//Lấy dòng thứ row ra để đổ dữ liệu
                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    rowData.Columns.AutoFit();
                    for (int i = 6; i <= 7; i++)
                    {
                        rowData.Cells[1, i].NumberFormat = "dd/MM/yyyy";
                        rowData.Cells[1, i].NumberFormat = "dd/MM/yyyy";
                    }
                    for (int i = 8; i < 17; i++)
                    {
                        if (i != 12)
                        {
                            rowData.Cells[1, i].NumberFormat = "###,##";
                        }
                    }

                    rowData.Value2 = arr;
                }
                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A6", "P" + row));

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

        string mahd;

        private void dgv_thongkehoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dgv_thongkehoadon.Rows)
            {
                if (row.Selected)
                    mahd = row.Cells[0].Value.ToString();
            }
            btn_chitiet.Enabled = true;
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            chitiet_hoadon chitiet = new chitiet_hoadon(conn);
            chitiet.get_mahd(mahd);
            chitiet.StartPosition = FormStartPosition.CenterScreen;
            chitiet.Show();
        }
    }
}

