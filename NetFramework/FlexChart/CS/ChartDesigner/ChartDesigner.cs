using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.FlexChart.Designer.Data;
using C1.Win.FlexChart.Designer.UI;

namespace C1.Win.FlexChart.Designer
{
    /// <summary>
    /// Runtime chart designer.
    /// </summary>
    public class ChartDesigner
    {
        DataEngine dataEngine = new DataEngine();
        ChartAdorner adorner;
        Chart.FlexChartBase chart;
        PropertiesPanel propertiesPanel1;
        Form frmProperties;

        /// <summary>
        /// Creates designer for the specified chart instance.
        /// </summary>
        /// <param name="chart"></param>
        public ChartDesigner(Chart.FlexChartBase chart)
        {
            dict[chart] = this;
            Init(chart);
        }

        /// <summary>
        /// Detaches the designer from chart instance.
        /// </summary>
        public void Detach()
        {
            dict.Remove(chart);
            adorner.Detach();
            Close();
        }

        /// <summary>
        /// Closes the designer window.
        /// </summary>
        public void Close()
        {
            if (frmProperties != null)
            {
                frmProperties.Close();
                frmProperties = null;
            }
        }

        void Init(Chart.FlexChartBase chart)
        {
            this.chart = chart;
            adorner = new ChartAdorner(chart);
            adorner.SelectedElementChanged += Chart_SelectedElementChanged;
            InitForms();
        }

        void InitForms()
        {
            if (frmProperties == null)
            {
                frmProperties = new Form()
                {
                    Text = "FlexChart Designer",
                    FormBorderStyle = FormBorderStyle.SizableToolWindow,
                    TopMost = true,
                    MinimumSize = new Size(300, 300)
                };

                propertiesPanel1 = new PropertiesPanel() { Dock = DockStyle.Fill };
                propertiesPanel1.LinkClicked += LinkClicked;
                propertiesPanel1.DataSource = DataSource;
                propertiesPanel1.Chart = chart;
                frmProperties.FormClosed += (s, e) =>
                {
                    adorner.HoverElement = adorner.SelectedElement = C1.Chart.ChartElement.None;
                    frmProperties = null;
                };
                frmProperties.Controls.Add(propertiesPanel1);
            }
        }

        private void LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText == "Chart")
                adorner.SelectedElement = C1.Chart.ChartElement.ChartArea;
            else if (e.LinkText == "X-Axis")
                adorner.SelectedElement = C1.Chart.ChartElement.AxisX;
            else if (e.LinkText == "Y-Axis")
                adorner.SelectedElement = C1.Chart.ChartElement.AxisY;
            else if (e.LinkText == "Header")
                adorner.SelectedElement = C1.Chart.ChartElement.Header;
            else if (e.LinkText == "Footer")
                adorner.SelectedElement = C1.Chart.ChartElement.Footer;
            else if (e.LinkText == "Legend")
                adorner.SelectedElement = C1.Chart.ChartElement.Legend;
            else if (e.LinkText == "Data Label")
                adorner.SelectedElement = C1.Chart.ChartElement.DataLabel;
            else if (e.LinkText == "Data")
            {
                propertiesPanel1.DataSource = DataSource;
                //propertiesPanel1.Chart = flexChart;
            }
        }

        private object DataSource
        {
            get
            {
                object ds = null;
                var fc = chart as Chart.FlexChart;
                if (fc != null)
                    ds = fc.DataSource;
                else
                {
                    var fp = chart as Chart.FlexPie;
                    if (fp != null)
                        ds = fp.DataSource;
                }
                return ds;
            }
        }

        private void Chart_SelectedElementChanged(object sender, EventArgs e)
        {
                InitForms();
                frmProperties.StartPosition = FormStartPosition.Manual;

            var loc = chart.PointToScreen(new Point(chart.Width - chart.Margin.Right, 0));

            if (loc.X + frmProperties.Width > Screen.FromControl(chart).Bounds.Width)
            {
                loc = chart.PointToScreen(new Point(0, 0));
                loc.X -= frmProperties.Width;
            }

            frmProperties.Location = loc;
                frmProperties.Show();

            var obj = adorner.GetSelectedObject();
            propertiesPanel1.Header = obj is SeriesProperties ? obj.ToString() : null;
            propertiesPanel1.propertyGrid2.SelectedObject = obj;

            propertiesPanel1.PerformClick(adorner.SelectedElement.ToString());
        }

        static Dictionary<Chart.FlexChartBase, ChartDesigner> dict = new Dictionary<Chart.FlexChartBase, ChartDesigner>();

        /// <summary>
        /// Gets the designer for the specified chart.
        /// </summary>
        /// <param name="chart"></param>
        /// <returns></returns>
        public static ChartDesigner GetDesigner(Chart.FlexChartBase chart)
        {
            ChartDesigner designer = null;
            dict.TryGetValue(chart, out designer);
            return designer;
        }
    }
}
