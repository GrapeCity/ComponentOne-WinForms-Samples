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
using FlexChartExplorer.Data;
using C1.Win.Chart;
using C1.Win.Ribbon;
using C1.Win.Chart.Ribbon;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Ribbon : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        private C1Ribbon ribbon;
        private Func<double, double> yFunc = x => Math.Round(Math.Sin(x) * Math.Tan(x), 3);

        public Ribbon()
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
            ribbon = new C1Ribbon() { HideAppMenuWithTHR = true, HideTabHeaderRow = true };
            Controls.Add(ribbon);

            ribbon.BeginUpdate();

            ribbon.TopToolBar.Visible = false;
            ribbon.Qat.Visible = false;

            var tab1 = new ChartRibbonTab(flexChart1);
            tab1.Text = "Chart";
            ribbon.Tabs.Add(tab1);

            tab1.Groups.Add(new ChartTypeRibbonGroup());
            tab1.Groups.Add(new ChartAppearanceRibbonGroup());
            tab1.Groups.Add(new ChartRangeRibbonGroup());
            tab1.Groups.Add(new ExportRibbonGroup());
            tab1.Groups.Add(new PrintRibbonGroup());

            ribbon.EndUpdate();
        }

        protected override void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.ChartType = ChartType.Line;

            flexChart1.DataSource = DataService.CreateDataPoints(x => x, yFunc, 360);
            flexChart1.BindingX = "X";
            flexChart1.Binding = "Y";
            flexChart1.Series.Add(new Series());

            flexChart1.AxisX.Title = "Time";
            flexChart1.AxisY.Title = "Signal Intensity";

            flexChart1.EndUpdate();

            CreateRibbon();
        }
    }
}
