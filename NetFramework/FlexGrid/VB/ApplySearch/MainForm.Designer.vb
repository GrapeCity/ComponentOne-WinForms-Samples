Imports C1.Win.Ribbon

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits C1RibbonForm

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.rcbHighlightMode = New C1.Win.Ribbon.RibbonComboBox()
        Me.rcbSearchFilter = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonButton1 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton2 = New C1.Win.Ribbon.RibbonButton()
        Me.rcbSearchTemplates = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonButton3 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton4 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton5 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton6 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton7 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton8 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.cmbTheme = New C1.Win.Ribbon.RibbonComboBox()
        Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.c1FlexGridSearchPanel1 = New C1.Win.C1FlexGrid.C1FlexGridSearchPanel()
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1Ribbon1
        '
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
        '
        'ribbonApplicationMenu1
        '
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        Me.ribbonApplicationMenu1.Visible = False
        '
        'ribbonBottomToolBar1
        '
        Me.ribbonBottomToolBar1.HorizontalAlignment = C1.Win.Ribbon.ToolBarHorizontalAlignment.Left
        Me.ribbonBottomToolBar1.Items.Add(Me.rcbHighlightMode)
        Me.ribbonBottomToolBar1.Items.Add(Me.rcbSearchFilter)
        Me.ribbonBottomToolBar1.Items.Add(Me.rcbSearchTemplates)
        Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
        '
        'rcbHighlightMode
        '
        Me.rcbHighlightMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rcbHighlightMode.Label = " Highlight Mode:"
        Me.rcbHighlightMode.Name = "rcbHighlightMode"
        '
        'rcbSearchFilter
        '
        Me.rcbSearchFilter.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rcbSearchFilter.Items.Add(Me.ribbonButton1)
        Me.rcbSearchFilter.Items.Add(Me.ribbonButton2)
        Me.rcbSearchFilter.Label = " Filter Results:"
        Me.rcbSearchFilter.Name = "rcbSearchFilter"
        '
        'ribbonButton1
        '
        Me.ribbonButton1.Name = "ribbonButton1"
        Me.ribbonButton1.Text = "Enabled"
        '
        'ribbonButton2
        '
        Me.ribbonButton2.Name = "ribbonButton2"
        Me.ribbonButton2.Text = "Disabled"
        '
        'rcbSearchTemplates
        '
        Me.rcbSearchTemplates.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton3)
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton4)
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton5)
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton6)
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton7)
        Me.rcbSearchTemplates.Items.Add(Me.ribbonButton8)
        Me.rcbSearchTemplates.Label = " Search Templates:"
        Me.rcbSearchTemplates.Name = "rcbSearchTemplates"
        '
        'ribbonButton3
        '
        Me.ribbonButton3.Name = "ribbonButton3"
        Me.ribbonButton3.Text = """a""""B"""
        '
        'ribbonButton4
        '
        Me.ribbonButton4.Name = "ribbonButton4"
        Me.ribbonButton4.Text = "123"
        '
        'ribbonButton5
        '
        Me.ribbonButton5.Name = "ribbonButton5"
        Me.ribbonButton5.Text = """VE""-""bA""-""9"""
        '
        'ribbonButton6
        '
        Me.ribbonButton6.Name = "ribbonButton6"
        Me.ribbonButton6.Text = "+""Ma""-""d"""
        '
        'ribbonButton7
        '
        Me.ribbonButton7.Name = "ribbonButton7"
        Me.ribbonButton7.Text = "+""rI""""od"""
        '
        'ribbonButton8
        '
        Me.ribbonButton8.Name = "ribbonButton8"
        Me.ribbonButton8.Text = """g s"""", p"""
        '
        'ribbonConfigToolBar1
        '
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        '
        'ribbonQat1
        '
        Me.ribbonQat1.Name = "ribbonQat1"
        Me.ribbonQat1.Visible = False
        '
        'ribbonTopToolBar1
        '
        Me.ribbonTopToolBar1.Items.Add(Me.cmbTheme)
        Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
        '
        'cmbTheme
        '
        Me.cmbTheme.Label = "Theme"
        Me.cmbTheme.Name = "cmbTheme"
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None
        Me.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = False
        Me.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = False
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 115)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Size = New System.Drawing.Size(1016, 645)
        Me.c1FlexGrid1.TabIndex = 1
        Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
        Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        '
        'c1FlexGridSearchPanel1
        '
        Me.c1FlexGridSearchPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1FlexGridSearchPanel1.Location = New System.Drawing.Point(0, 66)
        Me.c1FlexGridSearchPanel1.Name = "c1FlexGridSearchPanel1"
        Me.c1FlexGridSearchPanel1.SearchMode = C1.Win.C1FlexGrid.SearchMode.Always
        Me.c1FlexGridSearchPanel1.Size = New System.Drawing.Size(1016, 49)
        Me.c1FlexGridSearchPanel1.TabIndex = 5
        Me.c1ThemeController1.SetTheme(Me.c1FlexGridSearchPanel1, "(default)")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 760)
        Me.Controls.Add(Me.c1FlexGrid1)
        Me.Controls.Add(Me.c1FlexGridSearchPanel1)
        Me.Controls.Add(Me.c1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ApplySearch Sample"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents c1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents cmbTheme As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents c1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents rcbHighlightMode As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents rcbSearchFilter As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents rcbSearchTemplates As C1.Win.Ribbon.RibbonComboBox
    Friend WithEvents ribbonButton1 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton2 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents c1FlexGridSearchPanel1 As C1.Win.C1FlexGrid.C1FlexGridSearchPanel
    Friend WithEvents ribbonButton3 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton4 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton5 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton6 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton7 As C1.Win.Ribbon.RibbonButton
    Friend WithEvents ribbonButton8 As C1.Win.Ribbon.RibbonButton
End Class
