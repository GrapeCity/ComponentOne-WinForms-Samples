Imports C1.C1Report

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents C1Report2 As C1.C1Report.C1Report
    Friend WithEvents C1Report3 As C1.C1Report.C1Report
    Friend WithEvents C1Report4 As C1.C1Report.C1Report
    Friend WithEvents C1Report5 As C1.C1Report.C1Report
    Friend WithEvents C1Report6 As C1.C1Report.C1Report
    Friend WithEvents C1Report7 As C1.C1Report.C1Report
    Friend WithEvents C1Report8 As C1.C1Report.C1Report
    Friend WithEvents C1Report9 As C1.C1Report.C1Report
    Friend WithEvents C1Report10 As C1.C1Report.C1Report

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lstReports As System.Windows.Forms.ListBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1Report1 = New C1.C1Report.C1Report
        Me.C1Report2 = New C1.C1Report.C1Report
        Me.C1Report3 = New C1.C1Report.C1Report
        Me.C1Report4 = New C1.C1Report.C1Report
        Me.C1Report5 = New C1.C1Report.C1Report
        Me.C1Report6 = New C1.C1Report.C1Report
        Me.C1Report7 = New C1.C1Report.C1Report
        Me.C1Report8 = New C1.C1Report.C1Report
        Me.C1Report9 = New C1.C1Report.C1Report
        Me.C1Report10 = New C1.C1Report.C1Report
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.btnShow = New System.Windows.Forms.Button
        Me.lstReports = New System.Windows.Forms.ListBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Report10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "Alphabetical List of Products"
        '
        'C1Report2
        '
        Me.C1Report2.ReportDefinition = resources.GetString("C1Report2.ReportDefinition")
        Me.C1Report2.ReportName = "Catalog"
        '
        'C1Report3
        '
        Me.C1Report3.ReportDefinition = resources.GetString("C1Report3.ReportDefinition")
        Me.C1Report3.ReportName = "Customer Labels"
        '
        'C1Report4
        '
        Me.C1Report4.ReportDefinition = resources.GetString("C1Report4.ReportDefinition")
        Me.C1Report4.ReportName = "Employee Sales by Country"
        '
        'C1Report5
        '
        Me.C1Report5.ReportDefinition = resources.GetString("C1Report5.ReportDefinition")
        Me.C1Report5.ReportName = "Employees"
        '
        'C1Report6
        '
        Me.C1Report6.ReportDefinition = resources.GetString("C1Report6.ReportDefinition")
        Me.C1Report6.ReportName = "Invoice"
        '
        'C1Report7
        '
        Me.C1Report7.ReportDefinition = resources.GetString("C1Report7.ReportDefinition")
        Me.C1Report7.ReportName = "Orders by Value"
        '
        'C1Report8
        '
        Me.C1Report8.ReportDefinition = resources.GetString("C1Report8.ReportDefinition")
        Me.C1Report8.ReportName = "Products by Category"
        '
        'C1Report9
        '
        Me.C1Report9.ReportDefinition = resources.GetString("C1Report9.ReportDefinition")
        Me.C1Report9.ReportName = "Sales Chart"
        '
        'C1Report10
        '
        Me.C1Report10.ReportDefinition = resources.GetString("C1Report10.ReportDefinition")
        Me.C1Report10.ReportName = "Summary of Sales by Quarter"
        '
        'btnShow
        '
        Me.btnShow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnShow.Location = New System.Drawing.Point(0, 397)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(185, 32)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Render Report"
        '
        'lstReports
        '
        Me.lstReports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstReports.Location = New System.Drawing.Point(0, 0)
        Me.lstReports.Name = "lstReports"
        Me.lstReports.Size = New System.Drawing.Size(185, 394)
        Me.lstReports.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lstReports)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnShow)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.C1PrintPreviewControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(811, 429)
        Me.SplitContainer1.SplitterDistance = 185
        Me.SplitContainer1.TabIndex = 3
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.ExportOptions.Content = New C1.Win.C1Preview.ExporterOptions() {New C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "", True, False, False)}
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(622, 429)
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(811, 429)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "C1Report: Embedded reports"
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Report10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private m_Reports As ArrayList

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' build report list
        m_Reports = New ArrayList()
        m_Reports.Add(C1Report1)
        m_Reports.Add(C1Report2)
        m_Reports.Add(C1Report3)
        m_Reports.Add(C1Report4)
        m_Reports.Add(C1Report5)
        m_Reports.Add(C1Report6)
        m_Reports.Add(C1Report7)
        m_Reports.Add(C1Report8)
        m_Reports.Add(C1Report9)
        m_Reports.Add(C1Report10)

        ' populate list
        Dim r As C1Report
        For Each r In m_Reports
            lstReports.Items.Add(r.ReportName)
        Next
        lstReports.SelectedIndex = 0
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ShowReport()
    End Sub
    Private Sub lstReports_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstReports.DoubleClick
        ShowReport()
    End Sub

    Private Sub ShowReport()

        ' make sure the data is available
        Dim mdb As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\c1nwind.mdb"
        If Not System.IO.File.Exists(mdb) Then
            MsgBox("Sorry, cannot find data source at '" + mdb + "'.")
            Exit Sub
        End If

        ' make sure we're not busy
        Dim rTest As C1Report
        For Each rTest In m_Reports
            If rTest.IsBusy Then
                MsgBox("Please hold on, I'm still rendering '" + rTest.ReportName + "'.")
                Exit Sub
            End If
        Next

        ' select report
        Dim r As C1Report = m_Reports(lstReports.SelectedIndex)

        r.DataSource.ConnectionString = System.Text.RegularExpressions.Regex.Replace( _
            r.DataSource.ConnectionString, _
            "Data Source=.*Nwind.mdb", _
            "Data Source=" + mdb)

        ' render it into c1ppv control
        Cursor = Cursors.WaitCursor
        C1PrintPreviewControl1.Document = r
        Cursor = Cursors.Default

    End Sub

End Class
