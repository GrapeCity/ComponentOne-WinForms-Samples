using C1.Framework;
using C1.Win.Input;
using CurrencyComparison.Resources;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Themes;
namespace CurrencyComparison
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series4 = new C1.Win.Chart.Series();
            rootLayoutPanel = new TableLayoutPanel();
            pnlChart = new Panel();
            chartMain = new C1.Win.Chart.FlexChart();
            pnlHeader = new Panel();
            btnToggleTheme = new C1Button();
            lblTitleDesc = new C1Label();
            lblTitle = new C1Label();
            pnlControls = new Panel();
            imgLegend = new C1PictureBox();
            lblPeriod = new C1Label();
            lblMeasure = new C1Label();
            lblBaseCurrency = new C1Label();
            cbMeasure = new C1ComboBox();
            cbCurrency = new C1ComboBox();
            pnlButtons = new Panel();
            rb10Years = new C1RadioButton();
            rb5Years = new C1RadioButton();
            rb1Year = new C1RadioButton();
            rb6Months = new C1RadioButton();
            rb1Month = new C1RadioButton();
            rb10Days = new C1RadioButton();
            rb5Days = new C1RadioButton();
            pnlRangeSelector = new Panel();
            pnlChartRangeSelector = new Panel();
            chartRangeSelector = new C1.Win.Chart.FlexChart();
            rootLayoutPanel.SuspendLayout();
            pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMain).BeginInit();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnToggleTheme).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTitleDesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblTitle).BeginInit();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLegend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblMeasure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lblBaseCurrency).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbMeasure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cbCurrency).BeginInit();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rb10Years).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb5Years).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb1Year).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb6Months).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb1Month).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb10Days).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rb5Days).BeginInit();
            pnlRangeSelector.SuspendLayout();
            pnlChartRangeSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRangeSelector).BeginInit();
            SuspendLayout();
            // 
            // rootLayoutPanel
            // 
            rootLayoutPanel.BackColor = Color.Transparent;
            resources.ApplyResources(rootLayoutPanel, "rootLayoutPanel");
            rootLayoutPanel.Controls.Add(pnlChart, 0, 2);
            rootLayoutPanel.Controls.Add(pnlHeader, 0, 0);
            rootLayoutPanel.Controls.Add(pnlControls, 0, 1);
            rootLayoutPanel.Controls.Add(pnlButtons, 0, 3);
            rootLayoutPanel.Controls.Add(pnlRangeSelector, 0, 4);
            rootLayoutPanel.Name = "rootLayoutPanel";
            // 
            // pnlChart
            // 
            pnlChart.Controls.Add(chartMain);
            resources.ApplyResources(pnlChart, "pnlChart");
            pnlChart.Name = "pnlChart";
            // 
            // chartMain
            // 
            chartMain.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartMain.AnimationLoad.Duration = 400;
            chartMain.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartMain.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartMain.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartMain.AnimationUpdate.Duration = 400;
            chartMain.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartMain.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartMain.AxisX.AxisLine = true;
            chartMain.AxisX.Chart = chartMain;
            chartMain.AxisX.DataSource = null;
            chartMain.AxisX.Formatter = null;
            chartMain.AxisX.GroupProvider = null;
            chartMain.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartMain.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartMain.AxisX.GroupVisibilityLevel = 0;
            chartMain.AxisX.PlotAreaName = null;
            chartMain.AxisX.Position = C1.Chart.Position.Bottom;
            chartMain.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartMain.AxisY.AxisLine = false;
            chartMain.AxisY.Chart = chartMain;
            chartMain.AxisY.DataSource = null;
            chartMain.AxisY.Formatter = null;
            chartMain.AxisY.GroupProvider = null;
            chartMain.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartMain.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartMain.AxisY.GroupVisibilityLevel = 0;
            chartMain.AxisY.MajorGrid = true;
            chartMain.AxisY.PlotAreaName = null;
            chartMain.AxisY.Position = C1.Chart.Position.Left;
            chartMain.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartMain.BackColor = Color.Transparent;
            resources.ApplyResources(chartMain, "chartMain");
            chartMain.ChartType = C1.Chart.ChartType.Line;
            chartMain.DataLabel.Angle = 0;
            chartMain.DataLabel.Border = false;
            chartMain.DataLabel.ConnectingLine = false;
            chartMain.DataLabel.Content = null;
            chartMain.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartMain.DataLabel.MaxAutoLabels = 100;
            chartMain.DataLabel.MaxLines = 0;
            chartMain.DataLabel.MaxWidth = 0;
            chartMain.DataLabel.Offset = 0;
            chartMain.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartMain.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartMain.DataLabel.Position = C1.Chart.LabelPosition.None;
            chartMain.Legend.ItemMaxWidth = 0;
            chartMain.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartMain.Legend.Position = C1.Chart.Position.Right;
            chartMain.Legend.Reversed = false;
            chartMain.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartMain.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartMain.Legend.Title = null;
            chartMain.Name = "chartMain";
            chartMain.Options.Chart = chartMain;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            chartMain.Options.ClusterSize = elementSize1;
            chartMain.PlotMargin = new Padding(0);
            chartMain.SelectedSeries = null;
            chartMain.SelectionStyle.FillColor = Color.Transparent;
            chartMain.SelectionStyle.StrokeColor = Color.Red;
            series1.Binding = "Y";
            series1.BindingX = "X";
            series1.DataLabel = null;
            series1.DataSource = new Point[]
    {
    new Point(1, 8),
    new Point(2, 12),
    new Point(3, 10),
    new Point(4, 12),
    new Point(5, 15)
    };
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            series2.Binding = "Y";
            series2.BindingX = "X";
            series2.DataLabel = null;
            series2.DataSource = new Point[]
    {
    new Point(1, 10),
    new Point(2, 16),
    new Point(3, 17),
    new Point(4, 15),
    new Point(5, 23)
    };
            series2.Name = "Series 2";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            series2.Tooltip = null;
            series3.Binding = "Y";
            series3.BindingX = "X";
            series3.DataLabel = null;
            series3.DataSource = new Point[]
    {
    new Point(1, 16),
    new Point(2, 19),
    new Point(3, 15),
    new Point(4, 22),
    new Point(5, 18)
    };
            series3.Name = "Series 3";
            series3.StackingGroup = -1;
            series3.Style.StrokeWidth = 2F;
            series3.Tooltip = null;
            chartMain.Series.Add(series1);
            chartMain.Series.Add(series2);
            chartMain.Series.Add(series3);
            chartMain.TabStop = false;
            // 
            // 
            // 
            chartMain.ToolTip.Content = "{value}";
            chartMain.MouseMove += chartMain_MouseMove;
            // 
            // pnlHeader
            // 
            resources.ApplyResources(pnlHeader, "pnlHeader");
            pnlHeader.BackColor = SystemColors.Window;
            pnlHeader.Controls.Add(btnToggleTheme);
            pnlHeader.Controls.Add(lblTitleDesc);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Name = "pnlHeader";
            // 
            // btnToggleTheme
            // 
            resources.ApplyResources(btnToggleTheme, "btnToggleTheme");
            btnToggleTheme.Icon = new C1BitmapIcon(null, new Size(12, 14), Color.Transparent, AppResources.ImgToggleThemeIcon);
            btnToggleTheme.ImageAlign = ContentAlignment.MiddleLeft;
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Styles.Hot.BackColor = Color.FromArgb(217, 217, 217);
            btnToggleTheme.Styles.Hot.BorderColor = Color.FromArgb(138, 138, 138);
            btnToggleTheme.Styles.Hot.ForeColor = SystemColors.WindowText;
            btnToggleTheme.Styles.HotPressed.BackColor = Color.FromArgb(217, 217, 217);
            btnToggleTheme.Styles.HotPressed.BorderColor = Color.FromArgb(184, 184, 184);
            btnToggleTheme.Styles.Padding = new Thickness(7, 4, 7, 4);
            btnToggleTheme.TextAlign = ContentAlignment.MiddleRight;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // lblTitleDesc
            // 
            resources.ApplyResources(lblTitleDesc, "lblTitleDesc");
            lblTitleDesc.Name = "lblTitleDesc";
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.Name = "lblTitle";
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.Transparent;
            pnlControls.Controls.Add(imgLegend);
            pnlControls.Controls.Add(lblPeriod);
            pnlControls.Controls.Add(lblMeasure);
            pnlControls.Controls.Add(lblBaseCurrency);
            pnlControls.Controls.Add(cbMeasure);
            pnlControls.Controls.Add(cbCurrency);
            resources.ApplyResources(pnlControls, "pnlControls");
            pnlControls.Name = "pnlControls";
            // 
            // imgLegend
            // 
            resources.ApplyResources(imgLegend, "imgLegend");
            imgLegend.BackgroundImage = AppResources.ImgLegendLight;
            imgLegend.Name = "imgLegend";
            imgLegend.TabStop = false;
            // 
            // lblPeriod
            // 
            resources.ApplyResources(lblPeriod, "lblPeriod");
            lblPeriod.Name = "lblPeriod";
            // 
            // lblMeasure
            // 
            resources.ApplyResources(lblMeasure, "lblMeasure");
            lblMeasure.Name = "lblMeasure";
            // 
            // lblBaseCurrency
            // 
            resources.ApplyResources(lblBaseCurrency, "lblBaseCurrency");
            lblBaseCurrency.Name = "lblBaseCurrency";
            // 
            // cbMeasure
            // 
            resources.ApplyResources(cbMeasure, "cbMeasure");
            cbMeasure.DropDownStyle = DropDownStyle.DropDownList;
            cbMeasure.InitialSelection = InitialSelection.CaretAtStart;
            cbMeasure.Name = "cbMeasure";
            cbMeasure.ReadOnly = true;
            cbMeasure.Styles.Button.Default.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.Hot.BackColor = SystemColors.Window;
            cbMeasure.Styles.Button.Hot.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.Hot.ForeColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.HotPressed.BackColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.HotPressed.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.Pressed.BackColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Button.Pressed.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Corners = new Corners(3, 3, 3, 3);
            cbMeasure.Styles.Default.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.DropDown.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.DropDown.Corners = new Corners(5, 5, 5, 5);
            cbMeasure.Styles.Focused.BorderColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Item.Hot.BackColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Item.Hot.ForeColor = Color.Black;
            cbMeasure.Styles.Item.HotPressed.BackColor = Color.FromArgb(217, 217, 217);
            cbMeasure.Styles.Item.HotPressed.ForeColor = Color.Black;
            cbMeasure.SelectedIndexChanged += cbMeasure_SelectedIndexChanged;
            // 
            // cbCurrency
            // 
            resources.ApplyResources(cbCurrency, "cbCurrency");
            cbCurrency.DropDownStyle = DropDownStyle.DropDownList;
            cbCurrency.InitialSelection = InitialSelection.CaretAtStart;
            cbCurrency.Name = "cbCurrency";
            cbCurrency.ReadOnly = true;
            cbCurrency.Styles.Button.Default.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.Hot.BackColor = SystemColors.Window;
            cbCurrency.Styles.Button.Hot.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.Hot.ForeColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.HotPressed.BackColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.HotPressed.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.Pressed.BackColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Button.Pressed.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Corners = new Corners(3, 3, 3, 3);
            cbCurrency.Styles.Default.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.DropDown.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.DropDown.Corners = new Corners(5, 5, 5, 5);
            cbCurrency.Styles.Focused.BorderColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Item.Hot.BackColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Item.Hot.ForeColor = Color.Black;
            cbCurrency.Styles.Item.HotPressed.BackColor = Color.FromArgb(217, 217, 217);
            cbCurrency.Styles.Item.HotPressed.ForeColor = Color.Black;
            cbCurrency.SelectedIndexChanged += cbCurrency_SelectedIndexChanged;
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.Transparent;
            pnlButtons.Controls.Add(rb10Years);
            pnlButtons.Controls.Add(rb5Years);
            pnlButtons.Controls.Add(rb1Year);
            pnlButtons.Controls.Add(rb6Months);
            pnlButtons.Controls.Add(rb1Month);
            pnlButtons.Controls.Add(rb10Days);
            pnlButtons.Controls.Add(rb5Days);
            resources.ApplyResources(pnlButtons, "pnlButtons");
            pnlButtons.Name = "pnlButtons";
            // 
            // rb10Years
            // 
            resources.ApplyResources(rb10Years, "rb10Years");
            rb10Years.Appearance = Appearance.Button;
            rb10Years.Name = "rb10Years";
            rb10Years.Styles.Corners = new Corners(0, 2, 0, 2);
            rb10Years.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb10Years.TabStop = true;
            rb10Years.Tag = "10Y";
            rb10Years.TextAlign = ContentAlignment.MiddleCenter;
            rb10Years.Click += btnTimeFrameChanged;
            // 
            // rb5Years
            // 
            resources.ApplyResources(rb5Years, "rb5Years");
            rb5Years.Appearance = Appearance.Button;
            rb5Years.Name = "rb5Years";
            rb5Years.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb5Years.TabStop = true;
            rb5Years.Tag = "5Y";
            rb5Years.TextAlign = ContentAlignment.MiddleCenter;
            rb5Years.Click += btnTimeFrameChanged;
            // 
            // rb1Year
            // 
            resources.ApplyResources(rb1Year, "rb1Year");
            rb1Year.Appearance = Appearance.Button;
            rb1Year.Name = "rb1Year";
            rb1Year.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb1Year.TabStop = true;
            rb1Year.Tag = "1Y";
            rb1Year.TextAlign = ContentAlignment.MiddleCenter;
            rb1Year.Click += btnTimeFrameChanged;
            // 
            // rb6Months
            // 
            resources.ApplyResources(rb6Months, "rb6Months");
            rb6Months.Appearance = Appearance.Button;
            rb6Months.Name = "rb6Months";
            rb6Months.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb6Months.TabStop = true;
            rb6Months.Tag = "6M";
            rb6Months.TextAlign = ContentAlignment.MiddleCenter;
            rb6Months.Click += btnTimeFrameChanged;
            // 
            // rb1Month
            // 
            resources.ApplyResources(rb1Month, "rb1Month");
            rb1Month.Appearance = Appearance.Button;
            rb1Month.Name = "rb1Month";
            rb1Month.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb1Month.TabStop = true;
            rb1Month.Tag = "1M";
            rb1Month.TextAlign = ContentAlignment.MiddleCenter;
            rb1Month.Click += btnTimeFrameChanged;
            // 
            // rb10Days
            // 
            resources.ApplyResources(rb10Days, "rb10Days");
            rb10Days.Appearance = Appearance.Button;
            rb10Days.Name = "rb10Days";
            rb10Days.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb10Days.TabStop = true;
            rb10Days.Tag = "10D";
            rb10Days.TextAlign = ContentAlignment.MiddleCenter;
            rb10Days.Click += btnTimeFrameChanged;
            // 
            // rb5Days
            // 
            resources.ApplyResources(rb5Days, "rb5Days");
            rb5Days.Appearance = Appearance.Button;
            rb5Days.Name = "rb5Days";
            rb5Days.Styles.Corners = new Corners(2, 0, 2, 0);
            rb5Days.Styles.Padding = new Thickness(0, 0, 0, 0);
            rb5Days.TabStop = true;
            rb5Days.Tag = "5D";
            rb5Days.TextAlign = ContentAlignment.MiddleCenter;
            rb5Days.Click += btnTimeFrameChanged;
            // 
            // pnlRangeSelector
            // 
            pnlRangeSelector.Controls.Add(pnlChartRangeSelector);
            resources.ApplyResources(pnlRangeSelector, "pnlRangeSelector");
            pnlRangeSelector.Name = "pnlRangeSelector";
            // 
            // pnlChartRangeSelector
            // 
            pnlChartRangeSelector.Controls.Add(chartRangeSelector);
            resources.ApplyResources(pnlChartRangeSelector, "pnlChartRangeSelector");
            pnlChartRangeSelector.Name = "pnlChartRangeSelector";
            pnlChartRangeSelector.SizeChanged += pnl_Resize;
            // 
            // chartRangeSelector
            // 
            chartRangeSelector.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartRangeSelector.AnimationLoad.Duration = 400;
            chartRangeSelector.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartRangeSelector.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartRangeSelector.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartRangeSelector.AnimationUpdate.Duration = 400;
            chartRangeSelector.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartRangeSelector.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartRangeSelector.AxisX.AxisLine = true;
            chartRangeSelector.AxisX.Chart = chartRangeSelector;
            chartRangeSelector.AxisX.DataSource = null;
            chartRangeSelector.AxisX.Formatter = null;
            chartRangeSelector.AxisX.GroupProvider = null;
            chartRangeSelector.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartRangeSelector.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartRangeSelector.AxisX.GroupVisibilityLevel = 0;
            chartRangeSelector.AxisX.MajorUnit = 366D;
            chartRangeSelector.AxisX.PlotAreaName = null;
            chartRangeSelector.AxisX.Position = C1.Chart.Position.Bottom;
            chartRangeSelector.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartRangeSelector.AxisY.AxisLine = false;
            chartRangeSelector.AxisY.Chart = chartRangeSelector;
            chartRangeSelector.AxisY.DataSource = null;
            chartRangeSelector.AxisY.Formatter = null;
            chartRangeSelector.AxisY.GroupProvider = null;
            chartRangeSelector.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartRangeSelector.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartRangeSelector.AxisY.GroupVisibilityLevel = 0;
            chartRangeSelector.AxisY.Labels = false;
            chartRangeSelector.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            chartRangeSelector.AxisY.PlotAreaName = null;
            chartRangeSelector.AxisY.Position = C1.Chart.Position.Left;
            chartRangeSelector.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartRangeSelector.DataLabel.Angle = 0;
            chartRangeSelector.DataLabel.Border = false;
            chartRangeSelector.DataLabel.ConnectingLine = false;
            chartRangeSelector.DataLabel.Content = null;
            chartRangeSelector.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartRangeSelector.DataLabel.MaxAutoLabels = 100;
            chartRangeSelector.DataLabel.MaxLines = 0;
            chartRangeSelector.DataLabel.MaxWidth = 0;
            chartRangeSelector.DataLabel.Offset = 0;
            chartRangeSelector.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartRangeSelector.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartRangeSelector.DataLabel.Position = C1.Chart.LabelPosition.None;
            resources.ApplyResources(chartRangeSelector, "chartRangeSelector");
            chartRangeSelector.Legend.ItemMaxWidth = 0;
            chartRangeSelector.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartRangeSelector.Legend.Position = C1.Chart.Position.None;
            chartRangeSelector.Legend.Reversed = false;
            chartRangeSelector.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartRangeSelector.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartRangeSelector.Legend.Title = null;
            chartRangeSelector.Name = "chartRangeSelector";
            chartRangeSelector.Options.Chart = chartRangeSelector;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            chartRangeSelector.Options.ClusterSize = elementSize2;
            chartRangeSelector.PlotMargin = new Padding(0);
            chartRangeSelector.SelectedSeries = null;
            chartRangeSelector.SelectionStyle.StrokeColor = Color.Red;
            series4.DataLabel = null;
            series4.Name = "Series 1";
            series4.StackingGroup = -1;
            series4.Style.StrokeWidth = 2F;
            series4.Tooltip = null;
            chartRangeSelector.Series.Add(series4);
            // 
            // 
            // 
            chartRangeSelector.ToolTip.Content = "{value}";
            chartRangeSelector.Rendered += chartRangeSelector_Rendered;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(rootLayoutPanel);
            Name = "MainForm";
            rootLayoutPanel.ResumeLayout(false);
            rootLayoutPanel.PerformLayout();
            pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMain).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnToggleTheme).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTitleDesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblTitle).EndInit();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLegend).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblMeasure).EndInit();
            ((System.ComponentModel.ISupportInitialize)lblBaseCurrency).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbMeasure).EndInit();
            ((System.ComponentModel.ISupportInitialize)cbCurrency).EndInit();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rb10Years).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb5Years).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb1Year).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb6Months).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb1Month).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb10Days).EndInit();
            ((System.ComponentModel.ISupportInitialize)rb5Days).EndInit();
            pnlRangeSelector.ResumeLayout(false);
            pnlChartRangeSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRangeSelector).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
        private System.Windows.Forms.Panel pnlChartRangeSelector;
        private C1.Win.Chart.FlexChart chartRangeSelector;
        private System.Windows.Forms.Panel pnlHeader;
        private C1.Win.Input.C1Label lblTitleDesc;
        private C1.Win.Input.C1Label lblTitle;
        private C1.Win.Input.C1Button btnToggleTheme;
        private C1ComboBox cbCurrency;
        private C1ComboBox cbMeasure;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlButtons;
        private C1RadioButton rb10Years;
        private C1RadioButton rb5Years;
        private C1RadioButton rb1Year;
        private C1RadioButton rb6Months;
        private C1RadioButton rb1Month;
        private C1RadioButton rb10Days;
        private C1RadioButton rb5Days;
        private FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.FlexChart chartMain;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlChart;
        private C1Label lblBaseCurrency;
        private C1Label lblMeasure;
        private C1Label lblPeriod;
        private C1PictureBox imgLegend;
        private Panel pnlRangeSelector;
    }
}

