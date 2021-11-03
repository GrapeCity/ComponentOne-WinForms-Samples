using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;

namespace FlexRadarIntro.Samples
{
    public partial class RadarChart : UserControl
    {
        public RadarChart()
        {
            InitializeComponent();
        }

        private void GettingStarted_Load(object sender, EventArgs e)
        {
            flexRadar.BeginUpdate();

            var pts1 = new List<DataItem>();
            var pts2 = new List<DataItem>();

            var rnd = new Random();
            int n = 6;
            for (var i = 0; i < n; i++)
            {
                pts1.Add(new DataItem() { Name = "Item" + i.ToString(), Value = rnd.Next(100) });
                pts2.Add(new DataItem() { Name = "Item" + i.ToString(), Value = rnd.Next(50) });
            }

            flexRadar.Binding = "Value";
            flexRadar.BindingX = "Name";
            flexRadar.DataSource = pts1;
            flexRadar.Series.Add(new Series() { Name = "s1" });
            flexRadar.Series.Add(new Series() { Name = "s2", DataSource = pts2 });

            flexRadar.AxisY.Min = 0;
            flexRadar.AxisY.AxisLine = true;
            flexRadar.AxisY.MajorTickMarks = C1.Chart.TickMark.Cross;

            flexRadar.DataLabel.Content = "{Value}";
            //flexRadar.DataLabel.Position = C1.Chart.LabelPosition.Top;

            flexRadar.EndUpdate();

            comboBoxChartType.DataSource = Enum.GetValues(typeof(RadarChartType));
            comboBoxChartType.SelectedIndex = 0;
            comboBoxChartType.SelectedValueChanged += (s, a) => flexRadar.ChartType = (RadarChartType)comboBoxChartType.SelectedValue;

            comboBoxStacking.DataSource = Enum.GetValues(typeof(Stacking));
            comboBoxStacking.SelectedIndex = 0;
            comboBoxStacking.SelectedValueChanged += (s, a) => flexRadar.Stacking = (Stacking)comboBoxStacking.SelectedValue;

            comboBoxPalette.DataSource = Enum.GetValues(typeof(Palette));
            comboBoxPalette.SelectedIndex = 0;
            comboBoxPalette.SelectedValueChanged += (s, a) => flexRadar.Palette = (Palette)comboBoxPalette.SelectedValue;
        }

        private void checkBoxReversed_CheckedChanged(object sender, EventArgs e)
        {
            flexRadar.Reversed = checkBoxReversed.Checked;
        }

        private void numericUpDownStartingAngle_ValueChanged(object sender, EventArgs e)
        {
            flexRadar.StartAngle = (double)numericUpDownStartingAngle.Value;
        }
    }

    public class DataItem
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
