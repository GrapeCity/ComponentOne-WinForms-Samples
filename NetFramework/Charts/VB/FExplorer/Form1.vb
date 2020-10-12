
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
   Private tabControl1 As System.Windows.Forms.TabControl
   Private tabPage1 As System.Windows.Forms.TabPage
   Private tabPage2 As System.Windows.Forms.TabPage
   WithEvents treeView1 As System.Windows.Forms.TreeView
   WithEvents listView1 As System.Windows.Forms.ListView
   WithEvents cbAA As System.Windows.Forms.CheckBox
   Private statusBar1 As System.Windows.Forms.StatusBar
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents timer1 As System.Windows.Forms.Timer
   WithEvents btnAnimate As System.Windows.Forms.Button
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents miFile As System.Windows.Forms.MenuItem
   WithEvents miExit As System.Windows.Forms.MenuItem
   WithEvents miHelp As System.Windows.Forms.MenuItem
   WithEvents miAbout As System.Windows.Forms.MenuItem
   Private components As System.ComponentModel.IContainer
   
   
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
      Me.components = New System.ComponentModel.Container()
      Me.tabControl1 = New System.Windows.Forms.TabControl()
      Me.tabPage1 = New System.Windows.Forms.TabPage()
      Me.btnAnimate = New System.Windows.Forms.Button()
      Me.listView1 = New System.Windows.Forms.ListView()
      Me.treeView1 = New System.Windows.Forms.TreeView()
      Me.tabPage2 = New System.Windows.Forms.TabPage()
      Me.cbAA = New System.Windows.Forms.CheckBox()
      Me.statusBar1 = New System.Windows.Forms.StatusBar()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.miFile = New System.Windows.Forms.MenuItem()
      Me.miExit = New System.Windows.Forms.MenuItem()
      Me.miHelp = New System.Windows.Forms.MenuItem()
      Me.miAbout = New System.Windows.Forms.MenuItem()
      Me.tabControl1.SuspendLayout()
      Me.tabPage1.SuspendLayout()
      Me.tabPage2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' tabControl1
      ' 
      Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPage1, tabPage2})
      Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Left
      Me.tabControl1.Name = "tabControl1"
      Me.tabControl1.SelectedIndex = 0
      Me.tabControl1.Size = New System.Drawing.Size(200, 453)
      Me.tabControl1.TabIndex = 0
      ' 
      ' tabPage1
      ' 
      Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAnimate, listView1, treeView1})
      Me.tabPage1.DockPadding.Bottom = 34
      Me.tabPage1.Location = New System.Drawing.Point(4, 22)
      Me.tabPage1.Name = "tabPage1"
      Me.tabPage1.Size = New System.Drawing.Size(192, 427)
      Me.tabPage1.TabIndex = 0
      Me.tabPage1.Text = "Functions"
      ' 
      ' btnAnimate
      ' 
      Me.btnAnimate.Anchor = System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left
      Me.btnAnimate.Location = New System.Drawing.Point(46, 400)
      Me.btnAnimate.Name = "btnAnimate"
      Me.btnAnimate.Size = New System.Drawing.Size(101, 23)
      Me.btnAnimate.TabIndex = 2
      Me.btnAnimate.Text = "Start Animation"
      ' 
      ' listView1
      ' 
      Me.listView1.CheckBoxes = True
      Me.listView1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.listView1.GridLines = True
      Me.listView1.HideSelection = False
      Me.listView1.Location = New System.Drawing.Point(0, 168)
      Me.listView1.Name = "listView1"
      Me.listView1.Size = New System.Drawing.Size(192, 225)
      Me.listView1.TabIndex = 1
      Me.listView1.View = System.Windows.Forms.View.List
      ' 
      ' treeView1
      ' 
      Me.treeView1.Dock = System.Windows.Forms.DockStyle.Top
      Me.treeView1.HideSelection = False
      Me.treeView1.ImageIndex = - 1
      Me.treeView1.Name = "treeView1"
      Me.treeView1.SelectedImageIndex = - 1
      Me.treeView1.Size = New System.Drawing.Size(192, 168)
      Me.treeView1.TabIndex = 0
      ' 
      ' tabPage2
      ' 
      Me.tabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbAA})
      Me.tabPage2.Location = New System.Drawing.Point(4, 22)
      Me.tabPage2.Name = "tabPage2"
      Me.tabPage2.Size = New System.Drawing.Size(192, 427)
      Me.tabPage2.TabIndex = 1
      Me.tabPage2.Text = "Plot Options"
      ' 
      ' cbAA
      ' 
      Me.cbAA.Location = New System.Drawing.Point(8, 8)
      Me.cbAA.Name = "cbAA"
      Me.cbAA.Size = New System.Drawing.Size(120, 24)
      Me.cbAA.TabIndex = 0
      Me.cbAA.Text = "Use anti-aliasing"
      ' 
      ' statusBar1
      ' 
      Me.statusBar1.Location = New System.Drawing.Point(200, 431)
      Me.statusBar1.Name = "statusBar1"
      Me.statusBar1.Size = New System.Drawing.Size(432, 22)
      Me.statusBar1.TabIndex = 2
      Me.statusBar1.Text = "Ready"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Interaction.Enabled = True
      Me.c1Chart1.Location = New System.Drawing.Point(200, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area""><StyleData>Border=Solid,ControlText,1;BackColor=Wh" + "iteSmoke;</StyleData></NamedStyle><NamedStyle Name=""Legend"" ParentName=""Legend.d" + "efault""><StyleData /></NamedStyle><NamedStyle Name=""Footer"" ParentName=""Control""" + "><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedStyle Name=""Area""" + " ParentName=""Area.default""><StyleData /></NamedStyle><NamedStyle Name=""Control"" " + "ParentName=""Control.default""><StyleData>Border=Solid,Black,1;</StyleData></Named" + "Style><NamedStyle Name=""AxisX"" ParentName=""Area""><StyleData>Rotation=Rotate0;Bor" + "der=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;Align" + "Vert=Bottom;</StyleData></NamedStyle><NamedStyle Name=""AxisY"" ParentName=""Area"">" + "<StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;BackColor" + "=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><NamedStyle " + "Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.default""><StyleData /></N" + "amedStyle><NamedStyle Name=""Legend.default"" ParentName=""Control""><StyleData>Bord" + "er=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle Na" + "me=""LabelStyleDefault.default"" ParentName=""Control""><StyleData>Border=None,Black" + ",1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle Name=""Header"" Pare" + "ntName=""Control""><StyleData>Border=None,Black,1;</StyleData></NamedStyle><NamedS" + "tyle Name=""Control.default"" ParentName=""""><StyleData>ForeColor=ControlText;Borde" + "r=None,Black,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle Name=""Axis" + "Y2"" ParentName=""Area""><StyleData>Rotation=Rotate90;Border=None,Transparent,1;Ali" + "gnHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><Name" + "dStyle Name=""Area.default"" ParentName=""Control""><StyleData>Border=None,Black,1;A" + "lignVert=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><" + "ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><Data" + "SeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><Symbo" + "lStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4" + ";5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Dou" + "ble;Double</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer" + "><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""Cornflo" + "werBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;1" + "2;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</D" + "ataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesS" + "erializer><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tr" + "i"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y1" + " /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" + "lds>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineSt" + "yle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLa" + "bel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Y1 /><Y2 /><Y3 /" + "><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Data" + "Fields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><Na" + "me>Group1</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherO" + "ffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFa" + "lling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</Hi" + "LoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Pol" + "ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" + "d=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></C" + "hartGroup><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" /><Name>Grou" + "p2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset=0" + ",Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=T" + "rue,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData>" + "<Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degr" + "ees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False" + ",Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartGro" + "up></ChartGroupsCollection><Header Compass=""North"" Visible=""False""><Text /></Hea" + "der><Footer Compass=""South"" Visible=""False""><Text /></Footer><Legend Compass=""Ea" + "st"" Visible=""False""><Text /></Legend><ChartArea><Margin Top=""0"" Left=""0"" Bottom=" + """0"" Right=""0"" /></ChartArea><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0""" + " Compass=""South""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" Pattern=""" + "Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></Axis><A" + "xis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""T" + "rue"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compass=""West""><Text /><GridMajor " + "AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" " + "Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" Un" + "itMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onT" + "op=""0"" Compass=""East""><Text /><GridMajor AutoSpace=""True"" Color=""LightGray"" Patt" + "ern=""Dash"" /><GridMinor AutoSpace=""True"" Color=""LightGray"" Pattern=""Dash"" /></Ax" + "is></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(432, 431)
      Me.c1Chart1.TabIndex = 3
      ' 
      ' timer1
      ' 
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.miFile, miHelp})
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
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, statusBar1, tabControl1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(400, 300)
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Function Explorer Demo"
      Me.tabControl1.ResumeLayout(False)
      Me.tabPage1.ResumeLayout(False)
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
   
   ' colors
   Private clrs() As Color = {Color.Red, Color.Green, Color.Blue, Color.DarkRed, Color.DarkGreen, Color.DarkBlue}
   
   ' trigonometric
   Private trigNames() As String = {"sin(x)", "cos(x)", "tg(x)", "ctg(x)", "sec(x)", "cosec(x)"}
   Private trigCodes() As String = {"Math.Sin(x)", "Math.Cos(x)", "Math.Tan(x)", "1/Math.Tan(x)", "1/Math.Sin(x)", "1/Math.Cos(x)"}
   
   ' hyperbolic
   Private hbNames() As String = {"sinh(x)", "cosh(x)", "tgh(x)", "ctgh(x)"}
   Private hbCodes() As String = {"Math.Sinh(x)", "Math.Cosh(x)", "Math.Tanh(x)", "1/Math.Tanh(x)"}
   
   ' rational
   Private ratNames() As String = {"1/x", "1/(x*x-3)", "1/(x+2)+1/(x-2)"}
   Private ratCodes() As String = {"1/x", "1/(x*x-3)", "1/(x+2)+1/(x-2)"}
   
   ' exponent
   Private expNames() As String = {"sin(x)*exp(0.01*x*x)", "exp(0.01*x*x)", "-exp(0.01*x*x)"}
   Private expCodes() As String = {"Math.Sin(5*x)*Math.Exp(0.01*x*x)", "Math.Exp(0.01*x*x)", "-Math.Exp(0.01*x*x)"}
   
   ' lissajour
   Private lsNames() As String = {"x = sin(t) y= cos(t)", "x = sin(2t) y= cos(t)", "x = sin(t) y= cos(3t)", "x = sin(3t) y= cos(4t)"}
   Private lsCodesX() As String = {"Math.Sin(t)", "Math.Sin(2*t)", "Math.Sin(t)", "Math.Sin(3*t)"}
   Private lsCodesY() As String = {"Math.Cos(t)", "Math.Cos(t)", "Math.Cos(3*t)", "Math.Cos(4*t)"}
   
   ' spiral
   Private spNames() As String = {"x = t*sin(t) y= cos(t)", "x = sin(t) y= t*cos(t)", "x = t*sin(t) y= t*cos(t)"}
   Private spCodesX() As String = {"t*Math.Sin(t)", "Math.Sin(t)", "t*Math.Sin(t)"}
   Private spCodesY() As String = {"Math.Cos(t)", "t*Math.Cos(t)", "t*Math.Cos(t)"}
   
   ' roses
   Private rsNames() As String = {"x=sin(2*t)*sin(t) y=sin(2*t)*cos(t)", "x=sin(5*t/3)*sin(t) y=sin(5*t/3)*cos(t)", "x=sin(t/2)*sin(t) y=sin(t/2)*cos(t)"}
   Private rsCodesX() As String = {"Math.Sin(2*t)*Math.Sin(t)", "Math.Sin(5*t/3)*Math.Sin(t)", "Math.Sin(t/2)*Math.Sin(t)"}
   Private rsCodesY() As String = {"Math.Sin(2*t)*Math.Cos(t)", "Math.Sin(5*t/3)*Math.Cos(t)", "Math.Sin(t/2)*Math.Cos(t)"}
   
   ' wheel
   Private whNames() As String = {"x=t-1.25*sin(t) y=1-1.25*cos(t)-2", "x=t-0.75*sin(t) y=1-0.75*cos(t)", "x=t-sin(t) y=1-cos(t)+2"}
   Private whCodesX() As String = {"t-1.25*Math.Sin(t)", "t-0.75*Math.Sin(t)", "t-Math.Sin(t)"}
   Private whCodesY() As String = {"1-1.25*Math.Cos(t)-2", "1-0.75*Math.Cos(t)", "1-Math.Cos(t)+2"}
   
   
   ' create node and YFunction group
   Overloads Function AddGroup(node As TreeNode, name As String, fnames() As String, fcodes() As String, xmin As Double, xmax As Double, ymin As Double, ymax As Double, npoints As Integer) As TreeNode
      Dim gn As New TreeNode(name)
      
      Dim fs(fnames.Length-1) As FunctionBase
      Dim i As Integer
      For i = 0 To fs.Length - 1
         Dim f As New YFunction()
         f.Label = fnames(i)
         f.LineStyle.Color = clrs(i)
         f.LineStyle.Thickness = 2
         If npoints > 0 Then
            f.PlotNumPoints = npoints
         End If 
         fs(i) = f
      Next i
      
      Dim fg As New FunctionsGroup(fs, fcodes, xmin, xmax, ymin, ymax)
      
      gn.Tag = fg
      node.Nodes.Add(gn)
      
      Return gn
   End Function 'AddGroup
   
   
   ' create node and ParametricFunction group
   Overloads Function AddGroup(node As TreeNode, name As String, fnames() As String, fcodesx() As String, fcodesy() As String, tmin As Double, tmax As Double) As TreeNode
      Dim gn As New TreeNode(name)
      
      Dim fs(fnames.Length-1) As FunctionBase
      Dim i As Integer
      For i = 0 To fs.Length - 1
         Dim f As New ParametricFunction()
         f.Label = fnames(i)
         f.LineStyle.Color = clrs(i)
         f.LineStyle.Thickness = 2
         f.MinT = tmin
         f.MaxT = tmax
         fs(i) = f
      Next i
      
      Dim fg As New FunctionsGroup(fs, fcodesx, fcodesy)
      
      gn.Tag = fg
      node.Nodes.Add(gn)
      
      Return gn
   End Function 'AddGroup
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' show grid
      c1Chart1.ChartArea.AxisX.GridMajor.Visible = True
      c1Chart1.ChartArea.AxisY.GridMajor.Visible = True
      
      ' clear default series data
      c1Chart1.ChartGroups(0).ChartData.SeriesList.Clear()
      
      ' YFunction's
      Dim tn As New TreeNode("Explicit y=f(x)")
      
      treeView1.Nodes.Add(tn)
      
      Dim sn As TreeNode = AddGroup(tn, "Trigonometric", trigNames, trigCodes, - 10, 10, - 5, 5, 0)
      AddGroup(tn, "Hyperbolic", hbNames, hbCodes, - 5, 5, - 5, 5, 0)
      AddGroup(tn, "Rational", ratNames, ratCodes, - 4, 4, - 4, 4, 0)
      AddGroup(tn, "Exponent", expNames, expCodes, - 20, 20, - 55, 55, 400)
      
      ' ParametricFunction's
      tn = New TreeNode("Parametric x=f1(t) y=f2(t)")
      treeView1.Nodes.Add(tn)
      
      AddGroup(tn, "Lissajous", lsNames, lsCodesX, lsCodesY, 0, 2 * Math.PI)
      AddGroup(tn, "Spiral", spNames, spCodesX, spCodesY, 0, 20)
      AddGroup(tn, "Rose", rsNames, rsCodesX, rsCodesY, 0, 4 * Math.PI)
      AddGroup(tn, "Wheel", whNames, whCodesX, whCodesY, 0, 6 * Math.PI)
      
      
      ' expand all and select sn
      treeView1.ExpandAll()
      treeView1.SelectedNode = sn
   End Sub 'Form1_Load
   
   
   Private Sub treeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles treeView1.AfterSelect
      AnimateStop()
      btnAnimate.Enabled = False
      
      Dim sn As TreeNode = treeView1.SelectedNode
      
      ' if group of functions are associated with this node
      If Not (sn Is Nothing) AndAlso Not (sn.Tag Is Nothing) Then
         Dim fc As FunctionsCollection = c1Chart1.ChartGroups(0).ChartData.FunctionsList
         
         ' clear previous functions and listview
         fc.Clear()
         listView1.Items.Clear()
         
         Dim fg As FunctionsGroup = CType(sn.Tag, FunctionsGroup)
         fg.Load(statusBar1)
         
         ' fill listview
         Dim i As Integer
         For i = 0 To fg.FunctionList.Length - 1
            Dim f As FunctionBase = fg.FunctionList(i)
            Dim lvi As New ListViewItem(f.Label)
            lvi.Checked = True
            lvi.ForeColor = f.LineStyle.Color
            lvi.Tag = f
            listView1.Items.Add(lvi)
            fc.Add(f)
         Next i
         
         fg.ApplyOptions(c1Chart1)
      End If
   End Sub 'treeView1_AfterSelect
   
   
   Private Sub listView1_ItemCheck(sender As Object, e As System.Windows.Forms.ItemCheckEventArgs) Handles listView1.ItemCheck
      AnimateStop()
      ' hide or show corresponding function
      Dim lvi As ListViewItem = listView1.Items(e.Index)
      
      If Not (lvi.Tag Is Nothing) AndAlso TypeOf lvi.Tag Is FunctionBase Then
         Dim f As FunctionBase = CType(lvi.Tag, FunctionBase)
         
         f.Visible = e.NewValue = CheckState.Checked
      End If
   End Sub 'listView1_ItemCheck
   
   
   Private Sub cbAA_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAA.CheckedChanged
      c1Chart1.UseAntiAliasedGraphics = cbAA.Checked
   End Sub 'cbAA_CheckedChanged
   
   Private f_anim As FunctionBase = Nothing
   Private par_anim As Double = 0
   Private par_anim_step As Double = 0
   Private par_anim_max As Double = 0
   Private par_anim_min As Double = 0
   
   
   Private Sub AnimateStart()
      If TypeOf(listView1.SelectedItems(0).Tag) Is FunctionBase Then
         f_anim = CType(listView1.SelectedItems(0).Tag, FunctionBase)
         
         If TypeOf f_anim Is YFunction Then
            Dim yf As YFunction = CType(f_anim, YFunction)
            
            par_anim_max = yf.MaxX
            par_anim_min = yf.MinX
         ElseIf TypeOf f_anim Is ParametricFunction Then
            Dim pf As ParametricFunction = CType(f_anim, ParametricFunction)
            
            par_anim_max = pf.MaxT
            par_anim_min = pf.MinT
         End If
         
         par_anim = par_anim_min
         par_anim_step =(par_anim_max - par_anim_min) / 200
         
         timer1.Start()
         RedrawChart()
         
         btnAnimate.Text = "Stop animation"
      End If
   End Sub 'AnimateStart
   
   
   Private Sub AnimateStop()
      If Not (f_anim Is Nothing) Then
         f_anim = Nothing
         timer1.Stop()
         RedrawChart()
         curPosition = Point.Empty
         statusBar1.Text = "Ready"
         btnAnimate.Text = "Start animation"
      End If
   End Sub 'AnimateStop
   
   
   Private Sub timer1_Tick(sender As Object, e As System.EventArgs) Handles timer1.Tick
      par_anim += par_anim_step
      
      If par_anim > par_anim_max Then
         par_anim = par_anim_max
         par_anim_step = - par_anim_step
      ElseIf par_anim < par_anim_min Then
         par_anim = par_anim_min
         par_anim_step = - par_anim_step
      End If
      
      If Not (f_anim Is Nothing) Then
         Dim xd As Double = 0
         Dim yd As Double = 0
         Dim x As Integer = 0
         Dim y As Integer = 0
         
         If TypeOf f_anim Is YFunction Then
            Dim yf As YFunction = CType(f_anim, YFunction)
            
            xd = par_anim
            yd = yf.GetY(xd)
            
            statusBar1.Text = String.Format(" x={0:g4}", xd)
         ElseIf TypeOf f_anim Is ParametricFunction Then
            Dim pf As ParametricFunction = CType(f_anim, ParametricFunction)
            
            xd = pf.GetX(par_anim)
            yd = pf.GetY(par_anim)
            
            statusBar1.Text = String.Format(" t={0:g4}", par_anim)
         End If
         
         Dim xa As Axis = c1Chart1.ChartArea.AxisX
         Dim ya As Axis = c1Chart1.ChartArea.AxisY
         
         If xd >= xa.Min AndAlso xd <= xa.Max AndAlso yd >= ya.Min AndAlso yd <= ya.Max AndAlso c1Chart1.ChartGroups(0).DataCoordToCoord(xd, yd, x, y) Then
            RedrawChart()
            curPosition.X = x
            curPosition.Y = y
            RedrawChart()
         Else
            RedrawChart()
            curPosition = Point.Empty
         End If
      End If
   End Sub 'timer1_Tick
   
   
   Private Sub RedrawChart()
      If Not curPosition.IsEmpty Then
         Dim pt As Point = c1Chart1.PointToScreen(curPosition)
         ControlPaint.DrawReversibleLine(New Point(pt.X - 10, pt.Y), New Point(pt.X + 10, pt.Y), c1Chart1.ChartArea.PlotArea.BackColor)
         ControlPaint.DrawReversibleLine(New Point(pt.X, pt.Y - 10), New Point(pt.X, pt.Y + 10), c1Chart1.ChartArea.PlotArea.BackColor)
      End If
   End Sub 'RedrawChart
   
   Private curPosition As Point = Point.Empty
   
   
   Private Sub listView1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles listView1.SelectedIndexChanged
      AnimateStop()
      
      If Not (listView1.SelectedItems Is Nothing) AndAlso listView1.SelectedItems.Count = 1 Then
         btnAnimate.Enabled = True
      Else
         btnAnimate.Enabled = False
      End If
   End Sub 'listView1_SelectedIndexChanged
    
   Private Sub btnAnimate_Click(sender As Object, e As System.EventArgs) Handles btnAnimate.Click
      If f_anim Is Nothing Then
         AnimateStart()
      Else
         AnimateStop()
      End If
   End Sub 'btnAnimate_Click
    
   Private Sub miExit_Click(sender As Object, e As System.EventArgs) Handles miExit.Click
      Close()
   End Sub 'miExit_Click
   
   
   Private Sub c1Chart1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles c1Chart1.Paint
      curPosition = Point.Empty
   End Sub 'c1Chart1_Paint
   
   
   Private Sub miAbout_Click(sender As Object, e As System.EventArgs) Handles miAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'miAbout_Click
End Class 'Form1


' store for function and additional options
Class FunctionsGroup
   Private _xmin, _xmax, _ymin, _ymax As Double
   Private _flist() As FunctionBase
   
   Private _limits As Boolean = False
   
   Private _loaded As Boolean = False
   
   Private _xcodes(), _ycodes() As String
   
   
   Public Sub New(flist() As FunctionBase, ycodes() As String, xmin As Double, xmax As Double, ymin As Double, ymax As Double)
      _flist = flist
      _xmin = xmin
      _xmax = xmax
      _ymin = ymin
      _ymax = ymax
      _limits = True
      _ycodes = ycodes
   End Sub 'New
   
   
   Public Sub New(flist() As FunctionBase, xcodes() As String, ycodes() As String)
      _flist = flist
      _xcodes = xcodes
      _ycodes = ycodes
   End Sub 'New
   
   
   Public Sub ApplyOptions(chart As C1Chart)
      If _limits Then
         chart.ChartArea.AxisX.SetMinMax(_xmin, _xmax)
         chart.ChartArea.AxisY.SetMinMax(_ymin, _ymax)
      Else
         chart.ChartArea.AxisX.AutoMax = True
         chart.ChartArea.AxisX.AutoMin = True
         chart.ChartArea.AxisY.AutoMax = True
         chart.ChartArea.AxisY.AutoMin = True
      End If
   End Sub 'ApplyOptions
   
   
   Public Sub Load(sb As StatusBar)
      If Not _loaded Then
         Dim txt As String = sb.Text
         sb.Text = "Please wait. Loading functions..."
         
         ' setup function code
         ' can be long operation because code will be compiled in memory
         Dim i As Integer
         For i = 0 To _flist.Length - 1
            If TypeOf _flist(i) Is YFunction Then
               Dim yf As YFunction = CType(_flist(i), YFunction)
               yf.CodeText = _ycodes(i)
            ElseIf TypeOf _flist(i) Is ParametricFunction Then
               Dim pf As ParametricFunction = CType(_flist(i), ParametricFunction)
               pf.CodeTextX = _xcodes(i)
               pf.CodeTextY = _ycodes(i)
            End If
         Next i
         
         sb.Text = txt
         
         _loaded = True
      End If
   End Sub 'Load
   
   
   Public ReadOnly Property FunctionList() As FunctionBase()
      Get
         Return _flist
      End Get
   End Property
End Class 'FunctionsGroup
