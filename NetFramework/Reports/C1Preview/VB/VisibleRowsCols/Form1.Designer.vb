<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.c1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.doc = New C1.C1Preview.C1PrintDocument
        Me.panel1 = New System.Windows.Forms.Panel
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        CType(Me.c1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1PrintPreviewControl1.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'c1PrintPreviewControl1
        '
        Me.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1PrintPreviewControl1.Location = New System.Drawing.Point(0, 58)
        Me.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1"
        '
        'c1PrintPreviewControl1.OutlineView
        '
        Me.c1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.c1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        Me.c1PrintPreviewControl1.PreviewOutlineView.PreviewPane = Me.c1PrintPreviewControl1.PreviewPane
        Me.c1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.c1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        '
        'c1PrintPreviewControl1.PreviewPane
        '
        Me.c1PrintPreviewControl1.PreviewPane.Document = Me.doc
        Me.c1PrintPreviewControl1.PreviewPane.ExportOptions.Content = New C1.Win.C1Preview.ExporterOptions(-1) {}
        Me.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.c1PrintPreviewControl1.PreviewPane.TabIndex = 0
        '
        'c1PrintPreviewControl1.PreviewTextSearchPanel
        '
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(454, 0)
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(180, 240)
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.PreviewPane = Me.c1PrintPreviewControl1.PreviewPane
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(180, 394)
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        Me.c1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        '
        'c1PrintPreviewControl1.ThumbnailView
        '
        Me.c1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1PrintPreviewControl1.PreviewThumbnailView.HideSelection = False
        Me.c1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.c1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.c1PrintPreviewControl1.PreviewThumbnailView.OwnerDraw = True
        Me.c1PrintPreviewControl1.PreviewThumbnailView.PreviewPane = Me.c1PrintPreviewControl1.PreviewPane
        Me.c1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 368)
        Me.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.c1PrintPreviewControl1.PreviewThumbnailView.ThumbnailSize = New System.Drawing.Size(96, 96)
        Me.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.c1PrintPreviewControl1.Size = New System.Drawing.Size(634, 441)
        Me.c1PrintPreviewControl1.TabIndex = 3
        Me.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1"
        '
        'doc
        '
        Me.doc.PageLayouts.Default.PageSettings = New C1.C1Preview.C1PageSettings(System.Drawing.Printing.PaperKind.A4, False, "25.4mm", "25.4mm", "25.4mm", "25.4mm")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.button2)
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(634, 58)
        Me.panel1.TabIndex = 2
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(148, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(117, 34)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Hidden rows in header and footer"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(12, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(130, 34)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Simple table with hidden columns and rows"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 499)
        Me.Controls.Add(Me.c1PrintPreviewControl1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Visible property of columns and rows of RenderTable"
        CType(Me.c1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1PrintPreviewControl1.ResumeLayout(False)
        Me.c1PrintPreviewControl1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl
    Private WithEvents doc As C1.C1Preview.C1PrintDocument
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button

End Class
