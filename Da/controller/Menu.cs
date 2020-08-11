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

namespace Da
{
    public partial class Menu : Form
    {

        private frm_tt tt;
        public connect conn;
        private string mahd;

        public Menu(frm_tt _frm_tt, connect _conn)
        {
            InitializeComponent();
            tt = _frm_tt;
            conn = _conn;
        }

        public void get_mahd(string _mahd)
        {
            mahd = _mahd;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataSet ds;
        SqlDataAdapter da;

        private decimal get_dongia(string tenmenu)
        {
            if (conn.cnn.State == ConnectionState.Closed)
            {
                conn.cnn.Open();
            }
            string sql = "select DONGIA from MENU where TENMENU like N'%" + tenmenu + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (decimal)cmd.ExecuteScalar();
        }

        private string get_mamenu(string tenmenu)
        {
            if (conn.cnn.State == ConnectionState.Closed)
                conn.cnn.Open();

            string sql = "select IDMENU from MENU where TENMENU like N'%" + tenmenu + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn.cnn);
            return (string)cmd.ExecuteScalar();
        }

        private void update_soluong_hang()
        {
            try
            {
                foreach (Control chb in this.Controls)
                {
                    if (chb is CheckBox && ((CheckBox)chb).Checked)
                    {
                        foreach (Control num in this.Controls)
                        {
                            if (num is NumericUpDown && num.Name == "numeric_" + chb.Name && num.Enabled == true)
                            {
                                if (conn.cnn.State == ConnectionState.Closed)
                                    conn.cnn.Open();

                                string sql = "update HANG set SOLUONGHANG = SOLUONGHANG - " + ((NumericUpDown)num).Value + " where TENHANG = '" + get_mamenu(chb.Text) + "'";
                                SqlCommand cmd = new SqlCommand(sql, conn.cnn);
                                int kq = cmd.ExecuteNonQuery();

                                conn.cnn.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.cnn.State == ConnectionState.Closed)
                {
                    conn.cnn.Open();
                }
                string sql = "select * from MENU";
                ds = new DataSet();
                da = new SqlDataAdapter(sql, conn.cnn);
                da.Fill(ds, "MENU");

                DataTable menu = new DataTable();
                menu.Columns.Add("tentd");
                menu.Columns.Add("soluong");
                menu.Columns.Add("dongia");
                menu.Columns.Add("thanhtien");

                DataRow newrow;

                foreach (Control control in this.Controls)
                {
                    if (control is CheckBox && ((CheckBox)control).Checked == true)
                    {
                        foreach (Control num in this.Controls)
                        {
                            if (num is NumericUpDown && num.Name == "numeric_" + control.Name && num.Enabled == true)
                            {
                                newrow = menu.NewRow();
                                newrow["tentd"] = control.Text;
                                newrow["soluong"] = ((NumericUpDown)num).Value;
                                newrow["dongia"] = get_dongia(control.Text).ToString("###,##");
                                newrow["thanhtien"] = (decimal.Parse(((NumericUpDown)num).Value.ToString()) * decimal.Parse(get_dongia(control.Text).ToString())).ToString("###,##");

                                menu.Rows.Add(newrow);
                            }
                        }
                    }
                }

                update_soluong_hang();

                tt.get_thongtin_menu(menu);
                tt.get_tienmenu();
                tt.enable_menu();

                if (conn.cnn.State == ConnectionState.Open)
                {
                    conn.cnn.Close();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.cnn.Close();
            }
        }

        private void nuocsuoi_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is CheckBox )
                {
                    if (((CheckBox)control).Checked)
                    {
                        foreach (Control num in this.Controls)
                        {
                            if (num is NumericUpDown && num.Name == "numeric_" + control.Name)
                            {
                                num.Enabled = true;
                            }
                        }
                    }
                    else if (!((CheckBox)control).Checked)
                    {
                        foreach (Control num in this.Controls)
                        {
                            if (num is NumericUpDown && num.Name == "numeric_" + control.Name)
                            {
                                num.Enabled = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
