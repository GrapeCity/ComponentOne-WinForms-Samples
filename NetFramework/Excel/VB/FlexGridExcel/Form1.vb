Imports system.IO
Imports C1.Excel
Imports C1.Win.C1FlexGrid

Public Class Form1

    Private Sub _btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnLoad.Click

        ' choose file
        Dim dlg As New OpenFileDialog()
        dlg.DefaultExt = "xls"
        dlg.FileName = "*.xls"
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' clear everything
        _book.Clear()
        _tab.TabPages.Clear()

        ' load book
        _book.Load(dlg.FileName)

        ' create one grid per sheet and add them to listbox
        Dim sheet As XLSheet
        For Each sheet In _book.Sheets

            ' create a new grid for this sheet
            Dim flex As New C1FlexGrid()
            flex.BorderStyle = _flex.BorderStyle
            flex.AllowMerging = _flex.AllowMerging
            flex.Dock = _flex.Dock

            ' load sheet into new grid
            LoadSheet(flex, sheet, True)

            ' add new grid to the list
            Dim pg As New TabPage()
            pg.Text = sheet.Name
            flex.Name = sheet.Name
            pg.Controls.Add(flex)
            _tab.TabPages.Add(pg)
        Next

        ' select current sheet
        _tab.SelectedIndex = _book.Sheets.SelectedIndex
    End Sub

    Private Sub _btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnSave.Click

        ' choose file
        Dim dlg As New SaveFileDialog()
        dlg.DefaultExt = "xls"
        dlg.FileName = "*.xls"
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' clear book
        _book.Clear()
        _book.Sheets.Clear()

        ' copy grids to book sheets
        Dim pg As TabPage
        For Each pg In _tab.TabPages

            Dim grid As C1FlexGrid = pg.Controls(0)
            Dim sheet As XLSheet = _book.Sheets.Add(grid.Name)
            SaveSheet(grid, sheet, False)
        Next

        ' save selected sheet index
        _book.Sheets.SelectedIndex = _tab.SelectedIndex

        ' save the book
        _book.Save(dlg.FileName)
    End Sub

    Private Sub _btnBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _btnBatch.Click

        ' choose file
        Dim dlg As New OpenFileDialog()
        dlg.DefaultExt = "xls"
        dlg.FileName = "*.xls"
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        ' load and save all xls files in the selected directory
        Dim file As String
        Dim files As String() = Directory.GetFiles(Path.GetDirectoryName(dlg.FileName), "*.xls")
        For Each file In files

            ' load book
            _book.Load(file)

            ' save book
            _book.Save(file + "_c1xl.xls")
        Next
    End Sub

    '==============================================

    Dim _styles As Hashtable

    ' load sheet into grid
    Private Sub LoadSheet(ByVal flex As C1FlexGrid, ByVal sheet As XLSheet, ByVal fixedCells As Boolean)

        ' account for fixed cells
        Dim frows As Integer = flex.Rows.Fixed
        Dim fcols As Integer = flex.Cols.Fixed

        ' copy dimensions
        flex.Rows.Count = sheet.Rows.Count + frows
        flex.Cols.Count = sheet.Columns.Count + fcols

        ' initialize fixed cells
        Dim r As Integer, c As Integer
        If fixedCells AndAlso frows > 0 AndAlso fcols > 0 Then

            flex.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            For r = 1 To flex.Rows.Count - 1
                flex(r, 0) = r
            Next
            For c = 1 To flex.Cols.Count - 1
                flex(0, c) = String.Format("{0}", Chr(Asc("A") + c - 1))
            Next
        End If

        ' set default properties
        Dim font = sheet.Book.DefaultFont
        Dim fs As FontStyle = FontStyle.Regular
        If font.Bold Then fs = fs Or FontStyle.Bold
        If font.Italic Then fs = fs Or FontStyle.Italic
        If font.Strikeout Then fs = fs Or FontStyle.Strikeout
        If font.Underline <> XLUnderlineStyle.None Then fs = fs Or FontStyle.Underline
        flex.Font = New Font(font.FontName, font.FontSize, fs)
        flex.Rows.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultRowHeight)
        flex.Cols.DefaultSize = C1XLBook.TwipsToPixels(sheet.DefaultColumnWidth)

        ' prepare to convert styles
        _styles = New Hashtable()

        ' set row/column properties
        For r = 0 To sheet.Rows.Count - 1

            ' size/visibility
            Dim fr As Row = flex.Rows(r + frows)
            Dim xr As XLRow = sheet.Rows(r)
            If (xr.Height >= 0) Then
                fr.Height = C1XLBook.TwipsToPixels(xr.Height)
                fr.Visible = xr.Visible

                ' style
                Dim cs As CellStyle = StyleFromExcel(flex, xr.Style)
                If Not (cs Is Nothing) Then
                    fr.Style = cs
                End If
            End If
        Next
        For c = 0 To sheet.Columns.Count - 1

            ' size/visibility
            Dim fc As Column = flex.Cols(c + fcols)
            Dim xc As XLColumn = sheet.Columns(c)
            If (xc.Width >= 0) Then
                fc.Width = C1XLBook.TwipsToPixels(xc.Width)
                fc.Visible = xc.Visible

                ' style
                Dim cs As CellStyle = StyleFromExcel(flex, xc.Style)
                If Not (cs Is Nothing) Then
                    fc.Style = cs
                End If
            End If
        Next

        ' load cells
        For r = 0 To sheet.Rows.Count - 1
            For c = 0 To sheet.Columns.Count - 1

                ' get cell
                Dim cell As XLCell = sheet.GetCell(r, c)
                If (cell Is Nothing) Then
                    Continue For
                End If

                ' apply content
                flex(r + frows, c + fcols) = cell.Value

                ' apply style
                Dim cs As CellStyle = StyleFromExcel(flex, cell.Style)
                If Not (cs Is Nothing) Then
                    flex.SetCellStyle(r + frows, c + fcols, cs)
                End If
            Next
        Next
    End Sub

    ' ** convert Excel style into FlexGrid style
    Private Function StyleFromExcel(ByVal flex As C1FlexGrid, ByVal style As XLStyle) As CellStyle

        ' sanity
        If (style Is Nothing) Then
            Return Nothing
        End If

        ' look it up on list
        If (_styles.Contains(style)) Then
            Return _styles(style)
        End If

        ' create new flex style
        Dim cs As CellStyle = flex.Styles.Add(_styles.Count.ToString())

        ' set up new style
        Dim font = style.Font
        Dim fs As FontStyle = FontStyle.Regular
        If font.Bold Then fs = fs Or FontStyle.Bold
        If font.Italic Then fs = fs Or FontStyle.Italic
        If font.Strikeout Then fs = fs Or FontStyle.Strikeout
        If font.Underline <> XLUnderlineStyle.None Then fs = fs Or FontStyle.Underline
        If style.Font IsNot Nothing Then cs.Font = New Font(font.FontName, font.FontSize, fs)

        If (style.ForeColor <> Color.Transparent) Then cs.ForeColor = style.ForeColor
        If (style.BackColor <> Color.Transparent) Then cs.BackColor = style.BackColor
        If (style.Rotation = 90) Then cs.TextDirection = TextDirectionEnum.Up
        If (style.Rotation = 180) Then cs.TextDirection = TextDirectionEnum.Down

        If Not (style.Format Is Nothing OrElse style.Format.Length = 0) Then

            cs.Format = XLStyle.FormatXLToDotNet(style.Format)
            Select Case (style.AlignHorz)
                Case XLAlignHorz.Center
                    cs.WordWrap = style.WordWrap
                    Select Case (style.AlignVert)
                        Case XLAlignVert.Top
                            cs.TextAlign = TextAlignEnum.CenterTop
                        Case XLAlignVert.Center
                            cs.TextAlign = TextAlignEnum.CenterCenter
                        Case Else
                            cs.TextAlign = TextAlignEnum.CenterBottom
                    End Select
                Case XLAlignHorz.Right
                    cs.WordWrap = style.WordWrap
                    Select Case (style.AlignVert)
                        Case XLAlignVert.Top
                            cs.TextAlign = TextAlignEnum.RightTop
                        Case XLAlignVert.Center
                            cs.TextAlign = TextAlignEnum.RightCenter
                        Case Else
                            cs.TextAlign = TextAlignEnum.RightBottom
                    End Select
                Case XLAlignHorz.Left
                    cs.WordWrap = style.WordWrap
                    Select Case (style.AlignVert)
                        Case XLAlignVert.Top
                            cs.TextAlign = TextAlignEnum.LeftTop
                        Case XLAlignVert.Center
                            cs.TextAlign = TextAlignEnum.LeftCenter
                        Case Else
                            cs.TextAlign = TextAlignEnum.LeftBottom
                    End Select
                Case Else
                    cs.WordWrap = style.WordWrap
                    Select Case (style.AlignVert)
                        Case XLAlignVert.Top
                            cs.TextAlign = TextAlignEnum.GeneralTop
                        Case XLAlignVert.Center
                            cs.TextAlign = TextAlignEnum.GeneralCenter
                        Case Else
                            cs.TextAlign = TextAlignEnum.GeneralBottom
                    End Select
            End Select
        End If

        ' save it
        _styles.Add(style, cs)

        ' return it
        Return cs
    End Function

    ' ** save a C1FlexGrid into an XLSheet
    Private Sub SaveSheet(ByVal flex As C1FlexGrid, ByVal sheet As XLSheet, ByVal fixedCells As Boolean)

        ' account for fixed cells
        Dim frows As Integer = flex.Rows.Fixed
        Dim fcols As Integer = flex.Cols.Fixed
        If (fixedCells) Then
            frows = 0
            fcols = 0
        End If

        ' copy dimensions
        Dim lastRow As Integer = flex.Rows.Count - frows - 1
        Dim lastCol As Integer = flex.Cols.Count - fcols - 1
        If lastRow < 0 OrElse lastCol < 0 Then
            Return
        End If
        Dim cell As XLCell = sheet(lastRow, lastCol)

        ' set default properties
        Dim f = flex.Font
        Dim fs As XLFontScript = XLFontScript.None
        Dim us As XLUnderlineStyle = XLUnderlineStyle.None
        If f.Underline Then us = XLUnderlineStyle.Single
        sheet.Book.DefaultFont = New XLFont(f.Name, f.Size, f.Bold, f.Italic, f.Strikeout, fs, us, Color.Black)

        sheet.DefaultRowHeight = C1XLBook.PixelsToTwips(flex.Rows.DefaultSize)
        sheet.DefaultColumnWidth = C1XLBook.PixelsToTwips(flex.Cols.DefaultSize)

        ' prepare to convert styles
        _styles = New Hashtable()

        ' set row/column properties
        Dim r As Integer
        For r = frows To flex.Rows.Count - 1

            ' size/visibility
            Dim fr As Row = flex.Rows(r)
            Dim xr As XLRow = sheet.Rows(r - frows)
            If (fr.Height >= 0) Then
                xr.Height = C1XLBook.PixelsToTwips(fr.Height)
                xr.Visible = fr.Visible

                ' style
                Dim xs As XLStyle = StyleFromFlex(fr.Style)
                If Not (xs Is Nothing) Then
                    xr.Style = xs
                End If
            End If
        Next

        Dim c As Integer
        For c = fcols To flex.Cols.Count - 1

            ' size/visibility
            Dim fc As Column = flex.Cols(c)
            Dim xc As XLColumn = sheet.Columns(c - fcols)
            If (fc.Width >= 0) Then
                xc.Width = C1XLBook.PixelsToTwips(fc.Width)
                xc.Visible = fc.Visible

                ' style
                Dim xs As XLStyle = StyleFromFlex(fc.Style)
                If Not (xs Is Nothing) Then
                    xc.Style = xs
                End If
            End If
        Next

        ' load cells
        For r = frows To flex.Rows.Count - 1
            For c = fcols To flex.Cols.Count - 1

                ' get cell
                cell = sheet(r - frows, c - fcols)

                ' apply content
                cell.Value = flex(r, c)

                ' apply style
                Dim xs As XLStyle = StyleFromFlex(flex.GetCellStyle(r, c))
                If Not (xs Is Nothing) Then
                    cell.Style = xs
                End If
            Next
        Next
    End Sub

    ' ** convert FlexGrid style into Excel style
    Private Function StyleFromFlex(ByVal style As CellStyle) As XLStyle

        ' sanity
        If (style Is Nothing) Then
            Return Nothing
        End If

        ' look it up on list
        If (_styles.Contains(style)) Then
            Return _styles(style)
        End If

        ' create new Excel style
        Dim xs As XLStyle = New XLStyle(_book)

        ' set up new style
        Dim f = style.Font
        Dim fs As XLFontScript = XLFontScript.None
        Dim us As XLUnderlineStyle = XLUnderlineStyle.None
        If f.Underline Then us = XLUnderlineStyle.Single
        xs.Font = New XLFont(f.Name, f.Size, f.Bold, f.Italic, f.Strikeout, fs, us, xs.ForeColor)

        If (style.BackColor.ToArgb() <> SystemColors.Window.ToArgb()) Then
            xs.BackColor = style.BackColor
        End If

        xs.WordWrap = style.WordWrap
        xs.Format = XLStyle.FormatDotNetToXL(style.Format)
        Select Case (style.TextDirection)
            Case TextDirectionEnum.Up
                xs.Rotation = 90
            Case TextDirectionEnum.Down
                xs.Rotation = 180
        End Select
        Select Case (style.TextAlign)
            Case TextAlignEnum.CenterBottom
                xs.AlignHorz = XLAlignHorz.Center
                xs.AlignVert = XLAlignVert.Bottom
            Case TextAlignEnum.CenterCenter
                xs.AlignHorz = XLAlignHorz.Center
                xs.AlignVert = XLAlignVert.Center
            Case TextAlignEnum.CenterTop
                xs.AlignHorz = XLAlignHorz.Center
                xs.AlignVert = XLAlignVert.Top
            Case TextAlignEnum.GeneralBottom
                xs.AlignHorz = XLAlignHorz.General
                xs.AlignVert = XLAlignVert.Bottom
            Case TextAlignEnum.GeneralCenter
                xs.AlignHorz = XLAlignHorz.General
                xs.AlignVert = XLAlignVert.Center
            Case TextAlignEnum.GeneralTop
                xs.AlignHorz = XLAlignHorz.General
                xs.AlignVert = XLAlignVert.Top
            Case TextAlignEnum.LeftBottom
                xs.AlignHorz = XLAlignHorz.Left
                xs.AlignVert = XLAlignVert.Bottom
            Case TextAlignEnum.LeftCenter
                xs.AlignHorz = XLAlignHorz.Left
                xs.AlignVert = XLAlignVert.Center
            Case TextAlignEnum.LeftTop
                xs.AlignHorz = XLAlignHorz.Left
                xs.AlignVert = XLAlignVert.Top
            Case TextAlignEnum.RightBottom
                xs.AlignHorz = XLAlignHorz.Right
                xs.AlignVert = XLAlignVert.Bottom
            Case TextAlignEnum.RightCenter
                xs.AlignHorz = XLAlignHorz.Right
                xs.AlignVert = XLAlignVert.Center
            Case TextAlignEnum.RightTop
                xs.AlignHorz = XLAlignHorz.Right
                xs.AlignVert = XLAlignVert.Top
            Case Else
                Debug.Assert(False)
        End Select

        ' save it
        _styles.Add(style, xs)

        ' return it
        Return xs
    End Function

End Class
