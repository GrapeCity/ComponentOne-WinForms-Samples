using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Data;
using C1.Data.Express;
using C1.Win.C1Chart;

namespace DataChart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private System.Windows.Forms.ListBox lstCategories;
        private C1.Data.Express.C1ExpressTable c1xProducts;
        private C1.Data.Express.C1ExpressTable c1xCategories;
        private C1.Win.C1Chart.C1Chart c1Chart;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			this.c1xProducts.ConnectionString = getModifiedConnectionString(this.c1xProducts.ConnectionString);
			this.c1xProducts.SerializedSchemaXML = getModifiedConnectionString(this.c1xProducts.SerializedSchemaXML);
			this.c1xCategories.ConnectionString = getModifiedConnectionString(this.c1xCategories.ConnectionString);
			this.c1xCategories.SerializedSchemaXML = getModifiedConnectionString(this.c1xCategories.SerializedSchemaXML);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.lstCategories = new System.Windows.Forms.ListBox();
			this.c1xProducts = new C1.Data.Express.C1ExpressTable();
			this.c1xCategories = new C1.Data.Express.C1ExpressTable();
			this.c1Chart = new C1.Win.C1Chart.C1Chart();
			((System.ComponentModel.ISupportInitialize)(this.c1xProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1xCategories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart)).BeginInit();
			this.SuspendLayout();
			// 
			// lstCategories
			// 
			this.lstCategories.Dock = System.Windows.Forms.DockStyle.Left;
			this.lstCategories.IntegralHeight = false;
			this.lstCategories.Name = "lstCategories";
			this.lstCategories.Size = new System.Drawing.Size(112, 423);
			this.lstCategories.TabIndex = 1;
			this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.lstCategories_SelectedIndexChanged);
			// 
			// c1xProducts
			// 
			this.c1xProducts.BindingContextCtrl = this;
			this.c1xProducts.ConnectionComponent = null;
			this.c1xProducts.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\C1NWind.mdb;";
			this.c1xProducts.FullComponentName = "Form1.c1xProducts";
			this.c1xProducts.SchemaTableName = "Products";
			this.c1xProducts.SerializedSchemaXML = "VERSION98:<?xml version=\"1.0\"?><Schema><DataSetDefs><DataSetDef Name=\"DataSetDef_" +
				"1\"><CacheProperties /><FieldDefaults /><TableViews><TableView Name=\"Products\" Ta" +
				"bleName=\"Products\"><Fields><TableViewField TableFieldName=\"CategoryID\" Name=\"Cat" +
				"egoryID\" DataType=\"Int32\" AllowDbNull=\"false\" /><TableViewField TableFieldName=\"" +
				"Discontinued\" Name=\"Discontinued\" DataType=\"Boolean\" MaxLength=\"2\" /><TableViewF" +
				"ield TableFieldName=\"ProductID\" PrimaryKey=\"true\" Name=\"ProductID\" DataType=\"Int" +
				"32\" /><TableViewField TableFieldName=\"ProductName\" Name=\"ProductName\" DataType=\"" +
				"String\" MaxLength=\"40\" /><TableViewField TableFieldName=\"QuantityPerUnit\" Name=\"" +
				"QuantityPerUnit\" DataType=\"String\" MaxLength=\"20\" /><TableViewField TableFieldNa" +
				"me=\"ReorderLevel\" Name=\"ReorderLevel\" DataType=\"Int16\" /><TableViewField TableFi" +
				"eldName=\"SupplierID\" Name=\"SupplierID\" DataType=\"Int32\" /><TableViewField TableF" +
				"ieldName=\"UnitPrice\" Name=\"UnitPrice\" DataType=\"Decimal\" /><TableViewField Table" +
				"FieldName=\"UnitsInStock\" Name=\"UnitsInStock\" DataType=\"Int16\" /><TableViewField " +
				"TableFieldName=\"UnitsOnOrder\" Name=\"UnitsOnOrder\" DataType=\"Int16\" /></Fields></" +
				"TableView></TableViews></DataSetDef></DataSetDefs><Tables><dbtable ConnectionNam" +
				"e=\"Connection_1\" DbTableName=\"Products\" Name=\"Products\"><Fields><dbtable DbField" +
				"Name=\"CategoryID\" AllowDbNull=\"false\" Name=\"CategoryID\" DataType=\"Int32\" NativeD" +
				"bType=\"3\" /><dbtable DbFieldName=\"Discontinued\" AllowDbNull=\"false\" Name=\"Discon" +
				"tinued\" DataType=\"Boolean\" NativeDbType=\"11\" MaxLength=\"2\" /><dbtable DbFieldNam" +
				"e=\"ProductID\" PrimaryKey=\"true\" AllowDbNull=\"false\" Name=\"ProductID\" DataType=\"I" +
				"nt32\" NativeDbType=\"3\" /><dbtable DbFieldName=\"ProductName\" AllowDbNull=\"false\" " +
				"Name=\"ProductName\" DataType=\"String\" NativeDbType=\"130\" MaxLength=\"40\" /><dbtabl" +
				"e DbFieldName=\"QuantityPerUnit\" Name=\"QuantityPerUnit\" DataType=\"String\" NativeD" +
				"bType=\"130\" MaxLength=\"20\" /><dbtable DbFieldName=\"ReorderLevel\" Name=\"ReorderLe" +
				"vel\" DataType=\"Int16\" NativeDbType=\"2\" /><dbtable DbFieldName=\"SupplierID\" Name=" +
				"\"SupplierID\" DataType=\"Int32\" NativeDbType=\"3\" /><dbtable DbFieldName=\"UnitPrice" +
				"\" Name=\"UnitPrice\" DataType=\"Decimal\" NativeDbType=\"6\" /><dbtable DbFieldName=\"U" +
				"nitsInStock\" Name=\"UnitsInStock\" DataType=\"Int16\" NativeDbType=\"2\" /><dbtable Db" +
				"FieldName=\"UnitsOnOrder\" Name=\"UnitsOnOrder\" DataType=\"Int16\" NativeDbType=\"2\" /" +
				"></Fields></dbtable></Tables><Connections><oledb Name=\"Connection_1\"><SqlInfo Id" +
				"entityColumnLastValueSelect=\"SELECT @@IDENTITY\"><ChangedByUserPersist>true</Chan" +
				"gedByUserPersist><AlwaysEscapeNames>true</AlwaysEscapeNames></SqlInfo><Connectio" +
				"nString>Provider=Microsoft.Jet.OLEDB.4.0;Password=\"\";User ID=Admin;Data Source=C" +
				":\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\C1NWind.mdb;Mode=Share Deny None;Ex" +
				"tended Properties=\"\";Jet OLEDB:System database=\"\";Jet OLEDB:Registry Path=\"\";Jet" +
				" OLEDB:Database Password=\"\";Jet OLEDB:Engine Type=5;Jet OLEDB:Database Locking M" +
				"ode=1;Jet OLEDB:Global Partial Bulk Ops=2;Jet OLEDB:Global Bulk Transactions=1;J" +
				"et OLEDB:New Database Password=\"\";Jet OLEDB:Create System Database=False;Jet OLE" +
				"DB:Encrypt Database=False;Jet OLEDB:Don\'t Copy Locale on Compact=False;Jet OLEDB" +
				":Compact Without Replica Repair=False;Jet OLEDB:SFP=False</ConnectionString></ol" +
				"edb></Connections></Schema>";
			this.c1xProducts.TableViewName = "Products";
			// 
			// c1xCategories
			// 
			this.c1xCategories.BindingContextCtrl = this;
			this.c1xCategories.ConnectionComponent = null;
			this.c1xCategories.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio.NET 2.0\\Common\\C1NWind.mdb;";
			this.c1xCategories.FullComponentName = "Form1.c1xCategories";
			this.c1xCategories.SchemaTableName = "Categories";
			this.c1xCategories.SerializedSchemaXML = "VERSION98:<?xml version=\"1.0\"?><Schema><DataSetDefs><DataSetDef Name=\"DataSetDef_" +
				"1\"><CacheProperties /><FieldDefaults /><TableViews><TableView Name=\"Categories\" " +
				"TableName=\"Categories\"><Fields><TableViewField TableFieldName=\"CategoryID\" Prima" +
				"ryKey=\"true\" Name=\"CategoryID\" DataType=\"Int32\" AllowDbNull=\"false\" /><TableView" +
				"Field TableFieldName=\"CategoryName\" Name=\"CategoryName\" DataType=\"String\" MaxLen" +
				"gth=\"15\" /><TableViewField TableFieldName=\"Description\" Name=\"Description\" DataT" +
				"ype=\"String\" /><TableViewField TableFieldName=\"Picture\" Name=\"Picture\" DataType=" +
				"\"Byte[]\" /></Fields></TableView></TableViews></DataSetDef></DataSetDefs><Tables>" +
				"<dbtable ConnectionName=\"Connection_1\" DbTableName=\"Categories\" Name=\"Categories" +
				"\"><Fields><dbtable DbFieldName=\"CategoryID\" PrimaryKey=\"true\" AllowDbNull=\"false" +
				"\" Name=\"CategoryID\" DataType=\"Int32\" NativeDbType=\"3\" /><dbtable DbFieldName=\"Ca" +
				"tegoryName\" AllowDbNull=\"false\" Name=\"CategoryName\" DataType=\"String\" NativeDbTy" +
				"pe=\"130\" MaxLength=\"15\" /><dbtable DbFieldName=\"Description\" Name=\"Description\" " +
				"DataType=\"String\" NativeDbType=\"130\" /><dbtable DbFieldName=\"Picture\" Name=\"Pict" +
				"ure\" DataType=\"Byte[]\" NativeDbType=\"128\" /></Fields></dbtable></Tables><Connect" +
				"ions><oledb Name=\"Connection_1\"><SqlInfo IdentityColumnLastValueSelect=\"SELECT @" +
				"@IDENTITY\"><ChangedByUserPersist>true</ChangedByUserPersist><AlwaysEscapeNames>t" +
				"rue</AlwaysEscapeNames></SqlInfo><ConnectionString>Provider=Microsoft.Jet.OLEDB." +
				"4.0;Password=\"\";User ID=Admin;Data Source=C:\\Program Files\\ComponentOne Studio.N" +
				"ET\\common\\C1NWind.mdb;Mode=Share Deny None;Extended Properties=\"\";Jet OLEDB:System" +
				" database=\"\";Jet OLEDB:Registry Path=\"\";Jet OLEDB:Database Password=\"\";Jet OLEDB" +
				":Engine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk O" +
				"ps=2;Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password=\"\";Jet" +
				" OLEDB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:D" +
				"on\'t Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False" +
				";Jet OLEDB:SFP=False</ConnectionString></oledb></Connections></Schema>";
			this.c1xCategories.TableViewName = "Categories";
			// 
			// c1Chart
			// 
			this.c1Chart.DataSource = null;
			this.c1Chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart.Location = new System.Drawing.Point(112, 0);
			this.c1Chart.Name = "c1Chart";
			this.c1Chart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName" +
				">Control</ParentName><StyleData>Border=None,Black,1;</StyleData></NamedStyle><Na" +
				"medStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Na" +
				"medStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName" +
				"><StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</Paren" +
				"tName><StyleData>Rotation=Rotate270;Border=None,Transparent,1;AlignHorz=Near;Bac" +
				"kColor=Transparent;Opaque=False;AlignVert=Center;</StyleData></NamedStyle><Named" +
				"Style><Name>AxisY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0" +
				";Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Opaque=False;A" +
				"lignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault</Na" +
				"me><ParentName>LabelStyleDefault.default</ParentName><StyleData /></NamedStyle><" +
				"NamedStyle><Name>Legend.default</Name><ParentName>Control</ParentName><StyleData" +
				">Border=None,Black,1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedSty" +
				"le><Name>LabelStyleDefault.default</Name><ParentName>Control</ParentName><StyleD" +
				"ata>Border=None,Black,1;BackColor=Transparent;</StyleData></NamedStyle><NamedSty" +
				"le><Name>Header</Name><ParentName>Control</ParentName><StyleData>Border=None,Bla" +
				"ck,1;</StyleData></NamedStyle><NamedStyle><Name>Control.default</Name><ParentNam" +
				"e /><StyleData>ForeColor=ControlText;Border=None,Black,1;BackColor=Control;</Sty" +
				"leData></NamedStyle><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName>" +
				"<StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor" +
				"=Transparent;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.defau" +
				"lt</Name><ParentName>Control</ParentName><StyleData>Border=None,Black,1;AlignVer" +
				"t=Top;</StyleData></NamedStyle></StyleCollection><ChartGroupsCollection><ChartGr" +
				"oup><DataSerializer Hole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSeriesC" +
				"ollection><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenrod\" P" +
				"attern=\"Solid\" /><SymbolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Box\" /><Serie" +
				"sLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y" +
				"3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</D" +
				"ataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickne" +
				"ss=\"1\" Color=\"DarkGray\" Pattern=\"Solid\" /><SymbolStyle Color=\"CornflowerBlue\" Ou" +
				"tlineColor=\"\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><" +
				"Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Doub" +
				"le</DataTypes><DataFields>;;;;</DataFields><Tag /></DataSeriesSerializer><DataSe" +
				"riesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGreen\" Pattern=\"Solid\" /><Sym" +
				"bolStyle Color=\"Cornsilk\" OutlineColor=\"\" Shape=\"Tri\" /><SeriesLabel>series 2</S" +
				"eriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><Y1 /><Y2 /><Y3 /><DataTypes>Sin" +
				"gle;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><Tag /><" +
				"/DataSeriesSerializer></DataSeriesCollection></DataSerializer><Name>Group1</Name" +
				"><Stacked>False</Stacked><ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</P" +
				"ie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling=True,FillTra" +
				"nsparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData><Bubble>Enc" +
				"odingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,Pi" +
				"RatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</R" +
				"adar><Use3D>False</Use3D><Visible>True</Visible><ShowOutline>True</ShowOutline><" +
				"/ChartGroup><ChartGroup><DataSerializer Hole=\"3.4028234663852886E+38\" /><Name>Gr" +
				"oup2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartType><Pie>OtherOffset" +
				"=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFalling" +
				"=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoDat" +
				"a><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>De" +
				"grees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Filled=Fal" +
				"se,Start=0</Radar><Visible>True</Visible><ShowOutline>True</ShowOutline></ChartG" +
				"roup></ChartGroupsCollection><Header Compass=\"North\"><Text /></Header><Footer Co" +
				"mpass=\"South\"><Text /></Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></" +
				"Legend><ChartArea Inverted=\"True\" /><Axes><Axis Max=\"5.5\" Min=\"0.5\" UnitMajor=\"1" +
				"\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True" +
				"\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Co" +
				"lor=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color" +
				"=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMi" +
				"nor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop" +
				"=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"Li" +
				"ghtGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"Light" +
				"Gray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" " +
				"AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Compa" +
				"ss=\"North\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" P" +
				"attern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patt" +
				"ern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart.Size = new System.Drawing.Size(520, 423);
			this.c1Chart.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 423);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart,
																		  this.lstCategories});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Chart: Data Demo (using C1DataExpress)";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1xProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1xCategories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // initialize chart
            c1Chart.Header.Style.Font = new Font("Arial", 14);
            c1Chart.Legend.Visible = true;
            c1Chart.Legend.Compass = CompassEnum.South;
            Axis ax = c1Chart.ChartArea.AxisX;
            ax.TickMinor = TickMarksEnum.None;
            Axis ay = c1Chart.ChartArea.AxisY;
            ay.TickMinor = TickMarksEnum.None;
            ay.GridMajor.Visible = true;
            ay.GridMajor.Color = Color.White;
            ay.GridMajor.Pattern = LinePatternEnum.Dot;

            // populate categories list
            foreach (C1DataRow dr in c1xCategories.DataTable.Rows)
                lstCategories.Items.Add(dr["CategoryName"].ToString());

            // select first category (will update the chart)
            lstCategories.SelectedIndex = 0;
        }

		private string getModifiedConnectionString(string connstring)
		{
			int dataSource = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase);
			int dataSourceEnd = connstring.LastIndexOf('\\', connstring.IndexOf(';', dataSource));
			connstring = connstring.Substring(0, dataSource) + "Data Source=" +
				Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
				"\\ComponentOne Samples\\Common" + connstring.Substring(dataSourceEnd);
			return connstring;
		}

        // update chart when the selected category changes
        private void lstCategories_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // find selected categoryID
            int    catID   = -1;
            string catName = lstCategories.SelectedItem.ToString();
            foreach (C1DataRow dr in c1xCategories.DataTable.Rows)
            {
                if (dr["CategoryName"].ToString() == catName)
                {
                    catID = int.Parse(dr["CategoryID"].ToString());
                    break;
                }
            }

            // apply filter to data table
            C1ExpressView dv = new C1ExpressView();
            dv.ExpressTable = c1xProducts;
            dv.RowFilter = string.Format("CategoryID = {0}", catID);

            // sort by unit price
            dv.Sort = "UnitPrice DESC";

            // copy data from table to chart
            c1Chart.Header.Text = lstCategories.SelectedItem.ToString();
            BindSeries(c1Chart, 0, dv, "UnitPrice",    "ProductName");
            BindSeries(c1Chart, 1, dv, "UnitsInStock");
            BindSeries(c1Chart, 2, dv, "ReorderLevel");
        }

        // copy data from a data source to the chart
        // c1c          chart
        // series       index of the series to bind (0-based, will add if necessary)
        // datasource   datasource object (cannot be DataTable, DataView is OK)
        // field        name of the field that contains the y values
        // labels       name of the field that contains the x labels
        private void BindSeries(C1Chart c1c, int series, object dataSource, string field, string labels)
        {
            // check data source object
            ITypedList il = dataSource as ITypedList;
            IList list = dataSource as IList;
            if (list == null || il == null) 
                throw new ApplicationException("Invalid DataSource object.");

            // add series if necessary
            ChartDataSeriesCollection coll = c1c.ChartGroups[0].ChartData.SeriesList;
            while (series >= coll.Count)
                coll.AddNewSeries();

            // copy series data
            if (list.Count == 0) return;
            PointF[] data = (PointF[])Array.CreateInstance(typeof(PointF), list.Count);
            PropertyDescriptorCollection pdc = il.GetItemProperties(null);
            PropertyDescriptor pd = pdc[field];
            if (pd == null) 
                throw new ApplicationException(string.Format("Invalid field name used for Y values ({0}).", field));
			int i;
            for (i = 0; i < list.Count; i++)
            {
                data[i].X = i;
                try
                {
                    data[i].Y = float.Parse(pd.GetValue(list[i]).ToString());
                }
                catch
                {
                    data[i].Y = float.NaN;
                }
                coll[series].PointData.CopyDataIn(data);
                coll[series].Label = field;
            }

            // copy series labels
            if (labels != null && labels.Length > 0)
            {
                pd = pdc[labels];
                if (pd == null) 
                    throw new ApplicationException(string.Format("Invalid field name used for X values ({0}).", labels));
                Axis ax = c1c.ChartArea.AxisX;
                ax.ValueLabels.Clear();
                for (i = 0; i < list.Count; i++)
                {
                    string label = pd.GetValue(list[i]).ToString();
                    ax.ValueLabels.Add(i, label);
                }
                ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
            }
        }
        private void BindSeries(C1Chart c1c, int series, object dataSource, string field)
        {
            BindSeries(c1c, series, dataSource, field, null);
        }
	}
}
