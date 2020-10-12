Partial Class Form1
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c1Editor1 = New C1.Win.C1Editor.C1Editor()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me._lblDesign = New System.Windows.Forms.ToolStripStatusLabel()
        Me._lblPreview = New System.Windows.Forms.ToolStripStatusLabel()
        Me._lblSource = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.mainToolStrip = New C1EditorQuickStart.ToolStrips.ToolStripMain()
        Me.c1SpellChecker1 = New C1.Win.C1SpellChecker.C1SpellChecker(Me.components)
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.searchAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.searchAndReplaceDocToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectXmlNodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.styleToolStrip = New C1EditorQuickStart.ToolStrips.ToolStripStyles()
        Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.selectParagraphToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip1.SuspendLayout()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        DirectCast((Me.c1SpellChecker1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' c1Editor1
        ' 
        Me.c1Editor1.BackColor = System.Drawing.SystemColors.Window
        Me.c1Editor1.XmlExtensions = Nothing
        Me.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Editor1.Location = New System.Drawing.Point(0, 0)
        Me.c1Editor1.Margin = New System.Windows.Forms.Padding(5)
        Me.c1Editor1.Name = "c1Editor1"
        Me.c1Editor1.WordWrap = True
        Me.c1Editor1.Size = New System.Drawing.Size(675, 384)
        Me.c1Editor1.TabIndex = 0
        ' 
        ' statusStrip1
        ' 
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._lblDesign, Me._lblPreview, Me._lblSource})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 384)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(675, 23)
        Me.statusStrip1.TabIndex = 2
        Me.statusStrip1.Text = "statusStrip1"
        ' 
        ' _lblDesign
        ' 
        Me._lblDesign.BackColor = System.Drawing.Color.Orange
        Me._lblDesign.Image = DirectCast((resources.GetObject("_lblDesign.Image")), System.Drawing.Image)
        Me._lblDesign.Name = "_lblDesign"
        Me._lblDesign.Size = New System.Drawing.Size(67, 18)
        Me._lblDesign.Text = "Design"
        AddHandler Me._lblDesign.Click, New System.EventHandler(AddressOf Me._lblDesign_Click)
        ' 
        ' _lblPreview
        ' 
        Me._lblPreview.Image = C1EditorQuickStart.Resources.SplitMode_small
        Me._lblPreview.Name = "_lblPreview"
        Me._lblPreview.Size = New System.Drawing.Size(49, 18)
        Me._lblPreview.Text = "Preview"
        AddHandler Me._lblPreview.Click, New System.EventHandler(AddressOf Me._lblDesign_Click)
        ' 
        ' _lblSource
        ' 
        Me._lblSource.Image = C1EditorQuickStart.Resources.SourceMode_small
        Me._lblSource.Name = "_lblSource"
        Me._lblSource.Size = New System.Drawing.Size(68, 18)
        Me._lblSource.Text = "Source"
        AddHandler Me._lblSource.Click, New System.EventHandler(AddressOf Me._lblDesign_Click)
        ' 
        ' toolStripContainer1
        ' 
        ' 
        ' toolStripContainer1.ContentPanel
        ' 
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.c1Editor1)
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.statusStrip1)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(675, 407)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.Size = New System.Drawing.Size(675, 457)
        Me.toolStripContainer1.TabIndex = 3
        Me.toolStripContainer1.Text = "toolStripContainer1"
        ' 
        ' toolStripContainer1.TopToolStripPanel
        ' 
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.mainToolStrip)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip1)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.styleToolStrip)
        ' 
        ' mainToolStrip
        ' 
        Me.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.mainToolStrip.Editor = Me.c1Editor1
        Me.mainToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.mainToolStrip.Name = "mainToolStrip"
        Me.mainToolStrip.Size = New System.Drawing.Size(393, 25)
        Me.mainToolStrip.SpellChecker = Me.c1SpellChecker1
        Me.mainToolStrip.TabIndex = 2
        ' 
        ' toolStrip1
        ' 
        Me.toolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripDropDownButton1})
        Me.toolStrip1.Location = New System.Drawing.Point(3, 25)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(115, 25)
        Me.toolStrip1.TabIndex = 4
        ' 
        ' toolStripDropDownButton1
        ' 
        Me.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectParagraphToolStripMenuItem, Me.selectXmlNodeToolStripMenuItem, Me.toolStripMenuItem1, Me.searchAndReplaceToolStripMenuItem, Me.searchAndReplaceDocToolStripMenuItem})
        Me.toolStripDropDownButton1.Image = DirectCast((resources.GetObject("toolStripDropDownButton1.Image")), System.Drawing.Image)
        Me.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripDropDownButton1.Name = "toolStripDropDownButton1"
        Me.toolStripDropDownButton1.Size = New System.Drawing.Size(72, 22)
        Me.toolStripDropDownButton1.Text = "How To"
        ' 
        ' searchAndReplaceToolStripMenuItem
        ' 
        Me.searchAndReplaceToolStripMenuItem.Name = "searchAndReplaceToolStripMenuItem"
        Me.searchAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.searchAndReplaceToolStripMenuItem.Text = "Search and Replace (using selection)"
        AddHandler Me.searchAndReplaceToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.replaceUsingSelection_Click)
        ' 
        ' searchAndReplaceDocToolStripMenuItem
        ' 
        Me.searchAndReplaceDocToolStripMenuItem.Name = "searchAndReplaceDocToolStripMenuItem"
        Me.searchAndReplaceDocToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.searchAndReplaceDocToolStripMenuItem.Text = "Search and Replace (using XmlDocument)"
        AddHandler Me.searchAndReplaceDocToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.replaceUsingXmlDocument)
        ' 
        ' selectXmlNodeToolStripMenuItem
        ' 
        Me.selectXmlNodeToolStripMenuItem.Name = "selectXmlNodeToolStripMenuItem"
        Me.selectXmlNodeToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.selectXmlNodeToolStripMenuItem.Text = "Select Xml Node"
        AddHandler Me.selectXmlNodeToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.selectXmlNode_Click)
        ' 
        ' styleToolStrip
        ' 
        Me.styleToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.styleToolStrip.Editor = Me.c1Editor1
        Me.styleToolStrip.Location = New System.Drawing.Point(118, 25)
        Me.styleToolStrip.Name = "styleToolStrip"
        Me.styleToolStrip.Size = New System.Drawing.Size(262, 25)
        Me.styleToolStrip.TabIndex = 3
        ' 
        ' toolStripMenuItem1
        ' 
        Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
        Me.toolStripMenuItem1.Size = New System.Drawing.Size(347, 6)
        ' 
        ' selectParagraphToolStripMenuItem
        ' 
        Me.selectParagraphToolStripMenuItem.Name = "selectParagraphToolStripMenuItem"
        Me.selectParagraphToolStripMenuItem.Size = New System.Drawing.Size(350, 22)
        Me.selectParagraphToolStripMenuItem.Text = "Select Paragraph"
        AddHandler Me.selectParagraphToolStripMenuItem.Click, New System.EventHandler(AddressOf Me.selectParagraph_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 16.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 457)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.ContentPanel.PerformLayout()
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        DirectCast((Me.c1SpellChecker1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private c1Editor1 As C1.Win.C1Editor.C1Editor
    Private statusStrip1 As System.Windows.Forms.StatusStrip
    Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Private mainToolStrip As C1EditorQuickStart.ToolStrips.ToolStripMain
    Private c1SpellChecker1 As C1.Win.C1SpellChecker.C1SpellChecker
    Private styleToolStrip As C1EditorQuickStart.ToolStrips.ToolStripStyles
    Private _lblDesign As System.Windows.Forms.ToolStripStatusLabel
    Private _lblPreview As System.Windows.Forms.ToolStripStatusLabel
	Private _lblSource As System.Windows.Forms.ToolStripStatusLabel
	Private toolStrip1 As System.Windows.Forms.ToolStrip
	Private toolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
	Private searchAndReplaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private selectXmlNodeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private searchAndReplaceDocToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private selectParagraphToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Private toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
End Class

