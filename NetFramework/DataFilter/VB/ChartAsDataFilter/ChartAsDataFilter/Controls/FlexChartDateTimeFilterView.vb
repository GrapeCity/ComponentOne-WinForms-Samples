Imports C1.Chart

Namespace ChartAsDataFilter
    Partial Public Class FlexChartDateTimeFilterView
        Inherits FlexChartFilterView
#Region "fields"
        Private _cbGroupBy, _cbAggregate As ComboBox
        Private _groupBy As DateTimeGroupOption
        Private _aggregate As AggregateFunction
#End Region
#Region "Properties"
        Public Property GroupBy As DateTimeGroupOption
            Get
                Return _groupBy
            End Get
            Set(ByVal value As DateTimeGroupOption)

                If _groupBy <> value Then
                    _groupBy = value
                    _cbGroupBy.SelectedIndex = If(_cbGroupBy.SelectedIndex = -1, -1, CInt(value))
                    If GroupByChangedEvent IsNot Nothing Then RaiseEvent GroupByChanged(Me, Nothing)
                End If
            End Set
        End Property

        Public Property Aggregate As AggregateFunction
            Get
                Return _aggregate
            End Get
            Set(ByVal value As AggregateFunction)

                If _aggregate <> value Then
                    _aggregate = value
                    _cbAggregate.SelectedIndex = If(_cbAggregate.SelectedIndex = -1, -1, CInt(value))
                    If AggregateChangedEvent IsNot Nothing Then RaiseEvent AggregateChanged(Me, Nothing)
                End If
            End Set
        End Property

        Public Property ShowGroupBy As Boolean
            Get
                Return _cbGroupBy.Visible
            End Get
            Set(ByVal value As Boolean)
                _cbGroupBy.Visible = value
            End Set
        End Property

        Public Property ShowAggregate As Boolean
            Get
                Return _cbAggregate.Visible
            End Get
            Set(ByVal value As Boolean)
                _cbAggregate.Visible = value
            End Set
        End Property
#End Region
#Region "c'tor"
        Public Sub New(ByVal items As IEnumerable(Of Object), ByVal bindingX As String, ByVal binding As String, ByVal Optional chartType As ChartType = ChartType.Column)
            MyBase.New(items, bindingX, binding, chartType)
            InitializeComponent()
            _cbGroupBy = New ComboBox() With {
                .Width = 80,
                .FlatStyle = FlatStyle.Flat,
                .DataSource = [Enum].GetValues(GetType(DateTimeGroupOption))
            }
            AddHandler _cbGroupBy.SelectedIndexChanged, AddressOf _cbGroupBy_SelectedIndexChanged
            _cbAggregate = New ComboBox() With {
                .Width = 80,
                .FlatStyle = FlatStyle.Flat,
                .DataSource = [Enum].GetValues(GetType(AggregateFunction))
            }
            AddHandler _cbAggregate.SelectedIndexChanged, AddressOf _cbAggregate_SelectedIndexChanged
            GroupBy = DateTimeGroupOption.ShowAll
            Aggregate = AggregateFunction.Sum
            Me._pnlControlOptions.Controls.Add(_cbGroupBy)
            Me._pnlControlOptions.Controls.Add(_cbAggregate)
        End Sub
#End Region
#Region "Events"
        Public Event GroupByChanged As EventHandler
        Public Event AggregateChanged As EventHandler
#End Region
#Region "Control EventHandlers"
        Private Sub _cbAggregate_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            Aggregate = CType(_cbAggregate.SelectedValue, AggregateFunction)
        End Sub

        Private Sub _cbGroupBy_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            GroupBy = CType(_cbGroupBy.SelectedValue, DateTimeGroupOption)
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            _cbGroupBy.SelectedIndex = CInt(GroupBy)
            _cbAggregate.SelectedIndex = CInt(Aggregate)
        End Sub
#End Region
    End Class
End Namespace
