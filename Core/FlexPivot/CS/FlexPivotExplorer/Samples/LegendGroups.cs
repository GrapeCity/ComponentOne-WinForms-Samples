using System;
using System.Windows.Forms;
using C1.Win.FlexPivot;

namespace FlexPivotExplorer.Samples
{
    public partial class LegendGroups : UserControl
    {
        FlexPivotChart chart;

        public LegendGroups()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var panel = new C1FlexPivotPanel() { Dock = DockStyle.Fill, Visible = false };
            chart = new FlexPivotChart() { Dock = DockStyle.Fill, LegendGroups = true };
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
            tableLayoutPanel1.Controls.Add(chart, 1, 0);
            tableLayoutPanel1.SetRowSpan(chart, 2);

            panel.PivotEngine.BeginUpdate();

            panel.DataSource = DataSource.CreateSampleDataTable(1000);
            panel.PivotEngine.RowFields.Add( "Product");
            panel.PivotEngine.ColumnFields.Add("Region", "Country");
            panel.PivotEngine.ValueFields.Add("Sales");
            chart.DataSource = panel;
            panel.PivotEngine.EndUpdate();

            panel.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart.LegendGroups = checkBox1.Checked;
        }
    }
}
