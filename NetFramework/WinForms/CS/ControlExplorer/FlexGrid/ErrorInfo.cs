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
    public partial class ErrorInfo : C1DemoForm
    {
        public ErrorInfo()
        {
            InitializeComponent();
        }

        void ErrorInfo_Load(object sender, System.EventArgs e)
        {
            // load some data from db
            var sql = "select * from products";
            var conn = DemoConnectionString;
            var da = new OleDbDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);

            // add some errors to the table
            foreach (DataRow dr in dt.Rows)
            {
                // specific cells
                if ((int)dr["SupplierID"] == 4)
                    dr.SetColumnError("SupplierID", "Supplier 4 is no longer active.\r\nHe retired and moved to Tahiti.");
                if ((int)dr["CategoryID"] == 7)
                    dr.SetColumnError("CategoryID", "Category 7 has been deprecated.\r\nWe're moving out of the tobacco business.");

                // entire rows
                if ((int)dr["ProductID"] == 7)
                    dr.RowError = "This is product 7. That's bad luck.";
                if ((int)dr["ProductID"] == 13)
                    dr.RowError = "This is row 13. Even worse luck!!!\r\nPehaps you should leave it empty.";
            }

            // bind to grid
            flexGrid.DataSource = dt;

            // make sure grid shows the errors
            flexGrid.ShowErrors = true;

            // make the grid look nice
            flexGrid.ShowCursor = true;
            flexGrid.Cols[0].Width = 15;
        }

        // provide custom error information in addition to the IDataErrorInfo stuff
        void _flex_GetCellErrorInfo(object sender, C1.Win.C1FlexGrid.GetErrorInfoEventArgs e)
        {
            if (flexGrid.Cols[e.Col].Name == "UnitPrice")
            {
                if ((decimal)flexGrid[e.Row, e.Col] > 100)
                {
                    string fmt = "This product has a high unit price ({0:c}),\r\n" +
                        "call supplier {1} and negotiate a discount.";
                    e.ErrorText = string.Format(fmt, flexGrid[e.Row, e.Col], flexGrid[e.Row, "SupplierID"]);
                }
            }
        }
        void _flex_GetRowErrorInfo(object sender, C1.Win.C1FlexGrid.GetErrorInfoEventArgs e)
        {
            if (object.Equals(flexGrid[e.Row, "Discontinued"], true))
            {
                e.ErrorText = "Please check that this product\r\nhas really been discontinued.";
            }
        }
    }
}
