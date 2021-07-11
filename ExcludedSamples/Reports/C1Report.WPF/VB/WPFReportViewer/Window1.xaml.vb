Imports System.Windows.Forms

Class Window1

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles button1.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()
        ofd.Title = "Select report definition file"
        ofd.Filter = "Report definition files (*.xml)|*.xml|All files (*.*)|*.*"
        If (ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
            Try
                ' parse file and select report definitions
                Dim reports As String() = C1.C1Report.C1Report.GetReportList(ofd.FileName)
                If (reports Is Nothing) Or (reports.Length <= 0) Then
                    Throw New Exception(String.Format("File {0} has no reports definitions.", ofd.FileName))
                End If
                tbFileName.Text = ofd.FileName
                c1DocumentViewer.FileName = ofd.FileName

                cbReportName.Items.Clear()
                Dim reportName As String
                For Each reportName In reports
                    cbReportName.Items.Add(reportName)
                Next
                cbReportName.SelectedIndex = 0

            Catch ex As Exception
                System.Windows.MessageBox.Show("Report definition file can't be opened, error:" & Environment.NewLine & ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error)
                c1DocumentViewer.ReportName = ""
                c1DocumentViewer.FileName = ""
            End Try
        End If
    End Sub

    Private Sub cbReportName_SelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Controls.SelectionChangedEventArgs) Handles cbReportName.SelectionChanged
        c1DocumentViewer.ReportName = cbReportName.SelectedItem
    End Sub
End Class
