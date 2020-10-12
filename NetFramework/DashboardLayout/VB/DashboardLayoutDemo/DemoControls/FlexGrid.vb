Imports C1.Win.C1FlexGrid

Namespace DashboardDemo.Controls
    Partial Public Class DemoFlexGrid
        Inherits C1FlexGrid
        Implements IDemo

        Public Sub Init() Implements IDemo.Init
            DataSource = SampleHelper.Instance.GetSourceTable("Sales", Resources.Sales)
        End Sub
    End Class
End Namespace
