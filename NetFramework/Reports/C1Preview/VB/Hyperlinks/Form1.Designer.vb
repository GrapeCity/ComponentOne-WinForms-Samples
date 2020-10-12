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
        Me.C1PrintDocument1 = New C1.C1Preview.C1PrintDocument
        Me.C1PrintPreviewControl1 = New C1.Win.C1Preview.C1PrintPreviewControl
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1PrintPreviewControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1PrintDocument1
        '
        Me.C1PrintDocument1.PageLayouts.Default.PageSettings = New C1.C1Preview.C1PageSettings(False, System.Drawing.Printing.PaperKind.Letter, False, "1in", "1in", "1in", "1in")
        '
        'C1PrintPreviewControl1
        '
        Me.C1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.Name = "C1PrintPreviewControl1"
        '
        'C1PrintPreviewControl1.OutlineView
        '
        Me.C1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView"
        Me.C1PrintPreviewControl1.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.C1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewPane
        '
        Me.C1PrintPreviewControl1.PreviewPane.Document = Me.C1PrintDocument1
        Me.C1PrintPreviewControl1.PreviewPane.ExportOptions.Content = New C1.Win.C1Preview.ExporterOptions() {New C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "C1.C1Preview.Export.C1dOptionsForm", True, False, False)}
        '
        '
        '
        Me.C1PrintPreviewControl1.PreviewPane.HistoryOptions.SavedActions = CType(((((((((((((((((((C1.Win.C1Preview.HistorySavedActionsEnum.Continuous Or C1.Win.C1Preview.HistorySavedActionsEnum.PageLayout) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.Rows) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.Cols) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.ZoomMode) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.ZoomFactor) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.StartPageChange) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.HyperlinkJump) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.Scroll) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.TextSearch) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.DocumentOpen) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.DocumentReflow) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.DocumentChangeMargins) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.DocumentChangePageSettings) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.HideMarginsState) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.ShowRulers) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.ShowPrintableArea) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.PrintingLayout) _
                    Or C1.Win.C1Preview.HistorySavedActionsEnum.PrinterSettings), C1.Win.C1Preview.HistorySavedActionsEnum)
        Me.C1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = True
        Me.C1PrintPreviewControl1.PreviewPane.TabIndex = 0
        '
        'C1PrintPreviewControl1.PreviewTextSearchPanel
        '
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewTextSearchPanel.Visible = False
        '
        'C1PrintPreviewControl1.ThumbnailView
        '
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView"
        Me.C1PrintPreviewControl1.PreviewThumbnailView.Size = New System.Drawing.Size(165, 461)
        Me.C1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0
        Me.C1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.C1PrintPreviewControl1.Size = New System.Drawing.Size(754, 534)
        Me.C1PrintPreviewControl1.TabIndex = 0
        Me.C1PrintPreviewControl1.Text = "C1PrintPreviewControl1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 534)
        Me.Controls.Add(Me.C1PrintPreviewControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1PrintPreviewControl1.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PrintPreviewControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1PrintPreviewControl1.ResumeLayout(False)
        Me.C1PrintPreviewControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1PrintDocument1 As C1.C1Preview.C1PrintDocument
    Friend WithEvents C1PrintPreviewControl1 As C1.Win.C1Preview.C1PrintPreviewControl

End Class
