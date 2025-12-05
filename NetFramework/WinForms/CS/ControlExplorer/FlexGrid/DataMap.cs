using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class DataMap : C1DemoForm
    {
        private DataSet _dataSet = new DataSet();

        public DataMap()
        {
            InitializeComponent();
        }

        private void DataMap_Load(object sender, EventArgs e)
        {
            FillDataSet();
            SetupGrid();
        }

        private void FillDataSet()
        {
            var conn = DemoConnectionString;

            _dataSet.Tables.Add("Products");
            _dataSet.Tables.Add("Categories");

            // set up SQL statement
            var rs = "SELECT CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, Reorder" +
            "Level, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products";

            // retrieve data into DataSet
            var da = new OleDbDataAdapter(rs, conn);
            da.Fill(_dataSet, "Products");

            // set up SQL statement
            rs = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories";

            // retrieve data into DataSet
            da = new OleDbDataAdapter(rs, conn);
            da.Fill(_dataSet, "Categories");
        }

        private void SetupGrid()
        {
            var d = new Dictionary<int, string>();
            var dt = _dataSet.Tables["Categories"];

            // build data mapping for CategoryID->CategoryName
            foreach (DataRow dr in dt.Rows)
            {
                d.Add(Convert.ToInt32(dr["CategoryID"]), dr["CategoryName"].ToString());
            }

            // assign data source to grid
            flexGrid.DataSource = _dataSet.Tables["Products"];

            // assign data map to CategoryID column
            // after setting the data source 
            var c = flexGrid.Cols["CategoryID"];
            c.DataMap = d;
            c.TextAlign = TextAlignEnum.LeftTop;
        }
    }
}