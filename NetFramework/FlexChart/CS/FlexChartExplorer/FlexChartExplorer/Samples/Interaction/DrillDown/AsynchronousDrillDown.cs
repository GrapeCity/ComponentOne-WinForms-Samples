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

namespace FlexChartExplorer.Samples
{
    public partial class AsynchronousDrillDown : FlexChartBaseSample
    {
        DrillDownManager manager;
        private IDictionary<int, string> _paths = new Dictionary<int, string>();
        private object _currentValue;

        private FlowLayoutPanel _pNavBar;
        private FlexChart flexChart1;

        public AsynchronousDrillDown()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var items = HierarchicalDataSource.GetGroupedData("Country");
            manager = new DrillDownManager(items, "Value", "Name");
            manager.GroupNames.AddRange(new string[] { "Country", "City", "Year", "Month", "Day" });
            manager.BeforeDrill += Manager_BeforeDrill;
            manager.AfterDrill += Manager_AfterDrill;
            manager.Refresh();

            //FlexChart settings
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Value";
            flexChart1.Series.Add(new Series() { Name = "Value" });
            flexChart1.DataSource = manager.CurrentItems.Views;
            flexChart1.ToolTip.Content = "X:{x}\nY:{Value}";
            flexChart1.DataLabel.Style.Font = new Font("Segoe UI", 9);
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.Top;
            flexChart1.DataLabel.Content = "{y}";

            flexChart1.AxisY.Format = "#,##0,K";
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexChart1.MouseClick += ChartMouseClick;
            flexChart1.AxisX.AxisLine = false;
        }
        private void Manager_AfterDrill(object sender, DrillDownEventArgs e)
        {
            flexChart1.DataSource = manager.CurrentItems.Views;
            flexChart1.Header.Content = string.Format("{0}-wise Sales", manager.GroupNames[e.DrillDownLevel]);
            if (_currentValue != null && manager.CurrentItems.Name == null)
                manager.CurrentItems.Name = _currentValue.ToString();
            if (e.IsDrillDown)
            {
                if (_paths.ContainsKey(e.DrillDownLevel))
                    _paths.Remove(e.DrillDownLevel);
                _paths.Add(e.DrillDownLevel, manager.CurrentItems.Name);
            }
            UpdateNavBar();
            isDrilling = false;
        }

        private void Manager_BeforeDrill(object sender, DrillDownEventArgs e)
        {
            if (e.DrillDownLevel > 3 && e.IsDrillDown)
                e.Cancel = true;
        }
        private void UpdateNavBar()
        {
            _pNavBar.SuspendLayout();
            _pNavBar.Controls.Clear();

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

            _pNavBar.ResumeLayout();
        }

        private void AddToNavBar(Type control, string text, int level = -1)
        {
            Control lbl = (Control)Activator.CreateInstance(control);
            lbl.Text = text;
            lbl.Margin = new Padding(0);
            lbl.Padding = new Padding(0);
            lbl.AutoSize = true;
            lbl.Tag = level;

            if (lbl is LinkLabel)
            {
                var link = lbl as LinkLabel;
                link.LinkClicked += Link_LinkClicked;
            }
            _pNavBar.Controls.Add(lbl);
        }

        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lbl = sender as Control;
            int level = Convert.ToInt32(lbl.Tag);
            for (int l = _paths.Count; l > level; l--)
            {
                if (_paths.Keys.Contains(l))
                    _paths.Remove(l);
            }
            manager.DrillUp(level);
        }

        private bool isDrilling = false;
        private void ChartMouseClick(object sender, MouseEventArgs e)
        {
            if (manager == null)
                return;
            if (isDrilling)
                return;
            else
                isDrilling = true;
            if (e.Button == MouseButtons.Right)
                manager.DrillUp();
            else
            {
                var hitInfo = flexChart1.HitTest(new Point(e.X, e.Y));
                if (hitInfo != null && hitInfo.Distance < 2)
                {
                    _currentValue = hitInfo.X;

                    var tooltip = flexChart1.ToolTip.Content;
                    flexChart1.ToolTip.Content = "Please wait while the details are being fetched";
                    flexChart1.Cursor = Cursors.WaitCursor;

                    IEnumerable<object> data = null;
                    FetchDataAsync(manager.DrillDownLevel).ContinueWith(t =>
                    {
                        data = t.Result;
                        flexChart1.Enabled = true;
                        flexChart1.Invoke(new Action(() =>
                        {
                            flexChart1.ToolTip.Hide(flexChart1);
                            flexChart1.ToolTip.Content = tooltip;
                            flexChart1.Cursor = Cursors.Default;
                            manager.DrillDown(data);
                        }));
                    });

                }
            }
        }
        private Task<IEnumerable<object>> FetchDataAsync(int drilldownLevel)
        {
            return System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                IEnumerable<object> data = null;
                switch (drilldownLevel)
                {
                    case 0:
                        data = HierarchicalDataSource.GetGroupedData("Country", _currentValue, "City");
                        break;
                    case 1:
                        data = HierarchicalDataSource.GetGroupedData("City", _currentValue, "Year");
                        break;
                    case 2:
                        data = HierarchicalDataSource.GetGroupedData("Year", _currentValue, "Month");
                        break;
                    case 3:
                        data = HierarchicalDataSource.GetGroupedData("Month", _currentValue, "Day");
                        break;
                    default:
                        break;
                }
                return data;
            });
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            _pNavBar = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false,
                Font = new Font(this.Font.FontFamily, 11),
                Padding = new Padding(5),
            };
            this.pnlControls.Controls.Add(_pNavBar);
        }
    }
}
