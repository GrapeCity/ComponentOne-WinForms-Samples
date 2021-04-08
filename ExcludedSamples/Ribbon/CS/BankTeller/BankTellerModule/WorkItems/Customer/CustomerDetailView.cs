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
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.ObjectBuilder;

using BankTellerCommon;

namespace BankTellerModule
{
	[SmartPart]
	public partial class CustomerDetailView : UserControl
	{
		Customer _customer;

		public CustomerDetailView()
		{
			InitializeComponent();
		}

		// The Customer state is stored in our parent work item
		[State]
		public Customer Customer
		{
			set { _customer = value; }
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

			if (_customer != null)
			{
				customerBindingSource.Add(_customer);
			}
		}
	}
}
