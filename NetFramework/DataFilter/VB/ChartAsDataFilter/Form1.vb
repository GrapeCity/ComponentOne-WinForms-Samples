Imports System.Collections.ObjectModel
Imports ChartAsDataFilter.ChartAsDataFilter
Imports ChartAsDataFilter.ChartAsDataFilter.Data

Partial Public Class Form1
    Inherits Form

    Private finanicalData As ObservableCollection(Of Quote)

    Public Sub New()
        InitializeComponent()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        finanicalData = New ObservableCollection(Of Quote)(DataService.GetFinancialData(500))

        AddHandler c1FlexGrid1.DataSourceChanged, AddressOf C1FlexGrid1_DataSourceChanged
        c1FlexGrid1.DataSource = finanicalData
        c1DataFilter1.AutoGenerateFilters = False
        c1DataFilter1.DataSource = finanicalData

        AddHandler c1DataFilter1.FilterChanged, Sub(s, args)
                                                    c1FlexGrid1.DataSource = c1DataFilter1.View.ToList()
                                                End Sub

        InitFilters()
    End Sub

    Private Sub C1FlexGrid1_DataSourceChanged(ByVal sender As Object, ByVal e As EventArgs)
        For i As Integer = 1 To c1FlexGrid1.Cols.Count - 1
            c1FlexGrid1.Cols(i).StarWidth = "*"
        Next
    End Sub

    Private Sub InitFilters()

        Dim priceFilter = New FlexChartFilter(finanicalData, "Day", "High", C1.Chart.ChartType.Scatter)
        priceFilter.HeaderText = "Daily High Prices"
        priceFilter.SelectionMode = SelectionMode.RangeSelect
        priceFilter.ShowRangeSlider = True
        priceFilter.SliderLowerValue = New DateTime(finanicalData.Last().Day.Year, 7, 15).ToOADate()
        priceFilter.SliderUpperValue = finanicalData.Last().Day.ToOADate()
        priceFilter.FlexChart.SelectionStyle.FillColor = Color.NavajoWhite
        priceFilter.FlexChart.SelectionStyle.StrokeColor = Color.Red
        c1DataFilter1.Filters.Add(priceFilter)

        Dim grpVolumeFilter = New FlexChartDateTimeFilter(finanicalData, "Day", "Volume", C1.Chart.ChartType.Column)
        grpVolumeFilter.ShowSelectionMode = False
        grpVolumeFilter.HeaderText = "Volume"
        grpVolumeFilter.FlexChart.AxisY.Format = "#,##0,,M"
        AddHandler grpVolumeFilter.GroupByChanged, Sub(s, e)
                                                       Dim dtFilter = TryCast(s, FlexChartDateTimeFilter)
                                                       dtFilter.ShowRangeSlider = dtFilter.GroupBy <> DateTimeGroupOption.Quarterly AndAlso dtFilter.GroupBy <> DateTimeGroupOption.Yearly
                                                   End Sub

        grpVolumeFilter.GroupBy = DateTimeGroupOption.Yearly
        c1DataFilter1.Filters.Add(grpVolumeFilter)

        Dim customDtFilter = New FlexChartDateTimeFilter(finanicalData, "Day", "High,Low,Open,Close", C1.Chart.ChartType.Candlestick)
        customDtFilter.HeaderText = "High-Low-Open-Close"
        customDtFilter.FlexChart.ToolTip.Content = "X:{x}" & vbLf & "H:{High}" & vbLf & "L:{Low}" & vbLf & "O:{Open}" & vbLf & "C:{Close}"
        customDtFilter.UseCustomGroups = True
        AddHandler customDtFilter.GroupByChanged, AddressOf CustomDtFilter_GroupByChangedChanged
        customDtFilter.GroupBy = DateTimeGroupOption.Monthly
        customDtFilter.SliderLowerValue = 17
        customDtFilter.SliderUpperValue = 24
        customDtFilter.ShowAggregate = False
        customDtFilter.ShowSelectionMode = False
        c1DataFilter1.Filters.Add(customDtFilter)
    End Sub

    Private Sub CustomDtFilter_GroupByChangedChanged(ByVal sender As Object, ByVal e As GroupByEventArgs)
        Dim dtFilter = TryCast(sender, FlexChartDateTimeFilter)

        Select Case dtFilter.GroupBy
            Case DateTimeGroupOption.ShowAll
                e.BindingX = "Date"
                dtFilter.ShowRangeSlider = True
            Case DateTimeGroupOption.Yearly
                e.BindingX = "XValue"
                e.ItemsSource = GetGroupByYear(dtFilter)
                dtFilter.ShowRangeSlider = False
            Case DateTimeGroupOption.Quarterly
                e.BindingX = "XValue"
                e.ItemsSource = GetGroupByQuarter(dtFilter)
                dtFilter.ShowRangeSlider = False
            Case DateTimeGroupOption.Monthly
                e.BindingX = "XValue"
                e.ItemsSource = GetGroupByMonth(dtFilter)
                dtFilter.ShowRangeSlider = True
            Case DateTimeGroupOption.Weekly
                e.BindingX = "XValue"
                e.ItemsSource = GetGroupByWeek(dtFilter)
                dtFilter.ShowRangeSlider = True
        End Select
    End Sub

    Private Function GetGroupByYear(ByVal dtFilter As FlexChartDateTimeFilter) As IEnumerable(Of CustomGroupItem)
        Dim yearsData = finanicalData.[Select](Function(x)
                                                   Dim dt As DateTime = x.Day
                                                   Dim data = New With
                                                   {
                                                       .GroupKey = New DateTime(dt.Year, 1, 1),
                                                       .High = x.High,
                                                       .Low = x.Low,
                                                       .Open = x.Open,
                                                       .Close = x.Close
                                                   }
                                                   Return data
                                               End Function)
        Return yearsData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New CustomGroupItem With {
            .XValue = x.Key.ToString(dtFilter.GroupFormats(DateTimeGroupOption.Yearly)),
            .High = x.Max(Function(y) y.High),
            .Low = x.Min(Function(y) y.Low),
            .Open = x.First().Open,
            .Close = x.Last().Close,
            .Min = x.Key,
            .Max = New DateTime(x.Key.Year, 12, 31)
        })
    End Function

    Private Function GetGroupByQuarter(ByVal dtFilter As FlexChartDateTimeFilter) As IEnumerable(Of CustomGroupItem)
        Dim quartersData = finanicalData.[Select](Function(x)
                                                      Dim dt As DateTime = x.Day
                                                      Dim data = New With
                                                      {
                                                          .GroupKey = dt.GetFirstDateOfQuarter(),
                                                          .High = x.High,
                                                          .Low = x.Low,
                                                          .Open = x.Open,
                                                          .Close = x.Close
                                                      }
                                                      Return data
                                                  End Function)
        Return quartersData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New CustomGroupItem With {
            .XValue = dtFilter.GetFormattedString(x.Key, dtFilter.GroupFormats(DateTimeGroupOption.Quarterly), x.Key.GetQuarterNumber()),
            .High = x.Max(Function(y) y.High),
            .Low = x.Min(Function(y) y.Low),
            .Open = x.First().Open,
            .Close = x.Last().Close,
            .Min = x.Key,
            .Max = x.Key.GetLastDateOfQuarter()
        })
    End Function

    Private Function GetGroupByMonth(ByVal dtFilter As FlexChartDateTimeFilter) As IEnumerable(Of CustomGroupItem)
        Dim monthsData = finanicalData.[Select](Function(x)
                                                    Dim dt As DateTime = x.Day
                                                    Dim data = New With
                                                    {
                                                        .GroupKey = New DateTime(dt.Year, dt.Month, 1),
                                                        .High = x.High,
                                                        .Low = x.Low,
                                                        .Open = x.Open,
                                                        .Close = x.Close
                                                    }
                                                    Return data
                                                End Function)
        Return monthsData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New CustomGroupItem With {
            .XValue = x.Key.ToString(dtFilter.GroupFormats(DateTimeGroupOption.Monthly)),
            .High = x.Max(Function(y) y.High),
            .Low = x.Min(Function(y) y.Low),
            .Open = x.First().Open,
            .Close = x.Last().Close,
            .Min = x.Key,
            .Max = New DateTime(x.Key.Year, x.Key.Month, DateTime.DaysInMonth(x.Key.Year, x.Key.Month))
        })
    End Function

    Private Function GetGroupByWeek(ByVal dtFilter As FlexChartDateTimeFilter) As IEnumerable(Of CustomGroupItem)
        Dim weeksData = finanicalData.[Select](Function(x)
                                                   Dim dt As DateTime = x.Day
                                                   Dim data = New With
                                                   {
                                                       .GroupKey = dt.GetFirstDateOfWeek(),
                                                       .High = x.High,
                                                       .Low = x.Low,
                                                       .Open = x.Open,
                                                       .Close = x.Close
                                                   }
                                                   Return data
                                               End Function)
        Return weeksData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New CustomGroupItem With {
            .XValue = dtFilter.GetFormattedString(x.Key, dtFilter.GroupFormats(DateTimeGroupOption.Weekly), x.Key.GetWeekOfMonth()),
            .High = x.Max(Function(y) y.High),
            .Low = x.Min(Function(y) y.Low),
            .Open = x.First().Open,
            .Close = x.Last().Close,
            .Min = x.Key,
            .Max = x.Key.GetLastDateOfWeek()
        })
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class

Public Class CustomGroupItem
    Inherits GroupItem

    Public Property High As Double
    Public Property Low As Double
    Public Property Open As Double
    Public Property Close As Double
End Class

