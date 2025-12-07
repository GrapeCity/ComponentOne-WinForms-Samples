<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1.Win.Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.dockingTab = New C1.Win.Command.C1DockingTab()
        Me.dockingTabPageConditionalFormatting = New C1.Win.Command.C1DockingTabPage()
        Me.rulesManager = New C1.Win.RulesManager.C1RulesManager()
        Me.formattableDataGridView = New DataGridViewConditionalFormatting.FormattableDataGridView()
        Me.themeController = New C1.Win.Themes.C1ThemeController()
        Me.superTooltip = New C1.Win.SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.commandDock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.commandDock.SuspendLayout()
        CType(Me.dockingTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockingTab.SuspendLayout()
        Me.dockingTabPageConditionalFormatting.SuspendLayout()
        CType(Me.rulesManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formattableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ribbon.Size = New System.Drawing.Size(1092, 77)
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
        Me.commandDock.Controls.Add(Me.dockingTab)
        Me.commandDock.Dock = System.Windows.Forms.DockStyle.Right
        Me.commandDock.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.commandDock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.commandDock.Id = 1
        Me.commandDock.Location = New System.Drawing.Point(792, 77)
        Me.commandDock.Name = "commandDock"
        Me.commandDock.Size = New System.Drawing.Size(300, 675)
        Me.themeController.SetTheme(Me.commandDock, "(default)")
        '
        'dockingTab
        '
        Me.dockingTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dockingTab.Controls.Add(Me.dockingTabPageConditionalFormatting)
        Me.dockingTab.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dockingTab.HotTrack = True
        Me.dockingTab.Location = New System.Drawing.Point(0, 0)
        Me.dockingTab.Name = "dockingTab"
        Me.dockingTab.ShowSingleTab = False
        Me.dockingTab.Size = New System.Drawing.Size(300, 675)
        Me.dockingTab.TabIndex = 0
        Me.dockingTab.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit
        Me.dockingTab.TabsShowFocusCues = False
        Me.dockingTab.TabsSpacing = 2
        Me.dockingTab.TabStyle = C1.Win.Command.TabStyleEnum.Office2007
        Me.themeController.SetTheme(Me.dockingTab, "(default)")
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
        Me.rulesManager.Options.AllowedRules = C1.Win.RulesManager.RuleTypes.Solid
        Me.rulesManager.Options.IsBorderColorVisible = False
        Me.rulesManager.Options.IsTextAlignVisible = False
        Me.rulesManager.Size = New System.Drawing.Size(295, 673)
        Me.rulesManager.TabIndex = 0
        Me.rulesManager.Text = "rulesManager"
        Me.themeController.SetTheme(Me.rulesManager, "(default)")
        '
        'formattableDataGridView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.formattableDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.formattableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.rulesManager.SetC1RulesManager(Me.formattableDataGridView, Me.rulesManager)
        Me.formattableDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.formattableDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.formattableDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.formattableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.formattableDataGridView.EnableHeadersVisualStyles = False
        Me.formattableDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.formattableDataGridView.Location = New System.Drawing.Point(0, 77)
        Me.formattableDataGridView.Name = "formattableDataGridView"
        Me.formattableDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.formattableDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 11.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.formattableDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.formattableDataGridView.Size = New System.Drawing.Size(792, 675)
        Me.formattableDataGridView.TabIndex = 1
        Me.themeController.SetTheme(Me.formattableDataGridView, "(default)")
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
        Me.ClientSize = New System.Drawing.Size(1092, 752)
        Me.Controls.Add(Me.formattableDataGridView)
        Me.Controls.Add(Me.commandDock)
        Me.Controls.Add(Me.ribbon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "DataGridViewConditionalFormatting"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.commandDock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.commandDock.ResumeLayout(False)
        CType(Me.dockingTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockingTab.ResumeLayout(False)
        Me.dockingTabPageConditionalFormatting.ResumeLayout(False)
        CType(Me.rulesManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formattableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ribbonTopToolBar As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents ribbonGroupConditionalFormatting As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents themeController As C1.Win.Themes.C1ThemeController
    Friend WithEvents commandDock As C1.Win.Command.C1CommandDock
    Friend WithEvents dockingTab As C1.Win.Command.C1DockingTab
    Friend WithEvents dockingTabPageConditionalFormatting As C1.Win.Command.C1DockingTabPage
    Friend WithEvents rulesManager As C1.Win.RulesManager.C1RulesManager
    Friend WithEvents formattableDataGridView As DataGridViewConditionalFormatting.FormattableDataGridView
    Friend WithEvents ribbonComboBoxTheme As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents ribbonToggleButtonManageRules As C1.Win.Ribbon.RibbonToggleButton
    Friend WithEvents ribbonCheckBoxHeader As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxAddButton As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRemoveButton As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRuleName As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxRangeSelector As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents ribbonCheckBoxCondition As C1.Win.Ribbon.RibbonCheckBox
    Friend WithEvents superTooltip As C1.Win.SuperTooltip.C1SuperTooltip
End Class
