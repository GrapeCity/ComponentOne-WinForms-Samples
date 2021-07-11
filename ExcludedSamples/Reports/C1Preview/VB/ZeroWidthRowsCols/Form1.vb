Imports C1.C1Preview

Public Class Form1

    Friend Function CreateTable(ByVal doc As C1PrintDocument, ByVal colCount As Integer, ByVal rowCount As Integer, ByVal cellTextMask As String) As RenderTable
        Dim result As RenderTable = New RenderTable(doc)
        Dim r, c As Integer

        For r = 0 To rowCount - 1
            For c = 0 To colCount - 1
                result.Cells(r, c).Text = String.Format(cellTextMask, r, c)
            Next
        Next
        Return result
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        doc.Style.Font = New Font("Tahoma", 20)

        doc.Body.Children.Add(New RenderText("This table has the rows and columns with zero-width." & Microsoft.VisualBasic.Chr(13) & "" & Microsoft.VisualBasic.Chr(13) & "Column 1 is hidden and rows 2, 5 are hidden."))

        Dim rt As RenderTable = CreateTable(doc, 3, 10, "Cell {0} : {1}")
        rt.Style.GridLines.All = New LineDef("1mm", Color.Blue)
        rt.Cols(1).Width = Unit.Empty
        rt.Rows(2).Height = Unit.Empty
        rt.Rows(5).Height = Unit.Empty

        doc.Body.Children.Add(rt)
        doc.Generate()
    End Sub
End Class
