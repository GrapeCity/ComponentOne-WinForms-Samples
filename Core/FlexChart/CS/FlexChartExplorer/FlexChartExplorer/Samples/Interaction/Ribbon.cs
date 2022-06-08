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
        private Font fnt = new Font("Segoe UI Emoji", 14);

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
            tab1.Groups.Add(new ExportRibbonGroup());
            tab1.Groups.Add(new PrintRibbonGroup());

            ribbon.EndUpdate();
        }

        protected override void SetupChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.Legend.Style.Font = fnt;
            flexChart1.Legend.Position = Position.Right;
            flexChart1.AxisX.Title = "Hours of Sunshine ☀️";
            flexChart1.AxisX.TitleStyle.Font = fnt;
            flexChart1.AxisY.Title = "Sales 💲";
            flexChart1.AxisY.TitleStyle.Font = fnt;
            flexChart1.BindingX = "Hours";
            flexChart1.DataSource = SampleData.GetSalesData();
            flexChart1.Series.Add(new Series() { Binding = "SalesIceCream", Name = "Ice Cream 🍦" });
            flexChart1.Series.Add(new Series() { Binding = "SalesCola", Name = "Cola 🥤" });
            flexChart1.EndUpdate();

            CreateRibbon();
        }

        class SampleData
        {
            public class DataItem
            {
                public double Hours { get; set; }
                public int SalesIceCream { get; set; }
                public int SalesCola { get; set; }
            }

            public static List<DataItem> GetSalesData()
            {
                return new List<DataItem>() {
                    new DataItem() { Hours = 2, SalesIceCream = 4, SalesCola = 9},
                    new DataItem() { Hours = 3, SalesIceCream = 5, SalesCola = 15},
                    new DataItem() { Hours = 5, SalesIceCream = 7, SalesCola = 16},
                    new DataItem() { Hours = 7, SalesIceCream = 10, SalesCola = 22},
                    new DataItem() { Hours = 9, SalesIceCream = 15, SalesCola = 28}
                };
            }
        }
    }
}
