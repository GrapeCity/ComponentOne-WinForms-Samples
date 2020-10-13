<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageCarDashboard
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
        Dim C1GaugeRange5 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeMarks3 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeRange6 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeRange7 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeMarks4 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeSingleLabel4 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeLabels3 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels
        Dim C1GaugeSingleLabel5 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeLabels4 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels
        Dim C1GaugeSingleLabel6 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeRange8 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeEllipse2 As C1.Win.C1Gauge.C1GaugeEllipse = New C1.Win.C1Gauge.C1GaugeEllipse
        Dim C1GaugePointer4 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer5 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer6 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
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
        Me.timer1.Interval = 300
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
        Me.c1Gauge1.Location = New System.Drawing.Point(1, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(388, 430)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(640781521076085716, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeRange5.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeRange5.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRange5.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeRange5.Filling.Color = System.Drawing.Color.AntiqueWhite
        C1GaugeRange5.Filling.Color2 = System.Drawing.Color.RosyBrown
        C1GaugeRange5.Gradient.CenterPointX = 0.4
        C1GaugeRange5.Gradient.CenterPointY = 0.6
        C1GaugeRange5.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeRange5.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.SigmaBell
        C1GaugeRange5.Location = 90
        C1GaugeRange5.Location2 = 30
        C1GaugeRange5.ViewTag = CType(655418274945540252, Long)
        C1GaugeRange5.Width = 40
        C1GaugeRange5.Width2 = 10
        C1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.Filling.Color = System.Drawing.Color.RosyBrown
        C1GaugeMarks3.Interval = 10
        C1GaugeMarks3.Length = 39.5
        C1GaugeMarks3.Length2 = 11.5
        C1GaugeMarks3.Location = 89
        C1GaugeMarks3.Location2 = 32.3
        C1GaugeMarks3.ScaleFrom = -90
        C1GaugeMarks3.ScaleTo = 180
        C1GaugeMarks3.ViewTag = CType(656825655115455895, Long)
        C1GaugeMarks3.Width = 1
        C1GaugeRange6.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeRange6.Border.Color = System.Drawing.Color.LightCoral
        C1GaugeRange6.Location = 95
        C1GaugeRange6.Location2 = 35
        C1GaugeRange6.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(-90, -1, System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer)), 1, CType(676529226475175784, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(-40, -1, System.Drawing.Color.PaleGreen, 1, CType(677936611759773970, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(-25, -1, System.Drawing.Color.LightSalmon, 1, CType(678218087732741609, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(-7, -1, System.Drawing.Color.IndianRed, 1, CType(677655136309166209, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.SteelBlue, 1, CType(678499567948351913, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(70, -1, System.Drawing.Color.MidnightBlue, 1, CType(678781044024275440, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(180, -1, System.Drawing.Color.IndianRed, 1, CType(677373661041038885, Long))})
        C1GaugeRange6.ViewTag = CType(653447916928237854, Long)
        C1GaugeRange6.Width = 18
        C1GaugeRange6.Width2 = 18
        C1GaugeRange7.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeRange7.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRange7.Filling.Color = System.Drawing.Color.LightCoral
        C1GaugeRange7.Location = 95
        C1GaugeRange7.Location2 = 35
        C1GaugeRange7.ViewTag = CType(655136798311694813, Long)
        C1GaugeRange7.Width = 5
        C1GaugeMarks4.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks4.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeMarks4.Filling.Color = System.Drawing.Color.White
        C1GaugeMarks4.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugeMarks4.From = -90
        C1GaugeMarks4.Interval = 10
        C1GaugeMarks4.IsRotated = False
        C1GaugeMarks4.Length = 5
        C1GaugeMarks4.Location = 91.5
        C1GaugeMarks4.Location2 = 32.7
        C1GaugeMarks4.SequenceNo = -1
        C1GaugeMarks4.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks4.ViewTag = CType(641063176673067260, Long)
        C1GaugeSingleLabel4.Angle = -86
        C1GaugeSingleLabel4.Color = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        C1GaugeSingleLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel4.FontSize = 9
        C1GaugeSingleLabel4.Location = 100
        C1GaugeSingleLabel4.SequenceNo = 0
        C1GaugeSingleLabel4.Text = " RPM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x1000"
        C1GaugeSingleLabel4.ViewTag = CType(637122515720112954, Long)
        C1GaugeLabels3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeLabels3.FontSize = 10
        C1GaugeLabels3.FontSize2 = 14
        C1GaugeLabels3.Interval = 10
        C1GaugeLabels3.Location = 103
        C1GaugeLabels3.Location2 = 84
        C1GaugeLabels3.ScaleFrom = -90
        C1GaugeLabels3.ScaleTo = 0
        C1GaugeLabels3.To = -1
        C1GaugeLabels3.ValueFactor = 0.1
        C1GaugeLabels3.ValueOffset = 9
        C1GaugeLabels3.ViewTag = CType(636559562791001442, Long)
        C1GaugeSingleLabel5.Angle = 170
        C1GaugeSingleLabel5.Color = System.Drawing.Color.White
        C1GaugeSingleLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel5.FontSize = 10
        C1GaugeSingleLabel5.Location = 24
        C1GaugeSingleLabel5.Text = "MPH"
        C1GaugeSingleLabel5.ViewTag = CType(637403993970580858, Long)
        C1GaugeLabels4.Color = System.Drawing.Color.White
        C1GaugeLabels4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeLabels4.FontSize = 11
        C1GaugeLabels4.FontSize2 = 6
        C1GaugeLabels4.Interval = 10
        C1GaugeLabels4.Location = 84
        C1GaugeLabels4.Location2 = 44
        C1GaugeLabels4.ScaleFrom = 0
        C1GaugeLabels4.ViewTag = CType(641344658725412619, Long)
        C1GaugeSingleLabel6.Angle = -113
        C1GaugeSingleLabel6.Color = System.Drawing.Color.Snow
        C1GaugeSingleLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel6.FontSize = 10
        C1GaugeSingleLabel6.Location = 102
        C1GaugeSingleLabel6.Text = "Fuel"
        C1GaugeSingleLabel6.ViewTag = CType(688914168538589149, Long)
        C1GaugeRange8.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeRange8.AntiAliasing = C1.Win.C1Gauge.C1GaugeRangeAntiAliasing.LowQuality
        C1GaugeRange8.Border.Color = System.Drawing.Color.White
        C1GaugeRange8.From = 60
        C1GaugeRange8.Location = 100
        C1GaugeRange8.Location2 = 106
        C1GaugeRange8.To = 80
        C1GaugeRange8.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeRange8.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightCoral, 1, CType(688069741589521705, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 2, System.Drawing.Color.Lavender, 1, CType(688351217164156560, Long))})
        C1GaugeRange8.ViewTag = CType(687788264195372779, Long)
        C1GaugeRange8.Width = 6
        C1GaugeRange8.Width2 = 14
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeRange5, C1GaugeMarks3, C1GaugeRange6, C1GaugeRange7, C1GaugeMarks4, C1GaugeSingleLabel4, C1GaugeLabels3, C1GaugeSingleLabel5, C1GaugeLabels4, C1GaugeSingleLabel6, C1GaugeRange8})
        C1GaugeEllipse2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse2.CenterPointX = 0.44
        C1GaugeEllipse2.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse2.Filling.Color = System.Drawing.Color.Lavender
        C1GaugeEllipse2.Filling.Color2 = System.Drawing.Color.DarkBlue
        C1GaugeEllipse2.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical
        C1GaugeEllipse2.Height = -1.05
        C1GaugeEllipse2.RotateAngle = -32
        C1GaugeEllipse2.Width = -1.1
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeEllipse2})
        Me.c1RadialGauge1.Maximum = 186
        Me.c1RadialGauge1.Minimum = -95
        C1GaugePointer4.Border.Color = System.Drawing.Color.DarkSlateBlue
        C1GaugePointer4.Border.Thickness = 1
        C1GaugePointer4.CustomShape.EndWidth = 0
        C1GaugePointer4.CustomShape.StartAngle = -25
        C1GaugePointer4.CustomShape.StartWidth = 12
        C1GaugePointer4.Filling.Color = System.Drawing.Color.RoyalBlue
        C1GaugePointer4.Length = 10
        C1GaugePointer4.Name = "mph"
        C1GaugePointer4.Offset = 80
        C1GaugePointer4.Offset2 = 20
        C1GaugePointer4.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        C1GaugePointer4.SweepTime = 10
        C1GaugePointer4.Value = 65
        C1GaugePointer4.ViewTag = CType(677092177610324687, Long)
        C1GaugePointer5.Border.Color = System.Drawing.Color.DarkOliveGreen
        C1GaugePointer5.Border.Thickness = 1
        C1GaugePointer5.CustomShape.EndWidth = 0
        C1GaugePointer5.CustomShape.StartAngle = -25
        C1GaugePointer5.CustomShape.StartWidth = 12
        C1GaugePointer5.Filling.Color = System.Drawing.Color.OliveDrab
        C1GaugePointer5.Length = 10
        C1GaugePointer5.Name = "rpm"
        C1GaugePointer5.Offset = 80
        C1GaugePointer5.Offset2 = 20
        C1GaugePointer5.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Custom
        C1GaugePointer5.SweepTime = 7
        C1GaugePointer5.Value = 2500
        C1GaugePointer5.ValueFactor = 0.01
        C1GaugePointer5.ValueOffset = -90
        C1GaugePointer5.ViewTag = CType(682721708515102101, Long)
        C1GaugePointer6.Name = "fuel"
        C1GaugePointer6.SweepTime = 30
        C1GaugePointer6.Value = 70
        C1GaugePointer6.ValueFactor = 0.2
        C1GaugePointer6.ValueOffset = 60
        C1GaugePointer6.ViewTag = CType(688632692472186167, Long)
        C1GaugePointer6.Visible = False
        Me.c1RadialGauge1.MorePointers.AddRange(New C1.Win.C1Gauge.C1GaugePointer() {C1GaugePointer4, C1GaugePointer5, C1GaugePointer6})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Visible = False
        Me.c1RadialGauge1.PointerOriginX = 0.56
        Me.c1RadialGauge1.Radius = 0.45
        Me.c1RadialGauge1.StartAngle = -76
        Me.c1RadialGauge1.SweepAngle = 506
        Me.c1RadialGauge1.Viewport.AspectPinX = 0.45
        Me.c1RadialGauge1.Viewport.AspectPinY = 0.5
        Me.c1RadialGauge1.Viewport.AspectRatio = 1
        Me.c1RadialGauge1.ViewTag = CType(652884948141329328, Long)
        '
        'PageCase9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase9"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.C1Gauge.C1RadialGauge

End Class
