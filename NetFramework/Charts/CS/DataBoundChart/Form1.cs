using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using C1.Win.C1Chart;

namespace DataBoundChart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox listBox1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter2;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private DataBoundChart.DataSet1 dataSet11;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand2;
		private DataBoundChart.DataSet2 dataSet21;
		private System.Data.DataView dataView1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.oleDbConnection1.ConnectionString = getModifiedConnectionString(this.oleDbConnection1.ConnectionString);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.dataSet21 = new DataBoundChart.DataSet2();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.dataView1 = new System.Data.DataView();
			this.dataSet11 = new DataBoundChart.DataSet1();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter2 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.DataSource = this.dataSet21.Categories;
			this.listBox1.DisplayMember = "CategoryName";
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(112, 420);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// dataSet21
			// 
			this.dataSet21.DataSetName = "DataSet2";
			this.dataSet21.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet21.Namespace = "http://www.tempuri.org/DataSet2.xsd";
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = this.dataView1;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(112, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
				"e>PlotArea</Name><ParentName>Area</ParentName><StyleData>Border=None,Black,1;</S" +
				"tyleData></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default<" +
				"/ParentName><StyleData>AlignHorz=General;AlignVert=Top;</StyleData></NamedStyle>" +
				"<NamedStyle><Name>Footer</Name><ParentName>Control</ParentName><StyleData>Border" +
				"=None,Black,1;</StyleData></NamedStyle><NamedStyle><Name>Area</Name><ParentName>" +
				"Area.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName><StyleData /></NamedStyle><NamedStyle" +
				"><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Bo" +
				"rder=None,Transparent,1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignV" +
				"ert=Center;</StyleData></NamedStyle><NamedStyle><Name>AxisY</Name><ParentName>Ar" +
				"ea</ParentName><StyleData>Rotation=Rotate0;Border=None,Transparent,1;AlignHorz=C" +
				"enter;BackColor=Transparent;Opaque=False;AlignVert=Bottom;</StyleData></NamedSty" +
				"le><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.defau" +
				"lt</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Name>" +
				"<ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;AlignV" +
				"ert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</Na" +
				"me><ParentName>Control</ParentName><StyleData>Border=None,Black,1;BackColor=Tran" +
				"sparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>Cont" +
				"rol</ParentName><StyleData>Border=None,Black,1;Font=Arial, 14pt;</StyleData></Na" +
				"medStyle><NamedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeCo" +
				"lor=ControlText;Border=None,Black,1;BackColor=Control;</StyleData></NamedStyle><" +
				"NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=R" +
				"otate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;AlignVer" +
				"t=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>" +
				"Control</ParentName><StyleData>Border=None,Black,1;AlignVert=Top;</StyleData></N" +
				"amedStyle></StyleCollection><ChartGroupsCollection><ChartGroup><DataSerializer H" +
				"ole=\"3.4028234663852886E+38\" DefaultSet=\"True\"><DataSeriesCollection><DataSeries" +
				"Serializer><LineStyle Thickness=\"1\" Color=\"DarkGoldenrod\" Pattern=\"Solid\" /><Sym" +
				"bolStyle Color=\"Coral\" OutlineColor=\"\" Shape=\"Box\" /><SeriesLabel>UnitPrice</Ser" +
				"iesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><Y1 /><Y2 /><Y3 /><DataTypes>Singl" +
				"e;Single;Double;Double;Double</DataTypes><DataFields>ProductName;UnitPrice;;;</D" +
				"ataFields><Tag /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Thickne" +
				"ss=\"1\" Color=\"DarkGray\" Pattern=\"Solid\" /><SymbolStyle Color=\"CornflowerBlue\" Ou" +
				"tlineColor=\"\" Shape=\"Dot\" /><SeriesLabel>UnitsInStock</SeriesLabel><X>1;2;3;4;5<" +
				"/X><Y>8;12;10;12;15</Y><Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;" +
				"Double</DataTypes><DataFields>ProductName;UnitsInStock;;;</DataFields><Tag /></D" +
				"ataSeriesSerializer><DataSeriesSerializer><LineStyle Thickness=\"1\" Color=\"DarkGr" +
				"een\" Pattern=\"Solid\" /><SymbolStyle Color=\"Cornsilk\" OutlineColor=\"\" Shape=\"Tri\"" +
				" /><SeriesLabel>ReorderLevel</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><" +
				"Y1 /><Y2 /><Y3 /><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataF" +
				"ields>ProductName;ReorderLevel;;;</DataFields><Tag /></DataSeriesSerializer></Da" +
				"taSeriesCollection></DataSerializer><Name>Group1</Name><Stacked>False</Stacked><" +
				"ChartType>Bar</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,C" +
				"lusterWidth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=Fa" +
				"lse,ShowClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,Maxim" +
				"umSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Star" +
				"t=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visibl" +
				"e><ShowOutline>True</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=\"" +
				"3.4028234663852886E+38\" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>" +
				"XYPlot</ChartType><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterW" +
				"idth=50</Bar><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,Sho" +
				"wClose=True,ShowOpen=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=" +
				"20,MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Po" +
				"lar><Radar>Degrees=True,Filled=False,Start=0</Radar><Visible>True</Visible><Show" +
				"Outline>True</ShowOutline></ChartGroup></ChartGroupsCollection><Header Compass=\"" +
				"North\"><Text /></Header><Footer Compass=\"South\"><Text /></Footer><Legend Compass" +
				"=\"South\" Visible=\"True\" Orientation=\"Horizontal\"><Text /></Legend><ChartArea Inv" +
				"erted=\"True\" /><Axes><Axis Max=\"5.5\" Min=\"0.5\" UnitMajor=\"1\" UnitMinor=\"0.5\" Aut" +
				"oMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" TickMinor=\"None\" _o" +
				"nTop=\"0\" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=" +
				"\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"Li" +
				"ghtGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=" +
				"\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" TickMinor=" +
				"\"None\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor Visible=\"True\" Spacing=\"1\" " +
				"AutoSpace=\"True\" Thickness=\"1\" Color=\"White\" Pattern=\"Dot\" /><GridMinor AutoSpac" +
				"e=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" M" +
				"in=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"Tr" +
				"ue\" AutoMin=\"True\" _onTop=\"0\" Compass=\"North\"><Text /><GridMajor AutoSpace=\"True" +
				"\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" T" +
				"hickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(520, 423);
			this.c1Chart1.TabIndex = 1;
			// 
			// dataView1
			// 
			this.dataView1.AllowDelete = false;
			this.dataView1.AllowEdit = false;
			this.dataView1.AllowNew = false;
			this.dataView1.Table = this.dataSet11.Products;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd";
			// 
			// oleDbConnection1
			// 
			this.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Program Files\\ComponentOne Studio" +
				".NET 2.0\\Common\\C1NWind.mdb;Mode=Share Deny None;";
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Products", new System.Data.Common.DataColumnMapping[] {
																																																					new System.Data.Common.DataColumnMapping("ProductName", "ProductName"),
																																																					new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
																																																					new System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"),
																																																					new System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel")})});
			// 
			// oleDbSelectCommand1
			// 
			this.oleDbSelectCommand1.CommandText = "SELECT CategoryID, ProductName, UnitPrice, UnitsInStock, ReorderLevel FROM Produc" +
				"ts ORDER BY UnitPrice DESC";
			this.oleDbSelectCommand1.Connection = this.oleDbConnection1;
			// 
			// oleDbDataAdapter2
			// 
			this.oleDbDataAdapter2.SelectCommand = this.oleDbSelectCommand2;
			this.oleDbDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										new System.Data.Common.DataTableMapping("Table", "Categories", new System.Data.Common.DataColumnMapping[] {
																																																					  new System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"),
																																																					  new System.Data.Common.DataColumnMapping("CategoryID", "CategoryID")})});
			// 
			// oleDbSelectCommand2
			// 
			this.oleDbSelectCommand2.CommandText = "SELECT CategoryName, CategoryID FROM Categories";
			this.oleDbSelectCommand2.Connection = this.oleDbConnection1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 423);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.listBox1});
			this.Name = "Form1";
			this.Text = "C1Chart: DataBound Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet21)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
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

		private string getModifiedConnectionString(string connstring)
		{
			int dataSource = connstring.IndexOf("Data Source=",0,StringComparison.OrdinalIgnoreCase);
			int dataSourceEnd = connstring.LastIndexOf('\\', connstring.IndexOf(';', dataSource));
			connstring = connstring.Substring(0, dataSource) + "Data Source=" +
				Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
				"\\ComponentOne Samples\\Common" + connstring.Substring(dataSourceEnd);
			return connstring;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
            this.oleDbDataAdapter1.Fill(this.dataSet11);
            this.oleDbDataAdapter2.Fill(this.dataSet21);

            // force the new calculation after the refill.
            listBox1_SelectedIndexChanged(this.listBox1, new EventArgs());
        }

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            if (listBox1.SelectedIndex >= 0)
            {
                string categoryID = this.dataSet21.Categories[listBox1.SelectedIndex].CategoryID.ToString();
                this.dataView1.RowFilter = "CategoryID = " + categoryID;
                this.c1Chart1.Header.Text = listBox1.Text;
            }
        }
	}
}
