Imports C1.Win.TouchToolKit
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class PanWindowForm
		Inherits Form
		Private _formStartPosition As FormStartPosition
		Private _size As Size
		Private _location As Point
		Private _methodName As String

		Public Sub New()
			InitializeComponent()
		End Sub

		Public Sub New(methodName As String, size As Size, location As Point, formStartPosition As FormStartPosition)
			InitializeComponent()

			_methodName = methodName
			_size = size
			_location = location
			_formStartPosition = formStartPosition
		End Sub

		Protected Overrides Sub OnLoad(e As EventArgs)
			MyBase.OnLoad(e)

			gcZoom1.ZoomFactor = 2F

			Select Case _methodName
				Case "Form ShowPanWindow();"
					gcZoom1.ShowPanWindow()
					Exit Select
                Case "Form ShowPanWindow(FormStartPosition);"
                    gcZoom1.ShowPanWindow(_formStartPosition)
                    Exit Select
                Case "Form ShowPanWindow(FormStartPosition, Size);"
                    gcZoom1.ShowPanWindow(_formStartPosition, _size)
                    Exit Select
                Case "Form ShowPanWindow(Point);"
                    gcZoom1.ShowPanWindow(_location)
                    Exit Select
                Case "Form ShowPanWindow(Point, Size);"
                    gcZoom1.ShowPanWindow(_location, _size)
                    Exit Select
				Case Else
					Exit Select
			End Select
		End Sub
	End Class
End Namespace
