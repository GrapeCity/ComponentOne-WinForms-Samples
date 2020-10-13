Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c1TreeView1.BindingInfo.ParentKeyField = "ChiefID"
        c1TreeView1.BindingInfo.KeyField = "ID"
        c1TreeView1.BindingInfo.DataSource = Employee.GetData()
        c1TreeView1.Columns(2).DataMap = Country.GetCountries()
    End Sub
End Class
