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
        Me.c1InputPanel1 = New C1.Win.InputPanel.C1InputPanel
        Me.inputGroupHeader1 = New C1.Win.InputPanel.InputGroupHeader
        Me.inputLabel1 = New C1.Win.InputPanel.InputLabel
        Me.inputTextBox1 = New C1.Win.InputPanel.InputTextBox
        Me.inputLabel2 = New C1.Win.InputPanel.InputLabel
        Me.inputNumericBox1 = New C1.Win.InputPanel.InputNumericBox
        Me.inputLabel5 = New C1.Win.InputPanel.InputLabel
        Me.inputNumericBox2 = New C1.Win.InputPanel.InputNumericBox
        Me.inputLabel4 = New C1.Win.InputPanel.InputLabel
        Me.inputTimePicker1 = New C1.Win.InputPanel.InputTimePicker
        Me.inputLabel3 = New C1.Win.InputPanel.InputLabel
        Me.inputCheckBox1 = New C1.Win.InputPanel.InputCheckBox
        Me.inputCheckBox2 = New C1.Win.InputPanel.InputCheckBox
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1InputPanel1
        '
        Me.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1InputPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.c1InputPanel1.Items.Add(Me.inputGroupHeader1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel1)
        Me.c1InputPanel1.Items.Add(Me.inputTextBox1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel2)
        Me.c1InputPanel1.Items.Add(Me.inputNumericBox1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel5)
        Me.c1InputPanel1.Items.Add(Me.inputNumericBox2)
        Me.c1InputPanel1.Items.Add(Me.inputLabel4)
        Me.c1InputPanel1.Items.Add(Me.inputTimePicker1)
        Me.c1InputPanel1.Items.Add(Me.inputLabel3)
        Me.c1InputPanel1.Items.Add(Me.inputCheckBox1)
        Me.c1InputPanel1.Items.Add(Me.inputCheckBox2)
        Me.c1InputPanel1.Location = New System.Drawing.Point(0, 0)
        Me.c1InputPanel1.Name = "c1InputPanel1"
        Me.c1InputPanel1.Size = New System.Drawing.Size(443, 171)
        Me.c1InputPanel1.TabIndex = 1
        '
        'inputGroupHeader1
        '
        Me.inputGroupHeader1.Text = "ErrorProvider Demo"
        '
        'inputLabel1
        '
        Me.inputLabel1.Text = "Type something that starts with 'a':"
        Me.inputLabel1.Width = 236
        '
        'inputTextBox1
        '
        Me.inputTextBox1.ElementWidth = 180
        Me.inputTextBox1.Text = "acceptable..."
        Me.inputTextBox1.ToolTipText = "This is an <b>InputTextBox</b>.<br>What you type here doesn't really matter, as l" & _
            "ong as it starts with 'a'..."
        '
        'inputLabel2
        '
        Me.inputLabel2.Text = "Enter an even value:"
        Me.inputLabel2.Width = 236
        '
        'inputNumericBox1
        '
        Me.inputNumericBox1.Format = Nothing
        Me.inputNumericBox1.ToolTipText = "This is an <b>InputNumericBox</b>.<br>It only accepts even numbers."
        Me.inputNumericBox1.Value = New Decimal(New Integer() {98, 0, 0, 0})
        '
        'inputLabel5
        '
        Me.inputLabel5.Text = "Enter a value that totals 100 or more:"
        Me.inputLabel5.Width = 236
        '
        'inputNumericBox2
        '
        Me.inputNumericBox2.Format = Nothing
        Me.inputNumericBox2.ToolTipText = "This is an <b>InputNumericBox</b>.<br>The value should add to at least 100 with t" & _
            "he value in the previous box."
        Me.inputNumericBox2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'inputLabel4
        '
        Me.inputLabel4.Text = "Enter a time after 12:00:"
        Me.inputLabel4.Width = 236
        '
        'inputTimePicker1
        '
        Me.inputTimePicker1.ToolTipText = "This is an <b>InputTimePicker</b>.<br>The time you enter here shold be less than " & _
            "12:00 (noon)."
        Me.inputTimePicker1.Value = System.TimeSpan.Parse("12:01:00")
        '
        'inputLabel3
        '
        Me.inputLabel3.Text = "Check at least one box:"
        Me.inputLabel3.Width = 236
        '
        'inputCheckBox1
        '
        Me.inputCheckBox1.Break = C1.Win.InputPanel.BreakType.None
        Me.inputCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.inputCheckBox1.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " & _
            "proceeding."
        '
        'inputCheckBox2
        '
        Me.inputCheckBox2.ToolTipText = "This is an <b>InputCheckBox<b>.<br>Please check at least one of the boxes before " & _
            "proceeding."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 171)
        Me.Controls.Add(Me.c1InputPanel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1InputPanel: Validation"
        CType(Me.c1InputPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1InputPanel1 As C1.Win.InputPanel.C1InputPanel
    Private WithEvents inputGroupHeader1 As C1.Win.InputPanel.InputGroupHeader
    Private WithEvents inputLabel1 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTextBox1 As C1.Win.InputPanel.InputTextBox
    Private WithEvents inputLabel2 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputNumericBox1 As C1.Win.InputPanel.InputNumericBox
    Private WithEvents inputLabel5 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputNumericBox2 As C1.Win.InputPanel.InputNumericBox
    Private WithEvents inputLabel4 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputTimePicker1 As C1.Win.InputPanel.InputTimePicker
    Private WithEvents inputLabel3 As C1.Win.InputPanel.InputLabel
    Private WithEvents inputCheckBox1 As C1.Win.InputPanel.InputCheckBox
    Private WithEvents inputCheckBox2 As C1.Win.InputPanel.InputCheckBox

End Class
