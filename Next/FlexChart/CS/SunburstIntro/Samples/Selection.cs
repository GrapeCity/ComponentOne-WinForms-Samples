using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart;

using SunburstIntro.Services;

namespace SunburstIntro.Samples
{
    public partial class Selection : UserControl
    {
        public Selection()
        {
            InitializeComponent();
        }

        private void Selection_Load(object sender, EventArgs e)
        {
            comboBoxPosition.DataSource = Enum.GetNames(typeof(C1.Chart.Position));
            comboBoxPosition.SelectedIndex = 0;

            sunburst.BeginUpdate();
            sunburst.DataSource = DataService.CreateHierarchicalData();
            sunburst.Binding = "Value";
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.ChildItemsPath = "Items";
            sunburst.SelectionMode = C1.Chart.ChartSelectionMode.Point;
            sunburst.SelectionStyle.Stroke = Brushes.Red;
            sunburst.SelectionStyle.StrokeDashPattern = new float[] { 5, 5 };
            sunburst.ToolTip.Content = "{name}={value}";
            sunburst.EndUpdate();
        }

        private void numericUpDownSelectedItemOffset_ValueChanged(object sender, EventArgs e)
        {
            sunburst.SelectedItemOffset = (double)numericUpDownSelectedItemOffset.Value;
        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            sunburst.SelectedItemPosition = (C1.Chart.Position)Enum.Parse(typeof(C1.Chart.Position), (string)comboBoxPosition.SelectedValue);
        }
    }
}
