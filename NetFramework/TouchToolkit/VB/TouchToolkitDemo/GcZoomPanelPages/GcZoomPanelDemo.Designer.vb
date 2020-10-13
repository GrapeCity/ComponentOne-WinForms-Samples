Namespace C1ZoomPanelPages
    Partial Class C1ZoomPanelDemo
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
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.formButton = New System.Windows.Forms.Button()
            Me.splitter1 = New System.Windows.Forms.Splitter()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.AllowDoubleTapZoomCheckBox = New System.Windows.Forms.CheckBox()
            Me.alternativeContentGroup = New System.Windows.Forms.GroupBox()
            Me.panel4 = New System.Windows.Forms.Panel()
            Me.displayLabel = New System.Windows.Forms.Label()
            Me.ForeColorButton = New System.Windows.Forms.Button()
            Me.FontButton = New System.Windows.Forms.Button()
            Me.formatComboBox = New System.Windows.Forms.ComboBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.ZoomPreviewModeComboBox = New System.Windows.Forms.ComboBox()
            Me.NoPreivewInfoPanel = New System.Windows.Forms.Panel()
            Me.label4 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.boundaryFeedbackUI1 = New C1ZoomPages.BoundaryFeedbackUI()
            Me.label5 = New System.Windows.Forms.Label()
            Me.scrollIndicatorCombo = New System.Windows.Forms.ComboBox()
            Me.VerticalRailEnableCheckBox = New System.Windows.Forms.CheckBox()
            Me.HorizontalRailEnableCheckBox = New System.Windows.Forms.CheckBox()
            Me.panel1.SuspendLayout()
            Me.panel2.SuspendLayout()
            Me.tableLayoutPanel1.SuspendLayout()
            Me.alternativeContentGroup.SuspendLayout()
            Me.panel4.SuspendLayout()
            Me.NoPreivewInfoPanel.SuspendLayout()
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.tableLayoutPanel1)
            Me.panel1.Controls.Add(Me.splitter1)
            Me.panel1.Controls.Add(Me.panel2)
            ' 
            ' panel2
            ' 
            Me.panel2.Controls.Add(Me.formButton)
            Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel2.Location = New System.Drawing.Point(0, 0)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(255, 372)
            Me.panel2.TabIndex = 1
            ' 
            ' formButton
            ' 
            Me.formButton.Location = New System.Drawing.Point(7, 11)
            Me.formButton.Name = "formButton"
            Me.formButton.Size = New System.Drawing.Size(240, 55)
            Me.formButton.TabIndex = 33
            Me.formButton.Text = "Show Form"
            Me.formButton.UseVisualStyleBackColor = True
            ' 
            ' splitter1
            ' 
            Me.splitter1.BackColor = System.Drawing.Color.LightGray
            Me.splitter1.Enabled = False
            Me.splitter1.Location = New System.Drawing.Point(255, 0)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 372)
            Me.splitter1.TabIndex = 2
            Me.splitter1.TabStop = False
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 2
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.tableLayoutPanel1.Controls.Add(Me.label2, 0, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.AllowDoubleTapZoomCheckBox, 0, 5)
            Me.tableLayoutPanel1.Controls.Add(Me.alternativeContentGroup, 0, 1)
            Me.tableLayoutPanel1.Controls.Add(Me.ZoomPreviewModeComboBox, 1, 0)
            Me.tableLayoutPanel1.Controls.Add(Me.NoPreivewInfoPanel, 0, 2)
            Me.tableLayoutPanel1.Controls.Add(Me.boundaryFeedbackUI1, 0, 3)
            Me.tableLayoutPanel1.Controls.Add(Me.label5, 0, 7)
            Me.tableLayoutPanel1.Controls.Add(Me.scrollIndicatorCombo, 1, 7)
            Me.tableLayoutPanel1.Controls.Add(Me.VerticalRailEnableCheckBox, 0, 9)
            Me.tableLayoutPanel1.Controls.Add(Me.HorizontalRailEnableCheckBox, 0, 8)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(258, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 10
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(432, 372)
            Me.tableLayoutPanel1.TabIndex = 39
            ' 
            ' label2
            ' 
            Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label2.Location = New System.Drawing.Point(20, 20)
            Me.label2.Margin = New System.Windows.Forms.Padding(20, 20, 3, 10)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(202, 32)
            Me.label2.TabIndex = 33
            Me.label2.Text = "ZoomPreviewMode:"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' AllowDoubleTapZoomCheckBox
            ' 
            Me.AllowDoubleTapZoomCheckBox.AutoSize = True
            Me.AllowDoubleTapZoomCheckBox.Location = New System.Drawing.Point(20, 449)
            Me.AllowDoubleTapZoomCheckBox.Margin = New System.Windows.Forms.Padding(20, 10, 0, 0)
            Me.AllowDoubleTapZoomCheckBox.Name = "AllowDoubleTapZoomCheckBox"
            Me.AllowDoubleTapZoomCheckBox.Size = New System.Drawing.Size(189, 27)
            Me.AllowDoubleTapZoomCheckBox.TabIndex = 35
            Me.AllowDoubleTapZoomCheckBox.Text = "AllowDoubleTapZoom"
            Me.AllowDoubleTapZoomCheckBox.UseVisualStyleBackColor = True
            ' 
            ' alternativeContentGroup
            ' 
            Me.tableLayoutPanel1.SetColumnSpan(Me.alternativeContentGroup, 2)
            Me.alternativeContentGroup.Controls.Add(Me.panel4)
            Me.alternativeContentGroup.Controls.Add(Me.ForeColorButton)
            Me.alternativeContentGroup.Controls.Add(Me.FontButton)
            Me.alternativeContentGroup.Controls.Add(Me.formatComboBox)
            Me.alternativeContentGroup.Controls.Add(Me.label3)
            Me.alternativeContentGroup.Controls.Add(Me.label12)
            Me.alternativeContentGroup.Location = New System.Drawing.Point(40, 65)
            Me.alternativeContentGroup.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
            Me.alternativeContentGroup.Name = "alternativeContentGroup"
            Me.alternativeContentGroup.Size = New System.Drawing.Size(344, 206)
            Me.alternativeContentGroup.TabIndex = 37
            Me.alternativeContentGroup.TabStop = False
            Me.alternativeContentGroup.Text = "AlternativeContentSettings"
            Me.alternativeContentGroup.Visible = False
            ' 
            ' panel4
            ' 
            Me.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel4.Controls.Add(Me.displayLabel)
            Me.panel4.Location = New System.Drawing.Point(23, 95)
            Me.panel4.Name = "panel4"
            Me.panel4.Size = New System.Drawing.Size(300, 105)
            Me.panel4.TabIndex = 33
            ' 
            ' displayLabel
            ' 
            Me.displayLabel.AutoSize = True
            Me.displayLabel.Location = New System.Drawing.Point(95, 44)
            Me.displayLabel.Name = "displayLabel"
            Me.displayLabel.Size = New System.Drawing.Size(121, 23)
            Me.displayLabel.TabIndex = 32
            Me.displayLabel.Text = "Zooming 100%"
            ' 
            ' ForeColorButton
            ' 
            Me.ForeColorButton.Location = New System.Drawing.Point(264, 61)
            Me.ForeColorButton.Name = "ForeColorButton"
            Me.ForeColorButton.Size = New System.Drawing.Size(66, 32)
            Me.ForeColorButton.TabIndex = 31
            Me.ForeColorButton.Text = "Color..."
            Me.ForeColorButton.UseVisualStyleBackColor = True
            ' 
            ' FontButton
            ' 
            Me.FontButton.Location = New System.Drawing.Point(264, 24)
            Me.FontButton.Name = "FontButton"
            Me.FontButton.Size = New System.Drawing.Size(66, 31)
            Me.FontButton.TabIndex = 30
            Me.FontButton.Text = "Font..."
            Me.FontButton.UseVisualStyleBackColor = True
            ' 
            ' formatComboBox
            ' 
            Me.formatComboBox.FormattingEnabled = True
            Me.formatComboBox.Location = New System.Drawing.Point(86, 24)
            Me.formatComboBox.Name = "formatComboBox"
            Me.formatComboBox.Size = New System.Drawing.Size(172, 31)
            Me.formatComboBox.TabIndex = 29
            ' 
            ' label3
            ' 
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(15, 69)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(73, 23)
            Me.label3.TabIndex = 28
            Me.label3.Text = "Preview:"
            ' 
            ' label12
            ' 
            Me.label12.AutoSize = True
            Me.label12.Location = New System.Drawing.Point(15, 27)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(69, 23)
            Me.label12.TabIndex = 28
            Me.label12.Text = "Format:"
            ' 
            ' ZoomPreviewModeComboBox
            ' 
            Me.ZoomPreviewModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ZoomPreviewModeComboBox.FormattingEnabled = True
            Me.ZoomPreviewModeComboBox.Location = New System.Drawing.Point(228, 20)
            Me.ZoomPreviewModeComboBox.Margin = New System.Windows.Forms.Padding(3, 20, 3, 3)
            Me.ZoomPreviewModeComboBox.Name = "ZoomPreviewModeComboBox"
            Me.ZoomPreviewModeComboBox.Size = New System.Drawing.Size(175, 31)
            Me.ZoomPreviewModeComboBox.TabIndex = 32
            ' 
            ' NoPreivewInfoPanel
            ' 
            Me.NoPreivewInfoPanel.BackColor = System.Drawing.SystemColors.Info
            Me.tableLayoutPanel1.SetColumnSpan(Me.NoPreivewInfoPanel, 2)
            Me.NoPreivewInfoPanel.Controls.Add(Me.label4)
            Me.NoPreivewInfoPanel.Controls.Add(Me.pictureBox1)
            Me.NoPreivewInfoPanel.Location = New System.Drawing.Point(40, 277)
            Me.NoPreivewInfoPanel.Margin = New System.Windows.Forms.Padding(40, 3, 3, 3)
            Me.NoPreivewInfoPanel.Name = "NoPreivewInfoPanel"
            Me.NoPreivewInfoPanel.Size = New System.Drawing.Size(344, 75)
            Me.NoPreivewInfoPanel.TabIndex = 38
            Me.NoPreivewInfoPanel.Visible = False
            ' 
            ' label4
            ' 
            Me.label4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label4.Location = New System.Drawing.Point(38, 0)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(306, 75)
            Me.label4.TabIndex = 1
            Me.label4.Text = "Typical ""NoPreview"" use for very simple form with a few controls. Otherwise, it m" + "ay cause perfermance problem."
            ' 
            ' pictureBox1
            ' 
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left
            Me.pictureBox1.Image = My.Resources.warning
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(38, 75)
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            ' 
            ' boundaryFeedbackUI1
            ' 
            Me.boundaryFeedbackUI1.BoundaryFeedbackMode = C1.Win.TouchToolKit.BoundaryFeedbackMode.Split
            Me.tableLayoutPanel1.SetColumnSpan(Me.boundaryFeedbackUI1, 2)
            Me.boundaryFeedbackUI1.Location = New System.Drawing.Point(40, 359)
            Me.boundaryFeedbackUI1.Margin = New System.Windows.Forms.Padding(40, 4, 3, 4)
            Me.boundaryFeedbackUI1.Name = "boundaryFeedbackUI1"
            Me.boundaryFeedbackUI1.Size = New System.Drawing.Size(344, 76)
            Me.boundaryFeedbackUI1.TabIndex = 39
            ' 
            ' label5
            ' 
            Me.label5.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label5.Location = New System.Drawing.Point(20, 486)
            Me.label5.Margin = New System.Windows.Forms.Padding(20, 10, 0, 0)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(205, 39)
            Me.label5.TabIndex = 40
            Me.label5.Text = "ScrollIndicatorMode:"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            ' 
            ' scrollIndicatorCombo
            ' 
            Me.scrollIndicatorCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.scrollIndicatorCombo.FormattingEnabled = True
            Me.scrollIndicatorCombo.Location = New System.Drawing.Point(225, 486)
            Me.scrollIndicatorCombo.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.scrollIndicatorCombo.Name = "scrollIndicatorCombo"
            Me.scrollIndicatorCombo.Size = New System.Drawing.Size(175, 31)
            Me.scrollIndicatorCombo.TabIndex = 41
            ' 
            ' VerticalRailEnableCheckBox
            ' 
            Me.VerticalRailEnableCheckBox.AutoSize = True
            Me.VerticalRailEnableCheckBox.Location = New System.Drawing.Point(20, 572)
            Me.VerticalRailEnableCheckBox.Margin = New System.Windows.Forms.Padding(20, 10, 0, 0)
            Me.VerticalRailEnableCheckBox.Name = "VerticalRailEnableCheckBox"
            Me.VerticalRailEnableCheckBox.Size = New System.Drawing.Size(185, 27)
            Me.VerticalRailEnableCheckBox.TabIndex = 42
            Me.VerticalRailEnableCheckBox.Text = "IsVerticalRailEnabled"
            Me.VerticalRailEnableCheckBox.UseVisualStyleBackColor = True
            ' 
            ' HorizontalRailEnableCheckBox
            ' 
            Me.HorizontalRailEnableCheckBox.AutoSize = True
            Me.HorizontalRailEnableCheckBox.Location = New System.Drawing.Point(20, 535)
            Me.HorizontalRailEnableCheckBox.Margin = New System.Windows.Forms.Padding(20, 10, 0, 0)
            Me.HorizontalRailEnableCheckBox.Name = "HorizontalRailEnableCheckBox"
            Me.HorizontalRailEnableCheckBox.Size = New System.Drawing.Size(205, 27)
            Me.HorizontalRailEnableCheckBox.TabIndex = 42
            Me.HorizontalRailEnableCheckBox.Text = "IsHorizontalRailEnabled"
            Me.HorizontalRailEnableCheckBox.UseVisualStyleBackColor = True
            ' 
            ' C1ZoomPanelDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0F, 23.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "C1ZoomPanelDemo"
            Me.panel1.ResumeLayout(False)
            Me.panel2.ResumeLayout(False)
            Me.tableLayoutPanel1.ResumeLayout(False)
            Me.tableLayoutPanel1.PerformLayout()
            Me.alternativeContentGroup.ResumeLayout(False)
            Me.alternativeContentGroup.PerformLayout()
            Me.panel4.ResumeLayout(False)
            Me.panel4.PerformLayout()
            Me.NoPreivewInfoPanel.ResumeLayout(False)
            DirectCast(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private splitter1 As System.Windows.Forms.Splitter
        Private panel2 As System.Windows.Forms.Panel
        Private formButton As System.Windows.Forms.Button
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
        Private label2 As System.Windows.Forms.Label
        Private AllowDoubleTapZoomCheckBox As System.Windows.Forms.CheckBox
        Private ZoomPreviewModeComboBox As System.Windows.Forms.ComboBox
        Private NoPreivewInfoPanel As System.Windows.Forms.Panel
        Private label4 As System.Windows.Forms.Label
        Private pictureBox1 As System.Windows.Forms.PictureBox
        Private boundaryFeedbackUI1 As C1ZoomPages.BoundaryFeedbackUI
        Private label5 As System.Windows.Forms.Label
        Private scrollIndicatorCombo As System.Windows.Forms.ComboBox
        Private VerticalRailEnableCheckBox As System.Windows.Forms.CheckBox
        Private HorizontalRailEnableCheckBox As System.Windows.Forms.CheckBox
        Private alternativeContentGroup As System.Windows.Forms.GroupBox
        Private panel4 As System.Windows.Forms.Panel
        Private displayLabel As System.Windows.Forms.Label
        Private ForeColorButton As System.Windows.Forms.Button
        Private FontButton As System.Windows.Forms.Button
        Private formatComboBox As System.Windows.Forms.ComboBox
        Private label3 As System.Windows.Forms.Label
        Private label12 As System.Windows.Forms.Label


    End Class
End Namespace
