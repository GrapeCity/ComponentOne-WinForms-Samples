Imports C1.C1Preview
Imports System.Text

Public Class Form1

    Private Sub GenerateDoc(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Verdana", 18)


        Dim rt As RenderText = New RenderText()
        rt.Text = "New style property:" & Environment.NewLine & "Unit Style.CharSpacing { get; set; }" & Environment.NewLine & "Allows to define the space between character in text, it is zero by default."
        rt.Style.Borders.All = New LineDef("1mm", Color.Red)
        rt.Style.Spacing.Bottom = "10mm"
        doc.Body.Children.Add(rt)


        Dim cs As Unit = "2mm"
        doc.Body.Children.Add(New RenderText("CharSpacing: " + cs.ToString()))
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
        rt.Style.CharSpacing = cs
        doc.Body.Children.Add(rt)


        cs = "-2pt"
        doc.Body.Children.Add(New RenderText("CharSpacing: " + cs.ToString()))
        rt = New RenderText()
        sb = New StringBuilder()
        For i = 0 To 29
            sb.Append(String.Format("Fragment{0} ", i))
        Next
        sb.Remove(sb.Length - 1, 1)
        rt.Text = sb.ToString()
        rt.Style.Borders.All = LineDef.Default
        rt.Style.BackColor = Color.LawnGreen
        rt.Style.CharSpacing = cs
        doc.Body.Children.Add(rt)


        doc.Generate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GenerateDoc(Me.doc)
    End Sub
End Class
