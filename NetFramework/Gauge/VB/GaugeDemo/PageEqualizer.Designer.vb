<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageEqualizer
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
        Dim C1GaugeMarks21 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks22 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks23 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks24 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks25 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks26 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks27 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks28 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks29 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks30 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeRectangle3 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Dim C1GaugeCaption21 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption22 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption23 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption24 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption25 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption26 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption27 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption28 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption29 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeCaption30 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugePointer21 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer22 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer23 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer24 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer25 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer26 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer27 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer28 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer29 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer30 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
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
        Me.timer1.Interval = 300
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
        Me.c1Gauge1.Location = New System.Drawing.Point(15, 15)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(359, 406)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(634306981512399298, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisStart = 0.025
        Me.c1LinearGauge1.BaseFactor = 0.95
        Me.c1LinearGauge1.BaseOrigin = 0.025
        C1GaugeMarks21.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks21.From = 0.001
        C1GaugeMarks21.IntervalWidth = 3
        C1GaugeMarks21.Length = 7
        C1GaugeMarks21.Location = 5
        C1GaugeMarks21.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks21.ScaleFrom = 0
        C1GaugeMarks21.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks21.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks21.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Khaki, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 0, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks21.ViewTag = CType(635151407842501340, Long)
        C1GaugeMarks21.Width = 2
        C1GaugeMarks22.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks22.From = 0.001
        C1GaugeMarks22.IntervalWidth = 3
        C1GaugeMarks22.Length = 7
        C1GaugeMarks22.Location = 15
        C1GaugeMarks22.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks22.ScaleFrom = 0
        C1GaugeMarks22.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks22.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks22.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.DeepSkyBlue, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 1, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks22.ViewTag = CType(635151407842501341, Long)
        C1GaugeMarks22.Width = 2
        C1GaugeMarks23.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks23.From = 0.001
        C1GaugeMarks23.IntervalWidth = 3
        C1GaugeMarks23.Length = 7
        C1GaugeMarks23.Location = 25
        C1GaugeMarks23.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks23.ScaleFrom = 0
        C1GaugeMarks23.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks23.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks23.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.SpringGreen, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 2, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks23.ViewTag = CType(635151407842501342, Long)
        C1GaugeMarks23.Width = 2
        C1GaugeMarks24.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks24.From = 0.001
        C1GaugeMarks24.IntervalWidth = 3
        C1GaugeMarks24.Length = 7
        C1GaugeMarks24.Location = 35
        C1GaugeMarks24.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks24.ScaleFrom = 0
        C1GaugeMarks24.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks24.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks24.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightSteelBlue, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 3, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks24.ViewTag = CType(635151407842501343, Long)
        C1GaugeMarks24.Width = 2
        C1GaugeMarks25.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks25.From = 0.001
        C1GaugeMarks25.IntervalWidth = 3
        C1GaugeMarks25.Length = 7
        C1GaugeMarks25.Location = 45
        C1GaugeMarks25.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks25.ScaleFrom = 0
        C1GaugeMarks25.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks25.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks25.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Pink, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 4, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks25.ViewTag = CType(635151407842501344, Long)
        C1GaugeMarks25.Width = 2
        C1GaugeMarks26.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks26.From = 0.001
        C1GaugeMarks26.IntervalWidth = 3
        C1GaugeMarks26.Length = 7
        C1GaugeMarks26.Location = 55
        C1GaugeMarks26.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks26.ScaleFrom = 0
        C1GaugeMarks26.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks26.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks26.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.PaleGreen, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 5, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks26.ViewTag = CType(635151407842501345, Long)
        C1GaugeMarks26.Width = 2
        C1GaugeMarks27.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks27.From = 0.001
        C1GaugeMarks27.IntervalWidth = 3
        C1GaugeMarks27.Length = 7
        C1GaugeMarks27.Location = 65
        C1GaugeMarks27.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks27.ScaleFrom = 0
        C1GaugeMarks27.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks27.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks27.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Cyan, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 6, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks27.ViewTag = CType(635151407842501346, Long)
        C1GaugeMarks27.Width = 2
        C1GaugeMarks28.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks28.From = 0.001
        C1GaugeMarks28.IntervalWidth = 3
        C1GaugeMarks28.Length = 7
        C1GaugeMarks28.Location = 75
        C1GaugeMarks28.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks28.ScaleFrom = 0
        C1GaugeMarks28.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks28.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks28.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.Gold, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 7, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks28.ViewTag = CType(635151407842501347, Long)
        C1GaugeMarks28.Width = 2
        C1GaugeMarks29.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks29.From = 0.001
        C1GaugeMarks29.IntervalWidth = 3
        C1GaugeMarks29.Length = 7
        C1GaugeMarks29.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks29.ScaleFrom = 0
        C1GaugeMarks29.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks29.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks29.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.LightCoral, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 8, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks29.ViewTag = CType(635151407842501348, Long)
        C1GaugeMarks29.Width = 2
        C1GaugeMarks30.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks30.From = 0.001
        C1GaugeMarks30.IntervalWidth = 3
        C1GaugeMarks30.Length = 7
        C1GaugeMarks30.Location = 95
        C1GaugeMarks30.OrthogonalAlignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks30.ScaleFrom = 0
        C1GaugeMarks30.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks30.ValueColorFalloff = C1.Win.Gauge.C1GaugeValueColorFalloff.None
        C1GaugeMarks30.ValueColors.AddRange(New C1.Win.Gauge.C1GaugeValueColor() {New C1.Win.Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.OldLace, 1, CType(635432888687017615, Long)), New C1.Win.Gauge.C1GaugeValueColor(Double.NaN, 9, System.Drawing.Color.DimGray, 0.5, CType(641906831190384476, Long))})
        C1GaugeMarks30.ViewTag = CType(635151407842501349, Long)
        C1GaugeMarks30.Width = 2
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks21, C1GaugeMarks22, C1GaugeMarks23, C1GaugeMarks24, C1GaugeMarks25, C1GaugeMarks26, C1GaugeMarks27, C1GaugeMarks28, C1GaugeMarks29, C1GaugeMarks30})
        C1GaugeRectangle3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRectangle3.Filling.Color = System.Drawing.Color.Black
        C1GaugeRectangle3.Viewport.ScaleY = 1.07
        C1GaugeRectangle3.Viewport.TranslateY = -0.01
        C1GaugeCaption21.CenterPointX = 0.055
        C1GaugeCaption21.CenterPointY = 1.03
        C1GaugeCaption21.Color = System.Drawing.Color.White
        C1GaugeCaption21.FontSize = 4
        C1GaugeCaption21.Text = "31Hz"
        C1GaugeCaption22.CenterPointX = 0.15
        C1GaugeCaption22.CenterPointY = 1.03
        C1GaugeCaption22.Color = System.Drawing.Color.White
        C1GaugeCaption22.FontSize = 4
        C1GaugeCaption22.Text = "62"
        C1GaugeCaption23.CenterPointX = 0.25
        C1GaugeCaption23.CenterPointY = 1.03
        C1GaugeCaption23.Color = System.Drawing.Color.White
        C1GaugeCaption23.FontSize = 4
        C1GaugeCaption23.Text = "125"
        C1GaugeCaption24.CenterPointX = 0.35
        C1GaugeCaption24.CenterPointY = 1.03
        C1GaugeCaption24.Color = System.Drawing.Color.White
        C1GaugeCaption24.FontSize = 4
        C1GaugeCaption24.Text = "250"
        C1GaugeCaption25.CenterPointX = 0.45
        C1GaugeCaption25.CenterPointY = 1.03
        C1GaugeCaption25.Color = System.Drawing.Color.White
        C1GaugeCaption25.FontSize = 4
        C1GaugeCaption25.Text = "500"
        C1GaugeCaption26.CenterPointX = 0.55
        C1GaugeCaption26.CenterPointY = 1.03
        C1GaugeCaption26.Color = System.Drawing.Color.White
        C1GaugeCaption26.FontSize = 4
        C1GaugeCaption26.Text = "1KHz"
        C1GaugeCaption27.CenterPointX = 0.65
        C1GaugeCaption27.CenterPointY = 1.03
        C1GaugeCaption27.Color = System.Drawing.Color.White
        C1GaugeCaption27.FontSize = 4
        C1GaugeCaption27.Text = "2"
        C1GaugeCaption28.CenterPointX = 0.75
        C1GaugeCaption28.CenterPointY = 1.03
        C1GaugeCaption28.Color = System.Drawing.Color.White
        C1GaugeCaption28.FontSize = 4
        C1GaugeCaption28.Text = "4"
        C1GaugeCaption29.CenterPointX = 0.85
        C1GaugeCaption29.CenterPointY = 1.03
        C1GaugeCaption29.Color = System.Drawing.Color.White
        C1GaugeCaption29.FontSize = 4
        C1GaugeCaption29.Text = "8"
        C1GaugeCaption30.CenterPointX = 0.94
        C1GaugeCaption30.CenterPointY = 1.03
        C1GaugeCaption30.Color = System.Drawing.Color.White
        C1GaugeCaption30.FontSize = 4
        C1GaugeCaption30.Text = "16KHz"
        Me.c1LinearGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeRectangle3, C1GaugeCaption21, C1GaugeCaption22, C1GaugeCaption23, C1GaugeCaption24, C1GaugeCaption25, C1GaugeCaption26, C1GaugeCaption27, C1GaugeCaption28, C1GaugeCaption29, C1GaugeCaption30})
        Me.c1LinearGauge1.IsReversed = True
        C1GaugePointer21.SweepTime = 1
        C1GaugePointer21.Value = 9
        C1GaugePointer21.ViewTag = CType(639092078879292408, Long)
        C1GaugePointer21.Visible = False
        C1GaugePointer22.SweepTime = 1
        C1GaugePointer22.Value = 50
        C1GaugePointer22.ViewTag = CType(639373554037453443, Long)
        C1GaugePointer22.Visible = False
        C1GaugePointer23.SweepTime = 1
        C1GaugePointer23.Value = 68
        C1GaugePointer23.ViewTag = CType(639655029020324451, Long)
        C1GaugePointer23.Visible = False
        C1GaugePointer24.SweepTime = 1
        C1GaugePointer24.Value = 44
        C1GaugePointer24.ViewTag = CType(639936504002445416, Long)
        C1GaugePointer24.Visible = False
        C1GaugePointer25.SweepTime = 1
        C1GaugePointer25.Value = 89
        C1GaugePointer25.ViewTag = CType(640217978982406258, Long)
        C1GaugePointer25.Visible = False
        C1GaugePointer26.SweepTime = 1
        C1GaugePointer26.Value = 62
        C1GaugePointer26.ViewTag = CType(640499453962297096, Long)
        C1GaugePointer26.Visible = False
        C1GaugePointer27.SweepTime = 1
        C1GaugePointer27.Value = 27
        C1GaugePointer27.ViewTag = CType(640780928942047926, Long)
        C1GaugePointer27.Visible = False
        C1GaugePointer28.SweepTime = 1
        C1GaugePointer28.Value = 46
        C1GaugePointer28.ViewTag = CType(641062403921548742, Long)
        C1GaugePointer28.Visible = False
        C1GaugePointer29.SweepTime = 1
        C1GaugePointer29.Value = 75
        C1GaugePointer29.ViewTag = CType(641343878901929608, Long)
        C1GaugePointer29.Visible = False
        C1GaugePointer30.SweepTime = 1
        C1GaugePointer30.Value = 37
        C1GaugePointer30.ViewTag = CType(641625353888230812, Long)
        C1GaugePointer30.Visible = False
        Me.c1LinearGauge1.MorePointers.AddRange(New C1.Win.Gauge.C1GaugePointer() {C1GaugePointer21, C1GaugePointer22, C1GaugePointer23, C1GaugePointer24, C1GaugePointer25, C1GaugePointer26, C1GaugePointer27, C1GaugePointer28, C1GaugePointer29, C1GaugePointer30})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Orientation = C1.Win.Gauge.C1GaugeOrientation.Vertical
        Me.c1LinearGauge1.Pointer.Visible = False
        Me.c1LinearGauge1.ViewTag = CType(634588456711232659, Long)
        '
        'PageCase8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase8"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.Gauge.C1LinearGauge

End Class
