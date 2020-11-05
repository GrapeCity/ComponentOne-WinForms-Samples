using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;

namespace FlexChartCustomization.Samples
{
    public partial class LegendItems : UserControl
    {
        static List<SmartPhoneVendor> vendors = SmartPhoneVendors();
        Series defaultSeries, customSeries;
        public LegendItems()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();
            flexChart1.DataSource = vendors;
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Shipments";
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            flexChart1.Header.Content = "Top Smartphone Vendors";
            customSeries = new SeriesWithPointLegendItems()
            { 
                ShowLegendNames = chbLegendNames.Checked,
                ShowCustomIcons = chbLegendCustomIcons.Checked,
                ShowLegendGroups = chbLegendGroups.Checked,
            };
            customSeries.Name = "Shipments";
            customSeries.SymbolRendering += VendorSeries_SymbolRendering;
            flexChart1.Legend.GroupHeaderStyle.Font = new Font(flexChart1.Font.FontFamily, 14f, FontStyle.Italic);
            flexChart1.Series.Add(customSeries);
            flexChart1.ToolTip.Content = "{seriesName}\r\n{value}";
            flexChart1.EndUpdate();
        }

        private void VendorSeries_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            // Customize the color of the columns.
            e.Engine.SetFill(new SolidBrush(vendors.ElementAt(e.Index).Color));
            e.Engine.SetStroke(new SolidBrush(Color.FromArgb(200, vendors.ElementAt(e.Index).Color)));
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("legenditems", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("legenditems", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
            chbPointsLegends = new CheckBox()
            {
                Text = "Display Series Points in Legend",
                FlatStyle = FlatStyle.Flat,
                Checked = true,
                AutoSize = true
            };
            chbPointsLegends.CheckedChanged += ChbPointsLegends_CheckedChanged;
            baseSample1.pControls.Controls.Add(chbPointsLegends);

            chbLegendGroups = new CheckBox()
            {
                Text = "Display Legend Groups",
                FlatStyle = FlatStyle.Flat,
                Checked = true,
                AutoSize = true
            };
            chbLegendGroups.CheckedChanged += ChbLegendGroups_CheckedChanged;
            baseSample1.pControls.Controls.Add(chbLegendGroups);

            chbLegendCustomIcons = new CheckBox()
            {
                Text = "Display Custom Icons",
                FlatStyle = FlatStyle.Flat,
                Checked = true,
                AutoSize = true
            };
            chbLegendCustomIcons.CheckedChanged += chbLegendCustomIcons_CheckedChanged;
            baseSample1.pControls.Controls.Add(chbLegendCustomIcons);

            chbLegendNames = new CheckBox()
            {
                Text = "Display Legend Names",
                FlatStyle = FlatStyle.Flat,
                Checked = true,
                AutoSize = true
            };
            chbLegendNames.CheckedChanged += chbLegendNames_CheckedChanged;
            baseSample1.pControls.Controls.Add(chbLegendNames);
        }

        void chbLegendNames_CheckedChanged(object sender, System.EventArgs e)
        {
            if (flexChart1.Series[0] == customSeries)
            {
                (customSeries as SeriesWithPointLegendItems).ShowLegendNames = chbLegendNames.Checked;
                flexChart1.Invalidate();
            }
        }

        void chbLegendCustomIcons_CheckedChanged(object sender, System.EventArgs e)
        {
            if (flexChart1.Series[0] == customSeries)
            {
                (customSeries as SeriesWithPointLegendItems).ShowCustomIcons = chbLegendCustomIcons.Checked;
                flexChart1.Invalidate();
            }            
        }

        void ChbLegendGroups_CheckedChanged(object sender, System.EventArgs e)
        {
            if (flexChart1.Series[0] == customSeries)
            {
                (customSeries as SeriesWithPointLegendItems).ShowLegendGroups = chbLegendGroups.Checked;
                flexChart1.Invalidate();
            }
        }

        private void setCustomOptionCheckBoxes(bool customOptionVisibility)
        {
            chbLegendGroups.Visible = customOptionVisibility;
            chbLegendNames.Visible = customOptionVisibility;
            chbLegendCustomIcons.Visible = customOptionVisibility;
        }

        private void ChbPointsLegends_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbPointsLegends.Checked)
            {
                flexChart1.Series.Clear();
                flexChart1.Series.Add(customSeries);
                setCustomOptionCheckBoxes(true);
            }
            else
            {
                if (defaultSeries == null)
                {
                    defaultSeries = new Series();
                    defaultSeries.Name = "Shipments";
                }
                flexChart1.Series.Clear();
                flexChart1.Series.Add(defaultSeries);
                setCustomOptionCheckBoxes(false);
            }

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

        private static List<SmartPhoneVendor> SmartPhoneVendors()
        {
            List<SmartPhoneVendor> vendors = new List<SmartPhoneVendor>();

            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Apple",
                Color = Color.FromArgb(136, 189, 230),
                Shipments = 215.2,
                Country = "USA",
                Image = Properties.Resources.apple_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Huawei",
                Color = Color.FromArgb(251, 178, 88),
                Shipments = 139,
                Country = "China",
                Image = Properties.Resources.huawei_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Lenovo",
                Color = Color.FromArgb(144, 205, 151),
                Shipments = 50.7,
                Country = "China",
                Image = Properties.Resources.lenovo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "LG",
                Color = Color.FromArgb(246, 170, 201),
                Shipments = 55.1,
                Country = "Korea",
                Image = Properties.Resources.lg_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Oppo",
                Color = Color.FromArgb(191, 165, 84),
                Shipments = 92.5,
                Country = "China",
                Image = Properties.Resources.oppo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Samsung",
                Color = Color.FromArgb(188, 153, 199),
                Shipments = 310.3,
                Country = "Korea",
                Image = Properties.Resources.samsung_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Vivo",
                Color = Color.FromArgb(237, 221, 70),
                Shipments = 71.7,
                Country = "China",
                Image = Properties.Resources.vivo_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "Xiaomi",
                Color = Color.FromArgb(240, 126, 110),
                Shipments = 61,
                Country = "China",
                Image = Properties.Resources.xiaomi_50,
            });
            vendors.Add(new SmartPhoneVendor()
            {
                Name = "ZTE",
                Color = Color.FromArgb(140, 140, 140),
                Shipments = 61.9,
                Country = "China",
                Image = Properties.Resources.zte_50,
            });

            return vendors;
        }

        public class SmartPhoneVendor
        {
            public string Name { get; set; }
            public double Shipments { get; set; }
            public string Country { get; set; }
            public Color Color { get; set; }
            public Image Image { get; set; }
        }
    }
}
