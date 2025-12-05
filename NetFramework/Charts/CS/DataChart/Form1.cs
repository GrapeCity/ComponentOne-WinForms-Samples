using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using C1.Win.C1Chart;

namespace DataChart
{
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.C1Chart.C1Chart c1Chart1;
        private System.Windows.Forms.ListBox lstCategories;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.lstCategories = new System.Windows.Forms.ListBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(112, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle><Nam" +
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
				"ataFields><Tag /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" +
				"<Name>Group1</Name><Stacked>False</Stacked><ChartType>Bar</ChartType><Pie>OtherO" +
				"ffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><HiLoData>FillFa" +
				"lling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</Hi" +
				"LoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Pol" +
				"ar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degrees=True,Fille" +
				"d=False,Start=0</Radar><Use3D>False</Use3D><Visible>True</Visible><ShowOutline>T" +
				"rue</ShowOutline></ChartGroup><ChartGroup><DataSerializer Hole=\"3.40282346638528" +
				"86E+38\" /><Name>Group2</Name><Stacked>False</Stacked><ChartType>XYPlot</ChartTyp" +
				"e><Pie>OtherOffset=0,Start=0</Pie><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Hi" +
				"LoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,Show" +
				"Open=True</HiLoData><Bubble>EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5" +
				"</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><Radar>Degre" +
				"es=True,Filled=False,Start=0</Radar><Visible>True</Visible><ShowOutline>True</Sh" +
				"owOutline></ChartGroup></ChartGroupsCollection><Header Compass=\"North\"><Text /><" +
				"/Header><Footer Compass=\"South\"><Text /></Footer><Legend Compass=\"East\" Visible=" +
				"\"False\"><Text /></Legend><ChartArea Inverted=\"True\" /><Axes><Axis Max=\"5.5\" Min=" +
				"\"0.5\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"T" +
				"rue\" AutoMin=\"True\" _onTop=\"0\" Compass=\"West\"><Text /><GridMajor AutoSpace=\"True" +
				"\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" T" +
				"hickness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"25\" Min=\"19\" U" +
				"nitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" Au" +
				"toMin=\"True\" _onTop=\"0\" Compass=\"South\"><Text /><GridMajor AutoSpace=\"True\" Thic" +
				"kness=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickne" +
				"ss=\"1\" Color=\"LightGray\" Pattern=\"Dash\" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor" +
				"=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"Tru" +
				"e\" _onTop=\"0\" Compass=\"North\"><Text /><GridMajor AutoSpace=\"True\" Thickness=\"1\" " +
				"Color=\"LightGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Col" +
				"or=\"LightGray\" Pattern=\"Dash\" /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(520, 423);
			this.c1Chart1.TabIndex = 0;
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
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 423);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.lstCategories});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Chart: Data Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
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

        DataTable _dtCat, _dtPrd;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // load data (categories and products)
			string dbdir = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
				"\\ComponentOne Samples\\Common";
			string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbdir + "\\C1NWind.mdb;";

            OleDbDataAdapter daCat = new OleDbDataAdapter("select * from Categories", conn);
            _dtCat = new DataTable("Categories");
            daCat.Fill(_dtCat);

            OleDbDataAdapter daPrd = new OleDbDataAdapter("select * from Products", conn);
            _dtPrd = new DataTable("Products");
            daPrd.Fill(_dtPrd);

            // initialize chart
            c1Chart1.Header.Style.Font = new Font("Arial", 14);
            c1Chart1.Legend.Visible = true;
            c1Chart1.Legend.Compass = CompassEnum.South;
            Axis ax = c1Chart1.ChartArea.AxisX;
            ax.TickMinor = TickMarksEnum.None;
            Axis ay = c1Chart1.ChartArea.AxisY;
            ay.TickMinor = TickMarksEnum.None;
            ay.GridMajor.Visible = true;
            ay.GridMajor.Color = Color.White;
            ay.GridMajor.Pattern = LinePatternEnum.Dot;

            // populate categories list
            foreach (DataRow dr in _dtCat.Rows)
                lstCategories.Items.Add(dr["CategoryName"].ToString());

            // select first category (will update the chart)
            lstCategories.SelectedIndex = 0;
        }

        // update chart when the selected category changes
        private void lstCategories_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // find selected categoryID
            int    catID   = -1;
            string catName = lstCategories.SelectedItem.ToString();
            foreach (DataRow dr in _dtCat.Rows)
            {
                if (dr["CategoryName"].ToString() == catName)
                {
                    catID = int.Parse(dr["CategoryID"].ToString());
                    break;
                }
            }

            // apply filter to data table
            DataView dv = _dtPrd.DefaultView;
            dv.RowFilter = string.Format("CategoryID = {0}", catID);

            // sort by unit price
            dv.Sort = "UnitPrice DESC";

            // copy data from table to chart
            c1Chart1.Header.Text = lstCategories.SelectedItem.ToString();
            BindSeries(c1Chart1, 0, dv, "UnitPrice",    "ProductName");
            BindSeries(c1Chart1, 1, dv, "UnitsInStock");
            BindSeries(c1Chart1, 2, dv, "ReorderLevel");
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
            ITypedList il = (ITypedList)dataSource;
            IList list = (IList)dataSource;
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
