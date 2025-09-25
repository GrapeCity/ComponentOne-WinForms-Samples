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
            tableLayoutPanel1 = new TableLayoutPanel();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            financialChart2 = new C1.Win.Chart.Finance.FinancialChart();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1IndicatorType = new C1.Win.Input.C1ComboBox();
            label2 = new Label();
            period = new C1NumericEditEx();
            label3 = new Label();
            nudFastPeriod = new C1NumericEditEx();
            label4 = new Label();
            nudSlowPeriod = new C1NumericEditEx();
            label5 = new Label();
            nudMacdSignalSmoothingPeriod = new C1NumericEditEx();
            label6 = new Label();
            nudKPeriod = new C1NumericEditEx();
            label7 = new Label();
            nudDPeriod = new C1NumericEditEx();
            label8 = new Label();
            nudStochasticSmoothingPeriod = new C1NumericEditEx();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financialChart2).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1IndicatorType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)period).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFastPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSlowPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMacdSignalSmoothingPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudKPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDPeriod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStochasticSmoothingPeriod).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Controls.Add(financialChart2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1347, 654);
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
            financialChart1.Location = new Point(10, 10);
            financialChart1.Margin = new Padding(10);
            financialChart1.Name = "financialChart1";
            financialChart1.Options.BoxSize = 2D;
            financialChart1.Options.Chart = financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize1;
            financialChart1.Options.ReversalAmount = 1D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1327, 382);
            financialChart1.TabIndex = 0;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // financialChart2
            // 
            financialChart2.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            financialChart2.AnimationLoad.Duration = 400;
            financialChart2.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            financialChart2.AnimationLoad.Type = C1.Chart.AnimationType.All;
            financialChart2.AnimationSettings = C1.Chart.AnimationSettings.None;
            financialChart2.AnimationUpdate.Duration = 400;
            financialChart2.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            financialChart2.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            financialChart2.AxisX.AxisLine = true;
            financialChart2.AxisX.Chart = financialChart2;
            financialChart2.AxisX.DataSource = null;
            financialChart2.AxisX.Formatter = null;
            financialChart2.AxisX.GroupProvider = null;
            financialChart2.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart2.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart2.AxisX.GroupVisibilityLevel = 0;
            financialChart2.AxisX.PlotAreaName = null;
            financialChart2.AxisX.Position = C1.Chart.Position.Bottom;
            financialChart2.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart2.AxisY.AxisLine = false;
            financialChart2.AxisY.Chart = financialChart2;
            financialChart2.AxisY.DataSource = null;
            financialChart2.AxisY.Formatter = null;
            financialChart2.AxisY.GroupProvider = null;
            financialChart2.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart2.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart2.AxisY.GroupVisibilityLevel = 0;
            financialChart2.AxisY.MajorGrid = true;
            financialChart2.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            financialChart2.AxisY.PlotAreaName = null;
            financialChart2.AxisY.Position = C1.Chart.Position.Left;
            financialChart2.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            financialChart2.DataLabel.Angle = 0;
            financialChart2.DataLabel.Border = false;
            financialChart2.DataLabel.ConnectingLine = false;
            financialChart2.DataLabel.Content = null;
            financialChart2.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            financialChart2.DataLabel.MaxAutoLabels = 100;
            financialChart2.DataLabel.MaxLines = 0;
            financialChart2.DataLabel.MaxWidth = 0;
            financialChart2.DataLabel.Offset = 0;
            financialChart2.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            financialChart2.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            financialChart2.DataLabel.Position = C1.Chart.LabelPosition.None;
            financialChart2.Dock = DockStyle.Fill;
            financialChart2.Legend.ItemMaxWidth = 0;
            financialChart2.Legend.Orientation = C1.Chart.Orientation.Auto;
            financialChart2.Legend.Position = C1.Chart.Position.Right;
            financialChart2.Legend.Reversed = false;
            financialChart2.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            financialChart2.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            financialChart2.Legend.Title = null;
            financialChart2.Location = new Point(0, 402);
            financialChart2.Margin = new Padding(0);
            financialChart2.Name = "financialChart2";
            financialChart2.Options.BoxSize = 2D;
            financialChart2.Options.Chart = financialChart2;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            financialChart2.Options.ClusterSize = elementSize2;
            financialChart2.Options.ReversalAmount = 1D;
            financialChart2.PlotMargin = new Padding(0);
            financialChart2.SelectedSeries = null;
            financialChart2.SelectionStyle.StrokeColor = Color.Red;
            financialChart2.Size = new Size(1347, 133);
            financialChart2.TabIndex = 1;
            financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            financialChart2.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1IndicatorType);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(period);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(nudFastPeriod);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(nudSlowPeriod);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(nudMacdSignalSmoothingPeriod);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(nudKPeriod);
            flowLayoutPanel1.Controls.Add(label7);
            flowLayoutPanel1.Controls.Add(nudDPeriod);
            flowLayoutPanel1.Controls.Add(label8);
            flowLayoutPanel1.Controls.Add(nudStochasticSmoothingPeriod);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel1.Location = new Point(0, 535);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(1347, 119);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 24);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 36);
            label1.TabIndex = 0;
            label1.Text = "Indicator Type:";
            // 
            // c1IndicatorType
            // 
            c1IndicatorType.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1IndicatorType.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1IndicatorType.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1IndicatorType.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1IndicatorType.Location = new Point(200, 18);
            c1IndicatorType.Name = "c1IndicatorType";
            c1IndicatorType.ReadOnly = true;
            c1IndicatorType.Size = new Size(364, 44);
            c1IndicatorType.TabIndex = 2;
            c1IndicatorType.TextAlign = HorizontalAlignment.Center;
            c1IndicatorType.SelectedIndexChanged += c1IndicatorType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(580, 24);
            label2.Margin = new Padding(13, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 36);
            label2.TabIndex = 2;
            label2.Text = "Period:";
            // 
            // period
            // 
            period.Location = new Point(683, 18);
            period.Minimum = 1;
            period.Name = "period";
            period.Size = new Size(57, 46);
            period.TabIndex = 16;
            period.TextAlign = HorizontalAlignment.Center;
            period.Value = new decimal(new int[] { 1, 0, 0, 0 });
            period.ValueChanged += period_ValueChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(759, 24);
            label3.Margin = new Padding(16, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 36);
            label3.TabIndex = 4;
            label3.Text = "Fast period:";
            // 
            // nudFastPeriod
            // 
            nudFastPeriod.Location = new Point(917, 18);
            nudFastPeriod.Minimum = 2;
            nudFastPeriod.Name = "nudFastPeriod";
            nudFastPeriod.Size = new Size(57, 46);
            nudFastPeriod.TabIndex = 17;
            nudFastPeriod.TextAlign = HorizontalAlignment.Center;
            nudFastPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudFastPeriod.ValueChanged += nudFastPeriod_ValueChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(993, 24);
            label4.Margin = new Padding(16, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 36);
            label4.TabIndex = 6;
            label4.Text = "Slow period:";
            // 
            // nudSlowPeriod
            // 
            nudSlowPeriod.Location = new Point(1160, 18);
            nudSlowPeriod.Minimum = 2;
            nudSlowPeriod.Name = "nudSlowPeriod";
            nudSlowPeriod.Size = new Size(57, 46);
            nudSlowPeriod.TabIndex = 18;
            nudSlowPeriod.TextAlign = HorizontalAlignment.Center;
            nudSlowPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudSlowPeriod.ValueChanged += nudSlowPeriod_ValueChanged_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 76);
            label5.Margin = new Padding(16, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(311, 36);
            label5.TabIndex = 8;
            label5.Text = "Signal smoothing period:";
            // 
            // nudMacdSignalSmoothingPeriod
            // 
            nudMacdSignalSmoothingPeriod.Location = new Point(333, 70);
            nudMacdSignalSmoothingPeriod.Minimum = 2;
            nudMacdSignalSmoothingPeriod.Name = "nudMacdSignalSmoothingPeriod";
            nudMacdSignalSmoothingPeriod.Size = new Size(57, 46);
            nudMacdSignalSmoothingPeriod.TabIndex = 19;
            nudMacdSignalSmoothingPeriod.TextAlign = HorizontalAlignment.Center;
            nudMacdSignalSmoothingPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudMacdSignalSmoothingPeriod.ValueChanged += nudMacdSignalSmoothingPeriod_ValueChanged_1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(409, 76);
            label6.Margin = new Padding(16, 3, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 36);
            label6.TabIndex = 10;
            label6.Text = "K period:";
            // 
            // nudKPeriod
            // 
            nudKPeriod.Location = new Point(536, 70);
            nudKPeriod.Minimum = 2;
            nudKPeriod.Name = "nudKPeriod";
            nudKPeriod.Size = new Size(57, 46);
            nudKPeriod.TabIndex = 20;
            nudKPeriod.TextAlign = HorizontalAlignment.Center;
            nudKPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudKPeriod.ValueChanged += nudKPeriod_ValueChanged_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(612, 76);
            label7.Margin = new Padding(16, 3, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(124, 36);
            label7.TabIndex = 12;
            label7.Text = "D period:";
            // 
            // nudDPeriod
            // 
            nudDPeriod.Location = new Point(742, 70);
            nudDPeriod.Minimum = 2;
            nudDPeriod.Name = "nudDPeriod";
            nudDPeriod.Size = new Size(57, 46);
            nudDPeriod.TabIndex = 22;
            nudDPeriod.TextAlign = HorizontalAlignment.Center;
            nudDPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudDPeriod.ValueChanged += nudDPeriod_ValueChanged_1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(818, 76);
            label8.Margin = new Padding(16, 3, 3, 0);
            label8.Name = "label8";
            label8.Size = new Size(311, 36);
            label8.TabIndex = 14;
            label8.Text = "Signal smoothing period:";
            // 
            // nudStochasticSmoothingPeriod
            // 
            nudStochasticSmoothingPeriod.Location = new Point(1135, 70);
            nudStochasticSmoothingPeriod.Minimum = 2;
            nudStochasticSmoothingPeriod.Name = "nudStochasticSmoothingPeriod";
            nudStochasticSmoothingPeriod.Size = new Size(57, 46);
            nudStochasticSmoothingPeriod.TabIndex = 21;
            nudStochasticSmoothingPeriod.TextAlign = HorizontalAlignment.Center;
            nudStochasticSmoothingPeriod.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudStochasticSmoothingPeriod.ValueChanged += nudStochasticSmoothingPeriod_ValueChanged;
            // 
            // Indicators
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Indicators";
            Size = new Size(1347, 654);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)financialChart2).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1IndicatorType).EndInit();
            ((System.ComponentModel.ISupportInitialize)period).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFastPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSlowPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMacdSignalSmoothingPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudKPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDPeriod).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStochasticSmoothingPeriod).EndInit();
            ResumeLayout(false);

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
        private C1.Win.Input.C1ComboBox c1IndicatorType;
        private C1NumericEditEx period;
        private C1NumericEditEx nudFastPeriod;
        private C1NumericEditEx nudSlowPeriod;
        private C1NumericEditEx nudMacdSignalSmoothingPeriod;
        private C1NumericEditEx nudKPeriod;
        private C1NumericEditEx nudDPeriod;
        private C1NumericEditEx nudStochasticSmoothingPeriod;
    }
}
