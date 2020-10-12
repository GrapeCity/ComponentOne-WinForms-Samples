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
    public partial class ServiceInstallDialog : Form
    {
        public ServiceInstallDialog()
        {
            InitializeComponent();
            this.Text = string.Format("{0} Service Setup", C1ReportsSchedulerService.Constants.Name);
        }

        public string WcfEndpointBaseAddress
        {
            get { return txtWcfEndpointBaseAddress.Text; }
            set { txtWcfEndpointBaseAddress.Text = value; }
        }

        public string WcfEndpointRelAddress
        {
            get { return txtWcfEndpointRelAddress.Text; }
            set { txtWcfEndpointRelAddress.Text = value; }
        }

        public string C1rsconfFilePath
        {
            get { return txtC1rsconfFilePath.Text; }
            set { txtC1rsconfFilePath.Text = value; }
        }

        public bool AutoStart
        {
            get { return rbtStartupAuto.Checked; }
            set
            {
                rbtStartupAuto.Checked = value;
                rbtStartupManual.Checked = !value;
            }
        }

        public bool LogTasks
        {
            get { return chkLogTasks.Checked; }
            set { chkLogTasks.Checked = value; }
        }

        public bool LogActions
        {
            get { return chkLogActions.Checked; }
            set { chkLogActions.Checked = value; }
        }

        public bool LogProgramOutput
        {
            get { return chkLogProgramOutput.Checked; }
            set { chkLogProgramOutput.Checked = value; }
        }

        public bool EnableMex
        {
            get { return chkEnableMex.Checked; }
            set { chkEnableMex.Checked = value; }
        }

        private void btnC1rsconfFilePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "C1Reports_Scheduler service config files (*.c1rsconf)|*.c1rsconf|All files (*.*)|*.*";
                ofd.CheckPathExists = true;
                ofd.CheckFileExists = false;
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    C1rsconfFilePath = ofd.FileName;
                }
            }
        }

        private void txtWcfEndpointBaseAddress_Validating(object sender, CancelEventArgs e)
        {
            string text = ((TextBox)sender).Text;
            string proto = C1ReportsSchedulerService.Defaults.WcfEndpointBaseAddress.Substring(0,
                C1ReportsSchedulerService.Defaults.WcfEndpointBaseAddress.IndexOf("://") + 3);
            if (!text.StartsWith(proto))
            {
                AltUtil.ShowError("WCF endpoint base address must start with " + proto);
                e.Cancel = true;
            }
        }
    }
}
