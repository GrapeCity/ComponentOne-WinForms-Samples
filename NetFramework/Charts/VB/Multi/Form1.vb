
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents timer1 As System.Windows.Forms.Timer
   Private components As System.ComponentModel.IContainer
   WithEvents chartBar As C1.Win.C1Chart.C1Chart
   WithEvents chartXY As C1.Win.C1Chart.C1Chart
   WithEvents chartPie As C1.Win.C1Chart.C1Chart
   WithEvents toolBar1 As System.Windows.Forms.ToolBar
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   Private tbbPrint As System.Windows.Forms.ToolBarButton
   Private ilToolbar As System.Windows.Forms.ImageList
   Private tbbPreview As System.Windows.Forms.ToolBarButton
   WithEvents toolBarButton1 As System.Windows.Forms.ToolBarButton
   WithEvents printDocument As System.Drawing.Printing.PrintDocument
   Private printPreviewDialog As System.Windows.Forms.PrintPreviewDialog
   Private printDialog As System.Windows.Forms.PrintDialog
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private pageSetupDialog As System.Windows.Forms.PageSetupDialog
   Private tbbPageSetup As System.Windows.Forms.ToolBarButton
   WithEvents menuFilePageSetup As System.Windows.Forms.MenuItem
   WithEvents menuItem4 As System.Windows.Forms.MenuItem
   WithEvents menuFilePrintPreview As System.Windows.Forms.MenuItem
   WithEvents menuFilePrint As System.Windows.Forms.MenuItem
   
   ' initialize random generator
   Private rnd As New Random()
   ' history storage for bar chart
   Private ha As Single = 0
   Private hb As Single = 0
   Private hc As Single = 0
   Private hd As Single = 0
   ' counter for XY chart
   Private count As Integer = 0
   Private shift As Integer = 0
   Private npoints As Integer = 10
   WithEvents menuFileStart As System.Windows.Forms.MenuItem
   WithEvents menuItem5 As System.Windows.Forms.MenuItem
   Private tbbStart As System.Windows.Forms.ToolBarButton
   WithEvents menuFileStop As System.Windows.Forms.MenuItem
   Private nblocks As Integer = 50
   
   
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
   
   
   Sub positionCharts()
      Dim rc As Rectangle = ClientRectangle
      rc.Y += toolBar1.Height
      rc.Height -= toolBar1.Height
      
      chartPie.Location = New Point(rc.Left, rc.Top)
      chartPie.Size = New Size(rc.Width / 2, rc.Height / 2)
      
      chartBar.Location = New Point(rc.Left + rc.Width / 2, rc.Top)
      chartBar.Size = New Size(rc.Width / 2, rc.Height / 2)
      
      chartXY.Location = New Point(rc.Left, rc.Top + rc.Height / 2)
      chartXY.Size = New Size(rc.Width, rc.Height / 2)
   End Sub 'positionCharts
   
   
   ' printing handler 
   Private Sub pd_PrintPage(sender As Object, ev As System.Drawing.Printing.PrintPageEventArgs) Handles printDocument.PrintPage
      Dim marg As Integer = 10
      Dim x As Integer = ev.MarginBounds.Left
      Dim y As Integer = ev.MarginBounds.Top
      Dim w As Integer = ev.MarginBounds.Width
      Dim h As Integer = ev.MarginBounds.Height
      chartPie.Draw(ev.Graphics, New Rectangle(x, y, w / 2 - marg, h / 2 - marg))
      chartBar.Draw(ev.Graphics, New Rectangle(x + w / 2 + marg, y, w / 2 - marg, h / 2 - marg))
      chartXY.Draw(ev.Graphics, New Rectangle(x, y + h / 2 + marg, w, h / 2 - marg))
   End Sub 'pd_PrintPage
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.components = New System.ComponentModel.Container()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.chartBar = New C1.Win.C1Chart.C1Chart()
      Me.chartXY = New C1.Win.C1Chart.C1Chart()
      Me.chartPie = New C1.Win.C1Chart.C1Chart()
      Me.timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.toolBar1 = New System.Windows.Forms.ToolBar()
      Me.tbbPrint = New System.Windows.Forms.ToolBarButton()
      Me.tbbPreview = New System.Windows.Forms.ToolBarButton()
      Me.tbbPageSetup = New System.Windows.Forms.ToolBarButton()
      Me.toolBarButton1 = New System.Windows.Forms.ToolBarButton()
      Me.tbbStart = New System.Windows.Forms.ToolBarButton()
      Me.ilToolbar = New System.Windows.Forms.ImageList(Me.components)
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileStart = New System.Windows.Forms.MenuItem()
      Me.menuFileStop = New System.Windows.Forms.MenuItem()
      Me.menuItem5 = New System.Windows.Forms.MenuItem()
      Me.menuFilePageSetup = New System.Windows.Forms.MenuItem()
      Me.menuFilePrintPreview = New System.Windows.Forms.MenuItem()
      Me.menuFilePrint = New System.Windows.Forms.MenuItem()
      Me.menuItem4 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.printDocument = New System.Drawing.Printing.PrintDocument()
      Me.printPreviewDialog = New System.Windows.Forms.PrintPreviewDialog()
      Me.printDialog = New System.Windows.Forms.PrintDialog()
      Me.pageSetupDialog = New System.Windows.Forms.PageSetupDialog()
      CType(Me.chartBar, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chartXY, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chartPie, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' chartBar
      ' 
      Me.chartBar.BackColor = System.Drawing.Color.LightBlue
      Me.chartBar.Location = New System.Drawing.Point(296, 24)
      Me.chartBar.Name = "chartBar"
      Me.chartBar.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Silver;" + "</StyleData><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.def" + "ault</ParentName><StyleData>Border=Raised,LightBlue,1;AlignHorz=Center;BackColor" + "=Azure;</StyleData><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Contr" + "ol</ParentName><StyleData>Border=None,LightBlue,1;</StyleData><Name>Footer</Name" + "></NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Nam" + "e>Area</Name></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><S" + "tyleData>Border=Raised,LightBlue,1;BackColor=LightBlue;</StyleData><Name>Control" + "</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotation" + "=Rotate270;Border=None,LightBlue,1;AlignHorz=Near;BackColor=Transparent;AlignVer" + "t=Center;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><ParentName>Area" + "</ParentName><StyleData>Rotation=Rotate0;Border=None,LightBlue,1;AlignHorz=Cente" + "r;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>AxisY</Name></NamedSt" + "yle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleData /><" + "Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control</Paren" + "tName><StyleData>Border=None,LightBlue,1;Wrap=False;AlignVert=Top;</StyleData><N" + "ame>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</ParentNam" + "e><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>Label" + "StyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" + "ame><StyleData>Border=None,LightBlue,1;Font=Microsoft Sans Serif, 12pt, style=Bo" + "ld, Underline;</StyleData><Name>Header</Name></NamedStyle><NamedStyle><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,LightBlue,1;BackColor=Control;<" + "/StyleData><Name>Control.default</Name></NamedStyle><NamedStyle><ParentName>Area" + "</ParentName><StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Cen" + "ter;BackColor=Transparent;AlignVert=Top;</StyleData><Name>AxisY2</Name></NamedSt" + "yle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,LightBlue" + ",1;AlignVert=Top;</StyleData><Name>Area.default</Name></NamedStyle></StyleCollec" + "tion><Axes><Axis Max=""2.5"" Min=""0.5"" UnitMajor=""0.5"" UnitMinor=""0.25"" AutoMajor=" + """True"" AutoMinor=""True"" AutoMax=""False"" AutoMin=""False"" AnnoMethod=""ValueLabels""" + " _onTop=""0"" Compass=""West""><ValueLabels><ValueLabel Value=""1"" Text=""Current"" /><" + "ValueLabel Value=""2"" Text=""History"" /></ValueLabels><GridMajor AutoSpace=""True"" " + "Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thi" + "ckness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=" + """0"" UnitMajor=""10"" UnitMinor=""5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""Fals" + "e"" AutoMin=""False"" _onTop=""0"" Compass=""South""><GridMajor Spacing=""10"" AutoSpace=" + """True"" Visible=""True"" Thickness=""1"" Color=""Black"" Pattern=""Dash"" /><GridMinor Sp" + "acing=""5"" AutoSpace=""True"" Visible=""True"" Thickness=""1"" Color=""Black"" Pattern=""D" + "ash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajo" + "r=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""Nort" + "h""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" />" + "<GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Te" + "xt /></Axis></Axes><Header Compass=""North""><Text>Vehicle Comparison</Text></Head" + "er><Footer Compass=""South""><Text /></Footer><Legend Compass=""East"" Visible=""True" + """><Text /></Legend><ChartArea Inverted=""True"" /><ChartGroupsCollection><ChartGro" + "up><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Po" + "lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" + "ed=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Char" + "tType>Bar</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,Max" + "imumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=Tru" + "e,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Default" + "Set=""True""><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22</Y><" + "LineStyle Thickness=""1"" Color=""Orange"" Pattern=""Solid"" /><SymbolStyle Shape=""Box" + """ Color=""Coral"" /><SeriesLabel>Cars</SeriesLabel><DataTypes>Single;Single;Single" + ";Single;Single</DataTypes><Y1 /><X>1;2</X></DataSeriesSerializer><DataSeriesSeri" + "alizer><Y3 /><Y2 /><Y>8;12</Y><LineStyle Thickness=""1"" Color=""Violet"" Pattern=""S" + "olid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabel>Trucks</S" + "eriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2" + "</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>10;10</Y><LineSt" + "yle Thickness=""1"" Color=""Aquamarine"" Pattern=""Solid"" /><SymbolStyle Shape=""Inver" + "tedTri"" Color=""Cyan"" /><SeriesLabel>Buses</SeriesLabel><DataTypes>Single;Single;" + "Single;Single;Single</DataTypes><Y1 /><X>1;2</X></DataSeriesSerializer><DataSeri" + "esSerializer><Y3 /><Y2 /><Y>15;15</Y><LineStyle Thickness=""1"" Color=""LightGray"" " + "Pattern=""Solid"" /><SymbolStyle Shape=""Star"" Color=""DarkBlue"" /><SeriesLabel>Plan" + "es</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" + "X>1;2</X></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartG" + "roup><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</S" + "howOutline><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Deg" + "rees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Grou" + "p2</Name><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMe" + "thod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,Fi" + "llTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataS" + "erializer /></ChartGroup></ChartGroupsCollection></Chart2DPropBag>"

      Me.chartBar.Size = New System.Drawing.Size(296, 192)
      Me.chartBar.TabIndex = 1
      ' 
      ' chartXY
      ' 
      Me.chartXY.BackColor = System.Drawing.Color.PaleGreen
      Me.chartXY.ForeColor = System.Drawing.SystemColors.ControlText
      Me.chartXY.Location = New System.Drawing.Point(0, 216)
      Me.chartXY.Name = "chartXY"
      Me.chartXY.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>ForeColor=Blue;Border=Solid,Blue,1;</StyleDa" + "ta><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</Par" + "entName><StyleData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Con" + "trol</ParentName><StyleData>Border=None,PaleGreen,1;</StyleData><Name>Footer</Na" + "me></NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData>Fore" + "Color=Blue;</StyleData><Name>Area</Name></NamedStyle><NamedStyle><ParentName>Con" + "trol.default</ParentName><StyleData>ForeColor=ControlText;Border=Raised,PaleGree" + "n,1;BackColor=PaleGreen;</StyleData><Name>Control</Name></NamedStyle><NamedStyle" + "><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,PaleGreen," + "1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>Axis" + "X</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotatio" + "n=Rotate270;Border=None,PaleGreen,1;AlignHorz=Near;BackColor=Transparent;AlignVe" + "rt=Center;</StyleData><Name>AxisY</Name></NamedStyle><NamedStyle><ParentName>Lab" + "elStyleDefault.default</ParentName><StyleData /><Name>LabelStyleDefault</Name></" + "NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Pa" + "leGreen,1;Wrap=False;AlignVert=Top;</StyleData><Name>Legend.default</Name></Name" + "dStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Contro" + "l,1;BackColor=Transparent;</StyleData><Name>LabelStyleDefault.default</Name></Na" + "medStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=None,Pale" + "Green,1;Font=Microsoft Sans Serif, 12pt, style=Bold, Underline;</StyleData><Name" + ">Header</Name></NamedStyle><NamedStyle><ParentName /><StyleData>ForeColor=Contro" + "lText;Border=None,PaleGreen,1;BackColor=Control;</StyleData><Name>Control.defaul" + "t</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotatio" + "n=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVe" + "rt=Center;</StyleData><Name>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Co" + "ntrol</ParentName><StyleData>Border=None,PaleGreen,1;AlignVert=Top;</StyleData><" + "Name>Area.default</Name></NamedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""" + "1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""Fals" + "e"" Thickness=""1"" AutoMin=""False"" _onTop=""0"" Compass=""South""><GridMajor Spacing=""" + "1"" AutoSpace=""True"" Visible=""True"" Thickness=""1"" Color=""Blue"" Pattern=""Dot"" /><G" + "ridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text" + " /></Axis><Axis Max=""12"" Min=""-12"" UnitMajor=""10"" UnitMinor=""5"" AutoMajor=""True""" + " AutoMinor=""False"" AutoMax=""False"" Thickness=""1"" AutoMin=""False"" _onTop=""0"" Comp" + "ass=""West""><GridMajor Spacing=""10"" AutoSpace=""False"" Visible=""True"" Thickness=""1" + """ Color=""Blue"" Pattern=""Solid"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0""" + " UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _" + "onTop=""0"" Compass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightG" + "ray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray" + """ Pattern=""Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text>Noise Lev" + "el</Text></Header><Footer Compass=""South""><Text /></Footer><Legend Compass=""East" + """ Visible=""False""><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGro" + "up><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Po" + "lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" + "ed=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><Char" + "tType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter," + "MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=" + "True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer Defa" + "ultSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;1" + "9;24;25</Y><LineStyle Thickness=""1"" Color=""Black"" Pattern=""Solid"" /><SymbolStyle" + " Shape=""None"" Color=""Coral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Sing" + "le;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSeri" + "alizer></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Clu" + "sterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees" + "=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,St" + "art=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlo" + "t</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize" + "=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWi" + "dth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup>" + "</ChartGroupsCollection></Chart2DPropBag>"

      Me.chartXY.Size = New System.Drawing.Size(592, 184)
      Me.chartXY.TabIndex = 2
      ' 
      ' chartPie
      ' 
      Me.chartPie.BackColor = System.Drawing.Color.PaleGoldenrod
      Me.chartPie.Location = New System.Drawing.Point(0, 24)
      Me.chartPie.Name = "chartPie"
      Me.chartPie.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=None,PaleGoldenrod,1;</StyleData><Nam" + "e>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName" + "><StyleData>Border=Raised,PaleGoldenrod,1;AlignHorz=Center;BackColor=LightYellow" + ";</StyleData><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</Pa" + "rentName><StyleData>Border=None,PaleGoldenrod,1;</StyleData><Name>Footer</Name><" + "/NamedStyle><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>" + "Area</Name></NamedStyle><NamedStyle><ParentName>Control.default</ParentName><Sty" + "leData>Border=Raised,PaleGoldenrod,1;BackColor=PaleGoldenrod;</StyleData><Name>C" + "ontrol</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData" + ">Border=None,PaleGoldenrod,1;BackColor=Transparent;</StyleData><Name>LabelStyleD" + "efault.default</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><Styl" + "eData>Rotation=Rotate270;Border=None,Control,1;AlignHorz=Near;BackColor=Transpar" + "ent;AlignVert=Center;</StyleData><Name>AxisY</Name></NamedStyle><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,Control,1;Align" + "Horz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleData><Name>AxisX</Name" + "></NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><Sty" + "leData /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Cont" + "rol</ParentName><StyleData>Border=None,PaleGoldenrod,1;Wrap=False;AlignVert=Top;" + "</StyleData><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Cont" + "rol</ParentName><StyleData>Border=None,PaleGoldenrod,1;Font=Microsoft Sans Serif" + ", 12pt, style=Bold, Underline;</StyleData><Name>Header</Name></NamedStyle><Named" + "Style><ParentName /><StyleData>ForeColor=ControlText;Border=None,PaleGoldenrod,1" + ";BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><NamedSt" + "yle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Transp" + "arent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Name>A" + "xisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>" + "Border=None,PaleGoldenrod,1;AlignVert=Top;</StyleData><Name>Area.default</Name><" + "/NamedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMino" + "r=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""" + "0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" P" + "attern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patt" + "ern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""5"" UnitMinor=""2.5""" + " AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Comp" + "ass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""" + "Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Das" + "h"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=" + """True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East"">" + "<GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Gr" + "idMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text " + "/></Axis></Axes><Header Compass=""North""><Text>Vehicle Comparison</Text></Header>" + "<Footer Compass=""South""><Text>Current</Text></Footer><Legend Compass=""East"" Visi" + "ble=""True""><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar" + ">ClusterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Deg" + "rees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fals" + "e,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>P" + "ie</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSiz" + "e=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullW" + "idth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=""Tr" + "ue""><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20</Y><LineStyle " + "Thickness=""1"" Color=""Red"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=""Cora" + "l"" /><SeriesLabel>Cars</SeriesLabel><DataTypes>Single;Single;Single;Single;Singl" + "e</DataTypes><Y1 /><X>1</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y" + "2 /><Y>8</Y><LineStyle Thickness=""1"" Color=""Tan"" Pattern=""Solid"" /><SymbolStyle " + "Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabel>Trucks</SeriesLabel><DataTypes" + ">Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1</X></DataSeriesSeriali" + "zer><DataSeriesSerializer><Y3 /><Y2 /><Y>10</Y><LineStyle Thickness=""1"" Color=""L" + "ightGreen"" Pattern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><Series" + "Label>Buses</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataType" + "s><Y1 /><X>1</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>16</" + "Y><LineStyle Thickness=""1"" Color=""MediumTurquoise"" Pattern=""Solid"" /><SymbolStyl" + "e Shape=""Diamond"" Color=""Crimson"" /><SeriesLabel>Planes</SeriesLabel><DataTypes>" + "Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1</X></DataSeriesSerializ" + "er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" + "Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" + "e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" + "0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" + "hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," + "MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" + "False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" + "artGroupsCollection></Chart2DPropBag>"

      Me.chartPie.Size = New System.Drawing.Size(296, 192)
      Me.chartPie.TabIndex = 3
      ' 
      ' timer1
      ' 
      Me.timer1.Interval = 300
      ' 
      ' toolBar1
      ' 
      Me.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
      Me.toolBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.toolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbPrint, Me.tbbPreview, Me.tbbPageSetup, Me.toolBarButton1, Me.tbbStart})
      Me.toolBar1.Divider = False
      Me.toolBar1.DropDownArrows = True
      Me.toolBar1.ImageList = Me.ilToolbar
      Me.toolBar1.Name = "toolBar1"
      Me.toolBar1.ShowToolTips = True
      Me.toolBar1.Size = New System.Drawing.Size(592, 24)
      Me.toolBar1.TabIndex = 8
      Me.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
      ' 
      ' tbbPrint
      ' 
      Me.tbbPrint.ImageIndex = 0
      Me.tbbPrint.Text = "Print"
      Me.tbbPrint.ToolTipText = "Print"
      ' 
      ' tbbPreview
      ' 
      Me.tbbPreview.ImageIndex = 1
      Me.tbbPreview.Text = "Print Preview"
      Me.tbbPreview.ToolTipText = "Print Preview"
      ' 
      ' tbbPageSetup
      ' 
      Me.tbbPageSetup.ImageIndex = 4
      Me.tbbPageSetup.Text = "Page Setup"
      Me.tbbPageSetup.ToolTipText = "Page Setup"
      ' 
      ' toolBarButton1
      ' 
      Me.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
      ' 
      ' tbbStart
      ' 
      Me.tbbStart.ImageIndex = 2
      Me.tbbStart.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
      Me.tbbStart.Text = "Start"
      Me.tbbStart.ToolTipText = "Start"
      ' 
      ' ilToolbar
      ' 
      Me.ilToolbar.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
      Me.ilToolbar.ImageSize = New System.Drawing.Size(16, 16)
      Me.ilToolbar.ImageStream = CType(resources.GetObject("ilToolbar.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilToolbar.TransparentColor = System.Drawing.Color.Transparent
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3})
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 0
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileStart, Me.menuFileStop, Me.menuItem5, Me.menuFilePageSetup, Me.menuFilePrintPreview, Me.menuFilePrint, Me.menuItem4, Me.menuFileExit})
      Me.menuItem1.Text = "&File"
      ' 
      ' menuFileStart
      ' 
      Me.menuFileStart.Index = 0
      Me.menuFileStart.Text = "&Start"
      ' 
      ' menuFileStop
      ' 
      Me.menuFileStop.Index = 1
      Me.menuFileStop.Text = "Sto&p"
      ' 
      ' menuItem5
      ' 
      Me.menuItem5.Index = 2
      Me.menuItem5.Text = "-"
      ' 
      ' menuFilePageSetup
      ' 
      Me.menuFilePageSetup.Index = 3
      Me.menuFilePageSetup.Text = "Page Set&up ..."
      ' 
      ' menuFilePrintPreview
      ' 
      Me.menuFilePrintPreview.Index = 4
      Me.menuFilePrintPreview.Text = "Print Pre&view"
      ' 
      ' menuFilePrint
      ' 
      Me.menuFilePrint.Index = 5
      Me.menuFilePrint.Text = "&Print ..."
      ' 
      ' menuItem4
      ' 
      Me.menuItem4.Index = 6
      Me.menuItem4.Text = "-"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 7
      Me.menuFileExit.Text = "E&xit"
      ' 
      ' menuItem3
      ' 
      Me.menuItem3.Index = 1
      Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuItem3.Text = "&Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "&About"
      ' 
      ' printDocument
      ' 
      ' 
      ' printPreviewDialog
      ' 
      Me.printPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
      Me.printPreviewDialog.Document = Me.printDocument
      Me.printPreviewDialog.Enabled = True
      Me.printPreviewDialog.Icon = CType(resources.GetObject("printPreviewDialog.Icon"), System.Drawing.Icon)
      Me.printPreviewDialog.Location = New System.Drawing.Point(526, 17)
      Me.printPreviewDialog.MaximumSize = New System.Drawing.Size(0, 0)
      Me.printPreviewDialog.Name = "printPreviewDialog"
      Me.printPreviewDialog.Opacity = 1
      Me.printPreviewDialog.TransparencyKey = System.Drawing.Color.Empty
      Me.printPreviewDialog.Visible = False
      ' 
      ' printDialog
      ' 
      Me.printDialog.Document = Me.printDocument
      ' 
      ' pageSetupDialog
      ' 
      Me.pageSetupDialog.Document = Me.printDocument
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.toolBar1, Me.chartPie, Me.chartXY, Me.chartBar})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Multiple Charts Demo"
      CType(Me.chartBar, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chartXY, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chartPie, System.ComponentModel.ISupportInitialize).EndInit()
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
      ' clear data
      chartXY.ChartGroups.Group0.ChartData.SeriesList(0).PointData.Length = 0
      ' adjust axis
      chartXY.ChartArea.AxisX.Min = 0
      chartXY.ChartArea.AxisX.Max = nblocks * npoints
      
      positionCharts()
   End Sub 'Form1_Load
   
   
   Private Sub timer1_Tick(sender As Object, e As System.EventArgs) Handles timer1.Tick
      Dim a, b, c, d As Integer
      
      a = rnd.Next(1, 25)
      b = rnd.Next(1, 20)
      c = rnd.Next(1, 15)
      d = rnd.Next(1, 10)
      
      ha += a
      hb += b
      hc += c
      hd += d
      
      ' for the bar graph
      Dim y0() As Single = {a, ha * 0.025F}
      Dim y1() As Single = {b, hb * 0.025F}
      Dim y2() As Single = {c, hc * 0.025F}
      Dim y3() As Single = {d, hd * 0.025F}
      
      chartBar.ChartGroups.Group0.ChartData.SeriesList(0).Y.CopyDataIn(y0)
      chartBar.ChartGroups.Group0.ChartData.SeriesList(1).Y.CopyDataIn(y1)
      chartBar.ChartGroups.Group0.ChartData.SeriesList(2).Y.CopyDataIn(y2)
      chartBar.ChartGroups.Group0.ChartData.SeriesList(3).Y.CopyDataIn(y3)
      
      ' for the Pie Chart
      chartPie.ChartGroups.Group0.ChartData.SeriesList(0).Y(0) = a
      chartPie.ChartGroups.Group0.ChartData.SeriesList(1).Y(0) = b
      chartPie.ChartGroups.Group0.ChartData.SeriesList(2).Y(0) = c
      chartPie.ChartGroups.Group0.ChartData.SeriesList(3).Y(0) = d
      
      ' for XY chart
      ' adding n points
      If count >= nblocks Then
         ' adjust counters 
         shift += count * npoints
         count = 0
         ' clear data
         chartXY.ChartGroups.Group0.ChartData.SeriesList(0).PointData.Length = 0
         ' adjust axes
         chartXY.ChartArea.AxisX.Max = shift + nblocks * npoints
         chartXY.ChartArea.AxisX.Min = shift
      End If
      
      Dim len As Integer = chartXY.ChartGroups.Group0.ChartData.SeriesList(0).PointData.Length
      chartXY.ChartGroups.Group0.ChartData.SeriesList(0).PointData.Length = len + npoints
      Dim i As Integer
      For i = 0 To npoints - 1
         Dim r As Single = CSng(rnd.NextDouble())
         Dim y As Single = CSng(10 * r * Math.Sin((0.1 * i)) * Math.Sin((0.6 * rnd.NextDouble() * i)))
         chartXY.ChartGroups.Group0.ChartData.SeriesList(0).PointData((len + i)) = New PointF(shift + len + i, y)
      Next i
      count += 1
   End Sub 'timer1_Tick
   
   
   Private Sub toolBar1_ButtonClick(sender As Object, e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles toolBar1.ButtonClick
      Select Case toolBar1.Buttons.IndexOf(e.Button)
         Case 0
            printDialog.ShowDialog()
         Case 1
            printPreviewDialog.ShowDialog()
         Case 2
            pageSetupDialog.ShowDialog()
         Case 4
            timer1.Enabled = Not timer1.Enabled
         Case Else
      End Select
   End Sub 'toolBar1_ButtonClick
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFilePageSetup_Click(sender As Object, e As System.EventArgs) Handles menuFilePageSetup.Click
      pageSetupDialog.ShowDialog()
   End Sub 'menuFilePageSetup_Click
   
   
   Private Sub menuFilePrintPreview_Click(sender As Object, e As System.EventArgs) Handles menuFilePrintPreview.Click
      printPreviewDialog.ShowDialog()
   End Sub 'menuFilePrintPreview_Click
   
   
   Private Sub menuFilePrint_Click(sender As Object, e As System.EventArgs) Handles menuFilePrint.Click
      printDialog.ShowDialog()
   End Sub 'menuFilePrint_Click
   
   
   Private Sub Form1_SizeChanged(sender As Object, e As System.EventArgs) Handles MyBase.SizeChanged
      positionCharts()
   End Sub 'Form1_SizeChanged
   
   
   Private Sub menuFileStart_Click(sender As Object, e As System.EventArgs) Handles menuFileStart.Click
      If Not timer1.Enabled Then
         timer1.Enabled = True
         tbbStart.Pushed = True
      End If
   End Sub 'menuFileStart_Click
   
   
   Private Sub menuFileStop_Click(sender As Object, e As System.EventArgs) Handles menuFileStop.Click
      If timer1.Enabled Then
         timer1.Enabled = False
         tbbStart.Pushed = False
      End If
   End Sub 'menuFileStop_Click
End Class 'Form1
