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
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking;

namespace Da.controller
{
    public partial class frm_danhsachphong : UserControl
    {
        public frm_danhsachphong()
        {
            InitializeComponent();
        }

        DataSet ds;
        SqlDataAdapter da;
        connect conn = new connect();

        public void Load_control_all()
        {
            panelphong.Controls.Clear();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHONG", conn.cnn);
            da.Fill(ds, "PHONG");

            Load_control();
        }

        private void Load_control()
        {
            int x = 0;
            int y = 0;
            int dem = 0;

            foreach (DataRow row in ds.Tables["PHONG"].Rows)
            {
                if (int.Parse(row["TINHTRANG"].ToString()) == 0)
                {
                    frm_phongtrong phongtrong = new frm_phongtrong(row["MAPH"].ToString());
                    phongtrong.Location = new Point(x, y);
                    panelphong.Controls.Add(phongtrong);
                    x += 280;
                    if (dem >= 5)
                    {
                        y += 250;
                        x = 0;
                        dem = 0;

                    }
                    else
                    {
                        dem++;
                    }
                }
                if (int.Parse(row["TINHTRANG"].ToString()) == 1)
                {
                    frm_phongsudung sudung = new frm_phongsudung(row["MAPH"].ToString());
                    sudung.Location = new Point(x, y);
                    panelphong.Controls.Add(sudung);
                    x += 280;
                    if (dem >= 5)
                    {
                        y += 250;
                        x = 0;
                        dem = 0;

                    }
                    else
                    {
                        dem++;
                    }
                }
                if (int.Parse(row["TINHTRANG"].ToString()) == 2)
                {
                    frm_phongdattruoc dattruoc = new frm_phongdattruoc(row["MAPH"].ToString());
                    dattruoc.Location = new Point(x, y);
                    panelphong.Controls.Add(dattruoc);
                    x += 280;
                    if (dem >= 5)
                    {
                        y += 250;
                        x = 0;
                        dem = 0;

                    }
                    else
                    {
                        dem++;
                    }
                }
                if (int.Parse(row["TINHTRANG"].ToString()) == 3)
                {
                    frm_phongdondep dondep = new frm_phongdondep(row["MAPH"].ToString(), this);
                    dondep.Location = new Point(x, y);
                    panelphong.Controls.Add(dondep);
                    x += 280;
                    if (dem >= 5)
                    {
                        y += 250;
                        x = 0;
                        dem = 0;

                    }
                    else
                    {
                        dem++;
                    }
                }
                if (int.Parse(row["TINHTRANG"].ToString()) == 4)
                {
                    frm_phongsuachua suachua = new frm_phongsuachua(row["MAPH"].ToString(),this);
                    suachua.Location = new Point(x, y);
                    panelphong.Controls.Add(suachua);
                    x += 280;
                    if (dem >= 5)
                    {
                        y += 250;
                        x = 0;
                        dem = 0;

                    }
                    else
                    {
                        dem++;
                    }
                }
            }
        }

        private void Load_control_theotang(int tang)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHONG where VTPHONG = " + tang, conn.cnn);
            da.Fill(ds, "PHONG");

            Load_control();
        }

        private void Load_control_theotinhtrang(int tinhtrang)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHONG where TINHTRANG = " + tinhtrang.ToString(), conn.cnn);
            da.Fill(ds, "PHONG");

            Load_control();
        }

        private void Load_control_theoloai(string loai)
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHONG where MALOAI = '" + loai + "'", conn.cnn);
            da.Fill(ds, "PHONG");

            Load_control();
        }

        private int get_tinhtrang()
        {
            if (rdb_trong.Checked)
                return 0;
            else if (rdb_dangsudung.Checked)
                return 1;
            else if (rdb_duocdat.Checked)
                return 2;
            else if (rdb_dangdondep.Checked)
                return 3;
            else
                return 4;
        }

        private void Load_control_3dieukien()
        {
            int tinhtrang = get_tinhtrang();
            ds = new DataSet();
            da = new SqlDataAdapter("select * from PHONG where VTPHONG = " + (cbb_tang.SelectedIndex + 1)+" and TINHTRANG = "+tinhtrang+" and MALOAI = '"+cbb_loai.SelectedValue.ToString()+"'", conn.cnn);
            da.Fill(ds, "PHONG");

            Load_control();
        }

        private void Load_control_2dieukien()
        {
            int tinhtrang = get_tinhtrang();
            if (!chb_tinhtrang.Checked)
            {
                ds = new DataSet();
                da = new SqlDataAdapter("select * from PHONG where VTPHONG = " + (cbb_tang.SelectedIndex + 1) + " and MALOAI = '" + cbb_loai.SelectedValue.ToString() + "'", conn.cnn);
                da.Fill(ds, "PHONG");

                Load_control();
            }
            else
            {
                if (!chb_tang.Checked)
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter("select * from PHONG where TINHTRANG = " + tinhtrang + " and MALOAI = '" + cbb_loai.SelectedValue.ToString() + "'", conn.cnn);
                    da.Fill(ds, "PHONG");

                    Load_control();
                }
                else if(!chb_loai.Checked)
                {
                    ds = new DataSet();
                    da = new SqlDataAdapter("select * from PHONG where VTPHONG = " + (cbb_tang.SelectedIndex + 1) + " and TINHTRANG = " + tinhtrang, conn.cnn);
                    da.Fill(ds, "PHONG");

                    Load_control();
                }
            }
        }

        private void load_cbb_loai()
        {
            ds = new DataSet();
            da = new SqlDataAdapter("select * from LOAIPHONG", conn.cnn);
            da.Fill(ds, "LOAIPHONG");

            cbb_loai.DisplayMember = "TENLOAI";
            cbb_loai.ValueMember = "MALOAI";
            cbb_loai.DataSource = ds.Tables["LOAIPHONG"];
        }

        private void frm_danhsachphong_Load(object sender, EventArgs e)
        {
            cbb_tang.SelectedIndex = 0;
            load_cbb_loai();
            Load_control_all();
        }

        private int kiemtra_tinhtrang()
        {
            int count = 0;
            if (chb_tinhtrang.Checked)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is GroupBox)
                    {
                        foreach (Control panel in control.Controls)
                        {
                            if (panel is Panel)
                            {
                                foreach (RadioButton rdb in panel.Controls)
                                {
                                    if (rdb.Checked)
                                        count++;
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            int kt = kiemtra_tinhtrang();

            if (!chb_tang.Checked && !chb_loai.Checked && !chb_tinhtrang.Checked)
            {
                panelphong.Controls.Clear();
                Load_control_all();
            }
            else
            {
                if (chb_loai.Checked && chb_tang.Checked && chb_tinhtrang.Checked)
                {
                    panelphong.Controls.Clear();
                    Load_control_3dieukien();
                }
                else if (chb_loai.Checked && chb_tang.Checked)
                {
                    panelphong.Controls.Clear();
                    Load_control_2dieukien();
                }
                else if (!chb_tinhtrang.Checked)
                {
                    if (chb_tang.Checked)
                    {
                        panelphong.Controls.Clear();
                        Load_control_theotang(cbb_tang.SelectedIndex + 1);
                    }
                    else
                    {
                        panelphong.Controls.Clear();
                        Load_control_theoloai(cbb_loai.SelectedValue.ToString());
                    }
                }

                else
                {
                    if (chb_tang.Checked || chb_loai.Checked)
                    {
                        panelphong.Controls.Clear();
                        Load_control_2dieukien();
                    }
                    else
                    {
                        if (kt != 0)
                        {
                            int tinhtrang = get_tinhtrang();
                            panelphong.Controls.Clear();
                            Load_control_theotinhtrang(tinhtrang);
                        }
                    }
                }
            }
        }

        private void chb_tang_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_tang.Checked)
                cbb_tang.Enabled = true;
            else
            {
                cbb_tang.SelectedIndex = 0;
                cbb_tang.Enabled = false;
            }
        }

        private void chb_loai_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_loai.Checked)
                cbb_loai.Enabled = true;
            else
            {
                cbb_loai.SelectedIndex = 0;
                cbb_loai.Enabled = false;
            }
        }

        private void chb_tinhtrang_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_tinhtrang.Checked)
                panel_tinhtrang.Enabled = true;
            else
            {
                rdb_dangdondep.Checked = rdb_dangsuachua.Checked = rdb_dangsudung.Checked = rdb_duocdat.Checked = rdb_trong.Checked = false;
                panel_tinhtrang.Enabled = false;
            }
        }
    }
}
