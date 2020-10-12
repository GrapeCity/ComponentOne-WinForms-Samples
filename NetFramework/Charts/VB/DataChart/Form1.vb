
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports C1.Win.C1Chart



Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   WithEvents lstCategories As System.Windows.Forms.ListBox
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
      Me.lstCategories = New System.Windows.Forms.ListBox()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Nothing
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(112, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Nam" + "e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" + "tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" + "/ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName" + ">Control</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Na" + "medStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Na" + "medStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName" + "><StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</Paren" + "tName><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;Bac" + "kColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><Named" + "Style><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0" + ";Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;A" + "lignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Na" + "me><ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><" + "NamedStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData" + ">Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedSty" + "le><Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedSty" + "le><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Bla" + "ck,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</Sty" + "leData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName>" + "<StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor" + "=Transparent;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.defau" + "lt</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;AlignVer" + "t=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><ChartGr" + "oup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><DataSeriesC" + "ollection><DataSeriesSerializer><LineStyle Thickness=""1"" Color=""DarkGoldenrod"" P" + "attern=""Solid"" /><SymbolStyle Color=""Coral"" OutlineColor="""" Shape=""Box"" /><Serie" + "sLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y" + "3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</D" + "ataFields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" + "<Name>Group1</Name><Stacked>False</Stacked><ChartType>Bar</ChartType><Pie>OtherO" + "ffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFa" + "lling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</Hi" + "LoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Pol" + "ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" + "d=False,Start=0</Radar><Use3D>False</Use3D><Visible>True</Visible><ShowOutline>T" + "rue</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=""3.40282346638528" + "86E+38"" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartTyp" + "e><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Hi" + "LoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Show" + "Open=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5" + "</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degre" + "es=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Sh" + "owOutline></ChartGroup></ChartGroupsCollection><Header Compass=""North""><Text /><" + "/Header><Footer Compass=""South""><Text /></Footer><Legend Compass=""East"" Visible=" + """False""><Text /></Legend><ChartArea Inverted=""True"" /><Axes><Axis Max=""5.5"" Min=" + """0.5"" UnitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""T" + "rue"" AutoMin=""True"" _onTop=""0"" Compass=""West""><Text /><GridMajor AutoSpace=""True" + """ Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" T" + "hickness=""1"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""25"" Min=""19"" U" + "nitMajor=""1"" UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" Au" + "toMin=""True"" _onTop=""0"" Compass=""South""><Text /><GridMajor AutoSpace=""True"" Thic" + "kness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickne" + "ss=""1"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor" + "=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""Tru" + "e"" _onTop=""0"" Compass=""North""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" " + "Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Col" + "or=""LightGray"" Pattern=""Dash"" /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(520, 423)
      Me.c1Chart1.TabIndex = 0
      ' 
      ' lstCategories
      ' 
      Me.lstCategories.Dock = System.Windows.Forms.DockStyle.Left
      Me.lstCategories.IntegralHeight = False
      Me.lstCategories.Name = "lstCategories"
      Me.lstCategories.Size = New System.Drawing.Size(112, 423)
      Me.lstCategories.TabIndex = 1
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 423)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, Me.lstCategories})
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "C1Chart: Data Demo"
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
   
   Private _dtCat, _dtPrd As DataTable
   
   Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
      ' load data (categories and products)
      Dim dbdir As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
      Dim conn As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbdir + "\C1NWind.mdb;"
      
      Dim daCat As New OleDbDataAdapter("select * from Categories", conn)
      _dtCat = New DataTable("Categories")
      daCat.Fill(_dtCat)
      
      Dim daPrd As New OleDbDataAdapter("select * from Products", conn)
      _dtPrd = New DataTable("Products")
      daPrd.Fill(_dtPrd)
      
      ' initialize chart
      c1Chart1.Header.Style.Font = New Font("Arial", 14)
      c1Chart1.Legend.Visible = True
      c1Chart1.Legend.Compass = CompassEnum.South
      Dim ax As Axis = c1Chart1.ChartArea.AxisX
      ax.TickMinor = TickMarksEnum.None
      Dim ay As Axis = c1Chart1.ChartArea.AxisY
      ay.TickMinor = TickMarksEnum.None
      ay.GridMajor.Visible = True
      ay.GridMajor.Color = Color.White
      ay.GridMajor.Pattern = LinePatternEnum.Dot
      
      ' populate categories list
      Dim dr As DataRow
      For Each dr In  _dtCat.Rows
         lstCategories.Items.Add(dr("CategoryName").ToString())
      Next dr 
      ' select first category (will update the chart)
      lstCategories.SelectedIndex = 0
   End Sub 'Form1_Load
   
   
   ' update chart when the selected category changes
   Private Sub lstCategories_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstCategories.SelectedIndexChanged
      ' find selected categoryID
      Dim catID As Integer = - 1
      Dim catName As String = lstCategories.SelectedItem.ToString()
      Dim dr As DataRow
      For Each dr In  _dtCat.Rows
         If dr("CategoryName").ToString() = catName Then
            catID = Integer.Parse(dr("CategoryID").ToString())
            Exit For
         End If
      Next dr
      
      ' apply filter to data table
      Dim dv As DataView = _dtPrd.DefaultView
      dv.RowFilter = String.Format("CategoryID = {0}", catID)
      
      ' sort by unit price
      dv.Sort = "UnitPrice DESC"
      
      ' copy data from table to chart
      c1Chart1.Header.Text = lstCategories.SelectedItem.ToString()
      BindSeries(c1Chart1, 0, dv, "UnitPrice", "ProductName")
      BindSeries(c1Chart1, 1, dv, "UnitsInStock")
      BindSeries(c1Chart1, 2, dv, "ReorderLevel")
   End Sub 'lstCategories_SelectedIndexChanged
   
   
   ' copy data from a data source to the chart
   ' c1c          chart
   ' series       index of the series to bind (0-based, will add if necessary)
   ' datasource   datasource object (cannot be DataTable, DataView is OK)
   ' field        name of the field that contains the y values
   ' labels       name of the field that contains the x labels
   Overloads Private Sub BindSeries(c1c As C1Chart, series As Integer, dataSource As Object, field As String, labels As String)
      ' check data source object
      Dim il As ITypedList = CType(dataSource, ITypedList)
      Dim list As IList = CType(dataSource, IList)
      If list Is Nothing OrElse il Is Nothing Then
         Throw New ApplicationException("Invalid DataSource object.")
      End If 
      ' add series if necessary
      Dim coll As ChartDataSeriesCollection = c1c.ChartGroups(0).ChartData.SeriesList
      While series >= coll.Count
         coll.AddNewSeries()
      End While 
      ' copy series data
      If list.Count = 0 Then
         Return
      End If
      Dim data As PointF() = CType(Array.CreateInstance(GetType(PointF), list.Count), PointF())
      Dim pdc As PropertyDescriptorCollection = il.GetItemProperties(Nothing)
      Dim pd As PropertyDescriptor = pdc(field)
      If pd Is Nothing Then
         Throw New ApplicationException(String.Format("Invalid field name used for Y values ({0}).", field))
      End If 
      Dim i As Integer
      For i = 0 To list.Count - 1
         data(i).X = i
         Try
            data(i).Y = Single.Parse(pd.GetValue(list(i)).ToString())
         Catch
            data(i).Y = Single.NaN
         End Try
         coll(series).PointData.CopyDataIn(data)
         coll(series).Label = field
      Next i
      
      ' copy series labels
      If Not (labels Is Nothing) AndAlso labels.Length > 0 Then
         pd = pdc(labels)
         If pd Is Nothing Then
            Throw New ApplicationException(String.Format("Invalid field name used for X values ({0}).", labels))
         End If
         Dim ax As Axis = c1c.ChartArea.AxisX
         ax.ValueLabels.Clear()
         For i = 0 To list.Count - 1
            Dim label As String = pd.GetValue(list(i)).ToString()
            ax.ValueLabels.Add(i, label)
         Next i
         ax.AnnoMethod = AnnotationMethodEnum.ValueLabels
      End If
   End Sub 'BindSeries
   
   Overloads Private Sub BindSeries(c1c As C1Chart, series As Integer, dataSource As Object, field As String)
      BindSeries(c1c, series, dataSource, field, Nothing)
   End Sub 'BindSeries
End Class 'Form1
