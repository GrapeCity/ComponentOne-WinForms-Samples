Imports C1.C1Preview
Imports System.Text

Public Class Form1

    Private Sub BuildText(ByVal rt As RenderText, ByVal fragmentCount As Integer)
        Dim sb As StringBuilder = New StringBuilder
        Dim i As Integer = 0
        While i < fragmentCount
            sb.Append(String.Format("fragment{0} ", i))
            System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        If sb.Length > 0 Then
            sb.Remove(sb.Length - 1, 1)
        End If
        rt.Text = String.Format("Height = {0}, Width = {1}, TextAngle = {2}" & Microsoft.VisualBasic.Chr(13) & "", rt.Height, rt.Width, rt.Style.TextAngle) + sb.ToString
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doc.Style.Font = New Font("Verdana", 14)

        Dim rt As RenderText = New RenderText
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 46
        BuildText(rt, 40)
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 229
        BuildText(rt, 40)
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 46
        BuildText(rt, 10)
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        rt.Height = Unit.Auto
        rt.Width = Unit.Auto
        rt.Style.Borders.All = LineDef.Default
        BuildText(rt, 2)
        rt.Style.TextAngle = 46
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        rt.Height = Unit.Auto
        rt.Width = Unit.Auto
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 229
        BuildText(rt, 2)
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        rt.Height = Unit.Auto
        rt.Width = Unit.Auto
        rt.Style.Borders.All = LineDef.Default
        BuildText(rt, 2)
        rt.Style.TextAngle = 40
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        rt.Height = Unit.Auto
        rt.Width = Unit.Auto
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 190
        BuildText(rt, 2)
        doc.Body.Children.Add(rt)

        rt = New RenderText
        rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        rt.Height = "100mm"
        rt.Width = Unit.Auto
        rt.Style.Borders.All = LineDef.Default
        rt.Style.TextAngle = 270
        BuildText(rt, 50)
        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

End Class
