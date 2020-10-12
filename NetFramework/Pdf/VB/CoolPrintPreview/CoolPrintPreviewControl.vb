Imports System.Data
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports System.Windows.Forms
Imports System.Windows.Forms.Design

''' <summary>
''' Specifies the zoom mode for the <see cref="CoolPrintPreviewControl"/> control.
''' </summary>
Friend Enum ZoomMode
	''' <summary>
	''' Show the preview in actual size.
	''' </summary>
	ActualSize
	''' <summary>
	''' Show a full page.
	''' </summary>
	FullPage
	''' <summary>
	''' Show a full page width.
	''' </summary>
	PageWidth
	''' <summary>
	''' Show two full pages.
	''' </summary>
	TwoPages
	''' <summary>
	''' Use the zoom factor specified by the <see cref="CoolPrintPreviewControl.Zoom"/> property.
	''' </summary>
	[Custom]
End Enum

''' <summary>
''' Represents a preview of one or two pages in a <see cref="PrintDocument"/>.
''' </summary>
''' <remarks>
''' This control is similar to the standard <see cref="PrintPreviewControl"/> but
''' it displays pages as they are rendered. By contrast, the standard control 
''' waits until the entire document is rendered before it displays anything.
''' </remarks>
Friend Class CoolPrintPreviewControl
	Inherits UserControl
	'-------------------------------------------------------------
	#Region "** fields"

	Private _doc As PrintDocument
	Private _zoomMode As ZoomMode
	Private _zoom As Double
	Private _startPage As Integer
	Private _backBrush As Brush
	Private _ptLast As Point
	Private _img As New List(Of Image)()
	Private _himm2pix As New PointF(-1, -1)
	Private _cancel As Boolean, _rendering As Boolean

    Const DOC_MARGIN As Integer = 4

	#End Region

	'-------------------------------------------------------------
	#Region "** ctor"

	''' <summary>
	''' Initializes a new instance of a <see cref="CoolPrintPreviewControl"/> control.
	''' </summary>
	Public Sub New()
		BackColor = SystemColors.AppWorkspace
		ZoomMode = ZoomMode.FullPage
		StartPage = 0
		SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
	End Sub

	#End Region

	'-------------------------------------------------------------
	#Region "** object model"

	''' <summary>
	''' Gets or sets the <see cref="PrintDocument"/> being previewed.
	''' </summary>
	Public Property Document() As PrintDocument
		Get
			Return _doc
		End Get
		Set
			If value IsNot _doc Then
				_doc = value
				RefreshPreview()
			End If
		End Set
	End Property
	''' <summary>
	''' Regenerates the preview to reflect changes in the document layout.
	''' </summary>
	Public Sub RefreshPreview()
		' render into PrintController
		If _doc IsNot Nothing Then
			' prepare to render preview document
			_img.Clear()
			Dim savePC As PrintController = _doc.PrintController

			' render preview document
			Try
				_cancel = False
				_rendering = True
				_doc.PrintController = New PreviewPrintController()
				AddHandler _doc.PrintPage, AddressOf _doc_PrintPage
				AddHandler _doc.EndPrint, AddressOf _doc_EndPrint
				_doc.Print()
			Finally
				_cancel = False
				_rendering = False
				RemoveHandler _doc.PrintPage, AddressOf _doc_PrintPage
				RemoveHandler _doc.EndPrint, AddressOf _doc_EndPrint
				_doc.PrintController = savePC
			End Try
		End If

		' update
		OnPageCountChanged(EventArgs.Empty)
		UpdatePreview()
		UpdateScrollBars()
	End Sub
	''' <summary>
	''' Stops rendering the <see cref="Document"/>.
	''' </summary>
	Public Sub Cancel()
		_cancel = True
	End Sub
	''' <summary>
	''' Gets a value that indicates whether the <see cref="Document"/> is being rendered.
	''' </summary>
	<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
	Public ReadOnly Property IsRendering() As Boolean
		Get
			Return _rendering
		End Get
	End Property
	''' <summary>
	''' Gets or sets how the zoom should be adjusted when the control is resized.
	''' </summary>
	<DefaultValue(ZoomMode.FullPage)> _
	Public Property ZoomMode() As ZoomMode
		Get
			Return _zoomMode
		End Get
		Set
			If value <> _zoomMode Then
				_zoomMode = value
				UpdateScrollBars()
				OnZoomModeChanged(EventArgs.Empty)
			End If
		End Set
	End Property
	''' <summary>
	''' Gets or sets a custom zoom factor used when the <see cref="ZoomMode"/> property
	''' is set to <b>Custom</b>.
	''' </summary>
	<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
	Public Property Zoom() As Double
		Get
			Return _zoom
		End Get
		Set
			If value <> _zoom OrElse ZoomMode <> ZoomMode.[Custom] Then
				ZoomMode = ZoomMode.[Custom]
				_zoom = value
				UpdateScrollBars()
				OnZoomModeChanged(EventArgs.Empty)
			End If
		End Set
	End Property
	''' <summary>
	''' Gets or sets the first page being previewed.
	''' </summary>
	''' <remarks>
	''' There may be one or two pages visible depending on the setting of the
	''' <see cref="ZoomMode"/> property.
	''' </remarks>
	<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
	Public Property StartPage() As Integer
		Get
			Return _startPage
		End Get
		Set
			' validate new setting
			If value > PageCount - 1 Then
				value = PageCount - 1
			End If
			If value < 0 Then
				value = 0
			End If

			' apply new setting
			If value <> _startPage Then
				_startPage = value
				UpdateScrollBars()
				OnStartPageChanged(EventArgs.Empty)
			End If
		End Set
	End Property
	''' <summary>
	''' Gets the number of pages available for preview.
	''' </summary>
	''' <remarks>
	''' This number increases as the document is rendered into the control.
	''' </remarks>
	<Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
	Public ReadOnly Property PageCount() As Integer
		Get
			Return _img.Count
		End Get
	End Property
	''' <summary>
	''' Gets or sets the control's background color.
	''' </summary>
	<DefaultValue(GetType(Color), "AppWorkspace")> _
	Public Overrides Property BackColor() As Color
		Get
			Return MyBase.BackColor
		End Get
		Set
			MyBase.BackColor = value
			_backBrush = New SolidBrush(value)
		End Set
	End Property
	''' <summary>
	''' Gets a list containing the images of the pages in the document.
	''' </summary>
	<Browsable(False)> _
	Public ReadOnly Property PageImages() As List(Of Image)
		Get
			Return _img
		End Get
	End Property
	''' <summary>
	''' Prints the current document honoring the selected page range.
	''' </summary>
	Public Sub Print()
		' select pages to print
        Dim ps As PrinterSettings = _doc.PrinterSettings
		Dim first As Integer = ps.MinimumPage - 1
		Dim last As Integer = ps.MaximumPage - 1
		Select Case ps.PrintRange
			Case PrintRange.AllPages
				Document.Print()
				Return
			Case PrintRange.CurrentPage
				first = InlineAssignHelper(last, StartPage)
				Exit Select
			Case PrintRange.Selection
				first = InlineAssignHelper(last, StartPage)
				If ZoomMode = ZoomMode.TwoPages Then
					last = Math.Min(first + 1, PageCount - 1)
				End If
				Exit Select
			Case PrintRange.SomePages
				first = ps.FromPage - 1
				last = ps.ToPage - 1
				Exit Select
		End Select

		' print using helper class
        Dim dp As New DocumentPrinter(Me, first, last)
		dp.Print()
	End Sub

	#End Region

	'-------------------------------------------------------------
	#Region "** events"

	''' <summary>
	''' Occurs when the value of the <see cref="StartPage"/> property changes.
	''' </summary>
	Public Event StartPageChanged As EventHandler
	''' <summary>
	''' Raises the <see cref="StartPageChanged"/> event.
	''' </summary>
	''' <param name="e"><see cref="EventArgs"/> that provides the event data.</param>
	Protected Sub OnStartPageChanged(e As EventArgs)
		RaiseEvent StartPageChanged(Me, e)
	End Sub
	''' <summary>
	''' Occurs when the value of the <see cref="PageCount"/> property changes.
	''' </summary>
	Public Event PageCountChanged As EventHandler
	''' <summary>
	''' Raises the <see cref="PageCountChanged"/> event.
	''' </summary>
	''' <param name="e"><see cref="EventArgs"/> that provides the event data/</param>
	Protected Sub OnPageCountChanged(e As EventArgs)
		RaiseEvent PageCountChanged(Me, e)
	End Sub
	''' <summary>
	''' Occurs when the value of the <see cref="ZoomMode"/> property changes.
	''' </summary>
	Public Event ZoomModeChanged As EventHandler
	''' <summary>
	''' Raises the <see cref="ZoomModeChanged"/> event.
	''' </summary>
	''' <param name="e"><see cref="EventArgs"/> that contains the event data.</param>
	Protected Sub OnZoomModeChanged(e As EventArgs)
		RaiseEvent ZoomModeChanged(Me, e)
	End Sub

	#End Region

	'-------------------------------------------------------------
	#Region "** overrides"

	' painting
	Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
		' we're painting it all, so don't call base class
		'base.OnPaintBackground(e);
	End Sub
	Protected Overrides Sub OnPaint(e As PaintEventArgs)
		Dim img As Image = GetImage(StartPage)
		If img IsNot Nothing Then
			Dim rc As Rectangle = GetImageRectangle(img)
			If rc.Width > 2 AndAlso rc.Height > 2 Then
				' adjust for scrollbars
				rc.Offset(AutoScrollPosition)

				' render single page
				If _zoomMode <> ZoomMode.TwoPages Then
					RenderPage(e.Graphics, img, rc)
				Else
					' render two pages
					' render first page
                    rc.Width = (rc.Width - DOC_MARGIN) \ 2
					RenderPage(e.Graphics, img, rc)

					' render second page
					img = GetImage(StartPage + 1)
					If img IsNot Nothing Then
						' update bounds in case orientation changed
						rc = GetImageRectangle(img)
                        rc.Width = (rc.Width - DOC_MARGIN) \ 2

						' render second page
                        rc.Offset(rc.Width + DOC_MARGIN, 0)
						RenderPage(e.Graphics, img, rc)
					End If
				End If
			End If
		End If

		' paint background
		e.Graphics.FillRectangle(_backBrush, ClientRectangle)
	End Sub
	Protected Overrides Sub OnSizeChanged(e As EventArgs)
		UpdateScrollBars()
		MyBase.OnSizeChanged(e)
	End Sub

	' pan by dragging preview pane
	Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
		MyBase.OnMouseDown(e)
		If e.Button = MouseButtons.Left AndAlso AutoScrollMinSize <> Size.Empty Then
			Cursor = Cursors.NoMove2D
			_ptLast = New Point(e.X, e.Y)
		End If
	End Sub
	Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
		MyBase.OnMouseUp(e)
		If e.Button = MouseButtons.Left AndAlso Cursor Is Cursors.NoMove2D Then
			Cursor = Cursors.[Default]
		End If
	End Sub
	Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
		MyBase.OnMouseMove(e)
		If Cursor Is Cursors.NoMove2D Then
			Dim dx As Integer = e.X - _ptLast.X
			Dim dy As Integer = e.Y - _ptLast.Y
			If dx <> 0 OrElse dy <> 0 Then
				Dim pt As Point = AutoScrollPosition
				AutoScrollPosition = New Point(-(pt.X + dx), -(pt.Y + dy))
				_ptLast = New Point(e.X, e.Y)
			End If
		End If
	End Sub

	' keyboard support
	Protected Overrides Function IsInputKey(keyData As Keys) As Boolean
		Select Case keyData
			Case Keys.Left, Keys.Up, Keys.Right, Keys.Down, Keys.PageUp, Keys.PageDown, _
				Keys.Home, Keys.[End]
				Return True
		End Select
		Return MyBase.IsInputKey(keyData)
	End Function
	Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
		MyBase.OnKeyDown(e)
		If e.Handled Then
			Return
		End If

		Select Case e.KeyCode
			' arrow keys scroll or browse, depending on ZoomMode
			Case Keys.Left, Keys.Up, Keys.Right, Keys.Down

				' browse
				If ZoomMode = ZoomMode.FullPage OrElse ZoomMode = ZoomMode.TwoPages Then
					Select Case e.KeyCode
						Case Keys.Left, Keys.Up
							StartPage -= 1
							Exit Select
						Case Keys.Right, Keys.Down
							StartPage += 1
							Exit Select
					End Select
					Exit Select
				End If

				' scroll
				Dim pt As Point = AutoScrollPosition
				Select Case e.KeyCode
					Case Keys.Left
						pt.X += 20
						Exit Select
					Case Keys.Right
						pt.X -= 20
						Exit Select
					Case Keys.Up
						pt.Y += 20
						Exit Select
					Case Keys.Down
						pt.Y -= 20
						Exit Select
				End Select
				AutoScrollPosition = New Point(-pt.X, -pt.Y)
				Exit Select

			' page up/down browse pages
			Case Keys.PageUp
				StartPage -= 1
				Exit Select
			Case Keys.PageDown
				StartPage += 1
				Exit Select

			' home/end 
			Case Keys.Home
				AutoScrollPosition = Point.Empty
				StartPage = 0
				Exit Select
			Case Keys.[End]
				AutoScrollPosition = Point.Empty
				StartPage = PageCount - 1
				Exit Select
			Case Else

				Return
		End Select

		' if we got here, the event was handled
		e.Handled = True
	End Sub

	#End Region

	'-------------------------------------------------------------
	#Region "** implementation"

	Private Sub _doc_PrintPage(sender As Object, e As PrintPageEventArgs)
		SyncPageImages()
		If _cancel Then
			e.Cancel = True
		End If
	End Sub
	Private Sub _doc_EndPrint(sender As Object, e As PrintEventArgs)
		SyncPageImages()
	End Sub
	Private Sub SyncPageImages()
        Dim pv As PreviewPrintController = DirectCast(_doc.PrintController, PreviewPrintController)
		If pv IsNot Nothing Then
            Dim pageInfo As PreviewPageInfo() = pv.GetPreviewPageInfo()
			For i As Integer = _img.Count To pageInfo.Length - 1
				_img.Add(pageInfo(i).Image)
				OnPageCountChanged(EventArgs.Empty)
				If StartPage < 0 Then
					StartPage = 0
				End If
				If i = StartPage OrElse i = StartPage + 1 Then
					Refresh()
				End If
				Application.DoEvents()
			Next
		End If
	End Sub
	Private Function GetImage(page As Integer) As Image
		Return If(page > -1 AndAlso page < PageCount, _img(page), Nothing)
	End Function
	Private Function GetImageRectangle(img As Image) As Rectangle
		' start with regular image rectangle
		Dim sz As Size = GetImageSizeInPixels(img)
		Dim rc As New Rectangle(0, 0, sz.Width, sz.Height)

		' calculate zoom
		Dim rcCli As Rectangle = Me.ClientRectangle
		Select Case _zoomMode
			Case ZoomMode.ActualSize
				_zoom = 1
				Exit Select
			Case ZoomMode.TwoPages
				rc.Width *= 2
				' << two pages side-by-side
                ' fall through... goto case ZoomMode.FullPage
			Case ZoomMode.FullPage
				Dim zoomX As Double = If((rc.Width > 0), rcCli.Width / CDbl(rc.Width), 0)
				Dim zoomY As Double = If((rc.Height > 0), rcCli.Height / CDbl(rc.Height), 0)
				_zoom = Math.Min(zoomX, zoomY)
				Exit Select
			Case ZoomMode.PageWidth
				_zoom = If((rc.Width > 0), rcCli.Width / CDbl(rc.Width), 0)
				Exit Select
		End Select

		' apply zoom factor
		rc.Width = CInt(Math.Truncate(rc.Width * _zoom))
		rc.Height = CInt(Math.Truncate(rc.Height * _zoom))

		' center image
		Dim dx As Integer = (rcCli.Width - rc.Width) \ 2
		If dx > 0 Then
			rc.X += dx
		End If
		Dim dy As Integer = (rcCli.Height - rc.Height) \ 2
		If dy > 0 Then
			rc.Y += dy
		End If

		' add some extra space
        rc.Inflate(-DOC_MARGIN, -DOC_MARGIN)
		If _zoomMode = ZoomMode.TwoPages Then
            rc.Inflate(-DOC_MARGIN \ 2, 0)
		End If

		' done
		Return rc
	End Function
	Private Function GetImageSizeInPixels(img As Image) As Size
		' get image size
		Dim szf As SizeF = img.PhysicalDimension

		' if it is a metafile, convert to pixels
		If TypeOf img Is Metafile Then
			' get screen resolution
			If _himm2pix.X < 0 Then
				Using g As Graphics = Me.CreateGraphics()
					_himm2pix.X = g.DpiX / 2540F
					_himm2pix.Y = g.DpiY / 2540F
				End Using
			End If

			' convert himetric to pixels
			szf.Width *= _himm2pix.X
			szf.Height *= _himm2pix.Y
		End If

		' done
		Return Size.Truncate(szf)
	End Function
	Private Sub RenderPage(g As Graphics, img As Image, rc As Rectangle)
		' draw the page
		rc.Offset(1, 1)
		g.DrawRectangle(Pens.Black, rc)
		rc.Offset(-1, -1)
		g.FillRectangle(Brushes.White, rc)
		g.DrawImage(img, rc)
		g.DrawRectangle(Pens.Black, rc)

		' exclude cliprect to paint background later
		rc.Width += 1
		rc.Height += 1
		g.ExcludeClip(rc)
		rc.Offset(1, 1)
		g.ExcludeClip(rc)
	End Sub
	Private Sub UpdateScrollBars()
		' get image rectangle to adjust scroll size
		Dim rc As Rectangle = Rectangle.Empty
		Dim img As Image = Me.GetImage(StartPage)
		If img IsNot Nothing Then
			rc = GetImageRectangle(img)
		End If

		' calculate new scroll size
		Dim scrollSize As New Size(0, 0)
		Select Case _zoomMode
			Case ZoomMode.PageWidth
                scrollSize = New Size(0, rc.Height + 2 * DOC_MARGIN)
				Exit Select
			Case ZoomMode.ActualSize, ZoomMode.[Custom]
                scrollSize = New Size(rc.Width + 2 * DOC_MARGIN, rc.Height + 2 * DOC_MARGIN)
				Exit Select
		End Select

		' apply if needed
		If scrollSize <> AutoScrollMinSize Then
			AutoScrollMinSize = scrollSize
		End If

		' ready to update
		UpdatePreview()
	End Sub
	Private Sub UpdatePreview()
		' validate current page
		If _startPage < 0 Then
			_startPage = 0
		End If
		If _startPage > PageCount - 1 Then
			_startPage = PageCount - 1
		End If

		' repaint
		Invalidate()
	End Sub
	#End Region

	'-------------------------------------------------------------
	#Region "** nested class"

	' helper class that prints the selected page range in a PrintDocument.
	Friend Class DocumentPrinter
		Inherits PrintDocument
		Private _first As Integer, _last As Integer, _index As Integer
		Private _imgList As List(Of Image)

		Public Sub New(preview As CoolPrintPreviewControl, first As Integer, last As Integer)
			' save page range and image list
			_first = first
			_last = last
			_imgList = preview.PageImages

			' copy page and printer settings from original document
			DefaultPageSettings = preview.Document.DefaultPageSettings
			PrinterSettings = preview.Document.PrinterSettings
		End Sub

		Protected Overrides Sub OnBeginPrint(e As PrintEventArgs)
			' start from the first page
			_index = _first
		End Sub
		Protected Overrides Sub OnPrintPage(e As PrintPageEventArgs)
			' render the current page and increment the index
			e.Graphics.PageUnit = GraphicsUnit.Display
			e.Graphics.DrawImage(_imgList(System.Math.Max(System.Threading.Interlocked.Increment(_index),_index - 1)), e.PageBounds)

			' stop when we reach the last page in the range
			e.HasMorePages = _index <= _last
		End Sub
	End Class
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region
End Class
