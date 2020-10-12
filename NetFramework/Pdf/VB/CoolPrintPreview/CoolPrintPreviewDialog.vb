Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Text
Imports System.Windows.Forms

''' <summary>
''' Represents a dialog containing a <see cref="CoolPrintPreviewControl"/> control
''' used to preview and print <see cref="PrintDocument"/> objects.
''' </summary>
''' <remarks>
''' This dialog is similar to the standard <see cref="PrintPreviewDialog"/>
''' but provides additional options such printer and page setup buttons,
''' a better UI based on the <see cref="ToolStrip"/> control, and built-in
''' PDF export.
''' </remarks>
Friend Partial Class CoolPrintPreviewDialog
	Inherits Form
	'--------------------------------------------------------------------
	#Region "** fields"

	Private _doc As PrintDocument

	#End Region

	'--------------------------------------------------------------------
	#Region "** ctor"

	''' <summary>
	''' Initializes a new instance of a <see cref="CoolPrintPreviewDialog"/>.
	''' </summary>
	Public Sub New()
		Me.New(Nothing)
	End Sub
	''' <summary>
	''' Initializes a new instance of a <see cref="CoolPrintPreviewDialog"/>.
	''' </summary>
	''' <param name="parentForm">Parent form that defines the initial size for this dialog.</param>
	Public Sub New(parentForm As Control)
		InitializeComponent()
		If parentForm IsNot Nothing Then
			Size = parentForm.Size
		End If
	End Sub
	#End Region

	'--------------------------------------------------------------------
	#Region "** object model"

	''' <summary>
	''' Gets or sets the <see cref="PrintDocument"/> to preview.
	''' </summary>
	Public Property Document() As PrintDocument
		Get
			Return _doc
		End Get
		Set
			' unhook event handlers
			If _doc IsNot Nothing Then
				RemoveHandler _doc.BeginPrint, AddressOf _doc_BeginPrint
				RemoveHandler _doc.EndPrint, AddressOf _doc_EndPrint
			End If

			' save the value
			_doc = value

			' hook up event handlers
			If _doc IsNot Nothing Then
				AddHandler _doc.BeginPrint, AddressOf _doc_BeginPrint
				AddHandler _doc.EndPrint, AddressOf _doc_EndPrint
			End If


			' don't assign document to preview until this form becomes visible
			If Visible Then
				_preview.Document = Document
			End If
		End Set
	End Property

	#End Region

	'--------------------------------------------------------------------
	#Region "** overloads"

	''' <summary>
	''' Overridden to assign document to preview control only after the 
	''' initial activation.
	''' </summary>
	''' <param name="e"><see cref="EventArgs"/> that contains the event data.</param>
	Protected Overrides Sub OnShown(e As EventArgs)
		MyBase.OnShown(e)
		_preview.Document = Document
	End Sub
	''' <summary>
	''' Overridden to cancel any ongoing previews when closing form.
	''' </summary>
	''' <param name="e"><see cref="FormClosingEventArgs"/> that contains the event data.</param>
	Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
		MyBase.OnFormClosing(e)
		If _preview.IsRendering AndAlso Not e.Cancel Then
			_preview.Cancel()
		End If
	End Sub

	#End Region

	'--------------------------------------------------------------------
	#Region "** main commands"

	Private Sub _btnCreatePdf_Click(sender As Object, e As EventArgs)
        Dim dlg As New SaveFileDialog()
        dlg.Filter = "Portable Document File (*.pdf)|*.pdf"
        dlg.DefaultExt = ".pdf"
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim pdfGenerator As New PrintDocumentPdfExporter(_pdf)
            If pdfGenerator.RenderDocument(Document, True) Then
                _pdf.Save(dlg.FileName)
            End If
        End If
    End Sub
	Private Sub _btnPrint_Click(sender As Object, e As EventArgs)
        Dim dlg As New PrintDialog()

        ' configure dialog
        dlg.AllowSomePages = True
        dlg.AllowSelection = True
        dlg.UseEXDialog = True
        dlg.Document = Document

        ' show allowed page range
        Dim ps As PrinterSettings = dlg.PrinterSettings
        ps.MinimumPage = InlineAssignHelper(ps.FromPage, 1)
        ps.MaximumPage = InlineAssignHelper(ps.ToPage, _preview.PageCount)

        ' show dialog
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            ' print selected page range
            _preview.Print()
        End If
    End Sub
	Private Sub _btnPageSetup_Click(sender As Object, e As EventArgs)
        Dim dlg As New PageSetupDialog()
        dlg.Document = Document
        If dlg.ShowDialog(Me) = DialogResult.OK Then
            ' to show new page layout
            _preview.RefreshPreview()
        End If
    End Sub

	#End Region

	'--------------------------------------------------------------------
	#Region "** zoom"

	Private Sub _btnZoom_ButtonClick(sender As Object, e As EventArgs)
		_preview.ZoomMode = If(_preview.ZoomMode = ZoomMode.ActualSize, ZoomMode.FullPage, ZoomMode.ActualSize)
	End Sub
	Private Sub _btnZoom_DropDownItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)
		If e.ClickedItem Is _itemActualSize Then
			_preview.ZoomMode = ZoomMode.ActualSize
		ElseIf e.ClickedItem Is _itemFullPage Then
			_preview.ZoomMode = ZoomMode.FullPage
		ElseIf e.ClickedItem Is _itemPageWidth Then
			_preview.ZoomMode = ZoomMode.PageWidth
		ElseIf e.ClickedItem Is _itemTwoPages Then
			_preview.ZoomMode = ZoomMode.TwoPages
		End If
		If e.ClickedItem Is _item10 Then
			_preview.Zoom = 0.1
		ElseIf e.ClickedItem Is _item100 Then
			_preview.Zoom = 1
		ElseIf e.ClickedItem Is _item150 Then
			_preview.Zoom = 1.5
		ElseIf e.ClickedItem Is _item200 Then
			_preview.Zoom = 2
		ElseIf e.ClickedItem Is _item25 Then
			_preview.Zoom = 0.25
		ElseIf e.ClickedItem Is _item50 Then
			_preview.Zoom = 0.5
		ElseIf e.ClickedItem Is _item500 Then
			_preview.Zoom = 5
		ElseIf e.ClickedItem Is _item75 Then
			_preview.Zoom = 0.75
		End If
	End Sub
	#End Region

	'--------------------------------------------------------------------
	#Region "** page navigation"

	Private Sub _btnFirst_Click(sender As Object, e As EventArgs)
		_preview.StartPage = 0
	End Sub
	Private Sub _btnPrev_Click(sender As Object, e As EventArgs)
		_preview.StartPage -= 1
	End Sub
	Private Sub _btnNext_Click(sender As Object, e As EventArgs)
		_preview.StartPage += 1
	End Sub
	Private Sub _btnLast_Click(sender As Object, e As EventArgs)
		_preview.StartPage = _preview.PageCount - 1
	End Sub
	Private Sub _txtStartPage_Enter(sender As Object, e As EventArgs)
		_txtStartPage.SelectAll()
	End Sub
	Private Sub _txtStartPage_Validating(sender As Object, e As CancelEventArgs)
		CommitPageNumber()
	End Sub
	Private Sub _txtStartPage_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim c As Char = e.KeyChar
		If c = ChrW(13) Then
			CommitPageNumber()
			e.Handled = True
		ElseIf c > " "C AndAlso Not Char.IsDigit(c) Then
			e.Handled = True
		End If
	End Sub
	Private Sub CommitPageNumber()
		Dim page As Integer
		If Integer.TryParse(_txtStartPage.Text, page) Then
			_preview.StartPage = page - 1
		End If
	End Sub
	Private Sub _preview_StartPageChanged(sender As Object, e As EventArgs)
        Dim page As Integer = _preview.StartPage + 1
		_txtStartPage.Text = page.ToString()
	End Sub
	Private Sub _preview_PageCountChanged(sender As Object, e As EventArgs)
		Me.Update()
		Application.DoEvents()
		_lblPageCount.Text = String.Format("of {0}", _preview.PageCount)
	End Sub

	#End Region

	'--------------------------------------------------------------------
	#Region "** job control"

	Private Sub _btnCancel_Click(sender As Object, e As EventArgs)
		If _preview.IsRendering Then
			_preview.Cancel()
		Else
			Close()
		End If
	End Sub
	Private Sub _doc_BeginPrint(sender As Object, e As PrintEventArgs)
		_btnCancel.Text = "&Cancel"
		_btnPrint.Enabled = InlineAssignHelper(_btnCreatePdf.Enabled, InlineAssignHelper(_btnPageSetup.Enabled, False))
	End Sub
	Private Sub _doc_EndPrint(sender As Object, e As PrintEventArgs)
		_btnCancel.Text = "&Close"
		_btnPrint.Enabled = InlineAssignHelper(_btnCreatePdf.Enabled, InlineAssignHelper(_btnPageSetup.Enabled, True))
	End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function

	#End Region
End Class
