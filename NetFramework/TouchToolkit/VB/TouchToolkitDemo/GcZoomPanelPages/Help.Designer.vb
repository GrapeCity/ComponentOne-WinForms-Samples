Namespace C1ZoomPanelPages
    Partial Class Help
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
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.toolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
            Me.saveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.gcZoomPanel1 = New C1.Win.TouchToolKit.C1ZoomPanel()
            Me.button3 = New System.Windows.Forms.Button()
            Me.button2 = New System.Windows.Forms.Button()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.radioButton2 = New System.Windows.Forms.RadioButton()
            Me.radioButton1 = New System.Windows.Forms.RadioButton()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.progressBar1 = New System.Windows.Forms.ProgressBar()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.checkedListBox1 = New System.Windows.Forms.CheckedListBox()
            Me.listBox2 = New System.Windows.Forms.ListBox()
            Me.menuStrip1.SuspendLayout()
            Me.statusStrip1.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.panel1.SuspendLayout()
            Me.gcZoomPanel1.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' menuStrip1
            ' 
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItem1, Me.saveToolStripMenuItem, Me.exitToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.Size = New System.Drawing.Size(742, 24)
            Me.menuStrip1.TabIndex = 0
            Me.menuStrip1.Text = "menuStrip1"
            ' 
            ' toolStripMenuItem1
            ' 
            Me.toolStripMenuItem1.Name = "toolStripMenuItem1"
            Me.toolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
            Me.toolStripMenuItem1.Text = "Open"
            ' 
            ' saveToolStripMenuItem
            ' 
            Me.saveToolStripMenuItem.Name = "saveToolStripMenuItem"
            Me.saveToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
            Me.saveToolStripMenuItem.Text = "Save"
            ' 
            ' exitToolStripMenuItem
            ' 
            Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
            Me.exitToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
            Me.exitToolStripMenuItem.Text = "Exit"
            ' 
            ' statusStrip1
            ' 
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 457)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.Size = New System.Drawing.Size(742, 22)
            Me.statusStrip1.TabIndex = 1
            Me.statusStrip1.Text = "statusStrip1"
            ' 
            ' toolStripStatusLabel1
            ' 
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
            Me.toolStripStatusLabel1.Text = "toolStripStatusLabel1"
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.05668F))
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.94332F))
            Me.tableLayoutPanel1.Controls.Add(Me.panel1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.gcZoomPanel1, 1, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 24)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(742, 433)
            Me.tableLayoutPanel1.TabIndex = 7
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.listBox1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel1.Location = New System.Drawing.Point(4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(275, 425)
            Me.panel1.TabIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(173, 382)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 30)
            Me.button1.TabIndex = 7
            Me.button1.Text = "Clear Log"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(22, 9)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(61, 12)
            Me.label2.TabIndex = 6
            Me.label2.Text = "Event logs:"
            ' 
            ' listBox1
            ' 
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.ItemHeight = 12
            Me.listBox1.Location = New System.Drawing.Point(24, 40)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(239, 328)
            Me.listBox1.TabIndex = 5
            ' 
            ' gcZoomPanel1
            ' 
            Me.gcZoomPanel1.Controls.Add(Me.button3)
            Me.gcZoomPanel1.Controls.Add(Me.button2)
            Me.gcZoomPanel1.Controls.Add(Me.groupBox3)
            Me.gcZoomPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gcZoomPanel1.Location = New System.Drawing.Point(286, 4)
            Me.gcZoomPanel1.Name = "gcZoomPanel1"
            Me.gcZoomPanel1.Size = New System.Drawing.Size(452, 425)
            Me.gcZoomPanel1.TabIndex = 1
            ' 
            ' button3
            ' 
            Me.button3.Location = New System.Drawing.Point(222, 384)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(75, 23)
            Me.button3.TabIndex = 34
            Me.button3.Text = "Next"
            Me.button3.UseVisualStyleBackColor = True
            ' 
            ' button2
            ' 
            Me.button2.Location = New System.Drawing.Point(116, 384)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(75, 23)
            Me.button2.TabIndex = 33
            Me.button2.Text = "Pre"
            Me.button2.UseVisualStyleBackColor = True
            ' 
            ' groupBox3
            ' 
            Me.groupBox3.Controls.Add(Me.label7)
            Me.groupBox3.Controls.Add(Me.label6)
            Me.groupBox3.Controls.Add(Me.label3)
            Me.groupBox3.Controls.Add(Me.label5)
            Me.groupBox3.Controls.Add(Me.label4)
            Me.groupBox3.Controls.Add(Me.label8)
            Me.groupBox3.Controls.Add(Me.groupBox1)
            Me.groupBox3.Controls.Add(Me.textBox2)
            Me.groupBox3.Controls.Add(Me.progressBar1)
            Me.groupBox3.Controls.Add(Me.numericUpDown1)
            Me.groupBox3.Controls.Add(Me.linkLabel1)
            Me.groupBox3.Controls.Add(Me.pictureBox1)
            Me.groupBox3.Controls.Add(Me.checkedListBox1)
            Me.groupBox3.Controls.Add(Me.listBox2)
            Me.groupBox3.Location = New System.Drawing.Point(21, 17)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(410, 339)
            Me.groupBox3.TabIndex = 32
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Information"
            ' 
            ' label7
            ' 
            Me.label7.AutoSize = True
            Me.label7.Location = New System.Drawing.Point(208, 129)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(77, 12)
            Me.label7.TabIndex = 36
            Me.label7.Text = " Konstellation:"
            ' 
            ' label6
            ' 
            Me.label6.AutoSize = True
            Me.label6.Location = New System.Drawing.Point(21, 129)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(75, 12)
            Me.label6.TabIndex = 35
            Me.label6.Text = "Favorite food:"
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(208, 58)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(27, 12)
            Me.label3.TabIndex = 17
            Me.label3.Text = "Age:"
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(21, 253)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(120, 12)
            Me.label5.TabIndex = 34
            Me.label5.Text = "Degree Of Completion:"
            ' 
            ' label4
            ' 
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(21, 307)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(36, 12)
            Me.label4.TabIndex = 33
            Me.label4.Text = "Blogs:"
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(208, 21)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(36, 12)
            Me.label8.TabIndex = 1
            Me.label8.Text = "Name:"
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.radioButton2)
            Me.groupBox1.Controls.Add(Me.radioButton1)
            Me.groupBox1.Location = New System.Drawing.Point(210, 81)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(166, 45)
            Me.groupBox1.TabIndex = 32
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Sex"
            ' 
            ' radioButton2
            ' 
            Me.radioButton2.AutoSize = True
            Me.radioButton2.Location = New System.Drawing.Point(90, 18)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(47, 16)
            Me.radioButton2.TabIndex = 6
            Me.radioButton2.TabStop = True
            Me.radioButton2.Text = "Male"
            Me.radioButton2.UseVisualStyleBackColor = True
            ' 
            ' radioButton1
            ' 
            Me.radioButton1.AutoSize = True
            Me.radioButton1.Location = New System.Drawing.Point(6, 17)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(60, 16)
            Me.radioButton1.TabIndex = 5
            Me.radioButton1.TabStop = True
            Me.radioButton1.Text = "Female"
            Me.radioButton1.UseVisualStyleBackColor = True
            ' 
            ' textBox2
            ' 
            Me.textBox2.Location = New System.Drawing.Point(276, 18)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(100, 19)
            Me.textBox2.TabIndex = 31
            ' 
            ' progressBar1
            ' 
            Me.progressBar1.Location = New System.Drawing.Point(22, 271)
            Me.progressBar1.Name = "progressBar1"
            Me.progressBar1.Size = New System.Drawing.Size(138, 21)
            Me.progressBar1.TabIndex = 30
            Me.progressBar1.Value = 50
            ' 
            ' numericUpDown1
            ' 
            Me.numericUpDown1.Location = New System.Drawing.Point(276, 56)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(100, 19)
            Me.numericUpDown1.TabIndex = 29
            ' 
            ' linkLabel1
            ' 
            Me.linkLabel1.AutoSize = True
            Me.linkLabel1.Location = New System.Drawing.Point(107, 307)
            Me.linkLabel1.Name = "linkLabel1"
            Me.linkLabel1.Size = New System.Drawing.Size(219, 12)
            Me.linkLabel1.TabIndex = 28
            Me.linkLabel1.TabStop = True
            Me.linkLabel1.Text = "http://www.cnblogs.com/powertoolsteam/"
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.ErrorImage = Nothing
            Me.pictureBox1.Image = My.Resources.cube
            Me.pictureBox1.Location = New System.Drawing.Point(23, 14)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(137, 107)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 27
            Me.pictureBox1.TabStop = False
            ' 
            ' checkedListBox1
            ' 
            Me.checkedListBox1.FormattingEnabled = True
            Me.checkedListBox1.Items.AddRange(New Object() {"Cola", "Chips", "Hamburger", "Fried chicken", "Ice cream", "Other"})
            Me.checkedListBox1.Location = New System.Drawing.Point(23, 147)
            Me.checkedListBox1.Name = "checkedListBox1"
            Me.checkedListBox1.Size = New System.Drawing.Size(137, 88)
            Me.checkedListBox1.TabIndex = 26
            ' 
            ' listBox2
            ' 
            Me.listBox2.FormattingEnabled = True
            Me.listBox2.ItemHeight = 12
            Me.listBox2.Items.AddRange(New Object() {"Aries  (3/21-4/20)", "Taurus（4/21-5/21）", "Gemini （5/22-6/21）", "Cancer （6/22-7/22）", "Leo （7/23-8/23）", "Virgo （8/24-9/23）", _
                "Libra （9/24-10/23）", "Scorpio （10/24-11/22）", "Sagittarius （11/23-12/21）", "Capricorn （12/22-1/20）", "Aquarius （1/21-2/19）", "Pisces （2/20-3/20）"})
            Me.listBox2.Location = New System.Drawing.Point(210, 144)
            Me.listBox2.Name = "listBox2"
            Me.listBox2.Size = New System.Drawing.Size(166, 148)
            Me.listBox2.TabIndex = 25
            ' 
            ' Help
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 12.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(742, 479)
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Controls.Add(Me.statusStrip1)
            Me.Controls.Add(Me.menuStrip1)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Help"
            Me.Text = "Help"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            Me.statusStrip1.ResumeLayout(False)
            Me.statusStrip1.PerformLayout()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.gcZoomPanel1.ResumeLayout(False)
            Me.groupBox3.ResumeLayout(False)
            Me.groupBox3.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            DirectCast(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private menuStrip1 As System.Windows.Forms.MenuStrip
        Private statusStrip1 As System.Windows.Forms.StatusStrip
        Private toolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
        Private saveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private toolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private panel1 As System.Windows.Forms.Panel
        Private label2 As System.Windows.Forms.Label
        Private listBox1 As System.Windows.Forms.ListBox
        Private button1 As System.Windows.Forms.Button
        Private gcZoomPanel1 As C1.Win.TouchToolKit.C1ZoomPanel
        Private button3 As System.Windows.Forms.Button
        Private button2 As System.Windows.Forms.Button
        Private groupBox3 As System.Windows.Forms.GroupBox
        Private label7 As System.Windows.Forms.Label
        Private label6 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private label5 As System.Windows.Forms.Label
        Private label4 As System.Windows.Forms.Label
        Private label8 As System.Windows.Forms.Label
        Private groupBox1 As System.Windows.Forms.GroupBox
        Private radioButton2 As System.Windows.Forms.RadioButton
        Private radioButton1 As System.Windows.Forms.RadioButton
        Private textBox2 As System.Windows.Forms.TextBox
        Private progressBar1 As System.Windows.Forms.ProgressBar
        Private numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private linkLabel1 As System.Windows.Forms.LinkLabel
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private checkedListBox1 As System.Windows.Forms.CheckedListBox
        Private listBox2 As System.Windows.Forms.ListBox




    End Class
End Namespace
