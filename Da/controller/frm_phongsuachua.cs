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

namespace Da.controller
{
    public partial class frm_phongsuachua : UserControl
    {
        private frm_danhsachphong _frm_danhsachphong;
        public connect conn;
        string sophong;
        public frm_phongsuachua(frm_danhsachphong danhsachphong, connect _conn)
        {
            InitializeComponent();
            _frm_danhsachphong = danhsachphong;
            conn = _conn;
        }

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
                string sql = "update PHONG set TINHTRANG = 0 where MAPH = '" + lb_sophong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                int kq = cmd.ExecuteNonQuery();
                if (kq == 1)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                _frm_danhsachphong.Load_control_all();
                conn.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void frm_phongsuachua_Load(object sender, EventArgs e)
        {
            lb_sophong.Text = sophong;
        }
    }
}
