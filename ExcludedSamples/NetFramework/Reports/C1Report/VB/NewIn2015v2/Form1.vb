Imports C1.C1Report
Imports C1.Win.C1Ribbon
Imports System.IO

Public Class Form1

    Private WithEvents _rcbFile As RibbonComboBox 
    Private WithEvents _rcbReport As RibbonComboBox

    Private Sub _rcbFile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _rcbFile.SelectedIndexChanged
        Dim ri As RibbonItem = _rcbFile.SelectedItem
        _rcbFile.ToolTip = IIf(ri Is Nothing, "", ri.ToolTip)

        ' load list of the reports from file
        Dim file As String = ri.ToolTip
        _rcbReport.Items.Clear()
        Try
            Dim reports As String() = C1Report.GetReportList(file)
            For Each report As String In reports
                Dim rir As RibbonItem = _rcbReport.Items.Add(report)
                rir.ToolTip = report
            Next
        Catch
        End Try

        If _rcbReport.Items.Count > 0 Then
            _rcbReport.SelectedIndex = 0
        End If
    End Sub

    Private Sub _rcbReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _rcbReport.SelectedIndexChanged
        Dim ri As RibbonItem = _rcbReport.SelectedItem
        _rcbReport.ToolTip = IIf(ri Is Nothing, "", ri.ToolTip)

        Dim report As String = _rcbReport.ToolTip
        ' start timer do not update preview here to prevent too often updates
        Timer1.Enabled = False
        Timer1.Enabled = Not String.IsNullOrEmpty(report)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' ignore tick if we currently rendering a report
        If (C1Report1.IsBusy) Then
            Return
        End If

        Timer1.Enabled = False
        ' preview current report
        Dim file As String = IIf(_rcbFile.SelectedItem Is Nothing, Nothing, _rcbFile.SelectedItem.ToolTip)
        Dim report As String = IIf(_rcbReport.SelectedItem Is Nothing, Nothing, _rcbReport.SelectedItem.ToolTip)
        If (String.IsNullOrEmpty(report) Or String.IsNullOrEmpty(file)) Then
            C1RibbonPreview1.Document = Nothing
            Return
        End If

        Try
            C1Report1.Load(file, report)
        Catch ex As Exception
            MessageBox.Show(String.Format("Can not load report [{1}] from file:" + vbCrLf + "{0}" + vbCrLf + vbCrLf + "Exception:" + vbCrLf + "{2}", file, report, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
        Try
            C1RibbonPreview1.Document = C1Report1
        Catch ex As Exception
            MessageBox.Show(String.Format("Exception during report rendering:" + vbCrLf + "{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ' Build additional RibbonGroup in the Ribbon of C1RibbonPreview control
        Dim rgReports As RibbonGroup = New RibbonGroup("Reports")
        _rcbFile = New RibbonComboBox()
        _rcbFile.LabelWidth = 40
        _rcbFile.Label = "File"
        _rcbFile.DropDownStyle = RibbonComboBoxStyle.DropDownList
        _rcbFile.TextAreaWidth = 200
        rgReports.Items.Add(_rcbFile)

        _rcbReport = New RibbonComboBox()
        _rcbReport.LabelWidth = 40
        _rcbReport.Label = "Report"
        _rcbReport.DropDownStyle = RibbonComboBoxStyle.DropDownList
        _rcbReport.TextAreaWidth = 200
        rgReports.Items.Add(_rcbReport)

        ' fill _rbFile with initial list of the files
        ' added all files in the ..\..\Reports directory
        Dim files As String() = Directory.GetFiles("..\..\Reports", "*.xml")
        If Not files Is Nothing Then
            For Each file As String In files

                Try
                    Dim reports As String() = C1Report.GetReportList(file)
                    If (Not reports Is Nothing And reports.Length > 0) Then
                        Dim ri As RibbonItem = _rcbFile.Items.Add(file)
                        ri.ToolTip = file
                    End If
                Catch
                    ' eat all exceptions if folder contains "not C1Report xmls"
                End Try
                If (_rcbFile.Items.Count > 0) Then
                    _rcbFile.SelectedIndex = 0
                End If
            Next
        End If

        ' add created RibbonGroup to the ribbon
        C1RibbonPreview1.Ribbon.Tabs(0).Groups.Insert(0, rgReports)
    End Sub
End Class
