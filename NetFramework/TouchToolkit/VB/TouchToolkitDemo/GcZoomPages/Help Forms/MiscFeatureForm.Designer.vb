Namespace C1ZoomPages.Help_Forms
	Partial Class MiscFeatureForm
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
			Me.tabControl1 = New System.Windows.Forms.TabControl()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.textBox2 = New System.Windows.Forms.TextBox()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label1 = New System.Windows.Forms.Label()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.comboBox4 = New System.Windows.Forms.ComboBox()
			Me.comboBox3 = New System.Windows.Forms.ComboBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.comboBox2 = New System.Windows.Forms.ComboBox()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
			Me.label8 = New System.Windows.Forms.Label()
			Me.textBox3 = New System.Windows.Forms.TextBox()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label15 = New System.Windows.Forms.Label()
			Me.button1 = New System.Windows.Forms.Button()
			Me.tabControl1.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' tabControl1
			' 
			Me.tabControl1.Controls.Add(Me.tabPage1)
			Me.tabControl1.Location = New System.Drawing.Point(0, 0)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New System.Drawing.Size(510, 542)
			Me.tabControl1.TabIndex = 2
			' 
			' tabPage1
			' 
			Me.tabPage1.Controls.Add(Me.tableLayoutPanel1)
			Me.tabPage1.Location = New System.Drawing.Point(4, 22)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage1.Size = New System.Drawing.Size(502, 516)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "日付"
			Me.tabPage1.UseVisualStyleBackColor = True
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 1
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F))
			Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.groupBox2, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.groupBox3, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.label15, 0, 3)
			Me.tableLayoutPanel1.Controls.Add(Me.button1, 0, 4)
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 5
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.62337F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.37663F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F))
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(496, 510)
			Me.tableLayoutPanel1.TabIndex = 0
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.textBox2)
			Me.groupBox1.Controls.Add(Me.textBox1)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupBox1.Location = New System.Drawing.Point(3, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(490, 85)
			Me.groupBox1.TabIndex = 44
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "例"
			' 
			' textBox2
			' 
			Me.textBox2.Location = New System.Drawing.Point(128, 54)
			Me.textBox2.Name = "textBox2"
			Me.textBox2.Size = New System.Drawing.Size(193, 19)
			Me.textBox2.TabIndex = 3
			Me.textBox2.Text = "2013年1月24日"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(128, 26)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.Size = New System.Drawing.Size(193, 19)
			Me.textBox1.TabIndex = 2
			Me.textBox1.Text = "2013/01/24"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(27, 57)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(57, 12)
			Me.label2.TabIndex = 1
			Me.label2.Text = "長い形式："
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(26, 29)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(57, 12)
			Me.label1.TabIndex = 0
			Me.label1.Text = "短い形式："
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.comboBox4)
			Me.groupBox2.Controls.Add(Me.comboBox3)
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupBox2.Location = New System.Drawing.Point(3, 94)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(490, 152)
			Me.groupBox2.TabIndex = 45
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "データ形式："
			' 
			' comboBox4
			' 
			Me.comboBox4.FormattingEnabled = True
			Me.comboBox4.Location = New System.Drawing.Point(128, 55)
			Me.comboBox4.Name = "comboBox4"
			Me.comboBox4.Size = New System.Drawing.Size(272, 20)
			Me.comboBox4.TabIndex = 11
			Me.comboBox4.Text = "yyyy'年'M'月'd'日'"
			' 
			' comboBox3
			' 
			Me.comboBox3.FormattingEnabled = True
			Me.comboBox3.Location = New System.Drawing.Point(128, 25)
			Me.comboBox3.Name = "comboBox3"
			Me.comboBox3.Size = New System.Drawing.Size(272, 20)
			Me.comboBox3.TabIndex = 10
			Me.comboBox3.Text = "yyyy/MM/dd"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(26, 104)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(282, 12)
			Me.label6.TabIndex = 3
			Me.label6.Text = "d, dd = 日; ddd, dddd = 曜日; M = 月; y = 年; gg = 元号"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(26, 80)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(97, 12)
			Me.label5.TabIndex = 2
			Me.label5.Text = "データ形式の表記："
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(27, 55)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(57, 12)
			Me.label4.TabIndex = 1
			Me.label4.Text = "長い形式："
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(26, 28)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(57, 12)
			Me.label3.TabIndex = 0
			Me.label3.Text = "短い形式："
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.comboBox2)
			Me.groupBox3.Controls.Add(Me.comboBox1)
			Me.groupBox3.Controls.Add(Me.label10)
			Me.groupBox3.Controls.Add(Me.label9)
			Me.groupBox3.Controls.Add(Me.numericUpDown1)
			Me.groupBox3.Controls.Add(Me.label8)
			Me.groupBox3.Controls.Add(Me.textBox3)
			Me.groupBox3.Controls.Add(Me.label7)
			Me.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupBox3.Location = New System.Drawing.Point(3, 252)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(490, 156)
			Me.groupBox3.TabIndex = 46
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "カレンダー"
			' 
			' comboBox2
			' 
			Me.comboBox2.FormattingEnabled = True
			Me.comboBox2.Location = New System.Drawing.Point(169, 92)
			Me.comboBox2.Name = "comboBox2"
			Me.comboBox2.Size = New System.Drawing.Size(233, 20)
			Me.comboBox2.TabIndex = 10
			Me.comboBox2.Text = "西暦(日本語)"
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(169, 66)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(233, 20)
			Me.comboBox1.TabIndex = 9
			Me.comboBox1.Text = "日曜日"
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(28, 95)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(90, 12)
			Me.label10.TabIndex = 8
			Me.label10.Text = "力レンダーの種類:"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(28, 69)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(87, 12)
			Me.label9.TabIndex = 7
			Me.label9.Text = "週の最初の曜日:"
			' 
			' numericUpDown1
			' 
			Me.numericUpDown1.Location = New System.Drawing.Point(180, 41)
			Me.numericUpDown1.Maximum = New Decimal(New Integer() {3000, 0, 0, 0})
			Me.numericUpDown1.Name = "numericUpDown1"
			Me.numericUpDown1.Size = New System.Drawing.Size(88, 19)
			Me.numericUpDown1.TabIndex = 6
			Me.numericUpDown1.Value = New Decimal(New Integer() {2029, 0, 0, 0})
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(139, 44)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(23, 12)
			Me.label8.TabIndex = 5
			Me.label8.Text = "から"
			' 
			' textBox3
			' 
			Me.textBox3.Enabled = False
			Me.textBox3.Location = New System.Drawing.Point(58, 41)
			Me.textBox3.Name = "textBox3"
			Me.textBox3.Size = New System.Drawing.Size(69, 19)
			Me.textBox3.TabIndex = 4
			Me.textBox3.Text = "1930"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(28, 15)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(321, 12)
			Me.label7.TabIndex = 4
			Me.label7.Text = "2桁の数字で年を入力すると､ 次の範囲内での暦年として解釈する:"
			' 
			' label15
			' 
			Me.label15.Dock = System.Windows.Forms.DockStyle.Fill
			Me.label15.Location = New System.Drawing.Point(3, 411)
			Me.label15.Name = "label15"
			Me.label15.Size = New System.Drawing.Size(490, 41)
			Me.label15.TabIndex = 47
			Me.label15.Text = "数値､通貨､時刻､および日付のシステムの既定の設定を復えするには､｢リセット｣をクリックしてださい｡"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(3, 455)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(75, 23)
			Me.button1.TabIndex = 48
			Me.button1.Text = "リセット"
			Me.button1.UseVisualStyleBackColor = True
			' 
			' MiscFeatureForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 12F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(510, 542)
			Me.Controls.Add(Me.tabControl1)
			Me.Name = "MiscFeatureForm"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
			Me.tabControl1.ResumeLayout(False)
			Me.tabPage1.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox3.PerformLayout()
			DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private textBox2 As System.Windows.Forms.TextBox
		Private textBox1 As System.Windows.Forms.TextBox
		Private label2 As System.Windows.Forms.Label
		Private label1 As System.Windows.Forms.Label
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private comboBox4 As System.Windows.Forms.ComboBox
		Private comboBox3 As System.Windows.Forms.ComboBox
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private comboBox2 As System.Windows.Forms.ComboBox
		Private comboBox1 As System.Windows.Forms.ComboBox
		Private label10 As System.Windows.Forms.Label
		Private label9 As System.Windows.Forms.Label
		Private numericUpDown1 As System.Windows.Forms.NumericUpDown
		Private label8 As System.Windows.Forms.Label
		Private textBox3 As System.Windows.Forms.TextBox
		Private label7 As System.Windows.Forms.Label
		Private label15 As System.Windows.Forms.Label
		Private button1 As System.Windows.Forms.Button
	End Class
End Namespace
