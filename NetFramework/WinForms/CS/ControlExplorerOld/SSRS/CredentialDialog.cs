using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace ControlExplorer.SSRS
{
    public partial class CredentialDialog : Form
    {
        public CredentialDialog()
        {
            InitializeComponent();
        }

        public NetworkCredential Login(IWin32Window owner, string path, NetworkCredential nc)
        {
            tbPath.Text = path;
            if (nc != null)
            {
                tbUser.Text = nc.UserName;
                tbPassword.Text = nc.Password;
                tbDomain.Text = nc.Domain;
            }
            ActiveControl = tbUser;
            if (ShowDialog(owner) != System.Windows.Forms.DialogResult.OK)
                return null;
            return new NetworkCredential(tbUser.Text, tbPassword.Text, tbDomain.Text);
        }

        public static NetworkCredential DoLogin(IWin32Window owner, string path, NetworkCredential nc)
        {
            using (CredentialDialog f = new CredentialDialog())
                return f.Login(owner, path, nc);
        }
    }
}
