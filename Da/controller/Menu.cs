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
        public Menu()
        {
            InitializeComponent();
        }

        private frm_tt tt;

        public Menu(frm_tt _frm_tt)
        {
            InitializeComponent();
            tt = _frm_tt;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DataSet ds;
        SqlDataAdapter da;
        connect conn = new connect();

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

        private void btn_luu_Click(object sender, EventArgs e)
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
                            newrow["dongia"] = get_dongia(control.Text);
                            newrow["thanhtien"] = decimal.Parse(((NumericUpDown)num).Value.ToString()) * decimal.Parse(get_dongia(control.Text).ToString());

                            menu.Rows.Add(newrow);
                        }
                    }
                }
            }

            tt.get_thongtin_menu(menu);
            tt.get_tienmenu();
            tt.format_dgv_menu();
            conn.cnn.Close();
            this.Close();
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
