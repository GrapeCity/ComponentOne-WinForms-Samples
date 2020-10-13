Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1TreeView1.AllowDrop = True
        C1TreeView1.EnableDragDrop = True

        For i As Integer = 0 To 5
            C1TreeView1.Nodes.Add("Node" + i.ToString())
            For j As Integer = 0 To 5
                C1TreeView1.Nodes(i).Nodes.Add("Node" + (i * 10 + j).ToString())
            Next
        Next
    End Sub
End Class
