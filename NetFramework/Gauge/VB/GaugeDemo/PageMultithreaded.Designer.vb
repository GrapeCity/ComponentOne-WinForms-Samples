<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageMultithreaded
    Inherits BaseGaugePage

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim C1GaugeMarks3 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeMarks4 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeLabels2 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels
        Dim C1GaugeSingleLabel6 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel7 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeRange2 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeSingleLabel8 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel9 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel10 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleMark2 As C1.Win.C1Gauge.C1GaugeSingleMark = New C1.Win.C1Gauge.C1GaugeSingleMark
        Dim C1GaugeRectangle2 As C1.Win.C1Gauge.C1GaugeRectangle = New C1.Win.C1Gauge.C1GaugeRectangle
        Dim C1GaugePointer3 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer4 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Me.button3 = New System.Windows.Forms.Button
        Me.button2 = New System.Windows.Forms.Button
        Me.button1 = New System.Windows.Forms.Button
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.C1Gauge.C1LinearGauge
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.button3)
        Me.gaugePanel.Controls.Add(Me.button2)
        Me.gaugePanel.Controls.Add(Me.button1)
        Me.gaugePanel.Controls.Add(Me.c1Gauge1)
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.c1LinearGauge1
        '
        'button3
        '
        Me.button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button3.Location = New System.Drawing.Point(221, 398)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(153, 23)
        Me.button3.TabIndex = 7
        Me.button3.Text = "Start Thread 3 (max)"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.Location = New System.Drawing.Point(221, 369)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(153, 23)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Start Thread 2 (min)"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.Location = New System.Drawing.Point(221, 340)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(153, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Start Thread 1 (value)"
        Me.button1.UseVisualStyleBackColor = True
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1LinearGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(8, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(376, 330)
        Me.c1Gauge1.TabIndex = 4
        Me.c1Gauge1.ViewTag = CType(636563101699690835, Long)
        '
        'c1LinearGauge1
        '
        C1GaugeMarks3.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks3.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks3.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks3.Interval = 10
        C1GaugeMarks3.Length = 10
        C1GaugeMarks3.Location = 50
        C1GaugeMarks3.ViewTag = CType(678503004323206706, Long)
        C1GaugeMarks3.Width = 1
        C1GaugeMarks4.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks4.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks4.Filling.Color = System.Drawing.Color.Black
        C1GaugeMarks4.Interval = 2.5
        C1GaugeMarks4.Length = 6
        C1GaugeMarks4.Location = 50
        C1GaugeMarks4.ViewTag = CType(674843755455865891, Long)
        C1GaugeMarks4.Width = 1
        C1GaugeLabels2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeLabels2.FontSize = 6
        C1GaugeLabels2.Interval = 10
        C1GaugeLabels2.ViewTag = CType(675125231244322976, Long)
        C1GaugeSingleLabel6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel6.FontSize = 7
        C1GaugeSingleLabel6.Location = 95
        C1GaugeSingleLabel6.PointerIndex = 100
        C1GaugeSingleLabel6.Position = 0.5
        C1GaugeSingleLabel6.Text = "Value is below Minimum"
        C1GaugeSingleLabel6.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeSingleLabel6.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.CornflowerBlue, 1, CType(673717850602170323, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 0, System.Drawing.Color.White, 0, CType(673999326115721684, Long))})
        C1GaugeSingleLabel6.ViewTag = CType(673154898766071328, Long)
        C1GaugeSingleLabel7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel7.FontSize = 7
        C1GaugeSingleLabel7.Location = 95
        C1GaugeSingleLabel7.PointerIndex = 100
        C1GaugeSingleLabel7.Position = 0.5
        C1GaugeSingleLabel7.Text = "Value is above Maximum"
        C1GaugeSingleLabel7.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeSingleLabel7.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.White, 0, CType(674280801592380936, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 1, System.Drawing.Color.IndianRed, 1, CType(674562276824086177, Long))})
        C1GaugeSingleLabel7.ViewTag = CType(673436374572339432, Long)
        C1GaugeRange2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRange2.Location = 24
        C1GaugeRange2.ValueColorFalloff = C1.Win.C1Gauge.C1GaugeValueColorFalloff.None
        C1GaugeRange2.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(0, -1, System.Drawing.Color.CornflowerBlue, 1, CType(675688185048714551, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 0, System.Drawing.Color.LimeGreen, 1, CType(675969660391416140, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 1, System.Drawing.Color.IndianRed, 1, CType(676251135433310524, Long))})
        C1GaugeRange2.ViewTag = CType(675406709646489557, Long)
        C1GaugeSingleLabel8.Color = System.Drawing.Color.White
        C1GaugeSingleLabel8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel8.FontSize = 7
        C1GaugeSingleLabel8.Format = """value = ""0"
        C1GaugeSingleLabel8.ImmediateUpdate = True
        C1GaugeSingleLabel8.Location = 7
        C1GaugeSingleLabel8.PointerIndex = 100
        C1GaugeSingleLabel8.Position = 0.5
        C1GaugeSingleLabel8.ViewTag = CType(676532625544886845, Long)
        C1GaugeSingleLabel9.Color = System.Drawing.Color.White
        C1GaugeSingleLabel9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel9.FontSize = 7
        C1GaugeSingleLabel9.Format = """min = ""0"
        C1GaugeSingleLabel9.ImmediateUpdate = True
        C1GaugeSingleLabel9.Location = 7
        C1GaugeSingleLabel9.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeSingleLabel9.PointerIndex = 0
        C1GaugeSingleLabel9.Position = 0
        C1GaugeSingleLabel9.ViewTag = CType(676814100673526191, Long)
        C1GaugeSingleLabel10.Color = System.Drawing.Color.White
        C1GaugeSingleLabel10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel10.FontSize = 7
        C1GaugeSingleLabel10.Format = """max = ""0"
        C1GaugeSingleLabel10.ImmediateUpdate = True
        C1GaugeSingleLabel10.Location = 7
        C1GaugeSingleLabel10.OrthogonalAlignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        C1GaugeSingleLabel10.PointerIndex = 1
        C1GaugeSingleLabel10.Position = 1
        C1GaugeSingleLabel10.ViewTag = CType(677095575673368170, Long)
        C1GaugeSingleMark2.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeSingleMark2.Border.Color = System.Drawing.Color.Black
        C1GaugeSingleMark2.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.RadialOuter
        C1GaugeSingleMark2.Length = 15
        C1GaugeSingleMark2.Location = 33
        C1GaugeSingleMark2.PointerIndex = 100
        C1GaugeSingleMark2.Shape = C1.Win.C1Gauge.C1GaugeMarkShape.Triangle
        C1GaugeSingleMark2.ValueColors.AddRange(New C1.Win.C1Gauge.C1GaugeValueColor() {New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 0, System.Drawing.Color.CornflowerBlue, 1, CType(677658542811202374, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(50, -1, System.Drawing.Color.White, 1, CType(677940017979483988, Long)), New C1.Win.C1Gauge.C1GaugeValueColor(Double.NaN, 1, System.Drawing.Color.IndianRed, 1, CType(678221493208209058, Long))})
        C1GaugeSingleMark2.ViewTag = CType(677377064084777247, Long)
        C1GaugeSingleMark2.Width = 9
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeMarks3, C1GaugeMarks4, C1GaugeLabels2, C1GaugeSingleLabel6, C1GaugeSingleLabel7, C1GaugeRange2, C1GaugeSingleLabel8, C1GaugeSingleLabel9, C1GaugeSingleLabel10, C1GaugeSingleMark2})
        C1GaugeRectangle2.Border.LineStyle = C1.Win.C1Gauge.C1GaugeBorderStyle.None
        C1GaugeRectangle2.CornerRadius = 10
        C1GaugeRectangle2.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.Gradient
        C1GaugeRectangle2.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        C1GaugeRectangle2.Filling.Color2 = System.Drawing.Color.White
        C1GaugeRectangle2.Gradient.Direction = C1.Win.C1Gauge.C1GaugeGradientDirection.Vertical
        C1GaugeRectangle2.Gradient.Falloff = C1.Win.C1Gauge.C1GaugeGradientFalloff.SigmaBell
        C1GaugeRectangle2.Height = -1.1
        C1GaugeRectangle2.Width = -1.1
        Me.c1LinearGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeRectangle2})
        C1GaugePointer3.Filling.Color = System.Drawing.Color.CornflowerBlue
        C1GaugePointer3.FlipShape = True
        C1GaugePointer3.Length = 15
        C1GaugePointer3.Name = "min"
        C1GaugePointer3.Offset = 70
        C1GaugePointer3.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle
        C1GaugePointer3.SweepTime = 6
        C1GaugePointer3.Value = 40
        C1GaugePointer3.ViewTag = CType(640222285677810199, Long)
        C1GaugePointer4.Filling.Color = System.Drawing.Color.IndianRed
        C1GaugePointer4.FlipShape = True
        C1GaugePointer4.Length = 15
        C1GaugePointer4.Name = "max"
        C1GaugePointer4.Offset = 70
        C1GaugePointer4.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Triangle
        C1GaugePointer4.SweepTime = 6
        C1GaugePointer4.Value = 60
        C1GaugePointer4.ViewTag = CType(640503760658591088, Long)
        Me.c1LinearGauge1.MorePointers.AddRange(New C1.Win.C1Gauge.C1GaugePointer() {C1GaugePointer3, C1GaugePointer4})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Pointer.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.[In]
        Me.c1LinearGauge1.Pointer.Border.Color = System.Drawing.Color.Black
        Me.c1LinearGauge1.Pointer.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.None
        Me.c1LinearGauge1.Pointer.Length = 15
        Me.c1LinearGauge1.Pointer.Offset = 33
        Me.c1LinearGauge1.Pointer.Shape = C1.Win.C1Gauge.C1GaugePointerShape.Rectangle
        Me.c1LinearGauge1.Pointer.SweepTime = 6
        Me.c1LinearGauge1.Pointer.Value = 50
        Me.c1LinearGauge1.Pointer.Width = 0.01
        Me.c1LinearGauge1.Viewport.AspectRatio = 1.6
        Me.c1LinearGauge1.ViewTag = CType(636844576723984213, Long)
        '
        'PageCase12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase12"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents button3 As System.Windows.Forms.Button
    Private WithEvents button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.C1Gauge.C1LinearGauge

End Class
