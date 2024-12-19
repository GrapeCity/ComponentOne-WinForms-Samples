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

namespace FlexChartExplorer.Samples
{
    public partial class BasicDrillDown : FlexChartBaseSample
    {
        private FlexPie _flexPie;
        private ComboBoxEx _cbGroupBy, _cbAggregateType, _cbChartType;
        private LabelEx _lblGroupBy, _lblAggregateType, _lblChartType;
        private CheckBoxEx _chbEnableDrill;
        private FlowLayoutPanel _pNavBar;
        private string[] _groups = new string[]{ "Year,Country", "Country,Year", "Country,City","Country,City,Year","Year,Country,City"};
        private string[] _chartTypes = new string[] {"LineSymbols", "Column", "Pie" };

        DrillDownManager manager;
        bool isFlexChartShown = true;
        bool isDrillDownEnabled = true;
        private IDictionary<int, string> _paths = new Dictionary<int, string>();
        private FlexChart flexChart1;

        public BasicDrillDown()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            Queue<string> drilldownPath = new Queue<string>();
            drilldownPath.Enqueue("Year");
            drilldownPath.Enqueue("Country");

            var items = HierarchicalDataSource.GetFlatDataItems(500);
            manager = new DrillDownManager(items, "Amount", "Year,Country");
            manager.BeforeDrill += Manager_BeforeDrill;
            manager.AfterDrill += Manager_AfterDrill;
            //Triggers the AfterDrill event and update the chart as per the current DrillDownLevel
            manager.Refresh();

            //FlexChart settings
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Value";
            flexChart1.Series.Add(new Series() { Name="Value"});
            flexChart1.DataSource = manager.CurrentItems.Views;
            flexChart1.DataLabel.Style.Font = new Font("Segoe UI", 9);
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.Top;
            flexChart1.DataLabel.Content = "{y:n0}";
            flexChart1.ToolTip.Active = false;
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexChart1.MouseClick += ChartMouseClick;

            //FlexPie settings
            _flexPie.BindingName = "Name";
            _flexPie.Binding = "Value";
            _flexPie.DataSource = manager.CurrentItems.Views;
            _flexPie.DataLabel.Position = PieLabelPosition.Center;
            _flexPie.DataLabel.Content = "{name} | {value:n0}";
            _flexPie.ToolTip.Content = "{P:0}%";
            _flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;
            _flexPie.MouseClick += ChartMouseClick;
        }
        private void Manager_AfterDrill(object sender, DrillDownEventArgs e)
        {
            if (_cbChartType.SelectedIndex != -1)
            {
                switch (e.DrillDownPath)
                {
                    case "Year":
                        _cbChartType.SelectedIndex = isFlexChartShown ? 0 : 2;
                        break;
                    default:
                        _cbChartType.SelectedIndex = isFlexChartShown ? 1 : 2;
                        break;
                }
            }
            else
                flexChart1.ChartType = ChartType.LineSymbols;
            
            flexChart1.Header.Content = string.Format("{0}-wise Sales", e.DrillDownPath);
            _flexPie.Header.Content = string.Format("{0}-wise Sales", e.DrillDownPath);

            if (e.IsDrillDown)
            {
                if (_paths.ContainsKey(e.DrillDownLevel))
                    _paths.Remove(e.DrillDownLevel);
                _paths.Add(e.DrillDownLevel, manager.CurrentItems.Name);
            }
            UpdateChart();
        }

        private void Manager_BeforeDrill(object sender, DrillDownEventArgs e)
        {
            e.Cancel = !isDrillDownEnabled;
            if (isDrillDownEnabled && e.IsDrillDown == false && e.DrillDownLevel > 0)
            {
                _paths.Remove(e.DrillDownLevel);
            }

        }
        private void UpdateChart()
        {
            if (isFlexChartShown)
            {
                flexChart1.DataSource = manager.CurrentItems.Views;
                UpdateNavBar();
            }
            else
            {
                _flexPie.Enabled = false;
                _flexPie.DataSource = manager.CurrentItems.Views;
                _flexPie.Enabled = true;
                UpdateNavBar();
            }
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

            if (lbl is LinkLabel)
            {
                var link = lbl as LinkLabel;
                link.LinkClicked += (s, e) => manager.DrillUp(level);
            }
            _pNavBar.Controls.Add(lbl);
        }
        private void ChartMouseClick(object sender, MouseEventArgs e)
        {
            var flexChart = sender as FlexChartBase;
            var hitInfo = flexChart.HitTest(new Point(e.X, e.Y));
            if (hitInfo != null && hitInfo.Distance < 2)
            {
                if (manager != null)
                {
                    manager.DrillDown(hitInfo.PointIndex);
                }
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _flexPie = new FlexPie() { Dock = DockStyle.Fill, BackColor = Color.White };

            _cbGroupBy = new ComboBoxEx("Group By") { Width = 160, ItemsDataSource=_groups };
            _cbGroupBy.SelectedIndex = 0;
            _cbGroupBy.SelectedIndexChanged += _cbGroupBy_SelectedIndexChanged;

            _cbAggregateType = ControlFactory.EnumBasedCombo(typeof(AggregateType), "Aggregate Type");
            _cbAggregateType.Width = 160;
            _cbAggregateType.SelectedIndexChanged += (s, e) => 
            {
                manager.AggregateType = (AggregateType)Enum.Parse(typeof(AggregateType), _cbAggregateType.SelectedItem.DisplayText);
                UpdateChart();
            };

            _cbChartType = new ComboBoxEx("Chart Type") { ItemsDataSource = _chartTypes };
            _cbChartType.SelectedIndex = 0;
            _cbChartType.SelectedIndexChanged += _cbChartType_SelectedIndexChanged;

            _chbEnableDrill = new CheckBoxEx("Enable DrillDown") { Checked = isDrillDownEnabled};
            _chbEnableDrill.CheckedChanged += (s, e) => { isDrillDownEnabled = _chbEnableDrill.Checked; };

            _pNavBar = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                WrapContents = false,
                Font = new Font(this.Font.FontFamily, 11),
                Padding = new Padding(5),
            };

            _lblGroupBy = new LabelEx("Group By:");
            _lblAggregateType = new LabelEx("Aggregate Type:");
            _lblChartType = new LabelEx("Chart Type:");

            this.pnlControls.AutoSize = true;
            this.pnlControls.Controls.Add(_lblGroupBy);
            this.pnlControls.Controls.Add(_cbGroupBy);
            this.pnlControls.Controls.Add(_lblAggregateType);
            this.pnlControls.Controls.Add(_cbAggregateType);
            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_chbEnableDrill);
            this.pnlControls.Controls.Add(_pNavBar);
            this.pnlControls.SetFlowBreak(_chbEnableDrill, true);
        }

        private void _cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedText = _cbChartType.SelectedItem.ToString();
            if (selectedText == "Pie")
            {
                isFlexChartShown = false;
                this.pnlMain.Controls.Clear();
                this.pnlMain.Controls.Add(_flexPie);
            }
            else
            {
                flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), selectedText);
                isFlexChartShown = true;
                this.pnlMain.Controls.Clear();
                this.pnlMain.Controls.Add(flexChart1);
            }
            UpdateChart();
        }

        private void _cbGroupBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Queue<string> drilldownPath = new Queue<string>();
            var selectedText = _cbGroupBy.SelectedItem.ToString();
            var groups = selectedText.Split(',');
            foreach (var group in groups)
            {
                drilldownPath.Enqueue(group.Trim());
            }
            manager.DrillDownPath = selectedText;
            UpdateChart();
        }
    }
}
