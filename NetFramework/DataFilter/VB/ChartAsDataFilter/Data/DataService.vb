Imports System.IO
Imports System.Web.Script.Serialization

Namespace ChartAsDataFilter.Data
    Public Class DataService
        Private Shared dt As List(Of Quote)

        Shared Sub New()
            Dim buildDir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Dim quotesPath = Path.Combine(buildDir, "Resources", "HistoricalQuotes.json")
            Dim text = File.ReadAllText(quotesPath)
            Dim jsonSerializer = New JavaScriptSerializer()
            dt = jsonSerializer.Deserialize(Of List(Of Quote))(text)
        End Sub

        Public Shared Function GetFinancialData(ByVal Optional count As Integer = 365) As List(Of Quote)
            count = Math.Min(count, dt.Count)
            Return dt.Take(count).OrderBy(Function(x) x.Day).ToList()
        End Function

        Public Shared Function GetFinancialData(ByVal startDate As DateTime, ByVal Optional count As Integer = 365) As List(Of Quote)
            Dim quotes = GetFinancialData(count)

            For Each quote In quotes
                quote.Day = startDate.AddDays(quotes.IndexOf(quote))
            Next

            Return quotes
        End Function
    End Class
End Namespace

