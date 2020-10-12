Namespace C1ZoomPages.Help_Forms
	Partial Class ZoomPolicyForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.gcZoomPanel1 = New C1.Win.TouchToolKit.C1ZoomPanel()
			Me.gcZoomPanel2 = New C1.Win.TouchToolKit.C1ZoomPanel()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.tableLayoutPanel1.SetColumnSpan(Me.label1, 2)
			Me.label1.Location = New System.Drawing.Point(20, 22)
			Me.label1.Margin = New System.Windows.Forms.Padding(20, 22, 3, 0)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(254, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Please try zoom in the two touch rectangle by touch."
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label2.Location = New System.Drawing.Point(30, 46)
			Me.label2.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(322, 37)
			Me.label2.TabIndex = 1
			Me.label2.Text = "ZoomPolicy is Enabled:"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
			' 
			' gcZoomPanel1
			' 
			Me.gcZoomPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gcZoomPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gcZoomPanel1.Location = New System.Drawing.Point(10, 94)
			Me.gcZoomPanel1.Margin = New System.Windows.Forms.Padding(10, 8, 10, 11)
			Me.gcZoomPanel1.Name = "gcZoomPanel1"
			Me.gcZoomPanel1.Size = New System.Drawing.Size(335, 359)
			Me.gcZoomPanel1.TabIndex = 3
			' 
			' gcZoomPanel2
			' 
			Me.gcZoomPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gcZoomPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gcZoomPanel2.Location = New System.Drawing.Point(365, 94)
			Me.gcZoomPanel2.Margin = New System.Windows.Forms.Padding(10, 8, 10, 11)
			Me.gcZoomPanel2.Name = "gcZoomPanel2"
			Me.gcZoomPanel2.Size = New System.Drawing.Size(336, 359)
			Me.gcZoomPanel2.TabIndex = 4
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.gcZoomPanel2, 1, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.gcZoomPanel1, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.label3, 1, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.label1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 1)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 3
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(711, 464)
			Me.tableLayoutPanel1.TabIndex = 5
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label3.Location = New System.Drawing.Point(385, 46)
			Me.label3.Margin = New System.Windows.Forms.Padding(30, 3, 3, 3)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(323, 37)
			Me.label3.TabIndex = 2
			Me.label3.Text = "ZoomPolicy is Disabled:"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
			' 
			' ZoomPolicyForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(711, 464)
			Me.Controls.Add(Me.tableLayoutPanel1)
			Me.MinimumSize = New System.Drawing.Size(727, 503)
			Me.Name = "ZoomPolicyForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "ZoomPolicyForm"
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.tableLayoutPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private gcZoomPanel1 As C1.Win.TouchToolKit.C1ZoomPanel
		Private gcZoomPanel2 As C1.Win.TouchToolKit.C1ZoomPanel
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace
