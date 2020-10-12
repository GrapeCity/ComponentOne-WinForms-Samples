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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.hostPanel = New System.Windows.Forms.Panel
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.label2 = New System.Windows.Forms.Label
        Me.panel1 = New System.Windows.Forms.Panel
        Me.label1 = New System.Windows.Forms.Label
        Me.samplesTree = New System.Windows.Forms.TreeView
        Me.hsButton = New System.Windows.Forms.Button
        Me.panel2 = New System.Windows.Forms.Panel
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'hostPanel
        '
        Me.hostPanel.BackColor = System.Drawing.Color.LightSteelBlue
        Me.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.hostPanel.Location = New System.Drawing.Point(164, 42)
        Me.hostPanel.Name = "hostPanel"
        Me.hostPanel.Padding = New System.Windows.Forms.Padding(4)
        Me.hostPanel.Size = New System.Drawing.Size(620, 468)
        Me.hostPanel.TabIndex = 9
        '
        'splitter1
        '
        Me.splitter1.BackColor = System.Drawing.Color.SteelBlue
        Me.splitter1.Location = New System.Drawing.Point(160, 42)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(4, 468)
        Me.splitter1.TabIndex = 8
        Me.splitter1.TabStop = False
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.SteelBlue
        Me.label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.label2.Location = New System.Drawing.Point(0, 38)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(784, 4)
        Me.label2.TabIndex = 10
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panel1.Controls.Add(Me.label1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(784, 38)
        Me.panel1.TabIndex = 6
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(590, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(185, 23)
        Me.label1.TabIndex = 0
        Me.label1.Text = "C1Gauge Capabilities"
        '
        'samplesTree
        '
        Me.samplesTree.BackColor = System.Drawing.SystemColors.Window
        Me.samplesTree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.samplesTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.samplesTree.HideSelection = False
        Me.samplesTree.Location = New System.Drawing.Point(4, 4)
        Me.samplesTree.Name = "samplesTree"
        Me.samplesTree.Size = New System.Drawing.Size(152, 460)
        Me.samplesTree.TabIndex = 0
        '
        'hsButton
        '
        Me.hsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hsButton.BackColor = System.Drawing.SystemColors.Control
        Me.hsButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hsButton.Location = New System.Drawing.Point(736, 45)
        Me.hsButton.Name = "hsButton"
        Me.hsButton.Size = New System.Drawing.Size(45, 20)
        Me.hsButton.TabIndex = 5
        Me.hsButton.TabStop = False
        Me.hsButton.Text = "hide"
        Me.hsButton.UseVisualStyleBackColor = False
        Me.hsButton.Visible = False
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.panel2.Controls.Add(Me.samplesTree)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.panel2.Location = New System.Drawing.Point(0, 42)
        Me.panel2.Name = "panel2"
        Me.panel2.Padding = New System.Windows.Forms.Padding(4)
        Me.panel2.Size = New System.Drawing.Size(160, 468)
        Me.panel2.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(784, 510)
        Me.Controls.Add(Me.hsButton)
        Me.Controls.Add(Me.hostPanel)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.panel1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(535, 370)
        Me.Name = "Form1"
        Me.Text = "C1Gauge Demo"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents hostPanel As System.Windows.Forms.Panel
    Private WithEvents splitter1 As System.Windows.Forms.Splitter
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents samplesTree As System.Windows.Forms.TreeView
    Private WithEvents hsButton As System.Windows.Forms.Button
    Private WithEvents panel2 As System.Windows.Forms.Panel

End Class
