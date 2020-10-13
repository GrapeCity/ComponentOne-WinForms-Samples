using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

namespace C1ReportsScheduler
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

			// show C1Report version
			Assembly a = Assembly.GetAssembly(typeof(C1.C1Report.C1Report));
            Version v = a.GetName().Version;
            int year = v.Build / 10;
            _lblCopyright.Text = string.Format(_lblCopyright.Text, year);
        }

        public AboutForm(MainForm mainForm) : this()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("C1ReportsScheduler Frontend Application:");
            sb.AppendLine(Util.GetAssemblyAboutName(entryAssembly));
            foreach (AssemblyName name in entryAssembly.GetReferencedAssemblies())
                if (name.Name.ToLower().StartsWith("c1"))
                    sb.AppendLine(Util.GetAssemblyAboutName(name));

            if (mainForm.ClientMode)
            {
                sb.AppendLine();
                sb.AppendFormat("Running in Client Mode, connected to {0}:", C1ReportsSchedulerService.Constants.Name);
                sb.AppendLine();
                sb.AppendLine(((TaskListHolderClient)mainForm.TasksHolder).GetServiceAboutString());
            }
            else
            {
                sb.AppendLine();
                sb.AppendLine("Running in Standalone Mode.");
            }

            lblInstalledComponents.Text = sb.ToString();
        }

        // use online resources
        void resource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string C1_ROOT = "http://www.componentone.com/";
            var linkLabel = sender as LinkLabel;
            var url = (string)linkLabel.Tag;
            if (!url.StartsWith("http:", StringComparison.OrdinalIgnoreCase))
                url = C1_ROOT + url;
            Process.Start(url);
        }
    }
}
