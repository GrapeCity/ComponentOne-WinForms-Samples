
Partial Class RowDetails
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Me.dockingTab = New C1.Win.C1Command.C1DockingTab()
        Me.pageInputPanel = New C1.Win.C1Command.C1DockingTabPage()
        Me.inputPanelSample = New RowDetail.InputPanelSample()
        Me.pageFlexGrid = New C1.Win.C1Command.C1DockingTabPage()
        Me.flexGridSample = New RowDetail.FlexGridSample()
        Me.pageInheritance = New C1.Win.C1Command.C1DockingTabPage()
        Me.inheritanceSample = New RowDetail.InheritanceSample()
        Me.pageCustom = New C1.Win.C1Command.C1DockingTabPage()
        Me.customSample = New RowDetail.CustomSample()
        Me.themePicker = New C1.Win.C1Themes.C1ThemePicker()
        Me.themeController = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.dockingTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dockingTab.SuspendLayout()
        Me.pageInputPanel.SuspendLayout()
        Me.pageFlexGrid.SuspendLayout()
        Me.pageInheritance.SuspendLayout()
        Me.pageCustom.SuspendLayout()
        CType(Me.themePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dockingTab
        '
        Me.dockingTab.BackColor = System.Drawing.Color.White
        Me.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dockingTab.Controls.Add(Me.pageInputPanel)
        Me.dockingTab.Controls.Add(Me.pageFlexGrid)
        Me.dockingTab.Controls.Add(Me.pageInheritance)
        Me.dockingTab.Controls.Add(Me.pageCustom)
        Me.dockingTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dockingTab.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dockingTab.HotTrack = True
        Me.dockingTab.Location = New System.Drawing.Point(0, 0)
        Me.dockingTab.Name = "dockingTab"
        Me.dockingTab.Padding = New System.Drawing.Point(6, 6)
        Me.dockingTab.Size = New System.Drawing.Size(779, 605)
        Me.dockingTab.TabIndex = 0
        Me.dockingTab.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.dockingTab.TabsShowFocusCues = False
        Me.dockingTab.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.themeController.SetTheme(Me.dockingTab, "(default)")
        '
        'pageInputPanel
        '
        Me.pageInputPanel.Controls.Add(Me.inputPanelSample)
        Me.pageInputPanel.Location = New System.Drawing.Point(1, 35)
        Me.pageInputPanel.Name = "pageInputPanel"
        Me.pageInputPanel.Size = New System.Drawing.Size(777, 569)
        Me.pageInputPanel.TabIndex = 0
        Me.pageInputPanel.Text = "InputPanel"
        '
        'inputPanelSample
        '
        Me.inputPanelSample.BackColor = System.Drawing.Color.White
        Me.inputPanelSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inputPanelSample.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.inputPanelSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.inputPanelSample.Location = New System.Drawing.Point(0, 0)
        Me.inputPanelSample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inputPanelSample.Name = "inputPanelSample"
        Me.inputPanelSample.Size = New System.Drawing.Size(777, 569)
        Me.inputPanelSample.TabIndex = 0
        Me.themeController.SetTheme(Me.inputPanelSample, "(default)")
        '
        'pageFlexGrid
        '
        Me.pageFlexGrid.Controls.Add(Me.flexGridSample)
        Me.pageFlexGrid.Location = New System.Drawing.Point(1, 35)
        Me.pageFlexGrid.Name = "pageFlexGrid"
        Me.pageFlexGrid.Size = New System.Drawing.Size(777, 569)
        Me.pageFlexGrid.TabIndex = 1
        Me.pageFlexGrid.Text = "FlexGrid"
        '
        'flexGridSample
        '
        Me.flexGridSample.BackColor = System.Drawing.Color.White
        Me.flexGridSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexGridSample.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.flexGridSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.flexGridSample.Location = New System.Drawing.Point(0, 0)
        Me.flexGridSample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flexGridSample.Name = "flexGridSample"
        Me.flexGridSample.Size = New System.Drawing.Size(777, 569)
        Me.flexGridSample.TabIndex = 0
        Me.themeController.SetTheme(Me.flexGridSample, "(default)")
        '
        'pageInheritance
        '
        Me.pageInheritance.Controls.Add(Me.inheritanceSample)
        Me.pageInheritance.Location = New System.Drawing.Point(1, 35)
        Me.pageInheritance.Name = "pageInheritance"
        Me.pageInheritance.Size = New System.Drawing.Size(777, 569)
        Me.pageInheritance.TabIndex = 3
        Me.pageInheritance.Text = "Inheritance"
        '
        'inheritanceSample
        '
        Me.inheritanceSample.BackColor = System.Drawing.Color.White
        Me.inheritanceSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inheritanceSample.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.inheritanceSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.inheritanceSample.Location = New System.Drawing.Point(0, 0)
        Me.inheritanceSample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.inheritanceSample.Name = "inheritanceSample"
        Me.inheritanceSample.Size = New System.Drawing.Size(777, 569)
        Me.inheritanceSample.TabIndex = 0
        Me.themeController.SetTheme(Me.inheritanceSample, "(default)")
        '
        'pageCustom
        '
        Me.pageCustom.Controls.Add(Me.customSample)
        Me.pageCustom.Location = New System.Drawing.Point(1, 35)
        Me.pageCustom.Name = "pageCustom"
        Me.pageCustom.Size = New System.Drawing.Size(777, 569)
        Me.pageCustom.TabIndex = 2
        Me.pageCustom.Text = "Custom"
        '
        'customSample
        '
        Me.customSample.BackColor = System.Drawing.Color.White
        Me.customSample.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customSample.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.customSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.customSample.Location = New System.Drawing.Point(0, 0)
        Me.customSample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.customSample.Name = "customSample"
        Me.customSample.Size = New System.Drawing.Size(777, 569)
        Me.customSample.TabIndex = 0
        Me.themeController.SetTheme(Me.customSample, "(default)")
        '
        'themePicker
        '
        Me.themePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.themePicker.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.themePicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.themePicker.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.themePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.themePicker.Location = New System.Drawing.Point(575, 0)
        Me.themePicker.Name = "themePicker"
        Me.themePicker.SelectedThemeName = "Office2016Colorful"
        Me.themePicker.Size = New System.Drawing.Size(199, 23)
        Me.themePicker.Style.DropDownBackColor = System.Drawing.Color.White
        Me.themePicker.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro
        Me.themePicker.Style.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.themePicker.TabIndex = 0
        Me.themeController.SetTheme(Me.themePicker, "(default)")
        Me.themePicker.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'RowDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(779, 605)
        Me.Controls.Add(Me.themePicker)
        Me.Controls.Add(Me.dockingTab)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimumSize = New System.Drawing.Size(640, 480)
        Me.Name = "RowDetails"
        Me.Text = "RowDetails"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.dockingTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dockingTab.ResumeLayout(False)
        Me.pageInputPanel.ResumeLayout(False)
        Me.pageFlexGrid.ResumeLayout(False)
        Me.pageInheritance.ResumeLayout(False)
        Me.pageCustom.ResumeLayout(False)
        CType(Me.themePicker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private dockingTab As C1.Win.C1Command.C1DockingTab
    Private pageInputPanel As C1.Win.C1Command.C1DockingTabPage
    Private pageFlexGrid As C1.Win.C1Command.C1DockingTabPage
    Private pageInheritance As C1.Win.C1Command.C1DockingTabPage
    Private pageCustom As C1.Win.C1Command.C1DockingTabPage
    Private themePicker As C1.Win.C1Themes.C1ThemePicker
    Private themeController As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents inputPanelSample As InputPanelSample
    Friend WithEvents flexGridSample As FlexGridSample
    Friend WithEvents inheritanceSample As InheritanceSample
    Friend WithEvents customSample As CustomSample
End Class