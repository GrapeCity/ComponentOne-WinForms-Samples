//===============================================================================
// Microsoft patterns & practices
// CompositeUI Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using System;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.WinForms;
using BankTellerCommon;

namespace BankTellerModule
{
	public class CustomerSummaryController : Controller
	{
		// The CustomerSummaryController is the controller used by the CustomerSummaryView.
		// The summary view contains the pieces of the other views to display a customer,
		// and includes the Save button for the user to save their changes. The save
		// request is forwarded up to the work item.

		public new CustomerWorkItem WorkItem
		{
			get { return base.WorkItem as CustomerWorkItem; }
		}

		[CommandHandler(CommandConstants.EDIT_CUSTOMER)]
		public void OnCustomerEdit(object sender, EventArgs args)
		{
			if (WorkItem.Status == WorkItemStatus.Active)
			{
                FocusFirstTab();
			}
		}

        internal void FocusFirstTab()
        {
            TabWorkspace tabWS = WorkItem.Workspaces[WorkspaceConstants.CUSTOMER_TABS] as TabWorkspace;
            if (tabWS != null)
            {
                tabWS.SelectedIndex = 0;
            }
        }
	}
}
