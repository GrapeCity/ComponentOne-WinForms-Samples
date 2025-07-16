Imports C1.Win.TrueDBGrid

Namespace DashboardDemo.Controls
    Public Class DemoTrueDBGrid
        Inherits C1TrueDBGrid
        Implements IDemo

        Public Sub Init() Implements IDemo.Init
            DataSource = SampleHelper.Instance.GetSourceTable("Customers", Resources.Customers)
        End Sub
    End Class
End Namespace
