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
using FlexChartExplorer.Data;
using BaseExplorer;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class LegendItems : FlexChartBaseSample
    {
        private static List<SmartPhoneVendor> vendors = DataService.SmartPhoneVendors();
        private Series _defaultSeries, _customSeries;
        private CheckBoxEx _chbPointsLegends, _chbLegendGroups, _chbLegendCustomIcons, _chbLegendNames;
        private FlexChart flexChart1;

        public LegendItems()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Top Smartphone Vendors";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.DataSource = vendors;
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Binding = "Shipments";

            _customSeries = new SeriesWithPointLegendItems
            {
                Name = "Shipments",
                ShowLegendNames = _chbLegendNames.Checked,
                ShowCustomIcons = _chbLegendCustomIcons.Checked,
                ShowLegendGroups = _chbLegendGroups.Checked,
            };
            _customSeries.SymbolRendering += _customSeries_SymbolRendering;
            this.flexChart1.Series.Add(_customSeries);
            this.flexChart1.Legend.GroupHeaderStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Legend.Position = Position.Right;
            this.flexChart1.ToolTip.Content = "{seriesName}\r\n{value}";
        }

        private void _customSeries_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            e.Engine.SetFill(new SolidBrush(((SmartPhoneVendor)e.Item).Color));
            e.Engine.SetStroke(new SolidBrush(Color.FromArgb(200, ((SmartPhoneVendor)e.Item).Color)));
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _chbPointsLegends = new CheckBoxEx("Display Series Points In Legends") { Checked = true };
            _chbPointsLegends.CheckedChanged += _chbPointsLegends_CheckedChanged;

            _chbLegendGroups = new CheckBoxEx("Display Legend Groups") { Checked = true };
            _chbLegendGroups.CheckedChanged += (s, e) => 
            {
                if (flexChart1.Series[0] == _customSeries)
                {
                    (_customSeries as SeriesWithPointLegendItems).ShowLegendGroups = _chbLegendGroups.Checked;
                    flexChart1.Invalidate();
                }
            };

            _chbLegendCustomIcons = new CheckBoxEx("Display Custom Icons") { Checked = true };
            _chbLegendCustomIcons.CheckedChanged += (s, e) => 
            {
                if (flexChart1.Series[0] == _customSeries)
                {
                    (_customSeries as SeriesWithPointLegendItems).ShowCustomIcons = _chbLegendCustomIcons.Checked;
                    flexChart1.Invalidate();
                }
            };

            _chbLegendNames = new CheckBoxEx("Display Legend Names") { Checked = true };
            _chbLegendNames.CheckedChanged += (s, e) => 
            {
                if(flexChart1.Series[0] == _customSeries)
                {
                    (_customSeries as SeriesWithPointLegendItems).ShowLegendNames = _chbLegendNames.Checked;
                    flexChart1.Invalidate();
                }
            };

            this.pnlControls.Controls.Add(_chbPointsLegends);
            this.pnlControls.Controls.Add(_chbLegendGroups);
            this.pnlControls.Controls.Add(_chbLegendCustomIcons);
            this.pnlControls.Controls.Add(_chbLegendNames);
        }

        private void _chbPointsLegends_CheckedChanged(object sender, EventArgs e)
        {
            if (_chbPointsLegends.Checked)
            {
                flexChart1.Series.Clear();
                flexChart1.Series.Add(_customSeries);
                ShowCustomOptionCheckBoxes(true);
            }
            else
            {
                flexChart1.Series.Clear();
                if (_defaultSeries == null)
                    _defaultSeries = new Series { Name = "Shipments" };
                flexChart1.Series.Add(_defaultSeries);
                ShowCustomOptionCheckBoxes(false);
            }
        }
        void ShowCustomOptionCheckBoxes(bool show)
        {
            _chbLegendGroups.Visible = _chbLegendNames.Visible = _chbLegendCustomIcons.Visible = show;
        }
        public class SeriesWithPointLegendItems : Series, ISeries
        {
            public bool ShowLegendGroups { get; set; }
            public bool ShowCustomIcons { get; set; }
            public bool ShowLegendNames { get; set; }

            /// <summary>
            /// Gets the name of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            string ISeries.GetLegendItemName(int index)
            {
                return ShowLegendNames ? vendors.ElementAt(index).Name : null;
            }

            /// <summary>
            /// Gets the style of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            _Style ISeries.GetLegendItemStyle(int index)
            {
                return new _Style { Fill = new SolidBrush(vendors.ElementAt(index).Color) };
            }

            /// <summary>
            /// Get the number of series items in the legend.
            /// </summary>
            int ISeries.GetLegendItemLength() { return vendors.Count; }

            /// <summary>
            /// Get the legend group name for the series item.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            string ISeries.GetLegendItemGroup(int index)
            {
                if (ShowLegendGroups)
                    return vendors.ElementAt(index).Country;
                else
                    return null;
            }

            object ISeries.GetLegendItemImageSource(int index, ref C1.Chart._Size imageSize)
            {
                if (ShowCustomIcons)
                {
                    // Original images/logos are all 50x50 pixels.
                    // Here they are replaced with new images where a 5 pixel border is added
                    // around the logos.

                    imageSize.Height = 60;
                    imageSize.Width = 60;

                    SmartPhoneVendor vendor = vendors.ElementAt(index);
                    if (vendor.Image != null && vendor.Image.Width != 60)
                    {
                        Bitmap bmp = new Bitmap(60, 60);
                        using (SolidBrush sb = new SolidBrush(vendor.Color))
                        {
                            using (Graphics g = Graphics.FromImage(bmp))
                            {
                                Rectangle r = new Rectangle(0, 0, (int)imageSize.Width, (int)imageSize.Height);
                                using (Pen p = new Pen(sb))
                                {
                                    g.DrawRectangle(p, r);
                                }
                                g.FillRectangle(sb, r);

                                Point ci = new Point((int)(0.5 * (imageSize.Width - vendor.Image.Width)),
                                    (int)(0.5 * (imageSize.Height - vendor.Image.Height)));
                                g.DrawImage(vendor.Image, ci);
                            }
                        }
                        vendor.Image = bmp;
                    }

                    // Try and keep the original size of the logo bitmaps, but reduce their size if the chart window
                    // is too small to display the bitmaps properly.
                    Size bounds = this.Chart.ClientSize;
                    double divadj = (bounds.Height > 800) ? 12 : 25;
                    double fracHeight = bounds.Height / divadj;
                    if (fracHeight < imageSize.Height)
                        imageSize.Width = imageSize.Height = fracHeight;

                    return vendor.Image;
                }
                return null;
            }
        }
    }
}
