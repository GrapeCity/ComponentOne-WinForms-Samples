Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Tahoma", 15)

        ' create the top-level page header for the document
        Dim rt As New RenderText()
        rt.Text = "Header. Page [PageNo] of [PageCount]"
        rt.Style.Borders.Bottom = LineDef.DefaultBold
        rt.Style.Spacing.Bottom = "2mm"
        doc.PageLayout.PageHeader = rt

        ' create the top-level page footer for the document
        rt = New RenderText()
        rt.Text = "Footer. Page [PageNo] of [PageCount]"
        rt.Style.Borders.Top = LineDef.DefaultBold
        rt.Style.Spacing.Top = "2mm"
        doc.PageLayout.PageFooter = rt

        ' add content (text describing this sample) to the document body
        doc.Body.Children.Add(New RenderText(doc, _
            "The following object starts with a page break, and changes the page layout. " & _
            "The change is nested so the original (current) page layout will be automatically " & _
            " restored when the nested object ends."))

        ' create the object that changes the page layout
        Dim content As New RenderText()
        content.Style.TextAlignHorz = AlignHorzEnum.Justify
        ' add dummy text to fill the document
        content.Text = Text1 + Text1 + Text1 + Text1 + Text1

        ' create the object describing the nested layout.
        ' Several types based on LayoutChangeBase are provided,
        ' for layouts starting with page/column breaks or no breaks.
        Dim lcnp As New LayoutChangeNewPage()
        ' Set the LayoutChangeNewPage to the LayoutChangeBefore property
        ' of the "content" object:
        content.LayoutChangeBefore = lcnp

        ' setup the properties of the LayoutChangeNewPage. In particular,
        ' set Nested to true, it forces restoring of the previous page layout when
        ' the object is over
        lcnp.Nested = True
        ' create new page layout on the "layout change" object:
        lcnp.PageLayout = New PageLayout()
        ' force landscape
        lcnp.PageLayout.PageSettings = New C1PageSettings()
        lcnp.PageLayout.PageSettings.Landscape = True
        ' add page columns
        lcnp.PageLayout.Columns.Add()
        lcnp.PageLayout.Columns.Add()
        ' create the (nested) page header
        rt = New RenderText()
        rt.Text = "This is page header of the nested object." & Environment.NewLine & "Page [PageNo] of [PageCount]"
        rt.Style.BackColor = Color.Cornsilk
        rt.Style.Borders.Bottom = LineDef.DefaultBold
        rt.Style.Spacing.Bottom = "2mm"
        lcnp.PageLayout.PageHeader = rt
        ' create the (nested) page header
        rt = New RenderText()
        rt.Text = "This is page footer of the nested object." & Environment.NewLine & "Page [PageNo] of [PageCount]"
        rt.Style.BackColor = Color.Cornsilk
        rt.Style.Borders.Top = LineDef.DefaultBold
        rt.Style.Spacing.Top = "2mm"
        lcnp.PageLayout.PageFooter = rt

        ' add content to the document
        doc.Body.Children.Add(content)

        ' add text *after* the "content" object, to demonstrate
        ' that the top-level page layout is automatically restored:
        doc.Body.Children.Add(New RenderText(doc, _
            "This is the object AFTER the content object with the nested page layout."))

    End Sub

    Dim Text1 As String = "This is the house  that Jack  built.  " & _
"This is the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the rat,  " & _
"That ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the dog  that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the maiden  all forlorn,  " & _
"That milked  the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.   " & _
"This is the man  all tattered and torn, " & _
"That kissed  the maiden  all forlorn,  " & _
"That milked  the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the priest  all shaven and shorn, " & _
"That married the man  all tattered and torn, " & _
"That kissed  the maiden  all forlorn,  " & _
"That milked  the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the cock  that crowed  in the morn,  " & _
"That waked the priest  all shaven and shorn, " & _
"That married the man  all tattered and torn, " & _
"That kissed  the maiden  all forlorn,  " & _
"That milked  the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  " & _
"This is the farmer  sowing the corn,   " & _
"That kept the cock  that crowed  in the morn,   " & _
"That waked the priest  all shaven and shorn, " & _
"That married the man  all tattered and torn, " & _
"That kissed  the maiden  all forlorn,  " & _
"That milked  the cow  with the crumbled horn, " & _
"That tossed the dog , that worried the cat,  " & _
"That chased the rat , that ate the carrot,  " & _
"That lay in the house  that Jack  built.  "

End Class
