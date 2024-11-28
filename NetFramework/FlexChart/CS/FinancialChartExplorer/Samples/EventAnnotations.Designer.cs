namespace FinancialChartExplorer.Samples
{
    partial class EventAnnotations
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
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.financialChart2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(743, 335);
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
            this.financialChart1.BackColor = System.Drawing.Color.Transparent;
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
            this.financialChart1.Location = new System.Drawing.Point(13, 12);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            this.financialChart1.Options.Chart = this.financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 2D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(717, 189);
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
            this.financialChart2.Location = new System.Drawing.Point(13, 225);
            this.financialChart2.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.financialChart2.Name = "financialChart2";
            this.financialChart2.Options.BoxSize = 2D;
            this.financialChart2.Options.Chart = this.financialChart2;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart2.Options.ClusterSize = elementSize2;
            this.financialChart2.Options.ReversalAmount = 2D;
            this.financialChart2.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart2.SelectedSeries = null;
            this.financialChart2.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart2.Size = new System.Drawing.Size(717, 98);
            this.financialChart2.TabIndex = 1;
            this.financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            this.financialChart2.ToolTip.Content = "{value}";
            // 
            // EventAnnotations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventAnnotations";
            this.Size = new System.Drawing.Size(743, 335);
            this.Load += new System.EventHandler(this.RangeSelector_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
    }
}
