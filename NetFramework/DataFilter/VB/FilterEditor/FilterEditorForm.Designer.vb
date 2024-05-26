<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FilterEditorForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FilterEditorForm))
        Me.ribbon = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonCmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonTopToolBar = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.splitContainer = New System.Windows.Forms.SplitContainer()
        Me.btnReset = New C1.Win.C1Input.C1Button()
        Me.btnApply = New C1.Win.C1Input.C1Button()
        Me.filterEditor = New C1.Win.DataFilter.C1FilterEditor()
        Me.flexGrid = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.themeController = New C1.Win.C1Themes.C1ThemeController()
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitContainer.Panel1.SuspendLayout()
        Me.splitContainer.Panel2.SuspendLayout()
        Me.splitContainer.SuspendLayout()
        CType(Me.btnReset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnApply, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.themeController, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbon
        '
        Me.ribbon.ApplicationMenuHolder = Me.ribbonApplicationMenu
        Me.ribbon.BottomToolBarHolder = Me.ribbonBottomToolBar
        Me.ribbon.ConfigToolBarHolder = Me.ribbonConfigToolBar
        Me.ribbon.Location = New System.Drawing.Point(0, 0)
        Me.ribbon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ribbon.Name = "ribbon"
        Me.ribbon.QatHolder = Me.ribbonQat
        Me.ribbon.Size = New System.Drawing.Size(984, 71)
        Me.ribbon.Tabs.Add(Me.ribbonTab)
        Me.themeController.SetTheme(Me.ribbon, "(default)")
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
        Me.ribbonTab.Groups.Add(Me.ribbonGroup)
        Me.ribbonTab.Name = "ribbonTab"
        Me.ribbonTab.Text = "Styles"
        '
        'ribbonGroup
        '
        Me.ribbonGroup.Items.Add(Me.ribbonCmbThemes)
        Me.ribbonGroup.Name = "ribbonGroup"
        Me.ribbonGroup.Text = "Theme"
        '
        'ribbonCmbThemes
        '
        Me.ribbonCmbThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.ribbonCmbThemes.Name = "ribbonCmbThemes"
        Me.ribbonCmbThemes.TextAreaWidth = 100
        '
        'ribbonTopToolBar
        '
        Me.ribbonTopToolBar.Name = "ribbonTopToolBar"
        Me.ribbonTopToolBar.Visible = False
        '
        'splitContainer
        '
        Me.splitContainer.BackColor = System.Drawing.Color.White
        Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.splitContainer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.splitContainer.Location = New System.Drawing.Point(0, 71)
        Me.splitContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.splitContainer.Name = "splitContainer"
        '
        'splitContainer.Panel1
        '
        Me.splitContainer.Panel1.Controls.Add(Me.btnReset)
        Me.splitContainer.Panel1.Controls.Add(Me.btnApply)
        Me.splitContainer.Panel1.Controls.Add(Me.filterEditor)
        Me.splitContainer.Panel1MinSize = 300
        '
        'splitContainer.Panel2
        '
        Me.splitContainer.Panel2.Controls.Add(Me.flexGrid)
        Me.splitContainer.Size = New System.Drawing.Size(984, 690)
        Me.splitContainer.SplitterDistance = 400
        Me.splitContainer.SplitterWidth = 5
        Me.splitContainer.TabIndex = 1
        Me.themeController.SetTheme(Me.splitContainer, "(default)")
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(309, 644)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(87, 30)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset Filter"
        Me.themeController.SetTheme(Me.btnReset, "(default)")
        Me.btnReset.UseVisualStyleBackColor = True
        Me.btnReset.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.Location = New System.Drawing.Point(204, 644)
        Me.btnApply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(87, 30)
        Me.btnApply.TabIndex = 1
        Me.btnApply.Text = "Apply Filter"
        Me.themeController.SetTheme(Me.btnApply, "(default)")
        Me.btnApply.UseVisualStyleBackColor = True
        Me.btnApply.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'filterEditor
        '
        Me.filterEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filterEditor.Location = New System.Drawing.Point(0, 0)
        Me.filterEditor.Name = "filterEditor"
        Me.filterEditor.Size = New System.Drawing.Size(397, 636)
        Me.filterEditor.TabIndex = 0
        Me.filterEditor.Text = "c1FilterEditor1"
        Me.themeController.SetTheme(Me.filterEditor, "(default)")
        '
        'flexGrid
        '
        Me.flexGrid.BackColor = System.Drawing.Color.White
        Me.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flexGrid.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.flexGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.flexGrid.Location = New System.Drawing.Point(0, 0)
        Me.flexGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.flexGrid.Name = "flexGrid"
        Me.flexGrid.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.flexGrid.Size = New System.Drawing.Size(579, 690)
        Me.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo")
        Me.flexGrid.TabIndex = 0
        Me.themeController.SetTheme(Me.flexGrid, "(default)")
        Me.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        '
        'themeController
        '
        Me.themeController.Theme = "Office365White"
        '
        'FilterEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.splitContainer)
        Me.Controls.Add(Me.ribbon)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FilterEditorForm"
        Me.Text = "Filter Editor"
        Me.themeController.SetTheme(Me, "(default)")
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.Panel1.ResumeLayout(False)
        Me.splitContainer.Panel2.ResumeLayout(False)
        CType(Me.splitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitContainer.ResumeLayout(False)
        CType(Me.btnReset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnApply, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flexGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ribbonGroup As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents ribbonTopToolBar As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents ribbonCmbThemes As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents splitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents flexGrid As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents filterEditor As C1.Win.DataFilter.C1FilterEditor
    Friend WithEvents btnApply As C1.Win.C1Input.C1Button
    Friend WithEvents btnReset As C1.Win.C1Input.C1Button
    Friend WithEvents themeController As C1.Win.C1Themes.C1ThemeController
End Class
