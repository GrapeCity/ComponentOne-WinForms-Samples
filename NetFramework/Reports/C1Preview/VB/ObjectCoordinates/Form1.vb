Imports System.Drawing.Drawing2D
Imports C1.C1Preview
Imports C1.Win.C1Preview

Public Class Form1

    Private _roUnderMouse As RenderObject
    Private _hilitePen As Pen

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        '  set up a pen for hiliting
        Dim b As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Red, Color.FromArgb(128, Color.Yellow))
        _hilitePen = New Pen(b, 4)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' make a demo C1PrintDocument; a "real" document can be loaded
        ' via the File Open button.
        Dim doc As New C1PrintDocument()
        doc.PageLayout.PageHeader = New RenderText("Page [PageNo] of [PageCount]")
        doc.PageLayout.PageHeader.Style.TextAlignHorz = AlignHorzEnum.Right
        doc.PageLayout.PageHeader.Style.TextAlignVert = AlignVertEnum.Top
        doc.PageLayout.PageHeader.Height = "1cm"
        Dim title As New RenderText("This is just a sample; load any C1PrintDocument from a C1D file")
        title.Style.Font = New Font("Arial", 16)
        title.Style.TextAlignHorz = AlignHorzEnum.Center
        title.Style.Padding.All = "5mm"
        doc.Body.Children.Add(title)
        Dim rt As New RenderTable()
        rt.Style.GridLines.All = LineDef.Default
        Dim row, col As Integer
        For row = 0 To 100
            For col = 0 To 4
                rt.Cells(row, col).Text = String.Format("cell ({0},{1})", row, col)
            Next col
        Next row
        doc.Body.Children.Add(rt)
        C1PrintPreviewControl1.Document = doc
    End Sub

    ' On mouse move, we try to find the render object under the mouse.
    ' In case of success we cache the reference to that render object
    ' in the _roUnderMouse var, which is used in Paint handler to high-light
    ' that object. Also, we list info about that object in the list box.
    Private Sub c1PrintPreviewControl1_PreviewPane_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles C1PrintPreviewControl1.PreviewPane.MouseMove
        Dim pane As C1PreviewPane = sender
        ' this is the point in C1PreviewPane's client coords:
        Dim previewPanelP As New Point(e.X, e.Y)
        Dim pageIdx As Integer
        Dim docP As PointF
        ' convert to document coords, which are pixels which have also been:
        ' - scaled by the preview zoom factor, and
        ' - related to the document page (top left corner of the page is (0,0)).
        pane.ClientToDocument(previewPanelP, pageIdx, docP)
        ' further processing if the mouse is over a point on a document page:
        If (pageIdx >= 0) Then
            ' clear the list box of old stuff
            If ((ListBox1.Items.Count + 1) * ListBox1.ItemHeight > ListBox1.ClientSize.Height) Then
                ListBox1.Items.RemoveAt(0)
            End If

            ' find the RenderObject under the mouse
            Dim ro As RenderObject = FindRenderObject(pane.Document, pageIdx, docP, pane.DpiX, pane.DpiY)
            If (ro IsNot _roUnderMouse) Then
                ' print info in the list box
                Dim roStr As String
                If ro Is Nothing Then
                    roStr = "<none>"
                Else
                    roStr = ro.ToString
                End If
                ListBox1.Items.Add(String.Format("pageIdx: {0}, pos: {1}. Client: {2}. RO: {3}", _
                pageIdx, docP, previewPanelP, roStr))
                ' cache the render object (so that it is highlighted in the Paint handler)
                _roUnderMouse = ro
                ' force repaint for the highlight to show
                ' (TODO: optimize by invalidating only the areas under the ro's fragments)
                pane.Invalidate()
            End If
        End If
    End Sub

    ' highlight the render object under the mouse, if any
    Private Sub c1PrintPreviewControl1_PreviewPane_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles C1PrintPreviewControl1.PreviewPane.Paint
        If _roUnderMouse Is Nothing Then
            Return
        End If
        Dim pane As C1PreviewPane = C1PrintPreviewControl1.PreviewPane
        ' paint red rectangles over all fragments of the render object
        Dim rf As RenderFragment
        For Each rf In _roUnderMouse.Fragments
            Dim rd As RectangleD = rf.BoundsOnPage
            ' FromRU converts from "resolved units" (units in which fragment's bounds are
            ' expressed) to any desired unit - in our case, we convert to pixels
            Dim rpreview As RectangleD = _roUnderMouse.Document.FromRU(rd, UnitTypeEnum.Pixel, pane.DpiX, pane.DpiY)
            ' but because the document does not know anything about the preview's zoom
            ' or offset of pages in the preview, we convert "document pixels" to preview ones:
            Dim rectf As RectangleF = pane.DocumentToClient(rf.PageIndex, rpreview.ToRectangleF())
            ' finally, highlight the rectangle in the preview pane:
            e.Graphics.DrawRectangle(_hilitePen, rectf.X, rectf.Y, rectf.Width, rectf.Height)
        Next
    End Sub

    ' finds the render object given the document, page index, point in the page
    ' (in pixels), and resolution for those pixels.
    Private Function FindRenderObject(ByVal document As Object, ByVal pageIdx As Integer, ByVal pt As PointF, ByVal dpix As Decimal, ByVal dpiy As Decimal) As RenderObject
        Dim doc As C1PrintDocument = document
        If doc IsNot Nothing Then
            Return FindRenderObject(doc.Pages(pageIdx).Fragments, pt, dpix, dpiy)
        Else
            Return Nothing
        End If
    End Function

    ' finds the render object in the fragments' collection
    ' (the innermost render object containing the point is found)
    Private Function FindRenderObject(ByVal frags As RenderFragmentCollection, ByVal pt As PointF, ByVal dpix As Decimal, ByVal dpiy As Decimal) As RenderObject
        Dim rf As RenderFragment
        For Each rf In frags
            Dim rd As RectangleD = rf.Document.FromRU(rf.Bounds, UnitTypeEnum.Pixel, dpix, dpiy)
            Dim rrf As RectangleF = New RectangleF(rd.X, rd.Y, rd.Width, rd.Height)
            If (rrf.Contains(pt)) Then
                If (rf.RenderObject.Children.Count > 0) Then
                    ' try to go deeper
                    pt.X -= rd.Left
                    pt.Y -= rd.Top
                    Dim child As RenderObject = FindRenderObject(rf.Children, pt, dpix, dpiy)
                    If child IsNot Nothing Then
                        Return child
                    End If
                End If
                Return rf.RenderObject
            End If
        Next
        Return Nothing
    End Function

    ' "high-level" method, finds the render object under the screen point
    Private Function FindRoUnderScreenPoint(ByVal screenPt As Point) As RenderObject
        Dim pane As C1PreviewPane = C1PrintPreviewControl1.PreviewPane
        Dim doc As C1PrintDocument = TryCast(pane.Document, C1PrintDocument)
        If doc Is Nothing Then
            Return Nothing
        End If
        Dim clientP As Point = pane.PointToClient(screenPt)
        Dim pageIdx As Integer
        Dim docP As PointF
        pane.ClientToDocument(clientP, pageIdx, docP)
        If pageIdx >= 0 Then
            Return FindRenderObject(doc, pageIdx, docP, pane.DpiX, pane.DpiY)
        Else
            Return Nothing
        End If
    End Function

    ' re-generates the document keeping the current preview position
    Private Sub RegenerateDocument(ByVal doc As C1PrintDocument)
        ' NOTE the use of C1PreviewPane.LayoutSection - it will prevent flickering
        ' and make redisplay smoother.
        Dim layoutSection As New C1PreviewPane.LayoutSection(C1PrintPreviewControl1.PreviewPane, HistorySavedActionsEnum.None)
        Dim pos As PointF = C1PrintPreviewControl1.PreviewPane.PreviewScrollPosition
        doc.Generate()
        C1PrintPreviewControl1.PreviewPane.PreviewScrollPosition = pos
        layoutSection.Dispose()
    End Sub

    ' context menu to show for the render object under the mouse
    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Dim ro As RenderObject = FindRoUnderScreenPoint(MousePosition)
        If ro Is Nothing Then
            e.Cancel = True
            Return
        End If
        showProperties.Tag = ro
        colorizeRo.Tag = ro
        Dim roText As RenderText = TryCast(ro, RenderText)
        setRoText.Enabled = roText IsNot Nothing
        If (setRoText.Enabled) Then
            setRoText.Text = roText.Text
            setRoText.Tag = roText
        Else
            setRoText.Text = "<not a RenderText>"
            setRoText.Tag = Nothing
        End If

    End Sub

    ' show the properties of the selected object,
    ' attach a handler to reflow the document on a property change
    Private Sub showProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showProperties.Click
        Dim ro As RenderObject = TryCast(sender, ToolStripItem).Tag
        If ro Is Nothing Then
            Return
        End If
        Dim props As RoProps = New RoProps()
        props.PropertyGrid.SelectedObject = ro
        AddHandler props.PropertyGrid.PropertyValueChanged, New PropertyValueChangedEventHandler(AddressOf PropertyGrid_PropertyValueChanged)
        props.Show()
    End Sub

    ' on a property change of a render object, we re-generate the document.
    ' NOTE: this really is not a completely supported/valid action, as the 
    ' property grid may allow changes to render object properties that are
    ' invalid. DO NOT USE THIS CODE IN A PRODUCTION SOFTWARE!
    Private Sub PropertyGrid_PropertyValueChanged(ByVal s As Object, ByVal e As PropertyValueChangedEventArgs)
        Dim ro As RenderObject = TryCast(s, PropertyGrid).SelectedObject
        If ro IsNot Nothing Then
            RegenerateDocument(ro.Document)
        End If
    End Sub

    ' change the background color of a render object,
    ' and regenerate the document.
    Private Sub colorizeRo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorizeRo.Click
        Dim ro As RenderObject = TryCast(sender, ToolStripItem).Tag
        If ro Is Nothing Then
            Return
        End If
        Dim cd As New ColorDialog()
        cd.Color = ro.Style.BackColor
        If cd.ShowDialog = Windows.Forms.DialogResult.OK Then
            ro.Style.BackColor = cd.Color
            RegenerateDocument(ro.Document)
        End If
    End Sub

    Private Sub setRoText_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setRoText.Validated
        Dim rt As RenderText = TryCast(sender, ToolStripItem).Tag
        If rt Is Nothing Then
            Return
        End If
        ContextMenuStrip1.Hide()
        rt.Text = setRoText.Text
        RegenerateDocument(rt.Document)
    End Sub

    Private Sub setRoText_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles setRoText.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            setRoText_Validated(sender, EventArgs.Empty)
        End If
    End Sub

    Private Sub setRoText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles setRoText.KeyPress
        If e.KeyChar = vbCr Then
            e.Handled = True
        End If
    End Sub
End Class
