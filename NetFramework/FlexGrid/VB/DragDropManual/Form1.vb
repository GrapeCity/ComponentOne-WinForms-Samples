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
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flex = New C1.Win.FlexGrid.C1FlexGrid()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(168, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 17
        Me._flex.Size = New System.Drawing.Size(416, 349)
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
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.ImageIndex = -1
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.SelectedImageIndex = -1
        Me.TreeView1.Size = New System.Drawing.Size(168, 349)
        Me.TreeView1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 349)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex, Me.TreeView1})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: OleDragDrop from TreeView and within grid"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim treNode As TreeNode
        Dim intCount As Integer
        Dim intChild As Integer

        _flex.AllowEditing = False
        _flex.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None
        _flex.DragMode = C1.Win.FlexGrid.DragModeEnum.Manual
        _flex.DropMode = C1.Win.FlexGrid.DropModeEnum.Manual

        _flex.Cols.Fixed = 0
        _flex.Rows.Fixed = 0

        For intCount = 0 To 4
            treNode = New TreeNode()
            treNode.Text = "Number" & intCount
            treNode.ImageIndex = 1
            treNode.Tag = "PR" & intCount
            TreeView1.Nodes.Add(treNode)

            For intChild = 0 To 2
                treNode = New TreeNode()
                treNode.Text = "Child of " & intCount & ", Number " & intChild
                treNode.Tag = "CH" & intCount & "*" & intChild
                TreeView1.Nodes(intCount).Nodes.Add(treNode)
            Next intChild
        Next intCount

    End Sub

    Private Sub TreeView1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles TreeView1.ItemDrag
        DoDragDrop(e.Item, DragDropEffects.Copy)
    End Sub

    Private Sub _flex_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flex.DragEnter

        If e.Data.GetDataPresent(GetType(C1.Win.FlexGrid.CellRange)) Then

            ' user dragging cell
            e.Effect = DragDropEffects.Move

        ElseIf e.Data.GetDataPresent(GetType(TreeNode)) Then

            ' user dragging tree node
            e.Effect = DragDropEffects.Copy

        End If
    End Sub

    Private Sub _flex_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles _flex.DragDrop

        ' check that the drop range is valid
        _cellDrop = Me._flex.GetCellRange(_flex.MouseRow, _flex.MouseCol)
        If _cellDrop.r1 > -1 AndAlso _cellDrop.c1 > -1 Then

            If e.Data.GetDataPresent(GetType(C1.Win.FlexGrid.CellRange)) Then

                If _cellDrop.Contains(_cellDrag.r1, _cellDrag.c1) Then

                    ' drag and drop are the same, cancel
                    e.Effect = DragDropEffects.None

                Else
                    ' user dragged cell, copy value from original cell
                    _cellDrop.Data = _cellDrag.Data
                    e.Effect = DragDropEffects.Move

                End If

            ElseIf e.Data.GetDataPresent(GetType(TreeNode)) Then

                ' user dragged treenode, copy value from tree node
                Dim node As TreeNode = CType(e.Data.GetData(GetType(TreeNode)), TreeNode)
                _cellDrop.Data = node.Tag
                e.Effect = DragDropEffects.Copy

            End If

            ' select drop cell
            _flex.Select(_cellDrop)

        End If

    End Sub

    Dim _ptDown As Point
    Dim _cellDrag As C1.Win.FlexGrid.CellRange
    Dim _cellDrop As C1.Win.FlexGrid.CellRange

    Private Sub _flex_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _flex.MouseDown
        _ptDown = New Point(e.X, e.Y)
        _cellDrag = Me._flex.GetCellRange(_flex.MouseRow, _flex.MouseCol)
    End Sub

    Private Sub _flex_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _flex.MouseMove

        ' check if we should start dragging
        If e.Button And MouseButtons.Left Then

            ' check that the mouse is over the same cell where it started
            ' and that the cell is not empty
            If _cellDrag.r1 = _flex.MouseRow AndAlso _cellDrag.c1 = _flex.MouseCol AndAlso _
                _cellDrag.r1 > -1 And _cellDrag.c1 > -1 AndAlso _
                Not (_cellDrag.Data Is Nothing) Then

                ' check that the mouse has moved past the threshold, then start dragging
                If Math.Abs(_ptDown.X - e.X) + Math.Abs(_ptDown.Y - e.Y) > 5 Then

                    ' do drag-drop operation
                    Dim data As New DataObject(_cellDrag)
                    Dim effects As DragDropEffects = _flex.DoDragDrop(data, DragDropEffects.Move)

                    ' if it was a move, clear the original value
                    If effects = DragDropEffects.Move Then
                        _cellDrag.Data = Nothing
                    End If

                End If
            End If
        End If


    End Sub
End Class
