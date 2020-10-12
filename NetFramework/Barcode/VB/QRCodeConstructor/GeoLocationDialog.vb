
Imports C1.Win.C1Ribbon
Public Class GeoLocationDialog

    ''' <summary>
    ''' Initializes a new instance of the GeoLocationDialog class.
    ''' </summary>
    Public Sub New(ByVal webUrl As Uri, ByVal mapurl As Uri, ByVal vs As VisualStyle)

        InitializeComponent()

        brwsGetLatLon.Url = webUrl
        brwsMap.Url = mapurl
        VisualStyle = vs
    End Sub



    Private Sub btnWebOK_Click(sender As Object, e As EventArgs) Handles btnWebOK.Click

        Dim txt As String = brwsGetLatLon.Document.ActiveElement.InnerText
        Clipboard.SetText(txt)

    End Sub

    
End Class
