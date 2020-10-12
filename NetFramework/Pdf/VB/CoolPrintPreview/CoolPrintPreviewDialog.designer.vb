Partial Class CoolPrintPreviewDialog
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CoolPrintPreviewDialog))
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
		Me._preview = New CoolPrintPreview.CoolPrintPreviewControl()
		Me._btnCreatePdf = New System.Windows.Forms.ToolStripButton()
		Me._pdf = New C1.C1Pdf.C1PdfDocument()
		Me._toolStrip.SuspendLayout()
		Me.SuspendLayout()
		' 
		' _toolStrip
		' 
		Me._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me._toolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._btnPrint, Me._btnCreatePdf, Me._btnPageSetup, Me.toolStripSeparator2, Me._btnZoom, Me._btnFirst, _
			Me._btnPrev, Me._txtStartPage, Me._lblPageCount, Me._btnNext, Me._btnLast, Me._separator, _
			Me._btnCancel})
		Me._toolStrip.Location = New System.Drawing.Point(0, 0)
		Me._toolStrip.Name = "_toolStrip"
		Me._toolStrip.Size = New System.Drawing.Size(400, 25)
		Me._toolStrip.TabIndex = 0
		Me._toolStrip.Text = "toolStrip1"
		' 
		' _btnPrint
		' 
		Me._btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnPrint.Image = DirectCast(resources.GetObject("_btnPrint.Image"), System.Drawing.Image)
		Me._btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnPrint.Name = "_btnPrint"
		Me._btnPrint.Size = New System.Drawing.Size(23, 22)
		Me._btnPrint.Text = "Print Document"
		AddHandler Me._btnPrint.Click, New System.EventHandler(AddressOf Me._btnPrint_Click)
		' 
		' _btnPageSetup
		' 
		Me._btnPageSetup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnPageSetup.Image = DirectCast(resources.GetObject("_btnPageSetup.Image"), System.Drawing.Image)
		Me._btnPageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnPageSetup.Name = "_btnPageSetup"
		Me._btnPageSetup.Size = New System.Drawing.Size(23, 22)
		Me._btnPageSetup.Text = "Page Setup"
		AddHandler Me._btnPageSetup.Click, New System.EventHandler(AddressOf Me._btnPageSetup_Click)
		' 
		' toolStripSeparator2
		' 
		Me.toolStripSeparator2.Name = "toolStripSeparator2"
		Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
		' 
		' _btnZoom
		' 
		Me._btnZoom.AutoToolTip = False
		Me._btnZoom.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._itemActualSize, Me._itemFullPage, Me._itemPageWidth, Me._itemTwoPages, Me.toolStripMenuItem1, Me._item500, _
			Me._item200, Me._item150, Me._item100, Me._item75, Me._item50, Me._item25, _
			Me._item10})
		Me._btnZoom.Image = DirectCast(resources.GetObject("_btnZoom.Image"), System.Drawing.Image)
		Me._btnZoom.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnZoom.Name = "_btnZoom"
		Me._btnZoom.Size = New System.Drawing.Size(71, 22)
		Me._btnZoom.Text = "&Zoom"
		AddHandler Me._btnZoom.ButtonClick, New System.EventHandler(AddressOf Me._btnZoom_ButtonClick)
		AddHandler Me._btnZoom.DropDownItemClicked, New System.Windows.Forms.ToolStripItemClickedEventHandler(AddressOf Me._btnZoom_DropDownItemClicked)
		' 
		' _itemActualSize
		' 
		Me._itemActualSize.Image = DirectCast(resources.GetObject("_itemActualSize.Image"), System.Drawing.Image)
		Me._itemActualSize.Name = "_itemActualSize"
		Me._itemActualSize.Size = New System.Drawing.Size(135, 22)
		Me._itemActualSize.Text = "Actual Size"
		' 
		' _itemFullPage
		' 
		Me._itemFullPage.Image = DirectCast(resources.GetObject("_itemFullPage.Image"), System.Drawing.Image)
		Me._itemFullPage.Name = "_itemFullPage"
		Me._itemFullPage.Size = New System.Drawing.Size(135, 22)
		Me._itemFullPage.Text = "Full Page"
		' 
		' _itemPageWidth
		' 
		Me._itemPageWidth.Image = DirectCast(resources.GetObject("_itemPageWidth.Image"), System.Drawing.Image)
		Me._itemPageWidth.Name = "_itemPageWidth"
		Me._itemPageWidth.Size = New System.Drawing.Size(135, 22)
		Me._itemPageWidth.Text = "Page Width"
		' 
		' _itemTwoPages
		' 
		Me._itemTwoPages.Image = DirectCast(resources.GetObject("_itemTwoPages.Image"), System.Drawing.Image)
		Me._itemTwoPages.Name = "_itemTwoPages"
		Me._itemTwoPages.Size = New System.Drawing.Size(135, 22)
		Me._itemTwoPages.Text = "Two Pages"
		' 
		' toolStripMenuItem1
		' 
		Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
		Me.toolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
		' 
		' _item500
		' 
		Me._item500.Name = "_item500"
		Me._item500.Size = New System.Drawing.Size(135, 22)
		Me._item500.Text = "500%"
		' 
		' _item200
		' 
		Me._item200.Name = "_item200"
		Me._item200.Size = New System.Drawing.Size(135, 22)
		Me._item200.Text = "200%"
		' 
		' _item150
		' 
		Me._item150.Name = "_item150"
		Me._item150.Size = New System.Drawing.Size(135, 22)
		Me._item150.Text = "150%"
		' 
		' _item100
		' 
		Me._item100.Name = "_item100"
		Me._item100.Size = New System.Drawing.Size(135, 22)
		Me._item100.Text = "100%"
		' 
		' _item75
		' 
		Me._item75.Name = "_item75"
		Me._item75.Size = New System.Drawing.Size(135, 22)
		Me._item75.Text = "75%"
		' 
		' _item50
		' 
		Me._item50.Name = "_item50"
		Me._item50.Size = New System.Drawing.Size(135, 22)
		Me._item50.Text = "50%"
		' 
		' _item25
		' 
		Me._item25.Name = "_item25"
		Me._item25.Size = New System.Drawing.Size(135, 22)
		Me._item25.Text = "25%"
		' 
		' _item10
		' 
		Me._item10.Name = "_item10"
		Me._item10.Size = New System.Drawing.Size(135, 22)
		Me._item10.Text = "10%"
		' 
		' _btnFirst
		' 
		Me._btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnFirst.Image = DirectCast(resources.GetObject("_btnFirst.Image"), System.Drawing.Image)
		Me._btnFirst.ImageTransparentColor = System.Drawing.Color.Red
		Me._btnFirst.Name = "_btnFirst"
		Me._btnFirst.Size = New System.Drawing.Size(23, 22)
		Me._btnFirst.Text = "First Page"
		AddHandler Me._btnFirst.Click, New System.EventHandler(AddressOf Me._btnFirst_Click)
		' 
		' _btnPrev
		' 
		Me._btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnPrev.Image = DirectCast(resources.GetObject("_btnPrev.Image"), System.Drawing.Image)
		Me._btnPrev.ImageTransparentColor = System.Drawing.Color.Red
		Me._btnPrev.Name = "_btnPrev"
		Me._btnPrev.Size = New System.Drawing.Size(23, 22)
		Me._btnPrev.Text = "Previous Page"
		AddHandler Me._btnPrev.Click, New System.EventHandler(AddressOf Me._btnPrev_Click)
		' 
		' _txtStartPage
		' 
		Me._txtStartPage.AutoSize = False
		Me._txtStartPage.Name = "_txtStartPage"
		Me._txtStartPage.Size = New System.Drawing.Size(30, 23)
		Me._txtStartPage.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
		AddHandler Me._txtStartPage.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me._txtStartPage_Validating)
		AddHandler Me._txtStartPage.Enter, New System.EventHandler(AddressOf Me._txtStartPage_Enter)
		AddHandler Me._txtStartPage.KeyPress, New System.Windows.Forms.KeyPressEventHandler(AddressOf Me._txtStartPage_KeyPress)
		' 
		' _lblPageCount
		' 
		Me._lblPageCount.Name = "_lblPageCount"
		Me._lblPageCount.Size = New System.Drawing.Size(10, 22)
		Me._lblPageCount.Text = " "
		' 
		' _btnNext
		' 
		Me._btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnNext.Image = DirectCast(resources.GetObject("_btnNext.Image"), System.Drawing.Image)
		Me._btnNext.ImageTransparentColor = System.Drawing.Color.Red
		Me._btnNext.Name = "_btnNext"
		Me._btnNext.Size = New System.Drawing.Size(23, 22)
		Me._btnNext.Text = "Next Page"
		AddHandler Me._btnNext.Click, New System.EventHandler(AddressOf Me._btnNext_Click)
		' 
		' _btnLast
		' 
		Me._btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnLast.Image = DirectCast(resources.GetObject("_btnLast.Image"), System.Drawing.Image)
		Me._btnLast.ImageTransparentColor = System.Drawing.Color.Red
		Me._btnLast.Name = "_btnLast"
		Me._btnLast.Size = New System.Drawing.Size(23, 22)
		Me._btnLast.Text = "Last Page"
		AddHandler Me._btnLast.Click, New System.EventHandler(AddressOf Me._btnLast_Click)
		' 
		' _separator
		' 
		Me._separator.Name = "_separator"
		Me._separator.Size = New System.Drawing.Size(6, 25)
		Me._separator.Visible = False
		' 
		' _btnCancel
		' 
		Me._btnCancel.AutoToolTip = False
		Me._btnCancel.Image = DirectCast(resources.GetObject("_btnCancel.Image"), System.Drawing.Image)
		Me._btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnCancel.Name = "_btnCancel"
		Me._btnCancel.Size = New System.Drawing.Size(63, 22)
		Me._btnCancel.Text = "Cancel"
		AddHandler Me._btnCancel.Click, New System.EventHandler(AddressOf Me._btnCancel_Click)
		' 
		' _preview
		' 
		Me._preview.AutoScroll = True
		Me._preview.Dock = System.Windows.Forms.DockStyle.Fill
		Me._preview.Document = Nothing
		Me._preview.Location = New System.Drawing.Point(0, 25)
		Me._preview.Name = "_preview"
		Me._preview.Size = New System.Drawing.Size(400, 329)
		Me._preview.TabIndex = 1
		AddHandler Me._preview.PageCountChanged, New System.EventHandler(AddressOf Me._preview_PageCountChanged)
		AddHandler Me._preview.StartPageChanged, New System.EventHandler(AddressOf Me._preview_StartPageChanged)
		' 
		' _btnCreatePdf
		' 
		Me._btnCreatePdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me._btnCreatePdf.Image = DirectCast(resources.GetObject("_btnCreatePdf.Image"), System.Drawing.Image)
		Me._btnCreatePdf.ImageTransparentColor = System.Drawing.Color.Magenta
		Me._btnCreatePdf.Name = "_btnCreatePdf"
		Me._btnCreatePdf.Size = New System.Drawing.Size(23, 22)
		Me._btnCreatePdf.Text = "Export to PDF"
		AddHandler Me._btnCreatePdf.Click, New System.EventHandler(AddressOf Me._btnCreatePdf_Click)
		' 
		' CoolPrintPreviewDialog
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(400, 354)
		Me.Controls.Add(Me._preview)
		Me.Controls.Add(Me._toolStrip)
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

	#End Region

	Private _toolStrip As System.Windows.Forms.ToolStrip
	Private _btnPrint As System.Windows.Forms.ToolStripButton
	Private _btnPageSetup As System.Windows.Forms.ToolStripButton
	Private _preview As CoolPrintPreviewControl
	Private _btnZoom As System.Windows.Forms.ToolStripSplitButton
	Private _itemActualSize As System.Windows.Forms.ToolStripMenuItem
	Private _itemFullPage As System.Windows.Forms.ToolStripMenuItem
	Private _itemPageWidth As System.Windows.Forms.ToolStripMenuItem
	Private _itemTwoPages As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
	Private _item500 As System.Windows.Forms.ToolStripMenuItem
	Private _item200 As System.Windows.Forms.ToolStripMenuItem
	Private _item150 As System.Windows.Forms.ToolStripMenuItem
	Private _item100 As System.Windows.Forms.ToolStripMenuItem
	Private _item75 As System.Windows.Forms.ToolStripMenuItem
	Private _item50 As System.Windows.Forms.ToolStripMenuItem
	Private _item25 As System.Windows.Forms.ToolStripMenuItem
	Private _item10 As System.Windows.Forms.ToolStripMenuItem
	Private _btnFirst As System.Windows.Forms.ToolStripButton
	Private _btnPrev As System.Windows.Forms.ToolStripButton
	Private _txtStartPage As System.Windows.Forms.ToolStripTextBox
	Private _lblPageCount As System.Windows.Forms.ToolStripLabel
	Private _btnNext As System.Windows.Forms.ToolStripButton
	Private _btnLast As System.Windows.Forms.ToolStripButton
	Private _separator As System.Windows.Forms.ToolStripSeparator
	Private _btnCancel As System.Windows.Forms.ToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private _btnCreatePdf As System.Windows.Forms.ToolStripButton
	Private _pdf As C1.C1Pdf.C1PdfDocument
End Class
