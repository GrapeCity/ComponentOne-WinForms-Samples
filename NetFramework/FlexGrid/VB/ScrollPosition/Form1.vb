Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

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
    'It can be modified imports the Windows Form Designer.  
    'Do not modify it imports the code editor.
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents button1 As System.Windows.Forms.Button
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents _flex As C1.Win.FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(0, 23)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(95, 15)
        Me.label1.TabIndex = 6
        Me.label1.Text = "Scroll to Row:"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(224, 23)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(52, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "&go"
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(104, 23)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(117, 20)
        Me.textBox1.TabIndex = 4
        Me.textBox1.Text = "12"
        '
        '_flex
        '
        Me._flex.AllowFreezing = C1.Win.FlexGrid.AllowFreezingEnum.Rows
        Me._flex.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both
        Me._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.ExtendLastCol = True
        Me._flex.Location = New System.Drawing.Point(8, 56)
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(520, 424)
        Me._flex.Styles = New C1.Win.FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(555, 492)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.label1, Me.button1, Me.textBox1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: ScrollPosition"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _flex.Rows.DefaultSize = 20
        Dim i As Integer
        For i = 1 To _flex.Rows.Count - 1
            _flex(0, 1) = i
            _flex(i, 1) = _flex.Rows(i).Top

        Next
    End Sub

    Private Sub _flex_AfterScroll(ByVal sender As System.Object, ByVal e As C1.Win.FlexGrid.RangeEventArgs)
        Console.WriteLine("ScrollPosition.Y = {0}", _flex.ScrollPosition.Y)
    End Sub


    Private Sub _flex_AfterResizeRow(ByVal sender As System.Object, ByVal e As C1.Win.FlexGrid.RowColEventArgs)
        Dim i As Integer
        For i = 1 To _flex.Rows.Count - 1
            _flex(i, 1) = _flex.Rows(i).Top
        Next
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Dim x As Exception
        Try
            Dim topRow As Integer = Integer.Parse(textBox1.Text)
            Dim fixRow As Integer = _flex.Rows.Fixed + _flex.Rows.Frozen
            Dim y As Integer = _flex.Rows(topRow).Top - _flex.Rows(fixRow).Top
            _flex.ScrollPosition = New Point(0, -y)
        Catch x 'invalid input
            MessageBox.Show(x.Message)
        End Try
    End Sub
End Class
