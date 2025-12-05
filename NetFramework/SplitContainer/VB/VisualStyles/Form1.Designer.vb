<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits C1.Win.Ribbon.C1RibbonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.c1SplitContainer1 = New C1.Win.SplitContainer.C1SplitContainer
        Me.c1SplitterPanel1 = New C1.Win.SplitContainer.C1SplitterPanel
        Me.c1SplitContainer2 = New C1.Win.SplitContainer.C1SplitContainer
        Me.c1SplitterPanel2 = New C1.Win.SplitContainer.C1SplitterPanel
        Me.btnInnerReset = New System.Windows.Forms.Button
        Me.cbInnerStyle = New System.Windows.Forms.ComboBox
        Me.c1SplitterPanel4 = New C1.Win.SplitContainer.C1SplitterPanel
        Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid
        Me.c1SplitterPanel3 = New C1.Win.SplitContainer.C1SplitterPanel
        Me.btnOuterReset = New System.Windows.Forms.Button
        Me.cbOuterStyle = New System.Windows.Forms.ComboBox
        Me.c1SplitterPanel5 = New C1.Win.SplitContainer.C1SplitterPanel
        Me.c1InputPanel1 = New C1.Win.InputPanel.C1InputPanel
        Me.inputGroupHeader1 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel1 = New C1.Win.InputPanel.InputLabel
        Me.cbPanelStyle = New C1.Win.InputPanel.InputComboBox
        Me.inputOption1 = New C1.Win.InputPanel.InputOption
        Me.inputOption2 = New C1.Win.InputPanel.InputOption
        Me.inputOption3 = New C1.Win.InputPanel.InputOption
        Me.inputOption4 = New C1.Win.InputPanel.InputOption
        Me.inputOption5 = New C1.Win.InputPanel.InputOption
        Me.inputOption6 = New C1.Win.InputPanel.InputOption
        Me.inputOption7 = New C1.Win.InputPanel.InputOption
        Me.inputOption8 = New C1.Win.InputPanel.InputOption
        Me.btnPanelReset = New C1.Win.InputPanel.InputButton
        Me.inputCheckBox1 = New C1.Win.InputPanel.InputCheckBox
        Me.inputTrackBar1 = New C1.Win.InputPanel.InputTrackBar
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        CType(Me.c1SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1SplitContainer1.SuspendLayout()
        Me.c1SplitterPanel1.SuspendLayout()
        CType(Me.c1SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1SplitContainer2.SuspendLayout()
        Me.c1SplitterPanel2.SuspendLayout()
        Me.c1SplitterPanel4.SuspendLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1SplitterPanel3.SuspendLayout()
        Me.c1SplitterPanel5.SuspendLayout()
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1SplitContainer1
        '
        Me.c1SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1SplitContainer1.EnlargeCollapsingHandle = True
        Me.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.c1SplitContainer1.Location = New System.Drawing.Point(9, 32)
        Me.c1SplitContainer1.Name = "c1SplitContainer1"
        Me.c1SplitContainer1.Panels.Add(Me.c1SplitterPanel1)
        Me.c1SplitContainer1.Panels.Add(Me.c1SplitterPanel3)
        Me.c1SplitContainer1.Panels.Add(Me.c1SplitterPanel5)
        Me.c1SplitContainer1.Size = New System.Drawing.Size(475, 292)
        Me.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.c1SplitContainer1.SplitterWidth = 6
        Me.c1SplitContainer1.TabIndex = 3
        Me.c1SplitContainer1.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue
        '
        'c1SplitterPanel1
        '
        Me.c1SplitterPanel1.Controls.Add(Me.c1SplitContainer2)
        Me.c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Right
        Me.c1SplitterPanel1.Location = New System.Drawing.Point(240, 1)
        Me.c1SplitterPanel1.Name = "c1SplitterPanel1"
        Me.c1SplitterPanel1.Size = New System.Drawing.Size(234, 290)
        Me.c1SplitterPanel1.TabIndex = 0
        Me.c1SplitterPanel1.Width = 234
        '
        'c1SplitContainer2
        '
        Me.c1SplitContainer2.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.c1SplitContainer2.BorderWidth = 0
        Me.c1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1SplitContainer2.EnlargeCollapsingHandle = True
        Me.c1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.c1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.c1SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.c1SplitContainer2.Name = "c1SplitContainer2"
        Me.c1SplitContainer2.Panels.Add(Me.c1SplitterPanel2)
        Me.c1SplitContainer2.Panels.Add(Me.c1SplitterPanel4)
        Me.c1SplitContainer2.Size = New System.Drawing.Size(234, 290)
        Me.c1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.c1SplitContainer2.SplitterWidth = 6
        Me.c1SplitContainer2.TabIndex = 0
        Me.c1SplitContainer2.ToolTipGradient = C1.Win.SplitContainer.ToolTipGradient.Blue
        '
        'c1SplitterPanel2
        '
        Me.c1SplitterPanel2.Collapsible = True
        Me.c1SplitterPanel2.Controls.Add(Me.CheckBox2)
        Me.c1SplitterPanel2.Controls.Add(Me.btnInnerReset)
        Me.c1SplitterPanel2.Controls.Add(Me.cbInnerStyle)
        Me.c1SplitterPanel2.Dock = C1.Win.SplitContainer.PanelDockStyle.Bottom
        Me.c1SplitterPanel2.Height = 91
        Me.c1SplitterPanel2.Location = New System.Drawing.Point(0, 230)
        Me.c1SplitterPanel2.Name = "c1SplitterPanel2"
        Me.c1SplitterPanel2.Size = New System.Drawing.Size(234, 60)
        Me.c1SplitterPanel2.SizeRatio = 32.042
        Me.c1SplitterPanel2.TabIndex = 0
        Me.c1SplitterPanel2.Text = "Inner C1SplitContainer"
        '
        'btnInnerReset
        '
        Me.btnInnerReset.Location = New System.Drawing.Point(120, 9)
        Me.btnInnerReset.Name = "btnInnerReset"
        Me.btnInnerReset.Size = New System.Drawing.Size(75, 23)
        Me.btnInnerReset.TabIndex = 3
        Me.btnInnerReset.Text = "Reset Style"
        Me.btnInnerReset.UseVisualStyleBackColor = True
        '
        'cbInnerStyle
        '
        Me.cbInnerStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInnerStyle.FormattingEnabled = True
        Me.cbInnerStyle.Items.AddRange(New Object() {"System", "Office2007Black", "Office2007Blue", "Office2007Silver", "Office2010Black", "Office2010Blue", "Office2010Silver", "Windows7"})
        Me.cbInnerStyle.Location = New System.Drawing.Point(9, 10)
        Me.cbInnerStyle.Name = "cbInnerStyle"
        Me.cbInnerStyle.Size = New System.Drawing.Size(105, 21)
        Me.cbInnerStyle.TabIndex = 2
        '
        'c1SplitterPanel4
        '
        Me.c1SplitterPanel4.Controls.Add(Me.c1FlexGrid1)
        Me.c1SplitterPanel4.Height = 100
        Me.c1SplitterPanel4.Location = New System.Drawing.Point(0, 21)
        Me.c1SplitterPanel4.Name = "c1SplitterPanel4"
        Me.c1SplitterPanel4.Size = New System.Drawing.Size(234, 172)
        Me.c1SplitterPanel4.TabIndex = 1
        Me.c1SplitterPanel4.Text = "C1FlexGrid"
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1FlexGrid1.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.c1FlexGrid1.Location = New System.Drawing.Point(3, 3)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.DefaultSize = 20
        Me.c1FlexGrid1.Size = New System.Drawing.Size(228, 166)
        Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
        Me.c1FlexGrid1.TabIndex = 0
        '
        'c1SplitterPanel3
        '
        Me.c1SplitterPanel3.Collapsible = True
        Me.c1SplitterPanel3.Controls.Add(Me.CheckBox1)
        Me.c1SplitterPanel3.Controls.Add(Me.btnOuterReset)
        Me.c1SplitterPanel3.Controls.Add(Me.cbOuterStyle)
        Me.c1SplitterPanel3.Height = 91
        Me.c1SplitterPanel3.Location = New System.Drawing.Point(1, 22)
        Me.c1SplitterPanel3.Name = "c1SplitterPanel3"
        Me.c1SplitterPanel3.Size = New System.Drawing.Size(233, 60)
        Me.c1SplitterPanel3.SizeRatio = 32.042
        Me.c1SplitterPanel3.TabIndex = 1
        Me.c1SplitterPanel3.Text = "Outer C1SplitContainer"
        '
        'btnOuterReset
        '
        Me.btnOuterReset.Location = New System.Drawing.Point(120, 9)
        Me.btnOuterReset.Name = "btnOuterReset"
        Me.btnOuterReset.Size = New System.Drawing.Size(75, 23)
        Me.btnOuterReset.TabIndex = 1
        Me.btnOuterReset.Text = "Reset Style"
        Me.btnOuterReset.UseVisualStyleBackColor = True
        '
        'cbOuterStyle
        '
        Me.cbOuterStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOuterStyle.FormattingEnabled = True
        Me.cbOuterStyle.Items.AddRange(New Object() {"System", "Office2007Black", "Office2007Blue", "Office2007Silver", "Office2010Black", "Office2010Blue", "Office2010Silver", "Windows7"})
        Me.cbOuterStyle.Location = New System.Drawing.Point(9, 10)
        Me.cbOuterStyle.Name = "cbOuterStyle"
        Me.cbOuterStyle.Size = New System.Drawing.Size(105, 21)
        Me.cbOuterStyle.TabIndex = 0
        '
        'c1SplitterPanel5
        '
        Me.c1SplitterPanel5.Controls.Add(Me.c1InputPanel1)
        Me.c1SplitterPanel5.Height = 100
        Me.c1SplitterPanel5.Location = New System.Drawing.Point(1, 119)
        Me.c1SplitterPanel5.Name = "c1SplitterPanel5"
        Me.c1SplitterPanel5.Size = New System.Drawing.Size(233, 172)
        Me.c1SplitterPanel5.TabIndex = 2
        Me.c1SplitterPanel5.Text = "C1InputPanel"
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel1)
        Me.c1InputPanel1.Items.Add(Me.cbPanelStyle)
        Me.c1InputPanel1.Items.Add(Me.btnPanelReset)
        Me.c1InputPanel1.Items.Add(Me.inputCheckBox1)
        Me.c1InputPanel1.Items.Add(Me.inputTrackBar1)
        Me.c1InputPanel1.Location = New System.Drawing.Point(3, 3)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(227, 166)
        Me.c1InputPanel1.TabIndex = 0
        '
        'inputGroupHeader1
        '
        Me.inputGroupHeader1.Name = "inputGroupHeader1"
        Me.inputGroupHeader1.Text = "Group"
        '
        'inputLabel1
        '
        Me.inputLabel1.Break = C1.Win.InputPanel.BreakType.Row
        Me.inputLabel1.Height = 23
        Me.inputLabel1.Name = "inputLabel1"
        Me.inputLabel1.Text = "Panel Style:"
        Me.inputLabel1.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        Me.inputLabel1.Width = 61
        '
        'cbPanelStyle
        '
        Me.cbPanelStyle.Break = C1.Win.InputPanel.BreakType.None
        Me.cbPanelStyle.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList
        Me.cbPanelStyle.Height = 26
        Me.cbPanelStyle.Items.Add(Me.inputOption1)
        Me.cbPanelStyle.Items.Add(Me.inputOption2)
        Me.cbPanelStyle.Items.Add(Me.inputOption3)
        Me.cbPanelStyle.Items.Add(Me.inputOption4)
        Me.cbPanelStyle.Items.Add(Me.inputOption5)
        Me.cbPanelStyle.Items.Add(Me.inputOption6)
        Me.cbPanelStyle.Items.Add(Me.inputOption7)
        Me.cbPanelStyle.Items.Add(Me.inputOption8)
        Me.cbPanelStyle.Name = "cbPanelStyle"
        Me.cbPanelStyle.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        Me.cbPanelStyle.Width = 110
        '
        'inputOption1
        '
        Me.inputOption1.Name = "inputOption1"
        Me.inputOption1.Text = "System"
        '
        'inputOption2
        '
        Me.inputOption2.Name = "inputOption2"
        Me.inputOption2.Text = "Office2007Black"
        '
        'inputOption3
        '
        Me.inputOption3.Name = "inputOption3"
        Me.inputOption3.Text = "Office2007Blue"
        '
        'inputOption4
        '
        Me.inputOption4.Name = "inputOption4"
        Me.inputOption4.Text = "Office2007Silver"
        '
        'inputOption5
        '
        Me.inputOption5.Name = "inputOption5"
        Me.inputOption5.Text = "Office2010Black"
        '
        'inputOption6
        '
        Me.inputOption6.Name = "inputOption6"
        Me.inputOption6.Text = "Office2010Blue"
        '
        'inputOption7
        '
        Me.inputOption7.Name = "inputOption7"
        Me.inputOption7.Text = "Office2010Silver"
        '
        'inputOption8
        '
        Me.inputOption8.Name = "inputOption8"
        Me.inputOption8.Text = "Windows7"
        '
        'btnPanelReset
        '
        Me.btnPanelReset.Height = 26
        Me.btnPanelReset.Name = "btnPanelReset"
        Me.btnPanelReset.Text = "Reset Style"
        Me.btnPanelReset.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Far
        '
        'inputCheckBox1
        '
        Me.inputCheckBox1.Name = "inputCheckBox1"
        Me.inputCheckBox1.Text = "CheckBox"
        '
        'inputTrackBar1
        '
        Me.inputTrackBar1.Name = "inputTrackBar1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(9, 37)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(9, 37)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "CheckBox2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 331)
        Me.Controls.Add(Me.c1SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "VisualStyles Demo"
        CType(Me.c1SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1SplitContainer1.ResumeLayout(False)
        Me.c1SplitterPanel1.ResumeLayout(False)
        CType(Me.c1SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1SplitContainer2.ResumeLayout(False)
        Me.c1SplitterPanel2.ResumeLayout(False)
        Me.c1SplitterPanel2.PerformLayout()
        Me.c1SplitterPanel4.ResumeLayout(False)
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1SplitterPanel3.ResumeLayout(False)
        Me.c1SplitterPanel3.PerformLayout()
        Me.c1SplitterPanel5.ResumeLayout(False)
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents c1SplitContainer1 As C1.Win.SplitContainer.C1SplitContainer
    Private WithEvents c1SplitterPanel1 As C1.Win.SplitContainer.C1SplitterPanel
    Private WithEvents c1SplitContainer2 As C1.Win.SplitContainer.C1SplitContainer
    Private WithEvents c1SplitterPanel2 As C1.Win.SplitContainer.C1SplitterPanel
    Private WithEvents btnInnerReset As System.Windows.Forms.Button
    Private WithEvents cbInnerStyle As System.Windows.Forms.ComboBox
    Private WithEvents c1SplitterPanel4 As C1.Win.SplitContainer.C1SplitterPanel
    Private WithEvents c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
    Private WithEvents c1SplitterPanel3 As C1.Win.SplitContainer.C1SplitterPanel
    Private WithEvents btnOuterReset As System.Windows.Forms.Button
    Private WithEvents cbOuterStyle As System.Windows.Forms.ComboBox
    Private WithEvents c1SplitterPanel5 As C1.Win.SplitContainer.C1SplitterPanel
    Private WithEvents c1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents inputGroupHeader1 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel1 As C1.Win.InputPanel.InputLabel
    Private WithEvents cbPanelStyle As C1.Win.InputPanel.InputComboBox
    Private WithEvents inputOption1 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption2 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption3 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption4 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption5 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption6 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption7 As C1.Win.InputPanel.InputOption
    Private WithEvents inputOption8 As C1.Win.InputPanel.InputOption
    Private WithEvents btnPanelReset As C1.Win.InputPanel.InputButton
    Private WithEvents inputCheckBox1 As C1.Win.InputPanel.InputCheckBox
    Private WithEvents inputTrackBar1 As C1.Win.InputPanel.InputTrackBar
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
