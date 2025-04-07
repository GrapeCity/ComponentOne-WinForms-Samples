using FlexGridExplorer.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class ErrorInfo : UserControl
    {
        public ErrorInfo()
        {
            InitializeComponent();
        }

        void ErrorInfo_Load(object sender, System.EventArgs e)
        {
            // load some data from db
            var dt = DataSource.GetRows("select * from products");
            ConvertDiscontinuedColumn(dt);
            // add some errors to the table
            foreach (DataRow dr in dt.Rows)
            {
                // specific cells
                if (Convert.ToInt32(dr["SupplierID"]) == 4)
                    dr.SetColumnError("SupplierID", "Supplier 4 is no longer active.\r\nHe retired and moved to Tahiti.");
                if (Convert.ToInt32(dr["CategoryID"]) == 7)
                    dr.SetColumnError("CategoryID", "Category 7 has been deprecated.\r\nWe're moving out of the tobacco business.");

                // entire rows
                if (Convert.ToInt32(dr["ProductID"]) == 7)
                    dr.RowError = "This is product 7. That's bad luck.";
                if (Convert.ToInt32(dr["ProductID"]) == 13)
                    dr.RowError = "This is row 13. Even worse luck!!!\r\nPerhaps you should leave it empty.";
            }
            // bind to grid
            flexGrid.DataSource = dt;
            // make sure grid shows the errors
            flexGrid.ShowErrors = true;

            // make the grid look nice
            flexGrid.ShowCursor = true;
        }

        void ConvertDiscontinuedColumn(DataTable dt)
        {
            if (!dt.Columns.Contains("Discontinued"))
                return;

            // Create a new boolean column
            dt.Columns.Add("DiscontinuedBool", typeof(bool));

            // Copy values from the old column (0 -> false, 1 -> true)
            foreach (DataRow row in dt.Rows)
            {
                row["DiscontinuedBool"] = Convert.ToInt32(row["Discontinued"]) == 1;
            }

            // Remove the old column and rename the new column
            dt.Columns.Remove("Discontinued");
            dt.Columns["DiscontinuedBool"].ColumnName = "Discontinued";
        }

        // provide custom error information in addition to the IDataErrorInfo stuff
        void _flex_GetCellErrorInfo(object sender, C1.Win.FlexGrid.GetErrorInfoEventArgs e)
        {
            if (flexGrid.Cols[e.Col].Name == "UnitPrice")
            {
                if (Convert.ToDecimal(flexGrid[e.Row, e.Col]) > 100)
                {
                    string fmt = "This product has a high unit price ({0:c}),\r\n" +
                        "call supplier {1} and negotiate a discount.";
                    e.ErrorText = string.Format(fmt, flexGrid[e.Row, e.Col], flexGrid[e.Row, "SupplierID"]);
                }
            }
        }
        void _flex_GetRowErrorInfo(object sender, C1.Win.FlexGrid.GetErrorInfoEventArgs e)
        {
            if (object.Equals(flexGrid[e.Row, "Discontinued"], true))
            {
                e.ErrorText = "Please check that this product\r\nhas really been discontinued.";
            }
        }
    }
}