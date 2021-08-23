Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Style.Font = New Font("Verdana", 14)

        ' create the title of the document
        Dim title As New RenderParagraph()
        title.Content.AddText("The new version of C1PrintDocumet provides the ")
        title.Content.AddText("PageLayouts", Color.Blue)
        title.Content.AddText(" property allowing to define separate page layouts for the first page, even pages, and odd pages.")
        title.Style.TextAlignHorz = AlignHorzEnum.Justify
        title.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
        doc.Body.Children.Add(title)

        ' define PageLayout for the first page
        Dim pl As New PageLayout()
        pl.PageSettings = New C1PageSettings()
        pl.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Legal
        doc.PageLayouts.FirstPage = pl

        ' define PageLayout for even pages
        pl = New PageLayout()
        pl.PageSettings = New C1PageSettings()
        pl.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        ' create the page header
        Dim ph As New RenderText()
        ph.Text = "Even page. [PageNo] / [PageCount]"
        ph.Style.Borders.All = LineDef.Default
        ph.Style.BackColor = Color.Beige
        pl.PageHeader = ph
        ' even pages will have no page footer, set it to an empty object
        pl.PageFooter = New RenderEmpty()
        doc.PageLayouts.EvenPages = pl

        ' define PageLayout for odd pages
        pl = New PageLayout()
        ' odd pages will have 2 columns
        pl.Columns.Add()
        pl.Columns.Add()
        pl.PageSettings = New C1PageSettings()
        pl.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter
        pl.PageSettings.Landscape = True
        ' create the page header
        ph = New RenderText()
        ph.Text = "Odd page. [PageNo] / [PageCount]"
        ph.Style.Borders.All = LineDef.DefaultBold
        ph.Style.BackColor = Color.LightSeaGreen
        pl.PageHeader = ph
        ' create the page footer
        Dim pf As New RenderText()
        pf.Text = "Footer of odd page. [PageNo] / [PageCount]"
        pf.Style.Borders.All = LineDef.DefaultBold
        pf.Style.BackColor = Color.SlateGray
        pl.PageFooter = pf
        doc.PageLayouts.OddPages = pl

        ' generate the content of document
        Dim ro As New RenderText("This is the first page of the document. It has no page header or footer, and has Legal size.")
        ro.BreakAfter = BreakEnum.Page
        doc.Body.Children.Add(ro)

        ' 
        Dim text As String = "This is the house  that Jack  built.  " & _
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

        Dim i As Integer
        For i = 0 To 5
            doc.Body.Children.Add(New RenderText(text, AlignHorzEnum.Justify))
        Next i
    End Sub
End Class
