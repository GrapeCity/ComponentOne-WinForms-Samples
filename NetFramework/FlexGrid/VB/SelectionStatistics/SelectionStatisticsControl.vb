Imports System.ComponentModel
Imports C1.Win.C1FlexGrid

Public Class SelectionStatisticsControl
    Public Sub New()
        InitializeComponent()

        InitializeData()
        UpdateStatistics()
    End Sub
    Private Sub UpdateStatistics()
        Dim text = String.Empty

        If Not c1FlexGrid1.Selection.IsSingleCell Then
            text = $"Average: {c1FlexGrid1.Aggregate(AggregateEnum.Average):F2}  " &
                $"Count: {c1FlexGrid1.Aggregate(AggregateEnum.Count)}  " &
                $"Summary: {c1FlexGrid1.Aggregate(AggregateEnum.Sum):F2}"
        End If

        tslSelectionStatistics.Text = text
    End Sub

    Private Sub InitializeData()
        c1FlexGrid1.BeginUpdate()
        OrdersTableAdapter1.Connection.ConnectionString = GetConnectionString()
        OrdersTableAdapter1.Fill(C1NWindDataSet1.Orders)
        Dim groups = New List(Of GroupDescription)()
        Dim group1 = New GroupDescription("ShipRegion", ListSortDirection.Descending, True)
        Dim group2 = New GroupDescription("CustomerID", ListSortDirection.Ascending, True)
        groups.Add(group1)
        groups.Add(group2)
        c1FlexGrid1.GroupDescriptions = groups
        c1FlexGrid1.Cols(1).Width = 222
        c1FlexGrid1.EndUpdate()
    End Sub

    Private Sub c1FlexGrid1_SelChange(sender As Object, e As EventArgs) Handles c1FlexGrid1.SelChange
        UpdateStatistics()
    End Sub
    Private Shared Function GetConnectionString() As String
        Dim path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
