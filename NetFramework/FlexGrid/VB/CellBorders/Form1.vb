Imports System
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.FlexGrid

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tbBorderOff As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbBorderOn As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbIncreaseIn As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbDecreaseOut As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents imgToolbar As System.Windows.Forms.ImageList
    Friend WithEvents tbIncreaseOut As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbBorderColor As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbDecreaseIn As System.Windows.Forms.ToolBarButton
    Friend WithEvents toolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.tbBorderOff = New System.Windows.Forms.ToolBarButton()
        Me.tbBorderOn = New System.Windows.Forms.ToolBarButton()
        Me.tbIncreaseIn = New System.Windows.Forms.ToolBarButton()
        Me.tbDecreaseOut = New System.Windows.Forms.ToolBarButton()
        Me.tbSep1 = New System.Windows.Forms.ToolBarButton()
        Me.imgToolbar = New System.Windows.Forms.ImageList(Me.components)
        Me.tbIncreaseOut = New System.Windows.Forms.ToolBarButton()
        Me.tbSep2 = New System.Windows.Forms.ToolBarButton()
        Me.tbBorderColor = New System.Windows.Forms.ToolBarButton()
        Me.tbDecreaseIn = New System.Windows.Forms.ToolBarButton()
        Me.toolBar1 = New System.Windows.Forms.ToolBar()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbBorderOff
        '
        Me.tbBorderOff.ImageIndex = 1
        Me.tbBorderOff.ToolTipText = "Remove Border"
        '
        'tbBorderOn
        '
        Me.tbBorderOn.ImageIndex = 0
        Me.tbBorderOn.ToolTipText = "Apply Border"
        '
        'tbIncreaseIn
        '
        Me.tbIncreaseIn.ImageIndex = 5
        Me.tbIncreaseIn.ToolTipText = "Thicker inner border"
        '
        'tbDecreaseOut
        '
        Me.tbDecreaseOut.ImageIndex = 4
        Me.tbDecreaseOut.ToolTipText = "Thinner outer border"
        '
        'tbSep1
        '
        Me.tbSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'imgToolbar
        '
        Me.imgToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.imgToolbar.ImageSize = New System.Drawing.Size(16, 16)
        Me.imgToolbar.ImageStream = CType(resources.GetObject("imgToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgToolbar.TransparentColor = System.Drawing.Color.White
        '
        'tbIncreaseOut
        '
        Me.tbIncreaseOut.ImageIndex = 3
        Me.tbIncreaseOut.ToolTipText = "Thicker outer border"
        '
        'tbSep2
        '
        Me.tbSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbBorderColor
        '
        Me.tbBorderColor.ImageIndex = 2
        Me.tbBorderColor.ToolTipText = "Select Border Color"
        '
        'tbDecreaseIn
        '
        Me.tbDecreaseIn.ImageIndex = 6
        Me.tbDecreaseIn.ToolTipText = "Thinner inner border"
        '
        'toolBar1
        '
        Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbBorderOn, Me.tbBorderOff, Me.tbSep1, Me.tbBorderColor, Me.tbSep2, Me.tbIncreaseOut, Me.tbDecreaseOut, Me.tbIncreaseIn, Me.tbDecreaseIn})
        Me.toolBar1.DropDownArrows = True
        Me.toolBar1.ImageList = Me.imgToolbar
        Me.toolBar1.Name = "toolBar1"
        Me.toolBar1.ShowToolTips = True
        Me.toolBar1.Size = New System.Drawing.Size(569, 25)
        Me.toolBar1.TabIndex = 3
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 25)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(569, 338)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(569, 363)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.toolBar1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Custom cell borders"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _bdrBrush As SolidBrush
    Private _bdrOutside As Integer
    Private _bdrInside As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'create border style
        Dim s As CellStyle = _flex.Styles.Add("Border")
        _bdrBrush = New SolidBrush(Color.Red)
        _bdrOutside = 3
        _bdrInside = 1

        'enable ownerdraw
        _flex.DrawMode = DrawModeEnum.OwnerDraw
    End Sub

    'custom drawing for cells with custom borders
    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell

        'we only want cells with style set to "Border"
        Dim s As CellStyle = _flex.GetCellStyle(e.Row, e.Col)
        If (s Is Nothing OrElse s.Name <> "Border") Then
            Return
        End If

        'draw cell content as usual 
        e.DrawCell()

        'get custom border widths for this cell
        '(depends on neighbor cells)
        Dim m As Margins = GetBorderMargins(e.Row, e.Col)

        'draw custom borders
        Dim rc As Rectangle
        Dim g As Graphics = e.Graphics
        If m.Top > 0 Then
            rc = e.Bounds
            rc.Height = m.Top
            g.FillRectangle(_bdrBrush, rc)
        End If

        If m.Left > 0 Then
            rc = e.Bounds
            rc.Width = m.Left
            g.FillRectangle(_bdrBrush, rc)
        End If

        If m.Bottom > 0 Then
            rc = e.Bounds
            rc.Y = rc.Bottom - m.Bottom
            rc.Height = m.Bottom
            g.FillRectangle(_bdrBrush, rc)
        End If

        If m.Right > 0 Then
            rc = e.Bounds
            rc.X = rc.Right - m.Right
            rc.Width = m.Right
            g.FillRectangle(_bdrBrush, rc)
        End If
    End Sub

    'calculate border widths taking neighbor cells into account
    Dim _m As Margins = New Margins(0, 0, 0, 0)

    Private Function GetBorderMargins(ByVal row As Integer, ByVal col As Integer) As Margins

        'initialize return value
        _m.Left = 0
        _m.Right = 0
        _m.Top = 0
        _m.Bottom = 0

        'check whether this cell has a border
        Dim rg As CellRange = _flex.GetCellRange(row, col)
        If rg.Style Is Nothing Or rg.Style.Name <> "Border" Then
            Return _m
        End If

        'check whether this cell is at the top of the range
        _m.Top = _bdrOutside
        If row > _flex.Rows.Fixed Then
            rg.r1 = row - 1
            rg.r2 = row - 1
            If Not rg.Style Is Nothing AndAlso rg.Style.Name = "Border" Then
                _m.Top = 0
            End If
            rg.r1 = row
            rg.r2 = row
        End If

        'check whether this cell is at the left of the range
        _m.Left = _bdrOutside
        If col > _flex.Cols.Fixed Then
            rg.c1 = col - 1
            rg.c2 = col - 1
            If (Not rg.Style Is Nothing AndAlso rg.Style.Name = "Border") Then
                _m.Left = 0
            End If
            rg.c1 = col
            rg.c2 = col
        End If

        'check whether this cell is at the bottom of the range
        _m.Bottom = _bdrOutside
        If row < _flex.Rows.Count - 1 Then
            rg.r1 = row + 1
            rg.r2 = row + 1
            If (Not rg.Style Is Nothing AndAlso rg.Style.Name = "Border") Then
                _m.Bottom = _bdrInside
            End If
            rg.r1 = row
            rg.r2 = row
        End If

        'check whether this cell is at the right of the range
        _m.Right = _bdrOutside
        If col < _flex.Cols.Count - 1 Then
            rg.c1 = col + 1
            rg.c2 = col + 1
            If (Not rg.Style Is Nothing AndAlso rg.Style.Name = "Border") Then
                _m.Right = _bdrInside
            End If
            rg.c1 = col
            rg.c2 = col
        End If

        'done
        Return _m

    End Function


    Private Sub toolBar1_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick

        ' apply border to current selection
        If e.Button.Equals(tbBorderOn) Then
            Dim rg As CellRange = _flex.Selection
            rg.Style = _flex.Styles("Border")
        End If

        ' remove border from current selection
        If e.Button.Equals(tbBorderOff) Then

            'remove border style from selection
            Dim rg As CellRange = _flex.Selection
            rg.Style = Nothing

        End If

        ' change border color
        If e.Button.Equals(tbBorderColor) Then

            'show color picker dialog
            Dim dlg As ColorDialog = New ColorDialog()
            dlg.Color = _bdrBrush.Color

            'if the user clicked OK, set new border color
            If dlg.ShowDialog() = DialogResult.OK Then
                _bdrBrush.Color = dlg.Color
            End If
        End If

        ' thicker/thinner outer border
        If e.Button.Equals(tbIncreaseOut) Then
            If _bdrOutside < 10 Then _bdrOutside = _bdrOutside + 1
        End If
        If e.Button.Equals(tbDecreaseOut) Then
            If _bdrOutside > 0 Then _bdrOutside = _bdrOutside - 1
        End If

        'thinner thicker inner border
        If e.Button.Equals(tbIncreaseIn) Then
            If _bdrInside < 10 Then
                _bdrInside = _bdrInside + 1
            End If
        End If
        If e.Button.Equals(tbDecreaseIn) Then
            If _bdrInside > 0 Then _bdrInside = _bdrInside - 1

        End If

        'repaint control to show changes
        _flex.Invalidate()
    End Sub
End Class
