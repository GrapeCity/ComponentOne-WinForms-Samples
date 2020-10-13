
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
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
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.Size = New System.Drawing.Size(600, 400)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(600, 400)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.Name = "Form1"
      Me.Text = "Gantt Sample"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   ' Adds a new series to the Gantt chart accepting a task name,
   ' an array of starting times and an array of ending times.
   Private Sub AddGanttSeriesData(cdsc As ChartDataSeriesCollection, taskName As String, startTimes() As DateTime, endTimes() As DateTime)
      Dim cds As ChartDataSeries = cdsc.AddNewSeries()
      cds.Label = taskName
      cds.Y.CopyDataIn(startTimes)
      cds.Y1.CopyDataIn(endTimes)
   End Sub 'AddGanttSeriesData
   
   
   ' Add Chart Labels with beginning and ending dates for each data point
   ' in the Gantt chart.  Labels are placed inside on the western edge.
   Private Sub AddGanttTaskLabels(chart As C1Chart, cdsc As ChartDataSeriesCollection)
      Dim cl As ChartLabels = chart.ChartLabels
      cl.DefaultLabelStyle.BackColor = Color.Transparent
      cl.DefaultLabelStyle.GradientStyle = GradientStyleEnum.None
      cl.DefaultLabelStyle.ForeColor = Color.Azure
      cl.DefaultLabelStyle.HorizontalAlignment = AlignHorzEnum.Far
      
      Dim clc As C1.Win.C1Chart.LabelsCollection = cl.LabelsCollection
      clc.Clear()
      
      Dim slen As Integer = cdsc.Count
      Dim s As Integer
      For s = 0 To cdsc.Count - 1
         Dim cds As ChartDataSeries = cdsc(s)
         Dim p As Integer
         For p = 0 To cds.Length - 1
            Dim lab As C1.Win.C1Chart.Label = clc.AddNewLabel()
            Dim start As DateTime = CType(cds.Y(p), DateTime)
            Dim [end] As DateTime = CType(cds.Y1(p), DateTime)
            lab.Text = start.ToString("ddMMM") + "-" + [end].ToString("ddMMM")
            lab.AttachMethod = AttachMethodEnum.DataIndex
            lab.AttachMethodData.GroupIndex = 0
            lab.AttachMethodData.SeriesIndex = s
            lab.AttachMethodData.PointIndex = p
            lab.Compass = LabelCompassEnum.West
            lab.Offset = 0
            lab.Visible = True
         Next p
      Next s
   End Sub 'AddGanttTaskLabels
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' simplify the chart reference.
      Dim chart As C1Chart = c1Chart1
      
      ' Adjust the chart element styles
      '   Chart style.
      chart.Style.BackColor = Color.Navy
      chart.Style.BackColor2 = Color.Azure
      chart.Style.GradientStyle = GradientStyleEnum.FromCenter
      
      '   Chart Area style
      Dim area As Area = chart.ChartArea
      area.Style.BackColor = Color.Transparent
      area.Style.GradientStyle = GradientStyleEnum.None
      area.Inverted = True ' X axis is vertical
      '   Plot Area style
      area.PlotArea.BackColor = Color.Azure
      area.PlotArea.Boxed = True
      
      '   Set up the style and format of the Horizontal (Y) axis.
      Dim ax As Axis = area.AxisY
      ax.AnnoFormat = FormatEnum.DateManual
      ax.AnnoFormatString = "MMM-dd"
      ax.AnnotationRotation = - 30
      ax.Min = New DateTime(2004, 1, 1).ToOADate()
      ax.Max = New DateTime(2004, 4, 30).ToOADate()
      ax.Origin = ax.Min
      ax.Font = New Font("ArialBlack", 10, FontStyle.Bold)
      ax.UnitMajor = 14
      ax.TickMinor = TickMarksEnum.None
      ax.GridMajor.Pattern = LinePatternEnum.Dash
      ax.GridMajor.Color = Color.LightGray
      ax.GridMajor.Visible = True
      
      '   Set up the style and format of the Vertical (X) axis.
      ax = area.AxisX
      ax.TickMinor = TickMarksEnum.None
      ax.Reversed = True ' top to bottom
      ax.UnitMajor = 1
      ax.GridMinor.Pattern = LinePatternEnum.Dash
      ax.GridMinor.Color = Color.LightGray
      ax.GridMinor.Visible = True
      ax.GridMajor.Pattern = LinePatternEnum.Solid
      ax.GridMajor.Color = area.PlotArea.BackColor
      ax.GridMajor.Visible = True
      ax.Font = New Font("ArialBlack", 16, FontStyle.Bold)
      
      '   Specify the chart type as Gantt in the ChartGroup
      Dim cg As ChartGroup = chart.ChartGroups.Group0
      cg.ChartType = Chart2DTypeEnum.Gantt
      cg.Gantt.Width = 40
      
      '   Clear the existing data and add new Series data.
      Dim cdsc As ChartDataSeriesCollection = cg.ChartData.SeriesList
      cdsc.Clear()
      
      ' create a new series for each "row" of the Gantt chart.
      ' TASK ONE
      AddGanttSeriesData(cdsc, "Task One", New DateTime() {New DateTime(2004, 1, 1)}, New DateTime() {New DateTime(2004, 3, 9)})
      
      ' TASK TWO
      AddGanttSeriesData(cdsc, "Task Two", New DateTime() {New DateTime(2004, 1, 23)}, New DateTime() {New DateTime(2004, 2, 14)})
      
      ' TASK THREE
      AddGanttSeriesData(cdsc, "Task Three", New DateTime() {New DateTime(2004, 1, 21)}, New DateTime() {New DateTime(2004, 2, 24)})
      
      ' TASK FOUR
      AddGanttSeriesData(cdsc, "Task Four", New DateTime() {New DateTime(2004, 1, 22), New DateTime(2004, 2, 28)}, New DateTime() {New DateTime(2004, 2, 12), New DateTime(2004, 3, 24)})
      
      ' TASK FIVE
      AddGanttSeriesData(cdsc, "Task Five", New DateTime() {New DateTime(2004, 2, 13), New DateTime(2004, 3, 8)}, New DateTime() {New DateTime(2004, 3, 5), New DateTime(2004, 3, 31)})
      
      ' TASK SIX
      AddGanttSeriesData(cdsc, "Task Six", New DateTime() {New DateTime(2004, 3, 15)}, New DateTime() {New DateTime(2004, 4, 20)})
      
      ' TASK SEVEN
      AddGanttSeriesData(cdsc, "Task Seven", New DateTime() {New DateTime(2004, 4, 6)}, New DateTime() {New DateTime(2004, 4, 30)})
      
      ' Add task labels.
      AddGanttTaskLabels(chart, cdsc)
   End Sub 'Form1_Load
End Class 'Form1
