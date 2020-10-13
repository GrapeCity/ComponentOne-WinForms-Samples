Imports System
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Collections
Imports System.ComponentModel
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
    Friend WithEvents _flexLeft As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents _flexRight As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flexLeft = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me._flexRight = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flexLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._flexRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flexLeft
        '
        Me._flexLeft.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexLeft.Location = New System.Drawing.Point(7, 8)
        Me._flexLeft.Name = "_flexLeft"
        Me._flexLeft.Size = New System.Drawing.Size(329, 242)
        Me._flexLeft.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flexLeft.TabIndex = 0
        '
        '_flexRight
        '
        Me._flexRight.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flexRight.Location = New System.Drawing.Point(343, 8)
        Me._flexRight.Name = "_flexRight"
        Me._flexRight.Size = New System.Drawing.Size(329, 242)
        Me._flexRight.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flexRight.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(677, 257)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flexRight, Me._flexLeft})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Drag and Drop Rows between grids"
        CType(Me._flexLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._flexRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'populate grids
        _flexLeft.Rows.Count = 5
        Dim r As Integer
        For r = 1 To _flexLeft.Rows.Count - 1
            _flexLeft(r, 0) = "Left"
            _flexLeft(r, 1) = r
        Next
        _flexRight.Rows.Count = 5

        For r = 1 To _flexRight.Rows.Count - 1
            _flexRight(r, 0) = "Right"
            _flexRight(r, 1) = r
        Next

        'both are OLE drag sources
        With _flexLeft
            .DragMode = DragModeEnum.Manual
            .DropMode = DropModeEnum.Manual
        End With
        'both are drop targets 
        With _flexRight
            .DragMode = DragModeEnum.Manual
            .DropMode = DropModeEnum.Manual
        End With
    End Sub

    Dim _src As C1FlexGrid = Nothing

    Private Sub _flex_BeforeMouseDown(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.BeforeMouseDownEventArgs) Handles _flexLeft.BeforeMouseDown, _flexRight.BeforeMouseDown
        'start dragging when the user clicks the row headers
        Dim flex As C1FlexGrid = CType(sender, C1FlexGrid)
        Dim hti As HitTestInfo = flex.HitTest(e.X, e.Y)

        If hti.Type = HitTestTypeEnum.RowHeader Then
            'select the row 
            Dim index As Integer = hti.Row
            flex.Select(index, 0, index, flex.Cols.Count - 1, False)

            'save info for target
            _src = flex

            'do drag drop
            Dim dd As DragDropEffects = flex.DoDragDrop(flex.Clip, DragDropEffects.Move)

            'if it worked, delete row from source (it's a move) 
            If dd = DragDropEffects.Move Then
                flex.Rows.Remove(index)
            End If

            'done, reset info
            _src = Nothing
        End If
    End Sub

    Private Sub _flex_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flexLeft.DragOver, _flexRight.DragOver
        'check whether we can drop here:

        'we must have a source object, and it should be the other grid
        '(this sample allows dragging from one to the other grid only)
        If Not _src Is Nothing AndAlso Not _src.Equals(sender) Then
            'check that we have the type of data we want
            If e.Data.GetDataPresent(GetType(String)) Then
                e.Effect = DragDropEffects.Move
            End If
        End If

    End Sub

    Private Sub _flex_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flexLeft.DragDrop, _flexRight.DragDrop
        'find the drop position
        Dim flex As C1FlexGrid = CType(sender, C1FlexGrid)
        Dim pt As Point = flex.PointToClient(New Point(e.X, e.Y))
        Dim hti As HitTestInfo = flex.HitTest(pt.X, pt.Y)
        Dim index As Integer = hti.Row

        If index < 0 Then index = flex.Rows.Count 'append
        If index < 1 Then index = 1 'after fixed row

        'insert a new row at the drop position
        flex.Rows.Insert(index)

        'copy data from source row
        flex.Select(index, 0, index, flex.Cols.Count - 1, False)
        flex.Clip = CType(e.Data.GetData(GetType(String)), String)

    End Sub
End Class
