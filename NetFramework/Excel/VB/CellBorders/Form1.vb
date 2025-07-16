Imports System.Drawing.Printing
Imports C1.Win.FlexGrid
Imports C1.Excel

Public Class Form1

    Dim _bdrBrush As SolidBrush
    Dim _bdrOutside As Integer
    Dim _bdrInside As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' create border style
        Dim s As CellStyle = _flex.Styles.Add("Border")
        _bdrBrush = New SolidBrush(Color.Red)
        _bdrOutside = 3
        _bdrInside = 1

        ' enable ownerdraw
        _flex.DrawMode = DrawModeEnum.OwnerDraw

    End Sub

    Private Sub _flex_OwnerDrawCell(ByVal sender As Object, ByVal e As C1.Win.FlexGrid.OwnerDrawCellEventArgs) Handles _flex.OwnerDrawCell

        ' we only want cells with style set to "Border" 
        Dim s As CellStyle = _flex.GetCellStyle(e.Row, e.Col)
        If s Is Nothing OrElse s.Name <> "Border" Then
            Return
        End If

        ' draw cell content as usual
        e.DrawCell()

        ' get custom border widths for this cell
        ' (depends on neighbor cells)
        Dim m As Margins = GetBorderMargins(e.Row, e.Col)

        ' draw custom borders
        Dim rc As Rectangle
        Dim g As Graphics = e.Graphics
        If (m.Top > 0) Then
            rc = e.Bounds
            rc.Height = m.Top
            g.FillRectangle(_bdrBrush, rc)
        End If
        If (m.Left > 0) Then
            rc = e.Bounds
            rc.Width = m.Left
            g.FillRectangle(_bdrBrush, rc)
        End If
        If (m.Bottom > 0) Then
            rc = e.Bounds
            rc.Y = rc.Bottom - m.Bottom
            rc.Height = m.Bottom
            g.FillRectangle(_bdrBrush, rc)
        End If
        If (m.Right > 0) Then
            rc = e.Bounds
            rc.X = rc.Right - m.Right
            rc.Width = m.Right
            g.FillRectangle(_bdrBrush, rc)
        End If
    End Sub

    Private Function GetBorderMargins(ByVal row As Integer, ByVal col As Integer) As Margins

        ' initialize return value
        Dim m As New Margins(0, 0, 0, 0)

        ' check whether this cell has a border
        Dim rg As CellRange = _flex.GetCellRange(row, col)
        If rg.Style Is Nothing OrElse rg.Style.Name <> "Border" Then
            Return m
        End If

        ' check whether this cell is at the top of the range
        m.Top = _bdrOutside
        If (row > _flex.Rows.Fixed) Then
            rg.r1 = row - 1
            rg.r2 = row - 1
            If Not (rg.Style Is Nothing) Then
                If rg.Style.Name.Equals("Border") Then
                    m.Top = 0
                End If
            End If
            rg.r1 = row
            rg.r2 = row
        End If

        ' check whether this cell is at the left of the range
        m.Left = _bdrOutside
        If (col > _flex.Cols.Fixed) Then
            rg.c1 = col - 1
            rg.c2 = col - 1
            If Not (rg.Style Is Nothing) Then
                If rg.Style.Name.Equals("Border") Then
                    m.Left = 0
                End If
            End If
            rg.c1 = col
            rg.c2 = col
        End If

        ' check whether this cell is at the bottom of the range
        m.Bottom = _bdrOutside
        If (row < _flex.Rows.Count - 1) Then
            rg.r1 = row + 1
            rg.r2 = row + 1
            If Not (rg.Style Is Nothing) Then
                If rg.Style.Name.Equals("Border") Then
                    m.Bottom = _bdrInside
                End If
            End If
            rg.r1 = row
            rg.r2 = row
        End If

        ' check whether this cell is at the right of the range
        m.Right = _bdrOutside
        If (col < _flex.Cols.Count - 1) Then
            rg.c1 = col + 1
            rg.c2 = col + 1
            If Not (rg.Style Is Nothing) Then
                If rg.Style.Name.Equals("Border") Then
                    m.Right = _bdrInside
                End If
            End If
            rg.c1 = col
            rg.c2 = col
        End If

        ' done
        Return m
    End Function

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick

        ' apply border to current selection
        If (e.Button.Equals(tbBorderOn)) Then

            ' assign border style to selection
            Dim rg As CellRange = _flex.Selection
            rg.Style = _flex.Styles("Border")

        End If

        ' remove border from current selection
        If (e.Button.Equals(tbBorderOff)) Then

            ' remove border style from selection
            Dim rg As CellRange = _flex.Selection
            rg.Style = Nothing

        End If

        ' change border color
        If (e.Button.Equals(tbBorderColor)) Then

            ' show color picker dialog
            Using dlg = New ColorDialog()
                dlg.Color = _bdrBrush.Color

                ' if the user clicked OK, set new border color
                If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    _bdrBrush.Color = dlg.Color
                End If
            End Using
        End If

        ' thicker/thinner outer border
        If (e.Button.Equals(tbIncreaseOut)) Then
            If (_bdrOutside < 10) Then
                _bdrOutside = _bdrOutside + 1
            End If
        End If
        If (e.Button.Equals(tbDecreaseOut)) Then
            If (_bdrOutside > 0) Then
                _bdrOutside = _bdrOutside - 1
            End If
        End If

        ' thicker/thinner inner border
        If (e.Button.Equals(tbIncreaseIn)) Then
            If (_bdrInside < 10) Then
                _bdrInside = _bdrInside + 1
            End If
        End If
        If (e.Button.Equals(tbDecreaseIn)) Then
            If (_bdrInside > 0) Then
                _bdrInside = _bdrInside - 1
            End If
        End If

        ' save current sheet (with borders) into an Excel file
        If (e.Button.Equals(tbExcel)) Then
            _c1xl.Clear()
            _c1xl.DefaultFont = New XLFont(_flex.Font.FontFamily.Name, _flex.Font.Size)

            Dim sheet As XLSheet = _c1xl.Sheets(0)
            Dim r As Integer, c As Integer
            For c = 0 To _flex.Cols.Count - 1

                ' save column width (twips)
                sheet.Columns(c).Width = Int(_flex.Cols(c).WidthDisplay / 96.0F * 1440)

                ' save cells on this column
                For r = 0 To _flex.Rows.Count - 1

                    ' save cell value
                    sheet(r, c).Value = _flex(r, c)

                    ' we only want cells with style set to "Border" 
                    Dim s As CellStyle = _flex.GetCellStyle(r, c)
                    If (s Is Nothing) OrElse s.Name <> "Border" Then
                        Continue For
                    End If

                    ' get custom border widths for this cell
                    ' (depends on neighbor cells)
                    Dim m As Margins = GetBorderMargins(r, c)

                    ' create stytle for this cell
                    Dim xs As XLStyle = New XLStyle(_c1xl)
                    If (m.Top > 0) Then
                        xs.BorderTop = GetLineStyle(m.Top)
                        xs.BorderColorTop = _bdrBrush.Color
                    End If
                    If (m.Left > 0) Then
                        xs.BorderLeft = GetLineStyle(m.Left)
                        xs.BorderColorLeft = _bdrBrush.Color
                    End If
                    If (m.Right > 0) Then
                        xs.BorderRight = GetLineStyle(m.Right)
                        xs.BorderColorRight = _bdrBrush.Color
                    End If
                    If (m.Bottom > 0) Then
                        xs.BorderBottom = GetLineStyle(m.Bottom)
                        xs.BorderColorBottom = _bdrBrush.Color
                    End If
                    sheet(r, c).Style = xs
                Next
            Next

            ' save book
            Dim fileName As String = Application.StartupPath + "\borders.xls"
            _c1xl.Save(fileName)
            System.Diagnostics.Process.Start(fileName)

        End If

        ' repaint control to show changes
        _flex.Invalidate()

    End Sub

    ' map border width into Excel border widths
    Private Function GetLineStyle(ByVal width As Integer) As XLLineStyle
        Select Case (width)
            Case 0
                Return XLLineStyle.Hair
            Case 1
                Return XLLineStyle.Thin
            Case 2
                Return XLLineStyle.Medium
        End Select
        Return XLLineStyle.Thick

    End Function

End Class
