using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace C1ReportsScheduler
{
    public partial class HelpForm : Form
    {
        private const string c_nameTag = "___C1ReportsScheduler___name___";
        private const string c_versionTag = "___C1ReportsScheduler___version___";

        public HelpForm()
        {
            InitializeComponent();

            string helpHtml = global::C1ReportsScheduler.Properties.Resources.HelpPage1;
            Assembly entryAssembly = Assembly.GetEntryAssembly();

            string name = entryAssembly.GetName().Name;
            string ver = string.Format("Version {0}, built on {1}", entryAssembly.GetName().Version,
                Util.RetrieveLinkerTimestamp(entryAssembly).ToShortDateString());

            helpHtml = helpHtml.Replace(c_nameTag, name);
            helpHtml = helpHtml.Replace(c_versionTag, ver);

            this.WebBrowser.DocumentText = helpHtml;
        }
    }
}
