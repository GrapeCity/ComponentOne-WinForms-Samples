Public Class Form1

    Private Sub template8_Paint(ByVal sender As System.Object, ByVal e As C1.Win.Tile.TemplatePaintEventArgs) Handles template8.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
        Dim r As Rectangle = e.ClipRectangle
        Dim sz As Int32 = Convert.ToInt32(28 * g.DpiY / 96.0F)
        r.X += (r.Width - sz) / 2
        r.Y += (r.Height - sz) / 2
        r.Width = sz
        r.Height = sz
        Dim p As New Pen(e.Tile.GetForeColor())
        Dim b As New SolidBrush(e.Tile.GetBackColor())
        Select Case e.Tile.IntValue
            Case 1
                g.FillPie(b, r, 50.0F, 270.0F)
                g.DrawPie(p, r, 50.0F, 270.0F)
            Case 2
                g.FillRectangle(b, r)
                g.DrawRectangle(p, r)
            Case Else
                g.FillEllipse(b, r)
                g.DrawEllipse(p, r)
        End Select
        p.Dispose()
        b.Dispose()
    End Sub

End Class
