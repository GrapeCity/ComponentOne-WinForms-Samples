<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageSlidingScale
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
        Dim C1GaugeMarks1 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks2 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeLabels1 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeSegment1 As C1.Win.Gauge.C1GaugeSegment = New C1.Win.Gauge.C1GaugeSegment
        Me.trackBar1 = New System.Windows.Forms.TrackBar
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge
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
        Me.gaugeGrid.SelectedObject = Me.c1RadialGauge1
        '
        'trackBar1
        '
        Me.trackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackBar1.Location = New System.Drawing.Point(340, 29)
        Me.trackBar1.Maximum = 120
        Me.trackBar1.Minimum = -120
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.trackBar1.Size = New System.Drawing.Size(45, 373)
        Me.trackBar1.TabIndex = 3
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(20, 29)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(314, 373)
        Me.c1Gauge1.TabIndex = 2
        Me.c1Gauge1.ViewTag = CType(649504984882777612, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks1.Border.Color = System.Drawing.Color.Blue
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.RoyalBlue
        C1GaugeMarks1.Interval = 5
        C1GaugeMarks1.Length = 6.5
        C1GaugeMarks1.Location = 75
        C1GaugeMarks1.ScaleFrom = -30
        C1GaugeMarks1.ScaleTo = 30
        C1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks1.ViewTag = CType(648660559952575640, Long)
        C1GaugeMarks1.Width = 0.6
        C1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.IndianRed
        C1GaugeMarks2.Interval = 1
        C1GaugeMarks2.Length = 4
        C1GaugeMarks2.Location = 75
        C1GaugeMarks2.ScaleFrom = -30
        C1GaugeMarks2.ScaleTo = 30
        C1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks2.ViewTag = CType(648942034929296296, Long)
        C1GaugeMarks2.Width = 0.6
        C1GaugeLabels1.Color = System.Drawing.Color.MidnightBlue
        C1GaugeLabels1.FontSize = 4
        C1GaugeLabels1.Interval = 5
        C1GaugeLabels1.IsRotated = True
        C1GaugeLabels1.Location = 63
        C1GaugeLabels1.ScaleFrom = -30
        C1GaugeLabels1.ScaleTo = 30
        C1GaugeLabels1.TextAngle = 90
        C1GaugeLabels1.ViewTag = CType(649223509906016953, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks1, C1GaugeMarks2, C1GaugeLabels1})
        C1GaugeSegment1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeSegment1.CenterPointX = 0.305
        C1GaugeSegment1.CornerRadius = 12
        C1GaugeSegment1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSegment1.Filling.Color = System.Drawing.Color.SlateGray
        C1GaugeSegment1.Filling.Color2 = System.Drawing.Color.White
        C1GaugeSegment1.Filling.HatchStyle = C1.Win.Gauge.C1GaugeHatchStyle.Vertical
        C1GaugeSegment1.Filling.SwapColors = True
        C1GaugeSegment1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeSegment1.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.SigmaBell
        C1GaugeSegment1.InnerRadius = 100
        C1GaugeSegment1.OuterRadius = 50
        C1GaugeSegment1.StartAngle = -180
        C1GaugeSegment1.SweepAngle = 180
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeSegment1})
        Me.c1RadialGauge1.Maximum = 15
        Me.c1RadialGauge1.Minimum = -15
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Alignment = C1.Win.Gauge.C1GaugeAlignment.Center
        Me.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.IndianRed
        Me.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.333333333333
        Me.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.5
        Me.c1RadialGauge1.Pointer.CustomShape.StartRadius = 0.5
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.RosyBrown
        Me.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.c1RadialGauge1.Pointer.FlipShape = True
        Me.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.BackwardDiagonal
        Me.c1RadialGauge1.Pointer.Length = 4
        Me.c1RadialGauge1.Pointer.Offset = 80
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        Me.c1RadialGauge1.PointerOriginX = 2
        Me.c1RadialGauge1.Radius = 2.2
        Me.c1RadialGauge1.SlidingScale = True
        Me.c1RadialGauge1.StartAngle = -120
        Me.c1RadialGauge1.SweepAngle = 60
        Me.c1RadialGauge1.Viewport.AspectPinX = 0.45
        Me.c1RadialGauge1.Viewport.AspectRatio = 0.5
        Me.c1RadialGauge1.ViewTag = CType(649786459859508269, Long)
        '
        'PageSlidingScale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageSlidingScale"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents trackBar1 As System.Windows.Forms.TrackBar
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
