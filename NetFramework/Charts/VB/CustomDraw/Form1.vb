
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
   WithEvents trackBar1 As System.Windows.Forms.TrackBar
   Private label1 As System.Windows.Forms.Label
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
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.trackBar1 = New System.Windows.Forms.TrackBar()
      Me.label1 = New System.Windows.Forms.Label()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Interaction.Enabled = True
      Me.c1Chart1.Location = New System.Drawing.Point(150, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""GradientStyle=None;Border=Solid,Control" + "Text,1;BackColor2=;BackColor=DarkGray;Opaque=True;HatchStyle=None;"" /><NamedStyl" + "e Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Footer"" ParentNa" + "me=""Control"" StyleData=""Border=None,Black,1;"" /><NamedStyle Name=""Area"" ParentNa" + "me=""Area.default"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" Styl" + "eData=""Border=Solid,Transparent,1;"" /><NamedStyle Name=""AxisX"" ParentName=""Area""" + " StyleData=""Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;"" /><NamedStyle N" + "ame=""AxisY"" ParentName=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;Align" + "Vert=Center;"" /><NamedStyle Name=""LabelStyleDefault"" ParentName=""LabelStyleDefau" + "lt.default"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""" + "Border=None,Black,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""LabelStyleDef" + "ault.default"" ParentName=""Control"" StyleData=""Border=None,Black,1;BackColor=Tran" + "sparent;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleData=""Border=Non" + "e,Black,1;"" /><NamedStyle Name=""Control.default"" ParentName="""" StyleData=""ForeCo" + "lor=ControlText;Border=None,Black,1;BackColor=Control;"" /><NamedStyle Name=""Axis" + "Y2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;AlignVert=Cente" + "r;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" StyleData=""Border=Non" + "e,Black,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsCollection><ChartGroup" + " Name=""Group1"" Use3D=""False""><DataSerializer DefaultSet=""True""><DataSeriesCollec" + "tion><DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color" + "=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;" + "22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" + "lds>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><" + "LineStyle Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><" + "SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes" + ">Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Fil" + "lStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGree" + "n"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLa" + "bel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;" + "Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializ" + "er><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crim" + "son"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;" + "19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFie" + "lds>;;;;</DataFields><FillStyle /></DataSeriesSerializer></DataSeriesCollection>" + "</DataSerializer></ChartGroup><ChartGroup Name=""Group2""><DataSerializer /></Char" + "tGroup></ChartGroupsCollection><Header Compass=""North"" Visible=""False"" /><Footer" + " Compass=""South"" Visible=""False"" /><Legend Compass=""East"" Visible=""False"" /><Cha" + "rtArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""Tr" + "ue"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""South""><GridMajor />" + "<GridMinor /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMaj" + "or=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West""><GridMaj" + "or /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoM" + "ajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""East""><GridM" + "ajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(482, 453)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' trackBar1
      ' 
      Me.trackBar1.Location = New System.Drawing.Point(8, 40)
      Me.trackBar1.Name = "trackBar1"
      Me.trackBar1.Size = New System.Drawing.Size(128, 42)
      Me.trackBar1.TabIndex = 1
      ' 
      ' label1
      ' 
      Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(128, 23)
      Me.label1.TabIndex = 2
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' Form1
      ' 
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label1, Me.trackBar1, Me.c1Chart1})
      Me.DockPadding.Left = 150
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Custom Draw Demo"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
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
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      cd.SeriesList.Clear()
      
      ' Create first data series
      Dim ds1 As ChartDataSeries = cd.SeriesList.AddNewSeries()
      
      Dim np As Integer = 200
      Dim pa(np-1) As PointF
      Dim i As Integer = 0
      
      ' Generate data values
      For i = 0 To np - 1
         pa(i).X = CSng(i * Math.Cos((0.1 * i)))
         pa(i).Y = CSng(i * Math.Sin((0.1 * i)))
      Next i
      ds1.PointData.CopyDataIn(pa)
      
      ' Save points array
      ds1.Tag = pa
      ' Attach handler
      AddHandler ds1.Draw, AddressOf DataSeries_Draw
      
      ' Create second data series
      Dim ds2 As ChartDataSeries = cd.SeriesList.AddNewSeries()
      Dim pa2(np-1) As PointF
      
      ' Generate data values
      For i = np - 1 To 0 Step -1
         pa2(i).X = - CSng(i * Math.Cos((0.1 * i)))
         pa2(i).Y = - CSng(i * Math.Sin((0.1 * i)))
      Next i
      ds2.PointData.CopyDataIn(pa2)
      
      ' Save points array
      ds2.Tag = pa2
      ' Attach handler
      AddHandler ds2.Draw, AddressOf DataSeries_Draw
      
      ' Setup track bar properties
      trackBar1.Minimum = 0
      trackBar1.Maximum = 100
      trackBar1.TickFrequency = 5
      trackBar1.Value = 50
   End Sub 'Form1_Load
   
   
   Private Sub DataSeries_Draw(sender As Object, e As DrawSeriesEventArgs)
      Dim ds As ChartDataSeries = e.Series
      Dim g As Graphics = e.Graphics
      Dim cg As ChartGroup = ds.Group
      
      ' Get the point array
      Dim pa As PointF() = CType(ds.Tag, PointF())
      Dim np As Integer = pa.Length
      
      Dim pen As New Pen(Color.Black, 3)
      
      Dim x1 As Single = 0
      Dim y1 As Single = 0
      Dim x2 As Single = 0
      Dim y2 As Single = 0
      
      ' Index at which the color is changed
      Dim ichange As Integer = CInt(Math.Round((np * trackBar1.Value * 0.01)))
      
      ds.Group.DataCoordToCoord(pa(0).X, pa(0).Y, x1, y1)
      
      Dim i As Integer
      For i = 0 To (np - 1) - 1
         ' Change the color
         If i >= ichange Then
            pen.Color = Color.White
         End If 
         ' Calculate cooredinates
         cg.DataCoordToCoord(pa((i + 1)).X, pa((i + 1)).Y, x2, y2)
         
         ' Draw line
         g.DrawLine(pen, x1, y1, x2, y2)
         x1 = x2
         y1 = y2
      Next i
      
      pen.Dispose()
      
      ' Cancel rendering, it's already done
      e.Cancel = True
   End Sub 'DataSeries_Draw
   
   
   Private Sub trackBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles trackBar1.ValueChanged, trackBar1.Scroll
      ' Redraw chart and label
      c1Chart1.Invalidate()
      label1.Text = String.Format("{0} %", trackBar1.Value)
   End Sub 'trackBar1_ValueChanged
End Class 'Form1
