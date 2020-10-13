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
using System.Configuration;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.Services;
using Microsoft.Practices.ObjectBuilder;

using BankTellerCommon;

namespace BankTellerModule
{
	// This is the initialization class for the Module. Any classes in the assembly that
	// derive from Microsoft.Practices.CompositeUI.ModuleInit will automatically
	// be created and called for initialization.

	public class BankTellerModuleInit : ModuleInit
	{
		WorkItem _workItem;
		
		[InjectionConstructor]
		public BankTellerModuleInit([ServiceDependency] WorkItem workItem)
		{
			_workItem = workItem;
		}

		public override void Load()
		{
            BankTellerWorkItem wi = _workItem.WorkItems.AddNew<BankTellerWorkItem>();
            wi.CreateViews();
            wi.Show();
		}
	}
}
