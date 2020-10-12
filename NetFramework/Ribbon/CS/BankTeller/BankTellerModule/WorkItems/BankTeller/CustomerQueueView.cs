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
using BankTellerCommon;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.Utility;
using Microsoft.Practices.ObjectBuilder;

namespace BankTellerModule
{
	[SmartPart]
	public partial class CustomerQueueView : UserControl
	{
		CustomerQueueController _controller;

		[CreateNew]
		public CustomerQueueController Controller
		{
			set { _controller = value; }
		}

		public CustomerQueueView()
		{
			InitializeComponent();
		}

        public void InitCommands(WorkItem workItem)
        {
            workItem.Commands[CommandConstants.ACCEPT_CUSTOMER].AddInvoker(btnNextCustomer, "Click");
        }

		[CommandHandler(CommandConstants.ACCEPT_CUSTOMER)]
		public void OnAcceptCustomer(object sender, EventArgs e)
		{
			Customer customer = _controller.GetNextCustomerInQueue();

			if (customer == null)
			{
				MessageBox.Show(this, "There are no more customers in the queue.", "Bank Teller", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                _controller.DisableAcceptCustomers();
                return;
			}

			listCustomers.Items.Add(customer);

            // restore focus on the customer view item
            OnCustomerSelectionChanged(sender, e);
		}

		void OnCustomerSelectionChanged(object sender, EventArgs e)
		{
			Customer customer = listCustomers.SelectedItem as Customer;
			if (customer != null)
			{
				_controller.WorkWithCustomer(customer);
			}
		}
	}
}
