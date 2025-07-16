Imports System.Threading
Imports C1.Win.Gauge

Public Class PageMultithreaded

    Private _workingThread As Thread
    Private _minThread As Thread
    Private _maxThread As Thread
    Private _workingThreadRunning As Boolean
    Private _minThreadRunning As Boolean
    Private _maxThreadRunning As Boolean

    Private Const _startText As String = "Start Thread {0}"
    Private Const _stopText As String = "Stop Thread {0}"

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        _workingThreadRunning = False
        _minThreadRunning = False
        _maxThreadRunning = False
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        Const text As String = "1 (value)"
        If Not _workingThreadRunning Then
            button1.Text = String.Format(_stopText, text)
            _workingThread = New Thread(New ThreadStart(AddressOf DoWorkThreadFunc))
            _workingThreadRunning = True
            _workingThread.Start()
        Else
            button1.Text = String.Format(_startText, text)
            _workingThreadRunning = False
        End If
    End Sub

    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Const text As String = "2 (min)"
        If Not _minThreadRunning Then
            button2.Text = String.Format(_stopText, text)
            _minThread = New Thread(New ThreadStart(AddressOf UpdateMinThreadFunc))
            _minThreadRunning = True
            _minThread.Start()
        Else
            button2.Text = String.Format(_startText, text)
            _minThreadRunning = False
        End If
    End Sub

    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Const text As String = "3 (max)"
        If Not _maxThreadRunning Then
            button3.Text = String.Format(_stopText, text)
            _maxThread = New Thread(New ThreadStart(AddressOf UpdateMaxThreadFunc))
            _maxThreadRunning = True
            _maxThread.Start()
        Else
            button3.Text = String.Format(_startText, text)
            _maxThreadRunning = False
        End If
    End Sub

    Private Sub DoWorkThreadFunc()
        Dim rnd As Random = New Random()
        Dim pointer As C1GaugePointer = c1LinearGauge1.Pointer
        While _workingThreadRunning
            pointer.Value = rnd.Next(0, 101)
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub UpdateMinThreadFunc()
        Dim rnd As Random = New Random()
        Dim pointer As C1GaugePointer = c1LinearGauge1.MorePointers("min")
        While _minThreadRunning
            pointer.Value = rnd.Next(0, 50)
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub UpdateMaxThreadFunc()
        Dim rnd As Random = New Random()
        Dim pointer As C1GaugePointer = c1LinearGauge1.MorePointers("max")
        While _maxThreadRunning
            pointer.Value = rnd.Next(51, 101)
            Thread.Sleep(1000)
        End While
    End Sub

End Class
