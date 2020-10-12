<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageDataBound
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
        Dim C1GaugeLabels4 As C1.Win.C1Gauge.C1GaugeLabels = New C1.Win.C1Gauge.C1GaugeLabels
        Dim C1GaugeMarks4 As C1.Win.C1Gauge.C1GaugeMarks = New C1.Win.C1Gauge.C1GaugeMarks
        Dim C1GaugeRange10 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeRange11 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeRange12 As C1.Win.C1Gauge.C1GaugeRange = New C1.Win.C1Gauge.C1GaugeRange
        Dim C1GaugeSingleLabel10 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel11 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeSingleLabel12 As C1.Win.C1Gauge.C1GaugeSingleLabel = New C1.Win.C1Gauge.C1GaugeSingleLabel
        Dim C1GaugeCaption13 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption
        Dim C1GaugeCaption14 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption
        Dim C1GaugeCaption15 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption
        Dim C1GaugeCaption16 As C1.Win.C1Gauge.C1GaugeCaption = New C1.Win.C1Gauge.C1GaugeCaption
        Dim C1GaugePointer7 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer8 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.C1Gauge.C1LinearGauge
        Me.label1 = New System.Windows.Forms.Label
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.gaugePanel.SuspendLayout()
        Me.gridPanel.SuspendLayout()
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugePanel
        '
        Me.gaugePanel.Controls.Add(Me.c1Gauge1)
        Me.gaugePanel.Controls.Add(Me.label1)
        Me.gaugePanel.Controls.Add(Me.dataGridView1)
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
        Me.c1Gauge1.Location = New System.Drawing.Point(9, 225)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(371, 204)
        Me.c1Gauge1.TabIndex = 5
        Me.c1Gauge1.ViewTag = CType(634314462784886300, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisStart = 0.04
        Me.c1LinearGauge1.BaseOrigin = 0.07
        C1GaugeLabels4.FontSize = 7
        C1GaugeLabels4.Interval = 25
        C1GaugeLabels4.Location = 0
        C1GaugeLabels4.ViewTag = CType(641069907430065399, Long)
        C1GaugeMarks4.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeMarks4.Border.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeMarks4.Filling.BrushType = C1.Win.C1Gauge.C1GaugeBrushType.None
        C1GaugeMarks4.Interval = 25
        C1GaugeMarks4.Length = 95
        C1GaugeMarks4.Location = 5
        C1GaugeMarks4.ViewTag = CType(643884661361599274, Long)
        C1GaugeMarks4.Width = 0.01
        C1GaugeRange10.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeRange10.Border.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeRange10.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        C1GaugeRange10.Location = 15
        C1GaugeRange10.ToPointerIndex = 100
        C1GaugeRange10.ViewTag = CType(638536618060574778, Long)
        C1GaugeRange10.Width = 20
        C1GaugeRange11.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeRange11.Border.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeRange11.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        C1GaugeRange11.ToPointerIndex = 0
        C1GaugeRange11.ViewTag = CType(639099568095428233, Long)
        C1GaugeRange11.Width = 20
        C1GaugeRange12.Alignment = C1.Win.C1Gauge.C1GaugeAlignment.Out
        C1GaugeRange12.Border.Color = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        C1GaugeRange12.Filling.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        C1GaugeRange12.Location = 75
        C1GaugeRange12.ToPointerIndex = 1
        C1GaugeRange12.ViewTag = CType(638818093102181548, Long)
        C1GaugeRange12.Width = 20
        C1GaugeSingleLabel10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel10.Location = 27
        C1GaugeSingleLabel10.PointerIndex = 100
        C1GaugeSingleLabel10.Position = -0.15
        C1GaugeSingleLabel10.TextAngle = -30
        C1GaugeSingleLabel10.ViewTag = CType(655425141749395310, Long)
        C1GaugeSingleLabel11.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel11.Location = 57
        C1GaugeSingleLabel11.PointerIndex = 0
        C1GaugeSingleLabel11.Position = -0.15
        C1GaugeSingleLabel11.TextAngle = -30
        C1GaugeSingleLabel11.ViewTag = CType(655988093219139285, Long)
        C1GaugeSingleLabel12.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeSingleLabel12.Location = 87
        C1GaugeSingleLabel12.PointerIndex = 1
        C1GaugeSingleLabel12.Position = -0.15
        C1GaugeSingleLabel12.TextAngle = -30
        C1GaugeSingleLabel12.ViewTag = CType(655706618222616595, Long)
        Me.c1LinearGauge1.Decorators.AddRange(New C1.Win.C1Gauge.C1GaugeDecorator() {C1GaugeLabels4, C1GaugeMarks4, C1GaugeRange10, C1GaugeRange11, C1GaugeRange12, C1GaugeSingleLabel10, C1GaugeSingleLabel11, C1GaugeSingleLabel12})
        C1GaugeCaption13.CenterPointY = 0.2
        C1GaugeCaption13.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeCaption13.RotateAngle = -30
        C1GaugeCaption13.Text = "UnitsInStock"
        C1GaugeCaption13.Viewport.MarginX = -100
        C1GaugeCaption13.Viewport.TranslateX = -0.04
        C1GaugeCaption13.Viewport.Width = 100
        C1GaugeCaption14.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeCaption14.RotateAngle = -30
        C1GaugeCaption14.Text = "ReorderLevel"
        C1GaugeCaption14.Viewport.MarginX = -100
        C1GaugeCaption14.Viewport.TranslateX = -0.04
        C1GaugeCaption14.Viewport.Width = 100
        C1GaugeCaption15.CenterPointY = 0.8
        C1GaugeCaption15.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeCaption15.RotateAngle = -30
        C1GaugeCaption15.Text = "UnitsOnOrder"
        C1GaugeCaption15.Viewport.MarginX = -100
        C1GaugeCaption15.Viewport.TranslateX = -0.04
        C1GaugeCaption15.Viewport.Width = 100
        C1GaugeCaption16.CenterPointX = 0.8
        C1GaugeCaption16.CenterPointY = 1.07
        C1GaugeCaption16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        C1GaugeCaption16.Text = "fixed viewport size"
        Me.c1LinearGauge1.FaceShapes.AddRange(New C1.Win.C1Gauge.C1GaugeBaseShape() {C1GaugeCaption13, C1GaugeCaption14, C1GaugeCaption15, C1GaugeCaption16})
        Me.c1LinearGauge1.Maximum = 125
        C1GaugePointer7.ViewTag = CType(635440368798580392, Long)
        C1GaugePointer7.Visible = False
        C1GaugePointer8.ViewTag = CType(635158893673981477, Long)
        C1GaugePointer8.Visible = False
        Me.c1LinearGauge1.MorePointers.AddRange(New C1.Win.C1Gauge.C1GaugePointer() {C1GaugePointer7, C1GaugePointer8})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Pointer.Visible = False
        Me.c1LinearGauge1.Viewport.Height = -200
        Me.c1LinearGauge1.Viewport.Width = -270
        Me.c1LinearGauge1.Viewport.X = -270
        Me.c1LinearGauge1.Viewport.Y = -200
        Me.c1LinearGauge1.ViewTag = CType(634595937804029030, Long)
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(7, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(53, 13)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Products:"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(10, 21)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(371, 198)
        Me.dataGridView1.TabIndex = 3
        '
        'PageDataBound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageDataBound"
        Me.gaugePanel.ResumeLayout(False)
        Me.gaugePanel.PerformLayout()
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.C1Gauge.C1LinearGauge
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView

End Class
