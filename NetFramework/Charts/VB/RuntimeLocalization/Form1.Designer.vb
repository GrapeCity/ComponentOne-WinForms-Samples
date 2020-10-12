<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.c1Chart1 = New C1.Win.C1Chart.C1Chart
		Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.checkBox2 = New System.Windows.Forms.CheckBox
		Me.checkBox1 = New System.Windows.Forms.CheckBox
		Me.groupBox2 = New System.Windows.Forms.GroupBox
		Me.radioButton4 = New System.Windows.Forms.RadioButton
		Me.radioButton3 = New System.Windows.Forms.RadioButton
		Me.radioButton2 = New System.Windows.Forms.RadioButton
		Me.radioButton1 = New System.Windows.Forms.RadioButton
		Me.btnAddPrefix = New System.Windows.Forms.Button
		Me.btnReset = New System.Windows.Forms.Button
		Me.btnShowLocalizations = New System.Windows.Forms.Button
		Me.label1 = New System.Windows.Forms.Label
		Me.textBox1 = New System.Windows.Forms.TextBox
		Me.btnShowPropGrids = New System.Windows.Forms.Button
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox1.SuspendLayout()
		Me.groupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'c1Chart1
		'
		Me.c1Chart1.Location = New System.Drawing.Point(8, 198)
		Me.c1Chart1.Name = "c1Chart1"
		Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
		Me.c1Chart1.Size = New System.Drawing.Size(271, 259)
		Me.c1Chart1.TabIndex = 0
		'
		'c1Chart3D1
		'
		Me.c1Chart3D1.Location = New System.Drawing.Point(294, 198)
		Me.c1Chart3D1.Name = "c1Chart3D1"
		Me.c1Chart3D1.PropBag = resources.GetString("c1Chart3D1.PropBag")
		Me.c1Chart3D1.Size = New System.Drawing.Size(274, 259)
		Me.c1Chart3D1.TabIndex = 1
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.checkBox2)
		Me.groupBox1.Controls.Add(Me.checkBox1)
		Me.groupBox1.Location = New System.Drawing.Point(8, 479)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(271, 86)
		Me.groupBox1.TabIndex = 3
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Select Charts for Operations"
		'
		'checkBox2
		'
		Me.checkBox2.AutoSize = True
		Me.checkBox2.Location = New System.Drawing.Point(94, 51)
		Me.checkBox2.Name = "checkBox2"
		Me.checkBox2.Size = New System.Drawing.Size(68, 17)
		Me.checkBox2.TabIndex = 1
		Me.checkBox2.Text = "Chart 3D"
		Me.checkBox2.UseVisualStyleBackColor = True
		'
		'checkBox1
		'
		Me.checkBox1.AutoSize = True
		Me.checkBox1.Checked = True
		Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBox1.Location = New System.Drawing.Point(94, 28)
		Me.checkBox1.Name = "checkBox1"
		Me.checkBox1.Size = New System.Drawing.Size(68, 17)
		Me.checkBox1.TabIndex = 0
		Me.checkBox1.Text = "Chart 2D"
		Me.checkBox1.UseVisualStyleBackColor = True
		'
		'groupBox2
		'
		Me.groupBox2.Controls.Add(Me.radioButton4)
		Me.groupBox2.Controls.Add(Me.radioButton3)
		Me.groupBox2.Controls.Add(Me.radioButton2)
		Me.groupBox2.Controls.Add(Me.radioButton1)
		Me.groupBox2.Location = New System.Drawing.Point(294, 479)
		Me.groupBox2.Name = "groupBox2"
		Me.groupBox2.Size = New System.Drawing.Size(274, 85)
		Me.groupBox2.TabIndex = 4
		Me.groupBox2.TabStop = False
		Me.groupBox2.Text = "Select Prefix String"
		'
		'radioButton4
		'
		Me.radioButton4.AutoSize = True
		Me.radioButton4.Location = New System.Drawing.Point(169, 51)
		Me.radioButton4.Name = "radioButton4"
		Me.radioButton4.Size = New System.Drawing.Size(47, 17)
		Me.radioButton4.TabIndex = 3
		Me.radioButton4.TabStop = True
		Me.radioButton4.Text = """dd"""
		Me.radioButton4.UseVisualStyleBackColor = True
		'
		'radioButton3
		'
		Me.radioButton3.AutoSize = True
		Me.radioButton3.Location = New System.Drawing.Point(169, 24)
		Me.radioButton3.Name = "radioButton3"
		Me.radioButton3.Size = New System.Drawing.Size(47, 17)
		Me.radioButton3.TabIndex = 2
		Me.radioButton3.TabStop = True
		Me.radioButton3.Text = """cc"""
		Me.radioButton3.UseVisualStyleBackColor = True
		'
		'radioButton2
		'
		Me.radioButton2.AutoSize = True
		Me.radioButton2.Location = New System.Drawing.Point(48, 51)
		Me.radioButton2.Name = "radioButton2"
		Me.radioButton2.Size = New System.Drawing.Size(47, 17)
		Me.radioButton2.TabIndex = 1
		Me.radioButton2.TabStop = True
		Me.radioButton2.Text = """bb"""
		Me.radioButton2.UseVisualStyleBackColor = True
		'
		'radioButton1
		'
		Me.radioButton1.AutoSize = True
		Me.radioButton1.Checked = True
		Me.radioButton1.Location = New System.Drawing.Point(48, 24)
		Me.radioButton1.Name = "radioButton1"
		Me.radioButton1.Size = New System.Drawing.Size(47, 17)
		Me.radioButton1.TabIndex = 0
		Me.radioButton1.TabStop = True
		Me.radioButton1.Text = """aa"""
		Me.radioButton1.UseVisualStyleBackColor = True
		'
		'btnAddPrefix
		'
		Me.btnAddPrefix.Location = New System.Drawing.Point(8, 585)
		Me.btnAddPrefix.Name = "btnAddPrefix"
		Me.btnAddPrefix.Size = New System.Drawing.Size(134, 38)
		Me.btnAddPrefix.TabIndex = 5
		Me.btnAddPrefix.Text = "Add Selected Prefix"
		Me.btnAddPrefix.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.Location = New System.Drawing.Point(145, 585)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(134, 38)
		Me.btnReset.TabIndex = 6
		Me.btnReset.Text = "Reset Localization"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'btnShowLocalizations
		'
		Me.btnShowLocalizations.Location = New System.Drawing.Point(294, 585)
		Me.btnShowLocalizations.Name = "btnShowLocalizations"
		Me.btnShowLocalizations.Size = New System.Drawing.Size(134, 38)
		Me.btnShowLocalizations.TabIndex = 7
		Me.btnShowLocalizations.Text = "Show Localizations"
		Me.btnShowLocalizations.UseVisualStyleBackColor = True
		'
		'label1
		'
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(119, 175)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(338, 20)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Click a chart to show its properties dialog"
		'
		'textBox1
		'
		Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.textBox1.Location = New System.Drawing.Point(12, 23)
		Me.textBox1.Multiline = True
		Me.textBox1.Name = "textBox1"
		Me.textBox1.ReadOnly = True
		Me.textBox1.Size = New System.Drawing.Size(563, 123)
		Me.textBox1.TabIndex = 8
		Me.textBox1.Text = resources.GetString("textBox1.Text")
		'
		'btnShowPropGrids
		'
		Me.btnShowPropGrids.Location = New System.Drawing.Point(434, 585)
		Me.btnShowPropGrids.Name = "btnShowPropGrids"
		Me.btnShowPropGrids.Size = New System.Drawing.Size(134, 38)
		Me.btnShowPropGrids.TabIndex = 9
		Me.btnShowPropGrids.Text = "Show Prop Grids"
		Me.btnShowPropGrids.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(579, 630)
		Me.Controls.Add(Me.btnShowPropGrids)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.btnShowLocalizations)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btnAddPrefix)
		Me.Controls.Add(Me.groupBox2)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.c1Chart3D1)
		Me.Controls.Add(Me.c1Chart1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Name = "Form1"
		Me.Text = "Runtime Localizations"
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		Me.groupBox2.ResumeLayout(False)
		Me.groupBox2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub	'InitializeComponent 

	Friend WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
	Friend WithEvents c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
	Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents checkBox2 As System.Windows.Forms.CheckBox
	Friend WithEvents checkBox1 As System.Windows.Forms.CheckBox
	Friend WithEvents groupBox2 As System.Windows.Forms.GroupBox
	Friend WithEvents radioButton4 As System.Windows.Forms.RadioButton
	Friend WithEvents radioButton3 As System.Windows.Forms.RadioButton
	Friend WithEvents radioButton2 As System.Windows.Forms.RadioButton
	Friend WithEvents radioButton1 As System.Windows.Forms.RadioButton
	Friend WithEvents btnAddPrefix As System.Windows.Forms.Button
	Friend WithEvents btnReset As System.Windows.Forms.Button
	Friend WithEvents btnShowLocalizations As System.Windows.Forms.Button
	Friend WithEvents label1 As System.Windows.Forms.Label
	Friend WithEvents textBox1 As System.Windows.Forms.TextBox
	Friend WithEvents btnShowPropGrids As System.Windows.Forms.Button

End Class

