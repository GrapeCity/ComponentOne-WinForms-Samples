<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageYandexGauge
    Inherits GaugeDemo.BaseGaugePage

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim C1GaugeRange1 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeSingleLabel1 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel2 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel3 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSegment1 As C1.Win.C1Gauge.C1GaugeSegment = New C1.Win.C1Gauge.C1GaugeSegment
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
        Me.c1Gauge1.Location = New System.Drawing.Point(12, 12)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(367, 412)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(637779738145036078, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.BehindPointers = True
        Me.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.Black
        Me.c1RadialGauge1.Cap.HitTestable = False
        Me.c1RadialGauge1.Cap.Radius = 15
        C1GaugeRange1.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeRange1.AntiAliasing = C1.Win.C1Gauge.C1GaugeRangeAntiAliasing.HighQuality
        C1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.Location = 85
        C1GaugeRange1.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Gold, 1, CType(636371842368652348, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Red, 1, CType(636653317568599396, Long))})
        C1GaugeRange1.ViewTag = CType(636090364653824882, Long)
        C1GaugeRange1.Width = 0
        C1GaugeRange1.Width2 = 21
        C1GaugeSingleLabel1.Angle = -72
        C1GaugeSingleLabel1.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!)
        C1GaugeSingleLabel1.FontSize = 14
        C1GaugeSingleLabel1.Location = 80
        C1GaugeSingleLabel1.Text = "0"
        C1GaugeSingleLabel1.ViewTag = CType(637216281821005865, Long)
        C1GaugeSingleLabel2.Angle = 88
        C1GaugeSingleLabel2.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!)
        C1GaugeSingleLabel2.FontSize = 20
        C1GaugeSingleLabel2.Location = 76
        C1GaugeSingleLabel2.Text = "∞"
        C1GaugeSingleLabel2.ViewTag = CType(637497758063980745, Long)
        C1GaugeSingleLabel3.Angle = 0
        C1GaugeSingleLabel3.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!)
        C1GaugeSingleLabel3.FontSize = 14
        C1GaugeSingleLabel3.Location = 26
        C1GaugeSingleLabel3.Text = "Mb/s"
        C1GaugeSingleLabel3.ViewTag = CType(637779236517313508, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeRange1, C1GaugeSingleLabel1, C1GaugeSingleLabel2, C1GaugeSingleLabel3})
        C1GaugeSegment1.Border.Thickness = 1.5
        C1GaugeSegment1.CornerRadius = 3
        C1GaugeSegment1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Hatch
        C1GaugeSegment1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeSegment1.Filling.HatchStyle = C1.Win.C1Gauge.C1GaugeHatchStyle.SmallGrid
        C1GaugeSegment1.InnerRadius = 800
        C1GaugeSegment1.StartAngle = -105
        C1GaugeSegment1.SweepAngle = 210
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeSegment1})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.DarkRed
        Me.c1RadialGauge1.Pointer.Border.Thickness = 0.5
        Me.c1RadialGauge1.Pointer.CustomShape.EndRadius = 0.5
        Me.c1RadialGauge1.Pointer.CustomShape.EndWidth = 1
        Me.c1RadialGauge1.Pointer.CustomShape.StartAngle = 50
        Me.c1RadialGauge1.Pointer.CustomShape.StartWidth = 10
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Pink
        Me.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.Red
        Me.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Horizontal
        Me.c1RadialGauge1.Pointer.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.SigmaBell
        Me.c1RadialGauge1.Pointer.Gradient.ScaleX = 2
        Me.c1RadialGauge1.Pointer.HitTestable = False
        Me.c1RadialGauge1.Pointer.Length = 85
        Me.c1RadialGauge1.Pointer.Offset = -2
        Me.c1RadialGauge1.Pointer.Shadow.Visible = True
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        Me.c1RadialGauge1.Pointer.Value = 70
        Me.c1RadialGauge1.PointerOriginY = 0.786
        Me.c1RadialGauge1.Radius = 0.77
        Me.c1RadialGauge1.StartAngle = -60
        Me.c1RadialGauge1.SweepAngle = 140
        Me.c1RadialGauge1.Viewport.AspectPinX = 0.5
        Me.c1RadialGauge1.Viewport.AspectPinY = 0.5
        Me.c1RadialGauge1.Viewport.AspectRatio = 1.58
        Me.c1RadialGauge1.ViewTag = CType(637777636476463374, Long)
        '
        'PageYandexGauge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.Name = "PageYandexGauge"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.C1Gauge.C1RadialGauge

End Class
