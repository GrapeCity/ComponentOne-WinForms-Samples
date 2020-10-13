
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.ComponentModel.Design

Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private panel1 As System.Windows.Forms.Panel
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents cbChartType As System.Windows.Forms.ComboBox
   Private label4 As System.Windows.Forms.Label
   WithEvents cbStacked As System.Windows.Forms.CheckBox
   WithEvents cbUse3D As System.Windows.Forms.CheckBox
   WithEvents cbLegend As System.Windows.Forms.CheckBox
   Private ilTextures As System.Windows.Forms.ImageList
   Private panel2 As System.Windows.Forms.Panel
   WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
   Private components As System.ComponentModel.IContainer
   
   
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
      Me.components = New System.ComponentModel.Container()
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.panel1 = New System.Windows.Forms.Panel()
      Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
      Me.panel2 = New System.Windows.Forms.Panel()
      Me.cbStacked = New System.Windows.Forms.CheckBox()
      Me.cbUse3D = New System.Windows.Forms.CheckBox()
      Me.cbLegend = New System.Windows.Forms.CheckBox()
      Me.cbChartType = New System.Windows.Forms.ComboBox()
      Me.label4 = New System.Windows.Forms.Label()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.ilTextures = New System.Windows.Forms.ImageList(Me.components)
      Me.panel1.SuspendLayout()
      Me.panel2.SuspendLayout()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' panel1
      ' 
      Me.panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.propertyGrid1, panel2})
      Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
      Me.panel1.Name = "panel1"
      Me.panel1.Size = New System.Drawing.Size(200, 453)
      Me.panel1.TabIndex = 1
      ' 
      ' propertyGrid1
      ' 
      Me.propertyGrid1.CommandsVisibleIfAvailable = True
      Me.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.propertyGrid1.HelpVisible = False
      Me.propertyGrid1.LargeButtons = False
      Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar
      Me.propertyGrid1.Location = New System.Drawing.Point(0, 72)
      Me.propertyGrid1.Name = "propertyGrid1"
      Me.propertyGrid1.Size = New System.Drawing.Size(200, 381)
      Me.propertyGrid1.TabIndex = 8
      Me.propertyGrid1.Text = "propertyGrid1"
      Me.propertyGrid1.ToolbarVisible = False
      Me.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window
      Me.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText
      ' 
      ' panel2
      ' 
      Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.panel2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbStacked, cbUse3D, cbLegend, cbChartType, label4})
      Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
      Me.panel2.Name = "panel2"
      Me.panel2.Size = New System.Drawing.Size(200, 72)
      Me.panel2.TabIndex = 7
      ' 
      ' cbStacked
      ' 
      Me.cbStacked.Location = New System.Drawing.Point(8, 32)
      Me.cbStacked.Name = "cbStacked"
      Me.cbStacked.Size = New System.Drawing.Size(64, 24)
      Me.cbStacked.TabIndex = 3
      Me.cbStacked.Text = "Stacked"
      ' 
      ' cbUse3D
      ' 
      Me.cbUse3D.Location = New System.Drawing.Point(80, 32)
      Me.cbUse3D.Name = "cbUse3D"
      Me.cbUse3D.Size = New System.Drawing.Size(40, 24)
      Me.cbUse3D.TabIndex = 4
      Me.cbUse3D.Text = "3D"
      ' 
      ' cbLegend
      ' 
      Me.cbLegend.Location = New System.Drawing.Point(120, 32)
      Me.cbLegend.Name = "cbLegend"
      Me.cbLegend.Size = New System.Drawing.Size(64, 24)
      Me.cbLegend.TabIndex = 5
      Me.cbLegend.Text = "Legend"
      ' 
      ' cbChartType
      ' 
      Me.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cbChartType.Items.AddRange(New Object() {"XYPlot", "Area", "Bar", "Pie"})
      Me.cbChartType.Location = New System.Drawing.Point(80, 8)
      Me.cbChartType.Name = "cbChartType"
      Me.cbChartType.Size = New System.Drawing.Size(80, 21)
      Me.cbChartType.TabIndex = 1
      ' 
      ' label4
      ' 
      Me.label4.Location = New System.Drawing.Point(8, 8)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(64, 23)
      Me.label4.TabIndex = 2
      Me.label4.Text = "Chart type:"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(200, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><ChartGroupsCollection><ChartGrou" + "p><ShowOutline>True</ShowOutline><Bubble>EncodingMethod=Diameter,MaximumSize=20," + "MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar" + "><Stacked>False</Stacked><Radar>Degrees=True,Filled=False,Start=0</Radar><HiLoDa" + "ta>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen" + "=True</HiLoData><Name>Group1</Name><Pie>OtherOffset=0,Start=0</Pie><Visible>True" + "</Visible><DataSerializer DefaultSet=""True"" Hole=""3.4028234663852886E+38""><DataS" + "eriesCollection><DataSeriesSerializer><X>1;2;3;4;5</X><SeriesLabel>series 0</Ser" + "iesLabel><DataTypes>Single;Single;Double;Double;Double</DataTypes><Y1 /><Y2 /><Y" + "3 /><Y>20;22;19;24;25</Y><SymbolStyle Shape=""Box"" Color=""Coral"" /><LineStyle Pat" + "tern=""Solid"" Color=""DeepSkyBlue"" Thickness=""10"" /></DataSeriesSerializer><DataSe" + "riesSerializer><X>1;2;3;4;5</X><SeriesLabel>series 1</SeriesLabel><DataTypes>Sin" + "gle;Single;Double;Double;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>8;12;10;12;15</Y" + "><SymbolStyle Shape=""Dot"" Color=""CornflowerBlue"" /><LineStyle Pattern=""Solid"" Co" + "lor=""RoyalBlue"" Thickness=""10"" /></DataSeriesSerializer><DataSeriesSerializer><X" + ">1;2;3;4;5</X><SeriesLabel>series 2</SeriesLabel><DataTypes>Single;Single;Double" + ";Double;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>10;16;17;15;23</Y><SymbolStyle Sh" + "ape=""Tri"" Color=""Cornsilk"" /><LineStyle Pattern=""Solid"" Color=""MidnightBlue"" Thi" + "ckness=""10"" /></DataSeriesSerializer><DataSeriesSerializer FitType=""Spline""><X>1" + ";2;3;4;5</X><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;Single;Double;D" + "ouble;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>16;19;15;22;18</Y><SymbolStyle Shap" + "e=""Diamond"" Color=""Crimson"" /><LineStyle Pattern=""Solid"" Color=""LightSteelBlue"" " + "Thickness=""10"" /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" + "<Use3D>False</Use3D><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWi" + "dth=50</Bar></ChartGroup><ChartGroup><ShowOutline>True</ShowOutline><Bubble>Enco" + "dingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiR" + "atioAnnotations=True,Start=0</Polar><Stacked>False</Stacked><Radar>Degrees=True," + "Filled=False,Start=0</Radar><HiLoData>FillFalling=True,FillTransparent=True,Full" + "Width=False,ShowClose=True,ShowOpen=True</HiLoData><Name>Group2</Name><Pie>Other" + "Offset=0,Start=0</Pie><Visible>True</Visible><DataSerializer Hole=""3.40282346638" + "52886E+38"" /><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50<" + "/Bar></ChartGroup></ChartGroupsCollection><Header Compass=""North"" Visible=""False" + """><Text /></Header><Axes><Axis Compass=""South"" _onTop=""0"" Min=""1"" UnitMajor=""1"" " + "Max=""5"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin" + "=""True""><GridMajor AutoSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""" + "1"" /><GridMinor AutoSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""1"" " + "/><Text /></Axis><Axis Compass=""West"" _onTop=""0"" Min=""8"" UnitMajor=""1"" Max=""25"" " + "UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"">" + "<GridMajor AutoSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""1"" /><Gr" + "idMinor AutoSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""1"" /><Text " + "/></Axis><Axis Compass=""East"" _onTop=""0"" Min=""0"" UnitMajor=""0"" Max=""0"" UnitMinor" + "=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True""><GridMajor " + "AutoSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""1"" /><GridMinor Aut" + "oSpace=""True"" Pattern=""Dash"" Color=""LightGray"" Thickness=""1"" /><Text /></Axis></" + "Axes><Footer Compass=""South"" Visible=""False""><Text /></Footer><Legend Orientatio" + "n=""Auto"" Compass=""East"" Visible=""False""><Text /></Legend><ChartArea Rotation=""45" + """ Depth=""25"" Elevation=""45"" /><StyleCollection><NamedStyle><StyleData>Border=Sol" + "id,ControlText,1;</StyleData><Name>PlotArea</Name><ParentName>Area</ParentName><" + "/NamedStyle><NamedStyle><StyleData /><Name>Legend</Name><ParentName>Legend.defau" + "lt</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;</Style" + "Data><Name>Footer</Name><ParentName>Control</ParentName></NamedStyle><NamedStyle" + "><StyleData /><Name>Area</Name><ParentName>Area.default</ParentName></NamedStyle" + "><NamedStyle><StyleData>Border=Solid,ControlText,1;</StyleData><Name>Control</Na" + "me><ParentName>Control.default</ParentName></NamedStyle><NamedStyle><StyleData>R" + "otation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;Opa" + "que=False;AlignVert=Bottom;</StyleData><Name>AxisX</Name><ParentName>Area</Paren" + "tName></NamedStyle><NamedStyle><StyleData>Rotation=Rotate270;Border=None,Control" + ",1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleDat" + "a><Name>AxisY</Name><ParentName>Area</ParentName></NamedStyle><NamedStyle><Style" + "Data /><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</Pare" + "ntName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;Wrap=False;Alig" + "nVert=Top;</StyleData><Name>Legend.default</Name><ParentName>Control</ParentName" + "></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;BackColor=Transparent" + ";</StyleData><Name>LabelStyleDefault.default</Name><ParentName>Control</ParentNa" + "me></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;</StyleData><Name>H" + "eader</Name><ParentName>Control</ParentName></NamedStyle><NamedStyle><StyleData>" + "ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</StyleData><Name>" + "Control.default</Name><ParentName /></NamedStyle><NamedStyle><StyleData>Rotation" + "=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVer" + "t=Center;</StyleData><Name>AxisY2</Name><ParentName>Area</ParentName></NamedStyl" + "e><NamedStyle><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData><Name>A" + "rea.default</Name><ParentName>Control</ParentName></NamedStyle></StyleCollection" + "></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(432, 453)
      Me.c1Chart1.TabIndex = 2
      ' 
      ' ilTextures
      ' 
      Me.ilTextures.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
      Me.ilTextures.ImageSize = New System.Drawing.Size(12, 12)
      Me.ilTextures.ImageStream = CType(resources.GetObject("ilTextures.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ilTextures.TransparentColor = System.Drawing.Color.Green
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 453)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, panel1})
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "ComponentOne Chart for .NET 2D - CustomBrushes Chart Demo"
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
   
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      
      cbChartType.Text = "XYPlot"
      
      m_serData = New SeriesData(c1Chart1, ilTextures)
      propertyGrid1.SelectedObject = m_serData
      propertyGrid1.ExpandAllGridItems()
   End Sub 'Form1_Load
   
   
   Private Sub c1Chart1_DrawDataSeries(sender As Object, e As C1.Win.C1Chart.DrawDataSeriesEventArgs) Handles c1Chart1.DrawDataSeries
      Dim serInfo As SeriesInfo = m_serData.SeriesArray(e.SeriesIndex)
      
      Select Case serInfo.BrushType
         Case BrushType.Hatch
            Dim hb As New HatchBrush(serInfo.HatchStyle, serInfo.Color2, serInfo.Color1)
            e.Brush = hb
         Case BrushType.Gradient
            Dim r As RectangleF = e.Bounds
            Dim pt1 As PointF = PointF.Empty
            Dim pt2 As PointF = PointF.Empty
            Dim blend As Boolean = False
            
            Select Case serInfo.GradientStyle
               Case GradientStyle.Horizontal1, GradientStyle.Horizontal2
                  pt1 = r.Location
                  pt2 = pt1
                  pt2.X += r.Width
                  If serInfo.GradientStyle = GradientStyle.Horizontal2 Then
                     blend = True
                  End If
               Case GradientStyle.Vertical1, GradientStyle.Vertical2
                  pt1 = r.Location
                  pt2 = pt1
                  pt2.Y += r.Height
                  If serInfo.GradientStyle = GradientStyle.Vertical2 Then
                     blend = True
                  End If
               Case GradientStyle.Diagonal1, GradientStyle.Diagonal2
                  pt1 = r.Location
                  pt2 = pt1
                  pt2.X += r.Width
                  pt2.Y += r.Height
                  If serInfo.GradientStyle = GradientStyle.Diagonal2 Then
                     blend = True
                  End If
               Case GradientStyle.BackDiagonal1, GradientStyle.BackDiagonal2
                  pt1 = r.Location
                  pt2 = pt1
                  pt2.X += r.Width
                  pt1.Y += r.Height
                  If serInfo.GradientStyle = GradientStyle.BackDiagonal2 Then
                     blend = True
                  End If
               Case GradientStyle.Radial1, GradientStyle.Radial2
                  Dim path As New GraphicsPath()
                  If c1Chart1.ChartGroups(0).ChartType = Chart2DTypeEnum.Pie Then
                     path.AddEllipse(e.Bounds)
                  Else
                     path.AddRectangle(e.Bounds)
                  End If 
                  Dim pb As New PathGradientBrush(path)
                  pb.CenterColor = serInfo.Color2
                  pb.CenterPoint = New PointF(e.Bounds.X + e.Bounds.Width / 2, e.Bounds.Y + e.Bounds.Height / 2)
                  pb.SurroundColors = New Color() {serInfo.Color1}
                  If serInfo.GradientStyle = GradientStyle.Radial2 Then
                     Dim cb As New ColorBlend()
                     cb.Colors = New Color() {serInfo.Color1, serInfo.Color2, serInfo.Color1}
                     cb.Positions = New Single() {0, 0.5F, 1F}
                     pb.InterpolationColors = cb
                  End If
                  e.Brush = pb
                  path.Dispose()
            End Select
            
            If Not pt1.IsEmpty AndAlso Not pt2.IsEmpty Then
               Dim gb As New LinearGradientBrush(pt1, pt2, serInfo.Color1, serInfo.Color2)
               If blend Then
                  Dim cb As New ColorBlend()
                  cb.Colors = New Color() {serInfo.Color1, serInfo.Color2, serInfo.Color1}
                  cb.Positions = New Single() {0, 0.5F, 1F}
                  gb.InterpolationColors = cb
               End If
               e.Brush = gb
            End If
         Case BrushType.Texture
            If Not (serInfo.Image Is Nothing) Then
               Dim tb As New TextureBrush(serInfo.Image, WrapMode.Tile)
               e.Brush = tb
            End If
      End Select
   End Sub 'c1Chart1_DrawDataSeries
   
   Private hatchStyles() As HatchStyle = {HatchStyle.Cross, HatchStyle.Horizontal, HatchStyle.Vertical, HatchStyle.Percent10}
   Private m_serData As SeriesData = Nothing
   
   
   Private Sub cbChartType_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cbChartType.SelectedIndexChanged
      c1Chart1.ChartGroups(0).ChartType = CType([Enum].Parse(GetType(Chart2DTypeEnum), cbChartType.Text), Chart2DTypeEnum)
   End Sub 'cbChartType_SelectedIndexChanged
   
   
   Private Sub tabControl1_SelectedIndexChanged(sender As Object, e As System.EventArgs)
      c1Chart1.Invalidate()
   End Sub 'tabControl1_SelectedIndexChanged
   
   
   Private Sub cbStacked_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbStacked.CheckedChanged
      c1Chart1.ChartGroups(0).Stacked = cbStacked.Checked
   End Sub 'cbStacked_CheckedChanged
   
   
   Private Sub cbUse3D_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbUse3D.CheckedChanged
      c1Chart1.ChartGroups(0).Use3D = cbUse3D.Checked
   End Sub 'cbUse3D_CheckedChanged
   
   
   Private Sub cbLegend_CheckedChanged(sender As Object, e As System.EventArgs) Handles cbLegend.CheckedChanged
      c1Chart1.Legend.Visible = cbLegend.Checked
   End Sub 'cbLegend_CheckedChanged
   
   
   Private Sub cbGradientType_SelectedIndexChanged(sender As Object, e As System.EventArgs)
      c1Chart1.Invalidate()
   End Sub 'cbGradientType_SelectedIndexChanged
   
   
   Private Sub propertyGrid1_PropertyValueChanged(s As Object, e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles propertyGrid1.PropertyValueChanged
      c1Chart1.Invalidate()
   End Sub 'propertyGrid1_PropertyValueChanged
End Class 'Form1


Enum BrushType
   Hatch
   Gradient
   Texture
End Enum 'BrushType


Enum GradientStyle
   Horizontal1
   Horizontal2
   Vertical1
   Vertical2
   Diagonal1
   Diagonal2
   BackDiagonal1
   BackDiagonal2
   Radial1
   Radial2
End Enum 'GradientStyle


Friend Class SeriesInfoConverter
   Inherits ExpandableObjectConverter
   Private Shared hatchProps As String = "BrushType Color1 Color2 HatchStyle"
   Private Shared gradProps As String = "BrushType Color1 Color2 GradientStyle"
   Private Shared textProps As String = "BrushType Image"
   
   
   Public Overloads Overrides Function GetProperties(context As ITypeDescriptorContext, value As Object, attrs() As System.Attribute) As PropertyDescriptorCollection 
      If Not (context Is Nothing) AndAlso Not (attrs Is Nothing) Then
         Dim browse As Boolean = False
         
         Dim attr As Attribute
         For Each attr In  attrs
            If TypeOf attr Is BrowsableAttribute Then
               Dim ba As BrowsableAttribute = CType(attr, BrowsableAttribute)
               If ba.Browsable Then
                  browse = True
                  Exit For
               End If
            End If
         Next attr
         
         If browse Then
            Dim si As SeriesInfo = Nothing
            If TypeOf value Is SeriesInfo Then
               si = CType(value, SeriesInfo)
               If Not (si Is Nothing) Then
                  Dim pdcnew As New PropertyDescriptorCollection(Nothing)
                  Dim pdc As PropertyDescriptorCollection = TypeDescriptor.GetProperties(value, attrs)
                  
                  Dim pd As PropertyDescriptor
                  For Each pd In  pdc
                     Select Case si.BrushType
                        Case BrushType.Hatch
                           If hatchProps.IndexOf(pd.Name) <> - 1 Then
                              pdcnew.Add(pd)
                           End If
                        Case BrushType.Gradient
                           If gradProps.IndexOf(pd.Name) <> - 1 Then
                              pdcnew.Add(pd)
                           End If
                        Case BrushType.Texture
                           If textProps.IndexOf(pd.Name) <> - 1 Then
                              pdcnew.Add(pd)
                           End If
                     End Select
                  Next pd
                  
                  Return pdcnew
               End If
            End If
         End If
      End If
      Return MyBase.GetProperties(context, value, attrs)
   End Function 'GetProperties
   
   
   Public Overloads Overrides Function GetPropertiesSupported(context As ITypeDescriptorContext) As Boolean 
      Return True
   End Function 'GetPropertiesSupported
End Class 'SeriesInfoConverter

<TypeConverter(GetType(SeriesInfoConverter))>  _
Class SeriesInfo
   Private m_brushType As BrushType = BrushType.Hatch
   Private m_color1 As Color = Color.Empty
   Private m_color2 As Color = Color.Empty
   Private m_hatch As HatchStyle = HatchStyle.Vertical
   Private m_img As Image = Nothing
   Private m_gradient As GradientStyle = GradientStyle.Horizontal1
   Private m_ser As ChartDataSeries = Nothing
   
   
   Public Sub New(ds As ChartDataSeries, img As Image)
      m_ser = ds
      m_color1 = m_ser.LineStyle.Color
      m_color2 = Color.Black
      If Not (img Is Nothing) Then
         m_img = CType(img.Clone(), Image)
         Dim g As Graphics = Graphics.FromImage(m_img)
         g.Clear(m_color1)
         g.DrawImage(img, 0, 0)
         g.Dispose()
      End If
   End Sub 'New
   <RefreshProperties(RefreshProperties.All)>  _
   Public Property BrushType() As BrushType
      Get
         Return m_brushType
      End Get
      Set
         m_brushType = value
      End Set
   End Property 
   
   Public Property Color1() As Color
      Get
         Return m_color1
      End Get
      Set
         m_color1 = value
         If Not (m_ser Is Nothing) Then
            m_ser.LineStyle.Color = m_color1
         End If
      End Set
   End Property 
   
   Public Property Color2() As Color
      Get
         Return m_color2
      End Get
      Set
         m_color2 = value
      End Set
   End Property 
   
   Public Property GradientStyle() As GradientStyle
      Get
         Return m_gradient
      End Get
      Set
         m_gradient = value
      End Set
   End Property 
   
   Public Property HatchStyle() As HatchStyle
      Get
         Return m_hatch
      End Get
      Set
         m_hatch = value
      End Set
   End Property 
   
   Public Property Image() As Image
      Get
         Return m_img
      End Get
      Set
         m_img = value
      End Set
   End Property
End Class 'SeriesInfo

Class SeriesData
   Private m_sers As SeriesInfo() = Nothing
   
   
   Public Sub New(chart As C1Chart, images As ImageList)
      Dim sc As ChartDataSeriesCollection = chart.ChartGroups(0).ChartData.SeriesList
      m_sers = CType(Array.CreateInstance(GetType(SeriesInfo), sc.Count), SeriesInfo())
      Dim i As Integer
      For i = 0 To sc.Count - 1
         Dim img As Image = Nothing
         If i < images.Images.Count Then
            img = images.Images(i)
         End If
         m_sers(i) = New SeriesInfo(sc(i), img)
      Next i
   End Sub 'New
   <Browsable(False)>  _
   Public ReadOnly Property SeriesArray() As SeriesInfo()
      Get
         Return m_sers
      End Get
   End Property
   <Category("Appearance")>  _
   Public ReadOnly Property Series0() As SeriesInfo
      Get
         Return m_sers(0)
      End Get
   End Property
   <Category("Appearance")>  _
   Public ReadOnly Property Series1() As SeriesInfo
      Get
         Return m_sers(1)
      End Get
   End Property
   <Category("Appearance")>  _
   Public ReadOnly Property Series2() As SeriesInfo
      Get
         Return m_sers(2)
      End Get
   End Property
   <Category("Appearance")>  _
   Public ReadOnly Property Series3() As SeriesInfo
      Get
         Return m_sers(3)
      End Get
   End Property
End Class 'SeriesData
