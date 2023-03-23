using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JumpItemDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                string fileName = Path.GetFileName(args[0]);
                MessageBox.Show(string.Format("\"{0}\" passed as an argument to the application.", fileName),
                    "C1JumpList Destinations",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Application.Run(new Form1());
        }
    }
}
