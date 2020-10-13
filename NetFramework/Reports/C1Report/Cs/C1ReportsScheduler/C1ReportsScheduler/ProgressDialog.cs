using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1ReportsScheduler
{
    public partial class ProgressDialog : Form
    {
        public ProgressDialog()
        {
            InitializeComponent();
            Show(WinUtil.MainForm);
        }

        public void SetProgress(int complete, string info)
        {
            System.Diagnostics.Debug.Assert(complete >= 0 && complete <= 100);
            complete = Math.Max(Math.Min(complete, 100), 0);
            Complete = complete;
            Info = info;
            Application.DoEvents();
        }

        public string Info
        {
            get { return lblInfo.Text; }
            set { lblInfo.Text = value; }
        }

        public int Complete
        {
            get { return progressBar.Value; }
            set { progressBar.Value = value; }
        }
    }
}
