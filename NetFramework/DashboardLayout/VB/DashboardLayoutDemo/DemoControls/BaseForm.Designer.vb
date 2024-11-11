Namespace DashboardDemo.Controls
    Partial Public Class BaseForm
        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseForm))
            Me.c1Ribbon1 = New C1.Win.Ribbon.C1Ribbon()
            Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
            Me.ribbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
            Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
            Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
            Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab()
            Me.ribbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
            Me.ribbonMenu1 = New C1.Win.Ribbon.RibbonMenu()
            Me.menuSave = New C1.Win.Ribbon.RibbonButton()
            Me.menuApply = New C1.Win.Ribbon.RibbonSplitButton()
            Me.menuManage = New C1.Win.Ribbon.RibbonButton()
            Me.menuReset = New C1.Win.Ribbon.RibbonButton()
            Me.ribbonGroup4 = New C1.Win.Ribbon.RibbonGroup()
            Me.btnFlow = New C1.Win.Ribbon.RibbonToggleButton()
            Me.btnGrid = New C1.Win.Ribbon.RibbonToggleButton()
            Me.btnSplit = New C1.Win.Ribbon.RibbonToggleButton()
            Me.ribbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
            Me.cmbToolicon = New C1.Win.Ribbon.RibbonComboBox()
            Me.ribbonGroup3 = New C1.Win.Ribbon.RibbonGroup()
            Me.cmbThemes = New C1.Win.Ribbon.RibbonComboBox()
            Me.ribbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
            CType((Me.c1Ribbon1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.c1Ribbon1.ApplicationMenuHolder = Me.ribbonApplicationMenu1
            Me.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
            Me.c1Ribbon1.BottomToolBarHolder = Me.ribbonBottomToolBar1
            Me.c1Ribbon1.ConfigToolBarHolder = Me.ribbonConfigToolBar1
            Me.c1Ribbon1.Location = New System.Drawing.Point(0, 0)
            Me.c1Ribbon1.Name = "c1Ribbon1"
            Me.c1Ribbon1.QatHolder = Me.ribbonQat1
            Me.c1Ribbon1.Size = New System.Drawing.Size(1016, 155)
            Me.c1Ribbon1.Tabs.Add(Me.ribbonTab1)
            Me.c1Ribbon1.TopToolBarHolder = Me.ribbonTopToolBar1
            Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
            Me.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1"
            Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
            Me.ribbonQat1.Name = "ribbonQat1"
            Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
            Me.ribbonTab1.Groups.Add(Me.ribbonGroup4)
            Me.ribbonTab1.Groups.Add(Me.ribbonGroup2)
            Me.ribbonTab1.Groups.Add(Me.ribbonGroup3)
            Me.ribbonTab1.Name = "ribbonTab1"
            Me.ribbonTab1.Text = "Settings"
            Me.ribbonGroup1.Items.Add(Me.ribbonMenu1)
            Me.ribbonGroup1.Name = "ribbonGroup1"
            Me.ribbonGroup1.Text = "Layout"
            Me.ribbonMenu1.Items.Add(Me.menuSave)
            Me.ribbonMenu1.Items.Add(Me.menuApply)
            Me.ribbonMenu1.Items.Add(Me.menuManage)
            Me.ribbonMenu1.Items.Add(Me.menuReset)
            Me.ribbonMenu1.LargeImage = (CType((resources.GetObject("ribbonMenu1.LargeImage")), System.Drawing.Image))
            Me.ribbonMenu1.Name = "ribbonMenu1"
            Me.ribbonMenu1.TextImageRelation = C1.Win.Ribbon.TextImageRelation.ImageAboveText
            Me.menuSave.Name = "menuSave"
            Me.menuSave.SmallImage = (CType((resources.GetObject("menuSave.SmallImage")), System.Drawing.Image))
            Me.menuSave.Text = "Save Layout"
            AddHandler Me.menuSave.Click, New System.EventHandler(AddressOf Me.menuSave_Click)
            Me.menuApply.Name = "menuApply"
            Me.menuApply.SmallImage = (CType((resources.GetObject("menuApply.SmallImage")), System.Drawing.Image))
            Me.menuApply.Text = "Apply Layout"
            Me.menuManage.Name = "menuManage"
            Me.menuManage.SmallImage = (CType((resources.GetObject("menuManage.SmallImage")), System.Drawing.Image))
            Me.menuManage.Text = "Manage Layout"
            AddHandler Me.menuManage.Click, New System.EventHandler(AddressOf Me.menuManage_Click)
            Me.menuReset.Name = "menuReset"
            Me.menuReset.SmallImage = (CType((resources.GetObject("menuReset.SmallImage")), System.Drawing.Image))
            Me.menuReset.Text = "Reset Layout"
            AddHandler Me.menuReset.Click, New System.EventHandler(AddressOf Me.menuReset_Click)
            Me.ribbonGroup4.Items.Add(Me.btnFlow)
            Me.ribbonGroup4.Items.Add(Me.btnGrid)
            Me.ribbonGroup4.Items.Add(Me.btnSplit)
            Me.ribbonGroup4.Name = "ribbonGroup4"
            Me.ribbonGroup4.Text = "LayoutType"
            Me.btnFlow.CanDepress = False
            Me.btnFlow.Name = "btnFlow"
            Me.btnFlow.Text = "Flow"
            Me.btnFlow.ToggleGroupName = "LayoutType"
            AddHandler Me.btnFlow.PressedChanged, New System.EventHandler(AddressOf Me.btnFlow_PressedChanged)
            Me.btnGrid.CanDepress = False
            Me.btnGrid.Name = "btnGrid"
            Me.btnGrid.Text = "Grid"
            Me.btnGrid.ToggleGroupName = "LayoutType"
            AddHandler Me.btnGrid.PressedChanged, New System.EventHandler(AddressOf Me.btnGrid_PressedChanged)
            Me.btnSplit.CanDepress = False
            Me.btnSplit.Name = "btnSplit"
            Me.btnSplit.Text = "Split"
            Me.btnSplit.ToggleGroupName = "LayoutType"
            AddHandler Me.btnSplit.PressedChanged, New System.EventHandler(AddressOf Me.btnSplit_PressedChanged)
            Me.ribbonGroup2.Items.Add(Me.cmbToolicon)
            Me.ribbonGroup2.Name = "ribbonGroup2"
            Me.ribbonGroup2.Text = "Options"
            Me.cmbToolicon.Label = "Toolicon"
            Me.cmbToolicon.Name = "cmbToolicon"
            AddHandler Me.cmbToolicon.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbToolicon_SelectedIndexChanged)
            Me.ribbonGroup3.Items.Add(Me.cmbThemes)
            Me.ribbonGroup3.Name = "ribbonGroup3"
            Me.ribbonGroup3.Text = "Theme"
            Me.cmbThemes.Name = "cmbThemes"
            AddHandler Me.cmbThemes.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cmbThemes_SelectedIndexChanged)
            Me.ribbonTopToolBar1.Name = "ribbonTopToolBar1"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1016, 672)
            Me.Controls.Add(Me.c1Ribbon1)
            Me.Name = "BaseForm"
            Me.Text = "BaseForm"
            CType((Me.c1Ribbon1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

        Private c1Ribbon1 As C1.Win.Ribbon.C1Ribbon
        Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
        Private ribbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
        Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
        Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
        Private ribbonTab1 As C1.Win.Ribbon.RibbonTab
        Private ribbonGroup1 As C1.Win.Ribbon.RibbonGroup
        Private ribbonMenu1 As C1.Win.Ribbon.RibbonMenu
        Private menuSave As C1.Win.Ribbon.RibbonButton
        Private menuApply As C1.Win.Ribbon.RibbonSplitButton
        Private menuManage As C1.Win.Ribbon.RibbonButton
        Private menuReset As C1.Win.Ribbon.RibbonButton
        Private ribbonGroup4 As C1.Win.Ribbon.RibbonGroup
        Private btnFlow As C1.Win.Ribbon.RibbonToggleButton
        Private btnGrid As C1.Win.Ribbon.RibbonToggleButton
        Private btnSplit As C1.Win.Ribbon.RibbonToggleButton
        Private ribbonGroup2 As C1.Win.Ribbon.RibbonGroup
        Private cmbToolicon As C1.Win.Ribbon.RibbonComboBox
        Private ribbonGroup3 As C1.Win.Ribbon.RibbonGroup
        Private cmbThemes As C1.Win.Ribbon.RibbonComboBox
        Private ribbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    End Class
End Namespace
