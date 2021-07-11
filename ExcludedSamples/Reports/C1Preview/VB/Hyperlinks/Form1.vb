Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        ' setup a page header with links to first|prev|next|last pages:
        Dim rtnav As New RenderTable()
        ' suppress different display of visited hyperlinks for page navigator:
        rtnav.Style.VisitedHyperlinkAttrs = rtnav.Style.HyperlinkAttrs
        ' space things out
        rtnav.Style.Spacing.Bottom = "5mm"
        ' add navigator links
        rtnav.Cells(0, 0).Text = "First page"
        rtnav.Cells(0, 0).RenderObject.Hyperlink = New C1Hyperlink( _
            New C1LinkTargetPage(PageJumpTypeEnum.First), "Go to first page")
        rtnav.Cells(0, 1).Text = "Previous page"
        rtnav.Cells(0, 1).RenderObject.Hyperlink = New C1Hyperlink( _
            New C1LinkTargetPage(PageJumpTypeEnum.Previous), "Go to previous page")
        rtnav.Cells(0, 2).Text = "Next page"
        rtnav.Cells(0, 2).RenderObject.Hyperlink = New C1Hyperlink( _
            New C1LinkTargetPage(PageJumpTypeEnum.Next), "Go to next page")
        rtnav.Cells(0, 3).Text = "Last page"
        rtnav.Cells(0, 3).RenderObject.Hyperlink = New C1Hyperlink( _
            New C1LinkTargetPage(PageJumpTypeEnum.Last), "Go to last page")
        doc.PageLayout.PageHeader = rtnav

        ' make the body of the document

        ' make an anchor
        Dim rt1 As New RenderText("This is text with anchor1.")
        ' the name ("anchor1") will be used to jump to this link:
        rt1.Anchors.Add(New C1Anchor("anchor1"))
        rt1.Hyperlink = New C1Hyperlink(New C1LinkTargetPage(PageJumpTypeEnum.Last), _
            "Go to the last page of the document")
        doc.Body.Children.Add(rt1)

        '--------------------------------------------------------------------
        ' make an external document to jump to:
        Dim doc2 As New C1PrintDocument()
        Dim doc2rt As New RenderText("This is Document 2.")
        doc2rt.Style.Spacing.All = "3mm"
        doc2rt.Style.Font = New Font("Arial", 14)
        ' anchor names must be unique within the document but not across documents
        doc2rt.Anchors.Add(New C1Anchor("anchor1"))
        doc2.Body.Children.Add(doc2rt)
        ' make a button in the new document to go back
        Dim doc2btn As New RenderInputButton("Go back...")
        doc2btn.Width = "3cm"
        doc2btn.Height = "1cm"
        doc2btn.InputActions.Add(UserActionEnum.Click, New ActionHandlerHistoryPrev())
        doc2.Body.Children.Add(doc2btn)
        doc2.Generate()
        ' save the document in our run dir:
        Dim doc2path As String = Application.StartupPath + "\doc2.c1d"
        doc2.Save(doc2path)
        '--------------------------------------------------------------------

        ' add a link to open doc2:
        Dim rt2 As New RenderText("Click here to open Document 2.")
        rt2.Hyperlink = New C1Hyperlink( _
            New C1LinkTargetExternalAnchor(doc2path, "anchor1"))
        doc.Body.Children.Add(rt2)

        ' add filler
        Dim i
        For i = 0 To 500
            doc.Body.Children.Add(New RenderText(String.Format("... filler {0} ...", i)))
        Next

        ' add hyperlink to anchor1
        Dim rt3 As New RenderText("Click here to go to anchor1.")
        rt3.Hyperlink = New C1Hyperlink(New C1LinkTargetAnchor("anchor1"), _
            "This is status text when the mouse hovers over link to anchor1")
        doc.Body.Children.Add(rt3)

        ' to jump to a render object, an anchor is really not needed:
        Dim rt4 As New RenderText("Click here to go to the middle of document.")
        Dim middle As Integer = doc.Body.Children.Count / 2
        rt4.Hyperlink = New C1Hyperlink(doc.Body.Children(middle))
        rt4.Hyperlink.StatusText = "Go to the approximate middle of the document"
        doc.Body.Children.Add(rt4)

        ' add image with hyperlink to a URL
        Dim ri1 As New RenderImage(Global.Hyperlinks.My.Resources.Resources.google)
        ri1.Hyperlink = New C1Hyperlink(New C1LinkTargetFile("http://www.google.com"), "Go googling...")
        doc.Body.Children.Add(ri1)

    End Sub
End Class
