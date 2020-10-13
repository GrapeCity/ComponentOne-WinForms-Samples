Namespace C1MagnifyPages
    Partial Class C1MagnifyCommon
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
            Me.gcMagnifier1 = New C1.Win.TouchToolKit.C1Magnify()
            Me.selectTextBox = New System.Windows.Forms.TextBox()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.groupBox4 = New System.Windows.Forms.GroupBox()
            Me.moveRadioButton = New System.Windows.Forms.RadioButton()
            Me.moveLeftDownRadioButton = New System.Windows.Forms.RadioButton()
            Me.moveNoneRadioButton = New System.Windows.Forms.RadioButton()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.panel3 = New System.Windows.Forms.Panel()
            Me.tabControl1 = New System.Windows.Forms.TabControl()
            Me.tabPage1 = New System.Windows.Forms.TabPage()
            Me.groupBox5 = New System.Windows.Forms.GroupBox()
            Me.closeRightRadioButton = New System.Windows.Forms.RadioButton()
            Me.closeLeftRadioButton = New System.Windows.Forms.RadioButton()
            Me.closeNoneRadioButton = New System.Windows.Forms.RadioButton()
            Me.popupDelayLabel = New System.Windows.Forms.Label()
            Me.PopupDelayTrackBar = New System.Windows.Forms.TrackBar()
            Me.IsHorizontalRailEnabledCheckBox = New System.Windows.Forms.CheckBox()
            Me.IsVerticalRailEnalbedCheckBox = New System.Windows.Forms.CheckBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.tabPage2 = New System.Windows.Forms.TabPage()
            Me.groupBox3 = New System.Windows.Forms.GroupBox()
            Me.roundedRectangleRadioButton = New System.Windows.Forms.RadioButton()
            Me.rectangleRadioButton = New System.Windows.Forms.RadioButton()
            Me.circleRadioButton = New System.Windows.Forms.RadioButton()
            Me.ShowCursorCheckbox = New System.Windows.Forms.CheckBox()
            Me.zoomfactorTrackBar = New System.Windows.Forms.TrackBar()
            Me.sizeLabel = New System.Windows.Forms.Label()
            Me.zoomFactorLabel = New System.Windows.Forms.Label()
            Me.sizeTrackBar = New System.Windows.Forms.TrackBar()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.tabPage3 = New System.Windows.Forms.TabPage()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.customRadioButton = New System.Windows.Forms.RadioButton()
            Me.darkRadioButton = New System.Windows.Forms.RadioButton()
            Me.lightRadioButton = New System.Windows.Forms.RadioButton()
            Me.panel5 = New System.Windows.Forms.Panel()
            Me.borderWidthlabel = New System.Windows.Forms.Label()
            Me.borderWidthTrackBar = New System.Windows.Forms.TrackBar()
            Me.label5 = New System.Windows.Forms.Label()
            Me.customBackgroundSetting = New System.Windows.Forms.GroupBox()
            Me.label13 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.SelectImageButton = New System.Windows.Forms.Button()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.groupBox4.SuspendLayout()
            Me.panel3.SuspendLayout()
            Me.tabControl1.SuspendLayout()
            Me.tabPage1.SuspendLayout()
            Me.groupBox5.SuspendLayout()
            DirectCast(Me.PopupDelayTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage2.SuspendLayout()
            Me.groupBox3.SuspendLayout()
            DirectCast(Me.zoomfactorTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.sizeTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage3.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.panel5.SuspendLayout()
            DirectCast(Me.borderWidthTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.customBackgroundSetting.SuspendLayout()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.panel3)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.panel2)
            ' 
            ' selectTextBox
            ' 
            Me.gcMagnifier1.SetEnableMagnifier(Me.selectTextBox, True)
            Me.selectTextBox.Location = New System.Drawing.Point(19, 113)
            Me.selectTextBox.Multiline = True
            Me.selectTextBox.Name = "selectTextBox"
            Me.selectTextBox.Size = New System.Drawing.Size(253, 60)
            Me.selectTextBox.TabIndex = 28
            Me.selectTextBox.Text = "Try to select a part of string to copy by C1Magnify component"
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.textBox1)
            Me.panel2.Controls.Add(Me.selectTextBox)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(294, 400)
            Me.panel2.TabIndex = 1
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(19, 38)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(253, 60)
            Me.textBox1.TabIndex = 30
            Me.textBox1.Text = "Try to select a part of string to copy typically."
            ' 
            ' groupBox4
            ' 
            Me.groupBox4.Controls.Add(Me.moveRadioButton)
            Me.groupBox4.Controls.Add(Me.moveLeftDownRadioButton)
            Me.groupBox4.Controls.Add(Me.moveNoneRadioButton)
            Me.groupBox4.Location = New System.Drawing.Point(12, 12)
            Me.groupBox4.Name = "groupBox4"
            Me.groupBox4.Size = New System.Drawing.Size(361, 68)
            Me.groupBox4.TabIndex = 30
            Me.groupBox4.TabStop = False
            Me.groupBox4.Text = "Message When Move Magnifier"
            ' 
            ' moveRadioButton
            ' 
            Me.moveRadioButton.AutoSize = True
            Me.moveRadioButton.Checked = True
            Me.moveRadioButton.Location = New System.Drawing.Point(141, 27)
            Me.moveRadioButton.Name = "moveRadioButton"
            Me.moveRadioButton.Size = New System.Drawing.Size(69, 27)
            Me.moveRadioButton.TabIndex = 2
            Me.moveRadioButton.TabStop = True
            Me.moveRadioButton.Text = "Move"
            Me.moveRadioButton.UseVisualStyleBackColor = True
            ' 
            ' moveLeftDownRadioButton
            ' 
            Me.moveLeftDownRadioButton.AutoSize = True
            Me.moveLeftDownRadioButton.Location = New System.Drawing.Point(250, 27)
            Me.moveLeftDownRadioButton.Name = "moveLeftDownRadioButton"
            Me.moveLeftDownRadioButton.Size = New System.Drawing.Size(105, 27)
            Me.moveLeftDownRadioButton.TabIndex = 1
            Me.moveLeftDownRadioButton.Text = "Left Down"
            Me.moveLeftDownRadioButton.UseVisualStyleBackColor = True
            ' 
            ' moveNoneRadioButton
            ' 
            Me.moveNoneRadioButton.AutoSize = True
            Me.moveNoneRadioButton.Location = New System.Drawing.Point(17, 25)
            Me.moveNoneRadioButton.Name = "moveNoneRadioButton"
            Me.moveNoneRadioButton.Size = New System.Drawing.Size(118, 27)
            Me.moveNoneRadioButton.TabIndex = 0
            Me.moveNoneRadioButton.Text = "No Message"
            Me.moveNoneRadioButton.UseVisualStyleBackColor = True
            ' 
            ' splitter1
            ' 
            Me.splitter1.BackColor = System.Drawing.Color.LightGray
            Me.splitter1.Enabled = False
            Me.splitter1.Location = New System.Drawing.Point(294, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 400)
            Me.splitter1.TabIndex = 2
            Me.splitter1.TabStop = False
            ' 
            ' panel3
            ' 
            Me.panel3.Controls.Add(Me.tabControl1)
            Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel3.Location = New System.Drawing.Point(297, 0)
            Me.panel3.Name = "panel3"
            Me.panel3.Size = New System.Drawing.Size(393, 400)
            Me.panel3.TabIndex = 3
            ' 
            ' tabControl1
            ' 
            Me.tabControl1.Controls.Add(Me.tabPage1)
            Me.tabControl1.Controls.Add(Me.tabPage2)
            Me.tabControl1.Controls.Add(Me.tabPage3)
            Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabControl1.Location = New System.Drawing.Point(0, 0)
            Me.tabControl1.Name = "tabControl1"
            Me.tabControl1.SelectedIndex = 0
            Me.tabControl1.Size = New System.Drawing.Size(393, 400)
            Me.tabControl1.TabIndex = 40
            ' 
            ' tabPage1
            ' 
            Me.tabPage1.Controls.Add(Me.groupBox5)
            Me.tabPage1.Controls.Add(Me.popupDelayLabel)
            Me.tabPage1.Controls.Add(Me.groupBox4)
            Me.tabPage1.Controls.Add(Me.PopupDelayTrackBar)
            Me.tabPage1.Controls.Add(Me.IsHorizontalRailEnabledCheckBox)
            Me.tabPage1.Controls.Add(Me.IsVerticalRailEnalbedCheckBox)
            Me.tabPage1.Controls.Add(Me.label8)
            Me.tabPage1.Location = New System.Drawing.Point(4, 32)
            Me.tabPage1.Name = "tabPage1"
            Me.tabPage1.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage1.Size = New System.Drawing.Size(385, 364)
            Me.tabPage1.TabIndex = 0
            Me.tabPage1.Text = "Behavior"
            Me.tabPage1.UseVisualStyleBackColor = True
            ' 
            ' groupBox5
            ' 
            Me.groupBox5.Controls.Add(Me.closeRightRadioButton)
            Me.groupBox5.Controls.Add(Me.closeLeftRadioButton)
            Me.groupBox5.Controls.Add(Me.closeNoneRadioButton)
            Me.groupBox5.Location = New System.Drawing.Point(12, 86)
            Me.groupBox5.Name = "groupBox5"
            Me.groupBox5.Size = New System.Drawing.Size(361, 68)
            Me.groupBox5.TabIndex = 31
            Me.groupBox5.TabStop = False
            Me.groupBox5.Text = "Message When Close Magnifier"
            ' 
            ' closeRightRadioButton
            ' 
            Me.closeRightRadioButton.AutoSize = True
            Me.closeRightRadioButton.Location = New System.Drawing.Point(141, 28)
            Me.closeRightRadioButton.Name = "closeRightRadioButton"
            Me.closeRightRadioButton.Size = New System.Drawing.Size(108, 27)
            Me.closeRightRadioButton.TabIndex = 2
            Me.closeRightRadioButton.Text = "Right Click"
            Me.closeRightRadioButton.UseVisualStyleBackColor = True
            ' 
            ' closeLeftRadioButton
            ' 
            Me.closeLeftRadioButton.AutoSize = True
            Me.closeLeftRadioButton.Location = New System.Drawing.Point(250, 28)
            Me.closeLeftRadioButton.Name = "closeLeftRadioButton"
            Me.closeLeftRadioButton.Size = New System.Drawing.Size(98, 27)
            Me.closeLeftRadioButton.TabIndex = 1
            Me.closeLeftRadioButton.Text = "Left Click"
            Me.closeLeftRadioButton.UseVisualStyleBackColor = True
            ' 
            ' closeNoneRadioButton
            ' 
            Me.closeNoneRadioButton.AutoSize = True
            Me.closeNoneRadioButton.Checked = True
            Me.closeNoneRadioButton.Location = New System.Drawing.Point(17, 28)
            Me.closeNoneRadioButton.Name = "closeNoneRadioButton"
            Me.closeNoneRadioButton.Size = New System.Drawing.Size(118, 27)
            Me.closeNoneRadioButton.TabIndex = 0
            Me.closeNoneRadioButton.TabStop = True
            Me.closeNoneRadioButton.Text = "No Message"
            Me.closeNoneRadioButton.UseVisualStyleBackColor = True
            ' 
            ' popupDelayLabel
            ' 
            Me.popupDelayLabel.AutoSize = True
            Me.popupDelayLabel.Location = New System.Drawing.Point(149, 176)
            Me.popupDelayLabel.Name = "popupDelayLabel"
            Me.popupDelayLabel.Size = New System.Drawing.Size(58, 23)
            Me.popupDelayLabel.TabIndex = 55
            Me.popupDelayLabel.Text = "500ms"
            ' 
            ' PopupDelayTrackBar
            ' 
            Me.PopupDelayTrackBar.BackColor = System.Drawing.Color.White
            Me.PopupDelayTrackBar.LargeChange = 100
            Me.PopupDelayTrackBar.Location = New System.Drawing.Point(198, 172)
            Me.PopupDelayTrackBar.Maximum = 1000
            Me.PopupDelayTrackBar.Minimum = 1
            Me.PopupDelayTrackBar.Name = "PopupDelayTrackBar"
            Me.PopupDelayTrackBar.Size = New System.Drawing.Size(167, 56)
            Me.PopupDelayTrackBar.SmallChange = 100
            Me.PopupDelayTrackBar.TabIndex = 54
            Me.PopupDelayTrackBar.TickFrequency = 100
            Me.PopupDelayTrackBar.Value = 500
            ' 
            ' IsHorizontalRailEnabledCheckBox
            ' 
            Me.IsHorizontalRailEnabledCheckBox.AutoSize = True
            Me.IsHorizontalRailEnabledCheckBox.Location = New System.Drawing.Point(33, 257)
            Me.IsHorizontalRailEnabledCheckBox.Name = "IsHorizontalRailEnabledCheckBox"
            Me.IsHorizontalRailEnabledCheckBox.Size = New System.Drawing.Size(205, 27)
            Me.IsHorizontalRailEnabledCheckBox.TabIndex = 52
            Me.IsHorizontalRailEnabledCheckBox.Text = "IsHorizontalRailEnabled"
            Me.IsHorizontalRailEnabledCheckBox.UseVisualStyleBackColor = True
            ' 
            ' IsVerticalRailEnalbedCheckBox
            ' 
            Me.IsVerticalRailEnalbedCheckBox.AutoSize = True
            Me.IsVerticalRailEnalbedCheckBox.Location = New System.Drawing.Point(33, 224)
            Me.IsVerticalRailEnalbedCheckBox.Name = "IsVerticalRailEnalbedCheckBox"
            Me.IsVerticalRailEnalbedCheckBox.Size = New System.Drawing.Size(185, 27)
            Me.IsVerticalRailEnalbedCheckBox.TabIndex = 53
            Me.IsVerticalRailEnalbedCheckBox.Text = "IsVerticalRailEnalbed"
            Me.IsVerticalRailEnalbedCheckBox.UseVisualStyleBackColor = True
            ' 
            ' label8
            ' 
            Me.label8.AutoSize = True
            Me.label8.Location = New System.Drawing.Point(30, 176)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(102, 23)
            Me.label8.TabIndex = 50
            Me.label8.Text = "PopupDelay:"
            ' 
            ' tabPage2
            ' 
            Me.tabPage2.Controls.Add(Me.groupBox3)
            Me.tabPage2.Controls.Add(Me.ShowCursorCheckbox)
            Me.tabPage2.Controls.Add(Me.zoomfactorTrackBar)
            Me.tabPage2.Controls.Add(Me.sizeLabel)
            Me.tabPage2.Controls.Add(Me.zoomFactorLabel)
            Me.tabPage2.Controls.Add(Me.sizeTrackBar)
            Me.tabPage2.Controls.Add(Me.label9)
            Me.tabPage2.Controls.Add(Me.label11)
            Me.tabPage2.Location = New System.Drawing.Point(4, 32)
            Me.tabPage2.Name = "tabPage2"
            Me.tabPage2.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage2.Size = New System.Drawing.Size(385, 364)
            Me.tabPage2.TabIndex = 1
            Me.tabPage2.Text = "Shape"
            Me.tabPage2.UseVisualStyleBackColor = True
            ' 
            ' groupBox3
            ' 
            Me.groupBox3.Controls.Add(Me.roundedRectangleRadioButton)
            Me.groupBox3.Controls.Add(Me.rectangleRadioButton)
            Me.groupBox3.Controls.Add(Me.circleRadioButton)
            Me.groupBox3.Location = New System.Drawing.Point(3, 3)
            Me.groupBox3.Name = "groupBox3"
            Me.groupBox3.Size = New System.Drawing.Size(373, 155)
            Me.groupBox3.TabIndex = 64
            Me.groupBox3.TabStop = False
            Me.groupBox3.Text = "Magnifier Shape"
            ' 
            ' roundedRectangleRadioButton
            ' 
            Me.roundedRectangleRadioButton.BackgroundImage = My.Resources.MagnifierRoundedRectangle
            Me.roundedRectangleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.roundedRectangleRadioButton.Location = New System.Drawing.Point(253, 35)
            Me.roundedRectangleRadioButton.Name = "roundedRectangleRadioButton"
            Me.roundedRectangleRadioButton.Size = New System.Drawing.Size(110, 99)
            Me.roundedRectangleRadioButton.TabIndex = 2
            Me.roundedRectangleRadioButton.UseVisualStyleBackColor = True
            ' 
            ' rectangleRadioButton
            ' 
            Me.rectangleRadioButton.BackgroundImage = My.Resources.MagnifierRectangle
            Me.rectangleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.rectangleRadioButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.rectangleRadioButton.Location = New System.Drawing.Point(129, 35)
            Me.rectangleRadioButton.Name = "rectangleRadioButton"
            Me.rectangleRadioButton.Size = New System.Drawing.Size(119, 99)
            Me.rectangleRadioButton.TabIndex = 1
            Me.rectangleRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.rectangleRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.rectangleRadioButton.UseVisualStyleBackColor = True
            ' 
            ' circleRadioButton
            ' 
            Me.circleRadioButton.BackgroundImage = My.Resources.MagnifierCircle
            Me.circleRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.circleRadioButton.Checked = True
            Me.circleRadioButton.Location = New System.Drawing.Point(6, 35)
            Me.circleRadioButton.Name = "circleRadioButton"
            Me.circleRadioButton.Size = New System.Drawing.Size(117, 99)
            Me.circleRadioButton.TabIndex = 0
            Me.circleRadioButton.TabStop = True
            Me.circleRadioButton.UseVisualStyleBackColor = True
            ' 
            ' ShowCursorCheckbox
            ' 
            Me.ShowCursorCheckbox.AutoSize = True
            Me.ShowCursorCheckbox.Location = New System.Drawing.Point(13, 304)
            Me.ShowCursorCheckbox.Name = "ShowCursorCheckbox"
            Me.ShowCursorCheckbox.Size = New System.Drawing.Size(119, 27)
            Me.ShowCursorCheckbox.TabIndex = 55
            Me.ShowCursorCheckbox.Text = "ShowCursor"
            Me.ShowCursorCheckbox.UseVisualStyleBackColor = True
            ' 
            ' zoomfactorTrackBar
            ' 
            Me.zoomfactorTrackBar.AutoSize = False
            Me.zoomfactorTrackBar.BackColor = System.Drawing.Color.White
            Me.zoomfactorTrackBar.LargeChange = 1
            Me.zoomfactorTrackBar.Location = New System.Drawing.Point(204, 245)
            Me.zoomfactorTrackBar.Maximum = 4
            Me.zoomfactorTrackBar.Minimum = 1
            Me.zoomfactorTrackBar.Name = "zoomfactorTrackBar"
            Me.zoomfactorTrackBar.Size = New System.Drawing.Size(156, 31)
            Me.zoomfactorTrackBar.TabIndex = 53
            Me.zoomfactorTrackBar.Value = 2
            ' 
            ' sizeLabel
            ' 
            Me.sizeLabel.AutoSize = True
            Me.sizeLabel.Location = New System.Drawing.Point(115, 187)
            Me.sizeLabel.Name = "sizeLabel"
            Me.sizeLabel.Size = New System.Drawing.Size(83, 23)
            Me.sizeLabel.TabIndex = 52
            Me.sizeLabel.Text = "(100,100)"
            ' 
            ' zoomFactorLabel
            ' 
            Me.zoomFactorLabel.AutoSize = True
            Me.zoomFactorLabel.Location = New System.Drawing.Point(146, 245)
            Me.zoomFactorLabel.Name = "zoomFactorLabel"
            Me.zoomFactorLabel.Size = New System.Drawing.Size(52, 23)
            Me.zoomFactorLabel.TabIndex = 50
            Me.zoomFactorLabel.Text = "200%"
            ' 
            ' sizeTrackBar
            ' 
            Me.sizeTrackBar.AutoSize = False
            Me.sizeTrackBar.BackColor = System.Drawing.Color.White
            Me.sizeTrackBar.LargeChange = 1
            Me.sizeTrackBar.Location = New System.Drawing.Point(204, 183)
            Me.sizeTrackBar.Maximum = 4
            Me.sizeTrackBar.Minimum = 1
            Me.sizeTrackBar.Name = "sizeTrackBar"
            Me.sizeTrackBar.Size = New System.Drawing.Size(156, 31)
            Me.sizeTrackBar.TabIndex = 49
            Me.sizeTrackBar.Value = 1
            ' 
            ' label9
            ' 
            Me.label9.AutoSize = True
            Me.label9.Location = New System.Drawing.Point(10, 187)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(47, 23)
            Me.label9.TabIndex = 36
            Me.label9.Text = "Size:"
            ' 
            ' label11
            ' 
            Me.label11.AutoSize = True
            Me.label11.Location = New System.Drawing.Point(10, 247)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(104, 23)
            Me.label11.TabIndex = 21
            Me.label11.Text = "ZoomFactor:"
            ' 
            ' tabPage3
            ' 
            Me.tabPage3.Controls.Add(Me.tableLayoutPanel1)
            Me.tabPage3.Location = New System.Drawing.Point(4, 32)
            Me.tabPage3.Name = "tabPage3"
            Me.tabPage3.Padding = New System.Windows.Forms.Padding(3)
            Me.tabPage3.Size = New System.Drawing.Size(385, 364)
            Me.tabPage3.TabIndex = 2
            Me.tabPage3.Text = "C1Magnify Border"
            Me.tabPage3.UseVisualStyleBackColor = True
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.groupBox1, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.panel5, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.customBackgroundSetting, 0, 1)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 3
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(379, 358)
            Me.tableLayoutPanel1.TabIndex = 0
            ' 
            ' groupBox1
            ' 
            Me.groupBox1.Controls.Add(Me.customRadioButton)
            Me.groupBox1.Controls.Add(Me.darkRadioButton)
            Me.groupBox1.Controls.Add(Me.lightRadioButton)
            Me.groupBox1.Location = New System.Drawing.Point(3, 3)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(367, 157)
            Me.groupBox1.TabIndex = 63
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Magnifier Border Background Mode"
            ' 
            ' customRadioButton
            ' 
            Me.customRadioButton.BackgroundImage = My.Resources.MagnifierCustom
            Me.customRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.customRadioButton.Location = New System.Drawing.Point(251, 43)
            Me.customRadioButton.Name = "customRadioButton"
            Me.customRadioButton.Size = New System.Drawing.Size(110, 99)
            Me.customRadioButton.TabIndex = 2
            Me.customRadioButton.UseVisualStyleBackColor = True
            ' 
            ' darkRadioButton
            ' 
            Me.darkRadioButton.BackgroundImage = My.Resources.MagnifierDark
            Me.darkRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.darkRadioButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
            Me.darkRadioButton.Location = New System.Drawing.Point(126, 43)
            Me.darkRadioButton.Name = "darkRadioButton"
            Me.darkRadioButton.Size = New System.Drawing.Size(119, 99)
            Me.darkRadioButton.TabIndex = 1
            Me.darkRadioButton.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.darkRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
            Me.darkRadioButton.UseVisualStyleBackColor = True
            ' 
            ' lightRadioButton
            ' 
            Me.lightRadioButton.BackgroundImage = My.Resources.MagnifierCircle
            Me.lightRadioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lightRadioButton.Checked = True
            Me.lightRadioButton.Location = New System.Drawing.Point(6, 43)
            Me.lightRadioButton.Name = "lightRadioButton"
            Me.lightRadioButton.Size = New System.Drawing.Size(117, 99)
            Me.lightRadioButton.TabIndex = 0
            Me.lightRadioButton.TabStop = True
            Me.lightRadioButton.UseVisualStyleBackColor = True
            ' 
            ' panel5
            ' 
            Me.panel5.Controls.Add(Me.borderWidthlabel)
            Me.panel5.Controls.Add(Me.borderWidthTrackBar)
            Me.panel5.Controls.Add(Me.label5)
            Me.panel5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panel5.Location = New System.Drawing.Point(3, 300)
            Me.panel5.Name = "panel5"
            Me.panel5.Size = New System.Drawing.Size(373, 55)
            Me.panel5.TabIndex = 65
            ' 
            ' borderWidthlabel
            ' 
            Me.borderWidthlabel.AutoSize = True
            Me.borderWidthlabel.Location = New System.Drawing.Point(165, 12)
            Me.borderWidthlabel.Name = "borderWidthlabel"
            Me.borderWidthlabel.Size = New System.Drawing.Size(19, 23)
            Me.borderWidthlabel.TabIndex = 57
            Me.borderWidthlabel.Text = "5"
            ' 
            ' borderWidthTrackBar
            ' 
            Me.borderWidthTrackBar.AutoSize = False
            Me.borderWidthTrackBar.BackColor = System.Drawing.Color.White
            Me.borderWidthTrackBar.LargeChange = 1
            Me.borderWidthTrackBar.Location = New System.Drawing.Point(186, 8)
            Me.borderWidthTrackBar.Minimum = 1
            Me.borderWidthTrackBar.Name = "borderWidthTrackBar"
            Me.borderWidthTrackBar.Size = New System.Drawing.Size(169, 31)
            Me.borderWidthTrackBar.TabIndex = 56
            Me.borderWidthTrackBar.Value = 5
            ' 
            ' label5
            ' 
            Me.label5.AutoSize = True
            Me.label5.Location = New System.Drawing.Point(3, 12)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(108, 23)
            Me.label5.TabIndex = 55
            Me.label5.Text = "BorderWidth:"
            ' 
            ' customBackgroundSetting
            ' 
            Me.customBackgroundSetting.Controls.Add(Me.label13)
            Me.customBackgroundSetting.Controls.Add(Me.pictureBox1)
            Me.customBackgroundSetting.Controls.Add(Me.SelectImageButton)
            Me.customBackgroundSetting.Location = New System.Drawing.Point(3, 166)
            Me.customBackgroundSetting.Name = "customBackgroundSetting"
            Me.customBackgroundSetting.Size = New System.Drawing.Size(367, 128)
            Me.customBackgroundSetting.TabIndex = 66
            Me.customBackgroundSetting.TabStop = False
            Me.customBackgroundSetting.Text = "Magnifier Border Background"
            Me.customBackgroundSetting.Visible = False
            ' 
            ' label13
            ' 
            Me.label13.Location = New System.Drawing.Point(126, 60)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(241, 65)
            Me.label13.TabIndex = 46
            Me.label13.Text = "BorderBackground property only take effect when BorderBackgroundMode property is " & "custom."
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Image = My.Resources.MagnifierBorderBackground
            Me.pictureBox1.Location = New System.Drawing.Point(7, 24)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(103, 87)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 48
            Me.pictureBox1.TabStop = False
            ' 
            ' SelectImageButton
            ' 
            Me.SelectImageButton.Location = New System.Drawing.Point(128, 24)
            Me.SelectImageButton.Name = "SelectImageButton"
            Me.SelectImageButton.Size = New System.Drawing.Size(164, 30)
            Me.SelectImageButton.TabIndex = 49
            Me.SelectImageButton.Text = "Select Image ..."
            Me.SelectImageButton.UseVisualStyleBackColor = True
            ' 
            ' C1MagnifyCommon
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "C1MagnifyCommon"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.groupBox4.ResumeLayout(False)
            Me.groupBox4.PerformLayout()
            Me.panel3.ResumeLayout(False)
            Me.tabControl1.ResumeLayout(False)
            Me.tabPage1.ResumeLayout(False)
            Me.tabPage1.PerformLayout()
            Me.groupBox5.ResumeLayout(False)
            Me.groupBox5.PerformLayout()
            DirectCast(Me.PopupDelayTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage2.ResumeLayout(False)
            Me.tabPage2.PerformLayout()
            Me.groupBox3.ResumeLayout(False)
            DirectCast(Me.zoomfactorTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.sizeTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage3.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.panel5.ResumeLayout(False)
            Me.panel5.PerformLayout()
            DirectCast(Me.borderWidthTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.customBackgroundSetting.ResumeLayout(False)
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Friend WithEvents gcMagnifier1 As C1.Win.TouchToolKit.C1Magnify
        Friend WithEvents panel2 As System.Windows.Forms.Panel
        Friend WithEvents selectTextBox As System.Windows.Forms.TextBox
        Friend WithEvents splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents panel3 As System.Windows.Forms.Panel
        Friend WithEvents tabControl1 As System.Windows.Forms.TabControl
        Friend WithEvents tabPage1 As System.Windows.Forms.TabPage
        Friend WithEvents popupDelayLabel As System.Windows.Forms.Label
        Friend WithEvents PopupDelayTrackBar As System.Windows.Forms.TrackBar
        Friend WithEvents IsHorizontalRailEnabledCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents IsVerticalRailEnalbedCheckBox As System.Windows.Forms.CheckBox
        Friend WithEvents label8 As System.Windows.Forms.Label
        Friend WithEvents tabPage2 As System.Windows.Forms.TabPage
        Friend WithEvents ShowCursorCheckbox As System.Windows.Forms.CheckBox
        Friend WithEvents zoomfactorTrackBar As System.Windows.Forms.TrackBar
        Friend WithEvents sizeLabel As System.Windows.Forms.Label
        Friend WithEvents zoomFactorLabel As System.Windows.Forms.Label
        Friend WithEvents sizeTrackBar As System.Windows.Forms.TrackBar
        Friend WithEvents label9 As System.Windows.Forms.Label
        Friend WithEvents label11 As System.Windows.Forms.Label
        Friend WithEvents tabPage3 As System.Windows.Forms.TabPage
        Friend WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents customRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents darkRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents lightRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents panel5 As System.Windows.Forms.Panel
        Friend WithEvents borderWidthlabel As System.Windows.Forms.Label
        Friend WithEvents borderWidthTrackBar As System.Windows.Forms.TrackBar
        Friend WithEvents label5 As System.Windows.Forms.Label
        Friend WithEvents groupBox3 As System.Windows.Forms.GroupBox
        Friend WithEvents roundedRectangleRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents rectangleRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents circleRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents groupBox4 As System.Windows.Forms.GroupBox
        Friend WithEvents groupBox5 As System.Windows.Forms.GroupBox
        Friend WithEvents closeRightRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents closeLeftRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents closeNoneRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents moveRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents moveLeftDownRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents moveNoneRadioButton As System.Windows.Forms.RadioButton
        Friend WithEvents textBox1 As System.Windows.Forms.TextBox
        Friend WithEvents customBackgroundSetting As System.Windows.Forms.GroupBox
        Friend WithEvents label13 As System.Windows.Forms.Label
        Friend WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents SelectImageButton As System.Windows.Forms.Button
    End Class
End Namespace