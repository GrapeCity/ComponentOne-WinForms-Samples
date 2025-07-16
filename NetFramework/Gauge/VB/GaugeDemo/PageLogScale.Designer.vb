<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageLogScale
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
        Dim CommonFont1 As C1.Win.Gauge.CommonFont = New C1.Win.Gauge.CommonFont
        Dim C1GaugeLabels1 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeLabels2 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeRange1 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeMarks1 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks2 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks3 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks4 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks5 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeSingleLabel1 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeRectangle1 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Dim C1GaugeSector1 As C1.Win.Gauge.C1GaugeSector = New C1.Win.Gauge.C1GaugeSector
        Dim C1GaugeSector2 As C1.Win.Gauge.C1GaugeSector = New C1.Win.Gauge.C1GaugeSector
        Dim C1GaugeSector3 As C1.Win.Gauge.C1GaugeSector = New C1.Win.Gauge.C1GaugeSector
        Dim C1GaugeSector4 As C1.Win.Gauge.C1GaugeSector = New C1.Win.Gauge.C1GaugeSector
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge
        Me.label1 = New System.Windows.Forms.Label
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.label1)
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
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(6, 6)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(379, 424)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(636406609817355893, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        CommonFont1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        CommonFont1.FontSize = 2.6
        CommonFont1.Name = "labelFont"
        Me.c1RadialGauge1.CommonFonts.AddRange(New C1.Win.Gauge.CommonFont() {CommonFont1})
        C1GaugeLabels1.CommonFontName = "labelFont"
        C1GaugeLabels1.HitTestable = False
        C1GaugeLabels1.Interval = 1
        C1GaugeLabels1.IntervalCoeff = 18
        C1GaugeLabels1.IsRotated = True
        C1GaugeLabels1.Location = 95
        C1GaugeLabels1.To = 300
        C1GaugeLabels1.ValueOffset = -100
        C1GaugeLabels1.ViewTag = CType(646258289201856091, Long)
        C1GaugeLabels2.CommonFontName = "labelFont"
        C1GaugeLabels2.From = 400
        C1GaugeLabels2.HitTestable = False
        C1GaugeLabels2.Interval = 1
        C1GaugeLabels2.IntervalCoeff = 9
        C1GaugeLabels2.IsRotated = True
        C1GaugeLabels2.Location = 95
        C1GaugeLabels2.To = 600
        C1GaugeLabels2.ValueOffset = -100
        C1GaugeLabels2.ViewTag = CType(649354648548552152, Long)
        C1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        C1GaugeRange1.From = 600
        C1GaugeRange1.HitTestable = False
        C1GaugeRange1.Location = 87.5
        C1GaugeRange1.ViewTag = CType(649636126668672600, Long)
        C1GaugeRange1.Width = 3
        C1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks1.HitTestable = False
        C1GaugeMarks1.Interval = 1
        C1GaugeMarks1.IntervalCoeff = 18
        C1GaugeMarks1.Length = 5
        C1GaugeMarks1.Location = 87.5
        C1GaugeMarks1.ViewTag = CType(645976808331978366, Long)
        C1GaugeMarks1.Width = 0.2
        C1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks2.From = 100
        C1GaugeMarks2.HitTestable = False
        C1GaugeMarks2.Interval = 1
        C1GaugeMarks2.IntervalCoeff = 180
        C1GaugeMarks2.Length = 3
        C1GaugeMarks2.Location = 87.5
        C1GaugeMarks2.To = 150
        C1GaugeMarks2.ViewTag = CType(650199140502477661, Long)
        C1GaugeMarks2.Width = 0.2
        C1GaugeMarks3.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks3.From = 150
        C1GaugeMarks3.HitTestable = False
        C1GaugeMarks3.Interval = 1
        C1GaugeMarks3.IntervalCoeff = 90
        C1GaugeMarks3.Length = 3
        C1GaugeMarks3.Location = 87.5
        C1GaugeMarks3.To = 600
        C1GaugeMarks3.ViewTag = CType(650480635266470085, Long)
        C1GaugeMarks3.Width = 0.2
        C1GaugeMarks4.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks4.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks4.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks4.From = 600
        C1GaugeMarks4.HitTestable = False
        C1GaugeMarks4.Interval = 1
        C1GaugeMarks4.IntervalCoeff = 36
        C1GaugeMarks4.Length = 3
        C1GaugeMarks4.Location = 87.5
        C1GaugeMarks4.ViewTag = CType(651043594119340417, Long)
        C1GaugeMarks4.Width = 0.2
        C1GaugeMarks5.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeMarks5.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks5.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks5.HitTestable = False
        C1GaugeMarks5.Interval = 1
        C1GaugeMarks5.IntervalCoeff = 18
        C1GaugeMarks5.Length = 4
        C1GaugeMarks5.Location = 73
        C1GaugeMarks5.SequenceNo = 1
        C1GaugeMarks5.ViewTag = CType(649917638929085762, Long)
        C1GaugeMarks5.Width = 0.2
        C1GaugeSingleLabel1.Angle = -8
        C1GaugeSingleLabel1.FontSize = 4
        C1GaugeSingleLabel1.Format = """V = [""0""]"""
        C1GaugeSingleLabel1.HitTestable = False
        C1GaugeSingleLabel1.Location = 60
        C1GaugeSingleLabel1.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeSingleLabel1.PointerIndex = 100
        C1GaugeSingleLabel1.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeSingleLabel1.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(100, -1, System.Drawing.Color.Black, 1, CType(684539149286312450, Long)), New C1.Win.Gauge.C1GaugeValueColor(600.5, -1, System.Drawing.Color.Red, 1, CType(684820624429572632, Long))})
        C1GaugeSingleLabel1.ValueOffset = -100
        C1GaugeSingleLabel1.ViewTag = CType(660613758344991672, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeLabels1, C1GaugeLabels2, C1GaugeRange1, C1GaugeMarks1, C1GaugeMarks2, C1GaugeMarks3, C1GaugeMarks4, C1GaugeMarks5, C1GaugeSingleLabel1})
        C1GaugeRectangle1.Border.Color = System.Drawing.Color.LightSteelBlue
        C1GaugeRectangle1.CenterPointY = 0.125
        C1GaugeRectangle1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeRectangle1.Filling.Color = System.Drawing.Color.LightSteelBlue
        C1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.White
        C1GaugeRectangle1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Vertical
        C1GaugeRectangle1.Height = -0.25
        C1GaugeRectangle1.Width = -0.5
        C1GaugeSector1.Border.Color = System.Drawing.Color.Gray
        C1GaugeSector1.CenterRadius = 1.3
        C1GaugeSector1.CornerRadius = 1
        C1GaugeSector1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSector1.Filling.Color = System.Drawing.Color.Gray
        C1GaugeSector1.Filling.Color2 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        C1GaugeSector1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeSector1.Gradient.FocusScaleX = 0.7
        C1GaugeSector1.Gradient.FocusScaleY = 0.7
        C1GaugeSector1.HitTestable = False
        C1GaugeSector1.InnerRadius = 73
        C1GaugeSector1.OuterRadius = 98.5
        C1GaugeSector1.StartAngle = -29
        C1GaugeSector1.SweepAngle = 58
        C1GaugeSector2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSector2.CenterRadius = 1.3
        C1GaugeSector2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSector2.Filling.Color = System.Drawing.Color.Gainsboro
        C1GaugeSector2.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugeSector2.Filling.SwapColors = True
        C1GaugeSector2.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Horizontal
        C1GaugeSector2.Gradient.Falloff = C1.Win.Gauge.C1GaugeGradientFalloff.Triangular
        C1GaugeSector2.Gradient.FocusScaleX = 0.7
        C1GaugeSector2.Gradient.FocusScaleY = 0.7
        C1GaugeSector2.Gradient.ScaleX = 0.6
        C1GaugeSector2.Gradient.ScaleY = 0.2
        C1GaugeSector2.Gradient.TranslateX = 0.2
        C1GaugeSector2.HitTestable = False
        C1GaugeSector2.InnerRadius = 80
        C1GaugeSector2.OuterRadius = 84.5
        C1GaugeSector2.StartAngle = -29
        C1GaugeSector2.SweepAngle = 58
        C1GaugeSector3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSector3.CenterRadius = 1.3
        C1GaugeSector3.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSector3.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        C1GaugeSector3.Filling.Color2 = System.Drawing.Color.Gray
        C1GaugeSector3.Filling.SwapColors = True
        C1GaugeSector3.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeSector3.Gradient.FocusScaleX = 0.98
        C1GaugeSector3.Gradient.FocusScaleY = 0.98
        C1GaugeSector3.HitTestable = False
        C1GaugeSector3.InnerRadius = 84.4
        C1GaugeSector3.OuterRadius = 85.5
        C1GaugeSector3.StartAngle = -29
        C1GaugeSector3.SweepAngle = 58
        C1GaugeSector4.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSector4.CenterRadius = 1.3
        C1GaugeSector4.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSector4.Filling.Color = System.Drawing.Color.White
        C1GaugeSector4.Filling.Color2 = System.Drawing.Color.Gray
        C1GaugeSector4.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeSector4.Gradient.FocusScaleX = 0.98
        C1GaugeSector4.Gradient.FocusScaleY = 0.98
        C1GaugeSector4.HitTestable = False
        C1GaugeSector4.InnerRadius = 79
        C1GaugeSector4.OuterRadius = 80.1
        C1GaugeSector4.StartAngle = -29
        C1GaugeSector4.SweepAngle = 58
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeRectangle1, C1GaugeSector1, C1GaugeSector2, C1GaugeSector3, C1GaugeSector4})
        Me.c1RadialGauge1.IsLogarithmic = True
        Me.c1RadialGauge1.Maximum = 850
        Me.c1RadialGauge1.Minimum = 100
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.DodgerBlue
        Me.c1RadialGauge1.Pointer.Border.Thickness = 0.2
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black
        Me.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.Gainsboro
        Me.c1RadialGauge1.Pointer.Filling.Opacity = 0.7
        Me.c1RadialGauge1.Pointer.Filling.Opacity2 = 0.5
        Me.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Vertical
        Me.c1RadialGauge1.Pointer.HitTestable = False
        Me.c1RadialGauge1.Pointer.Length = 22
        Me.c1RadialGauge1.Pointer.Offset = 67
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Arrow2
        Me.c1RadialGauge1.Pointer.Value = 300
        Me.c1RadialGauge1.Pointer.ValueOffset = 100
        Me.c1RadialGauge1.Pointer.Width = 1.3
        Me.c1RadialGauge1.PointerOriginY = 2
        Me.c1RadialGauge1.Radius = 2
        Me.c1RadialGauge1.StartAngle = -28
        Me.c1RadialGauge1.SweepAngle = 56
        Me.c1RadialGauge1.Viewport.AspectPinY = 0.5
        Me.c1RadialGauge1.Viewport.AspectRatio = 2
        Me.c1RadialGauge1.ViewTag = CType(636688084856520121, Long)
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 407)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(216, 13)
        Me.label1.TabIndex = 2
        Me.label1.Text = "* You can drag the pointer or click the scale"
        '
        'PageLogScale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.Name = "PageLogScale"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge
    Private WithEvents label1 As System.Windows.Forms.Label

End Class

