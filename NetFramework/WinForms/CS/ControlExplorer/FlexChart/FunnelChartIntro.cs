using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;

namespace ControlExplorer.FlexChart
{
    public partial class FunnelChartIntro : C1DemoForm
    {
        public FunnelChartIntro()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();
            var data = new[]{
                new { Name = "US", Value = 10000 },
                new { Name = "Germany", Value = 9594 },
                new { Name = "UK", Value = 8692 },
                new { Name = "Japan", Value = 7488 },
                new { Name = "Italy", Value = 5662 },
                new { Name = "Greece", Value = 5329 }
            };

            // Add 3 data series
            var s1 = new Series();
            s1.Binding = s1.Name = "Value";
            flexChart1.Series.Add(s1);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Name";
            flexChart1.DataSource = data;
            flexChart1.DataLabel.Content = "{}{y}";
            flexChart1.DataLabel.Position = LabelPosition.Center;

            flexChart1.EndUpdate();
        }
        private void nudNeckWidth_ValueChanged(object sender, EventArgs e)
        {
            flexChart1.Options.FunnelNeckWidth = (double)nudNeckWidth.Value;
        }

        private void nudNeckHeight_ValueChanged(object sender, EventArgs e)
        {
            flexChart1.Options.FunnelNeckHeight = (double)nudNeckHeight.Value;
        }

        private void cbFunnelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.Options.FunnelType = (C1.Chart.FunnelChartType)Enum.Parse(typeof(C1.Chart.FunnelChartType),
                cbFunnelType.SelectedItem as string);
        }

        private void InitializeControls()
        {
            flexChart1.ChartType = ChartType.Funnel;

            // Initialize FunnelNeckWidth
            nudNeckWidth = new NumericUpDown()
            {
                Size = new Size(150, 21),
                ForeColor = Color.DimGray,
                Minimum = 0,
                Maximum = 1,
                DecimalPlaces = 1,
                Increment = 0.1m,
                Value = 0.2m
            };
            nudNeckWidth.ValueChanged += nudNeckWidth_ValueChanged;

            // Initialize FunnelNeckHeight
            nudNeckHeight = new NumericUpDown()
            {
                Size = new Size(150, 21),
                ForeColor = Color.DimGray,
                Minimum = 0,
                Maximum = 1,
                DecimalPlaces = 1,
                Increment = 0.1m,
                Value = 0.2m
            };
            nudNeckHeight.ValueChanged += nudNeckHeight_ValueChanged;

            // Initialize FunnelType combo box
            cbFunnelType = new ComboBox()
            {
                Size = new Size(150, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbFunnelType.SelectedIndexChanged += cbFunnelType_SelectedIndexChanged;

            int startTop = 2;
            int labWidth = 80;
            int labHeight = 21;

            this.Controls.Add(new Label()
            {
                Text = "Neck Width:",
                Top = startTop,
                Width = labWidth,
                Height = labHeight,
                TextAlign = ContentAlignment.MiddleLeft
            });
            this.Controls.Add(nudNeckWidth);
            nudNeckWidth.Top = startTop;
            nudNeckWidth.Left = labWidth + 10;

            startTop += labHeight + 2;
            this.Controls.Add(new Label()
            {
                Text = "Neck Height:",
                Top = startTop,
                Width = labWidth,
                Height = labHeight,
                TextAlign = ContentAlignment.MiddleLeft
            });
            this.Controls.Add(nudNeckHeight);
            nudNeckHeight.Top = startTop;
            nudNeckHeight.Left = labWidth + 10;

            startTop += labHeight + 2;
            this.Controls.Add(new Label()
            {
                Text = "Funnel Type:",
                Top = startTop,
                Width = labWidth,
                Height = labHeight,
                TextAlign = ContentAlignment.MiddleLeft
            });
            this.Controls.Add(cbFunnelType);
            cbFunnelType.Top = startTop;
            cbFunnelType.Left = labWidth + 10;

            startTop += labHeight + 5;
            flexChart1.Top = startTop;

            foreach (var item in Enum.GetValues(typeof(C1.Chart.FunnelChartType)))
                cbFunnelType.Items.Add(item.ToString());
            cbFunnelType.SelectedIndex = 0;
        }
    }
}
