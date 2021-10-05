using System;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    using C1.Win.TrueDBGrid;
    using TrueDBGridExplorer.Data;

    public partial class FilterMultiSelect : UserControl
    {
        private C1TrueDBDropdown c1TrueDBDropdown1;
        private C1TrueDBGrid c1TrueDBGrid1;

        public FilterMultiSelect()
        {
            InitializeComponent();

            c1TrueDBDropdown1 = new C1TrueDBDropdown();

            c1TrueDBGrid1 = new C1TrueDBGrid
            {
                Dock = DockStyle.Fill,
                FilterBar = true
            };
            Controls.Add(c1TrueDBGrid1);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string sqlOrders = @"SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" +
                "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " +
                "ShipVia FROM Orders";
            c1TrueDBGrid1.DataSource = DataSource.GetRows(sqlOrders);

            string sqlCustomers = @"SELECT CustomerID FROM Customers";
            c1TrueDBDropdown1.DataSource = DataSource.GetRows(sqlCustomers);

            // the dropdown control is bound to the Customers table
            c1TrueDBGrid1.Columns["CustomerID"].DropDown = c1TrueDBDropdown1;
            // turn on the dropdown button in the filterbar
            c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].FilterButton = true;
            // turn it off for regulars cells in the grid
            c1TrueDBGrid1.Splits[0].DisplayColumns["CustomerID"].Button = false;
            c1TrueDBDropdown1.ColumnHeaders = false;

            foreach (C1DataColumn c in c1TrueDBGrid1.Columns)
            {
                c.FilterDropdown = true;
                c.FilterMultiSelect = true;             
            }

            c1TrueDBGrid1.Columns["CustomerID"].FilterText = "A,S,VI";
            c1TrueDBGrid1.Columns["CustomerID"].FilterOperator = "like%";
            c1TrueDBGrid1.Columns["EmployeeID"].FilterText = "3,4,5";
        }
    }
}
