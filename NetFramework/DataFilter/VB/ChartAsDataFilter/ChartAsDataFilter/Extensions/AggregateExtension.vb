Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Namespace ChartAsDataFilter
    Module AggregateExtensions
        <Extension()>
        Function Aggregate(ByVal values As IEnumerable(Of Double), ByVal type As AggregateFunction, ByVal Optional customFun As Func(Of IEnumerable(Of Double), Double) = Nothing) As Double
            If customFun IsNot Nothing Then
                Return customFun(values)
            End If

            Select Case type
                Case AggregateFunction.Avg
                    Return values.Average()
                Case AggregateFunction.Sum
                    Return values.Sum()
                Case AggregateFunction.Max
                    Return values.Max()
                Case AggregateFunction.Min
                    Return values.Min()
                Case Else
                    Return values.Sum()
            End Select
        End Function
    End Module
End Namespace

