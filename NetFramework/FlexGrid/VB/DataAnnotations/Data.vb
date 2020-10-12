Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Class Data

    Shared _firstNames As String() = New String() {
        "Arnold",
        "Dave",
        "Sunny",
        "Gary",
        "Todd",
        "Kevin",
        "Gomez",
        "Chris",
        "Paul",
        "George",
        "John",
        "James",
        "Robert",
        "Jimmy",
        "Ronnie",
        "Tyler"
    }

    Shared _lastNames As String() = New String() {
        "Smith",
        "Anderson",
        "Acker",
        "Fox",
        "Dooley",
        "Chen",
        "Andrews",
        "Garrett",
        "Hill",
        "Parker",
        "Osborne",
        "Stone",
        "Marlow"
    }

    ' auto-generated CustomerName column header will show "Customer".
    ' (even though the property name Is "CustomerName")
    ' This column also requires non-empty string with minimal length at least 2 symbols.
    <Display(Name:="Customer")>
    <Required>
    <StringLength(Integer.MaxValue, MinimumLength:=2)>
    Public Property CustomerName As String

    ' auto-generated CustomerID column will be invisible.
    <Display(AutoGenerateField:=False)>
    Public Property CustomerID As Integer

    ' auto-generated "Frequency" column will show values formatted as percentages
    ' And will Not allow editing.
    <DisplayFormat(DataFormatString:="0%")>
    <Editable(False)>
    Public Property Frequency As Double

    ' auto-generated "Age" column will allow values in the predefined
    ' range.
    <Required>
    <Range(10, 90)>
    Public Property Age As Integer

    ' create some sample data
    Public Shared Function GetSampleData(ByVal cnt As Integer) As BindingList(Of Data)
        Dim list = New BindingList(Of Data)()
        Dim rnd = New Random()

        For i As Integer = 0 To cnt - 1
            Dim item = New Data()
            item.CustomerName = _firstNames(rnd.[Next](0, _firstNames.Length)) + " " + _lastNames(rnd.[Next](0, _lastNames.Length))
            item.CustomerID = i
            item.Frequency = rnd.NextDouble()
            item.Age = rnd.[Next](10, 91)
            list.Add(item)
        Next

        Return list
    End Function
End Class
