using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CustomColumns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // get data
            var da = new OleDbDataAdapter(Properties.Resources.sql, GetConnectionString());
            var dt = new DataTable("NorthWind Sales Data");
            da.Fill(dt);

            // assign data to C1FlexPivotPage control
            _c1FlexPivotPage.DataSource = dt;

            var fp = _c1FlexPivotPage.PivotEngine;
            fp.ValueFields.MaxItems = 3;
            fp.Updated += FlexPivot_Updated;
            fp.BeginUpdate();
            fp.RowFields.Add("Country");
            fp.ColumnFields.Add("Product");
            fp.ValueFields.Add("Sales");
            fp.EndUpdate();
        }

        // add custom columns after every FlexPivot update
        void FlexPivot_Updated(object sender, EventArgs e)
        {
            if (_chkCustomColumns.Checked)
            {
                // add a new calculated column to the output table
                var fp = _c1FlexPivotPage.PivotEngine;
                var dt = fp.PivotTable;
                if (dt.Columns.Count >= 2)
                {
                    // [column 0] - [column 1]
                    dt.Columns.Add("Diff", typeof(double),
                        string.Format("[{0}] - [{1}]",
                            dt.Columns[1].ColumnName, dt.Columns[0].ColumnName));

                    // [column 0] * [column 1]
                    dt.Columns.Add("Prod", typeof(double),
                        string.Format("[{0}] * [{1}]",
                            dt.Columns[1].ColumnName, dt.Columns[0].ColumnName));

                    // format the new columns on the grid
                    var cols = _c1FlexPivotPage.FlexPivotGrid.Cols;
                    for (int i = 0; i < 2; i++)
                    {
                        var col = cols[cols.Count - 1 - i];
                        col.Format = "n2";
                        col.TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                    }
                }
            }
        }

        // refresh FlexPivot output to reflect new setting
        void _chkCustomColumns_CheckedChanged(object sender, EventArgs e)
        {
            _c1FlexPivotPage.PivotEngine.Update();
        }

        // get standard nwind mdb connection string
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
