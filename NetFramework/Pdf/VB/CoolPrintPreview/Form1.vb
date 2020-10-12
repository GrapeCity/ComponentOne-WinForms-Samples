Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class Form1
	Inherits Form
	' constructor
	Public Sub New()
		InitializeComponent()
	End Sub

	' generate sample document
	Private _page As Integer = 0
	Private _font As New Font("Segoe UI", 14)
	Private Sub printDocument1_BeginPrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs)
		_page = 0
	End Sub
	Private Sub printDocument1_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs)
		' fill page with text
		Dim rc As Rectangle = e.MarginBounds
		rc.Height = _font.Height + 10
		Dim i As Integer = 0
		While True
            Dim text As String = String.Format("line {0} on page {1}", i + 1, _page + 1)
			e.Graphics.DrawString(text, _font, Brushes.Black, rc)
			rc.Y += rc.Height
			If rc.Bottom > e.MarginBounds.Bottom Then
				Exit While
			End If
			i += 1
		End While

		' move on to next page
		_page += 1
		e.HasMorePages = _page < 30
	End Sub

	' show standard print preview
	Private Sub button1_Click(sender As Object, e As EventArgs)
        Dim dlg As New PrintPreviewDialog()
        dlg.Document = Me.printDocument1
        dlg.ShowDialog(Me)
    End Sub

	' show cool print preview
	Private Sub button2_Click(sender As Object, e As EventArgs)
        Dim dlg As New CoolPrintPreviewDialog()
        dlg.Document = Me.printDocument1
        dlg.ShowDialog(Me)
    End Sub
End Class
