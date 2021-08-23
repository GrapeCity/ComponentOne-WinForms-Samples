Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Function CreateObj(ByVal txt As String)
        Dim result As New RenderText()
        result.Text = Text
        result.Style.Borders.All = New LineDef("1mm", Color.Blue)
        result.Style.TextAlignHorz = AlignHorzEnum.Center
        result.Style.TextAlignVert = AlignVertEnum.Center
        result.Style.BackColor = Color.LightSkyBlue
        result.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge
        result.Width = "7cm"
        result.Height = "4cm"
        CreateObj = result
    End Function

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        ' title of document
        Dim rt As New RenderText("Stacking and positioning of objects")
        rt.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
        doc.Body.Children.Add(rt)

        ' document will contains the TOC
        Dim toc As New RenderToc()

        ' 1. Demonstrate StackingRulesEnum.BlockTopToBottom
        Dim title As New RenderText("Demonstrates StackingRulesEnum.BlockTopToBottom stacking")
        title.BreakBefore = BreakEnum.Page
        doc.Body.Children.Add(title)
        Dim area As New RenderArea()
        area.Stacking = StackingRulesEnum.BlockTopToBottom
        Dim i As Integer
        For i = 1 To 11
            area.Children.Add(CreateObj(String.Format("OBJECT {0}", i)))
        Next i
        doc.Body.Children.Add(area)

        toc.AddItem("Stacking", title, 1)
        toc.AddItem("StackingRulesEnum.BlockTopToBottom", title, 2)

        ' 2. Demonstrate the StackingRulesEnum.BlockLeftToRight
        title = New RenderText("Demonstrates StackingRulesEnum.BlockLeftToRight stacking")
        title.BreakBefore = BreakEnum.Page
        doc.Body.Children.Add(title)
        area = New RenderArea()
        ' by default the RenderArea has a width = "parent.width" so we set it to
        ' auto to show all child objects
        area.Width = Unit.Auto
        ' by default the RenderArea does not split by horizontally...
        area.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded
        area.Stacking = StackingRulesEnum.BlockLeftToRight
        For i = 1 To 5
            area.Children.Add(CreateObj(String.Format("OBJECT {0}", i)))
        Next i
        doc.Body.Children.Add(area)

        toc.AddItem("StackingRulesEnum.BlockLeftToRight", title, 2)

        ' 3. Demonstrate the StackingRulesEnum.InlineLeftToRight
        title = New RenderText("Demonstrates StackingRulesEnum.InlineLeftToRight stacking")
        title.BreakBefore = BreakEnum.Page
        doc.Body.Children.Add(title)
        area = New RenderArea()
        area.Stacking = StackingRulesEnum.InlineLeftToRight
        For i = 1 To 11
            area.Children.Add(CreateObj(String.Format("OBJECT {0}", i)))
        Next i
        doc.Body.Children.Add(area)

        toc.AddItem("StackingRulesEnum.InlineLeftToRight", title, 2)

        ' 4. The positioning of objects
        title = New RenderText("Each object starting with the second one is positioned relative to the previous object.")
        title.BreakBefore = BreakEnum.Page
        doc.Body.Children.Add(title)

        doc.Body.Children.Add(CreateObj("FIRST OBJECT"))
        For i = 2 To 6
            Dim ro = CreateObj(String.Format("OBJECT {0}", i))
            ro.X = "prev.Left + 1cm"
            ro.Y = "prev.Top + 1cm"
            doc.Body.Children.Add(ro)
        Next i

        toc.AddItem("Positioning", title, 1)

        doc.Body.Children.Insert(1, toc)

    End Sub
End Class
