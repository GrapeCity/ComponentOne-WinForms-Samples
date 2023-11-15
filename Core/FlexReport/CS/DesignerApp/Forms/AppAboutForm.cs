//----------------------------------------------------------------------------
// AppAboutForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;


namespace C1.Util.Licensing
{
	internal partial class AppAboutForm : System.Windows.Forms.Form
	{
        const string C1_ROOT = "https://developer.mescius.com/componentone";

        const string c_aboutFmt = "About {0}";
        const string c_asmNameVerFmt = "{0}, Version {1}";
        const string c_appNameModeFmt = "{0} Application ({1} bit mode):";

        internal AppAboutForm()
		{
			// regular initialization
			InitializeComponent();

            Text = c_aboutFmt;

            _linkHome.Text = C1_ROOT.Replace("http://", "");

            // show main exe and all other loaded C1 assemblies:
            Func<AssemblyName, string> getName = (asmName) => string.Format(c_asmNameVerFmt, asmName.Name, asmName.Version);

            // get a sorted list of all C1 assemblies:
            var asms = AppDomain.CurrentDomain.GetAssemblies();
            Assembly flexReportDesignerAssembly = asms.SingleOrDefault(
                assembly => assembly.GetName().Name.ToLower().StartsWith("c1.win.flexreportdesigner")
                );
            if (flexReportDesignerAssembly != null)
            {
                AssemblyName flexReportDesignerAssemblyName = flexReportDesignerAssembly.GetName();
                int year = flexReportDesignerAssemblyName.Version.Build / 10;
                _copyright.Text = string.Format(_copyright.Text, year);
            }

            //
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            var entryName = entryAssembly.GetName();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(c_appNameModeFmt, entryName.Name, IntPtr.Size * 8);
            sb.AppendLine();
            sb.AppendLine(getName(entryName));
            
            List<string> names = new List<string>();
            foreach (Assembly asm in asms)
            {
                if (asm == entryAssembly)
                    continue;
                var name = asm.GetName();
                if (name.Name.ToLower().StartsWith("c1"))
                    names.Add(getName(name));
            }
            names.Sort(StringComparer.OrdinalIgnoreCase);
            names.ForEach((s_) => sb.AppendLine(s_));

            //
            _txtVersionInfo.Text = sb.ToString();
        }

        #region Public interface
        public AppAboutForm(string productName)
            :this()
        {
            _prodName.Text = productName;
            Text = string.Format(Text, productName);
        }

        public void AddInfo(string additionalInfo)
        {
            _txtVersionInfo.Text += additionalInfo;
        }

        public string Info
        {
            get { return _txtVersionInfo.Text; }
            set { _txtVersionInfo.Text = value; }
        }

        public Button ButtonOK { get { return _btnOk; } }

        public TextBox TextBoxInfo { get { return _txtVersionInfo; } }
        #endregion

        #region Hyperlinks
        private void resource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = C1_ROOT, UseShellExecute = true });
        }

        private void _link_linkMescius_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = _linkMescius.Text, UseShellExecute = true });
        }
        #endregion

        #region Form moving
        // from http://stackoverflow.com/a/24561946/4608039
        private bool _movingMouseDown;
        private Point _movingLastLocation;
        private void Mover_MouseDown(object sender, MouseEventArgs e)
        {
            // this is ugly but better than either immovable window or X that doesn't close it:
            if (e.Location.X > pictureBox1.Width - pictureBox1.Height)
                this.Close();
            else
            {
                _movingMouseDown = true;
                _movingLastLocation = e.Location;
            }
        }

        private void Mover_MouseMove(object sender, MouseEventArgs e)
        {
            if (_movingMouseDown)
            {
                this.Location = new Point((this.Location.X - _movingLastLocation.X) + e.X, (this.Location.Y - _movingLastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void Mover_MouseUp(object sender, MouseEventArgs e)
        {
            _movingMouseDown = false;
        }
        #endregion
    }
}
