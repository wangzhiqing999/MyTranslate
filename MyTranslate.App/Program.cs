using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;  
using System.Runtime.InteropServices;
using System.Reflection;  


namespace MyTranslate.App
{
    static class Program
    {


        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(int hWnd, int cmdShow);

        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32")]
        static extern int SetForegroundWindow(int hwnd);

        private const int SW_NORMAL = 1; //正常弹出窗体    


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Process currentProcess = Process.GetCurrentProcess();

            //判断程序是否已经启动  
            Mutex mutex = new Mutex(false, "MyTranslate");
            bool Running = !mutex.WaitOne(0, false);


            if (!Running)
            {
                Application.Run(new FormMain());
            }
            else
            {

                string title = "翻译小工具 - V " + Assembly.GetExecutingAssembly().GetName().Version.ToString();


                int WINDOW_HANDLER = FindWindow(null, title);   // 程序标题或类名二选1  
                if (WINDOW_HANDLER > 0)
                {
                    //MessageBox.Show(WINDOW_HANDLER.ToString());  
                    ShowWindowAsync(WINDOW_HANDLER, SW_NORMAL);
                    SetForegroundWindow(WINDOW_HANDLER);
                }
                Environment.Exit(0);
            }  


            
        }
    }
}
