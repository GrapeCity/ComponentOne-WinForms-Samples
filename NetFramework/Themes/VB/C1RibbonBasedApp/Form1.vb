Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Imports C1.Win.C1Themes
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Schedule
Imports C1.Win.C1FlexGrid
Imports C1.Win.C1Input
Imports C1.Win.C1Command
Imports C1.Win.C1TrueDBGrid
Imports C1.C1Schedule

Public Partial Class Form1
	Inherits C1RibbonForm
	Private _updateCounter As Integer
	Private _scheduleOptions As C1ScheduleOptions
	Private _flexGridOptions As C1FlexGridOptions
	Private _trueGridOptions As C1TrueDBGridOptions

	Public Sub New()
		InitializeComponent()
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ComponentOne Samples\Common")
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

	Private Sub UpdateMinimizeMaximize()
		If crMain.Minimized Then
			minimizeRibbonButton.SmallImageKey = "MaximizeRibbon.png"
			minimizeRibbonButton.ToolTip = "Maximize the Ribbon"
		Else
			minimizeRibbonButton.SmallImageKey = "MinimizeRibbon.png"
			minimizeRibbonButton.ToolTip = "Minimize the Ribbon"
		End If
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

	Private Sub FillItems(rcb As RibbonComboBox, type As Type)
		rcb.Items.Clear()
		Dim values As Array = [Enum].GetValues(type)
		Dim names As String() = [Enum].GetNames(type)

		For i As Integer = 0 To values.Length - 1
			Dim rb As New RibbonButton(names(i))
			rb.Tag = values.GetValue(i)
			rcb.Items.Add(rb)
		Next
	End Sub

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

	' Select item in RibbonGallery by its tag
	Private Sub SelectRibbonGalleryItem(rg As RibbonGallery, v As Object)
		For i As Integer = 0 To rg.Items.Count - 1
			If DirectCast(rg.Items(i).Tag, String) = v.ToString() Then
				rg.SelectedIndex = i
				Return
			End If
		Next
	End Sub

	Private Sub SelectComboBoxItem(rcb As RibbonComboBox, v As Object)
		For i As Integer = 0 To rcb.Items.Count - 1
			If rcb.Items(i).Tag.Equals(v) Then
				rcb.SelectedIndex = i
				Return
			End If
		Next
	End Sub

	Private Sub ShowRibbonContextualTabGroup(rctg As RibbonContextualTabGroup)
		For Each tg As RibbonContextualTabGroup In crMain.ContextualTabGroups
			If tg IsNot rctgC1FlexGrid AndAlso tg IsNot rctgC1Schedule AndAlso tg IsNot rctgC1TrueDBGrid Then
				Continue For
			End If
			If tg IsNot rctg Then
				tg.Visible = False
			End If
		Next
		rctg.Visible = True
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
		ccbShowCursor.Checked = _flexGridOptions.ShowCursor
        ' update ribbon controls
        SelectRibbonGalleryItem(rglrCFGView, _flexGridOptions.ViewMode)
        SelectRibbonGalleryItem(rglrCSView, _scheduleOptions.ViewType)
        rnbCFGFixedColCount.Value = _flexGridOptions.FrozenColCount
		rnbCFGFixedRowCount.Value = _flexGridOptions.FrozenRowCount
		SelectComboBoxItem(rcbCFGSelectionMode, _flexGridOptions.SelectionMode)
		SelectComboBoxItem(rcbCFGFocusRect, _flexGridOptions.FocusRect)
		rcbCFGShowCursor.Checked = _flexGridOptions.ShowCursor

		' C1TrueDBGrid options
		ccbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption
		ccbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar
		' update ribbon controls
		SelectRibbonGalleryItem(rglrCTDBGView, _trueGridOptions.DataView)
		rcbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption
		rcbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar

		' C1Schedule options
		' update C1Input controls
		ccbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping
		ccbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView
		' update C1Ribbon controls
		rcbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping
		rcbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView

		EndUpdate()
	End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        rnbCFGFixedColCount.Minimum = 0
        rnbCFGFixedColCount.Maximum = c1FlexGrid1.Cols.Count
        rnbCFGFixedRowCount.Minimum = 0
        rnbCFGFixedRowCount.Maximum = c1FlexGrid1.Rows.Count

        ' fill items of C1SplitButton used to select C1FlexGrid view mode
        FillItems(csbSelectionMode, GetType(SelectionModeEnum))
        FillItems(csbFocusRect, GetType(FocusRectEnum))
        FillItems(rcbCFGSelectionMode, GetType(C1.Win.C1FlexGrid.SelectionModeEnum))
        FillItems(rcbCFGFocusRect, GetType(C1.Win.C1FlexGrid.FocusRectEnum))

        '
        UpdateControls()

        '
        UpdateMinimizeMaximize()

        '
        c1DockingTab2_SelectedTabChanged(Nothing, EventArgs.Empty)

        ' fill list of themes
        Dim themes As String() = C1ThemeController.GetThemes()
        For Each theme As String In themes
            Dim rtb As New RibbonToggleButton()
            rtb.Text = theme
            rtb.Tag = theme
            AddHandler rtb.Click, AddressOf OnThemeClick
            rtb.Pressed = C1ThemeController.ApplicationTheme = theme
            themeMenu.Items.Add(rtb)
        Next
        themeMenu.Text = String.Format("Theme: {0}", C1ThemeController.ApplicationTheme)
    End Sub

	Private Sub OnThemeClick(sender As Object, e As EventArgs)
		Dim rtb As RibbonToggleButton = DirectCast(sender, RibbonToggleButton)
		Dim theme As String = DirectCast(rtb.Tag, String)
		For Each rb As RibbonToggleButton In themeMenu.Items
			rb.Pressed = False
		Next
		rtb.Pressed = True
		themeMenu.Text = String.Format("Theme: {0}", theme)
		C1ThemeController.ApplicationTheme = theme
	End Sub

    Private Sub cneFixedColCount_ValueChanged(sender As Object, e As EventArgs) Handles cneFixedColCount.ValueChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.FrozenColCount = CInt(Math.Truncate(CDec(cneFixedColCount.Value)))
        UpdateControls()
    End Sub

    Private Sub cneFixedRowCount_ValueChanged(sender As Object, e As EventArgs) Handles cneFixedRowCount.ValueChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.FrozenRowCount = CInt(Math.Truncate(CDec(cneFixedRowCount.Value)))
        UpdateControls()
    End Sub

    Private Sub csbSelectionMode_DropDownItemClicked(sender As Object, e As DropDownItemClickedEventArgs) Handles csbSelectionMode.DropDownItemClicked
        If UpdateDisabled Then
            Return
        End If
        DirectCast(sender, C1SplitButton).Text = e.ClickedItem.Text
        _flexGridOptions.SelectionMode = CType(e.ClickedItem.Tag, SelectionModeEnum)
        UpdateControls()
    End Sub

    Private Sub csbFocusRect_DropDownItemClicked(sender As Object, e As DropDownItemClickedEventArgs) Handles csbFocusRect.DropDownItemClicked
        If UpdateDisabled Then
            Return
        End If
        DirectCast(sender, C1SplitButton).Text = e.ClickedItem.Text
        _flexGridOptions.FocusRect = CType(e.ClickedItem.Tag, FocusRectEnum)
        UpdateControls()
    End Sub

    Private Sub ccbShowCursor_CheckedChanged(sender As Object, e As EventArgs) Handles ccbShowCursor.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.ShowCursor = ccbShowCursor.Checked
        UpdateControls()
    End Sub

    Private Sub ccbCTDBGShowCaption_CheckedChanged(sender As Object, e As EventArgs) Handles ccbCTDBGShowCaption.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _trueGridOptions.ShowCaption = ccbCTDBGShowCaption.Checked
        UpdateControls()
    End Sub

    Private Sub ccbCTDBGShowFilterBar_CheckedChanged(sender As Object, e As EventArgs) Handles ccbCTDBGShowFilterBar.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _trueGridOptions.ShowFilterBar = ccbCTDBGShowFilterBar.Checked
        UpdateControls()
    End Sub

    Private Sub ccbCSEnableGrouping_CheckedChanged(sender As Object, e As EventArgs) Handles ccbCSEnableGrouping.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _scheduleOptions.EnableGrouping = ccbCSEnableGrouping.Checked
        UpdateControls()
    End Sub

    Private Sub ccbCSOffice2003WeekView_CheckedChanged(sender As Object, e As EventArgs) Handles ccbCSOffice2003WeekView.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _scheduleOptions.Office2003WeekView = ccbCSOffice2003WeekView.Checked
        UpdateControls()
    End Sub

    Private Sub rglrCFGView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rglrCFGView.SelectedIndexChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.ViewMode = CType([Enum].Parse(GetType(FlexViewModeEnum), DirectCast(rglrCFGView.SelectedItem.Tag, String)), FlexViewModeEnum)
        UpdateControls()
    End Sub

    Private Sub rnbCFGFixedColCount_ValueChanged(sender As Object, e As EventArgs) Handles rnbCFGFixedColCount.ValueChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.FrozenColCount = CInt(Math.Truncate(rnbCFGFixedColCount.Value))
        UpdateControls()
    End Sub

    Private Sub rnbCFGFixedRowCount_ValueChanged(sender As Object, e As EventArgs) Handles rnbCFGFixedRowCount.ValueChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.FrozenRowCount = CInt(Math.Truncate(rnbCFGFixedRowCount.Value))
        UpdateControls()
    End Sub

    Private Sub rcbCFGSelectionMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbCFGSelectionMode.SelectedIndexChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.SelectionMode = CType(rcbCFGSelectionMode.SelectedItem.Tag, SelectionModeEnum)
        UpdateControls()
    End Sub

    Private Sub rcbCFGFocusRect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbCFGFocusRect.SelectedIndexChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.FocusRect = CType(rcbCFGFocusRect.SelectedItem.Tag, FocusRectEnum)
        UpdateControls()
    End Sub

    Private Sub rcbCFGShowCursor_CheckedChanged(sender As Object, e As EventArgs) Handles rcbCFGShowCursor.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _flexGridOptions.ShowCursor = rcbCFGShowCursor.Checked
        UpdateControls()
    End Sub

    Private Sub rglrCTDBGView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rglrCTDBGView.SelectedIndexChanged
        If UpdateDisabled Then
            Return
        End If
        _trueGridOptions.DataView = CType([Enum].Parse(GetType(DataViewEnum), DirectCast(rglrCTDBGView.SelectedItem.Tag, String)), DataViewEnum)
        UpdateControls()
    End Sub

    Private Sub rcbCTDBGShowCaption_CheckedChanged(sender As Object, e As EventArgs) Handles rcbCTDBGShowCaption.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _trueGridOptions.ShowCaption = rcbCTDBGShowCaption.Checked
        UpdateControls()
    End Sub

    Private Sub rcbCTDBGShowFilterBar_CheckedChanged(sender As Object, e As EventArgs) Handles rcbCTDBGShowFilterBar.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _trueGridOptions.ShowFilterBar = rcbCTDBGShowFilterBar.Checked
        UpdateControls()
    End Sub

    Private Sub rglrCSView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rglrCSView.SelectedIndexChanged
        If UpdateDisabled Then
            Return
        End If
        _scheduleOptions.ViewType = CType([Enum].Parse(GetType(ScheduleViewEnum), DirectCast(rglrCSView.SelectedItem.Tag, String)), ScheduleViewEnum)
        UpdateControls()
    End Sub

    Private Sub rcbCSEnableGrouping_CheckedChanged(sender As Object, e As EventArgs) Handles rcbCSEnableGrouping.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _scheduleOptions.EnableGrouping = rcbCSEnableGrouping.Checked
        UpdateControls()
    End Sub

    Private Sub rcbCSOffice2003WeekView_CheckedChanged(sender As Object, e As EventArgs) Handles rcbCSOffice2003WeekView.CheckedChanged
        If UpdateDisabled Then
            Return
        End If
        _scheduleOptions.Office2003WeekView = rcbCSOffice2003WeekView.Checked
        UpdateControls()
    End Sub

    Private Sub c1DockingTab2_SelectedTabChanged(sender As Object, e As EventArgs) Handles c1DockingTab2.SelectedTabChanged
        If UpdateDisabled Then
            Return
        End If
        BeginUpdate()
        If c1DockingTab2.SelectedTab Is c1DockingTabPage3 Then
            c1OutBar1.SelectedPage = copC1FlexGrid
            ShowRibbonContextualTabGroup(rctgC1FlexGrid)
            crMain.SelectedTab = rtC1FlexGrid
        ElseIf c1DockingTab2.SelectedTab Is c1DockingTabPage4 Then
            c1OutBar1.SelectedPage = copC1TrueDBGrid
            ShowRibbonContextualTabGroup(rctgC1TrueDBGrid)
            crMain.SelectedTab = rtC1TrueDBGrid
        ElseIf c1DockingTab2.SelectedTab Is c1DockingTabPage5 Then
            c1OutBar1.SelectedPage = copC1Schedule
            ShowRibbonContextualTabGroup(rctgC1Schedule)
            crMain.SelectedTab = rtC1Schedule
            c1NavBar1.SelectedButtonIndex = 1
        End If
        EndUpdate()
    End Sub

    Private Sub c1OutBar1_SelectedPageChanged(sender As Object, e As EventArgs) Handles c1OutBar1.SelectedPageChanged
        If UpdateDisabled Then
            Return
        End If
        BeginUpdate()
        EndUpdate()
    End Sub

    Private Sub minimizeRibbonButton_Click(sender As Object, e As EventArgs) Handles minimizeRibbonButton.Click
        crMain.Minimized = Not crMain.Minimized
        UpdateMinimizeMaximize()
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub
End Class
