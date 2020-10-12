using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C1dView
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
            // method to make first form:
            Func<C1dViewForm> MakeFirstForm = () =>
            {
                var viewer = new C1dViewForm();
                C1dViewSettings.Load(viewer);
                viewer.Show();
                return viewer;
            };
            // show all needed forms:
            if (args != null && args.Length > 0)
            {
                C1dViewForm viewer = null;
                for (int i = 0; i < args.Length; ++i)
                {
                    if (i == 0)
                    {
                        viewer = MakeFirstForm();
                        viewer.FileOpen(args[i]);
                    }
                    else
                    {
                        // open next file off last viewer to "cascade" windows:
                        viewer = viewer.FileNew(args[i]) ?? viewer;
                    }
                }
            }
            else
            {
                MakeFirstForm();
            }
            // no "main" form - the last one alive will be the main:
            Application.Run();
        }
    }
}
