using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnSizing: UserControl
    {
        public ColumnSizing()
        {
            InitializeComponent();
        }

        private void ColumnSizingOptions_Load(object sender, EventArgs e)
        {
            SetupGrid();
            SetupComboBox();
        }

        private void SetupGrid()
        {
            string sql = @"
                SELECT Distinct 
	                Orders.[OrderID], 
	                Orders.OrderDate, 
	                Shippers.CompanyName, 
	                Customers.Country AS Country, 
	                [FirstName] + ' ' + [LastName] AS Salesperson, 
	                Products.ProductName AS Product, 
	                [Order Details].UnitPrice AS UnitPrice, 
	                [Order Details].Quantity, 
	                [Order Details].Discount, 
	                ([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 as ExtendedPrice 
	                FROM Shippers 
		                INNER JOIN (Products 
		                INNER JOIN ((Employees 
		                INNER JOIN (Customers 
		                INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) 
		                INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID)
			                ON Shippers.ShipperID = Orders.ShipVia; ";


            flexGrid.DataSource = DataSource.GetRows(sql);
        }

        private void SetupComboBox()
        {
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbMethod.Items.Add("Fixed");
            cmbMethod.Items.Add("AutoSize");
            cmbMethod.Items.Add("ExtendLastColumn");
            cmbMethod.Items.Add("StarSize");

            cmbMethod.SelectedIndexChanged += CmbMethod_SelectedIndexChanged;

            cmbMethod.SelectedIndex = 3;
        }

        private void CmbMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFixedSize();

            var cmb = sender as ToolStripComboBox;

            if (cmb != null)
            {
                switch (cmb.Text)
                {
                    case "AutoSize":
                        flexGrid.AutoSizeCols();
                        break;
                    case "ExtendLastColumn":
                        flexGrid.ExtendLastCol = true;
                        break;
                    case "StarSize":
                        ApplyStarSize();
                        break;
                }
            }
        }

        private void ApplyFixedSize()
        {
            flexGrid.ExtendLastCol = false;

            var cols = flexGrid.Cols;

            for (var c = cols.Fixed; c < cols.Count; c++)
            {
                cols[c].Width = 95;
            }
        }

        private void ApplyStarSize()
        {
            var cols = flexGrid.Cols;

            for (var c = cols.Fixed; c < cols.Count; c++)
            {
                cols[c].MinWidth = 50;
            }

            cols["OrderID"].StarWidth = "*";
            cols["OrderDate"].StarWidth = "2*";
            cols["CompanyName"].StarWidth = "2*";
            cols["Country"].StarWidth = "2*";
            cols["Salesperson"].StarWidth = "2*";
            cols["Product"].StarWidth = "3*";
            cols["UnitPrice"].StarWidth = "*";
            cols["Quantity"].StarWidth = "*";
            cols["Discount"].StarWidth = "*";
            cols["ExtendedPrice"].StarWidth = "*";
        }
    }
}
