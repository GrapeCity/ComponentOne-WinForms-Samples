<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits C1.Win.Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim ElementSize1 As C1.Chart.ElementSize = New C1.Chart.ElementSize()
        Dim Series1 As C1.Win.Chart.Series = New C1.Win.Chart.Series()
        Dim Series2 As C1.Win.Chart.Series = New C1.Win.Chart.Series()
        Me.ribbon = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroupConditionalFormatting = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonToggleButtonManageRules = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonCheckBoxHeader = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBoxAddButton = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBoxRemoveButton = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBoxRuleName = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBoxRangeSelector = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBoxCondition = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonTopToolBar = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.ribbonComboBoxTheme = New C1.Win.Ribbon.RibbonComboBox()
        Me.commandDock = New C1.Win.Command.C1CommandDock()
        Me.dockingTabConditionalFormatting = New C1.Win.Command.C1DockingTab()
        Me.dockingTabPageConditionalFormatting = New C1.Win.Command.C1DockingTabPage()
        Me.rulesManager = New C1.Win.RulesManager.C1RulesManager()
        Me.formattablePieChart = New ChartConditionalFormatting.FormattablePieChart()
        Me.formattableFlexChart = New ChartConditionalFormatting.FormattableFlexChart()
        Me.dockingTabCharts = New C1.Win.Command.C1DockingTab()
        Me.dockingTabPagePieChart = New C1.Win.Command.C1DockingTabPage()
        Me.dockingTabPageFlexChart = New C1.Win.Command.C1DockingTabPage()
        Me.themeController = New C1.Win.Themes.C1ThemeController()
        Me.superTooltip = New C1.Win.SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.commandDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.commandDock.SuspendLayout()
        CType(Me.dockingTabConditionalFormatting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockingTabConditionalFormatting.SuspendLayout()
        Me.dockingTabPageConditionalFormatting.SuspendLayout()
        CType(Me.rulesManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formattableFlexChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dockingTabCharts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockingTabCharts.SuspendLayout()
        Me.dockingTabPagePieChart.SuspendLayout()
        Me.dockingTabPageFlexChart.SuspendLayout()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbon
        '
        Me.ribbon.ApplicationMenuHolder = Me.ribbonApplicationMenu
        Me.ribbon.BottomToolBarHolder = Me.ribbonBottomToolBar
        Me.ribbon.ConfigToolBarHolder = Me.ribbonConfigToolBar
        Me.ribbon.HideTabHeaderRow = True
        Me.ribbon.Location = New System.Drawing.Point(0, 0)
        Me.ribbon.Name = "ribbon"
        Me.ribbon.QatHolder = Me.ribbonQat
        Me.ribbon.Size = New System.Drawing.Size(1392, 77)
        Me.ribbon.Tabs.Add(Me.ribbonTab)
        Me.themeController.SetTheme(Me.ribbon, "(default)")
        Me.ribbon.ToolTipSettings.BackColor = System.Drawing.Color.White
        Me.ribbon.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None
        Me.ribbon.ToolTipSettings.Border = True
        Me.ribbon.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ribbon.ToolTipSettings.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ribbon.ToolTipSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.ribbon.ToolTipSettings.InitialDelay = 900
        Me.ribbon.ToolTipSettings.ReshowDelay = 180
        Me.ribbon.ToolTipSettings.Shadow = False
        Me.ribbon.TopToolBarHolder = Me.ribbonTopToolBar
        Me.ribbon.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        '
        'ribbonApplicationMenu
        '
        Me.ribbonApplicationMenu.Name = "ribbonApplicationMenu"
        Me.ribbonApplicationMenu.Visible = False
        '
        'ribbonBottomToolBar
        '
        Me.ribbonBottomToolBar.Name = "ribbonBottomToolBar"
        '
        'ribbonConfigToolBar
        '
        Me.ribbonConfigToolBar.Name = "ribbonConfigToolBar"
        '
        'ribbonQat
        '
        Me.ribbonQat.Name = "ribbonQat"
        Me.ribbonQat.Visible = False
        '
        'ribbonTab
        '
        Me.ribbonTab.Groups.Add(Me.ribbonGroupConditionalFormatting)
        Me.ribbonTab.Name = "ribbonTab"
        Me.ribbonTab.Text = "Tab"
        '
        'ribbonGroupConditionalFormatting
        '
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonToggleButtonManageRules)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxHeader)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxAddButton)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxRemoveButton)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxRuleName)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxRangeSelector)
        Me.ribbonGroupConditionalFormatting.Items.Add(Me.ribbonCheckBoxCondition)
        Me.ribbonGroupConditionalFormatting.Name = "ribbonGroupConditionalFormatting"
        Me.ribbonGroupConditionalFormatting.Text = "Conditional Formatting"
        '
        'ribbonToggleButtonManageRules
        '
        Me.ribbonToggleButtonManageRules.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("ribbonToggleButtonManageRules.IconSet"), System.Drawing.Image)))
        Me.ribbonToggleButtonManageRules.Name = "ribbonToggleButtonManageRules"
        Me.ribbonToggleButtonManageRules.Pressed = True
        Me.ribbonToggleButtonManageRules.Text = "Manage Rules"
        '
        'ribbonCheckBoxHeader
        '
        Me.ribbonCheckBoxHeader.Checked = True
        Me.ribbonCheckBoxHeader.Name = "ribbonCheckBoxHeader"
        Me.ribbonCheckBoxHeader.Text = "Header"
        '
        'ribbonCheckBoxAddButton
        '
        Me.ribbonCheckBoxAddButton.Checked = True
        Me.ribbonCheckBoxAddButton.Name = "ribbonCheckBoxAddButton"
        Me.ribbonCheckBoxAddButton.Text = "Add button"
        '
        'ribbonCheckBoxRemoveButton
        '
        Me.ribbonCheckBoxRemoveButton.Checked = True
        Me.ribbonCheckBoxRemoveButton.Name = "ribbonCheckBoxRemoveButton"
        Me.ribbonCheckBoxRemoveButton.Text = "Remove button"
        '
        'ribbonCheckBoxRuleName
        '
        Me.ribbonCheckBoxRuleName.Checked = True
        Me.ribbonCheckBoxRuleName.Name = "ribbonCheckBoxRuleName"
        Me.ribbonCheckBoxRuleName.Text = "Rule name"
        '
        'ribbonCheckBoxRangeSelector
        '
        Me.ribbonCheckBoxRangeSelector.Checked = True
        Me.ribbonCheckBoxRangeSelector.Name = "ribbonCheckBoxRangeSelector"
        Me.ribbonCheckBoxRangeSelector.Text = "Range selector"
        '
        'ribbonCheckBoxCondition
        '
        Me.ribbonCheckBoxCondition.Checked = True
        Me.ribbonCheckBoxCondition.Name = "ribbonCheckBoxCondition"
        Me.ribbonCheckBoxCondition.Text = "Condition"
        '
        'ribbonTopToolBar
        '
        Me.ribbonTopToolBar.Items.Add(Me.ribbonComboBoxTheme)
        Me.ribbonTopToolBar.Name = "ribbonTopToolBar"
        '
        'ribbonComboBoxTheme
        '
        Me.ribbonComboBoxTheme.Label = "Theme"
        Me.ribbonComboBoxTheme.Name = "ribbonComboBoxTheme"
        Me.ribbonComboBoxTheme.TextAreaWidth = 105
        '
        'commandDock
        '
        Me.commandDock.BackColor = System.Drawing.Color.White
        Me.commandDock.Controls.Add(Me.dockingTabConditionalFormatting)
        Me.commandDock.Dock = System.Windows.Forms.DockStyle.Right
        Me.commandDock.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.commandDock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.commandDock.Id = 1
        Me.commandDock.Location = New System.Drawing.Point(1092, 77)
        Me.commandDock.Name = "commandDock"
        Me.commandDock.Size = New System.Drawing.Size(300, 675)
        Me.themeController.SetTheme(Me.commandDock, "(default)")
        '
        'dockingTabConditionalFormatting
        '
        Me.dockingTabConditionalFormatting.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dockingTabConditionalFormatting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dockingTabConditionalFormatting.Controls.Add(Me.dockingTabPageConditionalFormatting)
        Me.dockingTabConditionalFormatting.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dockingTabConditionalFormatting.HotTrack = True
        Me.dockingTabConditionalFormatting.Location = New System.Drawing.Point(0, 0)
        Me.dockingTabConditionalFormatting.Name = "dockingTabConditionalFormatting"
        Me.dockingTabConditionalFormatting.ShowSingleTab = False
        Me.dockingTabConditionalFormatting.Size = New System.Drawing.Size(300, 675)
        Me.dockingTabConditionalFormatting.TabIndex = 0
        Me.dockingTabConditionalFormatting.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit
        Me.dockingTabConditionalFormatting.TabsShowFocusCues = False
        Me.dockingTabConditionalFormatting.TabsSpacing = 2
        Me.dockingTabConditionalFormatting.TabStyle = C1.Win.Command.TabStyleEnum.Office2007
        Me.themeController.SetTheme(Me.dockingTabConditionalFormatting, "(default)")
        '
        'dockingTabPageConditionalFormatting
        '
        Me.dockingTabPageConditionalFormatting.Controls.Add(Me.rulesManager)
        Me.dockingTabPageConditionalFormatting.Location = New System.Drawing.Point(4, 1)
        Me.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting"
        Me.dockingTabPageConditionalFormatting.Size = New System.Drawing.Size(295, 673)
        Me.dockingTabPageConditionalFormatting.TabIndex = 0
        Me.dockingTabPageConditionalFormatting.Text = "Conditional Formatting"
        '
        'rulesManager
        '
        Me.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rulesManager.Location = New System.Drawing.Point(0, 0)
        Me.rulesManager.Name = "rulesManager"
        Me.rulesManager.Options.AllowedRules = C1.Win.RulesManager.RuleTypes.Gradient
        Me.rulesManager.Options.IsFontStyleVisible = False
        Me.rulesManager.Options.IsHistogramVisible = False
        Me.rulesManager.Options.IsTextAlignVisible = False
        Me.rulesManager.Options.IsTextColorVisible = False
        Me.rulesManager.Size = New System.Drawing.Size(295, 673)
        Me.rulesManager.TabIndex = 0
        Me.rulesManager.Text = "rulesManager"
        Me.themeController.SetTheme(Me.rulesManager, "(default)")
        '
        'formattablePieChart
        '
        Me.formattablePieChart.AnimationLoad.Attributes = C1.Chart.SliceAttribute.Radius
        Me.formattablePieChart.AnimationLoad.Duration = 400
        Me.formattablePieChart.AnimationLoad.Easing = C1.Chart.Easing.Linear
        Me.formattablePieChart.AnimationLoad.Type = C1.Chart.AnimationType.All
        Me.formattablePieChart.AnimationSettings = C1.Chart.AnimationSettings.None
        Me.formattablePieChart.AnimationUpdate.Duration = 400
        Me.formattablePieChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear
        Me.formattablePieChart.AnimationUpdate.Type = C1.Chart.AnimationType.All
        Me.formattablePieChart.BackColor = System.Drawing.Color.White
        Me.formattablePieChart.Binding = "UnitsOnOrder"
        Me.formattablePieChart.BindingName = "ProductName"
        Me.rulesManager.SetC1RulesManager(Me.formattablePieChart, Me.rulesManager)
        Me.formattablePieChart.DataLabel.Border = False
        Me.formattablePieChart.DataLabel.ConnectingLine = False
        Me.formattablePieChart.DataLabel.Content = Nothing
        Me.formattablePieChart.DataLabel.Offset = 0
        Me.formattablePieChart.DataLabel.Overlapping = C1.Chart.PieLabelOverlapping.[Default]
        Me.formattablePieChart.DataLabel.Position = C1.Chart.PieLabelPosition.None
        Me.formattablePieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formattablePieChart.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.formattablePieChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.formattablePieChart.Header.Content = "Products: Units on Order"
        Me.formattablePieChart.Legend.ItemMaxWidth = 0
        Me.formattablePieChart.Legend.Orientation = C1.Chart.Orientation.[Auto]
        Me.formattablePieChart.Legend.Position = C1.Chart.Position.Right
        Me.formattablePieChart.Legend.Reversed = False
        Me.formattablePieChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None
        Me.formattablePieChart.Legend.TextWrapping = C1.Chart.TextWrapping.None
        Me.formattablePieChart.Legend.Title = Nothing
        Me.formattablePieChart.Location = New System.Drawing.Point(0, 0)
        Me.formattablePieChart.Name = "formattablePieChart"
        Me.formattablePieChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red
        Me.formattablePieChart.Size = New System.Drawing.Size(1090, 645)
        Me.formattablePieChart.TabIndex = 0
        Me.formattablePieChart.Text = "formattablePieChart"
        Me.themeController.SetTheme(Me.formattablePieChart, "(default)")
        Me.formattablePieChart.Titles = Nothing
        '
        '
        '
        Me.formattablePieChart.ToolTip.Content = ""
        '
        'formattableFlexChart
        '
        Me.formattableFlexChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y
        Me.formattableFlexChart.AnimationLoad.Duration = 400
        Me.formattableFlexChart.AnimationLoad.Easing = C1.Chart.Easing.Linear
        Me.formattableFlexChart.AnimationLoad.Type = C1.Chart.AnimationType.All
        Me.formattableFlexChart.AnimationSettings = C1.Chart.AnimationSettings.None
        Me.formattableFlexChart.AnimationUpdate.Duration = 400
        Me.formattableFlexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear
        Me.formattableFlexChart.AnimationUpdate.Type = C1.Chart.AnimationType.All
        Me.formattableFlexChart.AxisX.Chart = Me.formattableFlexChart
        Me.formattableFlexChart.AxisX.DataSource = Nothing
        Me.formattableFlexChart.AxisX.GroupProvider = Nothing
        Me.formattableFlexChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None
        Me.formattableFlexChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center
        Me.formattableFlexChart.AxisX.GroupVisibilityLevel = 0
        Me.formattableFlexChart.AxisX.LabelMax = False
        Me.formattableFlexChart.AxisX.LabelMin = False
        Me.formattableFlexChart.AxisX.PlotAreaName = Nothing
        Me.formattableFlexChart.AxisX.Position = C1.Chart.Position.Bottom
        Me.formattableFlexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day
        Me.formattableFlexChart.AxisY.AxisLine = False
        Me.formattableFlexChart.AxisY.Chart = Me.formattableFlexChart
        Me.formattableFlexChart.AxisY.DataSource = Nothing
        Me.formattableFlexChart.AxisY.GroupProvider = Nothing
        Me.formattableFlexChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None
        Me.formattableFlexChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center
        Me.formattableFlexChart.AxisY.GroupVisibilityLevel = 0
        Me.formattableFlexChart.AxisY.LabelMax = False
        Me.formattableFlexChart.AxisY.LabelMin = False
        Me.formattableFlexChart.AxisY.MajorGrid = True
        Me.formattableFlexChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None
        Me.formattableFlexChart.AxisY.PlotAreaName = Nothing
        Me.formattableFlexChart.AxisY.Position = C1.Chart.Position.Left
        Me.formattableFlexChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day
        Me.formattableFlexChart.BackColor = System.Drawing.Color.White
        Me.formattableFlexChart.BindingX = "ProductName"
        Me.rulesManager.SetC1RulesManager(Me.formattableFlexChart, Me.rulesManager)
        Me.formattableFlexChart.DataLabel.Angle = 0
        Me.formattableFlexChart.DataLabel.Border = False
        Me.formattableFlexChart.DataLabel.ConnectingLine = False
        Me.formattableFlexChart.DataLabel.Content = "{}{y}"
        Me.formattableFlexChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap
        Me.formattableFlexChart.DataLabel.MaxAutoLabels = 100
        Me.formattableFlexChart.DataLabel.MaxLines = 0
        Me.formattableFlexChart.DataLabel.MaxWidth = 0
        Me.formattableFlexChart.DataLabel.Offset = 0
        Me.formattableFlexChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide
        Me.formattableFlexChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea
        Me.formattableFlexChart.DataLabel.Position = C1.Chart.LabelPosition.Top
        Me.formattableFlexChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formattableFlexChart.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.formattableFlexChart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.formattableFlexChart.Legend.ItemMaxWidth = 0
        Me.formattableFlexChart.Legend.Orientation = C1.Chart.Orientation.[Auto]
        Me.formattableFlexChart.Legend.Position = C1.Chart.Position.Top
        Me.formattableFlexChart.Legend.Reversed = False
        Me.formattableFlexChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None
        Me.formattableFlexChart.Legend.TextWrapping = C1.Chart.TextWrapping.None
        Me.formattableFlexChart.Legend.Title = Nothing
        Me.formattableFlexChart.Location = New System.Drawing.Point(0, 0)
        Me.formattableFlexChart.Margin = New System.Windows.Forms.Padding(10)
        Me.formattableFlexChart.Name = "formattableFlexChart"
        ElementSize1.SizeType = C1.Chart.ElementSizeType.Percentage
        ElementSize1.Value = 70.0R
        Me.formattableFlexChart.Options.ClusterSize = ElementSize1
        Me.formattableFlexChart.PlotMargin = New System.Windows.Forms.Padding(0)
        Me.formattableFlexChart.SelectedSeries = Nothing
        Me.formattableFlexChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red
        Series1.Binding = "UnitsOnOrder"
        Series1.DataLabel = Nothing
        Series1.Name = "UnitsOnOrder"
        Series1.StackingGroup = -1
        Series1.Tooltip = Nothing
        Series2.Binding = "UnitsInStock"
        Series2.DataLabel = Nothing
        Series2.Name = "UnitsInStock"
        Series2.StackingGroup = -1
        Series2.Tooltip = Nothing
        Me.formattableFlexChart.Series.Add(Series1)
        Me.formattableFlexChart.Series.Add(Series2)
        Me.formattableFlexChart.Size = New System.Drawing.Size(1090, 645)
        Me.formattableFlexChart.TabIndex = 0
        Me.formattableFlexChart.Text = "formattableFlexChart"
        Me.themeController.SetTheme(Me.formattableFlexChart, "(default)")
        '
        '
        '
        Me.formattableFlexChart.ToolTip.Content = ""
        '
        'dockingTabCharts
        '
        Me.dockingTabCharts.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dockingTabCharts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dockingTabCharts.Controls.Add(Me.dockingTabPagePieChart)
        Me.dockingTabCharts.Controls.Add(Me.dockingTabPageFlexChart)
        Me.dockingTabCharts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockingTabCharts.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dockingTabCharts.HotTrack = True
        Me.dockingTabCharts.Location = New System.Drawing.Point(0, 77)
        Me.dockingTabCharts.Name = "dockingTabCharts"
        Me.dockingTabCharts.Size = New System.Drawing.Size(1092, 675)
        Me.dockingTabCharts.TabIndex = 0
        Me.dockingTabCharts.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit
        Me.dockingTabCharts.TabsShowFocusCues = False
        Me.dockingTabCharts.TabsSpacing = 2
        Me.dockingTabCharts.TabStyle = C1.Win.Command.TabStyleEnum.Office2007
        Me.themeController.SetTheme(Me.dockingTabCharts, "(default)")
        '
        'dockingTabPagePieChart
        '
        Me.dockingTabPagePieChart.Controls.Add(Me.formattablePieChart)
        Me.dockingTabPagePieChart.Location = New System.Drawing.Point(1, 29)
        Me.dockingTabPagePieChart.Name = "dockingTabPagePieChart"
        Me.dockingTabPagePieChart.Size = New System.Drawing.Size(1090, 645)
        Me.dockingTabPagePieChart.TabIndex = 0
        Me.dockingTabPagePieChart.Text = "Pie Chart"
        '
        'dockingTabPageFlexChart
        '
        Me.dockingTabPageFlexChart.Controls.Add(Me.formattableFlexChart)
        Me.dockingTabPageFlexChart.Location = New System.Drawing.Point(1, 29)
        Me.dockingTabPageFlexChart.Name = "dockingTabPageFlexChart"
        Me.dockingTabPageFlexChart.Size = New System.Drawing.Size(1090, 645)
        Me.dockingTabPageFlexChart.TabIndex = 1
        Me.dockingTabPageFlexChart.Text = "Flex Chart"
        '
        'superTooltip
        '
        Me.superTooltip.BackgroundGradient = C1.Win.SuperTooltip.BackgroundGradient.None
        Me.superTooltip.BorderColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.superTooltip.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.superTooltip.RightToLeft = System.Windows.Forms.RightToLeft.Inherit
        Me.themeController.SetTheme(Me.superTooltip, "(default)")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1392, 752)
        Me.Controls.Add(Me.dockingTabCharts)
        Me.Controls.Add(Me.commandDock)
        Me.Controls.Add(Me.ribbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "ChartConditionalFormatting"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.commandDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.commandDock.ResumeLayout(False)
        CType(Me.dockingTabConditionalFormatting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockingTabConditionalFormatting.ResumeLayout(False)
        Me.dockingTabPageConditionalFormatting.ResumeLayout(False)
        CType(Me.rulesManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formattableFlexChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dockingTabCharts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockingTabCharts.ResumeLayout(False)
        Me.dockingTabPagePieChart.ResumeLayout(False)
        Me.dockingTabPageFlexChart.ResumeLayout(False)
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ribbon As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents ribbonApplicationMenu As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents ribbonBottomToolBar As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents ribbonConfigToolBar As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents ribbonQat As C1.Win.Ribbon.RibbonQat
    Friend WithEvents ribbonTab As C1.Win.Ribbon.RibbonTab
    Friend WithEvents ribbonGroupConditionalFormatting As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents ribbonTopToolBar As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents commandDock As C1.Win.Command.C1CommandDock
    Friend WithEvents dockingTabConditionalFormatting As C1.Win.Command.C1DockingTab
    Friend WithEvents dockingTabPageConditionalFormatting As C1.Win.Command.C1DockingTabPage
    Friend WithEvents rulesManager As C1.Win.RulesManager.C1RulesManager
    Friend WithEvents dockingTabCharts As C1.Win.Command.C1DockingTab
    Friend WithEvents dockingTabPagePieChart As C1.Win.Command.C1DockingTabPage
    Friend WithEvents formattablePieChart As FormattablePieChart
    Friend WithEvents dockingTabPageFlexChart As C1.Win.Command.C1DockingTabPage
    Friend WithEvents formattableFlexChart As FormattableFlexChart
    Friend WithEvents themeController As C1.Win.Themes.C1ThemeController
    Friend WithEvents ribbonToggleButtonManageRules As C1.Win.Ribbon.RibbonToggleButton
    Friend WithEvents ribbonCheckBoxHeader As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxAddButton As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRemoveButton As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRuleName As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRangeSelector As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxCondition As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonComboBoxTheme As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents superTooltip As C1.Win.SuperTooltip.C1SuperTooltip
End Class
