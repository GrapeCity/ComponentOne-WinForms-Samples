using System;
using System.Windows.Forms;
using C1.Win.FlexPivot;

namespace FlexPivotExplorer.Samples
{
    public partial class HierarchicalAxes : UserControl
    {
        FlexPivotChart chart;

        public HierarchicalAxes()
        {
            InitializeComponent();
        }

        private void HierarchicalAxes_Load(object sender, EventArgs e)
        {
            var panel = new C1FlexPivotPanel() { Dock = DockStyle.Fill };

            chart = new FlexPivotChart() { Dock = DockStyle.Fill };
           
            panel.DataSource = DataSource.CreateSampleDataTable(1000);
            panel.PivotEngine.RowFields.Add("Region", "Country", "Product");
            panel.PivotEngine.ValueFields.Add("Sales");

            chart.DataSource = panel;
            
            chart.ShowHierarchicalAxes = true;
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
            tableLayoutPanel1.Controls.Add(chart, 1, 0);
            tableLayoutPanel1.SetRowSpan(chart, 2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart.ShowHierarchicalAxes = checkBox1.Checked;
        }
    }
}
