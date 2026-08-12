' Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        ribbonButtonImportSheet = New C1.Win.Ribbon.RibbonButton()
        ribbonButtonExportSheet = New C1.Win.Ribbon.RibbonButton()
        ribbonButtonLoadData = New C1.Win.Ribbon.RibbonButton()
        ribbonButtonExportMultiSheet = New C1.Win.Ribbon.RibbonButton()
        ribbonComboBoxThemes = New C1.Win.Ribbon.RibbonComboBox()
        ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        CType(c1FlexGrid1, ComponentModel.ISupportInitialize).BeginInit()
        CType(c1Ribbon1, ComponentModel.ISupportInitialize).BeginInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' c1FlexGrid1
        ' 
        Me.c1FlexGrid1.ColumnInfo = resources.GetString("C1FlexGrid1.ColumnInfo")
        Me.c1FlexGrid1.StyleInfo = resources.GetString("C1FlexGrid1.StyleInfo")
        c1FlexGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.Spill
        c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both
        c1FlexGrid1.BackColor = Drawing.Color.White
        c1FlexGrid1.Dock = Windows.Forms.DockStyle.Fill
        c1FlexGrid1.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background
        c1FlexGrid1.ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        c1FlexGrid1.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365
        c1FlexGrid1.Location = New Drawing.Point(0, 39)
        c1FlexGrid1.Margin = New Windows.Forms.Padding(6, 6, 6, 6)
        c1FlexGrid1.MarqueeStyle.BackgroundPadding = New Windows.Forms.Padding(1)
        c1FlexGrid1.MarqueeStyle.BackgroundPaddingColor = Drawing.Color.White
        c1FlexGrid1.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside
        c1FlexGrid1.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange
        c1FlexGrid1.MarqueeStyle.Color = Drawing.Color.FromArgb(33, 132, 72)
        c1FlexGrid1.MarqueeStyle.Width = 2
        c1FlexGrid1.Name = "c1FlexGrid1"
        c1FlexGrid1.Size = New Drawing.Size(1008, 690)
        c1FlexGrid1.TabIndex = 0
        c1ThemeController1.SetTheme(c1FlexGrid1, "(default)")
        c1FlexGrid1.Tree.Indent = 25
        c1FlexGrid1.Tree.LineColor = Drawing.Color.FromArgb(141, 141, 141)
        c1FlexGrid1.UseCompatibleTextRendering = True
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
        c1Ribbon1.Margin = New Windows.Forms.Padding(6, 6, 6, 6)
        c1Ribbon1.Name = "c1Ribbon1"
        c1Ribbon1.QatHolder = ribbonQat1
        c1Ribbon1.Size = New Drawing.Size(1008, 39)
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
        ribbonBottomToolBar1.Items.Add(ribbonButtonImportSheet)
        ribbonBottomToolBar1.Items.Add(ribbonButtonExportSheet)
        ribbonBottomToolBar1.Items.Add(ribbonButtonLoadData)
        ribbonBottomToolBar1.Items.Add(ribbonButtonExportMultiSheet)
        ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        ' 
        ' ribbonButtonImportSheet
        ' 
        ribbonButtonImportSheet.IconSet.Add(New C1.Framework.C1BitmapIcon("Import", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", 218))
        ribbonButtonImportSheet.Name = "ribbonButtonImportSheet"
        ribbonButtonImportSheet.TabIndex = 1
        ribbonButtonImportSheet.Text = "&Import Sheet..."
        AddHandler ribbonButtonImportSheet.Click, New EventHandler(AddressOf btnImportSheet_Click)
        ' 
        ' ribbonButtonExportSheet
        ' 
        ribbonButtonExportSheet.IconSet.Add(New C1.Framework.C1BitmapIcon("Export", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", 0))
        ribbonButtonExportSheet.Name = "ribbonButtonExportSheet"
        ribbonButtonExportSheet.TabIndex = 2
        ribbonButtonExportSheet.Text = "&Export Sheet..."
        AddHandler ribbonButtonExportSheet.Click, New EventHandler(AddressOf btnExportSheet_Click)
        ' 
        ' ribbonButtonLoadData
        ' 
        ribbonButtonLoadData.IconSet.Add(New C1.Framework.C1BitmapIcon("FromDatabase", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", 173))
        ribbonButtonLoadData.Name = "ribbonButtonLoadData"
        ribbonButtonLoadData.TabIndex = 3
        ribbonButtonLoadData.Text = "Load &Data"
        AddHandler ribbonButtonLoadData.Click, New EventHandler(AddressOf btnLoadData_Click)
        ' 
        ' ribbonButtonExportMultiSheet
        ' 
        ribbonButtonExportMultiSheet.IconSet.Add(New C1.Framework.C1BitmapIcon("SidebySide", New Drawing.Size(16, 16), Drawing.Color.Transparent, "Preset_SmallImages", 423))
        ribbonButtonExportMultiSheet.Name = "ribbonButtonExportMultiSheet"
        ribbonButtonExportMultiSheet.TabIndex = 4
        ribbonButtonExportMultiSheet.Text = "Export &Multi-Sheet..."
        AddHandler ribbonButtonExportMultiSheet.Click, New EventHandler(AddressOf btnMultiSheet_Click)
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
        ribbonTopToolBar1.Name = "ribbonTopToolBar1"
        ribbonTopToolBar1.Items.Add(ribbonComboBoxThemes)
        ' 
        ' c1ThemeController1
        ' 
        c1ThemeController1.Theme = "Office365Green"
        ' 
        ' MainForm
        AutoScaleDimensions = New Drawing.SizeF(11.0F, 25.0F)
        AutoScaleMode = Windows.Forms.AutoScaleMode.Font
        ClientSize = New Drawing.Size(1008, 729)
        Controls.Add(c1FlexGrid1)
        Controls.Add(c1Ribbon1)
        Font = New Drawing.Font("Segoe UI", 14.0F)
        ForeColor = Drawing.Color.FromArgb(32, 32, 32)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Margin = New Windows.Forms.Padding(6, 6, 6, 6)
        MinimumSize = New Drawing.Size(1024, 768)
        Name = "MainForm"
        StartPosition = Windows.Forms.FormStartPosition.CenterScreen
        Text = "Import and Export Excel files Sample"
        c1ThemeController1.SetTheme(Me, "(default)")
        CType(c1FlexGrid1, ComponentModel.ISupportInitialize).EndInit()
        CType(c1Ribbon1, ComponentModel.ISupportInitialize).EndInit()
        CType(c1ThemeController1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Private c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Private ribbonButtonExportSheet As C1.Win.Ribbon.RibbonButton
    Private ribbonButtonImportSheet As C1.Win.Ribbon.RibbonButton
    Private ribbonButtonLoadData As C1.Win.Ribbon.RibbonButton
    Private ribbonButtonExportMultiSheet As C1.Win.Ribbon.RibbonButton
    Private ribbonComboBoxThemes As C1.Win.Ribbon.RibbonComboBox
    Private c1ThemeController1 As C1.Win.Themes.C1ThemeController
End Class
