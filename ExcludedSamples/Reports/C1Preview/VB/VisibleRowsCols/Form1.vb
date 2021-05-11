Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Function CreateTable(ByVal doc As C1PrintDocument, ByVal colCount As Integer, ByVal rowCount As Integer, ByVal cellTextMask As String) As RenderTable
        Dim result As RenderTable = New RenderTable(doc)
        Dim r, c As Integer

        For r = 0 To rowCount - 1
            For c = 0 To colCount - 1
                result.Cells(r, c).Text = String.Format(cellTextMask, r, c)
            Next
        Next

        Return result
    End Function

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        doc.Clear()
        doc.Style.Font = New Font("Tahoma", 20)

        doc.Body.Children.Add(New RenderText("Some rows and columns of table are hidden."))

        Dim rt As RenderTable = CreateTable(doc, 3, 10, "Cell {0} : {1}")
        rt.Style.GridLines.All = New LineDef("1mm", Color.Blue)
        rt.Cols(1).Visible = False
        rt.Rows(7).Visible = False

        Dim c As TableCell = rt.Cells(0, 0)
        c.SpanCols = 3
        c.Text = String.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols)
        c.Style.TextAlignHorz = AlignHorzEnum.Center
        c.Style.BackColor = Color.LightGoldenrodYellow

        c = rt.Cells(3, 1)
        c.SpanCols = 2
        c.Text = String.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols)
        c.Style.TextAlignHorz = AlignHorzEnum.Center
        c.Style.BackColor = Color.LightSeaGreen

        c = rt.Cells(6, 0)
        c.SpanRows = 2
        c.Text = String.Format("Merged cell: Row={0}, Col={1}, SpanRows={2}, SpanCols={3}", c.Row, c.Col, c.SpanRows, c.SpanCols)
        c.Style.TextAlignHorz = AlignHorzEnum.Center
        c.Style.BackColor = Color.LightSkyBlue

        doc.Body.Children.Add(rt)

        doc.Generate()

    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        doc.Clear()

        doc.Style.Font = New Font("Tahoma", 20)

        doc.Body.Children.Add(New RenderText("Some rows of header and footer are hidden"))

        Dim rt As RenderTable = CreateTable(doc, 3, 50, "Cell {0} : {1}")
        rt.Style.GridLines.All = New LineDef("1mm", Color.Blue)

        ' build table header
        Dim ph As TableVectorGroup = rt.RowGroups(0, 3)
        ph.PageHeader = True
        ph.Style.BackColor = Color.LightSlateGray
        ph.Style.Font = New Font("Verdana", 25)
        ' hide row in table header
        rt.Rows(0).Visible = False

        ' build table footer
        Dim pf As TableVectorGroup = rt.RowGroups(rt.Rows.Count - 3, 3)
        pf.PageFooter = True
        pf.Style.BackColor = Color.CornflowerBlue
        pf.Style.Font = New Font("Tahoma", 25)
        ' hide row in table footer
        rt.Rows(rt.Rows.Count - 1).Visible = False

        doc.Body.Children.Add(rt)

        doc.Generate()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        button1_Click(Nothing, EventArgs.Empty)
    End Sub
End Class
