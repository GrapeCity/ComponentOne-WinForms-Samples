
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
   Private c1Chart1 As C1.Win.C1Chart.C1Chart
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
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
   
   
   Sub setupChart()
      'setup the chart style
      c1Chart1.Style.BackColor = Color.LightBlue
      
      'setup the chart header
      c1Chart1.Header.Text = "These are Error Bars"
      c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised
      c1Chart1.Header.Style.Font = New Font("Arial", 12)
      
      'setup the chart area
      c1Chart1.ChartArea.Style.BackColor = Color.LightYellow
      c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      c1Chart1.ChartArea.Style.Border.Thickness = 4
      
      'chart types for the two groups
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose
      c1Chart1.ChartGroups(0).HiLoData.FullWidth = True
      
      c1Chart1.ChartGroups(1).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot
      
      'setup axes
      c1Chart1.ChartArea.AxisX.ForeColor = Color.Red
      c1Chart1.ChartArea.AxisX.Min = 0
      c1Chart1.ChartArea.AxisX.Max = 6
      
      c1Chart1.ChartArea.AxisY.ForeColor = Color.Blue
      c1Chart1.ChartArea.AxisY.Max = 25
      c1Chart1.ChartArea.AxisY.Min = 0
      
      c1Chart1.ChartArea.AxisY2.ForeColor = Color.Blue
      c1Chart1.ChartArea.AxisY2.Min = 0
      c1Chart1.ChartArea.AxisY2.Max = 25
   End Sub 'setupChart
   
   
   Sub setupData()
      Dim x() As Double = {1, 2, 3, 4, 5}
      Dim y() As Double = {14, 17, 15, 18, 20}
      Dim ymax() As Double = {20, 22, 19, 24, 25}
      Dim ymin() As Double = {8, 12, 10, 12, 15}
      Dim len As Integer = y.Length
      
      ' setup group0 data
      c1Chart1.ChartGroups(0).ChartData(0).X.CopyDataIn(x)
      c1Chart1.ChartGroups(0).ChartData(0).Y.CopyDataIn(ymin)
      c1Chart1.ChartGroups(0).ChartData(0).Y1.CopyDataIn(ymax)
      c1Chart1.ChartGroups(0).ChartData(0).Y2.CopyDataIn(ymin)
      c1Chart1.ChartGroups(0).ChartData(0).Y3.CopyDataIn(ymax)
      
      ' setup group1 data
      Dim ds1 As New C1.Win.C1Chart.ChartDataSeries()
      
      ' setup appearance
      ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
      ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Box
      ds1.SymbolStyle.Color = Color.Black
      
      'copy the data into dataseries									
      ds1.X.CopyDataIn(x)
      ds1.Y.CopyDataIn(y)
      
      'add the data series
      c1Chart1.ChartGroups(1).ChartData.SeriesList.Add(ds1)
   End Sub 'setupData
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plot" + "Area</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Styl" + "eData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" + "ame><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyle" + "><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name>" + "</NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><N" + "ame>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleDa" + "ta>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent" + ";AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Parent" + "Name>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignH" + "orz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name></" + "NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleD" + "ata /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control" + "</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData" + "><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>La" + "belStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Pare" + "ntName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedSt" + "yle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Contr" + "ol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Nam" + "edStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Tr" + "ansparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Na" + "me>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></N" + "amedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""" + " Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" Aut" + "oMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=" + """West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash" + """ /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /" + "><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""Tru" + "e"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Gri" + "dMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMi" + "nor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /></" + "Axis></Axes><Header Compass=""North""><Text /></Header><Footer Compass=""South"" Vis" + "ible=""False""><Text /></Footer><Legend Compass=""East"" Visible=""False""><Text /></L" + "egend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,Clus" + "terWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnot" + "ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>" + "OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stac" + "ked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5<" + "/Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" + "e=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=""True""><DataSeriesColl" + "ection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickne" + "ss=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=""C" + "oral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Singl" + "e;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSeri" + "alizer><Y3 /><Y2 /><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" Color=""DarkGray""" + " Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabe" + "l>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes" + "><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 />" + "<Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" " + "/><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series 2</SeriesLabel" + "><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X>" + "</DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><L" + "ineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><SymbolStyle Shape=""D" + "iamond"" Color=""Crimson"" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;S" + "ingle;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializ" + "er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" + "Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" + "e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" + "0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" + "hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," + "MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" + "False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" + "artGroupsCollection></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(592, 403)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, Me.menuItem3})
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 0
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      Me.menuItem1.Text = "&File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
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
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Error Bar Demo"
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
      setupChart()
      setupData()
   End Sub 'Form1_Load
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
