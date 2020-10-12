Option Explicit On
Option Strict On

Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Public Class ReportSelectDialog

    Private _fileName As String = Nothing

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler lstReports.SelectedIndexChanged,
            Sub(s, e)
                If (lstReports.SelectedItems.Count > 0) Then
                    ReportName = lstReports.SelectedItems(0).Text
                Else
                    ReportName = String.Empty
                End If
            End Sub

        AddHandler lstReports.DoubleClick, Sub(s, e) btnOk.PerformClick()

        AddHandler btnOk.Click,
            Sub(s, e)
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End Sub

        AddHandler btnCancel.Click,
            Sub(s, e)

                Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
                Me.Close()
            End Sub
    End Sub

    Public Property ReportName As String

    Public ReadOnly Property HasReports As Boolean
        Get
            Return lstReports.Items.Count > 0
        End Get
    End Property

    Public Property FileName As String
        Get
            Return _fileName
        End Get
        Set(value As String)
            lstReports.Clear()
            Try
                Dim reports = C1Report.GetReportList(value)
                For Each repName As String In reports
                    lstReports.Items.Add(repName)
                Next
                If (lstReports.Items.Count > 0) Then
                    lstReports.SelectedIndices.Add(0)
                End If
                _fileName = value
            Catch

                _fileName = Nothing
            End Try
        End Set
    End Property
End Class
