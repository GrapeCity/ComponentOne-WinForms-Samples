Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace FlowPanelСatalogue
    Public Class CatalogueItem
        Public Property Brand As String
        Public Property Model As String
        Public Property ItemImage As System.Drawing.Bitmap
        Public Property Category As String
        Public Property Description As String
        Public Property Details As String
        Public Property Cost As String

        Public Sub New(brand1 As String, model1 As String, itemImage1 As System.Drawing.Bitmap, category1 As String, description1 As String, details1 As String, cost1 As Integer)
            Brand = brand1
            Model = model1
            ItemImage = itemImage1
            Category = category1
            Description = DescriptionToMultiline(description1)
            Details = "<a href=""" & details1 & """>" & details1 & "</a>"
            Cost = "$" & CStr(cost1)
        End Sub

        Private Function DescriptionToMultiline(ByVal longDescription As String) As String
            longDescription = longDescription.Split(vbLf, "."c)(0)
            Dim multiline As String = ""
            Dim spaceInd As Integer
            Dim rowWidth As Integer = 30

            While longDescription.Length > rowWidth
                spaceInd = (longDescription.Substring(0, rowWidth)).LastIndexOf(" ")
                If spaceInd < 0 Then spaceInd = rowWidth
                multiline += longDescription.Substring(0, spaceInd) & vbLf & vbCr
                longDescription = longDescription.Substring(spaceInd + 1)
            End While

            multiline += longDescription
            Return multiline
        End Function
    End Class
End Namespace
