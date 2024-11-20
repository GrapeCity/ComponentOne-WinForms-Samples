using FinancialChartExplorer.CustomControls;
using System;

namespace FinancialChartExplorer.Samples
{
    partial class Overlays
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.c1OverlayType = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.period = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMultiplier = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSize = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label5 = new System.Windows.Forms.Label();
            this.c1MvaType = new C1.Win.C1Input.C1ComboBox();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.conversionPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.baseLabel = new System.Windows.Forms.Label();
            this.basePeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.leadingLabel = new System.Windows.Forms.Label();
            this.leadingPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.laggingLabel = new System.Windows.Forms.Label();
            this.laggingPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.jawPeriodLabel = new System.Windows.Forms.Label();
            this.jawPeriodNumberic = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.teethPeriodLabel = new System.Windows.Forms.Label();
            this.teethPeriodNumberic = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.lipsPeriodLabel = new System.Windows.Forms.Label();
            this.lipsPeriodNumberic = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.zigZagDistanceLabel = new System.Windows.Forms.Label();
            this.zigZagDistanceNumberic = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1OverlayType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MvaType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laggingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jawPeriodNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teethPeriodNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lipsPeriodNumberic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zigZagDistanceNumberic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // financialChart1
            // 
            this.financialChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.financialChart1.AnimationLoad.Duration = 400;
            this.financialChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.financialChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.financialChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.financialChart1.AnimationUpdate.Duration = 400;
            this.financialChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.financialChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.financialChart1.AxisX.AxisLine = true;
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.DataSource = null;
            this.financialChart1.AxisX.Formatter = null;
            this.financialChart1.AxisX.GroupProvider = null;
            this.financialChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisX.GroupVisibilityLevel = 0;
            this.financialChart1.AxisX.PlotAreaName = null;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.DataSource = null;
            this.financialChart1.AxisY.Formatter = null;
            this.financialChart1.AxisY.GroupProvider = null;
            this.financialChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisY.GroupVisibilityLevel = 0;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.PlotAreaName = null;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.DataLabel.Angle = 0;
            this.financialChart1.DataLabel.Border = false;
            this.financialChart1.DataLabel.ConnectingLine = false;
            this.financialChart1.DataLabel.Content = null;
            this.financialChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.financialChart1.DataLabel.MaxAutoLabels = 100;
            this.financialChart1.DataLabel.MaxLines = 0;
            this.financialChart1.DataLabel.MaxWidth = 0;
            this.financialChart1.DataLabel.Offset = 0;
            this.financialChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.financialChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.financialChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(0, 0);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(0);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            this.financialChart1.Options.Chart = this.financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(800, 101);
            this.financialChart1.TabIndex = 0;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1OverlayType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.period);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudMultiplier);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudSize);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.c1MvaType);
            this.flowLayoutPanel1.Controls.Add(this.conversionLabel);
            this.flowLayoutPanel1.Controls.Add(this.conversionPeriod);
            this.flowLayoutPanel1.Controls.Add(this.baseLabel);
            this.flowLayoutPanel1.Controls.Add(this.basePeriod);
            this.flowLayoutPanel1.Controls.Add(this.leadingLabel);
            this.flowLayoutPanel1.Controls.Add(this.leadingPeriod);
            this.flowLayoutPanel1.Controls.Add(this.laggingLabel);
            this.flowLayoutPanel1.Controls.Add(this.laggingPeriod);
            this.flowLayoutPanel1.Controls.Add(this.jawPeriodLabel);
            this.flowLayoutPanel1.Controls.Add(this.jawPeriodNumberic);
            this.flowLayoutPanel1.Controls.Add(this.teethPeriodLabel);
            this.flowLayoutPanel1.Controls.Add(this.teethPeriodNumberic);
            this.flowLayoutPanel1.Controls.Add(this.lipsPeriodLabel);
            this.flowLayoutPanel1.Controls.Add(this.lipsPeriodNumberic);
            this.flowLayoutPanel1.Controls.Add(this.zigZagDistanceLabel);
            this.flowLayoutPanel1.Controls.Add(this.zigZagDistanceNumberic);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 101);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 171);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overlay Type:";
            // 
            // c1OverlayType
            // 
            this.c1OverlayType.AllowSpinLoop = false;
            this.c1OverlayType.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1OverlayType.GapHeight = 5;
            this.c1OverlayType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1OverlayType.Location = new System.Drawing.Point(150, 18);
            this.c1OverlayType.Name = "c1OverlayType";
            this.c1OverlayType.Size = new System.Drawing.Size(155, 37);
            this.c1OverlayType.TabIndex = 25;
            this.c1OverlayType.Tag = null;
            this.c1OverlayType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1OverlayType.SelectedIndexChanged += new System.EventHandler(this.c1OverlayType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period:";
            // 
            // period
            // 
            this.period.GapHeight = 0;
            this.period.ImagePadding = new System.Windows.Forms.Padding(0);
            this.period.Location = new System.Drawing.Point(406, 18);
            this.period.Maximum = 86;
            this.period.Minimum = 2;
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(60, 26);
            this.period.TabIndex = 27;
            this.period.Tag = null;
            this.period.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.period.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(485, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multiplier:";
            // 
            // nudMultiplier
            // 
            this.nudMultiplier.GapHeight = 0;
            this.nudMultiplier.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudMultiplier.Location = new System.Drawing.Point(601, 18);
            this.nudMultiplier.Name = "nudMultiplier";
            this.nudMultiplier.Size = new System.Drawing.Size(60, 26);
            this.nudMultiplier.TabIndex = 28;
            this.nudMultiplier.Tag = null;
            this.nudMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMultiplier.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudMultiplier.ValueChanged += new System.EventHandler(this.nudMultiplier_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size(%):";
            // 
            // nudSize
            // 
            this.nudSize.GapHeight = 0;
            this.nudSize.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudSize.Location = new System.Drawing.Point(3, 61);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(60, 26);
            this.nudSize.TabIndex = 29;
            this.nudSize.Tag = null;
            this.nudSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSize.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type:";
            // 
            // c1MvaType
            // 
            this.c1MvaType.AllowSpinLoop = false;
            this.c1MvaType.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1MvaType.GapHeight = 5;
            this.c1MvaType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1MvaType.Location = new System.Drawing.Point(151, 61);
            this.c1MvaType.Name = "c1MvaType";
            this.c1MvaType.Size = new System.Drawing.Size(155, 37);
            this.c1MvaType.TabIndex = 26;
            this.c1MvaType.Tag = null;
            this.c1MvaType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1MvaType.SelectedIndexChanged += new System.EventHandler(this.c1MvaType_SelectedIndexChanged);
            // 
            // conversionLabel
            // 
            this.conversionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionLabel.Location = new System.Drawing.Point(322, 66);
            this.conversionLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(194, 30);
            this.conversionLabel.TabIndex = 10;
            this.conversionLabel.Text = "Conversion Period:";
            // 
            // conversionPeriod
            // 
            this.conversionPeriod.GapHeight = 0;
            this.conversionPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.conversionPeriod.Location = new System.Drawing.Point(522, 61);
            this.conversionPeriod.Name = "conversionPeriod";
            this.conversionPeriod.Size = new System.Drawing.Size(60, 26);
            this.conversionPeriod.TabIndex = 30;
            this.conversionPeriod.Tag = null;
            this.conversionPeriod.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.conversionPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.conversionPeriod.ValueChanged += new System.EventHandler(this.conversionPeriod_ValueChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.baseLabel.AutoSize = true;
            this.baseLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseLabel.Location = new System.Drawing.Point(598, 66);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(128, 30);
            this.baseLabel.TabIndex = 12;
            this.baseLabel.Text = "Base Period:";
            // 
            // basePeriod
            // 
            this.basePeriod.GapHeight = 0;
            this.basePeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.basePeriod.Location = new System.Drawing.Point(732, 61);
            this.basePeriod.Name = "basePeriod";
            this.basePeriod.Size = new System.Drawing.Size(60, 26);
            this.basePeriod.TabIndex = 31;
            this.basePeriod.Tag = null;
            this.basePeriod.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.basePeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.basePeriod.ValueChanged += new System.EventHandler(this.basePeriod_ValueChanged);
            // 
            // leadingLabel
            // 
            this.leadingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leadingLabel.AutoSize = true;
            this.leadingLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadingLabel.Location = new System.Drawing.Point(13, 105);
            this.leadingLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.leadingLabel.Name = "leadingLabel";
            this.leadingLabel.Size = new System.Drawing.Size(159, 30);
            this.leadingLabel.TabIndex = 14;
            this.leadingLabel.Text = "Leading Period:";
            // 
            // leadingPeriod
            // 
            this.leadingPeriod.GapHeight = 0;
            this.leadingPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.leadingPeriod.Location = new System.Drawing.Point(178, 104);
            this.leadingPeriod.Name = "leadingPeriod";
            this.leadingPeriod.Size = new System.Drawing.Size(60, 26);
            this.leadingPeriod.TabIndex = 32;
            this.leadingPeriod.Tag = null;
            this.leadingPeriod.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.leadingPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.leadingPeriod.ValueChanged += new System.EventHandler(this.leadingPeriod_ValueChanged);
            // 
            // laggingLabel
            // 
            this.laggingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laggingLabel.AutoSize = true;
            this.laggingLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laggingLabel.Location = new System.Drawing.Point(254, 105);
            this.laggingLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.laggingLabel.Name = "laggingLabel";
            this.laggingLabel.Size = new System.Drawing.Size(161, 30);
            this.laggingLabel.TabIndex = 16;
            this.laggingLabel.Text = "Lagging Period:";
            // 
            // laggingPeriod
            // 
            this.laggingPeriod.GapHeight = 0;
            this.laggingPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.laggingPeriod.Location = new System.Drawing.Point(421, 104);
            this.laggingPeriod.Name = "laggingPeriod";
            this.laggingPeriod.Size = new System.Drawing.Size(60, 26);
            this.laggingPeriod.TabIndex = 33;
            this.laggingPeriod.Tag = null;
            this.laggingPeriod.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.laggingPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.laggingPeriod.ValueChanged += new System.EventHandler(this.laggingPeriod_ValueChanged);
            // 
            // jawPeriodLabel
            // 
            this.jawPeriodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jawPeriodLabel.AutoSize = true;
            this.jawPeriodLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jawPeriodLabel.Location = new System.Drawing.Point(487, 101);
            this.jawPeriodLabel.Name = "jawPeriodLabel";
            this.jawPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.jawPeriodLabel.Size = new System.Drawing.Size(126, 35);
            this.jawPeriodLabel.TabIndex = 15;
            this.jawPeriodLabel.Text = "Jaw Period:";
            // 
            // jawPeriodNumberic
            // 
            this.jawPeriodNumberic.GapHeight = 0;
            this.jawPeriodNumberic.ImagePadding = new System.Windows.Forms.Padding(0);
            this.jawPeriodNumberic.Location = new System.Drawing.Point(619, 104);
            this.jawPeriodNumberic.Name = "jawPeriodNumberic";
            this.jawPeriodNumberic.Size = new System.Drawing.Size(60, 26);
            this.jawPeriodNumberic.TabIndex = 34;
            this.jawPeriodNumberic.Tag = null;
            this.jawPeriodNumberic.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.jawPeriodNumberic.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.jawPeriodNumberic.ValueChanged += new System.EventHandler(this.jawPeriodNumberic_ValueChanged_1);
            // 
            // teethPeriodLabel
            // 
            this.teethPeriodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.teethPeriodLabel.AutoSize = true;
            this.teethPeriodLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teethPeriodLabel.Location = new System.Drawing.Point(3, 136);
            this.teethPeriodLabel.Name = "teethPeriodLabel";
            this.teethPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.teethPeriodLabel.Size = new System.Drawing.Size(141, 35);
            this.teethPeriodLabel.TabIndex = 19;
            this.teethPeriodLabel.Text = "Teeth Period:";
            // 
            // teethPeriodNumberic
            // 
            this.teethPeriodNumberic.GapHeight = 0;
            this.teethPeriodNumberic.ImagePadding = new System.Windows.Forms.Padding(0);
            this.teethPeriodNumberic.Location = new System.Drawing.Point(150, 139);
            this.teethPeriodNumberic.Name = "teethPeriodNumberic";
            this.teethPeriodNumberic.Size = new System.Drawing.Size(60, 26);
            this.teethPeriodNumberic.TabIndex = 36;
            this.teethPeriodNumberic.Tag = null;
            this.teethPeriodNumberic.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.teethPeriodNumberic.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.teethPeriodNumberic.ValueChanged += new System.EventHandler(this.teethPeriodNumberic_ValueChanged_1);
            // 
            // lipsPeriodLabel
            // 
            this.lipsPeriodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lipsPeriodLabel.AutoSize = true;
            this.lipsPeriodLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lipsPeriodLabel.Location = new System.Drawing.Point(216, 136);
            this.lipsPeriodLabel.Name = "lipsPeriodLabel";
            this.lipsPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lipsPeriodLabel.Size = new System.Drawing.Size(128, 35);
            this.lipsPeriodLabel.TabIndex = 21;
            this.lipsPeriodLabel.Text = "Lips Period:";
            // 
            // lipsPeriodNumberic
            // 
            this.lipsPeriodNumberic.GapHeight = 0;
            this.lipsPeriodNumberic.ImagePadding = new System.Windows.Forms.Padding(0);
            this.lipsPeriodNumberic.Location = new System.Drawing.Point(350, 139);
            this.lipsPeriodNumberic.Name = "lipsPeriodNumberic";
            this.lipsPeriodNumberic.Size = new System.Drawing.Size(60, 26);
            this.lipsPeriodNumberic.TabIndex = 35;
            this.lipsPeriodNumberic.Tag = null;
            this.lipsPeriodNumberic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lipsPeriodNumberic.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.lipsPeriodNumberic.ValueChanged += new System.EventHandler(this.lipsPeriodNumberic_ValueChanged_1);
            // 
            // zigZagDistanceLabel
            // 
            this.zigZagDistanceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zigZagDistanceLabel.AutoSize = true;
            this.zigZagDistanceLabel.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zigZagDistanceLabel.Location = new System.Drawing.Point(416, 136);
            this.zigZagDistanceLabel.Name = "zigZagDistanceLabel";
            this.zigZagDistanceLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.zigZagDistanceLabel.Size = new System.Drawing.Size(107, 35);
            this.zigZagDistanceLabel.TabIndex = 23;
            this.zigZagDistanceLabel.Text = "Distance:";
            // 
            // zigZagDistanceNumberic
            // 
            this.zigZagDistanceNumberic.GapHeight = 0;
            this.zigZagDistanceNumberic.ImagePadding = new System.Windows.Forms.Padding(0);
            this.zigZagDistanceNumberic.Location = new System.Drawing.Point(529, 139);
            this.zigZagDistanceNumberic.Name = "zigZagDistanceNumberic";
            this.zigZagDistanceNumberic.Size = new System.Drawing.Size(60, 26);
            this.zigZagDistanceNumberic.TabIndex = 37;
            this.zigZagDistanceNumberic.Tag = null;
            this.zigZagDistanceNumberic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.zigZagDistanceNumberic.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.zigZagDistanceNumberic.ValueChanged += new System.EventHandler(this.zigZagDistanceNumberic_ValueChanged_1);
            // 
            // Overlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Overlays";
            this.Size = new System.Drawing.Size(800, 272);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1OverlayType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1MvaType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conversionPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basePeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laggingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jawPeriodNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teethPeriodNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lipsPeriodNumberic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zigZagDistanceNumberic)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1ComboBox c1OverlayType;
        private System.Windows.Forms.Label label2;
        private C1NumericEditEx period;
        private System.Windows.Forms.Label label3;
        private C1NumericEditEx nudMultiplier;
        private System.Windows.Forms.Label label4;
        private C1NumericEditEx nudSize;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1Input.C1ComboBox c1MvaType;
        private System.Windows.Forms.Label conversionLabel;
        private C1NumericEditEx conversionPeriod;
        private System.Windows.Forms.Label baseLabel;
        private C1NumericEditEx basePeriod;
        private System.Windows.Forms.Label leadingLabel;
        private C1NumericEditEx leadingPeriod;
        private System.Windows.Forms.Label laggingLabel;
        private C1NumericEditEx laggingPeriod;
        private System.Windows.Forms.Label jawPeriodLabel;
        private C1NumericEditEx jawPeriodNumberic;
        private System.Windows.Forms.Label teethPeriodLabel;
        private C1NumericEditEx teethPeriodNumberic;
        private System.Windows.Forms.Label lipsPeriodLabel;
        private C1NumericEditEx lipsPeriodNumberic;
        private System.Windows.Forms.Label zigZagDistanceLabel;
        private C1NumericEditEx zigZagDistanceNumberic;
    }
}
