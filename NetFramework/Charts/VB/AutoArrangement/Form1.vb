
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
   WithEvents tabControl1 As System.Windows.Forms.TabControl
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents tabPage1 As System.Windows.Forms.TabPage
   WithEvents btnCreate As System.Windows.Forms.Button
   WithEvents btnArrange As System.Windows.Forms.Button
   WithEvents tabPage2 As System.Windows.Forms.TabPage
   WithEvents btnCreateLine As System.Windows.Forms.Button
   WithEvents btnArrangeLine As System.Windows.Forms.Button
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
      Me.tabControl1 = New System.Windows.Forms.TabControl()
      Me.tabPage1 = New System.Windows.Forms.TabPage()
      Me.btnArrange = New System.Windows.Forms.Button()
      Me.btnCreate = New System.Windows.Forms.Button()
      Me.tabPage2 = New System.Windows.Forms.TabPage()
      Me.btnArrangeLine = New System.Windows.Forms.Button()
      Me.btnCreateLine = New System.Windows.Forms.Button()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.tabControl1.SuspendLayout()
      Me.tabPage1.SuspendLayout()
      Me.tabPage2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' tabControl1
      ' 
      Me.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
      Me.tabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabPage1, Me.tabPage2})
      Me.tabControl1.Dock = System.Windows.Forms.DockStyle.Left
      Me.tabControl1.Name = "tabControl1"
      Me.tabControl1.SelectedIndex = 0
      Me.tabControl1.Size = New System.Drawing.Size(120, 453)
      Me.tabControl1.TabIndex = 1
      ' 
      ' tabPage1
      ' 
      Me.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.tabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnArrange, Me.btnCreate})
      Me.tabPage1.Location = New System.Drawing.Point(4, 25)
      Me.tabPage1.Name = "tabPage1"
      Me.tabPage1.Size = New System.Drawing.Size(112, 424)
      Me.tabPage1.TabIndex = 0
      Me.tabPage1.Text = "Scatter"
      ' 
      ' btnArrange
      ' 
      Me.btnArrange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnArrange.Location = New System.Drawing.Point(16, 56)
      Me.btnArrange.Name = "btnArrange"
      Me.btnArrange.TabIndex = 1
      Me.btnArrange.Text = "Arrange"
      ' 
      ' btnCreate
      ' 
      Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnCreate.Location = New System.Drawing.Point(16, 16)
      Me.btnCreate.Name = "btnCreate"
      Me.btnCreate.TabIndex = 0
      Me.btnCreate.Text = "Create"
      ' 
      ' tabPage2
      ' 
      Me.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.tabPage2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnArrangeLine, Me.btnCreateLine})
      Me.tabPage2.Location = New System.Drawing.Point(4, 25)
      Me.tabPage2.Name = "tabPage2"
      Me.tabPage2.Size = New System.Drawing.Size(112, 424)
      Me.tabPage2.TabIndex = 1
      Me.tabPage2.Text = "Line"
      ' 
      ' btnArrangeLine
      ' 
      Me.btnArrangeLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnArrangeLine.Location = New System.Drawing.Point(16, 56)
      Me.btnArrangeLine.Name = "btnArrangeLine"
      Me.btnArrangeLine.TabIndex = 2
      Me.btnArrangeLine.Text = "Arrange"
      ' 
      ' btnCreateLine
      ' 
      Me.btnCreateLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.btnCreateLine.Location = New System.Drawing.Point(16, 16)
      Me.btnCreateLine.Name = "btnCreateLine"
      Me.btnCreateLine.TabIndex = 0
      Me.btnCreateLine.Text = "Create"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.BackColor = System.Drawing.SystemColors.Control
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(120, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=Solid,ControlText,1;BackColor=Wh" + "iteSmoke;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle" + " Name=""Footer"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;"" /><Na" + "medStyle Name=""Area"" ParentName=""Area.default"" /><NamedStyle Name=""Control"" Pare" + "ntName=""Control.default"" StyleData=""Border=Solid,Black,1;Rounding=10 10 10 10;"" " + "/><NamedStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotation=Rotate0;AlignHo" + "rz=Center;AlignVert=Bottom;"" /><NamedStyle Name=""AxisY"" ParentName=""Area"" StyleD" + "ata=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><NamedStyle Name=""La" + "belStyleDefault"" ParentName=""LabelStyleDefault.default"" /><NamedStyle Name=""Lege" + "nd.default"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;Wrap=False" + ";AlignVert=Top;"" /><NamedStyle Name=""LabelStyleDefault.default"" ParentName=""Cont" + "rol"" StyleData=""Border=None,Transparent,1;BackColor=Transparent;"" /><NamedStyle " + "Name=""Header"" ParentName=""Control"" StyleData=""Border=None,Transparent,1;"" /><Nam" + "edStyle Name=""Control.default"" ParentName="""" StyleData=""ForeColor=ControlText;Bo" + "rder=None,Transparent,1;BackColor=Control;"" /><NamedStyle Name=""AxisY2"" ParentNa" + "me=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=Far;AlignVert=Center;"" /><Named" + "Style Name=""Area.default"" ParentName=""Control"" StyleData=""Border=None,Transparen" + "t,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsCollection><ChartGroup Name=" + """Group1"" Use3D=""False""><DataSerializer DefaultSet=""True""><DataSeriesCollection><" + "DataSeriesSerializer><LineStyle Color=""DarkGoldenrod"" /><SymbolStyle Color=""Cora" + "l"" Shape=""Box"" /><SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;" + "24;25</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" + ";;</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineSt" + "yle Color=""DarkGray"" /><SymbolStyle Color=""CornflowerBlue"" Shape=""Dot"" /><Series" + "Label>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><DataTypes>Singl" + "e;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle" + " /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""DarkGreen"" /><" + "SymbolStyle Color=""Cornsilk"" Shape=""Tri"" /><SeriesLabel>series 2</SeriesLabel><X" + ">1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Single;Double;Double;Double" + "</DataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><Da" + "taSeriesSerializer><LineStyle Color=""DarkKhaki"" /><SymbolStyle Color=""Crimson"" S" + "hape=""Diamond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;" + "22;18</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;" + ";;</DataFields><FillStyle /></DataSeriesSerializer></DataSeriesCollection></Data" + "Serializer></ChartGroup><ChartGroup Name=""Group2""><DataSerializer /></ChartGroup" + "></ChartGroupsCollection><Header Compass=""North"" Visible=""False"" /><Footer Compa" + "ss=""South"" /><Legend Compass=""East"" Visible=""False"" /><ChartArea><Margin Top=""0""" + " Left=""0"" Bottom=""0"" Right=""0"" /></ChartArea><Axes><Axis Max=""5"" Min=""1"" UnitMaj" + "or=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=" + """True"" Compass=""South""><SB Appearance=""Flat"" Min=""1"" Max=""5"" /><GridMajor /><Gri" + "dMinor /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""" + "True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West""><GridMajor /" + "><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor" + "=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""East""><GridMajor" + " /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(512, 453)
      Me.c1Chart1.TabIndex = 2
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, Me.tabControl1})
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Auto Label Arrangement Chart Demo"
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
   
   
   Private Sub btnCreate_Click(sender As Object, e As System.EventArgs) Handles btnCreate.Click
      Dim sz As Size = c1Chart1.ChartArea.PlotArea.Size
      Dim nseries As Integer = 35
      
      If sz.Width <> - 1 Then
         nseries = sz.Width * sz.Height / 5000
      End If 
      CreateScatterChart(nseries)
      btnArrange.Enabled = True
   End Sub 'btnCreate_Click
   
   Private _rnd As New Random()
   
   
   Function GetGradientColor(clr1 As Color, clr2 As Color, rat As Single) As Color
      Dim r As Integer = CInt(clr1.R) + CInt((CInt(clr2.R) - CInt(clr1.R)) * rat)
      Dim g As Integer = CInt(clr1.G) + CInt((CInt(clr2.G) - CInt(clr1.G)) * rat)
      Dim b As Integer = CInt(clr1.B) + CInt((CInt(clr2.B) - CInt(clr1.B)) * rat)
      
      Return Color.FromArgb(r, g, b)
   End Function 'GetGradientColor
   
   
   Sub CreateScatterChart(nseries As Integer)
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      cd.SeriesList.Clear()
      
      Dim lbls As ChartLabels = c1Chart1.ChartLabels
      lbls.LabelsCollection.Clear()
      
      Dim i As Integer
      For i = 0 To nseries - 1
         Dim ds As ChartDataSeries = cd.SeriesList.AddNewSeries()
         
         ds.X.Add(_rnd.Next(100))
         ds.Y.Add(_rnd.Next(100))
         
         ds.SymbolStyle.Color = GetGradientColor(Color.Red, Color.Blue, i /(nseries - 1F))
         ds.SymbolStyle.Shape = SymbolShapeEnum.Dot
         
         Dim lbl As C1.Win.C1Chart.Label = lbls.LabelsCollection.AddNewLabel()
         lbl.Text = ds.Label
         
         lbl.AttachMethod = AttachMethodEnum.DataIndex
         lbl.AttachMethodData.GroupIndex = 0
         lbl.AttachMethodData.SeriesIndex = i
         lbl.AttachMethodData.PointIndex = 0
         lbl.Offset = 1
         lbl.Connected = True
         lbl.Style.ForeColor = ds.SymbolStyle.Color
         lbl.Style.BackColor = Color.White
         lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid
         lbl.Visible = True
      Next i
      
      c1Chart1.ChartArea.AxisX.ScrollBar.Visible = False
      c1Chart1.ChartArea.AxisX.AutoMin = True
      c1Chart1.ChartArea.AxisX.AutoMax = True
   End Sub 'CreateScatterChart
   
   
   Private Sub btnArrange_Click(sender As Object, e As System.EventArgs) Handles btnArrange.Click
      c1Chart1.ChartLabels.AutoArrangement.Options = AutoLabelArrangementOptions.Default
      c1Chart1.ChartLabels.AutoArrangement.Method = AutoLabelArrangementMethodEnum.FindingOptimum
      
      Dim lbls As ChartLabels = c1Chart1.ChartLabels
      
      Dim lbl As C1.Win.C1Chart.Label
      For Each lbl In  lbls.LabelsCollection
         lbl.Compass = LabelCompassEnum.Auto
      Next lbl 
      btnArrange.Enabled = False
   End Sub 'btnArrange_Click
   
   
   Private Sub btnCreateLine_Click(sender As Object, e As System.EventArgs) Handles btnCreateLine.Click
      CreateLineChart(500)
   End Sub 'btnCreateLine_Click
   
   
   Sub CreateLineChart(npoints As Integer)
      Dim cd As ChartData = c1Chart1.ChartGroups(0).ChartData
      cd.SeriesList.Clear()
      
      Dim lbls As ChartLabels = c1Chart1.ChartLabels
      lbls.LabelsCollection.Clear()
      
      Dim x(npoints) As Integer
      Dim y(npoints) As Integer
      
      Dim ds As ChartDataSeries = cd.SeriesList.AddNewSeries()
      ds.SymbolStyle.Shape = SymbolShapeEnum.None
      ds.LineStyle.Color = Color.Blue
      
      Dim i As Integer
      For i = 0 To npoints - 1
         x(i) = i
         
         If i = 0 Then
            y(i) = _rnd.Next(1000)
         Else
            y(i) = y((i - 1)) +(_rnd.Next(1000) - 500) / 3
         End If 
         If i Mod 5 = 0 Then
            Dim lbl As C1.Win.C1Chart.Label = lbls.LabelsCollection.AddNewLabel()
            lbl.Text = y(i).ToString()
            
            lbl.AttachMethod = AttachMethodEnum.DataIndex
            lbl.AttachMethodData.GroupIndex = 0
            lbl.AttachMethodData.SeriesIndex = 0
            lbl.AttachMethodData.PointIndex = i
            lbl.Offset = 1
            lbl.Connected = True
            lbl.Style.ForeColor = Color.Red
            lbl.Style.BackColor = Color.White
            lbl.Style.Border.BorderStyle = BorderStyleEnum.Solid
            lbl.Visible = True
         End If
      Next i
      
      ds.X.CopyDataIn(x)
      ds.Y.CopyDataIn(y)
      
      c1Chart1.ChartArea.AxisX.ScrollBar.Min = 0
      c1Chart1.ChartArea.AxisX.ScrollBar.Max = 499
      c1Chart1.ChartArea.AxisX.ScrollBar.Visible = True
      
      btnArrangeLine.Enabled = True
   End Sub 'CreateLineChart
   
   
   Private Sub btnArrangeLine_Click(sender As Object, e As System.EventArgs) Handles btnArrangeLine.Click
      c1Chart1.ChartLabels.AutoArrangement.Method = C1.Win.C1Chart.AutoLabelArrangementMethodEnum.Decimation
      c1Chart1.ChartLabels.AutoArrangement.Options = AutoLabelArrangementOptions.Top OrElse AutoLabelArrangementOptions.TopLeft OrElse AutoLabelArrangementOptions.TopRight
      
      Dim lbls As ChartLabels = c1Chart1.ChartLabels
      
      Dim lbl As C1.Win.C1Chart.Label
      For Each lbl In  lbls.LabelsCollection
         lbl.Compass = LabelCompassEnum.Auto
      Next lbl 
      btnArrangeLine.Enabled = False
   End Sub 'btnArrangeLine_Click
   
   
   Private Sub tabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles tabControl1.SelectedIndexChanged
      If tabControl1.SelectedIndex = 0 Then
         btnCreate_Click(Nothing, EventArgs.Empty)
      ElseIf tabControl1.SelectedIndex = 1 Then
         btnCreateLine_Click(Nothing, EventArgs.Empty)
      End If
   End Sub 'tabControl1_SelectedIndexChanged
    
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      btnCreate_Click(Nothing, EventArgs.Empty)
   End Sub 'Form1_Load
End Class 'Form1
