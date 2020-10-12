
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
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   Private panel2 As System.Windows.Forms.Panel
   Private panel3 As System.Windows.Forms.Panel
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private groupBox2 As System.Windows.Forms.GroupBox
   Private c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents chkESeries3 As System.Windows.Forms.CheckBox
   WithEvents chkESeries1 As System.Windows.Forms.CheckBox
   WithEvents chkESeries2 As System.Windows.Forms.CheckBox
   WithEvents chkESeries0 As System.Windows.Forms.CheckBox
   WithEvents chkHSeries3 As System.Windows.Forms.CheckBox
   WithEvents chkHSeries1 As System.Windows.Forms.CheckBox
   WithEvents chkHSeries2 As System.Windows.Forms.CheckBox
   WithEvents chkHSeries0 As System.Windows.Forms.CheckBox
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private groupBox3 As System.Windows.Forms.GroupBox
   Private lblElevation As System.Windows.Forms.Label
   Private lblRotation As System.Windows.Forms.Label
   WithEvents udRotation As System.Windows.Forms.NumericUpDown
   Private lblDepth As System.Windows.Forms.Label
   WithEvents udElevation As System.Windows.Forms.NumericUpDown
   WithEvents udDepth As System.Windows.Forms.NumericUpDown
   WithEvents chk3DOn As System.Windows.Forms.CheckBox
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
      c1Chart1.Style.BackColor = Color.LightBlue
      c1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Fillet
      c1Chart1.Style.Border.Thickness = 1
      
      ' setup header
      c1Chart1.Header.Style.BackColor = Color.LightYellow
      c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      c1Chart1.Header.Style.Border.Thickness = 1
      c1Chart1.Header.Style.Font = New Font("Arial", 10)
      c1Chart1.Header.Text = "Use the Check Boxes to the Left to Hide or Exclude a Series"
      
      ' setup chart area
      c1Chart1.ChartArea.Style.BackColor = Color.PaleGreen
      c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.RaisedBevel
      c1Chart1.ChartArea.Style.Border.Thickness = 4
      
      ' setup legend
      'c1Chart1.ChartArea.Style.BackColor = Color.PaleGreen;
      c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Groove
      c1Chart1.Legend.Style.Border.Thickness = 2
      c1Chart1.Legend.Style.Border.Color = Color.LightBlue
      c1Chart1.Legend.Style.HorizontalAlignment = C1.Win.C1Chart.AlignHorzEnum.Center
      c1Chart1.Legend.Style.Font = New Font("Tahoma", 10)
      c1Chart1.Legend.Text = "Series"
      c1Chart1.Legend.Visible = True
      
      ' setup axes
      c1Chart1.ChartArea.AxisY.Min = 0
      c1Chart1.ChartArea.AxisY.Max = 100
      
      c1Chart1.ChartArea.AxisX.GridMajor.Color = Color.Black
      c1Chart1.ChartArea.AxisY.GridMajor.Color = Color.Black
      
      c1Chart1.ChartArea.AxisX.GridMajor.Visible = True
      c1Chart1.ChartArea.AxisY.GridMajor.Visible = True
      
      ' setup chart type
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar
      c1Chart1.ChartGroups(0).Stacked = True
      
      ' setup series appearence
      c1Chart1.ChartGroups(0).ChartData(0).LineStyle.Color = Color.Red
      c1Chart1.ChartGroups(0).ChartData(1).LineStyle.Color = Color.Tan
      c1Chart1.ChartGroups(0).ChartData(2).LineStyle.Color = Color.Green
      c1Chart1.ChartGroups(0).ChartData(3).LineStyle.Color = Color.MediumTurquoise
      
      ' setup default 3D view angles
      c1Chart1.ChartArea.PlotArea.View3D.Elevation = 45
      c1Chart1.ChartArea.PlotArea.View3D.Rotation = 45
   End Sub 'setupChart
   
   
#Region " Windows Form Designer generated code "
   '/ <summary>
   '/ Required method for Designer support - do not modify
   '/ the contents of this method with the code editor.
   '/ </summary>
   Private Sub InitializeComponent()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.panel2 = New System.Windows.Forms.Panel()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.panel3 = New System.Windows.Forms.Panel()
      Me.groupBox3 = New System.Windows.Forms.GroupBox()
      Me.lblDepth = New System.Windows.Forms.Label()
      Me.udDepth = New System.Windows.Forms.NumericUpDown()
      Me.lblRotation = New System.Windows.Forms.Label()
      Me.udRotation = New System.Windows.Forms.NumericUpDown()
      Me.lblElevation = New System.Windows.Forms.Label()
      Me.udElevation = New System.Windows.Forms.NumericUpDown()
      Me.chk3DOn = New System.Windows.Forms.CheckBox()
      Me.groupBox2 = New System.Windows.Forms.GroupBox()
      Me.chkESeries3 = New System.Windows.Forms.CheckBox()
      Me.chkESeries1 = New System.Windows.Forms.CheckBox()
      Me.chkESeries2 = New System.Windows.Forms.CheckBox()
      Me.chkESeries0 = New System.Windows.Forms.CheckBox()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.chkHSeries3 = New System.Windows.Forms.CheckBox()
      Me.chkHSeries1 = New System.Windows.Forms.CheckBox()
      Me.chkHSeries2 = New System.Windows.Forms.CheckBox()
      Me.chkHSeries0 = New System.Windows.Forms.CheckBox()
      Me.panel2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panel3.SuspendLayout()
      Me.groupBox3.SuspendLayout()
      CType(Me.udDepth, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.udRotation, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.udElevation, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.groupBox2.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      Me.SuspendLayout()
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
      ' panel2
      ' 
      Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, Me.panel3})
      Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.panel2.Name = "panel2"
      Me.panel2.Size = New System.Drawing.Size(592, 403)
      Me.panel2.TabIndex = 4
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.BackColor = System.Drawing.Color.LightBlue
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(104, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Nam" + "e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Control,1;<" + "/StyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.defaul" + "t</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentNa" + "me>Control</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle" + "><NamedStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData />" + "</NamedStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</Parent" + "Name><StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</P" + "arentName><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;Bac" + "kColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><Named" + "Style><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate2" + "70;Border=None,Control,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;Align" + "Vert=Center;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><" + "ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><Name" + "dStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData>Bor" + "der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><" + "Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleData>" + "Border=None,Control,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle" + "><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Contr" + "ol,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</S" + "tyleData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentNam" + "e><StyleData>Rotation=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor" + "=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Area.de" + "fault</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;Ali" + "gnVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><Ch" + "artGroup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><DataSe" + "riesCollection><DataSeriesSerializer><LineStyle Thickness=""1"" Color=""DarkGoldenr" + "od"" Pattern=""Solid"" /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>seri" + "es 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTy" + "pes>Single;Single;Single;Single;Single</DataTypes></DataSeriesSerializer><DataSe" + "riesSerializer><LineStyle Thickness=""1"" Color=""DarkGray"" Pattern=""Solid"" /><Symb" + "olStyle Color=""CornflowerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel>" + "<X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;S" + "ingle;Single;Single</DataTypes></DataSeriesSerializer><DataSeriesSerializer><Lin" + "eStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" /><SymbolStyle Color=""Cor" + "nsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16" + ";17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Single;Single;Single</Da" + "taTypes></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=""1"" Co" + "lor=""DarkKhaki"" Pattern=""Solid"" /><SymbolStyle Color=""Crimson"" Shape=""Diamond"" /" + "><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><" + "Y2 /><Y3 /><DataTypes>Single;Single;Single;Single;Single</DataTypes></DataSeries" + "Serializer></DataSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>F" + "alse</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>" + "ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent" + "=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMet" + "hod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnn" + "otations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Sh" + "owOutline>True</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=""3.402" + "8234663852886E+38"" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlo" + "t</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=" + "50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" + "e=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,Mi" + "nimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><" + "Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline></" + "ChartGroup></ChartGroupsCollection><Header Compass=""North""><Text /></Header><Foo" + "ter Compass=""South""><Text /></Footer><Legend Compass=""East"" Visible=""False""><Tex" + "t /></Legend><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0" + ".5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" C" + "ompass=""South""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGra" + "y"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" " + "Pattern=""Dash"" /></Axis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" AutoM" + "ajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""W" + "est""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern" + "=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""D" + "ash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True""" + " AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""East""><Text " + "/><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><" + "GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /></Ax" + "is></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(488, 403)
      Me.c1Chart1.TabIndex = 6
      ' 
      ' panel3
      ' 
      Me.panel3.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox3, Me.groupBox2, Me.groupBox1})
      Me.panel3.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel3.Name = "panel3"
      Me.panel3.Size = New System.Drawing.Size(104, 403)
      Me.panel3.TabIndex = 0
      ' 
      ' groupBox3
      ' 
      Me.groupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblDepth, Me.udDepth, Me.lblRotation, Me.udRotation, Me.lblElevation, Me.udElevation, Me.chk3DOn})
      Me.groupBox3.Location = New System.Drawing.Point(0, 256)
      Me.groupBox3.Name = "groupBox3"
      Me.groupBox3.Size = New System.Drawing.Size(104, 144)
      Me.groupBox3.TabIndex = 5
      Me.groupBox3.TabStop = False
      Me.groupBox3.Text = "3D View"
      ' 
      ' lblDepth
      ' 
      Me.lblDepth.Location = New System.Drawing.Point(8, 40)
      Me.lblDepth.Name = "lblDepth"
      Me.lblDepth.Size = New System.Drawing.Size(40, 16)
      Me.lblDepth.TabIndex = 6
      Me.lblDepth.Text = "Depth"
      ' 
      ' udDepth
      ' 
      Me.udDepth.Enabled = False
      Me.udDepth.Location = New System.Drawing.Point(48, 40)
      Me.udDepth.Name = "udDepth"
      Me.udDepth.Size = New System.Drawing.Size(40, 20)
      Me.udDepth.TabIndex = 5
      ' 
      ' lblRotation
      ' 
      Me.lblRotation.Location = New System.Drawing.Point(8, 104)
      Me.lblRotation.Name = "lblRotation"
      Me.lblRotation.Size = New System.Drawing.Size(32, 16)
      Me.lblRotation.TabIndex = 4
      Me.lblRotation.Text = "Rot."
      ' 
      ' udRotation
      ' 
      Me.udRotation.Enabled = False
      Me.udRotation.Location = New System.Drawing.Point(48, 104)
      Me.udRotation.Name = "udRotation"
      Me.udRotation.Size = New System.Drawing.Size(40, 20)
      Me.udRotation.TabIndex = 3
      ' 
      ' lblElevation
      ' 
      Me.lblElevation.Location = New System.Drawing.Point(8, 72)
      Me.lblElevation.Name = "lblElevation"
      Me.lblElevation.Size = New System.Drawing.Size(40, 16)
      Me.lblElevation.TabIndex = 2
      Me.lblElevation.Text = "Elev."
      ' 
      ' udElevation
      ' 
      Me.udElevation.Enabled = False
      Me.udElevation.Location = New System.Drawing.Point(48, 72)
      Me.udElevation.Name = "udElevation"
      Me.udElevation.Size = New System.Drawing.Size(40, 20)
      Me.udElevation.TabIndex = 1
      ' 
      ' chk3DOn
      ' 
      Me.chk3DOn.Location = New System.Drawing.Point(16, 16)
      Me.chk3DOn.Name = "chk3DOn"
      Me.chk3DOn.Size = New System.Drawing.Size(40, 16)
      Me.chk3DOn.TabIndex = 0
      Me.chk3DOn.Text = "On"
      ' 
      ' groupBox2
      ' 
      Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkESeries3, Me.chkESeries1, Me.chkESeries2, Me.chkESeries0})
      Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Top
      Me.groupBox2.Location = New System.Drawing.Point(0, 128)
      Me.groupBox2.Name = "groupBox2"
      Me.groupBox2.Size = New System.Drawing.Size(104, 128)
      Me.groupBox2.TabIndex = 4
      Me.groupBox2.TabStop = False
      Me.groupBox2.Text = "Exclude"
      ' 
      ' chkESeries3
      ' 
      Me.chkESeries3.Location = New System.Drawing.Point(16, 96)
      Me.chkESeries3.Name = "chkESeries3"
      Me.chkESeries3.Size = New System.Drawing.Size(80, 24)
      Me.chkESeries3.TabIndex = 7
      Me.chkESeries3.Text = "Series 3"
      ' 
      ' chkESeries1
      ' 
      Me.chkESeries1.Location = New System.Drawing.Point(16, 48)
      Me.chkESeries1.Name = "chkESeries1"
      Me.chkESeries1.Size = New System.Drawing.Size(80, 24)
      Me.chkESeries1.TabIndex = 6
      Me.chkESeries1.Text = "Series 1"
      ' 
      ' chkESeries2
      ' 
      Me.chkESeries2.Location = New System.Drawing.Point(16, 72)
      Me.chkESeries2.Name = "chkESeries2"
      Me.chkESeries2.Size = New System.Drawing.Size(80, 24)
      Me.chkESeries2.TabIndex = 5
      Me.chkESeries2.Text = "Series 2"
      ' 
      ' chkESeries0
      ' 
      Me.chkESeries0.Location = New System.Drawing.Point(16, 24)
      Me.chkESeries0.Name = "chkESeries0"
      Me.chkESeries0.Size = New System.Drawing.Size(80, 24)
      Me.chkESeries0.TabIndex = 4
      Me.chkESeries0.Text = "Series 0"
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkHSeries3, Me.chkHSeries1, Me.chkHSeries2, Me.chkHSeries0})
      Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Top
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(104, 128)
      Me.groupBox1.TabIndex = 3
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Hide"
      ' 
      ' chkHSeries3
      ' 
      Me.chkHSeries3.Location = New System.Drawing.Point(16, 96)
      Me.chkHSeries3.Name = "chkHSeries3"
      Me.chkHSeries3.Size = New System.Drawing.Size(80, 24)
      Me.chkHSeries3.TabIndex = 7
      Me.chkHSeries3.Text = "Series 3"
      ' 
      ' chkHSeries1
      ' 
      Me.chkHSeries1.Location = New System.Drawing.Point(16, 48)
      Me.chkHSeries1.Name = "chkHSeries1"
      Me.chkHSeries1.Size = New System.Drawing.Size(80, 24)
      Me.chkHSeries1.TabIndex = 6
      Me.chkHSeries1.Text = "Series 1"
      ' 
      ' chkHSeries2
      ' 
      Me.chkHSeries2.Location = New System.Drawing.Point(16, 72)
      Me.chkHSeries2.Name = "chkHSeries2"
      Me.chkHSeries2.Size = New System.Drawing.Size(80, 24)
      Me.chkHSeries2.TabIndex = 5
      Me.chkHSeries2.Text = "Series 2"
      ' 
      ' chkHSeries0
      ' 
      Me.chkHSeries0.Location = New System.Drawing.Point(16, 24)
      Me.chkHSeries0.Name = "chkHSeries0"
      Me.chkHSeries0.Size = New System.Drawing.Size(80, 24)
      Me.chkHSeries0.TabIndex = 4
      Me.chkHSeries0.Text = "Series 0"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 403)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2})
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Menu = Me.mainMenu1
      Me.MinimizeBox = False
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Floating Stacked Bars Demo"
      Me.panel2.ResumeLayout(False)
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panel3.ResumeLayout(False)
      Me.groupBox3.ResumeLayout(False)
      CType(Me.udDepth, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.udRotation, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.udElevation, System.ComponentModel.ISupportInitialize).EndInit()
      Me.groupBox2.ResumeLayout(False)
      Me.groupBox1.ResumeLayout(False)
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
      
      udDepth.Minimum = 1
      udDepth.Value = 20
      
      udElevation.Value = 45
      udElevation.Minimum = - 45
      udElevation.Maximum = 45
      
      udRotation.Value = 45
      udRotation.Minimum = - 45
      udRotation.Maximum = 45
   End Sub 'Form1_Load
   
   
   Private Sub chkHSeries0_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHSeries0.CheckedChanged
      If chkHSeries0.Checked Then
         If chkESeries0.Checked Then
            chkESeries0.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(0).Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(0).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkHSeries0_CheckedChanged
    
   Private Sub chkHSeries1_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHSeries1.CheckedChanged
      If chkHSeries1.Checked Then
         If chkESeries1.Checked Then
            chkESeries1.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(1).Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(1).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkHSeries1_CheckedChanged
    
   Private Sub chkHSeries2_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHSeries2.CheckedChanged
      If chkHSeries2.Checked Then
         If chkESeries2.Checked Then
            chkESeries2.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(2).Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(2).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkHSeries2_CheckedChanged
    
   Private Sub chkHSeries3_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHSeries3.CheckedChanged
      If chkHSeries3.Checked Then
         If chkESeries3.Checked Then
            chkESeries3.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(3).Display = C1.Win.C1Chart.SeriesDisplayEnum.Hide
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(3).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkHSeries3_CheckedChanged
    
   Private Sub chkESeries0_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkESeries0.CheckedChanged
      If chkESeries0.Checked Then
         If chkHSeries0.Checked Then
            chkHSeries0.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(0).Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(0).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkESeries0_CheckedChanged
    
   Private Sub chkESeries1_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkESeries1.CheckedChanged
      If chkESeries1.Checked Then
         If chkHSeries1.Checked Then
            chkHSeries1.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(1).Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(1).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkESeries1_CheckedChanged
    
   Private Sub chkESeries2_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkESeries2.CheckedChanged
      If chkESeries2.Checked Then
         If chkHSeries2.Checked Then
            chkHSeries2.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(2).Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(2).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkESeries2_CheckedChanged
    
   Private Sub chkESeries3_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkESeries3.CheckedChanged
      If chkESeries3.Checked Then
         If chkHSeries3.Checked Then
            chkHSeries3.Checked = False
         End If
         c1Chart1.ChartGroups(0).ChartData.SeriesList(3).Display = C1.Win.C1Chart.SeriesDisplayEnum.Exclude
      Else
         c1Chart1.ChartGroups(0).ChartData.SeriesList(3).Display = C1.Win.C1Chart.SeriesDisplayEnum.Show
      End If
   End Sub 'chkESeries3_CheckedChanged
    
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub chk3DOn_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk3DOn.CheckedChanged
      If chk3DOn.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
         udDepth.Enabled = True
         udElevation.Enabled = True
         udRotation.Enabled = True
      Else
         c1Chart1.ChartArea.PlotArea.View3D.Depth = 0
         udDepth.Enabled = False
         udElevation.Enabled = False
         udRotation.Enabled = False
      End If
   End Sub 'chk3DOn_CheckedChanged
   
   
   Private Sub udDepth_ValueChanged(sender As Object, e As System.EventArgs) Handles udDepth.ValueChanged
      If chk3DOn.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
      End If
   End Sub 'udDepth_ValueChanged
    
   Private Sub udElevation_ValueChanged(sender As Object, e As System.EventArgs) Handles udElevation.ValueChanged
      If chk3DOn.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(udElevation.Value)
      End If
   End Sub 'udElevation_ValueChanged
    
   Private Sub udRotation_ValueChanged(sender As Object, e As System.EventArgs) Handles udRotation.ValueChanged
      If chk3DOn.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Rotation = CInt(udRotation.Value)
      End If
   End Sub 'udRotation_ValueChanged
End Class 'Form1
