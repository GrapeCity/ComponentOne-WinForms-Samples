Imports C1.Win.FlexGrid

Public Class InputPanelSample
    Private Sub InputPanelSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String = Util.GetConnectionString()
        Dim ds = New DataSet()
        Util.FillTable(ds, "Customers", conn)

        flexGrid.DataSource = ds
        flexGrid.DataMember = "Customers"

        flexGrid.RowDetailProvider = Function(g, r) New C1InputPanelRowDetail()
        flexGrid.RowDetailsVisibilityMode = RowDetailsVisibilityMode.VisibleWhenSelected
    End Sub
End Class
