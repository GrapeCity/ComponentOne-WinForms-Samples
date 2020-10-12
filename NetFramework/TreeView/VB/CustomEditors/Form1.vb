
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1TreeView1.BindingInfo.DataMember = "Collection\Collection"
        C1TreeView1.BindingInfo.DataSource = EditorsData.GetData()
        C1TreeView1.Columns(2).Editor = New CustomColorPicker()
        C1TreeView1.Columns(3).Editor = New CustomDatePicker()
    End Sub
End Class