using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;

namespace DrillDown.Samples
{
    public partial class AsyncDrillDownDemo : UserControl
    {
        DrillDownManager manager;
        private IDictionary<int, string> _paths = new Dictionary<int,string>();
        public AsyncDrillDownDemo()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }
        void SetupChart()
        {
            var data = DataService.Instance.GetGroupedData("Country");
            manager = new DrillDownManager(data,"YValue","XValue");
            manager.GroupNames.AddRange(new[] { "Country", "City", "Year", "Month", "Day" });
            manager.BeforeDrill += Manager_BeforeDrill;
            manager.AfterDrill += Manager_AfterDrill;
            manager.Refresh();

            flexChart1.BeginUpdate();
            flexChart1.Name = "flexChart1";
            flexChart1.ToolTip.Content = "X:{x} Y:{y}";
            flexChart1.Footer.Style.Font = new Font(flexChart1.Font.FontFamily, 12);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Value";
            flexChart1.Series.Clear();
            flexChart1.Series.Add(new Series() { Binding = "Value" });
            flexChart1.DataSource = manager.CurrentItems.Views;
            flexChart1.DataLabel.Style.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10);
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.Top;
            flexChart1.DataLabel.Content = "{y}";
            flexChart1.MouseClick += ChartMouseClick;
            flexChart1.EndUpdate();

        }


        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("asyncDrillDown", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("asyncDrillDown", "description").MakeRtf();

            flexChart1 = baseSample1.flexChart1;

            pnlNavBar = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 11),
                Padding = new Padding(5)
            };

            baseSample1.pControls.WrapContents = true;
            baseSample1.pControls.AutoSize = true;
            baseSample1.pControls.Controls.Add(pnlNavBar);
        }
        private void Manager_AfterDrill(object sender, DrillDownEventArgs e)
        {
            flexChart1.DataSource = manager.CurrentItems.Views;
            flexChart1.Footer.Content = string.Format("{0}-wise sales", manager.GroupNames[e.DrillDownLevel]);

            if (_currentValue!=null && manager.CurrentItems.Name==null)
                manager.CurrentItems.Name = _currentValue.ToString();

            if (e.IsDrillDown)
            {
                if (_paths.ContainsKey(e.DrillDownLevel))
                    _paths.Remove(e.DrillDownLevel);
                _paths.Add(e.DrillDownLevel, manager.CurrentItems.Name);
            }

            UpdateNavBar();
        }

        private void Manager_BeforeDrill(object sender, DrillDownEventArgs e)
        {
            if (e.IsDrillDown == false && e.DrillDownLevel > 0)
                _paths.Remove(e.DrillDownLevel);

            if (e.DrillDownLevel > 3 && e.IsDrillDown)
                e.Cancel = true;
        }

        object _currentValue;
        private async void ChartMouseClick(object sender, MouseEventArgs e)
        {
            if (manager == null)
                return;

            if (e.Button == MouseButtons.Right)
                manager.DrillUp();
            else
            {
                var flexChart = sender as FlexChartBase;
                var hitInfo = flexChart.HitTest(new Point(e.X, e.Y));
                if (hitInfo != null && hitInfo.Distance < 2)
                {
                    _currentValue = hitInfo.X;

                    var tooltip = flexChart.ToolTip.Content;
                    flexChart.ToolTip.Content = "Please wait while the details are being fetched";
                    flexChart1.Cursor = Cursors.WaitCursor;
                    
                    Console.WriteLine("Start fetching details");

                    IEnumerable<object> data = await FetchDataAsync(manager.DrillDownLevel);

                    flexChart.Enabled = true;
                    Console.WriteLine("Fetching details completed");
                    flexChart.ToolTip.Hide(flexChart1);
                    flexChart.ToolTip.Content = tooltip;
                    flexChart1.Cursor = Cursors.Default;
                    manager.DrillDown(data);
                }
            }
        }

        private Task<IEnumerable<object>> FetchDataAsync(int drilldownLevel)
        {
            return Task.Run(() =>
            {
                IEnumerable<object> data = null;
                switch (drilldownLevel)
                {
                    case 0:
                        data = DataService.Instance.GetGroupedData("Country", _currentValue, "City");
                        break;
                    case 1:
                        data = DataService.Instance.GetGroupedData("City", _currentValue, "Year");
                        break;
                    case 2:
                        data = DataService.Instance.GetGroupedData("Year", _currentValue, "Month");
                        break;
                    case 3:
                        data = DataService.Instance.GetGroupedData("Month", _currentValue, "Day");
                        break;
                    default:
                        break;
                }
                return data;
            });

        }

        private void UpdateNavBar()
        {
            pnlNavBar.SuspendLayout();
            pnlNavBar.Controls.Clear();

            if (manager.DrillDownLevel > 0)
            {
                for (int i = 0; i < _paths.Count; i++)
                {
                    var path = _paths.ElementAt(i);
                    if (i == _paths.Count - 1)
                    {
                        AddToNavBar(typeof(Label), path.Value);
                        AddToNavBar(typeof(Label), "-");
                    }
                    else
                    {
                        AddToNavBar(typeof(LinkLabel), path.Value, path.Key);
                        AddToNavBar(typeof(Label), "\\");
                    }
                }
            }

            string tail = null;
            string aggregate = manager.AggregateType.ToString();
            string currentPath = manager.GroupNames[manager.DrillDownLevel];
            tail = string.Format("{0} By {1}", aggregate, currentPath);
            AddToNavBar(typeof(Label), tail);

            pnlNavBar.ResumeLayout();
        }

        private void AddToNavBar(Type control, string text, int level = -1)
        {
            Control lbl = (Control)Activator.CreateInstance(control);
            lbl.Text = text;
            lbl.Margin = new Padding(0);
            lbl.Padding = new Padding(0);
            lbl.AutoSize = true;

            if (lbl is LinkLabel)
            {
                var link = lbl as LinkLabel;
                link.LinkClicked += (s, e) => manager.DrillUp(level);
            }
            pnlNavBar.Controls.Add(lbl);
        }

    }
}