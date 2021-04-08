using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Web;

using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;

using BankTellerCommon;
using BankTellerModule;

namespace CustomerMapExtensionModule
{
	[SmartPart]
	public partial class CustomerMap : UserControl
	{
		Customer _customer;
		bool _mapLoaded;

		const string MapUrlFormat = "http://maps.msn.com/home.aspx?strt1={0}&city1={2}&stnm1={3}&zipc1={4}";

		[State(StateConstants.CUSTOMER)]
		public Customer Customer
		{
			set { _customer = value; }
		}

		public CustomerMap()
		{
			InitializeComponent();
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);
			
			if (Visible && !_mapLoaded)
			{
				LoadMap();
				_mapLoaded = true;
			}
		}
		
		void LoadMap()
		{
			if (_customer != null)
			{
				string url = String.Format(MapUrlFormat, _customer.Address1, _customer.Address2, _customer.City, _customer.State, _customer.ZipCode);				
				browser.Navigate(Uri.EscapeUriString(url));
			}
		}
	}
}
