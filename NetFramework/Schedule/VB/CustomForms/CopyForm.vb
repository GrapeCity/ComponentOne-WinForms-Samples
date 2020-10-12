Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace TestSchedule
	''' <summary>
	''' This form allows to select DateTime from the MonthCalendar control.
	''' </summary>
	Public Partial Class CopyForm
		Inherits Form
		Private _date As DateTime = DateTime.Today

		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property [Date]() As DateTime
			Get
				Return _date
			End Get
		End Property

		Private Sub monthCalendar1_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles monthCalendar1.DateSelected
			_date = e.Start
			Me.DialogResult = DialogResult.OK
			Close()
		End Sub
	End Class
End Namespace
