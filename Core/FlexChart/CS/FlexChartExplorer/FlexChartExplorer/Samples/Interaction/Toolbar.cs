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
using C1.Win.Chart.Toolbar;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Toolbar : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        private FlexChartToolbar toolbar;

        public Toolbar()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            flexChart1.Header.Content = "Monthly Mean Temperature";

            flexChart1.DataSource = ClimateData.GetData();
            flexChart1.BindingX = "month";
            flexChart1.Series.Add(new Series { Name = "NewYork", Binding = "NewYork" });
            flexChart1.Series.Add(new Series { Name = "LosAngeles", Binding = "LosAngeles" });

            AddToolbar();
        }

        protected override void InitializeControls()
        {
            Chart = flexChart1 = new FlexChart();
        }

        public override Image GetImage(int width = 200, int height = 200)
        {
            var img = (Bitmap)base.GetImage(width, height);
            toolbar.DrawToBitmap(img, toolbar.ClientRectangle);
            return img;
        }

        void AddToolbar()
        {
            toolbar = new FlexChartToolbar(true);

            // add custom toolbar option menu item
            toolbar.Items.Insert(0, new OptionsMenuItem(toolbar));
            toolbar.Items.Add(new ToolStripSeparator());
            toolbar.Items.Add(new SeriesMenuItem());
            
            flexChart1.Controls.Add(toolbar);
        }
    }


    class OptionsMenuItem : ChartMenuItemBase
    {
        public OptionsMenuItem(ToolStrip ts) : base(null, "☰")
        {
            ToolTipText = "Toolbar Options";
            DropDownItems.Add(new ToolStripLabel("Toolbar Options"));
            DropDownItems.Add(new ToolStripSeparator());
            MenuItemFromEnum<DockStyle>(DockStyle.Top, (v) => ts.Dock = v,
                new DockStyle[] { DockStyle.Left, DockStyle.Top, DockStyle.Right, DockStyle.Bottom });
            DropDownItems.Add(new ToolStripSeparator());
            MenuItemFromEnum<ToolStripItemDisplayStyle>(ToolStripItemDisplayStyle.ImageAndText,
            (style) =>
            {
                foreach (var item in ts.Items)
                {
                    var mi = item as ToolStripMenuItem;
                    if (mi != null && mi.Image != null)
                        mi.DisplayStyle = style;
                }
            }, new ToolStripItemDisplayStyle[] { ToolStripItemDisplayStyle.Image, ToolStripItemDisplayStyle.Text, ToolStripItemDisplayStyle.ImageAndText });
        }
    }

    // The climate of New York & Los Angeles
    // https://en.wikipedia.org/wiki/Climate_of_New_York
    // https://en.wikipedia.org/wiki/Climate_of_Los_Angeles
    class ClimateData
    {
        public static  object[] GetData()
        {
            return new object[]
            {
                new { month = "Jan", NewYork =  0.9, LosAngeles = 14.7, Seattle =  6.0},
                new { month = "Feb", NewYork =  2.2, LosAngeles = 15.0, Seattle =  6.7},
                new { month = "Mar", NewYork =  6.0, LosAngeles = 16.2, Seattle =  8.4},
                new { month = "Apr", NewYork = 12.1, LosAngeles = 17.6, Seattle = 10.7},
                new { month = "May", NewYork = 17.3, LosAngeles = 18.8, Seattle = 14.2},
                new { month = "Jun", NewYork = 22.2, LosAngeles = 20.7, Seattle = 16.7},
                new { month = "Jul", NewYork = 25.3, LosAngeles = 22.9, Seattle = 19.5},
                new { month = "Aug", NewYork = 24.5, LosAngeles = 23.7, Seattle = 19.7},
                new { month = "Sep", NewYork = 20.7, LosAngeles = 23.1, Seattle = 17.0},
                new { month = "Oct", NewYork = 14.4, LosAngeles = 20.7, Seattle = 12.1},
                new { month = "Nov", NewYork =  8.9, LosAngeles = 17.2, Seattle =  8.1},
                new { month = "Dec", NewYork =  3.9, LosAngeles = 14.3, Seattle =  5.6}
            };
        }
    }
}
