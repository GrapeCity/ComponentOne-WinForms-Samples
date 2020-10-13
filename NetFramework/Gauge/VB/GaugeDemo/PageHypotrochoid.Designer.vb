<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PageHypotrochoid
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
        Dim C1GaugePointer4 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer5 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Dim C1GaugePointer6 As C1.Win.C1Gauge.C1GaugePointer = New C1.Win.C1Gauge.C1GaugePointer
        Me.c1Gauge1 = New C1.Win.C1Gauge.C1Gauge
        Me.c1LinearGauge1 = New C1.Win.C1Gauge.C1LinearGauge
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
        Me.gaugeGrid.SelectedObject = Me.c1LinearGauge1
        '
        'c1Gauge1
        '
        Me.c1Gauge1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1Gauge1.Gauges.AddRange(New C1.Win.C1Gauge.C1GaugeBase() {Me.c1LinearGauge1})
        Me.c1Gauge1.Location = New System.Drawing.Point(3, 3)
        Me.c1Gauge1.Name = "c1Gauge1"
        Me.c1Gauge1.Size = New System.Drawing.Size(386, 430)
        Me.c1Gauge1.TabIndex = 1
        Me.c1Gauge1.ViewTag = CType(634310432362404793, Long)
        '
        'c1LinearGauge1
        '
        Me.c1LinearGauge1.AxisStart = 0
        Me.c1LinearGauge1.BaseFactor = -0.9
        Me.c1LinearGauge1.BaseOrigin = 0.95
        C1GaugePointer4.ViewTag = CType(644725104319914004, Long)
        C1GaugePointer4.Visible = False
        C1GaugePointer5.ViewTag = CType(645006579300514883, Long)
        C1GaugePointer5.Visible = False
        C1GaugePointer6.ViewTag = CType(648102824771747639, Long)
        C1GaugePointer6.Visible = False
        Me.c1LinearGauge1.MorePointers.AddRange(New C1.Win.C1Gauge.C1GaugePointer() {C1GaugePointer4, C1GaugePointer5, C1GaugePointer6})
        Me.c1LinearGauge1.Name = "c1LinearGauge1"
        Me.c1LinearGauge1.Pointer.Visible = False
        Me.c1LinearGauge1.Viewport.AspectRatio = 1
        Me.c1LinearGauge1.ViewTag = CType(634591907407259347, Long)
        '
        'PageCase10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Name = "PageCase10"
        Me.gaugePanel.ResumeLayout(False)
        Me.gridPanel.ResumeLayout(False)
        CType(Me.c1Gauge1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents c1Gauge1 As C1.Win.C1Gauge.C1Gauge
    Private WithEvents c1LinearGauge1 As C1.Win.C1Gauge.C1LinearGauge

End Class
