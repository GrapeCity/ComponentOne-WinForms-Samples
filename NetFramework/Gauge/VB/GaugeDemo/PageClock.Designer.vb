<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageClock
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
        Dim C1GaugeRectangle1 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Dim C1GaugeEllipse1 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugePointer1 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer2 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer3 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.C1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge
        Me.romanCheckBox = New System.Windows.Forms.CheckBox
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.romanCheckBox)
        Me.gaugePanel.Controls.Add(Me.c1Gauge1)
        '
        'timer1
        '
        Me.timer1.Enabled = True
        Me.timer1.Interval = 50
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.C1RadialGauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.C1RadialGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(16, 21)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(359, 396)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(637653635223226499, Long)
        '
        'C1RadialGauge1
        '
        Me.C1RadialGauge1.Cap.Border.Color = System.Drawing.Color.DarkSeaGreen
        Me.C1RadialGauge1.Cap.Border.Thickness = 1.5
        Me.C1RadialGauge1.Cap.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        Me.C1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.MistyRose
        Me.C1RadialGauge1.Cap.Filling.Color2 = System.Drawing.Color.DimGray
        Me.C1RadialGauge1.Cap.Radius = 5
        Me.C1RadialGauge1.Cap.Shadow.Visible = True
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.CustomShape.EndRadius = 2.5
        C1GaugeMarks1.CustomShape.StartRadius = 1.5
        C1GaugeMarks1.CustomShape.StartWidth = 3
        C1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.MistyRose
        C1GaugeMarks1.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugeMarks1.Filling.SwapColors = True
        C1GaugeMarks1.From = 0.5
        C1GaugeMarks1.Interval = 5
        C1GaugeMarks1.Length = 12
        C1GaugeMarks1.Location = 86
        C1GaugeMarks1.ScaleFrom = 0
        C1GaugeMarks1.Shadow.OffsetX = 0.5
        C1GaugeMarks1.Shadow.OffsetY = 0.5
        C1GaugeMarks1.Shadow.Visible = True
        C1GaugeMarks1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom
        C1GaugeMarks1.ViewTag = CType(634302468273582893, Long)
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.Gray
        C1GaugeMarks2.From = 0.5
        C1GaugeMarks2.Interval = 1
        C1GaugeMarks2.Length = 3
        C1GaugeMarks2.Location = 90
        C1GaugeMarks2.ScaleFrom = 0
        C1GaugeMarks2.Shadow.OffsetX = 0.5
        C1GaugeMarks2.Shadow.OffsetY = 0.5
        C1GaugeMarks2.Shadow.Visible = True
        C1GaugeMarks2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeMarks2.ViewTag = CType(634583943250743575, Long)
        C1GaugeMarks2.Width = 3
        C1GaugeLabels1.Color = System.Drawing.Color.Gainsboro
        C1GaugeLabels1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        C1GaugeLabels1.FontSize = 17
        C1GaugeLabels1.From = 0.5
        C1GaugeLabels1.Interval = 5
        C1GaugeLabels1.Location = 68
        C1GaugeLabels1.Name = "nums"
        C1GaugeLabels1.ScaleFrom = 0
        C1GaugeLabels1.Shadow.OffsetX = 0.5
        C1GaugeLabels1.Shadow.OffsetY = 0.5
        C1GaugeLabels1.Shadow.Visible = True
        C1GaugeLabels1.ValueFactor = 0.2
        C1GaugeLabels1.ViewTag = CType(634865418227634241, Long)
        Me.C1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks1, C1GaugeMarks2, C1GaugeLabels1})
        C1GaugeRectangle1.Border.Color = System.Drawing.Color.DarkSeaGreen
        C1GaugeRectangle1.Border.Thickness = 4
        C1GaugeRectangle1.CornerRadius = 30
        C1GaugeRectangle1.Filling.Color = System.Drawing.Color.DarkSlateGray
        C1GaugeRectangle1.Filling.Color2 = System.Drawing.Color.White
        C1GaugeRectangle1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialOuter
        C1GaugeRectangle1.HitTestable = False
        C1GaugeEllipse1.Border.Color = System.Drawing.Color.DarkSeaGreen
        C1GaugeEllipse1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeEllipse1.Border.Thickness = 2
        C1GaugeEllipse1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugeEllipse1.Filling.Color = System.Drawing.Color.SlateGray
        C1GaugeEllipse1.Filling.Color2 = System.Drawing.Color.DarkSlateGray
        C1GaugeEllipse1.Gradient.CenterPointX = 0.6
        C1GaugeEllipse1.Gradient.CenterPointY = 0.65
        C1GaugeEllipse1.Gradient.Direction = C1.Win.Gauge.C1GaugeGradientDirection.RadialInner
        C1GaugeEllipse1.Gradient.FocusScaleX = 0.1
        C1GaugeEllipse1.Gradient.FocusScaleY = 0.1
        C1GaugeEllipse1.Height = -0.97
        C1GaugeEllipse1.HitTestable = False
        C1GaugeEllipse1.Width = -0.97
        Me.C1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeRectangle1, C1GaugeEllipse1})
        Me.C1RadialGauge1.Maximum = 60
        C1GaugePointer1.Border.Color = System.Drawing.Color.DimGray
        C1GaugePointer1.CustomShape.EndRadius = 1.928571428571
        C1GaugePointer1.CustomShape.EndWidth = 3.857142857144
        C1GaugePointer1.CustomShape.StartRadius = 2.571428571429
        C1GaugePointer1.CustomShape.StartWidth = 9
        C1GaugePointer1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugePointer1.Filling.Color = System.Drawing.Color.MistyRose
        C1GaugePointer1.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugePointer1.Length = 63
        C1GaugePointer1.Name = "hours"
        C1GaugePointer1.Offset = -15
        C1GaugePointer1.Shadow.Visible = True
        C1GaugePointer1.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        C1GaugePointer1.Value = 0.42
        C1GaugePointer1.ValueFactor = 5
        C1GaugePointer1.ViewTag = CType(635146893204754921, Long)
        C1GaugePointer2.Border.Color = System.Drawing.Color.DimGray
        C1GaugePointer2.CustomShape.EndRadius = 1.928571428571
        C1GaugePointer2.CustomShape.EndWidth = 3.857142857144
        C1GaugePointer2.CustomShape.StartRadius = 2.571428571429
        C1GaugePointer2.CustomShape.StartWidth = 9
        C1GaugePointer2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        C1GaugePointer2.Filling.Color = System.Drawing.Color.MistyRose
        C1GaugePointer2.Filling.Color2 = System.Drawing.Color.DimGray
        C1GaugePointer2.Length = 94
        C1GaugePointer2.Name = "minutes"
        C1GaugePointer2.Offset = -15
        C1GaugePointer2.Shadow.Visible = True
        C1GaugePointer2.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        C1GaugePointer2.Value = 22.3
        C1GaugePointer2.ViewTag = CType(635428368181515579, Long)
        C1GaugePointer3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugePointer3.Filling.Color = System.Drawing.Color.DarkSeaGreen
        C1GaugePointer3.Length = 115
        C1GaugePointer3.Name = "seconds"
        C1GaugePointer3.Offset = -25
        C1GaugePointer3.Shadow.Visible = True
        C1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Round
        C1GaugePointer3.Value = 17
        C1GaugePointer3.ViewTag = CType(635709843158236236, Long)
        C1GaugePointer3.Width = 2
        Me.C1RadialGauge1.MorePointers.AddRange(New C1.Win.Gauge.C1GaugePointer() {C1GaugePointer1, C1GaugePointer2, C1GaugePointer3})
        Me.C1RadialGauge1.Name = "C1RadialGauge1"
        Me.C1RadialGauge1.Pointer.Visible = False
        Me.C1RadialGauge1.Radius = 0.49
        Me.C1RadialGauge1.StartAngle = 0
        Me.C1RadialGauge1.SweepAngle = 360
        Me.C1RadialGauge1.ViewTag = CType(636272793112967623, Long)
        '
        'romanCheckBox
        '
        Me.romanCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.romanCheckBox.AutoSize = True
        Me.romanCheckBox.Location = New System.Drawing.Point(326, 12)
        Me.romanCheckBox.Name = "romanCheckBox"
        Me.romanCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.romanCheckBox.TabIndex = 4
        Me.romanCheckBox.Text = "Roman"
        Me.romanCheckBox.UseVisualStyleBackColor = True
        '
        'PageClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageClock"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents romanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents C1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
