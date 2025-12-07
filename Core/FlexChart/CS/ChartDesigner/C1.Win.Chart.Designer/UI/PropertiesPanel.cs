using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.Chart.Designer.Data;

namespace C1.Win.Chart.Designer.UI
{
    partial class PropertiesPanel : UserControl
    {
        public PropertiesPanel()
        {
            InitializeComponent();
            dataMap.BindingsUpdated += BindingsUpdated;
            propertyGrid2.MouseClick += PropertyGrid2_MouseClick;
        }

        private void PropertyGrid2_MouseClick(object sender, MouseEventArgs e)
        {
            var grid = this.Controls[2];
            var flags = BindingFlags.Instance | BindingFlags.NonPublic;
            var invalidPoint = new Point(-2147483648, -2147483648);
            var FindPosition = grid.GetType().GetMethod("FindPosition", flags);
            var p = (Point)FindPosition.Invoke(grid, new object[] { e.X, e.Y });
            GridItem entry = null;
            if (p != invalidPoint)
            {
                var GetGridEntryFromRow = grid.GetType()
                                              .GetMethod("GetGridEntryFromRow", flags);
                entry = (GridItem)GetGridEntryFromRow.Invoke(grid, new object[] { p.Y });
            }
            if (entry != null && entry.Value != null)
            {
                object parent;
                if (entry.Parent != null && entry.Parent.Value != null)
                    parent = entry.Parent.Value;
                else
                    parent = propertyGrid2.SelectedObject;
                if (entry.Value != null && entry.Value is bool)
                {
                    entry.PropertyDescriptor.SetValue(parent, !(bool)entry.Value);
                    this.Refresh();
                }
            }
        }

        private void BindingsUpdated(object sender, EventArgs e)
        {
            var fc = chart as FlexChart;
            if (fc != null)
                UpdateBindings(fc);
            else
            {
                var fp = chart as FlexPie;
                if (fp != null)
                    UpdateBindings(fp);
            }
        }

        void UpdateBindings(FlexChart chart)
        {
            var binds = dataMap.Bindings;
            var bndx = binds["X-Axis"];
            if (bndx.Count > 0)
                chart.BindingX = bndx[0].Name;
            else
                chart.BindingX = null;

            var bndy = binds["Y-Axis"];
            if (bndy.Count > 0)
            {
                chart.Binding = bndy[0].Name;
                for (var i = 0; i < bndy.Count; i++)
                {
                    Series ser;
                    if (i >= chart.Series.Count)
                    {
                        ser = new Series();
                        chart.Series.Add(ser);
                    }
                    else
                        ser = chart.Series[i];
                    ser.Binding = bndy[i].Name;
                }

                while (chart.Series.Count > bndy.Count)
                {
                    chart.Series.RemoveAt(chart.Series.Count - 1);
                }

                if (chart.ChartType == C1.Chart.ChartType.Bubble)
                {
                    var bndsz = binds["Size"];
                    if (bndsz.Count > 0)
                    {
                        foreach (var ser in chart.Series)
                        {
                            if (!ser.ChartType.HasValue || ser.ChartType == C1.Chart.ChartType.Bubble)
                                ser.Binding += "," + bndsz[0].Name;
                        }
                    }
                }
            }
            else
            {
                chart.Binding = null;
                chart.Series.Clear();
            }
        }

        void UpdateBindings(FlexPie chart)
        {
            var binds = dataMap.Bindings;
            var bndn = binds["Name"];
            if (bndn.Count > 0)
                chart.Binding = bndn[0].Name;
            else
                chart.Binding = null;

            var bndv = binds["Value"];
            if (bndv.Count > 0)
            {
                var bind = "";
                for (var i = 0; i < bndv.Count; i++)
                {
                    if (!string.IsNullOrEmpty(bind))
                        bind += ",";
                    bind += bndv[i].Name;
                }
                chart.Binding = bind;
            }
            else
                chart.Binding = null;
        }


        public event EventHandler<LinkClickedEventArgs> LinkClicked;
        DataMap dataMap = new DataMap();
        DataEngine dataEngine = new DataEngine();
        object dataSource;
        FlexChartBase chart;


        public void PerformClick(string text)
        {
            if (text == "None" || text == "ChartArea" || text == "PlotArea")
                text = "Chart";
            else if (text == "DataLabel")
                text = "Data Label";
            else if (text == "AxisX")
                text = "X-Axis";
            else if (text == "AxisY")
                text = "Y-Axis";


            if (text == "Data")
            {
                if (!tableLayoutPanel1.Controls.Contains(dataMap))
                    tableLayoutPanel1.Controls.Add(dataMap, 0, 2);
                tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Percent, 0);
                tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Percent, 100);
                //dataMap.Visible = true;
                //propertyGrid2.Visible = false;
                lblStatus.Text = "Drag field to dimension to create binding";
                Header = "";
            }
            else
            {
                //if (tableLayoutPanel1.Controls.Contains(dataMap))
                //    tableLayoutPanel1.Controls.Remove(dataMap);
                tableLayoutPanel1.RowStyles[1] = new RowStyle(SizeType.Percent, 100);
                tableLayoutPanel1.RowStyles[2] = new RowStyle(SizeType.Percent, 0);

                //propertyGrid2.Visible = true;
                //dataMap.Visible = false;
                lblStatus.Text = "Select chart element to edit";
            }

            dropDownChartElements.Text = text;
            dropDownChartElements.Image = GetImage(text); //((ToolStripMenuItem)sender).Image;
        }

        [DefaultValue("")]
        public string Header
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }

        [DefaultValue(null)]
        public object DataSource
        {
            get { return dataSource; }
            set
            {
                if (dataSource != value)
                {
                    dataSource = value;
                    dataEngine.Load(dataSource as IEnumerable);
                    dataMap.Init(dataEngine);
                }
            }
        }

        private Image GetImage(string text)
        {
            if (text == "Chart")
            {
                if (chart is FlexChart)
                    text = "ColumnChart";
                else if (chart is FlexPie)
                    text = "PieChart";
            }
            return global::C1.Win.Chart.Designer.Properties.Resources.ResourceManager.GetObject(text) as Image;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid2.ResetSelectedProperty();
        }

        private void MenuClick(object sender, EventArgs e)
        {
            var text = ((ToolStripMenuItem)sender).Text;
            PerformClick(text);
            if (LinkClicked != null)
                LinkClicked(sender, new LinkClickedEventArgs(text));
        }

        [DefaultValue(null)]
        public FlexChartBase Chart
        {
            get { return chart; }
            set
            {
                //if (chart != value)
                {
                    chart = value;


                    if (chart is FlexChart)
                    {
                        toolStripMenuItem2.Visible = toolStripMenuItem3.Visible = true;
                    }
                    else if (chart is FlexPie)
                    {

                        toolStripMenuItem2.Visible = toolStripMenuItem3.Visible = false;
                    }
                    toolStripMenuItem1.Image = GetImage("Chart");
                    dataMap.InitBindings(chart);
                }
            }
        }
    }
}
