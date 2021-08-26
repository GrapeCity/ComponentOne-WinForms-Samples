Imports System.IO
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
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents C1Report1 As C1.C1Report.C1Report
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DirListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DirListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DriveListBox1 As Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.C1Report1 = New C1.C1Report.C1Report
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.DirListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DirListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DriveListBox1 = New Microsoft.VisualBasic.Compatibility.VB6.DriveListBox
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 508)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'C1Report1
        '
        Me.C1Report1.ReportDefinition = resources.GetString("C1Report1.ReportDefinition")
        Me.C1Report1.ReportName = "Directory Report"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DirListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DriveListBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.C1PrintPreviewControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(947, 508)
        Me.SplitContainer1.SplitterDistance = 198
        Me.SplitContainer1.TabIndex = 4
        '
        'DirListBox1
        '
        Me.DirListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DirListBox1.FormattingEnabled = True
        Me.DirListBox1.IntegralHeight = False
        Me.DirListBox1.Location = New System.Drawing.Point(0, 21)
        Me.DirListBox1.Name = "DirListBox1"
        Me.DirListBox1.Size = New System.Drawing.Size(198, 447)
        Me.DirListBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button1.Location = New System.Drawing.Point(0, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Create Report"
        '
        'DriveListBox1
        '
        Me.DriveListBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DriveListBox1.FormattingEnabled = True
        Me.DriveListBox1.Location = New System.Drawing.Point(0, 0)
        Me.DriveListBox1.Name = "DriveListBox1"
        Me.DriveListBox1.Size = New System.Drawing.Size(198, 21)
        Me.DriveListBox1.TabIndex = 6
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
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(745, 508)
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(951, 508)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Splitter1)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "C1Report: Custom Data Source demo"
        CType(Me.C1Report1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' start highlighting the root
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DirListBox1.SelectedIndex = 0
    End Sub

    ' change DirListBox to use new drive
    Private Sub DriveListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        DirListBox1.Path = DriveListBox1.Text
    End Sub

    Private Sub DirListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DirListBox1.SelectedIndexChanged
        If Not C1Report1.IsBusy Then
            C1PrintPreviewControl1.PreviewPane.StatusText = "Create report for: " + GetSelectedDir()
        End If
    End Sub

    ' get selected directory from DirListBox
    Private Function GetSelectedDir() As String
        Dim s As String = DirListBox1.Path
        Dim i As Integer = s.IndexOf(DirListBox1.SelectedItem)
        If i > -1 Then s = s.Substring(0, i + Len(DirListBox1.SelectedItem))
        Return s
    End Function

    ' render report with custom data
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' create custom data source using the selected directory
        Dim dir As String = GetSelectedDir()
        C1PrintPreviewControl1.PreviewPane.StatusText = "Reading " + dir
        Dim ds As DataSource = New DataSource(dir)

        ' assign data source to report object
        C1Report1.DataSource.Recordset = ds

        ' render the report
        C1Report1.PageImages.Clear()
        C1PrintPreviewControl1.PreviewPane.StatusText = "Rendering report"
        C1PrintPreviewControl1.Document = C1Report1

    End Sub

    ' always provide some user feedback while rendering
    Private Sub C1Report1_StartPage(ByVal sender As Object, ByVal e As C1.C1Report.ReportEventArgs) Handles C1Report1.StartPage
        C1PrintPreviewControl1.PreviewPane.StatusText = "Rendering Page " + e.Page.ToString() + " press ESC to cancel."
    End Sub
    Private Sub C1Report1_EndReport(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1Report1.EndReport
        C1PrintPreviewControl1.PreviewPane.StatusText = "Ready"
    End Sub

    ' cancel report when the user hits escape
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If C1Report1.IsBusy And e.KeyChar = Chr(27) Then
            C1Report1.Cancel = True
            C1PrintPreviewControl1.PreviewPane.StatusText = "Report cancelled"
        End If
    End Sub
End Class
