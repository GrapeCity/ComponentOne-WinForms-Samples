<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits C1.Win.Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1FlexViewer1 = New C1.Win.FlexViewer.C1FlexViewer()
        Me.tbReports = New C1.Win.C1Command.C1TopicBar()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.C1FlexReport1 = New C1.Win.FlexReport.C1FlexReport()
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1FlexViewer1
        '
        Me.C1FlexViewer1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.C1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1FlexViewer1.Location = New System.Drawing.Point(245, 0)
        Me.C1FlexViewer1.Name = "C1FlexViewer1"
        Me.C1FlexViewer1.Size = New System.Drawing.Size(522, 511)
        Me.C1FlexViewer1.TabIndex = 0
        '
        'tbReports
        '
        Me.tbReports.AutoScrollMinSize = New System.Drawing.Size(0, 30)
        Me.tbReports.Dock = System.Windows.Forms.DockStyle.Left
        Me.tbReports.ImageList = Nothing
        Me.tbReports.Location = New System.Drawing.Point(0, 0)
        Me.tbReports.Name = "tbReports"
        Me.tbReports.PagePadding = New System.Windows.Forms.Padding(10)
        Me.tbReports.Size = New System.Drawing.Size(242, 511)
        Me.tbReports.TabIndex = 1
        Me.tbReports.VisualStyle = C1.Win.C1Command.VisualStyle.Custom
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(242, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 511)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'C1FlexReport1
        '
        Me.C1FlexReport1.ReportDefinition = resources.GetString("C1FlexReport1.ReportDefinition")
        Me.C1FlexReport1.ReportName = "C1FlexReport1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 511)
        Me.Controls.Add(Me.C1FlexViewer1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.tbReports)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Flex Common Tasks"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.C1FlexViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1FlexViewer1 As C1.Win.FlexViewer.C1FlexViewer
    Friend WithEvents tbReports As C1.Win.C1Command.C1TopicBar
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents C1FlexReport1 As C1.Win.FlexReport.C1FlexReport

End Class
