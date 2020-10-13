
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
   Private txtStatistics As System.Windows.Forms.TextBox
   WithEvents chartRawData As C1.Win.C1Chart.C1Chart
   WithEvents chartHistogram As C1.Win.C1Chart.C1Chart
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
      Me.chartRawData = New C1.Win.C1Chart.C1Chart()
      Me.txtStatistics = New System.Windows.Forms.TextBox()
      Me.chartHistogram = New C1.Win.C1Chart.C1Chart()
      CType(Me.chartRawData, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.chartHistogram, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' txtStatistics
      ' 
      Me.txtStatistics.BackColor = System.Drawing.Color.White
      Me.txtStatistics.Multiline = True
      Me.txtStatistics.Name = "txtStatistics"
      Me.txtStatistics.ReadOnly = True
      Me.txtStatistics.Size = New System.Drawing.Size(160, 160)
      Me.txtStatistics.TabIndex = 1
      Me.txtStatistics.Text = ""
      ' 
      ' chartRawData
      ' 
      Me.chartRawData.DataSource = Nothing
      Me.chartRawData.Location = New System.Drawing.Point(168, 0)
      Me.chartRawData.Name = "chartRawData"
      Me.chartRawData.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""Area.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;AlignV" + "ert=Top;"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" /><NamedStyl" + "e Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;Ali" + "gnVert=Center;"" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData=""Bord" + "er=None,Transparent,1;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleDa" + "ta=""Border=None,Transparent,1;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.d" + "efault"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle Name=""" + "LabelStyleDefault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""La" + "belStyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Transparent" + ",1;BackColor=Transparent;"" /><NamedStyle Name=""PlotArea"" ParentName=""Area"" Style" + "Data=""Border=None,Transparent,1;"" /><NamedStyle Name=""Control.default"" ParentNam" + "e="""" StyleData=""ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" + "l;"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Border=N" + "one,Transparent,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""AxisY"" ParentNa" + "me=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><Nam" + "edStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Cen" + "ter;AlignVert=Bottom;"" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" + "me=""Group1""><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeriesS" + "erializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Coral"" Shape=""B" + "ox"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" + "Style Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><Seri" + "esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" + "gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" + "le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" + """DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2<" + "/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" + "e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " + "/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><S" + "ymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel>" + "<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" + "le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" + "sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" + "illStyle Color1=""Transparent"" /></NormalDisplay></Histogram></ChartGroup><ChartG" + "roup Name=""Group2""><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" + "=""Transparent"" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" + "n><Header Compass=""North"" /><Footer Compass=""South"" /><Legend Compass=""East"" Vis" + "ible=""False"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""S" + "outh""><GridMajor /><GridMinor /></Axis><Axis Max=""25"" Min=""5"" UnitMajor=""5"" Unit" + "Minor=""2.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Comp" + "ass=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" " + "UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Co" + "mpass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.chartRawData.Size = New System.Drawing.Size(336, 208)
      Me.chartRawData.TabIndex = 0
      ' 
      ' chartHistogram
      ' 
      Me.chartHistogram.DataSource = Nothing
      Me.chartHistogram.Location = New System.Drawing.Point(168, 232)
      Me.chartHistogram.Name = "chartHistogram"
      Me.chartHistogram.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""Area.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;AlignV" + "ert=Top;"" /><NamedStyle Name=""Control"" ParentName=""Control.default"" /><NamedStyl" + "e Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;Ali" + "gnVert=Center;"" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData=""Bord" + "er=None,Transparent,1;"" /><NamedStyle Name=""Header"" ParentName=""Control"" StyleDa" + "ta=""Border=None,Transparent,1;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.d" + "efault"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle Name=""" + "LabelStyleDefault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""La" + "belStyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Transparent" + ",1;BackColor=Transparent;"" /><NamedStyle Name=""PlotArea"" ParentName=""Area"" Style" + "Data=""Border=None,Transparent,1;"" /><NamedStyle Name=""Control.default"" ParentNam" + "e="""" StyleData=""ForeColor=ControlText;Border=None,Transparent,1;BackColor=Contro" + "l;"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Border=N" + "one,Transparent,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""AxisY"" ParentNa" + "me=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><Nam" + "edStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Cen" + "ter;AlignVert=Bottom;"" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" + "me=""Group1""><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeriesS" + "erializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Coral"" Shape=""B" + "ox"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><Line" + "Style Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><Seri" + "esLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Sin" + "gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillSty" + "le /><Histogram /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=" + """DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2<" + "/SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Doubl" + "e;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram " + "/></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki"" /><S" + "ymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel>" + "<X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Doub" + "le</DataTypes><DataFields>;;;;</DataFields><FillStyle /><Histogram /></DataSerie" + "sSerializer></DataSeriesCollection></DataSerializer><Histogram><NormalDisplay><F" + "illStyle Color1=""Transparent"" /></NormalDisplay></Histogram></ChartGroup><ChartG" + "roup Name=""Group2""><DataSerializer /><Histogram><NormalDisplay><FillStyle Color1" + "=""Transparent"" /></NormalDisplay></Histogram></ChartGroup></ChartGroupsCollectio" + "n><Header Compass=""North"" /><Footer Compass=""South"" /><Legend Compass=""East"" Vis" + "ible=""False"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""S" + "outh""><GridMajor /><GridMinor /></Axis><Axis Max=""25"" Min=""5"" UnitMajor=""5"" Unit" + "Minor=""2.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Comp" + "ass=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" " + "UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Co" + "mpass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.chartHistogram.Size = New System.Drawing.Size(344, 192)
      Me.chartHistogram.TabIndex = 2
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chartHistogram, Me.txtStatistics, Me.chartRawData})
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.chartRawData, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.chartHistogram, System.ComponentModel.ISupportInitialize).EndInit()
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

   
   Public Enum SeasonEnum
      Years
      Winter
      Spring
      Summer
      Fall
   End Enum 'SeasonEnum
   
   
   Public Function KansasCityTempData(season As SeasonEnum) As Double()
      ' returns year or Average Mean Temperature for the seasons from
      ' 1889 to 2004 for the specified Season in Kansas City, Mo., USA
      '
      ' http://www.crh.noaa.gov/eax/climo/winyear.htm
      Dim Winter() As Double = {37.0, 34.0, 33.9, 25.2, 30.9, 29.0, 33.3, 33.5, 31.8, 26.1, 30.2, 32.6, 27.7, 29.8, 29.2, 25.1, 34.0, 33.4, 35.0, 34.6, 27.0, 33.6, 26.8, 31.8, 33.9, 30.1, 30.8, 32.1, 24.6, 36.0, 29.7, 37.9, 33.0, 34.8, 33.0, 30.9, 34.2, 34.1, 32.9, 27.3, 32.8, 38.4, 39.0, 34.9, 36.1, 33.3, 24.6, 31.0, 33.6, 34.8, 28.2, 33.8, 34.6, 32.4, 34.0, 31.1, 33.2, 33.8, 31.1, 31.3, 34.3, 32.0, 34.5, 36.1, 36.6, 33.7, 31.3, 33.6, 33.0, 30.8, 33.3, 33.6, 28.8, 28.1, 32.8, 32.0, 35.2, 34.1, 32.0, 30.0, 31.8, 32.7, 32.4, 29.4, 29.5, 30.0, 34.6, 26.2, 22.0, 21.5, 29.8, 31.9, 25.0, 33.7, 25.4, 26.5, 29.2, 34.3, 29.9, 32.2, 31.6, 30.2, 37.2, 29.1, 29.9, 33.4, 29.4, 29.1, 36.0, 34.3, 36.0, 26.1, 36.2, 31.4, 31.4, 33.7}
      
      ' http://www.crh.noaa.gov/eax/climo/spryear.htm
      Dim Spring() As Double = {54.7, 52.9, 50.5, 49.9, 51.8, 56.7, 55.7, 56.4, 53.8, 54.3, 52.1, 55.1, 53.3, 56.1, 55.2, 52.0, 56.9, 52.8, 53.0, 56.0, 52.7, 58.0, 56.4, 52.0, 54.1, 55.1, 53.0, 54.6, 51.7, 56.5, 54.2, 52.2, 57.9, 55.9, 52.2, 51.1, 56.2, 54.2, 55.6, 55.6, 55.5, 55.6, 52.2, 53.7, 54.9, 56.8, 54.4, 58.1, 53.7, 57.9, 56.7, 53.4, 56.7, 56.5, 52.9, 53.1, 55.6, 59.4, 51.1, 55.6, 55.6, 52.7, 52.2, 53.3, 53.8, 54.6, 58.1, 56.2, 54.7, 53.8, 57.2, 51.3, 51.5, 56.5, 58.6, 56.4, 54.7, 55.6, 55.9, 56.0, 53.3, 57.2, 55.9, 57.2, 53.7, 56.2, 52.1, 53.7, 58.9, 51.7, 52.4, 52.4, 55.5, 53.0, 49.7, 48.9, 57.0, 56.9, 58.2, 55.6, 54.6, 52.9, 57.2, 54.2, 51.2, 54.8, 52.3, 51.6, 51.3, 54.8, 53.5, 56.5, 55.5, 52.9, 54.7, 57.3}
      
      ' http://www.crh.noaa.gov/eax/climo/sumyear.htm
      Dim Summer() As Double = {74.0, 77.1, 72.5, 75.5, 74.5, 76.7, 74.2, 75.8, 76.9, 76.8, 76.7, 77.1, 81.9, 74.8, 74.2, 73.5, 76.2, 75.5, 75.8, 74.4, 77.3, 75.3, 79.4, 75.7, 80.9, 79.1, 71.6, 77.7, 75.5, 80.8, 77.9, 74.7, 78.4, 77.6, 76.9, 75.1, 77.6, 76.9, 73.0, 74.7, 76.5, 78.9, 79.1, 79.1, 79.6, 84.9, 79.6, 84.4, 80.4, 79.9, 79.3, 77.5, 78.2, 77.5, 79.7, 77.4, 75.4, 78.2, 79.6, 77.9, 78.3, 72.8, 75.1, 80.4, 81.3, 82.6, 79.3, 80.0, 79.9, 76.8, 79.1, 77.5, 75.0, 77.3, 80.0, 77.4, 76.6, 77.2, 74.8, 78.3, 76.9, 79.3, 78.0, 77.1, 76.1, 74.9, 78.3, 76.0, 76.2, 76.8, 74.6, 80.3, 75.0, 74.5, 78.7, 76.5, 72.7, 76.1, 77.5, 80.2, 74.8, 76.6, 78.1, 71.6, 76.2, 75.7, 76.6, 74.6, 75.1, 76.1, 76.3, 76.6, 76.7, 78.7, 77.8, 72.7}
      
      ' http://www.crh.noaa.gov/eax/climo/falyear.htm
      Dim Fall() As Double = {53.2, 55.3, 55.8, 56.5, 57.1, 56.9, 55.8, 53.4, 61.6, 55.0, 61.0, 59.0, 58.5, 58.0, 55.5, 59.6, 57.7, 56.9, 56.7, 57.9, 59.3, 58.0, 55.9, 58.2, 58.4, 60.2, 60.6, 57.3, 55.5, 57.0, 56.7, 58.2, 59.4, 60.1, 56.6, 58.5, 55.4, 55.3, 59.8, 57.6, 55.1, 58.7, 63.5, 55.0, 60.3, 59.0, 55.9, 57.7, 56.3, 61.4, 60.9, 58.8, 59.7, 57.9, 54.9, 59.5, 57.8, 59.4, 60.6, 58.7, 58.3, 57.9, 54.4, 57.3, 61.6, 61.5, 57.9, 61.5, 55.5, 61.0, 55.1, 60.6, 56.3, 58.3, 65.4, 58.9, 59.5, 59.2, 57.0, 56.8, 57.8, 58.2, 61.2, 54.7, 57.6, 54.1, 56.1, 51.9, 55.6, 58.1, 55.7, 56.0, 56.4, 55.0, 57.5, 55.6, 53.4, 55.5, 55.4, 55.8, 54.5, 59.7, 54.4, 53.9, 51.9, 57.1, 54.1, 52.7, 55.9, 59.6, 58.2, 55.7, 57.6, 55.0, 55.0, 58.2}
      
      Dim seasonData As Double() = Nothing
      Select Case season
         Case SeasonEnum.Years
            If (True) Then
               ' returns an array of the years for which temperature
               ' data are available.
               Dim i As Integer = 0
               Dim j As Integer = 0
               seasonData = CType(Array.CreateInstance(GetType(Double), 2004 - 1889 + 1), Double())
               For i = 1889 To 2004
                  seasonData(j) = i
                  j += 1
               Next i
            End If
         Case SeasonEnum.Winter
            ' returns Winter Average Mean Temperatures
            seasonData = Winter
         Case SeasonEnum.Spring
            ' returns Spring Average Mean Temperatures
            seasonData = Spring
         Case SeasonEnum.Summer
            ' returns Summer Average Mean Temperatures
            seasonData = Summer
         Case SeasonEnum.Fall
            seasonData = Fall
      End Select ' returns Fall Average Mean Temperatures
      Return seasonData
   End Function 'KansasCityTempData
   
   
   Private Sub SetupRawTempChart(chart As C1Chart)
      ' show the average mean temperature data and resize
      ' the chart with the form.
      chart.Reset()
      chart.Width = Me.ClientSize.Width - chart.Left
      chart.Height = Me.ClientSize.Height / 2
      
      ' setup the chart appearance
      chart.Style.BackColor = Color.White
      chart.Style.Border.BorderStyle = BorderStyleEnum.Inset
      chart.Style.Border.Thickness = 2
      chart.Style.Border.Color = Color.Black
      
      ' setup the axis limits and titles
      Dim ax As Axis = chart.ChartArea.AxisX
      ax.Min = 1880
      ax.Max = 2020
      
      ax = chart.ChartArea.AxisY
      ax.Text = "Temperature F"
      ax.Min = 0
      ax.Max = 100
      
      ax = chart.ChartArea.AxisY2
      ax.Text = "Temperature C"
      ax.Min =(0.0 - 32.0) * 5.0 / 9.0
      ax.Max =(100.0 - 32.0) * 5.0 / 9.0
      
      ' Legend and header
      chart.Legend.Visible = True
      chart.Header.Text = "Yearly Average Kansas City Mean Temperatures by Season"
      chart.Header.Style.Font = New Font("Arial Narrow", 12, FontStyle.Bold)
      
      ' get and add the data
      Dim years As Double() = KansasCityTempData(SeasonEnum.Years)
      Dim cdsc As ChartDataSeriesCollection = chart.ChartGroups(0).ChartData.SeriesList
      
      ' use a thicker line for the plots so the lines are very visible.
      Const lineThickness As Integer = 2
      
      ' Winter
      Dim cds As ChartDataSeries = cdsc.AddNewSeries()
      cds.X.CopyDataIn(years)
      cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Winter))
      cds.SymbolStyle.Shape = SymbolShapeEnum.None
      cds.Label = "Winter"
      cds.LineStyle.Color = Color.Blue
      cds.LineStyle.Thickness = lineThickness
      
      ' Spring
      cds = cdsc.AddNewSeries()
      cds.X.CopyDataIn(years)
      cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Spring))
      cds.SymbolStyle.Shape = SymbolShapeEnum.None
      cds.Label = "Spring"
      cds.LineStyle.Color = Color.Green
      cds.LineStyle.Thickness = lineThickness
      
      ' Summer
      cds = cdsc.AddNewSeries()
      cds.X.CopyDataIn(years)
      cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Summer))
      cds.SymbolStyle.Shape = SymbolShapeEnum.None
      cds.Label = "Summer"
      cds.LineStyle.Color = Color.Red
      cds.LineStyle.Thickness = lineThickness
      
      ' Fall
      cds = cdsc.AddNewSeries()
      cds.X.CopyDataIn(years)
      cds.Y.CopyDataIn(KansasCityTempData(SeasonEnum.Fall))
      cds.SymbolStyle.Shape = SymbolShapeEnum.None
      cds.Label = "Fall"
      cds.LineStyle.Color = Color.Brown
      cds.LineStyle.Thickness = lineThickness
      
      ' add a series to Group1 so the Y2 axis is shown.  At the same time
      ' hide the series in the legend, since it is a dummy series.
      chart.ChartGroups(1).ChartData.SeriesList.AddNewSeries().LegendEntry = False
   End Sub 'SetupRawTempChart
   
   
   Private Sub SetupHistogramChart(chartRaw As C1Chart, chartHisto As C1Chart)
      chartHisto.Reset()
      chartHisto.Left = 0
      Form1_Resize(Nothing, Nothing)
      
      ' Setup the Histogram chart appearance
      chartHisto.Style.BackColor = Color.AliceBlue
      chartHisto.Style.Border.BorderStyle = BorderStyleEnum.Solid
      chartHisto.Style.Border.Thickness = 2
      chartHisto.Style.Border.Color = Color.Black
      chartHisto.Legend.Visible = True
      
      ' Create a histogram type chart using a bar chart type rather an actual
      ' histogram type.  Histograms reflect single series of data well, but do
      ' not show multiple series as well as a bar chart.
      '
      ' Use the chart static method to generate histogram data from the raw data.
      Dim cgHisto As ChartGroup = chartHisto.ChartGroups(0)
      Dim cdscHisto As ChartDataSeriesCollection = cgHisto.ChartData.SeriesList
      cgHisto.ChartType = Chart2DTypeEnum.Bar
      
      ' obtain the data from chartRaw.
      Dim cdRaw As ChartData = chartRaw.ChartGroups(0).ChartData
      Dim cdscRaw As ChartDataSeriesCollection = cdRaw.SeriesList
      Dim dataMax As Double = 0
      Dim dataMin As Double = 0
      
      ' determine the extremes from the series means
      Dim cdsRaw0 As ChartDataSeries
      For Each cdsRaw0 In  cdscRaw
         Dim mean As Double = cdsRaw0.Y.Statistics.Mean
         Dim mn As Double = cdsRaw0.MinY - mean
         Dim mx As Double = cdsRaw0.MaxY - mean
         
         If dataMax < mx Then
            dataMax = mx
         End If
         If dataMin > mn Then
            dataMin = mn
         End If
      Next cdsRaw0 
      dataMax = Math.Ceiling(dataMax)
      dataMin = Math.Floor(dataMin)
      
      ' Assume that the interval width is one degree.
      Dim intervalCount As Integer = CInt(dataMax - dataMin) + 1
      
      Dim cdsRaw As ChartDataSeries
      For Each cdsRaw In  cdscRaw
         Dim rawData As Double() = CType(cdsRaw.Y.CopyDataOut(GetType(Double)), Double())
         
         ' determine the difference of each point from the mean.
         Dim mean As Double = cdsRaw.Y.Statistics.Mean
         
         Dim differencesFromMean As Double() = CType(rawData.Clone(), Double())
         Dim d As Integer
         For d = 0 To differencesFromMean.Length - 1
            differencesFromMean(d) -= mean
         Next d 
         Dim xbounds As Double() = Nothing
         Dim ycounts As Double() = Nothing
         Dim bis As Double() = Nothing
         
         ' generate histogram data of the difference from the means.  Start
         ' using a half-width less than the dataMin.  This will provide
         ' intervals that center on each integral temperature difference.
         C1Chart.GenerateHistogramData(differencesFromMean, dataMin - 0.5, 1.0, intervalCount, - 1.0, xbounds, ycounts, bis)
         
         ' add a series of histogramdata
         Dim cdsHisto As ChartDataSeries = cdscHisto.AddNewSeries()
         cdsHisto.Label = cdsRaw.Label
         cdsHisto.LineStyle.Color = Color.FromArgb(128, cdsRaw.LineStyle.Color)
         
         bis = CType(Array.CreateInstance(GetType(Double), intervalCount), Double())
         Dim p As Integer
         For p = 0 To intervalCount - 1
            bis(p) =(xbounds(p) + xbounds((p + 1))) / 2
         Next p 
         cdsHisto.X.CopyDataIn(bis)
         cdsHisto.Y.CopyDataIn(ycounts)
      Next cdsRaw
      
      ' Add description and instructions to the header, footer and axes.
      chartHisto.Header.Text = "Bar Chart Histogram of Differences from Seasonal Mean Kansas City Temperatures"
      chartHisto.Header.Style.Font = chartRaw.Header.Style.Font
      chartHisto.Footer.Text = "Double-Click to Toggle Bar Stacking"
      chartHisto.ChartArea.AxisX.Text = "Difference From Mean Seasonal Mean Temperature (F)"
      chartHisto.ChartArea.AxisY.Text = "Count of Seasonal Mean Temperatures"
   End Sub 'SetupHistogramChart
   
   
   Private Sub SetupStatisticsInfo(chart As C1Chart)
      ' obtain the temperature statistics from the chart series, and report
      ' them through the textbox.
      Dim tb As TextBox = txtStatistics
      Dim cdsc As ChartDataSeriesCollection = chart.ChartGroups(0).ChartData.SeriesList
      Dim cds As ChartDataSeries
      For Each cds In  cdsc
         Dim mean As Double = cds.Y.Statistics.Mean
         Dim meanC As Double = (mean - 32) * 5.0 / 9.0
         
         Dim sd As Double = cds.Y.Statistics.StdDev
         Dim sdC As Double = sd * 5.0 / 9.0
         
         tb.Text += cds.Label + ControlChars.Cr + ControlChars.Lf
         tb.Text += "   Mean:   " + mean.ToString("0.0") + "F (" + meanC.ToString("0.0") + "C)" + ControlChars.Cr + ControlChars.Lf
         tb.Text += "   StdDev: " + sd.ToString("0.00") + "F (" + sdC.ToString("0.00") + "C)" + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf
      Next cds
   End Sub 'SetupStatisticsInfo
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      SetupRawTempChart(chartRawData)
      SetupHistogramChart(chartRawData, chartHistogram)
      SetupStatisticsInfo(chartRawData)
   End Sub 'Form1_Load
   
   
   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      ' resize the charts with each form resize.
      Dim chart As C1Chart = chartRawData
      
      Dim w As Integer = Me.ClientSize.Width - chart.Left
      Dim h As Integer = chart.Height
      If w < 100 Then
         w = 100
      End If
      chart.Width = w
      txtStatistics.Height = h
      
      chart = chartHistogram
      chart.Width = Me.ClientSize.Width
      
      chart.Top = h
      h = Me.ClientSize.Height - h
      If h < 100 Then
         h = 100
      End If
      chart.Height = h
   End Sub 'Form1_Resize
    
   
   Private Sub chartHistogram_DoubleClick(sender As Object, e As System.EventArgs) Handles chartHistogram.DoubleClick
      ' toggle the stacking property, and adjust the bar chart clusterwidth
      ' to fill each cluster when stacked, but separated when non-stacked.
      Dim cg As ChartGroup = chartHistogram.ChartGroups(0)
      If cg.Stacked Then
         cg.Stacked = False
         cg.Bar.ClusterWidth = 50
      Else
         cg.Stacked = True
         cg.Bar.ClusterWidth = 100
      End If
   End Sub 'chartHistogram_DoubleClick
End Class 'Form1
