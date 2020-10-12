
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports C1.Data
Imports C1.Data.Express
Imports C1.Win.C1Chart



'/ <summary>
'/ Summary description for Form1.
'/ </summary>
Public Class Form1
   Inherits System.Windows.Forms.Form
   WithEvents lstCategories As System.Windows.Forms.ListBox
   WithEvents c1xProducts As C1.Data.Express.C1ExpressTable
   WithEvents c1xCategories As C1.Data.Express.C1ExpressTable
   WithEvents c1Chart As C1.Win.C1Chart.C1Chart
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()

        Me.c1xProducts.ConnectionString = getModifiedConnectionString(Me.c1xProducts.ConnectionString)
        Me.c1xProducts.SerializedSchemaXML = getModifiedConnectionString(Me.c1xProducts.SerializedSchemaXML)
        Me.c1xCategories.ConnectionString = getModifiedConnectionString(Me.c1xCategories.ConnectionString)
        Me.c1xCategories.SerializedSchemaXML = getModifiedConnectionString(Me.c1xCategories.SerializedSchemaXML)

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
      Dim resources As New System.Resources.ResourceManager(GetType(Form1))
      Me.lstCategories = New System.Windows.Forms.ListBox()
      Me.c1xProducts = New C1.Data.Express.C1ExpressTable()
      Me.c1xCategories = New C1.Data.Express.C1ExpressTable()
      Me.c1Chart = New C1.Win.C1Chart.C1Chart()
      CType(Me.c1xProducts, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1xCategories, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.c1Chart, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      ' 
      ' lstCategories
      ' 
      Me.lstCategories.Dock = System.Windows.Forms.DockStyle.Left
      Me.lstCategories.IntegralHeight = False
      Me.lstCategories.Name = "lstCategories"
      Me.lstCategories.Size = New System.Drawing.Size(112, 423)
      Me.lstCategories.TabIndex = 1
      ' 
      ' c1xProducts
      ' 
      Me.c1xProducts.BindingContextCtrl = Me
      Me.c1xProducts.ConnectionComponent = Nothing
      Me.c1xProducts.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\C1NWind.mdb;"
      Me.c1xProducts.FullComponentName = "Form1.c1xProducts"
      Me.c1xProducts.SchemaTableName = "Products"
      Me.c1xProducts.SerializedSchemaXML = "VERSION98:<?xml version=""1.0""?><Schema><DataSetDefs><DataSetDef Name=""DataSetDef_" + "1""><CacheProperties /><FieldDefaults /><TableViews><TableView Name=""Products"" Ta" + "bleName=""Products""><Fields><TableViewField TableFieldName=""CategoryID"" Name=""Cat" + "egoryID"" DataType=""Int32"" AllowDbNull=""false"" /><TableViewField TableFieldName=""" + "Discontinued"" Name=""Discontinued"" DataType=""Boolean"" MaxLength=""2"" /><TableViewF" + "ield TableFieldName=""ProductID"" PrimaryKey=""true"" Name=""ProductID"" DataType=""Int" + "32"" /><TableViewField TableFieldName=""ProductName"" Name=""ProductName"" DataType=""" + "String"" MaxLength=""40"" /><TableViewField TableFieldName=""QuantityPerUnit"" Name=""" + "QuantityPerUnit"" DataType=""String"" MaxLength=""20"" /><TableViewField TableFieldNa" + "me=""ReorderLevel"" Name=""ReorderLevel"" DataType=""Int16"" /><TableViewField TableFi" + "eldName=""SupplierID"" Name=""SupplierID"" DataType=""Int32"" /><TableViewField TableF" + "ieldName=""UnitPrice"" Name=""UnitPrice"" DataType=""Decimal"" /><TableViewField Table" + "FieldName=""UnitsInStock"" Name=""UnitsInStock"" DataType=""Int16"" /><TableViewField " + "TableFieldName=""UnitsOnOrder"" Name=""UnitsOnOrder"" DataType=""Int16"" /></Fields></" + "TableView></TableViews></DataSetDef></DataSetDefs><Tables><dbtable ConnectionNam" + "e=""Connection_1"" DbTableName=""Products"" Name=""Products""><Fields><dbtable DbField" + "Name=""CategoryID"" AllowDbNull=""false"" Name=""CategoryID"" DataType=""Int32"" NativeD" + "bType=""3"" /><dbtable DbFieldName=""Discontinued"" AllowDbNull=""false"" Name=""Discon" + "tinued"" DataType=""Boolean"" NativeDbType=""11"" MaxLength=""2"" /><dbtable DbFieldNam" + "e=""ProductID"" PrimaryKey=""true"" AllowDbNull=""false"" Name=""ProductID"" DataType=""I" + "nt32"" NativeDbType=""3"" /><dbtable DbFieldName=""ProductName"" AllowDbNull=""false"" " + "Name=""ProductName"" DataType=""String"" NativeDbType=""130"" MaxLength=""40"" /><dbtabl" + "e DbFieldName=""QuantityPerUnit"" Name=""QuantityPerUnit"" DataType=""String"" NativeD" + "bType=""130"" MaxLength=""20"" /><dbtable DbFieldName=""ReorderLevel"" Name=""ReorderLe" + "vel"" DataType=""Int16"" NativeDbType=""2"" /><dbtable DbFieldName=""SupplierID"" Name=" + """SupplierID"" DataType=""Int32"" NativeDbType=""3"" /><dbtable DbFieldName=""UnitPrice" + """ Name=""UnitPrice"" DataType=""Decimal"" NativeDbType=""6"" /><dbtable DbFieldName=""U" + "nitsInStock"" Name=""UnitsInStock"" DataType=""Int16"" NativeDbType=""2"" /><dbtable Db" + "FieldName=""UnitsOnOrder"" Name=""UnitsOnOrder"" DataType=""Int16"" NativeDbType=""2"" /" + "></Fields></dbtable></Tables><Connections><oledb Name=""Connection_1""><SqlInfo Id" + "entityColumnLastValueSelect=""SELECT @@IDENTITY""><ChangedByUserPersist>true</Chan" + "gedByUserPersist><AlwaysEscapeNames>true</AlwaysEscapeNames></SqlInfo><Connectio" + "nString>Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C" + ":\Program Files\ComponentOne Studio.NET 2.0\Common\C1NWind.mdb;Mode=Share Deny None;Ex" + "tended Properties="""";Jet OLEDB:System database="""";Jet OLEDB:Registry Path="""";Jet" + " OLEDB:Database Password="""";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking M" + "ode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;J" + "et OLEDB:New Database Password="""";Jet OLEDB:Create System Database=False;Jet OLE" + "DB:Encrypt Database=False;Jet OLEDB:Don't Copy Locale on Compact=False;Jet OLEDB" + ":Compact Without Replica Repair=False;Jet OLEDB:SFP=False</ConnectionString></ol" + "edb></Connections></Schema>"

      Me.c1xProducts.TableViewName = "Products"
      ' 
      ' c1xCategories
      ' 
      Me.c1xCategories.BindingContextCtrl = Me
      Me.c1xCategories.ConnectionComponent = Nothing
      Me.c1xCategories.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studio.NET 2.0\Common\C1NWind.mdb;"
      Me.c1xCategories.FullComponentName = "Form1.c1xCategories"
      Me.c1xCategories.SchemaTableName = "Categories"
      Me.c1xCategories.SerializedSchemaXML = "VERSION98:<?xml version=""1.0""?><Schema><DataSetDefs><DataSetDef Name=""DataSetDef_" + "1""><CacheProperties /><FieldDefaults /><TableViews><TableView Name=""Categories"" " + "TableName=""Categories""><Fields><TableViewField TableFieldName=""CategoryID"" Prima" + "ryKey=""true"" Name=""CategoryID"" DataType=""Int32"" AllowDbNull=""false"" /><TableView" + "Field TableFieldName=""CategoryName"" Name=""CategoryName"" DataType=""String"" MaxLen" + "gth=""15"" /><TableViewField TableFieldName=""Description"" Name=""Description"" DataT" + "ype=""String"" /><TableViewField TableFieldName=""Picture"" Name=""Picture"" DataType=" + """Byte[]"" /></Fields></TableView></TableViews></DataSetDef></DataSetDefs><Tables>" + "<dbtable ConnectionName=""Connection_1"" DbTableName=""Categories"" Name=""Categories" + """><Fields><dbtable DbFieldName=""CategoryID"" PrimaryKey=""true"" AllowDbNull=""false" + """ Name=""CategoryID"" DataType=""Int32"" NativeDbType=""3"" /><dbtable DbFieldName=""Ca" + "tegoryName"" AllowDbNull=""false"" Name=""CategoryName"" DataType=""String"" NativeDbTy" + "pe=""130"" MaxLength=""15"" /><dbtable DbFieldName=""Description"" Name=""Description"" " + "DataType=""String"" NativeDbType=""130"" /><dbtable DbFieldName=""Picture"" Name=""Pict" + "ure"" DataType=""Byte[]"" NativeDbType=""128"" /></Fields></dbtable></Tables><Connect" + "ions><oledb Name=""Connection_1""><SqlInfo IdentityColumnLastValueSelect=""SELECT @" + "@IDENTITY""><ChangedByUserPersist>true</ChangedByUserPersist><AlwaysEscapeNames>t" + "rue</AlwaysEscapeNames></SqlInfo><ConnectionString>Provider=Microsoft.Jet.OLEDB." + "4.0;Password="""";User ID=Admin;Data Source=C:\Program Files\ComponentOne Studio.N" + "ET\common\C1NWind.mdb;Mode=Share Deny None;Extended Properties="""";Jet OLEDB:System" + " database="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB" + ":Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk O" + "ps=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet" + " OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:D" + "on't Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False" + ";Jet OLEDB:SFP=False</ConnectionString></oledb></Connections></Schema>"

      Me.c1xCategories.TableViewName = "Categories"
      ' 
      ' c1Chart
      ' 
      Me.c1Chart.DataSource = Nothing
      Me.c1Chart.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1Chart.Location = New System.Drawing.Point(112, 0)
      Me.c1Chart.Name = "c1Chart"
      Me.c1Chart.PropBag = "<?xml version=""1.0""?><Chart2DPropBag Version=""""><StyleCollection><NamedStyle><Nam" + "e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" + "tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" + "/ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName" + ">Control</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Na" + "medStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Na" + "medStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName" + "><StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</Paren" + "tName><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;Bac" + "kColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><Named" + "Style><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0" + ";Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;A" + "lignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Na" + "me><ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><" + "NamedStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData" + ">Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedSty" + "le><Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleD" + "ata>Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedSty" + "le><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Bla" + "ck,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" + "e /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</Sty" + "leData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName>" + "<StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor" + "=Transparent;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.defau" + "lt</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;AlignVer" + "t=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><ChartGr" + "oup><DataSerializer Hole=""3.4028234663852886E+38"" DefaultSet=""True""><DataSeriesC" + "ollection><DataSeriesSerializer><LineStyle Thickness=""1"" Color=""DarkGoldenrod"" P" + "attern=""Solid"" /><SymbolStyle Color=""Coral"" OutlineColor="""" Shape=""Box"" /><Serie" + "sLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y" + "3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</D" + "ataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickne" + "ss=""1"" Color=""DarkGray"" Pattern=""Solid"" /><SymbolStyle Color=""CornflowerBlue"" Ou" + "tlineColor="""" Shape=""Dot"" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><" + "Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Doub" + "le</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSe" + "riesSerializer><LineStyle Thickness=""1"" Color=""DarkGreen"" Pattern=""Solid"" /><Sym" + "bolStyle Color=""Cornsilk"" OutlineColor="""" Shape=""Tri"" /><SeriesLabel>series 2</S" + "eriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Sin" + "gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /><" + "/DataSeriesSerializer></DataSeriesCollection></DataSerializer><Name>Group1</Name" + "><Stacked>False</Stacked><ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</P" + "ie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTra" + "nsparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>Enc" + "odingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,Pi" + "RatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</R" + "adar><Use3D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline><" + "/ChartGroup><ChartGroup><DataSerializer Hole=""3.4028234663852886E+38"" /><Name>Gr" + "oup2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset" + "=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling" + "=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoDat" + "a><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>De" + "grees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fal" + "se,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartG" + "roup></ChartGroupsCollection><Header Compass=""North""><Text /></Header><Footer Co" + "mpass=""South""><Text /></Footer><Legend Compass=""East"" Visible=""False""><Text /></" + "Legend><ChartArea Inverted=""True"" /><Axes><Axis Max=""5.5"" Min=""0.5"" UnitMajor=""1" + """ UnitMinor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True" + """ _onTop=""0"" Compass=""West""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Co" + "lor=""LightGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color" + "=""LightGray"" Pattern=""Dash"" /></Axis><Axis Max=""25"" Min=""8"" UnitMajor=""1"" UnitMi" + "nor=""0.5"" AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop" + "=""0"" Compass=""South""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""Li" + "ghtGray"" Pattern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""Light" + "Gray"" Pattern=""Dash"" /></Axis><Axis Max=""0"" Min=""0"" UnitMajor=""0"" UnitMinor=""0"" " + "AutoMajor=""True"" AutoMinor=""True"" AutoMax=""True"" AutoMin=""True"" _onTop=""0"" Compa" + "ss=""North""><Text /><GridMajor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" P" + "attern=""Dash"" /><GridMinor AutoSpace=""True"" Thickness=""1"" Color=""LightGray"" Patt" + "ern=""Dash"" /></Axis></Axes></Chart2DPropBag>"

      Me.c1Chart.Size = New System.Drawing.Size(520, 423)
      Me.c1Chart.TabIndex = 2
      ' 
      ' Form1
      ' 
      Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
      Me.ClientSize = New System.Drawing.Size(632, 423)
      Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.c1Chart, Me.lstCategories})
      Me.Name = "Form1"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "C1Chart: Data Demo (using C1DataExpress)"
      CType(Me.c1xProducts, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1xCategories, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.c1Chart, System.ComponentModel.ISupportInitialize).EndInit()
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
      ' initialize chart
      c1Chart.Header.Style.Font = New Font("Arial", 14)
      c1Chart.Legend.Visible = True
      c1Chart.Legend.Compass = CompassEnum.South
      Dim ax As Axis = c1Chart.ChartArea.AxisX
      ax.TickMinor = TickMarksEnum.None
      Dim ay As Axis = c1Chart.ChartArea.AxisY
      ay.TickMinor = TickMarksEnum.None
      ay.GridMajor.Visible = True
      ay.GridMajor.Color = Color.White
      ay.GridMajor.Pattern = LinePatternEnum.Dot
      
      ' populate categories list
      Dim dr As C1DataRow
      For Each dr In  c1xCategories.DataTable.Rows
         lstCategories.Items.Add(dr("CategoryName").ToString())
      Next dr 
      ' select first category (will update the chart)
      lstCategories.SelectedIndex = 0
   End Sub 'Form1_Load

    Private Function getModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

    ' update chart when the selected category changes
   Private Sub lstCategories_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles lstCategories.SelectedIndexChanged
      ' find selected categoryID
      Dim catID As Integer = - 1
      Dim catName As String = lstCategories.SelectedItem.ToString()
      Dim dr As C1DataRow
      For Each dr In  c1xCategories.DataTable.Rows
         If dr("CategoryName").ToString() = catName Then
            catID = Integer.Parse(dr("CategoryID").ToString())
            Exit For
         End If
      Next dr
      
      ' apply filter to data table
      Dim dv As New C1ExpressView()
      dv.ExpressTable = c1xProducts
      dv.RowFilter = String.Format("CategoryID = {0}", catID)
      
      ' sort by unit price
      dv.Sort = "UnitPrice DESC"
      
      ' copy data from table to chart
      c1Chart.Header.Text = lstCategories.SelectedItem.ToString()
      BindSeries(c1Chart, 0, dv, "UnitPrice", "ProductName")
      BindSeries(c1Chart, 1, dv, "UnitsInStock")
      BindSeries(c1Chart, 2, dv, "ReorderLevel")
   End Sub 'lstCategories_SelectedIndexChanged
   
   
   ' copy data from a data source to the chart
   ' c1c          chart
   ' series       index of the series to bind (0-based, will add if necessary)
   ' datasource   datasource object (cannot be DataTable, DataView is OK)
   ' field        name of the field that contains the y values
   ' labels       name of the field that contains the x labels
   Overloads Private Sub BindSeries(c1c As C1Chart, series As Integer, dataSource As Object, field As String, labels As String)
      ' check data source object
      Dim il As ITypedList = dataSource '
      'ToDo: Error processing original source shown below
      '
      '
      '----------------------------------------^--- Syntax error: ';' expected
      Dim list As IList = dataSource '
      'ToDo: Error processing original source shown below
      '
      '
      '-------------------------------------^--- Syntax error: ';' expected
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
