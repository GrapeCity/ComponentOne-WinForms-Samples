Imports System.ComponentModel

Public Class EditorsData

    Public Property TextValue As String
    Public Property ObjectValue As Object
    Public Property ColorValue As Color
    Public Property DateValue As DateTime
    Public Property Collection As BindingList(Of EditorsData)

    Public Sub New()
        Collection = New BindingList(Of EditorsData)
    End Sub

    Public Shared Function GetData() As BindingList(Of EditorsData)
        Dim Data = New BindingList(Of EditorsData)
        For i As Integer = 0 To 5
            Dim ed = New EditorsData()
            ed.TextValue = i.ToString()
            ed.ObjectValue = i
            ed.ColorValue = Color.Black
            ed.DateValue = DateTime.Now
            Data.Add(ed)
            For j As Integer = 0 To 5
                Dim ed1 = New EditorsData()
                ed1.TextValue = (i + j).ToString()
                ed1.ObjectValue = i + j
                ed1.ColorValue = Color.White
                ed1.DateValue = DateTime.Now
                Data(i).Collection.Add(ed1)
            Next
        Next
        Return Data
    End Function

End Class
