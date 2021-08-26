Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Reflow()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Clear()

        Dim rtxt1 As New RenderText(doc)
        rtxt1.Text = "This test shows the basic features of tables in C1PrintDocument:" & vbCr & _
                vbTab & "- table borders (the GridLines style property, which allows to specify 4 outer and 2 inner lines)" & vbCr & _
                vbTab & "- borders around individual cells and groups of cells" & vbCr & _
                vbTab & "- style attributes (including borders) for groups of disconnected cells" & vbCr & _
                vbTab & "- cells spanning rows and columns" & vbCr & _
                vbTab & "- content alignment within the cells (spanned or otherwise)" & vbCr & _
                vbTab & "- table headers and footers" & vbCr & _
                vbTab & "- tags (such as page number/total page count) anywhere in the document (see the table footer)" & vbCr & _
                vbTab & "- different style attributes including borders, font and background images." & vbCr & _
                vbTab & vbCr

        rtxt1.Style.Font = New Font(rtxt1.Style.Font.FontFamily, 14)
        rtxt1.Style.Padding.Bottom = New Unit("5mm")
        doc.Body.Children.Add(rtxt1)

        '
        ' make a table and fill all its cells with some demo data
        Dim rt1 As New RenderTable(doc)
        Dim ROWS As Integer = 100
        Dim COLS As Integer = 4
        Dim row, col As Integer
        For row = 0 To ROWS
            For col = 0 To COLS
                Dim celltext As New RenderText(doc)
                celltext.Text = String.Format("Cell ({0},{1})", row, col)
                ' Note that rt1.Cells(row, col) will create cells on demand -
                ' no need to specify the number of rows/cols initially.
                rt1.Cells(row, col).RenderObject = celltext
            Next col
        Next row
        ' add the table to the document
        doc.Body.Children.Add(rt1)

        '
        ' unlike the old print-doc, in the new one changes can be made at any
        ' point in the program, and they will be reflected in the document when
        ' it is rendered. Add some customizations to the table:

        '
        ' by default, tables have no borders. add a simple border:
        rt1.Style.GridLines.All = New LineDef("2pt", Color.DarkGray)
        rt1.Style.GridLines.Horz = New LineDef("1pt", Color.Blue)
        rt1.Style.GridLines.Vert = New LineDef("1pt", Color.Brown)

        '
        ' table headers and footers

        ' add a table header:
        ' setup the header as a whole
        rt1.RowGroups(0, 2).PageHeader = True
        rt1.RowGroups(0, 2).Style.BackgroundImage = Global.Tables2.My.Resources.Resources.orange
        rt1.RowGroups(0, 2).Style.BackgroundImageAlign.StretchHorz = True
        rt1.RowGroups(0, 2).Style.BackgroundImageAlign.StretchVert = True
        rt1.RowGroups(0, 2).Style.BackgroundImageAlign.KeepAspectRatio = False
        ' multiple inheritance supported in styles: the text color from the
        ' group's style will merge with the font from the cell's own style:
        rt1.RowGroups(0, 2).Style.TextColor = Color.LightGreen
        rt1.RowGroups(0, 2).Style.GridLines.All = New LineDef("2pt", Color.DarkCyan)
        rt1.RowGroups(0, 2).Style.GridLines.Horz = LineDef.Empty
        rt1.RowGroups(0, 2).Style.GridLines.Vert = LineDef.Empty
        ' setup specific cells in the header:
        CType(rt1.Cells(0, 0).RenderObject, RenderText).Text = "Header row 0"
        CType(rt1.Cells(1, 0).RenderObject, RenderText).Text = "Header row 1"
        rt1.Cells(0, 1).SpanCols = 2
        rt1.Cells(0, 1).SpanRows = 2
        rt1.Cells(0, 1).RenderObject = New RenderText(doc)
        CType(rt1.Cells(0, 1).RenderObject, RenderText).Text = "Multi-row table headers and footers are supported"
        rt1.Cells(0, 1).Style.TextAlignHorz = AlignHorzEnum.Center
        rt1.Cells(0, 1).Style.Font = New Font("Arial", 14, FontStyle.Bold)

        ' setup a table footer
        rt1.RowGroups(rt1.Rows.Count - 2, 2).PageFooter = True
        rt1.RowGroups(rt1.Rows.Count - 2, 2).Style.BackColor = Color.LemonChiffon
        rt1.Cells(rt1.Rows.Count - 2, 0).SpanRows = 2
        rt1.Cells(rt1.Rows.Count - 2, 0).SpanCols = rt1.Cols.Count - 1
        rt1.Cells(rt1.Rows.Count - 2, 0).Style.TextAlignHorz = AlignHorzEnum.Center
        rt1.Cells(rt1.Rows.Count - 2, 0).Style.TextAlignVert = AlignVertEnum.Center
        CType(rt1.Cells(rt1.Rows.Count - 2, 0).RenderObject, RenderText).Text = "This is a table footer."
        rt1.Cells(rt1.Rows.Count - 2, 3).SpanRows = 2
        rt1.Cells(rt1.Rows.Count - 2, 3).Style.TextAlignHorz = AlignHorzEnum.Right
        ' tags (such as page no/page count) can be inserted anywhere in the document
        CType(rt1.Cells(rt1.Rows.Count - 2, 3).RenderObject, RenderText).Text = "Page (PageNo) of (PageCount)"

        '
        ' in tables, Style.Borders merges seamlessly into the table grid lines:

        ' it is easy to put a border around specific cells:
        rt1.Cells(8, 3).Style.Borders.All = New LineDef("3pt", Color.OrangeRed)
        CType(rt1.Cells(8, 3).RenderObject, RenderText).Text = "It is easy to put a border around a single cell using cell.Style.Borders"

        '
        ' cells can be combined into groups, and their styles can be manipulated as
        ' a single entity:

        ' define a group of cells by specifying the rectangles bounding the cells:
        CType(rt1.Cells(3, 2).RenderObject, RenderText).Text = _
            "Cells can be combined into groups to be manipulated as a single entity " & _
            "(such as all cells with the pale green background in this table)."
        rt1.Cells(3, 2).SpanCols = 2
        rt1.Cells(3, 2).SpanRows = 3
        Dim cells1() As Rectangle = { _
            New Rectangle(2, 3, 2, 3), _
            New Rectangle(0, 10, 3, 2), _
            New Rectangle(1, 23, 2, 4), _
            New Rectangle(1, 36, 1, 24), _
            New Rectangle(0, 72, 3, 6) _
            }
        Dim grp1 As New UserCellGroup(cells1)
        grp1.Style.BackColor = Color.PaleGreen
        grp1.Style.Font = New Font("Arial", 12, FontStyle.Bold)
        grp1.Style.Borders.All = New LineDef("2pt", Color.DarkGreen)
        rt1.UserCellGroups.Add(grp1)


        ' row/col span
        CType(rt1.Cells(14, 1).RenderObject, RenderText).Text = _
            "Column and row spans are fully supported, as well as alignment within the (spanned or not) cells."
        rt1.Cells(14, 1).SpanCols = 3
        rt1.Cells(14, 1).SpanRows = 5
        rt1.Cells(14, 1).Style.Font = New Font("Arial", 12, FontStyle.Bold Or FontStyle.Italic)
        rt1.Cells(14, 1).Style.Borders.All = New LineDef("2pt", Color.DarkOrange)
        rt1.Cells(14, 1).Style.TextAlignHorz = AlignHorzEnum.Center
        rt1.Cells(14, 1).Style.TextAlignVert = AlignVertEnum.Center
        rt1.RowGroups(14, 5).SplitBehavior = SplitBehaviorEnum.SplitIfLarge
    End Sub

End Class
