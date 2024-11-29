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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.C1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.RibbonCMBThemes = New C1.Win.Ribbon.RibbonComboBox()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.RibbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
        Me.RibbonButton1 = New C1.Win.Ribbon.RibbonButton()
        Me.C1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.C1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.C1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.C1DataFilter1 = New C1.Win.DataFilter.C1DataFilter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1CommandDock1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1DockingTab1.SuspendLayout()
        Me.C1DockingTabPage1.SuspendLayout()
        CType(Me.C1DataFilter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(640, 143)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1ThemeController1.SetTheme(Me.C1Ribbon1, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me.C1Ribbon1, Nothing)
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
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
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup1)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Styles"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.RibbonCMBThemes)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "Theme"
        '
        'RibbonCMBThemes
        '
        Me.RibbonCMBThemes.Name = "RibbonCMBThemes"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.RibbonButton1)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Filter"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "Apply filter"
        '
        'C1CommandDock1
        '
        Me.C1CommandDock1.Controls.Add(Me.C1DockingTab1)
        Me.C1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1CommandDock1.Id = 1
        Me.C1CommandDock1.Location = New System.Drawing.Point(0, 143)
        Me.C1CommandDock1.Name = "C1CommandDock1"
        Me.C1CommandDock1.Size = New System.Drawing.Size(300, 297)
        Me.C1ThemeController1.SetTheme(Me.C1CommandDock1, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me.C1CommandDock1, Nothing)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(300, 143)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 297)
        Me.Panel1.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.Panel1, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me.Panel1, Nothing)
        '
        'C1DockingTab1
        '
        Me.C1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.C1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DockingTab1.CanAutoHide = True
        Me.C1DockingTab1.CanCloseTabs = False
        Me.C1DockingTab1.CanMoveTabs = True
        Me.C1DockingTab1.Controls.Add(Me.C1DockingTabPage1)
        Me.C1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTab1.Name = "C1DockingTab1"
        Me.C1DockingTab1.ShowCaption = True
        Me.C1DockingTab1.Size = New System.Drawing.Size(300, 297)
        Me.C1DockingTab1.TabIndex = 0
        Me.C1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.C1ThemeController1.SetTheme(Me.C1DockingTab1, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me.C1DockingTab1, Nothing)
        '
        'C1DockingTabPage1
        '
        Me.C1DockingTabPage1.CaptionVisible = True
        Me.C1DockingTabPage1.Controls.Add(Me.C1DataFilter1)
        Me.C1DockingTabPage1.Location = New System.Drawing.Point(0, 0)
        Me.C1DockingTabPage1.Name = "C1DockingTabPage1"
        Me.C1DockingTabPage1.Size = New System.Drawing.Size(297, 273)
        Me.C1DockingTabPage1.TabIndex = 0
        Me.C1DockingTabPage1.Text = "Filter"
        '
        'C1DataFilter1
        '
        Me.C1DataFilter1.AutoGenerateFilters = True
        Me.C1DataFilter1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DataFilter1.HeaderText = "Filter Employees"
        Me.C1DataFilter1.Location = New System.Drawing.Point(0, 24)
        Me.C1DataFilter1.Name = "C1DataFilter1"
        Me.C1DataFilter1.Size = New System.Drawing.Size(297, 249)
        Me.C1DataFilter1.TabIndex = 0
        Me.C1DataFilter1.Text = "C1DataFilter1"
        Me.C1ThemeController1.SetTheme(Me.C1DataFilter1, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me.C1DataFilter1, Nothing)
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(340, 297)
        Me.DataGridView1.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 440)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.C1CommandDock1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "MainForm"
        Me.Text = "Form1"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.C1ThemeController1.SetThemeSettings(Me, Nothing)
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1CommandDock1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1DockingTab1.ResumeLayout(False)
        Me.C1DockingTabPage1.ResumeLayout(False)
        CType(Me.C1DataFilter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.Ribbon.C1Ribbon
    Private WithEvents RibbonCMBThemes As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents RibbonApplicationMenu1 As RibbonApplicationMenu
    Private WithEvents RibbonBottomToolBar1 As RibbonBottomToolBar
    Private WithEvents RibbonConfigToolBar1 As RibbonConfigToolBar
    Private WithEvents RibbonQat1 As RibbonQat
    Private WithEvents RibbonTab1 As RibbonTab
    Private WithEvents RibbonGroup1 As RibbonGroup
    Private WithEvents RibbonTopToolBar1 As RibbonTopToolBar
    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents RibbonGroup2 As RibbonGroup
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents C1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Friend WithEvents Panel1 As Panel
    Friend WithEvents C1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Friend WithEvents C1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents C1DataFilter1 As C1.Win.DataFilter.C1DataFilter
    Friend WithEvents DataGridView1 As DataGridView
End Class
