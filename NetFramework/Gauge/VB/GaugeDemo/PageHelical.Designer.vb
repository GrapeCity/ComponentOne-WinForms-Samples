<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageHelical
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
        Dim C1GaugeMarks3 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeLabels3 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeSingleMark3 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleLabel3 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge
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
        Me.timer1.Interval = 1000
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
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(7, 15)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(378, 399)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(648099090741175142, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeMarks3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.IntervalWidth = 15
        C1GaugeMarks3.Length = 22
        C1GaugeMarks3.Location = 20
        C1GaugeMarks3.Location2 = 90
        C1GaugeMarks3.Shadow.OffsetX = 0.5
        C1GaugeMarks3.Shadow.OffsetY = 0.5
        C1GaugeMarks3.Shadow.Visible = True
        C1GaugeMarks3.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks3.ShowIrregularTo = True
        C1GaugeMarks3.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Crimson, 1, CType(646691715857581860, Long)), New C1.Win.Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.Chocolate, 1, CType(646973190834302516, Long)), New C1.Win.Gauge.C1GaugeValueColor(80, -1, System.Drawing.Color.Teal, 1, CType(647254665811013172, Long)), New C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Olive, 1, CType(647536140787723828, Long))})
        C1GaugeMarks3.ViewTag = CType(646410240880851202, Long)
        C1GaugeMarks3.Width = 12
        C1GaugeLabels3.AllowFlip = True
        C1GaugeLabels3.Color = System.Drawing.Color.White
        C1GaugeLabels3.FontSize = 6.5
        C1GaugeLabels3.Format = "n1"
        C1GaugeLabels3.IntervalWidth = 15
        C1GaugeLabels3.IsRotated = True
        C1GaugeLabels3.Location = 20
        C1GaugeLabels3.Location2 = 90
        C1GaugeLabels3.ShowIrregularTo = True
        C1GaugeLabels3.TextAngle = 90
        C1GaugeLabels3.ViewTag = CType(647817615764444485, Long)
        C1GaugeSingleMark3.Angle = 0
        C1GaugeSingleMark3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark3.Filling.Color = System.Drawing.Color.CadetBlue
        C1GaugeSingleMark3.ImmediateUpdate = True
        C1GaugeSingleMark3.Length = 24
        C1GaugeSingleMark3.Location = 75
        C1GaugeSingleMark3.OrthogonalOffset = 75
        C1GaugeSingleMark3.PointerIndex = 100
        C1GaugeSingleMark3.Shadow.OffsetX = 0.5
        C1GaugeSingleMark3.Shadow.OffsetY = 0.5
        C1GaugeSingleMark3.Shadow.Visible = True
        C1GaugeSingleMark3.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeSingleMark3.ShapeAngle = 90
        C1GaugeSingleMark3.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Crimson, 1, CType(661328481413244809, Long)), New C1.Win.Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.Chocolate, 1, CType(661609956394915749, Long)), New C1.Win.Gauge.C1GaugeValueColor(80, -1, System.Drawing.Color.Teal, 1, CType(661891431375216610, Long)), New C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Olive, 1, CType(662172906356387521, Long))})
        C1GaugeSingleMark3.ViewTag = CType(658795202539365343, Long)
        C1GaugeSingleMark3.Width = 12
        C1GaugeSingleLabel3.Angle = 0
        C1GaugeSingleLabel3.Color = System.Drawing.Color.White
        C1GaugeSingleLabel3.FontSize = 6.5
        C1GaugeSingleLabel3.Format = "n1"
        C1GaugeSingleLabel3.ImmediateUpdate = True
        C1GaugeSingleLabel3.Location = 75
        C1GaugeSingleLabel3.OrthogonalOffset = 75
        C1GaugeSingleLabel3.PointerIndex = 100
        C1GaugeSingleLabel3.ViewTag = CType(659076679335980092, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks3, C1GaugeLabels3, C1GaugeSingleMark3, C1GaugeSingleLabel3})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Alignment = C1.Win.Gauge.C1GaugeAlignment.Center
        Me.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Black
        Me.c1RadialGauge1.Pointer.Border.Thickness = 2
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White
        Me.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.White
        Me.c1RadialGauge1.Pointer.Filling.Opacity = 0.7
        Me.c1RadialGauge1.Pointer.Filling.Opacity2 = 0.1
        Me.c1RadialGauge1.Pointer.Filling.SwapColors = True
        Me.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.CornerRay
        Me.c1RadialGauge1.Pointer.Length = 26
        Me.c1RadialGauge1.Pointer.Offset = 20
        Me.c1RadialGauge1.Pointer.Offset2 = 90
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round
        Me.c1RadialGauge1.Pointer.SweepTime = 20
        Me.c1RadialGauge1.Pointer.Value = 100
        Me.c1RadialGauge1.Pointer.Width = 16
        Me.c1RadialGauge1.PointerOriginX = 0.48
        Me.c1RadialGauge1.PointerOriginY = 0.47
        Me.c1RadialGauge1.Radius = 0.55
        Me.c1RadialGauge1.StartAngle = -90
        Me.c1RadialGauge1.SweepAngle = 1046
        Me.c1RadialGauge1.Viewport.AspectRatio = 0.95
        Me.c1RadialGauge1.ViewTag = CType(648380565717915800, Long)
        '
        'PageCase3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase3"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
