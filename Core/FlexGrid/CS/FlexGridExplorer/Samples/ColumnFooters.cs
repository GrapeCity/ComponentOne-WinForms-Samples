using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using FlexGridExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnFooters : UserControl
    {
        // Footer aggregate definitions for each column.
        private AggregateDefinition _orderIDAggregateDefinition = new AggregateDefinition();
        private AggregateDefinition _productAggregateDefinition = new AggregateDefinition();
        private AggregateDefinition _unitPriceAggregateDefinition = new AggregateDefinition();
        private AggregateDefinition _quantityAggregateDefinition = new AggregateDefinition();
        private AggregateDefinition _discountAggregateDefinition = new AggregateDefinition();

        private int _footerRowIndex = -1;

        public ColumnFooters()
        {
            InitializeComponent();
        }

        private void ColumnFooters_Load(object sender, EventArgs e)
        {
            SetupGrid();
            SetupFooterProperties();
        }

        #region Grid Setup

        private void SetupGrid()
        {
            SetupData();
            SetupFooter();
            SetupAutoSize();
            flexGrid.Styles.Footer.TextAlign = TextAlignEnum.RightCenter;
        }

        private void SetupData()
        {
            var sql = "SELECT DISTINCT Orders.OrderID, " +
                      "Products.ProductName AS Product, " +
                      "\"Order Details\".UnitPrice AS UnitPrice, " +
                      "\"Order Details\".Quantity, " +
                      "\"Order Details\".Discount/ 100.0 * 100 AS Discount  " +
                      "FROM Shippers " +
                      "INNER JOIN " +
                      "(Products INNER JOIN " +
                      "((Employees INNER JOIN " +
                      "(Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) " +
                      "ON Employees.EmployeeID = Orders.EmployeeID) " +
                      "INNER JOIN \"Order Details\" ON Orders.OrderID = \"Order Details\".OrderID) " +
                      "ON Products.ProductID = \"Order Details\".ProductID) " +
                      "ON Shippers.ShipperID = Orders.ShipVia;";
            flexGrid.DataSource = DataSource.GetRows(sql);
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
                flexGrid.AutoSizeCol(e.Col);
        }

        #endregion

        #region Ribbon Setup

        /// <summary>
        /// Configures the footer properties using the Ribbon controls declared in the designer.
        /// </summary>
        private void SetupFooterProperties()
        {
            // Fix Footer CheckBox
            rcbFixFooter.Checked = flexGrid.Footers.Fixed;
            rcbFixFooter.CheckedChanged += (s, e) =>
            {
                flexGrid.Footers.Fixed = rcbFixFooter.Checked;
            };

            // Column ComboBox (items use Tag to store the column name)
            rcbColumn.Items.Clear();
            foreach (Column col in flexGrid.Cols)
            {
                if (col.Index == 0)
                    continue; 

                rcbColumn.Items.Add(new RibbonButton() { Text = col.Name, Tag = col.Name });
            }
            rcbColumn.SelectedIndexChanged += RcbColumn_SelectedIndexChanged;
            rcbColumn.SelectedIndex = 0;

            // Aggregate ComboBox (each item wraps an AggregateEnum value in its Tag)
            rcbAggregate.Items.Clear();
            foreach (AggregateEnum agg in Enum.GetValues(typeof(AggregateEnum)))
            {
                RibbonButton rb = new RibbonButton
                {
                    Text = agg.ToString(),
                    Tag = agg
                };
                rcbAggregate.Items.Add(rb);
            }
            rcbAggregate.SelectedIndexChanged += RcbAggregate_SelectedIndexChanged;

            // Caption and Expression TextBoxes
            rtbCaption.LostFocus += (s, e) =>
            {
                if (rcbColumn.SelectedItem is RibbonButton selectedCol)
                {
                    var def = GetAggregateDefinitionForColumn(selectedCol.Text);
                    if (def != null)
                    {
                        def.Caption = rtbCaption.Text;
                        flexGrid.Refresh();
                    }
                }
            };

            rtbExpression.LostFocus += (s, e) =>
            {
                if (rcbColumn.SelectedItem is RibbonButton selectedCol)
                {
                    var def = GetAggregateDefinitionForColumn(selectedCol.Text);
                    if (def != null)
                    {
                        def.Expression = rtbExpression.Text;
                        flexGrid.Refresh();
                    }
                }
            };

            UpdateFooterPropertyFields();
        }

        private void RcbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFooterPropertyFields();
        }

        private void RcbAggregate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rcbColumn.SelectedItem is RibbonButton selectedCol &&
                rcbAggregate.SelectedItem is RibbonButton selectedAgg)
            {
                var def = GetAggregateDefinitionForColumn(selectedCol.Text);
                if (def != null)
                {
                    def.Aggregate = (AggregateEnum)selectedAgg.Tag;
                    flexGrid.Refresh();
                }
            }
        }

        /// <summary>
        /// Updates the Caption, Expression, and Aggregate fields on the Ribbon based on the selected column.
        /// </summary>
        private void UpdateFooterPropertyFields()
        {
            if (rcbColumn.SelectedItem is RibbonButton selectedCol)
            {
                string colName = selectedCol.Text;
                var def = GetAggregateDefinitionForColumn(colName);
                if (def != null)
                {
                    rtbCaption.Text = def.Caption;
                    rtbExpression.Text = def.Expression;
                    foreach (RibbonButton rb in rcbAggregate.Items)
                    {
                        if ((AggregateEnum)rb.Tag == def.Aggregate)
                        {
                            rcbAggregate.SelectedItem = rb;
                            break;
                        }
                    }
                }
            }
        }

        private AggregateDefinition GetAggregateDefinitionForColumn(string columnName)
        {
            return columnName switch
            {
                "OrderID" => _orderIDAggregateDefinition,
                "Product" => _productAggregateDefinition,
                "UnitPrice" => _unitPriceAggregateDefinition,
                "Quantity" => _quantityAggregateDefinition,
                "Discount" => _discountAggregateDefinition,
                _ => null,
            };
        }

        #endregion
    }
}