using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 仓库信息管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 欢迎界面());
            欢迎界面 frm=new 欢迎界面();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                主界面 frm2 = new 主界面();
                frm2.ShowDialog();
            }
        }
    }
}
