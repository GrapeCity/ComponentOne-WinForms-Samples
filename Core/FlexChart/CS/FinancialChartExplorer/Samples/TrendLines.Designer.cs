using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class TrendLines
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1FitType = new C1.Win.Input.C1ComboBox();
            label2 = new Label();
            order = new C1NumericEditEx();
            c1ChkForecast = new C1.Win.Input.C1CheckBox();
            label3 = new Label();
            numForwardPeriods = new C1NumericEditEx();
            label4 = new Label();
            numBackwardPeriods = new C1NumericEditEx();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FitType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ChkForecast).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numForwardPeriods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBackwardPeriods).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1640, 821);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1FitType);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(order);
            flowLayoutPanel1.Controls.Add(c1ChkForecast);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(numForwardPeriods);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(numBackwardPeriods);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 744);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 23, 0, 0);
            flowLayoutPanel1.Size = new Size(1640, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13F);
            label1.Location = new Point(5, 32);
            label1.Margin = new Padding(5, 6, 5, 6);
            label1.Name = "label1";
            label1.Size = new Size(107, 35);
            label1.TabIndex = 0;
            label1.Text = "Fit Type:";
            // 
            // c1FitType
            // 
            c1FitType.Anchor = AnchorStyles.Left;
            c1FitType.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1FitType.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1FitType.Font = new Font("Segoe UI Variable Display", 13F);
            c1FitType.GapHeight = 5;
            c1FitType.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1FitType.Location = new Point(120, 28);
            c1FitType.Name = "c1FitType";
            c1FitType.ReadOnly = true;
            c1FitType.Size = new Size(253, 43);
            c1FitType.TabIndex = 10;
            c1FitType.TextAlign = HorizontalAlignment.Center;
            c1FitType.SelectedIndexChanged += c1FitType_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13F);
            label2.Location = new Point(381, 32);
            label2.Margin = new Padding(5, 6, 5, 6);
            label2.Name = "label2";
            label2.Size = new Size(86, 35);
            label2.TabIndex = 2;
            label2.Text = "Order:";
            // 
            // order
            // 
            order.Anchor = AnchorStyles.Left;
            order.Location = new Point(475, 33);
            order.Maximum = 10;
            order.Minimum = 2;
            order.Name = "order";
            order.Size = new Size(79, 33);
            order.TabIndex = 12;
            order.TextAlign = HorizontalAlignment.Center;
            order.Value = new decimal(new int[] { 2, 0, 0, 0 });
            order.ValueChanged += order_ValueChanged_1;
            // 
            // c1ChkForecast
            // 
            c1ChkForecast.Anchor = AnchorStyles.Left;
            c1ChkForecast.Font = new Font("Segoe UI Variable Display", 13F);
            c1ChkForecast.Location = new Point(560, 26);
            c1ChkForecast.Name = "c1ChkForecast";
            c1ChkForecast.Size = new Size(150, 48);
            c1ChkForecast.TabIndex = 11;
            c1ChkForecast.Text = "Forecast Enable";
            c1ChkForecast.Value = null;
            c1ChkForecast.CheckedChanged += c1ChkForecast_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13F);
            label3.Location = new Point(713, 32);
            label3.Margin = new Padding(0, 6, 5, 6);
            label3.Name = "label3";
            label3.Size = new Size(112, 35);
            label3.TabIndex = 6;
            label3.Text = "Forward:";
            // 
            // numForwardPeriods
            // 
            numForwardPeriods.Anchor = AnchorStyles.Left;
            numForwardPeriods.Location = new Point(833, 33);
            numForwardPeriods.Name = "numForwardPeriods";
            numForwardPeriods.Size = new Size(91, 33);
            numForwardPeriods.TabIndex = 13;
            numForwardPeriods.TextAlign = HorizontalAlignment.Center;
            numForwardPeriods.Value = new decimal(new int[] { 30, 0, 0, 0 });
            numForwardPeriods.ValueChanged += numForwardPeriods_ValueChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13F);
            label4.Location = new Point(932, 32);
            label4.Margin = new Padding(5, 6, 5, 6);
            label4.Name = "label4";
            label4.Size = new Size(130, 35);
            label4.TabIndex = 8;
            label4.Text = "Backward:";
            // 
            // numBackwardPeriods
            // 
            numBackwardPeriods.Anchor = AnchorStyles.Left;
            numBackwardPeriods.Location = new Point(1070, 33);
            numBackwardPeriods.Name = "numBackwardPeriods";
            numBackwardPeriods.Size = new Size(91, 33);
            numBackwardPeriods.TabIndex = 14;
            numBackwardPeriods.TextAlign = HorizontalAlignment.Center;
            numBackwardPeriods.Value = new decimal(new int[] { 0, 0, 0, 0 });
            numBackwardPeriods.ValueChanged += numBackwardPeriods_ValueChanged_1;
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
            financialChart1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize1;
            financialChart1.Options.ReversalAmount = 1D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1640, 744);
            financialChart1.TabIndex = 1;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // TrendLines
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TrendLines";
            Size = new Size(1640, 821);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1FitType).EndInit();
            ((System.ComponentModel.ISupportInitialize)order).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ChkForecast).EndInit();
            ((System.ComponentModel.ISupportInitialize)numForwardPeriods).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBackwardPeriods).EndInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private C1.Win.Input.C1ComboBox c1FitType;
        private C1.Win.Input.C1CheckBox c1ChkForecast;
        private C1NumericEditEx order;
        private C1NumericEditEx numForwardPeriods;
        private C1NumericEditEx numBackwardPeriods;
    }
}
