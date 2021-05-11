Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Generate()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        ' create the title of document
        Dim rp As New RenderParagraph()
        rp.Content.AddText("You can get coordinates and sizes of individual characters in a text block using the ")
        rp.Content.AddText("GetCharRect()", Color.Blue)
        rp.Content.AddText(" method of RenderText and RenderParagraph classes." & Environment.NewLine)
        rp.Content.AddText("In the following example each character has a red rectangle drawn around it.")
        rp.Style.Font = New Font("Verdana", 15)
        rp.Style.Spacing.Bottom = "3mm"
        rp.Style.Borders.Bottom = LineDef.DefaultBold
        rp.Style.TextAlignHorz = AlignHorzEnum.Justify
        doc.Body.Children.Add(rp)

        rp = New RenderParagraph()
        rp.Style.Font = New Font("Arial", 36)
        rp.Content.Add(New ParagraphText("Normal text", TextPositionEnum.Normal))
        rp.Content.Add(New ParagraphText("Super script text" & vbNewLine, TextPositionEnum.Superscript))
        rp.Content.Add(New ParagraphText("Sub script text" & vbNewLine, TextPositionEnum.Subscript))
        rp.Content.Add(New ParagraphText("Normal text. ", TextPositionEnum.Normal))
        rp.Content.Add(New ParagraphText("Sub script. ", TextPositionEnum.Subscript))
        rp.Content.Add(New ParagraphText("Super script. ", TextPositionEnum.Superscript))
        rp.Content.Add(New ParagraphText("Normal text." & vbNewLine))
        rp.Content.Add(New ParagraphText("Normal text Normal text Normal text Normal text Normal text Normal text Normal text Normal text."))
        doc.Body.Children.Add(rp)

        ' To use the GetCharRect method, we must first generate
        ' the document so that character positions are calculated.
        ' The generation will be later repeated with drawing
        ' red rectangles around the individual characters.
        doc.Generate()

        Dim textLength As Integer = rp.TextLength
        ' Fragments contain info about the rendered objects:
        ' get the first fragment of rp object
        Dim rpf As RenderParagraphFragment = CType(rp.Fragments(0), RenderParagraphFragment)
        ' go over all characters in the text
        Dim i As Integer
        For i = 0 To textLength
            ' get the coordinates of character,
            ' they will be returned in C1PrintDocument.ResolvedUnit units
            Dim charRect As RectangleD = rpf.GetCharRect(i)

            ' make a rectangle around the char
            Dim r As New RenderRectangle()
            ' specify all coordinates of rectangle
            r.X = New Unit(rpf.Bounds.Left + charRect.Left, doc.ResolvedUnit)
            r.Y = New Unit(rpf.Bounds.Top + charRect.Top, doc.ResolvedUnit)
            r.Width = New Unit(charRect.Width, doc.ResolvedUnit)
            r.Height = New Unit(charRect.Height, doc.ResolvedUnit)
            ' set shape (rectangle) coordinates, they are specified
            ' relative to object
            r.Rectangle.X = 0
            r.Rectangle.Y = 0
            r.Rectangle.Width = r.Width
            r.Rectangle.Height = r.Height
            r.Style.ShapeLine = New LineDef("1pt", Color.Red)
            ' add the rectangle to the object
            doc.Body.Children.Add(r)
        Next i
    End Sub
End Class
