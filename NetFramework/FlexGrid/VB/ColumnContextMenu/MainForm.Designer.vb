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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.Themes.C1ThemeController()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.c1Label1 = New C1.Win.C1Input.C1Label()
        Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.HideTabHeaderRow = True
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(856, 77)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1Ribbon1.ToolTipSettings.BackColor = System.Drawing.Color.White
        Me.C1Ribbon1.ToolTipSettings.BackgroundGradient = C1.Win.Ribbon.ToolTipGradient.None
        Me.C1Ribbon1.ToolTipSettings.Border = True
        Me.C1Ribbon1.ToolTipSettings.BorderColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.C1Ribbon1.ToolTipSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.C1Ribbon1.ToolTipSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.C1Ribbon1.ToolTipSettings.InitialDelay = 900
        Me.C1Ribbon1.ToolTipSettings.ReshowDelay = 180
        Me.C1Ribbon1.ToolTipSettings.Shadow = False
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        Me.C1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        Me.RibbonApplicationMenu1.Visible = False
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        Me.RibbonQat1.Visible = False
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Tab"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.cmbThemes)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Styles"
        '
        'cmbThemes
        '
        Me.cmbThemes.Label = "Theme"
        Me.cmbThemes.Name = "cmbThemes"
        Me.cmbThemes.TextAreaWidth = 120
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.c1Label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 77)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(856, 30)
        Me.panel1.TabIndex = 5
        Me.C1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'c1Label1
        '
        Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.c1Label1.Location = New System.Drawing.Point(0, 0)
        Me.c1Label1.Name = "c1Label1"
        Me.c1Label1.Padding = New System.Windows.Forms.Padding(3)
        Me.c1Label1.Size = New System.Drawing.Size(856, 21)
        Me.c1Label1.TabIndex = 0
        Me.c1Label1.Tag = Nothing
        Me.c1Label1.Text = "Right-click on the column header to open the context menu."
        Me.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c1Label1.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me.c1Label1, "(default)")
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.ColumnContextMenuEnabled = True
        Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:"
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 98)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None
        Me.c1FlexGrid1.Size = New System.Drawing.Size(856, 402)
        Me.c1FlexGrid1.TabIndex = 6
        Me.C1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 500)
        Me.Controls.Add(Me.c1FlexGrid1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        CType(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Friend WithEvents RibbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Friend WithEvents RibbonQat1 As C1.Win.Ribbon.RibbonQat
    Friend WithEvents RibbonTab1 As C1.Win.Ribbon.RibbonTab
    Friend WithEvents RibbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents C1ThemeController1 As C1.Win.Themes.C1ThemeController
    Friend WithEvents cmbThemes As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents panel1 As Panel
    Private WithEvents c1Label1 As C1.Win.C1Input.C1Label
    Private WithEvents c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
End Class
