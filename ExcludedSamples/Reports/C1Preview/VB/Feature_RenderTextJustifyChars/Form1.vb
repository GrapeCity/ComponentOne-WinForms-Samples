Imports C1.C1Preview
Imports System.Text

Public Class Form1

    Private Sub GenerateDoc(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Verdana", 18)

        Dim rt As RenderText = New RenderText()
        rt.Text = "New mode of horizontal text alignment: AlignHorzEnum.JustifyChars." & Environment.NewLine & "Spaces added between all chars rather than only between words as is the case with AlignHorzEnum.Justify."
        rt.Style.Borders.All = New LineDef("1mm", Color.Red)
        rt.Style.Spacing.Bottom = "10mm"
        doc.Body.Children.Add(rt)

        doc.Body.Children.Add(New RenderText("AlignHorzEnum.JustifyChars:"))
        rt = New RenderText()
        Dim sb As StringBuilder = New StringBuilder()
        Dim i As Integer
        For i = 0 To 29
            sb.Append(String.Format("Fragment{0} ", i))
        Next
        sb.Remove(sb.Length - 1, 1)
        rt.Text = sb.ToString()
        rt.Style.Borders.All = LineDef.Default
        rt.Style.BackColor = Color.LawnGreen
        rt.Style.TextAlignHorz = AlignHorzEnum.JustifyChars
        doc.Body.Children.Add(rt)


        doc.Body.Children.Add(New RenderText("AlignHorzEnum.Justify:"))
        rt = New RenderText()
        sb = New StringBuilder()
        For i = 0 To 29
            sb.Append(String.Format("Fragment{0} ", i))
        Next
        sb.Remove(sb.Length - 1, 1)
        rt.Text = sb.ToString()
        rt.Style.Borders.All = LineDef.Default
        rt.Style.BackColor = Color.LawnGreen
        rt.Style.TextAlignHorz = AlignHorzEnum.Justify
        doc.Body.Children.Add(rt)


        doc.Generate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerateDoc(doc)
    End Sub
End Class
