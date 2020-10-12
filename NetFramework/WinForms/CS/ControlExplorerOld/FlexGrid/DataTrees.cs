using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class DataTrees : C1DemoForm
    {
        public DataTrees()
        {
            InitializeComponent();
        }

        // ** fields
        DataSet _ds = new DataSet();

        // load table into DataSet
        //private void FillTable(DataSet ds, string tableName, string conn)
        //{
        //    tableName = tableName.Trim();
        //    string sql = string.Format("select * from [{0}]", tableName);
        //    OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
        //    da.Fill(ds, tableName);
        //}

        // build a data map
        private IDictionary BuildDataMap(string table, string key, string value)
        {
            ListDictionary ld = new ListDictionary();
            foreach (DataRow dr in _ds.Tables[table].Rows)
                ld.Add(dr[key], dr[value]);
            return ld;
        }

        // customize grid display to show selected columns, captions, formats, and data maps
        private void _flex_SetupColumns(object sender, System.EventArgs e)
        {
            // get grid that was just bound
            C1FlexDataTree grid = sender as C1FlexDataTree;
            if (grid == null) return;

            // get data source name
            ITypedList itl = grid.DataSource as ITypedList;
            if (itl == null) return;
            string tableName = itl.GetListName(null);

            // look up table in data set 
            // (the table has formatting information in its ExtendedProperties)
            DataTable dt = _ds.Tables[tableName];

            // apply custom column order, captions, format
            string[] columns = dt.ExtendedProperties["ShowColumns"] as string[];
            if (columns != null)
                SetupColumns(grid, columns);

            // apply custom data maps
            foreach (Column gridColumn in grid.Cols)
            {
                DataColumn dataColumn = dt.Columns[gridColumn.Name];
                if (dataColumn == null) continue;
                gridColumn.DataMap = dataColumn.ExtendedProperties["DataMap"] as IDictionary;
                if (gridColumn.DataMap != null)
                    gridColumn.TextAlign = TextAlignEnum.LeftCenter;
            }

            // all done, auto size to show mapped data
            grid.AutoSizeCols(1, grid.Cols.Count - 1, 12);
        }

        // apply column information to a grid
        // this will set the column positions, caption, format, and visibility
        // (any columns not included in the 'columns' array will not be displayed
        private void SetupColumns(C1FlexDataTree grid, string[] columns)
        {
            // initialize column position
            int position = grid.Cols.Fixed;

            // apply column information
            foreach (string s in columns)
            {
                // split column info (name, caption, format)
                string[] columnInfo = s.Split(',');

                // move column to proper position based on its name
                Column column = grid.Cols[columnInfo[0].Trim()];
                column.Move(position);
                position++;

                // apply caption
                if (columnInfo.Length > 1)
                    column.Caption = columnInfo[1].Trim();

                // apply format
                if (columnInfo.Length > 2)
                    column.Format = columnInfo[2].Trim();
            }

            // hide all other columns
            for (int i = position; i < grid.Cols.Count; i++)
                grid.Cols[i].Visible = false;
        }

        private void DataTrees_Load(object sender, EventArgs e)
        { 
            _flex.Styles.Alternate.BackColor = ProfessionalColors.ToolStripGradientMiddle;

            // initialize db connection variables
            string conn = DemoConnectionString;

            // load some tables
            string[] tables = "Customers, Orders, Order Details, Products, Employees, Shippers".Split(',');
            foreach (string tableName in tables)
            {
                FillTable(_ds, tableName, conn);
            }

            // set up some relations
            _ds.Relations.Add("Customers_Orders",
                _ds.Tables["Customers"].Columns["CustomerID"],
                _ds.Tables["Orders"].Columns["CustomerID"]);

            _ds.Relations.Add("Orders_OrderDetails",
                _ds.Tables["Orders"].Columns["OrderID"],
                _ds.Tables["Order Details"].Columns["OrderID"]);

            // build display parameters for "Orders" table
            //
            // the parameters consist of a string array containing column names,
            // captions, and formats (applied to the table), as well as data maps 
            // bound to columns to show data other than raw IDs (e.g. product name 
            // instead of productID).
            //
            // we attach this info to the tables and columns as ExtendedProperties 
            // so the child grids can pick it up in the SetupColumns event.
            //
            // note that most of this work can be done at design time using the 
            // grid's Column Editor, but in this case we use code because all the
            // binding is done at run time.
            //
            DataTable dt = _ds.Tables["Orders"];
            dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "OrderID",
																	  "EmployeeID, Employee",
																	  "OrderDate, Order Date",
																	  "RequiredDate, Required Date",
																	  "ShippedDate, Shipped Date",
																	  "ShipVia, Ship Via",
																	  "Freight, Freight, c"
																  });
            dt.Columns["EmployeeID"].ExtendedProperties.Add("DataMap",
                BuildDataMap("Employees", "EmployeeID", "LastName"));
            dt.Columns["ShipVia"].ExtendedProperties.Add("DataMap",
                BuildDataMap("Shippers", "ShipperID", "CompanyName"));

            // build display parameters for "Order Details" table
            //
            dt = _ds.Tables["Order Details"];
            dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "ProductID, Product",
																	  "UnitPrice, Unit Price, c",
																	  "Quantity, Qty, 0.00",
																	  "Discount, Discount, c"
																  });
            dt.Columns["ProductID"].ExtendedProperties.Add("DataMap",
                BuildDataMap("Products", "ProductID", "ProductName"));

            // add a calculated column to Customers table so we can see the number of orders for each customer
            //
            dt = _ds.Tables["Customers"];
            DataColumn col = dt.Columns.Add("OrderCount", typeof(int), "Count(Child.OrderID)");

            // re-arrange the columns on the customer table
            //
            dt.ExtendedProperties.Add("ShowColumns", new string[] {
																	  "CustomerID, Customer",
																	  "OrderCount, Orders",
																	  "CompanyName, Company",
																	  "ContactName, Contact",
																	  "Phone",
																	  "City",
																	  "Region",
																	  "Country",
			});

            // show customers to begin with
            _flex.SetDataBinding(_ds, "Customers");
        }

        // load table into DataSet
        void FillTable(DataSet ds, string tableName, string conn)
        {
            tableName = tableName.Trim();
            string sql = string.Format("select * from [{0}]", tableName);
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            da.Fill(ds, tableName);
        }
    }
}
