Imports C1.Win.C1Ribbon

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
        Dim C1TreeColumn1 As C1.Win.TreeView.C1TreeColumn = New C1.Win.TreeView.C1TreeColumn()
        Dim C1TreeNode1 As C1.Win.TreeView.C1TreeNode = New C1.Win.TreeView.C1TreeNode()
        Dim C1TreeNode2 As C1.Win.TreeView.C1TreeNode = New C1.Win.TreeView.C1TreeNode()
        Dim C1TreeNode3 As C1.Win.TreeView.C1TreeNode = New C1.Win.TreeView.C1TreeNode()
        Dim C1TreeNode4 As C1.Win.TreeView.C1TreeNode = New C1.Win.TreeView.C1TreeNode()
        Dim C1TreeNode5 As C1.Win.TreeView.C1TreeNode = New C1.Win.TreeView.C1TreeNode()
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.RibbonBottomToolBar1 = New C1.Win.C1Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonCMBThemes = New C1.Win.C1Ribbon.RibbonComboBox()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.ribbonCBCheckBoxStates = New C1.Win.C1Ribbon.RibbonCheckBox()
        Me.ribbonCBExpandStates = New C1.Win.C1Ribbon.RibbonCheckBox()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.ribbonBtnEditCheckBox = New C1.Win.C1Ribbon.RibbonButton()
        Me.ribbonBtnEditExpand = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.ribbonCBEnabledTreeView = New C1.Win.C1Ribbon.RibbonCheckBox()
        Me.RibbonTopToolBar1 = New C1.Win.C1Ribbon.RibbonTopToolBar()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.C1TreeView1 = New C1.Win.TreeView.C1TreeView()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup3)
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
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.ribbonCBCheckBoxStates)
        Me.RibbonGroup2.Items.Add(Me.ribbonCBExpandStates)
        Me.RibbonGroup2.Items.Add(Me.RibbonSeparator1)
        Me.RibbonGroup2.Items.Add(Me.ribbonBtnEditCheckBox)
        Me.RibbonGroup2.Items.Add(Me.ribbonBtnEditExpand)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Images"
        '
        'ribbonCBCheckBoxStates
        '
        Me.ribbonCBCheckBoxStates.Name = "ribbonCBCheckBoxStates"
        Me.ribbonCBCheckBoxStates.Text = "Use two checkbox states"
        '
        'ribbonCBExpandStates
        '
        Me.ribbonCBExpandStates.Name = "ribbonCBExpandStates"
        Me.ribbonCBExpandStates.Text = "Use two expand button states"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'ribbonBtnEditCheckBox
        '
        Me.ribbonBtnEditCheckBox.Name = "ribbonBtnEditCheckBox"
        Me.ribbonBtnEditCheckBox.SmallImage = CType(resources.GetObject("ribbonBtnEditCheckBox.SmallImage"), System.Drawing.Image)
        Me.ribbonBtnEditCheckBox.Text = "Edit checkbox images"
        '
        'ribbonBtnEditExpand
        '
        Me.ribbonBtnEditExpand.Name = "ribbonBtnEditExpand"
        Me.ribbonBtnEditExpand.SmallImage = CType(resources.GetObject("ribbonBtnEditExpand.SmallImage"), System.Drawing.Image)
        Me.ribbonBtnEditExpand.Text = "Edit expand button images"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.ribbonCBEnabledTreeView)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "TreeView"
        '
        'ribbonCBEnabledTreeView
        '
        Me.ribbonCBEnabledTreeView.Name = "ribbonCBEnabledTreeView"
        Me.ribbonCBEnabledTreeView.Text = "Enabled"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'C1TreeView1
        '
        '
        '
        '
        Me.C1TreeView1.ButtonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.C1TreeView1.ButtonImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.C1TreeView1.ButtonImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.C1TreeView1.CheckBoxes = True
        '
        '
        '
        Me.C1TreeView1.CheckImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.C1TreeView1.CheckImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.C1TreeView1.CheckImageList.TransparentColor = System.Drawing.Color.Transparent
        C1TreeColumn1.DisplayFieldName = Nothing
        C1TreeColumn1.HeaderText = "Column1"
        C1TreeColumn1.Name = "Column1"
        Me.C1TreeView1.Columns.Add(C1TreeColumn1)
        Me.C1TreeView1.BindingInfo.DataMember = Nothing
        Me.C1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TreeView1.BindingInfo.KeyField = Nothing
        Me.C1TreeView1.Location = New System.Drawing.Point(0, 143)
        Me.C1TreeView1.Name = "C1TreeView1"
        C1TreeNode2.SetValue("New node")
        C1TreeNode1.Nodes.Add(C1TreeNode2)
        C1TreeNode1.SetValue("New node")
        C1TreeNode4.SetValue("New node")
        C1TreeNode3.Nodes.Add(C1TreeNode4)
        C1TreeNode3.SetValue("New node")
        C1TreeNode5.SetValue("New node")
        Me.C1TreeView1.Nodes.Add(C1TreeNode1)
        Me.C1TreeView1.Nodes.Add(C1TreeNode3)
        Me.C1TreeView1.Nodes.Add(C1TreeNode5)
        Me.C1TreeView1.BindingInfo.ParentKeyField = Nothing
        Me.C1TreeView1.Size = New System.Drawing.Size(640, 297)
        Me.C1TreeView1.Styles.ShowLines = False
        Me.C1TreeView1.TabIndex = 1
        Me.C1ThemeController1.SetTheme(Me.C1TreeView1, "(default)")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 440)
        Me.Controls.Add(Me.C1TreeView1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomStateImages"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        Me.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Custom
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TreeView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Private WithEvents RibbonCMBThemes As C1.Win.C1Ribbon.RibbonComboBox
    Private WithEvents RibbonApplicationMenu1 As RibbonApplicationMenu
    Private WithEvents RibbonBottomToolBar1 As RibbonBottomToolBar
    Private WithEvents RibbonConfigToolBar1 As RibbonConfigToolBar
    Private WithEvents RibbonQat1 As RibbonQat
    Private WithEvents RibbonTab1 As RibbonTab
    Private WithEvents RibbonGroup1 As RibbonGroup
    Private WithEvents RibbonTopToolBar1 As RibbonTopToolBar
    Private WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents RibbonGroup2 As RibbonGroup
    Friend WithEvents ribbonCBCheckBoxStates As RibbonCheckBox
    Friend WithEvents ribbonCBExpandStates As RibbonCheckBox
    Friend WithEvents RibbonSeparator1 As RibbonSeparator
    Friend WithEvents ribbonBtnEditCheckBox As RibbonButton
    Friend WithEvents ribbonBtnEditExpand As RibbonButton
    Friend WithEvents RibbonGroup3 As RibbonGroup
    Friend WithEvents ribbonCBEnabledTreeView As RibbonCheckBox
    Friend WithEvents C1TreeView1 As C1.Win.TreeView.C1TreeView
End Class
