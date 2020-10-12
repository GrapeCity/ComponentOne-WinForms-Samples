Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Imports C1.Win.C1FlexGrid
Imports C1.Win.C1TrueDBGrid
Imports C1.Win.C1Command
Imports C1.Win.C1Themes
Imports C1.Win.C1Schedule
Imports C1.Win.C1Input
Imports C1.C1Schedule

Public Partial Class Form1
	Inherits Form
	Private _updateCounter As Integer
	Private _scheduleOptions As C1ScheduleOptions
	Private _flexGridOptions As C1FlexGridOptions
	Private _trueGridOptions As C1TrueDBGridOptions

    Public Sub New()
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ComponentOne Samples\Common")
        InitializeComponent()

        _scheduleOptions = New C1ScheduleOptions(Me.csMain)
        _flexGridOptions = New C1FlexGridOptions(Me.c1FlexGrid1)
        _trueGridOptions = New C1TrueDBGridOptions(Me.c1TrueDBGrid1)

        ' 
        AddHandler ccCFGViewNormal.CommandStateQuery, AddressOf C1FlexGridViewCommandStateQuery
        AddHandler ccCFGViewNormal.Click, AddressOf C1FlexGridViewCommandClick
        AddHandler ccCFGViewTree.CommandStateQuery, AddressOf C1FlexGridViewCommandStateQuery
        AddHandler ccCFGViewTree.Click, AddressOf C1FlexGridViewCommandClick
        AddHandler ccCFGViewSubtotals.CommandStateQuery, AddressOf C1FlexGridViewCommandStateQuery
        AddHandler ccCFGViewSubtotals.Click, AddressOf C1FlexGridViewCommandClick

        '
        AddHandler ccCTDBGViewNormal.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewNormal.Click, AddressOf C1TrueDBGridViewCommandClick
        AddHandler ccCTDBGViewForm.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewForm.Click, AddressOf C1TrueDBGridViewCommandClick
        AddHandler ccCTDBGViewGroupBy.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewGroupBy.Click, AddressOf C1TrueDBGridViewCommandClick
        AddHandler ccCTDBGViewHierarchical.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewHierarchical.Click, AddressOf C1TrueDBGridViewCommandClick
        AddHandler ccCTDBGViewInverted.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewInverted.Click, AddressOf C1TrueDBGridViewCommandClick
        AddHandler ccCTDBGViewMultipleLines.CommandStateQuery, AddressOf C1TrueDBGridViewCommandStateQuery
        AddHandler ccCTDBGViewMultipleLines.Click, AddressOf C1TrueDBGridViewCommandClick

        '
        AddHandler ccCSViewDay.CommandStateQuery, AddressOf C1ScheduleViewCommandStateQuery
        AddHandler ccCSViewDay.Click, AddressOf C1ScheduleViewCommandClick
        AddHandler ccCSViewMonth.CommandStateQuery, AddressOf C1ScheduleViewCommandStateQuery
        AddHandler ccCSViewMonth.Click, AddressOf C1ScheduleViewCommandClick
        AddHandler ccCSViewTimeLine.CommandStateQuery, AddressOf C1ScheduleViewCommandStateQuery
        AddHandler ccCSViewTimeLine.Click, AddressOf C1ScheduleViewCommandClick
        AddHandler ccCSViewWeek.CommandStateQuery, AddressOf C1ScheduleViewCommandStateQuery
        AddHandler ccCSViewWeek.Click, AddressOf C1ScheduleViewCommandClick
        AddHandler ccCSViewWorkWeek.CommandStateQuery, AddressOf C1ScheduleViewCommandStateQuery
        AddHandler ccCSViewWorkWeek.Click, AddressOf C1ScheduleViewCommandClick

        '
        AddHandler ccCTDBGShowCaption.CommandStateQuery, Function(s, e) InlineAssignHelper(e.Pressed, _trueGridOptions.ShowCaption)
        AddHandler ccCTDBGShowCaption.Click, Sub(s, e)
                                                 _trueGridOptions.ShowCaption = Not _trueGridOptions.ShowCaption
                                                 UpdateControls()
                                             End Sub

        AddHandler ccCFGShowCursor.CommandStateQuery, Function(s, e) InlineAssignHelper(e.Pressed, _flexGridOptions.ShowCursor)
        AddHandler ccCFGShowCursor.Click, Sub(s, e)
                                              _flexGridOptions.ShowCursor = Not _flexGridOptions.ShowCursor
                                              UpdateControls()
                                          End Sub

        AddHandler ccCSEnableGrouping.CommandStateQuery, Function(s, e) InlineAssignHelper(e.Pressed, _scheduleOptions.EnableGrouping)
        AddHandler ccCSEnableGrouping.Click, Sub(s, e)
                                                 _scheduleOptions.EnableGrouping = Not _scheduleOptions.EnableGrouping
                                                 UpdateControls()
                                             End Sub
        AddHandler ccCSOffice2003WeekView.CommandStateQuery, Function(s, e) InlineAssignHelper(e.Pressed, _scheduleOptions.Office2003WeekView)
        AddHandler ccCSOffice2003WeekView.Click, Sub(s, e)
                                                     _scheduleOptions.Office2003WeekView = Not _scheduleOptions.Office2003WeekView
                                                     UpdateControls()
                                                 End Sub
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common\"
        If File.Exists(path & "c1nwind.mdb") Then
            AppDomain.CurrentDomain.SetData("DataDirectory", path)
        End If

        ' TODO: This line of code loads data into the 'c1NWINDDataSet.Employees' table. You can move, or remove it, as needed.
        Me.employeesTableAdapter.Fill(Me.c1NWINDDataSet.Employees)

        '
        ' initialize C1Schedule
        '
        csMain.ShowReminderForm = False

        Dim now As DateTime = DateTime.Now
        Dim app As Appointment = csMain.DataStorage.AppointmentStorage.Appointments.Add(New DateTime(now.Year, now.Month, now.Day, now.Hour, 0, 0), TimeSpan.FromHours(1))
        app.Subject = "test appointment"
        app.Location = "test location"
        app.Categories.Add(csMain.DataStorage.CategoryStorage.Categories(0))

        app = csMain.DataStorage.AppointmentStorage.Appointments.Add(New DateTime(now.Year, now.Month, now.Day).AddDays(1), TimeSpan.FromHours(24))
        app.Subject = "test event"
        app.AllDayEvent = True
        app.Location = "test location"
        app.Categories.Add(csMain.DataStorage.CategoryStorage.Categories(0))

        '
        ' initialize C1TrueDBGrid
        '
        _trueGridOptions.ShowCaption = True
        _trueGridOptions.ShowFilterBar = True
        _trueGridOptions.ShowGroupByArea = True
        _trueGridOptions.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Normal

        '
        ' initialize C1FlexGrid
        '
        _flexGridOptions.ViewMode = FlexViewModeEnum.Normal
        _flexGridOptions.FrozenColCount = 3

        '
        FillItems(ccmCFGSelectionMode, GetType(C1.Win.C1FlexGrid.SelectionModeEnum), AddressOf SelectionModeCommandClick, AddressOf SelectionModeCommandStateQuery)
        FillItems(ccmCFGFocusRect, GetType(C1.Win.C1FlexGrid.FocusRectEnum), AddressOf FocusRectCommandClick, AddressOf FocusRectCommandStateQuery)
        FillItems(csbSelectionMode, GetType(SelectionModeEnum))
        FillItems(csbFocusRect, GetType(FocusRectEnum))

        '
        UpdateControls()

        '
        c1DockingTab2_SelectedTabChanged(Nothing, EventArgs.Empty)

        ' fill list of themes
        Dim themes As String() = C1ThemeController.GetThemes()
        ccmTheme.CommandLinks.Clear()
        For i As Integer = 0 To themes.Length - 1
            Dim cmd As New C1Command()
            cmd.Text = themes(i)
            cmd.UserData = themes(i)
            AddHandler cmd.CommandStateQuery, AddressOf OnThemeCommandStateQuery
            AddHandler cmd.Click, AddressOf OnThemeClick
            Dim cl As New C1CommandLink(cmd)
            ccmTheme.CommandLinks.Add(cl)
        Next
        ccmTheme.Text = String.Format("Theme: {0}", C1ThemeController.ApplicationTheme)
    End Sub

    ''' <summary>
    ''' Sets the application theme.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OnThemeClick(sender As Object, e As EventArgs)
        Dim c As C1Command = DirectCast(sender, C1Command)
        Dim theme As String = DirectCast(c.UserData, String)

        ' reset the Form.Font first
        Font = New Font("Segoe UI", 8.0F)

        C1ThemeController.ApplicationTheme = theme
        ccmTheme.Text = String.Format("Theme: {0}", theme)
    End Sub

    ''' <summary>
    ''' Sets the 'pressed' state on the menu item corresponding to the current application theme.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub OnThemeCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
        Dim c As C1Command = DirectCast(sender, C1Command)
        e.Pressed = C1ThemeController.ApplicationTheme = DirectCast(c.UserData, String)
    End Sub

	Private Sub C1FlexGridViewCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
		Dim vm As FlexViewModeEnum = CType([Enum].Parse(GetType(FlexViewModeEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), FlexViewModeEnum)
		e.Pressed = _flexGridOptions.ViewMode = vm
	End Sub

	Private Sub C1FlexGridViewCommandClick(sender As Object, e As ClickEventArgs)
		Dim vm As FlexViewModeEnum = CType([Enum].Parse(GetType(FlexViewModeEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), FlexViewModeEnum)
		_flexGridOptions.ViewMode = vm
		UpdateControls()
	End Sub

	Private Sub C1TrueDBGridViewCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
		Dim dv As DataViewEnum = CType([Enum].Parse(GetType(DataViewEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), DataViewEnum)
		e.Pressed = _trueGridOptions.DataView = dv
	End Sub

	Private Sub C1TrueDBGridViewCommandClick(sender As Object, e As ClickEventArgs)
		Dim dv As DataViewEnum = CType([Enum].Parse(GetType(DataViewEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), DataViewEnum)
		_trueGridOptions.DataView = dv
		UpdateControls()
	End Sub

	Private Sub C1ScheduleViewCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
		Dim sv As ScheduleViewEnum = CType([Enum].Parse(GetType(ScheduleViewEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), ScheduleViewEnum)
		e.Pressed = _scheduleOptions.ViewType = sv
	End Sub

	Private Sub C1ScheduleViewCommandClick(sender As Object, e As ClickEventArgs)
		Dim sv As ScheduleViewEnum = CType([Enum].Parse(GetType(ScheduleViewEnum), DirectCast(DirectCast(sender, C1Command).UserData, String)), ScheduleViewEnum)
		_scheduleOptions.ViewType = sv
		UpdateControls()
	End Sub

	''' <summary>
	''' Method called before updating controls like cneFixedColCount, cneFixedRowCount
	''' to suppress events called when value of such controls is changed.
	''' </summary>
	Private Sub BeginUpdate()
		_updateCounter += 1
	End Sub

	''' <summary>
	''' Called after BeginUpdate().
	''' </summary>
	Private Sub EndUpdate()
		_updateCounter -= 1
	End Sub

	''' <summary>
	''' Returns true if execution between BeforeUpdate() and EndUpdate().
	''' </summary>
	Private ReadOnly Property UpdateDisabled() As Boolean
		Get
			Return _updateCounter <> 0
		End Get
	End Property

	Private Sub FillItems(btn As C1SplitButton, enumType As Type)
		Dim values As Array = [Enum].GetValues(enumType)
		Dim names As String() = [Enum].GetNames(enumType)

		btn.Items.Clear()
		For i As Integer = 0 To values.Length - 1
			Dim ddi As New DropDownItem()
			ddi.Text = names(i)
			ddi.Tag = values.GetValue(i)
			btn.Items.Add(ddi)
		Next
	End Sub

	Private Sub SelectionModeCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
		Dim sm As SelectionModeEnum = CType(DirectCast(sender, C1Command).UserData, SelectionModeEnum)
		e.Pressed = _flexGridOptions.SelectionMode = sm
	End Sub

	Private Sub SelectionModeCommandClick(sender As Object, e As ClickEventArgs)
		Dim sm As SelectionModeEnum = CType(DirectCast(sender, C1Command).UserData, SelectionModeEnum)
		_flexGridOptions.SelectionMode = sm
		UpdateControls()
	End Sub

	Private Sub FocusRectCommandStateQuery(sender As Object, e As CommandStateQueryEventArgs)
		Dim fr As FocusRectEnum = CType(DirectCast(sender, C1Command).UserData, FocusRectEnum)
		e.Pressed = _flexGridOptions.FocusRect = fr
	End Sub

	Private Sub FocusRectCommandClick(sender As Object, e As ClickEventArgs)
		Dim fr As FocusRectEnum = CType(DirectCast(sender, C1Command).UserData, FocusRectEnum)
		_flexGridOptions.FocusRect = fr
		UpdateControls()
	End Sub

	Private Sub FillItems(cm As C1CommandMenu, type As Type, commandClick As ClickEventHandler, commandStateQuery As CommandStateQueryEventHandler)
		Dim values As Array = [Enum].GetValues(type)
		Dim names As String() = [Enum].GetNames(type)

		cm.CommandLinks.Clear()
		For i As Integer = 0 To values.Length - 1
			Dim cmd As New C1Command()
			cmd.Text = names(i)
			cmd.UserData = values.GetValue(i)
			AddHandler cmd.CommandStateQuery, commandStateQuery
			AddHandler cmd.Click, commandClick
			Dim cl As New C1CommandLink(cmd)
			cm.CommandLinks.Add(cl)
		Next
	End Sub

	' Initializes controls on c1OutBar1
	Private Sub UpdateControls()
		BeginUpdate()

		' C1FlexGrid options
		' update C1Input controls
		csbSelectionMode.Text = _flexGridOptions.SelectionMode.ToString()
		csbFocusRect.Text = _flexGridOptions.FocusRect.ToString()
		cneFixedColCount.Value = _flexGridOptions.FrozenColCount
		cneFixedColCount.PostValidation.Intervals.Clear()
        cneFixedColCount.PostValidation.Intervals.Add(New ValueInterval(0, c1FlexGrid1.Cols.Count, True, True))
		cneFixedRowCount.Value = _flexGridOptions.FrozenRowCount
		cneFixedRowCount.PostValidation.Intervals.Clear()
        cneFixedRowCount.PostValidation.Intervals.Add(New ValueInterval(0, c1FlexGrid1.Rows.Count, True, True))
		cneCFGFrozenColCount.Value = _flexGridOptions.FrozenColCount
		cneCFGFrozenColCount.PostValidation.Intervals.Clear()
        cneCFGFrozenColCount.PostValidation.Intervals.Add(New ValueInterval(0, c1FlexGrid1.Cols.Count, True, True))
		cneCFGFrozenRowCount.Value = _flexGridOptions.FrozenRowCount
		cneCFGFrozenRowCount.PostValidation.Intervals.Clear()
        cneCFGFrozenRowCount.PostValidation.Intervals.Add(New ValueInterval(0, c1FlexGrid1.Rows.Count, True, True))
		ccbShowCursor.Checked = _flexGridOptions.ShowCursor

		' C1TrueDBGrid options
		ccbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption
		ccbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar

		' C1Schedule options
		' update C1Input controls
		ccbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping
		ccbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView

		EndUpdate()
	End Sub

	Private Sub c1DockingTab2_SelectedTabChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		BeginUpdate()
		If c1DockingTab2.SelectedTab Is c1DockingTabPage3 Then
			c1OutBar1.SelectedPage = copC1FlexGrid
		ElseIf c1DockingTab2.SelectedTab Is c1DockingTabPage4 Then
			c1OutBar1.SelectedPage = copC1TrueDBGrid
		ElseIf c1DockingTab2.SelectedTab Is c1DockingTabPage5 Then
			c1OutBar1.SelectedPage = copC1Schedule
			c1NavBar1.SelectedButtonIndex = 1
		End If
		EndUpdate()
	End Sub

	Private Sub ccFileExit_Click(sender As Object, e As ClickEventArgs)
		Close()
	End Sub

	Private Sub cneFixedColCount_ValueChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_flexGridOptions.FrozenColCount = CInt(Math.Truncate(CDec(DirectCast(sender, C1NumericEdit).Value)))
		UpdateControls()
	End Sub

	Private Sub cneFixedRowCount_ValueChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_flexGridOptions.FrozenRowCount = CInt(Math.Truncate(CDec(DirectCast(sender, C1NumericEdit).Value)))
		UpdateControls()
	End Sub

	Private Sub csbSelectionMode_DropDownItemClicked(sender As Object, e As DropDownItemClickedEventArgs)
		If UpdateDisabled Then
			Return
		End If
		DirectCast(sender, C1SplitButton).Text = e.ClickedItem.Text
		_flexGridOptions.SelectionMode = CType(e.ClickedItem.Tag, SelectionModeEnum)
		UpdateControls()
	End Sub

	Private Sub csbFocusRect_DropDownItemClicked(sender As Object, e As DropDownItemClickedEventArgs)
		If UpdateDisabled Then
			Return
		End If
		DirectCast(sender, C1SplitButton).Text = e.ClickedItem.Text
		_flexGridOptions.FocusRect = CType(e.ClickedItem.Tag, FocusRectEnum)
		UpdateControls()
	End Sub

	Private Sub ccbShowCursor_CheckedChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_flexGridOptions.ShowCursor = ccbShowCursor.Checked
		UpdateControls()
	End Sub

	Private Sub ccbCTDBGShowCaption_CheckedChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_trueGridOptions.ShowCaption = ccbCTDBGShowCaption.Checked
		UpdateControls()
	End Sub

	Private Sub ccbCTDBGShowFilterBar_CheckedChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_trueGridOptions.ShowFilterBar = ccbCTDBGShowFilterBar.Checked
		UpdateControls()
	End Sub

	Private Sub ccbCSEnableGrouping_CheckedChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_scheduleOptions.EnableGrouping = ccbCSEnableGrouping.Checked
		UpdateControls()
	End Sub

	Private Sub ccbCSOffice2003WeekView_CheckedChanged(sender As Object, e As EventArgs)
		If UpdateDisabled Then
			Return
		End If
		_scheduleOptions.Office2003WeekView = ccbCSOffice2003WeekView.Checked
		UpdateControls()
	End Sub
	Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, value As T) As T
		target = value
		Return value
	End Function
End Class
