
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports C1.Win.C1Chart3D



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   Private [step] As Integer = 0
   Private npoints As Integer = 30
   Private loaded As Boolean = False
   
   Private pset As New Chart3DDataSetPoint()
   WithEvents timer1 As System.Windows.Forms.Timer
   Private panel1 As System.Windows.Forms.Panel
   WithEvents cbLegend As System.Windows.Forms.CheckBox
   WithEvents cbMotion As System.Windows.Forms.CheckBox
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem3 As System.Windows.Forms.MenuItem
   WithEvents cbLabels As System.Windows.Forms.CheckBox
   WithEvents cbPaths As System.Windows.Forms.CheckBox
   WithEvents cbAxes As System.Windows.Forms.CheckBox
   WithEvents cbLines As System.Windows.Forms.CheckBox
   WithEvents cbDepth As System.Windows.Forms.CheckBox
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   Private components As System.ComponentModel.IContainer
   
   
   Public Sub New()
      InitializeComponent()
   End Sub 'New
   
   
   Sub initData()
      Dim pts As Chart3DPoint() = CType(Array.CreateInstance(GetType(Chart3DPoint), 1), Chart3DPoint())
      pset.AddSeries(pts)
      pset.AddSeries(pts)
      pset.AddSeries(pts)
      
      Dim pts0 As Chart3DPoint() = CType(Array.CreateInstance(GetType(Chart3DPoint), npoints), Chart3DPoint())
      Dim pts1 As Chart3DPoint() = CType(Array.CreateInstance(GetType(Chart3DPoint), npoints), Chart3DPoint())
      Dim pts2 As Chart3DPoint() = CType(Array.CreateInstance(GetType(Chart3DPoint), npoints), Chart3DPoint())
      
      Dim i As Integer
      For i = 0 To (npoints - 1) - 1
         Dim c As Single = CSng(10 * Math.Cos((i * 2 * Math.PI / npoints - 1)))
         Dim s As Single = CSng(10 * Math.Sin((i * 2 * Math.PI / npoints - 1)))
         
         pts0(i).X = c
         pts0(i).Y = 0
         pts0(i).Z = s
         
         pts1(i).X = c
         pts1(i).Y = s
         pts1(i).Z = 0
         
         pts2(i).X = 0
         pts2(i).Y = s
         pts2(i).Z = c
      Next i
      
      pts0((npoints - 1)) = pts0(0)
      pts1((npoints - 1)) = pts1(0)
      pts2((npoints - 1)) = pts2(0)
      
      pset.AddSeries(pts0)
      pset.AddSeries(pts1)
      pset.AddSeries(pts2)
      
      pset.SeriesCollection(3).Connected = True
      pset.SeriesCollection(4).Connected = True
      pset.SeriesCollection(5).Connected = True
      
      c1Chart3D1.ChartGroups(0).ChartData.Set = pset
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
      Me.components = New System.ComponentModel.Container()
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      Me.timer1 = New System.Windows.Forms.Timer(Me.components)
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.cbLabels = New System.Windows.Forms.CheckBox()
      Me.cbMotion = New System.Windows.Forms.CheckBox()
      Me.cbLegend = New System.Windows.Forms.CheckBox()
      Me.cbPaths = New System.Windows.Forms.CheckBox()
      Me.cbAxes = New System.Windows.Forms.CheckBox()
      Me.cbLines = New System.Windows.Forms.CheckBox()
      Me.cbDepth = New System.Windows.Forms.CheckBox()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem3 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.panel1.SuspendLayout()
      Me.SuspendLayout()
      ' 
      ' c1Chart3D1
      ' 
      Me.c1Chart3D1.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
      Me.c1Chart3D1.Location = New System.Drawing.Point(120, 0)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><LabelsCollection><Chart3DLabel C" + "onnected=""True"" AttachMethod=""DataIndex"" LabelCompass=""NorthEast"" StyleName=""Sty" + "le1"" Offset=""20"" Compass=""North"" Text=""1""><AttachMethodData PointIndex=""0"" Serie" + "sIndex=""0"" /></Chart3DLabel><Chart3DLabel Connected=""True"" AttachMethod=""DataInd" + "ex"" LabelCompass=""NorthEast"" StyleName=""Style2"" Offset=""20"" Compass=""North"" Text" + "=""2""><AttachMethodData PointIndex=""0"" SeriesIndex=""1"" /></Chart3DLabel><Chart3DL" + "abel Connected=""True"" AttachMethod=""DataIndex"" LabelCompass=""NorthEast"" StyleNam" + "e=""Style3"" Offset=""20"" Compass=""North"" Text=""3""><AttachMethodData PointIndex=""0""" + " SeriesIndex=""2"" /></Chart3DLabel></LabelsCollection><View BackColor=""DarkGray"" " + "PreviewMethod=""PreviewFull"" IsInteractive=""True"" /><ChartGroupsCollection><Chart" + "3DGroup ChartType=""Scatter""><ChartData><Set type=""Chart3DDataSetGrid"" RowOrigin=" + """0"" RowDelta=""1"" RowCount=""11"" ColumnCount=""11"" ColumnDelta=""1"" ColumnOrigin=""0""" + " Hole=""3.40282347E+38""><Data>4.5 3.6 2.89999986 2.39999986 2.1 1.99999988 2.1 2." + "39999986 2.89999986 3.6 4.5 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 10.9 10 9.3 " + "8.8 8.5 8.4 8.5 8.8 9.3 10 10.9 12.9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12" + ".9 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 14.5 13.6 12.9 12.4 12.1 1" + "2 12.1 12.4 12.9 13.6 14.5 14.1 13.2 12.5 12 11.7 11.6 11.7 12 12.5 13.2 14.1 12" + ".9 12 11.3 10.8 10.5 10.4 10.5 10.8 11.3 12 12.9 10.9 10 9.3 8.8 8.5 8.4 8.5 8.8" + " 9.3 10 10.9 8.1 7.2 6.5 6 5.7 5.6 5.7 6 6.5 7.2 8.1 4.5 3.6 2.89999986 2.399999" + "86 2.1 1.99999988 2.1 2.39999986 2.89999986 3.6 4.5</Data></Set></ChartData></Ch" + "art3DGroup></ChartGroupsCollection><StyleCollection><NamedStyle Name=""Legend"" Pa" + "rentName=""Legend.default"" StyleData=""Border=Solid,Black,1;BackColor=Silver;"" /><" + "NamedStyle Name=""Footer"" ParentName=""Control"" /><NamedStyle Name=""Area"" ParentNa" + "me=""Area.default"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" /><N" + "amedStyle Name=""Style1"" ParentName=""LabelStyleDefault"" /><NamedStyle Name=""Style" + "3"" ParentName=""LabelStyleDefault"" /><NamedStyle Name=""Style2"" ParentName=""LabelS" + "tyleDefault"" /><NamedStyle Name=""LabelStyleDefault"" ParentName=""Control"" StyleDa" + "ta=""BackColor=Transparent;"" /><NamedStyle Name=""Legend.default"" ParentName=""Cont" + "rol"" StyleData=""Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""Header"" ParentNam" + "e=""Control"" /><NamedStyle Name=""Control.default"" ParentName="""" StyleData=""ForeCo" + "lor=ControlText;BackColor=Control;"" /><NamedStyle Name=""Area.default"" ParentName" + "=""Control"" StyleData=""AlignVert=Top;"" /></StyleCollection><ChartStyles><Chart3DS" + "tyle><LineStyle Pattern=""Solid"" Color=""LightCoral"" Thickness=""0"" /><SymbolStyle " + "Size=""3"" Color=""LightCoral"" Shape=""Dot"" /></Chart3DStyle><Chart3DStyle><LineStyl" + "e Pattern=""Solid"" Color=""LightYellow"" Thickness=""0"" /><SymbolStyle Size=""3"" Colo" + "r=""LightYellow"" Shape=""Dot"" /></Chart3DStyle><Chart3DStyle><LineStyle Pattern=""S" + "olid"" Color=""LightGreen"" Thickness=""0"" /><SymbolStyle Size=""3"" Color=""LightGreen" + """ Shape=""Dot"" /></Chart3DStyle><Chart3DStyle><LineStyle Pattern=""Solid"" Color=""L" + "ightCoral"" Thickness=""0"" /><SymbolStyle Size=""12"" Color=""Red"" Shape=""Star"" /></C" + "hart3DStyle><Chart3DStyle><LineStyle Pattern=""Solid"" Color=""LightGreen"" Thicknes" + "s=""0"" /><SymbolStyle Size=""12"" Color=""LawnGreen"" Shape=""Star"" /></Chart3DStyle><" + "Chart3DStyle><LineStyle Pattern=""Solid"" Color=""LightYellow"" Thickness=""0"" /><Sym" + "bolStyle Size=""12"" Color=""Yellow"" Shape=""Star"" /></Chart3DStyle></ChartStyles><F" + "ooterData Compass=""South"" /><HeaderData Compass=""North"" /><LegendData Compass=""E" + "ast"" /></Chart3DPropBag>"

      Me.c1Chart3D1.Size = New System.Drawing.Size(472, 403)
      Me.c1Chart3D1.TabIndex = 0
      ' 
      ' timer1
      ' 
      Me.timer1.Interval = 200
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbLabels, Me.cbMotion, Me.cbLegend, Me.cbPaths, Me.cbAxes, Me.cbLines, Me.cbDepth})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(112, 403)
      Me.panel1.TabIndex = 1
      ' 
      ' cbLabels
      ' 
      Me.cbLabels.Location = New System.Drawing.Point(16, 112)
      Me.cbLabels.Name = "cbLabels"
      Me.cbLabels.TabIndex = 2
      Me.cbLabels.Text = "Labels"
      ' 
      ' cbMotion
      ' 
      Me.cbMotion.Location = New System.Drawing.Point(16, 16)
      Me.cbMotion.Name = "cbMotion"
      Me.cbMotion.TabIndex = 1
      Me.cbMotion.Text = "Motion"
      ' 
      ' cbLegend
      ' 
      Me.cbLegend.Location = New System.Drawing.Point(16, 80)
      Me.cbLegend.Name = "cbLegend"
      Me.cbLegend.TabIndex = 0
      Me.cbLegend.Text = "Legend"
      ' 
      ' cbPaths
      ' 
      Me.cbPaths.Checked = True
      Me.cbPaths.CheckState = System.Windows.Forms.CheckState.Checked
      Me.cbPaths.Location = New System.Drawing.Point(16, 144)
      Me.cbPaths.Name = "cbPaths"
      Me.cbPaths.Size = New System.Drawing.Size(72, 24)
      Me.cbPaths.TabIndex = 2
      Me.cbPaths.Text = "Paths"
      ' 
      ' cbAxes
      ' 
      Me.cbAxes.Checked = True
      Me.cbAxes.CheckState = System.Windows.Forms.CheckState.Checked
      Me.cbAxes.Location = New System.Drawing.Point(16, 48)
      Me.cbAxes.Name = "cbAxes"
      Me.cbAxes.Size = New System.Drawing.Size(72, 24)
      Me.cbAxes.TabIndex = 2
      Me.cbAxes.Text = "Axes"
      ' 
      ' cbLines
      ' 
      Me.cbLines.Location = New System.Drawing.Point(16, 176)
      Me.cbLines.Name = "cbLines"
      Me.cbLines.Size = New System.Drawing.Size(80, 24)
      Me.cbLines.TabIndex = 2
      Me.cbLines.Text = "Drop lines"
      ' 
      ' cbDepth
      ' 
      Me.cbDepth.Location = New System.Drawing.Point(16, 208)
      Me.cbDepth.Name = "cbDepth"
      Me.cbDepth.Size = New System.Drawing.Size(80, 24)
      Me.cbDepth.TabIndex = 2
      Me.cbDepth.Text = "Depth Cue"
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
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 3D - Scatter Demo"
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      c1Chart3D1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      initData()
      loaded = True
   End Sub 'Form1_Load
   
   
   Private Sub timer1_Tick(sender As Object, e As System.EventArgs) Handles timer1.Tick
      If [step] >= npoints Then
         [step] = 0
      End If 
      pset(0, 0) = pset(3, [step])
      pset(1, 0) = pset(4, [step])
      pset(2, 0) = pset(5, [step])
      
      [step] += 1
   End Sub 'timer1_Tick
   
   
   Private Sub cbLegend_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbLegend.CheckedChanged
      c1Chart3D1.Legend.Visible = cbLegend.Checked
   End Sub 'cbLegend_CheckedChanged
   
   
   Private Sub cbMotion_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbMotion.CheckedChanged
      timer1.Enabled = cbMotion.Checked
   End Sub 'cbMotion_CheckedChanged
   
   
   Private Sub cbLabels_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbLabels.CheckedChanged
      c1Chart3D1.ChartLabels(0).Visible = cbLabels.Checked
      c1Chart3D1.ChartLabels(1).Visible = cbLabels.Checked
      c1Chart3D1.ChartLabels(2).Visible = cbLabels.Checked
   End Sub 'cbLabels_CheckedChanged
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub cbPaths_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbPaths.CheckedChanged
      If Not loaded Then
         Return
      End If
      c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection(3).Visible = cbPaths.Checked
      c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection(4).Visible = cbPaths.Checked
      c1Chart3D1.ChartGroups.Group0.ChartData.SetPoint.SeriesCollection(5).Visible = cbPaths.Checked
   End Sub 'cbPaths_CheckedChanged
   
   
   Private Sub cbAxes_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbAxes.CheckedChanged
      c1Chart3D1.ChartArea.AxisX.Visible = cbAxes.Checked
      c1Chart3D1.ChartArea.AxisY.Visible = cbAxes.Checked
      c1Chart3D1.ChartArea.AxisZ.Visible = cbAxes.Checked
      If cbAxes.Checked Then
         c1Chart3D1.ChartArea.View.BackColor = Color.Silver
      Else
         c1Chart3D1.ChartArea.View.BackColor = Color.Transparent
      End If
   End Sub 'cbAxes_CheckedChanged
    
   Private Sub cbLines_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbLines.CheckedChanged
      c1Chart3D1.ChartGroups.Group0.Elevation.DropLines = cbLines.Checked
   End Sub 'cbLines_CheckedChanged
   
   
   Private Sub cbDepth_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbDepth.CheckedChanged
      c1Chart3D1.ChartGroups.Group0.Elevation.DepthCue = cbDepth.Checked
   End Sub 'cbDepth_CheckedChanged
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
End Class 'Form1
