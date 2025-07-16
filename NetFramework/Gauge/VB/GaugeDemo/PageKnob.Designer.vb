<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageKnob
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
        Dim C1GaugeRange1 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeSingleMark1 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeMarks1 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeSingleLabel1 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
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
        Me.c1Gauge1.Location = New System.Drawing.Point(3, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(382, 430)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(635266116717091809, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeRange1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeRange1.Filling.Color = System.Drawing.Color.Green
        C1GaugeRange1.HitTestable = False
        C1GaugeRange1.Location = 70
        C1GaugeRange1.Location2 = 100
        C1GaugeRange1.ViewTag = CType(635265198974198125, Long)
        C1GaugeRange1.Width = 1
        C1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeSingleMark1.Filling.Color = System.Drawing.Color.Gainsboro
        C1GaugeSingleMark1.Filling.Color2 = System.Drawing.Color.Blue
        C1GaugeSingleMark1.HitTestable = False
        C1GaugeSingleMark1.IsRotated = False
        C1GaugeSingleMark1.Length = 30
        C1GaugeSingleMark1.Location = 37
        C1GaugeSingleMark1.PointerIndex = 100
        C1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeSingleMark1.ViewTag = CType(635546684858422655, Long)
        C1GaugeSingleMark1.Width = 30
        C1GaugeMarks1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        C1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.White
        C1GaugeMarks1.Filling.Color2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        C1GaugeMarks1.FromPointerIndex = 100
        C1GaugeMarks1.Interval = 5000
        C1GaugeMarks1.IsRotated = False
        C1GaugeMarks1.Length = 10
        C1GaugeMarks1.Location = 70
        C1GaugeMarks1.Location2 = 100
        C1GaugeMarks1.ScaleFrom = 0
        C1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks1.ShowIrregularFrom = True
        C1GaugeMarks1.ViewTag = CType(636672592310256828, Long)
        C1GaugeMarks1.Width = 10
        C1GaugeSingleLabel1.Angle = 47
        C1GaugeSingleLabel1.Color = System.Drawing.Color.Green
        C1GaugeSingleLabel1.FontSize = 10
        C1GaugeSingleLabel1.Format = "#0.0"
        C1GaugeSingleLabel1.Location = 120
        C1GaugeSingleLabel1.PointerIndex = 100
        C1GaugeSingleLabel1.ViewTag = CType(636954074038533652, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeRange1, C1GaugeSingleMark1, C1GaugeMarks1, C1GaugeSingleLabel1})
        C1GaugeEllipse1.Border.Color = System.Drawing.Color.Silver
        C1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse1.Filling.Color = System.Drawing.Color.Gainsboro
        C1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugeEllipse1.Height = 120
        C1GaugeEllipse1.HitTestable = False
        C1GaugeEllipse1.Width = 120
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse1})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        Me.c1RadialGauge1.Pointer.Length = 30
        Me.c1RadialGauge1.Pointer.Offset = 22
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round
        Me.c1RadialGauge1.Pointer.Width = 30
        Me.c1RadialGauge1.SweepAngle = 1000
        Me.c1RadialGauge1.ViewTag = CType(634702240281386949, Long)
        '
        'PageKnob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.Name = "PageKnob"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Friend WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class

