using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.FlexGrid;
using C1.Win.C1Chart;

namespace GridChart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private C1.Win.C1Chart.C1Chart _chart;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox _checkRotate;
		private System.Windows.Forms.CheckBox _checkGridlines;
		private System.Windows.Forms.Button _btnInsert;
		private System.Windows.Forms.Button _btnDelete;
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

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._chart = new C1.Win.C1Chart.C1Chart();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this._checkRotate = new System.Windows.Forms.CheckBox();
			this._checkGridlines = new System.Windows.Forms.CheckBox();
			this._btnInsert = new System.Windows.Forms.Button();
			this._btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = @"4,1,0,0,0,75,Columns:0{Width:18;}	1{Caption:""X"";TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	2{Caption:""Series 1"";DataType:System.Single;Format:""#,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}	3{Caption:""Series 2"";DataType:System.Single;Format:""#,##0.00"";TextAlign:RightCenter;TextAlignFixed:RightCenter;}";
			this._flex.Dock = System.Windows.Forms.DockStyle.Left;
			this._flex.Location = new System.Drawing.Point(0, 40);
			this._flex.Name = "_flex";
			this._flex.Rows.Count = 13;
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(248, 309);
			this._flex.TabIndex = 0;
			this._flex.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_AfterEdit);
			// 
			// _chart
			// 
			this._chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this._chart.Location = new System.Drawing.Point(254, 40);
			this._chart.Name = "_chart";
			this._chart.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Footer Compass=\"South\"><Text /><" +
				"/Footer><Legend Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartArea /><Ch" +
				"artGroupsCollection><ChartGroup><DataSerializer DefaultSet=\"True\"><DataSeriesCol" +
				"lection><DataSeriesSerializer><Y1 /><SeriesLabel>series 0</SeriesLabel><DataType" +
				"s>Single;Single;Single;Single;Single</DataTypes><X>1;2;3;4;5</X><Y2 /><Y>20;22;1" +
				"9;24;25</Y><Y3 /><LineStyle Pattern=\"Solid\" Thickness=\"1\" Color=\"DarkGoldenrod\" " +
				"/><SymbolStyle Shape=\"Box\" Color=\"Coral\" /></DataSeriesSerializer><DataSeriesSer" +
				"ializer><Y1 /><SeriesLabel>series 1</SeriesLabel><DataTypes>Single;Single;Single" +
				";Single;Single</DataTypes><X>1;2;3;4;5</X><Y2 /><Y>8;12;10;12;15</Y><Y3 /><LineS" +
				"tyle Pattern=\"Solid\" Thickness=\"1\" Color=\"DarkGray\" /><SymbolStyle Shape=\"Dot\" C" +
				"olor=\"CornflowerBlue\" /></DataSeriesSerializer></DataSeriesCollection></DataSeri" +
				"alizer><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Name>Group1</Name><Polar>Degr" +
				"ees=True,PiRatioAnnotations=True,Start=0</Polar><ShowOutline>True</ShowOutline><" +
				"Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOffset=0,Start=0</Pie><" +
				"ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>EncodingMethod=Diame" +
				"ter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalling=True,FillTranspar" +
				"ent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoData></ChartGroup><Ch" +
				"artGroup><DataSerializer /><Bar>ClusterOverlap=0,ClusterWidth=50</Bar><Name>Grou" +
				"p2</Name><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar><ShowOutline" +
				">True</ShowOutline><Radar>Degrees=True,Filled=False,Start=0</Radar><Pie>OtherOff" +
				"set=0,Start=0</Pie><ChartType>XYPlot</ChartType><Stacked>False</Stacked><Bubble>" +
				"EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><HiLoData>FillFalli" +
				"ng=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen=True</HiLoD" +
				"ata></ChartGroup></ChartGroupsCollection><StyleCollection><NamedStyle><Name>Plot" +
				"Area</Name><ParentName>Area</ParentName><StyleData>Border=None,Control,1;</Style" +
				"Data></NamedStyle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</Par" +
				"entName><StyleData /></NamedStyle><NamedStyle><Name>Footer</Name><ParentName>Con" +
				"trol</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><Name" +
				"dStyle><Name>Area</Name><ParentName>Area.default</ParentName><StyleData /></Name" +
				"dStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</ParentName><" +
				"StyleData /></NamedStyle><NamedStyle><Name>AxisX</Name><ParentName>Area</ParentN" +
				"ame><StyleData>Rotation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor" +
				"=Transparent;AlignVert=Bottom;</StyleData></NamedStyle><NamedStyle><Name>AxisY</" +
				"Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;Border=None,Cont" +
				"rol,1;AlignHorz=Near;BackColor=Transparent;AlignVert=Center;</StyleData></NamedS" +
				"tyle><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.def" +
				"ault</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend.default</Nam" +
				"e><ParentName>Control</ParentName><StyleData>Border=None,Black,1;Wrap=False;Alig" +
				"nVert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyleDefault.default</" +
				"Name><ParentName>Control</ParentName><StyleData>Border=None,Control,1;BackColor=" +
				"Transparent;</StyleData></NamedStyle><NamedStyle><Name>Header</Name><ParentName>" +
				"Control</ParentName><StyleData>Border=None,Control,1;</StyleData></NamedStyle><N" +
				"amedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=Control" +
				"Text;Border=None,Control,1;BackColor=Control;</StyleData></NamedStyle><NamedStyl" +
				"e><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate90;B" +
				"order=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVert=Center;</" +
				"StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentName>Control<" +
				"/ParentName><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData></NamedSt" +
				"yle></StyleCollection><Header Compass=\"North\"><Text /></Header><Axes><Axis Compa" +
				"ss=\"South\" Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMi" +
				"nor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\"><GridMajor AutoSpace=\"True\" " +
				"Pattern=\"Dash\" Thickness=\"1\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Pat" +
				"tern=\"Dash\" Thickness=\"1\" Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"West" +
				"\" Max=\"25\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"1\" AutoMajor=\"True\" AutoMinor=\"True\"" +
				" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\"><GridMajor AutoSpace=\"True\" Pattern=\"D" +
				"ash\" Thickness=\"1\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Pattern=\"Dash" +
				"\" Thickness=\"1\" Color=\"LightGray\" /><Text /></Axis><Axis Compass=\"East\" Max=\"0\" " +
				"Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"T" +
				"rue\" AutoMin=\"True\" _onTop=\"0\"><GridMajor AutoSpace=\"True\" Pattern=\"Dash\" Thickn" +
				"ess=\"1\" Color=\"LightGray\" /><GridMinor AutoSpace=\"True\" Pattern=\"Dash\" Thickness" +
				"=\"1\" Color=\"LightGray\" /><Text /></Axis></Axes></Chart2DPropBag>";
			this._chart.Size = new System.Drawing.Size(378, 309);
			this._chart.TabIndex = 1;
			this._chart.MouseDown += new System.Windows.Forms.MouseEventHandler(this._chart_MouseDown);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(248, 40);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(6, 309);
			this.splitter1.TabIndex = 2;
			this.splitter1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this._btnInsert,
																				 this._checkRotate,
																				 this._checkGridlines,
																				 this._btnDelete});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(632, 40);
			this.panel1.TabIndex = 3;
			// 
			// _checkRotate
			// 
			this._checkRotate.Location = new System.Drawing.Point(256, 12);
			this._checkRotate.Name = "_checkRotate";
			this._checkRotate.Size = new System.Drawing.Size(112, 16);
			this._checkRotate.TabIndex = 0;
			this._checkRotate.Text = "Rotate Labels";
			this._checkRotate.CheckedChanged += new System.EventHandler(this._checkRotate_CheckedChanged);
			// 
			// _checkGridlines
			// 
			this._checkGridlines.Location = new System.Drawing.Point(384, 12);
			this._checkGridlines.Name = "_checkGridlines";
			this._checkGridlines.Size = new System.Drawing.Size(112, 16);
			this._checkGridlines.TabIndex = 0;
			this._checkGridlines.Text = "Gridlines";
			this._checkGridlines.CheckedChanged += new System.EventHandler(this._checkGridlines_CheckedChanged);
			// 
			// _btnInsert
			// 
			this._btnInsert.Location = new System.Drawing.Point(8, 8);
			this._btnInsert.Name = "_btnInsert";
			this._btnInsert.Size = new System.Drawing.Size(104, 24);
			this._btnInsert.TabIndex = 1;
			this._btnInsert.Text = "Insert Data Point";
			this._btnInsert.Click += new System.EventHandler(this._btnInsert_Click);
			// 
			// _btnDelete
			// 
			this._btnDelete.Location = new System.Drawing.Point(120, 8);
			this._btnDelete.Name = "_btnDelete";
			this._btnDelete.Size = new System.Drawing.Size(104, 24);
			this._btnDelete.TabIndex = 1;
			this._btnDelete.Text = "Delete Data Point";
			this._btnDelete.Click += new System.EventHandler(this._btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 349);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._chart,
																		  this.splitter1,
																		  this._flex,
																		  this.panel1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Charting with C1Chart";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
			this.panel1.ResumeLayout(false);
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

		private void UpdateChart()
		{
			// populate X labels
			int col = 1;
			Axis ax = _chart.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			for (int i = _flex.Rows.Fixed; i < _flex.Rows.Count; i++)
				ax.ValueLabels.Add(i, _flex[i, col].ToString());
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;

			// populate series
			int cnt = _flex.Rows.Count - _flex.Rows.Fixed;
			float[] arr = new float[cnt];
			foreach (ChartDataSeries cds in _chart.ChartGroups[0].ChartData.SeriesList)
			{
				// increment grid column index
				col++;
				if (col >= _flex.Cols.Count)
					break;

				// x values
				for (int i = 0; i < cnt; i++)
					arr[i] = i;
				cds.X.CopyDataIn(arr);

				// y values
				for (int i = 0; i < cnt; i++)
				{
					try
					{
						arr[i] = (float)_flex[i + _flex.Rows.Fixed, col];
					}
					catch
					{
						arr[i] = (float)cds.Y.Hole;
					}
				}
				cds.Y.CopyDataIn(arr);
			}
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// populate grid
			Random rnd = new Random();
			DateTime dt;
			for (int i = 1; i <= 12; i++)
			{
				dt = new DateTime(2002, i, 1);
				_flex[i,1] = string.Format("{0:MMMM}", dt);
				_flex[i,2] = rnd.Next(100000)/100.0;
				_flex[i,3] = rnd.Next(100000)/100.0;
			}

			// and update the chart
			UpdateChart();
		}
		
		// rotate X-axis labels
		private void _checkRotate_CheckedChanged(object sender, System.EventArgs e)
		{
			Axis ax = _chart.ChartArea.AxisX;
			ax.AnnotationRotation = (_checkRotate.Checked)? 270: 0;
		}

		// show/hide gridlines
		private void _checkGridlines_CheckedChanged(object sender, System.EventArgs e)
		{
			ChartGridStyle[] cgs = new ChartGridStyle[] { _chart.ChartArea.AxisX.GridMajor, _chart.ChartArea.AxisY.GridMajor};
			foreach (ChartGridStyle style in cgs)
			{
				style.Color	  = Color.DarkGray;
				style.Visible = _checkGridlines.Checked;
			}
		}

		// update the chart after the user changed a value
		private void _flex_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			UpdateChart();
		}

		// when the user clicks a point on the chart, select the data on the grid
		private void _chart_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				int series   = -1;
				int point    = -1;
				int distance = -1;
				ChartGroup grp = _chart.ChartGroups[0];
				bool foundDataPoint = grp.CoordToDataIndex(e.X, e.Y, CoordinateFocusEnum.XandYCoord, ref series, ref point, ref distance);
				if (foundDataPoint && distance < 10)
				{
					_flex.Select(point + _flex.Rows.Fixed, series + _flex.Cols.Fixed + 1);
					_flex.Focus();
				}
			}
		}

		// insert a data point
		private void _btnInsert_Click(object sender, System.EventArgs e)
		{
			int index = _flex.Row;
			if (index < 1) index = _flex.Rows.Count;
			_flex.Rows.Insert(index);
			_flex[index, 1] = "New Point";
			_flex[index, 2] = 0;
			_flex[index, 3] = 0;
			UpdateChart();
		}

		// remove a data point
		private void _btnDelete_Click(object sender, System.EventArgs e)
		{
			int index = _flex.Row;
			if (index >= 1)
				_flex.Rows.Remove(index);
			UpdateChart();
		}
	}
}
