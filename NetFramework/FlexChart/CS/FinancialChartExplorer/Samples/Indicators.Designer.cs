using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class Indicators
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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.financialChart2 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.c1IndicatorType = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.period = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFastPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSlowPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMacdSignalSmoothingPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label6 = new System.Windows.Forms.Label();
            this.nudKPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label8 = new System.Windows.Forms.Label();
            this.nudStochasticSmoothingPeriod = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1IndicatorType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFastPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMacdSignalSmoothingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStochasticSmoothingPeriod)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.financialChart2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
            this.financialChart1.Location = new System.Drawing.Point(10, 10);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
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
            this.financialChart1.Size = new System.Drawing.Size(780, 1);
            this.financialChart1.TabIndex = 0;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // financialChart2
            // 
            this.financialChart2.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.financialChart2.AnimationLoad.Duration = 400;
            this.financialChart2.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.financialChart2.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.financialChart2.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.financialChart2.AnimationUpdate.Duration = 400;
            this.financialChart2.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.financialChart2.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.financialChart2.AxisX.AxisLine = true;
            this.financialChart2.AxisX.Chart = this.financialChart2;
            this.financialChart2.AxisX.DataSource = null;
            this.financialChart2.AxisX.Formatter = null;
            this.financialChart2.AxisX.GroupProvider = null;
            this.financialChart2.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart2.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart2.AxisX.GroupVisibilityLevel = 0;
            this.financialChart2.AxisX.PlotAreaName = null;
            this.financialChart2.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart2.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart2.AxisY.AxisLine = false;
            this.financialChart2.AxisY.Chart = this.financialChart2;
            this.financialChart2.AxisY.DataSource = null;
            this.financialChart2.AxisY.Formatter = null;
            this.financialChart2.AxisY.GroupProvider = null;
            this.financialChart2.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart2.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart2.AxisY.GroupVisibilityLevel = 0;
            this.financialChart2.AxisY.MajorGrid = true;
            this.financialChart2.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart2.AxisY.PlotAreaName = null;
            this.financialChart2.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart2.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart2.DataLabel.Angle = 0;
            this.financialChart2.DataLabel.Border = false;
            this.financialChart2.DataLabel.ConnectingLine = false;
            this.financialChart2.DataLabel.Content = null;
            this.financialChart2.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.financialChart2.DataLabel.MaxAutoLabels = 100;
            this.financialChart2.DataLabel.MaxLines = 0;
            this.financialChart2.DataLabel.MaxWidth = 0;
            this.financialChart2.DataLabel.Offset = 0;
            this.financialChart2.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.financialChart2.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.financialChart2.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.financialChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart2.Legend.ItemMaxWidth = 0;
            this.financialChart2.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart2.Legend.Position = C1.Chart.Position.Right;
            this.financialChart2.Legend.Reversed = false;
            this.financialChart2.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.financialChart2.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart2.Legend.Title = null;
            this.financialChart2.Location = new System.Drawing.Point(0, -8);
            this.financialChart2.Margin = new System.Windows.Forms.Padding(0);
            this.financialChart2.Name = "financialChart2";
            this.financialChart2.Options.BoxSize = 2D;
            this.financialChart2.Options.Chart = this.financialChart2;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart2.Options.ClusterSize = elementSize2;
            this.financialChart2.Options.ReversalAmount = 1D;
            this.financialChart2.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart2.SelectedSeries = null;
            this.financialChart2.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart2.Size = new System.Drawing.Size(800, 133);
            this.financialChart2.TabIndex = 1;
            this.financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            this.financialChart2.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1IndicatorType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.period);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudFastPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudSlowPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.nudMacdSignalSmoothingPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.nudKPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.nudDPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.nudStochasticSmoothingPeriod);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 125);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 147);
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
            this.label1.Size = new System.Drawing.Size(155, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicator Type:";
            // 
            // c1IndicatorType
            // 
            this.c1IndicatorType.AllowSpinLoop = false;
            this.c1IndicatorType.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1IndicatorType.GapHeight = 5;
            this.c1IndicatorType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1IndicatorType.Location = new System.Drawing.Point(164, 18);
            this.c1IndicatorType.Name = "c1IndicatorType";
            this.c1IndicatorType.Size = new System.Drawing.Size(259, 37);
            this.c1IndicatorType.TabIndex = 2;
            this.c1IndicatorType.Tag = null;
            this.c1IndicatorType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1IndicatorType.SelectedIndexChanged += new System.EventHandler(this.c1IndicatorType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 23);
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
            this.period.Location = new System.Drawing.Point(524, 18);
            this.period.Minimum = 1;
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(57, 38);
            this.period.TabIndex = 16;
            this.period.Tag = null;
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.period.Value = new decimal(new int[] {
            1,
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
            this.label3.Location = new System.Drawing.Point(600, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fast period:";
            // 
            // nudFastPeriod
            // 
            this.nudFastPeriod.GapHeight = 0;
            this.nudFastPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudFastPeriod.Location = new System.Drawing.Point(731, 18);
            this.nudFastPeriod.Minimum = 2;
            this.nudFastPeriod.Name = "nudFastPeriod";
            this.nudFastPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudFastPeriod.TabIndex = 17;
            this.nudFastPeriod.Tag = null;
            this.nudFastPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFastPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFastPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudFastPeriod.ValueChanged += new System.EventHandler(this.nudFastPeriod_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Slow period:";
            // 
            // nudSlowPeriod
            // 
            this.nudSlowPeriod.GapHeight = 0;
            this.nudSlowPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudSlowPeriod.Location = new System.Drawing.Point(154, 62);
            this.nudSlowPeriod.Minimum = 2;
            this.nudSlowPeriod.Name = "nudSlowPeriod";
            this.nudSlowPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudSlowPeriod.TabIndex = 18;
            this.nudSlowPeriod.Tag = null;
            this.nudSlowPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudSlowPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSlowPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudSlowPeriod.ValueChanged += new System.EventHandler(this.nudSlowPeriod_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signal smoothing period:";
            // 
            // nudMacdSignalSmoothingPeriod
            // 
            this.nudMacdSignalSmoothingPeriod.GapHeight = 0;
            this.nudMacdSignalSmoothingPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudMacdSignalSmoothingPeriod.Location = new System.Drawing.Point(490, 62);
            this.nudMacdSignalSmoothingPeriod.Minimum = 2;
            this.nudMacdSignalSmoothingPeriod.Name = "nudMacdSignalSmoothingPeriod";
            this.nudMacdSignalSmoothingPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudMacdSignalSmoothingPeriod.TabIndex = 19;
            this.nudMacdSignalSmoothingPeriod.Tag = null;
            this.nudMacdSignalSmoothingPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMacdSignalSmoothingPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMacdSignalSmoothingPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudMacdSignalSmoothingPeriod.ValueChanged += new System.EventHandler(this.nudMacdSignalSmoothingPeriod_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(566, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "K period:";
            // 
            // nudKPeriod
            // 
            this.nudKPeriod.GapHeight = 0;
            this.nudKPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudKPeriod.Location = new System.Drawing.Point(671, 62);
            this.nudKPeriod.Minimum = 2;
            this.nudKPeriod.Name = "nudKPeriod";
            this.nudKPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudKPeriod.TabIndex = 20;
            this.nudKPeriod.Tag = null;
            this.nudKPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudKPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudKPeriod.ValueChanged += new System.EventHandler(this.nudKPeriod_ValueChanged_1);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "D period:";
            // 
            // nudDPeriod
            // 
            this.nudDPeriod.GapHeight = 0;
            this.nudDPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudDPeriod.Location = new System.Drawing.Point(123, 106);
            this.nudDPeriod.Minimum = 2;
            this.nudDPeriod.Name = "nudDPeriod";
            this.nudDPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudDPeriod.TabIndex = 22;
            this.nudDPeriod.Tag = null;
            this.nudDPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudDPeriod.ValueChanged += new System.EventHandler(this.nudDPeriod_ValueChanged_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(199, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Signal smoothing period:";
            // 
            // nudStochasticSmoothingPeriod
            // 
            this.nudStochasticSmoothingPeriod.GapHeight = 0;
            this.nudStochasticSmoothingPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudStochasticSmoothingPeriod.Location = new System.Drawing.Point(459, 106);
            this.nudStochasticSmoothingPeriod.Minimum = 2;
            this.nudStochasticSmoothingPeriod.Name = "nudStochasticSmoothingPeriod";
            this.nudStochasticSmoothingPeriod.Size = new System.Drawing.Size(57, 38);
            this.nudStochasticSmoothingPeriod.TabIndex = 21;
            this.nudStochasticSmoothingPeriod.Tag = null;
            this.nudStochasticSmoothingPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStochasticSmoothingPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudStochasticSmoothingPeriod.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudStochasticSmoothingPeriod.ValueChanged += new System.EventHandler(this.nudStochasticSmoothingPeriod_ValueChanged);
            // 
            // Indicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Indicators";
            this.Size = new System.Drawing.Size(800, 272);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1IndicatorType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFastPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMacdSignalSmoothingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStochasticSmoothingPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private C1.Win.C1Input.C1ComboBox c1IndicatorType;
        private C1NumericEditEx period;
        private C1NumericEditEx nudFastPeriod;
        private C1NumericEditEx nudSlowPeriod;
        private C1NumericEditEx nudMacdSignalSmoothingPeriod;
        private C1NumericEditEx nudKPeriod;
        private C1NumericEditEx nudDPeriod;
        private C1NumericEditEx nudStochasticSmoothingPeriod;
    }
}
