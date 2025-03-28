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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            chartRangeSelector = new C1.Win.Chart.FlexChart();
            chartPrecipitation = new C1.Win.Chart.FlexChart();
            chartPressure = new C1.Win.Chart.FlexChart();
            chartTemperature = new C1.Win.Chart.FlexChart();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRangeSelector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPrecipitation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartTemperature).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(chartRangeSelector, 0, 3);
            tableLayoutPanel1.Controls.Add(chartPrecipitation, 0, 2);
            tableLayoutPanel1.Controls.Add(chartPressure, 0, 1);
            tableLayoutPanel1.Controls.Add(chartTemperature, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 12F);
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1007, 774);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // chartRangeSelector
            // 
            chartRangeSelector.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartRangeSelector.AnimationLoad.Duration = 400;
            chartRangeSelector.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartRangeSelector.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartRangeSelector.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartRangeSelector.AnimationUpdate.Duration = 400;
            chartRangeSelector.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartRangeSelector.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartRangeSelector.AxisX.AxisLine = true;
            chartRangeSelector.AxisX.Chart = chartRangeSelector;
            chartRangeSelector.AxisX.DataSource = null;
            chartRangeSelector.AxisX.Formatter = null;
            chartRangeSelector.AxisX.GroupProvider = null;
            chartRangeSelector.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartRangeSelector.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartRangeSelector.AxisX.GroupVisibilityLevel = 0;
            chartRangeSelector.AxisX.LabelAngle = 45D;
            chartRangeSelector.AxisX.PlotAreaName = null;
            chartRangeSelector.AxisX.Position = C1.Chart.Position.Bottom;
            chartRangeSelector.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartRangeSelector.AxisY.AxisLine = false;
            chartRangeSelector.AxisY.Chart = chartRangeSelector;
            chartRangeSelector.AxisY.DataSource = null;
            chartRangeSelector.AxisY.Formatter = null;
            chartRangeSelector.AxisY.GroupProvider = null;
            chartRangeSelector.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartRangeSelector.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartRangeSelector.AxisY.GroupVisibilityLevel = 0;
            chartRangeSelector.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            chartRangeSelector.AxisY.PlotAreaName = null;
            chartRangeSelector.AxisY.Position = C1.Chart.Position.Left;
            chartRangeSelector.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartRangeSelector.DataLabel.Angle = 0;
            chartRangeSelector.DataLabel.Border = false;
            chartRangeSelector.DataLabel.ConnectingLine = false;
            chartRangeSelector.DataLabel.Content = null;
            chartRangeSelector.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartRangeSelector.DataLabel.MaxAutoLabels = 100;
            chartRangeSelector.DataLabel.MaxLines = 0;
            chartRangeSelector.DataLabel.MaxWidth = 0;
            chartRangeSelector.DataLabel.Offset = 0;
            chartRangeSelector.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartRangeSelector.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartRangeSelector.DataLabel.Position = C1.Chart.LabelPosition.None;
            chartRangeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            chartRangeSelector.Legend.ItemMaxWidth = 0;
            chartRangeSelector.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartRangeSelector.Legend.Position = C1.Chart.Position.None;
            chartRangeSelector.Legend.Reversed = false;
            chartRangeSelector.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartRangeSelector.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartRangeSelector.Legend.Title = null;
            chartRangeSelector.Location = new System.Drawing.Point(0, 603);
            chartRangeSelector.Margin = new System.Windows.Forms.Padding(0);
            chartRangeSelector.Name = "chartRangeSelector";
            chartRangeSelector.Options.Chart = chartRangeSelector;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            chartRangeSelector.Options.ClusterSize = elementSize1;
            chartRangeSelector.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 0);
            chartRangeSelector.SelectedSeries = null;
            chartRangeSelector.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            chartRangeSelector.Series.Add(series1);
            chartRangeSelector.Size = new System.Drawing.Size(1007, 171);
            chartRangeSelector.TabIndex = 3;
            chartRangeSelector.Text = "flexChart1";
            // 
            // 
            // 
            chartRangeSelector.ToolTip.Content = "{value}";
            chartRangeSelector.Rendered += chartRangeSelector_Rendered;
            // 
            // chartPrecipitation
            // 
            chartPrecipitation.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartPrecipitation.AnimationLoad.Duration = 400;
            chartPrecipitation.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartPrecipitation.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartPrecipitation.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartPrecipitation.AnimationUpdate.Duration = 400;
            chartPrecipitation.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartPrecipitation.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartPrecipitation.AxisX.AxisLine = true;
            chartPrecipitation.AxisX.Chart = chartPrecipitation;
            chartPrecipitation.AxisX.DataSource = null;
            chartPrecipitation.AxisX.Formatter = null;
            chartPrecipitation.AxisX.GroupProvider = null;
            chartPrecipitation.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartPrecipitation.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartPrecipitation.AxisX.GroupVisibilityLevel = 0;
            chartPrecipitation.AxisX.PlotAreaName = null;
            chartPrecipitation.AxisX.Position = C1.Chart.Position.None;
            chartPrecipitation.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartPrecipitation.AxisY.AxisLine = false;
            chartPrecipitation.AxisY.Chart = chartPrecipitation;
            chartPrecipitation.AxisY.DataSource = null;
            chartPrecipitation.AxisY.Formatter = null;
            chartPrecipitation.AxisY.GroupProvider = null;
            chartPrecipitation.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartPrecipitation.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartPrecipitation.AxisY.GroupVisibilityLevel = 0;
            chartPrecipitation.AxisY.MajorGrid = true;
            chartPrecipitation.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            chartPrecipitation.AxisY.PlotAreaName = null;
            chartPrecipitation.AxisY.Position = C1.Chart.Position.Left;
            chartPrecipitation.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartPrecipitation.AxisY.Title = "Preсipitation";
            chartPrecipitation.DataLabel.Angle = 0;
            chartPrecipitation.DataLabel.Border = false;
            chartPrecipitation.DataLabel.ConnectingLine = false;
            chartPrecipitation.DataLabel.Content = null;
            chartPrecipitation.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartPrecipitation.DataLabel.MaxAutoLabels = 100;
            chartPrecipitation.DataLabel.MaxLines = 0;
            chartPrecipitation.DataLabel.MaxWidth = 0;
            chartPrecipitation.DataLabel.Offset = 0;
            chartPrecipitation.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartPrecipitation.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartPrecipitation.DataLabel.Position = C1.Chart.LabelPosition.None;
            chartPrecipitation.Dock = System.Windows.Forms.DockStyle.Fill;
            chartPrecipitation.Legend.ItemMaxWidth = 0;
            chartPrecipitation.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartPrecipitation.Legend.Position = C1.Chart.Position.None;
            chartPrecipitation.Legend.Reversed = false;
            chartPrecipitation.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartPrecipitation.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartPrecipitation.Legend.Title = null;
            chartPrecipitation.Location = new System.Drawing.Point(0, 402);
            chartPrecipitation.Margin = new System.Windows.Forms.Padding(0);
            chartPrecipitation.Name = "chartPrecipitation";
            chartPrecipitation.Options.Chart = chartPrecipitation;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            chartPrecipitation.Options.ClusterSize = elementSize2;
            chartPrecipitation.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            chartPrecipitation.SelectedSeries = null;
            chartPrecipitation.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series2.DataLabel = null;
            series2.Name = "Series 1";
            series2.StackingGroup = -1;
            series2.Style.StrokeWidth = 2F;
            series2.Tooltip = null;
            chartPrecipitation.Series.Add(series2);
            chartPrecipitation.Size = new System.Drawing.Size(1007, 201);
            chartPrecipitation.TabIndex = 2;
            chartPrecipitation.Text = "flexChart1";
            // 
            // 
            // 
            chartPrecipitation.ToolTip.Content = "{value}";
            chartPrecipitation.Rendered += chartTemperature_Rendered;
            // 
            // chartPressure
            // 
            chartPressure.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartPressure.AnimationLoad.Duration = 400;
            chartPressure.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartPressure.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartPressure.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartPressure.AnimationUpdate.Duration = 400;
            chartPressure.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartPressure.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartPressure.AxisX.AxisLine = true;
            chartPressure.AxisX.Chart = chartPressure;
            chartPressure.AxisX.DataSource = null;
            chartPressure.AxisX.Formatter = null;
            chartPressure.AxisX.GroupProvider = null;
            chartPressure.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartPressure.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartPressure.AxisX.GroupVisibilityLevel = 0;
            chartPressure.AxisX.PlotAreaName = null;
            chartPressure.AxisX.Position = C1.Chart.Position.None;
            chartPressure.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartPressure.AxisY.AxisLine = false;
            chartPressure.AxisY.Chart = chartPressure;
            chartPressure.AxisY.DataSource = null;
            chartPressure.AxisY.Formatter = null;
            chartPressure.AxisY.GroupProvider = null;
            chartPressure.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartPressure.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartPressure.AxisY.GroupVisibilityLevel = 0;
            chartPressure.AxisY.MajorGrid = true;
            chartPressure.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            chartPressure.AxisY.PlotAreaName = null;
            chartPressure.AxisY.Position = C1.Chart.Position.Left;
            chartPressure.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartPressure.AxisY.Title = "MeanPressure";
            chartPressure.DataLabel.Angle = 0;
            chartPressure.DataLabel.Border = false;
            chartPressure.DataLabel.ConnectingLine = false;
            chartPressure.DataLabel.Content = null;
            chartPressure.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartPressure.DataLabel.MaxAutoLabels = 100;
            chartPressure.DataLabel.MaxLines = 0;
            chartPressure.DataLabel.MaxWidth = 0;
            chartPressure.DataLabel.Offset = 0;
            chartPressure.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartPressure.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartPressure.DataLabel.Position = C1.Chart.LabelPosition.None;
            chartPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            chartPressure.Header.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            chartPressure.Legend.ItemMaxWidth = 0;
            chartPressure.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartPressure.Legend.Position = C1.Chart.Position.None;
            chartPressure.Legend.Reversed = false;
            chartPressure.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartPressure.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartPressure.Legend.Title = null;
            chartPressure.Location = new System.Drawing.Point(0, 201);
            chartPressure.Margin = new System.Windows.Forms.Padding(0);
            chartPressure.Name = "chartPressure";
            chartPressure.Options.Chart = chartPressure;
            elementSize3.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize3.Value = 70D;
            chartPressure.Options.ClusterSize = elementSize3;
            chartPressure.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            chartPressure.SelectedSeries = null;
            chartPressure.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series3.DataLabel = null;
            series3.Name = "Series 1";
            series3.StackingGroup = -1;
            series3.Style.StrokeWidth = 2F;
            series3.Tooltip = null;
            chartPressure.Series.Add(series3);
            chartPressure.Size = new System.Drawing.Size(1007, 201);
            chartPressure.TabIndex = 1;
            chartPressure.Text = "flexChart1";
            // 
            // 
            // 
            chartPressure.ToolTip.Content = "{value}";
            chartPressure.Rendered += chartTemperature_Rendered;
            // 
            // chartTemperature
            // 
            chartTemperature.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            chartTemperature.AnimationLoad.Duration = 400;
            chartTemperature.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            chartTemperature.AnimationLoad.Type = C1.Chart.AnimationType.All;
            chartTemperature.AnimationSettings = C1.Chart.AnimationSettings.None;
            chartTemperature.AnimationUpdate.Duration = 400;
            chartTemperature.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            chartTemperature.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            chartTemperature.AxisX.AxisLine = true;
            chartTemperature.AxisX.Chart = chartTemperature;
            chartTemperature.AxisX.DataSource = null;
            chartTemperature.AxisX.Formatter = null;
            chartTemperature.AxisX.GroupProvider = null;
            chartTemperature.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartTemperature.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartTemperature.AxisX.GroupVisibilityLevel = 0;
            chartTemperature.AxisX.LabelAngle = 45D;
            chartTemperature.AxisX.PlotAreaName = null;
            chartTemperature.AxisX.Position = C1.Chart.Position.Top;
            chartTemperature.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            chartTemperature.AxisY.AxisLine = false;
            chartTemperature.AxisY.Chart = chartTemperature;
            chartTemperature.AxisY.DataSource = null;
            chartTemperature.AxisY.Formatter = null;
            chartTemperature.AxisY.GroupProvider = null;
            chartTemperature.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            chartTemperature.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            chartTemperature.AxisY.GroupVisibilityLevel = 0;
            chartTemperature.AxisY.MajorGrid = true;
            chartTemperature.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            chartTemperature.AxisY.PlotAreaName = null;
            chartTemperature.AxisY.Position = C1.Chart.Position.Left;
            chartTemperature.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            chartTemperature.DataLabel.Angle = 0;
            chartTemperature.DataLabel.Border = false;
            chartTemperature.DataLabel.ConnectingLine = false;
            chartTemperature.DataLabel.Content = null;
            chartTemperature.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            chartTemperature.DataLabel.MaxAutoLabels = 100;
            chartTemperature.DataLabel.MaxLines = 0;
            chartTemperature.DataLabel.MaxWidth = 0;
            chartTemperature.DataLabel.Offset = 0;
            chartTemperature.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            chartTemperature.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            chartTemperature.DataLabel.Position = C1.Chart.LabelPosition.None;
            chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            chartTemperature.Legend.ItemMaxWidth = 0;
            chartTemperature.Legend.Orientation = C1.Chart.Orientation.Auto;
            chartTemperature.Legend.Position = C1.Chart.Position.Left;
            chartTemperature.Legend.Reversed = false;
            chartTemperature.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            chartTemperature.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            chartTemperature.Legend.Title = null;
            chartTemperature.Location = new System.Drawing.Point(0, 0);
            chartTemperature.Margin = new System.Windows.Forms.Padding(0);
            chartTemperature.Name = "chartTemperature";
            chartTemperature.Options.Chart = chartTemperature;
            elementSize4.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize4.Value = 70D;
            chartTemperature.Options.ClusterSize = elementSize4;
            chartTemperature.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 5);
            chartTemperature.SelectedSeries = null;
            chartTemperature.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series4.DataLabel = null;
            series4.Name = "Series 1";
            series4.StackingGroup = -1;
            series4.Style.StrokeWidth = 2F;
            series4.Tooltip = null;
            chartTemperature.Series.Add(series4);
            chartTemperature.Size = new System.Drawing.Size(1007, 201);
            chartTemperature.TabIndex = 0;
            chartTemperature.Text = "flexChart1";
            // 
            // 
            // 
            chartTemperature.ToolTip.Content = "{value}";
            chartTemperature.Rendered += chartTemperature_Rendered;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1007, 774);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "WeatherChart";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartRangeSelector).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPrecipitation).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPressure).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartTemperature).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.FlexChart chartTemperature;
        private C1.Win.Chart.FlexChart chartRangeSelector;
        private C1.Win.Chart.FlexChart chartPressure;
        private C1.Win.Chart.FlexChart chartPrecipitation;
    }
}

