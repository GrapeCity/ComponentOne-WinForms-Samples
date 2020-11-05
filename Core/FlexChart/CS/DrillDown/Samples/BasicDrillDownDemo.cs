using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Linq;
using C1.Chart;

namespace DrillDown.Samples
{
    public partial class BasicDrillDownDemo : UserControl
    {
        DrillDownManager manager;
        bool isFlexChartShown = true;
        bool isDrillDownEnabled = true;
        private IDictionary<int, string> _paths = new Dictionary<int, string>();
        public BasicDrillDownDemo()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            Queue<string> drilldownPath = new Queue<string>();
            drilldownPath.Enqueue("Year");
            drilldownPath.Enqueue("Country");

            List<Item> items = DataService.Instance.GetData(500);
            manager = new DrillDownManager(items,"Amount","Year,Country");
            manager.BeforeDrill += Manager_BeforeDrill;
            manager.AfterDrill += Manager_AfterDrill;
            //Triggers the AfterDrill event and update the chart as per the current DrillDownLevel
            manager.Refresh();

            flexChart1.BeginUpdate();
            flexChart1.Name = "flexChart1";
            flexChart1.ToolTip.Content = "{value}";
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

            flexPie1.BeginUpdate();
            flexPie1.Name = "flexPie1";
            flexPie1.ToolTip.Content = "{value}";
            // Set x-binding and add data to the chart
            flexPie1.Binding = "Value";
            flexPie1.BindingName = "Name";
            flexPie1.DataLabel.Position = C1.Chart.PieLabelPosition.Center;
            flexPie1.DataLabel.Border = true;
            flexPie1.DataLabel.Content = "{name} | {y}";
            flexPie1.DataSource = manager.CurrentItems.Views;
            flexPie1.MouseClick += ChartMouseClick;
            flexPie1.EndUpdate();
        }


        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("basicDrillDown", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("basicDrillDown", "description").MakeRtf();

            cbChartType = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            cbAggregateType = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            cbGroupBy = new ComboBox()
            {
                Size = new Size(200, 21),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.DimGray
            };
            flexChart1 = baseSample1.flexChart1;

            flexPie1 = new FlexPie()
            {
                Dock = DockStyle.Fill,
                Visible = true,
                BackColor = Color.White,
            };

            chkEnableDrill = new CheckBox
            {
                Text = "Enable DrillDown",
                Checked = isDrillDownEnabled,
                AutoSize = true
            };

            pnlNavBar = new FlowLayoutPanel()
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Font = new Font(this.Font.FontFamily, 11),
                Padding = new Padding(5)
            };

            chkEnableDrill.CheckedChanged += (o, e) =>
            {
                isDrillDownEnabled = chkEnableDrill.Checked;
            };

            foreach (var item in Enum.GetValues(typeof(AggregateType)))
                cbAggregateType.Items.Add(new ComboBoxItem("Aggregate Type") { Text = ((AggregateType)item).ToString(), Value = (int)item });
            cbAggregateType.SelectedIndex = 0;

            cbAggregateType.SelectedIndexChanged += (o, e) =>
            {
                manager.AggregateType = (AggregateType)Enum.Parse(typeof(AggregateType), (cbAggregateType.SelectedItem as ComboBoxItem).Text);
                UpdateChart();
            };

            cbChartType.Items.Add(new ComboBoxItem("Chart Type") { Text = "Column" });
            cbChartType.Items.Add(new ComboBoxItem("Chart Type") { Text = "LineSymbols" });
            cbChartType.Items.Add(new ComboBoxItem("Chart Type") { Text = "Pie" });
            cbChartType.SelectedIndex = 0;
            cbChartType.SelectedIndexChanged += (o, e) =>
            {
                var selectedText = (cbChartType.SelectedItem as ComboBoxItem).Text;
                if (selectedText == "Pie")
                {
                    isFlexChartShown = false;
                    baseSample1.pChart.Controls.Clear();
                    baseSample1.pChart.Controls.Add(flexPie1);
                }
                else
                {
                    flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), selectedText);
                    isFlexChartShown = true;
                    baseSample1.pChart.Controls.Clear();
                    baseSample1.pChart.Controls.Add(flexChart1);
                }
                UpdateChart();
            };

            cbGroupBy.Items.Add(new ComboBoxItem("Group By") { Text = "Country,City", Value = 0 });
            cbGroupBy.Items.Add(new ComboBoxItem("Group By") { Text = "Country,Year", Value = 1 });
            cbGroupBy.Items.Add(new ComboBoxItem("Group By") { Text = "Year,Country", Value = 2 });
            cbGroupBy.Items.Add(new ComboBoxItem("Group By") { Text = "Country,City,Year", Value = 3 });
            cbGroupBy.Items.Add(new ComboBoxItem("Group By") { Text = "Year,Country,City", Value = 4 });
            cbGroupBy.SelectedIndex = 2;
            cbGroupBy.SelectedIndexChanged += (o, e) =>
            {
                Queue<string> drilldownPath = new Queue<string>();
                var selectedText = (cbGroupBy.SelectedItem as ComboBoxItem).Text;
                var groups = selectedText.Split(',');
                foreach (var group in groups)
                {
                    drilldownPath.Enqueue(group.Trim());
                }
                manager.DrillDownPath = selectedText;
                UpdateChart();
            };
            baseSample1.pControls.WrapContents = true;
            baseSample1.pControls.AutoSize = true;
            baseSample1.pControls.Controls.Add(cbGroupBy);
            baseSample1.pControls.Controls.Add(cbAggregateType);
            baseSample1.pControls.Controls.Add(cbChartType);
            baseSample1.pControls.Controls.Add(chkEnableDrill);
            baseSample1.pControls.Controls.Add(pnlNavBar);
            baseSample1.pControls.SetFlowBreak(chkEnableDrill, true);
        }
        private void Manager_AfterDrill(object sender, DrillDownEventArgs e)
        {
            switch (e.DrillDownPath)
            {
                case "Year":
                    cbChartType.SelectedIndex = isFlexChartShown ? 1 : 2;
                    break;
                default:
                    cbChartType.SelectedIndex = isFlexChartShown ? 0 : 2;
                    break;
            }
            flexChart1.Footer.Content = string.Format("{0}-wise Sales", e.DrillDownPath);
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

        private void UpdateChart()
        {
            if (isFlexChartShown)
            {
                flexChart1.DataSource = manager.CurrentItems.Views;
                UpdateNavBar();
            }
            else
            {
                flexPie1.Enabled = false;
                flexPie1.DataSource = manager.CurrentItems.Views;
                flexPie1.Enabled = true;
                UpdateNavBar();
            }
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
                    if (i == _paths.Count -1)
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

        private void AddToNavBar(Type control,string text,int level=-1)
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