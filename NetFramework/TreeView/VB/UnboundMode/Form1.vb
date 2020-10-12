Imports C1.Win.TreeView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1DockingTab1.SelectedIndex = 0
    End Sub

    Private Sub btnGenerateTree_Click(sender As Object, e As EventArgs) Handles btnGenereteTree.Click
        GenerateTreeView()
        ResetColumnsInCombobox()
    End Sub

    Private Sub GenerateTreeView()
        c1TreeView1.Columns.Clear()
        c1TreeView1.Nodes.Clear()

        For i = 0 To nudColumnsCount.Value - 1
            Dim column = New C1TreeColumn()
            column.HeaderText = String.Format("Column {0}", i)
            column.AutoWidth = False
            column.Width = 200
            c1TreeView1.Columns.Add(column)
        Next i

        For i = 0 To nudRootNodesCount.Value - 1
            Dim node = New C1TreeNode(String.Format("Node 0.{0}", i))
            c1TreeView1.Nodes.Add(node)
            RecGenerateNodes(node)
        Next i
    End Sub

    Private Sub RecGenerateNodes(parentNode As C1TreeNode)
        If parentNode.Level < nudLevelsCount.Value Then
            For i = 0 To nudNodesCount.Value - 1
                Dim node = New C1TreeNode(String.Format("Node {0}.{1}", parentNode.Level + 1, i))
                parentNode.Nodes.Add(node)
                RecGenerateNodes(node)
            Next i
        End If
    End Sub

    Private Sub ResetColumnsInCombobox()
        cmbSelectedColumn.Items.Clear()
        For i = 0 To c1TreeView1.Columns.Count - 1
            cmbSelectedColumn.Items.Add(String.Format("{0} {1}", i, c1TreeView1.Columns(i).HeaderText))
        Next i
        If cmbSelectedColumn.Items.Count > 0 Then
            cmbSelectedColumn.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnAddNewColumn_Click(sender As Object, e As EventArgs) Handles btnAddNewColumn.Click
        Dim addForm = New AddNewColumnForm
        If (addForm.ShowDialog() = DialogResult.OK) Then
            Dim column = New C1TreeColumn
            column.Name = addForm.ColumnName
            column.HeaderText = addForm.ColumnHeaderText
            column.DisplayFieldName = addForm.ColumnDisplayFieldName
            c1TreeView1.Columns.Add(column)
            ResetColumnsInCombobox()
        End If
    End Sub

    Private Sub btnRemoveColumn_Click(sender As Object, e As EventArgs) Handles btnRemoveColumn.Click
        Dim index = cmbSelectedColumn.SelectedIndex
        If (index > -1 And c1TreeView1.Columns.Count > index) Then
            c1TreeView1.Columns.RemoveAt(index)
            ResetColumnsInCombobox()
        End If
    End Sub

    Private Sub c1TreeView1_SelectionChanged(sender As Object, e As C1TreeViewEventArgs) Handles c1TreeView1.SelectionChanged
        pgNode.SelectedObject = e.Node
    End Sub

    Private Sub cmbSelectedColumn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelectedColumn.SelectedIndexChanged
        Dim index = cmbSelectedColumn.SelectedIndex
        If (index > -1 And c1TreeView1.Columns.Count > index) Then
            pgColumn.SelectedObject = c1TreeView1.Columns(index)
        End If
    End Sub

    Private Sub btnClearTree_Click(sender As Object, e As EventArgs) Handles btnClearTree.Click
        c1TreeView1.Columns.Clear()
        c1TreeView1.Nodes.Clear()
    End Sub

    Private Sub btnRemoveSelectedNodes_Click(sender As Object, e As EventArgs) Handles btnRemoveSelectedNodes.Click
        For Each node In c1TreeView1.SelectedNodes
            node.ParentCollection.Remove(node)
        Next
    End Sub
End Class