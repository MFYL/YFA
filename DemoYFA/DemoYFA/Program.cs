using PLC;
using System;
using System.Windows.Forms;

namespace LocalApp
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

            YHMI.HMI.Init();
            //YHMI.HMI.Init("13E47JMYKM");
            // 设置PLC登录密码
            YPLC.SetLoginPassword("123456789");

            Application.Run(new MainWnd());
        }
    }
}
