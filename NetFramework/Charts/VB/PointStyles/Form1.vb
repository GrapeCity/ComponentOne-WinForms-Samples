
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
   Private panel1 As System.Windows.Forms.Panel
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents cbMethod As System.Windows.Forms.ComboBox
   WithEvents cbChartType As System.Windows.Forms.ComboBox
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   WithEvents udPointIndex As System.Windows.Forms.NumericUpDown
   Private label3 As System.Windows.Forms.Label
   Private label4 As System.Windows.Forms.Label
   WithEvents udSeriesIndex As System.Windows.Forms.NumericUpDown
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents miFile As System.Windows.Forms.MenuItem
   WithEvents miNewData As System.Windows.Forms.MenuItem
   Private menuItem3 As System.Windows.Forms.MenuItem
   WithEvents miExit As System.Windows.Forms.MenuItem
   WithEvents miHelp As System.Windows.Forms.MenuItem
   WithEvents miAbout As System.Windows.Forms.MenuItem
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
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.label4 = New System.Windows.Forms.Label()
      Me.udSeriesIndex = New System.Windows.Forms.NumericUpDown()
      Me.label3 = New System.Windows.Forms.Label()
      Me.udPointIndex = New System.Windows.Forms.NumericUpDown()
      Me.label2 = New System.Windows.Forms.Label()
      Me.label1 = New System.Windows.Forms.Label()
      Me.cbChartType = New System.Windows.Forms.ComboBox()
      Me.cbMethod = New System.Windows.Forms.ComboBox()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.miFile = New System.Windows.Forms.MenuItem()
      Me.miNewData = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.miExit = New System.Windows.Forms.MenuItem()
      Me.miHelp = New System.Windows.Forms.MenuItem()
      Me.miAbout = New System.Windows.Forms.MenuItem()
      Me.panel1.SuspendLayout()
      CType(Me.udSeriesIndex, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.udPointIndex, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label4, udSeriesIndex, label3, udPointIndex, label2, label1, cbChartType, cbMethod})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(160, 425)
      Me.panel1.TabIndex = 1
      ' 
      ' label4
      ' 
      Me.label4.Location = New System.Drawing.Point(16, 152)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(72, 21)
      Me.label4.TabIndex = 7
      Me.label4.Text = "Series index"
      Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' udSeriesIndex
      ' 
      Me.udSeriesIndex.Location = New System.Drawing.Point(96, 152)
      Me.udSeriesIndex.Maximum = New System.Decimal(New Integer() {1, 0, 0, 0})
      Me.udSeriesIndex.Name = "udSeriesIndex"
      Me.udSeriesIndex.Size = New System.Drawing.Size(40, 20)
      Me.udSeriesIndex.TabIndex = 6
      ' 
      ' label3
      ' 
      Me.label3.Location = New System.Drawing.Point(16, 184)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(72, 21)
      Me.label3.TabIndex = 5
      Me.label3.Text = "Point index"
      Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' udPointIndex
      ' 
      Me.udPointIndex.Location = New System.Drawing.Point(96, 184)
      Me.udPointIndex.Name = "udPointIndex"
      Me.udPointIndex.Size = New System.Drawing.Size(40, 20)
      Me.udPointIndex.TabIndex = 4
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(16, 88)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(112, 20)
      Me.label2.TabIndex = 3
      Me.label2.Text = "Point style selection"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(16, 24)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(120, 20)
      Me.label1.TabIndex = 2
      Me.label1.Text = "Chart type"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      ' 
      ' cbChartType
      ' 
      Me.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbChartType.Items.AddRange(New Object() {"XYPlot", "Bar"})
      Me.cbChartType.Location = New System.Drawing.Point(16, 48)
      Me.cbChartType.Name = "cbChartType"
      Me.cbChartType.Size = New System.Drawing.Size(121, 21)
      Me.cbChartType.TabIndex = 1
      ' 
      ' cbMethod
      ' 
      Me.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbMethod.Location = New System.Drawing.Point(16, 112)
      Me.cbMethod.Name = "cbMethod"
      Me.cbMethod.Size = New System.Drawing.Size(121, 21)
      Me.cbMethod.TabIndex = 0
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(160, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area""><StyleData>Border=Solid,ControlText,1;BackColor=Wh" + "ite;</StyleData></NamedStyle><NamedStyle Name=""Legend"" ParentName=""Legend.defaul" + "t""><StyleData /></NamedStyle><NamedStyle Name=""Footer"" ParentName=""Control""><Sty" + "leData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=""Area"" Pare" + "ntName=""Area.default""><StyleData /></NamedStyle><NamedStyle Name=""Control"" Paren" + "tName=""Control.default""><StyleData>Border=Inset,Transparent,1;</StyleData></Name" + "dStyle><NamedStyle Name=""AxisX"" ParentName=""Area""><StyleData>Rotation=Rotate0;Bo" + "rder=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;Alig" + "nVert=Bottom;</StyleData></NamedStyle><NamedStyle Name=""AxisY"" ParentName=""Area""" + "><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColo" + "r=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle" + " Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.default""><StyleData /></" + "NamedStyle><NamedStyle Name=""Legend.default"" ParentName=""Control""><StyleData>Bor" + "der=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle N" + "ame=""LabelStyleDefault.default"" ParentName=""Control""><StyleData>Border=None,Blac" + "k,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle Name=""Header"" Par" + "entName=""Control""><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Named" + "Style Name=""Control.default"" ParentName=""""><StyleData>ForeColor=ControlText;Bord" + "er=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle Name=""Axi" + "sY2"" ParentName=""Area""><StyleData>Rotation=Rotate90;Border=None,Transparent,1;Al" + "ignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><Nam" + "edStyle Name=""Area.default"" ParentName=""Control""><StyleData>Border=None,Black,1;" + "AlignVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection>" + "<ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><Dat" + "aSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><Symb" + "olStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;" + "4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Do" + "uble;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerialize" + "r><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""Cornfl" + "owerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;" + "12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</" + "DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeries" + "Serializer><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""T" + "ri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y" + "1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFi" + "elds>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineS" + "tyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesL" + "abel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><Y2 /><Y3 " + "/><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Dat" + "aFields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><N" + "ame>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>Other" + "Offset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillF" + "alling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</H" + "iLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Po" + "lar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fill" + "ed=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></" + "ChartGroup><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" /><Name>Gro" + "up2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=" + "0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=" + "True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData" + "><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Deg" + "rees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fals" + "e,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGr" + "oup></ChartGroupsCollection><Header Compass=""North"" Visible=""False""><Text /></He" + "ader><Footer Compass=""South""><Text /></Footer><Legend Compass=""East"" Visible=""Fa" + "lse""><Text /></Legend><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" Uni" + "tMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _on" + "Top=""0"" Compass=""South""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" Pa" + "ttern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></" + "Axis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMin" + "or=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""West""><Text /><GridM" + "ajor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""T" + "rue"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""" + "0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True""" + " _onTop=""0"" Compass=""East""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray""" + " Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /" + "></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(472, 425)
      Me.c1Chart1.TabIndex = 2
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, miHelp})
      ' 
      ' miFile
      ' 
      Me.miFile.Index = 0
      Me.miFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miNewData, menuItem3, miExit})
      Me.miFile.Text = "&File"
      ' 
      ' miNewData
      ' 
      Me.miNewData.Index = 0
      Me.miNewData.Text = "&New data"
      ' 
      ' menuItem3
      ' 
      Me.menuItem3.Index = 1
      Me.menuItem3.Text = "-"
      ' 
      ' miExit
      ' 
      Me.miExit.Index = 2
      Me.miExit.Text = "E&xit"
      ' 
      ' miHelp
      ' 
      Me.miHelp.Index = 1
      Me.miHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miAbout})
      Me.miHelp.Text = "&Help"
      ' 
      ' miAbout
      ' 
      Me.miAbout.Index = 0
      Me.miAbout.Text = "&About"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 425)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, panel1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(400, 300)
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - PointStyles Demo"
      Me.panel1.ResumeLayout(False)
      CType(Me.udSeriesIndex, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.udPointIndex, System.ComponentModel.ISupportInitialize).EndInit()
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
   Private np As Integer = 10
   
   
   Private Sub GenerateData()
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      
      If cd.SeriesList.Count <> 2 Then
         cd.SeriesList.Clear()
         Dim ds1 As ChartDataSeries = cd.SeriesList.AddNewSeries()
         ds1.SymbolStyle.Shape = SymbolShapeEnum.Box
         ds1.SymbolStyle.Size = 10
         ds1.SymbolStyle.OutlineColor = Color.Black
         ds1.SymbolStyle.Color = Color.LightBlue
         ds1.LineStyle.Color = Color.Plum
         
         Dim ds2 As ChartDataSeries = cd.SeriesList.AddNewSeries()
         ds2.SymbolStyle.Shape = SymbolShapeEnum.Dot
         ds2.SymbolStyle.Size = 10
         ds2.SymbolStyle.OutlineColor = Color.Black
         ds2.SymbolStyle.Color = Color.LightPink
         ds2.LineStyle.Color = Color.PaleGreen
      End If
      
      Dim x(np-1) As Double
      Dim y(np-1) As Double
      Dim ds As ChartDataSeries
      For Each ds In  cd.SeriesList
         Dim i As Integer
         For i = 0 To np - 1
            x(i) = i
            y(i) = rnd.NextDouble() * 20 - 10
         Next i
         
         ds.X.CopyDataIn(x)
         ds.Y.CopyDataIn(y)
      Next ds
   End Sub 'GenerateData
   
   
   Private Sub InitComboFromEnum(cb As ComboBox, entype As Type)
      Dim arr As Array = [Enum].GetValues(entype)
      Dim i As Integer
      For i = 0 To arr.Length - 1
         cb.Items.Add(arr.GetValue(i))
      Next i 
      cb.SelectedItem = arr.GetValue(0)
   End Sub 'InitComboFromEnum
   
   
   Private Sub InitStyle()
      Dim ps As C1.Win.C1Chart.PointStyle = c1Chart1.ChartGroups(0).ChartData.PointStylesList(0)
      ps.LineStyle.Color = Color.Red
      ps.SymbolStyle.Color = Color.LightYellow
      ps.SymbolStyle.Size = 15
      ps.SymbolStyle.OutlineColor = Color.Red
      ps.SymbolStyle.OutlineWidth = 2
      ps.SymbolStyle.Shape = SymbolShapeEnum.Diamond
   End Sub 'InitStyle
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' show grid
      c1Chart1.ChartArea.AxisX.GridMajor.Visible = True
      c1Chart1.ChartArea.AxisY.GridMajor.Visible = True
      
      Dim ps As C1.Win.C1Chart.PointStyle = c1Chart1.ChartGroups(0).ChartData.PointStylesList.AddNewPointStyle()
      InitStyle()
      
      AddHandler ps.Select, AddressOf PointStyle_Select
      
      GenerateData()
      InitComboFromEnum(cbMethod, GetType(PointStyleSelectionEnum))
      cbChartType.SelectedIndex = 0
      
      udPointIndex.Maximum = np - 1
   End Sub 'Form1_Load
   
   
   Sub PointStyle_Select(sender As Object, e As C1.Win.C1Chart.PointStyleSelectEventArgs)
      Dim val As Double = Convert.ToDouble(c1Chart1.ChartGroups(0).ChartData(e.SeriesIndex).Y(e.PointIndex))
      Dim maxy As Double = c1Chart1.ChartGroups(0).ChartData.MaxY
      Dim miny As Double = c1Chart1.ChartGroups(0).ChartData.MinY
      Dim ds As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(e.SeriesIndex)
      
      Dim ps As C1.Win.C1Chart.PointStyle = CType(sender, C1.Win.C1Chart.PointStyle)
      
      If val > 0 Then
         'Color clr = Color.FromArgb( (int)(255 * ( 1 - (maxy -val) / maxy)), Color.Red);
         Dim clr As Color = Color.FromArgb(CInt(255 *(1 -(maxy - val) / maxy)), ds.LineStyle.Color)
         ps.LineStyle.Color = clr
         ps.SymbolStyle.Color = clr
         
         ps.SymbolStyle.OutlineColor = Color.Red
      Else
         val = Math.Abs(val)
         miny = Math.Abs(miny)
         'Color clr = Color.FromArgb( (int)(255 * ( 1 - (miny -val) / miny)), Color.Blue);
         Dim clr As Color = Color.FromArgb(CInt(255 *(1 -(miny - val) / miny)), ds.LineStyle.Color)
         ps.LineStyle.Color = clr
         ps.SymbolStyle.Color = clr
         ps.SymbolStyle.OutlineColor = Color.Blue
      End If
      
      e.Selected = True
   End Sub 'PointStyle_Select
   
   
   Private Sub c1Chart1_DoubleClick(sender As Object, e As System.EventArgs)
      c1Chart1.ShowProperties()
   End Sub 'c1Chart1_DoubleClick
   
   
   Private Sub cbMethod_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbMethod.SelectedIndexChanged
      Dim ps As C1.Win.C1Chart.PointStyle = c1Chart1.ChartGroups(0).ChartData.PointStylesList(0)
      
      ps.Selection = CType(cbMethod.SelectedItem, PointStyleSelectionEnum)
      InitStyle()
      
      If ps.Selection = PointStyleSelectionEnum.Index Then
         udPointIndex.Enabled = True
      Else
         udPointIndex.Enabled = False
      End If 
      If ps.Selection = PointStyleSelectionEnum.Index OrElse ps.Selection = PointStyleSelectionEnum.SeriesMaxX OrElse ps.Selection = PointStyleSelectionEnum.SeriesMaxY OrElse ps.Selection = PointStyleSelectionEnum.SeriesMinX OrElse ps.Selection = PointStyleSelectionEnum.SeriesMinY Then
         udSeriesIndex.Enabled = True
      Else
         udSeriesIndex.Enabled = False
      End If
   End Sub 'cbMethod_SelectedIndexChanged
    
   Private Sub cbChartType_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbChartType.SelectedIndexChanged
      Select Case cbChartType.SelectedIndex
         Case 0
            c1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.XYPlot
         Case 1
            c1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Bar
      End Select
   End Sub 'cbChartType_SelectedIndexChanged
   
   
   Private Sub udPointIndex_ValueChanged(sender As Object, e As System.EventArgs) Handles udPointIndex.ValueChanged
      Dim ps As C1.Win.C1Chart.PointStyle = c1Chart1.ChartGroups(0).ChartData.PointStylesList(0)
      ps.PointIndex = CInt(udPointIndex.Value)
   End Sub 'udPointIndex_ValueChanged
   
   
   Private Sub udSeriesIndex_ValueChanged(sender As Object, e As System.EventArgs) Handles udSeriesIndex.ValueChanged
      Dim ps As C1.Win.C1Chart.PointStyle = c1Chart1.ChartGroups(0).ChartData.PointStylesList(0)
      ps.SeriesIndex = CInt(udSeriesIndex.Value)
   End Sub 'udSeriesIndex_ValueChanged
   
   
   Private Sub miExit_Click(sender As Object, e As System.EventArgs) Handles miExit.Click
      Close()
   End Sub 'miExit_Click
   
   
   Private Sub miNewData_Click(sender As Object, e As System.EventArgs) Handles miNewData.Click
      GenerateData()
   End Sub 'miNewData_Click
   
   
   Private Sub miAbout_Click(sender As Object, e As System.EventArgs) Handles miAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'miAbout_Click
End Class 'Form1
