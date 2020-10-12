Imports C1.Win.TreeView
''' <summary>
''' The service of search a node by the value. 
''' </summary>
Public Class AutoSearchService
    Private _tree As C1TreeView
    Private _goal As C1TreeNode
    ''' <summary>
    ''' The service of search a node by the value. 
    ''' </summary>
    ''' <param name="tree"></param>
    Public Sub New(tree As C1TreeView)
        _tree = tree
        DFS = True
        ComparisonType = ComparisonType.StartsWith
    End Sub
    ''' <summary>
    ''' String comparison type.
    ''' </summary>
    Public Property ComparisonType() As ComparisonType
        Get
            Return m_ComparisonType
        End Get
        Set
            m_ComparisonType = Value
        End Set
    End Property
    Private m_ComparisonType As ComparisonType
    ''' <summary>
    ''' Search Type: true - Depth-first search, false - breadth-first search
    ''' </summary>
    Public Property DFS() As Boolean
        Get
            Return m_DFS
        End Get
        Set
            m_DFS = Value
        End Set
    End Property
    Private m_DFS As Boolean
    ''' <summary>
    ''' Search for the node containing the specified string.
    ''' </summary>
    ''' <param name="value">search string.</param>
    ''' <param name="columnIndex">Node column index.</param>
    ''' <returns>Node is found.</returns>
    Public Function Search(value As String, Optional columnIndex As Integer = 0) As Boolean
        _goal = Nothing

        If DFS Then
            DfsSearch(_tree.Nodes, value, columnIndex)
        Else
            BfsSearch(_tree.Nodes, value, columnIndex)
        End If

        _tree.CollapseAll()
        If _goal IsNot Nothing Then
            Dim parentColl = _goal.ParentCollection
            While parentColl.Parent IsNot Nothing
                parentColl.Parent.Expand()
                parentColl = parentColl.Parent.ParentCollection
            End While
            _goal.Selected = True
        End If

        Return _goal IsNot Nothing
    End Function

    Private Sub DfsSearch(nodes As C1TreeNodeCollection, value As String, columnIndex As Integer)
        For Each node As C1TreeNode In nodes
            If _goal IsNot Nothing Then
                Return
            End If
            If IsEquals(node.GetValue(columnIndex).ToString(), value) Then
                _goal = node
                Return
            End If
            DfsSearch(node.Nodes, value, columnIndex)
        Next
    End Sub

    Private Sub BfsSearch(nodes As C1TreeNodeCollection, value As String, columnIndex As Integer)
        Dim queue = New Queue(Of C1TreeNode)(nodes)
        While queue.Count > 0
            Dim node = queue.Dequeue()
            If IsEquals(node.GetValue(columnIndex).ToString(), value) Then
                _goal = node
                Return
            End If
            For Each child As C1TreeNode In node.Nodes
                queue.Enqueue(child)
            Next
        End While
    End Sub

    Private Function IsEquals(source As String, [sub] As String) As Boolean
        Select Case ComparisonType
            Case ComparisonType.StartsWith
                Return source.StartsWith([sub], System.StringComparison.InvariantCultureIgnoreCase)
            Case ComparisonType.Contains
                Return source.Contains([sub])
            Case Else
                Return source.Equals([sub], System.StringComparison.InvariantCultureIgnoreCase)
        End Select
    End Function
End Class
''' <summary>
''' String comparison type.
''' </summary>
Public Enum ComparisonType
    Equal
    StartsWith
    Contains
End Enum