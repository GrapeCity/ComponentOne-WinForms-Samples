Imports C1.Win.C1Schedule
Imports C1.C1Schedule
Imports C1.Win.C1Schedule.UI

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayToolStripMenuItem.Click
        ' Go to today date.
        Me.C1Schedule1.GoToDate(DateTime.Today)
    End Sub

    Private Sub MonthViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthViewToolStripMenuItem.Click
        ' Switch to the MonthView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.MonthView
    End Sub

    Private Sub TimeLineViewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLineViewMenuItem.Click
        ' Switch to the TimeLineView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.TimeLineView
    End Sub

    Private Sub WeekViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeekViewToolStripMenuItem.Click
        ' Switch to the WeekView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.WeekView
    End Sub

    Private Sub WorkWeekViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkWeekViewToolStripMenuItem.Click
        ' Switch to the WorkWeekView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView
    End Sub

    Private Sub DayViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayViewToolStripMenuItem.Click
        ' Switch to the DayView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.DayView
    End Sub

    ' On form closing update data adapters in order to save data to the database.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.EmployeesTableAdapter1.Update(C1NWindDataSet1.Appointees)
        Me.AppointmentsTableAdapter1.Update(C1NWindDataSet1.Appointments)
    End Sub

    ' On form loading fill data adapters in order to load data from the database.
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.EmployeesTableAdapter1.Fill(C1NWindDataSet1.Appointees)
        Me.AppointmentsTableAdapter1.Fill(C1NWindDataSet1.Appointments)
        ' set correct MenuCaption for contacts
        For Each cnt As Contact In C1Schedule1.DataStorage.ContactStorage.Contacts
            Dim row As C1ScheduleDemo.C1NWindDataSet.AppointeesRow = Me.C1NWindDataSet1.Appointees.FindByEmployeeID(cnt.Key(0))
            If row IsNot Nothing Then
                cnt.MenuCaption = row("FirstName").ToString() + " " + row("LastName").ToString()
            End If
        Next cnt
    End Sub

    Private Sub cmbVisualStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbVisualStyle.SelectedIndexChanged
        ' change visual style for both C1Calendar and C1Schedule controls
        Dim style As VisualStyle = cmbVisualStyle.SelectedItem
        C1Calendar1.VisualStyle = style
        C1Calendar1.Refresh()
        C1Schedule1.VisualStyle = style

    End Sub

    Public Sub New()

        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' fill available visual styles combo
        For Each style As VisualStyle In [Enum].GetValues(GetType(VisualStyle))
            If style <> VisualStyle.Custom Then
                cmbVisualStyle.Items.Add(style)
            End If
        Next style
        cmbVisualStyle.SelectedItem = VisualStyle.Office2010Blue

        ' fill combo for selecting group page size
        cmbGroupPageSize.Items.Add(1)
        cmbGroupPageSize.Items.Add(2)
        cmbGroupPageSize.Items.Add(3)
        cmbGroupPageSize.Items.Add(4)
        cmbGroupPageSize.Items.Add(5)
        cmbGroupPageSize.SelectedIndex = 1
    End Sub

    Private Sub NoneToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneToolStripMenuItem1.Click
        ' remove C1Schedule grouping
        C1Schedule1.GroupBy = ""
        ContactToolStripMenuItem.Checked = False
        CategoryToolStripMenuItem.Checked = False
        ResourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub ContactToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactToolStripMenuItem.Click
        ' group C1Schedule by appointment contacts
        C1Schedule1.GroupBy = "Contact"
        NoneToolStripMenuItem1.Checked = False
        CategoryToolStripMenuItem.Checked = False
        ResourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoryToolStripMenuItem.Click
        ' group C1Schedule by appointment categories
        C1Schedule1.GroupBy = "Category"
        NoneToolStripMenuItem1.Checked = False
        ContactToolStripMenuItem.Checked = False
        ResourceToolStripMenuItem.Checked = False
    End Sub

    Private Sub ResourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResourceToolStripMenuItem.Click
        ' group C1Schedule by appointment resources
        C1Schedule1.GroupBy = "Resource"
        NoneToolStripMenuItem1.Checked = False
        ContactToolStripMenuItem.Checked = False
        CategoryToolStripMenuItem.Checked = False
    End Sub

    Private Sub cmbGroupPageSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroupPageSize.SelectedIndexChanged
        ' update group page size
        C1Schedule1.GroupPageSize = cmbGroupPageSize.SelectedItem
    End Sub

    Private Sub ShowEmptyGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowEmptyGroupToolStripMenuItem.Click
        C1Schedule1.ShowEmptyGroupItem = (ShowEmptyGroupToolStripMenuItem.CheckState = CheckState.Checked)

    End Sub
End Class
