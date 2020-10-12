Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Tahoma", 16)

        Dim rt As New RenderText()
        rt.Text = _
            "The RenderText and RenderParagraph objects provide the TabPositions property " & _
            "that allows to define the positions of tabs in the text. " & _
            "This property works similar to tabs in MS Word. " & _
            "The following text has 2 tab positions: in the middle of the page, and " & _
            "at the right edge of the page."
        rt.Style.Borders.Bottom = LineDef.DefaultBold
        rt.Style.Spacing.Bottom = "3mm"
        rt.Style.TextAlignHorz = AlignHorzEnum.Justify
        doc.Body.Children.Add(rt)

        Dim rp As New RenderParagraph()
        ' add the tab in the middle of object
        rp.TabPositions.Add(New C1.C1Preview.TabPosition("width / 2", TabAlignmentEnum.Center))
        ' add the tab at the right edge of object
        rp.TabPositions.Add(New C1.C1Preview.TabPosition("width", TabAlignmentEnum.Right))
        Dim i As Integer
        For i = 0 To 3
            rp.Content.AddText("left text", Color.Red)
            rp.Content.AddText(vbTab)
            rp.Content.AddText("center text", Color.Green)
            rp.Content.AddText(vbTab)
            rp.Content.AddText("right text", Color.Blue)
            ' forces a new line
            rp.Content.AddText(vbCr)
        Next i

        doc.Body.Children.Add(rp)
    End Sub
End Class
