using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FlexReportViewer
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

            if (args.Length == 1)
            {
                string filePath = args[0];
                if (File.Exists(filePath))
                    PreviewForm.SetStartupFilePath(filePath);
                else
                {
                    MessageBox.Show(string.Format("\"{0}\" does not exist.", filePath),
                        PreviewForm.FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            Application.Run(new PreviewForm());
        }
    }
}
