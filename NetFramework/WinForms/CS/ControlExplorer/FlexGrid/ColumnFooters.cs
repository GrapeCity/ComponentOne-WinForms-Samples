using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnFooters : C1DemoForm
    {
        AggregateDefinition _orderIDAggregateDefinition = new AggregateDefinition();
        AggregateDefinition _productAggregateDefinition = new AggregateDefinition();
        AggregateDefinition _unitPriceAggregateDefinition = new AggregateDefinition();
        AggregateDefinition _quantityAggregateDefinition = new AggregateDefinition();
        AggregateDefinition _discountAggregateDefinition = new AggregateDefinition();
        int _footerRowIndex = -1;

        public ColumnFooters()
        {
            InitializeComponent();
        }

        private void ColumnFooters_Load(object sender, EventArgs e)
        {
            SetupGrid();
            SetupFooterProperties();
        }

        private void SetupGrid()
        {
            SetupData();
            SetupFooter();
            SetupAutoSize();

            flexGrid.Styles.Footer.TextAlign = TextAlignEnum.RightCenter;
        }

        private void SetupData()
        {
            var sql = "SELECT DISTINCTROW Orders.OrderID, " +
                                        "Products.ProductName AS Product, " +
                                        "[Order Details].UnitPrice, " +
                                        "[Order Details].Quantity, " +
                                        "[Order Details].Discount FROM Shippers " +
                                        "INNER JOIN " +
                                        "(Products INNER JOIN " +
                                        "((Employees INNER JOIN " +
                                        "(Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                                        "ON Employees.EmployeeID = Orders.EmployeeID) " +
                                        "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                                        "ON Products.ProductID = [Order Details].ProductID) " +
                                        "ON Shippers.ShipperID = Orders.ShipVia;";

            flexGrid.DataSource = DemoDataSource(sql, true);

            flexGrid.Cols["Discount"].Format = "P2";
        }

        private void SetupFooter()
        {
            var footerDescription = new FooterDescription();
            var footerAggregates = footerDescription.Aggregates;

            _orderIDAggregateDefinition.PropertyName = "OrderID";
            footerAggregates.Add(_orderIDAggregateDefinition);

            _productAggregateDefinition.PropertyName = "Product";
            _productAggregateDefinition.Caption = "Product Count: ";
            _productAggregateDefinition.Aggregate = AggregateEnum.CountDistinct;
            footerAggregates.Add(_productAggregateDefinition);

            _unitPriceAggregateDefinition.PropertyName = "UnitPrice";
            footerAggregates.Add(_unitPriceAggregateDefinition);

            _quantityAggregateDefinition.PropertyName = "Quantity";
            footerAggregates.Add(_quantityAggregateDefinition);

            _discountAggregateDefinition.PropertyName = "Discount";
            _discountAggregateDefinition.Caption = "Total Earnings: {0:N2}";
            _discountAggregateDefinition.Expression = "SUM(UnitPrice * Quantity * (1 - Discount))";
            footerAggregates.Add(_discountAggregateDefinition);

            flexGrid.Footers.Descriptions.Add(footerDescription);
            flexGrid.Footers.Fixed = true;

            _footerRowIndex = flexGrid.Rows.Count - 1;
        }

        private void SetupAutoSize()
        {
            flexGrid.AutoSizeCols();
            flexGrid.CellChanged += FlexGrid_CellChanged;
        }

        private void FlexGrid_CellChanged(object sender, RowColEventArgs e)
        {
            if (e.Row == _footerRowIndex)
            {
                flexGrid.AutoSizeCol(e.Col);
            }
        }

        private void SetupFooterProperties()
        {
            AddProperty("Fixed", flexGrid.Footers, "Fix footer");

            AddPropertySeparator();
            AddPropertyHeader("OrderID column:");
            AddProperty("Caption", _orderIDAggregateDefinition);
            AddProperty("Aggregate", _orderIDAggregateDefinition);
            AddProperty("Expression", _orderIDAggregateDefinition);

            AddPropertySeparator();
            AddPropertyHeader("Product column:");
            AddProperty("Caption", _productAggregateDefinition);
            AddProperty("Aggregate", _productAggregateDefinition);
            AddProperty("Expression", _productAggregateDefinition);

            AddPropertySeparator();
            AddPropertyHeader("UnitPrice column:");
            AddProperty("Caption", _unitPriceAggregateDefinition);
            AddProperty("Aggregate", _unitPriceAggregateDefinition);
            AddProperty("Expression", _unitPriceAggregateDefinition);

            AddPropertySeparator();
            AddPropertyHeader("Quantity column:");
            AddProperty("Caption", _quantityAggregateDefinition);
            AddProperty("Aggregate", _quantityAggregateDefinition);
            AddProperty("Expression", _quantityAggregateDefinition);

            AddPropertySeparator();
            AddPropertyHeader("Discount column:");
            AddProperty("Caption", _discountAggregateDefinition);
            AddProperty("Aggregate", _discountAggregateDefinition);
            AddProperty("Expression", _discountAggregateDefinition);
        }

        protected override void OnThemeApplied()
        {
            flexGrid.Styles.Footer.TextAlign = TextAlignEnum.RightCenter;
            flexGrid.AutoSizeCols();
        }
    }
}
