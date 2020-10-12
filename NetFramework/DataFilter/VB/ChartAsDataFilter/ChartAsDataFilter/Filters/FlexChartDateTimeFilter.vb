Imports C1.Chart

Namespace ChartAsDataFilter
    Public Class FlexChartDateTimeFilter
        Inherits FlexChartFilter

        Private Property dtFilterView As FlexChartDateTimeFilterView
            Get
                Return TryCast(filterView, FlexChartDateTimeFilterView)
            End Get
            Set(ByVal value As FlexChartDateTimeFilterView)
                filterView = value
            End Set
        End Property

        Private source As IEnumerable(Of Object)
#Region "Object Model"
        Public Property ShowGroupBy As Boolean
            Get
                Return dtFilterView.ShowGroupBy
            End Get
            Set(ByVal value As Boolean)
                dtFilterView.ShowGroupBy = value
            End Set
        End Property

        Public Property ShowAggregate As Boolean
            Get
                Return dtFilterView.ShowAggregate
            End Get
            Set(ByVal value As Boolean)
                dtFilterView.ShowAggregate = value
            End Set
        End Property

        Public Property GroupBy As DateTimeGroupOption
            Get
                Return dtFilterView.GroupBy
            End Get
            Set(ByVal value As DateTimeGroupOption)
                dtFilterView.GroupBy = value
            End Set
        End Property

        Public Property Aggregate As AggregateFunction
            Get
                Return dtFilterView.Aggregate
            End Get
            Set(ByVal value As AggregateFunction)
                dtFilterView.Aggregate = value
            End Set
        End Property

        Public Property UseCustomGroups As Boolean
        Public GroupFormats As Dictionary(Of DateTimeGroupOption, String) = New Dictionary(Of DateTimeGroupOption, String)() From {
            {DateTimeGroupOption.Yearly, "yyyy"},
            {DateTimeGroupOption.Quarterly, "yyyy|Q{0}"},
            {DateTimeGroupOption.Monthly, "MMM-yyyy"},
            {DateTimeGroupOption.Weekly, "MMM-yyyy|W{0}"}
        }
#End Region
        Public Event GroupByChanged As EventHandler(Of GroupByEventArgs)
#Region "c'tor"
        Public Sub New(ByVal items As IEnumerable(Of Object), ByVal xProperty As String, ByVal yProperty As String, ByVal Optional chartType As ChartType = ChartType.Column)
            dtFilterView = New FlexChartDateTimeFilterView(items, xProperty, yProperty, chartType) With {
                .Height = 250
            }
            propertyX = xProperty
            PropertyName = xProperty
            propertyY = yProperty
            source = items.OrderBy(Function(x) GetPropertyValue(xProperty, x))
            Me.items = source
            AddHandler dtFilterView.SelectionChanged, Sub(s, e) OnValueChanged(New C1.DataFilter.ValueChangedEventArgs With {
                .ApplyFilter = True
            })
            AddHandler dtFilterView.GroupByChanged, AddressOf FlexChartDateTimeFilter_GroupByChanged
            AddHandler dtFilterView.AggregateChanged, AddressOf FlexChartDateTimeFilter_AggregateChanged
            Control = filterView
        End Sub
#End Region
#Region "Event Handlers"

        Private Sub FlexChartDateTimeFilter_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If GroupBy <> DateTimeGroupOption.ShowAll Then
                UpdateView()
            End If
        End Sub

        Private Sub FlexChartDateTimeFilter_AggregateChanged(ByVal sender As Object, ByVal e As EventArgs)
            If GroupBy <> DateTimeGroupOption.ShowAll Then
                UpdateView()
            End If
        End Sub

        Private Sub FlexChartDateTimeFilter_GroupByChanged(ByVal sender As Object, ByVal e As EventArgs)
            If UseCustomGroups Then
                Dim customGroups = New GroupByEventArgs()
                RaiseEvent GroupByChanged(Me, customGroups)
                items = If(customGroups.ItemsSource Is Nothing, source, customGroups.ItemsSource)
                dtFilterView.ChangeDataSource(items, customGroups.BindingX, customGroups.Binding)
            Else
                RaiseEvent GroupByChanged(Me, Nothing)
                UpdateView()
            End If
        End Sub
#End Region
#Region "Private Helpers"
        Private Sub UpdateView()
            UpdateItems()

            If GroupBy = DateTimeGroupOption.ShowAll Then
                dtFilterView.ChangeDataSource(items, propertyX, propertyY)
            Else
                dtFilterView.ChangeDataSource(items, "XValue", "YValue")
            End If
        End Sub

        Private Sub UpdateItems()
            Select Case GroupBy
                Case DateTimeGroupOption.ShowAll
                    items = source
                Case DateTimeGroupOption.Yearly
                    items = GetGroupByYear()
                Case DateTimeGroupOption.Quarterly
                    items = GetGroupByQuarter()
                Case DateTimeGroupOption.Monthly
                    items = GetGroupByMonth()
                Case DateTimeGroupOption.Weekly
                    items = GetGroupByWeek()
            End Select
        End Sub

        Private Function GetGroupByYear() As IEnumerable(Of Object)
            Dim yearsData = source.[Select](Function(x)
                                                Dim dt As DateTime = CDate(GetPropertyValue(propertyX, x))
                                                Dim data = New With
                                                {
                                                    .GroupKey = New DateTime(dt.Year, 1, 1),
                                                    .Value = CDbl(GetPropertyValue(propertyY, x))
                                                }
                                                Return data
                                            End Function)
            Return yearsData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New GroupItem With {
                .XValue = x.Key.ToString(GroupFormats(DateTimeGroupOption.Yearly)),
                .YValue = x.[Select](Function(y) y.Value).Aggregate(Aggregate),
                .Min = x.Key,
                .Max = New DateTime(x.Key.Year, 12, 31)
            })
        End Function

        Private Function GetGroupByQuarter() As IEnumerable(Of Object)
            Dim quartersData = source.[Select](Function(x)
                                                   Dim dt As DateTime = CDate(GetPropertyValue(propertyX, x))
                                                   Dim data = New With
                                                   {
                                                       .GroupKey = dt.GetFirstDateOfQuarter(),
                                                       .Value = CDbl(GetPropertyValue(propertyY, x))
                                                   }
                                                   Return data
                                               End Function)
            Return quartersData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New GroupItem With {
                .XValue = GetFormattedString(x.Key, GroupFormats(DateTimeGroupOption.Quarterly), x.Key.GetQuarterNumber()),
                .YValue = x.[Select](Function(y) y.Value).Aggregate(Aggregate),
                .Min = x.Key,
                .Max = x.Key.GetLastDateOfQuarter()
            })
        End Function

        Private Function GetGroupByMonth() As IEnumerable(Of Object)
            Dim monthsData = source.[Select](Function(x)
                                                 Dim dt As DateTime = CDate(GetPropertyValue(propertyX, x))
                                                 Dim data = New With
                                                 {
                                                     .GroupKey = New DateTime(dt.Year, dt.Month, 1),
                                                     .Value = CDbl(GetPropertyValue(propertyY, x))
                                                 }
                                                 Return data
                                             End Function)
            Return monthsData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New GroupItem With {
                .XValue = x.Key.ToString(GroupFormats(DateTimeGroupOption.Monthly)),
                .YValue = x.[Select](Function(y) y.Value).Aggregate(Aggregate),
                .Min = x.Key,
                .Max = New DateTime(x.Key.Year, x.Key.Month, DateTime.DaysInMonth(x.Key.Year, x.Key.Month))
            })
        End Function

        Private Function GetGroupByWeek() As IEnumerable(Of Object)
            Dim weeksData = source.[Select](Function(x)
                                                Dim dt As DateTime = CDate(GetPropertyValue(propertyX, x))
                                                Dim data = New With
                                                {
                                                    .GroupKey = dt.GetFirstDateOfWeek(),
                                                    .Value = CDbl(GetPropertyValue(propertyY, x))
                                                }
                                                Return data
                                            End Function)
            Return weeksData.GroupBy(Function(x) x.GroupKey).[Select](Function(x) New GroupItem With {
                .XValue = GetFormattedString(x.Key, GroupFormats(DateTimeGroupOption.Weekly), x.Key.GetWeekOfMonth()),
                .YValue = x.[Select](Function(y) y.Value).Aggregate(Aggregate),
                .Min = x.Key,
                .Max = x.Key.GetLastDateOfWeek()
            })
        End Function

        Public Function GetFormattedString(ByVal day As DateTime, ByVal Format As String, ByVal formatItemVal As Integer) As String
            Dim parts = Format.Split("|"c)
            Dim result = String.Empty

            For Each part In parts
                result += If(result = String.Empty, String.Empty, " ")
                result += If(part.Contains("{0}"), String.Format(part, formatItemVal), day.ToString(part))
            Next

            Return result
        End Function
    End Class
#End Region
    Public Class GroupByEventArgs
        Public Property ItemsSource As IEnumerable(Of GroupItem)
        Public Property BindingX As String
        Public Property Binding As String
    End Class
End Namespace
