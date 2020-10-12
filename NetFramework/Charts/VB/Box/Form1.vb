
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
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuFile As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelp As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private grpInputs As System.Windows.Forms.GroupBox
   Private lblPointCount As System.Windows.Forms.Label
   WithEvents txtPointCount As System.Windows.Forms.TextBox
   WithEvents buttonGenerate As System.Windows.Forms.Button
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
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuFile = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuHelp = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.grpInputs = New System.Windows.Forms.GroupBox()
      Me.buttonGenerate = New System.Windows.Forms.Button()
      Me.txtPointCount = New System.Windows.Forms.TextBox()
      Me.lblPointCount = New System.Windows.Forms.Label()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.grpInputs.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, menuHelp})
      ' 
      ' menuFile
      ' 
      Me.menuFile.Index = 0
      Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      Me.menuFile.Text = "File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "Exit"
      ' 
      ' menuHelp
      ' 
      Me.menuHelp.Index = 1
      Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuHelp.Text = "Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "About"
      ' 
      ' grpInputs
      ' 
      Me.grpInputs.Controls.AddRange(New System.Windows.Forms.Control() {Me.buttonGenerate, txtPointCount, lblPointCount})
      Me.grpInputs.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpInputs.Name = "grpInputs"
      Me.grpInputs.Size = New System.Drawing.Size(328, 48)
      Me.grpInputs.TabIndex = 0
      Me.grpInputs.TabStop = False
      ' 
      ' buttonGenerate
      ' 
      Me.buttonGenerate.Location = New System.Drawing.Point(208, 16)
      Me.buttonGenerate.Name = "buttonGenerate"
      Me.buttonGenerate.Size = New System.Drawing.Size(104, 24)
      Me.buttonGenerate.TabIndex = 2
      Me.buttonGenerate.Text = "Regenerate Data"
      ' 
      ' txtPointCount
      ' 
      Me.txtPointCount.Location = New System.Drawing.Point(128, 16)
      Me.txtPointCount.Name = "txtPointCount"
      Me.txtPointCount.Size = New System.Drawing.Size(32, 20)
      Me.txtPointCount.TabIndex = 1
      Me.txtPointCount.Text = "5"
      ' 
      ' lblPointCount
      ' 
      Me.lblPointCount.Location = New System.Drawing.Point(8, 18)
      Me.lblPointCount.Name = "lblPointCount"
      Me.lblPointCount.Size = New System.Drawing.Size(120, 16)
      Me.lblPointCount.TabIndex = 0
      Me.lblPointCount.Text = "Number of data points:"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Location = New System.Drawing.Point(8, 56)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Max=""5"" Min=""1"" UnitM" + "ajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMi" + "n=""True"" _onTop=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Co" + "lor=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2" + """ UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" " + "_onTop=""0"" Compass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Light" + "Gray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGra" + "y"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor" + "=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" " + "Compass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patte" + "rn=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=" + """Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text /></Header><ChartGr" + "oupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</" + "Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</Stacked><H" + "iLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Sho" + "wOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>EncodingMethod=Diamete" + "r,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer Defaul" + "tSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y>20;22;19;24;25</Y><Li" + "neStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape" + "=""Box"" Color=""Coral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sing" + "le;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSerie" + "sSerializer><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" C" + "olor=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue" + """ /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Si" + "ngle</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSe" + "riesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" P" + "attern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series" + " 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" + "X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesSerializer><Y>16;19" + ";15;22;18</Y><LineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><Symbo" + "lStyle Shape=""Diamond"" Color=""Crimson"" /><SeriesLabel>series 3</SeriesLabel><Dat" + "aTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /" + "><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><ShowOutli" + "ne>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Pie>OtherOffset" + "=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=" + "True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>Fal" + "se</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Show" + "Close=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Encoding" + "Method=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name><DataSer" + "ializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" + "Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><StyleC" + "ollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName><StyleDa" + "ta>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Legend</Name" + "><ParentName>Legend.default</ParentName><StyleData /></NamedStyle><NamedStyle><N" + "ame>Footer</Name><ParentName>Control</ParentName><StyleData>Border=None,Control," + "1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default" + "</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Name><ParentNa" + "me>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>AxisX" + "</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Cont" + "rol,1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData></Name" + "dStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rot" + "ation=Rotate270;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Align" + "Vert=Center;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><" + "ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><Name" + "dStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData>Bor" + "der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><" + "Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleData>" + "Border=None,Control,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" + "><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Contr" + "ol,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</S" + "tyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNam" + "e><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor" + "=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.de" + "fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" + "gnVert=Top;</StyleData></NamedStyle></StyleCollection><Footer Compass=""South""><T" + "ext /></Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartAre" + "a /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(488, 312)
      Me.c1Chart1.TabIndex = 1
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(512, 381)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, grpInputs})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Box and Whisker Chart Demo"
      Me.grpInputs.ResumeLayout(False)
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
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Me.Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub txtPointCount_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtPointCount.KeyPress
      ' only allow numbers to be entered.
      If e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c OrElse e.KeyChar = ControlChars.Back Then
         Return
      End If 
      e.Handled = True
   End Sub 'txtPointCount_KeyPress
   
   
   Private Sub buttonGenerate_Click(sender As Object, e As System.EventArgs) Handles buttonGenerate.Click
      Me.GenerateSomeData()
      Me.LoadChartData()
   End Sub 'buttonGenerate_Click
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' center the form
      Me.CenterToParent()
      
      ' setup the chart.
      c1Chart1.Top = grpInputs.Bottom + 1
      c1Chart1.Left = 0
      c1Chart1.Size = New Size(Me.ClientSize.Width, ClientSize.Height - c1Chart1.Top)
      c1Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      c1Chart1.Style.BackColor = Color.LightGray
      c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.Groove
      c1Chart1.Style.Border.Thickness = 2
      
      ' setup the area
      Dim area As Area = c1Chart1.ChartArea
      area.Style.BackColor = Color.Wheat
      area.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel
      area.Style.Border.Thickness = 4
      area.PlotArea.BackColor = Color.BlanchedAlmond
      area.PlotArea.Boxed = True
      area.Inverted = True
      
      ' setup the header
      Dim hdr As Title = c1Chart1.Header
      hdr.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel
      hdr.Style.Border.Thickness = 4
      hdr.Text = "Box-and-Whisker Plot"
      hdr.Style.Font = New Font("Arial", 14)
      
      ' setup the groups
      c1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Candle
      c1Chart1.ChartGroups(1).ChartType = Chart2DTypeEnum.XYPlot
      
      ' fix the bounds of the Y and Y2 axes, always 0 to 100
      area.AxisY.Min = 0F
      area.AxisY.Max = 100F
      area.AxisY2.Min = 0F
      area.AxisY2.Max = 100F
      area.AxisY2.Visible = False
      
      GenerateSomeData()
      LoadChartData()
   End Sub 'Form1_Load
   
   
   ' use an array of arrays so each sub array can be sorted
   '   float [5 values per point] [# of points] ChartValues  (reduced data)
   Private ChartValues As Single()() = Nothing
   
   
   Private Function NumberOfPoints() As Integer
      Try
         Return Integer.Parse(txtPointCount.Text)
      Catch
         Return 0
      End Try
   End Function 'NumberOfPoints
    
   Private Sub GenerateSomeData()
      Dim i As Integer = 0
      Dim n As Integer = 0
      
      ' use an array of arrays so each sub array can be sorted
      '   float [# of points] [15 values per point] DataSets     (raw data)
      Const valuesPerPoint As Integer = 15
      Dim DataSets As Single()() = Nothing
      
      Dim nPoints As Integer = NumberOfPoints()
      If nPoints = 0 Then
         Return
      End If 
      ' build the outer array.
      DataSets = CType(Array.CreateInstance(GetType(Single()), nPoints), Single()())
      
      ' fill each element of the outer array with an inner array,
      ' each with 15 elements containing random float data.  Sort each
      ' inner array.
      For n = 0 To nPoints - 1
         ' for each element of the outer array
         Dim r As New Random(DateTime.Now.Millisecond - n)
         
         Dim inner As Single() = CType(Array.CreateInstance(GetType(Single), valuesPerPoint), Single())
         For i = 0 To valuesPerPoint - 1
            inner(i) = CSng(100.0 * r.NextDouble())
         Next i 
         Array.Sort(inner)
         DataSets(n) = inner
      Next n
      
      
      ' now create the reduced data, which includes high, low, median and
      ' upper and lower quartiles for each inner array (data point).
      ChartValues = CType(Array.CreateInstance(GetType(Single()), 5), Single()())
      For i = 0 To 4
         ChartValues(i) = CType(Array.CreateInstance(GetType(Single), nPoints), Single())
      Next i 
      ' fill all the array elements.  note that the inner arrays contain
      ' lows, highs, median, lower quartile and upper quartile, respectively.
      ' This allows each array to be copied into the chart at once.
      For n = 0 To nPoints - 1
         ChartValues(0)(n) = DataSets(n)(0) ' lowest values
         ChartValues(1)(n) = DataSets(n)((valuesPerPoint - 1)) ' highest values
         ChartValues(2)(n) = DataSets(n)(8) ' median values
         ChartValues(3)(n) = DataSets(n)(4) ' lower quartiles
         ChartValues(4)(n) = DataSets(n)(12) ' upper quartiles
      Next n
   End Sub 'GenerateSomeData
   
   
   Private Sub LoadChartData()
      Dim n As Integer = 0
      Dim nPoints As Integer = NumberOfPoints()
      
      ' the first chart group will handle the "candle" part of Box and Whisker
      Dim grp0 As ChartGroup = c1Chart1.ChartGroups(0)
      grp0.ChartData.SeriesList.Clear()
      
      ' the second group will handle the remaining elements of the Box and Whisker
      Dim grp1 As ChartGroup = c1Chart1.ChartGroups(1)
      grp1.ChartData.SeriesList.Clear()
      
      If nPoints = 0 Then
         Return
      End If 
      ' all the x values are the same, and for convenience simply
      ' indicate the number of the data points.
      Dim xvals As Integer() = CType(Array.CreateInstance(GetType(Integer), nPoints), Integer())
      For n = 0 To nPoints - 1
         xvals(n) = n + 1
      Next n 
      Dim cds As ChartDataSeries = grp0.ChartData.SeriesList.AddNewSeries()
      cds.X.CopyDataIn(xvals)
      cds.Y.CopyDataIn(ChartValues(1)) ' high values
      cds.Y1.CopyDataIn(ChartValues(0)) ' low values
      cds.Y2.CopyDataIn(ChartValues(3)) ' open values	(lower quartile)
      cds.Y3.CopyDataIn(ChartValues(4)) ' close values are high, making candle hollow
      cds.SymbolStyle.Size = 16
      cds.LineStyle.Color = Color.Purple
      cds.LineStyle.Thickness = 2
      
      ' now plot the Low, High and Median values in the
      ' second chart group.  Use consistent symbols and color, no lines.
      cds = grp1.ChartData.SeriesList.AddNewSeries()
      cds.X.CopyDataIn(xvals)
      cds.Y.CopyDataIn(ChartValues(0))
      cds.LineStyle.Pattern = LinePatternEnum.None
      cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine
      cds.SymbolStyle.Size = 16
      cds.SymbolStyle.Color = Color.Purple
      
      cds = grp1.ChartData.SeriesList.AddNewSeries()
      cds.X.CopyDataIn(xvals)
      cds.Y.CopyDataIn(ChartValues(1))
      cds.LineStyle.Pattern = LinePatternEnum.None
      cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine
      cds.SymbolStyle.Size = 16
      cds.SymbolStyle.Color = Color.Purple
      
      cds = grp1.ChartData.SeriesList.AddNewSeries()
      cds.X.CopyDataIn(xvals)
      cds.Y.CopyDataIn(ChartValues(2))
      cds.LineStyle.Pattern = LinePatternEnum.None
      cds.SymbolStyle.Shape = SymbolShapeEnum.VerticalLine
      cds.SymbolStyle.Size = 16
      cds.SymbolStyle.Color = Color.Purple
   End Sub 'LoadChartData
End Class 'Form1
