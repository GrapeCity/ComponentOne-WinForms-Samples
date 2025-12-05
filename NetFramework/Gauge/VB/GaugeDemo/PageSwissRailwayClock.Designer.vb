<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageSwissRailwayClock
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
        Dim C1GaugeSingleMark1 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleMark2 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeSingleMark3 As C1.Win.Gauge.C1GaugeSingleMark = New C1.Win.Gauge.C1GaugeSingleMark
        Dim C1GaugeEllipse1 As C1.Win.Gauge.C1GaugeEllipse = New C1.Win.Gauge.C1GaugeEllipse
        Dim C1GaugePointer1 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer2 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer3 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
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
        Me.timer1.Interval = 50
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
        Me.c1Gauge1.Location = New System.Drawing.Point(16, 21)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(359, 396)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(659045795142009005, Long)
        '
        'c1RadialGauge1
        '
        Me.c1RadialGauge1.Cap.Visible = False
        C1GaugeMarks1.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        C1GaugeMarks1.From = 0.5
        C1GaugeMarks1.Interval = 5
        C1GaugeMarks1.Length = 20
        C1GaugeMarks1.Location = 89
        C1GaugeMarks1.ScaleFrom = 0
        C1GaugeMarks1.ViewTag = CType(634302468273582893, Long)
        C1GaugeMarks1.Width = 6
        C1GaugeMarks2.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugeMarks2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks2.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks2.From = 0.5
        C1GaugeMarks2.Interval = 1
        C1GaugeMarks2.Length = 7
        C1GaugeMarks2.Location = 89
        C1GaugeMarks2.ScaleFrom = 0
        C1GaugeMarks2.ViewTag = CType(634583943250743575, Long)
        C1GaugeMarks2.Width = 2.7
        C1GaugeSingleMark1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeSingleMark1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark1.CustomShape.EndWidth = 9.5
        C1GaugeSingleMark1.CustomShape.StartWidth = 11
        C1GaugeSingleMark1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        C1GaugeSingleMark1.Length = 80
        C1GaugeSingleMark1.Location = -23
        C1GaugeSingleMark1.PointerIndex = 0
        C1GaugeSingleMark1.Shadow.Visible = True
        C1GaugeSingleMark1.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom
        C1GaugeSingleMark1.ViewTag = CType(649194152710971984, Long)
        C1GaugeSingleMark2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeSingleMark2.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark2.CustomShape.EndWidth = 7.8
        C1GaugeSingleMark2.CustomShape.StartWidth = 9.7
        C1GaugeSingleMark2.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        C1GaugeSingleMark2.Length = 104
        C1GaugeSingleMark2.Location = -21
        C1GaugeSingleMark2.PointerIndex = 1
        C1GaugeSingleMark2.Shadow.Visible = True
        C1GaugeSingleMark2.Shape = C1.Win.Gauge.C1GaugeMarkShape.Custom
        C1GaugeSingleMark2.ViewTag = CType(649475636021529278, Long)
        C1GaugeSingleMark3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeSingleMark3.Filling.Color = System.Drawing.Color.IndianRed
        C1GaugeSingleMark3.Length = 16
        C1GaugeSingleMark3.Location = 62
        C1GaugeSingleMark3.PointerIndex = 2
        C1GaugeSingleMark3.Shadow.Visible = True
        C1GaugeSingleMark3.Shape = C1.Win.Gauge.C1GaugeMarkShape.Round
        C1GaugeSingleMark3.ViewTag = CType(684378357605785544, Long)
        C1GaugeSingleMark3.Width = 16
        Me.c1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeMarks1, C1GaugeMarks2, C1GaugeSingleMark1, C1GaugeSingleMark2, C1GaugeSingleMark3})
        C1GaugeEllipse1.Border.Color = System.Drawing.Color.DarkGray
        C1GaugeEllipse1.Border.Thickness = 5
        C1GaugeEllipse1.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        C1GaugeEllipse1.Height = -0.97
        C1GaugeEllipse1.HitTestable = False
        C1GaugeEllipse1.Width = -0.97
        Me.c1RadialGauge1.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeEllipse1})
        Me.c1RadialGauge1.Maximum = 60
        C1GaugePointer1.Name = "hours"
        C1GaugePointer1.Value = 0.42
        C1GaugePointer1.ValueFactor = 5
        C1GaugePointer1.ViewTag = CType(635146893204754921, Long)
        C1GaugePointer1.Visible = False
        C1GaugePointer2.Name = "minutes"
        C1GaugePointer2.Value = 22.3
        C1GaugePointer2.ViewTag = CType(635428368181515579, Long)
        C1GaugePointer2.Visible = False
        C1GaugePointer3.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugePointer3.Filling.Color = System.Drawing.Color.IndianRed
        C1GaugePointer3.Name = "seconds"
        C1GaugePointer3.Offset = -30
        C1GaugePointer3.Shadow.Visible = True
        C1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle
        C1GaugePointer3.Value = 17
        C1GaugePointer3.ViewTag = CType(635709843158236236, Long)
        C1GaugePointer3.Width = 2.5
        Me.c1RadialGauge1.MorePointers.AddRange(New C1.Win.Gauge.C1GaugePointer() {C1GaugePointer1, C1GaugePointer2, C1GaugePointer3})
        Me.c1RadialGauge1.Name = "c1RadialGauge1"
        Me.c1RadialGauge1.Pointer.Visible = False
        Me.c1RadialGauge1.Radius = 0.5
        Me.c1RadialGauge1.StartAngle = 0
        Me.c1RadialGauge1.SweepAngle = 360
        Me.c1RadialGauge1.ViewTag = CType(636272793112967623, Long)
        '
        'PageSwissRailwayClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageSwissRailwayClock"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Friend WithEvents c1RadialGauge1 As C1.Win.Gauge.C1RadialGauge

End Class
