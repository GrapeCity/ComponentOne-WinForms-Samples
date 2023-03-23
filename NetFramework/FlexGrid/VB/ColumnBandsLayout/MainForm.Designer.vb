<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.rgThemes = New C1.Win.Ribbon.RibbonGroup()
        Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.rgLayout = New C1.Win.Ribbon.RibbonGroup()
        Me.rbLayoutOption = New C1.Win.Ribbon.RibbonComboBox()
        Me.columnBandsUserControl1 = New ColumnBandsLayout.ColumnBandsUserControl()
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
        Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
        Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
        Me.c1Ribbon1.HideTabHeaderRow = True
        Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.c1Ribbon1.Name = "c1Ribbon1"
        Me.c1Ribbon1.QatHolder = Me.ribbonQat1
        Me.c1Ribbon1.Size = New System.Drawing.Size(1016, 77)
        Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
        Me.c1ThemeController1.SetTheme(Me.c1Ribbon1, "(default)")
        Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
        Me.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        Me.ribbonApplicationMenu1.Visible = False
        Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        Me.ribbonQat1.Name = "ribbonQat1"
        Me.ribbonQat1.Visible = False
        Me.ribbonTab1.Groups.Add(Me.rgThemes)
        Me.ribbonTab1.Groups.Add(Me.rgLayout)
        Me.ribbonTab1.Name = "ribbonTab1"
        Me.ribbonTab1.Text = "Tab"
        Me.rgThemes.Items.Add(Me.cmbTheme)
        Me.rgThemes.Name = "rgThemes"
        Me.rgThemes.Text = "Styles"
        Me.cmbTheme.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.cmbTheme.Label = "Theme"
        Me.cmbTheme.Name = "cmbTheme"
        Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
        Me.c1ThemeController1.Theme = "Office2016Green"
        Me.rgLayout.IconSet.Add(New C1.Framework.C1BitmapIcon("DecreaseVerticalSpacing", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 114))
        Me.rgLayout.Items.Add(Me.rbLayoutOption)
        Me.rgLayout.Name = "rgLayout"
        Me.rgLayout.Text = "Layout Option"
        Me.rbLayoutOption.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rbLayoutOption.Label = "Layout Option"
        Me.rbLayoutOption.Name = "rbLayoutOption"
        Me.columnBandsUserControl1.BackColor = System.Drawing.Color.White
        Me.columnBandsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.columnBandsUserControl1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
        Me.columnBandsUserControl1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((68)))))), (CInt(((CByte((68)))))))
        Me.columnBandsUserControl1.Location = New System.Drawing.Point(0, 77)
        Me.columnBandsUserControl1.Name = "columnBandsUserControl1"
        Me.columnBandsUserControl1.Size = New System.Drawing.Size(1016, 683)
        Me.columnBandsUserControl1.TabIndex = 1
        Me.c1ThemeController1.SetTheme(Me.columnBandsUserControl1, "(default)")
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 760)
        Me.Controls.Add(Me.columnBandsUserControl1)
        Me.Controls.Add(Me.c1Ribbon1)
        Me.Icon = (CType((resources.GetObject("$this.Icon")), System.Drawing.Icon))
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Column Bands Layout Sample"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private ribbonTab1 As C1.Win.Ribbon.RibbonTab
    Private rgThemes As C1.Win.Ribbon.RibbonGroup
    Private ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Private WithEvents cmbTheme As C1.Win.Ribbon.RibbonComboBox
    Private c1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Private columnBandsUserControl1 As ColumnBandsUserControl
    Private rgLayout As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbLayoutOption As C1.Win.Ribbon.RibbonComboBox
End Class

