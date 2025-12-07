<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageInteractive
    Inherits BaseGaugePage

    'Control overrides dispose to clean up the component list.
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

    'Required by the Control Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Component Designer
    ' It can be modified using the Component Designer.  Do not modify it
    ' using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CommonColorMap1 As C1.Win.Gauge.CommonColorMap = New C1.Win.Gauge.CommonColorMap
        Dim C1GaugeRange1 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeMarks1 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks2 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeLabels1 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeSingleMark1 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleLabel1 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeEllipse1 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugeEllipse2 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugeEllipse3 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugeRectangle1 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Me.C1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.C1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.C1Gauge1)
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.C1RadialGauge1
        '
        'C1Gauge1
        '
        Me.C1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.C1RadialGauge1})
        Me.C1Gauge1.Location = New System.Drawing.Point(15, 15)
        Me.C1Gauge1.Name = "C1Gauge1"
        Me.C1Gauge1.Size = New System.Drawing.Size(361, 406)
        Me.C1Gauge1.TabIndex = 0
        Me.C1Gauge1.ViewTag = CType(638369401555506787, Long)
        '
        'C1RadialGauge1
        '
        Me.C1RadialGauge1.Cap.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        Me.C1RadialGauge1.Cap.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.C1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.LightSkyBlue
        Me.C1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.Black
        Me.C1RadialGauge1.Cap.HitTestable = False
        Me.C1RadialGauge1.Cap.Radius = 30
        Me.C1RadialGauge1.Cap.Shadow.Visible = True
        CommonColorMap1.Name = "rangeColors"
        CommonColorMap1.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightSkyBlue, 1, CType(637241566911221021, Long)), New C1.Win.Gauge.C1GaugeValueColor(30, -1, System.Drawing.Color.LimeGreen, 1, CType(637523042084282907, Long)), New C1.Win.Gauge.C1GaugeValueColor(60, -1, System.Drawing.Color.Yellow, 1, CType(640057159105629385, Long)), New C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.OrangeRed, 1, CType(637804517159929222, Long))})
        CommonColorMap1.ViewTag = CType(636960091733788884, Long)
        Me.C1RadialGauge1.ColorMaps.AddRange(New C1.Win.Gauge.CommonColorMap() {CommonColorMap1})
        C1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeRange1.AntiAliasing = C1.Win.Gauge.C1GaugeRangeAntiAliasing.LowQuality
        C1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.ColorMapName = "rangeColors"
        C1GaugeRange1.HitTestable = False
        C1GaugeRange1.Location = 61
        C1GaugeRange1.ViewTag = CType(636678616231258153, Long)
        C1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeMarks1.HitTestable = False
        C1GaugeMarks1.Interval = 10
        C1GaugeMarks1.Length = 20
        C1GaugeMarks1.Location = 60
        C1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks1.ViewTag = CType(635271056971997689, Long)
        C1GaugeMarks1.Width = 3
        C1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.DimGray
        C1GaugeMarks2.HitTestable = False
        C1GaugeMarks2.Interval = 2.5
        C1GaugeMarks2.Location = 60
        C1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks2.ViewTag = CType(635552533455524530, Long)
        C1GaugeMarks2.Width = 3
        C1GaugeLabels1.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeLabels1.FontSize = 10
        C1GaugeLabels1.HitTestable = False
        C1GaugeLabels1.Interval = 10
        C1GaugeLabels1.IsRotated = True
        C1GaugeLabels1.Location = 89
        C1GaugeLabels1.ViewTag = CType(636115488361649120, Long)
        C1GaugeSingleMark1.Angle = 0
        C1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark1.Clippings.AddRange(New C1.Win.Gauge.C1GaugeClipping() {New C1.Win.Gauge.C1GaugeClipping("face", C1.Win.Gauge.C1GaugeClipOperation.Exclude, 1)})
        C1GaugeSingleMark1.ColorMapName = "rangeColors"
        C1GaugeSingleMark1.Filling.Color = System.Drawing.Color.DarkGray
        C1GaugeSingleMark1.HitTestable = False
        C1GaugeSingleMark1.Length = 212
        C1GaugeSingleMark1.Location = 0
        C1GaugeSingleMark1.PointerIndex = 100
        C1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeSingleMark1.ViewTag = CType(636396980395055364, Long)
        C1GaugeSingleMark1.Width = 212
        C1GaugeSingleLabel1.Angle = 180
        C1GaugeSingleLabel1.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeSingleLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        C1GaugeSingleLabel1.FontSize = 10
        C1GaugeSingleLabel1.Format = "0.0"
        C1GaugeSingleLabel1.HitTestable = False
        C1GaugeSingleLabel1.Location = 76
        C1GaugeSingleLabel1.PointerIndex = 100
        C1GaugeSingleLabel1.ViewTag = CType(639774705812283003, Long)
        Me.C1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeRange1, C1GaugeMarks1, C1GaugeMarks2, C1GaugeLabels1, C1GaugeSingleMark1, C1GaugeSingleLabel1})
        C1GaugeEllipse1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse1.Filling.Color = System.Drawing.Color.White
        C1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkSlateBlue
        C1GaugeEllipse1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.BackwardDiagonal
        C1GaugeEllipse1.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.Triangular
        C1GaugeEllipse1.Height = 224
        C1GaugeEllipse1.Name = "back"
        C1GaugeEllipse1.Width = 224
        C1GaugeEllipse2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse2.Filling.Color = System.Drawing.Color.RoyalBlue
        C1GaugeEllipse2.Filling.Color2 = System.Drawing.Color.White
        C1GaugeEllipse2.HitTestable = False
        C1GaugeEllipse2.Name = "face"
        C1GaugeEllipse3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse3.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse3.Filling.Color = System.Drawing.Color.DarkSlateBlue
        C1GaugeEllipse3.Filling.Color2 = System.Drawing.Color.WhiteSmoke
        C1GaugeEllipse3.Filling.SwapColors = True
        C1GaugeEllipse3.Height = 100
        C1GaugeEllipse3.HitTestable = False
        C1GaugeEllipse3.Width = 100
        C1GaugeRectangle1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeRectangle1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRectangle1.Border.Thickness = 0.5
        C1GaugeRectangle1.CenterPointY = 0.88
        C1GaugeRectangle1.CornerRadius = 5
        C1GaugeRectangle1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Hatch
        C1GaugeRectangle1.Filling.Color = System.Drawing.Color.Transparent
        C1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugeRectangle1.Filling.HatchStyle = C1.Win.Gauge.C1GaugeHatchStyle.NarrowHorizontal
        C1GaugeRectangle1.Height = 16
        C1GaugeRectangle1.HitTestable = False
        C1GaugeRectangle1.Width = 34
        Me.C1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse1, C1GaugeEllipse2, C1GaugeEllipse3, C1GaugeRectangle1})
        Me.C1RadialGauge1.Name = "C1RadialGauge1"
        Me.C1RadialGauge1.OffAngle = -180
        Me.C1RadialGauge1.Pointer.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        Me.C1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.C1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black
        Me.C1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.LightBlue
        Me.C1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Vertical
        Me.C1RadialGauge1.Pointer.HitTestable = False
        Me.C1RadialGauge1.Pointer.Length = 30
        Me.C1RadialGauge1.Pointer.Offset = 28
        Me.C1RadialGauge1.Pointer.Shadow.Visible = True
        Me.C1RadialGauge1.Pointer.Width = 12
        Me.C1RadialGauge1.Radius = 0.44
        Me.C1RadialGauge1.StartAngle = -150
        Me.C1RadialGauge1.SweepAngle = 300
        Me.C1RadialGauge1.ViewTag = CType(636959884989692302, Long)
        '
        'PageInteractive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.Name = "PageInteractive"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents C1Gauge1 As C1.Win.Gauge.C1Gauge
    Friend WithEvents C1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class

