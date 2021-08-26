using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.WinForms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.CompositeUI.UIElements;

using BankTellerCommon;
using BankTellerModule;

namespace CustomerMapExtensionModule
{
	[WorkItemExtension(typeof(CustomerWorkItem))]
	public class CustomerWorkItemExtension : WorkItemExtension
	{
		CustomerMap _mapView;

		protected override void OnActivated()
		{
			if (_mapView == null)
			{
				_mapView = WorkItem.Items.AddNew<CustomerMap>();

				TabSmartPartInfo info = new TabSmartPartInfo();
				info.Title = "Customer Map";
				info.Description = "Map of the customer location";
                WorkItem.Workspaces[WorkspaceConstants.CUSTOMER_TABS].Show(_mapView, info);
			}
		}
	}
}
