Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MakeDoc1(C1PrintDocument1)
        C1PrintDocument1.Reflow()
    End Sub

    Private Sub MakeDoc1(ByVal doc As C1PrintDocument)
        doc.Clear()

        Dim rtxt As New RenderText(doc)
        rtxt.Text = "This test demonstrates multiple inheritance of styles in tables. " & _
            "In the table below, the font is redefined for row 4. " & _
            "Then, the text color is redefined for column 1. " & _
            "Finally, a cell group is defined containing cells in rows 4 to 6, cols 1 & 2, " & _
            "and background color is redefined for that cell group. " & _
            vbCr & "The cell at the intersection of row 4 and col 1 combines all 3 styles." & vbCr & vbCr
        doc.Body.Children.Add(rtxt)

        doc.Style.Font = New Font("Arial", 12, FontStyle.Regular)

        Dim ROWS As Integer = 12
        Dim COLS As Integer = 6

        Dim rt As New RenderTable(doc)
        rt.Style.Padding.All = New Unit("4mm")
        Dim row, col As Integer
        For row = 0 To ROWS
            For col = 0 To COLS
                Dim celltext As New RenderText(doc)
                celltext.Text = String.Format("Cell ({0},{1})", row, col)
                rt.Cells(row, col).RenderObject = celltext
            Next col
        Next row
        ' add the table to the document
        doc.Body.Children.Add(rt)

        ' set up table style
        rt.Style.GridLines.All = New LineDef("2pt", Color.Black)
        rt.Style.GridLines.Horz = New LineDef("1pt", Color.Gray)
        rt.Style.GridLines.Vert = New LineDef("1pt", Color.Gray)

        ' define a row style
        rt.Rows(4).Style.Font = New Font("Arial", 12, FontStyle.Bold Or FontStyle.Italic)

        ' define a column style
        rt.Cols(1).Style.TextColor = Color.DarkOrange

        ' define a cell group with a background color
        rt.UserCellGroups.Add(New UserCellGroup(New Rectangle(1, 4, 2, 3)))
        rt.UserCellGroups(0).Style.BackColor = Color.PaleGreen
    End Sub
End Class
