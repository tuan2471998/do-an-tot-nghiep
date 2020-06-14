using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da
{
    public partial class ThanhToanHoaDon : Form
    {
        public ThanhToanHoaDon()
        {
            InitializeComponent();
        }

        public void get_tongtien(double tongtien)
        {
            txt_tongtien.Text = tongtien.ToString();
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

        private void ThanhToanHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void txt_khachdua_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_khachdua.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_khachdua.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_khachdua.Text = String.Format(culture, "{0:N0}", value);
                txt_khachdua.Select(txt_khachdua.Text.Length, 0);
            }
        }

        private void txt_tralai_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_tralai.Text) == false)
            {
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                double value = double.Parse(txt_tralai.Text, System.Globalization.NumberStyles.AllowThousands);
                txt_tralai.Text = String.Format(culture, "{0:N0}", value);
                txt_tralai.Select(txt_tralai.Text.Length, 0);
            }
        }

        private void txt_khachdua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        double tiendu = 0;

        private void txt_khachdua_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tiendu = (double.Parse(txt_khachdua.Text) - double.Parse(txt_tongtien.Text));
                if (tiendu < 0)
                {
                    MessageBox.Show("Tiền dư không hợp lệ");
                }
                else
                    txt_tralai.Text = tiendu.ToString();
            }
        }
    }
}
