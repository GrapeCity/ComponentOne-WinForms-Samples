using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace ChartDialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1Chart1.Header.Text = "Header Element\r\n" + 
                "Click chart elements for user dialogs\r\n" +
                "Click outside an element for entire chart dialog.\r\n" + 
                "Use left-click for dialog, right-click for property grid.";

            c1Chart1.Legend.Text = "Legend Element\r\nClick series\r\nto toggle display";
            c1Chart1.Footer.Text = "Footer Element";
            c1Chart1.ChartArea.AxisX.Text = "X-Axis Element\r\nClick the axis for a dialog.";
            c1Chart1.ChartArea.AxisY.Text = "Y-Axis Element\r\nClick the axis for a dialog.";
            c1Chart1.Header.Visible = true;
            c1Chart1.Footer.Visible = true;
            c1Chart1.Header.Style.Border.BorderStyle = BorderStyleEnum.Solid;
            c1Chart1.Footer.Style.Border.BorderStyle = BorderStyleEnum.Solid;

            // add some Chart Labels for full chart dialogs
            makeLabel("Label 0\r\nElement", new Point(5,5), LabelCompassEnum.SouthEast);
            makeLabel("Label 1\r\nElement", new Point(-5 + this.ClientSize.Width, 5), LabelCompassEnum.SouthWest);
            makeLabel("Label 2\r\nElement", new Point(-5, -5) + this.ClientSize, LabelCompassEnum.NorthWest);
            makeLabel("Label 3\r\nElement", new Point(5, -5 + this.ClientSize.Height), LabelCompassEnum.NorthEast);
        }

        /// <summary>
        /// Builds a chart label with the specified properties.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="location"></param>
        /// <param name="compass"></param>
        private void makeLabel(string text, Point location, LabelCompassEnum compass)
        {
            C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
            lab.Style.Border.BorderStyle = BorderStyleEnum.Solid;
            lab.Text = text;
            lab.AttachMethod = AttachMethodEnum.Coordinate;
            lab.AttachMethodData.X = location.X;
            lab.AttachMethodData.Y = location.Y;
            lab.Style.HorizontalAlignment = AlignHorzEnum.Near;
            lab.Compass = compass;
            lab.Visible = true;
        }

        /// <summary>
        /// Generates a Form with a property grid for the specified object
        /// with an appropriate title for the form.
        /// </summary>
        /// <param name="selectedObject"></param>
        /// <param name="title"></param>
        private void showPropertyGridForm(object selectedObject, string title)
        {
            PropertyGrid pg = new PropertyGrid();
            pg.SelectedObject = selectedObject;
            pg.Dock = DockStyle.Fill;
            pg.Size = new Size(100, 300);

            Form f = new Form();
            f.Text = title;
            f.Controls.Add(pg);
            f.ShowDialog();
        }

        /// <summary>
        /// Handles the chart MouseDown event.  Based on the location of the click
        /// different chart dialogs are displayed.  If a property grid is desired,
        /// use the right mouse button for the click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Clicking on the individual series entries in the Legend toggles the
        /// display of the series in the PlotArea.  When hidden, the legend display
        /// is grayed to show it is hidden in the PlotArea.
        /// </remarks>
        private void c1Chart1_MouseDown(object sender, MouseEventArgs e)
        {
            ChartRegionEnum cre = c1Chart1.ChartRegionFromCoord(e.X, e.Y);
            if (cre == ChartRegionEnum.Legend)
            {
                Legend leg = c1Chart1.Legend;
                int groupIndex=-1, seriesIndex=-1;

                if (leg.SeriesFromCoord(e.X, e.Y, ref groupIndex, ref seriesIndex))
                {
                    // Toggle chart series display by clicking on the series in the legend
                    ChartDataSeries cds = c1Chart1.ChartGroups[groupIndex].ChartData.SeriesList[seriesIndex];
                    if (cds.Display == SeriesDisplayEnum.Show)
                    {
                        cds.Display = SeriesDisplayEnum.Hide;
                        cds.Tag = new Color[] { cds.LineStyle.Color, cds.SymbolStyle.Color, cds.SymbolStyle.OutlineColor };
                        cds.LineStyle.Color = Color.Gray;
                        cds.SymbolStyle.Color = Color.Gray;
                        cds.SymbolStyle.OutlineColor = Color.DarkSlateGray;
                    }
                    else
                    {
                        Color[] clrs = cds.Tag as Color[];
                        cds.LineStyle.Color = clrs[0];
                        cds.SymbolStyle.Color = clrs[1];
                        cds.SymbolStyle.OutlineColor = clrs[2];
                        cds.Display = SeriesDisplayEnum.Show;
                    }
                }
                else
                {
                    // Show property dialog for the chart Legend, in this case when a specific series is not clicked.
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                        c1Chart1.ShowProperties(PropertyPageFlags.AppearanceLegend);
                    else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                        showPropertyGridForm(c1Chart1.Legend, "Legend properties");
                }
            }

            else if (cre == ChartRegionEnum.XAxis)
            {
                // Show property dialog for the chart X Axis, including Scaling, Fonts, Colors, and annotations etc.
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.AxisXScale | PropertyPageFlags.AxisX | PropertyPageFlags.AxisXAnno);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    showPropertyGridForm(c1Chart1.ChartArea.AxisX, "X axis properties");
            }

            else if (cre == ChartRegionEnum.YAxis)
            {
                // Show property dialog for the chart Y Axis, including Scaling, Fonts, Colors, and annotations etc.
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.AxisYScale | PropertyPageFlags.AxisY | PropertyPageFlags.AxisYAnno);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    showPropertyGridForm(c1Chart1.ChartArea.AxisY, "Y axis properties");
            }

            else if (cre == ChartRegionEnum.Footer)
            {
                // Show property dialog for the chart Footer
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.AppearanceFooter);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    showPropertyGridForm(c1Chart1.Footer.Style, "Footer Style properties");
            }

            else if (cre == ChartRegionEnum.Header)
            {
                // Show property dialog for the chart Header
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.AppearanceHeader);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    showPropertyGridForm(c1Chart1.Header.Style, "Header Style properties");
            }

            else if (cre == ChartRegionEnum.PlotArea)
            {
                // Show property dialog for the chart PlotArea
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.AppearancePlotArea | PropertyPageFlags.Group0Data);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if ((Control.ModifierKeys | Keys.Shift) == 0)
                        showPropertyGridForm(c1Chart1.ChartArea.PlotArea, "PlotArea properties");
                    else
                        showPropertyGridForm(c1Chart1.ChartGroups.Group0, "Group 0 properties");
                }
            }

            else if (cre == ChartRegionEnum.ChartLabel)
            {
                // Toggle the forecolor of the clicked label, or for right clicks,
                // show a modal form with a property page.
                int labIndex = -1;
                if (c1Chart1.ChartLabels.LabelFromCoord(e.X, e.Y, ref labIndex))
                {
                    C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels[labIndex];
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        if (lab.Style.ForeColor != Color.Red)
                            lab.Style.ForeColor = Color.Red;
                        else
                            lab.Style.ForeColor = Color.Black;
                    }
                    else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    {
                        showPropertyGridForm(lab.Style, "Style properties for " + lab.Name);
                    }
                }
            }

            else
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    c1Chart1.ShowProperties(PropertyPageFlags.All);
                else if (e.Button == System.Windows.Forms.MouseButtons.Right)
                    showPropertyGridForm(c1Chart1, "Chart Properties");
            }
        }

        /// <summary>
        /// Update the position of the coordinate specified labels.
        /// Must use the AttachMethodData object of each label to specify these.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c1Chart1_Resize(object sender, EventArgs e)
        {
            // update the label positions to match the new chart boundaries.
            AttachMethodData adm = c1Chart1.ChartLabels[1].AttachMethodData;
            adm.X = -5 + this.ClientSize.Width;  adm.Y = 5;

            adm = c1Chart1.ChartLabels[2].AttachMethodData;
            adm.X = -5 + this.ClientSize.Width; adm.Y = -5 + this.ClientSize.Height;

            adm = c1Chart1.ChartLabels[3].AttachMethodData;
            adm.X = 5; adm.Y = -5 + this.ClientSize.Height;
        }
    }
}
