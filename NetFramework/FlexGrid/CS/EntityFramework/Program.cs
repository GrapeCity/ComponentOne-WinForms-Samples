using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EntityFramework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Specify where Entity Framework should look for the Northwind database.
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ComponentOne Samples\Common";
            string dbFile = Path.Combine(folder, "Northwnd.mdf");
            AppDomain.CurrentDomain.SetData("DataDirectory", folder);
            if (!File.Exists(dbFile))
                throw new Exception("Sample database Northwnd.mdf must be created in the Data folder. Run the CreateSampleDB utility to create the Northwind database");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
