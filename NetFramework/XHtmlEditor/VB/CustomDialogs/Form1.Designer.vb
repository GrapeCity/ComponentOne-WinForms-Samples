Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary> 
	''' Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
	''' </summary>
	''' <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
	Protected Overloads Overrides Sub Dispose(disposing As Boolean)
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
		Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
		Me.tsFormatting = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsHyperlink = New System.Windows.Forms.ToolStripButton()
		Me.tsBookmark = New System.Windows.Forms.ToolStripButton()
		Me.tsPicture = New System.Windows.Forms.ToolStripButton()
		Me.tsFlash = New System.Windows.Forms.ToolStripButton()
		Me.tsTable = New System.Windows.Forms.ToolStripButton()
		Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.tsFind = New System.Windows.Forms.ToolStripButton()
		Me.tsReplace = New System.Windows.Forms.ToolStripButton()
        Me.editor = New C1.Win.C1Editor.C1Editor()
        Me.toolStrip1.SuspendLayout()
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' toolStrip1
        ' 
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFormatting, Me.toolStripSeparator1, Me.tsHyperlink, Me.tsBookmark, Me.tsPicture, Me.tsFlash, _
         Me.tsTable, Me.toolStripSeparator2, Me.tsFind, Me.tsReplace})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(751, 25)
        Me.toolStrip1.TabIndex = 0
        Me.toolStrip1.Text = "toolStrip1"
        AddHandler Me.toolStrip1.ItemClicked, New System.Windows.Forms.ToolStripItemClickedEventHandler(AddressOf Me.toolStrip1_ItemClicked)
        ' 
        ' tsFormatting
        ' 
        Me.tsFormatting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFormatting.Image = Resources.formatting
        Me.tsFormatting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFormatting.Name = "tsFormatting"
        Me.tsFormatting.Size = New System.Drawing.Size(23, 22)
        Me.tsFormatting.Text = "Text Formatting"
        ' 
        ' toolStripSeparator1
        ' 
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        ' 
        ' tsHyperlink
        ' 
        Me.tsHyperlink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsHyperlink.Image = Resources.hyperlink
        Me.tsHyperlink.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHyperlink.Name = "tsHyperlink"
        Me.tsHyperlink.Size = New System.Drawing.Size(23, 22)
        Me.tsHyperlink.Text = "Insert Hyperlink"
        ' 
        ' tsBookmark
        ' 
        Me.tsBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBookmark.Image = Resources.bookmark
        Me.tsBookmark.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBookmark.Name = "tsBookmark"
        Me.tsBookmark.Size = New System.Drawing.Size(23, 22)
        Me.tsBookmark.Text = "Insert Bookmark"
        ' 
        ' tsPicture
        ' 
        Me.tsPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsPicture.Image = Resources.picture
        Me.tsPicture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPicture.Name = "tsPicture"
        Me.tsPicture.Size = New System.Drawing.Size(23, 22)
        Me.tsPicture.Text = "Insert Picture From File"
        ' 
        ' tsFlash
        ' 
        Me.tsFlash.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFlash.Image = Resources.flash
        Me.tsFlash.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFlash.Name = "tsFlash"
        Me.tsFlash.Size = New System.Drawing.Size(23, 22)
        Me.tsFlash.Text = "Insert Movie in Flash Format"
        ' 
        ' tsTable
        ' 
        Me.tsTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsTable.Image = Resources.table
        Me.tsTable.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsTable.Name = "tsTable"
        Me.tsTable.Size = New System.Drawing.Size(23, 22)
        Me.tsTable.Text = "Insert Table"
        ' 
        ' toolStripSeparator2
        ' 
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        ' 
        ' tsFind
        ' 
        Me.tsFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFind.Image = Resources.find
        Me.tsFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFind.Name = "tsFind"
        Me.tsFind.Size = New System.Drawing.Size(23, 22)
        Me.tsFind.Text = "Find"
        ' 
        ' tsReplace
        ' 
        Me.tsReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsReplace.Image = Resources.replace
        Me.tsReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsReplace.Name = "tsReplace"
        Me.tsReplace.Size = New System.Drawing.Size(23, 22)
        Me.tsReplace.Text = "Replace"
        ' 
        ' editor
        ' 
        Me.editor.BackColor = System.Drawing.SystemColors.Window
        Me.editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editor.Location = New System.Drawing.Point(0, 25)
        Me.editor.Name = "editor"
        Me.editor.WordWrap = True
        Me.editor.Size = New System.Drawing.Size(751, 436)
        Me.editor.TabIndex = 1
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 461)
        Me.Controls.Add(Me.editor)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private toolStrip1 As System.Windows.Forms.ToolStrip
    Private tsFormatting As System.Windows.Forms.ToolStripButton
    Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private tsHyperlink As System.Windows.Forms.ToolStripButton
    Private tsBookmark As System.Windows.Forms.ToolStripButton
    Private tsPicture As System.Windows.Forms.ToolStripButton
    Private tsFlash As System.Windows.Forms.ToolStripButton
    Private tsTable As System.Windows.Forms.ToolStripButton
    Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private tsFind As System.Windows.Forms.ToolStripButton
    Private tsReplace As System.Windows.Forms.ToolStripButton
    Private editor As C1.Win.C1Editor.C1Editor

End Class
