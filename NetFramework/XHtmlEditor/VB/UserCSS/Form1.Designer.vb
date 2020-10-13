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
		Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
		Me.tabControl1 = New System.Windows.Forms.TabControl()
		Me.tabPage1 = New System.Windows.Forms.TabPage()
		Me.tabPage2 = New System.Windows.Forms.TabPage()
        Me.editor = New C1.Win.C1Editor.C1Editor()
        Me.cssChooser1 = New UserCSS.Controls.CSSChooser()
        Me.cssChooser2 = New UserCSS.Controls.CSSChooser()
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPage1.SuspendLayout()
        Me.tabPage2.SuspendLayout()
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' splitContainer1
        ' 
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.splitContainer1.Name = "splitContainer1"
        ' 
        ' splitContainer1.Panel1
        ' 
        Me.splitContainer1.Panel1.Controls.Add(Me.editor)
        ' 
        ' splitContainer1.Panel2
        ' 
        Me.splitContainer1.Panel2.Controls.Add(Me.tabControl1)
        Me.splitContainer1.Size = New System.Drawing.Size(934, 472)
        Me.splitContainer1.SplitterDistance = 654
        Me.splitContainer1.TabIndex = 0
        ' 
        ' tabControl1
        ' 
        Me.tabControl1.Controls.Add(Me.tabPage1)
        Me.tabControl1.Controls.Add(Me.tabPage2)
        Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl1.Location = New System.Drawing.Point(0, 0)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(276, 472)
        Me.tabControl1.TabIndex = 0
        AddHandler Me.tabControl1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.tabControl1_SelectedIndexChanged)
        ' 
        ' tabPage1
        ' 
        Me.tabPage1.Controls.Add(Me.cssChooser1)
        Me.tabPage1.Location = New System.Drawing.Point(4, 22)
        Me.tabPage1.Name = "tabPage1"
        Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage1.Size = New System.Drawing.Size(268, 446)
        Me.tabPage1.TabIndex = 0
        Me.tabPage1.Text = "Design"
        Me.tabPage1.UseVisualStyleBackColor = True
        ' 
        ' tabPage2
        ' 
        Me.tabPage2.Controls.Add(Me.cssChooser2)
        Me.tabPage2.Location = New System.Drawing.Point(4, 22)
        Me.tabPage2.Name = "tabPage2"
        Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPage2.Size = New System.Drawing.Size(268, 446)
        Me.tabPage2.TabIndex = 1
        Me.tabPage2.Text = "Preview"
        Me.tabPage2.UseVisualStyleBackColor = True
        ' 
        ' editor
        ' 
        Me.editor.BackColor = System.Drawing.SystemColors.Window
        Me.editor.XmlExtensions = Nothing
        Me.editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editor.Location = New System.Drawing.Point(0, 0)
        Me.editor.Name = "editor"
        Me.editor.WordWrap = True
        Me.editor.Size = New System.Drawing.Size(654, 472)
        Me.editor.TabIndex = 0
        ' 
        ' cssChooser1
        ' 
        Me.cssChooser1.CSSMode = UserCSS.Controls.CSSChooser.Mode.Design
        Me.cssChooser1.Editor = Me.editor
        Me.cssChooser1.Location = New System.Drawing.Point(6, 6)
        Me.cssChooser1.Name = "cssChooser1"
        Me.cssChooser1.Size = New System.Drawing.Size(259, 434)
        Me.cssChooser1.TabIndex = 0
        ' 
        ' cssChooser2
        ' 
        Me.cssChooser2.CSSMode = UserCSS.Controls.CSSChooser.Mode.Preview
        Me.cssChooser2.Editor = Me.editor
        Me.cssChooser2.Location = New System.Drawing.Point(6, 6)
        Me.cssChooser2.Name = "cssChooser2"
        Me.cssChooser2.Size = New System.Drawing.Size(259, 434)
        Me.cssChooser2.TabIndex = 1
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 472)
        Me.Controls.Add(Me.splitContainer1)
        Me.Name = "Form1"
        Me.Text = "User CSS"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.tabControl1.ResumeLayout(False)
        Me.tabPage1.ResumeLayout(False)
        Me.tabPage2.ResumeLayout(False)
        DirectCast((Me.editor), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private splitContainer1 As System.Windows.Forms.SplitContainer
    Private editor As C1.Win.C1Editor.C1Editor
	Private tabControl1 As System.Windows.Forms.TabControl
	Private tabPage1 As System.Windows.Forms.TabPage
	Private tabPage2 As System.Windows.Forms.TabPage
	Private cssChooser1 As UserCSS.Controls.CSSChooser
	Private cssChooser2 As UserCSS.Controls.CSSChooser
End Class
