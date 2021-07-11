using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace ControlExplorer.FlexPivot
{
    public partial class Slicer : C1DemoForm
    {
        const string c_tableName = "Invoices";
        string _dataPath = Path.Combine(Application.StartupPath, "SlicerData");

        public Slicer()
        {
            InitializeComponent();
        }

        private void Slicer_Load(object sender, EventArgs e)
        {
            // set data source
            var dt = DemoDataSource("select * from Invoices", true);
            c1FlexPivotPanel1.DataSource = dt;

            // get FlexPivot engine
            var fp = c1FlexPivotPanel1.FlexPivotEngine;

            // build up view
            fp.ValueFields.Add("ExtendedPrice");
            fp.ColumnFields.Add("ProductName");
            fp.RowFields.Add("Country");

            // set field name
            c1FlexPivotSlicer1.FieldName = "Country";
        }
    }
}
