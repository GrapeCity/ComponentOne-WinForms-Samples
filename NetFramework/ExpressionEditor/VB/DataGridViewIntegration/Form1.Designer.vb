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
        Me.splitter1 = New System.Windows.Forms.Splitter()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.DataGridViewEE1 = New DataGridViewIntegration.DataGridViewEE()
        Me.groupBox1.SuspendLayout()
        CType(Me.DataGridViewEE1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splitter1
        '
        Me.splitter1.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.splitter1.Location = New System.Drawing.Point(0, 404)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(784, 3)
        Me.splitter1.TabIndex = 4
        Me.splitter1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.groupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.groupBox1.Location = New System.Drawing.Point(0, 407)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(784, 54)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(12, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(355, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Mouse right click on Expression column header to open Expression Editor."
        '
        'DataGridViewEE1
        '
        Me.DataGridViewEE1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEE1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewEE1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewEE1.Name = "DataGridViewEE1"
        Me.DataGridViewEE1.Size = New System.Drawing.Size(784, 404)
        Me.DataGridViewEE1.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.DataGridViewEE1)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Form1"
        Me.Text = "DataGridView Integration sample"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.DataGridViewEE1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents splitter1 As Splitter
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents label1 As Label
    Friend WithEvents DataGridViewEE1 As DataGridViewEE
End Class
