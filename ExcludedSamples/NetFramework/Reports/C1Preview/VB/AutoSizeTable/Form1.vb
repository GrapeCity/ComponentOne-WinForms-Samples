Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim doc As New C1PrintDocument()

        '' create a RenderTable object:
        Dim rt As New RenderTable()
        '' adjust table's properties so that columns are auto-sized:
        '' 1) By default, table width is set to parent (page) width,
        '' for auto-sizing we must change it to auto (i.e. based on content):
        rt.Width = Unit.Auto
        '' 2) Set ColumnSizingMode to Auto (default means Fixed for columns):
        rt.ColumnSizingMode = TableSizingModeEnum.Auto
        '' that's it, now the table's columns will be auto-sized.

        '' Turn table grid lines on to better see autosizing, add some padding:
        rt.Style.GridLines.All = LineDef.Default
        rt.CellStyle.Padding.All = "2mm"

        '' add some data
        rt.Cells(0, 0).Text = "aaa"
        rt.Cells(0, 1).Text = "bbbbbbbbbb"
        rt.Cells(0, 2).Text = "cccccc"
        rt.Cells(1, 0).Text = "aaa aaa aaa"
        rt.Cells(1, 1).Text = "bbbbb"
        rt.Cells(1, 2).Text = "cccccc cccccc"
        rt.Cells(2, 2).Text = "zzzzzzzzzzzzzzz zz z"

        '' add the table to the document
        doc.Body.Children.Add(rt)

        '' show the document
        C1PrintPreviewControl1.Document = doc
    End Sub

#If OBSOLETE Then '' code below is not needed anymore since ColumnSizingMode = TableSizingModeEnum.Auto is supported
    ''' <summary>
    ''' Auto-sizes the table based on cells' content.
    ''' </summary>
    ''' <param name="rt">The table to auto-size.</param>
    Private Shared Sub AutoSizeTable(ByVal rt As RenderTable)
        If rt.Document Is Nothing Then
            Throw New Exception("The table must be already added to the document")
        End If
        Dim widths(rt.Cols.Count) As Double
        Dim row, col As Integer
        For row = 0 To rt.Rows.Count - 1
            For col = 0 To rt.Cols.Count - 1
                If rt.Cells(row, col).RenderObject IsNot Nothing Then
                    Dim s As SizeD = rt.Cells(row, col).RenderObject.CalcSize(Unit.Auto, Unit.Auto)
                    widths(col) = Math.Max(widths(col), s.Width)
                End If
            Next col
        Next row
        ' 1. grid line widths are added to the columns' widths, so we must take them into consideration.
        ' 2. for calculations in the document, the maximum width is used, so we do that too.
        ' 3. first and last columns include an extra half-width of a line.

        Dim wVert As Double = 0
        If rt.Style.GridLines.Vert IsNot Nothing Then
            wVert = rt.Style.GridLines.Vert.Width.ConvertUnit(rt.Document.ResolvedUnit)
        End If
        Dim wLeft As Double = 0
        If rt.Style.GridLines.Left IsNot Nothing Then
            wLeft = rt.Style.GridLines.Left.Width.ConvertUnit(rt.Document.ResolvedUnit)
        End If
        Dim wRight As Double = 0
        If rt.Style.GridLines.Right IsNot Nothing Then
            wRight = rt.Style.GridLines.Right.Width.ConvertUnit(rt.Document.ResolvedUnit)
        End If
        Dim lineWidths As Double = Math.Max(wVert, Math.Max(wLeft, wRight))
        For col = 0 To rt.Cols.Count - 1
            If col = 0 OrElse col = rt.Cols.Count - 1 Then
                rt.Cols(col).Width = New Unit(widths(col) + lineWidths * 1.5, rt.Document.ResolvedUnit)
            Else
                rt.Cols(col).Width = New Unit(widths(col) + lineWidths, rt.Document.ResolvedUnit)
            End If
        Next
        ' the default for a table is 100% of the parent's width, so we must set the width
        ' to auto (which means the sum of all columns' widths).
        rt.Width = Unit.Auto
    End Sub
#End If
End Class
