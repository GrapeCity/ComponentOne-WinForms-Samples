using System.Collections.Generic;
using System.Drawing;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Ribbon;
using C1.Win.Ribbon;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class MultiTabRibbon : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        private C1Ribbon ribbon;
        private List<Quote> data = FinancialDataSource.GetFinancialData(1000);

        public MultiTabRibbon()
        {
            InitializeComponent();
        }

        protected override void InitializeControls()
        {
            Chart = flexChart1 = new FlexChart();
        }

        public override Image GetImage(int width = 200, int height = 200)
        {
            var img = (Bitmap)base.GetImage(width, height);
            ribbon.DrawToBitmap(img, ribbon.ClientRectangle);
            return img;
        }

        void CreateRibbon()
        {
            ribbon = new C1Ribbon() { HideAppMenuWithTHR = true };
            Controls.Add(ribbon);

            ribbon.BeginUpdate();
            ribbon.TopToolBar.Visible = false;
            ribbon.Qat.Visible = false;

            var tab1 = new ChartRibbonTab(flexChart1) { Text = "Chart" };
            ribbon.Tabs.Add(tab1);

            tab1.Groups.Add(new ChartTypeRibbonGroup());
            tab1.Groups.Add(new ChartAppearanceRibbonGroup());

            var tab2 = new ChartRibbonTab(flexChart1) { Text = "Elements" };
            ribbon.Tabs.Add(tab2);

            tab2.Groups.Add(new ChartElementsRibbonGroup());
            tab2.Groups.Add(new AxesRibbonGroup());
            tab2.Groups.Add(new TrendLineRibbonGroup());

            var tab3 = new ChartRibbonTab(flexChart1) { Text = "Export" };
            ribbon.Tabs.Add(tab3);

            tab3.Groups.Add(new ExportRibbonGroup());
            tab3.Groups.Add(new PrintRibbonGroup());

            CreateDataTab();

            ribbon.EndUpdate();
        }

        C1.Win.Chart.Interaction.RangeSelector rs;

        void CreateDataTab()
        {
            var tab4 = new ChartRibbonTab(flexChart1) { Text = "Data" };
            ribbon.Tabs.Add(tab4);

            var chart = new FlexChart()
            {
                ChartType = ChartType.Line,
                DataSource = data,
                BackColor = Color.Transparent,
                BindingX = "Date",
                Binding = "Close"
            };
            chart.AxisX.Position = chart.AxisY.Position = Position.None;
            chart.PlotMargin = new System.Windows.Forms.Padding(12, 4, 12, 4);

            var ser = new Series();
            ser.Style.StrokeWidth = 1;
            chart.Series.Add(ser);
            chart.Rendered += (s, e) =>
            {
                if (rs == null)
                {
                    rs = new C1.Win.Chart.Interaction.RangeSelector(chart);
                    rs.ValueChanged += (s1, e1) =>
                    {
                        flexChart1.BeginUpdate();
                        flexChart1.AxisX.Min = rs.LowerValue;
                        flexChart1.AxisX.Max = rs.UpperValue;
                        flexChart1.EndUpdate();
                    };
                }
            };
            var ctrl = new RibbonControlHost(chart);
            var gr = new RibbonGroup("Range Selector");
            gr.Items.Add(ctrl);

            tab4.Groups.Add(new TimeRangeRibbonGroup());
            tab4.Groups.Add(gr);
        }

        protected override void SetupChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.ChartType = ChartType.Line;
            flexChart1.AxisX.Title = "Date";
            flexChart1.AxisY.Title = "Price";
            flexChart1.BindingX = "Date";
            flexChart1.Binding = "Close";
            flexChart1.DataSource = data;
            flexChart1.Series.Add(new Series());
            flexChart1.EndUpdate();

            CreateRibbon();
        }
    }
}
