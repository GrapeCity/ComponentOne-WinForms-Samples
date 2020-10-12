<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal_Preferences
    Inherits C1.Win.C1Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Personal_Preferences))
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.cmbVisualStyle = New C1.Win.C1List.C1Combo()
        Me.chkUseOfficeTheme = New C1.Win.C1Input.C1CheckBox()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOpacity = New C1.Win.C1Input.C1NumericEdit()
        Me.chkShowToolTips = New C1.Win.C1Input.C1CheckBox()
        Me.C1SplitterPanel3 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.cmbIntDial = New C1.Win.C1List.C1Combo()
        Me.C1SplitterPanel4 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.chkShowPrintOutput = New C1.Win.C1Input.C1CheckBox()
        Me.C1SplitterPanel5 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.btnCancel = New C1.Win.C1Input.C1Button()
        Me.btnOK = New C1.Win.C1Input.C1Button()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.cmbVisualStyle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
        CType(Me.txtOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel3.SuspendLayout()
        CType(Me.cmbIntDial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel4.SuspendLayout()
        Me.C1SplitterPanel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1SplitContainer1
        '
        Me.C1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.C1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.C1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.C1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.C1SplitContainer1.LineBelowHeader = False
        Me.C1SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.C1SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.C1SplitContainer1.Name = "C1SplitContainer1"
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel1)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel2)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel3)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel4)
        Me.C1SplitContainer1.Panels.Add(Me.C1SplitterPanel5)
        Me.C1SplitContainer1.Size = New System.Drawing.Size(431, 448)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 0
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.cmbVisualStyle)
        Me.C1SplitterPanel1.Controls.Add(Me.chkUseOfficeTheme)
        Me.C1SplitterPanel1.Height = 132
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(431, 111)
        Me.C1SplitterPanel1.SizeRatio = 29.64R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "Visual Styles"
        '
        'cmbVisualStyle
        '
        Me.cmbVisualStyle.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbVisualStyle.Caption = ""
        Me.cmbVisualStyle.CaptionHeight = 17
        Me.cmbVisualStyle.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbVisualStyle.ColumnCaptionHeight = 17
        Me.cmbVisualStyle.ColumnFooterHeight = 17
        Me.cmbVisualStyle.ColumnHeaders = False
        Me.cmbVisualStyle.ContentHeight = 18
        Me.cmbVisualStyle.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cmbVisualStyle.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbVisualStyle.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbVisualStyle.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVisualStyle.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbVisualStyle.EditorHeight = 18
        Me.cmbVisualStyle.ExtendRightColumn = True
        Me.cmbVisualStyle.Images.Add(CType(resources.GetObject("cmbVisualStyle.Images"), System.Drawing.Image))
        Me.cmbVisualStyle.ItemHeight = 15
        Me.cmbVisualStyle.Location = New System.Drawing.Point(203, 17)
        Me.cmbVisualStyle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbVisualStyle.MatchEntryTimeout = CType(2000, Long)
        Me.cmbVisualStyle.MaxDropDownItems = CType(5, Short)
        Me.cmbVisualStyle.MaxLength = 32767
        Me.cmbVisualStyle.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbVisualStyle.Name = "cmbVisualStyle"
        Me.cmbVisualStyle.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbVisualStyle.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbVisualStyle.Size = New System.Drawing.Size(212, 24)
        Me.cmbVisualStyle.TabIndex = 1
        Me.cmbVisualStyle.Text = "Select Visual Style to use"
        Me.C1SuperTooltip1.SetToolTip(Me.cmbVisualStyle, resources.GetString("cmbVisualStyle.ToolTip"))
        Me.cmbVisualStyle.PropBag = resources.GetString("cmbVisualStyle.PropBag")
        '
        'chkUseOfficeTheme
        '
        Me.chkUseOfficeTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.chkUseOfficeTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkUseOfficeTheme.Checked = Global.QRCodeConstructor.My.MySettings.Default.UseOfficeVisualStyle
        Me.chkUseOfficeTheme.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.QRCodeConstructor.My.MySettings.Default, "UseOfficeVisualStyle", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkUseOfficeTheme.ForeColor = System.Drawing.Color.Black
        Me.chkUseOfficeTheme.Location = New System.Drawing.Point(17, 62)
        Me.chkUseOfficeTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkUseOfficeTheme.Name = "chkUseOfficeTheme"
        Me.chkUseOfficeTheme.Padding = New System.Windows.Forms.Padding(1)
        Me.chkUseOfficeTheme.Size = New System.Drawing.Size(397, 30)
        Me.chkUseOfficeTheme.TabIndex = 0
        Me.chkUseOfficeTheme.Text = "Use Visual Style in installed office applications"
        Me.C1SuperTooltip1.SetToolTip(Me.chkUseOfficeTheme, resources.GetString("chkUseOfficeTheme.ToolTip"))
        Me.chkUseOfficeTheme.UseVisualStyleBackColor = False
        Me.chkUseOfficeTheme.Value = Nothing
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.Label1)
        Me.C1SplitterPanel2.Controls.Add(Me.txtOpacity)
        Me.C1SplitterPanel2.Controls.Add(Me.chkShowToolTips)
        Me.C1SplitterPanel2.Height = 111
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 154)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(431, 90)
        Me.C1SplitterPanel2.SizeRatio = 35.2R
        Me.C1SplitterPanel2.TabIndex = 1
        Me.C1SplitterPanel2.Text = "Tool Tips"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 53)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tool Tip Opacity:"
        '
        'txtOpacity
        '
        Me.txtOpacity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtOpacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtOpacity.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpacity.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtOpacity.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtOpacity.Location = New System.Drawing.Point(203, 50)
        Me.txtOpacity.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtOpacity.Name = "txtOpacity"
        Me.txtOpacity.Size = New System.Drawing.Size(100, 20)
        Me.txtOpacity.TabIndex = 1
        Me.txtOpacity.Tag = Nothing
        Me.C1SuperTooltip1.SetToolTip(Me.txtOpacity, resources.GetString("txtOpacity.ToolTip"))
        Me.txtOpacity.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'chkShowToolTips
        '
        Me.chkShowToolTips.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.chkShowToolTips.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkShowToolTips.Checked = Global.QRCodeConstructor.My.MySettings.Default.ShowTooltips
        Me.chkShowToolTips.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowToolTips.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.QRCodeConstructor.My.MySettings.Default, "ShowTooltips", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkShowToolTips.ForeColor = System.Drawing.Color.Black
        Me.chkShowToolTips.Location = New System.Drawing.Point(17, 4)
        Me.chkShowToolTips.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowToolTips.Name = "chkShowToolTips"
        Me.chkShowToolTips.Padding = New System.Windows.Forms.Padding(1)
        Me.chkShowToolTips.Size = New System.Drawing.Size(189, 30)
        Me.chkShowToolTips.TabIndex = 0
        Me.chkShowToolTips.Text = "Show Tool Tips"
        Me.C1SuperTooltip1.SetToolTip(Me.chkShowToolTips, resources.GetString("chkShowToolTips.ToolTip"))
        Me.chkShowToolTips.UseVisualStyleBackColor = False
        Me.chkShowToolTips.Value = True
        '
        'C1SplitterPanel3
        '
        Me.C1SplitterPanel3.Controls.Add(Me.cmbIntDial)
        Me.C1SplitterPanel3.Height = 75
        Me.C1SplitterPanel3.Location = New System.Drawing.Point(0, 266)
        Me.C1SplitterPanel3.Name = "C1SplitterPanel3"
        Me.C1SplitterPanel3.Size = New System.Drawing.Size(431, 54)
        Me.C1SplitterPanel3.SizeRatio = 37.342R
        Me.C1SplitterPanel3.TabIndex = 2
        Me.C1SplitterPanel3.Text = "International Dialling Codes"
        '
        'cmbIntDial
        '
        Me.cmbIntDial.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbIntDial.Caption = ""
        Me.cmbIntDial.CaptionHeight = 17
        Me.cmbIntDial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbIntDial.ColumnCaptionHeight = 17
        Me.cmbIntDial.ColumnFooterHeight = 17
        Me.cmbIntDial.ColumnHeaders = False
        Me.cmbIntDial.ContentHeight = 18
        Me.cmbIntDial.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cmbIntDial.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbIntDial.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbIntDial.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIntDial.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbIntDial.EditorHeight = 18
        Me.cmbIntDial.ExtendRightColumn = True
        Me.cmbIntDial.Images.Add(CType(resources.GetObject("cmbIntDial.Images"), System.Drawing.Image))
        Me.cmbIntDial.ItemHeight = 15
        Me.cmbIntDial.Location = New System.Drawing.Point(203, 4)
        Me.cmbIntDial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbIntDial.MatchEntryTimeout = CType(2000, Long)
        Me.cmbIntDial.MaxDropDownItems = CType(5, Short)
        Me.cmbIntDial.MaxLength = 32767
        Me.cmbIntDial.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbIntDial.Name = "cmbIntDial"
        Me.cmbIntDial.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbIntDial.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbIntDial.Size = New System.Drawing.Size(212, 24)
        Me.cmbIntDial.TabIndex = 0
        Me.cmbIntDial.Text = "C1Combo1"
        Me.C1SuperTooltip1.SetToolTip(Me.cmbIntDial, resources.GetString("cmbIntDial.ToolTip"))
        Me.cmbIntDial.PropBag = resources.GetString("cmbIntDial.PropBag")
        '
        'C1SplitterPanel4
        '
        Me.C1SplitterPanel4.Controls.Add(Me.chkShowPrintOutput)
        Me.C1SplitterPanel4.Height = 73
        Me.C1SplitterPanel4.Location = New System.Drawing.Point(0, 342)
        Me.C1SplitterPanel4.Name = "C1SplitterPanel4"
        Me.C1SplitterPanel4.Size = New System.Drawing.Size(431, 52)
        Me.C1SplitterPanel4.SizeRatio = 57.895R
        Me.C1SplitterPanel4.TabIndex = 3
        Me.C1SplitterPanel4.Text = "Printing Options"
        '
        'chkShowPrintOutput
        '
        Me.chkShowPrintOutput.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.chkShowPrintOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.chkShowPrintOutput.Checked = Global.QRCodeConstructor.My.MySettings.Default.ShowTextInPrintOutput
        Me.chkShowPrintOutput.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowPrintOutput.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.QRCodeConstructor.My.MySettings.Default, "ShowTextInPrintOutput", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkShowPrintOutput.ForeColor = System.Drawing.Color.Black
        Me.chkShowPrintOutput.Location = New System.Drawing.Point(17, 5)
        Me.chkShowPrintOutput.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkShowPrintOutput.Name = "chkShowPrintOutput"
        Me.chkShowPrintOutput.Padding = New System.Windows.Forms.Padding(1)
        Me.chkShowPrintOutput.Size = New System.Drawing.Size(285, 30)
        Me.chkShowPrintOutput.TabIndex = 0
        Me.chkShowPrintOutput.Text = "C1CheckBox1"
        Me.C1SuperTooltip1.SetToolTip(Me.chkShowPrintOutput, resources.GetString("chkShowPrintOutput.ToolTip"))
        Me.chkShowPrintOutput.UseVisualStyleBackColor = False
        Me.chkShowPrintOutput.Value = True
        '
        'C1SplitterPanel5
        '
        Me.C1SplitterPanel5.Controls.Add(Me.btnCancel)
        Me.C1SplitterPanel5.Controls.Add(Me.btnOK)
        Me.C1SplitterPanel5.Height = 100
        Me.C1SplitterPanel5.Location = New System.Drawing.Point(0, 395)
        Me.C1SplitterPanel5.Name = "C1SplitterPanel5"
        Me.C1SplitterPanel5.Size = New System.Drawing.Size(431, 53)
        Me.C1SplitterPanel5.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(171, 2)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(59, 2)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'Personal_Preferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 448)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Personal_Preferences"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Personal Preferences Dialog"
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        CType(Me.cmbVisualStyle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.C1SplitterPanel2.PerformLayout()
        CType(Me.txtOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel3.ResumeLayout(False)
        Me.C1SplitterPanel3.PerformLayout()
        CType(Me.cmbIntDial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel4.ResumeLayout(False)
        Me.C1SplitterPanel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel3 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel4 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel5 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents btnCancel As C1.Win.C1Input.C1Button
    Friend WithEvents btnOK As C1.Win.C1Input.C1Button
    Friend WithEvents cmbVisualStyle As C1.Win.C1List.C1Combo
    Friend WithEvents chkUseOfficeTheme As C1.Win.C1Input.C1CheckBox
    Friend WithEvents cmbIntDial As C1.Win.C1List.C1Combo
    Friend WithEvents chkShowPrintOutput As C1.Win.C1Input.C1CheckBox
    Friend WithEvents txtOpacity As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkShowToolTips As C1.Win.C1Input.C1CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
End Class
