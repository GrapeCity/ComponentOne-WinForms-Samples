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

namespace C1dView
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

            // show C1dView and all other loaded C1 assemblies:
            Func<AssemblyName, string> getName = (asmName) => string.Format("{0}, Version {1}", asmName.Name, asmName.Version);
            //
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            var entryName = entryAssembly.GetName();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} Application ({1} bit mode):", entryName.Name, IntPtr.Size * 8);
            sb.AppendLine();
            sb.AppendLine(getName(entryName));
            // get a sorted list of all C1 assemblies:
            var asms = AppDomain.CurrentDomain.GetAssemblies().ToList()
                .Where((asm_) => (asm_ != entryAssembly))
                .Select((asm_) => asm_.GetName())
                .Where((asmName_) => asmName_.Name.ToLower().StartsWith("c1"));
            var asmNames = asms.ToList();
            asmNames.Sort((asm1_, asm2_) => StringComparer.OrdinalIgnoreCase.Compare(asm1_.Name, asm2_.Name));
            asmNames.ForEach((asmName) => sb.AppendLine(getName(asmName)));
            //
            _lblInstalledComponents.Text = sb.ToString();
            // set up caption:
            this.Text = string.Format("About {0}", entryName.Name);
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
