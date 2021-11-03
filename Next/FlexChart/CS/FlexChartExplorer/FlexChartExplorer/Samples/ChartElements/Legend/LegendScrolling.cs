using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class LegendScrolling : FlexChartBaseSample
    {
        ComboBoxEx cbX, cbY, cbSize;

        public LegendScrolling()
        {
            InitializeComponent();
            Load += LegendScrolling_Load    ;
        }

        private void LegendScrolling_Load(object sender, EventArgs e)
        {
            cbX.SelectedIndex = 1;
            cbY.SelectedIndex = 2;
        }

        protected override void SetupChart()
        {
            var chart = (FlexChart)Chart;
            var clrs = WebColors.GetColors();

            chart.BeginUpdate();
            chart.ChartType = ChartType.Scatter;

            chart.Legend.Position = Position.Right;
            chart.Legend.Title = "Web (X11) Colors";
            chart.Legend.GroupHeaderStyle.Font = new Font(chart.Font.FontFamily, chart.Font.Size, FontStyle.Bold);
            chart.Legend.ScrollBars = LegendScrollBars.Vertical;
            chart.LegendToggle = true;

            chart.AxisX.AxisLine = false;
            chart.AxisX.MajorGrid = true;

            chart.ToolTip.Content = "{Name}\nR={R}\nG={G}\nB={B}";

            foreach (var clr in clrs)
            {
                var ser = new Series() { Name = clr.Name };
                ser.Style.FillColor = clr.Color;
                ser.SymbolStyle.StrokeWidth = 0;
                ser.DataSource = new WebColor[] { clr };
                chart.Series.Add(ser);
            }

            chart.Binding = "B";
            chart.BindingX = "G";

            chart.EndUpdate();
        }

        protected override void InitializeControls()
        {
            var chart = new FlexChart();
            Chart = chart;

            cbX = new ComboBoxEx("X");
            cbX.DataSource = new string[] { "Red", "Green", "Blue" };
            cbX.SelectedValueChanged += (se, ar) =>
            {
                chart.BeginUpdate();
                var sel = cbX.SelectedValue.ToString();
                chart.AxisX.Title = sel;
                chart.BindingX = sel[0].ToString();
                chart.EndUpdate();
            };
            pnlControls.Controls.Add(cbX);

            cbY = new ComboBoxEx("Y");
            cbY.DataSource = new string[] { "Red", "Green", "Blue" };
            cbY.SelectedValueChanged += (se, ar) =>
            {
                chart.BeginUpdate();
                var sel = cbY.SelectedValue.ToString();
                chart.AxisY.Title = sel;
                chart.Binding = sel[0].ToString();
                UpdateSizeBinding();
                chart.EndUpdate();
            };
            pnlControls.Controls.Add(cbY);

            cbSize = new ComboBoxEx("Size");
            cbSize.DataSource = new string[] { "None", "Red", "Green", "Blue" };
            cbSize.SelectedValueChanged += (se, ar) => UpdateSizeBinding();
            pnlControls.Controls.Add(cbSize);

            var cbGroup = new CheckBoxEx("Legend Groups");
            cbGroup.CheckedChanged += (s,a) => GroupSeries(cbGroup.Checked);
            pnlControls.Controls.Add(cbGroup);
        }

        void UpdateSizeBinding()
        {
            var chart = (FlexChart)Chart;
            chart.BeginUpdate();
            var sel = cbSize.SelectedValue != null ? cbSize.SelectedValue.ToString() : "None";
            if (sel != "None")
            {
                chart.Binding = cbY.SelectedValue.ToString()[0].ToString() + "," + sel[0].ToString();
                chart.ChartType = ChartType.Bubble;
            }
            else
            {
                chart.Binding = cbY.SelectedValue.ToString()[0].ToString();
                chart.ChartType = ChartType.Scatter;
            }
            chart.EndUpdate();
        }

        void GroupSeries(bool create)
        {
            var chart = (FlexChart)Chart;
            chart.BeginUpdate();
            foreach (var ser in chart.Series)
                ser.LegendGroup = create ? ((WebColor[])ser.DataSource)[0].Group : null;
            chart.EndUpdate();
        }
    }
}
