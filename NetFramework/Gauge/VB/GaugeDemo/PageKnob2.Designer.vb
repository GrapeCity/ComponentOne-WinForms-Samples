<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageKnob2
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
        Dim C1GaugeCaption1 As C1.Win.Gauge.C1GaugeCaption = New C1.Win.Gauge.C1GaugeCaption
        Dim C1GaugeSingleLabel1 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeEllipse1 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugeSingleLabel2 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel
        Dim C1GaugeEllipse2 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.c1RadialGauge2 = New C1.Win.Gauge.C1RadialGauge
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
        Me.gaugeGrid.SelectedObject = Me.c1Gauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        C1GaugeCaption1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        C1GaugeCaption1.FontSize = 6
        C1GaugeCaption1.Text = "0"
        Me.c1Gauge1.CoverShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeCaption1})
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.c1RadialGauge2, Me.c1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(17, 26)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Selectable = True
        Me.c1Gauge1.Size = New System.Drawing.Size(357, 383)
        Me.c1Gauge1.TabIndex = 2
        Me.c1Gauge1.ViewTag = CType(634609965734186602, Long)
        '
        'c1RadialGauge2
        '
        Me.c1RadialGauge2.Cap.Visible = False
        C1GaugeSingleLabel1.Angle = 0
        C1GaugeSingleLabel1.FontSize = 10
        C1GaugeSingleLabel1.Location = 85
        C1GaugeSingleLabel1.OrthogonalOffset = -95
        C1GaugeSingleLabel1.PointerIndex = 100
        C1GaugeSingleLabel1.ViewTag = CType(638550678938439511, Long)
        Me.c1RadialGauge2.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeSingleLabel1})
        C1GaugeEllipse1.Border.Color = System.Drawing.Color.Gray
        C1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkGoldenrod
        C1GaugeEllipse1.HitTestable = False
        Me.c1RadialGauge2.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse1})
        Me.c1RadialGauge2.Maximum = 54
        Me.c1RadialGauge2.Minimum = -54
        Me.c1RadialGauge2.Name = "c1RadialGauge2"
        Me.c1RadialGauge2.Pointer.Border.Color = System.Drawing.Color.Gray
        Me.c1RadialGauge2.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge2.Pointer.Filling.Color = System.Drawing.Color.White
        Me.c1RadialGauge2.Pointer.Filling.Color2 = System.Drawing.Color.DarkGray
        Me.c1RadialGauge2.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        Me.c1RadialGauge2.Pointer.Length = 30
        Me.c1RadialGauge2.Pointer.Offset = 65
        Me.c1RadialGauge2.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round
        Me.c1RadialGauge2.Pointer.Width = 30
        Me.c1RadialGauge2.SlidingScale = True
        Me.c1RadialGauge2.StartAngle = -540
        Me.c1RadialGauge2.SweepAngle = 1080
        Me.c1RadialGauge2.ViewTag = CType(636017396939781318, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeSingleLabel2.Angle = 0
        C1GaugeSingleLabel2.FontSize = 10
        C1GaugeSingleLabel2.Location = 85
        C1GaugeSingleLabel2.OrthogonalOffset = 95
        C1GaugeSingleLabel2.PointerIndex = 100
        C1GaugeSingleLabel2.ViewTag = CType(636017371211619752, Long)
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeSingleLabel2})
        C1GaugeEllipse2.Border.Color = System.Drawing.Color.Gray
        C1GaugeEllipse2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse2.Filling.Color = System.Drawing.Color.Gainsboro
        C1GaugeEllipse2.Filling.Color2 = System.Drawing.Color.SeaGreen
        C1GaugeEllipse2.Height = 120
        C1GaugeEllipse2.HitTestable = False
        C1GaugeEllipse2.Width = 120
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse2})
        Me.c1RadialGauge1.Maximum = 27
        Me.c1RadialGauge1.Minimum = -27
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Gray
        Me.c1RadialGauge1.Pointer.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.White
        Me.c1RadialGauge1.Pointer.Filling.Color2 = System.Drawing.Color.DarkGray
        Me.c1RadialGauge1.Pointer.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        Me.c1RadialGauge1.Pointer.Length = 30
        Me.c1RadialGauge1.Pointer.Offset = 22
        Me.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Round
        Me.c1RadialGauge1.Pointer.Width = 30
        Me.c1RadialGauge1.SlidingScale = True
        Me.c1RadialGauge1.StartAngle = -540
        Me.c1RadialGauge1.SweepAngle = 1080
        Me.c1RadialGauge1.ViewTag = CType(634891441129901224, Long)
        '
        'PageKnob2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "PageKnob2"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents c1RadialGauge2 As C1.Win.Gauge.C1RadialGauge
    Private WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
