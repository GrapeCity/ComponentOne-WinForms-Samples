
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Reflection
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Text

Imports C1.Win.C1ChartBase
Imports C1.Win.C1Chart
Imports C1.Win.C1Chart3D



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuFile As System.Windows.Forms.MenuItem
   WithEvents menuOptions As System.Windows.Forms.MenuItem
   WithEvents menuPixelData As System.Windows.Forms.MenuItem
   WithEvents menuSaveAs As System.Windows.Forms.MenuItem
   WithEvents menuPrintToFit As System.Windows.Forms.MenuItem
   WithEvents menuExit As System.Windows.Forms.MenuItem
   WithEvents menuFixedAspect As System.Windows.Forms.MenuItem
   WithEvents menuHeaderVersion As System.Windows.Forms.MenuItem
   WithEvents menuFooterVersion As System.Windows.Forms.MenuItem
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents c1Chart3D1 As C1.Win.C1Chart3D.C1Chart3D
   WithEvents menuLoad As System.Windows.Forms.MenuItem
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   Private openFileDialog1 As System.Windows.Forms.OpenFileDialog
   Private saveFileDialog1 As System.Windows.Forms.SaveFileDialog
   
   Private chart As ChartHandler = Nothing
   WithEvents menuPropGrid As System.Windows.Forms.MenuItem
   WithEvents menuItem2 As System.Windows.Forms.MenuItem
   WithEvents menuLoadVer As System.Windows.Forms.MenuItem
   WithEvents menuResetChart As System.Windows.Forms.MenuItem
   WithEvents menuChartSelect As System.Windows.Forms.MenuItem
   WithEvents menuFileSep1 As System.Windows.Forms.MenuItem
   WithEvents menuChartProps As System.Windows.Forms.MenuItem
   WithEvents menuChartWizard As System.Windows.Forms.MenuItem
   WithEvents menuClientSize As System.Windows.Forms.MenuItem
   WithEvents menuSave As System.Windows.Forms.MenuItem
   WithEvents menuLoadFromUrl As System.Windows.Forms.MenuItem
   WithEvents menuLoadFromUrlVersion As System.Windows.Forms.MenuItem
   WithEvents menuItem4 As System.Windows.Forms.MenuItem
   WithEvents menuLoadFromClipboard As System.Windows.Forms.MenuItem
   WithEvents menuLoadFromClipboardVersion As System.Windows.Forms.MenuItem
   WithEvents menuSaveToClipboard As System.Windows.Forms.MenuItem
   WithEvents menuNewWindow As System.Windows.Forms.MenuItem
   WithEvents menuChartPropsLatest As System.Windows.Forms.MenuItem
   WithEvents menuChartPropsPrevious As System.Windows.Forms.MenuItem
   WithEvents menuChartWizardLatest As System.Windows.Forms.MenuItem
   WithEvents menuChartWizardPrevious As System.Windows.Forms.MenuItem
   
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
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuFile = New System.Windows.Forms.MenuItem()
      Me.menuNewWindow = New System.Windows.Forms.MenuItem()
      Me.menuChartSelect = New System.Windows.Forms.MenuItem()
      Me.menuFileSep1 = New System.Windows.Forms.MenuItem()
      Me.menuLoad = New System.Windows.Forms.MenuItem()
      Me.menuLoadVer = New System.Windows.Forms.MenuItem()
      Me.menuLoadFromUrl = New System.Windows.Forms.MenuItem()
      Me.menuLoadFromUrlVersion = New System.Windows.Forms.MenuItem()
      Me.menuLoadFromClipboard = New System.Windows.Forms.MenuItem()
      Me.menuLoadFromClipboardVersion = New System.Windows.Forms.MenuItem()
      Me.menuItem4 = New System.Windows.Forms.MenuItem()
      Me.menuSave = New System.Windows.Forms.MenuItem()
      Me.menuSaveAs = New System.Windows.Forms.MenuItem()
      Me.menuSaveToClipboard = New System.Windows.Forms.MenuItem()
      Me.menuPrintToFit = New System.Windows.Forms.MenuItem()
      Me.menuResetChart = New System.Windows.Forms.MenuItem()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuExit = New System.Windows.Forms.MenuItem()
      Me.menuOptions = New System.Windows.Forms.MenuItem()
      Me.menuFixedAspect = New System.Windows.Forms.MenuItem()
      Me.menuClientSize = New System.Windows.Forms.MenuItem()
      Me.menuPropGrid = New System.Windows.Forms.MenuItem()
      Me.menuChartProps = New System.Windows.Forms.MenuItem()
      Me.menuChartPropsLatest = New System.Windows.Forms.MenuItem()
      Me.menuChartPropsPrevious = New System.Windows.Forms.MenuItem()
      Me.menuChartWizard = New System.Windows.Forms.MenuItem()
      Me.menuChartWizardLatest = New System.Windows.Forms.MenuItem()
      Me.menuChartWizardPrevious = New System.Windows.Forms.MenuItem()
      Me.menuItem2 = New System.Windows.Forms.MenuItem()
      Me.menuHeaderVersion = New System.Windows.Forms.MenuItem()
      Me.menuFooterVersion = New System.Windows.Forms.MenuItem()
      Me.menuPixelData = New System.Windows.Forms.MenuItem()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
      Me.saveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
      Me.c1Chart3D1 = New C1.Win.C1Chart3D.C1Chart3D()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFile, Me.menuOptions, Me.menuPixelData})
      ' 
      ' menuFile
      ' 
      Me.menuFile.Index = 0
      Me.menuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuNewWindow, Me.menuChartSelect, Me.menuFileSep1, Me.menuLoad, Me.menuLoadVer, Me.menuLoadFromUrl, Me.menuLoadFromUrlVersion, Me.menuLoadFromClipboard, Me.menuLoadFromClipboardVersion, Me.menuItem4, Me.menuSave, Me.menuSaveAs, Me.menuSaveToClipboard, Me.menuPrintToFit, Me.menuResetChart, Me.menuItem1, Me.menuExit})
      Me.menuFile.Text = "File"
      ' 
      ' menuNewWindow
      ' 
      Me.menuNewWindow.Index = 0
      Me.menuNewWindow.Text = "New Window"
      ' 
      ' menuChartSelect
      ' 
      Me.menuChartSelect.Index = 1
      Me.menuChartSelect.Text = "Switch to 3D Chart"
      ' 
      ' menuFileSep1
      ' 
      Me.menuFileSep1.Index = 2
      Me.menuFileSep1.Text = "-"
      ' 
      ' menuLoad
      ' 
      Me.menuLoad.Index = 3
      Me.menuLoad.Text = "Load..."
      ' 
      ' menuLoadVer
      ' 
      Me.menuLoadVer.Index = 4
      Me.menuLoadVer.Text = "Load with Version Check..."
      ' 
      ' menuLoadFromUrl
      ' 
      Me.menuLoadFromUrl.Index = 5
      Me.menuLoadFromUrl.Text = "Load From URL..."
      ' 
      ' menuLoadFromUrlVersion
      ' 
      Me.menuLoadFromUrlVersion.Index = 6
      Me.menuLoadFromUrlVersion.Text = "Load From URL with Version Check..."
      ' 
      ' menuLoadFromClipboard
      ' 
      Me.menuLoadFromClipboard.Index = 7
      Me.menuLoadFromClipboard.Text = "Load From Clipboard"
      ' 
      ' menuLoadFromClipboardVersion
      ' 
      Me.menuLoadFromClipboardVersion.Index = 8
      Me.menuLoadFromClipboardVersion.Text = "Load From Clipboard with Version Check..."
      ' 
      ' menuItem4
      ' 
      Me.menuItem4.Index = 9
      Me.menuItem4.Text = "-"
      ' 
      ' menuSave
      ' 
      Me.menuSave.Index = 10
      Me.menuSave.Text = "Save"
      ' 
      ' menuSaveAs
      ' 
      Me.menuSaveAs.Index = 11
      Me.menuSaveAs.Text = "Save As..."
      ' 
      ' menuSaveToClipboard
      ' 
      Me.menuSaveToClipboard.Index = 12
      Me.menuSaveToClipboard.Text = "Save To Clipboard"
      ' 
      ' menuPrintToFit
      ' 
      Me.menuPrintToFit.Index = 13
      Me.menuPrintToFit.Text = "Print to fit..."
      ' 
      ' menuResetChart
      ' 
      Me.menuResetChart.Index = 14
      Me.menuResetChart.Text = "Reset Chart..."
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 15
      Me.menuItem1.Text = "-"
      ' 
      ' menuExit
      ' 
      Me.menuExit.Index = 16
      Me.menuExit.Text = "Exit"
      ' 
      ' menuOptions
      ' 
      Me.menuOptions.Index = 1
      Me.menuOptions.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFixedAspect, Me.menuClientSize, Me.menuPropGrid, Me.menuChartProps, Me.menuChartWizard, Me.menuItem2, Me.menuHeaderVersion, Me.menuFooterVersion})
      Me.menuOptions.Text = "Options"
      ' 
      ' menuFixedAspect
      ' 
      Me.menuFixedAspect.Index = 0
      Me.menuFixedAspect.Text = "Fixed Aspect Ratio"
      ' 
      ' menuClientSize
      ' 
      Me.menuClientSize.Index = 1
      Me.menuClientSize.Text = "ClientSize..."
      ' 
      ' menuPropGrid
      ' 
      Me.menuPropGrid.Index = 2
      Me.menuPropGrid.Text = "Property Grid ..."
      ' 
      ' menuChartProps
      ' 
      Me.menuChartProps.Index = 3
      Me.menuChartProps.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuChartPropsLatest, Me.menuChartPropsPrevious})
      Me.menuChartProps.Text = "Chart Properties"
      ' 
      ' menuChartPropsLatest
      ' 
      Me.menuChartPropsLatest.Index = 0
      Me.menuChartPropsLatest.Text = "Latest Version..."
      ' 
      ' menuChartPropsPrevious
      ' 
      Me.menuChartPropsPrevious.Index = 1
      Me.menuChartPropsPrevious.Text = "Previous Version..."
      ' 
      ' menuChartWizard
      ' 
      Me.menuChartWizard.Index = 4
      Me.menuChartWizard.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuChartWizardLatest, Me.menuChartWizardPrevious})
      Me.menuChartWizard.Text = "Chart Wizard"
      ' 
      ' menuChartWizardLatest
      ' 
      Me.menuChartWizardLatest.Index = 0
      Me.menuChartWizardLatest.Text = "Latest Version..."
      ' 
      ' menuChartWizardPrevious
      ' 
      Me.menuChartWizardPrevious.Index = 1
      Me.menuChartWizardPrevious.Text = "Previous Version..."
      ' 
      ' menuItem2
      ' 
      Me.menuItem2.Index = 5
      Me.menuItem2.Text = "-"
      ' 
      ' menuHeaderVersion
      ' 
      Me.menuHeaderVersion.Index = 6
      Me.menuHeaderVersion.Text = "Header Version"
      ' 
      ' menuFooterVersion
      ' 
      Me.menuFooterVersion.Index = 7
      Me.menuFooterVersion.Text = "Footer Version"
      ' 
      ' menuPixelData
      ' 
      Me.menuPixelData.Index = 2
      Me.menuPixelData.Text = "     Aspect=0  0 x 0"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=None,Black,1;"" /><NamedStyle Nam" + "e=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Footer"" ParentName=""C" + "ontrol"" StyleData=""Border=None,Black,1;"" /><NamedStyle Name=""Area"" ParentName=""A" + "rea.default"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" /><NamedS" + "tyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Center" + ";AlignVert=Bottom;"" /><NamedStyle Name=""AxisY"" ParentName=""Area"" StyleData=""Rota" + "tion=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><NamedStyle Name=""LabelStyleD" + "efault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""Legend.defaul" + "t"" ParentName=""Control"" StyleData=""Border=None,Black,1;Wrap=False;AlignVert=Top;" + """ /><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""Control"" StyleData=" + """Border=None,Black,1;BackColor=Transparent;"" /><NamedStyle Name=""Header"" ParentN" + "ame=""Control"" StyleData=""Border=None,Black,1;"" /><NamedStyle Name=""Control.defau" + "lt"" ParentName="""" StyleData=""ForeColor=ControlText;Border=None,Black,1;BackColor" + "=Control;"" /><NamedStyle Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rot" + "ate90;AlignHorz=Far;AlignVert=Center;"" /><NamedStyle Name=""Area.default"" ParentN" + "ame=""Control"" StyleData=""Border=None,Black,1;AlignVert=Top;"" /></StyleCollection" + "><ChartGroupsCollection><ChartGroup Name=""Group1""><DataSerializer DefaultSet=""Tr" + "ue""><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod""" + " /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><" + "X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Doubl" + "e</DataTypes><DataFields>;;;;</DataFields></DataSeriesSerializer><DataSeriesSeri" + "alizer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""" + "Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" />" + "<SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><" + "X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Doubl" + "e</DataTypes><DataFields>;;;;</DataFields></DataSeriesSerializer><DataSeriesSeri" + "alizer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Diamon" + "d"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><Da" + "taTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFiel" + "ds></DataSeriesSerializer></DataSeriesCollection></DataSerializer></ChartGroup><" + "ChartGroup Name=""Group2""><DataSerializer /></ChartGroup></ChartGroupsCollection>" + "<Header Compass=""North"" /><Footer Compass=""South"" /><Legend Compass=""East"" Visib" + "le=""False"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0" + ".5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""Sou" + "th""><GridMajor /><GridMinor /></Axis><Axis Max=""25"" Min=""5"" UnitMajor=""5"" UnitMi" + "nor=""2.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compas" + "s=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" Un" + "itMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Comp" + "ass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(352, 240)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' saveFileDialog1
      ' 
      Me.saveFileDialog1.FileName = "doc1"
      ' 
      ' c1Chart3D1
      ' 
      Me.c1Chart3D1.Location = New System.Drawing.Point(176, 168)
      Me.c1Chart3D1.Name = "c1Chart3D1"
      Me.c1Chart3D1.PropBag = "<?xml version=""1.0""?><Chart3DPropBag Version=""""><View /><ChartGroupsCollection><C" + "hart3DGroup><ChartData><Set type=""Chart3DDataSetGrid"" RowCount=""11"" ColumnCount=" + """11"" RowDelta=""1"" ColumnDelta=""1"" RowOrigin=""0"" ColumnOrigin=""0"" Hole=""3.4028234" + "663852886E+38""><Data>4.499999888241291 3.599999874830246 2.8999998643994331 2.39" + "99998569488525 2.0999998524785042 1.9999998509883881 2.0999998524785042 2.399999" + "8569488525 2.8999998643994331 3.599999874830246 4.499999888241291 8.099999941885" + "4713 7.1999999284744263 6.4999999180436134 5.9999999105930328 5.6999999061226845" + " 5.5999999046325684 5.6999999061226845 5.9999999105930328 6.4999999180436134 7.1" + "999999284744263 8.0999999418854713 10.899999983608723 9.9999999701976776 9.29999" + "99597668648 8.7999999523162842 8.4999999478459358 8.39999994635582 8.49999994784" + "59358 8.7999999523162842 9.2999999597668648 9.9999999701976776 10.89999998360872" + "3 12.900000013411045 12 11.299999989569187 10.799999982118607 10.499999977648258" + " 10.399999976158142 10.499999977648258 10.799999982118607 11.299999989569187 12 " + "12.900000013411045 14.100000031292439 13.200000017881393 12.500000007450581 12 1" + "1.699999995529652 11.599999994039536 11.699999995529652 12 12.500000007450581 13" + ".200000017881393 14.100000031292439 14.500000037252903 13.600000023841858 12.900" + "000013411045 12.400000005960465 12.100000001490116 12 12.100000001490116 12.4000" + "00005960465 12.900000013411045 13.600000023841858 14.500000037252903 14.10000003" + "1292439 13.200000017881393 12.500000007450581 12 11.699999995529652 11.599999994" + "039536 11.699999995529652 12 12.500000007450581 13.200000017881393 14.1000000312" + "92439 12.900000013411045 12 11.299999989569187 10.799999982118607 10.49999997764" + "8258 10.399999976158142 10.499999977648258 10.799999982118607 11.299999989569187" + " 12 12.900000013411045 10.899999983608723 9.9999999701976776 9.2999999597668648 " + "8.7999999523162842 8.4999999478459358 8.39999994635582 8.4999999478459358 8.7999" + "999523162842 9.2999999597668648 9.9999999701976776 10.899999983608723 8.09999994" + "18854713 7.1999999284744263 6.4999999180436134 5.9999999105930328 5.699999906122" + "6845 5.5999999046325684 5.6999999061226845 5.9999999105930328 6.4999999180436134" + " 7.1999999284744263 8.0999999418854713 4.499999888241291 3.599999874830246 2.899" + "9998643994331 2.3999998569488525 2.0999998524785042 1.9999998509883881 2.0999998" + "524785042 2.3999998569488525 2.8999998643994331 3.599999874830246 4.499999888241" + "291</Data></Set></ChartData></Chart3DGroup></ChartGroupsCollection><StyleCollect" + "ion><NamedStyle Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Fo" + "oter"" ParentName=""Control"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /" + "><NamedStyle Name=""Control"" ParentName=""Control.default"" /><NamedStyle Name=""Lab" + "elStyleDefault"" ParentName=""Control"" StyleData=""BackColor=Transparent;"" /><Named" + "Style Name=""Legend.default"" ParentName=""Control"" StyleData=""Wrap=False;AlignVert" + "=Top;"" /><NamedStyle Name=""Header"" ParentName=""Control"" /><NamedStyle Name=""Cont" + "rol.default"" ParentName="""" StyleData=""ForeColor=ControlText;Border=None,Black,1;" + "BackColor=Control;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" Style" + "Data=""AlignVert=Top;"" /></StyleCollection><LegendData Compass=""East"" /><FooterDa" + "ta Visible=""True"" Compass=""South"" /><HeaderData Visible=""True"" Compass=""North"" /" + "></Chart3DPropBag>"

      Me.c1Chart3D1.Size = New System.Drawing.Size(280, 176)
      Me.c1Chart3D1.TabIndex = 1
      Me.c1Chart3D1.Visible = False
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(488, 361)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart3D1, Me.c1Chart1})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
      Me.Text = "Show Chart 2D/3D Xml"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1Chart3D1, System.ComponentModel.ISupportInitialize).EndInit()
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
   
   
   Private Sub SetChartSelect(sender As Object, e As EventArgs)
      If chart.use2d Then
         menuChartSelect.Text = "Switch to 3D chart"
         menuChartPropsPrevious.Enabled = True
         menuChartWizardPrevious.Enabled = True
      Else
         menuChartSelect.Text = "Switch to 2D chart"
         menuChartPropsPrevious.Enabled = False
         menuChartWizardPrevious.Enabled = False
      End If
      
      Me.Text = chart.LastLoadedFile
   End Sub 'SetChartSelect
   
   
   Private Sub LoadChartInfo(filename As String, versionCheck As Boolean)
      Dim aspChecked As Boolean = Me.menuFixedAspect.Checked
      Me.menuFixedAspect.Checked = False
      Me.menuHeaderVersion.Checked = False
      Me.menuFooterVersion.Checked = False
      chart.LoadChartFromFile(filename, versionCheck)
      Me.Form1_Resize(Nothing, Nothing)
      Me.menuFixedAspect.Checked = aspChecked
   End Sub 'LoadChartInfo
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ClientSize = New Size(600, 400)
      c1Chart1.Location = New Point(0)
      c1Chart1.BackColor = Color.White
      c1Chart3D1.Location = New Point(0)
      c1Chart3D1.BackColor = Color.White
      
      chart = New ChartHandler(c1Chart1, c1Chart3D1)
      AddHandler chart.ChartTypeChanged, AddressOf SetChartSelect
      
      chart.Size = Me.ClientSize
      
      Dim commandArgs As String() = System.Environment.GetCommandLineArgs()
      If commandArgs.Length > 1 Then
         Me.LoadChartInfo(commandArgs(1), False)
         If commandArgs.Length > 2 Then
            ' spin off each extra argument as a separate process.
            Dim ia As Integer
            For ia = 2 To commandArgs.Length - 1
               System.Diagnostics.Process.Start(commandArgs(0), commandArgs(ia))
            Next ia
         End If
      End If
      Form1_Resize(sender, e)
   End Sub 'Form1_Load
   
   
   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      If chart Is Nothing Then
         Return
      End If
      Dim minbounds As Integer = 10
      
      Dim cw As Integer = chart.Width
      Dim ch As Integer = chart.Height
      Dim aspect As Double = CDbl(ch) / CDbl(cw)
      
      If menuFixedAspect.Checked Then
         
         Dim fw As Integer = Me.ClientSize.Width
         Dim fh As Integer = Me.ClientSize.Height
         
         ch = CInt(fw * aspect)
         cw = CInt(fh / aspect)
         
         If ch > fh Then
            ch = fh
         Else
            cw = fw
         End If
      Else
         cw = Me.ClientSize.Width
         ch = Me.ClientSize.Height
      End If
      
      If cw < minbounds Then
         cw = minbounds
      End If 
      If ch < minbounds Then
         ch = minbounds
      End If 
      aspect = CDbl(ch) / CDbl(cw)
      Me.menuPixelData.Text = "     Aspect=" + aspect.ToString() + "   " + cw.ToString() + " x " + ch.ToString()
      
      chart.Size = New Size(cw, ch)
   End Sub 'Form1_Resize
   
   
   Private Function getVersionString() As String
      Return chart.AssemblyFileVersionString
   End Function 'getVersionString
   
   
   Private Sub menuFixedAspect_Click(sender As Object, e As System.EventArgs) Handles menuFixedAspect.Click
      menuFixedAspect.Checked = Not menuFixedAspect.Checked
      If Not menuFixedAspect.Checked Then
         Me.Form1_Resize(Nothing, Nothing)
      End If
   End Sub 'menuFixedAspect_Click
    
   Private Sub menuHeaderVersion_Click(sender As Object, e As System.EventArgs) Handles menuHeaderVersion.Click
      menuHeaderVersion.Checked = Not menuHeaderVersion.Checked
      If menuHeaderVersion.Checked Then
         chart.HeaderText = getVersionString()
      Else
         chart.HeaderText = Nothing
      End If
   End Sub 'menuHeaderVersion_Click
    
   Private Sub menuFooterVersion_Click(sender As Object, e As System.EventArgs) Handles menuFooterVersion.Click
      menuFooterVersion.Checked = Not menuFooterVersion.Checked
      If menuFooterVersion.Checked Then
         chart.FooterText = getVersionString()
      Else
         chart.FooterText = Nothing
      End If
   End Sub 'menuFooterVersion_Click
    
   Private Sub menuExit_Click(sender As Object, e As System.EventArgs) Handles menuExit.Click
      Application.Exit()
   End Sub 'menuExit_Click
   
   
   Private Sub LoadChartWithVersion(versionCheck As Boolean)
      Dim ofd As OpenFileDialog = openFileDialog1
      ofd.DefaultExt = chart.defExtension
      If chart.use2d Then
         ofd.FilterIndex = 1
      Else
         ofd.FilterIndex = 2
      End If
      ofd.Filter = "Chart2DXml files (*.chart2dxml)|*.chart2dxml" + "|Chart3DXml files (*.chart3dxml)|*.chart3dxml" + "|All files (*.*)|*.*"
      
      Dim dr As DialogResult = ofd.ShowDialog(Me)
      If dr = DialogResult.OK Then
         Me.LoadChartInfo(ofd.FileName, versionCheck)
         Me.Text = chart.LastLoadedFile
      End If
   End Sub 'LoadChartWithVersion
   
   
   Private Sub menuLoad_Click(sender As Object, e As System.EventArgs) Handles menuLoad.Click
      LoadChartWithVersion(False)
   End Sub 'menuLoad_Click
   
   
   
   Private Sub menuLoadVer_Click(sender As Object, e As System.EventArgs) Handles menuLoadVer.Click
      LoadChartWithVersion(True)
   End Sub 'menuLoadVer_Click
   
   
   
   Private Sub menuSave_Click(sender As Object, e As System.EventArgs) Handles menuSave.Click
      chart.SaveChartToFile(chart.LastLoadedFile)
   End Sub 'menuSave_Click
   
   
   Private Sub menuSaveAs_Click(sender As Object, e As System.EventArgs) Handles menuSaveAs.Click
      Dim sfd As SaveFileDialog = saveFileDialog1
      sfd.DefaultExt = chart.defExtension
      sfd.Filter = chart.FilterString + "|JPEG File Interchange Format (*.jpg)|*.jpg" + "|Portable Network Graphics (*.png)|*.png" + "|Graphics Interchange Format (*.gif)|*.gif" + "|Bitmap Image (*.bmp)|*.bmp" + "|Enhanced MetaFile (*.emf)|*.emf" + "|Windows MetaFile (*.wmf)|*.wmf"
      
      Dim defExtension As String = "." + chart.defExtension
      Dim fstr As String = chart.LastLoadedFile
      If fstr.EndsWith(defExtension) Then
         fstr = fstr.Substring(0, fstr.Length - defExtension.Length)
      End If
      sfd.FileName = fstr
      
      Dim dr As DialogResult = sfd.ShowDialog(Me)
      If dr = DialogResult.OK Then
         Dim newfile As String = sfd.FileName
         Dim extension As String = newfile.Substring(newfile.LastIndexOf("."c))
         Dim imgfmt As ImageFormat = ImageFormat.Icon
         
         Select Case extension.ToLower()
            Case ".bmp"
               imgfmt = ImageFormat.Bmp
            
            Case ".jpeg", ".jpg"
               imgfmt = ImageFormat.Jpeg
            
            Case ".gif"
               imgfmt = ImageFormat.Gif
            
            Case ".png"
               imgfmt = ImageFormat.Png
            
            Case ".emf", ".wmf"
               imgfmt = ImageFormat.Emf
            
            Case ".chart2dxml", ".chart3dxml"
               chart.SaveChartToFile(sfd.FileName)
               Me.Text = chart.LastLoadedFile
         End Select
         
         If Not imgfmt.Equals(ImageFormat.Icon) Then
            chart.SaveImage(sfd.FileName, imgfmt)
         End If
      End If
   End Sub 'menuSaveAs_Click
   
   
   Private Sub menuPrintToFit_Click(sender As Object, e As System.EventArgs) Handles menuPrintToFit.Click
      chart.PrintChart()
   End Sub 'menuPrintToFit_Click
   
   
   Private Sub menuPropGrid_Click(sender As Object, e As System.EventArgs) Handles menuPropGrid.Click
      Dim fpg As New frmPropGrid()
      If chart.use2d Then
         fpg.ChartObject = c1Chart1
      Else
         fpg.ChartObject = c1Chart3D1
      End If
      fpg.Show()
   End Sub 'menuPropGrid_Click
   
   
   Private Sub menuResetChart_Click(sender As Object, e As System.EventArgs) Handles menuResetChart.Click
      Dim dr As DialogResult = MessageBox.Show("The Chart is about to be Reset.  All data " + ControlChars.Lf + "and settings will be lost.   Continue?", "Reset Chart...", MessageBoxButtons.YesNo)
      If dr = DialogResult.Yes Then
         chart.ResetChart()
      End If
   End Sub 'menuResetChart_Click
    
   Private Sub menuChartSelect_Click(sender As Object, e As System.EventArgs) Handles menuChartSelect.Click
      chart.use2d = Not chart.use2d
   End Sub 'menuChartSelect_Click
   
   
   Private Sub menuClientSize_Click(sender As Object, e As System.EventArgs) Handles menuClientSize.Click
      Dim frm As New frmClientSize()
      frm.SetClientForm(Me)
      frm.Show()
   End Sub 'menuClientSize_Click
   
   Private urlForLoad As String = "http://"
   
   
   Private Sub LoadChartUrlVersion(versionCheck As Boolean)
      Dim frm As New frmLoadURL()
      
      frm.URL = urlForLoad
      Dim dr As DialogResult = frm.ShowDialog()
      urlForLoad = frm.URL
      
      If dr = DialogResult.OK Then
         Dim invalid As Boolean = False
         If Not (urlForLoad Is Nothing) AndAlso urlForLoad <> "" Then
            invalid = chart.LoadChartFromUrl(urlForLoad, versionCheck)
         End If 
         If urlForLoad Is Nothing OrElse urlForLoad = "" Then
            MessageBox.Show("URL is invalid")
         End If
      End If
   End Sub 'LoadChartUrlVersion
    
   Private Sub menuLoadFromUrl_Click(sender As Object, e As System.EventArgs) Handles menuLoadFromUrl.Click
      LoadChartUrlVersion(False)
   End Sub 'menuLoadFromUrl_Click
   
   
   Private Sub menuLoadFromUrlVersion_Click(sender As Object, e As System.EventArgs) Handles menuLoadFromUrlVersion.Click
      LoadChartUrlVersion(True)
   End Sub 'menuLoadFromUrlVersion_Click
   
   
   Private Sub menuNewWindow_Click(sender As Object, e As System.EventArgs) Handles menuNewWindow.Click
      System.Diagnostics.Process.Start(("""" + System.Environment.GetCommandLineArgs()(0) + """"))
   End Sub 'menuNewWindow_Click
   
   
   Private Sub menuLoadFromClipboard_Click(sender As Object, e As System.EventArgs) Handles menuLoadFromClipboard.Click
      chart.LoadChartFromClipboard(False)
   End Sub 'menuLoadFromClipboard_Click
   
   
   Private Sub menuLoadFromClipboardVersion_Click(sender As Object, e As System.EventArgs) Handles menuLoadFromClipboardVersion.Click
      chart.LoadChartFromClipboard(True)
   End Sub 'menuLoadFromClipboardVersion_Click
   
   
   Private Sub menuSaveToClipboard_Click(sender As Object, e As System.EventArgs) Handles menuSaveToClipboard.Click
      chart.SaveChartToClipboard()
   End Sub 'menuSaveToClipboard_Click
   
   
   Private Sub menuChartPropsLatest_Click(sender As Object, e As System.EventArgs) Handles menuChartPropsLatest.Click
      chart.ShowProperties()
   End Sub 'menuChartPropsLatest_Click
   
   
   Private Sub menuChartPropsPrevious_Click(sender As Object, e As System.EventArgs) Handles menuChartPropsPrevious.Click
      chart.ShowPropertiesPrevious()
   End Sub 'menuChartPropsPrevious_Click
   
   
   Private Sub menuChartWizardLatest_Click(sender As Object, e As System.EventArgs) Handles menuChartWizardLatest.Click
      chart.ShowWizard()
   End Sub 'menuChartWizardLatest_Click
   
   
   Private Sub menuChartWizardPrevious_Click(sender As Object, e As System.EventArgs) Handles menuChartWizardPrevious.Click
      chart.ShowWizardPrevious()
   End Sub 'menuChartWizardPrevious_Click
End Class 'Form1


'/ <summary>
'/   ChartHandler manages the 2D or 3D chart from a single object
'/   based on the last loaded type of chart xml.
'/ </summary>
Public Class ChartHandler
   Private chart2d As C1.Win.C1Chart.C1Chart = Nothing
   Private chart3d As C1.Win.C1Chart3D.C1Chart3D = Nothing
   Private Chart2dDefault As String = Nothing
   Private Chart3dDefault As String = Nothing
   
   Private lastLoaded2dFile As String = "chart2d.chart2dxml"
   Private lastLoaded3dFile As String = "chart3d.chart3dxml"
   
   Private use2DChart As Boolean = True
   
   
   Public Sub New(c2d As C1Chart, c3d As C1Chart3D)
      chart2d = c2d
      Chart2dDefault = c2d.SaveChartToString()
      
      chart3d = c3d
      Chart3dDefault = c3d.SaveChartToString()
   End Sub 'New
   
   Public Event ChartTypeChanged As EventHandler
   
   Public Sub OnChartTypeChanged(sender As Object, e As EventArgs)
      '			if(ChartTypeChanged != null)	//!!VBComment   
      RaiseEvent ChartTypeChanged(sender, e)
   End Sub 'OnChartTypeChanged
   
   
   Public Property use2d() As Boolean
      Get
         Return use2DChart
      End Get
      Set
         If use2DChart = value Then
            Return
         End If 
         use2DChart = value
         
         If use2DChart Then
            chart2d.Size = chart3d.Size
            chart2d.Visible = True
            chart3d.Visible = False
         Else
            chart3d.Size = chart2d.Size
            chart3d.Visible = True
            chart2d.Visible = False
         End If
         
         OnChartTypeChanged(Me, New EventArgs())
      End Set
   End Property
   
   
   Public Property BackColor() As Color
      Get
         If use2d Then
            Return chart2d.BackColor
         Else
            Return chart3d.BackColor
         End If
      End Get
      Set
         If use2d Then
            chart2d.BackColor = value
         Else
            chart3d.BackColor = value
         End If
      End Set
   End Property 
   
   Public Property Location() As Point
      Get
         If use2d Then
            Return chart2d.Location
         Else
            Return chart3d.Location
         End If
      End Get
      Set
         If use2d Then
            chart2d.Location = value
         Else
            chart3d.Location = value
         End If
      End Set
   End Property 
   
   Public Property Size() As Size
      Get
         If use2d Then
            
            Return chart2d.Size
         Else
            Return chart3d.Size
         End If
      End Get
      Set
         If use2d Then
            chart2d.Size = value
         Else
            chart3d.Size = value
         End If
      End Set
   End Property 
   
   Public ReadOnly Property Width() As Integer
      Get
         If use2d Then
            Return chart2d.Width
         Else
            Return chart3d.Width
         End If
      End Get
   End Property 
   
   Public ReadOnly Property Height() As Integer
      Get
         If use2d Then
            Return chart2d.Height
         Else
            Return chart3d.Height
         End If
      End Get
   End Property 
   
   Public Property HeaderText() As String
      Get
         If use2d Then
            Return chart2d.Header.Text
         Else
            Return chart3d.Header.Text
         End If
      End Get
      Set
         If use2d Then
            chart2d.Header.Text = value
            chart2d.Header.Visible = True
         Else
            chart3d.Header.Text = value
            chart3d.Header.Visible = True
         End If
      End Set
   End Property
   
   
   Public Property FooterText() As String
      Get
         If use2d Then
            Return chart2d.Footer.Text
         Else
            Return chart3d.Footer.Text
         End If
      End Get
      Set
         If use2d Then
            chart2d.Footer.Text = value
         Else
            chart3d.Footer.Text = value
         End If
      End Set
   End Property 
   
   Public ReadOnly Property AssemblyFileVersionString() As String
      Get
         If use2d Then
            Return chart2d.AssemblyFileVersionString
         Else
            Return chart3d.AssemblyFileVersionString
         End If
      End Get
   End Property 
   
   Public ReadOnly Property defExtension() As String
      Get
         If use2d Then
            Return "chart2dxml"
         Else
            Return "chart3dxml"
         End If
      End Get
   End Property 
   
   Public ReadOnly Property LastLoadedFile() As String
      Get
         If use2d Then
            Return lastLoaded2dFile
         Else
            Return lastLoaded3dFile
         End If
      End Get
   End Property 
   
   Public ReadOnly Property FilterString() As String
      Get
         If use2d Then
            Return "Chart2DXml files (*.chart2dxml)|*.chart2dxml"
         Else
            Return "Chart3DXml files (*.chart3dxml)|*.chart3dxml"
         End If
      End Get
   End Property
    
   Private Function checkVersion(bagstr As String, contents As String, versionCheck As Boolean) As Boolean
      Dim rc As Boolean = True
      If versionCheck Then
         Dim verIndex As Integer = contents.IndexOf(bagstr) + bagstr.Length + 1
         Dim verstr As String = contents.Substring(verIndex, contents.IndexOf(ControlChars.Quote, verIndex) - verIndex)
         Dim dr As DialogResult = MessageBox.Show("Chart version in XML file is: " + verstr + ".   Do you wish to continue loading?", "", MessageBoxButtons.YesNo)
         rc = dr = DialogResult.Yes
      End If
      Return rc
   End Function 'checkVersion
   
   
   Private Function LoadChartFromStringContents(contents As String, versionCheck As Boolean) As Boolean
      Dim bag2d As String = "Chart2DPropBag Version="
      Dim bag3d As String = "Chart3DPropBag Version="
      If contents.IndexOf(bag2d) >= 0 Then
         use2d = True
         If Not checkVersion(bag2d, contents, versionCheck) Then
            Return False
         End If
      ElseIf contents.IndexOf(bag3d) >= 0 Then
         use2d = False
         If Not checkVersion(bag3d, contents, versionCheck) Then
            Return False
         End If
      Else
         MessageBox.Show("File must be a C1Chart XML or C1Chart3D XML file.")
         Return False
      End If
      
      If use2d Then
         chart2d.LoadChartFromString(contents)
      Else
         chart3d.LoadChartFromString(contents)
      End If 
      Return True
   End Function 'LoadChartFromStringContents
   
   
   Public Function LoadChartFromClipboard(versionCheck As Boolean) As Boolean
      Dim contents As String = ""
      Dim ido As IDataObject = Clipboard.GetDataObject()
      If ido.GetDataPresent(GetType(String)) Then
         contents = CStr(ido.GetData(GetType(String)))
      End If
      Return LoadChartFromStringContents(contents, versionCheck)
   End Function 'LoadChartFromClipboard
   
   
   Public Function LoadChartFromUrl(url As String, versionCheck As Boolean) As Boolean
      Dim wc As New WebClient()
      Dim byteData As Byte() = Nothing
      Dim success As Boolean = True
      Try
         byteData = wc.DownloadData(url)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
         success = False
      End Try
      wc.Dispose()
      
      If success Then
         Dim contents As String = Encoding.ASCII.GetString(byteData)
         success = LoadChartFromStringContents(contents, versionCheck)
      End If
      
      Return success
   End Function 'LoadChartFromUrl
   
   
   Public Sub LoadChartFromFile(fname As String, versionCheck As Boolean)
      Dim sr As StreamReader = Nothing
      Dim contents As String = Nothing
      
      Try
         sr = File.OpenText(fname)
      Catch
         Return
      End Try
      
      Try
         contents = sr.ReadToEnd()
      Catch
         sr.Close()
         Return
      End Try
      
      sr.Close()
      
      If LoadChartFromStringContents(contents, versionCheck) Then
         If use2d Then
            Me.lastLoaded2dFile = fname
         Else
            Me.lastLoaded3dFile = fname
         End If
      End If
   End Sub 'LoadChartFromFile
    
   Public Sub SaveChartToFile(fname As String)
      If use2d Then
         chart2d.SaveChartToFile(fname)
         Me.lastLoaded2dFile = fname
      Else
         chart3d.SaveChartToFile(fname)
         Me.lastLoaded3dFile = fname
      End If
   End Sub 'SaveChartToFile
   
   
   Public Sub SaveChartToClipboard()
      Dim chstr As String = Nothing
      If use2d Then
         chstr = chart2d.SaveChartToString()
      Else
         chstr = chart3d.SaveChartToString()
      End If
      Clipboard.SetDataObject(chstr, True)
   End Sub 'SaveChartToClipboard
   
   
   Public Sub SaveImage(fname As String, imgfmt As ImageFormat)
      If use2d Then
         chart2d.SaveImage(fname, imgfmt)
      Else
         chart3d.SaveImage(fname, imgfmt)
      End If
   End Sub 'SaveImage
    
   Public Sub PrintChart()
      If use2d Then
         chart2d.PrintChart()
      Else
         chart3d.PrintChart()
      End If
   End Sub 'PrintChart
    
   Public Sub ResetChart()
      If use2d Then
         chart2d.LoadChartFromString(Me.Chart2dDefault)
      Else
         chart3d.LoadChartFromString(Me.Chart3dDefault)
      End If
   End Sub 'ResetChart
    
   Public Sub ShowProperties()
      If use2d Then
         chart2d.ShowProperties()
      Else
         chart3d.ShowProperties()
      End If
   End Sub 'ShowProperties
    
   Public Sub ShowWizard()
      If use2d Then
         chart2d.ShowWizard()
      Else
         chart3d.ShowWizard()
      End If
   End Sub 'ShowWizard
    
   Public Sub ShowPropertiesPrevious()
      If use2d Then
         chart2d.ShowProperties(DesignerDialogEnum.V1)
      Else
         chart3d.ShowProperties()
      End If
   End Sub 'ShowPropertiesPrevious
    
   Public Sub ShowWizardPrevious()
      If use2d Then
         chart2d.ShowWizard(DesignerDialogEnum.V2)
      Else
         chart3d.ShowWizard()
      End If
   End Sub 'ShowWizardPrevious
End Class 'ChartHandler
