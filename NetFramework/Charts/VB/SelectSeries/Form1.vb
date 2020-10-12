
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
   Private panel2 As System.Windows.Forms.Panel
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
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
      Me.label2 = New System.Windows.Forms.Label()
      Me.label1 = New System.Windows.Forms.Label()
      Me.panel2 = New System.Windows.Forms.Panel()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.panel1.SuspendLayout()
      Me.panel2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' panel1
      ' 
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.label2, Me.label1})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(160, 453)
      Me.panel1.TabIndex = 0
      ' 
      ' label2
      ' 
      Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label2.Location = New System.Drawing.Point(8, 56)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(144, 32)
      Me.label2.TabIndex = 2
      Me.label2.Text = "Use mouse to select series"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' label1
      ' 
      Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(144, 32)
      Me.label1.TabIndex = 1
      Me.label1.Text = "Selection: none"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' panel2
      ' 
      Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1})
      Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.panel2.Location = New System.Drawing.Point(160, 0)
      Me.panel2.Name = "panel2"
      Me.panel2.Size = New System.Drawing.Size(472, 453)
      Me.panel2.TabIndex = 1
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=Solid,ControlText,1;BackColor=Wh" + "iteSmoke;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.default"" StyleData=""Bo" + "rder=Solid,Black,1;AlignHorz=Center;BackColor=WhiteSmoke;AlignVert=Top;Rounding=" + "10 0 10 0;"" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData=""Border=N" + "one,Black,1;"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle " + "Name=""Control"" ParentName=""Control.default"" /><NamedStyle Name=""AxisX"" ParentNam" + "e=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;"" /><Name" + "dStyle Name=""AxisY"" ParentName=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Ne" + "ar;AlignVert=Center;"" /><NamedStyle Name=""LabelStyleDefault"" ParentName=""LabelSt" + "yleDefault.default"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" Sty" + "leData=""Border=None,Black,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""Label" + "StyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Black,1;BackCo" + "lor=Transparent;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleData=""Bo" + "rder=None,Black,1;"" /><NamedStyle Name=""Control.default"" ParentName="""" StyleData" + "=""ForeColor=ControlText;Border=None,Black,1;BackColor=Control;"" /><NamedStyle Na" + "me=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;AlignVe" + "rt=Center;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" StyleData=""Bo" + "rder=None,Black,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsCollection><Ch" + "artGroup Name=""Group1""><DataSerializer DefaultSet=""True""><DataSeriesCollection><" + "DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Cora" + "l"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;" + "24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" + ";;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineSt" + "yle Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><Series" + "Label>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Singl" + "e;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle" + " /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" /><" + "SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X" + ">1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Double" + "</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><Da" + "taSeriesSerializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" S" + "hape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;" + "22;18</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" + ";;</DataFields><FillStyle /></DataSeriesSerializer></DataSeriesCollection></Data" + "Serializer></ChartGroup><ChartGroup Name=""Group2""><DataSerializer /></ChartGroup" + "></ChartGroupsCollection><Header Compass=""North"" Visible=""False"" /><Footer Compa" + "ss=""South"" Visible=""False"" /><Legend Compass=""East"" Visible=""True"" /><ChartArea " + "/><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" Aut" + "oMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""South""><GridMajor /><GridMi" + "nor /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""Tru" + "e"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West""><GridMajor Visi" + "ble=""True"" Spacing=""1"" /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0""" + " UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" C" + "ompass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(470, 451)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' Form1
      ' 
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.panel2, Me.panel1})
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Select Series Demo"
      Me.panel1.ResumeLayout(False)
      Me.panel2.ResumeLayout(False)
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
   
   Private selectionColor As Color = Color.Red
   
   ' Series colors
   Private clrs As Color() =  {Color.Blue, Color.DarkGreen, Color.Brown, Color.BlueViolet}
   Private rnd As New Random()
   Private selectedIndex As Integer = - 1
   
   
   Private Function CreateSeries(cd As ChartData, scale As Double, clr As Color) As ChartDataSeries
      Dim np As Integer = 150
      Dim x(np-1) As Double
      Dim y(np-1) As Double
      
      Dim ds As ChartDataSeries = cd.SeriesList.AddNewSeries()
      
      ' Create some data
      Dim i As Integer
      For i = 0 To np - 1
         Dim r As Double = rnd.NextDouble()
         x(i) = scale *(1 + r * Math.Sin((0.1 * i)) * Math.Sin((0.6 * rnd.NextDouble() * i)))
         y(i) = i
      Next i
      
      ' Copy data values
      ds.X.CopyDataIn(x)
      ds.Y.CopyDataIn(y)
      
      ' No symbols
      ds.SymbolStyle.Shape = SymbolShapeEnum.None
      ds.LineStyle.Color = clr
      
      Return ds
   End Function 'CreateSeries
   
   
   Private Sub c1Chart1_Load(sender As Object, e As System.EventArgs) Handles c1Chart1.Load
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      cd.SeriesList.Clear()
      
      ' Create sample data
      CreateSeries(cd, 5, clrs(0))
      CreateSeries(cd, 10, clrs(1))
      CreateSeries(cd, 15, clrs(2))
      CreateSeries(cd, 20, clrs(3))
      
      ' Setup scroll bar
      c1Chart1.ChartArea.AxisY.ScrollBar.Min = cd.MinY
      c1Chart1.ChartArea.AxisY.ScrollBar.Max = cd.MaxY
      c1Chart1.ChartArea.AxisY.ScrollBar.Appearance = ScrollBarAppearanceEnum.Flat
      c1Chart1.ChartArea.AxisY.ScrollBar.Visible = True
      c1Chart1.ChartArea.AxisY.ScrollBar.Scale = 0.5
   End Sub 'c1Chart1_Load
   
   
   Private Sub c1Chart1_Click(sender As Object, e As System.EventArgs) Handles c1Chart1.Click
      Dim p As Point = Control.MousePosition
      
      ' Convert to client coordinates
      p = c1Chart1.PointToClient(p)
      
      Dim si As Integer = - 1
      Dim d As Integer = - 1
      
      ' Find the distance
      If c1Chart1.ChartGroups(0).CoordToSeriesIndex(p.X, p.Y, PlotElementEnum.Series, si, d) Then
         If d <= 3 Then ' if close enough
            If si <> selectedIndex Then ' Another index
               If selectedIndex <> - 1 Then
                  ' Change series color and width to the default
                  Dim ds As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(selectedIndex)
                  ds.LineStyle.Color = clrs(selectedIndex)
                  ds.LineStyle.Thickness = 1
               End If
               
               selectedIndex = si
               If selectedIndex <> - 1 Then
                  ' Change series color and width to indicate selection
                  Dim ds As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(selectedIndex)
                  ds.LineStyle.Color = selectionColor
                  ds.LineStyle.Thickness = 2
               End If
               
               ' Show status label
               If selectedIndex < 0 Then
                  label1.Text = "Selection: none"
               Else
                  label1.Text = "Selection: " + c1Chart1.ChartGroups(0).ChartData(selectedIndex).Label
               End If
            End If
         End If
      End If
   End Sub 'c1Chart1_Click
    
   Private Sub c1Chart1_DrawLegendEntry(sender As Object, e As C1.Win.C1Chart.DrawLegendEntryEventArgs) Handles c1Chart1.DrawLegendEntry
      Dim ds As ChartDataSeries = CType(e.Entry, ChartDataSeries)
      
      ' Draw legend text using selection color
      If Not (ds Is Nothing) AndAlso ds.Group.ChartData.SeriesList.IndexOf(ds) = selectedIndex Then
         e.TextColor = selectionColor
      End If
   End Sub 'c1Chart1_DrawLegendEntry
End Class 'Form1
