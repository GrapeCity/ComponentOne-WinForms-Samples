<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageLogarithmic
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
        Dim C1GaugeSingleMark1 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleLabel1 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeRange1 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeEllipse1 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
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
        Me.c1Gauge1.Location = New System.Drawing.Point(19, 17)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(353, 374)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(638528936816453066, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.BehindPointers = True
        Me.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.Red
        C1GaugeMarks1.Interval = 3
        C1GaugeMarks1.Length = 10
        C1GaugeMarks1.Location = 73
        C1GaugeMarks1.ViewTag = CType(636840086956049122, Long)
        C1GaugeMarks1.Width = 2
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray
        C1GaugeMarks2.Interval = 3
        C1GaugeMarks2.IntervalCoeff = 10
        C1GaugeMarks2.Length = 10
        C1GaugeMarks2.Location = 73
        C1GaugeMarks2.ViewTag = CType(637121561932769779, Long)
        C1GaugeMarks2.Width = 2
        C1GaugeLabels1.AllowFlip = True
        C1GaugeLabels1.Color = System.Drawing.Color.WhiteSmoke
        C1GaugeLabels1.FontSize = 12
        C1GaugeLabels1.Interval = 3
        C1GaugeLabels1.IsRotated = True
        C1GaugeLabels1.Location = 58
        C1GaugeLabels1.Name = "scale"
        C1GaugeLabels1.ViewTag = CType(637403036909480435, Long)
        C1GaugeSingleMark1.AlignmentOffset = 1
        C1GaugeSingleMark1.Border.Color = System.Drawing.Color.RosyBrown
        C1GaugeSingleMark1.CustomShape.EndRadius = 5
        C1GaugeSingleMark1.CustomShape.EndWidth = 22
        C1GaugeSingleMark1.CustomShape.ScaleEndRadius = False
        C1GaugeSingleMark1.CustomShape.ScaleStartRadius = False
        C1GaugeSingleMark1.CustomShape.StartRadius = 5
        C1GaugeSingleMark1.CustomShape.StartWidth = 22
        C1GaugeSingleMark1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        C1GaugeSingleMark1.Length = 13
        C1GaugeSingleMark1.Location = 88
        C1GaugeSingleMark1.PointerIndex = 100
        C1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom
        C1GaugeSingleMark1.ViewTag = CType(637684511886201091, Long)
        C1GaugeSingleLabel1.AllowFlip = True
        C1GaugeSingleLabel1.Color = System.Drawing.Color.Black
        C1GaugeSingleLabel1.FontSize = 7
        C1GaugeSingleLabel1.Format = "####0"
        C1GaugeSingleLabel1.IsRotated = True
        C1GaugeSingleLabel1.Location = 88
        C1GaugeSingleLabel1.PointerIndex = 100
        C1GaugeSingleLabel1.ViewTag = CType(637965986862951750, Long)
        C1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeRange1.Filling.Color = System.Drawing.Color.IndianRed
        C1GaugeRange1.Filling.Color2 = System.Drawing.Color.White
        C1GaugeRange1.Filling.SwapColors = True
        C1GaugeRange1.From = 128
        C1GaugeRange1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.Horizontal
        C1GaugeRange1.Gradient.ScaleX = 0.37
        C1GaugeRange1.Gradient.TranslateX = 0.65
        C1GaugeRange1.Location = 50
        C1GaugeRange1.ViewTag = CType(638247461839692407, Long)
        C1GaugeRange1.Width = 1
        C1GaugeRange1.Width2 = 20
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks1, C1GaugeMarks2, C1GaugeLabels1, C1GaugeSingleMark1, C1GaugeSingleLabel1, C1GaugeRange1})
        C1GaugeEllipse1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse1.Filling.Color = System.Drawing.Color.Black
        C1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.Gray
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse1})
        Me.c1RadialGauge1.IsLogarithmic = True
        Me.c1RadialGauge1.LogarithmicBase = 2
        Me.c1RadialGauge1.Maximum = 4096
        Me.c1RadialGauge1.Minimum = 1
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Salmon
        Me.c1RadialGauge1.Pointer.Length = 100
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Arrow1
        Me.c1RadialGauge1.Pointer.SweepTime = 2
        Me.c1RadialGauge1.Pointer.Value = 18
        Me.c1RadialGauge1.Pointer.Width = 5
        Me.c1RadialGauge1.ViewTag = CType(638810411793193724, Long)
        '
        'PageCase1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase1"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
