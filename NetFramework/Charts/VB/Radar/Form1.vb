
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
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   WithEvents menuOptions As System.Windows.Forms.MenuItem
   WithEvents menuOptionsFilled As System.Windows.Forms.MenuItem
   WithEvents menuOptionsStacked As System.Windows.Forms.MenuItem
   WithEvents menuHelp As System.Windows.Forms.MenuItem
   WithEvents menuFile As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
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
      Me.menuOptions = New System.Windows.Forms.MenuItem()
      Me.menuOptionsFilled = New System.Windows.Forms.MenuItem()
      Me.menuOptionsStacked = New System.Windows.Forms.MenuItem()
      Me.menuHelp = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, menuOptions, menuHelp})
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
      ' menuOptions
      ' 
      Me.menuOptions.Index = 1
      Me.menuOptions.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuOptionsFilled, menuOptionsStacked})
      Me.menuOptions.Text = "Options"
      ' 
      ' menuOptionsFilled
      ' 
      Me.menuOptionsFilled.Index = 0
      Me.menuOptionsFilled.Text = "Filled"
      ' 
      ' menuOptionsStacked
      ' 
      Me.menuOptionsStacked.Index = 1
      Me.menuOptionsStacked.Text = "Stacked"
      ' 
      ' menuHelp
      ' 
      Me.menuHelp.Index = 2
      Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuHelp.Text = "Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "About"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Max=""5"" Min=""1"" UnitM" + "ajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMi" + "n=""True"" _onTop=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Co" + "lor=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2" + """ UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" " + "_onTop=""0"" Compass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Light" + "Gray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGra" + "y"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor" + "=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" " + "Compass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patte" + "rn=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=" + """Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text /></Header><ChartGr" + "oupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</" + "Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</Stacked><H" + "iLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Sho" + "wOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>EncodingMethod=Diamete" + "r,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer Defaul" + "tSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y>20;22;19;24;25</Y><Li" + "neStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape" + "=""Box"" Color=""Coral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Sing" + "le;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSerie" + "sSerializer><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" C" + "olor=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue" + """ /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Si" + "ngle</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSe" + "riesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" P" + "attern=""Solid"" /><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series" + " 2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" + "X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesSerializer><Y>16;19" + ";15;22;18</Y><LineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><Symbo" + "lStyle Shape=""Diamond"" Color=""Crimson"" /><SeriesLabel>series 3</SeriesLabel><Dat" + "aTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /" + "><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><ShowOutli" + "ne>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Pie>OtherOffset" + "=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=" + "True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>Fal" + "se</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Show" + "Close=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Encoding" + "Method=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name><DataSer" + "ializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" + "Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollection><StyleC" + "ollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName><StyleDa" + "ta>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Legend</Name" + "><ParentName>Legend.default</ParentName><StyleData /></NamedStyle><NamedStyle><N" + "ame>Footer</Name><ParentName>Control</ParentName><StyleData>Border=None,Control," + "1;</StyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</Pare" + "ntName><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;Back" + "Color=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Ar" + "ea</Name><ParentName>Area.default</ParentName><StyleData /></NamedStyle><NamedSt" + "yle><Name>Control</Name><ParentName>Control.default</ParentName><StyleData /></N" + "amedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>" + "Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;Al" + "ignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentNam" + "e>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignHorz" + "=Near;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyl" + "e><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentNam" + "e><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>C" + "ontrol</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</Sty" + "leData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentNam" + "e>Control</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</S" + "tyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name" + ">Control.default</Name><ParentName /><StyleData>ForeColor=ControlText;Border=Non" + "e,Control,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>Area.de" + "fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" + "gnVert=Top;</StyleData></NamedStyle></StyleCollection><Footer Compass=""South""><T" + "ext /></Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartAre" + "a /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(512, 312)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 349)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Radar Chart Demo"
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
   
   
   Private Sub menuOptionsFilled_Click(sender As Object, e As System.EventArgs) Handles menuOptionsFilled.Click
      ' turn filling on and off
      Dim mi As MenuItem = CType(sender, MenuItem)
      mi.Checked = Not mi.Checked
      c1Chart1.ChartGroups(0).Radar.Filled = mi.Checked
   End Sub 'menuOptionsFilled_Click
   
   
   Private Sub menuOptionsStacked_Click(sender As Object, e As System.EventArgs) Handles menuOptionsStacked.Click
      ' turn stacking on and off
      Dim mi As MenuItem = CType(sender, MenuItem)
      mi.Checked = Not mi.Checked
      c1Chart1.ChartGroups(0).Stacked = mi.Checked
      If mi.Checked Then
         c1Chart1.ChartArea.AxisY.Min = 0
      Else
         c1Chart1.ChartArea.AxisY.AutoMin = True
      End If
   End Sub 'menuOptionsStacked_Click
    
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' center the form.
      Me.CenterToParent()
      
      ' setup the chart to fill the form, then set the appearance.
      c1Chart1.Dock = DockStyle.Fill
      
      ' set the chart itself
      c1Chart1.Style.BackColor = Color.LightBlue
      c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel
      c1Chart1.Style.Border.Thickness = 4
      
      ' set up the area
      Dim area As Area = c1Chart1.ChartArea
      area.Style.BackColor = Color.LightYellow
      area.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel
      area.Style.Border.Thickness = 4
      
      ' set up the plot area
      Dim parea As PlotArea = area.PlotArea
      parea.BackColor = Color.AntiqueWhite
      
      ' set up the header
      Dim hdr As Title = c1Chart1.Header
      hdr.Text = "Radar Chart for System Adaptability"
      hdr.Style.Font = New Font("Arial Black", 14)
      hdr.Style.Border.BorderStyle = BorderStyleEnum.Raised
      hdr.Style.Border.Color = Color.PaleTurquoise
      
      ' set up the Legend
      Dim leg As Legend = c1Chart1.Legend
      leg.Style.Font = New Font("Arial Narrow", 9)
      leg.Style.BackColor = Color.AntiqueWhite
      leg.Style.Border.BorderStyle = BorderStyleEnum.Raised
      leg.Visible = True
      
      ' set up axes
      Dim ax As Axis = area.AxisX
      ax.AnnoMethod = AnnotationMethodEnum.ValueLabels
      ax.Font = New Font("Arial", 10)
      ax.Reversed = True
      ax.Thickness = 0
      ax.GridMajor.Color = Color.Black
      ax.GridMajor.Pattern = LinePatternEnum.Dot
      ax.GridMajor.Visible = True
      
      ' set the chart type to radar and add the data
      Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
      grp.ChartType = Chart2DTypeEnum.Radar
      
      ' set the axis information.  Not that the compass
      ' information is limited by the chart type, so it is
      ' necessary to set the chart type first.
      Dim ay As Axis = area.AxisY
      ay.GridMajor.Color = Color.Black
      ay.GridMajor.Pattern = LinePatternEnum.Dot
      ay.GridMajor.Visible = True
      ay.Compass = CompassEnum.North
      
      Dim series As ChartDataSeriesCollection = grp.ChartData.SeriesList
      series.Clear()
      
      ' there will be 3 new series, all with the same 7 x values:
      Dim x() As Integer = {1, 2, 3, 4, 5, 6, 7}
      Dim y0() As Single = {2.8F, 3.5F, 3.3F, 2F, 4F, 3F, 2.9F}
      Dim y1() As Single = {3.2F, 3.3F, 3.5F, 2.4F, 3.8F, 3.4F, 4.2F}
      Dim y2() As Single = {3.6F, 5F, 3.3F, 5F, 3.6F, 4.3F, 3.8F}
      
      ' series 0
      Dim s As ChartDataSeries = series.AddNewSeries()
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y0)
      s.LineStyle.Color = Color.Orange
      s.Label = "New Transport"
      
      ' series 1
      s = series.AddNewSeries()
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y1)
      s.LineStyle.Color = Color.Blue
      s.Label = "OTIS"
      
      ' series 2
      s = series.AddNewSeries()
      s.X.CopyDataIn(x)
      s.Y.CopyDataIn(y2)
      s.LineStyle.Color = Color.Green
      s.Label = "Mobile Walk"
      
      ' add in the value labels for the x axis.
      Dim vlabs As ValueLabelsCollection = ax.ValueLabels
      vlabs.Add(x(0), "Introduce")
      vlabs.Add(x(1), "Response")
      vlabs.Add(x(2), "Travel Time")
      vlabs.Add(x(3), "Get On/Off")
      vlabs.Add(x(4), "Comfort")
      vlabs.Add(x(5), "Social")
      vlabs.Add(x(6), "Operate")
   End Sub 'Form1_Load
End Class 'Form1
