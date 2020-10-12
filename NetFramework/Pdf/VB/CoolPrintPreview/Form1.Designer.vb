Partial Class Form1
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
		Me.printDocument1 = New System.Drawing.Printing.PrintDocument()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label1 = New System.Windows.Forms.Label()
		Me.button3 = New System.Windows.Forms.Button()
		Me.button1 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		' 
		' printDocument1
		' 
		AddHandler Me.printDocument1.PrintPage, New System.Drawing.Printing.PrintPageEventHandler(AddressOf Me.printDocument1_PrintPage)
		AddHandler Me.printDocument1.BeginPrint, New System.Drawing.Printing.PrintEventHandler(AddressOf Me.printDocument1_BeginPrint)
		' 
		' label2
		' 
		Me.label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label2.Font = New System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label2.Location = New System.Drawing.Point(175, 102)
		Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(338, 83)
		Me.label2.TabIndex = 8
		Me.label2.Text = "using (var dlg = new CoolPrintPreviewDialog())" & vbCr & vbLf & "{" & vbCr & vbLf & "  dlg.Document = this.printDoc" & "ument1;" & vbCr & vbLf & "  dlg.ShowDialog(this);" & vbCr & vbLf & "}" & vbCr & vbLf
		' 
		' label1
		' 
		Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.label1.Font = New System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.label1.Location = New System.Drawing.Point(175, 12)
		Me.label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(338, 83)
		Me.label1.TabIndex = 9
		Me.label1.Text = "using (var dlg = new PrintPreviewDialog())" & vbCr & vbLf & "{" & vbCr & vbLf & "  dlg.Document = this.printDocumen" & "t1;" & vbCr & vbLf & "  dlg.ShowDialog(this);" & vbCr & vbLf & "}" & vbCr & vbLf
		' 
		' button3
		' 
		Me.button3.Location = New System.Drawing.Point(13, 102)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(157, 83)
		Me.button3.TabIndex = 7
		Me.button3.Text = "Enhanced" & vbCr & vbLf & "PdfPrintPreviewDialog"
		Me.button3.UseVisualStyleBackColor = True
		AddHandler Me.button3.Click, New System.EventHandler(AddressOf Me.button2_Click)
		' 
		' button1
		' 
		Me.button1.Location = New System.Drawing.Point(13, 12)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(157, 83)
		Me.button1.TabIndex = 6
		Me.button1.Text = "Standard" & vbCr & vbLf & "PrintPreviewDialog"
		Me.button1.UseVisualStyleBackColor = True
		AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 196)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.button1)
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Compare Print Preview Dialogs"
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private printDocument1 As System.Drawing.Printing.PrintDocument
	Private label2 As System.Windows.Forms.Label
	Private label1 As System.Windows.Forms.Label
	Private button3 As System.Windows.Forms.Button
	Private button1 As System.Windows.Forms.Button
End Class

