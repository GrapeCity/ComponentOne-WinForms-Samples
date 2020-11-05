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
    public partial class BasicFeatures : UserControl
    {
        public BasicFeatures()
        {
            InitializeComponent();
        }

        private void BasicFeatures_Load(object sender, EventArgs e)
        {
            comboBoxPalette.DataSource = Enum.GetNames(typeof(C1.Chart.Palette));
            comboBoxPalette.SelectedIndex = 0;
            comboBoxLabelPos.DataSource = Enum.GetNames(typeof(C1.Chart.PieLabelPosition));
            comboBoxLabelPos.SelectedIndex = 0;
            comboBoxLabelOverlap.DataSource = Enum.GetNames(typeof(C1.Chart.PieLabelOverlapping));
            comboBoxLabelOverlap.SelectedIndex = 0;

            sunburst.BeginUpdate();
            sunburst.DataSource = DataService.CreateHierarchicalData();
            sunburst.Binding = "Value";
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.ChildItemsPath = "Items";
            sunburst.ToolTip.Content = "{name}\n{y}";
            sunburst.DataLabel.Content = "{name}={y}";
            sunburst.EndUpdate();
        }

        private void numericUpDownInnerRadius_ValueChanged(object sender, EventArgs e)
        {
            sunburst.InnerRadius = (double)numericUpDownInnerRadius.Value;
        }

        private void numericUpDownOffset_ValueChanged(object sender, EventArgs e)
        {
            sunburst.Offset = (double)numericUpDownOffset.Value;
        }

        private void numericUpDownStartAngle_ValueChanged(object sender, EventArgs e)
        {
            sunburst.StartAngle = (double)numericUpDownStartAngle.Value;
        }

        private void checkBoxReversed_CheckedChanged(object sender, EventArgs e)
        {
            sunburst.Reversed = checkBoxReversed.Checked;
        }

        private void comboBoxPalette_SelectedIndexChanged(object sender, EventArgs e)
        {
            sunburst.Palette = (C1.Chart.Palette)Enum.Parse(typeof(C1.Chart.Palette), (string)comboBoxPalette.SelectedItem);
        }

        private void comboBoxLabelPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            sunburst.DataLabel.Position = (C1.Chart.PieLabelPosition)Enum.Parse(typeof(C1.Chart.PieLabelPosition), (string)comboBoxLabelPos.SelectedItem);
        }

        private void comboBoxLabelOverlap_SelectedIndexChanged(object sender, EventArgs e)
        {
            sunburst.DataLabel.Overlapping = (C1.Chart.PieLabelOverlapping)Enum.Parse(typeof(C1.Chart.PieLabelOverlapping), (string)comboBoxLabelOverlap.SelectedItem);
        }
    }
}
