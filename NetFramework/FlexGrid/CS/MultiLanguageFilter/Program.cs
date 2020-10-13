using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Globalization;

namespace MultiLanguageFilter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // get current thread
            var ct = System.Threading.Thread.CurrentThread;

            // each thread has two cultures:
            //
            // CurrentCulture
            //   defines the formats used to show numbers, dates, etc.
            //   set using the ControlPanel Formats tab in Windows 7
            //
            // CurrentUICulture
            //   manages the language used to show strings in menus,
            //   dialog boxes, etc.
            //   this is the language of the operating system; Vista and Win7
            //   allow you to change this by installing language packs.
            //
            // Either culture can be changed in code by assigning a new
            // CultureInfo value to the corresponding thread property.
            //
            // For more details in the differences between CurrentCulture and
            // CurrentUICulture, please see:
            //
            //   http://blogs.msdn.com/b/michkap/archive/2007/01/11/1449754.aspx
            //
            //
            // EXAMPLE1: hardwired cultures:
            // ---------------------------------------------------------------------
            // This code sets both cultures to Greek. The current application will 
            // show numbers and dates using Greek settings (CurrentCulture), and 
            // will show string resources in Greek if they are available 
            // (CurrentUICulture):
            //  ct.CurrentCulture = new CultureInfo("el");
            //  ct.CurrentUICulture = new CultureInfo("el");

            // EXAMPLE2: automatically match cultures:
            // ---------------------------------------------------------------------
            // This code sets the CurrentUICulture to the same value as the 
            // CurrentCulture.
            // This causes the current formats selected in the Control Panel to be
            // applied to numbers and dates (as usual) and also causes string 
            // resources to be displayed in the corresponding language.
            // 
            ct.CurrentUICulture = ct.CurrentCulture;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
