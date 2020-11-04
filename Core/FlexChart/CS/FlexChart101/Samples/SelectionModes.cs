using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using System.Drawing.Drawing2D;

namespace FlexChart101.Samples
{
    public partial class SelectionModes : UserControl
    {
        public SelectionModes()
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

        private void cbSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            flexChart1.SelectionMode = (C1.Chart.ChartSelectionMode)Enum.Parse(typeof(C1.Chart.ChartSelectionMode), (cbSelectionMode.SelectedItem as ComboBoxItem).Text);
        }

        private void InitializeControls()
        {
            #region Init controls

            // Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("selectionmodes", "title");
            baseSample1.pDescription.Height = 90;
            baseSample1.tbDescription.Rtf = Localizer.GetItem("selectionmodes", "description").MakeRtf();

            baseSample1.tbCode.Text = @"//FlexChart ChartSelectionMode property
flexChart1.SelectionMode = C1.Chart.ChartSelectionMode.Series;";

            flexChart1 = baseSample1.flexChart1;

            // Initialize ChartType combo box
            cbChartType = new ComboBox()
            {
                Width = 180,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbChartType.SelectedIndexChanged += cbChartType_SelectedIndexChanged;

            // Initialize Stacked combo box
            cbSelectionMode = new ComboBox()
            {
                Width = 180,
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cbSelectionMode.SelectedIndexChanged += cbSelectionMode_SelectedIndexChanged;

            baseSample1.pControls.Controls.Add(cbChartType);
            baseSample1.pControls.Controls.Add(cbSelectionMode);
            #endregion
            foreach (var chartType in new ChartType[] { ChartType.Column, ChartType.Bar, ChartType.Scatter, ChartType.Line,
                ChartType.LineSymbols, ChartType.Area, ChartType.Spline, ChartType.SplineArea, ChartType.SplineSymbols, ChartType.Step, ChartType.StepArea, ChartType.StepSymbols} )
                cbChartType.Items.Add(new ComboBoxItem("Chart type") { Text = ((C1.Chart.ChartType)chartType).ToString(), Value = (int)chartType });
            cbChartType.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(C1.Chart.ChartSelectionMode)))
                cbSelectionMode.Items.Add(new ComboBoxItem("Selection mode") { Text = ((C1.Chart.ChartSelectionMode)item).ToString(), Value = (int)item });
            cbSelectionMode.SelectedIndex = 1;
        }
    }
}
