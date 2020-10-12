using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.FlexPivot;
using C1.Win.FlexPivot;

namespace ControlExplorer.FlexPivot
{
    public partial class TopN : C1DemoForm
    {
        C1FlexPivotEngine _engine;

        public TopN()
        {
            InitializeComponent();
            // get data
            var dt = DemoDataSource("select * from Invoices", true);

            // bind to data source
            var panel = new C1FlexPivotPanel();
            panel.DataSource = dt;
            c1FlexPivotGrid1.DataSource = panel;

            // initialize view
            _engine = panel.FlexPivotEngine;
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
