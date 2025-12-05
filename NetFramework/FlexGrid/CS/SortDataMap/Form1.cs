using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SortDataMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // load data into some tables
            var dtProducts = GetDataTable("Products");
            var dtCategories = GetDataTable("Categories");
            var dtSuppliers = GetDataTable("Suppliers");

            // create two data maps
            var mapCat = new Dictionary<int, string>();
            foreach (DataRow row in dtCategories.Rows)
            {
                var key = (int)row["CategoryID"];
                var val = (string)row["CategoryName"];
                mapCat[key] = val;
            }

            var mapSup = new Dictionary<int, string>();
            foreach (DataRow row in dtSuppliers.Rows)
            {
                var key = (int)row["SupplierID"];
                var val = (string)row["CompanyName"];
                mapSup[key] = val;
            }

            // bind grid
            _flex.DataSource = dtProducts;

            // add data maps
            _flex.Cols["CategoryID"].DataMap = mapCat;
            _flex.Cols["SupplierID"].DataMap = mapSup;

            // add custom sorting support (sort on mapped values rather than raw)
            _flex.BeforeSort += _flex_BeforeSort;
            _flex.AfterEdit += _flex_AfterEdit;
        }

        // name of the hidden column used to perform the actual sorting
        const string SORT_COL_NAME = "_dtSort";

        // column being used as a source for the hidden source column
        C1.Win.FlexGrid.Column _sourceColumn;

        // apply custom sort (use mapped values instead of raw)
        void _flex_BeforeSort(object sender, C1.Win.FlexGrid.SortColEventArgs e)
        {
            // if the column contains a data map
            _sourceColumn = _flex.Cols[e.Col];
            if (_sourceColumn.DataMap != null)
            {
                // add a hidden column just for sorting
                var dt = _flex.DataSource as DataTable;
                if (!dt.Columns.Contains(SORT_COL_NAME))
                {
                    var dcol = dt.Columns.Add(SORT_COL_NAME);
                    _flex.Cols[SORT_COL_NAME].Visible = false;
                }

                // remove current sort (if any)
                dt.DefaultView.Sort = string.Empty;

                // populate the sort column
                foreach (DataRow dr in dt.Rows)
                {
                    var key = dr[_sourceColumn.Name];
                    dr[SORT_COL_NAME] = _sourceColumn.DataMap[key];
                }

                // apply the new sort
                var sort = SORT_COL_NAME;
                if ((e.Order & C1.Win.FlexGrid.SortFlags.Descending) != 0)
                {
                    sort += " DESC";
                }
                dt.DefaultView.Sort = sort;

                // handled
                e.Handled = true;
            }
        }

        // update sort when user edits the sorted column
        void _flex_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            // if the user edited the column being sorted on
            if (_flex.Cols[e.Col] == _sourceColumn)
            {
                // refresh the content of the sort column
                var dt = _flex.DataSource as DataTable;
                foreach (DataRow dr in dt.Rows)
                {
                    var key = dr[_sourceColumn.Name];
                    dr[SORT_COL_NAME] = _sourceColumn.DataMap[key];
                }
            }
        }

        static DataTable GetDataTable(string name)
        {
            var dt = new DataTable(name);
            var da = new OleDbDataAdapter("select * from " + name , GetConnectionString());
            da.Fill(dt);
            return dt;
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
