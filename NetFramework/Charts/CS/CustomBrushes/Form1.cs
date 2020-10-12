using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel.Design;

using C1.Win.C1Chart;

namespace CustomBrushes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.ComboBox cbChartType;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbStacked;
		private System.Windows.Forms.CheckBox cbUse3D;
		private System.Windows.Forms.CheckBox cbLegend;
		private System.Windows.Forms.ImageList ilTextures;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbStacked = new System.Windows.Forms.CheckBox();
			this.cbUse3D = new System.Windows.Forms.CheckBox();
			this.cbLegend = new System.Windows.Forms.CheckBox();
			this.cbChartType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.ilTextures = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.propertyGrid1,
																																				 this.panel2});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 453);
			this.panel1.TabIndex = 1;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Location = new System.Drawing.Point(0, 72);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(200, 381);
			this.propertyGrid1.TabIndex = 8;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ToolbarVisible = false;
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																																				 this.cbStacked,
																																				 this.cbUse3D,
																																				 this.cbLegend,
																																				 this.cbChartType,
																																				 this.label4});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 72);
			this.panel2.TabIndex = 7;
			// 
			// cbStacked
			// 
			this.cbStacked.Location = new System.Drawing.Point(8, 32);
			this.cbStacked.Name = "cbStacked";
			this.cbStacked.Size = new System.Drawing.Size(64, 24);
			this.cbStacked.TabIndex = 3;
			this.cbStacked.Text = "Stacked";
			this.cbStacked.CheckedChanged += new System.EventHandler(this.cbStacked_CheckedChanged);
			// 
			// cbUse3D
			// 
			this.cbUse3D.Location = new System.Drawing.Point(80, 32);
			this.cbUse3D.Name = "cbUse3D";
			this.cbUse3D.Size = new System.Drawing.Size(40, 24);
			this.cbUse3D.TabIndex = 4;
			this.cbUse3D.Text = "3D";
			this.cbUse3D.CheckedChanged += new System.EventHandler(this.cbUse3D_CheckedChanged);
			// 
			// cbLegend
			// 
			this.cbLegend.Location = new System.Drawing.Point(120, 32);
			this.cbLegend.Name = "cbLegend";
			this.cbLegend.Size = new System.Drawing.Size(64, 24);
			this.cbLegend.TabIndex = 5;
			this.cbLegend.Text = "Legend";
			this.cbLegend.CheckedChanged += new System.EventHandler(this.cbLegend_CheckedChanged);
			// 
			// cbChartType
			// 
			this.cbChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbChartType.Items.AddRange(new object[] {
																										 "XYPlot",
																										 "Area",
																										 "Bar",
																										 "Pie"});
			this.cbChartType.Location = new System.Drawing.Point(80, 8);
			this.cbChartType.Name = "cbChartType";
			this.cbChartType.Size = new System.Drawing.Size(80, 21);
			this.cbChartType.TabIndex = 1;
			this.cbChartType.SelectedIndexChanged += new System.EventHandler(this.cbChartType_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 2;
			this.label4.Text = "Chart type:";
			// 
			// c1Chart1
			// 
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(200, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><ChartGroupsCollection><ChartGrou" +
				"p><ShowOutline>True</ShowOutline><Bubble>EncodingMethod=Diameter,MaximumSize=20," +
				"MinimumSize=5</Bubble><Polar>Degrees=True,PiRatioAnnotations=True,Start=0</Polar" +
				"><Stacked>False</Stacked><Radar>Degrees=True,Filled=False,Start=0</Radar><HiLoDa" +
				"ta>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClose=True,ShowOpen" +
				"=True</HiLoData><Name>Group1</Name><Pie>OtherOffset=0,Start=0</Pie><Visible>True" +
				"</Visible><DataSerializer DefaultSet=\"True\" Hole=\"3.4028234663852886E+38\"><DataS" +
				"eriesCollection><DataSeriesSerializer><X>1;2;3;4;5</X><SeriesLabel>series 0</Ser" +
				"iesLabel><DataTypes>Single;Single;Double;Double;Double</DataTypes><Y1 /><Y2 /><Y" +
				"3 /><Y>20;22;19;24;25</Y><SymbolStyle Shape=\"Box\" Color=\"Coral\" /><LineStyle Pat" +
				"tern=\"Solid\" Color=\"DeepSkyBlue\" Thickness=\"10\" /></DataSeriesSerializer><DataSe" +
				"riesSerializer><X>1;2;3;4;5</X><SeriesLabel>series 1</SeriesLabel><DataTypes>Sin" +
				"gle;Single;Double;Double;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>8;12;10;12;15</Y" +
				"><SymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue\" /><LineStyle Pattern=\"Solid\" Co" +
				"lor=\"RoyalBlue\" Thickness=\"10\" /></DataSeriesSerializer><DataSeriesSerializer><X" +
				">1;2;3;4;5</X><SeriesLabel>series 2</SeriesLabel><DataTypes>Single;Single;Double" +
				";Double;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>10;16;17;15;23</Y><SymbolStyle Sh" +
				"ape=\"Tri\" Color=\"Cornsilk\" /><LineStyle Pattern=\"Solid\" Color=\"MidnightBlue\" Thi" +
				"ckness=\"10\" /></DataSeriesSerializer><DataSeriesSerializer FitType=\"Spline\"><X>1" +
				";2;3;4;5</X><SeriesLabel>series 3</SeriesLabel><DataTypes>Single;Single;Double;D" +
				"ouble;Double</DataTypes><Y1 /><Y2 /><Y3 /><Y>16;19;15;22;18</Y><SymbolStyle Shap" +
				"e=\"Diamond\" Color=\"Crimson\" /><LineStyle Pattern=\"Solid\" Color=\"LightSteelBlue\" " +
				"Thickness=\"10\" /></DataSeriesSerializer></DataSeriesCollection></DataSerializer>" +
				"<Use3D>False</Use3D><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWi" +
				"dth=50</Bar></ChartGroup><ChartGroup><ShowOutline>True</ShowOutline><Bubble>Enco" +
				"dingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Polar>Degrees=True,PiR" +
				"atioAnnotations=True,Start=0</Polar><Stacked>False</Stacked><Radar>Degrees=True," +
				"Filled=False,Start=0</Radar><HiLoData>FillFalling=True,FillTransparent=True,Full" +
				"Width=False,ShowClose=True,ShowOpen=True</HiLoData><Name>Group2</Name><Pie>Other" +
				"Offset=0,Start=0</Pie><Visible>True</Visible><DataSerializer Hole=\"3.40282346638" +
				"52886E+38\" /><ChartType>XYPlot</ChartType><Bar>ClusterOverlap=0,ClusterWidth=50<" +
				"/Bar></ChartGroup></ChartGroupsCollection><Header Compass=\"North\" Visible=\"False" +
				"\"><Text /></Header><Axes><Axis Compass=\"South\" _onTop=\"0\" Min=\"1\" UnitMajor=\"1\" " +
				"Max=\"5\" UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin" +
				"=\"True\"><GridMajor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"" +
				"1\" /><GridMinor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" " +
				"/><Text /></Axis><Axis Compass=\"West\" _onTop=\"0\" Min=\"8\" UnitMajor=\"1\" Max=\"25\" " +
				"UnitMinor=\"0.5\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\">" +
				"<GridMajor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><Gr" +
				"idMinor AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><Text " +
				"/></Axis><Axis Compass=\"East\" _onTop=\"0\" Min=\"0\" UnitMajor=\"0\" Max=\"0\" UnitMinor" +
				"=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\"><GridMajor " +
				"AutoSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><GridMinor Aut" +
				"oSpace=\"True\" Pattern=\"Dash\" Color=\"LightGray\" Thickness=\"1\" /><Text /></Axis></" +
				"Axes><Footer Compass=\"South\" Visible=\"False\"><Text /></Footer><Legend Orientatio" +
				"n=\"Auto\" Compass=\"East\" Visible=\"False\"><Text /></Legend><ChartArea Rotation=\"45" +
				"\" Depth=\"25\" Elevation=\"45\" /><StyleCollection><NamedStyle><StyleData>Border=Sol" +
				"id,ControlText,1;</StyleData><Name>PlotArea</Name><ParentName>Area</ParentName><" +
				"/NamedStyle><NamedStyle><StyleData /><Name>Legend</Name><ParentName>Legend.defau" +
				"lt</ParentName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;</Style" +
				"Data><Name>Footer</Name><ParentName>Control</ParentName></NamedStyle><NamedStyle" +
				"><StyleData /><Name>Area</Name><ParentName>Area.default</ParentName></NamedStyle" +
				"><NamedStyle><StyleData>Border=Solid,ControlText,1;</StyleData><Name>Control</Na" +
				"me><ParentName>Control.default</ParentName></NamedStyle><NamedStyle><StyleData>R" +
				"otation=Rotate0;Border=None,Control,1;AlignHorz=Center;BackColor=Transparent;Opa" +
				"que=False;AlignVert=Bottom;</StyleData><Name>AxisX</Name><ParentName>Area</Paren" +
				"tName></NamedStyle><NamedStyle><StyleData>Rotation=Rotate270;Border=None,Control" +
				",1;AlignHorz=Near;BackColor=Transparent;Opaque=False;AlignVert=Center;</StyleDat" +
				"a><Name>AxisY</Name><ParentName>Area</ParentName></NamedStyle><NamedStyle><Style" +
				"Data /><Name>LabelStyleDefault</Name><ParentName>LabelStyleDefault.default</Pare" +
				"ntName></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;Wrap=False;Alig" +
				"nVert=Top;</StyleData><Name>Legend.default</Name><ParentName>Control</ParentName" +
				"></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;BackColor=Transparent" +
				";</StyleData><Name>LabelStyleDefault.default</Name><ParentName>Control</ParentNa" +
				"me></NamedStyle><NamedStyle><StyleData>Border=None,Control,1;</StyleData><Name>H" +
				"eader</Name><ParentName>Control</ParentName></NamedStyle><NamedStyle><StyleData>" +
				"ForeColor=ControlText;Border=None,Control,1;BackColor=Control;</StyleData><Name>" +
				"Control.default</Name><ParentName /></NamedStyle><NamedStyle><StyleData>Rotation" +
				"=Rotate90;Border=None,Transparent,1;AlignHorz=Far;BackColor=Transparent;AlignVer" +
				"t=Center;</StyleData><Name>AxisY2</Name><ParentName>Area</ParentName></NamedStyl" +
				"e><NamedStyle><StyleData>Border=None,Control,1;AlignVert=Top;</StyleData><Name>A" +
				"rea.default</Name><ParentName>Control</ParentName></NamedStyle></StyleCollection" +
				"></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(432, 453);
			this.c1Chart1.TabIndex = 2;
			this.c1Chart1.DrawDataSeries += new C1.Win.C1Chart.DrawDataSeriesEventHandler(this.c1Chart1_DrawDataSeries);
			// 
			// ilTextures
			// 
			this.ilTextures.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilTextures.ImageSize = new System.Drawing.Size(12, 12);
			this.ilTextures.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTextures.ImageStream")));
			this.ilTextures.TransparentColor = System.Drawing.Color.Green;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.c1Chart1,
																																	this.panel1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ComponentOne Chart for .NET 2D - CustomBrushes Chart Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
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

		private void Form1_Load(object sender, System.EventArgs e)
		{

			cbChartType.Text = "XYPlot";

			m_serData = new SeriesData( c1Chart1, ilTextures);
			propertyGrid1.SelectedObject = m_serData;
			propertyGrid1.ExpandAllGridItems();
		}

		private void c1Chart1_DrawDataSeries(object sender, C1.Win.C1Chart.DrawDataSeriesEventArgs e)
		{
			SeriesInfo serInfo = m_serData.SeriesArray[e.SeriesIndex];

			switch( serInfo.BrushType)
			{
				case BrushType.Hatch:
					HatchBrush hb = new HatchBrush( serInfo.HatchStyle, serInfo.Color2, serInfo.Color1);
					e.Brush = hb;
					break;
				case BrushType.Gradient:
					RectangleF r = e.Bounds;
					PointF pt1 = PointF.Empty, pt2 = PointF.Empty;
					bool blend = false;

					switch( serInfo.GradientStyle)
					{
						case GradientStyle.Horizontal1:
						case GradientStyle.Horizontal2:
							pt1	= r.Location;
							pt2 = pt1;
							pt2.X += r.Width;
							if(serInfo.GradientStyle == GradientStyle.Horizontal2)
								blend = true;
							break;
						case GradientStyle.Vertical1:
						case GradientStyle.Vertical2:
							pt1	= r.Location;
							pt2 = pt1;
							pt2.Y += r.Height;
							if(serInfo.GradientStyle == GradientStyle.Vertical2)
								blend = true;
							break;
						case GradientStyle.Diagonal1:
						case GradientStyle.Diagonal2:
							pt1	= r.Location;
							pt2 = pt1;
							pt2.X += r.Width;
							pt2.Y += r.Height;
							if(serInfo.GradientStyle == GradientStyle.Diagonal2)
								blend = true;
							break;
						case GradientStyle.BackDiagonal1:
						case GradientStyle.BackDiagonal2:
							pt1	= r.Location;
							pt2 = pt1;
							pt2.X += r.Width;
							pt1.Y += r.Height;
							if(serInfo.GradientStyle == GradientStyle.BackDiagonal2)
								blend = true;
							break;
						case GradientStyle.Radial1:
						case GradientStyle.Radial2:
							GraphicsPath path = new GraphicsPath();
							if( c1Chart1.ChartGroups[0].ChartType == Chart2DTypeEnum.Pie)
								path.AddEllipse( e.Bounds);
							else
								path.AddRectangle( e.Bounds);

							PathGradientBrush pb = new PathGradientBrush(path);
							pb.CenterColor = serInfo.Color2;
							pb.CenterPoint = new PointF( e.Bounds.X + e.Bounds.Width /2, e.Bounds.Y + e.Bounds.Height /2);
							pb.SurroundColors = new Color[] { serInfo.Color1};
							if(serInfo.GradientStyle == GradientStyle.Radial2)
							{
								ColorBlend cb = new ColorBlend();
								cb.Colors = new Color[] { serInfo.Color1, serInfo.Color2, serInfo.Color1};
								cb.Positions = new float[]{ 0, 0.5f, 1.0f};
								pb.InterpolationColors = cb;
							}
							e.Brush = pb;
							path.Dispose();
							break;
					}

					if( !pt1.IsEmpty && !pt2.IsEmpty)
					{
						LinearGradientBrush gb = new LinearGradientBrush( pt1, pt2, serInfo.Color1, serInfo.Color2);
						if( blend)
						{
							ColorBlend cb = new ColorBlend();
							cb.Colors = new Color[] { serInfo.Color1, serInfo.Color2, serInfo.Color1};
							cb.Positions = new float[]{ 0, 0.5f, 1.0f};
							gb.InterpolationColors = cb;
						}
						e.Brush = gb;
					}
					break;
				case BrushType.Texture:
					if( serInfo.Image!=null)
					{
						TextureBrush tb = new TextureBrush( serInfo.Image, WrapMode.Tile);
						e.Brush = tb;
					}
					break;
			}
		}

		private HatchStyle[] hatchStyles = new HatchStyle[] { HatchStyle.Cross, HatchStyle.Horizontal, HatchStyle.Vertical, HatchStyle.Percent10};
		private SeriesData m_serData = null;

		private void cbChartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[0].ChartType = (Chart2DTypeEnum)Enum.Parse( typeof(Chart2DTypeEnum), cbChartType.Text);
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			c1Chart1.Invalidate();
		}

		private void cbStacked_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[0].Stacked = cbStacked.Checked;
		}

		private void cbUse3D_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.ChartGroups[0].Use3D = cbUse3D.Checked;
		}

		private void cbLegend_CheckedChanged(object sender, System.EventArgs e)
		{
			c1Chart1.Legend.Visible = cbLegend.Checked;
		}

		private void cbGradientType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			c1Chart1.Invalidate();
		}

		private void propertyGrid1_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			c1Chart1.Invalidate();
		}
	}

	enum BrushType
	{
		Hatch,
		Gradient,
		Texture
	}

	enum GradientStyle
	{
		Horizontal1,
		Horizontal2,
		Vertical1,
		Vertical2,
		Diagonal1,
		Diagonal2,
		BackDiagonal1,
		BackDiagonal2,
		Radial1,
		Radial2,
	}

	internal class SeriesInfoConverter : ExpandableObjectConverter
	{
		private static string hatchProps = "BrushType Color1 Color2 HatchStyle";
		private static string gradProps = "BrushType Color1 Color2 GradientStyle";
		private static string textProps = "BrushType Image";

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, System.Attribute[] attrs)//!!VBReplace-Overrides-Overloads Overrides-
		{
			if( context!=null && attrs!=null)
			{
				bool browse = false;

				foreach( Attribute attr in attrs)
				{
					if( attr is BrowsableAttribute)
					{
						BrowsableAttribute ba = (BrowsableAttribute) attr;
						if( ba.Browsable)
						{
							browse = true;
							break;
						}
					}
				}

				if( browse)
				{
					SeriesInfo si = null;
					if( value is SeriesInfo)
					{
						si = (SeriesInfo)value;
						if( si!=null)
						{
							PropertyDescriptorCollection pdcnew = new PropertyDescriptorCollection(null);
							PropertyDescriptorCollection pdc = TypeDescriptor.GetProperties( value, attrs);

							foreach( PropertyDescriptor pd in pdc)
							{
								switch(si.BrushType)
								{
									case BrushType.Hatch:
										if( hatchProps.IndexOf( pd.Name)!=-1)
											pdcnew.Add( pd);
										break;
									case BrushType.Gradient:
										if( gradProps.IndexOf( pd.Name)!=-1)
											pdcnew.Add( pd);
										break;
									case BrushType.Texture:
										if( textProps.IndexOf( pd.Name)!=-1)
											pdcnew.Add( pd);
										break;
								}
							}

							return pdcnew;
						}
					}
				}
			}
			return base.GetProperties( context, value, attrs);
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)//!!VBReplace-Overrides-Overloads Overrides-
		{
			return true;
		}
	}

	[TypeConverter(typeof(SeriesInfoConverter))]
	class SeriesInfo
	{
		private BrushType m_brushType = BrushType.Hatch;
		private Color m_color1=Color.Empty;
		private Color m_color2=Color.Empty;
		private HatchStyle m_hatch = HatchStyle.Vertical;
		private Image m_img = null;
		private GradientStyle m_gradient = GradientStyle.Horizontal1;
		private ChartDataSeries m_ser = null;

		public SeriesInfo( ChartDataSeries ds, Image img)
		{
			m_ser = ds;
			m_color1 = m_ser.LineStyle.Color;
			m_color2 = Color.Black;
			if(img!=null)
			{
				m_img = (Image)img.Clone();
				Graphics g = Graphics.FromImage( m_img);
				g.Clear( m_color1);
				g.DrawImage( img, 0, 0);
				g.Dispose();
			}
		}

		[RefreshProperties(RefreshProperties.All)]
		public BrushType BrushType
		{
			get{ return m_brushType;}
			set{ m_brushType = value;}
		}

		public Color Color1
		{
			get{ return m_color1;}
			set
			{ 
				m_color1 = value;
				if( m_ser!=null)
					m_ser.LineStyle.Color = m_color1;
			}
		}

		public Color Color2
		{
			get{ return m_color2;}
			set{ m_color2 = value;}
		}

		public GradientStyle GradientStyle
		{
			get{ return m_gradient;}
			set{ m_gradient = value;}
		}

		public HatchStyle HatchStyle
		{
			get{ return m_hatch;}
			set{ m_hatch = value;}
		}

		public Image Image
		{
			get{ return m_img;}
			set{ m_img = value;}
		}
	}

	class SeriesData
	{
		private SeriesInfo[] m_sers = null;

		public SeriesData( C1Chart chart, ImageList images)
		{
			ChartDataSeriesCollection sc = chart.ChartGroups[0].ChartData.SeriesList;
			m_sers = (SeriesInfo[])Array.CreateInstance( typeof(SeriesInfo), sc.Count);
			for( int i=0; i<sc.Count; i++)
			{
				Image img = null;
				if( i<images.Images.Count)
					img = images.Images[i];
				m_sers[i] = new SeriesInfo( sc[i], img);
			}
		}

		[Browsable(false)]
		public SeriesInfo[] SeriesArray
		{
			get{ return m_sers;}
		}

		[Category("Appearance")]
		public SeriesInfo Series0
		{
			get{ return m_sers[0];}
		}

		[Category("Appearance")]
		public SeriesInfo Series1
		{
			get{ return m_sers[1];}
		}

		[Category("Appearance")]
		public SeriesInfo Series2
		{
			get{ return m_sers[2];}
		}

		[Category("Appearance")]
		public SeriesInfo Series3
		{
			get{ return m_sers[3];}
		}
	}
}
