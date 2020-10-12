Namespace C1ZoomPages
    Partial Class PanWindowDemo
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
            Me.locationPanel = New System.Windows.Forms.Panel()
            Me.locationErrorLabel = New System.Windows.Forms.Label()
            Me.llabel2 = New System.Windows.Forms.Label()
            Me.xTextBox = New System.Windows.Forms.TextBox()
            Me.yTextBox = New System.Windows.Forms.TextBox()
            Me.llabel1 = New System.Windows.Forms.Label()
            Me.sizePanel = New System.Windows.Forms.Panel()
            Me.sizeErrorLabel = New System.Windows.Forms.Label()
            Me.slabel1 = New System.Windows.Forms.Label()
            Me.wTextBox = New System.Windows.Forms.TextBox()
            Me.slabel2 = New System.Windows.Forms.Label()
            Me.hTextBox = New System.Windows.Forms.TextBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.ssRadioButton = New System.Windows.Forms.RadioButton()
            Me.lsRadioButton = New System.Windows.Forms.RadioButton()
            Me.lRadioButton = New System.Windows.Forms.RadioButton()
            Me.sRadioButton = New System.Windows.Forms.RadioButton()
            Me.noPRadioButton = New System.Windows.Forms.RadioButton()
            Me.formStartPositionGroupBox = New System.Windows.Forms.GroupBox()
            Me.CenterParentRadioButton = New System.Windows.Forms.RadioButton()
            Me.WindowsDefaultBoundsRadioButton = New System.Windows.Forms.RadioButton()
            Me.WindowsDefaultLocationRadioButton = New System.Windows.Forms.RadioButton()
            Me.CenterScreenRadioButton = New System.Windows.Forms.RadioButton()
            Me.ManualRadioButton = New System.Windows.Forms.RadioButton()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.formButton = New System.Windows.Forms.Button()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.panel1.SuspendLayout()
            Me.locationPanel.SuspendLayout()
            Me.sizePanel.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.formStartPositionGroupBox.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.tableLayoutPanel1)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.panel2)
            ' 
            ' locationPanel
            ' 
            Me.locationPanel.Controls.Add(Me.locationErrorLabel)
            Me.locationPanel.Controls.Add(Me.llabel2)
            Me.locationPanel.Controls.Add(Me.xTextBox)
            Me.locationPanel.Controls.Add(Me.yTextBox)
            Me.locationPanel.Controls.Add(Me.llabel1)
            Me.locationPanel.Location = New System.Drawing.Point(3, 373)
            Me.locationPanel.Name = "locationPanel"
            Me.locationPanel.Size = New System.Drawing.Size(422, 60)
            Me.locationPanel.TabIndex = 40
            ' 
            ' locationErrorLabel
            ' 
            Me.locationErrorLabel.AutoSize = True
            Me.locationErrorLabel.Location = New System.Drawing.Point(177, 36)
            Me.locationErrorLabel.Name = "locationErrorLabel"
            Me.locationErrorLabel.Size = New System.Drawing.Size(235, 23)
            Me.locationErrorLabel.TabIndex = 47
            Me.locationErrorLabel.Text = "Please write the right location."
            ' 
            ' llabel2
            ' 
            Me.llabel2.AutoSize = True
            Me.llabel2.Location = New System.Drawing.Point(227, 6)
            Me.llabel2.Name = "llabel2"
            Me.llabel2.Size = New System.Drawing.Size(15, 23)
            Me.llabel2.TabIndex = 46
            Me.llabel2.Text = ","
            ' 
            ' xTextBox
            ' 
            Me.xTextBox.Location = New System.Drawing.Point(88, 3)
            Me.xTextBox.Name = "xTextBox"
            Me.xTextBox.Size = New System.Drawing.Size(133, 30)
            Me.xTextBox.TabIndex = 44
            Me.xTextBox.Text = "200"
            ' 
            ' yTextBox
            ' 
            Me.yTextBox.Location = New System.Drawing.Point(245, 3)
            Me.yTextBox.Name = "yTextBox"
            Me.yTextBox.Size = New System.Drawing.Size(133, 30)
            Me.yTextBox.TabIndex = 45
            Me.yTextBox.Text = "200"
            ' 
            ' llabel1
            ' 
            Me.llabel1.AutoSize = True
            Me.llabel1.Location = New System.Drawing.Point(3, 6)
            Me.llabel1.Name = "llabel1"
            Me.llabel1.Size = New System.Drawing.Size(78, 23)
            Me.llabel1.TabIndex = 43
            Me.llabel1.Text = "Location:"
            ' 
            ' sizePanel
            ' 
            Me.sizePanel.Controls.Add(Me.sizeErrorLabel)
            Me.sizePanel.Controls.Add(Me.slabel1)
            Me.sizePanel.Controls.Add(Me.wTextBox)
            Me.sizePanel.Controls.Add(Me.slabel2)
            Me.sizePanel.Controls.Add(Me.hTextBox)
            Me.sizePanel.Location = New System.Drawing.Point(3, 307)
            Me.sizePanel.Name = "sizePanel"
            Me.sizePanel.Size = New System.Drawing.Size(422, 60)
            Me.sizePanel.TabIndex = 40
            ' 
            ' sizeErrorLabel
            ' 
            Me.sizeErrorLabel.AutoSize = True
            Me.sizeErrorLabel.Location = New System.Drawing.Point(177, 36)
            Me.sizeErrorLabel.Name = "sizeErrorLabel"
            Me.sizeErrorLabel.Size = New System.Drawing.Size(205, 23)
            Me.sizeErrorLabel.TabIndex = 38
            Me.sizeErrorLabel.Text = "Please write the right size."
            ' 
            ' slabel1
            ' 
            Me.slabel1.AutoSize = True
            Me.slabel1.Location = New System.Drawing.Point(3, 6)
            Me.slabel1.Name = "slabel1"
            Me.slabel1.Size = New System.Drawing.Size(47, 23)
            Me.slabel1.TabIndex = 31
            Me.slabel1.Text = "Size:"
            ' 
            ' wTextBox
            ' 
            Me.wTextBox.Location = New System.Drawing.Point(88, 3)
            Me.wTextBox.Name = "wTextBox"
            Me.wTextBox.Size = New System.Drawing.Size(133, 30)
            Me.wTextBox.TabIndex = 33
            Me.wTextBox.Text = "200"
            ' 
            ' slabel2
            ' 
            Me.slabel2.AutoSize = True
            Me.slabel2.Location = New System.Drawing.Point(227, 6)
            Me.slabel2.Name = "slabel2"
            Me.slabel2.Size = New System.Drawing.Size(15, 23)
            Me.slabel2.TabIndex = 37
            Me.slabel2.Text = ","
            ' 
            ' hTextBox
            ' 
            Me.hTextBox.Location = New System.Drawing.Point(245, 3)
            Me.hTextBox.Name = "hTextBox"
            Me.hTextBox.Size = New System.Drawing.Size(133, 30)
            Me.hTextBox.TabIndex = 34
            Me.hTextBox.Text = "200"
            ' 
            ' groupBox2
            ' 
            Me.groupBox2.Controls.Add(Me.ssRadioButton)
            Me.groupBox2.Controls.Add(Me.lsRadioButton)
            Me.groupBox2.Controls.Add(Me.lRadioButton)
            Me.groupBox2.Controls.Add(Me.sRadioButton)
            Me.groupBox2.Controls.Add(Me.noPRadioButton)
            Me.groupBox2.Location = New System.Drawing.Point(3, 3)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(423, 165)
            Me.groupBox2.TabIndex = 41
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Choose a method to show panWindow:"
            ' 
            ' ssRadioButton
            ' 
            Me.ssRadioButton.AutoSize = True
            Me.ssRadioButton.Location = New System.Drawing.Point(6, 80)
            Me.ssRadioButton.Name = "ssRadioButton"
            Me.ssRadioButton.Size = New System.Drawing.Size(392, 27)
            Me.ssRadioButton.TabIndex = 4
            Me.ssRadioButton.Text = "Form ShowPanWindow(FormStartPosition, Size);"
            Me.ssRadioButton.UseVisualStyleBackColor = True
            ' 
            ' lsRadioButton
            ' 
            Me.lsRadioButton.AutoSize = True
            Me.lsRadioButton.Location = New System.Drawing.Point(6, 137)
            Me.lsRadioButton.Name = "lsRadioButton"
            Me.lsRadioButton.Size = New System.Drawing.Size(297, 27)
            Me.lsRadioButton.TabIndex = 3
            Me.lsRadioButton.Text = "Form ShowPanWindow(Point, Size);"
            Me.lsRadioButton.UseVisualStyleBackColor = True
            ' 
            ' lRadioButton
            ' 
            Me.lRadioButton.AutoSize = True
            Me.lRadioButton.Location = New System.Drawing.Point(6, 108)
            Me.lRadioButton.Name = "lRadioButton"
            Me.lRadioButton.Size = New System.Drawing.Size(256, 27)
            Me.lRadioButton.TabIndex = 2
            Me.lRadioButton.Text = "Form ShowPanWindow(Point);"
            Me.lRadioButton.UseVisualStyleBackColor = True
            ' 
            ' sRadioButton
            ' 
            Me.sRadioButton.AutoSize = True
            Me.sRadioButton.Location = New System.Drawing.Point(6, 52)
            Me.sRadioButton.Name = "sRadioButton"
            Me.sRadioButton.Size = New System.Drawing.Size(351, 27)
            Me.sRadioButton.TabIndex = 1
            Me.sRadioButton.Text = "Form ShowPanWindow(FormStartPosition);"
            Me.sRadioButton.UseVisualStyleBackColor = True
            ' 
            ' noPRadioButton
            ' 
            Me.noPRadioButton.AutoSize = True
            Me.noPRadioButton.Checked = True
            Me.noPRadioButton.Location = New System.Drawing.Point(6, 24)
            Me.noPRadioButton.Name = "noPRadioButton"
            Me.noPRadioButton.Size = New System.Drawing.Size(219, 27)
            Me.noPRadioButton.TabIndex = 0
            Me.noPRadioButton.TabStop = True
            Me.noPRadioButton.Text = "Form ShowPanWindow();"
            Me.noPRadioButton.UseVisualStyleBackColor = True
            ' 
            ' formStartPositionGroupBox
            ' 
            Me.formStartPositionGroupBox.Controls.Add(Me.CenterParentRadioButton)
            Me.formStartPositionGroupBox.Controls.Add(Me.WindowsDefaultBoundsRadioButton)
            Me.formStartPositionGroupBox.Controls.Add(Me.WindowsDefaultLocationRadioButton)
            Me.formStartPositionGroupBox.Controls.Add(Me.CenterScreenRadioButton)
            Me.formStartPositionGroupBox.Controls.Add(Me.ManualRadioButton)
            Me.formStartPositionGroupBox.Location = New System.Drawing.Point(3, 174)
            Me.formStartPositionGroupBox.Name = "formStartPositionGroupBox"
            Me.formStartPositionGroupBox.Size = New System.Drawing.Size(422, 127)
            Me.formStartPositionGroupBox.TabIndex = 40
            Me.formStartPositionGroupBox.TabStop = False
            Me.formStartPositionGroupBox.Text = "FormStartPosition"
            ' 
            ' CenterParentRadioButton
            ' 
            Me.CenterParentRadioButton.AutoSize = True
            Me.CenterParentRadioButton.Location = New System.Drawing.Point(12, 93)
            Me.CenterParentRadioButton.Name = "CenterParentRadioButton"
            Me.CenterParentRadioButton.Size = New System.Drawing.Size(128, 27)
            Me.CenterParentRadioButton.TabIndex = 4
            Me.CenterParentRadioButton.Text = "CenterParent"
            Me.CenterParentRadioButton.UseVisualStyleBackColor = True
            ' 
            ' WindowsDefaultBoundsRadioButton
            ' 
            Me.WindowsDefaultBoundsRadioButton.AutoSize = True
            Me.WindowsDefaultBoundsRadioButton.Location = New System.Drawing.Point(171, 27)
            Me.WindowsDefaultBoundsRadioButton.Name = "WindowsDefaultBoundsRadioButton"
            Me.WindowsDefaultBoundsRadioButton.Size = New System.Drawing.Size(202, 27)
            Me.WindowsDefaultBoundsRadioButton.TabIndex = 3
            Me.WindowsDefaultBoundsRadioButton.Text = "WindowsDefaultBounds"
            Me.WindowsDefaultBoundsRadioButton.UseVisualStyleBackColor = True
            ' 
            ' WindowsDefaultLocationRadioButton
            ' 
            Me.WindowsDefaultLocationRadioButton.AutoSize = True
            Me.WindowsDefaultLocationRadioButton.Location = New System.Drawing.Point(171, 60)
            Me.WindowsDefaultLocationRadioButton.Name = "WindowsDefaultLocationRadioButton"
            Me.WindowsDefaultLocationRadioButton.Size = New System.Drawing.Size(211, 27)
            Me.WindowsDefaultLocationRadioButton.TabIndex = 2
            Me.WindowsDefaultLocationRadioButton.Text = "WindowsDefaultLocation"
            Me.WindowsDefaultLocationRadioButton.UseVisualStyleBackColor = True
            ' 
            ' CenterScreenRadioButton
            ' 
            Me.CenterScreenRadioButton.AutoSize = True
            Me.CenterScreenRadioButton.Location = New System.Drawing.Point(12, 60)
            Me.CenterScreenRadioButton.Name = "CenterScreenRadioButton"
            Me.CenterScreenRadioButton.Size = New System.Drawing.Size(131, 27)
            Me.CenterScreenRadioButton.TabIndex = 1
            Me.CenterScreenRadioButton.Text = "CenterScreen"
            Me.CenterScreenRadioButton.UseVisualStyleBackColor = True
            ' 
            ' ManualRadioButton
            ' 
            Me.ManualRadioButton.AutoSize = True
            Me.ManualRadioButton.Checked = True
            Me.ManualRadioButton.Location = New System.Drawing.Point(12, 27)
            Me.ManualRadioButton.Name = "ManualRadioButton"
            Me.ManualRadioButton.Size = New System.Drawing.Size(83, 27)
            Me.ManualRadioButton.TabIndex = 0
            Me.ManualRadioButton.TabStop = True
            Me.ManualRadioButton.Text = "Manual"
            Me.ManualRadioButton.UseVisualStyleBackColor = True
            ' 
            ' splitter1
            ' 
            Me.splitter1.BackColor = System.Drawing.Color.LightGray
            Me.splitter1.Enabled = False
            Me.splitter1.Location = New System.Drawing.Point(255, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 400)
            Me.splitter1.TabIndex = 16
            Me.splitter1.TabStop = False
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.locationPanel, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.groupBox2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.formStartPositionGroupBox, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.sizePanel, 0, 2)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(258, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 4
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(432, 400)
            Me.tableLayoutPanel1.TabIndex = 17
            ' 
            ' formButton
            ' 
            Me.formButton.Location = New System.Drawing.Point(7, 11)
            Me.formButton.Name = "formButton"
            Me.formButton.Size = New System.Drawing.Size(240, 55)
            Me.formButton.TabIndex = 33
            Me.formButton.Text = "Show Form"
            Me.formButton.UseVisualStyleBackColor = True
            AddHandler Me.formButton.Click, New EventHandler(AddressOf Me.formButton_Click)
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.formButton)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(255, 400)
            Me.panel2.TabIndex = 15
            ' 
            ' PanWindowDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PanWindowDemo"
            Me.panel1.ResumeLayout(False)
            Me.locationPanel.ResumeLayout(False)
            Me.locationPanel.PerformLayout()
            Me.sizePanel.ResumeLayout(False)
            Me.sizePanel.PerformLayout()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.formStartPositionGroupBox.ResumeLayout(False)
            Me.formStartPositionGroupBox.PerformLayout()
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private formStartPositionGroupBox As System.Windows.Forms.GroupBox
        Private CenterParentRadioButton As System.Windows.Forms.RadioButton
        Private WindowsDefaultBoundsRadioButton As System.Windows.Forms.RadioButton
        Private WindowsDefaultLocationRadioButton As System.Windows.Forms.RadioButton
        Private CenterScreenRadioButton As System.Windows.Forms.RadioButton
        Private ManualRadioButton As System.Windows.Forms.RadioButton
        Private hTextBox As System.Windows.Forms.TextBox
        Private wTextBox As System.Windows.Forms.TextBox
        Private slabel2 As System.Windows.Forms.Label
        Private slabel1 As System.Windows.Forms.Label
        Private splitter1 As System.Windows.Forms.Splitter
        Private groupBox2 As System.Windows.Forms.GroupBox
        Private ssRadioButton As System.Windows.Forms.RadioButton
        Private lsRadioButton As System.Windows.Forms.RadioButton
        Private lRadioButton As System.Windows.Forms.RadioButton
        Private sRadioButton As System.Windows.Forms.RadioButton
        Private noPRadioButton As System.Windows.Forms.RadioButton
        Private locationPanel As System.Windows.Forms.Panel
        Private llabel2 As System.Windows.Forms.Label
        Private xTextBox As System.Windows.Forms.TextBox
        Private yTextBox As System.Windows.Forms.TextBox
        Private llabel1 As System.Windows.Forms.Label
        Private sizePanel As System.Windows.Forms.Panel
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private locationErrorLabel As System.Windows.Forms.Label
        Private sizeErrorLabel As System.Windows.Forms.Label
        Private panel2 As System.Windows.Forms.Panel
        Private formButton As System.Windows.Forms.Button
    End Class
End Namespace
