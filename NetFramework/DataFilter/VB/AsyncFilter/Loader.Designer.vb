<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loader
    Inherits System.Windows.Forms.UserControl

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
        Me.components = New System.ComponentModel.Container()
        Dim C1GaugeRange3 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange()
        Dim C1GaugeRange4 As C1.Win.Gauge.C1GaugeRange = New C1.Win.Gauge.C1GaugeRange()
        Dim C1GaugeSingleLabel2 As C1.Win.Gauge.C1GaugeSingleLabel = New C1.Win.Gauge.C1GaugeSingleLabel()
        Me.C1Gauge1 = New C1.Win.Gauge.C1Gauge()
        Me.C1RadialGauge1 = New C1.Win.Gauge.C1RadialGauge()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Gauge1
        '
        Me.C1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Gauge1.Gauges.AddRange(New C1.Win.Gauge.C1GaugeBase() {Me.C1RadialGauge1})
        Me.C1Gauge1.Location = New System.Drawing.Point(0, 0)
        Me.C1Gauge1.Name = "C1Gauge1"
        Me.C1Gauge1.Size = New System.Drawing.Size(820, 543)
        Me.C1Gauge1.TabIndex = 0
        Me.C1Gauge1.Viewport.AspectRatio = 0.5R
        Me.C1Gauge1.ViewTag = CType(637017942564074529, Long)
        '
        'C1RadialGauge1
        '
        Me.C1RadialGauge1.Cap.Border.Color = System.Drawing.Color.Black
        Me.C1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.Black
        Me.C1RadialGauge1.Cap.Radius = 2.5R
        Me.C1RadialGauge1.Cap.Visible = False
        C1GaugeRange3.Border.Color = System.Drawing.Color.Transparent
        C1GaugeRange3.Filling.Color = System.Drawing.Color.Silver
        C1GaugeRange3.FromPointerIndex = 100
        C1GaugeRange3.Location = 60.0R
        C1GaugeRange3.ViewTag = CType(640162063073460990, Long)
        C1GaugeRange3.Width = 22.0R
        C1GaugeRange4.Border.Color = System.Drawing.Color.Transparent
        C1GaugeRange4.Filling.Color = System.Drawing.Color.SteelBlue
        C1GaugeRange4.Location = 60.0R
        C1GaugeRange4.Name = "Before"
        C1GaugeRange4.ToPointerIndex = 100
        C1GaugeRange4.ViewTag = CType(640443538688254004, Long)
        C1GaugeRange4.Width = 22.0R
        C1GaugeSingleLabel2.Angle = 0R
        C1GaugeSingleLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        C1GaugeSingleLabel2.Location = 0R
        C1GaugeSingleLabel2.PointerIndex = 100
        C1GaugeSingleLabel2.Text = "Loading..."
        C1GaugeSingleLabel2.ViewTag = CType(642976825261498990, Long)
        Me.C1RadialGauge1.Decorators.AddRange(New C1.Win.Gauge.C1GaugeDecorator() {C1GaugeRange3, C1GaugeRange4, C1GaugeSingleLabel2})
        Me.C1RadialGauge1.Name = "C1RadialGauge1"
        Me.C1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Black
        Me.C1RadialGauge1.Pointer.CustomShape.EndWidth = 0.15R
        Me.C1RadialGauge1.Pointer.CustomShape.StartWidth = 1.0R
        Me.C1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black
        Me.C1RadialGauge1.Pointer.Length = 64.0R
        Me.C1RadialGauge1.Pointer.Offset = 0R
        Me.C1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom
        Me.C1RadialGauge1.Pointer.Visible = False
        Me.C1RadialGauge1.Radius = 0.6R
        Me.C1RadialGauge1.StartAngle = -90.0R
        Me.C1RadialGauge1.SweepAngle = 360.0R
        Me.C1RadialGauge1.Viewport.AspectRatio = 0.5R
        Me.C1RadialGauge1.ViewTag = CType(639317637171740509, Long)
        '
        'Timer1
        '
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.C1Gauge1)
        Me.Name = "Loader"
        Me.Size = New System.Drawing.Size(820, 543)
        CType(Me.C1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents C1Gauge1 As C1.Win.Gauge.C1Gauge
    Friend WithEvents C1RadialGauge1 As C1.Win.Gauge.C1RadialGauge
    Friend WithEvents Timer1 As Timer
End Class
