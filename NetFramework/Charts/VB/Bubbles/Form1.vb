
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
   WithEvents chart As C1.Win.C1Chart.C1Chart
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
      ' setup chart style
      chart.Style.BackColor = Color.Firebrick
      chart.Style.ForeColor = Color.Navy
      
      ' setup header
      chart.Header.Style.BackColor = Color.Tan
      chart.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      chart.Header.Style.Border.Thickness = 5
      chart.Header.Style.Font = New Font("Arial", 10, FontStyle.Italic)
      chart.Header.Location = New Point(10, 20)
      chart.Header.Text = "Average length of stay for patients" + ControlChars.Lf + "with the same type of illness" + ControlChars.Lf + "at three different hospitals"
      
      ' setup footer
      chart.Footer.Style.BackColor = Color.Tan
      chart.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      chart.Footer.Style.Border.Thickness = 5
      chart.Footer.Style.Font = New Font("Arial", 10)
      chart.Footer.Text = "Nowhere"
      chart.Footer.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center
      
      ' setup label
      Dim lbl As C1.Win.C1Chart.Label = chart.ChartLabels.LabelsCollection.AddNewLabel()
      lbl.Style.BackColor = Color.Tan
      lbl.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      lbl.Style.Border.Thickness = 5
      lbl.Style.ForeColor = Color.DarkViolet
      lbl.Style.Font = New Font("Arial", 10)
      lbl.Text = "Move the mouse over a Bubble" + ControlChars.Lf + " to see length of stay in days"
      lbl.Compass = C1.Win.C1Chart.LabelCompassEnum.SouthEast
      lbl.AttachMethodData.X = 250
      lbl.AttachMethodData.Y = 20
      lbl.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center
      lbl.Visible = True
      
      ' setup chart area
      chart.ChartArea.Style.BackColor = Color.Tan
      chart.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.InsetBevel
      chart.ChartArea.Style.Border.Thickness = 5
      
      ' setup axis X
      Dim vlbl As C1.Win.C1Chart.ValueLabel = chart.ChartArea.AxisX.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 1
      vlbl.Text = "General"
      
      vlbl = chart.ChartArea.AxisX.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 2
      vlbl.Text = "Western"
      
      vlbl = chart.ChartArea.AxisX.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 3
      vlbl.Text = "Eastern"
      
      chart.ChartArea.AxisX.Min = 0.5F
      chart.ChartArea.AxisX.Max = 3.5F
      
      chart.ChartArea.AxisX.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels
      
      ' setup axis Y
      vlbl = chart.ChartArea.AxisY.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 1
      vlbl.Text = "Men"
      
      vlbl = chart.ChartArea.AxisY.ValueLabels.AddNewLabel()
      vlbl.NumericValue = 2
      vlbl.Text = "Women"
      
      chart.ChartArea.AxisY.Min = 0
      chart.ChartArea.AxisY.Max = 3
      
      chart.ChartArea.AxisY.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels
      
      chart.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bubble
   End Sub 'setupChart
   
   
   Sub setupData()
      ' Clear the existing data
      chart.ChartGroups(0).ChartData.SeriesList.Clear()
      
      ' Add the data
      ' first series
      Dim series1 As C1.Win.C1Chart.ChartDataSeries = chart.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      
      Dim x() As Single = {1, 2, 3}
      Dim y() As Single = {1, 1, 1}
      Dim y1() As Single = {33.16667F, 10, 25.33333F}
      
      series1.X.CopyDataIn(x)
      series1.Y.CopyDataIn(y)
      series1.Y1.CopyDataIn(y1)
      
      series1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      series1.SymbolStyle.Color = Color.IndianRed
      series1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
      
      ' second series
      Dim series2 As C1.Win.C1Chart.ChartDataSeries = chart.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      
      y = New Single() {2, 2, 2}
      y1 = New Single() {30.5F, 5.833333F, 13.16667F}
      
      series2.X.CopyDataIn(x)
      series2.Y.CopyDataIn(y)
      series2.Y1.CopyDataIn(y1)
      
      series2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      series2.SymbolStyle.Color = Color.LightSeaGreen
      series2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None
   End Sub 'setupData
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.chart = New C1.Win.C1Chart.C1Chart()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' chart
      ' 
      Me.chart.BackColor = System.Drawing.Color.Firebrick
      Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
      Me.chart.Name = "chart"
      Me.chart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plot" + "Area</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Styl" + "eData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" + "ame><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyle" + "><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name>" + "</NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><N" + "ame>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleDa" + "ta>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent" + ";AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Parent" + "Name>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignH" + "orz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name></" + "NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleD" + "ata /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control" + "</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData" + "><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>La" + "belStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Pare" + "ntName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedSt" + "yle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Contr" + "ol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Nam" + "edStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Tr" + "ansparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Na" + "me>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></N" + "amedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""" + " Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" Aut" + "oMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=" + """West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash" + """ /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /" + "><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""Tru" + "e"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Gri" + "dMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMi" + "nor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /></" + "Axis></Axes><Header Compass=""North""><Text /></Header><Footer Compass=""South""><Te" + "xt /></Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartArea" + " /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,ClusterWidth=50</Bar" + "><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotations=True,Star" + "t=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,St" + "art=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stacked>False</Stack" + "ed><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoDat" + "a>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=" + "True</HiLoData><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeri" + "esSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickness=""1"" Color=""Da" + "rkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=""Coral"" /><SeriesL" + "abel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTy" + "pes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2" + " /><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" Color=""DarkGray"" Pattern=""Solid""" + " /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabel>series 1</Seri" + "esLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;" + "4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>10;16;17;15;2" + "3</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" /><SymbolStyle S" + "hape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series 2</SeriesLabel><DataTypes>Sing" + "le;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSeri" + "alizer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><LineStyle Thickne" + "ss=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><SymbolStyle Shape=""Diamond"" Color=""C" + "rimson"" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;Single;Single;Sin" + "gle;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer></DataSeriesC" + "ollection></DataSerializer></ChartGroup><ChartGroup><Bar>ClusterOverlap=0,Cluste" + "rWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnotat" + "ions=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>Ot" + "herOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</ChartType><Stacke" + "d>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</B" + "ubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=" + "True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></ChartGroupsCollect" + "ion></Chart2DPropBag>"

      Me.chart.Size = New System.Drawing.Size(592, 403)
      Me.chart.TabIndex = 6
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
      Me.BackColor = System.Drawing.Color.Maroon
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chart})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Bubble Chart Demo"
      CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Private Sub chart_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles chart.MouseMove
      Dim row As Integer = 0
      Dim col As Integer = 0
      Dim dist As Integer = 0
      If chart.ChartGroups(0).CoordToDataIndex(e.X, e.Y, C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, row, col, dist) Then
         If dist <= 10 Then
            chart.Footer.Text = [String].Format("({0},{1}) = {2}", row, col, Me.chart.ChartGroups(0).ChartData.SeriesList(row).Y1(col))
         Else
            chart.Footer.Text = "Nowhere"
         End If
      End If
   End Sub 'chart_MouseMove
    
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      setupChart()
      setupData()
   End Sub 'Form1_Load
End Class 'Form1
