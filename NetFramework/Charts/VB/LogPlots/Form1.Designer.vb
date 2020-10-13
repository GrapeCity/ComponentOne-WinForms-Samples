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
		Me.C1Chart1 = New C1.Win.C1Chart.C1Chart
		Me.panel1 = New System.Windows.Forms.Panel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.checkYLOG = New System.Windows.Forms.CheckBox()
		Me.checkXLOG = New System.Windows.Forms.CheckBox()
		Me.comboBoxLogBase = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		CType(Me.C1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.panel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'C1Chart1
		'
		Me.c1Chart1.Location = New System.Drawing.Point(13, 77)
		Me.c1Chart1.Name = "c1Chart1"
		Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
		Me.c1Chart1.Size = New System.Drawing.Size(559, 374)
		Me.c1Chart1.TabIndex = 0
		' 
		' panel1
		' 
		Me.panel1.Controls.Add(Me.label2)
		Me.panel1.Controls.Add(Me.checkYLOG)
		Me.panel1.Controls.Add(Me.checkXLOG)
		Me.panel1.Location = New System.Drawing.Point(12, 2)
		Me.panel1.Name = "panel1"
		Me.panel1.Size = New System.Drawing.Size(296, 58)
		Me.panel1.TabIndex = 1
		' 
		' label2
		' 
		Me.label2.AutoSize = True
		Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(3, 11)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(154, 13)
		Me.label2.TabIndex = 4
		Me.label2.Text = "Select Axis for Log Scale:"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		' 
		' checkYLOG
		' 
		Me.checkYLOG.AutoSize = True
		Me.checkYLOG.Checked = True
		Me.checkYLOG.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkYLOG.Location = New System.Drawing.Point(160, 38)
		Me.checkYLOG.Name = "checkYLOG"
		Me.checkYLOG.Size = New System.Drawing.Size(136, 17)
		Me.checkYLOG.TabIndex = 1
		Me.checkYLOG.Text = "Y-Axis Using Log Scale"
		Me.checkYLOG.UseVisualStyleBackColor = True
		' 
		' checkXLOG
		' 
		Me.checkXLOG.AutoSize = True
		Me.checkXLOG.Location = New System.Drawing.Point(160, 10)
		Me.checkXLOG.Name = "checkXLOG"
		Me.checkXLOG.Size = New System.Drawing.Size(136, 17)
		Me.checkXLOG.TabIndex = 0
		Me.checkXLOG.Text = "X-Axis Using Log Scale"
		Me.checkXLOG.UseVisualStyleBackColor = True
		' 
		' comboBoxLogBase
		' 
		Me.comboBoxLogBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboBoxLogBase.FormattingEnabled = True
		Me.comboBoxLogBase.Location = New System.Drawing.Point(468, 6)
		Me.comboBoxLogBase.Name = "comboBoxLogBase"
		Me.comboBoxLogBase.Size = New System.Drawing.Size(64, 21)
		Me.comboBoxLogBase.TabIndex = 2
		' 
		' label1
		' 
		Me.label1.AutoSize = True
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(314, 11)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(148, 13)
		Me.label1.TabIndex = 3
		Me.label1.Text = "Select Logarithmic Base:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Ivory
		Me.ClientSize = New System.Drawing.Size(584, 463)
		Me.Controls.Add(label1)
		Me.Controls.Add(comboBoxLogBase)
		Me.Controls.Add(panel1)
		Me.Controls.Add(c1Chart1)
		Me.Name = "Form1"
		Me.Text = "ComponentOne Chart.Net 2D-Log Plots"
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.panel1.ResumeLayout(False)
		Me.panel1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents C1Chart1 As C1.Win.C1Chart.C1Chart
	Friend WithEvents checkYLOG As System.Windows.Forms.CheckBox
	Friend WithEvents checkXLOG As System.Windows.Forms.CheckBox
	Friend WithEvents comboBoxLogBase As System.Windows.Forms.ComboBox
	Private panel1 As System.Windows.Forms.Panel
	Private label1 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label

End Class

