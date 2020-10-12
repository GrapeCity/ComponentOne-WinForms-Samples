Public Class Country
    Public Shared Function GetCountries() As IDictionary
        Dim res = New Dictionary(Of Integer, String)()
        res.Add(0, "Japan")
        res.Add(1, "USA")
        res.Add(2, "China")
        res.Add(3, "Germany")
        Return res
    End Function
End Class
