Imports C1.Win.FlexGrid

Public Class Form1

    ' C1SuperLabel control used to render Html cells
    Dim _html As New C1.Win.SuperTooltip.C1SuperLabel()

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' set up grid
        _flex.AutoResize = False
        _flex.AllowResizing = AllowResizingEnum.Both
        _flex.DrawMode = DrawModeEnum.OwnerDraw
        _flex.Rows.DefaultSize = 80
        _flex.Rows(0).Height = 20
        _flex.Cols(0).Width = 20
        _flex.ShowCursor = True

        ' create a data table with an HTML field
        Dim dt As New DataTable()
        dt.Columns.Add("HTML", GetType(String))
        dt.Columns.Add("Plain Text", GetType(String))
        Dim i As Integer
        For i = 0 To 99
            dt.Rows.Add(GetHtml(8, "This is <u>underlined</u> text in an HTML string"), "Plain text...")
            dt.Rows.Add(GetHtml(9, "This is <i>italic</i> text in an HTML string"), "Plain text...")
            dt.Rows.Add(GetHtml(12, "This is <b>bold</b> text in an HTML string"), "Plain text...")
        Next

        ' bind grid
        _flex.DataSource = dt

        ' make Html field conspicuous
        Dim colHtml As Column = _flex.Cols("HTML")
        colHtml.Width = 500

        ' use HtmlEditor class to edit values in the "C1Editor" column
        Dim editor As New HtmlEditor()
        editor.BorderStyle = BorderStyle.None
        colHtml.Editor = editor

        ' use a different backcolor
        colHtml.StyleNew.BackColor = Color.LightGoldenrodYellow
        _flex.BackColor = Color.Bisque

    End Sub

    Function GetHtml(ByVal fontSize As Single, ByVal html As String) As String
        Dim bgColor As String = ColorTranslator.ToHtml(Color.LightGoldenrodYellow)
        Return String.Format( _
                   "<html><body style='margin:0pt;padding:0pt;font-family:{0};font-size:{1}pt;background-color:{2}'><p>{3}</p></body></html>", _
                   Font.Name, _
                   fontSize, _
                   bgColor, _
                   html)
    End Function

    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell
        If (Me._flex.Cols.Item(e.Col).Name = "HTML") Then

            ' draw background
            e.DrawCell(DrawCellFlags.Background)

            ' use the C1SuperLabel to draw the html text
            If ((e.Bounds.Width > 0) AndAlso (e.Bounds.Height > 0)) Then
                Me._html.Text = Me._flex.GetDataDisplay(e.Row, e.Col)
                Me._html.BackColor = Color.Transparent
                Me._html.DrawToGraphics(e.Graphics, e.Bounds)
            End If

            ' and draw border last
            e.DrawCell(DrawCellFlags.Border)

            ' we're done with this cell
            e.Handled = True
        End If
    End Sub
End Class
