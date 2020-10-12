<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseGaugePage
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.gaugePanel = New System.Windows.Forms.Panel
        Me.objectLabel = New System.Windows.Forms.Label
        Me.captionLabel = New System.Windows.Forms.Label
        Me.splitter1 = New System.Windows.Forms.Splitter
        Me.timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gridPanel = New System.Windows.Forms.Panel
        Me.gaugeGrid = New System.Windows.Forms.PropertyGrid
        Me.gridPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.BackColor = System.Drawing.SystemColors.Window
        Me.gaugePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gaugePanel.Location = New System.Drawing.Point(0, 25)
        Me.gaugePanel.Name = "gaugePanel"
        Me.gaugePanel.Size = New System.Drawing.Size(391, 436)
        Me.gaugePanel.TabIndex = 6
        '
        'objectLabel
        '
        Me.objectLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.objectLabel.Location = New System.Drawing.Point(2, 2)
        Me.objectLabel.Name = "objectLabel"
        Me.objectLabel.Size = New System.Drawing.Size(216, 16)
        Me.objectLabel.TabIndex = 0
        Me.objectLabel.Text = "object properties:"
        '
        'captionLabel
        '
        Me.captionLabel.BackColor = System.Drawing.Color.SteelBlue
        Me.captionLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.captionLabel.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.captionLabel.ForeColor = System.Drawing.Color.White
        Me.captionLabel.Location = New System.Drawing.Point(0, 0)
        Me.captionLabel.Name = "captionLabel"
        Me.captionLabel.Size = New System.Drawing.Size(391, 25)
        Me.captionLabel.TabIndex = 4
        Me.captionLabel.Text = "Caption"
        Me.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'splitter1
        '
        Me.splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.splitter1.Location = New System.Drawing.Point(391, 0)
        Me.splitter1.Name = "splitter1"
        Me.splitter1.Size = New System.Drawing.Size(4, 461)
        Me.splitter1.TabIndex = 5
        Me.splitter1.TabStop = False
        '
        'timer1
        '
        Me.timer1.Interval = 500
        '
        'gridPanel
        '
        Me.gridPanel.BackColor = System.Drawing.SystemColors.Control
        Me.gridPanel.Controls.Add(Me.gaugeGrid)
        Me.gridPanel.Controls.Add(Me.objectLabel)
        Me.gridPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.gridPanel.Location = New System.Drawing.Point(395, 0)
        Me.gridPanel.Name = "gridPanel"
        Me.gridPanel.Padding = New System.Windows.Forms.Padding(2)
        Me.gridPanel.Size = New System.Drawing.Size(220, 461)
        Me.gridPanel.TabIndex = 7
        '
        'gaugeGrid
        '
        Me.gaugeGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gaugeGrid.Location = New System.Drawing.Point(2, 18)
        Me.gaugeGrid.Name = "gaugeGrid"
        Me.gaugeGrid.Size = New System.Drawing.Size(216, 441)
        Me.gaugeGrid.TabIndex = 0
        Me.gaugeGrid.ToolbarVisible = False
        '
        'BaseGaugePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.gaugePanel)
        Me.Controls.Add(Me.captionLabel)
        Me.Controls.Add(Me.splitter1)
        Me.Controls.Add(Me.gridPanel)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Name = "BaseGaugePage"
        Me.Size = New System.Drawing.Size(615, 461)
        Me.gridPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents gaugePanel As System.Windows.Forms.Panel
    Private WithEvents objectLabel As System.Windows.Forms.Label
    Public WithEvents captionLabel As System.Windows.Forms.Label
    Public WithEvents splitter1 As System.Windows.Forms.Splitter
    Public WithEvents timer1 As System.Windows.Forms.Timer
    Public WithEvents gridPanel As System.Windows.Forms.Panel
    Public WithEvents gaugeGrid As System.Windows.Forms.PropertyGrid

End Class
