using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilterMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get the data
            var da = new OleDbDataAdapter("select * from customers", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);

            // bind to grid
            _flex.DataSource = dt;

            // enable filtering
            _flex.AllowFiltering = true;

            // populate edit filter menu
            _mnuEditFilters.DropDownItemClicked += _mnuEditFilters_DropDownItemClicked;
            foreach (DataColumn dc in dt.Columns)
            {
                _mnuEditFilters.DropDownItems.Add(dc.ColumnName);
            }

            // clear filter menu is populated when it opens
            _mnuClearFilters.DropDownOpening += _mnuClearFilters_DropDownOpening;
            _mnuClearFilters.DropDownItemClicked += _mnuClearFilters_DropDownItemClicked;
        }

        // allow clearing filters that are currently set
        void _mnuClearFilters_DropDownOpening(object sender, EventArgs e)
        {
            _mnuClearFilters.DropDownItems.Clear();
            for (int i = _flex.Cols.Fixed; i < _flex.Cols.Count; i++)
            {
                var col = _flex.Cols[i];
                if (col.ActiveFilter != null)
                {
                    _mnuClearFilters.DropDownItems.Add(col.Name);
                }
            }
        }

        // clear the filter for a given column
        void _mnuClearFilters_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var col = _flex.Cols[e.ClickedItem.Text];
            var colIndex = col.Index;

            // highlight the column
            _flex.Select(_flex.Rows.Fixed, colIndex, _flex.Rows.Count - 1, colIndex, true);

            // clear the filter
            _flex.ClearFilter(colIndex);
        }

        // edit the filter for a column
        void _mnuEditFilters_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var col = _flex.Cols[e.ClickedItem.Text];
            var colIndex = col.Index;

            // highlight the column
            _flex.Select(_flex.Rows.Fixed, colIndex, _flex.Rows.Count - 1, colIndex, true);

            // edit the filter
            _flex.EditFilter(colIndex);
        }

        // get the connection string for the sample database
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
