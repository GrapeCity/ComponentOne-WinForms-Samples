
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Management
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private panel1 As System.Windows.Forms.Panel
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private chartCpuHistory As C1.Win.C1Chart.C1Chart
   Private arrHistory As C1.Win.C1Chart.ChartDataArray
   WithEvents timer1 As System.Timers.Timer
   Private hits As Integer = 200
   Private left2right As Boolean = False
   Private performanceCounter1 As System.Diagnostics.PerformanceCounter
   Private groupBox2 As System.Windows.Forms.GroupBox
   Private chartCpuUsage As C1.Win.C1Chart.C1Chart
   Private pictureBox1 As System.Windows.Forms.PictureBox
   WithEvents button1 As System.Windows.Forms.Button
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
      
      InitChart()
      timer1.Enabled = True
   End Sub 'New
   
   
   '/ <summary>
   '/ Clean up any resources being used.
   '/ </summary>
   Protected Overloads Overrides Sub Dispose(disposing As Boolean) 
      If disposing Then
         If Not (components Is Nothing) Then
            components.Dispose()
         End If
      End If
      MyBase.Dispose(disposing)
   End Sub 'Dispose
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.chartCpuHistory = New C1.Win.C1Chart.C1Chart()
        Me.timer1 = New System.Timers.Timer()
        Me.performanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.chartCpuUsage = New C1.Win.C1Chart.C1Chart()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        CType(Me.chartCpuHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.performanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox2.SuspendLayout()
        CType(Me.chartCpuUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.button1)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(616, 56)
        Me.panel1.TabIndex = 2
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.button1.Location = New System.Drawing.Point(491, 10)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(104, 24)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Visit Web Site"
        Me.button1.UseVisualStyleBackColor = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(32, 3)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(143, 50)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox1.TabIndex = 0
        Me.pictureBox1.TabStop = False
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.chartCpuHistory)
        Me.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.groupBox1.Location = New System.Drawing.Point(144, 72)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(456, 248)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "CPU Usage History"
        '
        'chartCpuHistory
        '
        Me.chartCpuHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chartCpuHistory.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chartCpuHistory.Location = New System.Drawing.Point(3, 16)
        Me.chartCpuHistory.Name = "chartCpuHistory"
        Me.chartCpuHistory.PropBag = resources.GetString("chartCpuHistory.PropBag")
        Me.chartCpuHistory.Size = New System.Drawing.Size(450, 229)
        Me.chartCpuHistory.TabIndex = 0
        '
        'timer1
        '
        Me.timer1.Interval = 1000.0R
        Me.timer1.SynchronizingObject = Me
        '
        'performanceCounter1
        '
        Me.performanceCounter1.CategoryName = "Processor"
        Me.performanceCounter1.CounterName = "% Processor Time"
        Me.performanceCounter1.InstanceName = "_Total"
        '
        'groupBox2
        '
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me.chartCpuUsage)
        Me.groupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.groupBox2.Location = New System.Drawing.Point(16, 72)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(112, 248)
        Me.groupBox2.TabIndex = 4
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "CPU Usage"
        '
        'chartCpuUsage
        '
        Me.chartCpuUsage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartCpuUsage.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chartCpuUsage.Location = New System.Drawing.Point(16, 32)
        Me.chartCpuUsage.Name = "chartCpuUsage"
        Me.chartCpuUsage.PropBag = resources.GetString("chartCpuUsage.PropBag")
        Me.chartCpuUsage.Size = New System.Drawing.Size(80, 200)
        Me.chartCpuUsage.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 334)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.panel1)
        Me.MinimumSize = New System.Drawing.Size(450, 350)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "ComponentOne Chart for .NET Demo- CPU Usage"
        Me.TopMost = True
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.chartCpuHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.performanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox2.ResumeLayout(False)
        CType(Me.chartCpuUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent
    
#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New Form1())
   End Sub 'Main
   
   
   '/ <summary>
   '/ Set the CPU Usage
   '/ </summary>
   '/ <param name="lvalue"></param>
    Private Sub SetCpuUsage(lvalue As Single)
      If lvalue < 1 Then lvalue = 1
      chartCpuUsage.ChartArea.PlotArea.AlarmZones(0).UpperExtent = CInt(lvalue)
      chartCpuUsage.Footer.Text = CInt(lvalue).ToString() + "%"
    End Sub 'SetCpuUsage
   
   
   '/ <summary>
   '/ Initialize the Chart in code
   '/ </summary>
   Private Sub InitChart()
      groupBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      groupBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left 
      chartCpuUsage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right 
      '--Initalize the Cpu Usage Chart-----------------------------
      chartCpuUsage.BackColor = Color.Black
      
      Dim pa As C1.Win.C1Chart.PlotArea = chartCpuUsage.ChartArea.PlotArea
      pa.BackColor = Color.Black
      pa.BackColor2 = Color.Green
      pa.HatchStyle = C1.Win.C1Chart.HatchStyleEnum.DarkHorizontal
      
      ' Set up the X/Y axis
      Dim xa As C1.Win.C1Chart.Axis = chartCpuUsage.ChartArea.AxisX
      xa.AutoMax = False
      xa.AutoMin = False
      xa.AutoMajor = False
      xa.AutoMinor = False
      xa.Min = 0
      xa.Max = 100
      xa.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None
      xa.Thickness = 1
      xa.ForeColor = Color.Black
      
      Dim ya As C1.Win.C1Chart.Axis = chartCpuUsage.ChartArea.AxisY
      ya.AutoMax = False
      ya.AutoMin = False
      ya.AutoMajor = False
      ya.AutoMinor = False
      ya.Min = 0
      ya.Max = 100
      ya.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None
      ya.TickMajor = C1.Win.C1Chart.TickMarksEnum.None
      ya.TickMinor = C1.Win.C1Chart.TickMarksEnum.None
      ya.Thickness = 1
      ya.ForeColor = Color.Black
      ya.Compass = C1.Win.C1Chart.CompassEnum.East
      
      ' Add a alarm zone
      Dim almZone As C1.Win.C1Chart.AlarmZone = chartCpuUsage.ChartArea.PlotArea.AlarmZones.AddNewZone()
      almZone.BackColor = Color.Transparent
      almZone.ForeColor = Color.Lime
      almZone.PatternStyle = System.Drawing.Drawing2D.HatchStyle.DarkHorizontal
      almZone.PatternVisible = True
      almZone.LowerExtent = 0
      almZone.FarExtent = 100
      almZone.NearExtent = - 100
      almZone.UpperExtent = 0
      almZone.Visible = True
      
      ' Hide the header and legend
      chartCpuUsage.Header.Visible = False
      chartCpuUsage.Legend.Visible = False
      
      ' Set up the footer
      chartCpuUsage.Footer.Style.ForeColor = Color.Lime
      chartCpuUsage.Footer.Text = "25%"
      chartCpuUsage.Footer.Visible = True
      
      ' Set up the dummy data
      chartCpuUsage.ChartGroups(0).ChartData.SeriesList.RemoveAll()
      Dim series As C1.Win.C1Chart.ChartDataSeries = chartCpuUsage.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      series.PointData.Length = 1
      series.PointData(0) = New PointF(- 1, - 1)
      
      '--Initalize the Cpu History Chart-----------------------------
      chartCpuHistory.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot
      Dim caStyle As C1.Win.C1Chart.Style = chartCpuHistory.ChartArea.Style
      caStyle.BackColor = Color.BurlyWood
      caStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid
      caStyle.Border.Color = SystemColors.AppWorkspace
      caStyle.Border.Thickness = 2
      
      Dim plArea As C1.Win.C1Chart.PlotArea = chartCpuHistory.ChartArea.PlotArea
      plArea.BackColor = Color.Black
      plArea.ForeColor = Color.Green
      plArea.Boxed = True
      
      ' Set up the X Axis
      xa = chartCpuHistory.ChartArea.AxisX
      xa.ForeColor = Color.Green
      xa.Min = 0
      xa.Max = hits
      xa.TickMajor = C1.Win.C1Chart.TickMarksEnum.None
      xa.TickMinor = C1.Win.C1Chart.TickMarksEnum.None
      xa.TickLabels = C1.Win.C1Chart.TickLabelsEnum.None
      xa.Compass = C1.Win.C1Chart.CompassEnum.North
      xa.AutoMax = False
      xa.AutoMin = False
      xa.AutoMajor = False
      xa.AutoMinor = False
      xa.UnitMinor = 5
      xa.UnitMajor = 10
      xa.Thickness = 1
      xa.GridMajor.AutoSpace = True
      xa.GridMajor.Color = Color.Green
      xa.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      xa.GridMajor.Visible = True
      xa.GridMinor.AutoSpace = True
      xa.GridMinor.Color = Color.Green
      xa.GridMinor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      xa.GridMinor.Visible = True
      xa.Reversed = Not left2right
      
      
      ' Set up the Y Axis
      ya = chartCpuHistory.ChartArea.AxisY
      ya.ForeColor = Color.Green
      ya.Min = 0
      ya.Max = 1
      ya.TickMajor = C1.Win.C1Chart.TickMarksEnum.None
      ya.TickMinor = C1.Win.C1Chart.TickMarksEnum.None
      ya.AutoMax = False
      xa.AutoMin = False
      xa.AutoMajor = False
      xa.AutoMinor = False
      ya.UnitMinor = 0.05
      ya.UnitMajor = 0.1
      ya.Thickness = 1
      ya.AnnoFormat = C1.Win.C1Chart.FormatEnum.NumericManual
      ya.AnnoFormatString = "#0%"
      ya.GridMajor.AutoSpace = True
      ya.GridMajor.Color = Color.Green
      ya.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      ya.GridMajor.Visible = True
      ya.GridMinor.AutoSpace = True
      ya.GridMinor.Color = Color.Green
      ya.GridMinor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      ya.GridMinor.Visible = True
      
      ' Hide Header and Footer
      chartCpuHistory.Header.Visible = False
      chartCpuHistory.Footer.Visible = False
      
      ' Initialize the series
      chartCpuHistory.ChartGroups(0).ChartData.SeriesList.RemoveAll()
      series = chartCpuHistory.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      series.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None
      series.LineStyle.Color = Color.LawnGreen
      arrHistory = series.PointData
   End Sub 'InitChart
   
   
   '/ <summary>
   '/ Shift the PointData inorder to simulate a right to left plot drawing
   '/ </summary>
   '/ <param name="arr"></param>
   Private Sub ShiftRight(arr As ChartDataArray)
      Dim i As Integer
      For i = arr.Length - 2 To 0 Step -1
         Dim p As PointF = CType(arr(i), PointF)
         p.X += 1
         arr((i + 1)) = p
      Next i
   End Sub 'ShiftRight
   
   
   Private Sub timer1_Elapsed(sender As Object, e As System.Timers.ElapsedEventArgs) Handles timer1.Elapsed
      ' Stop the timer to prevent re-entrancy
      timer1.Stop()
      
      Dim lValue As Single = CSng(performanceCounter1.NextValue())
      
      ' Set data to the Cpu Usage Chart
      SetCpuUsage(lValue)
      
      ' Set data to the Cpu History Chart
      If left2right Then
         arrHistory.Length += 1
         
         ' Reach the max
         If arrHistory.Length >= hits + 1 Then
            arrHistory.Length = 0
            arrHistory.Length += 1
         End If
         
         arrHistory((arrHistory.Length - 1)) = New PointF(arrHistory.Length - 1, lValue / 100)
      Else
         If arrHistory.Length <= hits + 1 Then
            arrHistory.Length += 1
         End If 
         ShiftRight(arrHistory)
         arrHistory(0) = New PointF(0, lValue / 100)
      End If
      
      ' Start the timer
      timer1.Start()
   End Sub 'timer1_Elapsed
   
   
   Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles button1.Click
      System.Diagnostics.Process.Start("http://www.grapecity.com")
   End Sub 'button1_Click
End Class 'Form1
