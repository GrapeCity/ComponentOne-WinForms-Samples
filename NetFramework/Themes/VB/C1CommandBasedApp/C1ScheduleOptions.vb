Imports System.Windows.Forms

Imports C1.Win.Schedule

''' <summary>
''' Allow change view options of C1Schedule.
''' </summary>
Public Class C1ScheduleOptions
	Private _schedule As C1Schedule

	Public Sub New(schedule As C1Schedule)
		_schedule = schedule
	End Sub

	Public ReadOnly Property Schedule() As C1Schedule
		Get
			Return _schedule
		End Get
	End Property

	Public Property ViewType() As ScheduleViewEnum
		Get
			Return _schedule.ViewType
		End Get
		Set
			_schedule.ViewType = value
		End Set
	End Property

	Public Property EnableGrouping() As Boolean
		Get
			Return Not String.IsNullOrEmpty(_schedule.GroupBy)
		End Get
		Set
			_schedule.GroupBy = If(value, "Category", String.Empty)
		End Set
	End Property

	Public Property Office2003WeekView() As Boolean
		Get
			Return _schedule.WeekViewStyle = WeekViewStyleEnum.Office2003
		End Get
		Set
			_schedule.WeekViewStyle = If(value, WeekViewStyleEnum.Office2003, WeekViewStyleEnum.Office2007)
		End Set
	End Property
End Class
