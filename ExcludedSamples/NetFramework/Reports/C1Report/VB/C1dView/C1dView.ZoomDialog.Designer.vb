<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZoomDialog
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
        Me.rbtFitTextWidth = New System.Windows.Forms.RadioButton()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.chkFacing = New System.Windows.Forms.CheckBox()
        Me.rbtFitWidth = New System.Windows.Forms.RadioButton()
        Me.chkContinuous = New System.Windows.Forms.CheckBox()
        Me.numCols = New System.Windows.Forms.NumericUpDown()
        Me.numRows = New System.Windows.Forms.NumericUpDown()
        Me.label3 = New System.Windows.Forms.Label()
        Me.rbtFitWindow = New System.Windows.Forms.RadioButton()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbt100 = New System.Windows.Forms.RadioButton()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.numZoom = New System.Windows.Forms.NumericUpDown()
        CType(Me.numCols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.numZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbtFitTextWidth
        '
        Me.rbtFitTextWidth.AutoSize = True
        Me.rbtFitTextWidth.Location = New System.Drawing.Point(6, 93)
        Me.rbtFitTextWidth.Name = "rbtFitTextWidth"
        Me.rbtFitTextWidth.Size = New System.Drawing.Size(91, 17)
        Me.rbtFitTextWidth.TabIndex = 3
        Me.rbtFitTextWidth.TabStop = True
        Me.rbtFitTextWidth.Text = "Fit Text Width"
        Me.rbtFitTextWidth.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOk.Location = New System.Drawing.Point(259, 138)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 19
        Me.btnOk.Text = "&Close"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'chkFacing
        '
        Me.chkFacing.AutoSize = True
        Me.chkFacing.Location = New System.Drawing.Point(15, 90)
        Me.chkFacing.Name = "chkFacing"
        Me.chkFacing.Size = New System.Drawing.Size(168, 17)
        Me.chkFacing.TabIndex = 16
        Me.chkFacing.Text = "Facing Pages, Cover on Right"
        Me.chkFacing.UseVisualStyleBackColor = True
        '
        'rbtFitWidth
        '
        Me.rbtFitWidth.AutoSize = True
        Me.rbtFitWidth.Location = New System.Drawing.Point(6, 70)
        Me.rbtFitWidth.Name = "rbtFitWidth"
        Me.rbtFitWidth.Size = New System.Drawing.Size(67, 17)
        Me.rbtFitWidth.TabIndex = 2
        Me.rbtFitWidth.TabStop = True
        Me.rbtFitWidth.Text = "Fit Width"
        Me.rbtFitWidth.UseVisualStyleBackColor = True
        '
        'chkContinuous
        '
        Me.chkContinuous.AutoSize = True
        Me.chkContinuous.Location = New System.Drawing.Point(15, 113)
        Me.chkContinuous.Name = "chkContinuous"
        Me.chkContinuous.Size = New System.Drawing.Size(79, 17)
        Me.chkContinuous.TabIndex = 17
        Me.chkContinuous.Text = "Continuous"
        Me.chkContinuous.UseVisualStyleBackColor = True
        '
        'numCols
        '
        Me.numCols.Location = New System.Drawing.Point(117, 64)
        Me.numCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCols.Name = "numCols"
        Me.numCols.Size = New System.Drawing.Size(59, 20)
        Me.numCols.TabIndex = 15
        Me.numCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'numRows
        '
        Me.numRows.Location = New System.Drawing.Point(117, 38)
        Me.numRows.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numRows.Name = "numRows"
        Me.numRows.Size = New System.Drawing.Size(59, 20)
        Me.numRows.TabIndex = 13
        Me.numRows.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(12, 66)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Page Columns:"
        '
        'rbtFitWindow
        '
        Me.rbtFitWindow.AutoSize = True
        Me.rbtFitWindow.Location = New System.Drawing.Point(6, 47)
        Me.rbtFitWindow.Name = "rbtFitWindow"
        Me.rbtFitWindow.Size = New System.Drawing.Size(78, 17)
        Me.rbtFitWindow.TabIndex = 1
        Me.rbtFitWindow.TabStop = True
        Me.rbtFitWindow.Text = "Fit Window"
        Me.rbtFitWindow.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.rbtFitWidth)
        Me.groupBox1.Controls.Add(Me.rbtFitTextWidth)
        Me.groupBox1.Controls.Add(Me.rbt100)
        Me.groupBox1.Controls.Add(Me.rbtFitWindow)
        Me.groupBox1.Location = New System.Drawing.Point(216, 12)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(118, 115)
        Me.groupBox1.TabIndex = 18
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Auto Zoom"
        '
        'rbt100
        '
        Me.rbt100.AutoSize = True
        Me.rbt100.Location = New System.Drawing.Point(6, 24)
        Me.rbt100.Name = "rbt100"
        Me.rbt100.Size = New System.Drawing.Size(51, 17)
        Me.rbt100.TabIndex = 0
        Me.rbt100.TabStop = True
        Me.rbt100.Text = "100%"
        Me.rbt100.UseVisualStyleBackColor = True
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(12, 40)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(65, 13)
        Me.label2.TabIndex = 12
        Me.label2.Text = "Page Rows:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(48, 13)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Zoom %:"
        '
        'numZoom
        '
        Me.numZoom.Location = New System.Drawing.Point(84, 12)
        Me.numZoom.Name = "numZoom"
        Me.numZoom.Size = New System.Drawing.Size(92, 20)
        Me.numZoom.TabIndex = 11
        '
        'ZoomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 173)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.chkFacing)
        Me.Controls.Add(Me.chkContinuous)
        Me.Controls.Add(Me.numCols)
        Me.Controls.Add(Me.numRows)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.numZoom)
        Me.Name = "ZoomDialog"
        Me.Text = "ZoomDialog"
        CType(Me.numCols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numRows, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.numZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents rbtFitTextWidth As System.Windows.Forms.RadioButton
    Private WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents chkFacing As System.Windows.Forms.CheckBox
    Private WithEvents rbtFitWidth As System.Windows.Forms.RadioButton
    Private WithEvents chkContinuous As System.Windows.Forms.CheckBox
    Private WithEvents numCols As System.Windows.Forms.NumericUpDown
    Private WithEvents numRows As System.Windows.Forms.NumericUpDown
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents rbtFitWindow As System.Windows.Forms.RadioButton
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents rbt100 As System.Windows.Forms.RadioButton
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents numZoom As System.Windows.Forms.NumericUpDown
End Class
