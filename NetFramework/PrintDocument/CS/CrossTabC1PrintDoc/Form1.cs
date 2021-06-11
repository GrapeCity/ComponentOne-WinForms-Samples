using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

using C1.C1Preview;
using C1.C1Preview.DataBinding;
using C1.Win.C1Preview;

namespace CrossTabC1PrintDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = string.Format("Using C1NWind.mdb at: {0}", GetC1NWindMdbPath());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C1PrintDocument doc = new C1PrintDocument();

            // Add a document header:
            RenderText rtxt = new RenderText("This is a data-bound C1PrintDocument.");
            rtxt.Text += "\rThe RenderTable below is a crosstab, it has product categories in the column headers, years in the row headers, and total amounts of sales for that category and year in the table cells.";
            rtxt.Text += "\rJust to spice things up, sales amounts of $75,000 and above are highlighted.";
            rtxt.Style.FontSize += 2;
            rtxt.Style.FontItalic = true;
            rtxt.Style.Spacing.Bottom = "1cm";
            doc.Body.Children.Add(rtxt);

            // Create data source for data binding the document:
            DataSource ds = new DataSource();
            ds.ConnectionProperties.DataProvider = DataProviderEnum.OLEDB;
            ds.ConnectionProperties.ConnectString = GetConnectionString();
            doc.DataSchema.DataSources.Add(ds);

            // Create Categories data set - this will be used for column headers:
            C1.C1Preview.DataBinding.DataSet dCategories = new C1.C1Preview.DataBinding.DataSet();
            dCategories.Name = "Categories";
            dCategories.Query.DataSource = ds;
            dCategories.Query.CommandText = 
                @"SELECT DISTINCTROW Categories.CategoryID, Categories.CategoryName " +
                 "  FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID " +
                 " ORDER BY Categories.CategoryName";
            doc.DataSchema.DataSets.Add(dCategories);

            // Create Years data set - this will be used for row headers:
            C1.C1Preview.DataBinding.DataSet dYears = new C1.C1Preview.DataBinding.DataSet();
            dYears.Query.DataSource = ds;
            dYears.Name = "Years";
            dYears.Query.CommandText =
                @"SELECT DISTINCT Year(OrderDate) as Y " +
                 " FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID " +
                 " ORDER BY 1";
            doc.DataSchema.DataSets.Add(dYears);

            // Create a RenderTable that will have categories in column headers,
            // years in row headers, and total order amounts (sums) in cells:
            RenderTable rt = new RenderTable();
            rt.Style.GridLines.All = LineDef.Default;
            // Bind row 0 to dYears data source - this will create a row for each year:
            rt.RowGroups[1, 1].DataBinding.DataSource = dYears;
            // Bind column 0 to dCategories data source - this will create a column for each category:
            rt.ColGroups[1, 1].DataBinding.DataSource = dCategories;
            // Set up cells in row 0 and column 0 (data-bound) to show category and year:
            rt.Cells[0, 1].Text = "[Fields!CategoryName.Value]";
            rt.Cells[1, 0].Text = "[Fields!Y.Value]";
            // To show just plain text:
            // rt.Cells[1, 1].Text = "[Document.UserData.CalcSum(ColFields!CategoryID.Value, RowFields!Y.Value)]";
            // ...but we really want it formatted as currency:
            rt.Cells[1, 1].Text = "[string.Format(\"{0:C}\",Document.UserData.CalcSum(ColFields!CategoryID.Value, RowFields!Y.Value))]";
            // Highlight cells with totals above $75,000:
            rt.Cells[1, 1].Style.BackColorExpr = "iif(Document.UserData.CalcSum(ColFields!CategoryID.Value, RowFields!Y.Value)>75000, Color.Yellow, Color.Transparent)";
            // Add the table to the document:
            doc.Body.Children.Add(rt);

            // Create the "summary calculator" and assign it to UserData on the document -
            // this will be available to scripting and used by rt.Cells[1,1].Text expression above:
            doc.UserData = new AggCalc();

            //*** Functionaly, we're done, code below just adds some visual niceties ***

            // Adjust visual properties of the table:
            // auto-size columns, allow table to split horizontally:
            rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            rt.Width = "auto";
            rt.ColumnSizingMode = TableSizingModeEnum.Auto;
            // Set up repeating row and column headers:
            rt.RowGroups[0, 1].Header = TableHeaderEnum.All;
            rt.ColGroups[0, 1].Header = TableHeaderEnum.All;
            rt.RowGroups[0, 1].Style.BackColor = Color.Cornsilk;
            rt.ColGroups[0, 1].Style.BackColor = Color.Cornsilk;
            // Right-align sums:
            rt.Cells[1, 1].Style.TextAlignHorz = AlignHorzEnum.Right;
            // Add some padding:
            rt.CellStyle.Padding.All = "1mm";

            // Done, show the document:
            using (C1PrintPreviewDialog d = new C1PrintPreviewDialog())
            {
                d.Document = doc;
                d.ShowDialog();
            }
        }

        /// <summary>
        /// Gets full path to C1NWind.mdb sample data file.
        /// </summary>
        /// <returns></returns>
        public static string GetC1NWindMdbPath()
        {
            const string mdbName = "c1nwind.mdb";
            string mdbPath = string.Format(@"{0}\ComponentOne Samples\Common\{1}",
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                mdbName);
            if (!System.IO.File.Exists(mdbPath))
                throw new Exception(string.Format("Cannot find {0}", mdbName));
            return mdbPath;
        }

        public static string GetConnectionString()
        {
            return string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", GetC1NWindMdbPath());
        }
    }

    /// <summary>
    /// Creates and holds a DataTable that has 3 columns:
    /// - "CategoryID";
    /// - Year ("Y");
    /// - Sum ("S") (sum of order amounts for the year).
    /// The table is filled once when the instance of AggCalc is created
    /// at the same time as the document, and stored in C1PrintDocument.UserData.
    /// When the document generates, the CalcSum function is called from the cells
    /// of the pivot table with categoryId and year associated with that cell,
    /// and the sum for the requested category and year is returned and used
    /// as the value (text) of the cell.
    /// </summary>
    public class AggCalc
    {
        private DataTable _table;

        #region Private
        private void OpenTable()
        {
            if (_table != null)
                return;

            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = Form1.GetConnectionString();
            OleDbCommand com = con.CreateCommand();
            com.CommandText = 
                "SELECT DISTINCT Categories.CategoryID, Year(Orders.[OrderDate]) as Y, Sum([Order Details Extended].ExtendedPrice) AS S " +
                "  FROM Categories INNER JOIN (Products INNER JOIN (Orders INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID) ON Products.ProductID = [Order Details Extended].ProductID) ON Categories.CategoryID = Products.CategoryID " +
                "GROUP BY Categories.CategoryID, Year(Orders.[OrderDate])";
            OleDbDataAdapter adapter = new OleDbDataAdapter(com);
            _table = new DataTable();
            adapter.Fill(_table);
        }
        #endregion

        #region Public
        public object CalcSum(string categoryId, int year)
        {
            if (_table == null)
                OpenTable();
            DataRow[] rows = _table.Select(string.Format("CategoryID = {0} and y = {1}", categoryId, year));
            if (rows.Length != 1)
                return 0;
            else
                return rows[0]["S"];
        }
        #endregion
    }
}
