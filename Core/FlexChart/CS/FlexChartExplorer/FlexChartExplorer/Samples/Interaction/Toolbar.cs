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
            flexChart1.Legend.Style.Font = new Font("Segoe UI Emoji",14);

            flexChart1.DataSource = ClimateData.GetData();
            flexChart1.BindingX = "month";
            flexChart1.Series.Add(new Series { Name = "New York 🗽", Binding = "ny" });
            flexChart1.Series.Add(new Series { Name = "Los Angeles 🌴", Binding = "la" });

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
                new { month = "Jan", ny = 0.9, la = 14.7 },
                new { month = "Feb", ny = 2.2, la = 15.0 },
                new { month = "Mar", ny = 6.0, la = 16.2 },
                new { month = "Apr", ny = 12.1, la = 17.6 },
                new { month = "May", ny = 17.3, la = 18.8 },
                new { month = "Jun", ny = 22.2, la = 20.7 },
                new { month = "Jul", ny = 25.3, la = 22.9 },
                new { month = "Aug", ny = 24.5, la = 23.7 },
                new { month = "Sep", ny = 20.7, la = 23.1 },
                new { month = "Oct", ny = 14.4, la = 20.7 },
                new { month = "Nov", ny = 8.9, la = 17.2 },
                new { month = "Dec", ny = 3.9, la = 14.3 }
            };
        }
    }
}
