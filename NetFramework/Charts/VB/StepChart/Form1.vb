
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for StepChart.
'/ </summary>
Public Class StepChart
   Inherits System.Windows.Forms.Form
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents hScrollBar1 As System.Windows.Forms.HScrollBar
   WithEvents vScrollBar1 As System.Windows.Forms.VScrollBar
   WithEvents chkShow3D As System.Windows.Forms.CheckBox
   WithEvents updnDepth As System.Windows.Forms.NumericUpDown
   Private labDepth As System.Windows.Forms.Label
   Private labCoordInfo As System.Windows.Forms.Label
   WithEvents chkAlpha As System.Windows.Forms.CheckBox
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
      Me.hScrollBar1 = New System.Windows.Forms.HScrollBar()
      Me.vScrollBar1 = New System.Windows.Forms.VScrollBar()
      Me.chkShow3D = New System.Windows.Forms.CheckBox()
      Me.updnDepth = New System.Windows.Forms.NumericUpDown()
      Me.labDepth = New System.Windows.Forms.Label()
      Me.labCoordInfo = New System.Windows.Forms.Label()
      Me.chkAlpha = New System.Windows.Forms.CheckBox()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.updnDepth, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Location = New System.Drawing.Point(168, 48)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=None,Transparent,1;"" /><NamedSty" + "le Name=""Legend"" ParentName=""Legend.default"" StyleData=""AlignHorz=Center;AlignVe" + "rt=Top;"" /><NamedStyle Name=""Footer"" ParentName=""Control"" StyleData=""Border=None" + ",Transparent,1;"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" /><NamedSty" + "le Name=""Control"" ParentName=""Control.default"" /><NamedStyle Name=""AxisX"" Parent" + "Name=""Area"" StyleData=""Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;"" /><N" + "amedStyle Name=""AxisY"" ParentName=""Area"" StyleData=""Rotation=Rotate270;AlignHorz" + "=Near;AlignVert=Center;"" /><NamedStyle Name=""LabelStyleDefault"" ParentName=""Labe" + "lStyleDefault.default"" /><NamedStyle Name=""Legend.default"" ParentName=""Control"" " + "StyleData=""Border=None,Transparent,1;Wrap=False;AlignVert=Top;"" /><NamedStyle Na" + "me=""LabelStyleDefault.default"" ParentName=""Control"" StyleData=""Border=None,Trans" + "parent,1;BackColor=Transparent;"" /><NamedStyle Name=""Header"" ParentName=""Control" + """ StyleData=""Border=None,Transparent,1;"" /><NamedStyle Name=""Control.default"" Pa" + "rentName="""" StyleData=""ForeColor=ControlText;Border=None,Transparent,1;BackColor" + "=Control;"" /><NamedStyle Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rot" + "ate90;AlignHorz=Far;AlignVert=Center;"" /><NamedStyle Name=""Area.default"" ParentN" + "ame=""Control"" StyleData=""Border=None,Transparent,1;AlignVert=Top;"" /></StyleColl" + "ection><ChartGroupsCollection><ChartGroup Name=""Group1""><DataSerializer DefaultS" + "et=""True""><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""DarkGold" + "enrod"" /><SymbolStyle Color=""Coral"" Shape=""Box"" /><SeriesLabel>series 0</SeriesL" + "abel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double" + ";Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSeriali" + "zer><DataSeriesSerializer><LineStyle Color=""DarkGray"" /><SymbolStyle Color=""Corn" + "flowerBlue"" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>" + "8;12;10;12;15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataF" + "ields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer" + "><LineStyle Color=""DarkGreen"" /><SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><Ser" + "iesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>S" + "ingle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillS" + "tyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkKhaki""" + " /><SymbolStyle Color=""Crimson"" Shape=""Diamond"" /><SeriesLabel>series 3</SeriesL" + "abel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double" + ";Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSeriali" + "zer></DataSeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=""Group" + "2""><DataSerializer /></ChartGroup></ChartGroupsCollection><Header Compass=""North" + """ /><Footer Compass=""South"" /><Legend Compass=""East"" Visible=""True""><TooltipText" + ">Legend</TooltipText></Legend><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor" + "=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""T" + "rue"" Compass=""South""><GridMajor /><GridMinor /></Axis><Axis Max=""26"" Min=""8"" Uni" + "tMajor=""2"" UnitMinor=""1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMi" + "n=""True"" Compass=""West""><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" U" + "nitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" Auto" + "Min=""True"" Compass=""East""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropB" + "ag>"

      Me.c1Chart1.Size = New System.Drawing.Size(448, 400)
      Me.c1Chart1.TabIndex = 0
      Me.c1Chart1.ToolTip.Enabled = True
      ' 
      ' hScrollBar1
      ' 
      Me.hScrollBar1.Location = New System.Drawing.Point(168, 24)
      Me.hScrollBar1.Name = "hScrollBar1"
      Me.hScrollBar1.Size = New System.Drawing.Size(448, 16)
      Me.hScrollBar1.TabIndex = 1
      ' 
      ' vScrollBar1
      ' 
      Me.vScrollBar1.Location = New System.Drawing.Point(144, 40)
      Me.vScrollBar1.Name = "vScrollBar1"
      Me.vScrollBar1.Size = New System.Drawing.Size(16, 408)
      Me.vScrollBar1.TabIndex = 2
      ' 
      ' chkShow3D
      ' 
      Me.chkShow3D.Location = New System.Drawing.Point(8, 64)
      Me.chkShow3D.Name = "chkShow3D"
      Me.chkShow3D.Size = New System.Drawing.Size(112, 16)
      Me.chkShow3D.TabIndex = 3
      Me.chkShow3D.Text = "Show 3D Effects"
      ' 
      ' updnDepth
      ' 
      Me.updnDepth.Location = New System.Drawing.Point(80, 96)
      Me.updnDepth.Maximum = New System.Decimal(New Integer() {40, 0, 0, 0})
      Me.updnDepth.Minimum = New System.Decimal(New Integer() {5, 0, 0, 0})
      Me.updnDepth.Name = "updnDepth"
      Me.updnDepth.Size = New System.Drawing.Size(48, 20)
      Me.updnDepth.TabIndex = 4
      Me.updnDepth.Value = New System.Decimal(New Integer() {5, 0, 0, 0})
      ' 
      ' labDepth
      ' 
      Me.labDepth.Location = New System.Drawing.Point(8, 96)
      Me.labDepth.Name = "labDepth"
      Me.labDepth.Size = New System.Drawing.Size(56, 16)
      Me.labDepth.TabIndex = 5
      Me.labDepth.Text = "3D Depth"
      ' 
      ' labCoordInfo
      ' 
      Me.labCoordInfo.Location = New System.Drawing.Point(16, 144)
      Me.labCoordInfo.Name = "labCoordInfo"
      Me.labCoordInfo.Size = New System.Drawing.Size(112, 120)
      Me.labCoordInfo.TabIndex = 6
      Me.labCoordInfo.Text = "labCoordInfo"
      ' 
      ' chkAlpha
      ' 
      Me.chkAlpha.Location = New System.Drawing.Point(8, 32)
      Me.chkAlpha.Name = "chkAlpha"
      Me.chkAlpha.Size = New System.Drawing.Size(112, 16)
      Me.chkAlpha.TabIndex = 7
      Me.chkAlpha.Text = "Use Alpha Color"
      ' 
      ' StepChart
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkAlpha, Me.labCoordInfo, Me.labDepth, Me.updnDepth, Me.chkShow3D, Me.vScrollBar1, Me.hScrollBar1, Me.c1Chart1})
      Me.Name = "StepChart"
      Me.Text = "StepChart"
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.updnDepth, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
   End Sub 'InitializeComponent
    
#End Region
   '/ <summary>
   '/ The main entry point for the application.
   '/ </summary>
   <STAThread()>  _
   Shared    Sub Main()
      Application.Run(New StepChart())
   End Sub 'Main
   
   
   Private Function GetData() As PointF()
      Dim xa() As Double = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}
      Dim ya() As Double = {0, 1, 2, Double.NegativeInfinity, 4, 5, 6, 7, 6, 5, 4, Double.NaN, 2, 1, 0}
      Dim pda As PointF() = CType(Array.CreateInstance(GetType(PointF), xa.Length), PointF())
      pda.Initialize()
      
      Dim i As Integer
      For i = 0 To xa.Length - 1
         pda(i) = New PointF(CSng(xa(i)), CSng(ya(i)))
      Next i
      
      Return pda
   End Function 'GetData
   
   
   Private Function AdjustYValues(pfa() As PointF, factor As Single, offset As Single) As PointF()
      Dim pfa2 As PointF() = CType(Array.CreateInstance(GetType(PointF), pfa.Length), PointF())
      Dim i As Integer
      For i = 0 To pfa.Length - 1
         pfa2(i) = New PointF(pfa(i).X, pfa(i).Y * factor + offset)
      Next i 
      Return pfa2
   End Function 'AdjustYValues
   
   
   Private Sub StepChart_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' position the controls
      hScrollBar1.Location = New Point(c1Chart1.Left, 0)
      vScrollBar1.Location = New Point(c1Chart1.Left - vScrollBar1.Width, hScrollBar1.Height)
      c1Chart1.Location = New Point(hScrollBar1.Left, vScrollBar1.Top)
      
      ' set 3D effects scrollbars visibility
      Dim is3d As Boolean = chkShow3D.Checked
      vScrollBar1.Visible = is3d
      hScrollBar1.Visible = is3d
      
      ' set up the charts
      Dim cg As ChartGroup = c1Chart1.ChartGroups.Group0
      cg.Use3D = is3d
      
      ' ChartType is a Step chart.
      cg.ChartType = Chart2DTypeEnum.Step
      
      Dim cd As ChartData = cg.ChartData
      Dim cdsc As ChartDataSeriesCollection = cd.SeriesList
      cdsc.Clear() ' remove existing data.
      ' create some data using this application GetData() routine
      Dim pfa As PointF() = GetData()
      
      ' add the data to the chart
      Dim cds As ChartDataSeries = cdsc.AddNewSeries()
      cds.PointData.CopyDataIn(pfa)
      cds.LineStyle.Thickness = 3
      cds.TooltipText = "Step0"
      cds.TooltipTextLegend = "Step0 Legend"
      cds.SymbolStyle.Size = 15
      
      ' add a second series using the application AdjustYValues
      ' routine.  This data is similar to show behavior when
      ' excluding the data holes found in the first data.
      cds = cdsc.AddNewSeries()
      cds.PointData.CopyDataIn(AdjustYValues(pfa, 1F, 2F))
      cds.LineStyle.Thickness = 3
      cds.SymbolStyle.Size = 15
      cds.TooltipText = "Step1"
      cds.TooltipTextLegend = "Step1 Legend"
      cds.Display = SeriesDisplayEnum.ExcludeHoles
      
      ' set up the 3D view object and scrollbars.  When
      ' the 3D view is shown, the scrollbars can adjust
      ' the angles.
      Const initialAngles As Integer = 30
      Dim v3d As View3D = c1Chart1.ChartArea.PlotArea.View3D
      v3d.Depth = initialAngles
      v3d.Elevation = initialAngles
      v3d.Rotation = initialAngles
      
      hScrollBar1.Maximum = 45
      hScrollBar1.Minimum = - 45
      hScrollBar1.Value = - initialAngles
      
      vScrollBar1.Maximum = 45
      vScrollBar1.Minimum = - 45
      vScrollBar1.Value = initialAngles
      
      updnDepth.Value = initialAngles
      labDepth.Visible = is3d
      updnDepth.Visible = is3d
      
      ' in chart labels to label the scroll bars.
      Dim labs As C1.Win.C1Chart.LabelsCollection = c1Chart1.ChartLabels.LabelsCollection
      Dim lab As C1.Win.C1Chart.Label = labs.AddNewLabel()
      lab.AttachMethod = AttachMethodEnum.Coordinate
      lab.AttachMethodData.X = 1
      lab.AttachMethodData.Y = 1
      lab.Compass = LabelCompassEnum.SouthEast
      lab.SizeDefault = New Size(c1Chart1.Size.Width, 12)
      lab.Style.HorizontalAlignment = AlignHorzEnum.Center
      lab.Name = "hbar"
      lab.Text = "3D Rotation"
      lab.Visible = is3d
      
      lab = labs.AddNewLabel()
      lab.AttachMethod = AttachMethodEnum.Coordinate
      lab.AttachMethodData.X = 1
      lab.AttachMethodData.Y = 1
      lab.Compass = LabelCompassEnum.SouthEast
      lab.SizeDefault = New Size(12, c1Chart1.Size.Height)
      lab.Style.Rotation = RotationEnum.Rotate270
      lab.Style.HorizontalAlignment = AlignHorzEnum.Center
      lab.Name = "vbar"
      lab.Text = "3D Elevation"
      lab.Visible = is3d
      
      ' set up the Chart header
      Dim header As Title = c1Chart1.Header
      header.Style.Font = New Font("Arial Black", 16)
      header.Style.Border.BorderStyle = BorderStyleEnum.Solid
      If is3d Then
         header.Text = "3D Step Chart"
      Else
         header.Text = "2D Step Chart"
      End If 
      ' clear the position CoordInfo label
      labCoordInfo.Text = ""
      labCoordInfo.Visible = False
      
      ' force a resize to allow everything reposition.
      StepChart_Resize(Nothing, Nothing)
   End Sub 'StepChart_Load
   
   
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      Dim cg As ChartGroup = c1Chart1.ChartGroups(0)
      Dim xd As Double = 0
      Dim yd As Double = 0
      Dim si As Integer = - 1
      Dim pi As Integer = - 1
      Dim dist As Integer = - 1
      
      Dim res1 As Boolean = cg.CoordToDataCoord(e.X, e.Y, xd, yd)
      If Not res1 Then
         Return
      End If 
      cg.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, si, pi, dist)
      
      labCoordInfo.Text = "X,Y = " + xd.ToString("0.00") + " , " + yd.ToString("0.00") + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "Series = " + si.ToString() + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "Point = " + pi.ToString() + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "Distance = " + dist.ToString()
      
      If Not labCoordInfo.Visible Then
         labCoordInfo.Visible = True
      End If
   End Sub 'c1Chart1_MouseMove
    
   Private Sub StepChart_Resize(sender As Object, e As System.EventArgs) Handles MyBase.Resize
      Dim cw As Integer = ClientSize.Width - hScrollBar1.Left - 1
      Dim ch As Integer = ClientSize.Height - vScrollBar1.Top - 1
      
      If cw < 10 Then
         cw = 10
      End If
      If ch < 10 Then
         ch = 10
      End If 
      hScrollBar1.Width = cw
      vScrollBar1.Height = ch
      
      c1Chart1.Size = New Size(cw, ch)
      
      Dim labs As LabelsCollection = c1Chart1.ChartLabels.LabelsCollection
      If labs.Count > 1 Then
         If chkShow3D.Checked Then
            labs("hbar").Size = New Size(cw, 12)
            labs("vbar").Size = New Size(12, ch)
         End If
      End If 
   End Sub 'StepChart_Resize
   
   
   Private Sub vScrollBar1_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles vScrollBar1.Scroll
      c1Chart1.ChartArea.PlotArea.View3D.Elevation = e.NewValue
   End Sub 'vScrollBar1_Scroll
   
   
   Private Sub hScrollBar1_Scroll(sender As Object, e As System.Windows.Forms.ScrollEventArgs) Handles hScrollBar1.Scroll
      c1Chart1.ChartArea.PlotArea.View3D.Rotation = - e.NewValue
   End Sub 'hScrollBar1_Scroll
   
   
   Private Sub chkShow3D_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkShow3D.CheckedChanged
      Dim is3d As Boolean = chkShow3D.Checked
      c1Chart1.ChartGroups(0).Use3D = is3d
      hScrollBar1.Visible = is3d
      vScrollBar1.Visible = is3d
      labDepth.Visible = is3d
      updnDepth.Visible = is3d
      
      Dim labs As LabelsCollection = c1Chart1.ChartLabels.LabelsCollection
      If labs.Count > 0 Then
         labs("hbar").Visible = is3d
         labs("vbar").Visible = is3d
      End If
      
      ' add and remove chart margins so there is room for chart labels
      Dim area As Area = c1Chart1.ChartArea
      If is3d Then
         area.Margins.Left = 10
         area.Margins.Right = 10
         c1Chart1.Header.Text = "3D Step Chart"
      Else
         area.Margins.Left = 0
         area.Margins.Right = 0
         c1Chart1.Header.Text = "2D Step Chart"
      End If
   End Sub 'chkShow3D_CheckedChanged
   
   
   Private Sub updnDepth_ValueChanged(sender As Object, e As System.EventArgs) Handles updnDepth.ValueChanged
      c1Chart1.ChartArea.PlotArea.View3D.Depth = Convert.ToInt32(updnDepth.Value)
   End Sub 'updnDepth_ValueChanged
   
   
   Private Sub chkAlpha_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkAlpha.CheckedChanged
      Dim alpha As Integer
      
      If chkAlpha.Checked Then
         alpha = 100
      Else
         alpha = 255
      End If 
      Dim cdsc As ChartDataSeriesCollection = c1Chart1.ChartGroups(0).ChartData.SeriesList
      cdsc(0).LineStyle.Color = Color.FromArgb(alpha, cdsc(0).LineStyle.Color)
      cdsc(1).LineStyle.Color = Color.FromArgb(alpha, cdsc(1).LineStyle.Color)
   End Sub 'chkAlpha_CheckedChanged
End Class 'StepChart
