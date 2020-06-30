﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace Da
{
    static class Program
    {

        public static frm_dangnhap frm_dangnhap;
        public static frm_khachsan frm_khachsan;
        public static frm_tt frm_tt;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frm_dangnhap= new frm_dangnhap());
        }
    }
}
