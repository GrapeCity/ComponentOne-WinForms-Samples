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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.overlayType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMultiplier = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.mvaType = new System.Windows.Forms.ComboBox();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.conversionPeriod = new System.Windows.Forms.NumericUpDown();
            this.baseLabel = new System.Windows.Forms.Label();
            this.basePeriod = new System.Windows.Forms.NumericUpDown();
            this.leadingLabel = new System.Windows.Forms.Label();
            this.leadingPeriod = new System.Windows.Forms.NumericUpDown();
            this.laggingLabel = new System.Windows.Forms.Label();
            this.laggingPeriod = new System.Windows.Forms.NumericUpDown();
            this.jawPeriodLabel = new System.Windows.Forms.Label();
            this.jawPeriodNumberic = new System.Windows.Forms.NumericUpDown();
            this.teethPeriodLabel = new System.Windows.Forms.Label();
            this.teethPeriodNumberic = new System.Windows.Forms.NumericUpDown();
            this.lipsPeriodLabel = new System.Windows.Forms.Label();
            this.lipsPeriodNumberic = new System.Windows.Forms.NumericUpDown();
            this.zigZagDistanceLabel = new System.Windows.Forms.Label();
            this.zigZagDistanceNumberic = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
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
            this.financialChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.DataSource = null;
            this.financialChart1.AxisX.GroupProvider = null;
            this.financialChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisX.GroupVisibilityLevel = 0;
            this.financialChart1.AxisX.LabelMax = false;
            this.financialChart1.AxisX.LabelMin = false;
            this.financialChart1.AxisX.PlotAreaName = null;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.DataSource = null;
            this.financialChart1.AxisY.GroupProvider = null;
            this.financialChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisY.GroupVisibilityLevel = 0;
            this.financialChart1.AxisY.LabelMax = false;
            this.financialChart1.AxisY.LabelMin = false;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.PlotAreaName = null;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(10, 10);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize2;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(780, 134);
            this.financialChart1.TabIndex = 0;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.overlayType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.period);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudMultiplier);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudSize);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.mvaType);
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
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 157);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 112);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Overlay Type";
            // 
            // overlayType
            // 
            this.overlayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.overlayType.FormattingEnabled = true;
            this.overlayType.Location = new System.Drawing.Point(79, 3);
            this.overlayType.Name = "overlayType";
            this.overlayType.Size = new System.Drawing.Size(196, 21);
            this.overlayType.TabIndex = 1;
            this.overlayType.SelectedIndexChanged += new System.EventHandler(this.overlayType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period";
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(337, 3);
            this.period.Maximum = new decimal(new int[] {
            86,
            0,
            0,
            0});
            this.period.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(52, 22);
            this.period.TabIndex = 3;
            this.period.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Multiplier";
            // 
            // nudMultiplier
            // 
            this.nudMultiplier.Location = new System.Drawing.Point(471, 3);
            this.nudMultiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMultiplier.Name = "nudMultiplier";
            this.nudMultiplier.Size = new System.Drawing.Size(52, 22);
            this.nudMultiplier.TabIndex = 5;
            this.nudMultiplier.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMultiplier.ValueChanged += new System.EventHandler(this.nudMultiplier_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size(%)";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(590, 3);
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(52, 22);
            this.nudSize.TabIndex = 7;
            this.nudSize.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type";
            // 
            // mvaType
            // 
            this.mvaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mvaType.FormattingEnabled = true;
            this.mvaType.Location = new System.Drawing.Point(3, 31);
            this.mvaType.Name = "mvaType";
            this.mvaType.Size = new System.Drawing.Size(121, 21);
            this.mvaType.TabIndex = 9;
            this.mvaType.SelectedIndexChanged += new System.EventHandler(this.mvaType_SelectedIndexChanged);
            // 
            // conversionLabel
            // 
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Location = new System.Drawing.Point(140, 31);
            this.conversionLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(101, 13);
            this.conversionLabel.TabIndex = 10;
            this.conversionLabel.Text = "Conversion Period";
            // 
            // conversionPeriod
            // 
            this.conversionPeriod.Location = new System.Drawing.Point(247, 31);
            this.conversionPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.conversionPeriod.Name = "conversionPeriod";
            this.conversionPeriod.Size = new System.Drawing.Size(52, 22);
            this.conversionPeriod.TabIndex = 11;
            this.conversionPeriod.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.conversionPeriod.ValueChanged += new System.EventHandler(this.conversion_ValueChanged);
            // 
            // baseLabel
            // 
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(315, 31);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(67, 13);
            this.baseLabel.TabIndex = 12;
            this.baseLabel.Text = "Base Period";
            // 
            // basePeriod
            // 
            this.basePeriod.Location = new System.Drawing.Point(388, 31);
            this.basePeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.basePeriod.Name = "basePeriod";
            this.basePeriod.Size = new System.Drawing.Size(52, 22);
            this.basePeriod.TabIndex = 13;
            this.basePeriod.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.basePeriod.ValueChanged += new System.EventHandler(this.base_ValueChanged);
            // 
            // leadingLabel
            // 
            this.leadingLabel.AutoSize = true;
            this.leadingLabel.Location = new System.Drawing.Point(456, 31);
            this.leadingLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.leadingLabel.Name = "leadingLabel";
            this.leadingLabel.Size = new System.Drawing.Size(84, 13);
            this.leadingLabel.TabIndex = 14;
            this.leadingLabel.Text = "Leading Period";
            // 
            // leadingPeriod
            // 
            this.leadingPeriod.Location = new System.Drawing.Point(546, 31);
            this.leadingPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leadingPeriod.Name = "leadingPeriod";
            this.leadingPeriod.Size = new System.Drawing.Size(52, 22);
            this.leadingPeriod.TabIndex = 15;
            this.leadingPeriod.Value = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.leadingPeriod.ValueChanged += new System.EventHandler(this.leading_ValueChanged);
            // 
            // laggingLabel
            // 
            this.laggingLabel.AutoSize = true;
            this.laggingLabel.Location = new System.Drawing.Point(614, 31);
            this.laggingLabel.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.laggingLabel.Name = "laggingLabel";
            this.laggingLabel.Size = new System.Drawing.Size(85, 13);
            this.laggingLabel.TabIndex = 16;
            this.laggingLabel.Text = "Lagging Period";
            // 
            // laggingPeriod
            // 
            this.laggingPeriod.Location = new System.Drawing.Point(705, 31);
            this.laggingPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.laggingPeriod.Name = "laggingPeriod";
            this.laggingPeriod.Size = new System.Drawing.Size(52, 22);
            this.laggingPeriod.TabIndex = 17;
            this.laggingPeriod.Value = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.laggingPeriod.ValueChanged += new System.EventHandler(this.lagging_ValueChanged);
            // 
            // jawPeriodLabel
            // 
            this.jawPeriodLabel.AutoSize = true;
            this.jawPeriodLabel.Location = new System.Drawing.Point(3, 56);
            this.jawPeriodLabel.Name = "jawPeriodLabel";
            this.jawPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.jawPeriodLabel.Size = new System.Drawing.Size(68, 18);
            this.jawPeriodLabel.TabIndex = 15;
            this.jawPeriodLabel.Text = "Jaw Period";
            // 
            // jawPeriodNumberic
            // 
            this.jawPeriodNumberic.Location = new System.Drawing.Point(77, 59);
            this.jawPeriodNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jawPeriodNumberic.Name = "jawPeriodNumberic";
            this.jawPeriodNumberic.Size = new System.Drawing.Size(120, 22);
            this.jawPeriodNumberic.TabIndex = 18;
            this.jawPeriodNumberic.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.jawPeriodNumberic.ValueChanged += new System.EventHandler(this.jawPeriodNumberic_ValueChanged);
            // 
            // teethPeriodLabel
            // 
            this.teethPeriodLabel.AutoSize = true;
            this.teethPeriodLabel.Location = new System.Drawing.Point(203, 56);
            this.teethPeriodLabel.Name = "teethPeriodLabel";
            this.teethPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.teethPeriodLabel.Size = new System.Drawing.Size(76, 18);
            this.teethPeriodLabel.TabIndex = 19;
            this.teethPeriodLabel.Text = "Teeth Period";
            // 
            // teethPeriodNumberic
            // 
            this.teethPeriodNumberic.Location = new System.Drawing.Point(285, 59);
            this.teethPeriodNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.teethPeriodNumberic.Name = "teethPeriodNumberic";
            this.teethPeriodNumberic.Size = new System.Drawing.Size(120, 22);
            this.teethPeriodNumberic.TabIndex = 20;
            this.teethPeriodNumberic.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.teethPeriodNumberic.ValueChanged += new System.EventHandler(this.teethPeriodNumberic_ValueChanged);
            // 
            // lipsPeriodLabel
            // 
            this.lipsPeriodLabel.AutoSize = true;
            this.lipsPeriodLabel.Location = new System.Drawing.Point(411, 56);
            this.lipsPeriodLabel.Name = "lipsPeriodLabel";
            this.lipsPeriodLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lipsPeriodLabel.Size = new System.Drawing.Size(69, 18);
            this.lipsPeriodLabel.TabIndex = 21;
            this.lipsPeriodLabel.Text = "Lips Period";
            // 
            // lipsPeriodNumberic
            // 
            this.lipsPeriodNumberic.Location = new System.Drawing.Point(486, 59);
            this.lipsPeriodNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lipsPeriodNumberic.Name = "lipsPeriodNumberic";
            this.lipsPeriodNumberic.Size = new System.Drawing.Size(120, 22);
            this.lipsPeriodNumberic.TabIndex = 22;
            this.lipsPeriodNumberic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lipsPeriodNumberic.ValueChanged += new System.EventHandler(this.lipsPeriodNumberic_ValueChanged);
            // 
            // zigZagDistanceLabel
            // 
            this.zigZagDistanceLabel.AutoSize = true;
            this.zigZagDistanceLabel.Location = new System.Drawing.Point(612, 56);
            this.zigZagDistanceLabel.Name = "zigZagDistanceLabel";
            this.zigZagDistanceLabel.Padding = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.zigZagDistanceLabel.Size = new System.Drawing.Size(57, 18);
            this.zigZagDistanceLabel.TabIndex = 23;
            this.zigZagDistanceLabel.Text = "Distance";
            // 
            // zigZagDistanceNumberic
            // 
            this.zigZagDistanceNumberic.Location = new System.Drawing.Point(3, 87);
            this.zigZagDistanceNumberic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.zigZagDistanceNumberic.Name = "zigZagDistanceNumberic";
            this.zigZagDistanceNumberic.Size = new System.Drawing.Size(120, 22);
            this.zigZagDistanceNumberic.TabIndex = 24;
            this.zigZagDistanceNumberic.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.zigZagDistanceNumberic.ValueChanged += new System.EventHandler(this.zigZagDistanceNumberic_ValueChanged);
            // 
            // Overlays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
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
        private System.Windows.Forms.ComboBox overlayType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown period;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMultiplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mvaType;

        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.NumericUpDown conversionPeriod;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.NumericUpDown basePeriod;
        private System.Windows.Forms.Label leadingLabel;
        private System.Windows.Forms.NumericUpDown leadingPeriod;
        private System.Windows.Forms.Label laggingLabel;
        private System.Windows.Forms.NumericUpDown laggingPeriod;

        private System.Windows.Forms.Label jawPeriodLabel;
        private System.Windows.Forms.NumericUpDown jawPeriodNumberic;
        private System.Windows.Forms.Label teethPeriodLabel;
        private System.Windows.Forms.NumericUpDown teethPeriodNumberic;
        private System.Windows.Forms.Label lipsPeriodLabel;
        private System.Windows.Forms.NumericUpDown lipsPeriodNumberic;
        private System.Windows.Forms.Label zigZagDistanceLabel;
        private System.Windows.Forms.NumericUpDown zigZagDistanceNumberic;
    }
}
