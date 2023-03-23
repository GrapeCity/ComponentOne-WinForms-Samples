Imports C1.Chart
Imports C1.DataCollection
Imports C1.DataFilter
Imports C1.Win.C1Input
Imports C1.Win.Chart
Imports C1.Win.DataFilter
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ChartAsDataFilter
    Public Class FlexChartFilter
        Inherits CustomFilter
#Region "fields"
        Protected filterView As FlexChartFilterView
        Protected propertyX, propertyY As String
        Protected items As IEnumerable(Of Object)
#End Region
#Region "Object Model"
        Public ReadOnly Property FlexChart As FlexChart
            Get
                Return filterView.Chart
            End Get
        End Property

        Public Property SliderLowerValue As Double
            Get
                Return filterView.Slider.LowerValue
            End Get
            Set(ByVal value As Double)
                filterView.Slider.LowerValue = value
            End Set
        End Property

        Public Property SliderUpperValue As Double
            Get
                Return filterView.Slider.UpperValue
            End Get
            Set(ByVal value As Double)
                filterView.Slider.UpperValue = value
            End Set
        End Property

        Public Property ShowRangeSlider As Boolean
            Get
                Return filterView.ShowRangeSlider
            End Get
            Set(ByVal value As Boolean)
                filterView.ShowRangeSlider = value
            End Set
        End Property

        Public Property ShowSelectionMode As Boolean
            Get
                Return filterView.ShowSelectionMode
            End Get
            Set(ByVal value As Boolean)
                filterView.ShowSelectionMode = value
            End Set
        End Property

        Public Property SelectionMode As SelectionMode
            Get
                Return filterView.SelectionMode
            End Get
            Set(ByVal value As SelectionMode)
                filterView.SelectionMode = value
            End Set
        End Property
#End Region
#Region "c'tor"
        Protected Sub New()
        End Sub

        Public Sub New(ByVal items As IEnumerable(Of Object), ByVal xProperty As String, ByVal yProperty As String, ByVal Optional chartType As ChartType = ChartType.Column)
            filterView = New FlexChartFilterView(items, xProperty, yProperty, chartType) With {
                .Height = 250
            }
            propertyX = xProperty
            propertyY = yProperty
            AddHandler filterView.SelectionChanged, Sub(s, e) OnValueChanged(New C1.DataFilter.ValueChangedEventArgs With {
                .ApplyFilter = True
            })
            Control = filterView
            Me.items = items
        End Sub
#End Region
#Region "Overrides"
        Protected Overrides Function GetExpression() As Expression
            Dim exp = New CombinationExpression()

            If filterView.IsGroupedData Then
                Dim selectedItems = filterView.GetSelectedValues()

                If selectedItems Is Nothing OrElse selectedItems.Count() = 0 Then
                    Dim selectedRange = filterView.GetSliderRange()
                    selectedItems = New List(Of Object)()

                    For idx As Integer = CInt(Math.Ceiling(CDbl(selectedRange.Item1))) To CInt(Math.Floor(CDbl(selectedRange.Item2)))
                        TryCast(selectedItems, IList).Add(items.ElementAt(idx))
                    Next
                End If

                SetGroupExpression(exp, selectedItems)
            Else
                Dim selectedItems = filterView.GetSelectedValues()

                If selectedItems Is Nothing OrElse selectedItems.Count() = 0 Then
                    SetRangeExpression(exp, filterView.GetSliderRange())
                Else
                    SetXYExpression(exp, selectedItems)
                End If
            End If

            Return exp
        End Function

        Protected Overrides Sub SetExpression(ByVal expression As Expression)
            Throw New NotImplementedException()
        End Sub

        Public Overrides ReadOnly Property IsApplied As Boolean
            Get
                Return filterView.IsFilterApplied
            End Get
        End Property
#End Region
#Region "Helpers"

        Private Sub SetXYExpression(ByVal exp As CombinationExpression, ByVal selectedValues As IEnumerable(Of Object))
            exp.FilterCombination = FilterCombination.[Or]

            For Each item In selectedValues
                Dim comboExp = New CombinationExpression() With {
                    .FilterCombination = FilterCombination.[And]
                }
                comboExp.Expressions.Add(New OperationExpression With {
                    .PropertyName = propertyX,
                    .Value = GetPropertyValue(propertyX, item),
                    .FilterOperation = FilterOperation.Equal
                })

                For Each [property] In propertyY.Split(","c)
                    comboExp.Expressions.Add(New OperationExpression With {
                        .PropertyName = [property].Trim(),
                        .Value = GetPropertyValue([property].Trim(), item),
                        .FilterOperation = FilterOperation.Equal
                    })
                Next

                exp.Expressions.Add(comboExp)
            Next
        End Sub

        Private Sub SetRangeExpression(ByVal exp As CombinationExpression, ByVal sliderRange As Tuple(Of Object, Object))
            exp.FilterCombination = FilterCombination.[And]
            If sliderRange IsNot Nothing AndAlso Not isCategoricalData() Then exp.Expressions.Add(CreateRangeExpression(sliderRange.Item1, sliderRange.Item2))
        End Sub

        Private Sub SetGroupExpression(ByVal exp As CombinationExpression, ByVal selectedGroups As IEnumerable(Of Object))
            exp.FilterCombination = FilterCombination.[Or]

            For Each grpItem As GroupItem In selectedGroups
                exp.Expressions.Add(CreateRangeExpression(grpItem.Min, grpItem.Max))
            Next
        End Sub

        Private Function CreateRangeExpression(ByVal min As Object, ByVal max As Object) As CombinationExpression
            Dim subExpression = New CombinationExpression() With {
                .FilterCombination = FilterCombination.[And]
            }
            subExpression.Expressions.Add(New OperationExpression With {
                .PropertyName = If(PropertyName <> String.Empty, PropertyName, propertyX),
                .Value = min,
                .FilterOperation = If(min.[GetType]() = GetType(String), FilterOperation.Equal, FilterOperation.GreaterThanOrEqual)
            })
            subExpression.Expressions.Add(New OperationExpression With {
                .PropertyName = If(PropertyName <> String.Empty, PropertyName, propertyX),
                .Value = max,
                .FilterOperation = If(max.[GetType]() = GetType(String), FilterOperation.Equal, FilterOperation.LessThanOrEqual)
            })
            Return subExpression
        End Function

        Private Function isCategoricalData() As Boolean
            Dim objType = items.First().[GetType]()
            Return If(objType = GetType(GroupItem), True, objType.GetProperty(propertyX).[GetType]() = GetType(String))
        End Function

        Protected Function GetPropertyValue(ByVal name As String, ByVal obj As Object) As Object
            Dim propInfo = obj.[GetType]().GetProperty(name)
            Return propInfo.GetValue(obj)
        End Function
#End Region
    End Class
    ''' <summary>
    ''' This Class should be use for filtering by Grouped data in FlexChartFilter
    ''' </summary>
    Public Class GroupItem
        Public Property XValue As String
        Public Property YValue As Double
        Public Property Min As Object
        Public Property Max As Object
    End Class
End Namespace
