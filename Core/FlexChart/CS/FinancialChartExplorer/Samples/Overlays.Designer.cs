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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            tableLayoutPanel1 = new TableLayoutPanel();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1OverlayType = new C1.Win.Input.C1ComboBox();
            label2 = new Label();
            period = new C1NumericEditEx();
            label3 = new Label();
            nudMultiplier = new C1NumericEditEx();
            label4 = new Label();
            nudSize = new C1NumericEditEx();
            label5 = new Label();
            c1MvaType = new C1.Win.Input.C1ComboBox();
            conversionLabel = new Label();
            conversionPeriod = new C1NumericEditEx();
            baseLabel = new Label();
            basePeriod = new C1NumericEditEx();
            leadingLabel = new Label();
            leadingPeriod = new C1NumericEditEx();
            laggingLabel = new Label();
            laggingPeriod = new C1NumericEditEx();
            jawPeriodLabel = new Label();
            jawPeriodNumberic = new C1NumericEditEx();
            teethPeriodLabel = new Label();
            teethPeriodNumberic = new C1NumericEditEx();
            lipsPeriodLabel = new Label();
            lipsPeriodNumberic = new C1NumericEditEx();
            zigZagDistanceLabel = new Label();
            zigZagDistanceNumberic = new C1NumericEditEx();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1OverlayType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)period).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1MvaType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conversionPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)basePeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)leadingPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)laggingPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)jawPeriodNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teethPeriodNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lipsPeriodNumberic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zigZagDistanceNumberic).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1317, 748);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // financialChart1
            // 
            financialChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            financialChart1.AnimationLoad.Duration = 400;
            financialChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            financialChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            financialChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            financialChart1.AnimationUpdate.Duration = 400;
            financialChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            financialChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            financialChart1.AxisX.AxisLine = true;
            financialChart1.AxisX.Chart = financialChart1;
            financialChart1.AxisX.DataSource = null;
            financialChart1.AxisX.Formatter = null;
            financialChart1.AxisX.GroupProvider = null;
            financialChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart1.AxisX.GroupVisibilityLevel = 0;
            financialChart1.AxisX.PlotAreaName = null;
            financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            financialChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart1.AxisY.AxisLine = false;
            financialChart1.AxisY.Chart = financialChart1;
            financialChart1.AxisY.DataSource = null;
            financialChart1.AxisY.Formatter = null;
            financialChart1.AxisY.GroupProvider = null;
            financialChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart1.AxisY.GroupVisibilityLevel = 0;
            financialChart1.AxisY.MajorGrid = true;
            financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            financialChart1.AxisY.PlotAreaName = null;
            financialChart1.AxisY.Position = C1.Chart.Position.Left;
            financialChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            financialChart1.DataLabel.Angle = 0;
            financialChart1.DataLabel.Border = false;
            financialChart1.DataLabel.ConnectingLine = false;
            financialChart1.DataLabel.Content = null;
            financialChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            financialChart1.DataLabel.MaxAutoLabels = 100;
            financialChart1.DataLabel.MaxLines = 0;
            financialChart1.DataLabel.MaxWidth = 0;
            financialChart1.DataLabel.Offset = 0;
            financialChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            financialChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            financialChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            financialChart1.Dock = DockStyle.Fill;
            financialChart1.Legend.ItemMaxWidth = 0;
            financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            financialChart1.Legend.Position = C1.Chart.Position.Right;
            financialChart1.Legend.Reversed = false;
            financialChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            financialChart1.Legend.Title = null;
            financialChart1.Location = new Point(0, 0);
            financialChart1.Margin = new Padding(0);
            financialChart1.Name = "financialChart1";
            financialChart1.Options.BoxSize = 2D;
            financialChart1.Options.Chart = financialChart1;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize2;
            financialChart1.Options.ReversalAmount = 1D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1317, 601);
            financialChart1.TabIndex = 0;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1OverlayType);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(period);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(nudMultiplier);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(nudSize);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(c1MvaType);
            flowLayoutPanel1.Controls.Add(conversionLabel);
            flowLayoutPanel1.Controls.Add(conversionPeriod);
            flowLayoutPanel1.Controls.Add(baseLabel);
            flowLayoutPanel1.Controls.Add(basePeriod);
            flowLayoutPanel1.Controls.Add(leadingLabel);
            flowLayoutPanel1.Controls.Add(leadingPeriod);
            flowLayoutPanel1.Controls.Add(laggingLabel);
            flowLayoutPanel1.Controls.Add(laggingPeriod);
            flowLayoutPanel1.Controls.Add(jawPeriodLabel);
            flowLayoutPanel1.Controls.Add(jawPeriodNumberic);
            flowLayoutPanel1.Controls.Add(teethPeriodLabel);
            flowLayoutPanel1.Controls.Add(teethPeriodNumberic);
            flowLayoutPanel1.Controls.Add(lipsPeriodLabel);
            flowLayoutPanel1.Controls.Add(lipsPeriodNumberic);
            flowLayoutPanel1.Controls.Add(zigZagDistanceLabel);
            flowLayoutPanel1.Controls.Add(zigZagDistanceNumberic);
            flowLayoutPanel1.Location = new Point(0, 601);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(1317, 147);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 23);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 36);
            label1.TabIndex = 0;
            label1.Text = "Overlay Type:";
            // 
            // c1OverlayType
            // 
            c1OverlayType.Anchor = AnchorStyles.Left;
            c1OverlayType.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1OverlayType.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1OverlayType.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1OverlayType.GapHeight = 5;
            c1OverlayType.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1OverlayType.Location = new Point(183, 18);
            c1OverlayType.Name = "c1OverlayType";
            c1OverlayType.ReadOnly = true;
            c1OverlayType.Size = new Size(242, 44);
            c1OverlayType.TabIndex = 25;
            c1OverlayType.TextAlign = HorizontalAlignment.Center;
            c1OverlayType.SelectedIndexChanged += c1OverlayType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 23);
            label2.Margin = new Padding(13, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 2;
            label2.Text = "Period:";
            // 
            // period
            // 
            period.Anchor = AnchorStyles.Left;
            period.Location = new Point(544, 24);
            period.Maximum = 86;
            period.Minimum = 2;
            period.Name = "period";
            period.Size = new Size(60, 31);
            period.TabIndex = 27;
            period.TextAlign = HorizontalAlignment.Center;
            period.Value = new decimal(new int[] { 20, 0, 0, 0 });
            period.ValueChanged += period_ValueChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(623, 23);
            label3.Margin = new Padding(16, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 36);
            label3.TabIndex = 4;
            label3.Text = "Multiplier:";
            // 
            // nudMultiplier
            // 
            nudMultiplier.Anchor = AnchorStyles.Left;
            nudMultiplier.Location = new Point(763, 24);
            nudMultiplier.Name = "nudMultiplier";
            nudMultiplier.Size = new Size(60, 31);
            nudMultiplier.TabIndex = 28;
            nudMultiplier.TextAlign = HorizontalAlignment.Center;
            nudMultiplier.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudMultiplier.ValueChanged += nudMultiplier_ValueChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(842, 23);
            label4.Margin = new Padding(16, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(105, 36);
            label4.TabIndex = 6;
            label4.Text = "Size(%):";
            // 
            // nudSize
            // 
            nudSize.Anchor = AnchorStyles.Left;
            nudSize.Location = new Point(953, 24);
            nudSize.Name = "nudSize";
            nudSize.Size = new Size(60, 31);
            nudSize.TabIndex = 29;
            nudSize.TextAlign = HorizontalAlignment.Center;
            nudSize.Value = new decimal(new int[] { 3, 0, 0, 0 });
            nudSize.ValueChanged += nudSize_ValueChanged_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1032, 23);
            label5.Margin = new Padding(16, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 36);
            label5.TabIndex = 8;
            label5.Text = "Type:";
            // 
            // c1MvaType
            // 
            c1MvaType.Anchor = AnchorStyles.Left;
            c1MvaType.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1MvaType.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1MvaType.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1MvaType.GapHeight = 5;
            c1MvaType.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1MvaType.Location = new Point(1116, 18);
            c1MvaType.Name = "c1MvaType";
            c1MvaType.ReadOnly = true;
            c1MvaType.Size = new Size(198, 44);
            c1MvaType.TabIndex = 26;
            c1MvaType.TextAlign = HorizontalAlignment.Center;
            c1MvaType.SelectedIndexChanged += c1MvaType_SelectedIndexChanged;
            // 
            // conversionLabel
            // 
            conversionLabel.Anchor = AnchorStyles.Left;
            conversionLabel.AutoSize = true;
            conversionLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            conversionLabel.Location = new Point(13, 69);
            conversionLabel.Margin = new Padding(13, 3, 3, 0);
            conversionLabel.Name = "conversionLabel";
            conversionLabel.Size = new Size(239, 36);
            conversionLabel.TabIndex = 10;
            conversionLabel.Text = "Conversion Period:";
            // 
            // conversionPeriod
            // 
            conversionPeriod.Anchor = AnchorStyles.Left;
            conversionPeriod.Location = new Point(258, 70);
            conversionPeriod.Name = "conversionPeriod";
            conversionPeriod.Size = new Size(60, 31);
            conversionPeriod.TabIndex = 30;
            conversionPeriod.TextAlign = HorizontalAlignment.Center;
            conversionPeriod.Value = new decimal(new int[] { 9, 0, 0, 0 });
            conversionPeriod.ValueChanged += conversionPeriod_ValueChanged;
            // 
            // baseLabel
            // 
            baseLabel.Anchor = AnchorStyles.Left;
            baseLabel.AutoSize = true;
            baseLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            baseLabel.Location = new Point(334, 69);
            baseLabel.Margin = new Padding(13, 3, 3, 0);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(157, 36);
            baseLabel.TabIndex = 12;
            baseLabel.Text = "Base Period:";
            // 
            // basePeriod
            // 
            basePeriod.Anchor = AnchorStyles.Left;
            basePeriod.Location = new Point(497, 70);
            basePeriod.Name = "basePeriod";
            basePeriod.Size = new Size(60, 31);
            basePeriod.TabIndex = 31;
            basePeriod.TextAlign = HorizontalAlignment.Center;
            basePeriod.Value = new decimal(new int[] { 26, 0, 0, 0 });
            basePeriod.ValueChanged += basePeriod_ValueChanged;
            // 
            // leadingLabel
            // 
            leadingLabel.Anchor = AnchorStyles.Left;
            leadingLabel.AutoSize = true;
            leadingLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            leadingLabel.Location = new Point(573, 69);
            leadingLabel.Margin = new Padding(13, 3, 3, 0);
            leadingLabel.Name = "leadingLabel";
            leadingLabel.Size = new Size(195, 36);
            leadingLabel.TabIndex = 14;
            leadingLabel.Text = "Leading Period:";
            // 
            // leadingPeriod
            // 
            leadingPeriod.Anchor = AnchorStyles.Left;
            leadingPeriod.Location = new Point(774, 70);
            leadingPeriod.Name = "leadingPeriod";
            leadingPeriod.Size = new Size(60, 31);
            leadingPeriod.TabIndex = 32;
            leadingPeriod.TextAlign = HorizontalAlignment.Center;
            leadingPeriod.Value = new decimal(new int[] { 52, 0, 0, 0 });
            leadingPeriod.ValueChanged += leadingPeriod_ValueChanged;
            // 
            // laggingLabel
            // 
            laggingLabel.Anchor = AnchorStyles.Left;
            laggingLabel.AutoSize = true;
            laggingLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            laggingLabel.Location = new Point(850, 69);
            laggingLabel.Margin = new Padding(13, 3, 3, 0);
            laggingLabel.Name = "laggingLabel";
            laggingLabel.Size = new Size(197, 36);
            laggingLabel.TabIndex = 16;
            laggingLabel.Text = "Lagging Period:";
            // 
            // laggingPeriod
            // 
            laggingPeriod.Anchor = AnchorStyles.Left;
            laggingPeriod.Location = new Point(1053, 70);
            laggingPeriod.Name = "laggingPeriod";
            laggingPeriod.Size = new Size(60, 31);
            laggingPeriod.TabIndex = 33;
            laggingPeriod.TextAlign = HorizontalAlignment.Center;
            laggingPeriod.Value = new decimal(new int[] { 26, 0, 0, 0 });
            laggingPeriod.ValueChanged += laggingPeriod_ValueChanged;
            // 
            // jawPeriodLabel
            // 
            jawPeriodLabel.Anchor = AnchorStyles.Left;
            jawPeriodLabel.AutoSize = true;
            jawPeriodLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jawPeriodLabel.Location = new Point(1119, 65);
            jawPeriodLabel.Name = "jawPeriodLabel";
            jawPeriodLabel.Padding = new Padding(3, 5, 3, 0);
            jawPeriodLabel.Size = new Size(152, 41);
            jawPeriodLabel.TabIndex = 15;
            jawPeriodLabel.Text = "Jaw Period:";
            // 
            // jawPeriodNumberic
            // 
            jawPeriodNumberic.Anchor = AnchorStyles.Left;
            jawPeriodNumberic.Location = new Point(3, 111);
            jawPeriodNumberic.Name = "jawPeriodNumberic";
            jawPeriodNumberic.Size = new Size(60, 31);
            jawPeriodNumberic.TabIndex = 34;
            jawPeriodNumberic.TextAlign = HorizontalAlignment.Center;
            jawPeriodNumberic.Value = new decimal(new int[] { 13, 0, 0, 0 });
            jawPeriodNumberic.ValueChanged += jawPeriodNumberic_ValueChanged_1;
            // 
            // teethPeriodLabel
            // 
            teethPeriodLabel.Anchor = AnchorStyles.Left;
            teethPeriodLabel.AutoSize = true;
            teethPeriodLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teethPeriodLabel.Location = new Point(69, 106);
            teethPeriodLabel.Name = "teethPeriodLabel";
            teethPeriodLabel.Padding = new Padding(3, 5, 3, 0);
            teethPeriodLabel.Size = new Size(173, 41);
            teethPeriodLabel.TabIndex = 19;
            teethPeriodLabel.Text = "Teeth Period:";
            // 
            // teethPeriodNumberic
            // 
            teethPeriodNumberic.Anchor = AnchorStyles.Left;
            teethPeriodNumberic.Location = new Point(248, 111);
            teethPeriodNumberic.Name = "teethPeriodNumberic";
            teethPeriodNumberic.Size = new Size(60, 31);
            teethPeriodNumberic.TabIndex = 36;
            teethPeriodNumberic.TextAlign = HorizontalAlignment.Center;
            teethPeriodNumberic.Value = new decimal(new int[] { 8, 0, 0, 0 });
            teethPeriodNumberic.ValueChanged += teethPeriodNumberic_ValueChanged_1;
            // 
            // lipsPeriodLabel
            // 
            lipsPeriodLabel.Anchor = AnchorStyles.Left;
            lipsPeriodLabel.AutoSize = true;
            lipsPeriodLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lipsPeriodLabel.Location = new Point(314, 106);
            lipsPeriodLabel.Name = "lipsPeriodLabel";
            lipsPeriodLabel.Padding = new Padding(3, 5, 3, 0);
            lipsPeriodLabel.Size = new Size(155, 41);
            lipsPeriodLabel.TabIndex = 21;
            lipsPeriodLabel.Text = "Lips Period:";
            // 
            // lipsPeriodNumberic
            // 
            lipsPeriodNumberic.Anchor = AnchorStyles.Left;
            lipsPeriodNumberic.Location = new Point(475, 111);
            lipsPeriodNumberic.Name = "lipsPeriodNumberic";
            lipsPeriodNumberic.Size = new Size(60, 31);
            lipsPeriodNumberic.TabIndex = 35;
            lipsPeriodNumberic.TextAlign = HorizontalAlignment.Center;
            lipsPeriodNumberic.Value = new decimal(new int[] { 5, 0, 0, 0 });
            lipsPeriodNumberic.ValueChanged += lipsPeriodNumberic_ValueChanged_1;
            // 
            // zigZagDistanceLabel
            // 
            zigZagDistanceLabel.Anchor = AnchorStyles.Left;
            zigZagDistanceLabel.AutoSize = true;
            zigZagDistanceLabel.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            zigZagDistanceLabel.Location = new Point(541, 106);
            zigZagDistanceLabel.Name = "zigZagDistanceLabel";
            zigZagDistanceLabel.Padding = new Padding(3, 5, 3, 0);
            zigZagDistanceLabel.Size = new Size(130, 41);
            zigZagDistanceLabel.TabIndex = 23;
            zigZagDistanceLabel.Text = "Distance:";
            // 
            // zigZagDistanceNumberic
            // 
            zigZagDistanceNumberic.Anchor = AnchorStyles.Left;
            zigZagDistanceNumberic.Location = new Point(677, 111);
            zigZagDistanceNumberic.Name = "zigZagDistanceNumberic";
            zigZagDistanceNumberic.Size = new Size(60, 31);
            zigZagDistanceNumberic.TabIndex = 37;
            zigZagDistanceNumberic.TextAlign = HorizontalAlignment.Center;
            zigZagDistanceNumberic.Value = new decimal(new int[] { 5, 0, 0, 0 });
            zigZagDistanceNumberic.ValueChanged += zigZagDistanceNumberic_ValueChanged_1;
            // 
            // Overlays
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Overlays";
            Size = new Size(1317, 748);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1OverlayType).EndInit();
            ((System.ComponentModel.ISupportInitialize)period).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMultiplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1MvaType).EndInit();
            ((System.ComponentModel.ISupportInitialize)conversionPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)basePeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)leadingPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)laggingPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)jawPeriodNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)teethPeriodNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)lipsPeriodNumberic).EndInit();
            ((System.ComponentModel.ISupportInitialize)zigZagDistanceNumberic).EndInit();
            ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.Input.C1ComboBox c1OverlayType;
        private System.Windows.Forms.Label label2;
        private C1NumericEditEx period;
        private System.Windows.Forms.Label label3;
        private C1NumericEditEx nudMultiplier;
        private System.Windows.Forms.Label label4;
        private C1NumericEditEx nudSize;
        private System.Windows.Forms.Label label5;
        private C1.Win.Input.C1ComboBox c1MvaType;
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
