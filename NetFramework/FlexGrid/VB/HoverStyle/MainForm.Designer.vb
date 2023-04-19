Namespace HoverStyle
    Partial Class MainForm
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim c1CompositeIcon1 As C1.Framework.C1CompositeIcon = New C1.Framework.C1CompositeIcon()
            Dim c1PathIcon1 As C1.Framework.C1PathIcon = New C1.Framework.C1PathIcon()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
            Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
            Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
            Me.rbHoverMode = New C1.Win.Ribbon.RibbonComboBox()
            Me.rbSelectMode = New C1.Win.Ribbon.RibbonComboBox()
            Me.rbHoverColor = New C1.Win.Ribbon.RibbonColorPicker()
            Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
            Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
            Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
            Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
            Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
            Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
            CType(Me.c1Ribbon1, ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1FlexGrid1, ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1ThemeController1, ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' c1Ribbon1
            ' 
            Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
            Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
            Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
            Me.c1Ribbon1.HideTabHeaderRow = True
            Me.c1Ribbon1.Location = New Drawing.Point(0, 0)
            Me.c1Ribbon1.Name = "c1Ribbon1"
            Me.c1Ribbon1.QatHolder = Me.ribbonQat1
            Me.c1Ribbon1.Size = New Drawing.Size(1016, 66)
            Me.c1ThemeController1.SetTheme(Me.c1Ribbon1, "(default)")
            Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
            Me.c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
            ' 
            ' ribbonApplicationMenu1
            ' 
            Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
            Me.ribbonApplicationMenu1.Visible = False
            ' 
            ' ribbonBottomToolBar1
            ' 
            Me.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left
            Me.ribbonBottomToolBar1.Items.Add(Me.rbHoverMode)
            Me.ribbonBottomToolBar1.Items.Add(Me.rbSelectMode)
            Me.ribbonBottomToolBar1.Items.Add(Me.rbHoverColor)
            Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
            ' 
            ' rbHoverMode
            ' 
            Me.rbHoverMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
            Me.rbHoverMode.Label = " Hover Mode:"
            Me.rbHoverMode.Name = "rbHoverMode"
            Me.rbHoverMode.ToolTip = "Hover Mode"

            ' 
            ' rbSelectMode
            ' 
            Me.rbSelectMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
            Me.rbSelectMode.Label = " Select Mode:"
            Me.rbSelectMode.Name = "rbSelectMode"
            Me.rbSelectMode.ToolTip = "Select Mode"

            ' 
            ' rbHoverColor
            ' 
            Me.rbHoverColor.Color = Drawing.Color.FromArgb(0, 192, 0)
            Me.rbHoverColor.DefaultColor = Drawing.Color.FromArgb(0, 192, 0)
            c1PathIcon1.AllowSmoothing = False
            c1PathIcon1.Color = Drawing.Color.FromArgb(0, 192, 0)
            c1PathIcon1.Data = "M-2.7755575615628892e-17,18.89795939167988 h24 v5.142857098579968 h-24 z"
            c1PathIcon1.Size = New Drawing.Size(16, 16)
            c1PathIcon1.Stroke = Drawing.Color.Empty
            c1PathIcon1.ViewBox = New Drawing.Rectangle(0, 0, 24, 24)
            c1CompositeIcon1.Icons.Add(New C1.Framework.C1BitmapIcon("FontColor", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", -1))
            c1CompositeIcon1.Icons.Add(c1PathIcon1)
            c1CompositeIcon1.Size = New Drawing.Size(16, 16)
            Me.rbHoverColor.IconSet.Add(c1CompositeIcon1)
            Me.rbHoverColor.Name = "rbHoverColor"
            Me.rbHoverColor.Text = "Hover Color"
            Me.rbHoverColor.ToolTip = "Hover Color"

            ' 
            ' ribbonConfigToolBar1
            ' 
            Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
            ' 
            ' ribbonQat1
            ' 
            Me.ribbonQat1.Name = "ribbonQat1"
            Me.ribbonQat1.Visible = False
            ' 
            ' ribbonTopToolBar1
            ' 
            Me.ribbonTopToolBar1.Items.Add(Me.cmbTheme)
            Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
            ' 
            ' cmbTheme
            ' 
            Me.cmbTheme.Label = "Theme"
            Me.cmbTheme.Name = "cmbTheme"

            ' 
            ' c1FlexGrid1
            ' 
            Me.c1FlexGrid1.AllowFiltering = True
            Me.c1FlexGrid1.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both
            Me.c1FlexGrid1.ColumnContextMenuEnabled = True
            Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
            Me.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.Highlight
            Me.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = True
            Me.c1FlexGrid1.Dock = Windows.Forms.DockStyle.Fill
            Me.c1FlexGrid1.Font = New Drawing.Font("Segoe UI", 9.75F)
            Me.c1FlexGrid1.Location = New Drawing.Point(0, 66)
            Me.c1FlexGrid1.Name = "c1FlexGrid1"
            Me.c1FlexGrid1.Size = New Drawing.Size(1016, 694)
            Me.c1FlexGrid1.TabIndex = 6
            Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
            Me.c1FlexGrid1.Tree.LineColor = Drawing.Color.FromArgb(171, 171, 171)
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New Drawing.Size(1016, 760)
            Me.Controls.Add(Me.c1FlexGrid1)
            Me.Controls.Add(Me.c1Ribbon1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Me.Name = "MainForm"
            Me.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Advanced Filtering Sample"
            Me.c1ThemeController1.SetTheme(Me, "(default)")
            CType(Me.c1Ribbon1, ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1FlexGrid1, ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1ThemeController1, ComponentModel.ISupportInitialize).EndInit()
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
        Private c1TextBox1 As C1.Win.C1Input.C1TextBox
        Private WithEvents rbHoverColor As C1.Win.Ribbon.RibbonColorPicker
        Private WithEvents rbSelectMode As C1.Win.Ribbon.RibbonComboBox
        Private WithEvents rbHoverMode As C1.Win.Ribbon.RibbonComboBox
    End Class
End Namespace
