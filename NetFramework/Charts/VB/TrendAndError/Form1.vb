
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
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   Private mainMenu1 As System.Windows.Forms.MainMenu
   Private statusBar1 As System.Windows.Forms.StatusBar
   WithEvents trendChart As C1.Win.C1Chart.C1Chart
   WithEvents miView As System.Windows.Forms.MenuItem
   WithEvents miError As System.Windows.Forms.MenuItem
   WithEvents miErrScatter As System.Windows.Forms.MenuItem
   WithEvents miErrBar As System.Windows.Forms.MenuItem
   WithEvents miTrend As System.Windows.Forms.MenuItem
   WithEvents miTrend2 As System.Windows.Forms.MenuItem
   WithEvents miTrend3 As System.Windows.Forms.MenuItem
   WithEvents miTrend4 As System.Windows.Forms.MenuItem
   WithEvents miTrend5 As System.Windows.Forms.MenuItem
   WithEvents miTrend6 As System.Windows.Forms.MenuItem
   WithEvents miNewData As System.Windows.Forms.MenuItem
   Private menuItem5 As System.Windows.Forms.MenuItem
   WithEvents miExit As System.Windows.Forms.MenuItem
   WithEvents miHelp As System.Windows.Forms.MenuItem
   WithEvents miAbout As System.Windows.Forms.MenuItem
   WithEvents miFile As System.Windows.Forms.MenuItem
   WithEvents errChart As C1.Win.C1Chart.C1Chart
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
      InitializeComponent()
   End Sub 'New
    
   '
   ' TODO: Add any constructor code after InitializeComponent call
   '
   
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
      Me.miFile = New System.Windows.Forms.MenuItem()
      Me.miNewData = New System.Windows.Forms.MenuItem()
      Me.menuItem5 = New System.Windows.Forms.MenuItem()
      Me.miExit = New System.Windows.Forms.MenuItem()
      Me.miView = New System.Windows.Forms.MenuItem()
      Me.miError = New System.Windows.Forms.MenuItem()
      Me.miErrBar = New System.Windows.Forms.MenuItem()
      Me.miErrScatter = New System.Windows.Forms.MenuItem()
      Me.miTrend = New System.Windows.Forms.MenuItem()
      Me.miTrend2 = New System.Windows.Forms.MenuItem()
      Me.miTrend3 = New System.Windows.Forms.MenuItem()
      Me.miTrend4 = New System.Windows.Forms.MenuItem()
      Me.miTrend5 = New System.Windows.Forms.MenuItem()
      Me.miTrend6 = New System.Windows.Forms.MenuItem()
      Me.miHelp = New System.Windows.Forms.MenuItem()
      Me.miAbout = New System.Windows.Forms.MenuItem()
      Me.statusBar1 = New System.Windows.Forms.StatusBar()
      Me.errChart = New C1.Win.C1Chart.C1Chart()
      Me.trendChart = New C1.Win.C1Chart.C1Chart()
      CType(Me.errChart, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.trendChart, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, miView, miHelp})
      ' 
      ' miFile
      ' 
      Me.miFile.Index = 0
      Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewData, menuItem5, miExit})
      Me.miFile.Text = "&File"
      ' 
      ' miNewData
      ' 
      Me.miNewData.Index = 0
      Me.miNewData.Text = "&New data"
      ' 
      ' menuItem5
      ' 
      Me.menuItem5.Index = 1
      Me.menuItem5.Text = "-"
      ' 
      ' miExit
      ' 
      Me.miExit.Index = 2
      Me.miExit.Text = "E&xit"
      ' 
      ' miView
      ' 
      Me.miView.Index = 1
      Me.miView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miError, miTrend})
      Me.miView.Text = "&View"
      ' 
      ' miError
      ' 
      Me.miError.Index = 0
      Me.miError.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miErrBar, miErrScatter})
      Me.miError.Text = "Errors"
      ' 
      ' miErrBar
      ' 
      Me.miErrBar.Index = 0
      Me.miErrBar.RadioCheck = True
      Me.miErrBar.Text = "Bar"
      ' 
      ' miErrScatter
      ' 
      Me.miErrScatter.Checked = True
      Me.miErrScatter.Index = 1
      Me.miErrScatter.RadioCheck = True
      Me.miErrScatter.Text = "Scatter"
      ' 
      ' miTrend
      ' 
      Me.miTrend.Index = 1
      Me.miTrend.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miTrend2, miTrend3, miTrend4, miTrend5, miTrend6})
      Me.miTrend.Text = "Trend"
      ' 
      ' miTrend2
      ' 
      Me.miTrend2.Checked = True
      Me.miTrend2.Index = 0
      Me.miTrend2.RadioCheck = True
      Me.miTrend2.Text = "Linear"
      ' 
      ' miTrend3
      ' 
      Me.miTrend3.Index = 1
      Me.miTrend3.RadioCheck = True
      Me.miTrend3.Text = "Quadratic"
      ' 
      ' miTrend4
      ' 
      Me.miTrend4.Index = 2
      Me.miTrend4.RadioCheck = True
      Me.miTrend4.Text = "Cubic"
      ' 
      ' miTrend5
      ' 
      Me.miTrend5.Index = 3
      Me.miTrend5.RadioCheck = True
      Me.miTrend5.Text = "4-order"
      ' 
      ' miTrend6
      ' 
      Me.miTrend6.Index = 4
      Me.miTrend6.RadioCheck = True
      Me.miTrend6.Text = "5-order"
      ' 
      ' miHelp
      ' 
      Me.miHelp.Index = 2
      Me.miHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAbout})
      Me.miHelp.Text = "&Help"
      ' 
      ' miAbout
      ' 
      Me.miAbout.Index = 0
      Me.miAbout.Text = "&About"
      ' 
      ' statusBar1
      ' 
      Me.statusBar1.Location = New System.Drawing.Point(0, 411)
      Me.statusBar1.Name = "statusBar1"
      Me.statusBar1.Size = New System.Drawing.Size(632, 22)
      Me.statusBar1.TabIndex = 0
      Me.statusBar1.Text = "Drag points on the top chart"
      ' 
      ' errChart
      ' 
      Me.errChart.DataSource = Nothing
      Me.errChart.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.errChart.Location = New System.Drawing.Point(0, 243)
      Me.errChart.Name = "errChart"
      Me.errChart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area""><StyleData>Border=Solid,ControlText,1;BackColor=Wh" + "ite;</StyleData></NamedStyle><NamedStyle Name=""Legend"" ParentName=""Legend.defaul" + "t""><StyleData /></NamedStyle><NamedStyle Name=""Footer"" ParentName=""Control""><Sty" + "leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=""Area"" Pare" + "ntName=""Area.default""><StyleData /></NamedStyle><NamedStyle Name=""Control"" Paren" + "tName=""Control.default""><StyleData>Border=Solid,Transparent,1;BackColor=Control;" + "</StyleData></NamedStyle><NamedStyle Name=""AxisX"" ParentName=""Area""><StyleData>R" + "otation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent" + ";Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=""AxisY""" + " ParentName=""Area""><StyleData>Rotation=Rotate270;Border=None,Transparent,1;Align" + "Horz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></Name" + "dStyle><NamedStyle Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.defaul" + "t""><StyleData /></NamedStyle><NamedStyle Name=""Legend.default"" ParentName=""Contr" + "ol""><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedS" + "tyle><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""Control""><StyleDat" + "a>Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" + " Name=""Header"" ParentName=""Control""><StyleData>Border=None,Black,1;</StyleData><" + "/NamedStyle><NamedStyle Name=""Control.default"" ParentName=""""><StyleData>ForeColo" + "r=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><Na" + "medStyle Name=""AxisY2"" ParentName=""Area""><StyleData>Rotation=Rotate90;Border=Non" + "e,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData" + "></NamedStyle><NamedStyle Name=""Area.default"" ParentName=""Control""><StyleData>Bo" + "rder=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollection><Char" + "tGroupsCollection><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" Defa" + "ultSet=""True""><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""Dark" + "Goldenrod"" /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</Ser" + "iesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Singl" + "e;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></D" + "ataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolS" + "tyle Color=""CornflowerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>" + "1;2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Doub" + "le;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSeri" + "alizer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""" + "Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10" + ";16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double<" + "/DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSerie" + "sSerializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""D" + "iamond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</" + "Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><Da" + "taFields>;;;;</DataFields><Tag /></DataSeriesSerializer></DataSeriesCollection><" + "/DataSerializer><Name>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</Ch" + "artType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</B" + "ar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=Tru" + "e,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,Minimum" + "Size=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar" + ">Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>Tr" + "ue</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=""3.402823466385288" + "6E+38"" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType" + "><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiL" + "oData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowO" + "pen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5<" + "/Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degree" + "s=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Sho" + "wOutline></ChartGroup></ChartGroupsCollection><Header Compass=""North"" Visible=""F" + "alse""><Text /></Header><Footer Compass=""South"" Visible=""False""><Text /></Footer>" + "<Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartArea LocationDefau" + "lt=""5, -1""><Margin Left=""1"" Right=""1"" /></ChartArea><Axes><Axis Max=""5"" Min=""1"" " + "UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" A" + "utoMin=""True"" _onTop=""0"" Compass=""South""><Text /><GridMajor AutoSpace=""True"" Col" + "or=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pa" + "ttern=""Dash"" /></Axis><Axis Max=""25"" Min=""5"" UnitMajor=""5"" UnitMinor=""2.5"" AutoM" + "ajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""W" + "est""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><Gri" + "dMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" " + "Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""T" + "rue"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Text /><GridMajor AutoSpace=""True" + """ Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGra" + "y"" Pattern=""Dash"" /></Axis></Axes></Chart2DPropBag>"

      Me.errChart.Size = New System.Drawing.Size(632, 168)
      Me.errChart.TabIndex = 2
      ' 
      ' trendChart
      ' 
      Me.trendChart.DataSource = Nothing
      Me.trendChart.Dock = System.Windows.Forms.DockStyle.Fill
      Me.trendChart.Name = "trendChart"
      Me.trendChart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area""><StyleData>Border=Solid,ControlText,1;BackColor=Wh" + "ite;</StyleData></NamedStyle><NamedStyle Name=""Legend"" ParentName=""Legend.defaul" + "t""><StyleData /></NamedStyle><NamedStyle Name=""Footer"" ParentName=""Control""><Sty" + "leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=""Area"" Pare" + "ntName=""Area.default""><StyleData /></NamedStyle><NamedStyle Name=""Control"" Paren" + "tName=""Control.default""><StyleData>Border=Solid,Transparent,1;</StyleData></Name" + "dStyle><NamedStyle Name=""AxisX"" ParentName=""Area""><StyleData>Rotation=Rotate0;Bo" + "rder=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;Alig" + "nVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=""AxisY"" ParentName=""Area""" + "><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColo" + "r=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle" + " Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.default""><StyleData /></" + "NamedStyle><NamedStyle Name=""Legend.default"" ParentName=""Control""><StyleData>Bor" + "der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle N" + "ame=""LabelStyleDefault.default"" ParentName=""Control""><StyleData>Border=None,Blac" + "k,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle Name=""Header"" Par" + "entName=""Control""><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Named" + "Style Name=""Control.default"" ParentName=""""><StyleData>ForeColor=ControlText;Bord" + "er=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle Name=""Axi" + "sY2"" ParentName=""Area""><StyleData>Rotation=Rotate90;Border=None,Transparent,1;Al" + "ignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><Nam" + "edStyle Name=""Area.default"" ParentName=""Control""><StyleData>Border=None,Black,1;" + "AlignVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection>" + "<ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><Dat" + "aSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><Symb" + "olStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;" + "4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Do" + "uble;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerialize" + "r><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""Cornfl" + "owerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;" + "12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</" + "DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeries" + "Serializer><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""T" + "ri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y" + "1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFi" + "elds>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineS" + "tyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesL" + "abel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><Y2 /><Y3 " + "/><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Dat" + "aFields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><N" + "ame>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>Other" + "Offset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillF" + "alling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</H" + "iLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Po" + "lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" + "ed=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></" + "ChartGroup><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" /><Name>Gro" + "up2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=" + "0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=" + "True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData" + "><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Deg" + "rees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fals" + "e,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGr" + "oup></ChartGroupsCollection><Header Compass=""North"" Visible=""False""><Text /></He" + "ader><Footer Compass=""South"" Visible=""False""><Text /></Footer><Legend Compass=""E" + "ast"" Visible=""False""><Text /></Legend><ChartArea LocationDefault=""5, -1""><Margin" + " Left=""1"" Right=""1"" /></ChartArea><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" Unit" + "Minor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onT" + "op=""0"" Compass=""South""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></A" + "xis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMino" + "r=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""West""><Text /><GridMa" + "jor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""Tr" + "ue"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0" + """ UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" " + "_onTop=""0"" Compass=""East""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" " + "Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" />" + "</Axis></Axes></Chart2DPropBag>"

      Me.trendChart.Size = New System.Drawing.Size(632, 243)
      Me.trendChart.TabIndex = 3
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 433)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.trendChart, errChart, statusBar1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(400, 300)
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Trend&Error  Demo"
      CType(Me.errChart, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.trendChart, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   Private rnd As New Random()
   Private np As Integer = 15
   
   
   Private Sub GenerateData()
      Dim cd As ChartData = trendChart.ChartGroups(0).ChartData
      
      Dim ds As ChartDataSeries
      
      If cd.SeriesList.Count <> 1 Then
         cd.SeriesList.Clear()
         ds = cd.SeriesList.AddNewSeries()
         
         ds.LineStyle.Pattern = LinePatternEnum.None
         ds.SymbolStyle.Shape = SymbolShapeEnum.Dot
         
         ds.SymbolStyle.Color = Color.LightCoral
         
         ds.SymbolStyle.OutlineColor = Color.DarkRed
         ds.SymbolStyle.OutlineWidth = 1
         ds.SymbolStyle.Size = 12
      Else
         ds = cd(0)
      End If 
      Dim x(np-1) As Double
      Dim y(np-1) As Double
      Dim i As Integer
      For i = 0 To np - 1
         x(i) = i
         y(i) = rnd.NextDouble() * 100
      Next i
      
      ds.X.CopyDataIn(x)
      ds.Y.CopyDataIn(y)
   End Sub 'GenerateData
   
   
   Sub CalculateErrors()
      Dim cd As ChartData = trendChart.ChartGroups(0).ChartData
      
      Dim tl As TrendLine
      
      If cd.TrendsList.Count = 0 Then
         tl = cd.TrendsList.AddNewTrendLine()
         tl.LineStyle.Color = Color.DarkGreen
         tl.LineStyle.Thickness = 3
         tl.ForecastBackward = 1
         tl.ForecastForward = 1
      Else
         tl = cd.TrendsList(0)
      End If 
      Dim x As Double() = CType(cd(0).X.CopyDataOut(), Double())
      Dim y As Double() = CType(cd(0).Y.CopyDataOut(), Double())
      
      cd = errChart.ChartGroups(0).ChartData
      Dim ds As ChartDataSeries
      
      If cd.SeriesList.Count > 1 Then
         cd.SeriesList.Clear()
         ds = cd.SeriesList.AddNewSeries()
         ds.LineStyle.Pattern = LinePatternEnum.None
         
         ds.SymbolStyle.Shape = SymbolShapeEnum.DiagCross
         ds.SymbolStyle.Color = Color.ForestGreen
         ds.SymbolStyle.Size = 12
         
         ds.LineStyle.Color = Color.ForestGreen
      Else
         ds = cd(0)
      End If 
      Dim i As Integer
      For i = 0 To np - 1
         y(i) -= tl.GetY(x(i))
         x(i) = i + 1
      Next i
      
      ds.X.CopyDataIn(x)
      ds.Y.CopyDataIn(y)
      
      If cd.TrendsList.Count = 0 Then
         tl = cd.TrendsList.AddNewTrendLine()
         tl.TrendLineType = TrendLineTypeEnum.Maximum
         tl.LineStyle.Color = Color.FromArgb(128, Color.Red)
         tl.LineStyle.Thickness = 3
         tl.ForecastBackward = 1
         tl.ForecastForward = 1
         
         tl = cd.TrendsList.AddNewTrendLine()
         tl.TrendLineType = TrendLineTypeEnum.Minimum
         tl.LineStyle.Color = Color.FromArgb(128, Color.Blue)
         tl.LineStyle.Thickness = 3
         tl.ForecastBackward = 1
         tl.ForecastForward = 1
      End If
      
      Dim ymax As Double = Math.Max(Math.Abs(ds.MaxY), Math.Abs(ds.MinY)) + 5
      errChart.ChartArea.AxisY.SetMinMax(- ymax, ymax)
   End Sub 'CalculateErrors
   
   
   Sub CreatePointStyles()
      Dim cd As ChartData = errChart.ChartGroups(0).ChartData
      
      Dim ps As PointStyle = cd.PointStylesList.AddNewPointStyle()
      ps.Selection = PointStyleSelectionEnum.DataMaxY
      ps.LineStyle.Color = Color.Red
      ps.SymbolStyle.Color = Color.Red
      ps.SymbolStyle.Shape = SymbolShapeEnum.DiagCross
      ps.SymbolStyle.Size = 15
      
      ps = cd.PointStylesList.AddNewPointStyle()
      ps.Selection = PointStyleSelectionEnum.DataMinY
      ps.LineStyle.Color = Color.Blue
      ps.SymbolStyle.Color = Color.Blue
      ps.SymbolStyle.Shape = SymbolShapeEnum.DiagCross
      ps.SymbolStyle.Size = 15
   End Sub 'CreatePointStyles
   
   Private moving As Boolean = False
   Private move_si As Integer = - 1
   Private move_pi As Integer = - 1
   Private move_pt As Point
   Private prev As Point = Point.Empty
   
   
   Private Sub c1Chart1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles trendChart.MouseDown
      Dim si As Integer = - 1
      Dim pi As Integer = - 1
      Dim dist As Integer = - 1
      If trendChart.ChartGroups(0).CoordToDataIndex(e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, si, pi, dist) Then
         If dist <= 6 Then
            trendChart.Cursor = Cursors.Hand
            moving = True
            move_si = si
            move_pi = pi
            move_pt = New Point(e.X, e.Y)
         End If
      End If
   End Sub 'c1Chart1_MouseDown
   
   
   Private Sub c1Chart1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles trendChart.MouseUp
      If moving Then
         Dim x As Double = 0
         Dim y As Double = 0
         If trendChart.ChartGroups(0).CoordToDataCoord(e.X, e.Y, x, y) Then
            If y > 100 Then
               y = 100
            ElseIf y < 0 Then
               y = 0
            End If 
            trendChart.ChartGroups(0).ChartData(move_si).X(move_pi) = x
            trendChart.ChartGroups(0).ChartData(move_si).Y(move_pi) = y
            CalculateErrors()
         End If
         
         trendChart.Cursor = Cursors.Default
         moving = False
         
         If Not prev.IsEmpty Then
            Dim pt1 As Point = trendChart.PointToScreen(move_pt)
            ControlPaint.DrawReversibleLine(pt1, prev, trendChart.ChartArea.PlotArea.BackColor)
            prev = Point.Empty
         End If
      End If
   End Sub 'c1Chart1_MouseUp
   
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles trendChart.MouseMove
      If moving Then
         Dim pt1 As Point = trendChart.PointToScreen(move_pt)
         
         If Not prev.IsEmpty Then
            ControlPaint.DrawReversibleLine(pt1, prev, trendChart.ChartArea.PlotArea.BackColor)
         End If 
         Dim pt2 As Point = trendChart.PointToScreen(New Point(e.X, e.Y))
         ControlPaint.DrawReversibleLine(pt1, pt2, trendChart.ChartArea.PlotArea.BackColor)
         prev = pt2
      Else
         Dim si As Integer = - 1
         Dim pi As Integer = - 1
         Dim dist As Integer = - 1
         If trendChart.ChartGroups(0).CoordToDataIndex(e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, si, pi, dist) Then
            If dist <= 6 Then
               trendChart.Cursor = Cursors.SizeAll
            Else
               trendChart.Cursor = Cursors.Arrow
            End If
         Else
            trendChart.Cursor = Cursors.Arrow
         End If
      End If
   End Sub 'c1Chart1_MouseMove
    
   Private Sub Form1_SizeChanged(sender As Object, e As System.EventArgs) Handles MyBase.SizeChanged
      trendChart.ChartArea.Size = New Size(ClientSize.Width - 10, - 1)
      errChart.ChartArea.Size = New Size(ClientSize.Width - 10, - 1)
   End Sub 'Form1_SizeChanged
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      trendChart.Header.Text = "Random data with polynomial trend line"
      trendChart.Header.Visible = True
      
      trendChart.ChartArea.AxisY.GridMajor.Visible = True
      trendChart.ChartArea.AxisX.GridMajor.Visible = True
      
      errChart.ChartArea.AxisX.GridMajor.Visible = True
      errChart.ChartArea.AxisY.GridMajor.Visible = True
      
      errChart.Header.Text = "Estimate Error"
      errChart.Header.Visible = True
      
      errChart.ChartArea.AxisX.Text = "Sample Number"
      
      GenerateData()
      CalculateErrors()
      CreatePointStyles()
   End Sub 'Form1_Load
   
   
   Private Sub CheckGroup(mis() As MenuItem, sender As Object)
      Dim mi As MenuItem
      For Each mi In  mis
         If mi.Equals(sender) Then
            mi.Checked = True
         Else
            mi.Checked = False
         End If
      Next mi
   End Sub 'CheckGroup
    
   Private Sub miErrBar_Click(sender As Object, e As System.EventArgs) Handles miErrBar.Click, miErrScatter.Click
      CheckGroup(New MenuItem() {miErrBar, miErrScatter}, sender)
      
      If miErrBar.Equals(sender) Then
         errChart.ChartGroups(0).ChartType = Chart2DTypeEnum.Bar
      ElseIf miErrScatter.Equals(sender) Then
         errChart.ChartGroups(0).ChartType = Chart2DTypeEnum.XYPlot
      End If 
      CalculateErrors()
   End Sub 'miErrBar_Click
   
   
   Private Sub miTrend2_Click(sender As Object, e As System.EventArgs) Handles miTrend2.Click, miTrend3.Click, miTrend4.Click, miTrend5.Click, miTrend6.Click
      CheckGroup(New MenuItem() {miTrend2, miTrend3, miTrend4, miTrend5, miTrend6}, sender)
      Dim cd As ChartData = trendChart.ChartGroups(0).ChartData
      Dim tl As TrendLine = cd.TrendsList(0)
      
      If miTrend2.Equals(sender) Then
         tl.RegressionOptions.NumTerms = 2
      ElseIf miTrend3.Equals(sender) Then
         tl.RegressionOptions.NumTerms = 3
      ElseIf miTrend4.Equals(sender) Then
         tl.RegressionOptions.NumTerms = 4
      ElseIf miTrend5.Equals(sender) Then
         tl.RegressionOptions.NumTerms = 5
      ElseIf miTrend6.Equals(sender) Then
         tl.RegressionOptions.NumTerms = 6
      End If 
      CalculateErrors()
   End Sub 'miTrend2_Click
   
   
   Private Sub miExit_Click(sender As Object, e As System.EventArgs) Handles miExit.Click
      Close()
   End Sub 'miExit_Click
   
   
   Private Sub miNewData_Click(sender As Object, e As System.EventArgs) Handles miNewData.Click
      GenerateData()
      CalculateErrors()
   End Sub 'miNewData_Click
   
   
   Private Sub miAbout_Click(sender As Object, e As System.EventArgs) Handles miAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'miAbout_Click
End Class 'Form1
