Namespace C1WordsX
	Partial Class WordCount
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
			Me.label2 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me._lblWords = New System.Windows.Forms.Label()
			Me._lblCharsNoSpace = New System.Windows.Forms.Label()
			Me._lblChars = New System.Windows.Forms.Label()
			Me._lblParagraphs = New System.Windows.Forms.Label()
			Me._lblSentences = New System.Windows.Forms.Label()
			Me._lblWordLength = New System.Windows.Forms.Label()
			Me._lblSentenceLength = New System.Windows.Forms.Label()
			Me._lblParagraphLength = New System.Windows.Forms.Label()
			Me._btnOK = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label2
			' 
			Me.label2.Location = New System.Drawing.Point(10, 12)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(194, 22)
			Me.label2.TabIndex = 0
			Me.label2.Text = "Words:"
			Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label3
			' 
			Me.label3.Location = New System.Drawing.Point(10, 34)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(194, 22)
			Me.label3.TabIndex = 0
			Me.label3.Text = "Characters (no spaces):"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(10, 56)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(194, 22)
			Me.label4.TabIndex = 0
			Me.label4.Text = "Characters (with spaces):"
			Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label5
			' 
			Me.label5.Location = New System.Drawing.Point(10, 78)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(194, 22)
			Me.label5.TabIndex = 0
			Me.label5.Text = "Paragraphs:"
			Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label6
			' 
			Me.label6.Location = New System.Drawing.Point(10, 100)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(194, 22)
			Me.label6.TabIndex = 0
			Me.label6.Text = "Sentences:"
			Me.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label1
			' 
			Me.label1.Location = New System.Drawing.Point(10, 122)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(194, 22)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Average word length:"
			Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label7
			' 
			Me.label7.Location = New System.Drawing.Point(10, 144)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(194, 22)
			Me.label7.TabIndex = 0
			Me.label7.Text = "Average sentence length:"
			Me.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' label8
			' 
			Me.label8.Location = New System.Drawing.Point(10, 166)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(194, 22)
			Me.label8.TabIndex = 0
			Me.label8.Text = "Average paragraph length:"
			Me.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblWords
			' 
			Me._lblWords.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblWords.Location = New System.Drawing.Point(210, 12)
			Me._lblWords.Name = "_lblWords"
			Me._lblWords.Size = New System.Drawing.Size(85, 22)
			Me._lblWords.TabIndex = 0
			Me._lblWords.Text = "0"
			Me._lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblCharsNoSpace
			' 
			Me._lblCharsNoSpace.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblCharsNoSpace.Location = New System.Drawing.Point(210, 34)
			Me._lblCharsNoSpace.Name = "_lblCharsNoSpace"
			Me._lblCharsNoSpace.Size = New System.Drawing.Size(85, 22)
			Me._lblCharsNoSpace.TabIndex = 0
			Me._lblCharsNoSpace.Text = "0"
			Me._lblCharsNoSpace.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblChars
			' 
			Me._lblChars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblChars.Location = New System.Drawing.Point(210, 56)
			Me._lblChars.Name = "_lblChars"
			Me._lblChars.Size = New System.Drawing.Size(85, 22)
			Me._lblChars.TabIndex = 0
			Me._lblChars.Text = "0"
			Me._lblChars.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblParagraphs
			' 
			Me._lblParagraphs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblParagraphs.Location = New System.Drawing.Point(210, 78)
			Me._lblParagraphs.Name = "_lblParagraphs"
			Me._lblParagraphs.Size = New System.Drawing.Size(85, 22)
			Me._lblParagraphs.TabIndex = 0
			Me._lblParagraphs.Text = "0"
			Me._lblParagraphs.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblSentences
			' 
			Me._lblSentences.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblSentences.Location = New System.Drawing.Point(210, 100)
			Me._lblSentences.Name = "_lblSentences"
			Me._lblSentences.Size = New System.Drawing.Size(85, 22)
			Me._lblSentences.TabIndex = 0
			Me._lblSentences.Text = "0"
			Me._lblSentences.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblWordLength
			' 
			Me._lblWordLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblWordLength.Location = New System.Drawing.Point(210, 122)
			Me._lblWordLength.Name = "_lblWordLength"
			Me._lblWordLength.Size = New System.Drawing.Size(85, 22)
			Me._lblWordLength.TabIndex = 0
			Me._lblWordLength.Text = "0"
			Me._lblWordLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblSentenceLength
			' 
			Me._lblSentenceLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblSentenceLength.Location = New System.Drawing.Point(210, 144)
			Me._lblSentenceLength.Name = "_lblSentenceLength"
			Me._lblSentenceLength.Size = New System.Drawing.Size(85, 22)
			Me._lblSentenceLength.TabIndex = 0
			Me._lblSentenceLength.Text = "0"
			Me._lblSentenceLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _lblParagraphLength
			' 
			Me._lblParagraphLength.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._lblParagraphLength.Location = New System.Drawing.Point(210, 166)
			Me._lblParagraphLength.Name = "_lblParagraphLength"
			Me._lblParagraphLength.Size = New System.Drawing.Size(85, 22)
			Me._lblParagraphLength.TabIndex = 0
			Me._lblParagraphLength.Text = "0"
			Me._lblParagraphLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight
			' 
			' _btnOK
			' 
			Me._btnOK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
			Me._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
			Me._btnOK.Location = New System.Drawing.Point(192, 212)
			Me._btnOK.Name = "_btnOK"
			Me._btnOK.Size = New System.Drawing.Size(103, 28)
			Me._btnOK.TabIndex = 1
			Me._btnOK.Text = "OK"
			Me._btnOK.UseVisualStyleBackColor = True
			' 
			' WordCountDialog
			' 
			Me.AcceptButton = Me._btnOK
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(306, 252)
			Me.Controls.Add(Me._btnOK)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me._lblParagraphLength)
			Me.Controls.Add(Me._lblSentenceLength)
			Me.Controls.Add(Me._lblWordLength)
			Me.Controls.Add(Me._lblSentences)
			Me.Controls.Add(Me._lblParagraphs)
			Me.Controls.Add(Me._lblChars)
			Me.Controls.Add(Me._lblCharsNoSpace)
			Me.Controls.Add(Me._lblWords)
			Me.Controls.Add(Me.label2)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "WordCountDialog"
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.Text = "Word Count"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private _lblWords As System.Windows.Forms.Label
		Private _lblCharsNoSpace As System.Windows.Forms.Label
		Private _lblChars As System.Windows.Forms.Label
		Private _lblParagraphs As System.Windows.Forms.Label
		Private _lblSentences As System.Windows.Forms.Label
		Private _lblWordLength As System.Windows.Forms.Label
		Private _lblSentenceLength As System.Windows.Forms.Label
		Private _lblParagraphLength As System.Windows.Forms.Label
		Private _btnOK As System.Windows.Forms.Button
	End Class
End Namespace
