<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageIntervalWidth
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
        Dim C1GaugeCaption2 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption
        Dim C1GaugeMarks4 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeMarks5 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeMarks6 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1RadialGauge1 = New C1.Win.C1Gauge.C1RadialGauge
        Me.c1LinearGauge1 = New C1.Win.C1Gauge.C1LinearGauge
        Me.c1LinearGauge2 = New C1.Win.C1Gauge.C1LinearGauge
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
        Me.timer1.Interval = 200
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.c1Gauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.BackColor = System.Drawing.Color.LightSalmon
        C1GaugeCaption2.Alignment = System.Drawing.StringAlignment.Near
        C1GaugeCaption2.Height = -1
        C1GaugeCaption2.LineAlignment = System.Drawing.StringAlignment.Near
        C1GaugeCaption2.Text = "Space between tick marks remains unchanged when resizing the container control"
        C1GaugeCaption2.Viewport.MarginX = 35
        C1GaugeCaption2.Viewport.TranslateY = 0.05
        C1GaugeCaption2.Viewport.Y = 36
        C1GaugeCaption2.Width = -1
        Me.c1Gauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeCaption2})
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1RadialGauge1, Me.c1LinearGauge1, Me.c1LinearGauge2})
        Me.c1Gauge1.Location = New System.Drawing.Point(3, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(385, 430)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(643314165155657364, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        Me.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.DarkSlateBlue
        Me.c1RadialGauge1.Cap.Radius = 8
        C1GaugeMarks4.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks4.Filling.Color = System.Drawing.Color.Gray
        C1GaugeMarks4.IntervalWidth = 10
        C1GaugeMarks4.Length = 10
        C1GaugeMarks4.Location = 90
        C1GaugeMarks4.SequenceNo = -1
        C1GaugeMarks4.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks4.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks4.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Red, 1, CType(641062365341942114, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 100, System.Drawing.Color.Gray, 1, CType(641343840318652770, Long))})
        C1GaugeMarks4.ViewTag = CType(640780890365211457, Long)
        C1GaugeMarks4.Width = 10
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeMarks4})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        Me.c1RadialGauge1.Pointer.CustomShape.EndRadius = 1
        Me.c1RadialGauge1.Pointer.CustomShape.EndWidth = 2
        Me.c1RadialGauge1.Pointer.CustomShape.StartWidth = 6
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White
        Me.c1RadialGauge1.Pointer.Length = 80
        Me.c1RadialGauge1.Pointer.Offset = 0
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        Me.c1RadialGauge1.Pointer.SweepTime = 4
        Me.c1RadialGauge1.Pointer.Value = 70
        Me.c1RadialGauge1.PointerOriginY = 0.53
        Me.c1RadialGauge1.Radius = 0.5
        Me.c1RadialGauge1.StartAngle = -170
        Me.c1RadialGauge1.SweepAngle = 340
        Me.c1RadialGauge1.Viewport.ScaleX = 0.6
        Me.c1RadialGauge1.Viewport.ScaleY = 0.6
        Me.c1RadialGauge1.Viewport.TranslateX = 0.2
        Me.c1RadialGauge1.Viewport.TranslateY = 0.2
        Me.c1RadialGauge1.ViewTag = CType(643595640132398022, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisLength = 1
        Me.c1LinearGauge1.AxisStart = 0
        Me.c1LinearGauge1.BaseFactor = 1
        Me.c1LinearGauge1.BaseOrigin = 0
        C1GaugeMarks5.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks5.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks5.Filling.Color = System.Drawing.Color.Gray
        C1GaugeMarks5.IntervalWidth = 30
        C1GaugeMarks5.Length = 100
        C1GaugeMarks5.Location = 0
        C1GaugeMarks5.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks5.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks5.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Green, 1, CType(641906790272084083, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 100, System.Drawing.Color.Gray, 1, CType(642188265248794739, Long))})
        C1GaugeMarks5.ViewTag = CType(641625315295363426, Long)
        C1GaugeMarks5.Width = 20
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeMarks5})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Pointer.SweepTime = 5
        Me.c1LinearGauge1.Pointer.Value = 30
        Me.c1LinearGauge1.Pointer.Visible = False
        Me.c1LinearGauge1.Viewport.Height = 30
        Me.c1LinearGauge1.Viewport.MarginX = 39
        Me.c1LinearGauge1.Viewport.TranslateY = 0.05
        Me.c1LinearGauge1.ViewTag = CType(644158590085879337, Long)
        '
        'c1LinearGauge2
        '
        Me.c1LinearGauge2.AxisLength = 1
        Me.c1LinearGauge2.AxisStart = 0
        Me.c1LinearGauge2.BaseFactor = 1
        Me.c1LinearGauge2.BaseOrigin = 0
        C1GaugeMarks6.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks6.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks6.Filling.Color = System.Drawing.Color.Gray
        C1GaugeMarks6.IntervalWidth = 30
        C1GaugeMarks6.Length = 100
        C1GaugeMarks6.Location = 0
        C1GaugeMarks6.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks6.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks6.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.MidnightBlue, 1, CType(642751215202216051, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 100, System.Drawing.Color.Gray, 1, CType(643032690178926707, Long))})
        C1GaugeMarks6.ViewTag = CType(642469740225505395, Long)
        C1GaugeMarks6.Width = 20
        Me.c1LinearGauge2.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeMarks6})
        Me.c1LinearGauge2.IsReversed = True
        Me.c1LinearGauge2.Name = "c1LinearGauge2"
        Me.c1LinearGauge2.Pointer.SweepTime = 5
        Me.c1LinearGauge2.Pointer.Value = 30
        Me.c1LinearGauge2.Pointer.Visible = False
        Me.c1LinearGauge2.Viewport.Height = -30
        Me.c1LinearGauge2.Viewport.MarginX = 39
        Me.c1LinearGauge2.Viewport.ScaleY = 0.95
        Me.c1LinearGauge2.Viewport.Y = -30
        Me.c1LinearGauge2.ViewTag = CType(644721540039330651, Long)
        '
        'PageCase6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase6"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.C1Gauge.C1RadialGauge
    Private WithEvents c1LinearGauge1 As C1.Win.C1Gauge.C1LinearGauge
    Private WithEvents c1LinearGauge2 As C1.Win.C1Gauge.C1LinearGauge

End Class
