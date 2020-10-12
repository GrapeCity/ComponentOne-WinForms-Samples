<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageGageDial
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
        Dim C1GaugeMarks1 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeMarks2 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeMarks3 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeLabels1 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels
        Dim C1GaugeSector1 As C1.Win.C1Gauge.C1GaugeSector = New C1.Win.C1Gauge.C1GaugeSector
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1RadialGauge1 = New C1.Win.C1Gauge.C1RadialGauge
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.c1Gauge1)
        '
        'timer1
        '
        Me.timer1.Enabled = True
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.c1RadialGauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(16, 16)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(360, 405)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(640216300207618618, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeMarks1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.Green
        C1GaugeMarks1.Interval = 10
        C1GaugeMarks1.Length = 4
        C1GaugeMarks1.Location = 83
        C1GaugeMarks1.ViewTag = CType(639371875277416646, Long)
        C1GaugeMarks1.Width = 0.15
        C1GaugeMarks2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.Green
        C1GaugeMarks2.Interval = 5
        C1GaugeMarks2.Length = 3
        C1GaugeMarks2.Location = 83
        C1GaugeMarks2.ViewTag = CType(641060729845969881, Long)
        C1GaugeMarks2.Width = 0.15
        C1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.Filling.Color = System.Drawing.Color.Green
        C1GaugeMarks3.Interval = 1
        C1GaugeMarks3.Length = 2
        C1GaugeMarks3.Location = 83
        C1GaugeMarks3.ViewTag = CType(639653350254137302, Long)
        C1GaugeMarks3.Width = 0.15
        C1GaugeLabels1.Color = System.Drawing.Color.DarkSlateGray
        C1GaugeLabels1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeLabels1.FontSize = 2.1
        C1GaugeLabels1.Interval = 10
        C1GaugeLabels1.IsRotated = True
        C1GaugeLabels1.Location = 89
        C1GaugeLabels1.ViewTag = CType(639934825230857959, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeMarks1, C1GaugeMarks2, C1GaugeMarks3, C1GaugeLabels1})
        C1GaugeSector1.Border.Color = System.Drawing.Color.DarkSeaGreen
        C1GaugeSector1.Border.Thickness = 0.5
        C1GaugeSector1.CenterRadius = 3
        C1GaugeSector1.CornerRadius = 2
        C1GaugeSector1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeSector1.Filling.Color = System.Drawing.Color.Lavender
        C1GaugeSector1.Filling.Color2 = System.Drawing.Color.LightSlateGray
        C1GaugeSector1.Filling.SwapColors = True
        C1GaugeSector1.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeSector1.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.Triangular
        C1GaugeSector1.Gradient.ScaleY = 0.5
        C1GaugeSector1.InnerOffset = -150
        C1GaugeSector1.InnerRadius = 220
        C1GaugeSector1.Name = "sc"
        C1GaugeSector1.OuterRadius = 93
        C1GaugeSector1.StartAngle = -15
        C1GaugeSector1.SweepAngle = 30
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeSector1})
        Me.c1RadialGauge1.Maximum = 30
        Me.c1RadialGauge1.Minimum = -30
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        Me.c1RadialGauge1.Pointer.Clippings.AddRange(New C1.Win.C1Gauge.C1GaugeClipping() {New C1.Win.C1Gauge.C1GaugeClipping("sc", C1.Win.C1Gauge.C1GaugeClipOperation.Intersect, 1.01)})
        Me.c1RadialGauge1.Pointer.CustomShape.EndAngle = 75
        Me.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.1
        Me.c1RadialGauge1.Pointer.CustomShape.EndSwellAngle = 45
        Me.c1RadialGauge1.Pointer.CustomShape.EndSwellWidth = 0.7
        Me.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.6
        Me.c1RadialGauge1.Pointer.CustomShape.StartWidth = 0.6
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.DarkSlateGray
        Me.c1RadialGauge1.Pointer.Length = 23
        Me.c1RadialGauge1.Pointer.Offset = 60
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        Me.c1RadialGauge1.Pointer.SweepTime = 5
        Me.c1RadialGauge1.Pointer.Value = 7
        Me.c1RadialGauge1.PointerOriginY = 3.5
        Me.c1RadialGauge1.Radius = 3.7
        Me.c1RadialGauge1.StartAngle = -15
        Me.c1RadialGauge1.SweepAngle = 30
        Me.c1RadialGauge1.Viewport.AspectPinY = 0.3
        Me.c1RadialGauge1.Viewport.AspectRatio = 2.1
        Me.c1RadialGauge1.ViewTag = CType(640497775184369276, Long)
        '
        'PageGageDial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageGageDial"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.C1Gauge.C1RadialGauge

End Class
