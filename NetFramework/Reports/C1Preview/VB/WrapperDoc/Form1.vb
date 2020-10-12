Imports System.Text
Imports C1.C1Preview

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim doc As C1PrintDocumentWrapper = New C1PrintDocumentWrapper()
        doc.StartDoc()

        doc.Style.Font = New Font("Tahoma", 12)

        doc.RenderBlock(New RenderText("This document was rendered using the C1PrintDocumentWrapper class.", New Font("Tahoma", 18)))
        doc.AdvanceBlockFlow("5mm")

        Dim rt As RenderText = New RenderText("RenderText object with border.")
        rt.Style.Font = New Font("Tahoma", 14)
        rt.Style.Borders.All = LineDef.DefaultBold
        Dim mi As MeasureInfo = doc.RenderBlock(rt)

        doc.AdvanceBlockFlow("5mm")

        rt = New RenderText()
        rt.Text = String.Format("The previosly rendered object has the following coordinates:" & Environment.NewLine & "X = {0}, Y = {1}, Width = {2}, Height = {3}", mi.RenderedArea.X, mi.RenderedArea.Y, mi.RenderedArea.Width, mi.RenderedArea.Height)
        doc.RenderBlock(rt)

        rt = New RenderText()
        Dim sb As StringBuilder = New StringBuilder()
        Dim i
        For i = 1 To 60
            sb.Append("Line ")
            sb.Append(i.ToString())
            sb.Append(Environment.NewLine)
        Next
        rt.Text = sb.ToString()
        rt.Style.Borders.All = New LineDef("1mm", Color.Red)
        doc.RenderBlock(rt)

        rt = New RenderText()
        sb = New StringBuilder("The previosly rendered object occipied the following areas:" & Environment.NewLine)
        For i = 0 To doc.LastRenderedInfo.RenderedAreas.Length - 1
            sb.Append(String.Format("Area {0}, Bounds = {1}" & Environment.NewLine, i + 1, doc.LastRenderedInfo.RenderedAreas(i).ToString()))
        Next
        rt.Text = sb.ToString()
        doc.RenderBlock(rt)

        doc.AdvanceBlockFlow("5mm")

        Dim table As RenderTable = New RenderTable()
        table.Style.GridLines.All = LineDef.Default
        Dim r, c
        For r = 0 To 9
            For c = 0 To 2
                table.Cells(r, c).Text = String.Format("Cell {0}:{1}", r, c)
            Next
        Next

        table.Width = New Unit(doc.CurrentPageArea.Bounds.Width, doc.ResolvedUnit)
        mi = doc.MeasureObject(table, New Unit(doc.CurrentPageArea.Bounds.Width, doc.ResolvedUnit), Unit.Auto)

        doc.RenderBlockText(String.Format("The following table's size is: Width = {0} Height = {1}", mi.WidthUnit, mi.HeightUnit))

        doc.RenderBlock(table)

        doc.EndDoc()

        C1PrintPreviewControl1.Document = doc

    End Sub
End Class
