using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintAndExport
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        public string EnterPassword(string fileName)
        {
            label2.Text = string.Format("'{0}' is protected. Please enter a Document Open Password.", Path.GetFileName(fileName));
            ActiveControl = tbPassword;
            if (ShowDialog() == DialogResult.OK)
                return tbPassword.Text;
            return null;
        }

        public static string DoEnterPassword(string fileName)
        {
            using (PasswordForm f = new PasswordForm())
                return f.EnterPassword(fileName);
        }
    }
}
