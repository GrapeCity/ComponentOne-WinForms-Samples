Imports C1.Win.C1GanttView

Public Class Form1

    Private Sub btnLoadXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadXml.Click

        Dim dlg As New OpenFileDialog()
        dlg.DefaultExt = ".xml"
        dlg.Filter = "XML files|*.xml|All files|*.*"
        dlg.Title = "Load Gantt View From Xml File"
        If dlg.ShowDialog() = DialogResult.OK Then
            Try
                gv.LoadXml(dlg.FileName)
            Catch
                MessageBox.Show("Bad C1GanttView XML.", dlg.Title)
            End Try
        End If
        dlg.Dispose()

    End Sub

    Private Sub btnSaveXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveXml.Click

        Dim dlg As New SaveFileDialog()
        dlg.DefaultExt = ".xml"
        dlg.FileName = "gantt"
        dlg.Filter = "XML files|*.xml|All files|*.*"
        dlg.Title = "Save Gantt View As Xml File"
        If dlg.ShowDialog() = DialogResult.OK Then
            gv.SaveXml(dlg.FileName)
        End If
        dlg.Dispose()

    End Sub

    Private Sub btnAddPredecessor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddPredecessor.Click

        ' find task1 and task2
        Dim task1 As Task = gv.Tasks.Search("Task 1")
        Dim task2 As Task = gv.Tasks.Search("Task 2")

        If task1 IsNot Nothing AndAlso task2 IsNot Nothing AndAlso task2.Predecessors.Count = 0 Then

            ' switch to auto-scheduling mode
            task2.Mode = TaskMode.Automatic

            Dim p As Predecessor = New Predecessor()
            p.PredecessorTask = task1
            task2.Predecessors.Add(p)

            ' restore the manual mode
            task2.Mode = TaskMode.Manual

        End If

    End Sub

    Private Sub btnAddResource_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddResource.Click

        ' add the new Resource object
        Dim r As Resource = Nothing
        If gv.Resources.Count = 0 Then
            r = New Resource()
            r.Name = "Resource 1"
            r.Cost = 300
            gv.Resources.Add(r)
        End If

        ' find task1
        Dim task1 As Task = gv.Tasks.Search("Task 1")
        If task1 IsNot Nothing AndAlso r IsNot Nothing AndAlso task1.ResourceRefs.Count = 0 Then

            ' add a resource reference to the task
            Dim rRef As ResourceRef = New ResourceRef()
            rRef.Resource = r
            rRef.Amount = 0.5
            task1.ResourceRefs.Add(rRef)

        End If

    End Sub

    Private Sub btnAddTopLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTopLevel.Click

        Dim st As ScaleTier = gv.Timescale.TopTier
        st.Units = TimescaleUnits.ThirdsOfMonths
        st.Format = "sd"
        st.Visible = True
        btnRemoveTopLevel.Enabled = True
        btnAddTopLevel.Enabled = False

    End Sub

    Private Sub btnRemoveTopLevel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTopLevel.Click

        gv.Timescale.TopTier.Visible = False
        btnAddTopLevel.Enabled = True
        btnRemoveTopLevel.Enabled = False

    End Sub

    Private Sub btnInsertTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertTask.Click

        Dim tasks As TaskCollection = gv.Tasks
        Dim index As Int32 = gv.Tasks.IndexOf("Task 2")
        If index >= 0 Then

            ' create a new task
            Dim t As New Task()
            tasks.Insert(index, t)
            t.Mode = TaskMode.Automatic
            t.Name = "New Task"
            t.Start = New DateTime(2012, 6, 25)
            t.Duration = 3

            btnMove.Enabled = True
            btnDelete.Enabled = True
            btnInsertTask.Enabled = False

        End If

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click

        Dim tasks As TaskCollection = gv.Tasks
        Dim index As Int32 = tasks.IndexOf("New Task")
        If index >= 0 Then

            Dim t As Task = tasks(index)
            tasks.RemoveAt(index)
            tasks.Insert(0, t)

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim tasks As TaskCollection = gv.Tasks

        ' find NewTask
        Dim index As Int32 = gv.Tasks.IndexOf("New Task")
        If index >= 0 Then

            ' delete and dispose the new task
            Dim t As Task = tasks(index)
            tasks.RemoveAt(index)
            t.Dispose()

            btnInsertTask.Enabled = True
            btnMove.Enabled = False
            btnDelete.Enabled = False

        End If

    End Sub

    Private Sub chkShowDuration_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowDuration.CheckedChanged

        Dim durationCol As TaskPropertyColumn = gv.Columns.Search(TaskProperty.Duration)
        Dim unitsCol As TaskPropertyColumn = gv.Columns.Search(TaskProperty.DurationUnits)
        If durationCol IsNot Nothing AndAlso unitsCol IsNot Nothing Then

            Dim v As Boolean = chkShowDuration.Checked
            durationCol.Visible = v
            unitsCol.Visible = v

        End If

    End Sub

    Private Sub btnChangeCommonStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeCommonStyle.Click

        Dim bs As BarStyle = gv.GetPredefinedBarStyle(BarType.ManualTask)
        bs.BarColor = Color.LightCoral
        gv.BarStyles.Add(bs)

    End Sub

    Private Sub btnChangeTaskStyle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeTaskStyle.Click

        Dim task3 As Task = gv.Tasks.Search("Task 3")
        If task3 IsNot Nothing Then

            Dim bs As BarStyle = gv.GetPredefinedBarStyle(BarType.ManualTask)
            bs.BarColor = Color.Green
            bs.BarShape = BarShape.MiddleBar
            bs.StartShape = 19
            bs.EndShape = 19
            task3.BarStyles.Add(bs)

        End If

    End Sub
End Class
