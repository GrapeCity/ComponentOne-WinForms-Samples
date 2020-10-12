Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1TreeView1.BindingInfo.AutoGenerateColumns = True
        C1TreeView1.BindingInfo.ParentKeyField = "ChiefID"
        C1TreeView1.BindingInfo.KeyField = "ID"
        C1TreeView1.BindingInfo.DataSource = EmployeesTypedList.GetData()
    End Sub
End Class
