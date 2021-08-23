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
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            this.Text = string.Format("{0} Service Log", C1ReportsSchedulerService.Constants.Name);
        }

        protected override bool ShowWithoutActivation
        {
            get { return true; }
        }
    }
}
