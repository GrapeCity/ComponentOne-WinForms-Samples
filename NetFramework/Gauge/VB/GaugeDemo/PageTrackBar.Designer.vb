<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageTrackBar
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
        Dim CommonFilling1 As C1.Win.C1Gauge.CommonFilling = New C1.Win.C1Gauge.CommonFilling
        Dim CommonFilling2 As C1.Win.C1Gauge.CommonFilling = New C1.Win.C1Gauge.CommonFilling
        Dim CommonFilling3 As C1.Win.C1Gauge.CommonFilling = New C1.Win.C1Gauge.CommonFilling
        Dim CommonFilling4 As C1.Win.C1Gauge.CommonFilling = New C1.Win.C1Gauge.CommonFilling
        Dim CommonFilling5 As C1.Win.C1Gauge.CommonFilling = New C1.Win.C1Gauge.CommonFilling
        Dim CommonGradient1 As C1.Win.C1Gauge.CommonGradient = New C1.Win.C1Gauge.CommonGradient
        Dim CommonGradient2 As C1.Win.C1Gauge.CommonGradient = New C1.Win.C1Gauge.CommonGradient
        Dim C1GaugeSingleMark1 As C1.Win.C1Gauge.C1GaugeSingleMark = New C1.Win.C1Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleMark2 As C1.Win.C1Gauge.C1GaugeSingleMark = New C1.Win.C1Gauge.C1GaugeSingleMark
        Dim C1GaugeRange1 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeSingleLabel1 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel2 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleMark3 As C1.Win.C1Gauge.C1GaugeSingleMark = New C1.Win.C1Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleLabel3 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel4 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeRectangle1 As C1.Win.C1Gauge.C1GaugeRectangle = New C1.Win.C1Gauge.C1GaugeRectangle
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.C1Gauge.C1LinearGauge
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
        Me.timer1.Interval = 50
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
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1LinearGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(3, 92)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(382, 222)
        Me.c1Gauge1.SupportsTransitionEffect = True
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(639206783579924141, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisLength = 0.55
        Me.c1LinearGauge1.AxisStart = 0.25
        Me.c1LinearGauge1.BaseFactor = 0.88
        Me.c1LinearGauge1.BaseOrigin = 0.06
        CommonFilling1.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        CommonFilling1.Color = System.Drawing.Color.DimGray
        CommonFilling1.Color2 = System.Drawing.Color.White
        CommonFilling1.Name = "normalButton"
        CommonFilling1.SwapColors = True
        CommonFilling2.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        CommonFilling2.Color = System.Drawing.Color.LightCoral
        CommonFilling2.Color2 = System.Drawing.Color.MistyRose
        CommonFilling2.Name = "pressedButton"
        CommonFilling2.SwapColors = True
        CommonFilling3.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        CommonFilling3.Color = System.Drawing.Color.SeaGreen
        CommonFilling3.Color2 = System.Drawing.Color.White
        CommonFilling3.Name = "hotButton"
        CommonFilling3.SwapColors = True
        CommonFilling4.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        CommonFilling4.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        CommonFilling4.Color2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        CommonFilling4.Name = "normalPointer"
        CommonFilling4.SwapColors = True
        CommonFilling5.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        CommonFilling5.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        CommonFilling5.Color2 = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        CommonFilling5.Name = "hotPointer"
        CommonFilling5.SwapColors = True
        Me.c1LinearGauge1.CommonFillings.AddRange(New C1.Win.C1Gauge.CommonFilling() {CommonFilling1, CommonFilling2, CommonFilling3, CommonFilling4, CommonFilling5})
        CommonGradient1.CenterPointX = 0.7
        CommonGradient1.CenterPointY = 0.7
        CommonGradient1.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter
        CommonGradient1.FocusScaleX = 0.2
        CommonGradient1.FocusScaleY = 0.2
        CommonGradient1.Name = "normal"
        CommonGradient2.CenterPointX = 0.6
        CommonGradient2.CenterPointY = 0.6
        CommonGradient2.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter
        CommonGradient2.FocusScaleX = 0.2
        CommonGradient2.FocusScaleY = 0.2
        CommonGradient2.Name = "pressed"
        Me.c1LinearGauge1.CommonGradients.AddRange(New C1.Win.C1Gauge.CommonGradient() {CommonGradient1, CommonGradient2})
        C1GaugeSingleMark1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark1.CustomShape.EndRadius = 12
        C1GaugeSingleMark1.CustomShape.EndWidth = 36
        C1GaugeSingleMark1.CustomShape.StartRadius = 12
        C1GaugeSingleMark1.CustomShape.StartWidth = 36
        C1GaugeSingleMark1.Filling.CommonFillingName = "normalButton"
        C1GaugeSingleMark1.Gradient.CommonGradientName = "normal"
        C1GaugeSingleMark1.Length = 36
        C1GaugeSingleMark1.Location = 50
        C1GaugeSingleMark1.Name = "minusButton"
        C1GaugeSingleMark1.Position = -0.25
        C1GaugeSingleMark1.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom
        C1GaugeSingleMark1.ViewTag = CType(635265244106009517, Long)
        C1GaugeSingleMark2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark2.CustomShape.EndRadius = 12
        C1GaugeSingleMark2.CustomShape.EndWidth = 36
        C1GaugeSingleMark2.CustomShape.StartRadius = 12
        C1GaugeSingleMark2.CustomShape.StartWidth = 36
        C1GaugeSingleMark2.Filling.CommonFillingName = "normalButton"
        C1GaugeSingleMark2.Gradient.CommonGradientName = "normal"
        C1GaugeSingleMark2.Length = 36
        C1GaugeSingleMark2.Location = 50
        C1GaugeSingleMark2.Name = "plusButton"
        C1GaugeSingleMark2.Position = 1.15
        C1GaugeSingleMark2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Custom
        C1GaugeSingleMark2.ViewTag = CType(635546719779070002, Long)
        C1GaugeRange1.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeRange1.Filling.Color = System.Drawing.Color.RosyBrown
        C1GaugeRange1.Filling.Color2 = System.Drawing.Color.White
        C1GaugeRange1.Filling.SwapColors = True
        C1GaugeRange1.Location = 50
        C1GaugeRange1.ViewTag = CType(635828197239232703, Long)
        C1GaugeSingleLabel1.Color = System.Drawing.Color.SeaGreen
        C1GaugeSingleLabel1.FontSize = 29
        C1GaugeSingleLabel1.HitTestable = False
        C1GaugeSingleLabel1.Location = 50
        C1GaugeSingleLabel1.Name = "minusLabel"
        C1GaugeSingleLabel1.Position = -0.25
        C1GaugeSingleLabel1.Text = "-"
        C1GaugeSingleLabel1.ViewTag = CType(636109824900026389, Long)
        C1GaugeSingleLabel2.Color = System.Drawing.Color.SeaGreen
        C1GaugeSingleLabel2.FontSize = 27
        C1GaugeSingleLabel2.HitTestable = False
        C1GaugeSingleLabel2.Location = 50
        C1GaugeSingleLabel2.Name = "plusLabel"
        C1GaugeSingleLabel2.Position = 1.15
        C1GaugeSingleLabel2.Text = "+"
        C1GaugeSingleLabel2.ViewTag = CType(636391301269766722, Long)
        C1GaugeSingleMark3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark3.Filling.Color = System.Drawing.Color.Gray
        C1GaugeSingleMark3.Location = 50
        C1GaugeSingleMark3.Name = "offMark"
        C1GaugeSingleMark3.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Round
        C1GaugeSingleMark3.ViewTag = CType(638361660776914335, Long)
        C1GaugeSingleMark3.Width = 7
        C1GaugeSingleLabel3.FontSize = 12
        C1GaugeSingleLabel3.Location = 75
        C1GaugeSingleLabel3.Text = "Off"
        C1GaugeSingleLabel3.ViewTag = CType(638643135785906837, Long)
        C1GaugeSingleLabel4.Color = System.Drawing.Color.Firebrick
        C1GaugeSingleLabel4.FontSize = 14
        C1GaugeSingleLabel4.Format = "0.0"
        C1GaugeSingleLabel4.Location = 23
        C1GaugeSingleLabel4.PointerIndex = 100
        C1GaugeSingleLabel4.Position = 0.5
        C1GaugeSingleLabel4.ViewTag = CType(637244291430233034, Long)
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeSingleMark1, C1GaugeSingleMark2, C1GaugeRange1, C1GaugeSingleLabel1, C1GaugeSingleLabel2, C1GaugeSingleMark3, C1GaugeSingleLabel3, C1GaugeSingleLabel4})
        C1GaugeRectangle1.Border.Color = System.Drawing.Color.Gray
        C1GaugeRectangle1.CenterPointX = 0.455
        C1GaugeRectangle1.CornerRadius = 10
        C1GaugeRectangle1.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeRectangle1.Filling.Color = System.Drawing.Color.LightGray
        C1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.Gray
        C1GaugeRectangle1.HitTestable = False
        C1GaugeRectangle1.Width = -1.76
        Me.c1LinearGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeRectangle1})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.OffPosition = 0.21
        Me.c1LinearGauge1.Pointer.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Center
        Me.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.DarkGray
        Me.c1LinearGauge1.Pointer.Filling.CommonFillingName = "normalPointer"
        Me.c1LinearGauge1.Pointer.Length = 25
        Me.c1LinearGauge1.Pointer.Offset = 50
        Me.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Round
        Me.c1LinearGauge1.Pointer.Width = 12
        Me.c1LinearGauge1.Viewport.AspectRatio = 3
        Me.c1LinearGauge1.ViewTag = CType(634702292464031625, Long)
        '
        'PageTrackBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.Name = "PageTrackBar"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.C1Gauge.C1LinearGauge

End Class

