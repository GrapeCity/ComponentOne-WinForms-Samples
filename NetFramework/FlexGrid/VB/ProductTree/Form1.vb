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
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(480, 285)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 285)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Product Tree"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' set up the flex control
        _flex.Tree.Column = 1
        _flex.Rows.Count = 1
        _flex.Cols.Count = 4
        _flex.Cols(1).Caption = "Code"
        _flex.Cols(2).Caption = "Name"
        _flex.Cols(3).Caption = "Price"
        _flex.Cols(3).DataType = GetType(Decimal)

        ' populate the control with product structure
        Dim row As Integer, level As Integer
        For row = 1 To 1000
            _flex.Rows.InsertNode(row, level)
            _flex(row, 1) = "P" + row.ToString()
            _flex(row, 2) = "Product " + level.ToString() + "." + row.ToString()

            If level = 0 Then
                level = 1
            Else
                If Rnd() > 0.5 Then level = level + 1
                If Rnd() > 0.5 Then level = level - 1
            End If
            If level < 0 Or level > 5 Then level = 0
        Next

        ' calculate product prices
        For row = 1 To 1000
            _flex(row, 3) = GetPrice(row)
        Next

        ' and size the grid
        _flex.AutoSizeCols()
    End Sub

    Private Function GetPrice(ByVal row As Integer) As Decimal
        Dim price As Decimal = 0

        ' if the product has children, 
        ' scan them and add their prices
        Dim nd As Node = _flex.Rows(row).Node
        If nd.Children > 0 Then
            nd = nd.GetNode(NodeTypeEnum.FirstChild)
            While Not (nd Is Nothing)
                price = price + GetPrice(nd.Row.Index)
                nd = nd.GetNode(NodeTypeEnum.NextSibling)
            End While
            GetPrice = price
            Exit Function
        End If

        ' no children, charge $50
        GetPrice = 50
    End Function

End Class
