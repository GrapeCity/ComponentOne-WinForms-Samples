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

   Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.c1Chart1 = New C1.Win.C1Chart.C1Chart
		Me.chk3D = New System.Windows.Forms.CheckBox
		Me.chkStacked = New System.Windows.Forms.CheckBox
		Me.chkAscending = New System.Windows.Forms.CheckBox
		Me.label1 = New System.Windows.Forms.Label
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'c1Chart1
		'
		Me.c1Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.c1Chart1.Location = New System.Drawing.Point(0, 31)
		Me.c1Chart1.Name = "c1Chart1"
		Me.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag")
		Me.c1Chart1.Size = New System.Drawing.Size(571, 561)
		Me.c1Chart1.TabIndex = 0
		'
		'chk3D
		'
		Me.chk3D.AutoSize = True
		Me.chk3D.Checked = True
		Me.chk3D.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chk3D.Location = New System.Drawing.Point(0, 8)
		Me.chk3D.Name = "chk3D"
		Me.chk3D.Size = New System.Drawing.Size(76, 17)
		Me.chk3D.TabIndex = 1
		Me.chk3D.Text = "3D Effects"
		Me.chk3D.UseVisualStyleBackColor = True
		'
		'chkStacked
		'
		Me.chkStacked.AutoSize = True
		Me.chkStacked.Checked = True
		Me.chkStacked.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkStacked.Location = New System.Drawing.Point(82, 8)
		Me.chkStacked.Name = "chkStacked"
		Me.chkStacked.Size = New System.Drawing.Size(66, 17)
		Me.chkStacked.TabIndex = 2
		Me.chkStacked.Text = "Stacked"
		Me.chkStacked.UseVisualStyleBackColor = True
		'
		'chkAscending
		'
		Me.chkAscending.AutoSize = True
		Me.chkAscending.Checked = True
		Me.chkAscending.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chkAscending.Location = New System.Drawing.Point(154, 8)
		Me.chkAscending.Name = "chkAscending"
		Me.chkAscending.Size = New System.Drawing.Size(76, 17)
		Me.chkAscending.TabIndex = 3
		Me.chkAscending.Text = "Ascending"
		Me.chkAscending.UseVisualStyleBackColor = True
		'
		'label1
		'
		Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label1.AutoSize = True
		Me.label1.Location = New System.Drawing.Point(348, 8)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(172, 13)
		Me.label1.TabIndex = 4
		Me.label1.Text = "Click each pie element for a tooltip."
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(572, 593)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.chkAscending)
		Me.Controls.Add(Me.chkStacked)
		Me.Controls.Add(Me.chk3D)
		Me.Controls.Add(Me.c1Chart1)
		Me.Name = "Form1"
		Me.Text = "ComponentOne Chart.Net 2D Pie Grouping"
		CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
   
   Friend WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Friend WithEvents chk3D As System.Windows.Forms.CheckBox
   Friend WithEvents chkStacked As System.Windows.Forms.CheckBox
   Friend WithEvents chkAscending As System.Windows.Forms.CheckBox
   Friend WithEvents label1 As System.Windows.Forms.Label
End Class
