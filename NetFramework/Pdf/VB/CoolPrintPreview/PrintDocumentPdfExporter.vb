Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Text

Imports C1.C1Pdf

''' <summary>
''' Represents a class that exports a <see cref="PrintDocument"/> to a
''' PDF file.
''' </summary>
Friend Class PrintDocumentPdfExporter
	'-----------------------------------------------------------
	#Region "** fields"

	Private _doc As PrintDocument
	Private _pdf As C1PdfDocument
	Private _previewController As PreviewPrintController
	Private _pageCount As Integer
	Private _cancel As Boolean

	#End Region

	'-----------------------------------------------------------
	#Region "** ctor"

	Public Sub New(pdf As C1PdfDocument)
		' save reference to pdf component
		_pdf = pdf
	End Sub

	#End Region

	'-----------------------------------------------------------
	#Region "** object model"

	Public Function RenderDocument(doc As PrintDocument, showProgressDialog As Boolean) As Boolean
		' save reference to document
		_doc = doc

		' initialize pdf document
		_pdf.Clear()
		_pdf.Landscape = False

		' prepare to render
        Dim savePC As PrintController = _doc.PrintController
		_previewController = New PreviewPrintController()
		_doc.PrintController = If(showProgressDialog, New PrintControllerWithStatusDialog(_previewController), DirectCast(_previewController, PrintController))
		_pageCount = 0
		_cancel = False

		' render
		Try
			AddHandler _doc.PrintPage, AddressOf _doc_PrintPage
			AddHandler _doc.EndPrint, AddressOf _doc_EndPrint
			_doc.Print()
		Finally
			RemoveHandler _doc.PrintPage, AddressOf _doc_PrintPage
			RemoveHandler _doc.EndPrint, AddressOf _doc_EndPrint
			_doc.PrintController = savePC
		End Try

		' done
		Return Not _cancel
	End Function

	#End Region

	'-----------------------------------------------------------
	#Region "** PrintDocument event handlers"

	Private Sub _doc_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim pages As PreviewPageInfo() = _previewController.GetPreviewPageInfo()
        While _pageCount < pages.Length - 1
            DrawPage(pages, System.Math.Max(_pageCount, _pageCount - 1))
            _pageCount = _pageCount + 1
        End While
        If e.Cancel Then
            _cancel = True
        End If
    End Sub
	Private Sub _doc_EndPrint(sender As Object, e As PrintEventArgs)
        Dim pages As PreviewPageInfo() = _previewController.GetPreviewPageInfo()
		DrawPage(pages, _pageCount)
		If e.Cancel Then
			_cancel = True
		End If
	End Sub
    Private Sub DrawPage(pages As PreviewPageInfo(), index As Integer)

        ' skip to next page
        If index > 0 Then
            _pdf.NewPage()
        End If

        ' get preview page info
        Dim pi As PreviewPageInfo = pages(index)

        ' adjust page size
        Dim ps As Size = pi.PhysicalSize
        _pdf.PageSize = New SizeF(ps.Width / 100.0F * 72, ps.Height / 100.0F * 72)

        ' draw image
        Dim img As Image = pi.Image
        _pdf.DrawImage(img, _pdf.PageRectangle)
    End Sub

	#End Region
End Class
