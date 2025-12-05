namespace ControlExplorer.RulesManager
{
    partial class ChartConditionalFormatting
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
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            this.commandDock = new C1.Win.Command.C1CommandDock();
            this.dockingTabConditionalFormatting = new C1.Win.Command.C1DockingTab();
            this.dockingTabPageConditionalFormatting = new C1.Win.Command.C1DockingTabPage();
            this.rulesManager = new C1.Win.RulesManager.C1RulesManager();
            this.formattablePieChart = new ControlExplorer.RulesManager.FormattablePieChart();
            this.formattableFlexChart = new ControlExplorer.RulesManager.FormattableFlexChart();
            this.dockingTabCharts = new C1.Win.Command.C1DockingTab();
            this.dockingTabPagePieChart = new C1.Win.Command.C1DockingTabPage();
            this.dockingTabPageFlexChart = new C1.Win.Command.C1DockingTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).BeginInit();
            this.commandDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTabConditionalFormatting)).BeginInit();
            this.dockingTabConditionalFormatting.SuspendLayout();
            this.dockingTabPageConditionalFormatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableFlexChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTabCharts)).BeginInit();
            this.dockingTabCharts.SuspendLayout();
            this.dockingTabPagePieChart.SuspendLayout();
            this.dockingTabPageFlexChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // commandDock
            // 
            this.commandDock.Controls.Add(this.dockingTabConditionalFormatting);
            this.commandDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandDock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.commandDock.Id = 1;
            this.commandDock.Location = new System.Drawing.Point(1192, 0);
            this.commandDock.Name = "commandDock";
            this.commandDock.Size = new System.Drawing.Size(200, 752);
            // 
            // dockingTabConditionalFormatting
            // 
            this.dockingTabConditionalFormatting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTabConditionalFormatting.Controls.Add(this.dockingTabPageConditionalFormatting);
            this.dockingTabConditionalFormatting.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dockingTabConditionalFormatting.HotTrack = true;
            this.dockingTabConditionalFormatting.Location = new System.Drawing.Point(0, 0);
            this.dockingTabConditionalFormatting.Name = "dockingTabConditionalFormatting";
            this.dockingTabConditionalFormatting.ShowSingleTab = false;
            this.dockingTabConditionalFormatting.Size = new System.Drawing.Size(200, 752);
            this.dockingTabConditionalFormatting.TabIndex = 0;
            this.dockingTabConditionalFormatting.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTabConditionalFormatting.TabsSpacing = 2;
            this.dockingTabConditionalFormatting.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.dockingTabConditionalFormatting.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // dockingTabPageConditionalFormatting
            // 
            this.dockingTabPageConditionalFormatting.Controls.Add(this.rulesManager);
            this.dockingTabPageConditionalFormatting.Location = new System.Drawing.Point(4, 1);
            this.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting";
            this.dockingTabPageConditionalFormatting.Size = new System.Drawing.Size(195, 750);
            this.dockingTabPageConditionalFormatting.TabIndex = 0;
            this.dockingTabPageConditionalFormatting.Text = "Conditional Formatting";
            // 
            // rulesManager
            // 
            this.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesManager.Location = new System.Drawing.Point(0, 0);
            this.rulesManager.Name = "rulesManager";
            this.rulesManager.Size = new System.Drawing.Size(195, 750);
            this.rulesManager.TabIndex = 0;
            this.rulesManager.Text = "rulesManager";
            // 
            // formattablePieChart
            // 
            this.formattablePieChart.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius;
            this.formattablePieChart.AnimationLoad.Duration = 400;
            this.formattablePieChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.formattablePieChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.formattablePieChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.formattablePieChart.AnimationUpdate.Duration = 400;
            this.formattablePieChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.formattablePieChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.formattablePieChart.BackColor = System.Drawing.Color.White;
            this.formattablePieChart.Binding = "UnitsOnOrder";
            this.formattablePieChart.BindingName = "ProductName";
            this.rulesManager.SetC1RulesManager(this.formattablePieChart, this.rulesManager);
            this.formattablePieChart.DataLabel.Border = false;
            this.formattablePieChart.DataLabel.ConnectingLine = false;
            this.formattablePieChart.DataLabel.Content = null;
            this.formattablePieChart.DataLabel.Offset = 0;
            this.formattablePieChart.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.Default;
            this.formattablePieChart.DataLabel.Position = C1.Chart.PieLabelPosition.None;
            this.formattablePieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattablePieChart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.formattablePieChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.formattablePieChart.Header.Content = "Products: Units on Order";
            this.formattablePieChart.Legend.ItemMaxWidth = 0;
            this.formattablePieChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.formattablePieChart.Legend.Position = C1.Chart.Position.Right;
            this.formattablePieChart.Legend.Reversed = false;
            this.formattablePieChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.formattablePieChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.formattablePieChart.Legend.Title = null;
            this.formattablePieChart.Location = new System.Drawing.Point(0, 0);
            this.formattablePieChart.Name = "formattablePieChart";
            this.formattablePieChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.formattablePieChart.Size = new System.Drawing.Size(1190, 722);
            this.formattablePieChart.TabIndex = 0;
            this.formattablePieChart.Text = "formattablePieChart";
            this.formattablePieChart.Titles = null;
            // 
            // 
            // 
            this.formattablePieChart.ToolTip.Content = "";
            // 
            // formattableFlexChart
            // 
            this.formattableFlexChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.formattableFlexChart.AnimationLoad.Duration = 400;
            this.formattableFlexChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.formattableFlexChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.formattableFlexChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.formattableFlexChart.AnimationUpdate.Duration = 400;
            this.formattableFlexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.formattableFlexChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.formattableFlexChart.AxisX.Chart = this.formattableFlexChart;
            this.formattableFlexChart.AxisX.DataSource = null;
            this.formattableFlexChart.AxisX.GroupProvider = null;
            this.formattableFlexChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.formattableFlexChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.formattableFlexChart.AxisX.GroupVisibilityLevel = 0;
            this.formattableFlexChart.AxisX.LabelMax = false;
            this.formattableFlexChart.AxisX.LabelMin = false;
            this.formattableFlexChart.AxisX.PlotAreaName = null;
            this.formattableFlexChart.AxisX.Position = C1.Chart.Position.Bottom;
            this.formattableFlexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.formattableFlexChart.AxisY.AxisLine = false;
            this.formattableFlexChart.AxisY.Chart = this.formattableFlexChart;
            this.formattableFlexChart.AxisY.DataSource = null;
            this.formattableFlexChart.AxisY.GroupProvider = null;
            this.formattableFlexChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.formattableFlexChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.formattableFlexChart.AxisY.GroupVisibilityLevel = 0;
            this.formattableFlexChart.AxisY.LabelMax = false;
            this.formattableFlexChart.AxisY.LabelMin = false;
            this.formattableFlexChart.AxisY.MajorGrid = true;
            this.formattableFlexChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.formattableFlexChart.AxisY.PlotAreaName = null;
            this.formattableFlexChart.AxisY.Position = C1.Chart.Position.Left;
            this.formattableFlexChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.formattableFlexChart.BackColor = System.Drawing.Color.White;
            this.formattableFlexChart.BindingX = "ProductName";
            this.rulesManager.SetC1RulesManager(this.formattableFlexChart, this.rulesManager);
            this.formattableFlexChart.DataLabel.Angle = 0;
            this.formattableFlexChart.DataLabel.Border = false;
            this.formattableFlexChart.DataLabel.ConnectingLine = false;
            this.formattableFlexChart.DataLabel.Content = "{}{y}";
            this.formattableFlexChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.formattableFlexChart.DataLabel.MaxAutoLabels = 100;
            this.formattableFlexChart.DataLabel.MaxLines = 0;
            this.formattableFlexChart.DataLabel.MaxWidth = 0;
            this.formattableFlexChart.DataLabel.Offset = 0;
            this.formattableFlexChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.formattableFlexChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.formattableFlexChart.DataLabel.Position = C1.Chart.LabelPosition.Top;
            this.formattableFlexChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattableFlexChart.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.formattableFlexChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.formattableFlexChart.Legend.ItemMaxWidth = 0;
            this.formattableFlexChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.formattableFlexChart.Legend.Position = C1.Chart.Position.Top;
            this.formattableFlexChart.Legend.Reversed = false;
            this.formattableFlexChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.formattableFlexChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.formattableFlexChart.Legend.Title = null;
            this.formattableFlexChart.Location = new System.Drawing.Point(0, 0);
            this.formattableFlexChart.Margin = new System.Windows.Forms.Padding(10);
            this.formattableFlexChart.Name = "formattableFlexChart";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.formattableFlexChart.Options.ClusterSize = elementSize1;
            this.formattableFlexChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.formattableFlexChart.SelectedSeries = null;
            this.formattableFlexChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Binding = "UnitsOnOrder";
            series1.DataLabel = null;
            series1.Name = "UnitsOnOrder";
            series1.StackingGroup = -1;
            series1.Tooltip = null;
            series2.Binding = "UnitsInStock";
            series2.DataLabel = null;
            series2.Name = "UnitsInStock";
            series2.StackingGroup = -1;
            series2.Tooltip = null;
            this.formattableFlexChart.Series.Add(series1);
            this.formattableFlexChart.Series.Add(series2);
            this.formattableFlexChart.Size = new System.Drawing.Size(1190, 722);
            this.formattableFlexChart.TabIndex = 0;
            this.formattableFlexChart.Text = "formattableFlexChart";
            // 
            // 
            // 
            this.formattableFlexChart.ToolTip.Content = "";
            // 
            // dockingTabCharts
            // 
            this.dockingTabCharts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTabCharts.Controls.Add(this.dockingTabPagePieChart);
            this.dockingTabCharts.Controls.Add(this.dockingTabPageFlexChart);
            this.dockingTabCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockingTabCharts.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dockingTabCharts.HotTrack = true;
            this.dockingTabCharts.Location = new System.Drawing.Point(0, 0);
            this.dockingTabCharts.Name = "dockingTabCharts";
            this.dockingTabCharts.Size = new System.Drawing.Size(1192, 752);
            this.dockingTabCharts.TabIndex = 0;
            this.dockingTabCharts.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTabCharts.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.dockingTabCharts.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // dockingTabPagePieChart
            // 
            this.dockingTabPagePieChart.Controls.Add(this.formattablePieChart);
            this.dockingTabPagePieChart.Location = new System.Drawing.Point(1, 29);
            this.dockingTabPagePieChart.Name = "dockingTabPagePieChart";
            this.dockingTabPagePieChart.Size = new System.Drawing.Size(1190, 722);
            this.dockingTabPagePieChart.TabIndex = 0;
            this.dockingTabPagePieChart.Text = "Pie Chart";
            // 
            // dockingTabPageFlexChart
            // 
            this.dockingTabPageFlexChart.Controls.Add(this.formattableFlexChart);
            this.dockingTabPageFlexChart.Location = new System.Drawing.Point(1, 29);
            this.dockingTabPageFlexChart.Name = "dockingTabPageFlexChart";
            this.dockingTabPageFlexChart.Size = new System.Drawing.Size(1190, 722);
            this.dockingTabPageFlexChart.TabIndex = 1;
            this.dockingTabPageFlexChart.Text = "Flex Chart";
            // 
            // ChartConditionalFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 752);
            this.Controls.Add(this.dockingTabCharts);
            this.Controls.Add(this.commandDock);
            this.Name = "ChartConditionalFormatting";
            this.Text = "ChartConditionalFormatting";
            this.Load += new System.EventHandler(this.ChartConditionalFormatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).EndInit();
            this.commandDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTabConditionalFormatting)).EndInit();
            this.dockingTabConditionalFormatting.ResumeLayout(false);
            this.dockingTabPageConditionalFormatting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableFlexChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTabCharts)).EndInit();
            this.dockingTabCharts.ResumeLayout(false);
            this.dockingTabPagePieChart.ResumeLayout(false);
            this.dockingTabPageFlexChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Command.C1CommandDock commandDock;
        private C1.Win.Command.C1DockingTab dockingTabConditionalFormatting;
        private C1.Win.Command.C1DockingTabPage dockingTabPageConditionalFormatting;
        private C1.Win.RulesManager.C1RulesManager rulesManager;
        private C1.Win.Command.C1DockingTab dockingTabCharts;
        private C1.Win.Command.C1DockingTabPage dockingTabPagePieChart;
        private ControlExplorer.RulesManager.FormattablePieChart formattablePieChart;
        private C1.Win.Command.C1DockingTabPage dockingTabPageFlexChart;
        private ControlExplorer.RulesManager.FormattableFlexChart formattableFlexChart;
    }
}

