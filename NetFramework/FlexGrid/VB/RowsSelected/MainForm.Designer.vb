Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        ribbonComboBoxSelMode = New C1.Win.Ribbon.RibbonComboBox()
        ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        ribbonComboBoxThemes = New C1.Win.Ribbon.RibbonComboBox()
        c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        splitContainer1 = New Windows.Forms.SplitContainer()
        c1FlexGridData = New C1.Win.FlexGrid.C1FlexGrid()
        c1FlexGridRowsSelected = New C1.Win.FlexGrid.C1FlexGrid()
        CType(c1Ribbon1, ComponentModel.ISupportInitialize).BeginInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).BeginInit()
        CType(splitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        splitContainer1.Panel1.SuspendLayout()
        splitContainer1.Panel2.SuspendLayout()
        splitContainer1.SuspendLayout()
        CType(c1FlexGridData, ComponentModel.ISupportInitialize).BeginInit()
        CType(c1FlexGridRowsSelected, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' c1Ribbon1
        ' 
        c1Ribbon1.AllowContextMenu = False
        c1Ribbon1.AllowMinimize = False
        c1Ribbon1.AllowSimplifiedView = False
        c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1
        c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1
        c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1
        c1Ribbon1.HideTabHeaderRow = True
        c1Ribbon1.Location = New Drawing.Point(0, 0)
        c1Ribbon1.Margin = New Windows.Forms.Padding(6)
        c1Ribbon1.Name = "c1Ribbon1"
        c1Ribbon1.QatHolder = ribbonQat1
        c1Ribbon1.Size = New Drawing.Size(1016, 73)
        c1ThemeController1.SetTheme(c1Ribbon1, "(default)")
        c1Ribbon1.TopToolBarHolder = ribbonTopToolBar1
        ' 
        ' ribbonApplicationMenu1
        ' 
        ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        ribbonApplicationMenu1.TabIndex = 0
        ribbonApplicationMenu1.Visible = False
        ' 
        ' ribbonBottomToolBar1
        ' 
        ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left
        ribbonBottomToolBar1.Items.Add(ribbonComboBoxSelMode)
        ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        ' 
        ' ribbonComboBoxSelMode
        ' 
        ribbonComboBoxSelMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        ribbonComboBoxSelMode.Label = "Selection Mode:"
        ribbonComboBoxSelMode.Name = "ribbonComboBoxSelMode"
        ribbonComboBoxSelMode.TabIndex = 7
        AddHandler ribbonComboBoxSelMode.SelectedIndexChanged, New EventHandler(AddressOf ribbonComboBoxSelMode_SelectedIndexChanged)
        ' 
        ' ribbonConfigToolBar1
        ' 
        ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        ribbonConfigToolBar1.Visible = False
        ' 
        ' ribbonQat1
        ' 
        ribbonQat1.Name = "ribbonQat1"
        ribbonQat1.Visible = False
        ' 
        ' ribbonTopToolBar1
        ' 
        ribbonTopToolBar1.Items.Add(ribbonComboBoxThemes)
        ribbonTopToolBar1.Name = "ribbonTopToolBar1"
        ' 
        ' ribbonComboBoxThemes
        ' 
        ribbonComboBoxThemes.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        ribbonComboBoxThemes.IconSet.Add(New C1.Framework.C1BitmapIcon("Themes", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", 462))
        ribbonComboBoxThemes.Label = "Theme:"
        ribbonComboBoxThemes.Name = "ribbonComboBoxThemes"
        ribbonComboBoxThemes.TabIndex = 6
        AddHandler ribbonComboBoxThemes.SelectedIndexChanged, New EventHandler(AddressOf ribbonComboBoxThemes_SelectedIndexChanged)
        ' 
        ' c1ThemeController1
        ' 
        c1ThemeController1.Theme = "Office365Green"
        ' 
        ' splitContainer1
        ' 
        splitContainer1.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        splitContainer1.Dock = Windows.Forms.DockStyle.Fill
        splitContainer1.Font = New Drawing.Font("Segoe UI", 14.0F)
        splitContainer1.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        splitContainer1.Location = New Drawing.Point(0, 73)
        splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        splitContainer1.Panel1.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        splitContainer1.Panel1.Controls.Add(c1FlexGridData)
        splitContainer1.Panel1.Font = New Drawing.Font("Segoe UI", 14.0F)
        splitContainer1.Panel1.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        c1ThemeController1.SetTheme(splitContainer1.Panel1, "(default)")
        ' 
        ' splitContainer1.Panel2
        ' 
        splitContainer1.Panel2.BackColor = Drawing.Color.FromArgb(240, 240, 240)
        splitContainer1.Panel2.Controls.Add(c1FlexGridRowsSelected)
        splitContainer1.Panel2.Font = New Drawing.Font("Segoe UI", 14.0F)
        splitContainer1.Panel2.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        c1ThemeController1.SetTheme(splitContainer1.Panel2, "(default)")
        splitContainer1.Size = New Drawing.Size(1016, 687)
        splitContainer1.SplitterDistance = 867
        splitContainer1.TabIndex = 2
        c1ThemeController1.SetTheme(splitContainer1, "(default)")
        ' 
        ' c1FlexGridData
        ' 
        c1FlexGridData.AllowEditing = False
        c1FlexGridData.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Spill
        c1FlexGridData.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.None
        c1FlexGridData.BackColor = Drawing.Color.White
        c1FlexGridData.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}" & Microsoft.VisualBasic.Constants.vbTab
        c1FlexGridData.Dock = Windows.Forms.DockStyle.Fill
        c1FlexGridData.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background
        c1FlexGridData.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        c1FlexGridData.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365
        c1FlexGridData.Location = New Drawing.Point(0, 0)
        c1FlexGridData.Margin = New Windows.Forms.Padding(6)
        c1FlexGridData.MarqueeStyle.BackgroundPadding = New Windows.Forms.Padding(1)
        c1FlexGridData.MarqueeStyle.BackgroundPaddingColor = Drawing.Color.White
        c1FlexGridData.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside
        c1FlexGridData.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange
        c1FlexGridData.MarqueeStyle.Color = Drawing.Color.FromArgb(33, 132, 72)
        c1FlexGridData.MarqueeStyle.Width = 2
        c1FlexGridData.Name = "c1FlexGridData"
        c1FlexGridData.Size = New Drawing.Size(867, 687)
        c1FlexGridData.StyleInfo = resources.GetString("c1FlexGridData.StyleInfo")
        c1FlexGridData.TabIndex = 1
        c1ThemeController1.SetTheme(c1FlexGridData, "(default)")
        c1FlexGridData.Tree.Indent = 25
        c1FlexGridData.Tree.LineColor = Drawing.Color.FromArgb(141, 141, 141)
        c1FlexGridData.UseCompatibleTextRendering = True
        AddHandler c1FlexGridData.AfterSelChange, New C1.Win.FlexGrid.RangeEventHandler(AddressOf c1FlexGridData_AfterSelChange)
        ' 
        ' c1FlexGridRowsSelected
        ' 
        c1FlexGridRowsSelected.BackColor = Drawing.Color.White
        c1FlexGridRowsSelected.ColumnInfo = "1,0,0,0,0,-1,Columns:0{Name:""colRowsSelected"";Caption:""Rows.Selected:"";AllowDragg" & "ing:False;AllowResizing:False;AllowEditing:False;}" & Microsoft.VisualBasic.Constants.vbTab
        c1FlexGridRowsSelected.Dock = Windows.Forms.DockStyle.Fill
        c1FlexGridRowsSelected.ExtendLastCol = True
        c1FlexGridRowsSelected.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background
        c1FlexGridRowsSelected.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        c1FlexGridRowsSelected.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365
        c1FlexGridRowsSelected.Location = New Drawing.Point(0, 0)
        c1FlexGridRowsSelected.MarqueeStyle.BackgroundPadding = New Windows.Forms.Padding(1)
        c1FlexGridRowsSelected.MarqueeStyle.BackgroundPaddingColor = Drawing.Color.White
        c1FlexGridRowsSelected.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside
        c1FlexGridRowsSelected.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange
        c1FlexGridRowsSelected.MarqueeStyle.Color = Drawing.Color.FromArgb(33, 132, 72)
        c1FlexGridRowsSelected.MarqueeStyle.Width = 2
        c1FlexGridRowsSelected.Name = "c1FlexGridRowsSelected"
        c1FlexGridRowsSelected.Rows.Count = 1
        c1FlexGridRowsSelected.Size = New Drawing.Size(145, 687)
        c1FlexGridRowsSelected.StyleInfo = resources.GetString("c1FlexGridRowsSelected.StyleInfo")
        c1FlexGridRowsSelected.TabIndex = 0
        c1ThemeController1.SetTheme(c1FlexGridRowsSelected, "(default)")
        c1FlexGridRowsSelected.Tree.Indent = 25
        c1FlexGridRowsSelected.Tree.LineColor = Drawing.Color.FromArgb(141, 141, 141)
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New Drawing.SizeF(11.0F, 25.0F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1016, 760)
        Controls.Add(splitContainer1)
        Controls.Add(c1Ribbon1)
        Font = New Drawing.Font("Segoe UI", 14.0F)
        ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        Margin = New Windows.Forms.Padding(6)
        MinimumSize = New Drawing.Size(1024, 768)
        Name = "MainForm"
        StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        Text = "FlexGrid Rows Selected Sample"
        c1ThemeController1.SetTheme(Me, "(default)")
        CType(c1Ribbon1, ComponentModel.ISupportInitialize).EndInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.Panel1.ResumeLayout(False)
        splitContainer1.Panel2.ResumeLayout(False)
        CType(splitContainer1, ComponentModel.ISupportInitialize).EndInit()
        splitContainer1.ResumeLayout(False)
        CType(c1FlexGridData, ComponentModel.ISupportInitialize).EndInit()
        CType(c1FlexGridRowsSelected, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private components As ComponentModel.IContainer
    Private c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Private ribbonComboBoxThemes As C1.Win.Ribbon.RibbonComboBox
    Private c1ThemeController1 As C1.Win.Themes.C1ThemeController
    Private splitContainer1 As Windows.Forms.SplitContainer
    Private c1FlexGridData As C1.Win.FlexGrid.C1FlexGrid
    Private ribbonComboBoxSelMode As C1.Win.Ribbon.RibbonComboBox
    Private c1FlexGridRowsSelected As C1.Win.FlexGrid.C1FlexGrid
End Class
