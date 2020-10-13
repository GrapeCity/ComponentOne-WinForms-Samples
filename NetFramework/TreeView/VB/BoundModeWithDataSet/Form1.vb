Imports C1.Win.TreeView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1DockingTab1.SelectedIndex = 0
        ResetDataInTreeView()
        ResetColumnsInCombobox()
    End Sub

    Private Sub btnResetData_Click(sender As Object, e As EventArgs) Handles btnResetData.Click
        ResetDataInTreeView()
        ResetColumnsInCombobox()
    End Sub

    Private Sub ResetDataInTreeView()
        c1TreeView1.Columns.Clear()
        c1TreeView1.BindingInfo.DataSource = Nothing
        c1TreeView1.BindingInfo.DataMember = "Employees"
        Dim column = New C1TreeColumn
        column.DisplayFieldName = "Post\Post\Post"
        column.HeaderText = "Post"
        c1TreeView1.Columns.Add(column)
        column = New C1TreeColumn()
        column.DisplayFieldName = "FirstName\FirstName\FirstName"
        column.HeaderText = "First name"
        c1TreeView1.Columns.Add(column)
        column = New C1TreeColumn()
        column.DisplayFieldName = "LastName\LastName\LastName"
        column.HeaderText = "Last name"
        c1TreeView1.Columns.Add(column)
        c1TreeView1.BindingInfo.KeyField = "ID"
        c1TreeView1.BindingInfo.ParentKeyField = "ChiefID"
        c1TreeView1.BindingInfo.DataSource = Initilize()
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

    Public Function Initilize() As BindingSource
        Dim bindingSource = New BindingSource
        bindingSource.DataSource = EmployeesSelfRefDataSet.GetData()
        bindingSource.DataMember = "Employees"
        Return bindingSource
    End Function

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

End Class