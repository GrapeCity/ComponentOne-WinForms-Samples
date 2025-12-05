namespace RulesManagerExplorer.Samples
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
            this.ribbon = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroupConditionalFormatting = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToggleButtonManageRules = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonCheckBoxHeader = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxAddButton = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRemoveButton = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRuleName = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxRangeSelector = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonCheckBoxCondition = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.commandDock = new C1.Win.Command.C1CommandDock();
            this.dockingTabConditionalFormatting = new C1.Win.Command.C1DockingTab();
            this.dockingTabPageConditionalFormatting = new C1.Win.Command.C1DockingTabPage();
            this.rulesManager = new C1.Win.RulesManager.C1RulesManager();
            this.formattablePieChart = new RulesManagerExplorer.Samples.FormattablePieChart();
            this.formattableFlexChart = new RulesManagerExplorer.Samples.FormattableFlexChart();
            this.dockingTabCharts = new C1.Win.Command.C1DockingTab();
            this.dockingTabPagePieChart = new C1.Win.Command.C1DockingTabPage();
            this.dockingTabPageFlexChart = new C1.Win.Command.C1DockingTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            // ribbon
            // 
            this.ribbon.AllowContextMenu = false;
            this.ribbon.ApplicationMenuHolder = this.ribbonApplicationMenu;
            this.ribbon.BottomToolBarHolder = this.ribbonBottomToolBar;
            this.ribbon.ConfigToolBarHolder = this.ribbonConfigToolBar;
            this.ribbon.HideTabHeaderRow = true;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Name = "ribbon";
            this.ribbon.QatHolder = this.ribbonQat;
            this.ribbon.Size = new System.Drawing.Size(707, 43);
            this.ribbon.Tabs.Add(this.ribbonTab);
            this.ribbon.ToolTipSettings.BackColor = System.Drawing.Color.White;
            this.ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None;
            this.ribbon.ToolTipSettings.Border = true;
            this.ribbon.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.ribbon.ToolTipSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ribbon.ToolTipSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.ribbon.ToolTipSettings.InitialDelay = 900;
            this.ribbon.ToolTipSettings.ReshowDelay = 180;
            this.ribbon.ToolTipSettings.Shadow = false;
            this.ribbon.TopToolBarHolder = this.ribbonTopToolBar1;
            this.ribbon.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu
            // 
            this.ribbonApplicationMenu.Name = "ribbonApplicationMenu";
            this.ribbonApplicationMenu.Visible = false;
            // 
            // ribbonBottomToolBar
            // 
            this.ribbonBottomToolBar.Name = "ribbonBottomToolBar";
            this.ribbonBottomToolBar.Visible = false;
            // 
            // ribbonConfigToolBar
            // 
            this.ribbonConfigToolBar.Name = "ribbonConfigToolBar";
            this.ribbonConfigToolBar.Visible = false;
            // 
            // ribbonQat
            // 
            this.ribbonQat.Name = "ribbonQat";
            this.ribbonQat.Visible = false;
            // 
            // ribbonTab
            // 
            this.ribbonTab.Groups.Add(this.ribbonGroupConditionalFormatting);
            this.ribbonTab.Name = "ribbonTab";
            this.ribbonTab.Text = "Tab";
            // 
            // ribbonGroupConditionalFormatting
            // 
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonToggleButtonManageRules);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxHeader);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxAddButton);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRemoveButton);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRuleName);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxRangeSelector);
            this.ribbonGroupConditionalFormatting.Items.Add(this.ribbonCheckBoxCondition);
            this.ribbonGroupConditionalFormatting.Name = "ribbonGroupConditionalFormatting";
            this.ribbonGroupConditionalFormatting.Text = "Conditional Formatting";
            // 
            // ribbonToggleButtonManageRules
            // 
            this.ribbonToggleButtonManageRules.Name = "ribbonToggleButtonManageRules";
            this.ribbonToggleButtonManageRules.Pressed = true;
            this.ribbonToggleButtonManageRules.Text = "Manage Rules";
            this.ribbonToggleButtonManageRules.PressedChanged += new System.EventHandler(this.ribbonToggleButtonManageRules_PressedChanged);
            // 
            // ribbonCheckBoxHeader
            // 
            this.ribbonCheckBoxHeader.Checked = true;
            this.ribbonCheckBoxHeader.Name = "ribbonCheckBoxHeader";
            this.ribbonCheckBoxHeader.Text = "Header";
            this.ribbonCheckBoxHeader.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxHeader_CheckedChanged);
            // 
            // ribbonCheckBoxAddButton
            // 
            this.ribbonCheckBoxAddButton.Checked = true;
            this.ribbonCheckBoxAddButton.Name = "ribbonCheckBoxAddButton";
            this.ribbonCheckBoxAddButton.Text = "Add button";
            this.ribbonCheckBoxAddButton.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxAddButton_CheckedChanged);
            // 
            // ribbonCheckBoxRemoveButton
            // 
            this.ribbonCheckBoxRemoveButton.Checked = true;
            this.ribbonCheckBoxRemoveButton.Name = "ribbonCheckBoxRemoveButton";
            this.ribbonCheckBoxRemoveButton.Text = "Remove button";
            this.ribbonCheckBoxRemoveButton.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRemoveButton_CheckedChanged);
            // 
            // ribbonCheckBoxRuleName
            // 
            this.ribbonCheckBoxRuleName.Checked = true;
            this.ribbonCheckBoxRuleName.Name = "ribbonCheckBoxRuleName";
            this.ribbonCheckBoxRuleName.Text = "Rule name";
            this.ribbonCheckBoxRuleName.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRuleName_CheckedChanged);
            // 
            // ribbonCheckBoxRangeSelector
            // 
            this.ribbonCheckBoxRangeSelector.Checked = true;
            this.ribbonCheckBoxRangeSelector.Name = "ribbonCheckBoxRangeSelector";
            this.ribbonCheckBoxRangeSelector.Text = "Range selector";
            this.ribbonCheckBoxRangeSelector.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxRangeSelector_CheckedChanged);
            // 
            // ribbonCheckBoxCondition
            // 
            this.ribbonCheckBoxCondition.Checked = true;
            this.ribbonCheckBoxCondition.Name = "ribbonCheckBoxCondition";
            this.ribbonCheckBoxCondition.Text = "Condition";
            this.ribbonCheckBoxCondition.CheckedChanged += new System.EventHandler(this.ribbonCheckBoxCondition_CheckedChanged);
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            this.ribbonTopToolBar1.Visible = false;
            // 
            // commandDock
            // 
            this.commandDock.BackColor = System.Drawing.Color.White;
            this.commandDock.Controls.Add(this.dockingTabConditionalFormatting);
            this.commandDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandDock.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.commandDock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.commandDock.Id = 1;
            this.commandDock.Location = new System.Drawing.Point(407, 43);
            this.commandDock.Name = "commandDock";
            this.commandDock.Size = new System.Drawing.Size(300, 709);
            // 
            // dockingTabConditionalFormatting
            // 
            this.dockingTabConditionalFormatting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dockingTabConditionalFormatting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTabConditionalFormatting.Controls.Add(this.dockingTabPageConditionalFormatting);
            this.dockingTabConditionalFormatting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dockingTabConditionalFormatting.HotTrack = true;
            this.dockingTabConditionalFormatting.Location = new System.Drawing.Point(0, 0);
            this.dockingTabConditionalFormatting.Name = "dockingTabConditionalFormatting";
            this.dockingTabConditionalFormatting.ShowSingleTab = false;
            this.dockingTabConditionalFormatting.Size = new System.Drawing.Size(300, 709);
            this.dockingTabConditionalFormatting.TabIndex = 0;
            this.dockingTabConditionalFormatting.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTabConditionalFormatting.TabsShowFocusCues = false;
            this.dockingTabConditionalFormatting.TabsSpacing = 2;
            // 
            // dockingTabPageConditionalFormatting
            // 
            this.dockingTabPageConditionalFormatting.Controls.Add(this.rulesManager);
            this.dockingTabPageConditionalFormatting.Location = new System.Drawing.Point(4, 1);
            this.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting";
            this.dockingTabPageConditionalFormatting.Size = new System.Drawing.Size(295, 707);
            this.dockingTabPageConditionalFormatting.TabIndex = 0;
            this.dockingTabPageConditionalFormatting.Text = "Conditional Formatting";
            // 
            // rulesManager
            // 
            this.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesManager.Location = new System.Drawing.Point(0, 0);
            this.rulesManager.Name = "rulesManager";
            this.rulesManager.Options.AllowedRules = C1.Win.RulesManager.RuleTypes.Gradient;
            this.rulesManager.Options.IsFontStyleVisible = false;
            this.rulesManager.Options.IsHistogramVisible = false;
            this.rulesManager.Options.IsTextAlignVisible = false;
            this.rulesManager.Options.IsTextColorVisible = false;
            this.rulesManager.Size = new System.Drawing.Size(295, 707);
            this.rulesManager.TabIndex = 0;
            this.rulesManager.Text = "rulesManager";
            this.rulesManager.MouseLeave += new System.EventHandler(this.rulesManager_MouseLeave);
            this.rulesManager.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rulesManager_MouseMove);
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
            this.formattablePieChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.formattablePieChart.Size = new System.Drawing.Size(405, 679);
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
            this.formattableFlexChart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.formattableFlexChart.Size = new System.Drawing.Size(405, 679);
            this.formattableFlexChart.TabIndex = 0;
            this.formattableFlexChart.Text = "formattableFlexChart";
            // 
            // 
            // 
            this.formattableFlexChart.ToolTip.Content = "";
            // 
            // dockingTabCharts
            // 
            this.dockingTabCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dockingTabCharts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTabCharts.Controls.Add(this.dockingTabPagePieChart);
            this.dockingTabCharts.Controls.Add(this.dockingTabPageFlexChart);
            this.dockingTabCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockingTabCharts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dockingTabCharts.HotTrack = true;
            this.dockingTabCharts.Location = new System.Drawing.Point(0, 43);
            this.dockingTabCharts.Name = "dockingTabCharts";
            this.dockingTabCharts.Size = new System.Drawing.Size(407, 709);
            this.dockingTabCharts.TabIndex = 0;
            this.dockingTabCharts.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTabCharts.TabsShowFocusCues = false;
            this.dockingTabCharts.TabsSpacing = 2;
            // 
            // dockingTabPagePieChart
            // 
            this.dockingTabPagePieChart.Controls.Add(this.formattablePieChart);
            this.dockingTabPagePieChart.Location = new System.Drawing.Point(1, 29);
            this.dockingTabPagePieChart.Name = "dockingTabPagePieChart";
            this.dockingTabPagePieChart.Size = new System.Drawing.Size(405, 679);
            this.dockingTabPagePieChart.TabIndex = 0;
            this.dockingTabPagePieChart.Text = "Pie Chart";
            // 
            // dockingTabPageFlexChart
            // 
            this.dockingTabPageFlexChart.Controls.Add(this.formattableFlexChart);
            this.dockingTabPageFlexChart.Location = new System.Drawing.Point(1, 29);
            this.dockingTabPageFlexChart.Name = "dockingTabPageFlexChart";
            this.dockingTabPageFlexChart.Size = new System.Drawing.Size(405, 679);
            this.dockingTabPageFlexChart.TabIndex = 1;
            this.dockingTabPageFlexChart.Text = "Flex Chart";
            // 
            // ChartConditionalFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dockingTabCharts);
            this.Controls.Add(this.commandDock);
            this.Controls.Add(this.ribbon);
            this.Name = "ChartConditionalFormatting";
            this.Size = new System.Drawing.Size(707, 752);
            this.Load += new System.EventHandler(this.ChartConditionalFormatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon ribbon;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar;
        private C1.Win.Ribbon.RibbonQat ribbonQat;
        private C1.Win.Ribbon.RibbonTab ribbonTab;
        private C1.Win.Ribbon.RibbonGroup ribbonGroupConditionalFormatting;
        private C1.Win.Command.C1CommandDock commandDock;
        private C1.Win.Command.C1DockingTab dockingTabConditionalFormatting;
        private C1.Win.Command.C1DockingTabPage dockingTabPageConditionalFormatting;
        private C1.Win.RulesManager.C1RulesManager rulesManager;
        private C1.Win.Command.C1DockingTab dockingTabCharts;
        private C1.Win.Command.C1DockingTabPage dockingTabPagePieChart;
        private FormattablePieChart formattablePieChart;
        private C1.Win.Command.C1DockingTabPage dockingTabPageFlexChart;
        private FormattableFlexChart formattableFlexChart;
        private C1.Win.Ribbon.RibbonToggleButton ribbonToggleButtonManageRules;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxHeader;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxAddButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRemoveButton;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRuleName;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxRangeSelector;
        private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBoxCondition;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        //private C1.Win.SuperTooltip.SuperTooltip superTooltip;
    }
}

