Imports C1.Win.Command
Imports C1.Win.FlexReport

Public Class Form1
    Const c_FlexCommonTasks As String = "FlexCommonTasks.flxr"

    Sub New()
        'MyBase.New()

        InitializeComponent()

        UpdateLayout()

        BuildTopicBar()
    End Sub

    Sub UpdateLayout()
        tbReports.Parent = Nothing
        Splitter1.Parent = Nothing

        Dim viewerControls = C1FlexViewer1.Controls
        Dim c1 As Control = viewerControls(0)
        Dim c2 As Control = viewerControls(1)
        Dim c3 As Control = viewerControls(2)
        viewerControls.Clear()

        viewerControls.Add(c1)
        viewerControls.Add(Splitter1)
        viewerControls.Add(tbReports)
        viewerControls.Add(c2)
        viewerControls.Add(c3)
    End Sub

    Sub BuildTopicBar()
        ' get list of the reports
        Dim fileName As String = "..\..\..\" + c_FlexCommonTasks
        Dim reports As String() = C1FlexReport.GetReportList(fileName)

        ' go over reports and get category from C1FlexReport.ReportInfo.Keywords
        Dim fr As C1FlexReport = New C1FlexReport()
        Dim categories As Dictionary(Of String, List(Of String)) = New Dictionary(Of String, List(Of String))(StringComparer.CurrentCultureIgnoreCase)
        For Each reportName As String In reports
            fr.Load(fileName, reportName)
            Dim keywords As String = fr.ReportInfo.Keywords
            Dim ss As String() = keywords.Split(New String() {vbCrLf}, StringSplitOptions.None)
            For i As Integer = 0 To ss.Length - 1
                Dim reps As List(Of String) = Nothing
                If (Not categories.TryGetValue(ss(i), reps)) Then
                    reps = New List(Of String)()
                    categories.Add(ss(i), reps)
                End If
                reps.Add(reportName)
            Next
        Next

        For Each kvp As KeyValuePair(Of String, List(Of String)) In categories
            ' build items in the C1TopicBar
            Dim tp As C1TopicPage = New C1TopicPage(kvp.Key)
            For Each s As String In kvp.Value
                Dim tl As C1TopicLink = New C1TopicLink(s)
                tp.Links.Add(tl)
            Next
            tbReports.Pages.Add(tp)
        Next
    End Sub

    Private Sub tbReports_LinkClick(sender As Object, e As C1TopicBarClickEventArgs) Handles tbReports.LinkClick
        If (C1FlexReport1.IsBusy) Then
            Return
        End If
        C1FlexReport1.Load("..\..\..\" + c_FlexCommonTasks, e.Link.Text)
        C1FlexViewer1.DocumentSource = C1FlexReport1
    End Sub
End Class
