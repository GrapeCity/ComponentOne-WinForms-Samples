//----------------------------------------------------------------------------
// Program.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FlexReportDesignerApp
{
    static class Program
    {
        // exit codes:
        public enum ExitCodes
        {
            FatalError = 108,
            UserAbort = 109,
        }

        public static void Exit(ExitCodes exitCode)
        {
            Environment.Exit((int)exitCode);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm.ShowSpash();
            Application.Run(new MainForm());
        }
    }
}
