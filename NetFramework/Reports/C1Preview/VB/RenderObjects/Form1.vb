Imports C1.C1Preview
Imports C1.Win.C1Preview
Imports System.IO

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Reflow()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        ' clear the document
        doc.Clear()

        ' Set up basic page headers and footers:
        doc.PageLayout.PageHeader = New RenderText("RenderObjects sample")
        doc.PageLayout.PageHeader.Style.TextAlignHorz = AlignHorzEnum.Right
        doc.PageLayout.PageHeader.Style.Spacing.Bottom = "0.5cm"
        doc.PageLayout.PageHeader.Style.Borders.Bottom = LineDef.Default

        doc.PageLayout.PageFooter = New RenderText("Page [PageNo] of [PageCount]")
        doc.PageLayout.PageFooter.Style.TextAlignHorz = AlignHorzEnum.Right
        doc.PageLayout.PageFooter.Style.Spacing.Top = "0.5cm"
        doc.PageLayout.PageFooter.Style.Borders.Top = LineDef.Default


        '-------------
        ' RenderArea
        '-------------
        ' The general purpose container for other render objects
        ' We create an area for a few RenderText objects,
        ' and add it to another are which is a container for all elements in the document:
        Dim ra1 As New RenderArea()

        Dim ra2 As New RenderArea()
        ' set the back color for the area so its bounds are visible
        ra2.Style.BackColor = Color.AntiqueWhite
        ' keep the area to 60% of its parent's width
        ra2.Width = "60%"

        ' Add the area which will hold the render texts, to
        ' the bigger area which will hold all else
        ra1.Children.Add(ra2)

        '-------------
        ' RenderText
        '-------------
        ' Allows to output a block of text in a single style
            ' we also create an outline entry for each RenderText

        ' plain text using the default style
        Dim rt1 As New RenderText(Global.RenderObjects.My.Resources.strings.APOLOGIZE)
        doc.Outlines.Add("APOLOGIZE", rt1)

        ' different font and color
        Dim rt2 As New RenderText(Global.RenderObjects.My.Resources.strings.APPEAL, New Font("Arial", 16), Color.BlueViolet)
        doc.Outlines.Add("APPEAL", rt2)

        ' right-alignged text
        Dim rt3 As New RenderText(Global.RenderObjects.My.Resources.strings.BAROMETER, AlignHorzEnum.Right)
        doc.Outlines.Add("BAROMETER", rt3)

        ' justified text in a different font
        Dim rt4 As New RenderText(Global.RenderObjects.My.Resources.strings.BOTANY, New Font("Times New Roman", 14), AlignHorzEnum.Justify)
        doc.Outlines.Add("BOTANY", rt4)

        ' text with a different style
        ' styles can only exist on an object or as child styles of another style
        Dim s1 As Style = doc.Style.Children.Add()
        s1.BackColor = Color.Chartreuse
        s1.Padding.All = New Unit("3mm")
        s1.LineSpacing = 120
        Dim rt5 As New RenderText(Global.RenderObjects.My.Resources.strings.CALAMITY, s1)
        doc.Outlines.Add("CALAMITY", rt5)

        ' add RenderText's to the nested area
        ra2.Children.Add(rt1)
        ra2.Children.Add(rt2)
        ra2.Children.Add(rt3)
        ra2.Children.Add(rt4)
        ra2.Children.Add(rt5)

        '---------------
        ' RenderGraphics
        '---------------
        ' Allows to insert arbitrary GDI+ drawings in the document
        ' Note that RenderGraphics' size is by default automatically adjusted
        ' to the actual size of the drawing.
        Dim rg1 As New RenderGraphics()
        rg1.Graphics.DrawArc(Pens.Red, New Rectangle(0, 0, 30, 40), 0, 135)
        rg1.Graphics.DrawEllipse(Pens.Blue, New Rectangle(20, 20, 90, 45))
        rg1.Style.Borders.All = New LineDef("1mm", Color.CornflowerBlue)
        ra1.Children.Add(rg1)
        ' provide an outline entry for the RenderGraphics
        doc.Outlines.Add("RenderGraphics", rg1)

        '-------------
        ' RenderEmpty
        '-------------
        ' Allows to insert breaks in arbitrary locations w/out affecting other render objects
        Dim re1 As New RenderEmpty()
        re1.BreakAfter = BreakEnum.Column
        ra1.Children.Add(re1)

        '---------------
        ' RenderImage
        '---------------
        ' Allows to insert images in the document. Again, by default the size
        ' is determined by the size of the image
        Dim ri1 = New RenderImage(Global.RenderObjects.My.Resources.Resources.tn_img70)
        ra1.Children.Add(ri1)
        doc.Outlines.Add("RenderImage", ri1)

        '---------------
        ' RenderRichText
        '---------------
        ' Allows to insert RTF in the document
        Dim tr As New StreamReader(GetType(Form1).Assembly.GetManifestResourceStream("RenderObjects.Rich_Text_Format.rtf"))
        Dim rrt1 As New RenderRichText(tr.ReadToEnd())
        tr.Close()
        ra1.Children.Add(rrt1)
        doc.Outlines.Add("RenderRichText", rrt1)

        '--------------
        ' RenderPolygon
        '--------------
        ' A bunch of classes derived from RenderShapeBase provide shapes - 
        ' lines, polygons and rectangles. Here we draw a polygon:
        Dim rpoly1 As New RenderPolygon()
        rpoly1.Line.Points = New UnitPoint() { _
                New UnitPoint("0.5cm", "0.5cm"), _
                New UnitPoint("2.0cm", "1cm"), _
                New UnitPoint("3.5cm", "0cm"), _
                New UnitPoint("6cm", "4cm"), _
                New UnitPoint("3cm", "5cm") _
            }
        rpoly1.Line.Closed = True
        ' set the fill color
        rpoly1.Style.ShapeFillColor = Color.Gainsboro
        ' pad on all sides, otherwise corners may end up outside of the
        ' RenderPolygon area and get clipped:
        rpoly1.Style.Padding.All = "0.5cm"
        rpoly1.Style.BackColor = Color.Cornsilk
        ra1.Children.Add(rpoly1)
        doc.Outlines.Add("RenderPolygon", rpoly1)

        '------------
        ' RenderTable
        '------------
        ' Allows to draw tables. Tables are very powerful and can be used
        ' both for data presentation and as layout tools. Here we show
        ' some very basic tables functionality:
        Dim rtbl1 As New RenderTable()
        ' tables are logically infinte, just touching a cell creates it:
        Dim row, col As Integer
        For row = 0 To 100
            For col = 0 To 4
                rtbl1.Cells(row, col).Text = String.Format("Cell ({0}, {1})", row, col)
            Next col
        Next row

        ' column (see below, in headers) and row spans are supported,
        ' as alignment within cells, borders around cells and more:
        rtbl1.Cells(8, 1).SpanRows = 6
        rtbl1.Cells(8, 1).Style.BackColor = Color.Gold
        rtbl1.Cells(8, 1).Style.TextAlignVert = AlignVertEnum.Center
        rtbl1.Cells(8, 1).Style.TextAlignHorz = AlignHorzEnum.Center
        rtbl1.Cells(8, 1).Style.Borders.All = LineDef.DefaultBold

        ' table header is just a flag on some rows:
        rtbl1.Rows.Insert(0, 1)
        rtbl1.RowGroups(0, 1).PageHeader = True
        rtbl1.Cells(0, 0).SpanCols = rtbl1.Cols.Count
        rtbl1.Cells(0, 0).Text = "This is table header"
        rtbl1.Cells(0, 0).Style.TextAlignHorz = AlignHorzEnum.Center
        rtbl1.Cells(0, 0).Style.BackColor = Color.LemonChiffon
        ' ditto for the table footer:
        ' (again, just touching a row adds it):
        Dim n As Integer = rtbl1.Rows.Count
        rtbl1.RowGroups(n, 1).PageFooter = True
        rtbl1.Cells(n, 0).SpanCols = rtbl1.Cols.Count
        rtbl1.Cells(n, 0).Text = "This is table footer"
        rtbl1.Cells(n, 0).Style.TextAlignHorz = AlignHorzEnum.Center
        rtbl1.Cells(n, 0).Style.BackColor = Color.LemonChiffon
        ' by default, tables have no grid lines. add some:
        rtbl1.Style.GridLines.All = LineDef.Default

        ' Using RenderEmpty, we can add outline nodes to start and end of table:
        Dim rtbl1Beg = New RenderEmpty()
        Dim rtbl1End = New RenderEmpty()
        ra1.Children.Add(rtbl1Beg)
        ra1.Children.Add(rtbl1)
        ra1.Children.Add(rtbl1End)
        doc.Outlines.Add("Table - first row", rtbl1Beg)
        doc.Outlines.Add("Table - last row", rtbl1End)

        '---------------
        ' RenderParagraph
        '---------------
        ' Allows to render milti-line text, inline images, and hyperlinks within text
        ' Create paragraph
        Dim rpar1 = New RenderParagraph()
        Dim f As New Font(CType(rpar1.Style.Font, Font), CType(FontStyle.Bold, FontStyle))
        rpar1.Content.AddText("This is a paragraph. This is normal text. ")
        rpar1.Content.AddText("This text is bold. ", f)
        rpar1.Content.AddText("This text is red. ", Color.Red)
        rpar1.Content.AddText("This text is superscript. ", TextPositionEnum.Superscript)
        rpar1.Content.AddText("This text is bold and red. ", f, Color.Red)
        rpar1.Content.AddText("This text is bold and red and subscript. ", f, Color.Red, TextPositionEnum.Subscript)
        rpar1.Content.AddText("This is normal text again. ")
        rpar1.Content.AddHyperlink("This is a link to the start of the document.", ra1)
        rpar1.Content.AddText("Finally, here is an inline image: ")
        rpar1.Content.AddImage(Me.Icon.ToBitmap())
        rpar1.Content.AddText(".")
        ' Add paragraph to the area
        ra1.Children.Add(rpar1)
        ' and an outline entry to point to it:
        doc.Outlines.Add("RenderParagraph", rpar1)

        ' we're done. Add the outer RenderArea to the document:
        doc.Body.Children.Add(ra1)

    End Sub
End Class
