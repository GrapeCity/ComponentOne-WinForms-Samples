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
   
#Region " Windows Form Designer generated code "
   Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.c1Chart1 = New C1.Win.C1Chart.C1Chart
		Me.groupBox1 = New System.Windows.Forms.GroupBox
		Me.picSelect = New System.Windows.Forms.PictureBox
		Me.radioRotation = New System.Windows.Forms.RadioButton
		Me.radioCompass = New System.Windows.Forms.RadioButton
		Me.label1 = New System.Windows.Forms.Label
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox1.SuspendLayout()
		CType(Me.picSelect, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'c1Chart1
		'
		Me.c1Chart1.BackColor = System.Drawing.Color.Tan
		Me.c1Chart1.Location = New System.Drawing.Point(12, 13)
		Me.c1Chart1.Name = "c1Chart1"
		Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
		Me.c1Chart1.Size = New System.Drawing.Size(330, 348)
		Me.c1Chart1.TabIndex = 0
		'
		'groupBox1
		'
		Me.groupBox1.BackColor = System.Drawing.Color.Tan
		Me.groupBox1.Controls.Add(Me.picSelect)
		Me.groupBox1.Controls.Add(Me.radioRotation)
		Me.groupBox1.Controls.Add(Me.radioCompass)
		Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.groupBox1.Location = New System.Drawing.Point(357, 110)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(216, 251)
		Me.groupBox1.TabIndex = 1
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Selections"
		'
		'picSelect
		'
		Me.picSelect.Location = New System.Drawing.Point(18, 51)
		Me.picSelect.Name = "picSelect"
		Me.picSelect.Size = New System.Drawing.Size(180, 180)
		Me.picSelect.TabIndex = 2
		Me.picSelect.TabStop = False
		'
		'radioRotation
		'
		Me.radioRotation.AutoSize = True
		Me.radioRotation.Location = New System.Drawing.Point(93, 19)
		Me.radioRotation.Name = "radioRotation"
		Me.radioRotation.Size = New System.Drawing.Size(105, 17)
		Me.radioRotation.TabIndex = 1
		Me.radioRotation.Text = "RotationOverride"
		Me.radioRotation.UseVisualStyleBackColor = True
		'
		'radioCompass
		'
		Me.radioCompass.AutoSize = True
		Me.radioCompass.Checked = True
		Me.radioCompass.Location = New System.Drawing.Point(19, 19)
		Me.radioCompass.Name = "radioCompass"
		Me.radioCompass.Size = New System.Drawing.Size(68, 17)
		Me.radioCompass.TabIndex = 0
		Me.radioCompass.TabStop = True
		Me.radioCompass.Text = "Compass"
		Me.radioCompass.UseVisualStyleBackColor = True
		'
		'label1
		'
		Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.label1.Location = New System.Drawing.Point(357, 13)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(216, 76)
		Me.label1.TabIndex = 2
		Me.label1.Text = "Rotated labels orient the text as upright as possible.  The pivot of the rotation" & _
			" is the label connection point."
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Tan
		Me.ClientSize = New System.Drawing.Size(589, 373)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.c1Chart1)
		Me.Name = "Form1"
		Me.Text = "RotatedLabels"
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox1.ResumeLayout(False)
		Me.groupBox1.PerformLayout()
		CType(Me.picSelect, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub	'InitializeComponent 
   
#End Region
   Friend WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Private groupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents picSelect As System.Windows.Forms.PictureBox
   Friend WithEvents radioRotation As System.Windows.Forms.RadioButton
   Friend WithEvents radioCompass As System.Windows.Forms.RadioButton
   Private label1 As System.Windows.Forms.Label
End Class 'Form1
