<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.C1XLBook1 = New C1.Excel.C1XLBook
        Me.groupBox3 = New System.Windows.Forms.GroupBox
        Me.label6 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.label8 = New System.Windows.Forms.Label
        Me.label9 = New System.Windows.Forms.Label
        Me._udLeft = New System.Windows.Forms.NumericUpDown
        Me._udRight = New System.Windows.Forms.NumericUpDown
        Me._udTop = New System.Windows.Forms.NumericUpDown
        Me._udBottom = New System.Windows.Forms.NumericUpDown
        Me.label10 = New System.Windows.Forms.Label
        Me.label11 = New System.Windows.Forms.Label
        Me._udFooter = New System.Windows.Forms.NumericUpDown
        Me._udHeader = New System.Windows.Forms.NumericUpDown
        Me._txtStartPage = New System.Windows.Forms.TextBox
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me._rdPortrait = New System.Windows.Forms.RadioButton
        Me._rdLandscape = New System.Windows.Forms.RadioButton
        Me.label4 = New System.Windows.Forms.Label
        Me._cmbPaperSize = New System.Windows.Forms.ComboBox
        Me.button1 = New System.Windows.Forms.Button
        Me.groupBox2 = New System.Windows.Forms.GroupBox
        Me.label1 = New System.Windows.Forms.Label
        Me._udPercentSize = New System.Windows.Forms.NumericUpDown
        Me._rdAdjust = New System.Windows.Forms.RadioButton
        Me._rdFit = New System.Windows.Forms.RadioButton
        Me.label2 = New System.Windows.Forms.Label
        Me._udAcross = New System.Windows.Forms.NumericUpDown
        Me._udDown = New System.Windows.Forms.NumericUpDown
        Me.label3 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.button2 = New System.Windows.Forms.Button
        Me._txtHeader = New System.Windows.Forms.TextBox
        Me._txtFooter = New System.Windows.Forms.TextBox
        Me.label12 = New System.Windows.Forms.Label
        Me.label13 = New System.Windows.Forms.Label
        Me.groupBox3.SuspendLayout()
        CType(Me._udLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udTop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udFooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me._udPercentSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udAcross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._udDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox3
        '
        Me.groupBox3.Controls.Add(Me.label6)
        Me.groupBox3.Controls.Add(Me.label7)
        Me.groupBox3.Controls.Add(Me.label8)
        Me.groupBox3.Controls.Add(Me.label9)
        Me.groupBox3.Controls.Add(Me._udLeft)
        Me.groupBox3.Controls.Add(Me._udRight)
        Me.groupBox3.Controls.Add(Me._udTop)
        Me.groupBox3.Controls.Add(Me._udBottom)
        Me.groupBox3.Controls.Add(Me.label10)
        Me.groupBox3.Controls.Add(Me.label11)
        Me.groupBox3.Controls.Add(Me._udFooter)
        Me.groupBox3.Controls.Add(Me._udHeader)
        Me.groupBox3.Location = New System.Drawing.Point(320, 116)
        Me.groupBox3.Name = "groupBox3"
        Me.groupBox3.Size = New System.Drawing.Size(288, 104)
        Me.groupBox3.TabIndex = 16
        Me.groupBox3.TabStop = False
        Me.groupBox3.Text = "Margins"
        '
        'label6
        '
        Me.label6.Location = New System.Drawing.Point(8, 24)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(56, 16)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Left"
        Me.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label7
        '
        Me.label7.Location = New System.Drawing.Point(152, 24)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(56, 16)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Right"
        Me.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label8
        '
        Me.label8.Location = New System.Drawing.Point(8, 48)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(56, 16)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Top"
        Me.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label9
        '
        Me.label9.Location = New System.Drawing.Point(152, 48)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(56, 16)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Bottom"
        Me.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        '_udLeft
        '
        Me._udLeft.DecimalPlaces = 2
        Me._udLeft.Location = New System.Drawing.Point(64, 24)
        Me._udLeft.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udLeft.Name = "_udLeft"
        Me._udLeft.Size = New System.Drawing.Size(72, 20)
        Me._udLeft.TabIndex = 1
        Me._udLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udLeft.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_udRight
        '
        Me._udRight.DecimalPlaces = 2
        Me._udRight.Location = New System.Drawing.Point(208, 24)
        Me._udRight.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udRight.Name = "_udRight"
        Me._udRight.Size = New System.Drawing.Size(72, 20)
        Me._udRight.TabIndex = 1
        Me._udRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udRight.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_udTop
        '
        Me._udTop.DecimalPlaces = 2
        Me._udTop.Location = New System.Drawing.Point(64, 48)
        Me._udTop.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udTop.Name = "_udTop"
        Me._udTop.Size = New System.Drawing.Size(72, 20)
        Me._udTop.TabIndex = 1
        Me._udTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udTop.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_udBottom
        '
        Me._udBottom.DecimalPlaces = 2
        Me._udBottom.Location = New System.Drawing.Point(208, 48)
        Me._udBottom.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udBottom.Name = "_udBottom"
        Me._udBottom.Size = New System.Drawing.Size(72, 20)
        Me._udBottom.TabIndex = 1
        Me._udBottom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udBottom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label10
        '
        Me.label10.Location = New System.Drawing.Point(8, 72)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(56, 16)
        Me.label10.TabIndex = 0
        Me.label10.Text = "Header"
        Me.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label11
        '
        Me.label11.Location = New System.Drawing.Point(152, 72)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(56, 16)
        Me.label11.TabIndex = 0
        Me.label11.Text = "Footer"
        Me.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        '_udFooter
        '
        Me._udFooter.DecimalPlaces = 2
        Me._udFooter.Location = New System.Drawing.Point(208, 72)
        Me._udFooter.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udFooter.Name = "_udFooter"
        Me._udFooter.Size = New System.Drawing.Size(72, 20)
        Me._udFooter.TabIndex = 1
        Me._udFooter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udFooter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_udHeader
        '
        Me._udHeader.DecimalPlaces = 2
        Me._udHeader.Location = New System.Drawing.Point(64, 72)
        Me._udHeader.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udHeader.Name = "_udHeader"
        Me._udHeader.Size = New System.Drawing.Size(72, 20)
        Me._udHeader.TabIndex = 1
        Me._udHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udHeader.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        '_txtStartPage
        '
        Me._txtStartPage.Location = New System.Drawing.Point(120, 300)
        Me._txtStartPage.Name = "_txtStartPage"
        Me._txtStartPage.Size = New System.Drawing.Size(112, 20)
        Me._txtStartPage.TabIndex = 13
        Me._txtStartPage.Text = "Auto"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me._rdPortrait)
        Me.groupBox1.Controls.Add(Me._rdLandscape)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me._cmbPaperSize)
        Me.groupBox1.Location = New System.Drawing.Point(8, 52)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(600, 56)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Paper Size/Orientation"
        '
        '_rdPortrait
        '
        Me._rdPortrait.Location = New System.Drawing.Point(368, 24)
        Me._rdPortrait.Name = "_rdPortrait"
        Me._rdPortrait.Size = New System.Drawing.Size(64, 16)
        Me._rdPortrait.TabIndex = 0
        Me._rdPortrait.Text = "Portrait"
        '
        '_rdLandscape
        '
        Me._rdLandscape.Location = New System.Drawing.Point(440, 24)
        Me._rdLandscape.Name = "_rdLandscape"
        Me._rdLandscape.Size = New System.Drawing.Size(112, 16)
        Me._rdLandscape.TabIndex = 0
        Me._rdLandscape.Text = "Landscape"
        '
        'label4
        '
        Me.label4.Location = New System.Drawing.Point(8, 24)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(72, 16)
        Me.label4.TabIndex = 2
        Me.label4.Text = "Paper Size"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        '_cmbPaperSize
        '
        Me._cmbPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._cmbPaperSize.Location = New System.Drawing.Point(88, 22)
        Me._cmbPaperSize.Name = "_cmbPaperSize"
        Me._cmbPaperSize.Size = New System.Drawing.Size(240, 21)
        Me._cmbPaperSize.TabIndex = 3
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(8, 12)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(120, 24)
        Me.button1.TabIndex = 6
        Me.button1.Text = "Load"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.label1)
        Me.groupBox2.Controls.Add(Me._udPercentSize)
        Me.groupBox2.Controls.Add(Me._rdAdjust)
        Me.groupBox2.Controls.Add(Me._rdFit)
        Me.groupBox2.Controls.Add(Me.label2)
        Me.groupBox2.Controls.Add(Me._udAcross)
        Me.groupBox2.Controls.Add(Me._udDown)
        Me.groupBox2.Controls.Add(Me.label3)
        Me.groupBox2.Location = New System.Drawing.Point(8, 116)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(304, 104)
        Me.groupBox2.TabIndex = 8
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Scaling"
        '
        'label1
        '
        Me.label1.Location = New System.Drawing.Point(136, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(96, 16)
        Me.label1.TabIndex = 2
        Me.label1.Text = "% normal size"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        '_udPercentSize
        '
        Me._udPercentSize.Location = New System.Drawing.Point(80, 22)
        Me._udPercentSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me._udPercentSize.Minimum = New Decimal(New Integer() {1, 0, 0, -2147483648})
        Me._udPercentSize.Name = "_udPercentSize"
        Me._udPercentSize.Size = New System.Drawing.Size(48, 20)
        Me._udPercentSize.TabIndex = 1
        Me._udPercentSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me._udPercentSize.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        '_rdAdjust
        '
        Me._rdAdjust.Location = New System.Drawing.Point(8, 24)
        Me._rdAdjust.Name = "_rdAdjust"
        Me._rdAdjust.Size = New System.Drawing.Size(72, 16)
        Me._rdAdjust.TabIndex = 0
        Me._rdAdjust.Text = "Adjust to"
        '
        '_rdFit
        '
        Me._rdFit.Location = New System.Drawing.Point(8, 64)
        Me._rdFit.Name = "_rdFit"
        Me._rdFit.Size = New System.Drawing.Size(56, 16)
        Me._rdFit.TabIndex = 0
        Me._rdFit.Text = "Fit to"
        '
        'label2
        '
        Me.label2.Location = New System.Drawing.Point(136, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(80, 16)
        Me.label2.TabIndex = 2
        Me.label2.Text = "pages wide by"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        '_udAcross
        '
        Me._udAcross.Location = New System.Drawing.Point(80, 62)
        Me._udAcross.Name = "_udAcross"
        Me._udAcross.Size = New System.Drawing.Size(48, 20)
        Me._udAcross.TabIndex = 1
        Me._udAcross.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_udDown
        '
        Me._udDown.Location = New System.Drawing.Point(216, 62)
        Me._udDown.Name = "_udDown"
        Me._udDown.Size = New System.Drawing.Size(48, 20)
        Me._udDown.TabIndex = 1
        Me._udDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label3
        '
        Me.label3.Location = New System.Drawing.Point(272, 64)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 16)
        Me.label3.TabIndex = 2
        Me.label3.Text = "tall"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label5
        '
        Me.label5.Location = New System.Drawing.Point(16, 300)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(104, 16)
        Me.label5.TabIndex = 12
        Me.label5.Text = "First page number"
        Me.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(144, 12)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(120, 24)
        Me.button2.TabIndex = 7
        Me.button2.Text = "Save"
        '
        '_txtHeader
        '
        Me._txtHeader.Location = New System.Drawing.Point(120, 236)
        Me._txtHeader.Name = "_txtHeader"
        Me._txtHeader.Size = New System.Drawing.Size(488, 20)
        Me._txtHeader.TabIndex = 15
        '
        '_txtFooter
        '
        Me._txtFooter.Location = New System.Drawing.Point(120, 268)
        Me._txtFooter.Name = "_txtFooter"
        Me._txtFooter.Size = New System.Drawing.Size(488, 20)
        Me._txtFooter.TabIndex = 14
        '
        'label12
        '
        Me.label12.Location = New System.Drawing.Point(16, 268)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(104, 16)
        Me.label12.TabIndex = 11
        Me.label12.Text = "Page Footer"
        Me.label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'label13
        '
        Me.label13.Location = New System.Drawing.Point(16, 236)
        Me.label13.Name = "label13"
        Me.label13.Size = New System.Drawing.Size(104, 16)
        Me.label13.TabIndex = 10
        Me.label13.Text = "Page Header"
        Me.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 333)
        Me.Controls.Add(Me.groupBox3)
        Me.Controls.Add(Me._txtStartPage)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me._txtHeader)
        Me.Controls.Add(Me._txtFooter)
        Me.Controls.Add(Me.label12)
        Me.Controls.Add(Me.label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Excel: Print Settings"
        Me.groupBox3.ResumeLayout(False)
        CType(Me._udLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udTop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udFooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        CType(Me._udPercentSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udAcross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._udDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C1XLBook1 As C1.Excel.C1XLBook
    Private WithEvents groupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents _udLeft As System.Windows.Forms.NumericUpDown
    Private WithEvents _udRight As System.Windows.Forms.NumericUpDown
    Private WithEvents _udTop As System.Windows.Forms.NumericUpDown
    Private WithEvents _udBottom As System.Windows.Forms.NumericUpDown
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents _udFooter As System.Windows.Forms.NumericUpDown
    Private WithEvents _udHeader As System.Windows.Forms.NumericUpDown
    Private WithEvents _txtStartPage As System.Windows.Forms.TextBox
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents _rdPortrait As System.Windows.Forms.RadioButton
    Private WithEvents _rdLandscape As System.Windows.Forms.RadioButton
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents _cmbPaperSize As System.Windows.Forms.ComboBox
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents _udPercentSize As System.Windows.Forms.NumericUpDown
    Private WithEvents _rdAdjust As System.Windows.Forms.RadioButton
    Private WithEvents _rdFit As System.Windows.Forms.RadioButton
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents _udAcross As System.Windows.Forms.NumericUpDown
    Private WithEvents _udDown As System.Windows.Forms.NumericUpDown
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents _txtHeader As System.Windows.Forms.TextBox
    Private WithEvents _txtFooter As System.Windows.Forms.TextBox
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents label13 As System.Windows.Forms.Label

End Class
