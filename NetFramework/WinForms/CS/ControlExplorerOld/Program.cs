using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.Configuration;
using System.Runtime.InteropServices;

namespace ControlExplorer
{
    static class Program
    {
        internal static int WM_UpdateDemoStatus;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            WM_UpdateDemoStatus = RegisterWindowMessage("UpdateDemoStatus");
            ChangeWindowMessageFilter(WM_UpdateDemoStatus, 1 /* MSGFLT_ADD */);
            if (args.Length > 0)
            {
                int action;
                if (!int.TryParse(args[0], out action))
                {                  
                    return;
                }
                IntPtr hWnd = FindWindow(IntPtr.Zero, "Jump List Demo");
                if (hWnd != IntPtr.Zero)
                {
                    SetForegroundWindow(hWnd);
                    PostMessage(hWnd, WM_UpdateDemoStatus, new IntPtr(action), IntPtr.Zero);
                    return;
                }
                Win7Pack.JumpTaskDemo.Action = (Win7Pack.JumpTaskAction)action;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern bool ChangeWindowMessageFilter(int message, int dwFlag);

        [DllImport("user32.dll", EntryPoint = "FindWindowW", CharSet = CharSet.Unicode)]
        private static extern IntPtr FindWindow(IntPtr lpClassName /* Dummy */,
            [MarshalAs(UnmanagedType.LPWStr)] string lpWindowName);

        [DllImport("user32.dll", EntryPoint = "PostMessageW", CharSet = CharSet.Unicode)]
        internal static extern IntPtr PostMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", EntryPoint = "RegisterWindowMessageW", CharSet = CharSet.Unicode)]
        private static extern int RegisterWindowMessage([MarshalAs(UnmanagedType.LPWStr)] string lpString);

        [DllImport("user32.dll", ExactSpelling = true)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
