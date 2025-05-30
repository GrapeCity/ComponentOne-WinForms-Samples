﻿namespace CurrencyComparison
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
            this.rootLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnThemeToggle = new C1.Win.C1Input.C1Button();
            this.lblDescription = new C1.Win.C1Input.C1Label();
            this.lblTitle = new C1.Win.C1Input.C1Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.imgLegend = new C1.Win.C1Input.C1PictureBox();
            this.lblPeriod = new C1.Win.C1Input.C1Label();
            this.lblMeasure = new C1.Win.C1Input.C1Label();
            this.lblBaseCurrency = new C1.Win.C1Input.C1Label();
            this.cbMeasure = new C1.Win.C1Input.C1ComboBox();
            this.cbCurrency = new C1.Win.C1Input.C1ComboBox();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.chartMain = new C1.Win.Chart.FlexChart();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.rb5Days = new System.Windows.Forms.RadioButton();
            this.rb10Years = new System.Windows.Forms.RadioButton();
            this.rb5Years = new System.Windows.Forms.RadioButton();
            this.rb1Year = new System.Windows.Forms.RadioButton();
            this.rb6Months = new System.Windows.Forms.RadioButton();
            this.rb1Month = new System.Windows.Forms.RadioButton();
            this.rb10Days = new System.Windows.Forms.RadioButton();
            this.pnlRangeSelector = new System.Windows.Forms.Panel();
            this.pnlChartRangeSelector = new System.Windows.Forms.Panel();
            this.chartRangeSelector = new C1.Win.Chart.FlexChart();
            this.rootLayoutPanel.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemeToggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaseCurrency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).BeginInit();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.pnlRangeSelector.SuspendLayout();
            this.pnlChartRangeSelector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // rootLayoutPanel
            // 
            resources.ApplyResources(this.rootLayoutPanel, "rootLayoutPanel");
            this.rootLayoutPanel.Controls.Add(this.pnlTop, 0, 0);
            this.rootLayoutPanel.Controls.Add(this.pnlControls, 0, 1);
            this.rootLayoutPanel.Controls.Add(this.pnlChart, 0, 2);
            this.rootLayoutPanel.Controls.Add(this.pnlButtons, 0, 3);
            this.rootLayoutPanel.Controls.Add(this.pnlRangeSelector, 0, 4);
            this.rootLayoutPanel.Name = "rootLayoutPanel";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Window;
            this.pnlTop.Controls.Add(this.btnThemeToggle);
            this.pnlTop.Controls.Add(this.lblDescription);
            this.pnlTop.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.pnlTop, "pnlTop");
            this.pnlTop.Name = "pnlTop";
            // 
            // btnThemeToggle
            // 
            resources.ApplyResources(this.btnThemeToggle, "btnThemeToggle");
            this.btnThemeToggle.Name = "btnThemeToggle";
            this.btnThemeToggle.UseVisualStyleBackColor = true;
            this.btnThemeToggle.UseVisualStyleForeColor = false;
            this.btnThemeToggle.Click += new System.EventHandler(this.btnToggleTheme_Click);
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.Name = "lblDescription";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblTitle.Name = "lblTitle";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.imgLegend);
            this.pnlControls.Controls.Add(this.lblPeriod);
            this.pnlControls.Controls.Add(this.lblMeasure);
            this.pnlControls.Controls.Add(this.lblBaseCurrency);
            this.pnlControls.Controls.Add(this.cbMeasure);
            this.pnlControls.Controls.Add(this.cbCurrency);
            resources.ApplyResources(this.pnlControls, "pnlControls");
            this.pnlControls.Name = "pnlControls";
            // 
            // imgLegend
            // 
            resources.ApplyResources(this.imgLegend, "imgLegend");
            this.imgLegend.BackColor = System.Drawing.Color.Transparent;
            this.imgLegend.Name = "imgLegend";
            this.imgLegend.TabStop = false;
            // 
            // lblPeriod
            // 
            resources.ApplyResources(this.lblPeriod, "lblPeriod");
            this.lblPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblPeriod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPeriod.Name = "lblPeriod";
            // 
            // lblMeasure
            // 
            resources.ApplyResources(this.lblMeasure, "lblMeasure");
            this.lblMeasure.BackColor = System.Drawing.Color.Transparent;
            this.lblMeasure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblMeasure.Name = "lblMeasure";
            // 
            // lblBaseCurrency
            // 
            resources.ApplyResources(this.lblBaseCurrency, "lblBaseCurrency");
            this.lblBaseCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblBaseCurrency.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblBaseCurrency.Name = "lblBaseCurrency";
            // 
            // cbMeasure
            // 
            this.cbMeasure.AllowSpinLoop = false;
            resources.ApplyResources(this.cbMeasure, "cbMeasure");
            this.cbMeasure.BackColor = System.Drawing.Color.Transparent;
            this.cbMeasure.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbMeasure.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbMeasure.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbMeasure.Name = "cbMeasure";
            this.cbMeasure.SelectedIndexChanged += new System.EventHandler(this.cbMeasure_SelectedIndexChanged);
            // 
            // cbCurrency
            // 
            this.cbCurrency.AllowSpinLoop = false;
            resources.ApplyResources(this.cbCurrency, "cbCurrency");
            this.cbCurrency.BackColor = System.Drawing.Color.Transparent;
            this.cbCurrency.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbCurrency.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbCurrency.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.SelectedIndexChanged += new System.EventHandler(this.cbCurrency_SelectedIndexChanged);
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.Transparent;
            this.pnlChart.Controls.Add(this.chartMain);
            resources.ApplyResources(this.pnlChart, "pnlChart");
            this.pnlChart.Name = "pnlChart";
            // 
            // chartMain
            // 
            this.chartMain.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartMain.AxisX.AxisLine = true;
            this.chartMain.AxisX.Chart = this.chartMain;
            this.chartMain.AxisX.DataSource = null;
            this.chartMain.AxisX.Formatter = null;
            this.chartMain.AxisX.GroupProvider = null;
            this.chartMain.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartMain.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartMain.AxisX.GroupVisibilityLevel = 0;
            this.chartMain.AxisX.PlotAreaName = null;
            this.chartMain.AxisX.Position = C1.Chart.Position.Bottom;
            this.chartMain.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartMain.AxisY.AxisLine = false;
            this.chartMain.AxisY.Chart = this.chartMain;
            this.chartMain.AxisY.DataSource = null;
            this.chartMain.AxisY.Formatter = null;
            this.chartMain.AxisY.GroupProvider = null;
            this.chartMain.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartMain.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartMain.AxisY.GroupVisibilityLevel = 0;
            this.chartMain.AxisY.MajorGrid = true;
            this.chartMain.AxisY.PlotAreaName = null;
            this.chartMain.AxisY.Position = C1.Chart.Position.Left;
            this.chartMain.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.chartMain, "chartMain");
            this.chartMain.ChartType = C1.Chart.ChartType.Line;
            this.chartMain.DataLabel.Angle = 0;
            this.chartMain.DataLabel.Border = false;
            this.chartMain.DataLabel.ConnectingLine = false;
            this.chartMain.DataLabel.Content = null;
            this.chartMain.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartMain.DataLabel.MaxAutoLabels = 100;
            this.chartMain.DataLabel.MaxLines = 0;
            this.chartMain.DataLabel.MaxWidth = 0;
            this.chartMain.DataLabel.Offset = 0;
            this.chartMain.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartMain.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartMain.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartMain.Legend.ItemMaxWidth = 0;
            this.chartMain.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartMain.Legend.Position = C1.Chart.Position.Right;
            this.chartMain.Legend.Reversed = false;
            this.chartMain.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartMain.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartMain.Legend.Title = null;
            this.chartMain.Name = "chartMain";
            this.chartMain.Options.Chart = this.chartMain;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.chartMain.Options.ClusterSize = elementSize1;
            this.chartMain.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartMain.SelectedSeries = null;
            this.chartMain.SelectionStyle.FillColor = System.Drawing.Color.Transparent;
            this.chartMain.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Binding = "Y";
            series1.BindingX = "X";
            series1.DataLabel = null;
            series1.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 8),
        new System.Drawing.Point(2, 12),
        new System.Drawing.Point(3, 10),
        new System.Drawing.Point(4, 12),
        new System.Drawing.Point(5, 15)};
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            series2.Binding = "Y";
            series2.BindingX = "X";
            series2.DataLabel = null;
            series2.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 10),
        new System.Drawing.Point(2, 16),
        new System.Drawing.Point(3, 17),
        new System.Drawing.Point(4, 15),
        new System.Drawing.Point(5, 23)};
            series2.Name = "Series 2";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            series2.Tooltip = null;
            series3.Binding = "Y";
            series3.BindingX = "X";
            series3.DataLabel = null;
            series3.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 16),
        new System.Drawing.Point(2, 19),
        new System.Drawing.Point(3, 15),
        new System.Drawing.Point(4, 22),
        new System.Drawing.Point(5, 18)};
            series3.Name = "Series 3";
            series3.StackingGroup = -1;
            series3.Style.StrokeWidth = 2F;
            series3.Tooltip = null;
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Series.Add(series3);
            this.chartMain.TabStop = false;
            // 
            // 
            // 
            this.chartMain.ToolTip.Content = "{value}";
            this.chartMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartMain_MouseMove);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.rb5Days);
            this.pnlButtons.Controls.Add(this.rb10Years);
            this.pnlButtons.Controls.Add(this.rb5Years);
            this.pnlButtons.Controls.Add(this.rb1Year);
            this.pnlButtons.Controls.Add(this.rb6Months);
            this.pnlButtons.Controls.Add(this.rb1Month);
            this.pnlButtons.Controls.Add(this.rb10Days);
            resources.ApplyResources(this.pnlButtons, "pnlButtons");
            this.pnlButtons.Name = "pnlButtons";
            // 
            // rb5Days
            // 
            resources.ApplyResources(this.rb5Days, "rb5Days");
            this.rb5Days.BackColor = System.Drawing.Color.Transparent;
            this.rb5Days.Name = "rb5Days";
            this.rb5Days.Tag = "5D";
            this.rb5Days.UseVisualStyleBackColor = false;
            this.rb5Days.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb10Years
            // 
            resources.ApplyResources(this.rb10Years, "rb10Years");
            this.rb10Years.BackColor = System.Drawing.Color.Transparent;
            this.rb10Years.Name = "rb10Years";
            this.rb10Years.Tag = "10Y";
            this.rb10Years.UseVisualStyleBackColor = false;
            this.rb10Years.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb5Years
            // 
            resources.ApplyResources(this.rb5Years, "rb5Years");
            this.rb5Years.BackColor = System.Drawing.Color.Transparent;
            this.rb5Years.Name = "rb5Years";
            this.rb5Years.Tag = "5Y";
            this.rb5Years.UseVisualStyleBackColor = false;
            this.rb5Years.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb1Year
            // 
            resources.ApplyResources(this.rb1Year, "rb1Year");
            this.rb1Year.BackColor = System.Drawing.Color.Transparent;
            this.rb1Year.Name = "rb1Year";
            this.rb1Year.Tag = "1Y";
            this.rb1Year.UseVisualStyleBackColor = false;
            this.rb1Year.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb6Months
            // 
            resources.ApplyResources(this.rb6Months, "rb6Months");
            this.rb6Months.BackColor = System.Drawing.Color.Transparent;
            this.rb6Months.Name = "rb6Months";
            this.rb6Months.Tag = "6M";
            this.rb6Months.UseVisualStyleBackColor = false;
            this.rb6Months.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb1Month
            // 
            resources.ApplyResources(this.rb1Month, "rb1Month");
            this.rb1Month.BackColor = System.Drawing.Color.Transparent;
            this.rb1Month.Checked = true;
            this.rb1Month.Name = "rb1Month";
            this.rb1Month.TabStop = true;
            this.rb1Month.Tag = "1M";
            this.rb1Month.UseVisualStyleBackColor = false;
            this.rb1Month.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // rb10Days
            // 
            resources.ApplyResources(this.rb10Days, "rb10Days");
            this.rb10Days.BackColor = System.Drawing.Color.Transparent;
            this.rb10Days.Name = "rb10Days";
            this.rb10Days.Tag = "10D";
            this.rb10Days.UseVisualStyleBackColor = false;
            this.rb10Days.Click += new System.EventHandler(this.btnTimeFrameChanged);
            // 
            // pnlRangeSelector
            // 
            this.pnlRangeSelector.Controls.Add(this.pnlChartRangeSelector);
            resources.ApplyResources(this.pnlRangeSelector, "pnlRangeSelector");
            this.pnlRangeSelector.Name = "pnlRangeSelector";
            // 
            // pnlChartRangeSelector
            // 
            this.pnlChartRangeSelector.BackColor = System.Drawing.SystemColors.Window;
            this.pnlChartRangeSelector.Controls.Add(this.chartRangeSelector);
            resources.ApplyResources(this.pnlChartRangeSelector, "pnlChartRangeSelector");
            this.pnlChartRangeSelector.Name = "pnlChartRangeSelector";
            // 
            // chartRangeSelector
            // 
            this.chartRangeSelector.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartRangeSelector.AxisX.AxisLine = true;
            this.chartRangeSelector.AxisX.Chart = this.chartRangeSelector;
            this.chartRangeSelector.AxisX.DataSource = null;
            this.chartRangeSelector.AxisX.Formatter = null;
            this.chartRangeSelector.AxisX.GroupProvider = null;
            this.chartRangeSelector.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartRangeSelector.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartRangeSelector.AxisX.GroupVisibilityLevel = 0;
            this.chartRangeSelector.AxisX.MajorUnit = 366D;
            this.chartRangeSelector.AxisX.PlotAreaName = null;
            this.chartRangeSelector.AxisX.Position = C1.Chart.Position.Bottom;
            this.chartRangeSelector.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartRangeSelector.AxisY.AxisLine = false;
            this.chartRangeSelector.AxisY.Chart = this.chartRangeSelector;
            this.chartRangeSelector.AxisY.DataSource = null;
            this.chartRangeSelector.AxisY.Formatter = null;
            this.chartRangeSelector.AxisY.GroupProvider = null;
            this.chartRangeSelector.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartRangeSelector.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartRangeSelector.AxisY.GroupVisibilityLevel = 0;
            this.chartRangeSelector.AxisY.Labels = false;
            this.chartRangeSelector.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartRangeSelector.AxisY.PlotAreaName = null;
            this.chartRangeSelector.AxisY.Position = C1.Chart.Position.Left;
            this.chartRangeSelector.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartRangeSelector.BackColor = System.Drawing.Color.Transparent;
            this.chartRangeSelector.DataLabel.Angle = 0;
            this.chartRangeSelector.DataLabel.Border = false;
            this.chartRangeSelector.DataLabel.ConnectingLine = false;
            this.chartRangeSelector.DataLabel.Content = null;
            this.chartRangeSelector.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartRangeSelector.DataLabel.MaxAutoLabels = 100;
            this.chartRangeSelector.DataLabel.MaxLines = 0;
            this.chartRangeSelector.DataLabel.MaxWidth = 0;
            this.chartRangeSelector.DataLabel.Offset = 0;
            this.chartRangeSelector.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartRangeSelector.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartRangeSelector.DataLabel.Position = C1.Chart.LabelPosition.None;
            resources.ApplyResources(this.chartRangeSelector, "chartRangeSelector");
            this.chartRangeSelector.Legend.ItemMaxWidth = 0;
            this.chartRangeSelector.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartRangeSelector.Legend.Position = C1.Chart.Position.None;
            this.chartRangeSelector.Legend.Reversed = false;
            this.chartRangeSelector.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartRangeSelector.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartRangeSelector.Legend.Title = null;
            this.chartRangeSelector.Name = "chartRangeSelector";
            this.chartRangeSelector.Options.Chart = this.chartRangeSelector;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartRangeSelector.Options.ClusterSize = elementSize2;
            this.chartRangeSelector.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartRangeSelector.SelectedSeries = null;
            this.chartRangeSelector.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series4.DataLabel = null;
            series4.Name = "Series 1";
            series4.StackingGroup = -1;
            series4.Style.StrokeWidth = 2F;
            series4.Tooltip = null;
            this.chartRangeSelector.Series.Add(series4);
            // 
            // 
            // 
            this.chartRangeSelector.ToolTip.Content = "{value}";
            this.chartRangeSelector.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartRangeSelector_Rendered);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.rootLayoutPanel);
            this.Name = "MainForm";
            this.rootLayoutPanel.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnThemeToggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBaseCurrency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbCurrency)).EndInit();
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.pnlRangeSelector.ResumeLayout(false);
            this.pnlChartRangeSelector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel rootLayoutPanel;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.RadioButton rb5Days;
        private System.Windows.Forms.RadioButton rb10Years;
        private System.Windows.Forms.RadioButton rb5Years;
        private System.Windows.Forms.RadioButton rb1Year;
        private System.Windows.Forms.RadioButton rb6Months;
        private System.Windows.Forms.RadioButton rb1Month;
        private System.Windows.Forms.RadioButton rb10Days;
        private System.Windows.Forms.Panel pnlChart;
        private C1.Win.Chart.FlexChart chartMain;
        private System.Windows.Forms.Panel pnlControls;
        private C1.Win.C1Input.C1ComboBox cbMeasure;
        private C1.Win.C1Input.C1ComboBox cbCurrency;
        private C1.Win.Chart.FlexChart chartRangeSelector;
        private C1.Win.C1Input.C1Label lblBaseCurrency;
        private C1.Win.C1Input.C1Label lblPeriod;
        private C1.Win.C1Input.C1Label lblMeasure;
        private C1.Win.C1Input.C1PictureBox imgLegend;
        private System.Windows.Forms.Panel pnlRangeSelector;
        private System.Windows.Forms.Panel pnlChartRangeSelector;
        private C1.Win.C1Input.C1Label lblTitle;
        private C1.Win.C1Input.C1Label lblDescription;
        private C1.Win.C1Input.C1Button btnThemeToggle;
    }
}

