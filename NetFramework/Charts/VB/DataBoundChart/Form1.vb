
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents listBox1 As System.Windows.Forms.ListBox
   WithEvents c1Chart1 As C1.Win.C1Chart.C1Chart
   Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
   Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
   Private oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
   WithEvents oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
   WithEvents dataSet11 As DataBoundChart.DataSet1
   WithEvents oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
   WithEvents dataSet21 As DataBoundChart.DataSet2
   Private dataView1 As System.Data.DataView
   '/ <summary>
   '/ Required designer variable.
   '/ </summary>
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()
        Me.oleDbConnection1.ConnectionString = getModifiedConnectionString(Me.oleDbConnection1.ConnectionString)
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
      Me.listBox1 = New System.Windows.Forms.ListBox()
      Me.dataSet21 = New DataBoundChart.DataSet2()
      Me.c1Chart1 = New C1.Win.C1Chart.C1Chart()
      Me.dataView1 = New System.Data.DataView()
      Me.dataSet11 = New DataBoundChart.DataSet1()
      Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection()
      Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
      Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
      Me.oleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
      Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
      CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dataView1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' listBox1
      ' 
      Me.listBox1.DataSource = Me.dataSet21.Categories
      Me.listBox1.DisplayMember = "CategoryName"
      Me.listBox1.Dock = System.Windows.Forms.DockStyle.Left
      Me.listBox1.Name = "listBox1"
      Me.listBox1.Size = New System.Drawing.Size(112, 420)
      Me.listBox1.TabIndex = 0
      ' 
      ' dataSet21
      ' 
      Me.dataSet21.DataSetName = "DataSet2"
      Me.dataSet21.Locale = New System.Globalization.CultureInfo("en-US")
      Me.dataSet21.Namespace = "http://www.tempuri.org/DataSet2.xsd"
      ' 
      ' c1Chart1
      ' 
      Me.c1Chart1.DataSource = Me.dataView1
      Me.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart1.Location = New System.Drawing.Point(112, 0)
      Me.c1Chart1.Name = "c1Chart1"
      Me.c1Chart1.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Nam" + "e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" + "tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" + "/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" + "<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" + "=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" + "Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" + "me><ParentName>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle" + "><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Bo" + "rder=None,Transparent,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignV" + "ert=Center;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Ar" + "ea</ParentName><StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=C" + "enter;BackColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData></NamedSty" + "le><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.defau" + "lt</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name>" + "<ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignV" + "ert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Na" + "me><ParentName>Control</ParentName><StyleData>Border=None,Black,1;BackColor=Tran" + "sparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Cont" + "rol</ParentName><StyleData>Border=None,Black,1;Font=Arial, 14pt;</StyleData></Na" + "medStyle><NamedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeCo" + "lor=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><" + "NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=R" + "otate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;AlignVer" + "t=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>" + "Control</ParentName><StyleData>Border=None,Black,1;AlignVert=Top;</StyleData></N" + "amedStyle></StyleCollection><ChartGroupsCollection><ChartGroup><DataSerializer H" + "ole=""3.4028234663852886E+38"" DefaultSet=""True""><DataSeriesCollection><DataSeries" + "Serializer><LineStyle Thickness=""1"" Color=""DarkGoldenrod"" Pattern=""Solid"" /><Sym" + "bolStyle Color=""Coral"" OutlineColor="""" Shape=""Box"" /><SeriesLabel>UnitPrice</Ser" + "iesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Singl" + "e;Single;Double;Double;Double</DataTypes><DataFields>ProductName;UnitPrice;;;</D" + "ataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickne" + "ss=""1"" Color=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Color=""CornflowerBlue"" Ou" + "tlineColor="""" Shape=""Dot"" /><SeriesLabel>UnitsInStock</SeriesLabel><X>1;2;3;4;5<" + "/X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;" + "Double</DataTypes><DataFields>ProductName;UnitsInStock;;;</DataFields><Tag /></D" + "ataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=""1"" Color=""DarkGr" + "een"" Pattern=""Solid"" /><SymbolStyle Color=""Cornsilk"" OutlineColor="""" Shape=""Tri""" + " /><SeriesLabel>ReorderLevel</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><" + "Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataF" + "ields>ProductName;ReorderLevel;;;</DataFields><Tag /></DataSeriesSerializer></Da" + "taSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>False</Stacked><" + "ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,C" + "lusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=Fa" + "lse,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,Maxim" + "umSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Star" + "t=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visibl" + "e><ShowOutline>True</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=""" + "3.4028234663852886E+38"" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>" + "XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterW" + "idth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Sho" + "wClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=" + "20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Po" + "lar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><Show" + "Outline>True</ShowOutline></ChartGroup></ChartGroupsCollection><Header Compass=""" + "North""><Text /></Header><Footer Compass=""South""><Text /></Footer><Legend Compass" + "=""South"" Visible=""True"" Orientation=""Horizontal""><Text /></Legend><ChartArea Inv" + "erted=""True"" /><Axes><Axis Max=""5.5"" Min=""0.5"" UnitMajor=""1"" UnitMinor=""0.5"" Aut" + "oMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" TickMinor=""None"" _o" + "nTop=""0"" Compass=""West""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Color=" + """LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""Li" + "ghtGray"" Pattern=""Dash"" /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMinor=" + """0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" TickMinor=" + """None"" _onTop=""0"" Compass=""South""><Text /><GridMajor Visible=""True"" Spacing=""1"" " + "AutoSpace=""True"" Thickness=""1"" Color=""White"" Pattern=""Dot"" /><GridMinor AutoSpac" + "e=""True"" Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" M" + "in=""0"" UnitMajor=""0"" UnitMinor=""0"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""Tr" + "ue"" AutoMin=""True"" _onTop=""0"" Compass=""North""><Text /><GridMajor AutoSpace=""True" + """ Thickness=""1"" Color=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" T" + "hickness=""1"" Color=""LightGray"" Pattern=""Dash"" /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart1.Size = New System.Drawing.Size(520, 423)
      Me.c1Chart1.TabIndex = 1
      ' 
      ' dataView1
      ' 
      Me.dataView1.AllowDelete = False
      Me.dataView1.AllowEdit = False
      Me.dataView1.AllowNew = False
      Me.dataView1.Table = Me.dataSet11.Products
      ' 
      ' dataSet11
      ' 
      Me.dataSet11.DataSetName = "DataSet1"
      Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
      Me.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
      ' 
      ' oleDbConnection1
      ' 
      Me.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studio" + ".NET 2.0\Common\C1NWind.mdb;Mode=Share Deny None;"
      ' 
      ' oleDbDataAdapter1
      ' 
      Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
      Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel")})})
      ' 
      ' oleDbSelectCommand1
      ' 
      Me.oleDbSelectCommand1.CommandText = "SELECT CategoryID, ProductName, UnitPrice, UnitsInStock, ReorderLevel FROM Produc" + "ts ORDER BY UnitPrice DESC"
      Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
      ' 
      ' oleDbDataAdapter2
      ' 
      Me.oleDbDataAdapter2.SelectCommand = Me.oleDbSelectCommand2
      Me.oleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID")})})
      ' 
      ' oleDbSelectCommand2
      ' 
      Me.oleDbSelectCommand2.CommandText = "SELECT CategoryName, CategoryID FROM Categories"
      Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 423)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart1, Me.listBox1})
      Me.Name = "Form1"
      Me.Text = "C1Chart: DataBound Chart Demo"
      CType(Me.dataSet21, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1Chart1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dataView1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
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
   
    Private Function getModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.oleDbDataAdapter1.Fill(Me.dataSet11)
        Me.oleDbDataAdapter2.Fill(Me.dataSet21)

        ' force the new calculation after the refill.
        listBox1_SelectedIndexChanged(Me.listBox1, New EventArgs())
    End Sub 'Form1_Load
   
   
   Private Sub listBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles listBox1.SelectedIndexChanged
      If listBox1.SelectedIndex >= 0 Then
         Dim categoryID As String = Me.dataSet21.Categories(listBox1.SelectedIndex).CategoryID.ToString()
         Me.dataView1.RowFilter = "CategoryID = " + categoryID
         Me.c1Chart1.Header.Text = listBox1.Text
      End If
   End Sub 'listBox1_SelectedIndexChanged
End Class 'Form1
