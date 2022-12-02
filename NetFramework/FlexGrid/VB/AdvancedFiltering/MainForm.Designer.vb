Namespace AdvancedFiltering
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
            Me.rbCreateFilters = New C1.Win.Ribbon.RibbonButton()
            Me.rbSaveFiltersToXml = New C1.Win.Ribbon.RibbonButton()
            Me.rbClearFilters = New C1.Win.Ribbon.RibbonButton()
            Me.rbLoadFiltersFromXml = New C1.Win.Ribbon.RibbonButton()
            Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
            Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
            Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
            Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
            Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
            Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
            Me.c1TextBox1 = New C1.Win.C1Input.C1TextBox()
            Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
            CType((Me.c1Ribbon1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.c1FlexGrid1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainer1.Panel1.SuspendLayout()
            Me.splitContainer1.Panel2.SuspendLayout()
            Me.splitContainer1.SuspendLayout()
            CType((Me.c1TextBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.c1ThemeController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
            Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
            Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
            Me.c1Ribbon1.HideTabHeaderRow = True
            Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
            Me.c1Ribbon1.Name = "c1Ribbon1"
            Me.c1Ribbon1.QatHolder = Me.ribbonQat1
            Me.c1Ribbon1.Size = New System.Drawing.Size(1016, 66)
            Me.c1ThemeController1.SetTheme(Me.c1Ribbon1, "(default)")
            Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
            Me.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
            Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
            Me.ribbonApplicationMenu1.Visible = False
            Me.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left
            Me.ribbonBottomToolBar1.Items.Add(Me.rbCreateFilters)
            Me.ribbonBottomToolBar1.Items.Add(Me.rbSaveFiltersToXml)
            Me.ribbonBottomToolBar1.Items.Add(Me.rbClearFilters)
            Me.ribbonBottomToolBar1.Items.Add(Me.rbLoadFiltersFromXml)
            Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
            Me.rbCreateFilters.Description = "Create Some Filters"
            Me.rbCreateFilters.IconSet.Add(New C1.Framework.C1BitmapIcon("AdvancedFilter", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294))
            Me.rbCreateFilters.Name = "rbCreateFilters"
            Me.rbCreateFilters.Text = "Create Filters"
            Me.rbCreateFilters.ToolTip = "Create Some Filters"
            Me.rbSaveFiltersToXml.Description = "Save Filters To XML"
            Me.rbSaveFiltersToXml.IconSet.Add(New C1.Framework.C1BitmapIcon("Save", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294))
            Me.rbSaveFiltersToXml.Name = "rbSaveFiltersToXml"
            Me.rbSaveFiltersToXml.Text = "Save Filters"
            Me.rbSaveFiltersToXml.ToolTip = "Save Filters To XML"
            Me.rbClearFilters.Description = "Clear All Filters"
            Me.rbClearFilters.IconSet.Add(New C1.Framework.C1BitmapIcon("ClearFilter", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294))
            Me.rbClearFilters.Name = "rbClearFilters"
            Me.rbClearFilters.Text = "Clear Filters"
            Me.rbClearFilters.ToolTip = "Clear All Filters"
            Me.rbLoadFiltersFromXml.Description = "Load Filters From XML"
            Me.rbLoadFiltersFromXml.IconSet.Add(New C1.Framework.C1BitmapIcon("ReapplyFilter", New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "Preset_SmallImages", 294))
            Me.rbLoadFiltersFromXml.Name = "rbLoadFiltersFromXml"
            Me.rbLoadFiltersFromXml.Text = "Load Filters"
            Me.rbLoadFiltersFromXml.ToolTip = "Load Filters From XML"
            Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
            Me.ribbonQat1.Name = "ribbonQat1"
            Me.ribbonQat1.Visible = False
            Me.ribbonTopToolBar1.Items.Add(Me.cmbTheme)
            Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
            Me.cmbTheme.Label = "Theme"
            Me.cmbTheme.Name = "cmbTheme"
            Me.c1FlexGrid1.AllowEditing = False
            Me.c1FlexGrid1.BackColor = System.Drawing.Color.White
            Me.c1FlexGrid1.ColumnContextMenuEnabled = True
            Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
            Me.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None
            Me.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = False
            Me.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = False
            Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((68)))))), (CInt(((CByte((68)))))))
            Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
            Me.c1FlexGrid1.Name = "c1FlexGrid1"
            Me.c1FlexGrid1.Size = New System.Drawing.Size(750, 694)
            Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
            Me.c1FlexGrid1.TabIndex = 1
            Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
            Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb((CInt(((CByte((171)))))), (CInt(((CByte((171)))))), (CInt(((CByte((171)))))))
            Me.splitContainer1.BackColor = System.Drawing.Color.White
            Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.splitContainer1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((68)))))), (CInt(((CByte((68)))))))
            Me.splitContainer1.Location = New System.Drawing.Point(0, 66)
            Me.splitContainer1.Name = "splitContainer1"
            Me.splitContainer1.Panel1.BackColor = System.Drawing.Color.White
            Me.splitContainer1.Panel1.Controls.Add(Me.c1FlexGrid1)
            Me.splitContainer1.Panel1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.splitContainer1.Panel1.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((68)))))), (CInt(((CByte((68)))))))
            Me.c1ThemeController1.SetTheme(Me.splitContainer1.Panel1, "(default)")
            Me.splitContainer1.Panel2.BackColor = System.Drawing.Color.White
            Me.splitContainer1.Panel2.Controls.Add(Me.c1TextBox1)
            Me.splitContainer1.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.splitContainer1.Panel2.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((68)))))), (CInt(((CByte((68)))))), (CInt(((CByte((68)))))))
            Me.c1ThemeController1.SetTheme(Me.splitContainer1.Panel2, "(default)")
            Me.splitContainer1.Size = New System.Drawing.Size(1016, 694)
            Me.splitContainer1.SplitterDistance = 750
            Me.splitContainer1.TabIndex = 4
            Me.c1ThemeController1.SetTheme(Me.splitContainer1, "(default)")
            Me.c1TextBox1.AutoSize = False
            Me.c1TextBox1.BorderColor = System.Drawing.Color.FromArgb((CInt(((CByte((171)))))), (CInt(((CByte((171)))))), (CInt(((CByte((171)))))))
            Me.c1TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.c1TextBox1.DisabledForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((173)))))), (CInt(((CByte((173)))))), (CInt(((CByte((173)))))))
            Me.c1TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.75F)
            Me.c1TextBox1.Location = New System.Drawing.Point(0, 0)
            Me.c1TextBox1.Multiline = True
            Me.c1TextBox1.Name = "c1TextBox1"
            Me.c1TextBox1.Size = New System.Drawing.Size(262, 694)
            Me.c1TextBox1.TabIndex = 0
            Me.c1TextBox1.Tag = Nothing
            Me.c1ThemeController1.SetTheme(Me.c1TextBox1, "(default)")
            Me.c1TextBox1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 760)
            Me.Controls.Add(Me.splitContainer1)
            Me.Controls.Add(Me.c1Ribbon1)
            Me.Icon = (CType((resources.GetObject("$this.Icon")), System.Drawing.Icon))
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Advanced Filtering Sample"
            Me.c1ThemeController1.SetTheme(Me, "(default)")
            CType((Me.c1Ribbon1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.c1FlexGrid1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.Panel1.ResumeLayout(False)
            Me.splitContainer1.Panel2.ResumeLayout(False)
            CType((Me.splitContainer1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainer1.ResumeLayout(False)
            CType((Me.c1TextBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.c1ThemeController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
        Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
        Private ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
        Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
        Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
        Private ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
        Private c1ThemeController1 As C1.Win.C1Themes.C1ThemeController
        Private WithEvents cmbTheme As C1.Win.Ribbon.RibbonComboBox
        Private c1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
        Private WithEvents rbSaveFiltersToXml As C1.Win.Ribbon.RibbonButton
        Private splitContainer1 As System.Windows.Forms.SplitContainer
        Private c1TextBox1 As C1.Win.C1Input.C1TextBox
        Private WithEvents rbCreateFilters As C1.Win.Ribbon.RibbonButton
        Private WithEvents rbLoadFiltersFromXml As C1.Win.Ribbon.RibbonButton
        Private WithEvents rbClearFilters As C1.Win.Ribbon.RibbonButton
    End Class
End Namespace
