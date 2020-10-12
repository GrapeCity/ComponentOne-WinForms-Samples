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
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.toolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
		Me.panel1 = New System.Windows.Forms.Panel()
        Me.c1C1Editor1 = New C1.Win.C1Editor.C1Editor()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.checkBox3 = New System.Windows.Forms.CheckBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.checkBox2 = New System.Windows.Forms.CheckBox()
        Me.checkBox1 = New System.Windows.Forms.CheckBox()
        Me.c1EditorToolStripMain1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain()
        Me.c1EditorToolStripStyle1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle()
        Me.c1EditorToolStripObjects1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects()
        Me.c1EditorToolStripTable1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable()
        Me.toolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.toolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.c1C1EditorToolStripButton1 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton()
        Me.c1C1EditorToolStripButton2 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton()
        Me.c1C1EditorToolStripButton3 = New C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripContainer1.ContentPanel.SuspendLayout()
        Me.toolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.toolStripContainer1.SuspendLayout()
        Me.panel1.SuspendLayout()
        DirectCast((Me.c1C1Editor1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel2.SuspendLayout()
        Me.toolStrip2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' toolStripContainer1
        ' 
        Me.toolStripContainer1.BottomToolStripPanelVisible = False
        ' 
        ' toolStripContainer1.ContentPanel
        ' 
        Me.toolStripContainer1.ContentPanel.Controls.Add(Me.panel1)
        Me.toolStripContainer1.ContentPanel.Size = New System.Drawing.Size(586, 415)
        Me.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.toolStripContainer1.Name = "toolStripContainer1"
        Me.toolStripContainer1.RightToolStripPanelVisible = False
        Me.toolStripContainer1.Size = New System.Drawing.Size(586, 515)
        Me.toolStripContainer1.TabIndex = 2
        Me.toolStripContainer1.Text = "toolStripContainer1"
        ' 
        ' toolStripContainer1.TopToolStripPanel
        ' 
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.c1EditorToolStripStyle1)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.c1EditorToolStripMain1)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.c1EditorToolStripObjects1)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolStrip2)
        Me.toolStripContainer1.TopToolStripPanel.Controls.Add(Me.c1EditorToolStripTable1)
        ' 
        ' panel1
        ' 
        Me.panel1.Controls.Add(Me.c1C1Editor1)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(586, 415)
        Me.panel1.TabIndex = 0
        ' 
        ' c1C1Editor1
        ' 
        Me.c1C1Editor1.AllowDrop = False
        Me.c1C1Editor1.BackColor = System.Drawing.SystemColors.Window
        Me.c1C1Editor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1C1Editor1.Location = New System.Drawing.Point(0, 0)
        Me.c1C1Editor1.Name = "c1C1Editor1"
        Me.c1C1Editor1.Size = New System.Drawing.Size(586, 333)
        Me.c1C1Editor1.TabIndex = 3
        Me.c1C1Editor1.XmlExtensions = Nothing
        ' 
        ' panel2
        ' 
        Me.panel2.Controls.Add(Me.checkBox3)
        Me.panel2.Controls.Add(Me.label1)
        Me.panel2.Controls.Add(Me.checkBox2)
        Me.panel2.Controls.Add(Me.checkBox1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Location = New System.Drawing.Point(0, 333)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(586, 82)
        Me.panel2.TabIndex = 2
        ' 
        ' checkBox3
        ' 
        Me.checkBox3.AutoSize = True
        Me.checkBox3.Location = New System.Drawing.Point(66, 52)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(104, 17)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "Custom Toolstrip"
        Me.checkBox3.UseVisualStyleBackColor = True
        AddHandler Me.checkBox3.CheckedChanged, New System.EventHandler(AddressOf Me.checkBox1_CheckedChanged)
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 10)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(37, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "Show:"
        ' 
        ' checkBox2
        ' 
        Me.checkBox2.AutoSize = True
        Me.checkBox2.Location = New System.Drawing.Point(66, 29)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(205, 17)
        Me.checkBox2.TabIndex = 1
        Me.checkBox2.Text = "MS Toolstrip with C1Editor buttons"
        Me.checkBox2.UseVisualStyleBackColor = True
        AddHandler Me.checkBox2.CheckedChanged, New System.EventHandler(AddressOf Me.checkBox1_CheckedChanged)
        ' 
        ' checkBox1
        ' 
        Me.checkBox1.AutoSize = True
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.Location = New System.Drawing.Point(66, 6)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(133, 17)
        Me.checkBox1.TabIndex = 0
        Me.checkBox1.Text = "C1Editor ToolStrips"
        Me.checkBox1.UseVisualStyleBackColor = True
        AddHandler Me.checkBox1.CheckedChanged, New System.EventHandler(AddressOf Me.checkBox1_CheckedChanged)
        ' 
        ' c1EditorToolStripMain1
        ' 
        Me.c1EditorToolStripMain1.Dock = System.Windows.Forms.DockStyle.None
        Me.c1EditorToolStripMain1.Editor = Me.c1C1Editor1
        Me.c1EditorToolStripMain1.Location = New System.Drawing.Point(3, 25)
        Me.c1EditorToolStripMain1.Name = "c1EditorToolStripMain1"
        Me.c1EditorToolStripMain1.Size = New System.Drawing.Size(379, 25)
        Me.c1EditorToolStripMain1.TabIndex = 5
        Me.c1EditorToolStripMain1.Text = "c1EditorToolStripMain1"
        ' 
        ' c1EditorToolStripStyle1
        ' 
        Me.c1EditorToolStripStyle1.Dock = System.Windows.Forms.DockStyle.None
        Me.c1EditorToolStripStyle1.Editor = Me.c1C1Editor1
        Me.c1EditorToolStripStyle1.Location = New System.Drawing.Point(8, 0)
        Me.c1EditorToolStripStyle1.Name = "c1EditorToolStripStyle1"
        Me.c1EditorToolStripStyle1.Size = New System.Drawing.Size(479, 25)
        Me.c1EditorToolStripStyle1.TabIndex = 7
        Me.c1EditorToolStripStyle1.Text = "c1EditorToolStripStyle1"
        ' 
        ' c1EditorToolStripObjects1
        ' 
        Me.c1EditorToolStripObjects1.Dock = System.Windows.Forms.DockStyle.None
        Me.c1EditorToolStripObjects1.Editor = Me.c1C1Editor1
        Me.c1EditorToolStripObjects1.Location = New System.Drawing.Point(177, 50)
        Me.c1EditorToolStripObjects1.Name = "c1EditorToolStripObjects1"
        Me.c1EditorToolStripObjects1.Size = New System.Drawing.Size(125, 25)
        Me.c1EditorToolStripObjects1.TabIndex = 8
        Me.c1EditorToolStripObjects1.Text = "c1EditorToolStripObjects1"
        ' 
        ' c1EditorToolStripTable1
        ' 
        Me.c1EditorToolStripTable1.Dock = System.Windows.Forms.DockStyle.None
        Me.c1EditorToolStripTable1.Editor = Me.c1C1Editor1
        Me.c1EditorToolStripTable1.Location = New System.Drawing.Point(3, 75)
        Me.c1EditorToolStripTable1.Name = "c1EditorToolStripTable1"
        Me.c1EditorToolStripTable1.Size = New System.Drawing.Size(286, 25)
        Me.c1EditorToolStripTable1.TabIndex = 6
        Me.c1EditorToolStripTable1.Text = "c1EditorToolStripTable1"
        ' 
        ' toolStrip2
        ' 
        Me.toolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.toolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripLabel2, Me.c1C1EditorToolStripButton1, Me.c1C1EditorToolStripButton2, Me.c1C1EditorToolStripButton3, Me.toolStripSeparator2, Me.toolStripButton2})
        Me.toolStrip2.Location = New System.Drawing.Point(3, 50)
        Me.toolStrip2.Name = "toolStrip2"
        Me.toolStrip2.Size = New System.Drawing.Size(174, 25)
        Me.toolStrip2.TabIndex = 9
        ' 
        ' toolStripLabel2
        ' 
        Me.toolStripLabel2.Name = "toolStripLabel2"
        Me.toolStripLabel2.Size = New System.Drawing.Size(66, 22)
        Me.toolStripLabel2.Text = "MS ToolStrip"
        ' 
        ' c1C1EditorToolStripButton1
        ' 
        Me.c1C1EditorToolStripButton1.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Cut
        Me.c1C1EditorToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.c1C1EditorToolStripButton1.Editor = Me.c1C1Editor1
        Me.c1C1EditorToolStripButton1.Enabled = False
        Me.c1C1EditorToolStripButton1.Image = DirectCast((resources.GetObject("c1C1EditorToolStripButton1.Image")), System.Drawing.Image)
        Me.c1C1EditorToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.c1C1EditorToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.c1C1EditorToolStripButton1.Name = "c1C1EditorToolStripButton1"
        Me.c1C1EditorToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.c1C1EditorToolStripButton1.Text = "Cut"
        Me.c1C1EditorToolStripButton1.ToolTipText = "Cut (Ctrl+X)"
        ' 
        ' c1C1EditorToolStripButton2
        ' 
        Me.c1C1EditorToolStripButton2.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Copy
        Me.c1C1EditorToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.c1C1EditorToolStripButton2.Editor = Me.c1C1Editor1
        Me.c1C1EditorToolStripButton2.Enabled = False
        Me.c1C1EditorToolStripButton2.Image = DirectCast((resources.GetObject("c1C1EditorToolStripButton2.Image")), System.Drawing.Image)
        Me.c1C1EditorToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.c1C1EditorToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.c1C1EditorToolStripButton2.Name = "c1C1EditorToolStripButton2"
        Me.c1C1EditorToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.c1C1EditorToolStripButton2.Text = "Copy"
        Me.c1C1EditorToolStripButton2.ToolTipText = "Copy (Ctrl+C)"
        ' 
        ' c1C1EditorToolStripButton3
        ' 
        Me.c1C1EditorToolStripButton3.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Paste
        Me.c1C1EditorToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.c1C1EditorToolStripButton3.Editor = Me.c1C1Editor1
        Me.c1C1EditorToolStripButton3.Enabled = False
        Me.c1C1EditorToolStripButton3.Image = DirectCast((resources.GetObject("c1C1EditorToolStripButton3.Image")), System.Drawing.Image)
        Me.c1C1EditorToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.c1C1EditorToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.c1C1EditorToolStripButton3.Name = "c1C1EditorToolStripButton3"
        Me.c1C1EditorToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.c1C1EditorToolStripButton3.Text = "Paste"
        Me.c1C1EditorToolStripButton3.ToolTipText = "Paste (Ctrl+V)"
        ' 
        ' toolStripSeparator2
        ' 
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        ' 
        ' toolStripButton2
        ' 
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.toolStripButton2.Image = DirectCast((resources.GetObject("toolStripButton2.Image")), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.toolStripButton2.Text = "Word count"
        Me.toolStripButton2.ToolTipText = "Word count"
        AddHandler Me.toolStripButton2.Click, New System.EventHandler(AddressOf Me.toolStripButton1_Click)
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 515)
        Me.Controls.Add(Me.toolStripContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
        Me.toolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.toolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.toolStripContainer1.ResumeLayout(False)
        Me.toolStripContainer1.PerformLayout()
        Me.panel1.ResumeLayout(False)
        DirectCast((Me.c1C1Editor1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        Me.toolStrip2.ResumeLayout(False)
        Me.toolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private toolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Private c1EditorToolStripObjects1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects
    Private c1EditorToolStripStyle1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle
    Private c1EditorToolStripTable1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable
    Private c1EditorToolStripMain1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain
    Private panel1 As System.Windows.Forms.Panel
    Private c1C1Editor1 As C1.Win.C1Editor.C1Editor
    Private panel2 As System.Windows.Forms.Panel
    Private label1 As System.Windows.Forms.Label
    Private checkBox2 As System.Windows.Forms.CheckBox
    Private checkBox1 As System.Windows.Forms.CheckBox
    Private checkBox3 As System.Windows.Forms.CheckBox
    Private toolStrip2 As System.Windows.Forms.ToolStrip
    Private toolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Private c1C1EditorToolStripButton1 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton
    Private c1C1EditorToolStripButton2 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton
    Private c1C1EditorToolStripButton3 As C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton
	Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
	Private toolStripButton2 As System.Windows.Forms.ToolStripButton
End Class

