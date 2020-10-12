Namespace CustomFilters
	Partial Public Class DateFilterEditor
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me._chkCalendar = New CheckBox()
			Me._calendar = New MonthCalendar()
			Me._chkYesterday = New CheckBox()
			Me._chkEarlierThisWeek = New CheckBox()
			Me._chkLastWeek = New CheckBox()
			Me._chkLongAgo = New CheckBox()
			Me.SuspendLayout()
			' 
			' _chkCalendar
			' 
			Me._chkCalendar.AutoSize = True
			Me._chkCalendar.Location = New Point(3, 0)
			Me._chkCalendar.Margin = New Padding(3, 0, 3, 0)
			Me._chkCalendar.Name = "_chkCalendar"
			Me._chkCalendar.Size = New Size(175, 21)
			Me._chkCalendar.TabIndex = 0
			Me._chkCalendar.Text = "Filter by a specific date"
			Me._chkCalendar.UseVisualStyleBackColor = True
'			Me._chkCalendar.CheckedChanged += New System.EventHandler(Me._chkCalendar_CheckedChanged)
			' 
			' _calendar
			' 
			Me._calendar.Location = New Point(22, 25)
			Me._calendar.Margin = New Padding(9, 4, 9, 4)
			Me._calendar.MaxSelectionCount = 30
			Me._calendar.Name = "_calendar"
			Me._calendar.ShowToday = False
			Me._calendar.TabIndex = 1
			Me._calendar.TitleBackColor = SystemColors.ControlDark
'			Me._calendar.DateSelected += New System.Windows.Forms.DateRangeEventHandler(Me._calendar_DateSelected)
			' 
			' _chkYesterday
			' 
			Me._chkYesterday.AutoSize = True
			Me._chkYesterday.Location = New Point(3, 215)
			Me._chkYesterday.Margin = New Padding(3, 0, 3, 0)
			Me._chkYesterday.Name = "_chkYesterday"
			Me._chkYesterday.Size = New Size(94, 21)
			Me._chkYesterday.TabIndex = 0
			Me._chkYesterday.Text = "Yesterday"
			Me._chkYesterday.UseVisualStyleBackColor = True
			' 
			' _chkEarlierThisWeek
			' 
			Me._chkEarlierThisWeek.AutoSize = True
			Me._chkEarlierThisWeek.Location = New Point(3, 257)
			Me._chkEarlierThisWeek.Margin = New Padding(3, 0, 3, 0)
			Me._chkEarlierThisWeek.Name = "_chkEarlierThisWeek"
			Me._chkEarlierThisWeek.Size = New Size(129, 21)
			Me._chkEarlierThisWeek.TabIndex = 0
			Me._chkEarlierThisWeek.Text = "Earlier this year"
			Me._chkEarlierThisWeek.UseVisualStyleBackColor = True
			' 
			' _chkLastWeek
			' 
			Me._chkLastWeek.AutoSize = True
			Me._chkLastWeek.Location = New Point(3, 236)
			Me._chkLastWeek.Margin = New Padding(3, 0, 3, 0)
			Me._chkLastWeek.Name = "_chkLastWeek"
			Me._chkLastWeek.Size = New Size(93, 21)
			Me._chkLastWeek.TabIndex = 0
			Me._chkLastWeek.Text = "Last week"
			Me._chkLastWeek.UseVisualStyleBackColor = True
			' 
			' _chkLongAgo
			' 
			Me._chkLongAgo.AutoSize = True
			Me._chkLongAgo.Location = New Point(3, 278)
			Me._chkLongAgo.Margin = New Padding(3, 0, 3, 0)
			Me._chkLongAgo.Name = "_chkLongAgo"
			Me._chkLongAgo.Size = New Size(128, 21)
			Me._chkLongAgo.TabIndex = 0
			Me._chkLongAgo.Text = "A long time ago"
			Me._chkLongAgo.UseVisualStyleBackColor = True
			' 
			' DateFilterEditor
			' 
			Me.AutoScaleDimensions = New SizeF(8F, 16F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.AutoSize = True
			Me.BackColor = Color.Transparent
			Me.Controls.Add(Me._chkCalendar)
			Me.Controls.Add(Me._calendar)
			Me.Controls.Add(Me._chkYesterday)
			Me.Controls.Add(Me._chkEarlierThisWeek)
			Me.Controls.Add(Me._chkLastWeek)
			Me.Controls.Add(Me._chkLongAgo)
			Me.Margin = New Padding(4)
			Me.Name = "DateFilterEditor"
			Me.Size = New Size(278, 305)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents _chkCalendar As CheckBox
		Private WithEvents _calendar As MonthCalendar
		Private _chkYesterday As CheckBox
		Private _chkLastWeek As CheckBox
		Private _chkEarlierThisWeek As CheckBox
		Private _chkLongAgo As CheckBox
	End Class
End Namespace
