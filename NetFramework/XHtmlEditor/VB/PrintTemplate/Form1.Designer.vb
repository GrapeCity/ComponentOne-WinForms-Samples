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
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button2 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.radioButtonTemplateSource = New System.Windows.Forms.RadioButton()
		Me.radioButtonPreview = New System.Windows.Forms.RadioButton()
		Me.radioButtonSource = New System.Windows.Forms.RadioButton()
		Me.radioButtonDesign = New System.Windows.Forms.RadioButton()
		Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.c1Editor1 = New C1.Win.C1Editor.C1Editor()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' panel1
        ' 
        Me.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Controls.Add(Me.comboBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(628, 51)
        Me.panel1.TabIndex = 0
        ' 
        ' label1
        ' 
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((204)))
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(132, 20)
        Me.label1.TabIndex = 1
        Me.label1.Text = "Printing Template"
        ' 
        ' comboBox1
        ' 
        Me.comboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Template1.htm: A Minimal Template (Print Preview Only)", "Template2.htm: Minimal Template Supporting Printing", "Template3.htm: Dynamic Creation of LayoutRects (Preview Only)", "Template4.htm: Adding Headers and Footers 1 (Preview Only)", "Template5.htm: Adding Headers and Footers 2 (Preview Only)", "Template6.htm: Reading from Page Setup/Synchronizing Threads", _
         "Template7.htm: Building a User Interface", "Template8.htm: Adjustable Margin UI"})
        Me.comboBox1.Location = New System.Drawing.Point(200, 13)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(416, 21)
        Me.comboBox1.TabIndex = 0
        AddHandler Me.comboBox1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBox1_SelectedIndexChanged)
        ' 
        ' panel2
        ' 
        Me.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panel2.Controls.Add(Me.button3)
        Me.panel2.Controls.Add(Me.button2)
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel2.Location = New System.Drawing.Point(0, 51)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(200, 392)
        Me.panel2.TabIndex = 1
        ' 
        ' button3
        ' 
        Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button3.Location = New System.Drawing.Point(13, 93)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(168, 23)
        Me.button3.TabIndex = 2
        Me.button3.Text = "Print w/o Prompt"
        Me.button3.UseVisualStyleBackColor = True
        AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button3_Click)
        ' 
        ' button2
        ' 
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button2.Location = New System.Drawing.Point(13, 64)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(168, 23)
        Me.button2.TabIndex = 1
        Me.button2.Text = "Print with Prompt"
        Me.button2.UseVisualStyleBackColor = True
        AddHandler Me.button2.Click, New System.EventHandler(AddressOf Me.button2_Click)
        ' 
        ' button1
        ' 
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.button1.Location = New System.Drawing.Point(13, 23)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(168, 23)
        Me.button1.TabIndex = 0
        Me.button1.Text = "Print Preview"
        Me.button1.UseVisualStyleBackColor = True
        AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
        ' 
        ' panel3
        ' 
        Me.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.panel3.Controls.Add(Me.radioButtonTemplateSource)
        Me.panel3.Controls.Add(Me.radioButtonPreview)
        Me.panel3.Controls.Add(Me.radioButtonSource)
        Me.panel3.Controls.Add(Me.radioButtonDesign)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel3.Location = New System.Drawing.Point(200, 402)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(428, 41)
        Me.panel3.TabIndex = 2
        ' 
        ' radioButtonTemplateSource
        ' 
        Me.radioButtonTemplateSource.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioButtonTemplateSource.AutoSize = True
        Me.radioButtonTemplateSource.FlatAppearance.BorderSize = 0
        Me.radioButtonTemplateSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButtonTemplateSource.Location = New System.Drawing.Point(214, 7)
        Me.radioButtonTemplateSource.Name = "radioButtonTemplateSource"
        Me.radioButtonTemplateSource.Size = New System.Drawing.Size(98, 23)
        Me.radioButtonTemplateSource.TabIndex = 4
        Me.radioButtonTemplateSource.Text = "Template Source"
        Me.radioButtonTemplateSource.UseVisualStyleBackColor = True
        AddHandler Me.radioButtonTemplateSource.CheckedChanged, New System.EventHandler(AddressOf Me.radioButtonPreview_CheckedChanged)
        ' 
        ' radioButtonPreview
        ' 
        Me.radioButtonPreview.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioButtonPreview.AutoSize = True
        Me.radioButtonPreview.Checked = True
        Me.radioButtonPreview.FlatAppearance.BorderSize = 0
        Me.radioButtonPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButtonPreview.Location = New System.Drawing.Point(123, 7)
        Me.radioButtonPreview.Name = "radioButtonPreview"
        Me.radioButtonPreview.Size = New System.Drawing.Size(55, 23)
        Me.radioButtonPreview.TabIndex = 3
        Me.radioButtonPreview.TabStop = True
        Me.radioButtonPreview.Text = "Preview"
        Me.radioButtonPreview.UseVisualStyleBackColor = True
        AddHandler Me.radioButtonPreview.CheckedChanged, New System.EventHandler(AddressOf Me.radioButtonPreview_CheckedChanged)
        ' 
        ' radioButtonSource
        ' 
        Me.radioButtonSource.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioButtonSource.AutoSize = True
        Me.radioButtonSource.FlatAppearance.BorderSize = 0
        Me.radioButtonSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButtonSource.Location = New System.Drawing.Point(64, 7)
        Me.radioButtonSource.Name = "radioButtonSource"
        Me.radioButtonSource.Size = New System.Drawing.Size(51, 23)
        Me.radioButtonSource.TabIndex = 2
        Me.radioButtonSource.Text = "Source"
        Me.radioButtonSource.UseVisualStyleBackColor = True
        AddHandler Me.radioButtonSource.CheckedChanged, New System.EventHandler(AddressOf Me.radioButtonPreview_CheckedChanged)
        ' 
        ' radioButtonDesign
        ' 
        Me.radioButtonDesign.Appearance = System.Windows.Forms.Appearance.Button
        Me.radioButtonDesign.AutoSize = True
        Me.radioButtonDesign.FlatAppearance.BorderSize = 0
        Me.radioButtonDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.radioButtonDesign.Location = New System.Drawing.Point(6, 7)
        Me.radioButtonDesign.Name = "radioButtonDesign"
        Me.radioButtonDesign.Size = New System.Drawing.Size(50, 23)
        Me.radioButtonDesign.TabIndex = 1
        Me.radioButtonDesign.Text = "Design"
        Me.radioButtonDesign.UseVisualStyleBackColor = True
        AddHandler Me.radioButtonDesign.CheckedChanged, New System.EventHandler(AddressOf Me.radioButtonPreview_CheckedChanged)
        ' 
        ' richTextBox1
        ' 
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte((204)))
        Me.richTextBox1.Location = New System.Drawing.Point(200, 51)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.[ReadOnly] = True
        Me.richTextBox1.Size = New System.Drawing.Size(428, 351)
        Me.richTextBox1.TabIndex = 4
        Me.richTextBox1.Text = ""
        ' 
        ' c1Editor1
        ' 
        Me.c1Editor1.BackColor = System.Drawing.SystemColors.Window
        Me.c1Editor1.XmlExtensions = Nothing
        Me.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Editor1.Location = New System.Drawing.Point(200, 51)
        Me.c1Editor1.Name = "c1Editor1"
        Me.c1Editor1.WordWrap = True
        Me.c1Editor1.Size = New System.Drawing.Size(428, 351)
        Me.c1Editor1.TabIndex = 3
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 443)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.c1Editor1)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        DirectCast((Me.c1Editor1), System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private panel1 As System.Windows.Forms.Panel
    Private panel2 As System.Windows.Forms.Panel
    Private panel3 As System.Windows.Forms.Panel
    Private c1Editor1 As C1.Win.C1Editor.C1Editor
	Private radioButtonDesign As System.Windows.Forms.RadioButton
	Private radioButtonPreview As System.Windows.Forms.RadioButton
	Private radioButtonSource As System.Windows.Forms.RadioButton
	Private label1 As System.Windows.Forms.Label
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private button3 As System.Windows.Forms.Button
	Private button2 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
	Private radioButtonTemplateSource As System.Windows.Forms.RadioButton
	Private richTextBox1 As System.Windows.Forms.RichTextBox
End Class

