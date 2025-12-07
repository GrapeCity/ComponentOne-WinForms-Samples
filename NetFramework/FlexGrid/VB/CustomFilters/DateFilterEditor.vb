Imports System.ComponentModel
Imports System.Text

Namespace CustomFilters
	Partial Public Class DateFilterEditor
		Inherits UserControl
		Implements C1.Win.FlexGrid.IC1ColumnFilterEditor
		'-------------------------------------------------------------------------------
		#Region "** fields"

		Private _filter As DateFilter

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** ctor"

		Public Sub New()
			InitializeComponent()
		End Sub

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** IC1ColumnFilterEditor"

		Public Sub Initialize(ByVal grid As C1.Win.FlexGrid.C1FlexGridBase, ByVal columnIndex As Integer, ByVal filter As C1.Win.FlexGrid.IC1ColumnFilter) Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.Initialize
			_filter = CType(filter, DateFilter)

			' TODO: 
			' a really useful editor would set the calendar/checkboxes to match the current
			' filter values.
		End Sub
		Public Sub ApplyChanges() Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.ApplyChanges
			_filter.Reset()
			If _chkCalendar.Checked Then
				_filter.Minimum = _calendar.SelectionRange.Start
				_filter.Maximum = _calendar.SelectionRange.End
			Else
				Dim yesterday = Date.Today.AddDays(-1)
				If _chkYesterday.Checked Then
					_filter.Maximum = yesterday
					_filter.Minimum = yesterday
				End If
				If _chkEarlierThisWeek.Checked Then
					_filter.Maximum = yesterday
					_filter.Minimum = yesterday
					Do While _filter.Minimum.DayOfWeek <> DayOfWeek.Monday
						_filter.Minimum = _filter.Minimum.AddDays(-1)
					Loop
				End If
				If _chkLastWeek.Checked Then
					_filter.Maximum = yesterday
					_filter.Minimum = yesterday.AddDays(-7)
					Do While _filter.Minimum.DayOfWeek <> DayOfWeek.Monday
						_filter.Minimum = _filter.Minimum.AddDays(-1)
					Loop
				End If
				If _chkLongAgo.Checked Then
					_filter.Maximum = yesterday
					_filter.Minimum = yesterday.AddYears(-5)
				End If
			End If
		End Sub
		Public ReadOnly Property KeepFormOpen() As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilterEditor.KeepFormOpen
			Get
				Return False
			End Get
		End Property

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** event handlers"

		Private Sub _calendar_DateSelected(ByVal sender As Object, ByVal e As DateRangeEventArgs) Handles _calendar.DateSelected
			_chkCalendar.Checked = True
		End Sub
		Private Sub _chkCalendar_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _chkCalendar.CheckedChanged
			Dim cb = TryCast(sender, CheckBox)
			cb.Font = New Font(Font,If(cb.Checked, FontStyle.Bold, FontStyle.Regular))
		End Sub

		#End Region
	End Class
End Namespace
