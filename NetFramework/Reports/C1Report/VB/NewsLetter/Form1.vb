Imports C1.C1Report

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        CorrectConnectionString(c1r)
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
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c1r = New C1.C1Report.C1Report
        Me.Button1 = New System.Windows.Forms.Button
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1r
        '
        Me.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition")
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(658, 35)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Show Newsletter"
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 35)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.ExportOptions.Content = New C1.Win.C1Preview.ExporterOptions() {New C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "", True, False, False)}
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(658, 489)
        Me.C1PrintPreviewControl1.TabIndex = 2
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(658, 524)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Report: Unbound report sample"
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CorrectConnectionString(ByVal rep As C1.C1Report.C1Report)
        Dim cs As String = rep.DataSource.ConnectionString
        If (IsNothing(cs)) Then
            Return
        End If

        '
        Dim i As Integer = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
        If (i < 0) Then
            Return
        End If
        While (i < cs.Length And cs(i) <> "=")
            i = i + 1
        End While
        If (i >= cs.Length) Then
            Return
        End If

        Dim j As Integer = i
        While (i < cs.Length And cs(i) <> ";")
            i = i + 1
        End While

        '
        Dim mdbName As String = cs.Substring(j + 1, i - j - 1).Trim()
        If (mdbName.Length <= 0) Then
            Return
        End If
        mdbName = System.IO.Path.GetFileName(mdbName)
        If (String.Compare(mdbName, "nwind.mdb", True) = 0) Then
            mdbName = "c1nwind.mdb"
        End If

        '
        cs = cs.Substring(0, j + 1) + _
            Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\" + _
            mdbName + _
            cs.Substring(i)

        rep.DataSource.ConnectionString = cs

        '
        For i = 0 To rep.Fields.Count - 1 Step 1
            If (Not IsNothing(rep.Fields(i).Subreport)) Then
                CorrectConnectionString(rep.Fields(i).Subreport)
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ' find report definition file
        Dim path As String = Application.StartupPath
        Dim i As Integer = path.IndexOf("\bin")
        If i > -1 Then path = path.Substring(0, i)
        path = path & "\"

        ' load unbound report
        c1r.Load(path & "Newsletter.xml", "NewsLetter")

        ' set field values
        c1r.Fields("FldHeadline1").Text = "C1Report Launched"
        c1r.Fields("FldBody1").Text = "ComponentOne unveils C1Report, the easiest way to add powerful and flexible reports to your .NET applications. Create reports like the ones in Microsoft Access, leveraging the latest .NET technologies, and publish them over the Web."

        c1r.Fields("FldHeadline2").Text = "Competitive Upgrades"
        c1r.Fields("FldBody2").Text = "Get ahead of the competition. Step up from GlassReports, DiamondReports, or OpalReports today for only $200. C1Report is so easy to use, it will pay for itself in a couple of days."

        c1r.Fields("FldHeadline3").Text = "C1Report Designer"
        c1r.Fields("FldBody3").Text = "The C1Report Designer is the one you are already used to. It looks like Access, works like Access, and smells like Access. Start using it today without looking at any docs."

        ' done, show the report
        C1PrintPreviewControl1.Document = c1r

        ' and/or save it to an HTML/RTF/XLS file so your subscribers can get to it over the Web
        c1r.RenderToFile(path & "Newsletter.htm", FileFormatEnum.HTML)
        c1r.RenderToFile(path & "Newsletter.pdf", FileFormatEnum.PDF)
        c1r.RenderToFile(path & "Newsletter.xls", FileFormatEnum.Excel)

    End Sub
End Class
