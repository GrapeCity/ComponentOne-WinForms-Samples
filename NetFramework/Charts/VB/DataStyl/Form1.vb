
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
   Private grpChartTypes As System.Windows.Forms.GroupBox
   WithEvents radioPlot As System.Windows.Forms.RadioButton
   WithEvents radioBar As System.Windows.Forms.RadioButton
   WithEvents radioPie As System.Windows.Forms.RadioButton
   WithEvents radioHiLoOpCl As System.Windows.Forms.RadioButton
   WithEvents radioCandle As System.Windows.Forms.RadioButton
   WithEvents radioPolar As System.Windows.Forms.RadioButton
   WithEvents radioRadar As System.Windows.Forms.RadioButton
   WithEvents radioBubble As System.Windows.Forms.RadioButton
   Private mainMenu1 As System.Windows.Forms.MainMenu
   WithEvents menuItem1 As System.Windows.Forms.MenuItem
   WithEvents menuItem2 As System.Windows.Forms.MenuItem
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents menuFileExit As System.Windows.Forms.MenuItem
   WithEvents menuHelpAbout As System.Windows.Forms.MenuItem
   WithEvents radioArea As System.Windows.Forms.RadioButton
   Private grpStacking As System.Windows.Forms.GroupBox
   WithEvents checkStacked As System.Windows.Forms.CheckBox
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
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
      Me.grpChartTypes = New System.Windows.Forms.GroupBox()
      Me.radioPlot = New System.Windows.Forms.RadioButton()
      Me.radioBar = New System.Windows.Forms.RadioButton()
      Me.radioPie = New System.Windows.Forms.RadioButton()
      Me.radioArea = New System.Windows.Forms.RadioButton()
      Me.radioHiLoOpCl = New System.Windows.Forms.RadioButton()
      Me.radioCandle = New System.Windows.Forms.RadioButton()
      Me.radioPolar = New System.Windows.Forms.RadioButton()
      Me.radioRadar = New System.Windows.Forms.RadioButton()
      Me.radioBubble = New System.Windows.Forms.RadioButton()
      Me.mainMenu1 = New System.Windows.Forms.MainMenu()
      Me.menuItem1 = New System.Windows.Forms.MenuItem()
      Me.menuFileExit = New System.Windows.Forms.MenuItem()
      Me.menuItem2 = New System.Windows.Forms.MenuItem()
      Me.menuHelpAbout = New System.Windows.Forms.MenuItem()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.grpStacking = New System.Windows.Forms.GroupBox()
      Me.checkStacked = New System.Windows.Forms.CheckBox()
      Me.grpChartTypes.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpStacking.SuspendLayout()
      Me.SuspendLayout()
      ' 
      ' grpChartTypes
      ' 
      Me.grpChartTypes.Controls.AddRange(New System.Windows.Forms.Control() {Me.radioPlot, radioBar, radioPie, radioArea, radioHiLoOpCl, radioCandle, radioPolar, radioRadar, radioBubble})
      Me.grpChartTypes.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpChartTypes.Name = "grpChartTypes"
      Me.grpChartTypes.Size = New System.Drawing.Size(592, 40)
      Me.grpChartTypes.TabIndex = 0
      Me.grpChartTypes.TabStop = False
      Me.grpChartTypes.Text = "Chart Types:"
      ' 
      ' radioPlot
      ' 
      Me.radioPlot.Checked = True
      Me.radioPlot.Location = New System.Drawing.Point(8, 16)
      Me.radioPlot.Name = "radioPlot"
      Me.radioPlot.Size = New System.Drawing.Size(48, 16)
      Me.radioPlot.TabIndex = 0
      Me.radioPlot.TabStop = True
      Me.radioPlot.Text = "Plot"
      ' 
      ' radioBar
      ' 
      Me.radioBar.Location = New System.Drawing.Point(56, 16)
      Me.radioBar.Name = "radioBar"
      Me.radioBar.Size = New System.Drawing.Size(48, 16)
      Me.radioBar.TabIndex = 1
      Me.radioBar.Text = "Bar"
      ' 
      ' radioPie
      ' 
      Me.radioPie.Location = New System.Drawing.Point(104, 16)
      Me.radioPie.Name = "radioPie"
      Me.radioPie.Size = New System.Drawing.Size(40, 16)
      Me.radioPie.TabIndex = 2
      Me.radioPie.Text = "Pie"
      ' 
      ' radioArea
      ' 
      Me.radioArea.Location = New System.Drawing.Point(152, 16)
      Me.radioArea.Name = "radioArea"
      Me.radioArea.Size = New System.Drawing.Size(48, 16)
      Me.radioArea.TabIndex = 3
      Me.radioArea.Text = "Area"
      ' 
      ' radioHiLoOpCl
      ' 
      Me.radioHiLoOpCl.Location = New System.Drawing.Point(200, 16)
      Me.radioHiLoOpCl.Name = "radioHiLoOpCl"
      Me.radioHiLoOpCl.Size = New System.Drawing.Size(136, 16)
      Me.radioHiLoOpCl.TabIndex = 4
      Me.radioHiLoOpCl.Text = "High-Low-Open-Close"
      ' 
      ' radioCandle
      ' 
      Me.radioCandle.Location = New System.Drawing.Point(336, 16)
      Me.radioCandle.Name = "radioCandle"
      Me.radioCandle.Size = New System.Drawing.Size(64, 16)
      Me.radioCandle.TabIndex = 5
      Me.radioCandle.Text = "Candle"
      ' 
      ' radioPolar
      ' 
      Me.radioPolar.Location = New System.Drawing.Point(400, 16)
      Me.radioPolar.Name = "radioPolar"
      Me.radioPolar.Size = New System.Drawing.Size(56, 16)
      Me.radioPolar.TabIndex = 6
      Me.radioPolar.Text = "Polar"
      ' 
      ' radioRadar
      ' 
      Me.radioRadar.Location = New System.Drawing.Point(456, 16)
      Me.radioRadar.Name = "radioRadar"
      Me.radioRadar.Size = New System.Drawing.Size(64, 16)
      Me.radioRadar.TabIndex = 7
      Me.radioRadar.Text = "Radar"
      ' 
      ' radioBubble
      ' 
      Me.radioBubble.Location = New System.Drawing.Point(520, 16)
      Me.radioBubble.Name = "radioBubble"
      Me.radioBubble.Size = New System.Drawing.Size(64, 16)
      Me.radioBubble.TabIndex = 8
      Me.radioBubble.Text = "Bubble"
      ' 
      ' mainMenu1
      ' 
      Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1, menuItem2})
      ' 
      ' menuItem1
      ' 
      Me.menuItem1.Index = 0
      Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuFileExit})
      Me.menuItem1.Text = "File"
      ' 
      ' menuFileExit
      ' 
      Me.menuFileExit.Index = 0
      Me.menuFileExit.Text = "Exit"
      ' 
      ' menuItem2
      ' 
      Me.menuItem2.Index = 1
      Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuHelpAbout})
      Me.menuItem2.Text = "Help"
      ' 
      ' menuHelpAbout
      ' 
      Me.menuHelpAbout.Index = 0
      Me.menuHelpAbout.Text = "About"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.BackColor = System.Drawing.Color.LightSalmon
      Me.c1Chart1.Location = New System.Drawing.Point(16, 56)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><Axes><Axis Max=""5"" Min=""1"" UnitM" + "ajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMi" + "n=""True"" _onTop=""0"" Compass=""South""><GridMajor AutoSpace=""True"" Thickness=""1"" Co" + "lor=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""5" + """ UnitMinor=""2.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True" + """ _onTop=""0"" Compass=""West""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Lig" + "htGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightG" + "ray"" Pattern=""Dash"" /><Text /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMin" + "or=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0" + """ Compass=""East""><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Pat" + "tern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patter" + "n=""Dash"" /><Text /></Axis></Axes><Header Compass=""North""><Text>header text</Text" + "></Header><ChartGroupsCollection><ChartGroup><Polar>Degrees=False,PiRatioAnnotat" + "ions=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacke" + "d>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False" + ",ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble>Enc" + "odingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><Da" + "taSerializer DefaultSet=""True""><DataSeriesCollection><DataSeriesSerializer><Y>20" + ";22;19;24;25</Y><LineStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /" + "><SymbolStyle Shape=""Box"" Size=""8"" Color=""Coral"" /><SeriesLabel>0</SeriesLabel><" + "DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1>8;12;10;12;15</Y1><X" + ">1;2;3;4;5</X><Y3>16;19;15;22;18</Y3><Y2>10;16;17;15;23</Y2></DataSeriesSerializ" + "er><DataSeriesSerializer><Y>8;12;10;12;15</Y><LineStyle Thickness=""1"" Color=""Dar" + "kGray"" Pattern=""Solid"" /><SymbolStyle Shape=""Dot"" Size=""8"" Color=""CornflowerBlue" + """ /><SeriesLabel>1</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</D" + "ataTypes><Y1>10;16;17;15;23</Y1><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializ" + "er><DataSeriesSerializer><Y>10;16;17;15;23</Y><LineStyle Thickness=""1"" Color=""Da" + "rkGreen"" Pattern=""Solid"" /><SymbolStyle Shape=""Tri"" Size=""8"" Color=""DarkOliveGre" + "en"" /><SeriesLabel>2</SeriesLabel><DataTypes>Single;Single;Single;Single;Single<" + "/DataTypes><Y1 /><X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesS" + "erializer><Y>16;19;15;22;18</Y><LineStyle Thickness=""1"" Color=""DarkKhaki"" Patter" + "n=""Solid"" /><SymbolStyle Shape=""Diamond"" Size=""8"" Color=""Crimson"" /><SeriesLabel" + ">3</SeriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><" + "X>1;2;3;4;5</X><Y3 /><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataS" + "erializer><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=50</" + "Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True" + ",PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0" + "</Radar><Stacked>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True," + "FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartT" + "ype><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>G" + "roup2</Name><DataSerializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap" + "=0,ClusterWidth=50</Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGrou" + "psCollection><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName>Area<" + "/ParentName><StyleData>Border=Solid,ControlText,1;BackColor=Cornsilk;</StyleData" + "></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</ParentN" + "ame><StyleData>Border=InsetBevel,Cornsilk,3;AlignHorz=Center;BackColor=Cornsilk;" + "Font=Microsoft Sans Serif, 10pt, style=Bold;</StyleData></NamedStyle><NamedStyle" + "><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border=InsetBevel" + ",Control,3;BackColor=Gainsboro;Font=Microsoft Sans Serif, 10pt, style=Bold;</Sty" + "leData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default</Paren" + "tName><StyleData /></NamedStyle><NamedStyle><Name>Control</Name><ParentName>Cont" + "rol.default</ParentName><StyleData>BackColor=LightSalmon;</StyleData></NamedStyl" + "e><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation" + "=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;AlignVert=" + "Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Area</" + "ParentName><StyleData>Rotation=Rotate270;Border=None,Control,1;AlignHorz=Near;Ba" + "ckColor=Transparent;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>" + "LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</ParentName><Style" + "Data /></NamedStyle><NamedStyle><Name>Legend.default</Name><ParentName>Control</" + "ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData><" + "/NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Name><ParentName>Contro" + "l</ParentName><StyleData>Border=None,Control,1;BackColor=Transparent;</StyleData" + "></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Control</ParentName><St" + "yleData>Border=Inset,Gainsboro,1;AlignHorz=Center;BackColor=Gainsboro;Font=Micro" + "soft Sans Serif, 10pt, style=Bold;</StyleData></NamedStyle><NamedStyle><Name>Con" + "trol.default</Name><ParentName /><StyleData>ForeColor=ControlText;Border=None,Co" + "ntrol,1;BackColor=Control;</StyleData></NamedStyle><NamedStyle><Name>AxisY2</Nam" + "e><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;Border=None,Transpar" + "ent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</StyleData></NamedSt" + "yle><NamedStyle><Name>Area.default</Name><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Control,1;AlignVert=Top;</StyleData></NamedStyle></StyleCollecti" + "on><Footer Compass=""South""><Text>Nowhere</Text></Footer><Legend Compass=""East"" V" + "isible=""True""><Text>Series</Text></Legend><ChartArea /></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(656, 280)
      Me.c1Chart1.TabIndex = 2
      ' 
      ' grpStacking
      ' 
      Me.grpStacking.Controls.AddRange(New System.Windows.Forms.Control() {Me.checkStacked})
      Me.grpStacking.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.grpStacking.Location = New System.Drawing.Point(600, 0)
      Me.grpStacking.Name = "grpStacking"
      Me.grpStacking.Size = New System.Drawing.Size(80, 40)
      Me.grpStacking.TabIndex = 1
      Me.grpStacking.TabStop = False
      Me.grpStacking.Text = "Stacking"
      ' 
      ' checkStacked
      ' 
      Me.checkStacked.Location = New System.Drawing.Point(8, 16)
      Me.checkStacked.Name = "checkStacked"
      Me.checkStacked.Size = New System.Drawing.Size(64, 16)
      Me.checkStacked.TabIndex = 0
      Me.checkStacked.Text = "Stacked"
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(688, 361)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpStacking, c1Chart1, grpChartTypes})
      Me.Menu = Me.mainMenu1
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - DataStyle Chart Demo"
      Me.grpChartTypes.ResumeLayout(False)
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpStacking.ResumeLayout(False)
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
      ' center the form
      Me.CenterToParent()
      
      ' manage the chart position.
      c1Chart1.Top = grpChartTypes.Bottom + 1
      c1Chart1.Left = 0
      c1Chart1.Width = Me.ClientSize.Width
      c1Chart1.Height = Me.ClientSize.Height - grpChartTypes.Height
      c1Chart1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right 
      ' add the multiline header text.
      c1Chart1.Header.Text = "  Left click on the legend to change the symbols for its related series.  " + ControlChars.Lf + "  Right click on the legend to restore the original series symbol and color.  " + ControlChars.Lf + "  Middle click on the legend to toggle the series display.  " + ControlChars.Lf + "  Hover the cursor over a data point for its series and point indices.  "
      
      ' set the tag of each radio label to the type of chart desired.
      radioPlot.Tag = Chart2DTypeEnum.XYPlot
      radioBar.Tag = Chart2DTypeEnum.Bar
      radioPie.Tag = Chart2DTypeEnum.Pie
      radioArea.Tag = Chart2DTypeEnum.Area
      radioHiLoOpCl.Tag = Chart2DTypeEnum.HiLoOpenClose
      radioCandle.Tag = Chart2DTypeEnum.Candle
      radioPolar.Tag = Chart2DTypeEnum.Polar
      radioRadar.Tag = Chart2DTypeEnum.Radar
      radioBubble.Tag = Chart2DTypeEnum.Bubble
   End Sub 'Form1_Load
   
   
   Private Sub radioChartTypeChanged(sender As Object, e As System.EventArgs) Handles radioPlot.CheckedChanged, radioBar.CheckedChanged, radioPie.CheckedChanged, radioArea.CheckedChanged, radioHiLoOpCl.CheckedChanged, radioCandle.CheckedChanged, radioPolar.CheckedChanged, radioRadar.CheckedChanged, radioBubble.CheckedChanged
      Dim rb As RadioButton = CType(sender, RadioButton)
      If rb.Checked Then
         Dim ct As Chart2DTypeEnum = CType(rb.Tag, Chart2DTypeEnum)
         c1Chart1.ChartGroups(0).ChartType = ct
         
         Dim maxSeries As Integer = 10
         Dim stackable As Boolean = True
         
         ' special cases that limit the number of series shown.
         ' this allows the demo to use the same data for all charts.
         Select Case ct
            Case Chart2DTypeEnum.Pie
               stackable = False
            
            Case Chart2DTypeEnum.HiLo, Chart2DTypeEnum.Bubble
               stackable = False
               maxSeries = 2
            
            Case Chart2DTypeEnum.HiLoOpenClose, Chart2DTypeEnum.Candle
               stackable = False
               maxSeries = 1
         End Select
         
         checkStacked.Enabled = stackable
         
         Dim grp As ChartGroup = c1Chart1.ChartGroups(0)
         Dim sl As ChartDataSeriesCollection = grp.ChartData.SeriesList
         Dim slim As Integer = sl.Count
         Dim s As Integer
         For s = 0 To slim - 1
            If s < maxSeries Then
               sl(s).Display = SeriesDisplayEnum.Show
            Else
               sl(s).Display = SeriesDisplayEnum.Exclude
            End If
         Next s
      End If
   End Sub 'radioChartTypeChanged

   ' SeriesStuff is a private class to the form used to
   ' manage the rotating line and symbol data when clicking
   ' legend entries
   Private Class SeriesStuff
      Private wasSet As Boolean = False
      Private lineColor As Color = Color.Empty
      Private symbolColor As Color = Color.Empty
      Private symbolShape As SymbolShapeEnum = SymbolShapeEnum.None
      
      
      Public Sub New()
      End Sub 'New
       
      Public Shared Function Create(len As Integer) As SeriesStuff()
         Dim ss As SeriesStuff() = CType(Array.CreateInstance(GetType(SeriesStuff), len), SeriesStuff())
         Dim s As Integer
         For s = 0 To len - 1
            ss(s) = New SeriesStuff()
         Next s
         Return ss
      End Function 'Create
      
      
      Public Sub SetStuff(ser As ChartDataSeries)
         If Not wasSet Then
            lineColor = ser.LineStyle.Color
            symbolColor = ser.SymbolStyle.Color
            symbolShape = ser.SymbolStyle.Shape
            wasSet = True
         End If
      End Sub 'SetStuff
      
      
      Public Sub GetStuff(ser As ChartDataSeries)
         If wasSet Then
            ser.LineStyle.Color = lineColor
            ser.SymbolStyle.Color = symbolColor
            ser.SymbolStyle.Shape = symbolShape
         End If
      End Sub 'GetStuff
      
      
      Private Function NextColor(c As Color) As Color
         Dim c1 As Integer = c.ToArgb()
         Dim r As New Random(c1)
         c1 = r.Next(Integer.MaxValue)
         If c1 > 0 Then
            c1 = - c1
         End If
         c1 /= 256
         c = Color.FromArgb(c1)
         Return c
      End Function 'NextColor
      
      
      Private Function NextShape(ss As SymbolShapeEnum) As SymbolShapeEnum
         Dim t As Type = GetType(SymbolShapeEnum)
         Dim iss As Integer = CInt(ss) + 1
         If Not [Enum].IsDefined(t, iss) Then
            iss = 0
         End If
         Return CType(iss, SymbolShapeEnum)
      End Function 'NextShape
      
      
      Public Sub NextStuff(ser As ChartDataSeries)
         If Not wasSet Then
            SetStuff(ser)
         End If 
         ser.LineStyle.Color = NextColor(ser.LineStyle.Color)
         ser.SymbolStyle.Color = NextColor(ser.SymbolStyle.Color)
         ser.SymbolStyle.Shape = NextShape(ser.SymbolStyle.Shape)
      End Sub 'NextStuff
   End Class 'SeriesStuff
   
   Private initialSeriesStuff As SeriesStuff() = Nothing
   
   
   Private Sub CycleSeries(s As Integer)
      If initialSeriesStuff Is Nothing Then
         initialSeriesStuff = SeriesStuff.Create(4)
      End If 
      Dim ser As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(s)
      initialSeriesStuff(s).NextStuff(ser)
   End Sub 'CycleSeries
   
   
   Private Sub ResetSeries(s As Integer)
      If initialSeriesStuff Is Nothing Then
         Return
      End If 
      Dim ser As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(s)
      initialSeriesStuff(s).GetStuff(ser)
   End Sub 'ResetSeries
   
   
   Private Sub ToggleSeriesDisplay(s As Integer)
      Dim ser As ChartDataSeries = c1Chart1.ChartGroups(0).ChartData(s)
      If ser.Display.Equals(SeriesDisplayEnum.Show) Then
         ser.Display = SeriesDisplayEnum.Hide
      Else
         ser.Display = SeriesDisplayEnum.Show
      End If
   End Sub 'ToggleSeriesDisplay
    
   Private Sub c1Chart1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseUp
      Dim chart As C1Chart = CType(sender, C1Chart)
      Dim g As Integer = 0
      Dim s As Integer = - 1
      
      Dim [region] As ChartRegionEnum = chart.ChartRegionFromCoord(e.X, e.Y)
      If [region].Equals(ChartRegionEnum.Legend) Then
         Dim leg As Legend = chart.Legend
         If leg.SeriesFromCoord(e.X, e.Y, g, s) Then
            If s >= 0 Then
               If e.Button.Equals(MouseButtons.Left) Then
                  CycleSeries(s)
               ElseIf e.Button.Equals(MouseButtons.Right) Then
                  ResetSeries(s)
               ElseIf e.Button.Equals(MouseButtons.Middle) Then
                  ToggleSeriesDisplay(s)
               End If
            End If
         End If
      End If
   End Sub 'c1Chart1_MouseUp
    
   Private Sub c1Chart1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles c1Chart1.MouseMove
      Dim chart As C1Chart = CType(sender, C1Chart)
      Dim g As Integer = 0
      Dim s As Integer = - 1
      Dim p As Integer = - 1
      Dim d As Integer = - 1
      Dim grp As ChartGroup = chart.ChartGroups(g)
      
      Dim [region] As ChartRegionEnum = chart.ChartRegionFromCoord(e.X, e.Y)
      
      Dim footerText As String = "Nowhere"
      
      If [region].Equals(ChartRegionEnum.Legend) Then
         ' if in the legend, check for the series and update
         ' the footerText as appropriate
         Dim leg As Legend = chart.Legend
         If leg.SeriesFromCoord(e.X, e.Y, g, s) Then
            If s >= 0 Then
               footerText = String.Format("Series {0}", s)
            End If
         End If
      Else
         ' if it's close enough check for the series and update
         ' the footerText as appropriate
         Dim focus As CoordinateFocusEnum = CoordinateFocusEnum.XandYCoord
         Dim stacked As Boolean = grp.Stacked
         Dim minDist As Integer = 5
         
         If radioBar.Checked AndAlso Not stacked Then
            ' special case where X focus is more appropriate
            focus = CoordinateFocusEnum.XCoord
            minDist = 0
         ElseIf radioPie.Checked Or(radioBar.Checked AndAlso stacked) Then
            ' special case where minimum distance of 0 is more
            ' appropriate.
            minDist = 0
         End If
         
         If grp.CoordToDataIndex(e.X, e.Y, focus, s, p, d) Then
            If s >= 0 AndAlso p >= 0 AndAlso d <= minDist Then
               footerText = String.Format("Index({0},{1})", s, p)
            End If
         End If
      End If 
      chart.Footer.Text = footerText
   End Sub 'c1Chart1_MouseMove
   
   
   Private Sub menuHelpAbout_Click(sender As Object, e As System.EventArgs) Handles menuHelpAbout.Click
      MessageBox.Show(Me, [Text], "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
   End Sub 'menuHelpAbout_Click
   
   
   Private Sub menuFileExit_Click(sender As Object, e As System.EventArgs) Handles menuFileExit.Click
      Me.Close()
   End Sub 'menuFileExit_Click
   
   
   Private Sub checkStacked_CheckedChanged(sender As Object, e As System.EventArgs) Handles checkStacked.CheckedChanged
      Dim cb As CheckBox = CType(sender, CheckBox)
      c1Chart1.ChartGroups(0).Stacked = cb.Checked
   End Sub 'checkStacked_CheckedChanged
End Class 'Form1
