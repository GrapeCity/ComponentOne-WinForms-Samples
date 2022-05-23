using System.Collections.Generic;
using System.Drawing;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Ribbon;
using C1.Win.Ribbon;

namespace FlexChartExplorer.Samples
{
    public partial class Ribbon : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        private C1Ribbon ribbon;

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
            if (ribbon == null)
            {
                ribbon = new C1Ribbon() { HideAppMenuWithTHR = true };
                CreateOptionsMenu();
                Controls.Add(ribbon);
            }
            else
                ribbon.Tabs.Clear();

            ribbon.BeginUpdate();
            
            ribbon.HideTabHeaderRow = true;

            var tab1 = new ChartRibbonTab(flexChart1);
            tab1.Text = "Chart";
            ribbon.Tabs.Add(tab1);

            tab1.Groups.Add(new ChartTypeRibbonGroup());
            tab1.Groups.Add(new ChartAppearanceRibbonGroup());
            tab1.Groups.Add(new ExportRibbonGroup());
            tab1.Groups.Add(new PrintRibbonGroup());

            ribbon.EndUpdate();
        }

        void CreateMultiTabRibbon()
        {
            ribbon.BeginUpdate();

            ribbon.HideTabHeaderRow = false;

            ribbon.Tabs.Clear();

            var tab1 = new ChartRibbonTab(flexChart1) { Text = "Chart" };
            ribbon.Tabs.Add(tab1);

            tab1.Groups.Add(new ChartTypeRibbonGroup());
            tab1.Groups.Add(new ChartAppearanceRibbonGroup());

            var tab2 = new RibbonTab("Elements");
            ribbon.Tabs.Add(tab2);

            tab2.Groups.Add(new ChartElementsRibbonGroup(flexChart1));
            tab2.Groups.Add(new AxesRibbonGroup(flexChart1));
            tab2.Groups.Add(new TrendlineRibbonGroup(flexChart1));

            var tab3 = new ChartRibbonTab(flexChart1) { Text = "Export" };
            ribbon.Tabs.Add(tab3);

            tab3.Groups.Add(new ExportRibbonGroup());
            tab3.Groups.Add(new PrintRibbonGroup());

            ribbon.EndUpdate();
        }


        void CreateOptionsMenu()
        {
            var optionsMenu = new RibbonMenu() { Text = "☰" };
            var optionsGroup = new RibbonToggleGroup();

            var btnRibbon = new RibbonToggleButton() { Text = "Ribbon", Pressed = true };
            btnRibbon.Click += (s, a) => CreateRibbon();

            var btnMultiRibbon = new RibbonToggleButton() { Text = "Multi Tabs Ribbon" };
            btnMultiRibbon.Click += (s, a) => CreateMultiTabRibbon();

            optionsGroup.Items.Add(btnRibbon);
            optionsGroup.Items.Add(btnMultiRibbon);

            optionsMenu.Items.Add(optionsGroup);
            ribbon.Qat.Items.Add(optionsMenu);

            ribbon.Qat.MenuVisible = false;
        }


        protected override void SetupChart()
        {
            var fnt = new Font("Segoe UI Emoji", 14);
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
