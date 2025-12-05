Imports C1.Win.FlexGrid

Public Class FlexGridSample
    Private Sub FlexGridSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As String = Util.GetConnectionString()
        Dim ds = New DataSet()
        Dim tables As String() = "Customers, Orders".Split(","c)
        For Each tableName As String In tables
            Util.FillTable(ds, tableName, conn)
        Next

        ds.Relations.Add("Customers_Orders", ds.Tables("Customers").Columns("CustomerID"), ds.Tables("Orders").Columns("CustomerID"))

        flexGrid.DataSource = ds
        flexGrid.DataMember = "Customers"

        flexGrid.RowDetailProvider = Function(g, r) New C1FlexGridRowDetail()
        flexGrid.AreRowDetailsFrozen = False
    End Sub
End Class
