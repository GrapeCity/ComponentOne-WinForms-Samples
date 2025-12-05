using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace FindRowRegEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // populate grid
            var da = new OleDbDataAdapter("select * from invoices", GetConnectionString());
            var dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;
            _flex.AutoSizeCols();
        }

        static string GetConnectionString()
        {
            // get connection to nwind
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        void _btnFind_Click(object sender, EventArgs e)
        {
            // use the regular FindRow
            var index = this._flex.FindRow(_txtSearch.Text, 1, _flex.Col, false, true, true);
            if (index > -1)
            {
                this._flex.Row = index;
            }
        }
        void _btnFindRx_Click(object sender, EventArgs e)
        {
            // use the new FindRowRegex (requires build 532 or later)
            var index = this._flex.FindRowRegex(_txtSearch.Text, 1, _flex.Col, true);

            // use local implementation with older versions of the grid
            //var index = FindRowRegex(_flex, _txtSearch.Text, 1, _flex.Col, true);

            // if we found a row, select it
            if (index > -1)
            {
                this._flex.Row = index;
            }
        }

        // not needed with builds after 532...
        int FindRowRegex(C1FlexGridBase grid, string pattern, int rowStart, int col, bool wrap)
        {
            // null? found (allow searching for empty strings though)
            if (pattern == null)
                return rowStart;

            // search for the string
            for (int row = rowStart; row < grid.Rows.Count; row++)
            {
                var str = grid.GetDataDisplay(row, col);
                if (str != null && Regex.IsMatch(str, pattern))
                    return row;
            }

            // not found, wrap from top
            if (wrap)
            {
                for (int row = grid.Rows.Fixed; row < rowStart; row++)
                {
                    var str = grid.GetDataDisplay(row, col);
                    if (str != null && Regex.IsMatch(str, pattern))
                        return row;
                }
            }

            // not found
            return -1;
        }
    }
}
