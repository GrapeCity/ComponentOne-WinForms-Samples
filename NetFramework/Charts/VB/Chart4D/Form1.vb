
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
   Private c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   Private panel1 As System.Windows.Forms.Panel
   Private groupBox1 As System.Windows.Forms.GroupBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents rbSphere As System.Windows.Forms.RadioButton
   WithEvents rbWave As System.Windows.Forms.RadioButton
   Private groupBox2 As System.Windows.Forms.GroupBox
   WithEvents rbConNone As System.Windows.Forms.RadioButton
   WithEvents rbConSphere As System.Windows.Forms.RadioButton
   WithEvents rbConWaves As System.Windows.Forms.RadioButton
   WithEvents rbConRandom As System.Windows.Forms.RadioButton
   Private pgConStyle As System.Windows.Forms.PropertyGrid
   Private groupBox3 As System.Windows.Forms.GroupBox
   WithEvents rbBar As System.Windows.Forms.RadioButton
   WithEvents rbSurface As System.Windows.Forms.RadioButton
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   Private sphere_set As C1.Win.C1Chart3D.Chart3DDataSetGrid = Nothing
   Private wave_set As C1.Win.C1Chart3D.Chart3DDataSetGrid = Nothing
   Private npoints As Integer = 21
   Private sdata As Double(,) = Nothing
   Private wdata As Double(,) = Nothing
   Private rdata As Double(,) = Nothing
   Private rnd As New Random()
   
   
   Sub initData()
      Dim nx As Integer = npoints
      Dim ny As Integer = npoints
      Dim x0 As Single = - 5
      Dim y0 As Single = - 5
      Dim dx As Single = 10F /(npoints - 1)
      Dim dy As Single = 10F /(npoints - 1)
      sdata = CType(Array.CreateInstance(GetType(Double), nx, ny), Double(,))
      wdata = CType(Array.CreateInstance(GetType(Double), nx, ny), Double(,))
      rdata = CType(Array.CreateInstance(GetType(Double), nx, ny), Double(,))
      Dim i As Integer
      For i = 0 To nx - 1
         Dim j As Integer
         For j = 0 To ny - 1
            Dim x As Single = x0 + dx * i
            Dim y As Single = y0 + dy * j
            sdata(i, j) = Math.Sqrt((50 - x * x - y * y))
            wdata(i, j) = Math.Sin(x) + Math.Cos(y)
            rdata(i, j) = rnd.NextDouble()
         Next j
      Next i 
      sphere_set = New C1.Win.C1Chart3D.Chart3DDataSetGrid(x0, y0, 1, 1, sdata)
      wave_set = New C1.Win.C1Chart3D.Chart3DDataSetGrid(x0, y0, 1, 1, wdata)
   End Sub 'initData
   
   
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
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.groupBox3 = New System.Windows.Forms.GroupBox()
      Me.rbSurface = New System.Windows.Forms.RadioButton()
      Me.rbBar = New System.Windows.Forms.RadioButton()
      Me.pgConStyle = New System.Windows.Forms.PropertyGrid()
      Me.groupBox2 = New System.Windows.Forms.GroupBox()
      Me.rbConRandom = New System.Windows.Forms.RadioButton()
      Me.rbConWaves = New System.Windows.Forms.RadioButton()
      Me.rbConSphere = New System.Windows.Forms.RadioButton()
      Me.rbConNone = New System.Windows.Forms.RadioButton()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.rbWave = New System.Windows.Forms.RadioButton()
      Me.rbSphere = New System.Windows.Forms.RadioButton()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panel1.SuspendLayout()
      Me.groupBox3.SuspendLayout()
      Me.groupBox2.SuspendLayout()
      Me.groupBox1.SuspendLayout()
      Me.SuspendLayout()
      ' 
      ' c1Chart3D1
      ' 
      Me.c1Chart3D1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
      Me.c1Chart3D1.Location = New System.Drawing.Point(204, 0)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><AxisX /><AxisY /><AxisZ /><Chart" + "GroupsCollection><Chart3DGroup ChartType=""Surface""><Elevation><SurfaceTopColor>W" + "hite</SurfaceTopColor><SurfaceBottomColor>DarkGray</SurfaceBottomColor></Elevati" + "on><ChartData><Set type=""Chart3DDataSetGrid"" RowOrigin=""0"" RowDelta=""1"" RowCount" + "=""11"" ColumnCount=""11"" ColumnDelta=""1"" ColumnOrigin=""0"" Hole=""3.40282347E+38""><D" + "ata>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4" + ".5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 1" + "0 10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 14.1 13.2 12.5 12 11.7" + " 11.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 12 12.1 12.4 12.9 13.6 14." + "5 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12.9 12 11.3 10.8 10.5 10.4" + " 10.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 8.1 7.2 6.5 " + "6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2.3" + "9999986 2.89999986 3.6 4.5 </Data></Set></ChartData><Bar /><Surface /><Contour I" + "sZoned=""True"" NumLevels=""25"" /></Chart3DGroup></ChartGroupsCollection><ChartStyl" + "es><Chart3DStyle><LineStyle Color=""Black"" Pattern=""Solid"" Thickness=""0"" /><Symbo" + "lStyle Color=""Coral"" Shape=""Box"" Size=""5"" /></Chart3DStyle></ChartStyles><Contou" + "rStyles ColorSet=""RevRainbow"" /><LegendData Compass=""East"" /><StyleCollection><N" + "amedStyle Name=""Legend"" ParentName=""Legend.default"" StyleData="""" /><NamedStyle N" + "ame=""Footer"" ParentName=""Control"" StyleData="""" /><NamedStyle Name=""Area"" ParentN" + "ame=""Area.default"" StyleData=""Border=Empty,Black,1;"" /><NamedStyle Name=""Control" + """ ParentName=""Control.default"" StyleData=""Border=Solid,Black,1;"" /><NamedStyle N" + "ame=""LabelStyleDefault"" ParentName=""Control"" StyleData=""BackColor=Transparent;"" " + "/><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Wrap=False;A" + "lignVert=Top;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleData="""" /><" + "NamedStyle Name=""Control.default"" ParentName="""" StyleData=""ForeColor=ControlText" + ";BackColor=Control;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" Styl" + "eData=""AlignVert=Top;"" /></StyleCollection><FooterData Compass=""South"" /><View I" + "sInteractive=""True"" AxisTitleFont=""Microsoft Sans Serif, 12world"" AxisFont=""Micr" + "osoft Sans Serif, 10world""><Ceiling /><Floor /></View><HeaderData Compass=""North" + """ /></Chart3DPropBag>"

      Me.c1Chart3D1.Size = New System.Drawing.Size(388, 403)
      Me.c1Chart3D1.TabIndex = 0
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.groupBox3, Me.pgConStyle, Me.groupBox2, Me.groupBox1})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(200, 403)
      Me.panel1.TabIndex = 1
      ' 
      ' groupBox3
      ' 
      Me.groupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbSurface, Me.rbBar})
      Me.groupBox3.Location = New System.Drawing.Point(8, 8)
      Me.groupBox3.Name = "groupBox3"
      Me.groupBox3.Size = New System.Drawing.Size(184, 48)
      Me.groupBox3.TabIndex = 4
      Me.groupBox3.TabStop = False
      Me.groupBox3.Text = "Chart Type"
      ' 
      ' rbSurface
      ' 
      Me.rbSurface.Location = New System.Drawing.Point(104, 16)
      Me.rbSurface.Name = "rbSurface"
      Me.rbSurface.Size = New System.Drawing.Size(72, 24)
      Me.rbSurface.TabIndex = 1
      Me.rbSurface.Text = "Surface"
      ' 
      ' rbBar
      ' 
      Me.rbBar.Location = New System.Drawing.Point(8, 16)
      Me.rbBar.Name = "rbBar"
      Me.rbBar.Size = New System.Drawing.Size(40, 24)
      Me.rbBar.TabIndex = 0
      Me.rbBar.Text = "Bar"
      ' 
      ' pgConStyle
      ' 
      Me.pgConStyle.CommandsVisibleIfAvailable = True
      Me.pgConStyle.HelpVisible = False
      Me.pgConStyle.LargeButtons = False
      Me.pgConStyle.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.pgConStyle.Location = New System.Drawing.Point(8, 184)
      Me.pgConStyle.Name = "pgConStyle"
      Me.pgConStyle.PropertySort = System.Windows.Forms.PropertySort.Alphabetical
      Me.pgConStyle.Size = New System.Drawing.Size(184, 56)
      Me.pgConStyle.TabIndex = 3
      Me.pgConStyle.Text = "propertyGrid1"
      Me.pgConStyle.ToolbarVisible = False
      Me.pgConStyle.ViewBackColor = System.Drawing.SystemColors.Window
      Me.pgConStyle.ViewForeColor = System.Drawing.SystemColors.WindowText
      ' 
      ' groupBox2
      ' 
      Me.groupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbConRandom, Me.rbConWaves, Me.rbConSphere, Me.rbConNone})
      Me.groupBox2.Location = New System.Drawing.Point(104, 56)
      Me.groupBox2.Name = "groupBox2"
      Me.groupBox2.Size = New System.Drawing.Size(88, 120)
      Me.groupBox2.TabIndex = 2
      Me.groupBox2.TabStop = False
      Me.groupBox2.Text = "Contour Data"
      ' 
      ' rbConRandom
      ' 
      Me.rbConRandom.Location = New System.Drawing.Point(8, 88)
      Me.rbConRandom.Name = "rbConRandom"
      Me.rbConRandom.Size = New System.Drawing.Size(68, 24)
      Me.rbConRandom.TabIndex = 3
      Me.rbConRandom.Text = "Random"
      ' 
      ' rbConWaves
      ' 
      Me.rbConWaves.Location = New System.Drawing.Point(8, 64)
      Me.rbConWaves.Name = "rbConWaves"
      Me.rbConWaves.Size = New System.Drawing.Size(64, 24)
      Me.rbConWaves.TabIndex = 2
      Me.rbConWaves.Text = "Waves"
      ' 
      ' rbConSphere
      ' 
      Me.rbConSphere.Location = New System.Drawing.Point(8, 40)
      Me.rbConSphere.Name = "rbConSphere"
      Me.rbConSphere.Size = New System.Drawing.Size(64, 24)
      Me.rbConSphere.TabIndex = 1
      Me.rbConSphere.Text = "Sphere"
      ' 
      ' rbConNone
      ' 
      Me.rbConNone.Location = New System.Drawing.Point(8, 16)
      Me.rbConNone.Name = "rbConNone"
      Me.rbConNone.Size = New System.Drawing.Size(56, 24)
      Me.rbConNone.TabIndex = 0
      Me.rbConNone.Text = "None"
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbWave, Me.rbSphere})
      Me.groupBox1.Location = New System.Drawing.Point(8, 56)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(96, 72)
      Me.groupBox1.TabIndex = 1
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Elevation Data"
      ' 
      ' rbWave
      ' 
      Me.rbWave.Location = New System.Drawing.Point(8, 40)
      Me.rbWave.Name = "rbWave"
      Me.rbWave.Size = New System.Drawing.Size(64, 24)
      Me.rbWave.TabIndex = 1
      Me.rbWave.Text = "Waves"
      ' 
      ' rbSphere
      ' 
      Me.rbSphere.Location = New System.Drawing.Point(8, 16)
      Me.rbSphere.Name = "rbSphere"
      Me.rbSphere.Size = New System.Drawing.Size(64, 24)
      Me.rbSphere.TabIndex = 0
      Me.rbSphere.Text = "Sphere"
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
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel1, Me.c1Chart3D1})
      Me.Menu = Me.mainMenu1
      Me.MinimumSize = New System.Drawing.Size(300, 308)
      Me.Name = "Form1"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 3D - 4D Chart Demo"
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.panel1.ResumeLayout(False)
      Me.groupBox3.ResumeLayout(False)
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
   
   
   Private Sub btnGen4_Click(sender As Object, e As System.EventArgs)
      Dim rnd As New Random()
      Dim nx As Integer = c1Chart3D1.ChartGroups.Group0.ChartData.SetGrid.ColumnCount
      Dim ny As Integer = c1Chart3D1.ChartGroups.Group0.ChartData.SetGrid.RowCount
      Dim data As Double(,) = CType(Array.CreateInstance(GetType(Double), nx, ny), Double(,))
      Dim i As Integer
      For i = 0 To nx - 1
         Dim j As Integer
         For j = 0 To ny - 1
            data(i, j) = rnd.NextDouble()
         Next j
      Next i
      c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = data
   End Sub 'btnGen4_Click
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      initData()
      pgConStyle.SelectedObject = New ContourProperties(c1Chart3D1)
      rbSphere.Checked = True
      rbSurface.Checked = True
   End Sub 'Form1_Load
   
   
   Private Sub rbSphere_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbSphere.CheckedChanged
      If rbSphere.Checked Then
         c1Chart3D1.ChartGroups(0).ChartData.SetGrid = sphere_set
      Else
         c1Chart3D1.ChartGroups(0).ChartData.SetGrid = wave_set
      End If
   End Sub 'rbSphere_CheckedChanged
    
   Private Sub rbConNone_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbConNone.CheckedChanged
      If rbConNone.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = Nothing
      End If
   End Sub 'rbConNone_CheckedChanged
    
   Private Sub rbConSphere_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbConSphere.CheckedChanged
      If rbConSphere.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = sdata
      End If
   End Sub 'rbConSphere_CheckedChanged
    
   Private Sub rbConWaves_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbConWaves.CheckedChanged
      If rbConWaves.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = wdata
      End If
   End Sub 'rbConWaves_CheckedChanged
    
   Private Sub rbConRandom_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbConRandom.CheckedChanged
      If rbConRandom.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartData.ContourData = rdata
      End If
   End Sub 'rbConRandom_CheckedChanged
    
   Private Sub rbBar_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbBar.CheckedChanged
      If rbBar.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Bar
      End If
   End Sub 'rbBar_CheckedChanged
    
   Private Sub rbSurface_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbSurface.CheckedChanged
      If rbSurface.Checked Then
         c1Chart3D1.ChartGroups.Group0.ChartType = C1.Win.C1Chart3D.Chart3DTypeEnum.Surface
      End If
   End Sub 'rbSurface_CheckedChanged
    
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1


Class ContourProperties
   Private _chart As C1.Win.C1Chart3D.C1Chart3D
   
   
   Public Sub New(chart As C1.Win.C1Chart3D.C1Chart3D)
      _chart = chart
   End Sub 'New
   
   
   Public ReadOnly Property Colors() As C1.Win.C1Chart3D.Chart3DColorsCollection
      Get
         Return _chart.ChartGroups.ContourStyles.Colors
      End Get
   End Property 
   
   Public Property ColorSet() As C1.Win.C1Chart3D.ColorSetEnum
      Get
         Return _chart.ChartGroups.ContourStyles.ColorSet
      End Get
      Set
         _chart.ChartGroups.ContourStyles.ColorSet = value
      End Set
   End Property 
   
   Public ReadOnly Property Styles() As C1.Win.C1Chart3D.Chart3DContourStylesCollection
      Get
         Return _chart.ChartGroups.ContourStyles.Styles
      End Get
   End Property
End Class 'ContourProperties
