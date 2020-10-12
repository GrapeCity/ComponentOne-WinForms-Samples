
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
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuFile As System.Windows.Forms.MenuItem
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelp As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private grpChartLabels As System.Windows.Forms.GroupBox
   Private grpDataLabels As System.Windows.Forms.GroupBox
   Private grpOutlines As System.Windows.Forms.GroupBox
   Private grpStartAngle As System.Windows.Forms.GroupBox
   Private lblStartAngle As System.Windows.Forms.Label
   WithEvents txtStartAngle As System.Windows.Forms.TextBox
   WithEvents radioLabelsOn As System.Windows.Forms.RadioButton
   WithEvents radioLabelsOff As System.Windows.Forms.RadioButton
   WithEvents radioDataLabOn As System.Windows.Forms.RadioButton
   WithEvents radioDataLabOff As System.Windows.Forms.RadioButton
   WithEvents checkOutlines As System.Windows.Forms.CheckBox
   Private grpPieSliceOffsets As System.Windows.Forms.GroupBox
   Private lblSlice0Offset As System.Windows.Forms.Label
   WithEvents txtSlice0Offset As System.Windows.Forms.TextBox
   Private lblSlice1Offset As System.Windows.Forms.Label
   WithEvents txtSlice1Offset As System.Windows.Forms.TextBox
   Private lblSlice2Offset As System.Windows.Forms.Label
   WithEvents txtSlice2Offset As System.Windows.Forms.TextBox
   Private lblSlice3Offset As System.Windows.Forms.Label
   WithEvents txtSlice3Offset As System.Windows.Forms.TextBox
   Private lblSlice4Offset As System.Windows.Forms.Label
   WithEvents txtSlice4Offset As System.Windows.Forms.TextBox
   Private lblSlice5Offset As System.Windows.Forms.Label
   WithEvents txtSlice5Offset As System.Windows.Forms.TextBox
   Private lblSlice6Offset As System.Windows.Forms.Label
   WithEvents txtSlice6Offset As System.Windows.Forms.TextBox
   Private lblSlice7Offset As System.Windows.Forms.Label
   WithEvents txtSlice7Offset As System.Windows.Forms.TextBox
   Private grpOtherSlice As System.Windows.Forms.GroupBox
   Private lblOtherOffset As System.Windows.Forms.Label
   WithEvents txtOtherOffset As System.Windows.Forms.TextBox
   WithEvents menuHelpMoreInfo As System.Windows.Forms.MenuItem
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private lblElev As System.Windows.Forms.Label
   Private lblDepth As System.Windows.Forms.Label
   WithEvents udElev As System.Windows.Forms.NumericUpDown
   WithEvents udDepth As System.Windows.Forms.NumericUpDown
   WithEvents check3D As System.Windows.Forms.CheckBox
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
      Me.grpChartLabels = New System.Windows.Forms.GroupBox()
      Me.radioLabelsOff = New System.Windows.Forms.RadioButton()
      Me.radioLabelsOn = New System.Windows.Forms.RadioButton()
      Me.grpDataLabels = New System.Windows.Forms.GroupBox()
      Me.radioDataLabOff = New System.Windows.Forms.RadioButton()
      Me.radioDataLabOn = New System.Windows.Forms.RadioButton()
      Me.grpOutlines = New System.Windows.Forms.GroupBox()
      Me.checkOutlines = New System.Windows.Forms.CheckBox()
      Me.grpStartAngle = New System.Windows.Forms.GroupBox()
      Me.txtStartAngle = New System.Windows.Forms.TextBox()
      Me.lblStartAngle = New System.Windows.Forms.Label()
      Me.grpOtherSlice = New System.Windows.Forms.GroupBox()
      Me.txtOtherOffset = New System.Windows.Forms.TextBox()
      Me.lblOtherOffset = New System.Windows.Forms.Label()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuFile = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuHelp = New System.Windows.Forms.MenuItem()
      Me.menuHelpMoreInfo = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.grpPieSliceOffsets = New System.Windows.Forms.GroupBox()
      Me.lblSlice0Offset = New System.Windows.Forms.Label()
      Me.txtSlice0Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice1Offset = New System.Windows.Forms.Label()
      Me.txtSlice1Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice2Offset = New System.Windows.Forms.Label()
      Me.txtSlice2Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice3Offset = New System.Windows.Forms.Label()
      Me.txtSlice3Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice4Offset = New System.Windows.Forms.Label()
      Me.txtSlice4Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice5Offset = New System.Windows.Forms.Label()
      Me.txtSlice5Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice6Offset = New System.Windows.Forms.Label()
      Me.txtSlice6Offset = New System.Windows.Forms.TextBox()
      Me.lblSlice7Offset = New System.Windows.Forms.Label()
      Me.txtSlice7Offset = New System.Windows.Forms.TextBox()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.udElev = New System.Windows.Forms.NumericUpDown()
      Me.lblElev = New System.Windows.Forms.Label()
      Me.check3D = New System.Windows.Forms.CheckBox()
      Me.udDepth = New System.Windows.Forms.NumericUpDown()
      Me.lblDepth = New System.Windows.Forms.Label()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpChartLabels.SuspendLayout()
      Me.grpDataLabels.SuspendLayout()
      Me.grpOutlines.SuspendLayout()
      Me.grpStartAngle.SuspendLayout()
      Me.grpOtherSlice.SuspendLayout()
      Me.grpPieSliceOffsets.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      CType(Me.udElev, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.udDepth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Location = New System.Drawing.Point(136, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Footer Compass=""South""><Text /><" + "/Footer><Legend Compass=""East"" Visible=""False""><Text /></Legend><ChartArea /><He" + "ader Compass=""North""><Text /></Header><ChartGroupsCollection><ChartGroup><ChartT" + "ype>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><DataSerializer" + " DefaultSet=""True"" Hole=""3.4028234663852886E+38""><DataSeriesCollection><DataSeri" + "esSerializer><Y3 /><Y1 /><Y2 /><Y>20;22;19;24;25</Y><SymbolStyle Shape=""Box"" Col" + "or=""Coral"" /><X>1;2;3;4;5</X><SeriesLabel>series 0</SeriesLabel><LineStyle Patte" + "rn=""Solid"" Thickness=""1"" Color=""DarkGoldenrod"" /><DataTypes>Single;Single;Single" + ";Single;Single</DataTypes></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y1" + " /><Y2 /><Y>8;12;10;12;15</Y><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><" + "X>1;2;3;4;5</X><SeriesLabel>series 1</SeriesLabel><LineStyle Pattern=""Solid"" Thi" + "ckness=""1"" Color=""DarkGray"" /><DataTypes>Single;Single;Single;Single;Single</Dat" + "aTypes></DataSeriesSerializer><DataSeriesSerializer><Y3 /><Y1 /><Y2 /><Y>10;16;1" + "7;15;23</Y><SymbolStyle Shape=""Tri"" Color=""Cornsilk"" /><X>1;2;3;4;5</X><SeriesLa" + "bel>series 2</SeriesLabel><LineStyle Pattern=""Solid"" Thickness=""1"" Color=""DarkGr" + "een"" /><DataTypes>Single;Single;Single;Single;Single</DataTypes></DataSeriesSeri" + "alizer><DataSeriesSerializer><Y3 /><Y1 /><Y2 /><Y>16;19;15;22;18</Y><SymbolStyle" + " Shape=""Diamond"" Color=""Crimson"" /><X>1;2;3;4;5</X><SeriesLabel>series 3</Series" + "Label><LineStyle Pattern=""Solid"" Thickness=""1"" Color=""DarkKhaki"" /><DataTypes>Si" + "ngle;Single;Single;Single;Single</DataTypes></DataSeriesSerializer></DataSeriesC" + "ollection></DataSerializer><Name>Group1</Name><Polar>Degrees=True,PiRatioAnnotat" + "ions=True,Start=0</Polar><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumS" + "ize=5</Bubble><Radar>Degrees=True,Filled=False,Start=0</Radar><ShowOutline>True<" + "/ShowOutline><Pie>OtherOffset=0,Start=0</Pie><Stacked>False</Stacked><HiLoData>F" + "illFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=Tru" + "e</HiLoData></ChartGroup><ChartGroup><ChartType>XYPlot</ChartType><Bar>ClusterOv" + "erlap=0,ClusterWidth=50</Bar><DataSerializer Hole=""3.4028234663852886E+38"" /><Na" + "me>Group2</Name><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Bubb" + "le>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Radar>Degrees=T" + "rue,Filled=False,Start=0</Radar><ShowOutline>True</ShowOutline><Pie>OtherOffset=" + "0,Start=0</Pie><Stacked>False</Stacked><HiLoData>FillFalling=True,FillTransparen" + "t=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData></ChartGroup></Cha" + "rtGroupsCollection><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName" + ">Area</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><Nam" + "edStyle><Name>Legend</Name><ParentName>Legend.default</ParentName><StyleData /><" + "/NamedStyle><NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><Styl" + "eData>Border=None,Control,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Nam" + "e><ParentName>Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Na" + "me>Control</Name><ParentName>Control.default</ParentName><StyleData /></NamedSty" + "le><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotatio" + "n=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;Opaque=Fa" + "lse;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><Par" + "entName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;Ali" + "gnHorz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></Na" + "medStyle><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault" + ".default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default<" + "/Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;" + "AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.defau" + "lt</Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;BackCo" + "lor=Transparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentN" + "ame>Control</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyl" + "e><NamedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=Con" + "trolText;Border=None,Control,1;BackColor=Control;</StyleData></NamedStyle><Named" + "Style><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate" + "90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Cente" + "r;</StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Cont" + "rol</ParentName><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData></Nam" + "edStyle></StyleCollection><Axes><Axis _onTop=""0"" Compass=""South"" Max=""5"" Min=""1""" + " UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" " + "AutoMin=""True""><GridMajor AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""L" + "ightGray"" /><GridMinor AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""Ligh" + "tGray"" /><Text /></Axis><Axis _onTop=""0"" Compass=""West"" Max=""26"" Min=""8"" UnitMaj" + "or=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""T" + "rue""><GridMajor AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""LightGray"" " + "/><GridMinor AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""LightGray"" /><" + "Text /></Axis><Axis _onTop=""0"" Compass=""East"" Max=""0"" Min=""0"" UnitMajor=""0"" Unit" + "Minor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True""><GridM" + "ajor AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""LightGray"" /><GridMino" + "r AutoSpace=""True"" Pattern=""Dash"" Thickness=""1"" Color=""LightGray"" /><Text /></Ax" + "is></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(336, 296)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' grpChartLabels
      ' 
      Me.grpChartLabels.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioLabelsOff, radioLabelsOn})
      Me.grpChartLabels.Name = "grpChartLabels"
      Me.grpChartLabels.Size = New System.Drawing.Size(136, 39)
      Me.grpChartLabels.TabIndex = 1
      Me.grpChartLabels.TabStop = False
      Me.grpChartLabels.Text = "Chart Labels"
      ' 
      ' radioLabelsOff
      ' 
      Me.radioLabelsOff.Location = New System.Drawing.Point(8, 12)
      Me.radioLabelsOff.Name = "radioLabelsOff"
      Me.radioLabelsOff.Size = New System.Drawing.Size(39, 17)
      Me.radioLabelsOff.TabIndex = 1
      Me.radioLabelsOff.Text = "Off"
      ' 
      ' radioLabelsOn
      ' 
      Me.radioLabelsOn.Checked = True
      Me.radioLabelsOn.Location = New System.Drawing.Point(80, 12)
      Me.radioLabelsOn.Name = "radioLabelsOn"
      Me.radioLabelsOn.Size = New System.Drawing.Size(39, 16)
      Me.radioLabelsOn.TabIndex = 0
      Me.radioLabelsOn.TabStop = True
      Me.radioLabelsOn.Text = "On"
      ' 
      ' grpDataLabels
      ' 
      Me.grpDataLabels.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioDataLabOff, radioDataLabOn})
      ME.grpDataLabels.Location = new System.Drawing.Point(0, 38)
      Me.grpDataLabels.Name = "grpDataLabels"
      Me.grpDataLabels.Size = New System.Drawing.Size(136, 39)
      Me.grpDataLabels.TabIndex = 2
      Me.grpDataLabels.TabStop = False
      Me.grpDataLabels.Text = "Data Labels"
      ' 
      ' radioDataLabOff
      ' 
      Me.radioDataLabOff.Location = New System.Drawing.Point(8, 16)
      Me.radioDataLabOff.Name = "radioDataLabOff"
      Me.radioDataLabOff.Size = New System.Drawing.Size(39, 17)
      Me.radioDataLabOff.TabIndex = 1
      Me.radioDataLabOff.Text = "Off"
      ' 
      ' radioDataLabOn
      ' 
      Me.radioDataLabOn.Checked = True
      Me.radioDataLabOn.Location = New System.Drawing.Point(80, 16)
      Me.radioDataLabOn.Name = "radioDataLabOn"
      Me.radioDataLabOn.Size = New System.Drawing.Size(39, 17)
      Me.radioDataLabOn.TabIndex = 0
      Me.radioDataLabOn.TabStop = True
      Me.radioDataLabOn.Text = "On"
      ' 
      ' grpOutlines
      ' 
      Me.grpOutlines.Controls.AddRange(New System.Windows.Forms.Control() {Me.checkOutlines})
      Me.grpOutlines.Location = New System.Drawing.Point(0, 77)
      Me.grpOutlines.Name = "grpOutlines"
      Me.grpOutlines.Size = New System.Drawing.Size(136, 40)
      Me.grpOutlines.TabIndex = 3
      Me.grpOutlines.TabStop = False
      Me.grpOutlines.Text = "Outlines"
      ' 
      ' checkOutlines
      ' 
      Me.checkOutlines.Checked = True
      Me.checkOutlines.CheckState = System.Windows.Forms.CheckState.Checked
      Me.checkOutlines.Location = New System.Drawing.Point(8, 16)
      Me.checkOutlines.Name = "checkOutlines"
      Me.checkOutlines.Size = New System.Drawing.Size(96, 16)
      Me.checkOutlines.TabIndex = 0
      Me.checkOutlines.Text = "Outlines"
      ' 
      ' grpStartAngle
      ' 
      Me.grpStartAngle.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtStartAngle, lblStartAngle})
      Me.grpStartAngle.Location = New System.Drawing.Point(0, 117)
      Me.grpStartAngle.Name = "grpStartAngle"
      Me.grpStartAngle.Size = New System.Drawing.Size(136, 48)
      Me.grpStartAngle.TabIndex = 4
      Me.grpStartAngle.TabStop = False
      ' 
      ' txtStartAngle
      ' 
      Me.txtStartAngle.Location = New System.Drawing.Point(88, 16)
      Me.txtStartAngle.Name = "txtStartAngle"
      Me.txtStartAngle.Size = New System.Drawing.Size(40, 20)
      Me.txtStartAngle.TabIndex = 1
      Me.txtStartAngle.Text = "55"
      ' 
      ' lblStartAngle
      ' 
      Me.lblStartAngle.Location = New System.Drawing.Point(8, 18)
      Me.lblStartAngle.Name = "lblStartAngle"
      Me.lblStartAngle.Size = New System.Drawing.Size(80, 16)
      Me.lblStartAngle.TabIndex = 0
      Me.lblStartAngle.Text = "Starting Angle:"
      ' 
      ' grpOtherSlice
      ' 
      Me.grpOtherSlice.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOtherOffset, lblOtherOffset})
      Me.grpOtherSlice.Location = New System.Drawing.Point(0, 277)
      Me.grpOtherSlice.Name = "grpOtherSlice"
      Me.grpOtherSlice.Size = New System.Drawing.Size(136, 48)
      Me.grpOtherSlice.TabIndex = 6
      Me.grpOtherSlice.TabStop = False
      Me.grpOtherSlice.Text = "Other Slice"
      ' 
      ' txtOtherOffset
      ' 
      Me.txtOtherOffset.Location = New System.Drawing.Point(72, 16)
      Me.txtOtherOffset.Name = "txtOtherOffset"
      Me.txtOtherOffset.Size = New System.Drawing.Size(32, 20)
      Me.txtOtherOffset.TabIndex = 1
      Me.txtOtherOffset.Text = "0"
      ' 
      ' lblOtherOffset
      ' 
      Me.lblOtherOffset.Location = New System.Drawing.Point(24, 18)
      Me.lblOtherOffset.Name = "lblOtherOffset"
      Me.lblOtherOffset.Size = New System.Drawing.Size(40, 16)
      Me.lblOtherOffset.TabIndex = 0
      Me.lblOtherOffset.Text = "Offset:"
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
      Me.menuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpMoreInfo, menuHelpAbout})
      Me.menuHelp.Text = "Help"
      ' 
      ' menuHelpMoreInfo
      ' 
      Me.menuHelpMoreInfo.Index = 0
      Me.menuHelpMoreInfo.Text = "More Info ..."
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 1
      Me.menuHelpAbout.Text = "About"
      ' 
      ' grpPieSliceOffsets
      ' 
      Me.grpPieSliceOffsets.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblSlice0Offset, txtSlice0Offset, lblSlice1Offset, txtSlice1Offset, lblSlice2Offset, txtSlice2Offset, lblSlice3Offset, txtSlice3Offset, lblSlice4Offset, txtSlice4Offset, lblSlice5Offset, txtSlice5Offset, lblSlice6Offset, txtSlice6Offset, lblSlice7Offset, txtSlice7Offset})
      Me.grpPieSliceOffsets.Location = New System.Drawing.Point(0, 165)
      Me.grpPieSliceOffsets.Name = "grpPieSliceOffsets"
      Me.grpPieSliceOffsets.Size = New System.Drawing.Size(136, 112)
      Me.grpPieSliceOffsets.TabIndex = 5
      Me.grpPieSliceOffsets.TabStop = False
      Me.grpPieSliceOffsets.Text = "Pie Slice Offset Values"
      ' 
      ' lblSlice0Offset
      ' 
      Me.lblSlice0Offset.Location = New System.Drawing.Point(8, 18)
      Me.lblSlice0Offset.Name = "lblSlice0Offset"
      Me.lblSlice0Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice0Offset.TabIndex = 0
      Me.lblSlice0Offset.Text = "0:"
      ' 
      ' txtSlice0Offset
      ' 
      Me.txtSlice0Offset.Location = New System.Drawing.Point(24, 16)
      Me.txtSlice0Offset.Name = "txtSlice0Offset"
      Me.txtSlice0Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice0Offset.TabIndex = 1
      Me.txtSlice0Offset.Tag = 0
      Me.txtSlice0Offset.Text = "0"
      ' 
      ' lblSlice1Offset
      ' 
      Me.lblSlice1Offset.Location = New System.Drawing.Point(8, 40)
      Me.lblSlice1Offset.Name = "lblSlice1Offset"
      Me.lblSlice1Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice1Offset.TabIndex = 2
      Me.lblSlice1Offset.Text = "1:"
      ' 
      ' txtSlice1Offset
      ' 
      Me.txtSlice1Offset.Location = New System.Drawing.Point(24, 38)
      Me.txtSlice1Offset.Name = "txtSlice1Offset"
      Me.txtSlice1Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice1Offset.TabIndex = 3
      Me.txtSlice1Offset.Tag = 1
      Me.txtSlice1Offset.Text = "0"
      ' 
      ' lblSlice2Offset
      ' 
      Me.lblSlice2Offset.Location = New System.Drawing.Point(8, 62)
      Me.lblSlice2Offset.Name = "lblSlice2Offset"
      Me.lblSlice2Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice2Offset.TabIndex = 4
      Me.lblSlice2Offset.Text = "2:"
      ' 
      ' txtSlice2Offset
      ' 
      Me.txtSlice2Offset.Location = New System.Drawing.Point(24, 60)
      Me.txtSlice2Offset.Name = "txtSlice2Offset"
      Me.txtSlice2Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice2Offset.TabIndex = 5
      Me.txtSlice2Offset.Tag = 2
      Me.txtSlice2Offset.Text = "0"
      ' 
      ' lblSlice3Offset
      ' 
      Me.lblSlice3Offset.Location = New System.Drawing.Point(8, 84)
      Me.lblSlice3Offset.Name = "lblSlice3Offset"
      Me.lblSlice3Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice3Offset.TabIndex = 6
      Me.lblSlice3Offset.Text = "3:"
      ' 
      ' txtSlice3Offset
      ' 
      Me.txtSlice3Offset.Location = New System.Drawing.Point(24, 82)
      Me.txtSlice3Offset.Name = "txtSlice3Offset"
      Me.txtSlice3Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice3Offset.TabIndex = 7
      Me.txtSlice3Offset.Tag = 3
      Me.txtSlice3Offset.Text = "0"
      ' 
      ' lblSlice4Offset
      ' 
      Me.lblSlice4Offset.Location = New System.Drawing.Point(70, 18)
      Me.lblSlice4Offset.Name = "lblSlice4Offset"
      Me.lblSlice4Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice4Offset.TabIndex = 8
      Me.lblSlice4Offset.Text = "4:"
      ' 
      ' txtSlice4Offset
      ' 
      Me.txtSlice4Offset.Location = New System.Drawing.Point(86, 16)
      Me.txtSlice4Offset.Name = "txtSlice4Offset"
      Me.txtSlice4Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice4Offset.TabIndex = 9
      Me.txtSlice4Offset.Tag = 4
      Me.txtSlice4Offset.Text = "0"
      ' 
      ' lblSlice5Offset
      ' 
      Me.lblSlice5Offset.Location = New System.Drawing.Point(70, 40)
      Me.lblSlice5Offset.Name = "lblSlice5Offset"
      Me.lblSlice5Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice5Offset.TabIndex = 10
      Me.lblSlice5Offset.Text = "5:"
      ' 
      ' txtSlice5Offset
      ' 
      Me.txtSlice5Offset.Location = New System.Drawing.Point(86, 38)
      Me.txtSlice5Offset.Name = "txtSlice5Offset"
      Me.txtSlice5Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice5Offset.TabIndex = 11
      Me.txtSlice5Offset.Tag = 5
      Me.txtSlice5Offset.Text = "0"
      ' 
      ' lblSlice6Offset
      ' 
      Me.lblSlice6Offset.Location = New System.Drawing.Point(70, 62)
      Me.lblSlice6Offset.Name = "lblSlice6Offset"
      Me.lblSlice6Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice6Offset.TabIndex = 12
      Me.lblSlice6Offset.Text = "6:"
      ' 
      ' txtSlice6Offset
      ' 
      Me.txtSlice6Offset.Location = New System.Drawing.Point(86, 60)
      Me.txtSlice6Offset.Name = "txtSlice6Offset"
      Me.txtSlice6Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice6Offset.TabIndex = 13
      Me.txtSlice6Offset.Tag = 6
      Me.txtSlice6Offset.Text = "0"
      ' 
      ' lblSlice7Offset
      ' 
      Me.lblSlice7Offset.Location = New System.Drawing.Point(70, 84)
      Me.lblSlice7Offset.Name = "lblSlice7Offset"
      Me.lblSlice7Offset.Size = New System.Drawing.Size(16, 16)
      Me.lblSlice7Offset.TabIndex = 14
      Me.lblSlice7Offset.Text = "7:"
      ' 
      ' txtSlice7Offset
      ' 
      Me.txtSlice7Offset.Location = New System.Drawing.Point(86, 82)
      Me.txtSlice7Offset.Name = "txtSlice7Offset"
      Me.txtSlice7Offset.Size = New System.Drawing.Size(40, 20)
      Me.txtSlice7Offset.TabIndex = 15
      Me.txtSlice7Offset.Tag = 7
      Me.txtSlice7Offset.Text = "0"
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.udElev, lblElev, check3D, udDepth, lblDepth})
      Me.groupBox1.Location = New System.Drawing.Point(0, 325)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(136, 64)
      Me.groupBox1.TabIndex = 7
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "3D"
      ' 
      ' udElev
      ' 
      Me.udElev.Enabled = False
      Me.udElev.Location = New System.Drawing.Point(88, 40)
      Me.udElev.Name = "udElev"
      Me.udElev.Size = New System.Drawing.Size(40, 20)
      Me.udElev.TabIndex = 9
      ' 
      ' lblElev
      ' 
      Me.lblElev.Location = New System.Drawing.Point(48, 40)
      Me.lblElev.Name = "lblElev"
      Me.lblElev.Size = New System.Drawing.Size(32, 16)
      Me.lblElev.TabIndex = 8
      Me.lblElev.Text = "Elev."
      ' 
      ' check3D
      ' 
      Me.check3D.Location = New System.Drawing.Point(8, 16)
      Me.check3D.Name = "check3D"
      Me.check3D.Size = New System.Drawing.Size(40, 40)
      Me.check3D.TabIndex = 7
      Me.check3D.Text = "On"
      ' 
      ' udDepth
      ' 
      Me.udDepth.Enabled = False
      Me.udDepth.Location = New System.Drawing.Point(88, 16)
      Me.udDepth.Name = "udDepth"
      Me.udDepth.Size = New System.Drawing.Size(40, 20)
      Me.udDepth.TabIndex = 7
      ' 
      ' lblDepth
      ' 
      Me.lblDepth.Location = New System.Drawing.Point(48, 16)
      Me.lblDepth.Name = "lblDepth"
      Me.lblDepth.Size = New System.Drawing.Size(40, 16)
      Me.lblDepth.TabIndex = 7
      Me.lblDepth.Text = "Depth"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(592, 391)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox1, grpOtherSlice, grpPieSliceOffsets, grpStartAngle, grpOutlines, grpDataLabels, grpChartLabels, c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Pie Chart Demo"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpChartLabels.ResumeLayout(False)
      Me.grpDataLabels.ResumeLayout(False)
      Me.grpOutlines.ResumeLayout(False)
      Me.grpStartAngle.ResumeLayout(False)
      Me.grpOtherSlice.ResumeLayout(False)
      Me.grpPieSliceOffsets.ResumeLayout(False)
      Me.groupBox1.ResumeLayout(False)
      CType(Me.udElev, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.udDepth, System.ComponentModel.ISupportInitialize).EndInit()
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
      ' Center the form
      Me.CenterToParent()
      
      ' All properties can be set at Design time, however
      ' for instructional purposes, it is easier to see if
      ' the properties are set at runtime.
      ' Set up the Chart Appearance
      c1Chart1.Width = Me.ClientSize.Width - c1Chart1.Left
      c1Chart1.Height = Me.ClientSize.Height
      c1Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      c1Chart1.Style.BackColor = Color.CadetBlue
      c1Chart1.Style.Border.BorderStyle = BorderStyleEnum.InsetBevel
      
      ' Add in the header
      Dim hdr As Title = c1Chart1.Header
      hdr.Text = "Pie Chart Stuff"
      hdr.Style.Font = New Font("Arial Black", 16)
      hdr.Style.BackColor = Color.Tan
      hdr.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel
      hdr.Style.Border.Thickness = 4
      
      ' Add in the footer
      Dim ftr As Title = c1Chart1.Footer
      ftr.Text = "Nowhere"
      ftr.Style.Font = New Font("Arial Narrow", 12, FontStyle.Bold)
      ftr.LocationDefault = New Point(10, - 1)
      
      ' Setup the legend.
      Dim lgd As Legend = c1Chart1.Legend
      lgd.Compass = CompassEnum.East
      lgd.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel
      lgd.Style.Border.Color = Color.CadetBlue
      lgd.Style.Border.Thickness = 4
      lgd.Style.Font = New Font("Arial Narrow", 10)
      lgd.Style.HorizontalAlignment = AlignHorzEnum.Center
      lgd.Text = "Series"
      lgd.Visible = True
      
      ' Set the Chart area style.
      Dim area As Area = c1Chart1.ChartArea
      area.Style.Border.BorderStyle = BorderStyleEnum.RaisedBevel
      area.Style.Border.Thickness = 4
      
      ' Set the default label style.  By using the default style,
      ' all the labels styles can be handled uniformly
      c1Chart1.ChartLabels.DefaultLabelStyle.BackColor = SystemColors.Info
      c1Chart1.ChartLabels.DefaultLabelStyle.Border.BorderStyle = BorderStyleEnum.Solid
      
      ' Set up a Pie chart with 8 slices
      Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
      grp.ChartType = Chart2DTypeEnum.Pie
      grp.Pie.OtherOffset = 0
      grp.Pie.Start = Integer.Parse(txtStartAngle.Text)
      
      ' Clear existing, and add new data.
      Dim dat As ChartData = grp.ChartData
      dat.SeriesList.Clear()
      
      ' SliceValue is the relative value of the slice in the whole.
      ' These are the Y values.
      Dim SliceValue() As Integer = {30, 18, 26, 10, 40, 26, 12, 35}
      
      ' Pick a nice color for each Series.
      Dim ColorValue() As Color = {Color.Red, Color.Tan, Color.LightGreen, Color.MediumTurquoise, Color.Blue, Color.Magenta, Color.GreenYellow, Color.MediumBlue}
      
      Dim slice As Integer
      For slice = 0 To SliceValue.Length - 1
         Dim series As ChartDataSeries = dat.SeriesList.AddNewSeries()
         series.PointData.Length = 1
         series.PointData(0) = New PointF(1F, SliceValue(slice))
         series.LineStyle.Color = ColorValue(slice)
         series.Label = slice.ToString()

         'set the DataLabel to show each value and percent of the whole
         Dim dlab As DataLabel = series.DataLabel
         dlab.Compass = LabelCompassEnum.RadialText
         dlab.Offset = -2
         dlab.Text = "{#YVAL} ({%YVAL:0.00%})"
         dlab.Style.BackColor = Color.Transparent
         dlab.Style.Border.BorderStyle = BorderStyleEnum.None
         dlab.Visible = radioDataLabOn.Checked
         
         ' Add a chart label for each slice
         Dim lab As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
         lab.AttachMethod = AttachMethodEnum.DataIndex
         
         Dim amd As AttachMethodData = lab.AttachMethodData
         amd.GroupIndex = 0
         amd.PointIndex = 0
         amd.SeriesIndex = slice
         
         lab.Text = "Chart Label " + slice.ToString()
         lab.Compass = LabelCompassEnum.Radial
         lab.Connected = True
         lab.Offset = 10
         lab.Visible = radioLabelsOn.Checked
      Next slice
      
      udDepth.Minimum = 5
      udDepth.Maximum = 100
      udDepth.Value = 30
      udDepth.Increment = 5
      
      udElev.Minimum = 5
      udElev.Maximum = 85
      udElev.Value = 45
      udElev.Increment = 5
   End Sub 'Form1_Load
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Me.Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuHelpMoreInfo_Click(sender As Object, e As System.EventArgs) Handles menuHelpMoreInfo.Click
      Dim msg As String = "Click on a slice to toggle it's offset." + ControlChars.Lf + "Click on a legend entry to toggle the series display."
      
      MessageBox.Show(Me, msg, "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpMoreInfo_Click
   
   Private Sub setLabelsStatus(labelsOn As Boolean)
      Dim labels As LabelsCollection = c1Chart1.ChartLabels.LabelsCollection
      Dim lab As C1.Win.C1Chart.Label
      For Each lab In  labels
         lab.Visible = labelsOn
      Next lab
   End Sub 'setLabelsStatus
    
   Private Sub radioLabelsOn_CheckedChanged(sender As Object, e As System.EventArgs) Handles radioLabelsOn.CheckedChanged
      Dim rb As RadioButton = CType(sender, RadioButton)
      If rb.Checked Then
         setLabelsStatus(True)
      End If
   End Sub 'radioLabelsOn_CheckedChanged
    
   Private Sub radioLabelsOff_CheckedChanged(sender As Object, e As System.EventArgs) Handles radioLabelsOff.CheckedChanged
      Dim rb As RadioButton = CType(sender, RadioButton)
      If rb.Checked Then
         setLabelsStatus(False)
      End If
   End Sub 'radioLabelsOff_CheckedChanged

   Private Sub setDataLabelsStatus(labelsOn As Boolean)
      Dim seriesList as ChartDataSeriesCollection = c1Chart1.ChartGroups.Group0.ChartData.SeriesList
      Dim cds As ChartDataSeries
      For Each cds in seriesList
         cds.DataLabel.Visible = labelsOn
      Next cds
   End Sub 'setDataLabelsStatus
   
   Private Sub radioDataLabelsOn_CheckedChanged(sender As Object, e As System.EventArgs) Handles radioDataLabOn.CheckedChanged
      Dim rb As RadioButton = CType(sender, RadioButton)
      If rb.Checked Then
         setDataLabelsStatus(True)
      End If
   End Sub 'radioDataLabelsOn_CheckedChanged
    
   Private Sub radioDataLabelsOff_CheckedChanged(sender As Object, e As System.EventArgs) Handles radioDataLabOff.CheckedChanged
      Dim rb As RadioButton = CType(sender, RadioButton)
      If rb.Checked Then
         setDataLabelsStatus(False)
      End If
   End Sub 'radioDataLabelsOff_CheckedChanged

   Private Sub checkOutlines_CheckedChanged(sender As Object, e As System.EventArgs) Handles checkOutlines.CheckedChanged
      Dim cb As CheckBox = CType(sender, CheckBox)
      c1Chart1.ChartGroups(0).ShowOutline = cb.Checked
   End Sub 'checkOutlines_CheckedChanged
   
   Private Sub txtStartAngle_TextChanged(sender As Object, e As System.EventArgs) Handles txtStartAngle.TextChanged
      Dim angle As Integer = c1Chart1.ChartGroups(0).Pie.Start
      Try
         angle = Integer.Parse(txtStartAngle.Text)
         c1Chart1.ChartGroups(0).Pie.Start = angle
      Catch
      End Try
   End Sub 'txtStartAngle_TextChanged
    
   Private Sub SliceOffsetTextChanged(sender As Object, e As System.EventArgs) Handles txtSlice0Offset.TextChanged, txtSlice1Offset.TextChanged, txtSlice2Offset.TextChanged, txtSlice3Offset.TextChanged, txtSlice4Offset.TextChanged, txtSlice5Offset.TextChanged, txtSlice6Offset.TextChanged, txtSlice7Offset.TextChanged
      Dim tb As TextBox = CType(sender, TextBox)
      Dim index As Integer = CInt(tb.Tag)
      Dim serList As ChartDataSeriesCollection = c1Chart1.ChartGroups(0).ChartData.SeriesList
      If index >= 0 AndAlso index < serList.Count Then
         Dim series As ChartDataSeries = serList(index)
         Dim offset As Integer = series.Offset
         Try
            offset = Integer.Parse(tb.Text)
            series.Offset = offset
         Catch
         End Try
      End If
   End Sub 'SliceOffsetTextChanged
    
   Private Sub txtOtherOffset_TextChanged(sender As Object, e As System.EventArgs) Handles txtOtherOffset.TextChanged
      Dim tb As TextBox = CType(sender, TextBox)
      Dim offset As Integer = c1Chart1.ChartGroups(0).Pie.OtherOffset
      Try
         offset = Integer.Parse(tb.Text)
         c1Chart1.ChartGroups(0).Pie.OtherOffset = offset
      Catch
      End Try
   End Sub 'txtOtherOffset_TextChanged
    
   Private Sub txtKeyCheck(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtStartAngle.KeyPress, txtOtherOffset.KeyPress, txtSlice0Offset.KeyPress, txtSlice1Offset.KeyPress, txtSlice2Offset.KeyPress, txtSlice3Offset.KeyPress, txtSlice4Offset.KeyPress, txtSlice5Offset.KeyPress, txtSlice6Offset.KeyPress, txtSlice7Offset.KeyPress
      If e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c OrElse e.KeyChar = ControlChars.Back Then
         Return
      End If 
      e.Handled = True
   End Sub 'txtKeyCheck
   
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      If e.Button.Equals(MouseButtons.None) Then
         Dim chart As C1Chart = CType(sender, C1Chart)
         Dim [region] As ChartRegionEnum = chart.ChartRegionFromCoord(e.X, e.Y)
         
         Dim g As Integer = - 1
         Dim s As Integer = - 1
         Dim p As Integer = - 1
         Dim d As Integer = - 1
         If [region].Equals(ChartRegionEnum.Legend) Then
            If chart.Legend.SeriesFromCoord(e.X, e.Y, g, s) Then
               If g >= 0 AndAlso s >= 0 Then
                  chart.Footer.Text = "Series #" + s.ToString()
               End If
            End If
         Else
            Dim grp As ChartGroup = chart.ChartGroups(0)
            If grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, s, p, d) Then
               If d = 0 AndAlso s >= 0 AndAlso p >= 0 Then
                  chart.Footer.Text = "Slice #" + s.ToString()
               ElseIf Not chart.Footer.Text.Equals("Nowhere") Then
                  chart.Footer.Text = "Nowhere"
               End If
            End If
         End If
      End If
   End Sub 'c1Chart1_MouseMove
    
   Private Sub SetTextBoxSliceOffsetValue(series As Integer, offset As Integer)
      Dim c As Control
      For Each c In  grpPieSliceOffsets.Controls
         If TypeOf c Is TextBox AndAlso TypeOf c.Tag Is Integer AndAlso c.Tag.Equals(series) Then
            c.Text = offset.ToString()
            Return
         End If
      Next c
   End Sub 'SetTextBoxSliceOffsetValue
   
   
   Private Sub c1Chart1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseUp
      Dim chart As C1Chart = CType(sender, C1Chart)
      
      If e.Button.Equals(MouseButtons.Left) Then
         Dim g As Integer = - 1
         Dim s As Integer = - 1
         Dim p As Integer = - 1
         Dim d As Integer = - 1
         Dim grp As ChartGroup = chart.ChartGroups(0)
         Dim ser As ChartDataSeries = Nothing
         
         Dim [region] As ChartRegionEnum = chart.ChartRegionFromCoord(e.X, e.Y)
         If [region].Equals(ChartRegionEnum.Legend) Then
            If chart.Legend.SeriesFromCoord(e.X, e.Y, g, s) Then
               ser = grp.ChartData.SeriesList(s)
               If ser.Display.Equals(SeriesDisplayEnum.Show) Then
                  ser.Display = SeriesDisplayEnum.Hide
               Else
                  ser.Display = SeriesDisplayEnum.Show
               End If
            End If
            Return
         End If
         
         If grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, s, p, d) Then
            If d = 0 AndAlso s >= 0 AndAlso p >= 0 Then
               ser = grp.ChartData.SeriesList(s)
               Dim offset As Integer = ser.Offset
               If offset = 0 Then
                  offset = 40
               Else
                  offset = 0
               End If
               ser.Offset = offset
               
               SetTextBoxSliceOffsetValue(s, offset)
            End If
         End If
      End If
   End Sub 'c1Chart1_MouseUp
   
   
   Private Sub udDepth_ValueChanged(sender As Object, e As System.EventArgs) Handles udDepth.ValueChanged
      If check3D.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
      End If
   End Sub 'udDepth_ValueChanged
    
   Private Sub udElev_ValueChanged(sender As Object, e As System.EventArgs) Handles udElev.ValueChanged
      If check3D.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(udElev.Value)
      End If
   End Sub 'udElev_ValueChanged
    
   Private Sub check3D_CheckedChanged(sender As Object, e As System.EventArgs) Handles check3D.CheckedChanged
      If check3D.Checked Then
         c1Chart1.ChartArea.PlotArea.View3D.Depth = CInt(udDepth.Value)
         c1Chart1.ChartArea.PlotArea.View3D.Elevation = CInt(udElev.Value)
         
         udDepth.Enabled = True
         udElev.Enabled = True
      Else
         c1Chart1.ChartArea.PlotArea.View3D.Depth = 0
         
         udDepth.Enabled = False
         udElev.Enabled = False
      End If
   End Sub 'check3D_CheckedChanged
End Class 'Form1
