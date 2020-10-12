Namespace TouchEvent
	Partial Class TouchEventListener
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gcTouchEventProvider1 = New C1.Win.TouchToolKit.C1TouchEventProvider()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.label3 = New System.Windows.Forms.Label()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.tabControl1 = New System.Windows.Forms.TabControl()
			Me.tabPage2 = New System.Windows.Forms.TabPage()
			Me.tableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
			Me.label2 = New System.Windows.Forms.Label()
			Me.listBox1 = New System.Windows.Forms.ListBox()
			Me.clearButton = New System.Windows.Forms.Button()
			Me.tabPage1 = New System.Windows.Forms.TabPage()
			Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
			Me.manipulationButton = New System.Windows.Forms.Button()
			Me.pointerButton = New System.Windows.Forms.Button()
			Me.selectAllButton = New System.Windows.Forms.Button()
			Me.tapButton = New System.Windows.Forms.Button()
			Me.panel1.SuspendLayout()
			Me.panel2.SuspendLayout()
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControl1.SuspendLayout()
			Me.tabPage2.SuspendLayout()
			Me.tableLayoutPanel2.SuspendLayout()
			Me.tabPage1.SuspendLayout()
			Me.tableLayoutPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.tabControl1)
			' 
			' panel2
			' 
			Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.panel2.Controls.Add(Me.label3)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gcTouchEventProvider1.SetEnableTouchEvents(Me.panel2, True)
			Me.panel2.ForeColor = System.Drawing.Color.Silver
			Me.panel2.Location = New System.Drawing.Point(243, 3)
			Me.panel2.Name = "panel2"
			Me.tableLayoutPanel2.SetRowSpan(Me.panel2, 3)
			Me.panel2.Size = New System.Drawing.Size(430, 324)
			Me.panel2.TabIndex = 0
			' 
			' label3
			' 
			Me.label3.Font = New System.Drawing.Font("Meiryo", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(128))
			Me.label3.Location = New System.Drawing.Point(3, 0)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(422, 310)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Touch here!"
			Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' dataGridView1
			' 
			Me.dataGridView1.AllowUserToAddRows = False
			Me.dataGridView1.AllowUserToDeleteRows = False
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
			Me.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dataGridView1.Location = New System.Drawing.Point(189, 3)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.RowHeadersVisible = False
			Me.tableLayoutPanel1.SetRowSpan(Me.dataGridView1, 4)
			Me.dataGridView1.RowTemplate.Height = 21
			Me.dataGridView1.Size = New System.Drawing.Size(484, 324)
			Me.dataGridView1.TabIndex = 0
			' 
			' Column1
			' 
			Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column1.HeaderText = "Selected"
			Me.Column1.Name = "Column1"
			Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
			Me.Column1.Width = 80
			' 
			' Column2
			' 
			Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column2.HeaderText = "Event Name"
			Me.Column2.Name = "Column2"
			Me.Column2.Width = 124
			' 
			' Column3
			' 
			Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
			Me.Column3.HeaderText = "Parameters"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 119
			' 
			' tabControl1
			' 
			Me.tabControl1.Controls.Add(Me.tabPage2)
			Me.tabControl1.Controls.Add(Me.tabPage1)
			Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControl1.Location = New System.Drawing.Point(0, 0)
			Me.tabControl1.Name = "tabControl1"
			Me.tabControl1.SelectedIndex = 0
			Me.tabControl1.Size = New System.Drawing.Size(690, 372)
			Me.tabControl1.TabIndex = 1
			' 
			' tabPage2
			' 
			Me.tabPage2.Controls.Add(Me.tableLayoutPanel2)
			Me.tabPage2.Location = New System.Drawing.Point(4, 32)
			Me.tabPage2.Name = "tabPage2"
			Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage2.Size = New System.Drawing.Size(682, 336)
			Me.tabPage2.TabIndex = 1
			Me.tabPage2.Text = "  Touch Area  "
			Me.tabPage2.UseVisualStyleBackColor = True
			' 
			' tableLayoutPanel2
			' 
			Me.tableLayoutPanel2.ColumnCount = 2
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F))
			Me.tableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel2.Controls.Add(Me.panel2, 1, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.label2, 0, 0)
			Me.tableLayoutPanel2.Controls.Add(Me.listBox1, 0, 1)
			Me.tableLayoutPanel2.Controls.Add(Me.clearButton, 0, 2)
			Me.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
			Me.tableLayoutPanel2.Name = "tableLayoutPanel2"
			Me.tableLayoutPanel2.RowCount = 3
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel2.Size = New System.Drawing.Size(676, 330)
			Me.tableLayoutPanel2.TabIndex = 3
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(3, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(91, 23)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Event logs:"
			' 
			' listBox1
			' 
			Me.listBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.listBox1.FormattingEnabled = True
			Me.listBox1.ItemHeight = 23
			Me.listBox1.Location = New System.Drawing.Point(3, 26)
			Me.listBox1.Name = "listBox1"
			Me.listBox1.Size = New System.Drawing.Size(234, 260)
			Me.listBox1.TabIndex = 0
			' 
			' clearButton
			' 
			Me.clearButton.Dock = System.Windows.Forms.DockStyle.Right
			Me.clearButton.Location = New System.Drawing.Point(162, 292)
			Me.clearButton.Name = "clearButton"
			Me.clearButton.Size = New System.Drawing.Size(75, 35)
			Me.clearButton.TabIndex = 2
			Me.clearButton.Text = "Clear Log"
			Me.clearButton.UseVisualStyleBackColor = True
			' 
			' tabPage1
			' 
			Me.tabPage1.Controls.Add(Me.tableLayoutPanel1)
			Me.tabPage1.Location = New System.Drawing.Point(4, 32)
			Me.tabPage1.Name = "tabPage1"
			Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
			Me.tabPage1.Size = New System.Drawing.Size(682, 336)
			Me.tabPage1.TabIndex = 0
			Me.tabPage1.Text = "Event Select Area"
			Me.tabPage1.UseVisualStyleBackColor = True
			' 
			' tableLayoutPanel1
			' 
			Me.tableLayoutPanel1.ColumnCount = 2
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F))
			Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Controls.Add(Me.manipulationButton, 0, 1)
			Me.tableLayoutPanel1.Controls.Add(Me.pointerButton, 0, 2)
			Me.tableLayoutPanel1.Controls.Add(Me.dataGridView1, 1, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.selectAllButton, 0, 0)
			Me.tableLayoutPanel1.Controls.Add(Me.tapButton, 0, 3)
			Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
			Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
			Me.tableLayoutPanel1.RowCount = 4
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
			Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
			Me.tableLayoutPanel1.Size = New System.Drawing.Size(676, 330)
			Me.tableLayoutPanel1.TabIndex = 6
			' 
			' manipulationButton
			' 
			Me.manipulationButton.Location = New System.Drawing.Point(3, 55)
			Me.manipulationButton.Name = "manipulationButton"
			Me.manipulationButton.Size = New System.Drawing.Size(180, 46)
			Me.manipulationButton.TabIndex = 7
			Me.manipulationButton.Text = "Manipulation Events"
			Me.manipulationButton.UseVisualStyleBackColor = True
			' 
			' pointerButton
			' 
			Me.pointerButton.Location = New System.Drawing.Point(3, 107)
			Me.pointerButton.Name = "pointerButton"
			Me.pointerButton.Size = New System.Drawing.Size(180, 46)
			Me.pointerButton.TabIndex = 8
			Me.pointerButton.Text = "Pointer Events"
			Me.pointerButton.UseVisualStyleBackColor = True
			' 
			' selectAllButton
			' 
			Me.selectAllButton.Location = New System.Drawing.Point(3, 3)
			Me.selectAllButton.Name = "selectAllButton"
			Me.selectAllButton.Size = New System.Drawing.Size(180, 46)
			Me.selectAllButton.TabIndex = 6
			Me.selectAllButton.Text = "All"
			Me.selectAllButton.UseVisualStyleBackColor = True
			' 
			' tapButton
			' 
			Me.tapButton.Location = New System.Drawing.Point(3, 159)
			Me.tapButton.Name = "tapButton"
			Me.tapButton.Size = New System.Drawing.Size(180, 46)
			Me.tapButton.TabIndex = 9
			Me.tapButton.Text = "Tap Events"
			Me.tapButton.UseVisualStyleBackColor = True
			' 
			' TouchEventListener
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 23F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "TouchEventListener"
			Me.panel1.ResumeLayout(False)
			Me.panel2.ResumeLayout(False)
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControl1.ResumeLayout(False)
			Me.tabPage2.ResumeLayout(False)
			Me.tableLayoutPanel2.ResumeLayout(False)
			Me.tableLayoutPanel2.PerformLayout()
			Me.tabPage1.ResumeLayout(False)
			Me.tableLayoutPanel1.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gcTouchEventProvider1 As C1.Win.TouchToolKit.C1TouchEventProvider
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private tabControl1 As System.Windows.Forms.TabControl
		Private tabPage1 As System.Windows.Forms.TabPage
		Private tabPage2 As System.Windows.Forms.TabPage
		Private listBox1 As System.Windows.Forms.ListBox
		Private panel2 As System.Windows.Forms.Panel
		Private clearButton As System.Windows.Forms.Button
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
		Private tapButton As System.Windows.Forms.Button
		Private manipulationButton As System.Windows.Forms.Button
		Private selectAllButton As System.Windows.Forms.Button
		Private pointerButton As System.Windows.Forms.Button
		Private tableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
	End Class
End Namespace
