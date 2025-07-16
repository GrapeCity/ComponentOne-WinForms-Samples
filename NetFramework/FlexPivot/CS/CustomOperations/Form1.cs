using C1.DataEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomOperations
{
    public partial class Form1 : Form
    {
        // query descriptions
        private string[] desc = new string[] {
            "Standard Operation: Standard discount for all products",
            "Custom Operation: Progressive discount for all products",
            "Standard Operation: How many big orders made for each product. Whether an order is considered big for a product depends on the product and ordered quantity.",
            "Custom Operation: How many orders made for each product."
        };

        C1.DataEngine.Workspace workspace = null;
        
        public Form1()
        {
            // designer support
            InitializeComponent();
            
            // initial state of controls
            cbQuery.SelectedIndex = 0;
            cbItemsCount.SelectedIndex = 0;

            // where DataEngine data is stored
            workspace = C1.Win.FlexPivot.C1FlexPivotPanel.CreateWorkspace();
            workspace.Init(Path.Combine(System.Windows.Forms.Application.StartupPath, "Data"));
        }

        // initialize controls with data
        protected override void OnLoad(EventArgs e)
        {
            RefreshControls();
         	base.OnLoad(e);
        }

        // save workspace metadata
        protected override void OnClosed(EventArgs e)
        {
            workspace.Save();
            base.OnClosed(e);
        }

        // generate data
        private void Generate()
        {
            int cnt;
            if (int.TryParse(cbItemsCount.Text.Replace(",", ""), out cnt))
            {
                gbQuery.Enabled = false;

                // remove previously generated data
                workspace.Clear();

                // generate table
                DateTime start = DateTime.Now;
                Utils.Products.Generate(workspace, cbQuery.SelectedIndex > 1 ? 4 : 77, 500, 500);
                Utils.OrderDetails.Generate(workspace, cnt, 0, (int)workspace.GetTableData(Utils.Products.Name).Size, 50, 10000, 10);
                Utils.Orders.Generate(workspace, cnt, DateTime.Now.Subtract(new TimeSpan(170, 0, 0, 0)), DateTime.Now, 2, 14);
                double sec = DateTime.Now.Subtract(start).TotalSeconds;
                lblTimeGen.Text = string.Format("Time generating data: {0:n2} sec.", sec);

                // update controls
                RefreshControls();
                gbQuery.Enabled = true;
            }
        }

        // shows controls to run a specific query
        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = desc[cbQuery.SelectedIndex];
            FillGrid(dgvResult, null);
            FillGrid(dgvOrderDetails, null);
        }

        // executes the selected query
        private void btnExec_Click(object sender, EventArgs e)
        {
            gbQuery.Enabled = false;
            Generate();
            ExecuteQuery();
            gbQuery.Enabled = true;
        }
               
        // executes the selected query
        private void ExecuteQuery()
        {
            tabControl1.SelectedIndex = 1;
            Application.DoEvents();
            DateTime start = DateTime.Now;
            IDataList res = null;
            if (cbQuery.SelectedIndex == 0)
                res = QueryProductDiscount();
            else if (cbQuery.SelectedIndex == 1)
                res = QueryProductCustomDiscount();
            else if (cbQuery.SelectedIndex == 2)
                res = QueryBigOrders();
            else if (cbQuery.SelectedIndex == 3)
                res = QueryOrdersCount();
            double sec = DateTime.Now.Subtract(start).TotalSeconds;
            lblTime.Text = string.Format("Time executing query: {0:n2} sec.", sec);
            FillGrid(dgvResult, res);
        }

        // fills the grid with table data
        private void FillGrid(C1.Win.FlexGrid.C1FlexGrid grid, string tableName, int maxRows = 0)
        {
            if (string.IsNullOrEmpty(tableName))
                return;
            FillGrid(grid, workspace.GetTableData(tableName, maxRows));
        }

        // fills the grid with data
        private void FillGrid(C1.Win.FlexGrid.C1FlexGrid grid, IDataList source)
        {
            lblResultTotalRows.Text = "0";
            grid.DataSource = source;
            long count = 0;
            if (source != null)
            {
                count = source.Size;
                // update column names and format using data schema
                var cols = source.GetSchemaTable().Rows;
                for (int i = 1; i < cols.Count; i++)
                {
                    grid.Cols[i + 1].Caption = (string)cols[i]["caption"];
                    Type type = System.Type.GetType((string)cols[i]["type"]);
                    if (IsFloat(type))
                        grid.Cols[i + 1].Style.Format = "n2";
                }
            }
            Label lbl = null;
            if (grid == dgvResult)
                lbl = lblResultTotalRows;
            else if (grid == dgvOrderDetails)
                lbl = lblODRowsTotal;
            if (lbl != null)
                lbl.Text = string.Format("{0:n0}", count);
        }

        // check whether the data type is float
        private static bool IsFloat(Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }

        // fills controls with data
        private void RefreshControls()
        {
            FillGrid(dgvOrderDetails, Utils.OrderDetails.Name, 300);
        }

        // Class defining custom (user-defined) operations.
        // Operation names: ProgressiveDiscount (simple operation, without grouping), BigOrders (group, aggregation operation)
        unsafe class MyOp : Op
        {
            private static double CalcDiscount(float price, short quantity, double discount)
            {
                double res = 0;
                if (quantity * price < 1000) // order item with total price less than 1000
                {
                    if (quantity > 10) // if more than 10 items, apply 20% discount, otherwise apply discount from the [Order Details].Discount field
                        res = price * 0.2;
                    else
                        res = price * discount;
                }
                else // order item total price greater than 1000
                {
                    res = price * Math.Min(discount + 0.1, 1); // add 10% discount to the discount specified in the [Order Details].Discount field
                }
                return res;
            }
            public static ColumnOp ProgressiveDiscount(Column unitPrice, Column discount, Column quantity)
            {
                Type resType = typeof(double); // result type
                return new ColumnOpCustom(typeof(MyOp), "ProgressiveDiscount", new Column[] { discount, unitPrice, quantity }, resType, (Values[] columns, long offset, long count, Values result, long* filterOids) =>
                {
                    float* pricePtr = (float*)columns[0].Pointer + offset; // UnitPrice
                    double* discountPtr = (double*)columns[1].Pointer + offset; // Discount
                    short* quantityPtr = (short*)columns[2].Pointer + offset; // Quantity
                    double* ptrRes = (double*)result.Pointer;
                    if (filterOids == null)
                        for (long i = 0; i < count; i++, quantityPtr++, pricePtr++, discountPtr++, ptrRes++)
                            *ptrRes = CalcDiscount(*pricePtr, *quantityPtr, *discountPtr);
                    else
                        for (long i = 0; i < count; i++, filterOids++, ptrRes++)
                            *ptrRes = CalcDiscount(*(pricePtr + *filterOids), *(quantityPtr + *filterOids), *(discountPtr + *filterOids));
                });
            }
            public static ColumnOp BigOrders(Column productID, Column quantity)
            {
                Type resType = typeof(int); // result type
                return new ColumnOpCustomGroup(typeof(MyOp), "BigOrders", new Column[] { productID, quantity }, resType, (Values[] columns, long offset, long count, Values result, long offsetResult) =>
                {
                    int* productPtr = (int*)columns[0].Pointer + offset; // ProducID
                    short* quantityPtr = (short*)columns[1].Pointer + offset; // Quantity
                    int* ptrRes = (int*)result.Pointer + offsetResult;

                    *ptrRes = 0;
                    for (long i = 0; i < count; i++, productPtr++, quantityPtr++)
                    {
                        int id = *productPtr; // get and analyze product-specific data
                        int q = *quantityPtr;
                        if (id == 0 && q > 10) // orders with product id = 0 are considered big if quantity is greater than 10
                            (*ptrRes)++;
                        else if (id == 1 && q > 48) // orders with product id = 1 are considered big if quantity is greater than 48
                            (*ptrRes)++;
                        else if (id == 2 && q > 2) // orders with product id = 2 are considered big if quantity is greater than 2
                            (*ptrRes)++;
                        else if (id == 3 && q > 13) // orders with product id = 3 are considered big if quantity is greater than 13
                            (*ptrRes)++;
                    }
                });
            }
        }

        // Query using a custom operation:
        // custom discount information for all products
        private IDataList QueryProductCustomDiscount()
        {
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qp = workspace.query("query_productCustomDiscount", new
            {
                ds = MyOp.ProgressiveDiscount(od.UnitPrice, od.Discount, od.Quantity), // calculate discount for a product in an order
                Product = od.ProductID, // group by product
                OrderCount = Op.Count(od.OrderID), // order count for a product
                DiscountSum = Op.Sum("ds") // total progressive discount for a product in all orders
            });
            return qp.Query.Execute();
        }

        // Query using only standard operations:
        // discount information for all products
        private IDataList QueryProductDiscount()
        {
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qp = workspace.query("query_productDiscount", new
            {
                ds = Op.Mul(od.UnitPrice, od.Discount), // calculate discount for a product in an order
                Product = od.ProductID, // group by product
                OrderCount = Op.Count(od.OrderID), // order count for a product
                DiscountSum = Op.Sum("ds") // total  discount for a product in all orders
            });
            return qp.Query.Execute();
        }

        // Query using a custom group operation:
        private IDataList QueryBigOrders()
        {
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qp = workspace.query("query_bigOrders", new
            {
                Product = od.ProductID, // group by order
                BigOrders = MyOp.BigOrders(od.ProductID, od.Quantity) // how many big orders are made for each product
            });
            return qp.Query.Execute();
        }

        // Query using only standard operations:
        private IDataList QueryOrdersCount()
        {
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qp = workspace.query("query_ordersCount", new
            {
                Product = od.ProductID, // group by order
                Orders = Op.Count(od.OrderID) // how many orders are made for each product
            });
            return qp.Query.Execute();
        }


    }
}
