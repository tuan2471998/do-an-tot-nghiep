using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Da.controller
{
    public partial class frm_phongtrong : UserControl
    {
        public frm_phongtrong()
        {
            InitializeComponent();
        }

        public frm_phongtrong(string sophong)
        {
            InitializeComponent();
            lb_sophong.Text = sophong;
        }
    }
}
