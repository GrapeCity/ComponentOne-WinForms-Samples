
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
   WithEvents comboBox1 As System.Windows.Forms.ComboBox
   Private label1 As System.Windows.Forms.Label
   Private label2 As System.Windows.Forms.Label
   WithEvents tbTooltip As System.Windows.Forms.TextBox
   Private panel1 As System.Windows.Forms.Panel
   Private label3 As System.Windows.Forms.Label
   Private label4 As System.Windows.Forms.Label
   WithEvents cbActivation As System.Windows.Forms.ComboBox
   WithEvents cbPlotElement As System.Windows.Forms.ComboBox
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
      Me.comboBox1 = New System.Windows.Forms.ComboBox()
      Me.tbTooltip = New System.Windows.Forms.TextBox()
      Me.label1 = New System.Windows.Forms.Label()
      Me.label2 = New System.Windows.Forms.Label()
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.label3 = New System.Windows.Forms.Label()
      Me.cbActivation = New System.Windows.Forms.ComboBox()
      Me.label4 = New System.Windows.Forms.Label()
      Me.cbPlotElement = New System.Windows.Forms.ComboBox()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(168, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle Name" + "=""PlotArea"" ParentName=""Area"" StyleData=""Border=Solid,ControlText,1;BackColor=Wh" + "iteSmoke;"" /><NamedStyle Name=""Legend"" ParentName=""Legend.default"" /><NamedStyle" + " Name=""Footer"" ParentName=""Control"" StyleData=""Border=Solid,RoyalBlue,2;Font=Mic" + "rosoft Sans Serif, 16pt;"" /><NamedStyle Name=""Area"" ParentName=""Area.default"" />" + "<NamedStyle Name=""Control"" ParentName=""Control.default"" StyleData=""Border=Raised" + ",Transparent,1;"" /><NamedStyle Name=""AxisX"" ParentName=""Area"" StyleData=""Rotatio" + "n=Rotate0;AlignHorz=Center;AlignVert=Bottom;"" /><NamedStyle Name=""AxisY"" ParentN" + "ame=""Area"" StyleData=""Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;"" /><Na" + "medStyle Name=""LabelStyleDefault"" ParentName=""LabelStyleDefault.default"" /><Name" + "dStyle Name=""Legend.default"" ParentName=""Control"" StyleData=""Border=None,Black,1" + ";Wrap=False;AlignVert=Top;"" /><NamedStyle Name=""LabelStyleDefault.default"" Paren" + "tName=""Control"" StyleData=""Border=None,Black,1;BackColor=Transparent;"" /><NamedS" + "tyle Name=""Header"" ParentName=""Control"" StyleData=""Border=Solid,RoyalBlue,2;Font" + "=Microsoft Sans Serif, 16pt;"" /><NamedStyle Name=""Control.default"" ParentName=""""" + " StyleData=""ForeColor=ControlText;Border=None,Black,1;BackColor=Control;"" /><Nam" + "edStyle Name=""AxisY2"" ParentName=""Area"" StyleData=""Rotation=Rotate90;AlignHorz=F" + "ar;AlignVert=Center;"" /><NamedStyle Name=""Area.default"" ParentName=""Control"" Sty" + "leData=""Border=None,Black,1;AlignVert=Top;"" /></StyleCollection><ChartGroupsColl" + "ection><ChartGroup Name=""Group1"" Use3D=""False""><DataSerializer DefaultSet=""True""" + "><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=""ForestGreen"" /><S" + "ymbolStyle Size=""7"" Color=""DarkSeaGreen"" OutlineColor=""DarkGreen"" Shape=""Box"" />" + "<SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTyp" + "es>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><F" + "illStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""RoyalB" + "lue"" /><SymbolStyle Size=""7"" Color=""CornflowerBlue"" OutlineColor=""Navy"" Shape=""D" + "ot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><Da" + "taTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFiel" + "ds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""D" + "arkViolet"" /><SymbolStyle Size=""7"" Color=""Violet"" OutlineColor=""Indigo"" Shape=""T" + "ri"" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><D" + "ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" + "lds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=""" + "Firebrick"" /><SymbolStyle Size=""7"" Color=""Pink"" OutlineColor=""DarkRed"" Shape=""Di" + "amond"" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y" + "><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Data" + "Fields><FillStyle /></DataSeriesSerializer></DataSeriesCollection></DataSerializ" + "er></ChartGroup><ChartGroup Name=""Group2""><DataSerializer /></ChartGroup></Chart" + "GroupsCollection><Header Compass=""North""><Text>Chart Header</Text></Header><Foot" + "er Compass=""South""><Text>Footer</Text></Footer><Legend Compass=""East"" Visible=""F" + "alse"" /><ChartArea /><Axes><Axis Max=""5"" Min=""1"" UnitMajor=""1"" UnitMinor=""0.5"" A" + "utoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""South""><" + "GridMajor /><GridMinor /></Axis><Axis Max=""26"" Min=""8"" UnitMajor=""2"" UnitMinor=""" + "1"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""West" + """><GridMajor /><GridMinor /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor" + "=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" Compass=""Ea" + "st""><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(464, 453)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' comboBox1
      ' 
      Me.comboBox1.BackColor = System.Drawing.SystemColors.Control
      Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.comboBox1.Items.AddRange(New Object() {"Header", "Footer", "X-axis", "Y-axis", "DataSeries"})
      Me.comboBox1.Location = New System.Drawing.Point(8, 32)
      Me.comboBox1.Name = "comboBox1"
      Me.comboBox1.Size = New System.Drawing.Size(152, 21)
      Me.comboBox1.TabIndex = 1
      ' 
      ' tbTooltip
      ' 
      Me.tbTooltip.BackColor = System.Drawing.SystemColors.Control
      Me.tbTooltip.Location = New System.Drawing.Point(8, 96)
      Me.tbTooltip.Multiline = True
      Me.tbTooltip.Name = "tbTooltip"
      Me.tbTooltip.Size = New System.Drawing.Size(152, 96)
      Me.tbTooltip.TabIndex = 2
      Me.tbTooltip.Text = ""
      ' 
      ' label1
      ' 
      Me.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label1.Location = New System.Drawing.Point(8, 8)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(152, 23)
      Me.label1.TabIndex = 3
      Me.label1.Text = "Chart element"
      Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' label2
      ' 
      Me.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label2.Location = New System.Drawing.Point(8, 72)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(152, 23)
      Me.label2.TabIndex = 4
      Me.label2.Text = "Tooltip"
      Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' panel1
      ' 
      Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.panel1.Location = New System.Drawing.Point(0, 208)
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(168, 4)
      Me.panel1.TabIndex = 5
      ' 
      ' label3
      ' 
      Me.label3.BackColor = System.Drawing.SystemColors.ControlLight
      Me.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label3.Location = New System.Drawing.Point(8, 232)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(152, 23)
      Me.label3.TabIndex = 7
      Me.label3.Text = "Activation"
      Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' cbActivation
      ' 
      Me.cbActivation.BackColor = System.Drawing.SystemColors.Control
      Me.cbActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbActivation.Items.AddRange(New Object() {"MouseOver", "MouseClick"})
      Me.cbActivation.Location = New System.Drawing.Point(8, 256)
      Me.cbActivation.Name = "cbActivation"
      Me.cbActivation.Size = New System.Drawing.Size(152, 21)
      Me.cbActivation.TabIndex = 6
      ' 
      ' label4
      ' 
      Me.label4.BackColor = System.Drawing.SystemColors.ControlLight
      Me.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.label4.Location = New System.Drawing.Point(8, 296)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(152, 23)
      Me.label4.TabIndex = 9
      Me.label4.Text = "Plot element"
      Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
      ' 
      ' cbPlotElement
      ' 
      Me.cbPlotElement.BackColor = System.Drawing.SystemColors.Control
      Me.cbPlotElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbPlotElement.Items.AddRange(New Object() {"Points", "Series"})
      Me.cbPlotElement.Location = New System.Drawing.Point(8, 320)
      Me.cbPlotElement.Name = "cbPlotElement"
      Me.cbPlotElement.Size = New System.Drawing.Size(152, 21)
      Me.cbPlotElement.TabIndex = 8
      ' 
      ' Form1
      ' 
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.label4, Me.cbPlotElement, Me.label3, Me.cbActivation, Me.panel1, Me.label2, Me.label1, Me.tbTooltip, Me.comboBox1, Me.c1Chart1})
      Me.DockPadding.Left = 168
      Me.Name = "Form1"
      Me.Text = "ComponentOne Chart.Net 2D - Chart Tooltip Demo"
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
   
   Private _canTooltipChange As Boolean = False
   Private _dstt As String = ""
   
   
   Property DataSeriesTooltipText() As String
      Get
         Return _dstt
      End Get
      Set
         If _dstt <> value Then
            _dstt = value
            
            ' Set tooltip for all series
            Dim ds As ChartDataSeries
            For Each ds In  c1Chart1.ChartGroups(0).ChartData.SeriesList
               ds.TooltipText = _dstt
            Next ds
         End If
      End Set
   End Property
    
   Private Sub comboBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles comboBox1.SelectedIndexChanged
      tbTooltip.Enabled = True
      
      Dim prev As Boolean = _canTooltipChange
      _canTooltipChange = False
      
      ' Put corresponding tootip text into textbox
      Dim s As String = comboBox1.SelectedItem.ToString()
      Select Case s
         Case "Header"
            tbTooltip.Text = c1Chart1.Header.TooltipText
         Case "Footer"
            tbTooltip.Text = c1Chart1.Footer.TooltipText
         Case "X-axis"
            tbTooltip.Text = c1Chart1.ChartArea.AxisX.TooltipText
         Case "Y-axis"
            tbTooltip.Text = c1Chart1.ChartArea.AxisY.TooltipText
         Case "DataSeries"
            If c1Chart1.ToolTip.PlotElement = PlotElementEnum.Points Then
               tbTooltip.Text = DataSeriesTooltipText
            Else
               tbTooltip.Text = "Tooltip text is changing in ShowTooltip event"
               tbTooltip.Enabled = False
            End If
         Case Else
      End Select
      
      _canTooltipChange = prev
   End Sub 'comboBox1_SelectedIndexChanged
   
   
   Private Sub tbTooltip_TextChanged(sender As Object, e As System.EventArgs) Handles tbTooltip.TextChanged
      If Not _canTooltipChange Then
         Return
      End If 
      ' Change tooltip for coresponding chart element
      Dim s As String = comboBox1.SelectedItem.ToString()
      Select Case s
         Case "Header"
            c1Chart1.Header.TooltipText = tbTooltip.Text
         Case "Footer"
            c1Chart1.Footer.TooltipText = tbTooltip.Text
         Case "X-axis"
            c1Chart1.ChartArea.AxisX.TooltipText = tbTooltip.Text
         Case "Y-axis"
            c1Chart1.ChartArea.AxisY.TooltipText = tbTooltip.Text
         Case "DataSeries"
            If c1Chart1.ToolTip.PlotElement = PlotElementEnum.Points Then
               DataSeriesTooltipText = tbTooltip.Text
            End If
         Case Else
      End Select
   End Sub 'tbTooltip_TextChanged
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' Set default tooltips
      DataSeriesTooltipText = "Series: {#TEXT}" + ControlChars.Cr + ControlChars.Lf + "x = {#XVAL}" + ControlChars.Cr + ControlChars.Lf + "y = {#YVAL}"
      c1Chart1.Header.TooltipText = "This is header tooltip." + ControlChars.Cr + ControlChars.Lf + "Second line."
      c1Chart1.Footer.TooltipText = "This is footer tooltip." + ControlChars.Cr + ControlChars.Lf + "Second line."
      
      c1Chart1.ChartArea.AxisX.TooltipText = "X-Axis"
      c1Chart1.ChartArea.AxisY.TooltipText = "Y-Axis"
      
      ' Set default values
      comboBox1.SelectedItem = "Header"
      cbActivation.SelectedItem = "MouseOver"
      cbPlotElement.SelectedItem = "Points"
      
      _canTooltipChange = True
      
      ' Enable tooltip
      c1Chart1.ToolTip.Enabled = True
   End Sub 'Form1_Load
   
   
   Private Sub c1Chart1_ShowTooltip(sender As Object, e As C1.Win.C1Chart.ShowTooltipEventArgs) Handles c1Chart1.ShowTooltip
      ' Select item in combobox
      If sender.Equals(c1Chart1.Header) Then
         comboBox1.SelectedItem = "Header"
      ElseIf sender.Equals(c1Chart1.Footer) Then
         comboBox1.SelectedItem = "Footer"
      ElseIf sender.Equals(c1Chart1.ChartArea.AxisX) Then
         comboBox1.SelectedItem = "X-axis"
      ElseIf sender.Equals(c1Chart1.ChartArea.AxisY) Then
         comboBox1.SelectedItem = "Y-axis"
      ElseIf TypeOf sender Is ChartDataSeries Then
         ' Create new tooltip text
         If c1Chart1.ToolTip.PlotElement = PlotElementEnum.Series Then
            Dim ds As ChartDataSeries = CType(sender, ChartDataSeries)
            
            Dim p As Point = Control.MousePosition
            p = c1Chart1.PointToClient(p)
            
            Dim x As Double = 0
            Dim y As Double = 0
            
            ' Callculate data coordinates
            If ds.Group.CoordToDataCoord(p.X, p.Y, x, y) Then
               e.TooltipText = String.Format("{0}" + ControlChars.Lf + "x = {1:#.##}" + ControlChars.Lf + "y = {2:#.##}", ds.Label, x, y)
            Else
               e.TooltipText = ""
            End If
         End If 
         comboBox1.SelectedItem = "DataSeries"
      End If
   End Sub 'c1Chart1_ShowTooltip
   
   
   Private Sub cbActivation_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbActivation.SelectedIndexChanged
      If cbActivation.SelectedItem.ToString() = "MouseOver" Then
         c1Chart1.ToolTip.SelectAction = SelectActionEnum.MouseOver
      Else
         c1Chart1.ToolTip.SelectAction = SelectActionEnum.Click
      End If
   End Sub 'cbActivation_SelectedIndexChanged
    
   Private Sub cbPlotElement_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbPlotElement.SelectedIndexChanged
      ' Default values
      Dim ss As SymbolShapeEnum = SymbolShapeEnum.Dot
      Dim thickness As Integer = 1
      
      If cbPlotElement.SelectedItem.ToString() = "Points" Then
         c1Chart1.ToolTip.PlotElement = PlotElementEnum.Points
      Else
         ' Hide symbols and increase thickness
         ss = SymbolShapeEnum.None
         thickness = 3
         c1Chart1.ToolTip.PlotElement = PlotElementEnum.Series
      End If
      
      ' Change appearance of series
      Dim ds As ChartDataSeries
      For Each ds In  c1Chart1.ChartGroups(0).ChartData.SeriesList
         ds.SymbolStyle.Shape = ss
         ds.LineStyle.Thickness = thickness
      Next ds
   End Sub 'cbPlotElement_SelectedIndexChanged
End Class 'Form1
