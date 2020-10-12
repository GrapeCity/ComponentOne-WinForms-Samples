Imports C1.Win.Chart

Namespace DashboardDemo.Controls
    Public Class DemoFlexChart
        Inherits FlexChart
        Implements IDemo

        Public Sub Init() Implements IDemo.Init
            DataSource = SampleHelper.Instance.GetSourceTable("Sales By Country", Resources.SalesByCountry)
            Series.Clear()
            Dim series1 = New Series()
            series1.Name = "Sales"
            series1.Binding = "Sales"
            Series.Add(series1)
            BindingX = "Country"
        End Sub
    End Class
End Namespace
