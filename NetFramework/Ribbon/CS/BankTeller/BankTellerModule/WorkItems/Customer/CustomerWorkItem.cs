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
using System.Drawing;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.Commands;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.WinForms;

using C1.Win.C1Ribbon;

using BankTellerCommon;

namespace BankTellerModule
{
	// The CustomerWorkItem represents the use case of editing a customer's data.
	// It contains the views necessary to edit a single customer. When it's time
	// to edit a customer, the work item's parent calls Run and passes the
	// workspace where the editing will take place.

	public class CustomerWorkItem : WorkItem
	{
		CustomerSummaryView _customerSummaryView;
		CustomerCommentsView _commentsView;
        RibbonLabel _addressLabel;
        RibbonButton _saveButton;

		// This event is published to indicate that the module would like to
		// "update status". The only subscriber to this event today is the shell
		// which updates the status bar. These two components don't know anything
		// about one another, because they communicate indirectly via the
		// EventBroker. In reality, you can have any number of publishers and
		// any number of subscribers; in fact, other modules will undoubtedly
		// also publish status update events.
		[EventPublication("topic://BankShell/statusupdate", PublicationScope.Global)]
		public event EventHandler<DataEventArgs<string>> UpdateStatusTextEvent;

        public void CreateViews()
        {
            _customerSummaryView = Items.AddNew<CustomerSummaryView>();
            Commands[CommandConstants.CUSTOMER_MOUSEOVER].AddInvoker(_customerSummaryView, "MouseHover");

            _addressLabel = new RibbonLabel();
            UIExtensionSites[UIExtensionConstants.SB_LEFT_PANE_ITEMS].Add(_addressLabel);

            _saveButton = new RibbonButton();
            _saveButton.Text = "Save Changes";
            _saveButton.SmallImage = (Image)this.Parent.State["saveImage"];
            _saveButton.ToolTip = "Save Customer Data";
            UIExtensionSites[UIExtensionConstants.SB_RIGHT_PANE_ITEMS].Add(_saveButton);
            Commands[CommandConstants.SAVE_CHANGES].AddInvoker(_saveButton, "Click");
        }

		public void Show(IWorkspace workspace)
		{
			workspace.Show(_customerSummaryView);

			Customer customer = (Customer)State[StateConstants.CUSTOMER];
			OnStatusTextUpdate(string.Format("Editing {0}, {1}", customer.LastName, customer.FirstName));
            _addressLabel.Text = customer.Address1;

			this.Activate();

			// When activating, force focus on the first tab in the view.
			// Extensions may have added stuff at the end of the tab.
			_customerSummaryView.Controller.FocusFirstTab();
		}

        private void SetUIElementVisibility(bool visible)
        {
            _addressLabel.Visible = visible;
            _saveButton.Visible = visible;
        }

		// We watch for when we are activated (i.e., shown to
		// be worked on), we want to fire a status update event and show ourselves
		// in the provided workspace.
		protected override void OnActivated()
		{
			base.OnActivated();

			SetUIElementVisibility(true);
		}

		protected override void OnDeactivated()
		{
			base.OnDeactivated();

			SetUIElementVisibility(false);
		}

		protected virtual void OnStatusTextUpdate(string newText)
		{
			if (UpdateStatusTextEvent != null)
			{
				UpdateStatusTextEvent(this, new DataEventArgs<string>(newText));
			}
		}

        [CommandHandler(CommandConstants.ADD_COMMENTS)]
        public void OnShowCustomerComments(object sender, EventArgs e)
		{
            if (Status == WorkItemStatus.Active)
            {
                if (_commentsView == null)
                {
                    _commentsView = SmartParts.AddNew<CustomerCommentsView>();
                    ISmartPartInfo info = new TabSmartPartInfo();
                    info.Title = "Comments";
                    RegisterSmartPartInfo(_commentsView, info);
                }
                IWorkspace ws = Workspaces[WorkspaceConstants.CUSTOMER_TABS];
                if (ws != null)
                {
                    ws.Show(_commentsView);
                }
            }
		}

        [CommandHandler(CommandConstants.SAVE_CHANGES)]
        public void OnSaveChanges(object sender, EventArgs args)
        {
            _customerSummaryView.Validate();
            Save();
        }

		[CommandHandler(CommandConstants.CUSTOMER_MOUSEOVER)]
		public void OnCustomerEdit(object sender, EventArgs args)
		{
			if (Status == WorkItemStatus.Active)
			{
				Form form = _customerSummaryView.ParentForm;

                Point pt = _customerSummaryView.PointToScreen(new Point(_customerSummaryView.Width - 30, -10));
                pt = form.PointToClient(pt);

				string tooltipText = "This is customer work item " + this.ID;
				ToolTip toolTip = new ToolTip();
				toolTip.IsBalloon = true;
				toolTip.Show(tooltipText, form, pt.X, pt.Y, 3000);
			}
		}
	}
}