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
        Me.components = New System.ComponentModel.Container
        Me.splitContainer1 = New System.Windows.Forms.SplitContainer
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.c1SuperLabel4 = New C1.Win.SuperTooltip.C1SuperLabel
        Me.c1SuperLabel1 = New C1.Win.SuperTooltip.C1SuperLabel
        Me.c1SuperLabel5 = New C1.Win.SuperTooltip.C1SuperLabel
        Me.button1 = New System.Windows.Forms.Button
        Me.comboBox1 = New System.Windows.Forms.ComboBox
        Me.c1SuperLabel3 = New C1.Win.SuperTooltip.C1SuperLabel
        Me.c1SuperLabel2 = New C1.Win.SuperTooltip.C1SuperLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.splitContainer1.Panel1.SuspendLayout()
        Me.splitContainer1.Panel2.SuspendLayout()
        Me.splitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitContainer1
        '
        Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splitContainer1.Location = New System.Drawing.Point(0, 35)
        Me.splitContainer1.Name = "splitContainer1"
        '
        'splitContainer1.Panel1
        '
        Me.splitContainer1.Panel1.Controls.Add(Me.richTextBox1)
        Me.splitContainer1.Panel1.Controls.Add(Me.c1SuperLabel4)
        '
        'splitContainer1.Panel2
        '
        Me.splitContainer1.Panel2.Controls.Add(Me.c1SuperLabel1)
        Me.splitContainer1.Panel2.Controls.Add(Me.c1SuperLabel5)
        Me.splitContainer1.Size = New System.Drawing.Size(730, 362)
        Me.splitContainer1.SplitterDistance = 342
        Me.splitContainer1.SplitterWidth = 5
        Me.splitContainer1.TabIndex = 9
        '
        'richTextBox1
        '
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.richTextBox1.Location = New System.Drawing.Point(0, 21)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(342, 341)
        Me.richTextBox1.TabIndex = 1
        Me.richTextBox1.Text = ""
        Me.richTextBox1.WordWrap = False
        '
        'c1SuperLabel4
        '
        Me.c1SuperLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1SuperLabel4.Location = New System.Drawing.Point(0, 0)
        Me.c1SuperLabel4.Name = "c1SuperLabel4"
        Me.c1SuperLabel4.Size = New System.Drawing.Size(342, 21)
        Me.c1SuperLabel4.TabIndex = 0
        Me.c1SuperLabel4.Text = "&Html Source"
        '
        'c1SuperLabel1
        '
        Me.c1SuperLabel1.BackColor = System.Drawing.Color.White
        Me.c1SuperLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.c1SuperLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1SuperLabel1.Location = New System.Drawing.Point(0, 21)
        Me.c1SuperLabel1.Name = "c1SuperLabel1"
        Me.c1SuperLabel1.Size = New System.Drawing.Size(383, 341)
        Me.c1SuperLabel1.TabIndex = 1
        '
        'c1SuperLabel5
        '
        Me.c1SuperLabel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1SuperLabel5.Location = New System.Drawing.Point(0, 0)
        Me.c1SuperLabel5.Name = "c1SuperLabel5"
        Me.c1SuperLabel5.Size = New System.Drawing.Size(383, 21)
        Me.c1SuperLabel5.TabIndex = 0
        Me.c1SuperLabel5.Text = "Preview"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(474, 3)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(35, 20)
        Me.button1.TabIndex = 8
        Me.button1.Text = "..."
        Me.button1.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(140, 4)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(212, 21)
        Me.comboBox1.TabIndex = 6
        '
        'c1SuperLabel3
        '
        Me.c1SuperLabel3.AutoSize = True
        Me.c1SuperLabel3.Location = New System.Drawing.Point(372, 5)
        Me.c1SuperLabel3.Name = "c1SuperLabel3"
        Me.c1SuperLabel3.Size = New System.Drawing.Size(81, 19)
        Me.c1SuperLabel3.TabIndex = 7
        Me.c1SuperLabel3.Text = "&Open <b>Html</b> file:"
        '
        'c1SuperLabel2
        '
        Me.c1SuperLabel2.AutoSize = True
        Me.c1SuperLabel2.Location = New System.Drawing.Point(8, 5)
        Me.c1SuperLabel2.Name = "c1SuperLabel2"
        Me.c1SuperLabel2.Size = New System.Drawing.Size(107, 19)
        Me.c1SuperLabel2.TabIndex = 5
        Me.c1SuperLabel2.Text = "&Select <b>Html</b> content:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 397)
        Me.Controls.Add(Me.splitContainer1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.c1SuperLabel3)
        Me.Controls.Add(Me.c1SuperLabel2)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(0, 35, 0, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1SuperLabel: Show Html text in labels"
        Me.splitContainer1.Panel1.ResumeLayout(False)
        Me.splitContainer1.Panel2.ResumeLayout(False)
        Me.splitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents splitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents c1SuperLabel4 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents c1SuperLabel1 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents c1SuperLabel5 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents c1SuperLabel3 As C1.Win.SuperTooltip.C1SuperLabel
    Private WithEvents c1SuperLabel2 As C1.Win.SuperTooltip.C1SuperLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
