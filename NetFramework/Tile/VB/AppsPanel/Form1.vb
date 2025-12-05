Imports System.Drawing.Drawing2D
Imports C1.Win.Tile

Public Class Form1

    Private Const _palX As Int32 = 20
    Private Const _palY As Int32 = 16

    Private _currentIndex As Int32 = 10

    Private Sub DrawRect(ByVal g As Graphics, ByRef x As Int32, ByVal c1 As Color, ByVal c2 As Color)

        Dim b1 As New SolidBrush(c1)
        Dim b2 As New SolidBrush(c2)

        g.FillRectangle(b1, x, _palY, 24, 24)
        g.FillRectangle(b2, x + 7, _palY + 7, 10, 10)
        x += 24

        b1.Dispose()
        b2.Dispose()

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

        Dim cx As Int32 = _palX
        Dim g As Graphics = e.Graphics

        DrawRect(g, cx, Color.FromArgb(37, 37, 37), Color.FromArgb(244, 179, 0))
        DrawRect(g, cx, Color.FromArgb(37, 37, 37), Color.FromArgb(120, 186, 0))
        DrawRect(g, cx, Color.FromArgb(37, 37, 37), Color.FromArgb(38, 115, 236))
        DrawRect(g, cx, Color.FromArgb(37, 37, 37), Color.FromArgb(174, 17, 61))
        DrawRect(g, cx, Color.FromArgb(46, 23, 0), Color.FromArgb(99, 47, 0))
        DrawRect(g, cx, Color.FromArgb(78, 0, 0), Color.FromArgb(176, 30, 0))
        DrawRect(g, cx, Color.FromArgb(78, 0, 56), Color.FromArgb(193, 0, 79))
        DrawRect(g, cx, Color.FromArgb(45, 0, 78), Color.FromArgb(114, 0, 172))
        DrawRect(g, cx, Color.FromArgb(31, 0, 104), Color.FromArgb(70, 23, 180))
        DrawRect(g, cx, Color.FromArgb(0, 30, 78), Color.FromArgb(0, 106, 193))
        DrawRect(g, cx, Color.FromArgb(0, 77, 96), Color.FromArgb(0, 130, 135))
        DrawRect(g, cx, Color.FromArgb(0, 74, 0), Color.FromArgb(25, 153, 0))
        DrawRect(g, cx, Color.FromArgb(21, 153, 42), Color.FromArgb(0, 193, 63))
        DrawRect(g, cx, Color.FromArgb(229, 108, 25), Color.FromArgb(255, 152, 29))
        DrawRect(g, cx, Color.FromArgb(184, 27, 27), Color.FromArgb(255, 46, 18))
        DrawRect(g, cx, Color.FromArgb(184, 27, 108), Color.FromArgb(255, 29, 119))
        DrawRect(g, cx, Color.FromArgb(105, 27, 184), Color.FromArgb(170, 64, 255))
        DrawRect(g, cx, Color.FromArgb(27, 88, 184), Color.FromArgb(31, 174, 255))
        DrawRect(g, cx, Color.FromArgb(86, 156, 227), Color.FromArgb(86, 197, 255))
        DrawRect(g, cx, Color.FromArgb(0, 170, 170), Color.FromArgb(0, 216, 204))
        DrawRect(g, cx, Color.FromArgb(131, 186, 31), Color.FromArgb(145, 209, 0))
        DrawRect(g, cx, Color.FromArgb(211, 157, 9), Color.FromArgb(225, 183, 0))
        DrawRect(g, cx, Color.FromArgb(224, 100, 183), Color.FromArgb(255, 118, 188))
        DrawRect(g, cx, Color.FromArgb(105, 105, 105), Color.FromArgb(0, 164, 164))
        DrawRect(g, cx, Color.FromArgb(105, 105, 105), Color.FromArgb(255, 125, 35))

        Dim pb As New SolidBrush(Color.FromArgb(35, 37, 34))

        Dim x As Int32 = _currentIndex * 24 + _palX + 6

        Dim y As Int32 = _palY - 12
        Dim path As New GraphicsPath()

        Dim arr1 As Point() = {New Point(x, y), New Point(x + 12, y), New Point(x + 12, y + 3), New Point(x + 6, y + 9), New Point(x + 6, y + 9), New Point(x, y + 3)}
        path.AddLines(arr1)

        path.CloseFigure()

        g.FillPath(pb, path)
        path.Dispose()

        y += 47
        path = New GraphicsPath()

        Dim arr2 As Point() = {New Point(x, y), New Point(x + 12, y), New Point(x + 12, y - 3), New Point(x + 6, y - 9), New Point(x + 6, y - 9), New Point(x, y - 3)}
        path.AddLines(arr2)
        path.CloseFigure()
        g.FillPath(pb, path)
        path.Dispose()

        pb.Dispose()

    End Sub

    Private Sub Panel1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseClick

        If e.Button = MouseButtons.Left Then
            If e.X >= _palX AndAlso e.Y >= _palY AndAlso e.X < _palX + (25 * 24) AndAlso e.Y < _palY + 24 Then
                Dim newIndex As Int32 = (e.X - _palX) \ 24
                If (newIndex <> _currentIndex) Then
                    UpdateColorPalette(newIndex)
                End If
            End If
        End If
    End Sub

    Private Sub UpdateColorPalette(ByVal newIndex As Int32)

        Dim panel As PanelElement = CType(mapImgTemplate.Elements(0), PanelElement)
        Dim imageElem As ImageElement = CType(panel.Children(0), ImageElement)
        imageElem.ColumnIndex = newIndex

        Dim backColor As Color = Color.Empty
        Dim checkBackColor As Color = Color.Empty
        Dim hotBackColor As Color = Color.Empty
        Dim hotCheckBackColor As Color = Color.Empty
        Dim subgroupLineColor As Color = Color.Empty
        Dim subgroupTitleColor As Color = Color.Empty

        Select newIndex
            Case 0
                backColor = Color.FromArgb(29, 29, 29)
                checkBackColor = Color.FromArgb(244, 179, 0)
                hotBackColor = Color.FromArgb(58, 58, 58)
                hotCheckBackColor = Color.FromArgb(246, 188, 35)
                subgroupLineColor = Color.FromArgb(38, 38, 38)
                subgroupTitleColor = Color.FromArgb(255, 200, 63)
            Case 1
                backColor = Color.FromArgb(29, 29, 29)
                checkBackColor = Color.FromArgb(118, 182, 0)
                hotBackColor = Color.FromArgb(58, 58, 58)
                hotCheckBackColor = Color.FromArgb(137, 192, 35)
                subgroupLineColor = Color.FromArgb(38, 38, 38)
                subgroupTitleColor = Color.FromArgb(139, 216, 0)
            Case 2
                backColor = Color.FromArgb(29, 29, 29)
                checkBackColor = Color.FromArgb(38, 115, 236)
                hotBackColor = Color.FromArgb(58, 58, 58)
                hotCheckBackColor = Color.FromArgb(68, 133, 239)
                subgroupLineColor = Color.FromArgb(38, 38, 38)
                subgroupTitleColor = Color.FromArgb(54, 158, 255)
            Case 3
                backColor = Color.FromArgb(29, 29, 29)
                checkBackColor = Color.FromArgb(174, 17, 61)
                hotBackColor = Color.FromArgb(58, 58, 58)
                hotCheckBackColor = Color.FromArgb(185, 50, 88)
                subgroupLineColor = Color.FromArgb(38, 38, 38)
                subgroupTitleColor = Color.FromArgb(240, 0, 67)
            Case 4
                backColor = Color.FromArgb(38, 19, 0)
                checkBackColor = Color.FromArgb(99, 47, 0)
                hotBackColor = Color.FromArgb(66, 50, 33)
                hotCheckBackColor = Color.FromArgb(120, 76, 35)
                subgroupLineColor = Color.FromArgb(51, 26, 0)
                subgroupTitleColor = Color.FromArgb(209, 105, 22)
            Case 5
                backColor = Color.FromArgb(56, 0, 0)
                checkBackColor = Color.FromArgb(176, 30, 0)
                hotBackColor = Color.FromArgb(82, 33, 33)
                hotCheckBackColor = Color.FromArgb(187, 61, 35)
                subgroupLineColor = Color.FromArgb(74, 0, 0)
                subgroupTitleColor = Color.FromArgb(255, 42, 0)
            Case 6
                backColor = Color.FromArgb(64, 0, 46)
                checkBackColor = Color.FromArgb(193, 0, 79)
                hotBackColor = Color.FromArgb(88, 32, 72)
                hotCheckBackColor = Color.FromArgb(202, 35, 103)
                subgroupLineColor = Color.FromArgb(78, 0, 56)
                subgroupTitleColor = Color.FromArgb(244, 0, 133)
            Case 7
                backColor = Color.FromArgb(37, 0, 64)
                checkBackColor = Color.FromArgb(114, 0, 172)
                hotBackColor = Color.FromArgb(65, 33, 89)
                hotCheckBackColor = Color.FromArgb(133, 35, 183)
                subgroupLineColor = Color.FromArgb(51, 0, 87)
                subgroupTitleColor = Color.FromArgb(196, 80, 255)
            Case 8
                backColor = Color.FromArgb(24, 0, 82)
                checkBackColor = Color.FromArgb(70, 23, 180)
                hotBackColor = Color.FromArgb(54, 33, 104)
                hotCheckBackColor = Color.FromArgb(95, 55, 190)
                subgroupLineColor = Color.FromArgb(33, 0, 110)
                subgroupTitleColor = Color.FromArgb(146, 92, 255)
            Case 9
                backColor = Color.FromArgb(0, 25, 64)
                checkBackColor = Color.FromArgb(0, 106, 193)
                hotBackColor = Color.FromArgb(33, 55, 89)
                hotCheckBackColor = Color.FromArgb(35, 126, 202)
                subgroupLineColor = Color.FromArgb(0, 31, 82)
                subgroupTitleColor = Color.FromArgb(50, 163, 255)
            Case 10
                backColor = Color.FromArgb(0, 64, 80)
                checkBackColor = Color.FromArgb(0, 130, 135)
                hotBackColor = Color.FromArgb(33, 89, 103)
                hotCheckBackColor = Color.FromArgb(35, 146, 151)
                subgroupLineColor = Color.FromArgb(0, 73, 92)
                subgroupTitleColor = Color.FromArgb(82, 238, 255)
            Case 11
                backColor = Color.FromArgb(0, 62, 0)
                checkBackColor = Color.FromArgb(25, 153, 0)
                hotBackColor = Color.FromArgb(33, 87, 33)
                hotCheckBackColor = Color.FromArgb(57, 167, 35)
                subgroupLineColor = Color.FromArgb(0, 71, 0)
                subgroupTitleColor = Color.FromArgb(38, 236, 0)
            Case 12
                backColor = Color.FromArgb(18, 128, 35)
                checkBackColor = Color.FromArgb(0, 193, 63)
                hotBackColor = Color.FromArgb(49, 144, 63)
                hotCheckBackColor = Color.FromArgb(35, 202, 88)
                subgroupLineColor = Color.FromArgb(20, 140, 40)
                subgroupTitleColor = Color.FromArgb(0, 255, 83)
            Case 13
                backColor = Color.FromArgb(191, 90, 21)
                checkBackColor = Color.FromArgb(255, 152, 29)
                hotBackColor = Color.FromArgb(199, 111, 51)
                hotCheckBackColor = Color.FromArgb(255, 166, 60)
                subgroupLineColor = Color.FromArgb(201, 99, 30)
                subgroupTitleColor = Color.FromArgb(255, 202, 96)
            Case 14
                backColor = Color.FromArgb(154, 22, 22)
                checkBackColor = Color.FromArgb(255, 46, 18)
                hotBackColor = Color.FromArgb(167, 52, 52)
                hotCheckBackColor = Color.FromArgb(255, 75, 51)
                subgroupLineColor = Color.FromArgb(171, 26, 26)
                subgroupTitleColor = Color.FromArgb(255, 120, 67)
            Case 15
                backColor = Color.FromArgb(154, 22, 90)
                checkBackColor = Color.FromArgb(255, 29, 119)
                hotBackColor = Color.FromArgb(167, 52, 111)
                hotCheckBackColor = Color.FromArgb(255, 60, 138)
                subgroupLineColor = Color.FromArgb(168, 25, 99)
                subgroupTitleColor = Color.FromArgb(255, 93, 192)
            Case 16
                backColor = Color.FromArgb(87, 22, 154)
                checkBackColor = Color.FromArgb(170, 64, 255)
                hotBackColor = Color.FromArgb(109, 52, 167)
                hotCheckBackColor = Color.FromArgb(182, 90, 255)
                subgroupLineColor = Color.FromArgb(101, 26, 176)
                subgroupTitleColor = Color.FromArgb(82, 238, 255)
            Case 17
                backColor = Color.FromArgb(22, 73, 154)
                checkBackColor = Color.FromArgb(31, 174, 255)
                hotBackColor = Color.FromArgb(52, 97, 167)
                hotCheckBackColor = Color.FromArgb(62, 185, 255)
                subgroupLineColor = Color.FromArgb(25, 80, 168)
                subgroupTitleColor = Color.FromArgb(0, 198, 255)
            Case 18
                backColor = Color.FromArgb(67, 144, 223)
                checkBackColor = Color.FromArgb(86, 197, 255)
                hotBackColor = Color.FromArgb(91, 158, 227)
                hotCheckBackColor = Color.FromArgb(109, 205, 255)
                subgroupLineColor = Color.FromArgb(88, 154, 219)
                subgroupTitleColor = Color.FromArgb(65, 255, 255)
            Case 19
                backColor = Color.FromArgb(0, 142, 142)
                checkBackColor = Color.FromArgb(0, 216, 204)
                hotBackColor = Color.FromArgb(33, 157, 157)
                hotCheckBackColor = Color.FromArgb(35, 221, 210)
                subgroupLineColor = Color.FromArgb(0, 153, 153)
                subgroupTitleColor = Color.FromArgb(0, 255, 241)
            Case 20
                backColor = Color.FromArgb(120, 170, 28)
                checkBackColor = Color.FromArgb(145, 209, 0)
                hotBackColor = Color.FromArgb(137, 181, 57)
                hotCheckBackColor = Color.FromArgb(159, 215, 35)
                subgroupLineColor = Color.FromArgb(128, 181, 29)
                subgroupTitleColor = Color.FromArgb(185, 255, 20)
            Case 21
                backColor = Color.FromArgb(194, 144, 8)
                checkBackColor = Color.FromArgb(225, 183, 0)
                hotBackColor = Color.FromArgb(202, 158, 40)
                hotCheckBackColor = Color.FromArgb(229, 193, 35)
                subgroupLineColor = Color.FromArgb(199, 154, 30)
                subgroupTitleColor = Color.FromArgb(255, 243, 47)
            Case 22
                backColor = Color.FromArgb(220, 79, 173)
                checkBackColor = Color.FromArgb(255, 118, 188)
                hotBackColor = Color.FromArgb(225, 102, 184)
                hotCheckBackColor = Color.FromArgb(255, 137, 197)
                subgroupLineColor = Color.FromArgb(229, 90, 183)
                subgroupTitleColor = Color.FromArgb(255, 166, 198)
            Case 23
                backColor = Color.FromArgb(88, 88, 88)
                checkBackColor = Color.FromArgb(0, 164, 164)
                hotBackColor = Color.FromArgb(110, 110, 110)
                hotCheckBackColor = Color.FromArgb(35, 175, 176)
                subgroupLineColor = Color.FromArgb(97, 97, 97)
                subgroupTitleColor = Color.FromArgb(0, 212, 212)
            Case 24
                backColor = Color.FromArgb(88, 88, 88)
                checkBackColor = Color.FromArgb(255, 125, 35)
                hotBackColor = Color.FromArgb(110, 110, 110)
                hotCheckBackColor = Color.FromArgb(255, 143, 65)
                subgroupLineColor = Color.FromArgb(97, 97, 97)
                subgroupTitleColor = Color.FromArgb(255, 158, 56)
        End Select

        C1TileControl1.BackColor = backColor
        C1TileControl1.TileBackColor = backColor
        C1TileControl1.CheckBackColor = checkBackColor
        C1TileControl1.HotBackColor = hotBackColor
        C1TileControl1.HotCheckBackColor = hotCheckBackColor
        panel = CType(subgroupTemplate.Elements(0), PanelElement)
        Dim textElem As TextElement = CType(panel.Children(1), TextElement)
        textElem.ForeColor = subgroupTitleColor
        panel = CType(panel.Children(0), PanelElement)
        panel.BackColor = subgroupLineColor

        _currentIndex = newIndex
        Panel1.Invalidate()
    End Sub

End Class
