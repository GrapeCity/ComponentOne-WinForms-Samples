Imports System.Drawing.Drawing2D

Public Class Form1

    Private Sub c1SplitterPanel6_DrawHeader(ByVal sender As System.Object, ByVal e As C1.Win.SplitContainer.DrawHeaderEventArgs) Handles c1SplitterPanel6.DrawHeader

        Dim lgb As LinearGradientBrush = New LinearGradientBrush(e.Bounds, Color.MistyRose, Color.SteelBlue, 90.0F)
        e.Graphics.FillRectangle(lgb, e.Bounds)
        lgb.Dispose()

    End Sub

    Private Sub c1SplitterPanel6_DrawSplitter(ByVal sender As System.Object, ByVal e As C1.Win.SplitContainer.DrawSplitterEventArgs) Handles c1SplitterPanel6.DrawSplitter

        Dim pt1 As Point = e.Bounds.Location
        pt1.Y += e.Bounds.Height \ 2
        Dim pt2 As Point = pt1
        pt2.X += e.Bounds.Width
        pt1.X += 10
        pt2.X -= 5
        Dim p As Pen = New Pen(Color.White)
        p.Width = 2.0F
        p.DashPattern = New Single() {1.0F, 2.0F, 1.0F, 2.0F}
        e.Graphics.DrawLine(p, pt1, pt2)
        p.Dispose()

    End Sub
End Class
