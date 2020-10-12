Imports C1.Win.TreeView

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1TreeView1.AllowDrop = True
        C1TreeView2.AllowDrop = True

        For i As Integer = 0 To 5
            C1TreeView1.Nodes.Add("Node" + i.ToString())
            C1TreeView2.Nodes.Add("Node" + (i * 100).ToString())
            For j As Integer = 0 To 5
                C1TreeView1.Nodes(i).Nodes.Add("Node" + (i * 10 + j).ToString())
                C1TreeView2.Nodes(i).Nodes.Add("Node" + (i * 100 + j).ToString())
            Next
        Next
    End Sub

    Private Sub C1TreeView_DragDrop(sender As Object, e As DragEventArgs) Handles C1TreeView1.DragDrop, C1TreeView2.DragDrop
        Dim TreeView = CType(sender, C1TreeView)
        Dim p = TreeView.PointToClient(New Point(e.X, e.Y))
        Dim currentNode = TreeView.GetNodeAtPoint(p)

        Dim distanceNodes = CType(e.Data.GetData(GetType(C1TreeNode())), C1TreeNode())
        Dim distanceNode = distanceNodes(0)
        Dim pos = CType(e.Data.GetData(GetType(DragDropPosition)), DragDropPosition)
        If (currentNode IsNot Nothing) Then
            Dim Index = currentNode.ParentCollection.IndexOf(currentNode)
            distanceNode.ParentCollection.Remove(distanceNode)
            Select Case pos
                Case DragDropPosition.After
                    currentNode.ParentCollection.Insert(Index + 1, distanceNode)
                Case DragDropPosition.Before
                    currentNode.ParentCollection.Insert(Index, distanceNode)
                Case DragDropPosition.Inner
                    currentNode.Nodes.Add(distanceNode)
            End Select
        Else
            distanceNode.ParentCollection.Remove(distanceNode)
            TreeView.Nodes.Add(distanceNode)
        End If
    End Sub

    Private Sub C1TreeView_DragEnter(sender As Object, e As DragEventArgs) Handles C1TreeView1.DragEnter, C1TreeView2.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub C1TreeView_ItemDrag(sender As Object, e As C1.Win.TreeView.C1TreeViewItemDragEventArgs) Handles C1TreeView1.ItemDrag, C1TreeView2.ItemDrag
        DoDragDrop(e.DraggedData, DragDropEffects.Move)
    End Sub
End Class
