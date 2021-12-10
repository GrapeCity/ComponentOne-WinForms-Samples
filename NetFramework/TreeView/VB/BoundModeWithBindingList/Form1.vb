Imports C1.Win.TreeView

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageList1.Images.Add(My.Resources._1)
        imageList1.Images.Add(My.Resources._2)
        imageList1.Images.Add(My.Resources._3)
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

        c1TreeView1.BindingInfo.DataMemberPath(1) = "ProductsGroups"
        c1TreeView1.BindingInfo.DataMemberPath(2) = "Products"
        Dim column = New C1TreeColumn()
        column.HeaderText = "Name"
        c1TreeView1.Columns.Add(column)

        column = New C1TreeColumn()
        column.DisplayFieldName = "CountOfProducts"
        column.HeaderText = "Products in store"
        column.AutoWidth = False
        column.Width = 100
        column.Styles.Default.BackColor = Color.LightBlue
        column.Styles.Hot.BackColor = Color.LightBlue
        c1TreeView1.Columns.Add(column)

        column = New C1TreeColumn()
        column.DisplayMemberPath(2) = "Price"
        column.HeaderText = "Price"
        column.Width = 200
        c1TreeView1.Columns.Add(column)

        c1TreeView1.BindingInfo.DataSource = StoreCollection.GetData()

        c1TreeView1.Nodes(0).Images.Add(0)
        c1TreeView1.Nodes(1).Images.Add(1)
        c1TreeView1.Nodes(2).Images.Add(2)
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

End Class