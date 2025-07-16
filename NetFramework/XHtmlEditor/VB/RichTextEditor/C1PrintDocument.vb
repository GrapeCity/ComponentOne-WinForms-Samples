Imports System.Drawing
Imports System.Drawing.Printing
Imports C1.Win.C1Editor

''' <summary>
''' Custom PrintDocument that knows how to render the contents of the C1Editor control.
''' </summary>
''' <remarks>
''' This class uses the C1SuperLabel to render the content of a C1Editor control into a
''' regular <see cref="PrintDocument"/> object which can in turn be used to preview, print,
''' or export the document to Pdf (using a C1Pdf component).
''' </remarks>
Public Class XhtmlPrintDocument
    Inherits PrintDocument
    Private _editor As C1Editor
    Private _label As C1.Win.SuperTooltip.C1SuperLabel
    Private _offset As Integer

    Public Sub New(ByVal editor As C1Editor)
        _editor = editor
    End Sub
    Protected Overloads Overrides Sub OnBeginPrint(ByVal e As PrintEventArgs)
        _offset = 0
        _label = New C1.Win.SuperTooltip.C1SuperLabel()
        _label.Text = _editor.Document.InnerXml
        _label.Font = _editor.Font
        _label.ForeColor = _editor.ForeColor
    End Sub
    Protected Overloads Overrides Sub OnEndPrint(ByVal e As PrintEventArgs)
        If _label IsNot Nothing Then
            _label.Dispose()
            _label = Nothing
        End If
    End Sub
    Protected Overloads Overrides Sub OnPrintPage(ByVal e As PrintPageEventArgs)
        ' calculate bounds
        Dim rc As Rectangle = e.MarginBounds
        Dim scale As Single = 96.0F / 100.0F
        Dim bounds As RectangleF = New RectangleF(rc.Left * scale, rc.Top * scale, rc.Width * scale, rc.Height * scale)

        ' render from current offset
        Dim newOffset As Integer = _label.DrawToGraphics(e.Graphics, bounds, _offset)

        ' update offset
        e.HasMorePages = newOffset <> _offset AndAlso newOffset < Integer.MaxValue
        _offset = newOffset
    End Sub
End Class
