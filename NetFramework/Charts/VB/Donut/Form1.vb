
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Diagnostics
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
   WithEvents tbarDepth As System.Windows.Forms.TrackBar
   WithEvents tbarElevation As System.Windows.Forms.TrackBar
   WithEvents bRotateCounterClockwise As System.Windows.Forms.Button
   WithEvents bRotateClockwise As System.Windows.Forms.Button
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   WithEvents chkAlpha As System.Windows.Forms.CheckBox
   WithEvents chkAntiAlias As System.Windows.Forms.CheckBox
   Private imageList1 As System.Windows.Forms.ImageList
   Private label3 As System.Windows.Forms.Label
   WithEvents tbarHoleRadius As System.Windows.Forms.TrackBar
   Private components As System.ComponentModel.IContainer
   
   
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.tbarDepth = New System.Windows.Forms.TrackBar()
      Me.tbarElevation = New System.Windows.Forms.TrackBar()
      Me.bRotateCounterClockwise = New System.Windows.Forms.Button()
      Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
      Me.bRotateClockwise = New System.Windows.Forms.Button()
      Me.label1 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.chkAlpha = New System.Windows.Forms.CheckBox()
      Me.chkAntiAlias = New System.Windows.Forms.CheckBox()
      Me.label3 = New System.Windows.Forms.Label()
      Me.tbarHoleRadius = New System.Windows.Forms.TrackBar()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.tbarDepth, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.tbarElevation, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.tbarHoleRadius, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Location = New System.Drawing.Point(176, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=None,Transparent,1;"" /><NamedSty" + "le Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle Name=""Footer"" ParentN" + "ame=""Control"" StyleData=""Border=None,Transparent,1;"" /><NamedStyle Name=""Area"" P" + "arentName=""Area.default"" /><NamedStyle Name=""Control"" ParentName=""Control.defaul" + "t"" /><NamedStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;Alig" + "nHorz=Center;AlignVert=Bottom;"" /><NamedStyle Name=""AxisY"" ParentName=""Area"" Sty" + "leData=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><NamedStyle Name=" + """LabelStyleDefault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""L" + "egend.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;Wrap=Fa" + "lse;AlignVert=Top;"" /><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""C" + "ontrol"" StyleData=""Border=None,Transparent,1;BackColor=Transparent;"" /><NamedSty" + "le Name=""Header"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;"" /><" + "NamedStyle Name=""Control.default"" ParentName="""" StyleData=""ForeColor=ControlText" + ";Border=None,Transparent,1;BackColor=Control;"" /><NamedStyle Name=""AxisY2"" Paren" + "tName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;AlignVert=Center;"" /><Na" + "medStyle Name=""Area.default"" ParentName=""Control"" StyleData=""Border=None,Transpa" + "rent,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsCollection><ChartGroup Na" + "me=""Group1""><DataSerializer DefaultSet=""True""><DataSeriesCollection><DataSeriesS" + "erializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Coral"" Shape=""B" + "ox"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""" + "DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><SeriesLabel>serie" + "s 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Single;Single;Do" + "uble;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSe" + "riesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" /><SymbolStyle" + " Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5<" + "/X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes" + "><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSer" + "ializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" Shape=""Diamo" + "nd"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" + "</ChartGroup><ChartGroup Name=""Group2""><DataSerializer /></ChartGroup></ChartGro" + "upsCollection><Header Compass=""North"" /><Footer Compass=""South"" /><Legend Compas" + "s=""East"" Visible=""False"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1" + """ UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True" + """ Compass=""South""><GridMajor /><GridMinor /></Axis><Axis Max=""26"" Min=""8"" UnitMa" + "jor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""" + "True"" Compass=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" Unit" + "Major=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin" + "=""True"" Compass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>" + ""

      Me.c1Chart1.Size = New System.Drawing.Size(352, 360)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' tbarDepth
      ' 
      Me.tbarDepth.Location = New System.Drawing.Point(8, 24)
      Me.tbarDepth.Name = "tbarDepth"
      Me.tbarDepth.Size = New System.Drawing.Size(152, 42)
      Me.tbarDepth.TabIndex = 1
      ' 
      ' tbarElevation
      ' 
      Me.tbarElevation.Location = New System.Drawing.Point(8, 104)
      Me.tbarElevation.Name = "tbarElevation"
      Me.tbarElevation.Size = New System.Drawing.Size(152, 42)
      Me.tbarElevation.TabIndex = 2
      ' 
      ' bRotateCounterClockwise
      ' 
      Me.bRotateCounterClockwise.Image = CType(resources.GetObject("bRotateCounterClockwise.Image"), System.Drawing.Bitmap)
      Me.bRotateCounterClockwise.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bRotateCounterClockwise.ImageIndex = 1
      Me.bRotateCounterClockwise.ImageList = Me.imageList1
      Me.bRotateCounterClockwise.Location = New System.Drawing.Point(8, 248)
      Me.bRotateCounterClockwise.Name = "bRotateCounterClockwise"
      Me.bRotateCounterClockwise.Size = New System.Drawing.Size(72, 72)
      Me.bRotateCounterClockwise.TabIndex = 3
      Me.bRotateCounterClockwise.Text = "Counter Clockwise"
      Me.bRotateCounterClockwise.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      ' 
      ' imageList1
      ' 
      Me.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
      Me.imageList1.ImageSize = New System.Drawing.Size(72, 36)
      Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.imageList1.TransparentColor = System.Drawing.Color.White
      ' 
      ' bRotateClockwise
      ' 
      Me.bRotateClockwise.Image = CType(resources.GetObject("bRotateClockwise.Image"), System.Drawing.Bitmap)
      Me.bRotateClockwise.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.bRotateClockwise.ImageIndex = 0
      Me.bRotateClockwise.ImageList = Me.imageList1
      Me.bRotateClockwise.Location = New System.Drawing.Point(88, 248)
      Me.bRotateClockwise.Name = "bRotateClockwise"
      Me.bRotateClockwise.Size = New System.Drawing.Size(72, 72)
      Me.bRotateClockwise.TabIndex = 4
      Me.bRotateClockwise.Text = "Clockwise"
      Me.bRotateClockwise.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      ' 
      ' label1
      ' 
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(128, 16)
      Me.label1.TabIndex = 5
      Me.label1.Text = "Depth Adjustment"
      ' 
      ' label2
      ' 
      Me.label2.Location = New System.Drawing.Point(8, 88)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(144, 16)
      Me.label2.TabIndex = 6
      Me.label2.Text = "Elevation Adjustment"
      ' 
      ' chkAlpha
      ' 
      Me.chkAlpha.Checked = True
      Me.chkAlpha.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkAlpha.Location = New System.Drawing.Point(8, 336)
      Me.chkAlpha.Name = "chkAlpha"
      Me.chkAlpha.Size = New System.Drawing.Size(144, 16)
      Me.chkAlpha.TabIndex = 7
      Me.chkAlpha.Text = "Use Alpha Blending"
      ' 
      ' chkAntiAlias
      ' 
      Me.chkAntiAlias.Location = New System.Drawing.Point(8, 360)
      Me.chkAntiAlias.Name = "chkAntiAlias"
      Me.chkAntiAlias.Size = New System.Drawing.Size(144, 24)
      Me.chkAntiAlias.TabIndex = 0
      Me.chkAntiAlias.Text = "Use AntiAliasing"
      ' 
      ' label3
      ' 
      Me.label3.Location = New System.Drawing.Point(8, 168)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(144, 16)
      Me.label3.TabIndex = 8
      Me.label3.Text = "Donut Hole Radius"
      ' 
      ' tbarHoleRadius
      ' 
      Me.tbarHoleRadius.Location = New System.Drawing.Point(8, 184)
      Me.tbarHoleRadius.Name = "tbarHoleRadius"
      Me.tbarHoleRadius.Size = New System.Drawing.Size(144, 42)
      Me.tbarHoleRadius.TabIndex = 9
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbarHoleRadius, Me.label3, Me.chkAntiAlias, Me.chkAlpha, Me.label2, Me.label1, Me.bRotateClockwise, Me.bRotateCounterClockwise, Me.tbarElevation, Me.tbarDepth, Me.c1Chart1})
      Me.Name = "Form1"
      Me.Text = "Form1"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.tbarDepth, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.tbarElevation, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.tbarHoleRadius, System.ComponentModel.ISupportInitialize).EndInit()
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
      Dim cg As ChartGroup = c1Chart1.ChartGroups.Group0
      
      ' a donut is a Pie chart with a non-zero inner radius.
      cg.ChartType = Chart2DTypeEnum.Pie
      
      ' the inner radius is specified as a percentage of the pie radius
      cg.Pie.InnerRadius = 30
      
      ' create a single donut from the existing data.
      Dim cdsc As ChartDataSeriesCollection = cg.ChartData.SeriesList
      Dim cds As ChartDataSeries
      For Each cds In  cdsc
         ' give the first series an offset
         If cds.Label = "series 0" Then
            cds.Offset = 30
         End If 
         ' reduce each series to a single point for 1 donut.
         If cds.Length > 1 Then
            cds.PointData.Length = 1
         End If 
         ' use alpha blending to show the internals
         cds.FillStyle.Alpha = 100
         
         ' provide the ToolTip text
         cds.TooltipText = "Slice {#ISERIES}"
      Next cds
      
      ' give the donut some depth and elevation
      Dim v As View3D = c1Chart1.ChartArea.PlotArea.View3D
      v.Depth = 10
      v.Elevation = 45
      
      ' turn on the tooltips
      c1Chart1.ToolTip.Enabled = True
      
      ' turn on highlighting
      cg.ChartData.HighLight.Activation = HighlightActivationEnum.MouseOver
      
      ' add a legend
      c1Chart1.Legend.Visible = True
      
      ' add some color and borders
      Dim sty As Style = c1Chart1.Style
      sty.GradientStyle = GradientStyleEnum.HorizontalCenter
      sty.BackColor = Color.White
      sty.BackColor2 = Color.LightBlue
      Dim bord As Border = sty.Border
      bord.BorderStyle = BorderStyleEnum.Solid
      bord.Rounding.All = 10
      bord.Thickness = 3
      bord.Color = Color.Blue
      
      ' turn off color in legend and chart area so the gradient
      ' is not inheritted - it looks odd
      sty = c1Chart1.Legend.Style
      sty.BackColor = Color.Transparent
      sty.GradientStyle = GradientStyleEnum.None
      
      sty = c1Chart1.ChartArea.Style
      sty.BackColor = Color.Transparent
      sty.GradientStyle = GradientStyleEnum.None
      
      ' force a resize
      Form1_Resize(Nothing, Nothing)
      
      
      ' initialize the TBars
      tbarDepth.Maximum = 50
      tbarDepth.Minimum = 0
      tbarDepth.Value = c1Chart1.ChartArea.PlotArea.View3D.Depth
      
      tbarElevation.Maximum = 50
      tbarElevation.Minimum = 5
      tbarElevation.Value = c1Chart1.ChartArea.PlotArea.View3D.Elevation
      
      tbarHoleRadius.Maximum = 90
      tbarHoleRadius.Minimum = 0
      tbarHoleRadius.Value = c1Chart1.ChartGroups.Group0.Pie.InnerRadius
   End Sub 'Form1_Load
   
   
   Private Sub Form1_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      Dim w As Integer = ClientSize.Width - c1Chart1.Left
      Dim h As Integer = ClientSize.Height
      
      If w < 10 Then
         w = 10
      End If
      If h < 10 Then
         h = 10
      End If 
      c1Chart1.Size = New Size(w, h)
   End Sub 'Form1_Resize
   
   
   Private Sub tbarDepth_Scroll(sender As Object, e As System.EventArgs) Handles tbarDepth.Scroll
      c1Chart1.ChartArea.PlotArea.View3D.Depth = tbarDepth.Value
   End Sub 'tbarDepth_Scroll
   
   
   Private Sub tbarElevation_Scroll(sender As Object, e As System.EventArgs) Handles tbarElevation.Scroll
      c1Chart1.ChartArea.PlotArea.View3D.Elevation = tbarElevation.Value
   End Sub 'tbarElevation_Scroll
   
   
   Private Sub tbarHoleRadius_Scroll(sender As Object, e As System.EventArgs) Handles tbarHoleRadius.Scroll
      c1Chart1.ChartGroups.Group0.Pie.InnerRadius = tbarHoleRadius.Value
   End Sub 'tbarHoleRadius_Scroll
   
   
   Private Sub bRotateCounterClockwise_Click(sender As Object, e As System.EventArgs) Handles bRotateCounterClockwise.Click
      Dim pie As Pie = c1Chart1.ChartGroups.Group0.Pie
      pie.Start =(pie.Start + 10) Mod 360
   End Sub 'bRotateCounterClockwise_Click
   
   
   Private Sub bRotateClockwise_Click(sender As Object, e As System.EventArgs) Handles bRotateClockwise.Click
      Dim pie As Pie = c1Chart1.ChartGroups.Group0.Pie
      pie.Start =(pie.Start + 350) Mod 360
   End Sub 'bRotateClockwise_Click
   
   
   Private Sub chkAlpha_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkAlpha.CheckedChanged
      Dim useAlpha As Boolean = chkAlpha.Checked
      Dim cdsc As ChartDataSeriesCollection = c1Chart1.ChartGroups(0).ChartData.SeriesList
      Dim cds As ChartDataSeries
      For Each cds In  cdsc
         If useAlpha AndAlso cds.FillStyle.Alpha = 255 Then
            cds.FillStyle.Alpha = 100
         ElseIf cds.FillStyle.Alpha < 255 Then
            cds.FillStyle.Alpha = 255
         End If
      Next cds
   End Sub 'chkAlpha_CheckedChanged
    
   Private Sub chkAntiAlias_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkAntiAlias.CheckedChanged
      c1Chart1.UseAntiAliasedGraphics = chkAntiAlias.Checked
   End Sub 'chkAntiAlias_CheckedChanged
End Class 'Form1
