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
using DevExpress.DataAccess.UI.Native.Sql.DataConnectionControls;
using DevExpress.XtraGrid.Views.BandedGrid.Drawing;

namespace Da.controller
{
    public partial class frm_Nhaphang : UserControl
    {
        public connect conn;

        public frm_Nhaphang(connect _conn)
        {
            InitializeComponent();
            conn = _conn;
        }

        private void btn_nhaphang_Click(object sender, EventArgs e)
        {
            them_nhaphang nhaphang = new them_nhaphang(conn);
            nhaphang.StartPosition = FormStartPosition.CenterScreen;
            nhaphang.Show();
        }
    }
}
