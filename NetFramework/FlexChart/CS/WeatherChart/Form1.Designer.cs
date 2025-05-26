namespace WeatherChart
{
    partial class Form1
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize3 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize4 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series4 = new C1.Win.Chart.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartRangeSelector = new C1.Win.Chart.FlexChart();
            this.chartPrecipitation = new C1.Win.Chart.FlexChart();
            this.chartPressure = new C1.Win.Chart.FlexChart();
            this.chartTemperature = new C1.Win.Chart.FlexChart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartRangeSelector, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartPrecipitation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartPressure, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartTemperature, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 619);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartRangeSelector
            // 
            this.chartRangeSelector.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartRangeSelector.AnimationLoad.Duration = 400;
            this.chartRangeSelector.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartRangeSelector.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartRangeSelector.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartRangeSelector.AnimationUpdate.Duration = 400;
            this.chartRangeSelector.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartRangeSelector.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartRangeSelector.AxisX.AxisLine = true;
            this.chartRangeSelector.AxisX.Chart = this.chartRangeSelector;
            this.chartRangeSelector.AxisX.DataSource = null;
            this.chartRangeSelector.AxisX.Formatter = null;
            this.chartRangeSelector.AxisX.GroupProvider = null;
            this.chartRangeSelector.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartRangeSelector.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartRangeSelector.AxisX.GroupVisibilityLevel = 0;
            this.chartRangeSelector.AxisX.LabelAngle = 45D;
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
            this.chartRangeSelector.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartRangeSelector.AxisY.PlotAreaName = null;
            this.chartRangeSelector.AxisY.Position = C1.Chart.Position.Left;
            this.chartRangeSelector.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
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
            this.chartRangeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRangeSelector.Legend.ItemMaxWidth = 0;
            this.chartRangeSelector.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartRangeSelector.Legend.Position = C1.Chart.Position.None;
            this.chartRangeSelector.Legend.Reversed = false;
            this.chartRangeSelector.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartRangeSelector.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartRangeSelector.Legend.Title = null;
            this.chartRangeSelector.Location = new System.Drawing.Point(0, 483);
            this.chartRangeSelector.Margin = new System.Windows.Forms.Padding(0);
            this.chartRangeSelector.Name = "chartRangeSelector";
            this.chartRangeSelector.Options.Chart = this.chartRangeSelector;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.chartRangeSelector.Options.ClusterSize = elementSize1;
            this.chartRangeSelector.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 0);
            this.chartRangeSelector.SelectedSeries = null;
            this.chartRangeSelector.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            this.chartRangeSelector.Series.Add(series1);
            this.chartRangeSelector.Size = new System.Drawing.Size(1007, 136);
            this.chartRangeSelector.TabIndex = 3;
            this.chartRangeSelector.Text = "flexChart1";
            // 
            // 
            // 
            this.chartRangeSelector.ToolTip.Content = "{value}";
            this.chartRangeSelector.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartRangeSelector_Rendered);
            // 
            // chartPrecipitation
            // 
            this.chartPrecipitation.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartPrecipitation.AnimationLoad.Duration = 400;
            this.chartPrecipitation.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartPrecipitation.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartPrecipitation.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartPrecipitation.AnimationUpdate.Duration = 400;
            this.chartPrecipitation.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartPrecipitation.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartPrecipitation.AxisX.AxisLine = true;
            this.chartPrecipitation.AxisX.Chart = this.chartPrecipitation;
            this.chartPrecipitation.AxisX.DataSource = null;
            this.chartPrecipitation.AxisX.Formatter = null;
            this.chartPrecipitation.AxisX.GroupProvider = null;
            this.chartPrecipitation.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartPrecipitation.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartPrecipitation.AxisX.GroupVisibilityLevel = 0;
            this.chartPrecipitation.AxisX.PlotAreaName = null;
            this.chartPrecipitation.AxisX.Position = C1.Chart.Position.None;
            this.chartPrecipitation.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartPrecipitation.AxisY.AxisLine = false;
            this.chartPrecipitation.AxisY.Chart = this.chartPrecipitation;
            this.chartPrecipitation.AxisY.DataSource = null;
            this.chartPrecipitation.AxisY.Formatter = null;
            this.chartPrecipitation.AxisY.GroupProvider = null;
            this.chartPrecipitation.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartPrecipitation.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartPrecipitation.AxisY.GroupVisibilityLevel = 0;
            this.chartPrecipitation.AxisY.MajorGrid = true;
            this.chartPrecipitation.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartPrecipitation.AxisY.PlotAreaName = null;
            this.chartPrecipitation.AxisY.Position = C1.Chart.Position.Left;
            this.chartPrecipitation.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartPrecipitation.AxisY.Title = "Preсipitation";
            this.chartPrecipitation.DataLabel.Angle = 0;
            this.chartPrecipitation.DataLabel.Border = false;
            this.chartPrecipitation.DataLabel.ConnectingLine = false;
            this.chartPrecipitation.DataLabel.Content = null;
            this.chartPrecipitation.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartPrecipitation.DataLabel.MaxAutoLabels = 100;
            this.chartPrecipitation.DataLabel.MaxLines = 0;
            this.chartPrecipitation.DataLabel.MaxWidth = 0;
            this.chartPrecipitation.DataLabel.Offset = 0;
            this.chartPrecipitation.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartPrecipitation.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartPrecipitation.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartPrecipitation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPrecipitation.Legend.ItemMaxWidth = 0;
            this.chartPrecipitation.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartPrecipitation.Legend.Position = C1.Chart.Position.None;
            this.chartPrecipitation.Legend.Reversed = false;
            this.chartPrecipitation.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartPrecipitation.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartPrecipitation.Legend.Title = null;
            this.chartPrecipitation.Location = new System.Drawing.Point(0, 322);
            this.chartPrecipitation.Margin = new System.Windows.Forms.Padding(0);
            this.chartPrecipitation.Name = "chartPrecipitation";
            this.chartPrecipitation.Options.Chart = this.chartPrecipitation;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartPrecipitation.Options.ClusterSize = elementSize2;
            this.chartPrecipitation.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            this.chartPrecipitation.SelectedSeries = null;
            this.chartPrecipitation.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series2.DataLabel = null;
            series2.Name = "Series 1";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            series2.Tooltip = null;
            this.chartPrecipitation.Series.Add(series2);
            this.chartPrecipitation.Size = new System.Drawing.Size(1007, 161);
            this.chartPrecipitation.TabIndex = 2;
            this.chartPrecipitation.Text = "flexChart1";
            // 
            // 
            // 
            this.chartPrecipitation.ToolTip.Content = "{value}";
            this.chartPrecipitation.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // chartPressure
            // 
            this.chartPressure.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartPressure.AnimationLoad.Duration = 400;
            this.chartPressure.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartPressure.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartPressure.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartPressure.AnimationUpdate.Duration = 400;
            this.chartPressure.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartPressure.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartPressure.AxisX.AxisLine = true;
            this.chartPressure.AxisX.Chart = this.chartPressure;
            this.chartPressure.AxisX.DataSource = null;
            this.chartPressure.AxisX.Formatter = null;
            this.chartPressure.AxisX.GroupProvider = null;
            this.chartPressure.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartPressure.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartPressure.AxisX.GroupVisibilityLevel = 0;
            this.chartPressure.AxisX.PlotAreaName = null;
            this.chartPressure.AxisX.Position = C1.Chart.Position.None;
            this.chartPressure.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartPressure.AxisY.AxisLine = false;
            this.chartPressure.AxisY.Chart = this.chartPressure;
            this.chartPressure.AxisY.DataSource = null;
            this.chartPressure.AxisY.Formatter = null;
            this.chartPressure.AxisY.GroupProvider = null;
            this.chartPressure.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartPressure.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartPressure.AxisY.GroupVisibilityLevel = 0;
            this.chartPressure.AxisY.MajorGrid = true;
            this.chartPressure.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartPressure.AxisY.PlotAreaName = null;
            this.chartPressure.AxisY.Position = C1.Chart.Position.Left;
            this.chartPressure.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartPressure.AxisY.Title = "MeanPressure";
            this.chartPressure.DataLabel.Angle = 0;
            this.chartPressure.DataLabel.Border = false;
            this.chartPressure.DataLabel.ConnectingLine = false;
            this.chartPressure.DataLabel.Content = null;
            this.chartPressure.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartPressure.DataLabel.MaxAutoLabels = 100;
            this.chartPressure.DataLabel.MaxLines = 0;
            this.chartPressure.DataLabel.MaxWidth = 0;
            this.chartPressure.DataLabel.Offset = 0;
            this.chartPressure.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartPressure.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartPressure.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPressure.Header.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.chartPressure.Legend.ItemMaxWidth = 0;
            this.chartPressure.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartPressure.Legend.Position = C1.Chart.Position.None;
            this.chartPressure.Legend.Reversed = false;
            this.chartPressure.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartPressure.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartPressure.Legend.Title = null;
            this.chartPressure.Location = new System.Drawing.Point(0, 161);
            this.chartPressure.Margin = new System.Windows.Forms.Padding(0);
            this.chartPressure.Name = "chartPressure";
            this.chartPressure.Options.Chart = this.chartPressure;
            elementSize3.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize3.Value = 70D;
            this.chartPressure.Options.ClusterSize = elementSize3;
            this.chartPressure.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            this.chartPressure.SelectedSeries = null;
            this.chartPressure.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series3.DataLabel = null;
            series3.Name = "Series 1";
            series3.StackingGroup = -1;
            series3.Style.StrokeWidth = 2F;
            series3.Tooltip = null;
            this.chartPressure.Series.Add(series3);
            this.chartPressure.Size = new System.Drawing.Size(1007, 161);
            this.chartPressure.TabIndex = 1;
            this.chartPressure.Text = "flexChart1";
            // 
            // 
            // 
            this.chartPressure.ToolTip.Content = "{value}";
            this.chartPressure.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // chartTemperature
            // 
            this.chartTemperature.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartTemperature.AnimationLoad.Duration = 400;
            this.chartTemperature.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartTemperature.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartTemperature.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartTemperature.AnimationUpdate.Duration = 400;
            this.chartTemperature.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartTemperature.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartTemperature.AxisX.AxisLine = true;
            this.chartTemperature.AxisX.Chart = this.chartTemperature;
            this.chartTemperature.AxisX.DataSource = null;
            this.chartTemperature.AxisX.Formatter = null;
            this.chartTemperature.AxisX.GroupProvider = null;
            this.chartTemperature.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartTemperature.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartTemperature.AxisX.GroupVisibilityLevel = 0;
            this.chartTemperature.AxisX.LabelAngle = 45D;
            this.chartTemperature.AxisX.PlotAreaName = null;
            this.chartTemperature.AxisX.Position = C1.Chart.Position.Top;
            this.chartTemperature.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartTemperature.AxisY.AxisLine = false;
            this.chartTemperature.AxisY.Chart = this.chartTemperature;
            this.chartTemperature.AxisY.DataSource = null;
            this.chartTemperature.AxisY.Formatter = null;
            this.chartTemperature.AxisY.GroupProvider = null;
            this.chartTemperature.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartTemperature.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartTemperature.AxisY.GroupVisibilityLevel = 0;
            this.chartTemperature.AxisY.MajorGrid = true;
            this.chartTemperature.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartTemperature.AxisY.PlotAreaName = null;
            this.chartTemperature.AxisY.Position = C1.Chart.Position.Left;
            this.chartTemperature.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartTemperature.DataLabel.Angle = 0;
            this.chartTemperature.DataLabel.Border = false;
            this.chartTemperature.DataLabel.ConnectingLine = false;
            this.chartTemperature.DataLabel.Content = null;
            this.chartTemperature.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartTemperature.DataLabel.MaxAutoLabels = 100;
            this.chartTemperature.DataLabel.MaxLines = 0;
            this.chartTemperature.DataLabel.MaxWidth = 0;
            this.chartTemperature.DataLabel.Offset = 0;
            this.chartTemperature.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartTemperature.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartTemperature.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTemperature.Legend.ItemMaxWidth = 0;
            this.chartTemperature.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartTemperature.Legend.Position = C1.Chart.Position.Left;
            this.chartTemperature.Legend.Reversed = false;
            this.chartTemperature.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartTemperature.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartTemperature.Legend.Title = null;
            this.chartTemperature.Location = new System.Drawing.Point(0, 0);
            this.chartTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Options.Chart = this.chartTemperature;
            elementSize4.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize4.Value = 70D;
            this.chartTemperature.Options.ClusterSize = elementSize4;
            this.chartTemperature.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 5);
            this.chartTemperature.SelectedSeries = null;
            this.chartTemperature.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series4.DataLabel = null;
            series4.Name = "Series 1";
            series4.StackingGroup = -1;
            series4.Style.StrokeWidth = 2F;
            series4.Tooltip = null;
            this.chartTemperature.Series.Add(series4);
            this.chartTemperature.Size = new System.Drawing.Size(1007, 161);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "flexChart1";
            // 
            // 
            // 
            this.chartTemperature.ToolTip.Content = "{value}";
            this.chartTemperature.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1007, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "WeatherChart";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.FlexChart chartTemperature;
        private C1.Win.Chart.FlexChart chartRangeSelector;
        private C1.Win.Chart.FlexChart chartPressure;
        private C1.Win.Chart.FlexChart chartPrecipitation;
    }
}

