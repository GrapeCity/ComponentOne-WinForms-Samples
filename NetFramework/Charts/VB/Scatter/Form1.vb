
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
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   ' series and point index
   Private si As Integer = 0
   Private pi As Integer = 0
   Private dist As Integer = 0
   
   ' mouse pointer over point of first data series
   Private onPoint As Boolean = False
   
   Private ds1, ds2 As C1.Win.C1Chart.ChartDataSeries
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem2 As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents menuOptionsShowLabels As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   
   
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
      ' setup chart style
      c1Chart1.Style.BackColor = Color.PaleTurquoise
      
      
      ' setup header
      c1Chart1.Header.Style.BackColor = Color.Tan
      c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      c1Chart1.Header.Style.Border.Thickness = 3
      c1Chart1.Header.Style.Font = New Font("Lucida console", 10, FontStyle.Bold)
      c1Chart1.Header.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center
      
      c1Chart1.Footer.Visible = False
      
      ' setup legend
      c1Chart1.Legend.Style.BackColor = Color.PowderBlue
      c1Chart1.Legend.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center
      c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised
      c1Chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South
      c1Chart1.Legend.Visible = True
      
      ' setup chart area
      c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet
      c1Chart1.ChartArea.Style.Border.Thickness = 2
      c1Chart1.ChartArea.Style.BackColor = Color.PowderBlue
      
      c1Chart1.ChartArea.PlotArea.Boxed = True
   End Sub 'setupChart
   
   
   Sub setupData()
      c1Chart1.Header.Text = "Connect the Dots!"
      
      Dim npoints As Integer = 50
      
      ' clear all data
      c1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()
      
      ' fisrt series
      ds1 = c1Chart1.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      Dim x As Single() = CType(Array.CreateInstance(GetType(Single), npoints), Single())
      Dim y As Single() = CType(Array.CreateInstance(GetType(Single), npoints), Single())
      Dim rnd As New Random()
      
      Dim i As Integer
      For i = 0 To npoints - 1
         x(i) = rnd.Next(100)
         y(i) = rnd.Next(100)
      Next i
      
      ds1.X.CopyDataIn(x)
      ds1.Y.CopyDataIn(y)
      
      ds1.SymbolStyle.Color = Color.Red
      ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      ds1.SymbolStyle.Size = 6
      ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
      ds1.Label = String.Format("Red series - {0} points", ds1.Length)
      
      ' second series
      ds2 = c1Chart1.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      ds2.SymbolStyle.Color = Color.Blue
      ds2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      ds2.SymbolStyle.Size = 6
      ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid
      ds2.LineStyle.Color = Color.Navy
      
      ds2.Label = String.Format("Blue series - {0} points", ds2.Length)
   End Sub 'setupData
   
   
   Sub showLabels(show As Boolean)
      Dim i As Integer
      For i = 0 To c1Chart1.ChartLabels.LabelsCollection.Count - 1
         c1Chart1.ChartLabels(i).Visible = show
      Next i
   End Sub 'showLabels
    
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
      Me.menuItem2 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuOptionsShowLabels = New System.Windows.Forms.MenuItem()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plot" + "Area</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Styl" + "eData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" + "ame><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyle" + "><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name>" + "</NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><N" + "ame>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleDa" + "ta>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent" + ";AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Parent" + "Name>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignH" + "orz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name></" + "NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleD" + "ata /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control" + "</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData" + "><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>La" + "belStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Pare" + "ntName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedSt" + "yle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Contr" + "ol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Nam" + "edStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Tr" + "ansparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Na" + "me>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></N" + "amedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""" + " Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" Aut" + "oMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=" + """West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash" + """ /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /" + "><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""Tru" + "e"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Gri" + "dMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMi" + "nor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /></" + "Axis></Axes><Header Compass=""North""><Text /></Header><Footer Compass=""South""><Te" + "xt /></Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartArea" + " /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar" + "><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotations=True,Star" + "t=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,St" + "art=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stacked>False</Stack" + "ed><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoDat" + "a>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=" + "True</HiLoData><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeri" + "esSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickness=""1"" Color=""Da" + "rkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=""Coral"" /><SeriesL" + "abel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTy" + "pes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2" + " /><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" Color=""DarkGray"" Pattern=""Solid""" + " /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabel>series 1</Seri" + "esLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;" + "4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>10;16;17;15;2" + "3</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" /><SymbolStyle S" + "hape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series 2</SeriesLabel><DataTypes>Sing" + "le;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSeri" + "alizer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><LineStyle Thickne" + "ss=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><SymbolStyle Shape=""Diamond"" Color=""C" + "rimson"" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;Single;Single;Sin" + "gle;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer></DataSeriesC" + "ollection></DataSerializer></ChartGroup><ChartGroup><Bar>ClusterOverlap=0,Cluste" + "rWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotat" + "ions=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>Ot" + "herOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</ChartType><Stacke" + "d>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" + "ubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=" + "True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></ChartGroupsCollect" + "ion></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(592, 395)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, menuItem3, menuItem2})
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
      ' menuItem2
      ' 
      Me.menuItem2.Index = 2
      Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuItem2.Text = "&Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "&About"
      ' 
      ' menuItem3
      ' 
      Me.menuItem3.Index = 1
      Me.menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuOptionsShowLabels})
      Me.menuItem3.Text = "&Options"
      ' 
      ' menuOptionsShowLabels
      ' 
      Me.menuOptionsShowLabels.Index = 0
      Me.menuOptionsShowLabels.Text = "ShowLabels"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 395)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Scatter Demo"
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
   
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      If c1Chart1.ChartGroups(0).CoordToDataIndex(e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, si, pi, dist) AndAlso dist <= 6 AndAlso si = 0 Then
         Cursor = Cursors.Cross
         c1Chart1.Legend.Text = [String].Format("(X = {0}, Y = {1})", ds1.X(pi), ds1.Y(pi))
         onPoint = True
      Else
         Cursor = Cursors.Default
         c1Chart1.Legend.Text = "No point selected"
         onPoint = False
      End If
   End Sub 'c1Chart1_MouseMove
   
   
   Private Sub c1Chart1_Click(sender As Object, e As System.EventArgs) Handles c1Chart1.Click
      If onPoint Then
         ' add point to the second series
         Dim len As Integer = ds2.PointData.Length
         ds2.PointData.Length = len + 1
         ds2.PointData(len) = ds1.PointData(pi)
         
         ds2.Label = String.Format("Blue series - {0} points", ds2.Length)
         
         Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
         lbl.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.DataIndex
         lbl.AttachMethodData.GroupIndex = 0
         lbl.AttachMethodData.SeriesIndex = 1
         lbl.AttachMethodData.PointIndex = len
         lbl.Text = String.Format("{0}", len + 1)
         lbl.Visible = menuOptionsShowLabels.Checked
         
         ' remove point from the first series
         If pi <> ds1.Length - 1 Then
            ds1.PointData(pi) = ds1.PointData((ds1.Length - 1))
         End If
         ds1.PointData.Length -= 1
         ds1.Label = String.Format("Red series - {0} points", ds1.Length)
         If ds1.Length = 0 Then
            c1Chart1.Header.Text = "Game Over!" + ControlChars.Lf + "Double click on the chart to restart"
         End If
      End If
   End Sub 'c1Chart1_Click
    
   Private Sub c1Chart1_DoubleClick(sender As Object, e As System.EventArgs) Handles c1Chart1.DoubleClick
      If ds1.Length = 0 Then
         setupData()
      End If
   End Sub 'c1Chart1_DoubleClick
    
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuOptionsShowLabels_Click(sender As Object, e As System.EventArgs) Handles menuOptionsShowLabels.Click
      menuOptionsShowLabels.Checked = Not menuOptionsShowLabels.Checked
      showLabels(menuOptionsShowLabels.Checked)
   End Sub 'menuOptionsShowLabels_Click
End Class 'Form1
