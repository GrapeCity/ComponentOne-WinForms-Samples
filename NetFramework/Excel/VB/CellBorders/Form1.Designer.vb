<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.imgToolbar = New System.Windows.Forms.ImageList(Me.components)
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ToolBar2 = New System.Windows.Forms.ToolBar()
        Me.tbBorderOn = New System.Windows.Forms.ToolBarButton()
        Me.tbBorderOff = New System.Windows.Forms.ToolBarButton()
        Me.tbSep1 = New System.Windows.Forms.ToolBarButton()
        Me.tbBorderColor = New System.Windows.Forms.ToolBarButton()
        Me.tbSep2 = New System.Windows.Forms.ToolBarButton()
        Me.tbIncreaseOut = New System.Windows.Forms.ToolBarButton()
        Me.tbDecreaseOut = New System.Windows.Forms.ToolBarButton()
        Me.tbIncreaseIn = New System.Windows.Forms.ToolBarButton()
        Me.tbDecreaseIn = New System.Windows.Forms.ToolBarButton()
        Me.tbSep3 = New System.Windows.Forms.ToolBarButton()
        Me.tbExcel = New System.Windows.Forms.ToolBarButton()
        Me._c1xl = New C1.Excel.C1XLBook()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgToolbar
        '
        Me.imgToolbar.ImageStream = CType(resources.GetObject("imgToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgToolbar.TransparentColor = System.Drawing.Color.White
        Me.imgToolbar.Images.SetKeyName(0, "")
        Me.imgToolbar.Images.SetKeyName(1, "")
        Me.imgToolbar.Images.SetKeyName(2, "")
        Me.imgToolbar.Images.SetKeyName(3, "")
        Me.imgToolbar.Images.SetKeyName(4, "")
        Me.imgToolbar.Images.SetKeyName(5, "")
        Me.imgToolbar.Images.SetKeyName(6, "")
        Me.imgToolbar.Images.SetKeyName(7, "")
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:27;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me._flex.Location = New System.Drawing.Point(0, 28)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(557, 353)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        Me._flex.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me._flex.Tree.NodeImageCollapsed = CType(resources.GetObject("_flex.Tree.NodeImageCollapsed"), System.Drawing.Image)
        Me._flex.Tree.NodeImageExpanded = CType(resources.GetObject("_flex.Tree.NodeImageExpanded"), System.Drawing.Image)
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbBorderOn, Me.tbBorderOff, Me.tbSep1, Me.tbBorderColor, Me.tbSep2, Me.tbIncreaseOut, Me.tbDecreaseOut, Me.tbIncreaseIn, Me.tbDecreaseIn, Me.tbSep3, Me.tbExcel})
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.ImageList = Me.imgToolbar
        Me.ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(557, 28)
        Me.ToolBar2.TabIndex = 5
        '
        'tbBorderOn
        '
        Me.tbBorderOn.ImageIndex = 0
        Me.tbBorderOn.Name = "tbBorderOn"
        Me.tbBorderOn.ToolTipText = "Apply Border"
        '
        'tbBorderOff
        '
        Me.tbBorderOff.ImageIndex = 1
        Me.tbBorderOff.Name = "tbBorderOff"
        Me.tbBorderOff.ToolTipText = "Remove Border"
        '
        'tbSep1
        '
        Me.tbSep1.Name = "tbSep1"
        Me.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbBorderColor
        '
        Me.tbBorderColor.ImageIndex = 2
        Me.tbBorderColor.Name = "tbBorderColor"
        Me.tbBorderColor.ToolTipText = "Select Border Color"
        '
        'tbSep2
        '
        Me.tbSep2.Name = "tbSep2"
        Me.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbIncreaseOut
        '
        Me.tbIncreaseOut.ImageIndex = 3
        Me.tbIncreaseOut.Name = "tbIncreaseOut"
        Me.tbIncreaseOut.ToolTipText = "Thicker outer border"
        '
        'tbDecreaseOut
        '
        Me.tbDecreaseOut.ImageIndex = 4
        Me.tbDecreaseOut.Name = "tbDecreaseOut"
        Me.tbDecreaseOut.ToolTipText = "Thinner outer border"
        '
        'tbIncreaseIn
        '
        Me.tbIncreaseIn.ImageIndex = 5
        Me.tbIncreaseIn.Name = "tbIncreaseIn"
        Me.tbIncreaseIn.ToolTipText = "Thicker inner border"
        '
        'tbDecreaseIn
        '
        Me.tbDecreaseIn.ImageIndex = 6
        Me.tbDecreaseIn.Name = "tbDecreaseIn"
        Me.tbDecreaseIn.ToolTipText = "Thinner inner border"
        '
        'tbSep3
        '
        Me.tbSep3.Name = "tbSep3"
        Me.tbSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbExcel
        '
        Me.tbExcel.ImageIndex = 7
        Me.tbExcel.Name = "tbExcel"
        Me.tbExcel.ToolTipText = "Save Excel File"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(557, 381)
        Me.Controls.Add(Me._flex)
        Me.Controls.Add(Me.ToolBar2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Excel: Custom cell borders"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents imgToolbar As System.Windows.Forms.ImageList
    Private WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Private WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Private WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Private WithEvents _c1xl As C1.Excel.C1XLBook
    Private WithEvents tbBorderOn As System.Windows.Forms.ToolBarButton
    Private WithEvents tbBorderOff As System.Windows.Forms.ToolBarButton
    Private WithEvents tbSep1 As System.Windows.Forms.ToolBarButton
    Private WithEvents tbBorderColor As System.Windows.Forms.ToolBarButton
    Private WithEvents tbSep2 As System.Windows.Forms.ToolBarButton
    Private WithEvents tbIncreaseOut As System.Windows.Forms.ToolBarButton
    Private WithEvents tbDecreaseOut As System.Windows.Forms.ToolBarButton
    Private WithEvents tbIncreaseIn As System.Windows.Forms.ToolBarButton
    Private WithEvents tbDecreaseIn As System.Windows.Forms.ToolBarButton
    Private WithEvents tbSep3 As System.Windows.Forms.ToolBarButton
    Private WithEvents tbExcel As System.Windows.Forms.ToolBarButton

End Class
