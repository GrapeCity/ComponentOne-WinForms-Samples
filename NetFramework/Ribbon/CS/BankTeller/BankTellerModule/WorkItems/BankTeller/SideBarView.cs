using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;

namespace BankTellerModule
{
    [SmartPart]
    public partial class SideBarView : UserControl
	{
		public SideBarView()
		{
			InitializeComponent();
		}

        public void InitCommands(WorkItem workItem)
        {
            customerQueueView1.InitCommands(workItem);
        }
	}
}
