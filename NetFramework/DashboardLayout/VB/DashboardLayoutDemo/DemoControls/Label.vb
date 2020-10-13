Imports C1.Win.C1Input

Namespace DashboardDemo.Controls
    Public Class DemoLabel
        Inherits C1Label
        Implements IDemo

        Public Sub Init() Implements IDemo.Init
            DataSource = SampleHelper.Instance.GetSourceTable("Total Sales", Resources.TotalSales)
            DataField = "Sales"
        End Sub
    End Class
End Namespace
