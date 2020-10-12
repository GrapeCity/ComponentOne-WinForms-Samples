Imports C1.Win.Chart

Namespace DashboardDemo.Controls
    Public Partial Class DemoFlexPie
        Inherits FlexPie
        Implements IDemo

        Public Sub Init() Implements IDemo.Init
            DataSource = SampleHelper.Instance.GetSourceTable("Sales By Employee", Resources.SalesByEmployee)
            Binding = "Sales"
            BindingName = "Employee"
        End Sub
    End Class
End Namespace
