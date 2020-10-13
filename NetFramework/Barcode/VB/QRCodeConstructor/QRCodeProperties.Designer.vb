<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRCodeProperties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QRCodeProperties))
        Me.C1SplitContainer1 = New C1.Win.C1SplitContainer.C1SplitContainer()
        Me.C1SplitterPanel1 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFore2 = New C1.Win.C1Input.C1Button()
        Me.btnFore3 = New C1.Win.C1Input.C1Button()
        Me.btnFore1 = New C1.Win.C1Input.C1Button()
        Me.btnBack = New C1.Win.C1Input.C1Button()
        Me.cmbErrorCorrectionLevel = New C1.Win.C1List.C1Combo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodeVersion = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSymbolSize = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnShowBackColourDialog = New C1.Win.C1Input.C1Button()
        Me.btnDisplayBackColour = New C1.Win.C1Input.C1Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDisplayForeColour = New C1.Win.C1Input.C1Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnForeColourDialog = New C1.Win.C1Input.C1Button()
        Me.C1SplitterPanel2 = New C1.Win.C1SplitContainer.C1SplitterPanel()
        Me.btnCancel = New C1.Win.C1Input.C1Button()
        Me.btnOK = New C1.Win.C1Input.C1Button()
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitContainer1.SuspendLayout()
        Me.C1SplitterPanel1.SuspendLayout()
        CType(Me.cmbErrorCorrectionLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodeVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSymbolSize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.C1SplitterPanel2.SuspendLayout()
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
        Me.C1SplitContainer1.Size = New System.Drawing.Size(361, 433)
        Me.C1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.C1SplitContainer1.SplitterWidth = 1
        Me.C1SplitContainer1.TabIndex = 0
        Me.C1SplitContainer1.ToolTipGradient = C1.Win.C1SplitContainer.ToolTipGradient.Blue
        '
        'C1SplitterPanel1
        '
        Me.C1SplitterPanel1.Controls.Add(Me.Label6)
        Me.C1SplitterPanel1.Controls.Add(Me.btnFore2)
        Me.C1SplitterPanel1.Controls.Add(Me.btnFore3)
        Me.C1SplitterPanel1.Controls.Add(Me.btnFore1)
        Me.C1SplitterPanel1.Controls.Add(Me.btnBack)
        Me.C1SplitterPanel1.Controls.Add(Me.cmbErrorCorrectionLevel)
        Me.C1SplitterPanel1.Controls.Add(Me.Label5)
        Me.C1SplitterPanel1.Controls.Add(Me.txtCodeVersion)
        Me.C1SplitterPanel1.Controls.Add(Me.Label4)
        Me.C1SplitterPanel1.Controls.Add(Me.txtSymbolSize)
        Me.C1SplitterPanel1.Controls.Add(Me.Label3)
        Me.C1SplitterPanel1.Controls.Add(Me.btnShowBackColourDialog)
        Me.C1SplitterPanel1.Controls.Add(Me.btnDisplayBackColour)
        Me.C1SplitterPanel1.Controls.Add(Me.Label2)
        Me.C1SplitterPanel1.Controls.Add(Me.btnDisplayForeColour)
        Me.C1SplitterPanel1.Controls.Add(Me.Label1)
        Me.C1SplitterPanel1.Controls.Add(Me.btnForeColourDialog)
        Me.C1SplitterPanel1.Height = 379
        Me.C1SplitterPanel1.Location = New System.Drawing.Point(0, 21)
        Me.C1SplitterPanel1.Name = "C1SplitterPanel1"
        Me.C1SplitterPanel1.Size = New System.Drawing.Size(361, 358)
        Me.C1SplitterPanel1.SizeRatio = 87.637R
        Me.C1SplitterPanel1.TabIndex = 0
        Me.C1SplitterPanel1.Text = "Properties to Set"
        Me.C1SuperTooltip1.SetToolTip(Me.C1SplitterPanel1, resources.GetString("C1SplitterPanel1.ToolTip"))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Contrast Display:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label6, resources.GetString("Label6.ToolTip"))
        '
        'btnFore2
        '
        Me.btnFore2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFore2.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRForeColour
        Me.btnFore2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRForeColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnFore2.Enabled = False
        Me.btnFore2.Location = New System.Drawing.Point(153, 90)
        Me.btnFore2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFore2.Name = "btnFore2"
        Me.btnFore2.Size = New System.Drawing.Size(31, 28)
        Me.btnFore2.TabIndex = 15
        Me.btnFore2.UseVisualStyleBackColor = False
        '
        'btnFore3
        '
        Me.btnFore3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnFore3.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRForeColour
        Me.btnFore3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRForeColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnFore3.Enabled = False
        Me.btnFore3.Location = New System.Drawing.Point(184, 88)
        Me.btnFore3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFore3.Name = "btnFore3"
        Me.btnFore3.Size = New System.Drawing.Size(31, 28)
        Me.btnFore3.TabIndex = 14
        Me.btnFore3.UseVisualStyleBackColor = False
        '
        'btnFore1
        '
        Me.btnFore1.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRForeColour
        Me.btnFore1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRForeColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnFore1.Enabled = False
        Me.btnFore1.Location = New System.Drawing.Point(184, 90)
        Me.btnFore1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFore1.Name = "btnFore1"
        Me.btnFore1.Size = New System.Drawing.Size(31, 28)
        Me.btnFore1.TabIndex = 13
        Me.btnFore1.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRBackColour
        Me.btnBack.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRBackColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnBack.Enabled = False
        Me.btnBack.Location = New System.Drawing.Point(175, 80)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(139, 128)
        Me.btnBack.TabIndex = 12
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cmbErrorCorrectionLevel
        '
        Me.cmbErrorCorrectionLevel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbErrorCorrectionLevel.AutoCompletion = True
        Me.cmbErrorCorrectionLevel.Caption = ""
        Me.cmbErrorCorrectionLevel.CaptionHeight = 17
        Me.cmbErrorCorrectionLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbErrorCorrectionLevel.ColumnCaptionHeight = 17
        Me.cmbErrorCorrectionLevel.ColumnFooterHeight = 17
        Me.cmbErrorCorrectionLevel.ColumnHeaders = False
        Me.cmbErrorCorrectionLevel.ContentHeight = 18
        Me.cmbErrorCorrectionLevel.DataMode = C1.Win.C1List.DataModeEnum.AddItem
        Me.cmbErrorCorrectionLevel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbErrorCorrectionLevel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbErrorCorrectionLevel.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbErrorCorrectionLevel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbErrorCorrectionLevel.EditorHeight = 18
        Me.cmbErrorCorrectionLevel.ExtendRightColumn = True
        Me.cmbErrorCorrectionLevel.Images.Add(CType(resources.GetObject("cmbErrorCorrectionLevel.Images"), System.Drawing.Image))
        Me.cmbErrorCorrectionLevel.ItemHeight = 15
        Me.cmbErrorCorrectionLevel.Location = New System.Drawing.Point(175, 308)
        Me.cmbErrorCorrectionLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbErrorCorrectionLevel.MatchEntryTimeout = CType(2000, Long)
        Me.cmbErrorCorrectionLevel.MaxDropDownItems = CType(5, Short)
        Me.cmbErrorCorrectionLevel.MaxLength = 32767
        Me.cmbErrorCorrectionLevel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbErrorCorrectionLevel.Name = "cmbErrorCorrectionLevel"
        Me.cmbErrorCorrectionLevel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbErrorCorrectionLevel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbErrorCorrectionLevel.Size = New System.Drawing.Size(139, 24)
        Me.cmbErrorCorrectionLevel.TabIndex = 11
        Me.cmbErrorCorrectionLevel.Text = "Set Error Level "
        Me.cmbErrorCorrectionLevel.PropBag = resources.GetString("cmbErrorCorrectionLevel.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 308)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Error Correction Level:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label5, resources.GetString("Label5.ToolTip"))
        '
        'txtCodeVersion
        '
        Me.txtCodeVersion.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtCodeVersion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtCodeVersion.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodeVersion.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCodeVersion.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCodeVersion.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.QRCodeConstructor.My.MySettings.Default, "QRCodeVersion", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtCodeVersion.DataType = GetType(Short)
        Me.txtCodeVersion.Location = New System.Drawing.Point(175, 266)
        Me.txtCodeVersion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodeVersion.Name = "txtCodeVersion"
        Me.txtCodeVersion.Size = New System.Drawing.Size(67, 20)
        Me.txtCodeVersion.TabIndex = 9
        Me.txtCodeVersion.Tag = Nothing
        Me.txtCodeVersion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 268)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Code Version:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label4, resources.GetString("Label4.ToolTip"))
        '
        'txtSymbolSize
        '
        Me.txtSymbolSize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(177, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.txtSymbolSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtSymbolSize.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSymbolSize.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSymbolSize.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSymbolSize.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.QRCodeConstructor.My.MySettings.Default, "QRSymbolSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtSymbolSize.DataType = GetType(Short)
        Me.txtSymbolSize.Location = New System.Drawing.Point(175, 225)
        Me.txtSymbolSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSymbolSize.Name = "txtSymbolSize"
        Me.txtSymbolSize.Size = New System.Drawing.Size(67, 20)
        Me.txtSymbolSize.TabIndex = 7
        Me.txtSymbolSize.Tag = Nothing
        Me.txtSymbolSize.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 228)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Symbol Size:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        '
        'btnShowBackColourDialog
        '
        Me.btnShowBackColourDialog.Location = New System.Drawing.Point(269, 39)
        Me.btnShowBackColourDialog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnShowBackColourDialog.Name = "btnShowBackColourDialog"
        Me.btnShowBackColourDialog.Size = New System.Drawing.Size(44, 28)
        Me.btnShowBackColourDialog.TabIndex = 5
        Me.btnShowBackColourDialog.Text = "&BC"
        Me.btnShowBackColourDialog.UseVisualStyleBackColor = True
        '
        'btnDisplayBackColour
        '
        Me.btnDisplayBackColour.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRBackColour
        Me.btnDisplayBackColour.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRBackColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDisplayBackColour.Enabled = False
        Me.btnDisplayBackColour.Location = New System.Drawing.Point(175, 39)
        Me.btnDisplayBackColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplayBackColour.Name = "btnDisplayBackColour"
        Me.btnDisplayBackColour.Size = New System.Drawing.Size(67, 28)
        Me.btnDisplayBackColour.TabIndex = 4
        Me.btnDisplayBackColour.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Back Colour:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label2, resources.GetString("Label2.ToolTip"))
        '
        'btnDisplayForeColour
        '
        Me.btnDisplayForeColour.BackColor = Global.QRCodeConstructor.My.MySettings.Default.QRForeColour
        Me.btnDisplayForeColour.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.QRCodeConstructor.My.MySettings.Default, "QRForeColour", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDisplayForeColour.Enabled = False
        Me.btnDisplayForeColour.Location = New System.Drawing.Point(175, 2)
        Me.btnDisplayForeColour.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDisplayForeColour.Name = "btnDisplayForeColour"
        Me.btnDisplayForeColour.Size = New System.Drawing.Size(67, 28)
        Me.btnDisplayForeColour.TabIndex = 2
        Me.btnDisplayForeColour.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fore Colour:"
        Me.C1SuperTooltip1.SetToolTip(Me.Label1, resources.GetString("Label1.ToolTip"))
        '
        'btnForeColourDialog
        '
        Me.btnForeColourDialog.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnForeColourDialog.Location = New System.Drawing.Point(269, 2)
        Me.btnForeColourDialog.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnForeColourDialog.Name = "btnForeColourDialog"
        Me.btnForeColourDialog.Size = New System.Drawing.Size(44, 28)
        Me.btnForeColourDialog.TabIndex = 0
        Me.btnForeColourDialog.Text = "&FC"
        Me.btnForeColourDialog.UseVisualStyleBackColor = True
        '
        'C1SplitterPanel2
        '
        Me.C1SplitterPanel2.Controls.Add(Me.btnCancel)
        Me.C1SplitterPanel2.Controls.Add(Me.btnOK)
        Me.C1SplitterPanel2.Height = 100
        Me.C1SplitterPanel2.Location = New System.Drawing.Point(0, 380)
        Me.C1SplitterPanel2.Name = "C1SplitterPanel2"
        Me.C1SplitterPanel2.Size = New System.Drawing.Size(361, 53)
        Me.C1SplitterPanel2.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(127, 1)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 28)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(15, 1)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(100, 28)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'QRCodeProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 433)
        Me.Controls.Add(Me.C1SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QRCodeProperties"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "QR Code Properties Dialog"
        CType(Me.C1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitContainer1.ResumeLayout(False)
        Me.C1SplitterPanel1.ResumeLayout(False)
        Me.C1SplitterPanel1.PerformLayout()
        CType(Me.cmbErrorCorrectionLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodeVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSymbolSize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.C1SplitterPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1SplitContainer1 As C1.Win.C1SplitContainer.C1SplitContainer
    Friend WithEvents C1SplitterPanel1 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents C1SplitterPanel2 As C1.Win.C1SplitContainer.C1SplitterPanel
    Friend WithEvents btnCancel As C1.Win.C1Input.C1Button
    Friend WithEvents btnOK As C1.Win.C1Input.C1Button
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents btnForeColourDialog As C1.Win.C1Input.C1Button
    Friend WithEvents btnDisplayForeColour As C1.Win.C1Input.C1Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowBackColourDialog As C1.Win.C1Input.C1Button
    Friend WithEvents btnDisplayBackColour As C1.Win.C1Input.C1Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSymbolSize As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodeVersion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbErrorCorrectionLevel As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFore2 As C1.Win.C1Input.C1Button
    Friend WithEvents btnFore3 As C1.Win.C1Input.C1Button
    Friend WithEvents btnFore1 As C1.Win.C1Input.C1Button
    Friend WithEvents btnBack As C1.Win.C1Input.C1Button
End Class
