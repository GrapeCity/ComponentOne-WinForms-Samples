Imports C1.Win.FlexGrid

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        _flex.Rows(3).Style = _flex.Styles.Fixed

    End Sub

    Dim _resizeCol As Integer
    Dim _startX As Integer
    Private Sub _flex_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles _flex.MouseMove

        ' record column resize information while the mouse moves
        If Not _flex.Capture Then
            Dim ht As HitTestInfo = _flex.HitTest()
            If ht.Row > _flex.Rows.Fixed Then
                _resizeCol = -1
                If _flex.Styles.Fixed.Equals(_flex.Rows(ht.Row).Style) Then
                    Dim htTop As HitTestInfo = _flex.HitTest(e.X, 1)
                    If htTop.Type = HitTestTypeEnum.ColumnResize Then
                        _resizeCol = htTop.Column
                        _startX = _flex.ScrollPosition.X
                    End If
                End If

                ' show resizing cursor
                If _resizeCol < 0 Then
                    _flex.Cursor = Cursors.Default
                Else
                    _flex.Cursor = Cursors.VSplit
                End If
            End If
        End If

        ' resize column while mouse is captured
        If _flex.Capture AndAlso _resizeCol > -1 Then
            Dim colWidth As Integer = (e.X - _startX) - _flex.Cols(_resizeCol).Left
            _flex.Cols(_resizeCol).Width = Math.Max(0, colWidth)
        End If

    End Sub

    Private Sub _flex_BeforeMouseDown(ByVal sender As System.Object, ByVal e As C1.Win.FlexGrid.BeforeMouseDownEventArgs) Handles _flex.BeforeMouseDown

        ' ignore clicks while resizing columns
        If _resizeCol > -1 Then e.Cancel = True

    End Sub

End Class
