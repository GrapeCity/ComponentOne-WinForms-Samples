
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
   WithEvents optComplexCandle As System.Windows.Forms.RadioButton
   WithEvents optCandle As System.Windows.Forms.RadioButton
   WithEvents optHiLoOpenClose As System.Windows.Forms.RadioButton
   WithEvents optHiLo As System.Windows.Forms.RadioButton
   WithEvents chkOpenVisible As System.Windows.Forms.CheckBox
   WithEvents chkCloseVisible As System.Windows.Forms.CheckBox
   Private frTickLength As System.Windows.Forms.GroupBox
   Private frCandleWidth As System.Windows.Forms.GroupBox
   Private frChartTypes As System.Windows.Forms.GroupBox
   WithEvents chart As C1.Win.C1Chart.C1Chart
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents udTickLen As System.Windows.Forms.NumericUpDown
   WithEvents udCandleWidth As System.Windows.Forms.NumericUpDown
   Private frWidth As System.Windows.Forms.GroupBox
   WithEvents udWidth As System.Windows.Forms.NumericUpDown
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
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Me.chart = New C1.Win.C1Chart.C1Chart()
      Me.frChartTypes = New System.Windows.Forms.GroupBox()
      Me.optComplexCandle = New System.Windows.Forms.RadioButton()
      Me.optCandle = New System.Windows.Forms.RadioButton()
      Me.optHiLoOpenClose = New System.Windows.Forms.RadioButton()
      Me.optHiLo = New System.Windows.Forms.RadioButton()
      Me.chkOpenVisible = New System.Windows.Forms.CheckBox()
      Me.chkCloseVisible = New System.Windows.Forms.CheckBox()
      Me.frTickLength = New System.Windows.Forms.GroupBox()
      Me.udTickLen = New System.Windows.Forms.NumericUpDown()
      Me.frCandleWidth = New System.Windows.Forms.GroupBox()
      Me.udCandleWidth = New System.Windows.Forms.NumericUpDown()
      Me.frWidth = New System.Windows.Forms.GroupBox()
      Me.udWidth = New System.Windows.Forms.NumericUpDown()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.frChartTypes.SuspendLayout()
      Me.frTickLength.SuspendLayout()
      CType(Me.udTickLen, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.frCandleWidth.SuspendLayout()
      CType(Me.udCandleWidth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.frWidth.SuspendLayout()
      CType(Me.udWidth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' chart
      ' 
      Me.chart.Name = "chart"
      Me.chart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Plot" + "Area</Name></NamedStyle><NamedStyle><ParentName>Legend.default</ParentName><Styl" + "eData /><Name>Legend</Name></NamedStyle><NamedStyle><ParentName>Control</ParentN" + "ame><StyleData>Border=None,Control,1;</StyleData><Name>Footer</Name></NamedStyle" + "><NamedStyle><ParentName>Area.default</ParentName><StyleData /><Name>Area</Name>" + "</NamedStyle><NamedStyle><ParentName>Control.default</ParentName><StyleData /><N" + "ame>Control</Name></NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleDa" + "ta>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent" + ";AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><NamedStyle><Parent" + "Name>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignH" + "orz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>AxisY</Name></" + "NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</ParentName><StyleD" + "ata /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><ParentName>Control" + "</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData" + "><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>Control</Parent" + "Name><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData><Name>La" + "belStyleDefault.default</Name></NamedStyle><NamedStyle><ParentName>Control</Pare" + "ntName><StyleData>Border=None,Control,1;</StyleData><Name>Header</Name></NamedSt" + "yle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Border=None,Contr" + "ol,1;BackColor=Control;</StyleData><Name>Control.default</Name></NamedStyle><Nam" + "edStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Tr" + "ansparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData><Na" + "me>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.default</Name></N" + "amedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""" + " Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" Aut" + "oMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=" + """West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash" + """ /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /" + "><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""Tru" + "e"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Gri" + "dMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMi" + "nor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><Text /></" + "Axis></Axes><Header Compass=""North""><Text /></Header><Footer Compass=""South"" Vis" + "ible=""False""><Text /></Footer><Legend Compass=""East"" Visible=""False""><Text /></L" + "egend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar>ClusterOverlap=0,Clus" + "terWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=True,PiRatioAnnot" + "ations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>" + "OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>XYPlot</ChartType><Stac" + "ked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5<" + "/Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" + "e=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=""True""><DataSeriesColl" + "ection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y><LineStyle Thickne" + "ss=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Shape=""Box"" Color=""C" + "oral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;Single;Single;Singl" + "e;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSeri" + "alizer><Y3 /><Y2 /><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" Color=""DarkGray""" + " Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><SeriesLabe" + "l>series 1</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes" + "><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 />" + "<Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" " + "/><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><SeriesLabel>series 2</SeriesLabel" + "><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X>" + "</DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y2 /><Y>16;19;15;22;18</Y><L" + "ineStyle Thickness=""1"" Color=""DarkKhaki"" Pattern=""Solid"" /><SymbolStyle Shape=""D" + "iamond"" Color=""Crimson"" /><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;S" + "ingle;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializ" + "er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" + "Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" + "e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" + "0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" + "hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," + "MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" + "False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" + "artGroupsCollection></Chart2DPropBag>"

      Me.chart.Size = New System.Drawing.Size(552, 288)
      Me.chart.TabIndex = 0
      ' 
      ' frChartTypes
      ' 
      Me.frChartTypes.Controls.AddRange(New System.Windows.Forms.Control() {Me.optComplexCandle, Me.optCandle, Me.optHiLoOpenClose, Me.optHiLo})
      Me.frChartTypes.Location = New System.Drawing.Point(8, 288)
      Me.frChartTypes.Name = "frChartTypes"
      Me.frChartTypes.Size = New System.Drawing.Size(536, 48)
      Me.frChartTypes.TabIndex = 1
      Me.frChartTypes.TabStop = False
      Me.frChartTypes.Text = "Chart Types"
      ' 
      ' optComplexCandle
      ' 
      Me.optComplexCandle.Location = New System.Drawing.Point(416, 16)
      Me.optComplexCandle.Name = "optComplexCandle"
      Me.optComplexCandle.Size = New System.Drawing.Size(112, 24)
      Me.optComplexCandle.TabIndex = 3
      Me.optComplexCandle.Text = "Complex Candle"
      ' 
      ' optCandle
      ' 
      Me.optCandle.Location = New System.Drawing.Point(304, 16)
      Me.optCandle.Name = "optCandle"
      Me.optCandle.TabIndex = 2
      Me.optCandle.Text = "Candle"
      ' 
      ' optHiLoOpenClose
      ' 
      Me.optHiLoOpenClose.Location = New System.Drawing.Point(136, 16)
      Me.optHiLoOpenClose.Name = "optHiLoOpenClose"
      Me.optHiLoOpenClose.Size = New System.Drawing.Size(152, 24)
      Me.optHiLoOpenClose.TabIndex = 1
      Me.optHiLoOpenClose.Text = "Hi-Low-Open-Close"
      ' 
      ' optHiLo
      ' 
      Me.optHiLo.Location = New System.Drawing.Point(32, 16)
      Me.optHiLo.Name = "optHiLo"
      Me.optHiLo.TabIndex = 0
      Me.optHiLo.Text = "Hi-Low"
      ' 
      ' chkOpenVisible
      ' 
      Me.chkOpenVisible.Location = New System.Drawing.Point(24, 352)
      Me.chkOpenVisible.Name = "chkOpenVisible"
      Me.chkOpenVisible.Size = New System.Drawing.Size(112, 16)
      Me.chkOpenVisible.TabIndex = 2
      Me.chkOpenVisible.Text = "Open Tick Visible?"
      ' 
      ' chkCloseVisible
      ' 
      Me.chkCloseVisible.Location = New System.Drawing.Point(24, 376)
      Me.chkCloseVisible.Name = "chkCloseVisible"
      Me.chkCloseVisible.Size = New System.Drawing.Size(128, 16)
      Me.chkCloseVisible.TabIndex = 3
      Me.chkCloseVisible.Text = "Close Tick Visible?"
      ' 
      ' frTickLength
      ' 
      Me.frTickLength.Controls.AddRange(New System.Windows.Forms.Control() {Me.udTickLen})
      Me.frTickLength.Location = New System.Drawing.Point(304, 344)
      Me.frTickLength.Name = "frTickLength"
      Me.frTickLength.Size = New System.Drawing.Size(96, 48)
      Me.frTickLength.TabIndex = 4
      Me.frTickLength.TabStop = False
      Me.frTickLength.Text = "Tick Length"
      ' 
      ' udTickLen
      ' 
      Me.udTickLen.Location = New System.Drawing.Point(16, 16)
      Me.udTickLen.Maximum = New System.Decimal(New Integer() {50, 0, 0, 0})
      Me.udTickLen.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
      Me.udTickLen.Name = "udTickLen"
      Me.udTickLen.Size = New System.Drawing.Size(64, 20)
      Me.udTickLen.TabIndex = 0
      Me.udTickLen.Value = New System.Decimal(New Integer() {1, 0, 0, 0})
      ' 
      ' frCandleWidth
      ' 
      Me.frCandleWidth.Controls.AddRange(New System.Windows.Forms.Control() {Me.udCandleWidth})
      Me.frCandleWidth.Location = New System.Drawing.Point(448, 344)
      Me.frCandleWidth.Name = "frCandleWidth"
      Me.frCandleWidth.Size = New System.Drawing.Size(96, 48)
      Me.frCandleWidth.TabIndex = 5
      Me.frCandleWidth.TabStop = False
      Me.frCandleWidth.Text = "Candle Width"
      ' 
      ' udCandleWidth
      ' 
      Me.udCandleWidth.Location = New System.Drawing.Point(16, 16)
      Me.udCandleWidth.Maximum = New System.Decimal(New Integer() {50, 0, 0, 0})
      Me.udCandleWidth.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
      Me.udCandleWidth.Name = "udCandleWidth"
      Me.udCandleWidth.Size = New System.Drawing.Size(64, 20)
      Me.udCandleWidth.TabIndex = 1
      Me.udCandleWidth.Value = New System.Decimal(New Integer() {1, 0, 0, 0})
      ' 
      ' frWidth
      ' 
      Me.frWidth.Controls.AddRange(New System.Windows.Forms.Control() {Me.udWidth})
      Me.frWidth.Location = New System.Drawing.Point(160, 344)
      Me.frWidth.Name = "frWidth"
      Me.frWidth.Size = New System.Drawing.Size(96, 48)
      Me.frWidth.TabIndex = 6
      Me.frWidth.TabStop = False
      Me.frWidth.Text = "Line Thickness"
      ' 
      ' udWidth
      ' 
      Me.udWidth.Location = New System.Drawing.Point(16, 16)
      Me.udWidth.Maximum = New System.Decimal(New Integer() {50, 0, 0, 0})
      Me.udWidth.Minimum = New System.Decimal(New Integer() {1, 0, 0, 0})
      Me.udWidth.Name = "udWidth"
      Me.udWidth.Size = New System.Drawing.Size(64, 20)
      Me.udWidth.TabIndex = 1
      Me.udWidth.Value = New System.Decimal(New Integer() {1, 0, 0, 0})
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
      Me.ClientSize = New System.Drawing.Size(550, 401)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.frWidth, Me.frTickLength, Me.chkCloseVisible, Me.chkOpenVisible, Me.frChartTypes, Me.chart, Me.frCandleWidth})
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.MaximizeBox = False
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D -  HiLoOpenClose & Candle Chart Demo"
      CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
      Me.frChartTypes.ResumeLayout(False)
      Me.frTickLength.ResumeLayout(False)
      CType(Me.udTickLen, System.ComponentModel.ISupportInitialize).EndInit()
      Me.frCandleWidth.ResumeLayout(False)
      CType(Me.udCandleWidth, System.ComponentModel.ISupportInitialize).EndInit()
      Me.frWidth.ResumeLayout(False)
      CType(Me.udWidth, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Sub setupChart()
      ' setup the chart
      chart.Style.BackColor = Color.LightGray
      chart.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised
      
      ' setup the chart area
      chart.ChartArea.Style.BackColor = Color.Silver
      chart.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised
      
      ' setup the header
      chart.Header.Style.ForeColor = Color.Yellow
      chart.Header.Style.BackColor = Color.Silver
      chart.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised
      chart.Header.Style.Font = New Font("Arial", 14, FontStyle.Underline)
      
      ' setup the legend
      chart.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Inset
      chart.Legend.Style.BackColor = Color.LightGray
      chart.Legend.Compass = C1.Win.C1Chart.CompassEnum.South
      chart.Legend.Style.Font = New Font("Arial", 9, FontStyle.Bold)
      chart.Legend.Visible = True
      
      ' setup axes
      chart.ChartArea.Style.ForeColor = Color.White
      chart.ChartArea.AxisX.Min = 0.5F
      chart.ChartArea.AxisX.Max = 5.5F
      chart.ChartArea.AxisY.Min = 5F
      chart.ChartArea.AxisY.Max = 25F
   End Sub 'setupChart
   
   
   Sub setupData()
      ' remove all previous data and add one new data series
      chart.ChartGroups(0).ChartData.SeriesList.Clear()
      chart.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      
      Dim x() As Double = {1, 2, 3, 4, 5}
      Dim y_hi() As Double = {8, 12, 10, 12, 15}
      Dim y_low() As Double = {20, 22, 19, 24, 25}
      Dim y_open() As Double = {10, 16, 17, 15, 23}
      Dim y_close() As Double = {16, 19, 15, 22, 18}
      
      chart.ChartGroups(0).ChartData(0).X.CopyDataIn(x)
      chart.ChartGroups(0).ChartData(0).Y.CopyDataIn(y_hi)
      chart.ChartGroups(0).ChartData(0).Y1.CopyDataIn(y_low)
      chart.ChartGroups(0).ChartData(0).Y2.CopyDataIn(y_open)
      chart.ChartGroups(0).ChartData(0).Y3.CopyDataIn(y_close)
      
      chart.ChartGroups(0).ChartData(0).Label = "Series 1"
   End Sub 'setupData
   
   
   Sub setHiLoChart()
      chart.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLo
      
      chart.Header.Text = "Hi Lo Chart"
      
      chart.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Color = System.Drawing.Color.Blue
      
      chkOpenVisible.Enabled = False
      chkCloseVisible.Enabled = False
      frTickLength.Enabled = False
      frCandleWidth.Enabled = False
   End Sub 'setHiLoChart
   
   
   Sub setHiLoOpenCloseChart()
      chart.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose
      
      chart.Header.Text = "Hi Lo OpenClose Chart"
      
      chart.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Color = System.Drawing.Color.Green
      chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Size = CInt(udTickLen.Value)
      
      chkOpenVisible.Enabled = True
      chkCloseVisible.Enabled = True
      frTickLength.Enabled = True
      frCandleWidth.Enabled = False
   End Sub 'setHiLoOpenCloseChart
   
   
   Sub setCandleChart()
      chart.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle
      
      chart.ChartGroups(0).HiLoData.FillTransparent = True
      chart.Header.Text = "Candle Chart"
      
      chart.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Color = System.Drawing.Color.Red
      chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Size = CInt(udCandleWidth.Value)
      
      chkOpenVisible.Enabled = False
      chkCloseVisible.Enabled = False
      frTickLength.Enabled = False
      frCandleWidth.Enabled = True
   End Sub 'setCandleChart
   
   
   Sub setComplexCandleChart()
      chart.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle
      chart.ChartGroups(0).HiLoData.FillTransparent = False
      chart.ChartGroups(0).HiLoData.FillFalling = True
      
      chart.Header.Text = "Complex Candle Chart"
      
      chart.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Color = System.Drawing.Color.Red
      chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Size = CInt(udCandleWidth.Value)
      chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Color = System.Drawing.Color.Yellow
      
      chkOpenVisible.Enabled = False
      chkCloseVisible.Enabled = False
      frTickLength.Enabled = False
      frCandleWidth.Enabled = True
   End Sub 'setComplexCandleChart
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      chkCloseVisible.Checked = True
      chkOpenVisible.Checked = True
      
      setupChart()
      setupData()
      
      setHiLoChart()
      optHiLo.Checked = True
      
      udWidth.Value = 2
      udTickLen.Value = 7
      udCandleWidth.Value = 7
   End Sub 'Form1_Load
   
   
   Private Sub optCandle_Click(sender As Object, e As System.EventArgs) Handles optCandle.Click
      setCandleChart()
   End Sub 'optCandle_Click
   
   
   Private Sub optHiLo_Click(sender As Object, e As System.EventArgs) Handles optHiLo.Click
      setHiLoChart()
   End Sub 'optHiLo_Click
   
   
   Private Sub optHiLoOpenClose_Click(sender As Object, e As System.EventArgs) Handles optHiLoOpenClose.Click
      setHiLoOpenCloseChart()
   End Sub 'optHiLoOpenClose_Click
   
   
   Private Sub optComplexCandle_Click(sender As Object, e As System.EventArgs) Handles optComplexCandle.Click
      setComplexCandleChart()
   End Sub 'optComplexCandle_Click
   
   
   Private Sub chkOpenVisible_Click(sender As Object, e As System.EventArgs) Handles chkOpenVisible.Click
      chart.ChartGroups(0).HiLoData.ShowOpen = chkOpenVisible.Checked
   End Sub 'chkOpenVisible_Click
   
   
   Private Sub chkCloseVisible_Click(sender As Object, e As System.EventArgs) Handles chkCloseVisible.Click
      chart.ChartGroups(0).HiLoData.ShowClose = chkCloseVisible.Checked
   End Sub 'chkCloseVisible_Click
   
   
   Private Sub udTickLen_ValueChanged(sender As Object, e As System.EventArgs) Handles udTickLen.ValueChanged
      If chart.ChartGroups(0).ChartData.SeriesList.Count <> 0 Then
         chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Size = CInt(udTickLen.Value)
      End If
   End Sub 'udTickLen_ValueChanged
    
   Private Sub udCandleWidth_ValueChanged(sender As Object, e As System.EventArgs) Handles udCandleWidth.ValueChanged
      If chart.ChartGroups(0).ChartData.SeriesList.Count <> 0 Then
         chart.ChartGroups(0).ChartData.SeriesList(0).SymbolStyle.Size = CInt(udCandleWidth.Value)
      End If
   End Sub 'udCandleWidth_ValueChanged
    
   Private Sub udWidth_ValueChanged(sender As Object, e As System.EventArgs) Handles udWidth.ValueChanged
      If chart.ChartGroups(0).ChartData.SeriesList.Count <> 0 Then
         chart.ChartGroups(0).ChartData.SeriesList(0).LineStyle.Thickness = CInt(udWidth.Value)
      End If
   End Sub 'udWidth_ValueChanged
    
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
