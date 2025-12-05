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

namespace DataEngineQueries
{
    public partial class Form1 : Form
    {
        // query descriptions
        private string[] desc = new string[] {
            "Product information: how many times it was ordered (from Order Details) and how many items are left in stock (from Products table)",
            "Join Order Details table with Products table by ProductID",
            "Discount information for the specified product",
            "Products within the specified unit price range",
            "Products that were ordered more than the specified number of times",
            "Orders information by month"
        };

        C1.DataEngine.Workspace workspace = null;
        
        public Form1()
        {
            // designer support
            InitializeComponent();
            
            // initial state of controls
            panelProduct.Top = panelUnitPriceRange.Top;
            panelJoin.Top = panelUnitPriceRange.Top;
            panelJoinFlexPivot.Top = panelUnitPriceRange.Top;
            panelGroupRange.Top = panelUnitPriceRange.Top;
            btnFlexPivot.Enabled = false;
            cbQuery.SelectedIndex = 0;

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

        // generates data
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int cnt;
            if (int.TryParse(cbItemsCount.Text.Replace(",", ""), out cnt))
            {
                gbQuery.Enabled = false;

                // remove previously generated data
                workspace.Clear();

                // generate table
                Utils.Products.Generate(workspace, 77, 500, 500);
                Utils.OrderDetails.Generate(workspace, cnt, 0, (int)workspace.GetTableData(Utils.Products.Name).Size, 50, 100, 10);
                Utils.Orders.Generate(workspace, cnt, DateTime.Now.Subtract(new TimeSpan(170, 0, 0, 0)), DateTime.Now, 2, 14);

                // update controls
                RefreshControls();
                ExecuteQuery();
                gbQuery.Enabled = true;
            }
        }

        // shows appropriate controls to run a specific query
        private void cbQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelUnitPriceRange.Hide();
            panelProduct.Hide();
            panelJoin.Hide();
            panelGroupRange.Hide();
            panelJoinFlexPivot.Hide();
            btnFlexPivot.Enabled = false;
            if (cbQuery.SelectedIndex == 0)
                panelJoin.Show();
            else if (cbQuery.SelectedIndex == 1)
                panelJoinFlexPivot.Show();
            else if (cbQuery.SelectedIndex == 2)
                panelProduct.Show();
            else if (cbQuery.SelectedIndex == 3)
                panelUnitPriceRange.Show();
            else if (cbQuery.SelectedIndex == 4)
                panelGroupRange.Show();
            else if (cbQuery.SelectedIndex == 5)
                panelJoin.Show();
            lblDesc.Text = desc[cbQuery.SelectedIndex];
        }

        // don't allow "from" to be greater than "to"
        private void nudUnitPriceFrom_ValueChanged(object sender, EventArgs e)
        {
            if (nudUnitPriceFrom.Value > nudUnitPriceTo.Value)
                nudUnitPriceTo.Value = nudUnitPriceFrom.Value;
        }

        // analyze join query results in C1 FlexPivot
        private void btnFlexPivot_Click(object sender, EventArgs e)
        {
            using (FlexPivotForm f = new FlexPivotForm())
            {
                f.FlexPivot.Workspace = workspace;
                f.FlexPivot.ConnectDataEngine("query_join");
                f.FlexPivot.ViewDefinition = Properties.Resources.JoinView;
                f.ShowDialog(this);
            }
        }

        // executes the selected query
        private void btnExec_Click(object sender, EventArgs e)
        {
            gbQuery.Enabled = false;
            ExecuteQuery();
            gbQuery.Enabled = true;
            btnFlexPivot.Enabled = true;
        }
               
        // executes the selected query
        private void ExecuteQuery()
        {
            tabControl1.SelectedIndex = 3;
            Application.DoEvents();
            DateTime start = DateTime.Now;
            IDataList res = null;
            if (cbQuery.SelectedIndex == 0)
                res = QueryJoin();
            else if (cbQuery.SelectedIndex == 1)
                res = QueryJoinWithFlexPivot();
            else if (cbQuery.SelectedIndex == 2)
                res = QueryProduct();
            else if (cbQuery.SelectedIndex == 3)
                res = QueryUnitPriceRange();
            else if (cbQuery.SelectedIndex == 4)
                res = QueryGroupRange();
            else if (cbQuery.SelectedIndex == 5)
                res = QueryMonth();
            double sec = DateTime.Now.Subtract(start).TotalSeconds;
            lblTime.Text = string.Format("Time: {0:n2} sec.", sec);
            FillGrid(dgvResult, res);
        }

        // products within specified unit price range
        private IDataList QueryUnitPriceRange()
        {
            double from = (double)nudUnitPriceFrom.Value;
            double to = (double)nudUnitPriceTo.Value;

            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qr = workspace.query("query_range", new
            {
                _range = od.UnitPrice.Gte(from).Lte(to), // narrow data to the specified unit price range
                ds = Op.Mul(od.UnitPrice, od.Discount), // calculate the discount for a product in an order
                Price = od.UnitPrice, // group by UnitPrice
                OrdersCount = Op.Count(od.OrderID), // how many times products with the same price were ordered
                MaxDiscount = Op.Max("ds") // what is the maximum discount for products with the same price
            });
            return qr.Query.Execute();
        }

        // discount information for the specified product
        private IDataList QueryProduct()
        {
            int productID = cbProduct.SelectedIndex;
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails table
            dynamic qp = workspace.query("query_product", new
            {
                _range = od.ProductID.Eq(productID), // narrow data to the specified product
                ds = Op.Mul(od.UnitPrice, od.Discount), // calculate the discount for a product in an order
                Product = od.ProductID, // group by product
                Discount = od.Discount, // and group by discount
                OrdersCount = Op.Count(od.OrderID), // order count for products with the same discount in all orders
                DiscountSum = Op.Sum("ds") // total discount for products with the same discount in all orders
            });
            return qp.Query.Execute();
        }

        // product information: how many times it was ordered (from Order Details) and how many items are left in stock (from Products table)
        private IDataList QueryJoin()
        {
            // get tables
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            dynamic pr = workspace.table(Utils.Products.Name);
            // join OrderDetails and Products tables
            dynamic jq = workspace.join("query_join", od, new
            {
                od = od.ProductID + od.OrderID, // get ProductID and OrderID from the OrderDetails table
                pr = pr.UnitsInStock | od.ProductID == pr.ProductID // get UnitsInStock from the Products table and join OrderDetails and Products table on ProductID field
            });
            // aggregate joined data 
            dynamic qjf = workspace.query("query_join_result", new
            {
                Product = jq.ProductID, // group by ProductID
                OrdersCount = Op.Count(jq.OrderID), // order count of a product
                UnitsOnStock = Op.First(jq.UnitsInStock), // how many units of a product left in stock
            });
            return qjf.Query.Execute();
        }

        // join Odrer Details table with Products table by ProductID
        private IDataList QueryJoinWithFlexPivot()
        {
            // get tables
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            dynamic pr = workspace.table(Utils.Products.Name);
            // join OrderDetails and Products tables
            dynamic jq = workspace.join("query_join", od, new
            {
                od = od.ProductID + od.OrderID, // get ProductID and OrderID from the OrderDetails table
                pr = pr.UnitsInStock | od.ProductID == pr.ProductID // get UnitsInStock from the Products table and join OrderDetails and Products table on ProductID field
            });
            jq.Query.Execute();
            return workspace.GetQueryData("query_join", 300); // get the first 300 rows from the query result
        }

        // products that were ordered more than specified number of times
        private IDataList QueryGroupRange()
        {
            // get OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            // aggregate OrderDetails
            dynamic qb = workspace.query("query_group", new
            {
                Product = od.ProductID, // group by ProducID
                OrdersCount = Op.Count(od.OrderID), // order count of that product
                SumPrice = Op.Sum(od.UnitPrice) // price sum of that product
            });
            // filter products by order count
            long from = (long)nudGroupFilter.Value;
            dynamic qg = workspace.query("query_group_range", new 
            {
                _base = "*", // include all columns from the aggregated OrderDetails
                _range = qb.OrdersCount.Gte(from).Lte(long.MaxValue)  // filter products by order count
            });
            return qg.Query.Execute();
        }

        // order information by month
        private IDataList QueryMonth()
        {
            // get Orders table
            dynamic orders = workspace.table(Utils.Orders.Name);
            // create a query from Orders table with additional OrdersMonth column
            dynamic qm = workspace.query("query_date", new
            {
                _base = "*", // all columns from the Orders table
                OrderMonth = Op.DtPart(orders.OrderDate, DateTimeParts.Month) // month from Orders.OrderDate column
            });
            // aggregate query_date data 
            dynamic qdt = workspace.query("query_month", new
            {
                Month = qm.OrderMonth, // group by OrderMonth
                FirstOrderDate = Op.Min(qm.OrderDate), // first order date in that month
                OrderCount = Op.Count(qm.OrderID) // order count in that month
            });
            return qdt.Query.Execute();
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
            else if (grid == dgvProducts)
                lbl = lblProductsRowsTotal;
            else if (grid == dgvOrders)
                lbl = lblOrdersTotalRows;
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
            CheckItemsCount();
            FillGrid(dgvOrderDetails, Utils.OrderDetails.Name, 300);
            FillGrid(dgvProducts, Utils.Products.Name, 300);
            FillGrid(dgvOrders, Utils.Orders.Name, 300);
            RefreshMinMaxUnitPriceRange();
            RefreshProductsList();
        }

        // whether to require generating data
        private void CheckItemsCount()
        {
            IDataList colOd = workspace.GetTableData(Utils.OrderDetails.Name);
            IDataList colProducts = workspace.GetTableData(Utils.Products.Name);
            IDataList colOrders = workspace.GetTableData(Utils.Orders.Name);
            if (colOd != null && colProducts != null && colOrders != null)
                lblItemsCount.Text = string.Format("{0:n0}", colOd.Size);
            else
            {
                lblItemsCount.Text = "0";
                if (string.IsNullOrEmpty(cbItemsCount.Text))
                    cbItemsCount.SelectedIndex = 0;
            }
            bool hasItems = lblItemsCount.Text != "0";
            gbQuery.Enabled = hasItems;
            lblWarning.Visible = !hasItems;
        }

        // updates min and max values of the price range
        private void RefreshMinMaxUnitPriceRange()
        {
            if (workspace.GetTableData(Utils.OrderDetails.Name) == null)
                return;

            // aggregate min and max price in the OrderDetails table
            dynamic od = workspace.table(Utils.OrderDetails.Name);
            dynamic qod = workspace.query("query_order_details", new
            {
                maxPrice = Op.Max(od.UnitPrice),
                minPrice = Op.Min(od.UnitPrice)
            });
            IDataList list = qod.Query.Execute();
            if (list == null || list.Size != 1)
                return;

            // read aggregated values
            var item = list.GetItem(0);
            double max = item.GetDouble(item.GetOrdinal(qod.maxPrice.Name));
            double min = item.GetDouble(item.GetOrdinal(qod.minPrice.Name));

            // set bound values in the controls
            this.nudUnitPriceFrom.ValueChanged -= new System.EventHandler(this.nudUnitPriceFrom_ValueChanged);
            nudUnitPriceFrom.Minimum = (decimal)min;
            nudUnitPriceFrom.Maximum = (decimal)max;
            nudUnitPriceTo.Minimum = (decimal)min;
            nudUnitPriceTo.Maximum = (decimal)max;
            this.nudUnitPriceFrom.ValueChanged += new System.EventHandler(this.nudUnitPriceFrom_ValueChanged);
        }

        // fills product list box with values from the Product table
        private void RefreshProductsList()
        {
            cbProduct.Items.Clear();
            IDataList col = workspace.GetTableData(Utils.Products.Name);
            if (col == null)
                return;

            for (long i = 0; i < col.Size; i++)
                cbProduct.Items.Add(string.Format("Product #{0}", i));
            cbProduct.SelectedIndex = 0;
        }

    }
}
