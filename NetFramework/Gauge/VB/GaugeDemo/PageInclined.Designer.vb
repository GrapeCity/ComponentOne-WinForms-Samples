<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageInclined
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
        Dim C1GaugeRange5 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeRange6 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeMarks7 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeLabels5 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeMarks8 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks9 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeLabels6 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.Gauge.C1LinearGauge
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
        Me.gaugeGrid.SelectedObject = Me.c1LinearGauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1LinearGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(12, 17)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(368, 404)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(640217874461468003, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisLength = 0.93
        C1GaugeRange5.AdjustAngle = True
        C1GaugeRange5.AntiAliasing = C1.Win.Gauge.C1GaugeRangeAntiAliasing.HighQuality
        C1GaugeRange5.Border.Color = System.Drawing.Color.Purple
        C1GaugeRange5.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRange5.Location = 50
        C1GaugeRange5.Location2 = 65
        C1GaugeRange5.ScaleFrom = 0
        C1GaugeRange5.ScaleTo = 100
        C1GaugeRange5.ToPointerIndex = 100
        C1GaugeRange5.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Blue, 1, CType(636558699764029463, Long)), New C1.Win.Gauge.C1GaugeValueColor(25, -1, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), 1, CType(636840174740750120, Long)), New C1.Win.Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer)), 1, CType(637121649717460776, Long)), New C1.Win.Gauge.C1GaugeValueColor(75, -1, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), 1, CType(637403124694171432, Long)), New C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Red, 1, CType(637684599670882088, Long))})
        C1GaugeRange5.ViewTag = CType(636277224787288805, Long)
        C1GaugeRange6.AdjustAngle = True
        C1GaugeRange6.Border.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeRange6.Border.Thickness = 1
        C1GaugeRange6.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        C1GaugeRange6.Location = 50
        C1GaugeRange6.Location2 = 65
        C1GaugeRange6.ViewTag = CType(637966074647592744, Long)
        C1GaugeMarks7.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks7.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeMarks7.Interval = 5
        C1GaugeMarks7.Location = 35
        C1GaugeMarks7.Location2 = 15
        C1GaugeMarks7.OrthogonalOffset = 2
        C1GaugeMarks7.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks7.ShapeAngle = -10
        C1GaugeMarks7.ViewTag = CType(638247549624303400, Long)
        C1GaugeLabels5.Color = System.Drawing.Color.White
        C1GaugeLabels5.FontSize = 4
        C1GaugeLabels5.Format = "n1"
        C1GaugeLabels5.Interval = 5
        C1GaugeLabels5.Location = 35
        C1GaugeLabels5.Location2 = 15
        C1GaugeLabels5.OrthogonalOffset = 2
        C1GaugeLabels5.TextAngle = -10
        C1GaugeLabels5.ViewTag = CType(638529024601034057, Long)
        C1GaugeMarks8.IntervalWidth = 5
        C1GaugeMarks8.Length = 10
        C1GaugeMarks8.Location = 65
        C1GaugeMarks8.Location2 = 85
        C1GaugeMarks8.OrthogonalOffset = 4
        C1GaugeMarks8.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks8.ToPointerIndex = 100
        C1GaugeMarks8.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.White, 1, CType(639091974554465369, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 100, System.Drawing.Color.Purple, 1, CType(639373449531306033, Long))})
        C1GaugeMarks8.ViewTag = CType(638810499577754713, Long)
        C1GaugeMarks8.Width = 10
        C1GaugeMarks9.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks9.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        C1GaugeMarks9.Interval = 10
        C1GaugeMarks9.Length = 10
        C1GaugeMarks9.Location = 95
        C1GaugeMarks9.SequenceNo = 1
        C1GaugeMarks9.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks9.ViewTag = CType(639654924508026690, Long)
        C1GaugeMarks9.Width = 0.5
        C1GaugeLabels6.FontSize = 4
        C1GaugeLabels6.Interval = 10
        C1GaugeLabels6.Location = 95
        C1GaugeLabels6.OrthogonalOffset = 3
        C1GaugeLabels6.SequenceNo = 1
        C1GaugeLabels6.ViewTag = CType(639936399484737346, Long)
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeRange5, C1GaugeRange6, C1GaugeMarks7, C1GaugeLabels5, C1GaugeMarks8, C1GaugeMarks9, C1GaugeLabels6})
        Me.c1LinearGauge1.IsReversed = True
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Orientation = C1.Win.Gauge.C1GaugeOrientation.Vertical
        Me.c1LinearGauge1.Pointer.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        Me.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.MediumOrchid
        Me.c1LinearGauge1.Pointer.CustomShape.EndAngle = 68
        Me.c1LinearGauge1.Pointer.CustomShape.EndWidth = 4
        Me.c1LinearGauge1.Pointer.CustomShape.StartAngle = 68
        Me.c1LinearGauge1.Pointer.CustomShape.StartWidth = 4
        Me.c1LinearGauge1.Pointer.Filling.Color = System.Drawing.Color.MediumSeaGreen
        Me.c1LinearGauge1.Pointer.Length = 10
        Me.c1LinearGauge1.Pointer.Offset = 25
        Me.c1LinearGauge1.Pointer.Offset2 = 5
        Me.c1LinearGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        Me.c1LinearGauge1.Pointer.ShapeAngle = -10
        Me.c1LinearGauge1.Pointer.SweepTime = 5
        Me.c1LinearGauge1.Pointer.Value = 50
        Me.c1LinearGauge1.Viewport.AspectRatio = 0.9
        Me.c1LinearGauge1.ViewTag = CType(640499349438208660, Long)
        '
        'PageCase4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase4"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.Gauge.C1LinearGauge

End Class
