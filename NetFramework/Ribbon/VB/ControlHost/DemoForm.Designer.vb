<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DemoForm
    Inherits C1.Win.C1Ribbon.C1RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DemoForm))
        Me.C1Ribbon1 = New C1.Win.C1Ribbon.C1Ribbon()
        Me.RibbonApplicationMenu1 = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.exitButton = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonBottomToolBar1 = New C1.Win.C1Ribbon.RibbonBottomToolBar()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.RibbonTab1 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup1 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.pictureBoxHost1 = New ControlHostLib.PictureBoxHost()
        Me.RibbonGroup4 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.numericUpDownHost1 = New ControlHostLib.NumericUpDownHost()
        Me.RibbonGroup5 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.checkedListBoxHost1 = New ControlHostLib.CheckedListBoxHost()
        Me.RibbonTab2 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup2 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonLabel1 = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonLabel2 = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator3 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.backColorEditor = New ControlHostLib.ColorEditorHost()
        Me.foreColorEditor = New ControlHostLib.ColorEditorHost()
        Me.RibbonGroup6 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.fontEditor = New ControlHostLib.FontEditorHost()
        Me.RibbonTab3 = New C1.Win.C1Ribbon.RibbonTab()
        Me.RibbonGroup3 = New C1.Win.C1Ribbon.RibbonGroup()
        Me.axWebBrowserHost1 = New ControlHostLib.AxWebBrowserHost()
        Me.RibbonTopToolBar1 = New C1.Win.C1Ribbon.RibbonTopToolBar()
        Me.C1StatusBar1 = New C1.Win.C1Ribbon.C1StatusBar()
        Me.statusLabel = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.checkStatusLabel = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbLoad = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbSave = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbClear = New C1.Win.C1Ribbon.RibbonButton()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Ribbon1
        '
        Me.C1Ribbon1.AllowMinimize = False
        Me.C1Ribbon1.ApplicationMenuHolder = Me.RibbonApplicationMenu1
        Me.C1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.C1Ribbon1.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.C1Ribbon1.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.C1Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.C1Ribbon1.Name = "C1Ribbon1"
        Me.C1Ribbon1.QatHolder = Me.RibbonQat1
        Me.C1Ribbon1.Size = New System.Drawing.Size(472, 155)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.C1Ribbon1.Tabs.Add(Me.RibbonTab3)
        Me.C1Ribbon1.TopToolBarHolder = Me.RibbonTopToolBar1
        '
        'RibbonApplicationMenu1
        '
        Me.RibbonApplicationMenu1.BottomPaneItems.Add(Me.exitButton)
        Me.RibbonApplicationMenu1.DropDownWidth = 60
        Me.RibbonApplicationMenu1.LargeImage = CType(resources.GetObject("RibbonApplicationMenu1.LargeImage"), System.Drawing.Image)
        Me.RibbonApplicationMenu1.Name = "RibbonApplicationMenu1"
        '
        'exitButton
        '
        Me.exitButton.Name = "exitButton"
        Me.exitButton.SmallImage = CType(resources.GetObject("exitButton.SmallImage"), System.Drawing.Image)
        Me.exitButton.Text = "Exit"
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
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup4)
        Me.RibbonTab1.Groups.Add(Me.RibbonGroup5)
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Simple Controls"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Items.Add(Me.pictureBoxHost1)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Text = "PictureBox"
        '
        'pictureBoxHost1
        '
        Me.pictureBoxHost1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBoxHost1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pictureBoxHost1.Image = Global.ControlHost.My.Resources.Resources._1403_Globe
        Me.pictureBoxHost1.Name = "pictureBoxHost1"
        Me.pictureBoxHost1.Width = 50
        '
        'RibbonGroup4
        '
        Me.RibbonGroup4.Items.Add(Me.numericUpDownHost1)
        Me.RibbonGroup4.Name = "RibbonGroup4"
        Me.RibbonGroup4.Text = "NumericUpDown"
        '
        'numericUpDownHost1
        '
        Me.numericUpDownHost1.BackColor = System.Drawing.SystemColors.Window
        Me.numericUpDownHost1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.numericUpDownHost1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.numericUpDownHost1.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numericUpDownHost1.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
        Me.numericUpDownHost1.Minimum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.numericUpDownHost1.Name = "numericUpDownHost1"
        Me.numericUpDownHost1.Value = New Decimal(New Integer() {12, 0, 0, 0})
        Me.numericUpDownHost1.Width = 100
        '
        'RibbonGroup5
        '
        Me.RibbonGroup5.Items.Add(Me.checkedListBoxHost1)
        Me.RibbonGroup5.Name = "RibbonGroup5"
        Me.RibbonGroup5.Text = "CheckedListBox"
        '
        'checkedListBoxHost1
        '
        Me.checkedListBoxHost1.BackColor = System.Drawing.SystemColors.Window
        Me.checkedListBoxHost1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.checkedListBoxHost1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.checkedListBoxHost1.Items.AddRange(New Object() {"Apple", "Bananas", "Bilberry", "Cherries", "Gooseberry", "Grape", "Peach", "Strawberry"})
        Me.checkedListBoxHost1.Name = "checkedListBoxHost1"
        Me.checkedListBoxHost1.Width = 140
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Groups.Add(Me.RibbonGroup2)
        Me.RibbonTab2.Groups.Add(Me.RibbonGroup6)
        Me.RibbonTab2.Name = "RibbonTab2"
        Me.RibbonTab2.Text = "Items Based on UITypeEditor"
        '
        'RibbonGroup2
        '
        Me.RibbonGroup2.Items.Add(Me.RibbonLabel1)
        Me.RibbonGroup2.Items.Add(Me.RibbonLabel2)
        Me.RibbonGroup2.Items.Add(Me.RibbonSeparator3)
        Me.RibbonGroup2.Items.Add(Me.backColorEditor)
        Me.RibbonGroup2.Items.Add(Me.foreColorEditor)
        Me.RibbonGroup2.Name = "RibbonGroup2"
        Me.RibbonGroup2.Text = "Color Editors"
        '
        'RibbonLabel1
        '
        Me.RibbonLabel1.Name = "RibbonLabel1"
        Me.RibbonLabel1.Text = "BackColor:"
        '
        'RibbonLabel2
        '
        Me.RibbonLabel2.Name = "RibbonLabel2"
        Me.RibbonLabel2.Text = "ForeColor:"
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.HiddenMode = True
        Me.RibbonSeparator3.Name = "RibbonSeparator3"
        '
        'backColorEditor
        '
        Me.backColorEditor.BackColor = System.Drawing.SystemColors.Window
        Me.backColorEditor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.backColorEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.backColorEditor.Name = "backColorEditor"
        Me.backColorEditor.Width = 110
        '
        'foreColorEditor
        '
        Me.foreColorEditor.BackColor = System.Drawing.SystemColors.Window
        Me.foreColorEditor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.foreColorEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.foreColorEditor.Name = "foreColorEditor"
        Me.foreColorEditor.Width = 110
        '
        'RibbonGroup6
        '
        Me.RibbonGroup6.Items.Add(Me.fontEditor)
        Me.RibbonGroup6.Name = "RibbonGroup6"
        Me.RibbonGroup6.Text = "Font Editor"
        '
        'fontEditor
        '
        Me.fontEditor.BackColor = System.Drawing.SystemColors.Window
        Me.fontEditor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.fontEditor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fontEditor.Name = "fontEditor"
        Me.fontEditor.Width = 240
        '
        'RibbonTab3
        '
        Me.RibbonTab3.Groups.Add(Me.RibbonGroup3)
        Me.RibbonTab3.Name = "RibbonTab3"
        Me.RibbonTab3.Text = "ActiveX Element"
        '
        'RibbonGroup3
        '
        Me.RibbonGroup3.Items.Add(Me.axWebBrowserHost1)
        Me.RibbonGroup3.Name = "RibbonGroup3"
        Me.RibbonGroup3.Text = "ActiveX Web Browser"
        '
        'axWebBrowserHost1
        '
        Me.axWebBrowserHost1.BackColor = System.Drawing.SystemColors.Control
        Me.axWebBrowserHost1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.axWebBrowserHost1.Height = 70
        Me.axWebBrowserHost1.Name = "axWebBrowserHost1"
        Me.axWebBrowserHost1.Width = 440
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'C1StatusBar1
        '
        Me.C1StatusBar1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.C1StatusBar1.LeftPaneItems.Add(Me.statusLabel)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.RibbonSeparator1)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.checkStatusLabel)
        Me.C1StatusBar1.LeftPaneItems.Add(Me.RibbonSeparator2)
        Me.C1StatusBar1.Location = New System.Drawing.Point(0, 310)
        Me.C1StatusBar1.Name = "C1StatusBar1"
        Me.C1StatusBar1.RightPaneItems.Add(Me.rbLoad)
        Me.C1StatusBar1.RightPaneItems.Add(Me.rbSave)
        Me.C1StatusBar1.RightPaneItems.Add(Me.rbClear)
        Me.C1StatusBar1.Size = New System.Drawing.Size(472, 23)
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Text = "Status"
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'checkStatusLabel
        '
        Me.checkStatusLabel.Name = "checkStatusLabel"
        Me.checkStatusLabel.Text = "Checked: <none>"
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.Name = "RibbonSeparator2"
        '
        'rbLoad
        '
        Me.rbLoad.Name = "rbLoad"
        Me.rbLoad.SmallImage = CType(resources.GetObject("rbLoad.SmallImage"), System.Drawing.Image)
        Me.rbLoad.Text = "Load"
        '
        'rbSave
        '
        Me.rbSave.Name = "rbSave"
        Me.rbSave.SmallImage = CType(resources.GetObject("rbSave.SmallImage"), System.Drawing.Image)
        Me.rbSave.Text = "Save"
        '
        'rbClear
        '
        Me.rbClear.Name = "rbClear"
        Me.rbClear.SmallImage = CType(resources.GetObject("rbClear.SmallImage"), System.Drawing.Image)
        Me.rbClear.Text = "Clear"
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(20, 174)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(430, 124)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Demo"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DemoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 333)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.C1StatusBar1)
        Me.Controls.Add(Me.C1Ribbon1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name = "DemoForm"
        Me.Text = "Control Host Demo"
        CType(Me.C1Ribbon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1Ribbon1 As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents C1StatusBar1 As C1.Win.C1Ribbon.C1StatusBar
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents RibbonApplicationMenu1 As C1.Win.C1Ribbon.RibbonApplicationMenu
    Private WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Private WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Private WithEvents RibbonTab1 As C1.Win.C1Ribbon.RibbonTab
    Private WithEvents RibbonGroup1 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents statusLabel As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Private WithEvents checkStatusLabel As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Private WithEvents RibbonTab2 As C1.Win.C1Ribbon.RibbonTab
    Private WithEvents RibbonGroup2 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents RibbonTab3 As C1.Win.C1Ribbon.RibbonTab
    Private WithEvents RibbonGroup3 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents RibbonGroup4 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents RibbonGroup5 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents RibbonGroup6 As C1.Win.C1Ribbon.RibbonGroup
    Private WithEvents pictureBoxHost1 As ControlHostLib.PictureBoxHost
    Private WithEvents numericUpDownHost1 As ControlHostLib.NumericUpDownHost
    Private WithEvents checkedListBoxHost1 As ControlHostLib.CheckedListBoxHost
    Private WithEvents RibbonLabel1 As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonLabel2 As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonSeparator3 As C1.Win.C1Ribbon.RibbonSeparator
    Private WithEvents backColorEditor As ControlHostLib.ColorEditorHost
    Private WithEvents foreColorEditor As ControlHostLib.ColorEditorHost
    Private WithEvents fontEditor As ControlHostLib.FontEditorHost
    Private WithEvents axWebBrowserHost1 As ControlHostLib.AxWebBrowserHost
    Private WithEvents exitButton As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents RibbonBottomToolBar1 As C1.Win.C1Ribbon.RibbonBottomToolBar
    Private WithEvents RibbonTopToolBar1 As C1.Win.C1Ribbon.RibbonTopToolBar
    Private WithEvents rbLoad As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rbSave As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rbClear As C1.Win.C1Ribbon.RibbonButton
End Class
