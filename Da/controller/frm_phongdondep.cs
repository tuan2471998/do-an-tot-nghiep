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
using DevExpress.Charts.Native;
using DevExpress.Office.Drawing;

namespace Da.controller
{
    public partial class frm_phongdondep : UserControl
    {
        public connect conn;
        private frm_danhsachphong frm_danhsachphong;

        public frm_phongdondep(frm_danhsachphong _danhsachphong, connect _conn)
        {
            InitializeComponent();
            frm_danhsachphong = _danhsachphong;
            conn = _conn;
        }

        string sophong;
        public void get_sophong(string _sophong)
        {
            sophong = _sophong;
        }

        private void hoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "update PHONG set TINHTRANG = 0, TIME_DONDEP_KT = null where MAPH = '" + lb_sophong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = cmd.ExecuteNonQuery();
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                frm_danhsachphong.Load_control_all();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        DateTime batdau;
        DateTime ketthuc;

        private void get_time_ketthuc()
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "select TIME_DONDEP_KT from PHONG where MAPH = '" + lb_sophong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                ketthuc = (DateTime)cmd.ExecuteScalar();

                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void lb_sophong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                get_time_ketthuc();
                batdau = DateTime.Now;
                conlai = ketthuc - batdau;
                gio = conlai.Hours;
                phut = conlai.Minutes;
                giay = conlai.Seconds;
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        TimeSpan conlai;
        int gio;
        int phut;
        int giay;

        private void frm_phongdondep_Load(object sender, EventArgs e)
        {
            lb_sophong.Text = sophong;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gio <= 0 && phut <= 0 && giay <= 0)
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                timer1.Stop();
                string sql = "update PHONG set TINHTRANG = 0, TIME_DONDEP_KT = null where MAPH = '" + lb_sophong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = cmd.ExecuteNonQuery();
                frm_danhsachphong.Load_control_all();
                conn.cnn.Close();
            }
            else
            {
                giay--;
                if (giay < 0 && phut > 0)
                {
                    giay = 59;
                    phut--;
                }
                if (phut < 0 && gio > 0)
                {
                    phut = 59;
                    gio--;
                }
                if (phut < 10)
                    lb_phut.Text = "0" + phut.ToString();
                else
                    lb_phut.Text = phut.ToString();
                if (giay < 10)
                    lb_giay.Text = "0" + giay.ToString();
                else
                    lb_giay.Text = giay.ToString();
                lb_gio.Text = "0" + gio.ToString();
            }
        }
    }
}
