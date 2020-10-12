<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.listBoxCustomers = New System.Windows.Forms.ListBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.comboBoxCity = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Location = New System.Drawing.Point(222, 5)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(587, 337)
        Me.tabControl1.TabIndex = 9
        '
        'listBoxCustomers
        '
        Me.listBoxCustomers.FormattingEnabled = True
        Me.listBoxCustomers.Location = New System.Drawing.Point(4, 64)
        Me.listBoxCustomers.Name = "listBoxCustomers"
        Me.listBoxCustomers.Size = New System.Drawing.Size(203, 277)
        Me.listBoxCustomers.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(1, 39)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(188, 13)
        Me.label2.TabIndex = 7
        Me.label2.Text = "Double-click a customer to edit orders:"
        '
        'comboBoxCity
        '
        Me.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCity.FormattingEnabled = True
        Me.comboBoxCity.Location = New System.Drawing.Point(32, 5)
        Me.comboBoxCity.Name = "comboBoxCity"
        Me.comboBoxCity.Size = New System.Drawing.Size(175, 21)
        Me.comboBoxCity.TabIndex = 6
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(1, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(27, 13)
        Me.label1.TabIndex = 5
        Me.label1.Text = "City:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 344)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.listBoxCustomers)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.comboBoxCity)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MainForm"
        Me.Text = "Client-side transactions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents listBoxCustomers As System.Windows.Forms.ListBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents comboBoxCity As System.Windows.Forms.ComboBox
    Private WithEvents label1 As System.Windows.Forms.Label

End Class
