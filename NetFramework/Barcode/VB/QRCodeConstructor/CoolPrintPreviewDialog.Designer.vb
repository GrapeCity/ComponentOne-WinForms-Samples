<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoolPrintPreviewDialog
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CoolPrintPreviewDialog))
        Me._toolStrip = New System.Windows.Forms.ToolStrip()
        Me._btnPrint = New System.Windows.Forms.ToolStripButton()
        Me._btnPageSetup = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me._btnZoom = New System.Windows.Forms.ToolStripSplitButton()
        Me._itemActualSize = New System.Windows.Forms.ToolStripMenuItem()
        Me._itemFullPage = New System.Windows.Forms.ToolStripMenuItem()
        Me._itemPageWidth = New System.Windows.Forms.ToolStripMenuItem()
        Me._itemTwoPages = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me._item500 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item200 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item150 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item100 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item75 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item50 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item25 = New System.Windows.Forms.ToolStripMenuItem()
        Me._item10 = New System.Windows.Forms.ToolStripMenuItem()
        Me._btnFirst = New System.Windows.Forms.ToolStripButton()
        Me._btnPrev = New System.Windows.Forms.ToolStripButton()
        Me._txtStartPage = New System.Windows.Forms.ToolStripTextBox()
        Me._lblPageCount = New System.Windows.Forms.ToolStripLabel()
        Me._btnNext = New System.Windows.Forms.ToolStripButton()
        Me._btnLast = New System.Windows.Forms.ToolStripButton()
        Me._separator = New System.Windows.Forms.ToolStripSeparator()
        Me._btnCancel = New System.Windows.Forms.ToolStripButton()
        Me._preview = New CoolPrintPreviewControl()
        Me._toolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        '_toolStrip
        '
        Me._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me._toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._btnPrint, Me._btnPageSetup, Me.toolStripSeparator2, Me._btnZoom, Me._btnFirst, Me._btnPrev, Me._txtStartPage, Me._lblPageCount, Me._btnNext, Me._btnLast, Me._separator, Me._btnCancel})
        Me._toolStrip.Location = New System.Drawing.Point(0, 0)
        Me._toolStrip.Name = "_toolStrip"
        Me._toolStrip.Size = New System.Drawing.Size(426, 25)
        Me._toolStrip.TabIndex = 1
        Me._toolStrip.Text = "toolStrip1"
        '
        '_btnPrint
        '
        Me._btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnPrint.Image = CType(resources.GetObject("_btnPrint.Image"), System.Drawing.Image)
        Me._btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(23, 22)
        Me._btnPrint.Text = "Print Document"
        '
        '_btnPageSetup
        '
        Me._btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnPageSetup.Image = CType(resources.GetObject("_btnPageSetup.Image"), System.Drawing.Image)
        Me._btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnPageSetup.Name = "_btnPageSetup"
        Me._btnPageSetup.Size = New System.Drawing.Size(23, 22)
        Me._btnPageSetup.Text = "Page Setup"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        '_btnZoom
        '
        Me._btnZoom.AutoToolTip = False
        Me._btnZoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._itemActualSize, Me._itemFullPage, Me._itemPageWidth, Me._itemTwoPages, Me.toolStripMenuItem1, Me._item500, Me._item200, Me._item150, Me._item100, Me._item75, Me._item50, Me._item25, Me._item10})
        Me._btnZoom.Image = CType(resources.GetObject("_btnZoom.Image"), System.Drawing.Image)
        Me._btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnZoom.Name = "_btnZoom"
        Me._btnZoom.Size = New System.Drawing.Size(71, 22)
        Me._btnZoom.Text = "&Zoom"
        '
        '_itemActualSize
        '
        Me._itemActualSize.Image = CType(resources.GetObject("_itemActualSize.Image"), System.Drawing.Image)
        Me._itemActualSize.Name = "_itemActualSize"
        Me._itemActualSize.Size = New System.Drawing.Size(135, 22)
        Me._itemActualSize.Text = "Actual Size"
        '
        '_itemFullPage
        '
        Me._itemFullPage.Image = CType(resources.GetObject("_itemFullPage.Image"), System.Drawing.Image)
        Me._itemFullPage.Name = "_itemFullPage"
        Me._itemFullPage.Size = New System.Drawing.Size(135, 22)
        Me._itemFullPage.Text = "Full Page"
        '
        '_itemPageWidth
        '
        Me._itemPageWidth.Image = CType(resources.GetObject("_itemPageWidth.Image"), System.Drawing.Image)
        Me._itemPageWidth.Name = "_itemPageWidth"
        Me._itemPageWidth.Size = New System.Drawing.Size(135, 22)
        Me._itemPageWidth.Text = "Page Width"
        '
        '_itemTwoPages
        '
        Me._itemTwoPages.Image = CType(resources.GetObject("_itemTwoPages.Image"), System.Drawing.Image)
        Me._itemTwoPages.Name = "_itemTwoPages"
        Me._itemTwoPages.Size = New System.Drawing.Size(135, 22)
        Me._itemTwoPages.Text = "Two Pages"
        '
        'toolStripMenuItem1
        '
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
        '
        '_item500
        '
        Me._item500.Name = "_item500"
        Me._item500.Size = New System.Drawing.Size(135, 22)
        Me._item500.Text = "500%"
        '
        '_item200
        '
        Me._item200.Name = "_item200"
        Me._item200.Size = New System.Drawing.Size(135, 22)
        Me._item200.Text = "200%"
        '
        '_item150
        '
        Me._item150.Name = "_item150"
        Me._item150.Size = New System.Drawing.Size(135, 22)
        Me._item150.Text = "150%"
        '
        '_item100
        '
        Me._item100.Name = "_item100"
        Me._item100.Size = New System.Drawing.Size(135, 22)
        Me._item100.Text = "100%"
        '
        '_item75
        '
        Me._item75.Name = "_item75"
        Me._item75.Size = New System.Drawing.Size(135, 22)
        Me._item75.Text = "75%"
        '
        '_item50
        '
        Me._item50.Name = "_item50"
        Me._item50.Size = New System.Drawing.Size(135, 22)
        Me._item50.Text = "50%"
        '
        '_item25
        '
        Me._item25.Name = "_item25"
        Me._item25.Size = New System.Drawing.Size(135, 22)
        Me._item25.Text = "25%"
        '
        '_item10
        '
        Me._item10.Name = "_item10"
        Me._item10.Size = New System.Drawing.Size(135, 22)
        Me._item10.Text = "10%"
        '
        '_btnFirst
        '
        Me._btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnFirst.Image = CType(resources.GetObject("_btnFirst.Image"), System.Drawing.Image)
        Me._btnFirst.ImageTransparentColor = System.Drawing.Color.Red
        Me._btnFirst.Name = "_btnFirst"
        Me._btnFirst.Size = New System.Drawing.Size(23, 22)
        Me._btnFirst.Text = "First Page"
        '
        '_btnPrev
        '
        Me._btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnPrev.Image = CType(resources.GetObject("_btnPrev.Image"), System.Drawing.Image)
        Me._btnPrev.ImageTransparentColor = System.Drawing.Color.Red
        Me._btnPrev.Name = "_btnPrev"
        Me._btnPrev.Size = New System.Drawing.Size(23, 22)
        Me._btnPrev.Text = "Previous Page"
        '
        '_txtStartPage
        '
        Me._txtStartPage.AutoSize = False
        Me._txtStartPage.Name = "_txtStartPage"
        Me._txtStartPage.Size = New System.Drawing.Size(32, 23)
        Me._txtStartPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_lblPageCount
        '
        Me._lblPageCount.Name = "_lblPageCount"
        Me._lblPageCount.Size = New System.Drawing.Size(10, 22)
        Me._lblPageCount.Text = " "
        '
        '_btnNext
        '
        Me._btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnNext.Image = CType(resources.GetObject("_btnNext.Image"), System.Drawing.Image)
        Me._btnNext.ImageTransparentColor = System.Drawing.Color.Red
        Me._btnNext.Name = "_btnNext"
        Me._btnNext.Size = New System.Drawing.Size(23, 22)
        Me._btnNext.Text = "Next Page"
        '
        '_btnLast
        '
        Me._btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me._btnLast.Image = CType(resources.GetObject("_btnLast.Image"), System.Drawing.Image)
        Me._btnLast.ImageTransparentColor = System.Drawing.Color.Red
        Me._btnLast.Name = "_btnLast"
        Me._btnLast.Size = New System.Drawing.Size(23, 22)
        Me._btnLast.Text = "Last Page"
        '
        '_separator
        '
        Me._separator.Name = "_separator"
        Me._separator.Size = New System.Drawing.Size(6, 25)
        Me._separator.Visible = False
        '
        '_btnCancel
        '
        Me._btnCancel.AutoToolTip = False
        Me._btnCancel.Image = CType(resources.GetObject("_btnCancel.Image"), System.Drawing.Image)
        Me._btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me._btnCancel.Name = "_btnCancel"
        Me._btnCancel.Size = New System.Drawing.Size(63, 22)
        Me._btnCancel.Text = "Cancel"
        '
        '_preview
        '
        Me._preview.Dock = System.Windows.Forms.DockStyle.Fill
        Me._preview.Document = Nothing
        Me._preview.Location = New System.Drawing.Point(0, 25)
        Me._preview.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me._preview.Name = "_preview"
        Me._preview.Size = New System.Drawing.Size(426, 323)
        Me._preview.TabIndex = 2
        ' Me._preview.ZoomMode = CoolPrintPreviewControl.ZoomMode.FullPage
        '
        'CoolPrintPreviewDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(426, 348)
        Me.Controls.Add(Me._preview)
        Me.Controls.Add(Me._toolStrip)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "CoolPrintPreviewDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print Preview"
        Me._toolStrip.ResumeLayout(False)
        Me._toolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents _toolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents _btnPrint As System.Windows.Forms.ToolStripButton
    Private WithEvents _btnPageSetup As System.Windows.Forms.ToolStripButton
    Private WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _btnZoom As System.Windows.Forms.ToolStripSplitButton
    Private WithEvents _itemActualSize As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _itemFullPage As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _itemPageWidth As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _itemTwoPages As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _item500 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item200 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item150 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item100 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item75 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item50 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item25 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _item10 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents _btnFirst As System.Windows.Forms.ToolStripButton
    Private WithEvents _btnPrev As System.Windows.Forms.ToolStripButton
    Private WithEvents _txtStartPage As System.Windows.Forms.ToolStripTextBox
    Private WithEvents _lblPageCount As System.Windows.Forms.ToolStripLabel
    Private WithEvents _btnNext As System.Windows.Forms.ToolStripButton
    Private WithEvents _btnLast As System.Windows.Forms.ToolStripButton
    Private WithEvents _separator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents _btnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents _preview As CoolPrintPreviewControl
End Class
