<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.C1InputPanel1 = New C1.Win.C1InputPanel.C1InputPanel
        Me.xmlTextBox = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.themeCombo = New System.Windows.Forms.ComboBox
        Me.reloadButton = New System.Windows.Forms.Button
        Me.testCaseCombo = New System.Windows.Forms.ComboBox
        Me.label1 = New System.Windows.Forms.Label
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.splitContainer1.Location = New System.Drawing.Point(15, 33)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.C1InputPanel1)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.xmlTextBox)
        Me.splitContainer1.Size = New System.Drawing.Size(893, 503)
        Me.splitContainer1.SplitterDistance = 452
        Me.splitContainer1.TabIndex = 13
        '
        'C1InputPanel1
        '
        Me.C1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1InputPanel1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.C1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.C1InputPanel1.Name = "C1InputPanel1"
        Me.C1InputPanel1.Size = New System.Drawing.Size(452, 503)
        Me.C1InputPanel1.TabIndex = 0
        Me.C1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Office2007Blue
        '
        'xmlTextBox
        '
        Me.xmlTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xmlTextBox.Location = New System.Drawing.Point(0, 0)
        Me.xmlTextBox.Multiline = True
        Me.xmlTextBox.Name = "xmlTextBox"
        Me.xmlTextBox.ReadOnly = True
        Me.xmlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.xmlTextBox.Size = New System.Drawing.Size(437, 503)
        Me.xmlTextBox.TabIndex = 0
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(242, 9)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(43, 13)
        Me.label2.TabIndex = 10
        Me.label2.Text = "Theme:"
        '
        'themeCombo
        '
        Me.themeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.themeCombo.FormattingEnabled = True
        Me.themeCombo.Items.AddRange(New Object() {"System", "Blue", "Black", "Silver"})
        Me.themeCombo.Location = New System.Drawing.Point(291, 6)
        Me.themeCombo.Name = "themeCombo"
        Me.themeCombo.Size = New System.Drawing.Size(79, 21)
        Me.themeCombo.TabIndex = 11
        '
        'reloadButton
        '
        Me.reloadButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reloadButton.Location = New System.Drawing.Point(834, 4)
        Me.reloadButton.Name = "reloadButton"
        Me.reloadButton.Size = New System.Drawing.Size(74, 23)
        Me.reloadButton.TabIndex = 12
        Me.reloadButton.Text = "Reload XML"
        Me.reloadButton.UseVisualStyleBackColor = True
        '
        'testCaseCombo
        '
        Me.testCaseCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.testCaseCombo.FormattingEnabled = True
        Me.testCaseCombo.Location = New System.Drawing.Point(77, 6)
        Me.testCaseCombo.Name = "testCaseCombo"
        Me.testCaseCombo.Size = New System.Drawing.Size(153, 21)
        Me.testCaseCombo.TabIndex = 9
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(59, 13)
        Me.label1.TabIndex = 8
        Me.label1.Text = "Test Case:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 548)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.themeCombo)
        Me.Controls.Add(Me.reloadButton)
        Me.Controls.Add(Me.testCaseCombo)
        Me.Controls.Add(Me.label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name = "Form1"
        Me.Text = "Test Cases Sample"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.Panel2.PerformLayout()
        Me.splitContainer1.ResumeLayout(False)
        CType(Me.C1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents xmlTextBox As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents themeCombo As System.Windows.Forms.ComboBox
    Private WithEvents reloadButton As System.Windows.Forms.Button
    Private WithEvents testCaseCombo As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents C1InputPanel1 As C1.Win.C1InputPanel.C1InputPanel

End Class
