Imports System.Windows.Forms
Imports System.Dynamic
Imports C1.DataEngine

Public Class FormJoin

    Private _tableNodes As New List(Of TreeNode)()
    Public Sub New()
        InitializeComponent()
        _imageList.Images.Add(My.Resources.table_22x16)
        _imageList.Images.Add(My.Resources.column_22x16)
        ' bold font for table nodes
        tvTables.Font = New System.Drawing.Font(Font, FontStyle.Bold)
    End Sub

    ' gets or sets C1DataEngine tables to join
    Public Property Tables() As Object()
        Get
            Return m_Tables
        End Get
        Set(value As Object())
            m_Tables = value
        End Set
    End Property
    Private m_Tables As Object()

    ' gets or sets selected field names to join
    Public Property SelectedFields() As String()
        Get
            Return m_SelectedFields
        End Get
        Set(value As String())
            m_SelectedFields = value
        End Set
    End Property
    Private m_SelectedFields As String()

    ' gets settings object for join
    Public Property JoinSettings() As Dictionary(Of String, Object)
        Get
            Return m_JoinSettings
        End Get
        Private Set(value As Dictionary(Of String, Object))
            m_JoinSettings = value
        End Set
    End Property
    Private m_JoinSettings As Dictionary(Of String, Object)

    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        ShowTables()
    End Sub

    ' saves user choices
    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)
        SelectedFields = GetCheckedNodes()
        JoinSettings = GetJoinSettings()
    End Sub

    ' shows table fields in the tree view
    Private Sub ShowTables()
        Dim root As TreeNode = ShowTable(Nothing, Tables(0))
        ShowTable(root.Nodes(1), Tables(1))
        ShowTable(root.Nodes(2), Tables(2))
        CheckNodes()
        AddHandler tvTables.AfterCheck, AddressOf tvTables_AfterCheck
        tvTables.SelectedNode = root
        tvTables.ExpandAll()
        root.EnsureVisible()
    End Sub

    ' shows a table in the tree view
    Private Function ShowTable(parent As TreeNode, table As Object) As TreeNode
        Dim nt As New TreeNode(table.Table.Name, 0, 0)
        nt.Name = nt.Text
        nt.Tag = table
        nt.Checked = True
        ' gets the table as a dictionary of properties
        Dim props = DirectCast(table, IDictionary(Of String, [Object]))
        For Each prop As Object In props
            ' create a node if the property is a column
            If prop.Value IsNot Nothing AndAlso (prop.Value.[GetType]() = GetType(Column)) Then
                Dim col As Column = DirectCast(prop.Value, Column)
                Dim nc As New TreeNode(col.Name, 1, 1)
                nc.Name = nc.Text
                nc.Tag = col
                nc.NodeFont = Font
                nt.Nodes.Add(nc)
            End If
        Next
        ' add the table node to the tree view
        ' and check referenced nodes
        If parent IsNot Nothing Then
            parent.Nodes.Add(nt)
            parent.Checked = True
        Else
            tvTables.Nodes.Add(nt)
        End If

        nt.Nodes(0).Checked = True
        _tableNodes.Add(nt)
        Return nt
    End Function

    ' creates a settings object to build a join query
    Private Function GetJoinSettings() As Dictionary(Of String, Object)
        Dim settings = New Dictionary(Of String, Object)()
        For Each node As TreeNode In _tableNodes
            Dim cols As Columns = GetSelectedColumns(node)
            If DirectCast(cols, Object) IsNot Nothing Then
                settings(node.Text) = cols
            End If
        Next
        Return settings
    End Function

    ' gets selected columns for a table node
    Private Function GetSelectedColumns(node As TreeNode) As Columns
        Dim cols As Columns = Nothing
        For i As Integer = 0 To node.Nodes.Count - 1
            Dim cn As TreeNode = node.Nodes(i)
            ' add a selected column to the collection
            If cn.Checked Then
                ' do not add relationship column by default
                If (node.Parent IsNot Nothing And cn Is node.Nodes(0)) Then
                    Continue For
                End If
                cols += DirectCast(cn.Tag, Column)
            End If
        Next
        If node.Parent IsNot Nothing Then
            ' if no result columns are selected, add a relationship column
            If DirectCast(cols, Object) Is Nothing Then
                cols += DirectCast(node.Nodes(0).Tag, Column)
            End If
            ' add a relation between the tables
            cols = cols Or DirectCast(node.Parent.Tag, Column) = DirectCast(node.Nodes(0).Tag, Column)
        End If
        Return cols
    End Function

    ' gets paths of the selected nodes
    Private Function GetCheckedNodes() As String()
        Dim nodes As New List(Of String)()
        GetCheckedNodes(tvTables.Nodes, nodes)
        Return nodes.ToArray()
    End Function

    ' adds path of the selected nodes to the list
    Private Sub GetCheckedNodes(nodes As TreeNodeCollection, checkedNodes As List(Of String))
        For Each node As TreeNode In nodes
            If node.Checked Then
                checkedNodes.Add(node.FullPath)
            End If
            GetCheckedNodes(node.Nodes, checkedNodes)
        Next
    End Sub

    ' checks tree view nodes by the selected paths
    Private Sub CheckNodes()
        If SelectedFields Is Nothing Then
            Return
        End If
        For Each path As String In SelectedFields
            GetNode(path).Checked = True
        Next
    End Sub

    ' gets a tree view node by path
    Private Function GetNode(fullPath As String) As TreeNode
        Dim node As TreeNode = Nothing
        Dim names As String() = fullPath.Split(tvTables.PathSeparator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        Dim nodes As TreeNodeCollection = tvTables.Nodes
        For Each name As String In names
            node = nodes.Find(name, False)(0)
            nodes = node.Nodes
        Next
        Return node
    End Function

    ' validates check state of a node
    ' referenced nodes must always be checked
    Private Sub tvTables_AfterCheck(sender As Object, e As TreeViewEventArgs)
        RemoveHandler tvTables.AfterCheck, AddressOf tvTables_AfterCheck
        If e.Node.Nodes.Count > 0 Then
            e.Node.Checked = True
        ElseIf e.Node.Parent IsNot Nothing AndAlso e.Node.Parent.Nodes(0) Is e.Node Then
            e.Node.Checked = True
        End If
        AddHandler tvTables.AfterCheck, AddressOf tvTables_AfterCheck
    End Sub

End Class