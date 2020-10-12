Imports C1.Win.C1FlexGrid

Public Class CustomSample
    Private Sub CustomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String = Util.GetConnectionString()
        Dim ds = New DataSet()
        Util.FillTable(ds, "Employees", conn)

        flexGrid.DataSource = ds
        flexGrid.DataMember = "Employees"

        flexGrid.RowDetailProvider = Function(g, r) New CustomRowDetail()
        flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected

        flexGrid.Cols("Notes").Visible = False
    End Sub
End Class
