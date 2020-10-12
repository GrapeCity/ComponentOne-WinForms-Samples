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

using System;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;

using BankTellerCommon;

namespace BankTellerModule
{
	// The BankTellerWorkItem is the core work item of the module. Rather than
	// representing a single use case, it is the container of all the other
	// smaller work items in the system.
	public class BankTellerWorkItem : WorkItem
	{
		// The work item uses the state persistence service that's been registered
		// in the shell initialization
		public IStatePersistenceService PersistenceService
		{
			get { return Services.Get<IStatePersistenceService>(); }
		}

        public void CreateViews()
        {
            SmartParts.AddNew<UserInfoView>("UserInfoView");
            SideBarView sbv = SmartParts.AddNew<SideBarView>("SideBarView");
            sbv.InitCommands(this);
            RibbonView rv = SmartParts.AddNew<RibbonView>("RibbonView");
            rv.InitCommands(this);
        }

		// Note that order is important here. When we create the BankTellerMainView,
		// it is going to assume that the smart parts that it needs already exist
		// in the work item. Therefore, we create the smart parts first, and then
		// create the main view that contains them.
        public void Show()
		{
            IWorkspace ribbonBar = Workspaces[WorkspaceConstants.SHELL_RIBBON];
            IWorkspace sideBar = Workspaces[WorkspaceConstants.SHELL_SIDEBAR];

            RibbonView ribbonView = SmartParts.Get<RibbonView>("RibbonView");
            ribbonBar.Show(ribbonView);

            SideBarView sideBarView = SmartParts.Get<SideBarView>("SideBarView");
			sideBar.Show(sideBarView);

			this.Activate();
		}

		// When the user clicks on a customer in their customer queue, the
		// CustomerQueueController calls us to tell us to start working with
		// the customer.
		//
		// Editing a customer is self-contained in a work item (the CustomerWorkItem)
		// so we end up with one CustomerWorkItem contained in ourselves for
		// each customer that is being edited.
		public void WorkWithCustomer(Customer customer)
		{
			// Construct a key to register the work item in ourselves
			string key = string.Format("Customer #{0}", customer.ID);

			// Have we already made the work item for this customer?
			// If so, return the existing one.
			CustomerWorkItem workItem = this.Items.Get<CustomerWorkItem>(key);

			if (workItem == null)
			{
				workItem = WorkItems.AddNew<CustomerWorkItem>(key);

				//Set ID before setting state.  State will be cleared if a new id is set.
				workItem.ID = key;
				workItem.State[StateConstants.CUSTOMER] = customer;
				
				// Ask the persistence service if we have a saved version of
				// this work item. If so, load it from persistence.
                IStatePersistenceService persistenceService = PersistenceService;
                if (persistenceService != null && persistenceService.Contains(workItem.ID))
                {
                    workItem.Load();
                }

                workItem.CreateViews();
			}

            workItem.Show(Workspaces[WorkspaceConstants.SHELL_CONTENT]);

            Command cmd = workItem.Commands[CommandConstants.SELECTION_TAB_GROUP];
            cmd.Status = CommandStatus.Enabled;
            cmd.Execute();
		}
	}
}
