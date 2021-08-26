Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' because we want to show a wide table, we adjust the properties
        ' of the preview accordingly:
        ' hide all margins
        C1PrintPreviewControl1.PreviewPane.HideMarginsState = HideMarginsFlags.All
        ' do not allow the user to show margins
        C1PrintPreviewControl1.PreviewPane.HideMargins = HideMarginsFlags.None
        ' set padding between pages with hidden margins to 0, so that no gap is visible:
        C1PrintPreviewControl1.PreviewPane.PagesPaddingSmall = New Size(0, 0)
        ' set zoom mode:
        C1PrintPreviewControl1.PreviewPane.ZoomMode = ZoomModeEnum.PageWidth
        ' make the document:
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Reflow()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Clear()

        Dim rtxt As New RenderText()
        rtxt.Text = "This sample demonstrates horizontal (extended) pages, which allow to " & _
            "render wide objects (for example, tables with many columns) on separate pages that can " & _
            "be ""glued"" side to side."
        ' set the width of the text to 3 times the width of the page
        rtxt.Width = "page*3"
        ' allow it to span horizontal pages:
        rtxt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded
        ' add padding
        rtxt.Style.Padding.All = "2mm"
        rtxt.Style.Padding.Bottom = "5mm"
        '/ add text to the document
        doc.Body.Children.Add(rtxt)

        doc.Style.Font = New Font("Arial", 12, FontStyle.Regular)

        Dim ROWS As Integer = 63
        Dim COLS As Integer = 8

        ' make the table
        Dim rt As New RenderTable()
        ' for tables, "auto" width means that the width of the table
        ' will be equal to the widths of all columns, so we MUST also
        ' set the columns' widths.
        rt.Width = "auto"
        Dim row, col As Integer
        For col = 0 To COLS
            rt.Cols(col).Width = "5cm"
        Next col

        ' we want the last column on page to stretch to the right edge of the page,
        ' so that there is no white space left before the margin
        rt.StretchColumns = StretchTableEnum.LastVectorOnPage
        ' for the rightmost column, we turn stretching off:
        rt.Cols(rt.Cols.Count - 1).Stretch = StretchColumnEnum.No
        ' tell the table that it can split horizontally,
        ' otherwise the right part of the table will be clipped:
        rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded


        ' fill table with sample data
        For row = 0 To ROWS
            For col = 0 To COLS
                rt.Cells(row, col).Text = String.Format("Cell ({0}, {1})", row, col)
            Next col
        Next row

        ' add the table to the document
        doc.Body.Children.Add(rt)

        ' set up table style
        rt.Style.GridLines.All = New LineDef("2pt", Color.Black)
        rt.Style.GridLines.Horz = New LineDef("1pt", Color.Gray)
        rt.Style.GridLines.Vert = New LineDef("1pt", Color.Gray)

        ' add some comments at the bottom
        rtxt = New RenderText()
        rtxt.Text = "Note also that the preview supports such documents by showing " & _
            "the pages side by side rather than one below the other."
        ' set the width of the text to the width of the preceding sibling (i.e. the table):
        rtxt.Width = "prev.width"
        ' allow it to span horizontal pages:
        rtxt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded
        ' add padding
        rtxt.Style.Padding.All = "2mm"
        rtxt.Style.Padding.Top = "5mm"
        ' add the text to the document
        doc.Body.Children.Add(rtxt)
    End Sub
End Class
