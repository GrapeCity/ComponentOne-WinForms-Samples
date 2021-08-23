Imports C1.C1Preview
Imports System.Text

Public Class Form1

    Private Sub GenerateDoc(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Verdana", 18)

        Dim rt As RenderText = New RenderText()
        rt.Text = "New style property:" & Environment.NewLine & "float Style.CharWidth { get; set; }" & Environment.NewLine & "Allows to define the width of text characters, it is define a percent of width relative to normal width i.e. 100 - normal width (default), 200 - 2times wider."
        rt.Style.Borders.All = New LineDef("1mm", Color.Red)
        rt.Style.Spacing.Bottom = "10mm"
        doc.Body.Children.Add(rt)


        Dim cw As Double = 200
        doc.Body.Children.Add(New RenderText("CharWidth: " + cw.ToString()))
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
        rt.Style.CharWidth = cw
        doc.Body.Children.Add(rt)


        cw = 50
        doc.Body.Children.Add(New RenderText("CharWidth: " + cw.ToString()))
        rt = New RenderText()
        sb = New StringBuilder()
        For i = 0 To 29
            sb.Append(String.Format("Fragment{0} ", i))
        Next
        sb.Remove(sb.Length - 1, 1)
        rt.Text = sb.ToString()
        rt.Style.Borders.All = LineDef.Default
        rt.Style.BackColor = Color.LawnGreen
        rt.Style.CharWidth = cw
        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GenerateDoc(doc)
    End Sub
End Class
