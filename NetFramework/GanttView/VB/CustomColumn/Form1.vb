Imports System.ComponentModel
Imports C1.Win.GanttView

Public Class Form1

    Private _updating As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddHandler gv.Tasks.ListChanged, AddressOf TasksResources_ListChanged
        AddHandler gv.Resources.ListChanged, AddressOf TasksResources_ListChanged
        UpdateCost()

    End Sub

    Private Sub TasksResources_ListChanged(ByVal sender As System.Object, ByVal e As ListChangedEventArgs)

        UpdateCost()

    End Sub

    Private Sub UpdateCost()

        If Not _updating Then
            _updating = True
            For Each t As Task In gv.Tasks
                If t.Initialized Then
                    Dim total As Decimal = 0
                    Dim duration As Double = t.GetDurationInDays()
                    If Double.IsNaN(duration) Then duration = 0
                    For Each rr As ResourceRef In t.ResourceRefs
                        Dim r As Resource = rr.Resource
                        If r IsNot Nothing Then
                            total += Convert.ToDecimal(rr.Amount * duration) * r.Cost
                        End If
                    Next rr
                    t.SetFieldValue("ActualCost", total)
                End If
            Next t
            _updating = False
        End If

    End Sub

End Class
