namespace FinancialChartExplorer.Samples
{
    partial class RangeSelector
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
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financialChart2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Controls.Add(financialChart2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1514, 866);
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
            financialChart1.Location = new Point(16, 19);
            financialChart1.Margin = new Padding(16, 19, 16, 19);
            financialChart1.Name = "financialChart1";
            financialChart1.Options.BoxSize = 2D;
            financialChart1.Options.Chart = financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize1;
            financialChart1.Options.ReversalAmount = 2D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1482, 630);
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
            financialChart2.Location = new Point(16, 687);
            financialChart2.Margin = new Padding(16, 19, 16, 19);
            financialChart2.Name = "financialChart2";
            financialChart2.Options.BoxSize = 2D;
            financialChart2.Options.Chart = financialChart2;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            financialChart2.Options.ClusterSize = elementSize2;
            financialChart2.Options.ReversalAmount = 2D;
            financialChart2.PlotMargin = new Padding(0);
            financialChart2.SelectedSeries = null;
            financialChart2.SelectionStyle.StrokeColor = Color.Red;
            financialChart2.Size = new Size(1482, 160);
            financialChart2.TabIndex = 1;
            financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            financialChart2.ToolTip.Content = "{value}";
            // 
            // RangeSelector
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(0);
            Name = "RangeSelector";
            Size = new Size(1514, 866);
            Load += RangeSelector_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)financialChart2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
    }
}
