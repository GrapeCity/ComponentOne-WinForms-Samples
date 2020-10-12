

Partial Class Form1
	Inherits Form
	'/ <summary>
	'/ Required designer variable.
	'/ </summary>
	Private components As System.ComponentModel.IContainer = Nothing


	'/ <summary>
	'/ Clean up any resources being used.
	'/ </summary>
	'/ <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso Not (components Is Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub	'Dispose


#Region " Windows Form Designer generated code "
	'/ <summary>
	'/ Required method for Designer support - do not modify
	'/ the contents of this method with the code editor.
	'/ </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.checkDefaultEffects = New System.Windows.Forms.CheckBox
		Me.checkGroup1Effects = New System.Windows.Forms.CheckBox
		Me.checkGroup0Effects = New System.Windows.Forms.CheckBox
		Me.btnVisualEffectsEditor = New System.Windows.Forms.Button
		Me.c1Chart1 = New C1.Win.C1Chart.C1Chart
		Me.btnClearEffects = New System.Windows.Forms.Button
		Me.groupBox1.SuspendLayout()
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'groupBox1
		'
		Me.groupBox1.Controls.Add(Me.checkDefaultEffects)
		Me.groupBox1.Controls.Add(Me.checkGroup1Effects)
		Me.groupBox1.Controls.Add(Me.checkGroup0Effects)
		Me.groupBox1.Location = New System.Drawing.Point(12, 12)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(180, 104)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Data Group Effects Selection"
		'
		'checkDefaultEffects
		'
		Me.checkDefaultEffects.AutoSize = True
		Me.checkDefaultEffects.Checked = True
		Me.checkDefaultEffects.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkDefaultEffects.Location = New System.Drawing.Point(15, 74)
		Me.checkDefaultEffects.Name = "checkDefaultEffects"
		Me.checkDefaultEffects.Size = New System.Drawing.Size(122, 17)
		Me.checkDefaultEffects.TabIndex = 5
		Me.checkDefaultEffects.Text = "Default Data Effects"
		Me.checkDefaultEffects.UseVisualStyleBackColor = True
		'
		'checkGroup1Effects
		'
		Me.checkGroup1Effects.AutoSize = True
		Me.checkGroup1Effects.Location = New System.Drawing.Point(15, 51)
		Me.checkGroup1Effects.Name = "checkGroup1Effects"
		Me.checkGroup1Effects.Size = New System.Drawing.Size(123, 17)
		Me.checkGroup1Effects.TabIndex = 4
		Me.checkGroup1Effects.Text = "Data Group1 Effects"
		Me.checkGroup1Effects.UseVisualStyleBackColor = True
		'
		'checkGroup0Effects
		'
		Me.checkGroup0Effects.AutoSize = True
		Me.checkGroup0Effects.Location = New System.Drawing.Point(15, 28)
		Me.checkGroup0Effects.Name = "checkGroup0Effects"
		Me.checkGroup0Effects.Size = New System.Drawing.Size(123, 17)
		Me.checkGroup0Effects.TabIndex = 3
		Me.checkGroup0Effects.Text = "Data Group0 Effects"
		Me.checkGroup0Effects.UseVisualStyleBackColor = True
		'
		'btnVisualEffectsEditor
		'
		Me.btnVisualEffectsEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnVisualEffectsEditor.Location = New System.Drawing.Point(317, 21)
		Me.btnVisualEffectsEditor.Name = "btnVisualEffectsEditor"
		Me.btnVisualEffectsEditor.Size = New System.Drawing.Size(136, 36)
		Me.btnVisualEffectsEditor.TabIndex = 3
		Me.btnVisualEffectsEditor.Text = "VisualEffects Editor"
		Me.btnVisualEffectsEditor.UseVisualStyleBackColor = True
		'
		'c1Chart1
		'
		Me.c1Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.c1Chart1.BackColor = System.Drawing.Color.LightSteelBlue
		Me.c1Chart1.Location = New System.Drawing.Point(12, 145)
		Me.c1Chart1.Name = "c1Chart1"
		Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
		Me.c1Chart1.Size = New System.Drawing.Size(441, 313)
		Me.c1Chart1.TabIndex = 0
		'
		'btnClearEffects
		'
		Me.btnClearEffects.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnClearEffects.Location = New System.Drawing.Point(317, 75)
		Me.btnClearEffects.Name = "btnClearEffects"
		Me.btnClearEffects.Size = New System.Drawing.Size(136, 36)
		Me.btnClearEffects.TabIndex = 4
		Me.btnClearEffects.Text = "Clear Effects"
		Me.btnClearEffects.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightSteelBlue
		Me.ClientSize = New System.Drawing.Size(467, 470)
		Me.Controls.Add(Me.btnClearEffects)
		Me.Controls.Add(Me.btnVisualEffectsEditor)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.c1Chart1)
		Me.MinimumSize = New System.Drawing.Size(475, 497)
		Me.Name = "Form1"
		Me.Text = "Separate Group Visual Effects"
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub	'InitializeComponent 

#End Region
	Private c1Chart1 As C1.Win.C1Chart.C1Chart
	Private groupBox1 As System.Windows.Forms.GroupBox
	WithEvents btnVisualEffectsEditor As System.Windows.Forms.Button
	WithEvents checkDefaultEffects As System.Windows.Forms.CheckBox
	WithEvents checkGroup1Effects As System.Windows.Forms.CheckBox
	WithEvents checkGroup0Effects As System.Windows.Forms.CheckBox
	WithEvents btnClearEffects As System.Windows.Forms.Button
End Class 'Form1
