using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace C1Report2Rpx
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
        }

        #region Public static
        public static void DoShow(
            IWin32Window owner)
        {
            using (AboutDialog f = new AboutDialog())
                f.ShowDialog(owner);
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start((string)e.Link.LinkData);
        }

        private void AboutDialog_Load(object sender, EventArgs e)
        {
            Text = Strings.C1Report2RpxLongName;
            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            lblBuild.Text = string.Format("{0}.{1}.{2}{3}.{4}", v.Major, v.Minor, v.Build / 10, v.Build % 10, v.Revision);
            lblCopyright.Text = this.lblCopyright.Text.Replace("2010", DateTime.Now.Year.ToString(System.Globalization.CultureInfo.InvariantCulture));
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Strings.C1Urls.Website);
        }
    }
}
