Public Class Form1

    ' add some data to grid
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' bind grid on first page
        Dim sql As String = "select * from products"
        Dim conn As String = GetConnectionString()
        Dim da As New System.Data.OleDb.OleDbDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        c1FlexGrid1.DataSource = dt

        ' select each page (needed so Control.DrawToBitmap works the first time)
        Dim selected As TabPage = tabControl1.SelectedTab
        Dim page As TabPage
        For Each page In tabControl1.TabPages
            tabControl1.SelectedTab = page
        Next
        tabControl1.SelectedTab = selected
    End Sub

    ' update tooltip as the mouse moves
    Private Sub tabControl1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tabControl1.MouseMove

        ' find tab under the mouse
        Dim page As TabPage = Nothing
        Dim pt As Point = New Point(e.X, e.Y)
        Dim index As Integer
        For index = 0 To tabControl1.TabPages.Count - 1
            If tabControl1.GetTabRect(index).Contains(pt) Then
                page = tabControl1.TabPages(index)
                Exit For
            End If
        Next

        ' show tip if the mouse is over a tab that is not selected
        If Not (page Is Nothing) AndAlso Not page.Equals(tabControl1.SelectedTab) Then
            Dim fmt As String = _
                        "<p>Here's a screenshot of page <b>'{0}'</b>.</p>" + _
                        "<p>This page contains either a grid or a chart plus some other controls...</p>" + _
                        "<p align='center'><img style='border:solid 4 darkblue;margin:4;' src='res://tabPage'></p>" + _
                        "<p>The page image was created using the <b>Control.DrawToBitmap</b> method,<br>" + _
                        "then stored in the <b>C1SuperTooltip.Images</b> list. The tooltip text displays<br>" + _
                        "the image using an html tag that looks like this:</p>" + _
                        "<p align='center'><b>&lt;img src='res://tabPage'&gt;</b>.</p>"
            Dim tipText As String = String.Format(fmt, page.Text)
            If tipText <> c1SuperTooltip1.GetToolTip(tabControl1) Then
                c1SuperTooltip1.Images("tabPage").Image = GetControlImage(page, 0.5F)
                c1SuperTooltip1.SetToolTip(tabControl1, tipText)
            End If
        Else
            c1SuperTooltip1.SetToolTip(tabControl1, String.Empty)
        End If
    End Sub

    ' reset tip when mouse leaves the control
    Private Sub tabControl1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl1.MouseLeave
        c1SuperTooltip1.SetToolTip(tabControl1, String.Empty)
    End Sub

    ' helper to get control images
    Public Function GetControlImage(ByVal ctl As Control, ByVal zoom As Single) As Image

        ' get image
        Dim rc As Rectangle = ctl.ClientRectangle
        Dim bmp As Bitmap = New Bitmap(rc.Width, rc.Height)
        ctl.DrawToBitmap(bmp, rc)

        ' apply zoom
        If zoom <> 1 Then
            Dim newSize As Size = Size.Round(New SizeF(bmp.Width * zoom, bmp.Height * zoom))
            bmp = New Bitmap(bmp, newSize)
        End If

        ' return image
        Return bmp
    End Function

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
