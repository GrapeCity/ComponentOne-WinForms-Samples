using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.PivotEngine;
using C1.Win.FlexPivot;

namespace ControlExplorer.FlexPivot
{
    public partial class TopN : C1DemoForm
    {
        C1PivotEngine _engine;

        public TopN()
        {
            InitializeComponent();
            // get data
            var dt = DemoDataSource("select * from Invoices", true);

            // bind to data source
            c1FlexPivotPanel1.DataSource = dt;
            c1FlexPivotGrid1.DataSource = c1FlexPivotPanel1;

            // initialize view
            _engine = c1FlexPivotPanel1.PivotEngine;
            _engine.RowFields.Add("ProductName");
            _engine.ColumnFields.Add("Country");
            _engine.ValueFields.Add("Quantity");
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            var filter = _engine.RowFields["ProductName"].Filter;
            if (sender == radioButton1)
                filter.TopN = 0;
            else
            {
                filter.TopN = 3;
                if (sender == radioButton2)
                    filter.TopNRule = TopNRule.TopN;
                else
                    filter.TopNRule = TopNRule.BottomN;
            }
        }
    }
}
