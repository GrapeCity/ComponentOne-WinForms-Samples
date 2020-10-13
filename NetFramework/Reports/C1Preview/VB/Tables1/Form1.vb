Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Reflow()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Clear()

        Dim rnd As New Random(DateTime.Now.Millisecond)

        Dim n As Integer
        ' make a table
        Dim rt1 As New RenderTable()
        ' set up some styles on the table
        '
        ' Note: all style attributes are divided into ambient and non-ambient.
        ' Ambient attributes affect the data itself, whereas non-ambient attributes
        ' are those affecting the decorations. Examples of ambient are:
        ' Font, TextColor, text alignment. Examples of non-ambient are:
        ' Borders, Padding, Spacing.
        ' Ambient attributes are propagated via the objects containment,
        ' so that e.g. setting the Font on the table will affect text in cells.
        ' Non-ambient attributes are inherited via the styles hierarchy. In tables,
        ' to set a non-ambient on all cells, table.CellStyle should be used. Ambient
        ' attributes can be set via table.Style:
        rt1.Style.GridLines.All = LineDef.Default
        rt1.Style.TextAlignHorz = AlignHorzEnum.Right
        rt1.Style.Font = New Font("Courier New", 12)
        rt1.Style.TextColor = Color.Green
        rt1.CellStyle.Padding.All = "1mm"

        ' fill the table with more or less random data
        Dim nrows As Integer = rnd.Next(100, 500)
        Dim ncols As Integer = rnd.Next(2, 4)

        Dim row, col As Integer
        For row = 0 To nrows
            For col = 0 To ncols
                n = rnd.Next()
                rt1.Cells(row, col).Text = n.ToString()
                If rt1.Cells(nrows, col).Tag Is Nothing Then
                    rt1.Cells(nrows, col).Tag = n
                Else
                    rt1.Cells(nrows, col).Tag = n + CType(rt1.Cells(nrows, col).Tag, Long)
                End If
            Next col
        Next row

        ' table headers and footers are implemented as row groups.

        ' The header:
        ' insert 2 rows for the header at the top:
        rt1.Rows.Insert(0, 2)
        ' mark the top row as a table header (not repeated),
        ' set it up appropriately:
        rt1.RowGroups(0, 1).Header = TableHeaderEnum.None
        rt1.RowGroups(0, 1).Style.BackColor = Color.GreenYellow
        rt1.Cells(0, 0).SpanCols = rt1.Cols.Count
        rt1.Cells(0, 0).Text = _
            "This table is filled with random data. It also has a table header (this text), " + _
            "running headers with column captions, running footers duplicating the running headers, " + _
            "and a footer which prints the column totals."
        rt1.Cells(0, 0).Style.TextAlignHorz = AlignHorzEnum.Center
        rt1.Cells(0, 0).Style.Font = New Font("Courier New", 14, FontStyle.Bold)
        ' mark the 2nd row as a page header (i.e. repeated on each page).
        rt1.RowGroups(1, 1).Header = TableHeaderEnum.All
        rt1.RowGroups(1, 1).Style.TextColor = Color.Honeydew
        rt1.RowGroups(1, 1).Style.BackColor = Color.DarkKhaki
        For col = 0 To ncols
            rt1.Cells(1, col).Text = String.Format("Column {0}", col)
        Next col

        ' The footer:
        ' We used the last row for totals. We push it down
        ' (to be printed at the very bottom of the table), and add
        ' a "running footer" in front, with column headers to be
        ' printed on each page:
        n = rt1.Rows.Count - 1
        rt1.Rows.Insert(n, 1)
        ' Orphan control:
        ' this line makes sure that at least 3 lines are printed before the
        ' footer on the same page.
        rt1.RowGroups(n, 1).MinVectorsBefore = 3
        rt1.RowGroups(n, 1).Footer = TableFooterEnum.All
        rt1.RowGroups(n, 1).Style.TextColor = rt1.RowGroups(1, 1).Style.TextColor
        rt1.RowGroups(n, 1).Style.BackColor = rt1.RowGroups(1, 1).Style.BackColor
        For col = 0 To ncols
            rt1.Cells(n, col).Text = rt1.Cells(1, col).Text
        Next col

        ' the final footer with totals and a line saying "the end":
        n = rt1.Rows.Count - 1
        rt1.RowGroups(n, 2).Footer = TableFooterEnum.None
        rt1.RowGroups(n, 2).Style.BackColor = Color.SandyBrown
        For col = 0 To ncols
            rt1.Cells(n, col).Text = CType(rt1.Cells(n, col).Tag, Long).ToString()
        Next col
        rt1.Cells(n + 1, 0).SpanCols = rt1.Cols.Count
        rt1.Cells(n + 1, 0).Text = "The end."
        rt1.Cells(n + 1, 0).Style.TextAlignHorz = AlignHorzEnum.Center

        doc.Body.Children.Add(rt1)
    End Sub
End Class
