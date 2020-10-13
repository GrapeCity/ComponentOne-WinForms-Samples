
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
   Private panel1 As System.Windows.Forms.Panel
   WithEvents btnNew As System.Windows.Forms.Button
   WithEvents btnEdit As System.Windows.Forms.Button
   Private components As System.ComponentModel.IContainer
   WithEvents lbFList As System.Windows.Forms.ListBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   Private label1 As System.Windows.Forms.Label
   Private pgSeries As System.Windows.Forms.PropertyGrid
   Private label2 As System.Windows.Forms.Label
   WithEvents btnRemove As System.Windows.Forms.Button
   WithEvents rbXY As System.Windows.Forms.RadioButton
   WithEvents rbPolar As System.Windows.Forms.RadioButton
   Private toolTip1 As System.Windows.Forms.ToolTip
   Private groupBox1 As System.Windows.Forms.GroupBox
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private pgOptions As System.Windows.Forms.PropertyGrid
   
   Private engine As New Engine()
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   
   Sub addNewFunction([text] As String, xmin As Single, xmax As Single, npts As Integer)
      Dim s As New C1.Win.C1Chart.ChartDataSeries()
      c1Chart1.ChartGroups.Group0.ChartData.SeriesList.Add(s)
      Dim pts As PointF() = engine.Run([text], xmin, xmax, npts)
      s.PointData.CopyDataIn(pts)
      s.Label = [text]
      
      Dim i As Integer = lbFList.Items.Add([text])
      
      lbFList.SelectedIndex = i
   End Sub 'addNewFunction
   
   
   Sub setXYChart()
      Cursor.Current = Cursors.WaitCursor
      
      c1Chart1.Header.Text = "X - Y chart"
      c1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()
      lbFList.Items.Clear()
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot
      
      Dim pi As Single = CSng(Math.PI)
      addNewFunction("Math.Sin(x)", - pi, pi, 20)
      addNewFunction("Math.Cos(x)", - pi, pi, 20)
      addNewFunction("Math.Sin(5*x)*Math.Exp(-Math.Abs(x))", - pi, pi, 50)
      lbFList.SelectedIndex = 0
      
      pgOptions.Visible = False
      Cursor.Current = Cursors.Default
   End Sub 'setXYChart
   
   
   Sub setPolarChart()
      Cursor.Current = Cursors.WaitCursor
      
      c1Chart1.Header.Text = "Polar chart"
      c1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()
      lbFList.Items.Clear()
      c1Chart1.ChartGroups(0).ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Polar
      
      addNewFunction("3*Math.Cos(2*x*Math.PI/180)", 0, 360, 50)
      addNewFunction("1-2*Math.Cos(x*Math.PI/180)", 0, 360, 50)
      addNewFunction("2*Math.Cos((3*x)*Math.PI/180)", 0, 180, 50)
      lbFList.SelectedIndex = 0
      
      pgOptions.Visible = True
      Cursor.Current = Cursors.Default
   End Sub 'setPolarChart
   
   
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.pgOptions = New System.Windows.Forms.PropertyGrid()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.rbPolar = New System.Windows.Forms.RadioButton()
      Me.rbXY = New System.Windows.Forms.RadioButton()
      Me.label2 = New System.Windows.Forms.Label()
      Me.pgSeries = New System.Windows.Forms.PropertyGrid()
      Me.label1 = New System.Windows.Forms.Label()
      Me.btnRemove = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.lbFList = New System.Windows.Forms.ListBox()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panel1.SuspendLayout()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
      Me.c1Chart1.Location = New System.Drawing.Point(200, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Par" + "entName>Area</ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Gainsbo" + "ro;</StyleData><Name>PlotArea</Name></NamedStyle><NamedStyle><ParentName>Legend." + "default</ParentName><StyleData>Border=Solid,Black,1;</StyleData><Name>Legend</Na" + "me></NamedStyle><NamedStyle><ParentName>Control</ParentName><StyleData>Border=No" + "ne,Control,1;</StyleData><Name>Footer</Name></NamedStyle><NamedStyle><ParentName" + ">Area.default</ParentName><StyleData /><Name>Area</Name></NamedStyle><NamedStyle" + "><ParentName>Control.default</ParentName><StyleData>Border=Solid,ControlText,1;<" + "/StyleData><Name>Control</Name></NamedStyle><NamedStyle><ParentName>Area</Parent" + "Name><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColo" + "r=Transparent;AlignVert=Bottom;</StyleData><Name>AxisX</Name></NamedStyle><Named" + "Style><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Con" + "trol,1;AlignHorz=Near;BackColor=Transparent;AlignVert=Center;</StyleData><Name>A" + "xisY</Name></NamedStyle><NamedStyle><ParentName>LabelStyleDefault.default</Paren" + "tName><StyleData /><Name>LabelStyleDefault</Name></NamedStyle><NamedStyle><Paren" + "tName>Control</ParentName><StyleData>Border=None,Control,1;Wrap=False;AlignVert=" + "Top;</StyleData><Name>Legend.default</Name></NamedStyle><NamedStyle><ParentName>" + "Control</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</Sty" + "leData><Name>LabelStyleDefault.default</Name></NamedStyle><NamedStyle><ParentNam" + "e>Control</ParentName><StyleData>Border=None,Control,1;</StyleData><Name>Header<" + "/Name></NamedStyle><NamedStyle><ParentName /><StyleData>ForeColor=ControlText;Bo" + "rder=None,Control,1;BackColor=Control;</StyleData><Name>Control.default</Name></" + "NamedStyle><NamedStyle><ParentName>Area</ParentName><StyleData>Rotation=Rotate90" + ";Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;" + "</StyleData><Name>AxisY2</Name></NamedStyle><NamedStyle><ParentName>Control</Par" + "entName><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData><Name>Area.de" + "fault</Name></NamedStyle></StyleCollection><Axes><Axis Max=""5"" Min=""1"" UnitMajor" + "=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""T" + "rue"" _onTop=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=" + """LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""Li" + "ghtGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""19"" UnitMajor=""1"" U" + "nitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _" + "onTop=""0"" Compass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightG" + "ray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray" + """ Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=" + """0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" C" + "ompass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""" + "Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text /></Header><Footer C" + "ompass=""South"" Visible=""False""><Text /></Footer><Legend Compass=""East"" Visible=""" + "False""><Text /></Legend><ChartArea /><ChartGroupsCollection><ChartGroup><Bar>Clu" + "sterOverlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees" + "=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,St" + "art=0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group1</Name><ChartType>XYPlo" + "t</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize" + "=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWi" + "dth=False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer DefaultSet=""Tru" + "e""><DataSeriesCollection><DataSeriesSerializer><Y3 /><Y2 /><Y>20;22;19;24;25</Y>" + "<LineStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><SymbolStyle Sh" + "ape=""Box"" Color=""Coral"" /><SeriesLabel>series 0</SeriesLabel><DataTypes>Single;S" + "ingle;Single;Single;Single</DataTypes><Y1 /><X>1;2;3;4;5</X></DataSeriesSerializ" + "er></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup><Bar>Cluster" + "Overlap=0,ClusterWidth=50</Bar><ShowOutline>True</ShowOutline><Polar>Degrees=Tru" + "e,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=" + "0</Radar><Pie>OtherOffset=0,Start=0</Pie><Name>Group2</Name><ChartType>XYPlot</C" + "hartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diameter,MaximumSize=20," + "MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=" + "False,ShowClose=True,ShowOpen=True</HiLoData><DataSerializer /></ChartGroup></Ch" + "artGroupsCollection></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(392, 403)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgOptions, Me.groupBox1, Me.rbPolar, Me.rbXY, Me.label2, Me.pgSeries, Me.label1, Me.btnRemove, Me.btnEdit, Me.btnNew, Me.lbFList})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(200, 403)
      Me.panel1.TabIndex = 1
      ' 
      ' pgOptions
      ' 
      Me.pgOptions.Anchor = System.Windows.Forms.AnchorStyles.Bottom
      Me.pgOptions.CommandsVisibleIfAvailable = True
      Me.pgOptions.HelpVisible = False
      Me.pgOptions.LargeButtons = False
      Me.pgOptions.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.pgOptions.Location = New System.Drawing.Point(8, 336)
      Me.pgOptions.Name = "pgOptions"
      Me.pgOptions.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
      Me.pgOptions.Size = New System.Drawing.Size(184, 56)
      Me.pgOptions.TabIndex = 11
      Me.pgOptions.Text = "propertyGrid1"
      Me.pgOptions.ToolbarVisible = False
      Me.pgOptions.ViewBackColor = System.Drawing.SystemColors.Window
      Me.pgOptions.ViewForeColor = System.Drawing.SystemColors.WindowText
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Location = New System.Drawing.Point(0, 24)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(200, 4)
      Me.groupBox1.TabIndex = 10
      Me.groupBox1.TabStop = False
      ' 
      ' rbPolar
      ' 
      Me.rbPolar.Location = New System.Drawing.Point(96, 8)
      Me.rbPolar.Name = "rbPolar"
      Me.rbPolar.Size = New System.Drawing.Size(72, 16)
      Me.rbPolar.TabIndex = 9
      Me.rbPolar.Text = "Polar"
      ' 
      ' rbXY
      ' 
      Me.rbXY.Checked = True
      Me.rbXY.Location = New System.Drawing.Point(16, 8)
      Me.rbXY.Name = "rbXY"
      Me.rbXY.Size = New System.Drawing.Size(72, 16)
      Me.rbXY.TabIndex = 8
      Me.rbXY.TabStop = True
      Me.rbXY.Text = "X - Y"
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(8, 152)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(100, 16)
      Me.label2.TabIndex = 7
      Me.label2.Text = "Data Series:"
      ' 
      ' pgSeries
      ' 
      Me.pgSeries.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
      Me.pgSeries.CommandsVisibleIfAvailable = True
      Me.pgSeries.HelpVisible = False
      Me.pgSeries.LargeButtons = False
      Me.pgSeries.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.pgSeries.Location = New System.Drawing.Point(8, 168)
      Me.pgSeries.Name = "pgSeries"
      Me.pgSeries.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
      Me.pgSeries.Size = New System.Drawing.Size(184, 160)
      Me.pgSeries.TabIndex = 6
      Me.pgSeries.Text = "propertyGrid1"
      Me.pgSeries.ToolbarVisible = False
      Me.pgSeries.ViewBackColor = System.Drawing.SystemColors.Window
      Me.pgSeries.ViewForeColor = System.Drawing.SystemColors.WindowText
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(8, 32)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(100, 16)
      Me.label1.TabIndex = 5
      Me.label1.Text = "Functions:"
      ' 
      ' btnRemove
      ' 
      Me.btnRemove.Image = CType(resources.GetObject("btnRemove.Image"), System.Drawing.Bitmap)
      Me.btnRemove.Location = New System.Drawing.Point(168, 120)
      Me.btnRemove.Name = "btnRemove"
      Me.btnRemove.Size = New System.Drawing.Size(24, 23)
      Me.btnRemove.TabIndex = 3
      Me.toolTip1.SetToolTip(Me.btnRemove, "Remove function")
      ' 
      ' btnEdit
      ' 
      Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Bitmap)
      Me.btnEdit.Location = New System.Drawing.Point(168, 84)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(24, 23)
      Me.btnEdit.TabIndex = 2
      Me.toolTip1.SetToolTip(Me.btnEdit, "Edit function")
      ' 
      ' btnNew
      ' 
      Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
      Me.btnNew.Location = New System.Drawing.Point(168, 48)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(24, 23)
      Me.btnNew.TabIndex = 1
      Me.toolTip1.SetToolTip(Me.btnNew, "New function")
      ' 
      ' lbFList
      ' 
      Me.lbFList.Location = New System.Drawing.Point(8, 48)
      Me.lbFList.Name = "lbFList"
      Me.lbFList.Size = New System.Drawing.Size(152, 95)
      Me.lbFList.TabIndex = 0
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, menuItem3})
      ' 
      ' menuItem1
      ' 
      menuItem1.Index = 0
      menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      menuItem1.Text = "&File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "E&xit"
      ' 
      ' menuItem3
      ' 
      menuItem3.Index = 1
      menuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      menuItem3.Text = "&Help"
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
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - Function Plotting Demo"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panel1.ResumeLayout(False)
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
   
   
   Private Sub btnNew_Click(sender As Object, e As System.EventArgs) Handles btnNew.Click
      Dim ff As New FuncForm(engine)
      If ff.ShowDialog(Me) = DialogResult.OK Then
         addNewFunction(ff.Code, ff.MinX, ff.MaxX, ff.NPts)
      End If
   End Sub 'btnNew_Click
    
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub btnEdit_Click(sender As Object, e As System.EventArgs) Handles btnEdit.Click
      Dim index As Integer = lbFList.SelectedIndex
      If index >= 0 Then
         Dim s As C1.Win.C1Chart.ChartDataSeries = c1Chart1.ChartGroups.Group0.ChartData.SeriesList(index)
         Dim ff As New FuncForm(engine)
         ff.Code = lbFList.SelectedItem.ToString()
         ff.MinX = CSng(s.MinX)
         ff.MaxX = CSng(s.MaxX)
         ff.NPts = s.Length
         If ff.ShowDialog(Me) = DialogResult.OK Then
            Dim pts As PointF() = engine.Run(ff.Code, ff.MinX, ff.MaxX, ff.NPts)
            s.PointData.CopyDataIn(pts)
            s.Label = ff.Code
            
            lbFList.Items(index) = ff.Code
         End If
      End If
   End Sub 'btnEdit_Click
   
   
   Private Sub button1_Click(sender As Object, e As System.EventArgs) Handles btnRemove.Click
      Dim index As Integer = lbFList.SelectedIndex
      If index >= 0 Then
         If MessageBox.Show(Me, "Delete function?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            c1Chart1.ChartGroups.Group0.ChartData.SeriesList.RemoveAt(index)
            lbFList.Items.RemoveAt(index)
            
            c1Chart1.Invalidate()
         End If
      End If
   End Sub 'button1_Click
   
   
   Private Sub lbFList_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lbFList.SelectedIndexChanged
      Dim index As Integer = lbFList.SelectedIndex
      If index >= 0 Then
         pgSeries.SelectedObject = c1Chart1.ChartGroups.Group0.ChartData.SeriesList(index)
         btnEdit.Enabled = True
         btnRemove.Enabled = True
      Else
         pgSeries.SelectedObject = Nothing
         btnEdit.Enabled = False
         btnRemove.Enabled = False
      End If
   End Sub 'lbFList_SelectedIndexChanged
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      c1Chart1.Header.Style.Font = New Font("Arial", 12, FontStyle.Underline)
      
      pgOptions.SelectedObject = c1Chart1.ChartGroups(0).Polar
      setXYChart()
   End Sub 'Form1_Load
   
   
   Private Sub rbXY_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbXY.CheckedChanged
      If rbXY.Checked Then
         setXYChart()
      Else
         setPolarChart()
      End If
   End Sub 'rbXY_CheckedChanged
    
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
