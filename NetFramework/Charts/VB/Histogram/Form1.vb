
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports C1.Win.C1Chart
Imports System.Diagnostics



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Private groupBox1 As System.Windows.Forms.GroupBox
   WithEvents radHistogram As System.Windows.Forms.RadioButton
   WithEvents radFreq As System.Windows.Forms.RadioButton
   WithEvents radStepFreq As System.Windows.Forms.RadioButton
   WithEvents txtDescription As System.Windows.Forms.TextBox
   WithEvents chkShowNormal As System.Windows.Forms.CheckBox
   WithEvents txtDistanceStats As System.Windows.Forms.TextBox
   WithEvents chkHideData As System.Windows.Forms.CheckBox
   WithEvents chkHideLabels As System.Windows.Forms.CheckBox
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
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.groupBox1 = New System.Windows.Forms.GroupBox()
      Me.radStepFreq = New System.Windows.Forms.RadioButton()
      Me.radFreq = New System.Windows.Forms.RadioButton()
      Me.radHistogram = New System.Windows.Forms.RadioButton()
      Me.txtDescription = New System.Windows.Forms.TextBox()
      Me.chkShowNormal = New System.Windows.Forms.CheckBox()
      Me.txtDistanceStats = New System.Windows.Forms.TextBox()
      Me.chkHideData = New System.Windows.Forms.CheckBox()
      Me.chkHideLabels = New System.Windows.Forms.CheckBox()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.groupBox1.SuspendLayout()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Location = New System.Drawing.Point(176, 5)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""Area.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;AlignV" + "ert=Top;"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" /><NamedStyl" + "e Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;Ali" + "gnVert=Center;"" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData=""Bord" + "er=None,Transparent,1;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleDa" + "ta=""Border=None,Transparent,1;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.d" + "efault"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle Name=""" + "LabelStyleDefault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""La" + "belStyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Transparent" + ",1;BackColor=Transparent;"" /><NamedStyle Name=""PlotArea"" ParentName=""Area"" Style" + "Data=""Border=None,Transparent,1;"" /><NamedStyle Name=""Control.default"" ParentNam" + "e="""" StyleData=""ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" + "l;"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Border=N" + "one,Transparent,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""AxisY"" ParentNa" + "me=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><Nam" + "edStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Cen" + "ter;AlignVert=Bottom;"" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" + "me=""Group1""><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeriesS" + "erializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Coral"" Shape=""B" + "ox"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" + "Style Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><Seri" + "esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" + "gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" + "le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" + """DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2<" + "/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" + "e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " + "/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><S" + "ymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel>" + "<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" + "le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" + "sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" + "illStyle Color1=""Transparent"" /></NormalDisplay></Histogram></ChartGroup><ChartG" + "roup Name=""Group2""><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" + "=""Transparent"" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" + "n><Header Compass=""North"" /><Footer Compass=""South"" /><Legend Compass=""East"" Vis" + "ible=""False"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""S" + "outh""><GridMajor /><GridMinor /></Axis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" Unit" + "Minor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compas" + "s=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" Un" + "itMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Comp" + "ass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(448, 443)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' groupBox1
      ' 
      Me.groupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.radStepFreq, radFreq, radHistogram})
      Me.groupBox1.Location = New System.Drawing.Point(8, 0)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(144, 72)
      Me.groupBox1.TabIndex = 1
      Me.groupBox1.TabStop = False
      ' 
      ' radStepFreq
      ' 
      Me.radStepFreq.Location = New System.Drawing.Point(8, 48)
      Me.radStepFreq.Name = "radStepFreq"
      Me.radStepFreq.Size = New System.Drawing.Size(128, 16)
      Me.radStepFreq.TabIndex = 2
      Me.radStepFreq.Text = "Stepped Frequency"
      ' 
      ' radFreq
      ' 
      Me.radFreq.Location = New System.Drawing.Point(8, 32)
      Me.radFreq.Name = "radFreq"
      Me.radFreq.Size = New System.Drawing.Size(96, 16)
      Me.radFreq.TabIndex = 1
      Me.radFreq.Text = "Frequency"
      ' 
      ' radHistogram
      ' 
      Me.radHistogram.Checked = True
      Me.radHistogram.Location = New System.Drawing.Point(8, 16)
      Me.radHistogram.Name = "radHistogram"
      Me.radHistogram.Size = New System.Drawing.Size(96, 16)
      Me.radHistogram.TabIndex = 0
      Me.radHistogram.TabStop = True
      Me.radHistogram.Text = "Histogram"
      ' 
      ' txtDescription
      ' 
      Me.txtDescription.Location = New System.Drawing.Point(8, 232)
      Me.txtDescription.Multiline = True
      Me.txtDescription.Name = "txtDescription"
      Me.txtDescription.ReadOnly = True
      Me.txtDescription.Size = New System.Drawing.Size(160, 216)
      Me.txtDescription.TabIndex = 2
      Me.txtDescription.Text = ""
      ' 
      ' chkShowNormal
      ' 
      Me.chkShowNormal.Location = New System.Drawing.Point(16, 80)
      Me.chkShowNormal.Name = "chkShowNormal"
      Me.chkShowNormal.Size = New System.Drawing.Size(128, 16)
      Me.chkShowNormal.TabIndex = 3
      Me.chkShowNormal.Text = "Show Normal Curve"
      ' 
      ' txtDistanceStats
      ' 
      Me.txtDistanceStats.BorderStyle = System.Windows.Forms.BorderStyle.None
      Me.txtDistanceStats.Location = New System.Drawing.Point(8, 152)
      Me.txtDistanceStats.Multiline = True
      Me.txtDistanceStats.Name = "txtDistanceStats"
      Me.txtDistanceStats.ReadOnly = True
      Me.txtDistanceStats.Size = New System.Drawing.Size(160, 72)
      Me.txtDistanceStats.TabIndex = 4
      Me.txtDistanceStats.Text = "Distance Statistics"
      ' 
      ' chkHideData
      ' 
      Me.chkHideData.Location = New System.Drawing.Point(16, 104)
      Me.chkHideData.Name = "chkHideData"
      Me.chkHideData.Size = New System.Drawing.Size(128, 16)
      Me.chkHideData.TabIndex = 5
      Me.chkHideData.Text = "Hide Raw Data"
      ' 
      ' chkHideLabels
      ' 
      Me.chkHideLabels.Location = New System.Drawing.Point(16, 128)
      Me.chkHideLabels.Name = "chkHideLabels"
      Me.chkHideLabels.Size = New System.Drawing.Size(128, 16)
      Me.chkHideLabels.TabIndex = 6
      Me.chkHideLabels.Text = "Hide Data Labels"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkHideLabels, Me.chkHideData, Me.txtDistanceStats, Me.txtDescription, Me.groupBox1, Me.c1Chart1, Me.chkShowNormal})
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.groupBox1.ResumeLayout(False)
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent

#End Region
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()>
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


    Private Function GenerateScatterData(NumberOfPoints As Integer, xscale As Single, yscale As Single) As PointF()
      Dim rnd As New Random()
      Dim result As PointF() = CType(Array.CreateInstance(GetType(PointF), NumberOfPoints), PointF())
      Dim i As Integer
      For i = 0 To NumberOfPoints - 1
         Dim x As Single = CSng(xscale * rnd.NextDouble())
         Dim y As Single = CSng(yscale * rnd.NextDouble())
         result(i) = New PointF(x, y)
      Next i
      Return result
   End Function 'GenerateScatterData
   
   
   Private Function AddChartAxisMarker(ax As Axis) As Double
      ' Set the annotation method to Mixed so both automatic
      ' Values annotation AND ValueLabels can be used concurrently.
      ax.AnnoMethod = AnnotationMethodEnum.Mixed
      
      ' Set the GridMajor line pattern to solid.  This will be
      ' used for the ValueLabel Gridline draw.
      ax.GridMajor.Pattern = LinePatternEnum.Solid
      ax.OnTop = True
      
      ' A convenient value for the axes units.
      ax.UnitMajor = 10
      
      ' Create the ValueLabel.  Use an arrow, and make it big
      ' and red so it cannot be missed.
      Dim vl As ValueLabel = ax.ValueLabels.AddNewLabel()
      vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker
      vl.GridLine = True
      vl.Moveable = True
      vl.MarkerSize = 20
      vl.Color = Color.Red
      
      ' Put it in the middle of the axis.  For this to work
      ' the chart must have been drawn so the axis is properly
      ' scaled.  A prior GetImage() will do this.
      vl.NumericValue =(ax.Max - ax.Min) / 2
      
      ' Set the event so the data can be recalculated
      ' each time the marker is moved.
      AddHandler vl.ValueChanged, AddressOf MarkerMoved
      ' return the numeric location.
      Return vl.NumericValue
   End Function 'AddChartAxisMarker
   
   
   Private Sub MarkerMoved(sender As Object, e As EventArgs)
      SetHistogramData()
   End Sub 'MarkerMoved
   
   
   Private Sub ChartSetup()
      ' Reset the chart, position it, and appropriately anchor
      c1Chart1.Reset()
      c1Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right Or AnchorStyles.Left 
      ' Setup the Chart appearance
      Dim sty As Style = c1Chart1.Style
      sty.BackColor = Color.FromKnownColor(KnownColor.Window)
      
      ' The Chart border
      Dim b As Border = sty.Border
      b.BorderStyle = BorderStyleEnum.Solid
      b.Rounding.All = 10
      b.Thickness = 3
      b.Color = Color.Black
      
      ' Turn on tooltips
      c1Chart1.ToolTip.Enabled = True
      
      ' Generate scatter data and populate the chart.
      Dim scatter As PointF() = GenerateScatterData(100, 100F, 75F)
      
      ' Plot the data in the first ChartGroup.  For scatter data, turn off the lines.
      Dim cds As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData.SeriesList.AddNewSeries()
      cds.LineStyle.Pattern = LinePatternEnum.None
      cds.PointData.CopyDataIn(scatter)
      cds.TooltipText = "({#XVAL:0.00},{#YVAL:0.00})"
      
      ' Force the chart to scale the axes right now.
      c1Chart1.GetImage()
      
      ' Automatically label each of the points by its PointIndex.
      cds.DataLabel.Compass = LabelCompassEnum.Auto
      cds.DataLabel.Offset = 4
      cds.DataLabel.Connected = True
      cds.DataLabel.Text = "{#IPOINT}"
      cds.DataLabel.Visible = True
      
      ' Provide Header for description
      Dim t As Title = c1Chart1.Header
      t.Style.Font = New Font("Tahoma", 14)
      t.Text = "Histogram/Frequency Data Measuring Distance from Crosshairs to Scatter data."
      
      ' Provide Footer for instructions
      t = c1Chart1.Footer
      Dim f As New Font("Tahoma", 12)
      t.AppendRtfText("Drag the ", f)
      t.AppendRtfText("Red", Color.Red, f)
      t.AppendRtfText(" arrows to move the crosshairs", Color.Black, f, HorizontalAlignment.Center)
      
      ' Switch over the axes to mixed label mode and add some centered
      ' markers to form a target.
      Dim carea As Area = c1Chart1.ChartArea
      Dim xMarker As Double = AddChartAxisMarker(carea.AxisX)
      Dim yMarker As Double = AddChartAxisMarker(carea.AxisY)
      
      ' Set the Axis Titles.
      carea.AxisX.Text = "Scatter data X values / Distances from crosshair"
      carea.AxisY.Text = "Scatter data Y values"
      carea.AxisY2.Text = "Count of data at distance from crosshair"
   End Sub 'ChartSetup
    
   
   Private Sub SetupHistogram()
      ' Create a Histogram in the second chart group using the scatter data
      ' and the distance from the marker intersection as data for the histogram.
      Dim cg As ChartGroup = c1Chart1.ChartGroups(1)
      
      ' Start by adding a Normal (Gaussian) distribution curve.  This is available
      ' as a convenient reference to compare the histogram shape.
      Dim nc As NormalCurve = cg.Histogram.NormalDisplay
      nc.FillStyle.Alpha = 64
      nc.FillStyle.Color1 = Color.Yellow
      nc.Visible = chkShowNormal.Checked
      
      cg.ChartType = Chart2DTypeEnum.Histogram
      
      Dim cds As ChartDataSeries = cg.ChartData.SeriesList.AddNewSeries()
      cds.FitType = FitTypeEnum.Spline
      cds.FillStyle.Alpha = 64
      cds.FillStyle.Color1 = Color.Blue
      
      cds.Histogram.IntervalCreationMethod = IntervalMethodEnum.SemiAutomatic
      cds.Histogram.DisplayType = DisplayTypeEnum.Histogram
      cds.Histogram.IntervalStart = 0
      cds.Histogram.IntervalWidth = 10
      cds.Histogram.IntervalNumber = 10
      
      Dim lab As C1.Win.C1Chart.Label = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel()
      lab.AttachMethod = AttachMethodEnum.DataCoordinate
      lab.AttachMethodData.X = 100
      lab.AttachMethodData.Y = 0
      lab.AttachMethodData.GroupIndex = 0
      lab.Offset = 50
      lab.Name = "overflow"
      lab.Text = ""
      lab.Compass = LabelCompassEnum.South
      lab.Visible = True
   End Sub 'SetupHistogram
   
   
   Private Sub SetHistogramData()
      Dim carea As Area = c1Chart1.ChartArea
      If Not (carea.AxisX.ValueLabels(0) Is Nothing) Then
         ' get the Target Coordinates
         Dim xtarget As Double = carea.AxisX.ValueLabels(0).NumericValue
         Dim ytarget As Double = carea.AxisY.ValueLabels(0).NumericValue
         
         ' get the data point coordinates from the chart.
         Dim cds As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData.SeriesList(0)
         Dim cdata As PointF() = CType(cds.PointData.CopyDataOut(), PointF())
         
         ' find the distance from each scatter point to the target point.
         Dim n As Integer = cdata.Length
         Dim distances As Double() = CType(Array.CreateInstance(GetType(Double), n), Double())
         Dim i As Integer
         For i = 0 To n - 1
            Dim dx As Double = cdata(i).X - xtarget
            Dim dy As Double = cdata(i).Y - ytarget
            distances(i) = Math.Sqrt((dx * dx + dy * dy))
         Next i
         
         ' add the data to the Histogram chart series in ChartGroup(1).
         cds = c1Chart1.ChartGroups(1).ChartData.SeriesList(0)
         cds.Y.CopyDataIn(distances)
         
         ' report the statistics of the distance data.
         txtDistanceStats.Text = "Distance Statistics:" + ControlChars.Cr + ControlChars.Lf + "  Mean: " + cds.Y.Statistics.Mean.ToString("0.000") + ControlChars.Cr + ControlChars.Lf + "  Median: " + cds.Y.Statistics.Median.ToString("0.000") + ControlChars.Cr + ControlChars.Lf + "  StdDev: " + cds.Y.Statistics.StdDev.ToString("0.000")
         
         ' set the overflow label.
         Dim overflow As Integer = CInt(cds.Histogram.AboveIntervalCount)
         Dim msg As String = ""
         If overflow > 0 Then
            msg = "Number > " + carea.AxisX.Max.ToString() + " = " + overflow.ToString()
         End If
         c1Chart1.ChartLabels("overflow").Text = msg
      End If
   End Sub 'SetHistogramData
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      txtDescription.Text = "Shown, is a combination chart with scatter data in "
      txtDescription.Text += "Group0 and a Histogram in Group1." + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf
      txtDescription.Text += "The histogram shows the distribution of the distance (in data coordinates) "
      txtDescription.Text += "from each of the scatter data points to the marker intersection (crosshairs)." + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf
      txtDescription.Text += "The optional Normal Curve is unrelated to the data, and is provided "
      txtDescription.Text += "for comparison of the histogram to the normal (Gaussian) distribution.  "
      txtDescription.Text += "The curve always fills the PlotArea."
      
      ' Setup the Chart with markers and Scatter data in the first ChartGroup.
      ' Setup a Histogram in the second ChartGroup, but do not add the data.
      ChartSetup()
      
      ' Create a Histogram in the second chart group using the scatter data
      ' and the distance from the marker intersection as data for the histogram.
      SetupHistogram()
      
      ' now set the actual histogram data based on the marker values.
      SetHistogramData()
   End Sub 'Form1_Load
   
   
   Private Sub RadioCheckedChanged(sender As Object, e As System.EventArgs) Handles radStepFreq.CheckedChanged, radFreq.CheckedChanged, radHistogram.CheckedChanged
      If c1Chart1.ChartGroups(1).ChartData.SeriesList.Count < 1 Then
         Return
      End If 
      Dim rb As RadioButton = CType(sender, RadioButton)
      Dim ch As ChartHistogram = c1Chart1.ChartGroups(1).ChartData.SeriesList(0).Histogram
      
      If rb.Checked Then
         Select Case rb.Text
            Case "Histogram"
               ch.DisplayType = DisplayTypeEnum.Histogram
            
            Case "Frequency"
               ch.DisplayType = DisplayTypeEnum.FrequencyGraph
            
            Case "Stepped Frequency"
               ch.DisplayType = DisplayTypeEnum.SteppedFrequencyGraph
         End Select
      End If
   End Sub 'RadioCheckedChanged
   
   
   Private Sub chkShowNormal_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkShowNormal.CheckedChanged
      c1Chart1.ChartGroups(1).Histogram.NormalDisplay.Visible = chkShowNormal.Checked
   End Sub 'chkShowNormal_CheckedChanged
   
   
   Private Sub chkHideData_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHideData.CheckedChanged
      Dim sde As SeriesDisplayEnum
      If chkHideData.Checked Then
         sde = SeriesDisplayEnum.Hide
      Else
         sde = SeriesDisplayEnum.Show
      End If 
      c1Chart1.ChartGroups(0).ChartData.SeriesList(0).Display = sde
   End Sub 'chkHideData_CheckedChanged
   
   
   Private Sub chkHideLabels_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkHideLabels.CheckedChanged
      c1Chart1.ChartGroups(0).ChartData.SeriesList(0).DataLabel.Visible = Not chkHideLabels.Checked
   End Sub 'chkHideLabels_CheckedChanged
End Class 'Form1
