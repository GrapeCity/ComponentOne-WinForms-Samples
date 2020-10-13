Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.ComponentModel

Public Enum ZoomMode
    ActualSize = 0
    Custom = 4
    FullPage = 1
    PageWidth = 2
    TwoPages = 3
End Enum

Public Class CoolPrintPreviewControl

    Inherits UserControl

    ' Events
    Public Event PageCountChanged As EventHandler
    Public Event StartPageChanged As EventHandler
    Public Event ZoomModeChanged As EventHandler

    ' Methods
    Public Sub New()
        Me.BackColor = SystemColors.AppWorkspace
        Me.ZoomMode = ZoomMode.FullPage
        Me.StartPage = 0
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
    End Sub

    Private Sub _doc_EndPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
        Me.SyncPageImages(True)
    End Sub

    Private Sub _doc_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Me.SyncPageImages(False)
        If Me._cancel Then
            e.Cancel = True
        End If
    End Sub

    Public Sub Cancel()
        Me._cancel = True
    End Sub

    Private Function GetImage(ByVal page As Integer) As Image
        If (page > -1) AndAlso (page < Me.PageCount) Then
            Return Me._img.Item(page)
        Else
            Return Nothing
        End If
    End Function

    Private Function GetImageRectangle(ByVal img As Image) As Rectangle

        Dim sz As Size = Me.GetImageSizeInPixels(img)
        Dim rc As New Rectangle(0, 0, sz.Width, sz.Height)

        Dim rcCli As Rectangle = MyBase.ClientRectangle
        Select Case Me._zoomMode
            Case ZoomMode.ActualSize
                Me._zoom = 1
                GoTo Label_00FF
            Case ZoomMode.FullPage
                Exit Select
            Case ZoomMode.PageWidth
                Me._zoom = IIf((rc.Width > 0), (CDbl(rcCli.Width) / CDbl(rc.Width)), 0)
                GoTo Label_00FF
            Case ZoomMode.TwoPages
                rc.Width = (rc.Width * 2)
                Exit Select
            Case Else
                GoTo Label_00FF
        End Select
        Dim zoomX As Double = IIf((rc.Width > 0), (CDbl(rcCli.Width) / CDbl(rc.Width)), 0)
        Dim zoomY As Double = IIf((rc.Height > 0), (CDbl(rcCli.Height) / CDbl(rc.Height)), 0)
        Me._zoom = Math.Min(zoomX, zoomY)
Label_00FF:
        rc.Width = CInt((rc.Width * Me._zoom))
        rc.Height = CInt((rc.Height * Me._zoom))
        Dim dx As Integer = ((rcCli.Width - rc.Width) / 2)
        If (dx > 0) Then
            rc.X = (rc.X + dx)
        End If
        Dim dy As Integer = ((rcCli.Height - rc.Height) / 2)
        If (dy > 0) Then
            rc.Y = (rc.Y + dy)
        End If
        rc.Inflate(-4, -4)
        If (Me._zoomMode = ZoomMode.TwoPages) Then
            rc.Inflate(-2, 0)
        End If
        Return rc
    End Function

    Private Function GetImageSizeInPixels(ByVal img As Image) As Size
        Dim szf As SizeF = img.PhysicalDimension
        If TypeOf img Is Metafile Then
            If (Me._himm2pix.X < 0.0!) Then
                Using g As Graphics = MyBase.CreateGraphics
                    Me._himm2pix.X = (g.DpiX / 2540.0!)
                    Me._himm2pix.Y = (g.DpiY / 2540.0!)
                End Using
            End If
            szf.Width = (szf.Width * Me._himm2pix.X)
            szf.Height = (szf.Height * Me._himm2pix.Y)
        End If
        Return Size.Truncate(szf)
    End Function

    Protected Overrides Function IsInputKey(ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Prior, Keys.Next, Keys.End, Keys.Home, Keys.Left, Keys.Up, Keys.Right, Keys.Down
                Return True
        End Select
        Return MyBase.IsInputKey(keyData)
    End Function

    Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
        MyBase.OnKeyDown(e)
        If e.Handled Then Return

        Select Case e.KeyCode

            ' arrow keys scroll or browse, depending on ZoomMode
            Case Keys.Left, Keys.Up, Keys.Right, Keys.Down

                ' browse
                If ZoomMode = ZoomMode.FullPage OrElse ZoomMode = ZoomMode.TwoPages Then
                    Select Case e.KeyCode
                        Case Keys.Left, Keys.Up
                            StartPage -= 1

                        Case Keys.Right, Keys.Down
                            StartPage += 1
                    End Select
                End If

                ' scroll
                Dim pt As Point = AutoScrollPosition
                Select Case e.KeyCode
                    Case Keys.Left
                        pt.X += 20
                    Case Keys.Right
                        pt.X -= 20
                    Case Keys.Up
                        pt.Y += 20
                    Case Keys.Down
                        pt.Y -= 20
                End Select
                AutoScrollPosition = New Point(-pt.X, -pt.Y)

                ' page up/down browse pages
            Case Keys.PageUp
                StartPage -= 1
            Case Keys.PageDown
                StartPage += 1

                ' home/end 
            Case Keys.Home
                AutoScrollPosition = Point.Empty
                StartPage = 0
            Case Keys.End
                AutoScrollPosition = Point.Empty
                StartPage = PageCount - 1

            Case Else
                Return
        End Select

        ' if we got here, the event was handled
        e.Handled = True
    End Sub

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        MyBase.OnMouseDown(e)
        If ((e.Button = MouseButtons.Left) AndAlso (MyBase.AutoScrollMinSize <> Size.Empty)) Then
            Me.Cursor = Cursors.NoMove2D
            Me._ptLast = New Point(e.X, e.Y)
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        MyBase.OnMouseMove(e)
        If (Me.Cursor Is Cursors.NoMove2D) Then
            Dim dx As Integer = (e.X - Me._ptLast.X)
            Dim dy As Integer = (e.Y - Me._ptLast.Y)
            If ((dx <> 0) OrElse (dy <> 0)) Then
                Dim pt As Point = MyBase.AutoScrollPosition
                MyBase.AutoScrollPosition = New Point(-(pt.X + dx), -(pt.Y + dy))
                Me._ptLast = New Point(e.X, e.Y)
            End If
        End If
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        MyBase.OnMouseUp(e)
        If ((e.Button = MouseButtons.Left) AndAlso (Me.Cursor Is Cursors.NoMove2D)) Then
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Protected Sub OnPageCountChanged(ByVal e As EventArgs)
        RaiseEvent PageCountChanged(Me, e)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim img As Image = Me.GetImage(Me.StartPage)
        If (Not img Is Nothing) Then
            Dim rc As Rectangle = Me.GetImageRectangle(img)
            If ((rc.Width > 2) AndAlso (rc.Height > 2)) Then
                rc.Offset(MyBase.AutoScrollPosition)
                If (Me._zoomMode <> ZoomMode.TwoPages) Then
                    Me.RenderPage(e.Graphics, img, rc)
                Else
                    rc.Width = ((rc.Width - 4) / 2)
                    Me.RenderPage(e.Graphics, img, rc)
                    img = Me.GetImage((Me.StartPage + 1))
                    If (Not img Is Nothing) Then
                        rc = Me.GetImageRectangle(img)
                        rc.Width = ((rc.Width - 4) / 2)
                        rc.Offset((rc.Width + 4), 0)
                        Me.RenderPage(e.Graphics, img, rc)
                    End If
                End If
            End If
        End If
        e.Graphics.FillRectangle(Me._backBrush, MyBase.ClientRectangle)
    End Sub

    Protected Overrides Sub OnPaintBackground(ByVal e As PaintEventArgs)
    End Sub

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        Me.UpdateScrollBars()
        MyBase.OnSizeChanged(e)
    End Sub

    Protected Sub OnStartPageChanged(ByVal e As EventArgs)
        RaiseEvent StartPageChanged(Me, e)
    End Sub

    Protected Sub OnZoomModeChanged(ByVal e As EventArgs)
        RaiseEvent ZoomModeChanged(Me, e)
    End Sub

    Public Sub Print()
        Dim ps As PrinterSettings = Me._doc.PrinterSettings
        Dim first As Integer = (ps.MinimumPage - 1)
        Dim last As Integer = (ps.MaximumPage - 1)
        Select Case ps.PrintRange
            Case PrintRange.AllPages
                Me.Document.Print()
                Return
            Case PrintRange.Selection
                first = Me.StartPage
                last = Me.StartPage
                If (Me.ZoomMode = ZoomMode.TwoPages) Then
                    last = Math.Min(CInt((first + 1)), CInt((Me.PageCount - 1)))
                End If
                Exit Select
            Case PrintRange.SomePages
                first = (ps.FromPage - 1)
                last = (ps.ToPage - 1)
                Exit Select
            Case PrintRange.CurrentPage
                first = Me.StartPage
                last = Me.StartPage
                Exit Select
        End Select

        Dim dp = New DocumentPrinter(Me, first, last)
        dp.Print()
    End Sub

    Public Sub RefreshPreview()
        If (Not Me._doc Is Nothing) Then
            Me._img.Clear()
            Dim savePC As PrintController = Me._doc.PrintController
            Try
                Me._cancel = False
                Me._rendering = True
                Me._doc.PrintController = New PreviewPrintController
                AddHandler Me._doc.PrintPage, New PrintPageEventHandler(AddressOf Me._doc_PrintPage)
                AddHandler Me._doc.EndPrint, New PrintEventHandler(AddressOf Me._doc_EndPrint)
                Me._doc.Print()
            Finally
                Me._cancel = False
                Me._rendering = False
                RemoveHandler Me._doc.PrintPage, New PrintPageEventHandler(AddressOf Me._doc_PrintPage)
                RemoveHandler Me._doc.EndPrint, New PrintEventHandler(AddressOf Me._doc_EndPrint)
                Me._doc.PrintController = savePC
            End Try
        End If
        Me.OnPageCountChanged(EventArgs.Empty)
        Me.UpdatePreview()
        Me.UpdateScrollBars()
    End Sub

    Private Sub RenderPage(ByVal g As Graphics, ByVal img As Image, ByVal rc As Rectangle)
        rc.Offset(1, 1)
        g.DrawRectangle(Pens.Black, rc)
        rc.Offset(-1, -1)
        g.FillRectangle(Brushes.White, rc)
        g.DrawImage(img, rc)
        g.DrawRectangle(Pens.Black, rc)
        rc.Width += 1
        rc.Height += 1
        g.ExcludeClip(rc)
        rc.Offset(1, 1)
        g.ExcludeClip(rc)
    End Sub

    Private Sub SyncPageImages(ByVal lastPageReady As Boolean)
        Dim pv As PreviewPrintController = DirectCast(Me._doc.PrintController, PreviewPrintController)
        If (Not pv Is Nothing) Then
            Dim pageInfo As PreviewPageInfo() = pv.GetPreviewPageInfo
            Dim count As Integer = IIf(lastPageReady, pageInfo.Length, (pageInfo.Length - 1))
            Dim i As Integer
            For i = Me._img.Count To count - 1
                Dim img As Image = pageInfo(i).Image
                Me._img.Add(img)
                Me.OnPageCountChanged(EventArgs.Empty)
                If (Me.StartPage < 0) Then
                    Me.StartPage = 0
                End If
                If ((i = Me.StartPage) OrElse (i = (Me.StartPage + 1))) Then
                    Me.Refresh()
                End If
                Application.DoEvents()
            Next i
        End If
    End Sub

    Private Sub UpdatePreview()
        If (Me._startPage < 0) Then
            Me._startPage = 0
        End If
        If (Me._startPage > (Me.PageCount - 1)) Then
            Me._startPage = (Me.PageCount - 1)
        End If
        MyBase.Invalidate()
    End Sub

    Private Sub UpdateScrollBars()
        Dim rc As Rectangle = Rectangle.Empty
        Dim img As Image = Me.GetImage(Me.StartPage)
        If (Not img Is Nothing) Then
            rc = Me.GetImageRectangle(img)
        End If
        Dim scrollSize As New Size(0, 0)
        Select Case Me._zoomMode
            Case ZoomMode.ActualSize, ZoomMode.Custom
                scrollSize = New Size((rc.Width + 8), (rc.Height + 8))
                Exit Select
            Case ZoomMode.PageWidth
                scrollSize = New Size(0, (rc.Height + 8))
                Exit Select
        End Select
        If (scrollSize <> MyBase.AutoScrollMinSize) Then
            MyBase.AutoScrollMinSize = scrollSize
        End If
        Me.UpdatePreview()
    End Sub


    ' Properties
    <DefaultValue(GetType(Color), "AppWorkspace")> _
    Public Overrides Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            Me._backBrush = New SolidBrush(value)
        End Set
    End Property

    Public Property Document() As PrintDocument
        Get
            Return Me._doc
        End Get
        Set(ByVal value As PrintDocument)
            If (Not value Is Me._doc) Then
                Me._doc = value
                Me.RefreshPreview()
            End If
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), Browsable(False)> _
    Public ReadOnly Property IsRendering() As Boolean
        Get
            Return Me._rendering
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public ReadOnly Property PageCount() As Integer
        Get
            Return Me._img.Count
        End Get
    End Property

    <Browsable(False)> _
    Public ReadOnly Property PageImages() As PageImageList
        Get
            Return Me._img
        End Get
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property StartPage() As Integer
        Get
            Return Me._startPage
        End Get
        Set(ByVal value As Integer)
            If (value > (Me.PageCount - 1)) Then
                value = (Me.PageCount - 1)
            End If
            If (value < 0) Then
                value = 0
            End If
            If (value <> Me._startPage) Then
                Me._startPage = value
                Me.UpdateScrollBars()
                Me.OnStartPageChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
    Public Property Zoom() As Double
        Get
            Return Me._zoom
        End Get
        Set(ByVal value As Double)
            If ((value <> Me._zoom) OrElse (Me.ZoomMode <> ZoomMode.Custom)) Then
                Me.ZoomMode = ZoomMode.Custom
                Me._zoom = value
                Me.UpdateScrollBars()
                Me.OnZoomModeChanged(EventArgs.Empty)
            End If
        End Set
    End Property

    <DefaultValue(1)> _
    Public Property ZoomMode() As ZoomMode
        Get
            Return Me._zoomMode
        End Get
        Set(ByVal value As ZoomMode)
            If (value <> Me._zoomMode) Then
                Me._zoomMode = value
                Me.UpdateScrollBars()
                Me.OnZoomModeChanged(EventArgs.Empty)
            End If
        End Set
    End Property


    ' Fields
    Private _backBrush As Brush
    Private _cancel As Boolean
    Private _doc As PrintDocument
    Private _himm2pix As PointF = New PointF(-1.0!, -1.0!)
    Private _img As PageImageList = New PageImageList
    Private _ptLast As Point
    Private _rendering As Boolean
    Private _startPage As Integer
    Private _zoom As Double
    Private _zoomMode As ZoomMode
    Private Const MARGIN As Integer = 4

    ' Nested Types
    Friend Class DocumentPrinter
        Inherits PrintDocument
        ' Methods
        Public Sub New(ByVal preview As CoolPrintPreviewControl, ByVal first As Integer, ByVal last As Integer)
            Me._first = first
            Me._last = last
            Me._imgList = preview.PageImages
            MyBase.DefaultPageSettings = preview.Document.DefaultPageSettings
            MyBase.PrinterSettings = preview.Document.PrinterSettings
        End Sub

        Protected Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
            Me._index = Me._first
        End Sub

        Protected Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
            e.Graphics.PageUnit = GraphicsUnit.Display
            e.Graphics.DrawImage(Me._imgList.Item(Me._index), e.PageBounds)
            Me._index = Me._index + 1
            e.HasMorePages = (Me._index <= Me._last)
        End Sub


        ' Fields
        Private _first As Integer
        Private _imgList As PageImageList
        Private _index As Integer
        Private _last As Integer
    End Class
End Class


