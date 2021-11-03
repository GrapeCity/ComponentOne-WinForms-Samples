using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;

namespace FlexChart101.Samples
{
    public partial class ChartTypes : UserControl
    {
        public ChartTypes()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();

            // Add 3 data series
            var s1 = new Series();
            s1.Binding = s1.Name = "March";
            flexChart1.Series.Add(s1);

            var s2 = new Series();
            s2.Binding = s2.Name = "April";
            flexChart1.Series.Add(s2);

            var s3 = new Series();
            s3.Binding = s3.Name = "May";
            flexChart1.Series.Add(s3);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Fruit";
            flexChart1.DataSource = DataCreator.CreateFruit();

            flexChart1.EndUpdate();
        }

        private void cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.ChartType = (C1.Chart.ChartType)Enum.Parse(typeof(C1.Chart.ChartType), (cbChartType.SelectedItem as ComboBoxItem).Text);
        }

        private void cbStacked_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.Stacking = (C1.Chart.Stacking)Enum.Parse(typeof(C1.Chart.Stacking), (cbStacked.SelectedItem as ComboBoxItem).Text);
        }

        private void cbRotated_CheckedChanged(object sender, EventArgs e)
        {
            flexChart1.Rotated = chbRotate.Checked;
        }

        private void InitializeControls()
        {
            #region Init controls

            // Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("charttypes", "title");
            baseSample1.pDescription.Height = 130;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("charttypes", "description").MakeRtf();

            baseSample1.tbCode.Text = @"// Set FlexChart.ChartType property
flexChart1.ChartType = C1.Chart.ChartType.Bar;

// Set FlexChart.Stacked property
flexChart1.Stacking = C1.Chart.Stacking.Stacked;

// Set FlexChart.Rotated property
flexChart1.Rotated = true;
";

            flexChart1 = baseSample1.flexChart1;

            // Initialize ChartType combo box
            cbChartType = new ComboBox()
            {
                Location = new Point(40, 5),
                Size = new Size(150, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbChartType.SelectedIndexChanged += cbChartType_SelectedIndexChanged;

            // Initialize Stacked combo box
            cbStacked = new ComboBox()
            {
                Location = new Point(cbChartType.Right + 10, 5),
                Size = new Size(150, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbStacked.SelectedIndexChanged += cbStacked_SelectedIndexChanged;

            // Initialize Rotate checkbox
            chbRotate = new CheckBox()
            {
                Text = "Rotate",
                Location = new Point(cbStacked.Right + 10, 5),
                FlatStyle = FlatStyle.Flat,
                Checked = false
            };
            chbRotate.CheckedChanged += cbRotated_CheckedChanged;

            baseSample1.pControls.Controls.Add(cbChartType);
            baseSample1.pControls.Controls.Add(cbStacked);
            baseSample1.pControls.Controls.Add(chbRotate);
            #endregion

            foreach (var chartType in new ChartType[] { ChartType.Column, ChartType.Bar, ChartType.Scatter, ChartType.Line,
                ChartType.LineSymbols, ChartType.Area, ChartType.Spline, ChartType.SplineArea, ChartType.SplineSymbols, ChartType.Step, ChartType.StepArea, ChartType.StepSymbols})
                cbChartType.Items.Add(new ComboBoxItem("Chart type") { Text = ((C1.Chart.ChartType)chartType).ToString(), Value = (int)chartType });
            cbChartType.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(C1.Chart.Stacking)))
                cbStacked.Items.Add(new ComboBoxItem("Stacking") { Text = ((C1.Chart.Stacking)item).ToString(), Value = (int)item });
            cbStacked.SelectedIndex = 0;
        }
    }
}
