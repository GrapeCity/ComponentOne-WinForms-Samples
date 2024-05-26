using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportFromFlexReportAndPdf
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
            return string.Empty;
        }

        public static string DoEnterPassword(string fileName)
        {
            using (PasswordForm f = new PasswordForm())
                return f.EnterPassword(fileName);
        }
    }
}
