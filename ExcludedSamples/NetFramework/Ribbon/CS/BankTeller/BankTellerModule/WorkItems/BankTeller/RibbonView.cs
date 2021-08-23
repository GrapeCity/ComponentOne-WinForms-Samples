using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

using C1.Win.C1Ribbon;
using C1.Win.C1Ribbon.CAB;

using BankTellerCommon;

namespace BankTellerModule
{
    [SmartPart]
    public partial class RibbonView : UserControl
    {
        public RibbonView()
        {
            InitializeComponent();
        }

        public void InitCommands(WorkItem workItem)
        {
            workItem.Commands[CommandConstants.HELP_ABOUT].AddInvoker(aboutButton, "Click");
            workItem.Commands[CommandConstants.FILE_EXIT].AddInvoker(exitButton, "Click");
            workItem.Commands[CommandConstants.ACCEPT_CUSTOMER].AddInvoker(rbAcceptCustomer, "Click");
            workItem.Commands[CommandConstants.SAVE_CHANGES].AddInvoker(saveButton, "Click");
            workItem.Commands[CommandConstants.EDIT_CUSTOMER].AddInvoker(editButton, "Click");
            workItem.Commands[CommandConstants.ADD_COMMENTS].AddInvoker(commentsButton, "Click");
            workItem.Commands[CommandConstants.HELP_ABOUT].AddInvoker(helpConfigButton, "Click");

            Command cmd = workItem.Commands[CommandConstants.SELECTION_TAB_GROUP];
            cmd.AddInvoker(selectionCTG, "Click");
            cmd.Status = CommandStatus.Unavailable;

            workItem.State["saveImage"] = saveButton.SmallImage;
        }

        [CommandHandler(CommandConstants.SELECTION_TAB_GROUP)]
        public void OnSelectionCTGClick(object sender, EventArgs e)
        {
            if (!c1Ribbon1.Minimized)
            {
                c1Ribbon1.SelectedTab = customerTab;
            }
        }

        void c1Ribbon1_MinimizedChanged(object sender, EventArgs e)
        {
            if (c1Ribbon1.Minimized)
            {
                minimizeRibbonButton.Visible = false;
                expandRibbonButton.Visible = true;
            }
            else
            {
                minimizeRibbonButton.Visible = true;
                expandRibbonButton.Visible = false;
            }
        }
        void minimizeRibbonButton_Click(object sender, EventArgs e)
        {
            c1Ribbon1.Minimized = true;
        }
        void expandRibbonButton_Click(object sender, EventArgs e)
        {
            c1Ribbon1.Minimized = false;
        }
    }
}
