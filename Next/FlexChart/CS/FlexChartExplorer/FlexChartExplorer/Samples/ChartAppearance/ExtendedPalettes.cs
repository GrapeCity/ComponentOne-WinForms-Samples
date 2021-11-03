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
using BaseExplorer;
using FlexChartExplorer.Data;
using ExtPalettes = C1.Win.Chart.Palettes;

namespace FlexChartExplorer.Samples
{
    public partial class ExtendedPalettes : FlexChartBaseSample
    {
        private FlexChart chart;
        private FlexPie pie;
        private ListView lv;

        public ExtendedPalettes()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = GetGdpData();

            chart.BeginUpdate();
            chart.Palette = Palette.Custom;
            chart.CustomPalette = ExtPalettes.Qualitative.Accent;

            chart.Series.Clear();
            chart.DataSource = data;
            chart.BindingX = "country";

            var ser = new Series() { Binding = "y2016" };
            ser.SymbolRendering += (s, a) =>
            {
                a.Engine.SetFill(chart.CustomPalette[a.Index]);
                a.Engine.SetStroke(null);
            };
            chart.Series.Add(ser);

            chart.AxisX.AxisLine = false;
            chart.AxisX.MajorTickMarks = TickMark.None;
            chart.EndUpdate();

            pie.BeginUpdate();
            pie.DataSource = data;
            pie.BindingName = "country";
            pie.Binding = "y2016";
            pie.Palette = C1.Chart.Palette.Custom;
            pie.CustomPalette = ExtPalettes.Qualitative.Accent;
            pie.Legend.Position = Position.Bottom;
            pie.SliceRendering += (s, a) =>
            {
                a.Engine.SetFill(chart.CustomPalette[a.Index]);
                a.Engine.SetStroke(null);
            };
            pie.EndUpdate();

            SetupListView();
        }
        protected override void InitializeControls()
        {
            lv = new ListView() {Dock = DockStyle.Fill };
            lv.BorderStyle = BorderStyle.None;
            lv.View = View.Details;

            chart = new FlexChart() { Dock = DockStyle.Fill };
            pie = new FlexPie() { Dock = DockStyle.Fill };

            var tbl = new TableLayoutPanel() { Dock = DockStyle.Fill };
            tbl.RowStyles.Add( new RowStyle(SizeType.Percent, 50));
            tbl.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3f));
            tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.7f));
            tbl.SetRowSpan(lv, 2);

            tbl.Controls.Add(lv, 0, 0);
            tbl.Controls.Add(chart, 1, 0);
            tbl.Controls.Add(pie, 1, 1);

            pnlMain.Controls.Add(tbl);
        }

        void SetupListView()
        {
            var imageList = new ImageList() { ImageSize = new Size(64, 12) };

            AddItems(imageList, "Qualitative", ExtPalettes.Qualitative.Brushes);
            AddItems(imageList, "Diverging", ExtPalettes.Diverging.Brushes);
            AddItems(imageList, "SequentialSingle", ExtPalettes.SequentialSingle.Brushes);
            AddItems(imageList, "SequentialMulti", ExtPalettes.SequentialMulti.Brushes);

            lv.LargeImageList = imageList;
            lv.View = View.LargeIcon;

            lv.SelectedIndexChanged += (s, a) =>
            {
                if (lv.SelectedItems.Count > 0)
                {
                    chart.CustomPalette = pie.CustomPalette = lv.SelectedItems[0].Tag as IList<Brush>;
                    lv.SelectedItems[0].BackColor = Color.White;
                }
            };

            lv.OwnerDraw = true;
            lv.DrawItem += (s, a) =>
            {
                var rect = a.Bounds;
                var center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                var sz = a.Item.ImageList.ImageSize;
                rect.Inflate(-1, -1);
                a.Graphics.DrawImage(a.Item.ImageList.Images[a.Item.ImageIndex], center.X - sz.Width / 2, center.Y - sz.Height / 2 - 4);
                a.DrawText(TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter);

                if (a.Item.Selected)
                    a.Graphics.DrawRectangle(SystemPens.Highlight, rect);
            };
        }

        void AddItems(ImageList imageList, string name, IDictionary<string, IList<Brush>> brushes)
        {
            var ig = lv.Groups.Add(new ListViewGroup(name, HorizontalAlignment.Left));
            foreach (var key in brushes.Keys)
            {
                var item = lv.Items.Add(key);
                item.ImageIndex = imageList.Images.Count;
                item.Group = lv.Groups[ig];
                item.Tag = brushes[key];
                imageList.Images.Add(key, CreateSwatch(imageList.ImageSize.Width, imageList.ImageSize.Height, brushes[key]));
            }
        }

        Bitmap CreateSwatch(int w, int h, IList<Brush> brushes)
        {
            var bmp = new Bitmap(w, h);

            using (var g = Graphics.FromImage(bmp))
            {
                var cnt = brushes.Count;
                var dw = (float)w / cnt;

                for (var i = 0; i < cnt; i++)
                    g.FillRectangle(brushes[i], new RectangleF(i * dw, 0, dw, h));
            }

            return bmp;
        }


        // list of country GDP
        // https://en.wikipedia.org/wiki/List_of_IMF_ranked_countries_by_GDP
        List<object> GetGdpData()
        {
            return new List<object>
            {
                new { country = "US", y2014 = 17348075, y2015 = 18036650, y2016 = 18624450 },
                new { country = "China", y2014 = 10356508, y2015 = 11181556, y2016 = 11232110 },
                new { country= "Japan", y2014 = 4602367, y2015 = 4124211, y2016 = 4936540 },
                new { country= "Germany", y2014 = 3874437, y2015 = 3365293, y2016 = 3479230 },
                new { country= "UK", y2014= 2950039, y2015 = 2858482, y2016 = 2629190 },
                new { country= "France", y2014= 2833687, y2015 = 2420163, y2016 = 2466470 },
                new { country= "India", y2014= 2051228, y2015 = 2073002, y2016 = 2263790 },
                new { country= "Italy", y2014= 2147744, y2015 = 1815759, y2016 = 1850740 }
            };
        }
    }
}
