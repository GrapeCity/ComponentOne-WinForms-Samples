Imports C1.Win.C1FlexGrid

Public Class ZoomCell
    Inherits PictureBox

    ' ** fields
    Private _owner As C1FlexGrid
    Private _zoom As Single

    ' ** ctor
    Public Sub New(ByVal owner As C1FlexGrid)

        ' initialize base class (PictureBox)
        BorderStyle = BorderStyle.FixedSingle
        SizeMode = PictureBoxSizeMode.StretchImage
        Visible = False
        Parent = owner

        ' initialize zoom factor: 25%
        _zoom = 1.35F

        ' hook up event handlers
        _owner = owner
        AddHandler owner.MouseDown, AddressOf Flex_MouseDown
        AddHandler owner.EnterCell, AddressOf Flex_EnterCell
        AddHandler owner.LostFocus, AddressOf Flex_LostFocus
        AddHandler owner.KeyPress, AddressOf Flex_KeyPress
    End Sub


    ' ** event handlers
    Private Sub Flex_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

        ' show zoom when user clicks the cell
        ShowZoomedCell(_owner.MouseRow, _owner.MouseCol)

    End Sub

    Private Sub Flex_EnterCell(ByVal sender As Object, ByVal e As EventArgs)

        ' follow cursor
        If Visible Then
            ShowZoomedCell(_owner.Row, _owner.Col)
        End If

    End Sub

    Private Sub Flex_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)

        ' hide zoom when user hits escape
        If Visible And e.KeyChar = Microsoft.VisualBasic.ChrW(27) Then
            Visible = False
        End If

    End Sub

    Private Sub Flex_LostFocus(ByVal sender As Object, ByVal e As EventArgs)

        Visible = False

    End Sub


    ' ** private
    Private Sub ShowZoomedCell(ByVal row As Integer, ByVal col As Integer)

        ' ignore empty area
        If row < _owner.Rows.Fixed Or col < _owner.Cols.Fixed Then
            Visible = False
            Return
        End If

        ' get cell rectangle
        Dim rc As Rectangle = _owner.GetCellRect(row, col)

        ' create bitmap
        Dim style As CellStyle = _owner.GetCellStyleDisplay(row, col)
        Image = New Bitmap(rc.Width, rc.Height)
        Dim g As Graphics = Graphics.FromImage(Image)
        Try
            Dim pt As Point = rc.Location
            rc.Location = Point.Empty
            style.Render(g, rc, _owner.GetDataDisplay(row, col))
            rc.Location = pt
        Finally
            g.Dispose()
        End Try

        ' apply zoom factor
        rc.Inflate(CInt(rc.Width * (_zoom - 1)), CInt(rc.Height * (_zoom - 1)))
        Bounds = rc
        Visible = True
        Invalidate()
    End Sub 'ZoomCell
End Class
