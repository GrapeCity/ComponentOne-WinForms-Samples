using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using C1.Win.C1Chart;

namespace AlarmZoneShapes
{
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.Windows.Forms.CheckedListBox zoneSelect;
		private System.Windows.Forms.Label labDescription;
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
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.zoneSelect = new System.Windows.Forms.CheckedListBox();
			this.labDescription = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Location = new System.Drawing.Point(250, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=None,Transparent,1;\" /><NamedSty" +
				"le Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle Name=\"Footer\" ParentN" +
				"ame=\"Control\" StyleData=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Area\" P" +
				"arentName=\"Area.default\" /><NamedStyle Name=\"Control\" ParentName=\"Control.defaul" +
				"t\" StyleData=\"BackColor=WhiteSmoke;\" /><NamedStyle Name=\"AxisX\" ParentName=\"Area" +
				"\" StyleData=\"Rotation=Rotate0;AlignHorz=Center;AlignVert=Bottom;\" /><NamedStyle " +
				"Name=\"AxisY\" ParentName=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;Alig" +
				"nVert=Center;\" /><NamedStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefa" +
				"ult.default\" /><NamedStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=" +
				"\"Border=None,Transparent,1;Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"LabelS" +
				"tyleDefault.default\" ParentName=\"Control\" StyleData=\"Border=None,Transparent,1;B" +
				"ackColor=Transparent;\" /><NamedStyle Name=\"Header\" ParentName=\"Control\" StyleDat" +
				"a=\"Border=None,Transparent,1;\" /><NamedStyle Name=\"Control.default\" ParentName=\"" +
				"\" StyleData=\"ForeColor=ControlText;Border=None,Transparent,1;BackColor=Control;\"" +
				" /><NamedStyle Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;Alig" +
				"nHorz=Far;AlignVert=Center;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Contr" +
				"ol\" StyleData=\"Border=None,Transparent,1;AlignVert=Top;\" /></StyleCollection><Ch" +
				"artGroupsCollection><ChartGroup Name=\"Group1\"><DataSerializer DefaultSet=\"True\">" +
				"<DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"DarkGoldenrod\" /><" +
				"SymbolStyle Color=\"Coral\" Shape=\"Box\" /><SeriesLabel>series 0</SeriesLabel><X>1;" +
				"2;3;4;5</X><Y>20;22;19;24;25</Y><DataTypes>Single;Single;Double;Double;Double</D" +
				"ataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer><DataS" +
				"eriesSerializer><LineStyle Color=\"DarkGray\" /><SymbolStyle Color=\"CornflowerBlue" +
				"\" Shape=\"Dot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12" +
				";15</Y><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;" +
				"</DataFields><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyl" +
				"e Color=\"DarkGreen\" /><SymbolStyle Color=\"Cornsilk\" Shape=\"Tri\" /><SeriesLabel>s" +
				"eries 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><DataTypes>Single;Sing" +
				"le;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><FillStyle /></D" +
				"ataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"DarkKhaki\" /><Symbol" +
				"Style Color=\"Crimson\" Shape=\"Diamond\" /><SeriesLabel>series 3</SeriesLabel><X>1;" +
				"2;3;4;5</X><Y>16;19;15;22;18</Y><DataTypes>Single;Single;Double;Double;Double</D" +
				"ataTypes><DataFields>;;;;</DataFields><FillStyle /></DataSeriesSerializer></Data" +
				"SeriesCollection></DataSerializer></ChartGroup><ChartGroup Name=\"Group2\"><DataSe" +
				"rializer /></ChartGroup></ChartGroupsCollection><Header Compass=\"North\" /><Foote" +
				"r Compass=\"South\" /><Legend Compass=\"East\" Visible=\"False\" /><ChartArea /><Axes>" +
				"<Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"" +
				"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><GridMajor /><GridMinor /></" +
				"Axis><Axis Max=\"25\" Min=\"8\" UnitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoM" +
				"inor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West\"><GridMajor /><GridMinor" +
				" /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"0\" AutoMajor=\"True\" Aut" +
				"oMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"East\"><GridMajor /><GridMin" +
				"or /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(424, 448);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			// 
			// zoneSelect
			// 
			this.zoneSelect.BackColor = System.Drawing.SystemColors.Control;
			this.zoneSelect.Items.AddRange(new object[] {
															"AlarmZone 0 (Rectangle)",
															"AlarmZone 1 (Ellipse)",
															"AlarmZone 2 (Polygon Coordinates)",
															"AlarmZone 3 (Polygon DataSeries)",
															"AlarmZone 4 (Fixed Size)"});
			this.zoneSelect.Location = new System.Drawing.Point(8, 56);
			this.zoneSelect.Name = "zoneSelect";
			this.zoneSelect.Size = new System.Drawing.Size(224, 79);
			this.zoneSelect.TabIndex = 5;
			this.zoneSelect.SelectedIndexChanged += new System.EventHandler(this.zoneSelect_SelectedIndexChanged);
			this.zoneSelect.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.zoneSelect_ItemCheck);
			// 
			// labDescription
			// 
			this.labDescription.Location = new System.Drawing.Point(8, 152);
			this.labDescription.Name = "labDescription";
			this.labDescription.Size = new System.Drawing.Size(224, 64);
			this.labDescription.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(224, 48);
			this.label2.TabIndex = 7;
			this.label2.Text = "Check an AlarmZone entry to show it on the chart.  Select an AlarmZone for short " +
				"description and to explore its properties.";
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(8, 224);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(232, 224);
			this.propertyGrid1.TabIndex = 8;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 469);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.propertyGrid1,
																		  this.label2,
																		  this.labDescription,
																		  this.zoneSelect,
																		  this.c1Chart1});
			this.Location = new System.Drawing.Point(100, 200);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "AlarmZones";
			this.Resize += new System.EventHandler(this.Form1_Resize);
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

		PointF[] GetPoints(int funcType, int nElements, double xstart, double xend, double ylow, double yhigh)
		{
			PointF [] pts = (PointF[])Array.CreateInstance(typeof(PointF),nElements);

			switch (funcType)
			{
				case 1:
				{
					// x and y values form a sine curve for 1.5 cycles
					for(int i=0; i < nElements; i++)
					{
						double xd = xstart + i * (xend - xstart)/(nElements-1);
						double yd = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI;
						double yh = (yhigh - ylow) * 0.5;
						pts[i].X = (float)xd;
						pts[i].Y = (float)(Math.Sin(yd) * yh + ylow + yh);
					}
				}
					break;

				case 3:
					// x and y values form a sine curve for 1.5 cycles with random aspects
					Random rnd = new Random();
					for(int i=0; i < nElements; i++)
					{
						double xd = xstart + i * (xend - xstart)/(nElements-1);
						double yd = (xd - xstart) / (xend - xstart) * 3.0 * Math.PI;
						double yh = (yhigh - ylow) * 0.5;
						pts[i].X = (float)xd;
						pts[i].Y = (float)(Math.Sin(yd) * yh + ylow + yh) + (float)(0.5 * yh * rnd.NextDouble());
					}
					break;
			}

			return pts;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Form1_Resize(null, null);
			c1Chart1.ChartArea.AxisY.SetMinMax(0, 30);

			// using the routine GetPoints defined above, create some
			// additional data and add it to the chart.
			PointF[] pfs = GetPoints(3, 201, 1, 5, 1, 7.5);
			ChartDataSeriesCollection cdsc = c1Chart1.ChartGroups[0].ChartData.SeriesList;
			ChartDataSeries cds = cdsc.AddNewSeries();
			cds.PointData.CopyDataIn(pfs);
			cds.SymbolStyle.Shape = SymbolShapeEnum.None;

			// turn on all of the checked listbox items.
			for(int z=0; z < zoneSelect.Items.Count; z++)
				zoneSelect.SetItemChecked(z, true);

			// create the alarm zones.
			AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;

			// add the rectangle
			AlarmZone az = azs.AddNewZone();
			az.Name = (string)zoneSelect.Items[0];
			az.BackColor = Color.FromArgb(100,Color.Red);
			az.Shape = AlarmZoneShapeEnum.Rectangle;
			az.UpperExtent = 20;
			az.LowerExtent = 16;
			az.FarExtent = 2.5;
			az.NearExtent = 1.5;
			az.Visible = true;

			// add the ellipse
			az = azs.AddNewZone();
			az.BackColor = Color.FromArgb(100,Color.Blue);
			az.Shape = AlarmZoneShapeEnum.Ellipse;
			az.Name = (string)zoneSelect.Items[1];
			az.UpperExtent = 24;
			az.LowerExtent = 16;
			az.FarExtent = 4.5;
			az.NearExtent = 3;
			az.Visible = true;

			// add a polygon defined by coordinates.  Coordinates
			// are obtained using the GetPoints method defined above.
			az = azs.AddNewZone();
			az.BackColor = Color.FromArgb(100,Color.Green);
			az.Shape = AlarmZoneShapeEnum.Polygon;
			az.Name = (string)zoneSelect.Items[2];
			az.UpperExtent = 14;
			az.LowerExtent = 8;
			az.FarExtent = 4.5;
			az.NearExtent = 2.5;
			pfs = GetPoints(1, 15, az.NearExtent, az.FarExtent, 
				az.LowerExtent, az.UpperExtent);
			az.PolygonData.PointData.CopyDataIn(pfs);
			az.Visible = true;

			// add a polygon
			az = azs.AddNewZone();
			az.BackColor = Color.FromArgb(100,Color.Yellow);
			az.PatternStyle = HatchStyle.DiagonalBrick;
			az.PatternVisible = true;
			az.Shape = AlarmZoneShapeEnum.Rectangle;
			az.Name = (string)zoneSelect.Items[4];
			az.UpperExtent = 24;
			az.LowerExtent = 24;
			az.FarExtent = 3;
			az.NearExtent = 3;
			az.MinHeight = 32;
			az.MinWidth = 32;
			az.Visible = true;

			// add another polygon defined by the DataSeries.
			az = azs.AddNewZone();
			az.BackColor = Color.FromArgb(100,Color.Brown);
			az.Shape = AlarmZoneShapeEnum.Polygon;
			az.PolygonData.PolygonSource = PolygonSourceEnum.DataSeries;
			az.PolygonData.SeriesIndex = 4;
			az.Name = (string)zoneSelect.Items[3];
			az.UpperExtent = 10;
			az.LowerExtent = 6;
			az.NearExtent = 1.15;
			az.FarExtent = 2.25;
			az.Visible = true;


			// Add a Header that will be updated to the current AlarmZone
			// under the cursor.
			c1Chart1.Header.Text = "-- Mouse is not over an AlarmZone --";

			// now select the first alarmzone
			zoneSelect.SelectedIndex = 0;

			// Add some marker style ValueLabels.  These will be used to
			// mark the Near and Far extents of the DataSeries AlarmZone
			Axis ax = c1Chart1.ChartArea.AxisX;
			ax.AnnoMethod = AnnotationMethodEnum.Mixed;
			
			ValueLabel vl = ax.ValueLabels.AddNewLabel();
			vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker;
			vl.Text = "M1";
			vl.Color = Color.FromArgb(100,Color.Red);
			vl.GridLine = true;
			vl.Moveable = true;
			vl.NumericValue = az.NearExtent;
			vl.ValueChanged += new EventHandler(ValueLabelChangedHandler);//!!VBSubst AddHandler vl.ValueChanged, AddressOf ValueLabelChangedHandler
			vl.MarkerSize = 13;

			vl = ax.ValueLabels.AddNewLabel();
			vl.Appearance = ValueLabelAppearanceEnum.ArrowMarker;
			vl.Text = "M2";
			vl.Color = Color.FromArgb(100,Color.Red);
			vl.GridLine = true;
			vl.Moveable = true;
			vl.NumericValue = az.FarExtent;
			vl.ValueChanged += new EventHandler(ValueLabelChangedHandler);//!!VBSubst AddHandler vl.ValueChanged, AddressOf ValueLabelChangedHandler
			vl.MarkerSize = 13;

			// Call it to get markers and extensions recalculated.
			ValueLabelChangedHandler(null, null);

			// Add some instructions about how to use the markers.
			c1Chart1.Footer.Text = "Drag markers M1 and M2 along the X axis\n" +
				"to adjust the extents of the DataSeries sourced AlarmZone";
		}

		private void ValueLabelChangedHandler(object sender, EventArgs e)
		{
			ValueLabelsCollection vls = c1Chart1.ChartArea.AxisX.ValueLabels;
			string minMarker = "M1", maxMarker = "M2";
			if(vls["M1"].NumericValue > vls["M2"].NumericValue)
			{
				minMarker = "M2";  maxMarker = "M1";
			}

			float minValue = (float)vls[minMarker].NumericValue;
			float maxValue = (float)vls[maxMarker].NumericValue;

			string name = (string)zoneSelect.Items[3];
			AlarmZone az = c1Chart1.ChartArea.PlotArea.AlarmZones[name];

			int gi = az.GroupIndex;
			int si = az.PolygonData.SeriesIndex;
			ChartGroup cg = c1Chart1.ChartGroups[gi];
			ChartDataSeries cds = cg.ChartData.SeriesList[si];

			PointF[] pfs = (PointF[])cds.PointData.CopyDataOut();
			int pmin=-1, pmax=-1;
			float minY=float.MaxValue, maxY=float.MinValue;
			for(int p=0; p < pfs.Length; p++)
			{
                if (pmin < 0 && pfs[p].X >= minValue)
                    pmin = p;

				if(pmax < 0 && pfs[p].X >= maxValue)
				{
                    pmax = (pfs[p].X == maxValue) ? p :  p - 1;
					break;
				}

				if(pmin >= 0)
				{
					if(pfs[p].Y < minY) minY = pfs[p].Y;
					if(pfs[p].Y > maxY) maxY = pfs[p].Y;
				}
			}
			
			az.NearExtent = pfs[pmin].X;
			az.FarExtent = pfs[pmax].X;
			az.UpperExtent = maxY;
			az.LowerExtent = minY;
		}

		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			AlarmZonesCollection zones = c1Chart1.ChartArea.PlotArea.AlarmZones;
			AlarmZone az = zones.AlarmZoneAtCoord(e.X, e.Y);
			if(az != null)
			{
				Cursor.Current = Cursors.Cross;
				c1Chart1.Header.Text = "Mouse is over " + az.Name;
			}
			else
			{
				Cursor.Current = Cursors.Default;
				c1Chart1.Header.Text = "-- Mouse is not over an AlarmZone --";
			}	
		}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
			int w = ClientSize.Width - c1Chart1.Left;
			int h = ClientSize.Height;
			if(w < 10) w = 10;
			if(h < 10) h = 10;

			c1Chart1.Size = new Size(w,h);

			h = ClientSize.Height - propertyGrid1.Top;
			if(h < 10) h = 10;
			propertyGrid1.Height = h;
		}

		private void zoneSelect_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			string zname = (string)zoneSelect.SelectedItem;
			string description = "";
			if(zname.IndexOf("Rectangle") > 0)
				description = "A rectangle defined by data coordinates " +
					"specified by the AlarmZone extents.";

			else if(zname.IndexOf("Ellipse") > 0)
				description = "An ellipse bounded by a rectangle defined by " +
					"data coordinates specified by the AlarmZone extents.";

			else if(zname.IndexOf("Polygon Coordinates") > 0)
				description = "A polygon defined by a set of X,Y data coordinates. " +
					"Polygons are automatically close with a straight line.";

			else if(zname.IndexOf("Polygon DataSeries") > 0)
				description = "A polygon defined by a combination of a ChartDataSeries " +
					"and the extents of the AlarmZone which are used for clipping " +
					"the AlarmZone.";

			else if(zname.IndexOf("Fixed Size") > 0)
				description = "Fixed size AlarmZones are located by data coordinates, " +
					"and sized using the MinWidth and MinHeight properties. " +
					"Applicable to Rectangle and Ellipse shaped AlarmZones.";

			labDescription.Text = description;
			AlarmZonesCollection zones = c1Chart1.ChartArea.PlotArea.AlarmZones;
			propertyGrid1.SelectedObject = zones[zname];
		}

		private void zoneSelect_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
		{
			if(e.Index >= 0)
			{
				string name = (string)zoneSelect.Items[e.Index];
				bool isChecked = e.NewValue.Equals(CheckState.Checked);
				AlarmZonesCollection zones = c1Chart1.ChartArea.PlotArea.AlarmZones;
				if(zones[name] != null)
					zones[name].Visible = isChecked;
			}
		}
	}
}
