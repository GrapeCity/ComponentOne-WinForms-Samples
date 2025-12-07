<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageRuler
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PageRuler))
        Dim CommonBorder1 As C1.Win.Gauge.CommonBorder = New C1.Win.Gauge.CommonBorder
        Dim CommonBorder2 As C1.Win.Gauge.CommonBorder = New C1.Win.Gauge.CommonBorder
        Dim CommonBorder3 As C1.Win.Gauge.CommonBorder = New C1.Win.Gauge.CommonBorder
        Dim CommonFilling1 As C1.Win.Gauge.CommonFilling = New C1.Win.Gauge.CommonFilling
        Dim CommonFilling2 As C1.Win.Gauge.CommonFilling = New C1.Win.Gauge.CommonFilling
        Dim CommonFilling3 As C1.Win.Gauge.CommonFilling = New C1.Win.Gauge.CommonFilling
        Dim CommonShape1 As C1.Win.Gauge.CommonShape = New C1.Win.Gauge.CommonShape
        Dim C1GaugeRange1 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeLabels1 As C1.Win.Gauge.C1GaugeLabels = New C1.Win.Gauge.C1GaugeLabels
        Dim C1GaugeMarks1 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks2 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeMarks3 As C1.Win.Gauge.C1GaugeMarks = New C1.Win.Gauge.C1GaugeMarks
        Dim C1GaugeRange2 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange
        Dim C1GaugeRectangle1 As C1.Win.Gauge.C1GaugeRectangle = New C1.Win.Gauge.C1GaugeRectangle
        Dim C1GaugePointer1 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer2 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer3 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer4 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Dim C1GaugePointer5 As C1.Win.Gauge.C1GaugePointer = New C1.Win.Gauge.C1GaugePointer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox
        Me.c1Gauge1 = New C1.Win.Gauge.C1Gauge
        Me.rulerGauge = New C1.Win.Gauge.C1LinearGauge
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.Panel1)
        '
        'gaugeGrid
        '
        Me.gaugeGrid.SelectedObject = Me.rulerGauge
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.c1Gauge1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(391, 436)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.richTextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8, 0, 8, 8)
        Me.Panel2.Size = New System.Drawing.Size(389, 401)
        Me.Panel2.TabIndex = 3
        '
        'richTextBox1
        '
        Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.richTextBox1.Location = New System.Drawing.Point(8, 0)
        Me.richTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.RightMargin = 320
        Me.richTextBox1.ShowSelectionMargin = True
        Me.richTextBox1.Size = New System.Drawing.Size(373, 393)
        Me.richTextBox1.TabIndex = 2
        Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
        Me.richTextBox1.WordWrap = False
        '
        'c1Gauge1
        '
        Me.c1Gauge1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Top
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.rulerGauge})
        Me.c1Gauge1.Location = New System.Drawing.Point(1, 1)
        Me.c1Gauge1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(389, 33)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(634807802611695961, Long)
        '
        'rulerGauge
        '
        Me.rulerGauge.AxisLength = 1
        Me.rulerGauge.AxisStart = 0
        Me.rulerGauge.BaseFactor = 1
        Me.rulerGauge.BaseOrigin = 0
        CommonBorder1.Color = System.Drawing.Color.DimGray
        CommonBorder1.Name = "Normal"
        CommonBorder2.Color = System.Drawing.Color.IndianRed
        CommonBorder2.Name = "Hot"
        CommonBorder3.Color = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(143, Byte), Integer))
        CommonBorder3.Name = "Outer"
        Me.rulerGauge.CommonBorders.AddRange(New C1.Win.Gauge.CommonBorder() {CommonBorder1, CommonBorder2, CommonBorder3})
        CommonFilling1.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        CommonFilling1.Color = System.Drawing.Color.Gray
        CommonFilling1.Color2 = System.Drawing.Color.White
        CommonFilling1.Name = "Normal"
        CommonFilling2.BrushType = C1.Win.Gauge.C1GaugeBrushType.Gradient
        CommonFilling2.Color = System.Drawing.Color.LightCoral
        CommonFilling2.Color2 = System.Drawing.Color.White
        CommonFilling2.Name = "Hot"
        CommonFilling3.Color = System.Drawing.Color.Black
        CommonFilling3.Name = "Outer"
        CommonFilling3.Opacity = 0.1
        Me.rulerGauge.CommonFillings.AddRange(New C1.Win.Gauge.CommonFilling() {CommonFilling1, CommonFilling2, CommonFilling3})
        CommonShape1.EndAngle = 45
        CommonShape1.EndWidth = 50
        CommonShape1.Name = "SimplePointer"
        CommonShape1.StartWidth = 50
        Me.rulerGauge.CommonShapes.AddRange(New C1.Win.Gauge.CommonShape() {CommonShape1})
        C1GaugeRange1.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeRange1.Border.CommonBorderName = "Outer"
        C1GaugeRange1.Filling.CommonFillingName = "Outer"
        C1GaugeRange1.HitTestable = False
        C1GaugeRange1.Location = 0
        C1GaugeRange1.To = 0
        C1GaugeRange1.ViewTag = CType(658173190335200112, Long)
        C1GaugeRange1.Width = 100
        C1GaugeLabels1.Color = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(94, Byte), Integer))
        C1GaugeLabels1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        C1GaugeLabels1.From = 40
        C1GaugeLabels1.Interval = 40
        C1GaugeLabels1.Location = 52
        C1GaugeLabels1.ValueFactor = 0.025
        C1GaugeLabels1.ViewTag = CType(688832955907896122, Long)
        C1GaugeMarks1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugeMarks1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        C1GaugeMarks1.HitTestable = False
        C1GaugeMarks1.Interval = 40
        C1GaugeMarks1.ScaleFrom = 0
        C1GaugeMarks1.ViewTag = CType(689395905861317434, Long)
        C1GaugeMarks2.Border.Color = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(94, Byte), Integer))
        C1GaugeMarks2.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        C1GaugeMarks2.HitTestable = False
        C1GaugeMarks2.Interval = 20
        C1GaugeMarks2.Length = 40
        C1GaugeMarks2.Location = 50
        C1GaugeMarks2.ScaleFrom = 0
        C1GaugeMarks2.ViewTag = CType(664362727045719722, Long)
        C1GaugeMarks2.Width = 0.1
        C1GaugeMarks3.Border.Color = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(94, Byte), Integer))
        C1GaugeMarks3.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        C1GaugeMarks3.HitTestable = False
        C1GaugeMarks3.Interval = 10
        C1GaugeMarks3.Length = 16
        C1GaugeMarks3.Location = 50
        C1GaugeMarks3.ScaleFrom = 0
        C1GaugeMarks3.ViewTag = CType(664644205730878892, Long)
        C1GaugeMarks3.Width = 0.1
        C1GaugeRange2.Alignment = C1.Win.Gauge.C1GaugeAlignment.Out
        C1GaugeRange2.Border.CommonBorderName = "Outer"
        C1GaugeRange2.Filling.CommonFillingName = "Outer"
        C1GaugeRange2.FromPointerIndex = 0
        C1GaugeRange2.HitTestable = False
        C1GaugeRange2.Location = 0
        C1GaugeRange2.ViewTag = CType(653385666070406411, Long)
        C1GaugeRange2.Width = 100
        Me.rulerGauge.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeRange1, C1GaugeLabels1, C1GaugeMarks1, C1GaugeMarks2, C1GaugeMarks3, C1GaugeRange2})
        C1GaugeRectangle1.Border.Color = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(143, Byte), Integer))
        C1GaugeRectangle1.Filling.Color = System.Drawing.Color.White
        C1GaugeRectangle1.HitTestable = False
        Me.rulerGauge.FaceShapes.AddRange(New C1.Win.Gauge.C1GaugeBaseShape() {C1GaugeRectangle1})
        Me.rulerGauge.Maximum = 365
        Me.rulerGauge.Minimum = -8
        C1GaugePointer1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None
        C1GaugePointer1.Filling.BrushType = C1.Win.Gauge.C1GaugeBrushType.None
        C1GaugePointer1.Length = 100
        C1GaugePointer1.Name = "RightMargin"
        C1GaugePointer1.Offset = 0
        C1GaugePointer1.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle
        C1GaugePointer1.Value = 320
        C1GaugePointer1.ViewTag = CType(657044864145362080, Long)
        C1GaugePointer1.Width = 30
        C1GaugePointer2.Border.CommonBorderName = "Normal"
        C1GaugePointer2.Filling.CommonFillingName = "Normal"
        C1GaugePointer2.Length = 36
        C1GaugePointer2.Name = "LeftIndent"
        C1GaugePointer2.Offset = 100
        C1GaugePointer2.Shape = C1.Win.Gauge.C1GaugePointerShape.Rectangle
        C1GaugePointer2.ViewTag = CType(637341394413943775, Long)
        C1GaugePointer2.Width = 56
        C1GaugePointer3.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugePointer3.Border.CommonBorderName = "Normal"
        C1GaugePointer3.CustomShape.CommonShapeName = "SimplePointer"
        C1GaugePointer3.CustomShape.EndWidth = 56
        C1GaugePointer3.CustomShape.StartWidth = 56
        C1GaugePointer3.Filling.CommonFillingName = "Normal"
        C1GaugePointer3.FlipShape = True
        C1GaugePointer3.Length = 50
        C1GaugePointer3.Name = "HangingIndent"
        C1GaugePointer3.Offset = 100
        C1GaugePointer3.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        C1GaugePointer3.ViewTag = CType(664925685614266166, Long)
        C1GaugePointer4.Border.CommonBorderName = "Normal"
        C1GaugePointer4.CustomShape.CommonShapeName = "SimplePointer"
        C1GaugePointer4.CustomShape.EndWidth = 56
        C1GaugePointer4.CustomShape.StartWidth = 56
        C1GaugePointer4.Filling.CommonFillingName = "Normal"
        C1GaugePointer4.Length = 50
        C1GaugePointer4.Name = "FirstLineIndent"
        C1GaugePointer4.Offset = -20
        C1GaugePointer4.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        C1GaugePointer4.ViewTag = CType(637622871569666258, Long)
        C1GaugePointer5.Alignment = C1.Win.Gauge.C1GaugeAlignment.[In]
        C1GaugePointer5.Border.CommonBorderName = "Normal"
        C1GaugePointer5.CustomShape.CommonShapeName = "SimplePointer"
        C1GaugePointer5.CustomShape.EndWidth = 56
        C1GaugePointer5.CustomShape.StartWidth = 56
        C1GaugePointer5.Filling.CommonFillingName = "Normal"
        C1GaugePointer5.FlipShape = True
        C1GaugePointer5.Length = 50
        C1GaugePointer5.Name = "RightIndent"
        C1GaugePointer5.Offset = 100
        C1GaugePointer5.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        C1GaugePointer5.Value = 320
        C1GaugePointer5.ViewTag = CType(665207218141115929, Long)
        Me.rulerGauge.MorePointers.AddRange(New C1.Win.Gauge.C1GaugePointer() {C1GaugePointer1, C1GaugePointer2, C1GaugePointer3, C1GaugePointer4, C1GaugePointer5})
        Me.rulerGauge.Name = "rulerGauge"
        Me.rulerGauge.Pointer.Visible = False
        Me.rulerGauge.Viewport.Height = 16
        Me.rulerGauge.Viewport.MarginX = 8
        Me.rulerGauge.Viewport.MarginY = 6
        Me.rulerGauge.ViewTag = CType(688270005954464810, Long)
        '
        'PageRuler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "PageRuler"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents richTextBox1 As System.Windows.Forms.RichTextBox
    Private WithEvents c1Gauge1 As C1.Win.Gauge.C1Gauge
    Private WithEvents rulerGauge As C1.Win.Gauge.C1LinearGauge
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
