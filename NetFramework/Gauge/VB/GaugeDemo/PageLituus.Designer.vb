<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageLituus
    Inherits BaseGaugePage

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
        Dim C1GaugeSingleLabel2 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeRectangle2 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.Gauge.C1LinearGauge
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.trackBar1)
        Me.gaugePanel.Controls.Add(Me.c1Gauge1)
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.c1LinearGauge1
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.Location = New System.Drawing.Point(15, 384)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(360, 45)
        Me.trackBar1.TabIndex = 3
        Me.trackBar1.Value = 67
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1LinearGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(3, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(387, 385)
        Me.c1Gauge1.TabIndex = 2
        Me.c1Gauge1.ViewTag = CType(639096176253039103, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.BaseFactor = 0.9
        Me.c1LinearGauge1.BaseOrigin = 0.05
        C1GaugeSingleLabel2.Color = System.Drawing.Color.Silver
        C1GaugeSingleLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel2.FontSize = 8
        C1GaugeSingleLabel2.Format = "p1"
        C1GaugeSingleLabel2.Location = 17
        C1GaugeSingleLabel2.PointerIndex = 100
        C1GaugeSingleLabel2.Position = 0.8
        C1GaugeSingleLabel2.ViewTag = CType(646977542129652696, Long)
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeSingleLabel2})
        C1GaugeRectangle2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRectangle2.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.c1LinearGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeRectangle2})
        Me.c1LinearGauge1.Maximum = 1
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Pointer.Value = 0.67
        Me.c1LinearGauge1.Pointer.Visible = False
        Me.c1LinearGauge1.Viewport.AspectRatio = 1.5
        Me.c1LinearGauge1.ViewTag = CType(639377651282252762, Long)
        '
        'PageCase11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase11"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.Gauge.C1LinearGauge

End Class
