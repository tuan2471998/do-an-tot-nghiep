using System;
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
    ////ktra form chính tồn tại chưa
    //private frm_khachsan kiemtraform(Type ftype)
    //{
    //    foreach (frm_khachsan f in this.MdiChildren)
    //    {
    //        if (f.GetType() == ftype)
    //        {
    //            return f;
    //        }
    //    }
    //    return null;
    //}
}
