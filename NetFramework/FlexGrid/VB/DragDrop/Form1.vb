Imports System
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Collections


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
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.DragMode = C1.Win.FlexGrid.DragModeEnum.Automatic
        Me._flex.DropMode = C1.Win.FlexGrid.DropModeEnum.Automatic
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(384, 253)
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
        Me.ClientSize = New System.Drawing.Size(384, 253)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Customized Drag Drop"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'data is being dragged over the grid for the first time
    '
    'Customization #1 :
    'handle this to make sure only numbers can be dropped.
    '(anything can be dragged, perhaps to drop into another app).
    '
    Private _validData As Boolean

    Private Sub _flex_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flex.DragEnter
        'get the data
        Dim str As String = CType(e.Data.GetData(GetType(String)), String)

        'no empty data
        If str Is Nothing OrElse str.Length = 0 Then
            _validData = False
            Return
        End If

        'check for numbers
        If Not str Is Nothing Then
            Dim d As Double
            Dim cells As String() = str.Split(ControlChars.Tab, vbLf, vbCr)
            Dim cell As String
            For Each cell In cells
                'not a number? bail
                If cell.Length > 0 AndAlso Not Double.TryParse(cell, Globalization.NumberStyles.Any, Nothing, d) Then
                    _validData = False
                    Return
                End If

            Next
        End If

        'data is valid
        Console.WriteLine("good data")
        _validData = True
    End Sub

    'data is being dragged over the grid
    '
    'Customization #2:
    'only allow copying (not moving)
    '

    Private Sub _flex_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flex.DragOver
        If _validData Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    'data is being dragged over the grid for the last time

    Private Sub _flex_DragLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles _flex.DragLeave
        Console.WriteLine("_flex_DragLeave")
    End Sub

    'some data was dropped on the grid
    Private Sub _flex_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flex.DragDrop
        Console.WriteLine("_flex_DragDrop")
    End Sub
End Class
