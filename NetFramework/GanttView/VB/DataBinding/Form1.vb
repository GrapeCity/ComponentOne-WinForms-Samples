Imports System.ComponentModel
Imports C1.Win.C1GanttView

Public Class Form1

    Private Sub LoadData()
        Try
            TasksTableAdapter1.Fill(C1NWindDataSet1.Tasks)
            ResourcesTableAdapter1.Fill(C1NWindDataSet1.Resources)
            PropertiesTableAdapter1.Fill(C1NWindDataSet1.Properties)
            CalendarsTableAdapter1.Fill(C1NWindDataSet1.Calendars)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub SaveData()
        Try
            TasksTableAdapter1.Update(C1NWindDataSet1.Tasks)
            ResourcesTableAdapter1.Update(C1NWindDataSet1.Resources)
            PropertiesTableAdapter1.Update(C1NWindDataSet1.Properties)
            CalendarsTableAdapter1.Update(C1NWindDataSet1.Calendars)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common")
        LoadData()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveData()
    End Sub
End Class
