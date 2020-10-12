Imports System
Imports System.Data
Imports System.Drawing
Imports System.ComponentModel
Imports System.Collections
Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid

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
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents _flex2 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _flex1 As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me._flex2 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._flex1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flex1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(240, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Method 1: OwnerDraw"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(16, 192)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(240, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "Method 2: Styles"
        '
        '_flex2
        '
        Me._flex2.BackColor = System.Drawing.SystemColors.Window
        Me._flex2.ColumnInfo = "3,1,0,0,0,85,Columns:1{Name:""Length"";Caption:""Length (ft)"";DataType:System.Int64;" & _
        "Format:""#,###.00"";}" & Microsoft.VisualBasic.ChrW(9) & "2{Name:""UserDef"";Caption:""User-Defined"";DataType:System.Bool" & _
        "ean;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex2.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me._flex2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._flex2.Location = New System.Drawing.Point(16, 208)
        Me._flex2.Name = "_flex2"
        Me._flex2.Size = New System.Drawing.Size(296, 144)
        Me._flex2.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex2.TabIndex = 4
        '
        '_flex1
        '
        Me._flex1.BackColor = System.Drawing.SystemColors.Window
        Me._flex1.ColumnInfo = "3,1,0,0,0,85,Columns:1{Name:""Length"";Caption:""Length(ft)"";DataType:System.Int64;F" & _
        "ormat:""#,###.00"";}" & Microsoft.VisualBasic.ChrW(9) & "2{Name:""UserDef"";Caption:""User-Defined"";DataType:System.Boole" & _
        "an;ImageAlign:CenterCenter;}" & Microsoft.VisualBasic.ChrW(9)
        Me._flex1.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
        Me._flex1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._flex1.Location = New System.Drawing.Point(16, 24)
        Me._flex1.Name = "_flex1"
        Me._flex1.Size = New System.Drawing.Size(296, 144)
        Me._flex1.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(336, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex1, Me._flex2, Me.label1, Me.label2})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "C1FlexGrid: Dynamic cell formatting"
        CType(Me._flex2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flex1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'method1 : use OwnerDraw cells to paint one column yellow when another is checked

    Private Sub _flex1_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles _flex1.OwnerDrawCell
        'paint a yellow background depending on the value of another column
        If (_flex1.Cols(e.Col).Name = "Length" AndAlso e.Row > 0) Then
            If _flex1(e.Row, "UserDef") Then
                e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds)
                e.DrawCell(DrawCellFlags.Border Or DrawCellFlags.Content)
            End If
        End If
    End Sub

    Private Sub _flex1_CellChanged(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _flex1.CellChanged
        'invalidate row to force repaint
        If _flex1.Cols(e.Col).Name = "UserDef" Then
            _flex1.Invalidate(e.Row, 0, e.Row, _flex1.Cols.Count - 1)
        End If
    End Sub

    'method 2: use styles to accomplish the same thing
    Private Sub _flex2_CellChanged(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles _flex2.CellChanged
        If _flex2.Cols(e.Col).Name = "UserDef" AndAlso e.Row > 0 Then
            'create style if we have to 
            Dim s As CellStyle = _flex2.Styles("Yellow")
            If s Is Nothing Then
                s = _flex2.Styles.Add("Yellow")
                s.BackColor = Color.Yellow
            End If

            'apply style based on cell value
            Dim rg As CellRange = _flex2.GetCellRange(e.Row, _flex2.Cols("Length").Index)
            If _flex2(e.Row, "UserDef") Then
                rg.Style = s
            Else
                rg.Style = Nothing
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class
