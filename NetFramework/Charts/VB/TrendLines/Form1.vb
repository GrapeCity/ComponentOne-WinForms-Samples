
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Globalization
Imports System.Windows.Forms
Imports System.Data
Imports System.Text

Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents btnNewData As System.Windows.Forms.Button
   WithEvents udOrder As System.Windows.Forms.NumericUpDown
   WithEvents cbTrendType As System.Windows.Forms.ComboBox
   WithEvents cbDataType As System.Windows.Forms.ComboBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents miFile As System.Windows.Forms.MenuItem
   WithEvents miExit As System.Windows.Forms.MenuItem
   WithEvents miView As System.Windows.Forms.MenuItem
   WithEvents miStat As System.Windows.Forms.MenuItem
   WithEvents miFormula As System.Windows.Forms.MenuItem
   WithEvents miEdit As System.Windows.Forms.MenuItem
   WithEvents miCopy As System.Windows.Forms.MenuItem
   WithEvents miLegend As System.Windows.Forms.MenuItem
   Private tabControl1 As System.Windows.Forms.TabControl
   Private tabPage1 As System.Windows.Forms.TabPage
   Private tabPage2 As System.Windows.Forms.TabPage
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Private label1 As System.Windows.Forms.Label
   Private lblNumber As System.Windows.Forms.Label
   WithEvents miHelp As System.Windows.Forms.MenuItem
   WithEvents miAbout As System.Windows.Forms.MenuItem
   Private label2 As System.Windows.Forms.Label
   Private lblErrorData As System.Windows.Forms.Label
   Private lblErrorTrend As System.Windows.Forms.Label
   WithEvents cbTLCursor As System.Windows.Forms.CheckBox
   WithEvents miPaste As System.Windows.Forms.MenuItem
   WithEvents miCopyStat As System.Windows.Forms.MenuItem
   Private menuItem1 As System.Windows.Forms.MenuItem
   WithEvents cbUseYIntercept As System.Windows.Forms.CheckBox
   WithEvents udYIntercept As System.Windows.Forms.NumericUpDown
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
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
      Me.btnNewData = New System.Windows.Forms.Button()
      Me.udOrder = New System.Windows.Forms.NumericUpDown()
      Me.cbTrendType = New System.Windows.Forms.ComboBox()
      Me.cbDataType = New System.Windows.Forms.ComboBox()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.miFile = New System.Windows.Forms.MenuItem()
      Me.miExit = New System.Windows.Forms.MenuItem()
      Me.miEdit = New System.Windows.Forms.MenuItem()
      Me.miCopy = New System.Windows.Forms.MenuItem()
      Me.miCopyStat = New System.Windows.Forms.MenuItem()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.miPaste = New System.Windows.Forms.MenuItem()
      Me.miView = New System.Windows.Forms.MenuItem()
      Me.miStat = New System.Windows.Forms.MenuItem()
      Me.miFormula = New System.Windows.Forms.MenuItem()
      Me.miLegend = New System.Windows.Forms.MenuItem()
      Me.miHelp = New System.Windows.Forms.MenuItem()
      Me.miAbout = New System.Windows.Forms.MenuItem()
      Me.tabControl1 = New System.Windows.Forms.TabControl()
      Me.tabPage1 = New System.Windows.Forms.TabPage()
      Me.udYIntercept = New System.Windows.Forms.NumericUpDown()
      Me.cbUseYIntercept = New System.Windows.Forms.CheckBox()
      Me.cbTLCursor = New System.Windows.Forms.CheckBox()
      Me.lblErrorTrend = New System.Windows.Forms.Label()
      Me.lblNumber = New System.Windows.Forms.Label()
      Me.label1 = New System.Windows.Forms.Label()
      Me.tabPage2 = New System.Windows.Forms.TabPage()
      Me.lblErrorData = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      CType(Me.udOrder, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabControl1.SuspendLayout()
      Me.tabPage1.SuspendLayout()
      CType(Me.udYIntercept, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tabPage2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' btnNewData
      ' 
      Me.btnNewData.Location = New System.Drawing.Point(8, 88)
      Me.btnNewData.Name = "btnNewData"
      Me.btnNewData.Size = New System.Drawing.Size(144, 20)
      Me.btnNewData.TabIndex = 1
      Me.btnNewData.Text = "Generate new data"
      ' 
      ' udOrder
      ' 
      Me.udOrder.Location = New System.Drawing.Point(112, 80)
      Me.udOrder.Maximum = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.udOrder.Minimum = New System.Decimal(New Integer() {2, 0, 0, 0})
      Me.udOrder.Name = "udOrder"
      Me.udOrder.Size = New System.Drawing.Size(40, 20)
      Me.udOrder.TabIndex = 3
      Me.udOrder.Value = New System.Decimal(New Integer() {2, 0, 0, 0})
      ' 
      ' cbTrendType
      ' 
      Me.cbTrendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbTrendType.Location = New System.Drawing.Point(8, 48)
      Me.cbTrendType.Name = "cbTrendType"
      Me.cbTrendType.Size = New System.Drawing.Size(144, 21)
      Me.cbTrendType.TabIndex = 4
      ' 
      ' cbDataType
      ' 
      Me.cbDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbDataType.Location = New System.Drawing.Point(8, 48)
      Me.cbDataType.Name = "cbDataType"
      Me.cbDataType.Size = New System.Drawing.Size(144, 21)
      Me.cbDataType.TabIndex = 5
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, miEdit, miView, miHelp})
      ' 
      ' miFile
      ' 
      Me.miFile.Index = 0
      Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miExit})
      Me.miFile.Text = "&File"
      ' 
      ' miExit
      ' 
      Me.miExit.Index = 0
      Me.miExit.Text = "E&xit"
      ' 
      ' miEdit
      ' 
      Me.miEdit.Index = 1
      Me.miEdit.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miCopy, miCopyStat, menuItem1, miPaste})
      Me.miEdit.Text = "&Edit"
      ' 
      ' miCopy
      ' 
      Me.miCopy.Index = 0
      Me.miCopy.Text = "Copy"
      ' 
      ' miCopyStat
      ' 
      Me.miCopyStat.Index = 1
      Me.miCopyStat.Text = "Copy Statistics"
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 2
      Me.menuItem1.Text = "-"
      ' 
      ' miPaste
      ' 
      Me.miPaste.Index = 3
      Me.miPaste.Text = "Paste"
      ' 
      ' miView
      ' 
      Me.miView.Index = 2
      Me.miView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miStat, miFormula, miLegend})
      Me.miView.Text = "&View"
      ' 
      ' miStat
      ' 
      Me.miStat.Index = 0
      Me.miStat.Text = "&Statistics"
      ' 
      ' miFormula
      ' 
      Me.miFormula.Index = 1
      Me.miFormula.Text = "Fo&rmula"
      ' 
      ' miLegend
      ' 
      Me.miLegend.Index = 2
      Me.miLegend.Text = "Legend"
      ' 
      ' miHelp
      ' 
      Me.miHelp.Index = 3
      Me.miHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAbout})
      Me.miHelp.Text = "&Help"
      ' 
      ' miAbout
      ' 
      Me.miAbout.Index = 0
      Me.miAbout.Text = "About"
      ' 
      ' tabControl1
      ' 
      Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPage1, tabPage2})
      Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Left
      Me.tabControl1.Name = "tabControl1"
      Me.tabControl1.SelectedIndex = 0
      Me.tabControl1.Size = New System.Drawing.Size(168, 433)
      Me.tabControl1.TabIndex = 6
      ' 
      ' tabPage1
      ' 
      Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.udYIntercept, cbUseYIntercept, cbTLCursor, lblErrorTrend, lblNumber, label1, cbTrendType, udOrder})
      Me.tabPage1.Location = New System.Drawing.Point(4, 22)
      Me.tabPage1.Name = "tabPage1"
      Me.tabPage1.Size = New System.Drawing.Size(160, 407)
      Me.tabPage1.TabIndex = 0
      Me.tabPage1.Text = "Trend line"
      ' 
      ' udYIntercept
      ' 
      Me.udYIntercept.DecimalPlaces = 1
      Me.udYIntercept.Location = New System.Drawing.Point(104, 112)
      Me.udYIntercept.Name = "udYIntercept"
      Me.udYIntercept.Size = New System.Drawing.Size(48, 20)
      Me.udYIntercept.TabIndex = 11
      Me.udYIntercept.Visible = False
      ' 
      ' cbUseYIntercept
      ' 
      Me.cbUseYIntercept.Location = New System.Drawing.Point(8, 112)
      Me.cbUseYIntercept.Name = "cbUseYIntercept"
      Me.cbUseYIntercept.Size = New System.Drawing.Size(96, 24)
      Me.cbUseYIntercept.TabIndex = 10
      Me.cbUseYIntercept.Text = "UseYIntercept"
      ' 
      ' cbTLCursor
      ' 
      Me.cbTLCursor.Location = New System.Drawing.Point(8, 144)
      Me.cbTLCursor.Name = "cbTLCursor"
      Me.cbTLCursor.Size = New System.Drawing.Size(144, 24)
      Me.cbTLCursor.TabIndex = 9
      Me.cbTLCursor.Text = "Trend line cursor"
      ' 
      ' lblErrorTrend
      ' 
      Me.lblErrorTrend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblErrorTrend.ForeColor = System.Drawing.Color.Red
      Me.lblErrorTrend.Location = New System.Drawing.Point(8, 248)
      Me.lblErrorTrend.Name = "lblErrorTrend"
      Me.lblErrorTrend.Size = New System.Drawing.Size(144, 32)
      Me.lblErrorTrend.TabIndex = 8
      Me.lblErrorTrend.Text = "This data does not fit to the selected trend type."
      Me.lblErrorTrend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' lblNumber
      ' 
      Me.lblNumber.Location = New System.Drawing.Point(8, 80)
      Me.lblNumber.Name = "lblNumber"
      Me.lblNumber.Size = New System.Drawing.Size(96, 20)
      Me.lblNumber.TabIndex = 6
      Me.lblNumber.Text = "Number of terms:"
      Me.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(8, 24)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(100, 20)
      Me.label1.TabIndex = 5
      Me.label1.Text = "Trend line type:"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' tabPage2
      ' 
      Me.tabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblErrorData, label2, cbDataType, btnNewData})
      Me.tabPage2.Location = New System.Drawing.Point(4, 22)
      Me.tabPage2.Name = "tabPage2"
      Me.tabPage2.Size = New System.Drawing.Size(160, 407)
      Me.tabPage2.TabIndex = 1
      Me.tabPage2.Text = "Data"
      ' 
      ' lblErrorData
      ' 
      Me.lblErrorData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.lblErrorData.ForeColor = System.Drawing.Color.Red
      Me.lblErrorData.Location = New System.Drawing.Point(8, 128)
      Me.lblErrorData.Name = "lblErrorData"
      Me.lblErrorData.Size = New System.Drawing.Size(144, 32)
      Me.lblErrorData.TabIndex = 7
      Me.lblErrorData.Text = "This data does not fit to the selected trend type."
      Me.lblErrorData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(8, 24)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(144, 20)
      Me.label2.TabIndex = 6
      Me.label2.Text = "Data distribution:"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.DockPadding.Left = 150
      Me.c1Chart1.Location = New System.Drawing.Point(168, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area""><StyleData>Border=Solid,ControlText,1;BackColor=Wh" + "ite;</StyleData></NamedStyle><NamedStyle Name=""Legend"" ParentName=""Legend.defaul" + "t""><StyleData>Border=Solid,Black,1;BackColor=192, 224, 224, 224;Rounding=5 5 5 5" + ";</StyleData></NamedStyle><NamedStyle Name=""Footer"" ParentName=""Control""><StyleD" + "ata>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=""Area"" ParentN" + "ame=""Area.default""><StyleData /></NamedStyle><NamedStyle Name=""Control"" ParentNa" + "me=""Control.default""><StyleData>Border=Solid,Transparent,1;BackColor=Gainsboro;<" + "/StyleData></NamedStyle><NamedStyle Name=""AxisX"" ParentName=""Area""><StyleData>Ro" + "tation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;" + "Opaque=False;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=""AxisY"" " + "ParentName=""Area""><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignH" + "orz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></Named" + "Style><NamedStyle Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.default" + """><StyleData /></NamedStyle><NamedStyle Name=""Legend.default"" ParentName=""Contro" + "l""><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedSt" + "yle><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""Control""><StyleData" + ">Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle " + "Name=""Header"" ParentName=""Control""><StyleData>Border=None,Black,1;</StyleData></" + "NamedStyle><NamedStyle Name=""Control.default"" ParentName=""""><StyleData>ForeColor" + "=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><Nam" + "edStyle Name=""AxisY2"" ParentName=""Area""><StyleData>Rotation=Rotate90;Border=None" + ",Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData>" + "</NamedStyle><NamedStyle Name=""Area.default"" ParentName=""Control""><StyleData>Bor" + "der=None,Black,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollection><Chart" + "GroupsCollection><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" Defau" + "ltSet=""True""><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkG" + "oldenrod"" /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</Seri" + "esLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single" + ";Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></Da" + "taSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolSt" + "yle Color=""CornflowerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1" + ";2;3;4;5</X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Doubl" + "e;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSeria" + "lizer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""C" + "ornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;" + "16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</" + "DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeries" + "Serializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Di" + "amond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y" + "><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><Dat" + "aFields>;;;;</DataFields><Tag /></DataSeriesSerializer></DataSeriesCollection></" + "DataSerializer><Name>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</Cha" + "rtType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Ba" + "r><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True" + ",ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumS" + "ize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>" + "Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>Tru" + "e</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=""3.4028234663852886" + "E+38"" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType>" + "<Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLo" + "Data>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOp" + "en=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</" + "Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees" + "=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Show" + "Outline></ChartGroup></ChartGroupsCollection><Header Compass=""North"" Visible=""Fa" + "lse""><Text /></Header><Footer Compass=""South"" Visible=""False""><Text /></Footer><" + "Legend Compass=""North"" LocationDefault=""80, 80"" Visible=""False""><Text /></Legend" + "><ChartArea><Margin Top=""0"" Left=""0"" Bottom=""0"" Right=""0"" /></ChartArea><Axes><A" + "xis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""Tr" + "ue"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""South""><Text /><GridMajor " + "Visible=""True"" Spacing=""1"" AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><" + "GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""" + "25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" Auto" + "Max=""True"" AutoMin=""True"" _onTop=""0"" Compass=""West""><Text /><GridMajor Visible=""" + "True"" Spacing=""1"" AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor" + " AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0" + """ UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" A" + "utoMin=""True"" _onTop=""0"" Compass=""East""><Text /><GridMajor AutoSpace=""True"" Colo" + "r=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pat" + "tern=""Dash"" /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(464, 433)
      Me.c1Chart1.TabIndex = 7
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 433)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, tabControl1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(400, 300)
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart.Net 2D - Trend Lines Demo"
      CType(Me.udOrder, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabControl1.ResumeLayout(False)
      Me.tabPage1.ResumeLayout(False)
      CType(Me.udYIntercept, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tabPage2.ResumeLayout(False)
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
   
   Private rnd As New Random()
   Private np As Integer = 100
   Private k() As Double

   
   Enum DataType
      Poly2
      Poly3
      Poly4
      Expo
      Log
      Pow
      Fourier2
      Fourier3
      Fourier4
      Random
   End Enum 'DataType
   
   Private dtLastGenerated As DataType = DataType.Poly2
   
   
   ' generates normally distributed random numbers
   Function RandNormal(n As Integer) As Double()
      If n Mod 2 = 1 Then
         n += 1
      End If 
      Dim rn(n-1) As Double
      Dim i As Integer
      For i = 0 To (n / 2) - 1
         Do
            Dim u As Double = 2 * rnd.NextDouble() - 1
            Dim v As Double = 2 * rnd.NextDouble() - 1
            
            Dim s As Double = u * u + v * v
            
            If s < 1 Then
               s = Math.Sqrt((- 2 * Math.Log(s) / s))
               rn((2 * i)) = u * s
               rn((2 * i + 1)) = v * s
               Exit Do
            End If
         Loop While True
      Next i
      
      Return rn
   End Function 'RandNormal
   
   
   ' create pseudo-random data
   Private Sub GenerateNewData(dt As DataType)
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      Dim ds As ChartDataSeries
      
      If cd.SeriesList.Count <> 1 Then
         ' create and setup data series
         cd.SeriesList.Clear()
         ds = cd.SeriesList.AddNewSeries()
         ds.LineStyle.Pattern = LinePatternEnum.None
         ds.SymbolStyle.Color = Color.LightBlue
         ds.SymbolStyle.OutlineColor = Color.DarkBlue
         ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot
      Else
         ds = cd(0)
      End If 
      Dim x(np-1) As Double
      Dim y(np-1) As Double
      Dim nk As Integer = 2
      
      If dt = DataType.Poly3 OrElse dt = DataType.Fourier3 Then
         nk = 3
      End If 
      If dt = DataType.Poly4 OrElse dt = DataType.Fourier4 Then
         nk = 4
      End If 
      k = New Double(nk - 1) {}
      Dim i As Integer
      
      For i = 0 To k.Length - 1
         k(i) = 2 * rnd.NextDouble() - 1
         
         If dt = DataType.Fourier2 OrElse dt = DataType.Fourier3 OrElse dt = DataType.Fourier4 OrElse dt = DataType.Log Then
            k(i) *= 10
         End If
      Next i 
      Dim rns As Double() = RandNormal(np)
      
      Dim xconst As Double = 5
      
      If dt = DataType.Fourier2 OrElse dt = DataType.Fourier3 OrElse dt = DataType.Fourier4 Then
         xconst = 50
      End If 
      If dt = DataType.Log Then
         k(1) = Math.Abs(k(1))
      ElseIf dt = DataType.Pow OrElse dt = DataType.Expo Then
         If k(0) < 0 Then
            k(1) = - Math.Abs(k(1))
         Else
            k(1) = Math.Abs(k(1))
         End If
      End If 
      For i = 0 To np - 1
         x(i) = xconst * rnd.NextDouble()
         
         Select Case dt
            Case DataType.Poly2, DataType.Poly3, DataType.Poly4
               y(i) = 0
               Dim j As Integer
               For j = 0 To k.Length - 1
                  y(i) += k(j) * Math.Pow(x(i), j)
               Next j
            
            Case DataType.Log
               y(i) = k(0) * Math.Log((k(1) * x(i)))
            
            Case DataType.Pow
               y(i) = k(0) * Math.Pow(x(i), k(1))
            
            Case DataType.Expo
               y(i) = k(0) * Math.Exp((x(i) * k(1)))
            
            Case DataType.Fourier2
               y(i) = k(0) + Math.Cos(x(i)) * k(1)
            
            Case DataType.Fourier3
               y(i) = k(0) + Math.Cos(x(i)) * k(1) + Math.Sin(x(i)) * k(2)
            
            Case DataType.Fourier4
               y(i) = k(0) + Math.Cos(x(i)) * k(1) + Math.Sin(x(i)) * k(2) + Math.Cos((2 * x(i))) * k(3)
            
            Case Else
         End Select
         
         y(i) += rns(i) / 10 ' add some random noise
      Next i
      
      dtLastGenerated = dt
      
      ' put data into chart
      ds.X.CopyDataIn(x)
      ds.Y.CopyDataIn(y)
      
      ' init trend line
      If cd.TrendsList.Count = 0 Then
         Dim tl As TrendLine = cd.TrendsList.AddNewTrendLine()
         tl.SeriesIndex = 0
         tl.LineStyle.Color = Color.RoyalBlue
         tl.LineStyle.Thickness = 3
         tl.NumTerms = CInt(udOrder.Value)
         tl.ForecastBackward = 1
         tl.ForecastForward = 1
      End If
      
      ' reset axes limits
      c1Chart1.ChartArea.AxisX.AutoMax = True
      c1Chart1.ChartArea.AxisX.AutoMin = True
      c1Chart1.ChartArea.AxisY.AutoMax = True
      c1Chart1.ChartArea.AxisY.AutoMin = True
      
      ' update labels
      UpdateStatisticsLabel()
      UpdateFormulaLabel()
   End Sub 'GenerateNewData
   
   
   Overloads Private Function GetFormula(dt As DataType, k() As Double) As String
      Dim fmt As String = "G2"
      
      Dim s As String = ""
      Select Case dt
         Case DataType.Poly2, DataType.Poly3, DataType.Poly4
            s = k(0).ToString(fmt)
            Dim i As Integer
            For i = 1 To k.Length - 1
               s += String.Format("+{0}x^{1}", k(i).ToString(fmt), i)
            Next i
         
         Case DataType.Expo
            s = String.Format("{0} * exp({1}*x)", k(0).ToString(fmt), k(1).ToString(fmt))
         
         Case DataType.Log
            s = String.Format("{0} * ln({1}*x)", k(0).ToString(fmt), k(1).ToString(fmt))
         
         Case DataType.Pow
            s = String.Format("{0} * pow( x, {1})", k(0).ToString(fmt), k(1).ToString(fmt))
         
         Case DataType.Fourier2, DataType.Fourier3, DataType.Fourier4
            s = String.Format("{0} + {1}*cos(x)", k(0).ToString(fmt), k(1).ToString(fmt))
            
            If k.Length > 2 Then
               s += String.Format(" + {0}*sin(x)", k(2).ToString(fmt))
            End If 
            If k.Length > 3 Then
               s += String.Format(" + {0}*cos(2*x)", k(3).ToString(fmt))
            End If 
            If k.Length > 4 Then
               s += String.Format(" + {0}*sin(2*x)", k(4).ToString(fmt))
            End If 
         
         Case Else
      End Select
      
      Return s
   End Function 'GetFormula
   
   
   Overloads Private Function GetFormula(tlt As TrendLineTypeEnum, k() As Double) As String
      Dim s As String = ""
      Select Case tlt
         Case TrendLineTypeEnum.Polynom
               Return GetFormula(DataType.Poly2, k)
         
         Case TrendLineTypeEnum.Exponent
               Return GetFormula(DataType.Expo, k)
         
         Case TrendLineTypeEnum.Logarithmic
               Return GetFormula(DataType.Log, k)
         
         Case TrendLineTypeEnum.Power
               Return GetFormula(DataType.Pow, k)
         
         Case TrendLineTypeEnum.Fourier
               Return GetFormula(DataType.Fourier2, k)
         
         Case Else
      End Select
      
      Return s
   End Function 'GetFormula
   
   
   Private Sub UpdateFormulaLabel()
      Dim lbl As C1.Win.C1Chart.Label
      
      If c1Chart1.ChartLabels.LabelsCollection.Count < 2 Then
         ' create formula label
         lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
         lbl.AttachMethod = AttachMethodEnum.Coordinate
         lbl.AttachMethodData.X = c1Chart1.ChartArea.PlotArea.Location.X + c1Chart1.ChartArea.PlotArea.Size.Width / 2
         lbl.AttachMethodData.Y = c1Chart1.ChartArea.PlotArea.Location.Y + 20
         lbl.Style.BackColor = Color.FromArgb(192, Color.LightBlue)
         lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid
         lbl.Style.Border.Color = Color.DarkBlue
         lbl.Style.Border.Rounding.All = 15
         lbl.Style.VerticalAlignment = AlignVertEnum.Center
         lbl.Compass = LabelCompassEnum.North
      Else
         lbl = c1Chart1.ChartLabels(1)
      End If 
      Dim tl As TrendLine = Nothing
      
      If c1Chart1.ChartGroups(0).ChartData.TrendsList.Count > 0 Then
         tl = c1Chart1.ChartGroups(0).ChartData.TrendsList(0)
      Else
         Return
      End If 
      Dim rs As RegressionStatistics = tl.RegressionStatistics
      
      If rs Is Nothing OrElse rs.Coeffs Is Nothing OrElse Not miFormula.Checked Then
         lbl.Visible = False
         Return
      End If
      
      Dim tlt As TrendLineTypeEnum = CType(cbTrendType.SelectedItem, TrendLineTypeEnum)
      
      Dim s_regr As String = GetFormula(tlt, rs.Coeffs)
      Dim s_exact As String = GetFormula(dtLastGenerated, k)
      
      If s_regr.Length > 0 AndAlso s_exact.Length > 0 Then
         lbl.Visible = True
         lbl.Text = String.Format("Data formula: {0}" + ControlChars.Lf + ControlChars.Lf + "Regression formula: {1}", s_exact, s_regr)
      ElseIf s_regr.Length > 0 Then
         lbl.Visible = True
         lbl.Text = String.Format("Regression formula: {1}", s_exact, s_regr)
      Else
         lbl.Visible = False
      End If
   End Sub 'UpdateFormulaLabel
    
   Private Sub UpdateStatisticsLabel()
      Dim lbl As C1.Win.C1Chart.Label
      
      If c1Chart1.ChartLabels.LabelsCollection.Count < 1 Then
         ' create statistics label
         lbl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
         lbl.AttachMethod = AttachMethodEnum.Coordinate
         lbl.Style.BackColor = Color.FromArgb(192, Color.MistyRose)
         lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid
         lbl.Style.Border.Color = Color.IndianRed
         lbl.Style.Border.Rounding.All = 15
         lbl.Compass = LabelCompassEnum.West
         lbl.Style.VerticalAlignment = C1.Win.C1Chart.AlignVertEnum.Center
         lbl.Style.Font = New Font("Lucida Console", 8)
      Else
         lbl = c1Chart1.ChartLabels(0)
      End If 
      Dim tl As TrendLine = Nothing
      
      If c1Chart1.ChartGroups(0).ChartData.TrendsList.Count > 0 Then
         tl = c1Chart1.ChartGroups(0).ChartData.TrendsList(0)
      Else
         Return
      End If 
      Dim rs As RegressionStatistics = tl.RegressionStatistics
      
      Dim isRegression As Boolean = tl.TrendLineType = TrendLineTypeEnum.Exponent OrElse tl.TrendLineType = TrendLineTypeEnum.Fourier OrElse tl.TrendLineType = TrendLineTypeEnum.Logarithmic OrElse tl.TrendLineType = TrendLineTypeEnum.Polynom OrElse tl.TrendLineType = TrendLineTypeEnum.Power
      
      If rs Is Nothing AndAlso isRegression Then
         lblErrorData.Visible = True
         lblErrorTrend.Visible = True
      Else
         lblErrorData.Visible = False
         lblErrorTrend.Visible = False
      End If
      
      If Not (rs Is Nothing) AndAlso miStat.Checked Then
         lbl.Text = CreateStatisticsString(rs, "g4", False)
         'string.Format(
         '"Statistics\n----------\nRSQ\t= {0:g4}\nSEY\t= {1:g4}\nF\t= {2:g4}\nDF\t= {3:g4}\nSSR\t= {4:g4}\nSSE\t= {5:g4}",
         'rs.Rsq, rs.Sey, rs.F, rs.DF, rs.Ssr, rs.Sse);
         lbl.Visible = True
      Else
         lbl.Visible = False
      End If
   End Sub 'UpdateStatisticsLabel
    
   Function CreateStatisticsString(rs As RegressionStatistics, fmt As String, coeffs As Boolean) As String
      Dim s As String = "Statistics" + ControlChars.Lf + "----------" + ControlChars.Lf
      
      If coeffs Then
         Dim k As Double() = rs.Coeffs
         
         Dim i As Integer
         For i = 0 To k.Length - 1
            s += String.Format("k[{0}]" + ControlChars.Tab + "= {1}" + ControlChars.Lf, i, k(i).ToString(fmt))
         Next i
      End If 
      s += String.Format("RSQ" + ControlChars.Tab + "= {0}" + ControlChars.Lf + "SEY" + ControlChars.Tab + "= {1}" + ControlChars.Lf + "F" + ControlChars.Tab + "= {2}" + ControlChars.Lf + "DF" + ControlChars.Tab + "= {3}" + ControlChars.Lf + "SSR" + ControlChars.Tab + "= {4}" + ControlChars.Lf + "SSE" + ControlChars.Tab + "= {5}", rs.Rsq.ToString(fmt), rs.Sey.ToString(fmt), rs.F.ToString(fmt), rs.DF.ToString(fmt), rs.Ssr.ToString(fmt), rs.Sse.ToString(fmt))
      
      Return s
   End Function 'CreateStatisticsString
   
   
   Private Sub CopyDataToClipboard(ds As ChartDataSeries)
      Dim x As Double() = CType(ds.X.CopyDataOut(GetType(Double)), Double())
      Dim y As Double() = CType(ds.Y.CopyDataOut(GetType(Double)), Double())
      
      Dim len As Integer = x.Length
      
      Dim ss(len-1) As Double
      Dim sb As New StringBuilder()
      
      Dim i As Integer
      For i = 0 To len - 1
         sb.AppendFormat("{0}" + ControlChars.Tab + "{1}" + ControlChars.Lf, x(i), y(i))
      Next i 
      Clipboard.SetDataObject(sb.ToString(), False)
   End Sub 'CopyDataToClipboard
   
   
   Private Sub PasteDataFromClipboard(ds As ChartDataSeries)
      Try
         Dim obj As IDataObject = Clipboard.GetDataObject()
         
         Dim s As String = CStr(obj.GetData(GetType(String)))
         
         Dim ss As String() = s.Split()
         
         Dim np As Integer = 0
         Dim i As Integer
         
         Dim al As New ArrayList()
         
         For i = 0 To ss.Length - 1
            If ss(i).Length > 0 Then
               al.Add(ss(i))
            End If
         Next i 
         np = al.Count / 2
         
         If np < 2 Then
            MessageBox.Show("No available data in clipboard")
            Return
         End If
         
         Dim x(np-1) As Double
         Dim y(np-1) As Double
         For i = 0 To np - 1
            Dim res As Double = 0
            
            If ParseDouble(CStr(al((2 * i + 1))), res) Then
               x(i) = res
            Else
               Throw New FormatException()
            End If 
            If ParseDouble(CStr(al((2 * i))), res) Then
               y(i) = res
            Else
               Throw New FormatException()
            End If
         Next i 
         ds.X.CopyDataIn(x)
         ds.Y.CopyDataIn(y)
         
         dtLastGenerated = DataType.Random
         
         UpdateStatisticsLabel()
         UpdateFormulaLabel()
      Catch
         MessageBox.Show("No available data in clipboard")
      End Try
   End Sub 'PasteDataFromClipboard
   
   
   Private Function ParseDouble(s As String, ByRef result As Double) As Boolean
      If Not Double.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, result) Then
         Return Double.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, result)
      End If
      Return True
   End Function 'ParseDouble
   
   
   Private Sub btnNewData_Click(sender As Object, e As System.EventArgs) Handles btnNewData.Click
      GenerateNewData(CType(cbDataType.SelectedItem, DataType))
   End Sub 'btnNewData_Click
   
   
   Private Sub udOrder_ValueChanged(sender As Object, e As System.EventArgs) Handles udOrder.ValueChanged
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      
      If cd.TrendsList.Count > 0 Then
         Dim tl As TrendLine = cd.TrendsList(0)
         
         If tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage Then
            tl.Period = CInt(udOrder.Value)
         Else
            tl.NumTerms = CInt(udOrder.Value)
         End If 
         UpdateStatisticsLabel()
         UpdateFormulaLabel()
      End If
   End Sub 'udOrder_ValueChanged
   
   
   Private Sub InitComboFromEnum(cb As ComboBox, entype As Type)
      Dim arr As Array = [Enum].GetValues(entype)
      Dim i As Integer
      For i = 0 To arr.Length - 1
         cb.Items.Add(arr.GetValue(i))
      Next i 
      cb.SelectedItem = arr.GetValue(0)
   End Sub 'InitComboFromEnum
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      c1Chart1.Legend.Orientation = LegendOrientationEnum.Vertical
      
      InitComboFromEnum(cbTrendType, GetType(TrendLineTypeEnum))
      InitComboFromEnum(cbDataType, GetType(DataType))
      c1Chart1.UseAntiAliasedGraphics = True
      
      GenerateNewData(CType(cbDataType.SelectedItem, DataType))
      
      udYIntercept.Minimum = - 10
      udYIntercept.Maximum = 10
   End Sub 'Form1_Load
   
   
   Private Sub cbTrendType_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbTrendType.SelectedIndexChanged
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      
      If cd.TrendsList.Count > 0 Then
         Dim tl As TrendLine = cd.TrendsList(0)
         tl.TrendLineType = CType(cbTrendType.SelectedItem, TrendLineTypeEnum)
         If tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage Then
            udOrder.Maximum = np
         Else
            udOrder.Maximum = 5
         End If 
         Dim isNumber As Boolean = tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage OrElse tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.Polynom OrElse tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.Fourier
         
         lblNumber.Visible = isNumber
         udOrder.Visible = isNumber
         
         Dim isPoly As Boolean = tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.Polynom
         
         cbUseYIntercept.Visible = isPoly
         udYIntercept.Visible = isPoly
         
         If tl.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.MovingAverage Then
            lblNumber.Text = "Period:"
         Else
            lblNumber.Text = "Number of terms:"
         End If 
         UpdateStatisticsLabel()
         UpdateFormulaLabel()
      End If
   End Sub 'cbTrendType_SelectedIndexChanged
   
   
   Private Sub c1Chart1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles c1Chart1.Paint
      If hasPoint Then
         Dim pen As New Pen(Color.Red, 2)
         e.Graphics.DrawEllipse(pen, tlp0.X - 5, tlp0.Y - 5, 11, 11)
         pen.Dispose()
      End If
   End Sub 'c1Chart1_Paint
   
   Private hasPoint As Boolean = False
   Private tlp0 As Point
   
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      Dim mpt As New Point(e.X, e.Y)
      
      Dim pa As PlotArea = c1Chart1.ChartArea.PlotArea
      
      Dim rect As New Rectangle(pa.Location, pa.Size)
      
      If rect.Contains(mpt) AndAlso Me.cbTLCursor.Checked Then
         Dim cg As ChartGroup = c1Chart1.ChartGroups(0)
         If cg.ChartData.TrendsList.Count > 0 Then
            Dim tl As TrendLine = cg.ChartData.TrendsList(0)
            
            Dim x As Double = 0
            Dim y As Double = 0
            Dim ix As Integer = 0
            Dim iy As Integer = 0
            
            If Not (tl.RegressionStatistics Is Nothing) Then
               If cg.CoordToDataCoord(mpt.X, mpt.Y, x, y) Then
                  y = tl.GetY(x)
                  
                  If cg.DataCoordToCoord(x, y, ix, iy) AndAlso rect.Contains(ix, iy) Then
                     Dim tlp As New Point(ix, iy)
                     
                     hasPoint = True
                     
                     Dim invRect As New Rectangle(tlp.X - 8, tlp.Y - 8, 16, 16)
                     
                     If Not tlp0.IsEmpty Then
                        invRect = Rectangle.Union(invRect, New Rectangle(tlp0.X - 8, tlp0.Y - 8, 16, 16))
                     End If 
                     c1Chart1.Invalidate(invRect)
                     
                     tlp0 = tlp
                     
                     Return
                  End If
               End If
            End If
         End If
      End If
      hasPoint = False
   End Sub 'c1Chart1_MouseMove
   
   
   Private Sub c1Chart1_LayoutLabels(sender As Object, e As System.EventArgs) Handles c1Chart1.LayoutLabels
      Dim p As Point = c1Chart1.ChartArea.PlotArea.Location
      
      If c1Chart1.Legend.Visible Then
         c1Chart1.Legend.Location = New Point(p.X + 20, p.Y + 20)
      End If 
      If c1Chart1.ChartLabels.LabelsCollection.Count > 0 Then
         Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels(0)
         
         p.X += c1Chart1.ChartArea.PlotArea.Size.Width - 10
         p.Y += c1Chart1.ChartArea.PlotArea.Size.Height / 2
         
         lbl.AttachMethodData.X = p.X
         lbl.AttachMethodData.Y = p.Y
      End If
      
      If c1Chart1.ChartLabels.LabelsCollection.Count > 1 Then
         Dim lbl As C1.Win.C1Chart.Label = c1Chart1.ChartLabels(1)
         
         p = c1Chart1.ChartArea.PlotArea.Location
         
         p.X += c1Chart1.ChartArea.PlotArea.Size.Width / 2
         p.Y += c1Chart1.ChartArea.PlotArea.Size.Height - 10
         
         lbl.AttachMethodData.X = p.X
         lbl.AttachMethodData.Y = p.Y
      End If
   End Sub 'c1Chart1_LayoutLabels
   
   
   ' menu handlers
   Private Sub miStat_Click(sender As Object, e As System.EventArgs) Handles miStat.Click
      miStat.Checked = Not miStat.Checked
      UpdateStatisticsLabel()
   End Sub 'miStat_Click
   
   
   Private Sub miExit_Click(sender As Object, e As System.EventArgs) Handles miExit.Click
      Close()
   End Sub 'miExit_Click
   
   
   Private Sub miCopy_Click(sender As Object, e As System.EventArgs) Handles miCopy.Click
      CopyDataToClipboard(c1Chart1.ChartGroups(0).ChartData(0))
   End Sub 'miCopy_Click
   
   
   Private Sub miLegend_Click(sender As Object, e As System.EventArgs) Handles miLegend.Click
      miLegend.Checked = Not miLegend.Checked
      c1Chart1.Legend.Visible = miLegend.Checked
   End Sub 'miLegend_Click
   
   
   Private Sub miFormula_Click(sender As Object, e As System.EventArgs) Handles miFormula.Click
      miFormula.Checked = Not miFormula.Checked
      UpdateFormulaLabel()
   End Sub 'miFormula_Click
   
   
   Private Sub miAbout_Click(sender As Object, e As System.EventArgs) Handles miAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'miAbout_Click
   
   
   Private Sub cbTLCursor_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbTLCursor.CheckedChanged
      If Not cbTLCursor.Checked Then
         c1Chart1.Invalidate()
      End If
   End Sub 'cbTLCursor_CheckedChanged
    
   Private Sub miPaste_Click(sender As Object, e As System.EventArgs) Handles miPaste.Click
      PasteDataFromClipboard(c1Chart1.ChartGroups(0).ChartData(0))
   End Sub 'miPaste_Click
   
   
   Private Sub miCopyStat_Click(sender As Object, e As System.EventArgs) Handles miCopyStat.Click
      Dim cg As ChartGroup = c1Chart1.ChartGroups(0)
      If cg.ChartData.TrendsList.Count > 0 Then
         Dim tl As TrendLine = cg.ChartData.TrendsList(0)
         
         Dim rs As RegressionStatistics = tl.RegressionStatistics
         
         If Not (rs Is Nothing) Then
            Clipboard.SetDataObject(CreateStatisticsString(rs, "e", True), False)
         End If
      End If
   End Sub 'miCopyStat_Click
    
   Private Sub cbUseYIntercept_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbUseYIntercept.CheckedChanged
      Dim cg As ChartGroup = c1Chart1.ChartGroups(0)
      If cg.ChartData.TrendsList.Count > 0 Then
         Dim tl As TrendLine = cg.ChartData.TrendsList(0)
         tl.RegressionOptions.UseYIntercept = cbUseYIntercept.Checked
         
         UpdateStatisticsLabel()
         UpdateFormulaLabel()
      End If
      
      udYIntercept.Visible = cbUseYIntercept.Checked
   End Sub 'cbUseYIntercept_CheckedChanged
   
   
   Private Sub udYIntercept_ValueChanged(sender As Object, e As System.EventArgs) Handles udYIntercept.ValueChanged
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      
      If cd.TrendsList.Count > 0 Then
         Dim tl As TrendLine = cd.TrendsList(0)
         
         tl.RegressionOptions.YIntercept = CDbl(udYIntercept.Value)
         
         UpdateStatisticsLabel()
         UpdateFormulaLabel()
      End If
   End Sub 'udYIntercept_ValueChanged
End Class 'Form1
