
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
      Me.c1Chart1.Location = New System.Drawing.Point(16, 16)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Max=""5"" Min=""1"" UnitM" + "ajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMi" + "n=""True"" _onTop=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Co" + "lor=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2" + """ UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" " + "_onTop=""0"" Compass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Light" + "Gray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGra" + "y"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor" + "=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" " + "Compass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patte" + "rn=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=" + """Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text /></Header><ChartGr" + "oupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</" + "Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</Stacked><H" + "iLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Sho" + "wOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>EncodingMethod=Diamete" + "r,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer Defaul" + "tSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y>20;22;19;24;25</Y><Li" + "neStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape" + "=""Box"" Color=""Coral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sing" + "le;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSerie" + "sSerializer><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" C" + "olor=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue" + """ /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Si" + "ngle</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSe" + "riesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" P" + "attern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series" + " 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" + "X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesSerializer><Y>16;19" + ";15;22;18</Y><LineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><Symbo" + "lStyle Shape=""Diamond"" Color=""Crimson"" /><SeriesLabel>series 3</SeriesLabel><Dat" + "aTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /" + "><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><ShowOutli" + "ne>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Pie>OtherOffset" + "=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=" + "True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>Fal" + "se</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Show" + "Close=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Encoding" + "Method=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name><DataSer" + "ializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" + "Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><StyleC" + "ollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName><StyleDa" + "ta>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Legend</Name" + "><ParentName>Legend.default</ParentName><StyleData /></NamedStyle><NamedStyle><N" + "ame>Footer</Name><ParentName>Control</ParentName><StyleData>Border=None,Control," + "1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default" + "</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Name><ParentNa" + "me>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>AxisX" + "</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Cont" + "rol,1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData></Name" + "dStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rot" + "ation=Rotate270;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Align" + "Vert=Center;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><" + "ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><Name" + "dStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData>Bor" + "der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><" + "Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleData>" + "Border=None,Control,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" + "><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Contr" + "ol,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</S" + "tyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNam" + "e><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor" + "=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.de" + "fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" + "gnVert=Top;</StyleData></NamedStyle></StyleCollection><Footer Compass=""South""><T" + "ext /></Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartAre" + "a /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(552, 288)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 373)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Alarm Zone Chart Demo"
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
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' Size the form to fit any screen
      Me.ClientSize = New Size(600, 400)
      
      ' Center the form
      Me.CenterToParent()
      
      ' Fill the form client area with the chart
      c1Chart1.Dock = DockStyle.Fill
      
      ' Get the data arrays and data.
      Dim StudentScores As Integer() = Me.GetStudentPointTotals()
      Dim StudentNumbers As Integer() = CType(Array.CreateInstance(GetType(Integer), StudentScores.Length), Integer())
      Dim nStudents As Integer = StudentScores.Length
      Dim i As Integer
      For i = 0 To nStudents - 1
         StudentNumbers(i) = i
      Next i 
      ' Get the statistics
      Dim mean As Double = FindMean(StudentScores)
      Dim stddev As Double = FindStdDev(StudentScores, mean)
      
      ' Set up the header
      c1Chart1.Header.Text = "Student Scores and Grades"
      c1Chart1.Header.Style.Font = New Font("Tahoma", 18, FontStyle.Bold)
      
      ' Set the background color
      c1Chart1.Style.BackColor = Color.FromArgb(128, 192, 150)
      
      ' Clear the existing data
      c1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()
      
      ' Add the data
      Dim data As ChartData = c1Chart1.ChartGroups(0).ChartData
      Dim series As ChartDataSeriesCollection = data.SeriesList
      
      'plot the student scores
      Dim StuSeries As ChartDataSeries = series.AddNewSeries()
      StuSeries.Label = "raw scores"
      StuSeries.LineStyle.Pattern = LinePatternEnum.None
      StuSeries.LineStyle.Color = c1Chart1.Style.BackColor
      StuSeries.SymbolStyle.Shape = SymbolShapeEnum.Star
      StuSeries.SymbolStyle.Color = Color.DarkRed
      StuSeries.X.CopyDataIn(StudentNumbers)
      StuSeries.Y.CopyDataIn(StudentScores)
      StuSeries = Nothing
      
      ' mean + 2 s
      Dim LinePatterns() As LinePatternEnum = {LinePatternEnum.Dash, LinePatternEnum.DashDot, LinePatternEnum.Solid, LinePatternEnum.DashDotDot, LinePatternEnum.Dot}
      For i = 2 To - 2 Step -1
         Dim StatSeries As ChartDataSeries = series.AddNewSeries()
         Dim xd() As Double = {0, nStudents}
         Dim yd() As Double = {mean + i * stddev, mean + i * stddev}
         
         StatSeries.X.CopyDataIn(xd)
         StatSeries.Y.CopyDataIn(yd)
         StatSeries.SymbolStyle.Shape = SymbolShapeEnum.None
         StatSeries.LineStyle.Pattern = LinePatterns((i + 2))
         StatSeries.LineStyle.Color = Color.Black
         StatSeries.LineStyle.Thickness = 1
         
         If i > 0 Then
            StatSeries.Label = "m+" + i.ToString() + "s"
         ElseIf i < 0 Then
            StatSeries.Label = "m" + i.ToString() + "s"
         Else
            StatSeries.Label = "mean"
            StatSeries.LineStyle.Thickness = 2
            StatSeries.LineStyle.Pattern = LinePatternEnum.Solid
         End If
      Next i
      
      ' box the plot area
      c1Chart1.ChartArea.PlotArea.Boxed = True
      
      ' Show the legend
      c1Chart1.Legend.Visible = True
      
      ' Set the Axis titles
      c1Chart1.ChartArea.AxisX.Text = "Student Number"
      c1Chart1.ChartArea.AxisY.Text = "Student Accumulated Points"
      
      ' sort the student scores so they can be analyzed		
      Array.Sort(StudentScores)
      
      ' Define each of the letter grades
      Dim GradeLetter() As String = New [String]() {"A", "B", "C", "D", "F"}
      
      ' Get the bounds of each letter grade
      ' At most 95% of the students will not get an A
      ' At most 75% of the students will not get a B or higher
      ' At most 25% of the students will not get a C or higher
      ' At most 5% of the students will not get a D or higher
      Dim GradeBounds() As Integer = {StudentScores(GetBoundingIndex(StudentScores, 0.95)), StudentScores(GetBoundingIndex(StudentScores, 0.75)), StudentScores(GetBoundingIndex(StudentScores, 0.25)), StudentScores(GetBoundingIndex(StudentScores, 0.05))}
      
      ' get the color codes for each grade
      Dim GradeColor() As Color = {Color.FromArgb(128, 128, 225), Color.FromArgb(128, 255, 128), Color.FromArgb(255, 228, 128), Color.FromArgb(55, 228, 228), Color.FromArgb(255, 192, 192)}
      
      ' Add the chart labels.  They will be positioned later
      Dim labels As ChartLabels = c1Chart1.ChartLabels
      labels.DefaultLabelStyle.BackColor = c1Chart1.Style.BackColor
      labels.DefaultLabelStyle.Font = New Font("Courier New", 16, FontStyle.Bold)
      
      Dim lab As C1.Win.C1Chart.Label = Nothing
      For i = 0 To 4
         lab = labels.LabelsCollection.AddNewLabel()
         lab.Text = GradeLetter(i)
         lab.Style.BackColor = GradeColor(i)
         lab.AttachMethod = AttachMethodEnum.Coordinate
         lab.Visible = True
      Next i
      
      ' Below are calculations and settings that depend upon auto
      ' positioning of the chart.  The auto positions are only
      ' calculated during rendering of the chart.  Force the
      ' chart to be rendered so the chart element positions are
      ' calculated.
      ' Force calculation of chart element positions
      c1Chart1.GetImage()
      
      ' Add and show the alarm zones
      Dim zones As AlarmZonesCollection = c1Chart1.ChartArea.PlotArea.AlarmZones
      For i = 0 To 4
         Dim zone As AlarmZone = zones.AddNewZone()
         
         zone.Name = GradeLetter(i)
         zone.BackColor = GradeColor(i)
         
         If i = 0 Then
            zone.UpperExtent = c1Chart1.ChartArea.AxisY.Max
         Else
            zone.UpperExtent = zones((i - 1)).LowerExtent
         End If 
         If i = 4 Then
            zone.LowerExtent = c1Chart1.ChartArea.AxisY.Min
         Else
            zone.LowerExtent = GradeBounds(i)
         End If 
         zone.Visible = True
      Next i
      
      PositionLegends()
   End Sub 'Form1_Load
   
   Private Sub PositionLegends()
      ' reposition the legend and labels
      Dim labels As C1.Win.C1Chart.ChartLabels = c1Chart1.ChartLabels
      If labels Is Nothing OrElse labels.LabelsCollection.Count < 5 Then
         Return
      End If 
      c1Chart1.GetImage()
      
      Dim plota As PlotArea = c1Chart1.ChartArea.PlotArea
      Dim leg As Legend = c1Chart1.Legend
      
      ' get left alignment with the legend, and
      ' center about the plot area centerline
      Dim labP As Point = leg.Location
      labP.Y = plota.Location.Y + plota.Size.Height / 2
      
      ' get the height of the labels and legend
      Dim labHeight As Integer = labels(0).Size.Height
      Dim h As Integer = labHeight * 5 + leg.Size.Height
      labP.Y -= h / 2
      
      Dim i As Integer
      For i = 0 To 4
         Dim lab As C1.Win.C1Chart.Label = labels(i)
         lab.AttachMethodData.X = labP.X
         lab.AttachMethodData.Y = labP.Y
         labP.Y += labHeight
      Next i
      
      leg.LocationDefault = New Point(- 1, labP.Y)
   End Sub 'PositionLegends
   
   
   Private Function GetStudentPointTotals() As Integer()
      'populates the array with ficticious student scores for the demo
      Const nStudents As Integer = 300
      Const nMaxPoints As Integer = 1600
      
      Dim scores As Integer() = CType(Array.CreateInstance(GetType(Integer), nStudents), Integer())
      Dim rnd As New System.Random()
      Dim i As Integer
      For i = 0 To nStudents - 1
         scores(i) = nMaxPoints / 2 + rnd.Next((nMaxPoints / 2))
      Next i
      Return scores
   End Function 'GetStudentPointTotals
   
   
   Private Function FindMean(arr() As Integer) As Double
      'calculates the mean of an all inclusive group of integers
      Dim sum As Double = 0
      Dim i As Integer
      For i = 0 To arr.Length - 1
         sum = sum + arr(i)
      Next i
      Return sum / arr.Length
   End Function 'FindMean
   
   
   Private Function FindStdDev(arr() As Integer, mean As Double) As Double
      'calculates the standard deviation of an all inclusive group of integers
      Dim sum As Double = 0
      Dim temp As Double = 0
      Dim i As Integer
      For i = 0 To arr.Length - 1
         temp = arr(i) - mean
         sum = sum + temp * temp
      Next i
      Return Math.Sqrt((sum / arr.Length))
   End Function 'FindStdDev
   
   
   Private Function GetBoundingIndex(scores() As Integer, frac As Double) As Integer
      ' Assumes scores are sorted, then obtains the
      ' index of the first scores() element below
      ' the specified percentile fraction
      Dim n As Integer = scores.Length
      Dim i As Integer = CInt(n * frac)
      
      While i > scores(0) AndAlso scores(i) = scores((i + 1))
         i -= 1
      End While 
      Return i
   End Function 'GetBoundingIndex
   
   
   Private Sub c1Chart1_Resize(sender As Object, e As System.EventArgs) Handles c1Chart1.Resize
      Me.PositionLegends()
   End Sub 'c1Chart1_Resize
End Class 'Form1
