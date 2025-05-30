﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Configuration;
using System.Globalization;

namespace TraditionalToLiveLinq
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ComponentOne Samples\Common";
            string dbFile = Path.Combine(folder, "Northwnd.mdf");
            AppDomain.CurrentDomain.SetData("DataDirectory", folder);
            if (!File.Exists(dbFile))
            {
                throw new Exception("Sample database Northwnd.mdf must be created in the Common folder. Run the CreateSampleDB utility to create the Northwind database");
            }

            // make sure both version 11 and version 12 or higher of SQLServer LocalDb are supported
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions");
            if (key == null)
            {
                throw new Exception("Microsoft SQL Server LocalDB is not installed.");
            }
            var version = "v11.0";
            foreach (var subKeyName in key.GetSubKeyNames())
            {
                double localDBVersion = 0;
                if (double.TryParse(subKeyName, NumberStyles.Number, CultureInfo.InvariantCulture, out localDBVersion) && localDBVersion >= 12)
                {
                    version = "MSSQLLocalDB";
                    break;
                }
            }
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connStr = config.ConnectionStrings.ConnectionStrings["TraditionalToLiveLinq.Properties.Settings.NORTHWNDConnectionString"];
            connStr.ConnectionString = connStr.ConnectionString.Replace("v11.0", version);
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
