Imports System.IO
Imports System.Windows.Threading
Imports C1.C1Report


Class MainWindow
    Dim WithEvents timer As DispatcherTimer
    Dim c1Report As C1Report

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        '
        timer = New DispatcherTimer()
        timer.Interval = New TimeSpan(0, 0, 0, 0, 500)
        c1Report = New C1Report()

        ' fill _rbFile with initial list of the files
        ' added all files in the ..\..\Reports directory
        Dim files As String() = Directory.GetFiles("..\..\Reports", "*.xml")
        If Not files Is Nothing Then
            For Each file As String In files
                Try
                    Dim reports As String() = C1Report.GetReportList(file)
                    If (Not reports Is Nothing And reports.Length > 0) Then
                        rbFile.Items.Add(file)
                    End If
                Catch
                    ' eat all exceptions if folder contains "not C1Report xmls"
                End Try
                If (rbFile.Items.Count > 0) Then
                    rbFile.SelectedIndex = 0
                End If
            Next
        End If
    End Sub

    Private Sub rbFile_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles rbFile.SelectionChanged
        rbReport.Items.Clear()
        Dim file As String = IIf(rbFile.SelectedItem Is Nothing, "", DirectCast(rbFile.SelectedItem, String))
        ' load list of the reports from file
        Try
            Dim reports As String() = C1Report.GetReportList(file)
            For Each report As String In reports
                rbReport.Items.Add(report)
            Next
        Catch
        End Try

        If rbReport.Items.Count > 0 Then
            rbReport.SelectedIndex = 0
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        ' ignore tick if we currently rendering a report
        If (c1Report.IsBusy) Then
            Return
        End If

        timer.Stop()
        ' preview current report
        Dim file As String = IIf(rbFile.SelectedItem Is Nothing, Nothing, DirectCast(rbFile.SelectedItem, String))
        Dim report As String = IIf(rbReport.SelectedItem Is Nothing, Nothing, DirectCast(rbReport.SelectedItem, String))
        If (String.IsNullOrEmpty(report) Or String.IsNullOrEmpty(file)) Then
            viewer.Document = Nothing
            Return
        End If

        Try
            c1Report.Load(file, report)
        Catch ex As Exception
            MessageBox.Show(String.Format("Can not load report [{1}] from file:" + vbCrLf + "{0}" + vbCrLf + vbCrLf + "Exception:" + vbCrLf + "{2}", file, report, ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error)
            Return
        End Try
        Try
            viewer.Document = c1Report.C1Document.FixedDocumentSequence
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception during report rendering:" + vbCrLf + "{0}", ex.Message), "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub

    Private Sub rbReport_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles rbReport.SelectionChanged
        Dim report As String = IIf(rbReport.SelectedItem Is Nothing, "", DirectCast(rbReport.SelectedItem, String))

        ' start timer do not update preview here to prevent too often updates
        timer.Stop()
        If (Not String.IsNullOrEmpty(report)) Then
            timer.Start()
        End If
    End Sub
End Class
