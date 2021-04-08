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
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.CompositeUI.EventBroker;
using Microsoft.Practices.ObjectBuilder;

using C1.Win.C1Ribbon;

using BankTellerCommon;

namespace BankShell
{
	// The shell represents the main window of the application. The shell
	// provides a menu, status bar, and a single workspace for the rest of
	// the window. Modules will use the workspace to display their role-
	// specific user interface.
	//
	// Core menu items (like Exit and About) are handled in the shell. We
	// ask for them to be dispatched on the user interface thread so that
	// we can directly call Form methods without using Invoke.
	//
	// We listen for status update events. Modules can fire status update
	// events to tell us to change the status bar.
	public partial class BankShellForm : C1RibbonForm
	{
		WorkItem _workItem;
		IWorkItemTypeCatalogService _workItemTypeCatalog;

		public BankShellForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// This constructor will be called by ObjectBuilder when the Form is created
		/// by calling WorkItem.Items.AddNew.
		/// </summary>
		[InjectionConstructor]
		public BankShellForm(WorkItem workItem, IWorkItemTypeCatalogService workItemTypeCatalog)
			: this()
		{
			_workItem = workItem;
			_workItemTypeCatalog = workItemTypeCatalog;
		}

		[CommandHandler("FileExit")]
		public void OnFileExit(object sender, EventArgs e)
		{
			Close();
		}

		[CommandHandler("HelpAbout")]
		public void OnHelpAbout(object sender, EventArgs e)
		{
            MessageBox.Show(this, "Bank Teller Composite UI Application Block (CAB) sample\nbased on ComponentOne Ribbon controls.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		[EventSubscription("topic://BankShell/statusupdate", Thread = ThreadOption.UserInterface)]
		public void OnStatusUpdate(object sender, DataEventArgs<string> e)
		{
            ribbonLabel1.Text = e.Data;
		}
	}
}