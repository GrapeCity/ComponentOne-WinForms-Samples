using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using C1.Win.C1Chart;

namespace Chlabels
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuFile;
		private System.Windows.Forms.MenuItem menuFileExit;
		private System.Windows.Forms.MenuItem menuHelp;
		private System.Windows.Forms.MenuItem menuHelpAbout;
		private System.Windows.Forms.Button buttonClearLabels;
		private System.Windows.Forms.GroupBox grpLabels;
		private System.Windows.Forms.Label lblOne;
		private System.Windows.Forms.Label lblTwo;
		private System.Windows.Forms.Label lblThree;
		private System.Windows.Forms.Label lblFour;
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.MenuItem menuHelpMoreInfo;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuFile = new System.Windows.Forms.MenuItem();
			this.menuFileExit = new System.Windows.Forms.MenuItem();
			this.menuHelp = new System.Windows.Forms.MenuItem();
			this.menuHelpAbout = new System.Windows.Forms.MenuItem();
			this.buttonClearLabels = new System.Windows.Forms.Button();
			this.grpLabels = new System.Windows.Forms.GroupBox();
			this.lblFour = new System.Windows.Forms.Label();
			this.lblThree = new System.Windows.Forms.Label();
			this.lblTwo = new System.Windows.Forms.Label();
			this.lblOne = new System.Windows.Forms.Label();
			this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
			this.menuHelpMoreInfo = new System.Windows.Forms.MenuItem();
			this.grpLabels.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuFile,
																					  this.menuHelp});
			// 
			// menuFile
			// 
			this.menuFile.Index = 0;
			this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuFileExit});
			this.menuFile.Text = "File";
			// 
			// menuFileExit
			// 
			this.menuFileExit.Index = 0;
			this.menuFileExit.Text = "Exit";
			this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
			// 
			// menuHelp
			// 
			this.menuHelp.Index = 1;
			this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuHelpMoreInfo,
																					 this.menuHelpAbout});
			this.menuHelp.Text = "Help";
			// 
			// menuHelpAbout
			// 
			this.menuHelpAbout.Index = 1;
			this.menuHelpAbout.Text = "About";
			this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
			// 
			// buttonClearLabels
			// 
			this.buttonClearLabels.Location = new System.Drawing.Point(0, 8);
			this.buttonClearLabels.Name = "buttonClearLabels";
			this.buttonClearLabels.Size = new System.Drawing.Size(96, 32);
			this.buttonClearLabels.TabIndex = 0;
			this.buttonClearLabels.Text = "Clear All Labels";
			this.buttonClearLabels.Click += new System.EventHandler(this.buttonClearLabels_Click);
			// 
			// grpLabels
			// 
			this.grpLabels.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.lblFour,
																					this.lblThree,
																					this.lblTwo,
																					this.lblOne});
			this.grpLabels.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.grpLabels.Location = new System.Drawing.Point(112, 0);
			this.grpLabels.Name = "grpLabels";
			this.grpLabels.Size = new System.Drawing.Size(296, 48);
			this.grpLabels.TabIndex = 1;
			this.grpLabels.TabStop = false;
			// 
			// lblFour
			// 
			this.lblFour.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblFour.Location = new System.Drawing.Point(200, 14);
			this.lblFour.Name = "lblFour";
			this.lblFour.Size = new System.Drawing.Size(80, 26);
			this.lblFour.TabIndex = 3;
			this.lblFour.Text = "Four";
			this.lblFour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragLabels_MouseDown);
			// 
			// lblThree
			// 
			this.lblThree.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblThree.Location = new System.Drawing.Point(128, 14);
			this.lblThree.Name = "lblThree";
			this.lblThree.Size = new System.Drawing.Size(72, 26);
			this.lblThree.TabIndex = 2;
			this.lblThree.Text = "Three";
			this.lblThree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragLabels_MouseDown);
			// 
			// lblTwo
			// 
			this.lblTwo.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblTwo.Location = new System.Drawing.Point(72, 14);
			this.lblTwo.Name = "lblTwo";
			this.lblTwo.Size = new System.Drawing.Size(56, 26);
			this.lblTwo.TabIndex = 1;
			this.lblTwo.Text = "Two";
			this.lblTwo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragLabels_MouseDown);
			// 
			// lblOne
			// 
			this.lblOne.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblOne.Location = new System.Drawing.Point(16, 14);
			this.lblOne.Name = "lblOne";
			this.lblOne.Size = new System.Drawing.Size(56, 26);
			this.lblOne.TabIndex = 0;
			this.lblOne.Text = "One";
			this.lblOne.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragLabels_MouseDown);
			// 
			// c1Chart1
			// 
			this.c1Chart1.AllowDrop = true;
			this.c1Chart1.BackColor = System.Drawing.Color.LightSlateGray;
			this.c1Chart1.Location = new System.Drawing.Point(0, 56);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><Axes><Axis Max=\"2.5\" Min=\"0.5\" U" +
				"nitMajor=\"1\" UnitMinor=\"0.5\" AutoMajor=\"False\" AutoMinor=\"True\" AutoMax=\"False\" " +
				"AutoMin=\"False\" TickMinor=\"None\" AnnoMethod=\"ValueLabels\" _onTop=\"0\" Compass=\"We" +
				"st\"><ValueLabels><ValueLabel Value=\"1\" Text=\"Group 2\" /><ValueLabel Value=\"2\" Te" +
				"xt=\"Group 1\" /></ValueLabels><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"Li" +
				"ghtGray\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"Light" +
				"Gray\" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"30\" Min=\"0\" UnitMajor=\"10\" Unit" +
				"Minor=\"5\" AutoMajor=\"False\" AutoMinor=\"True\" AutoMax=\"False\" AutoMin=\"False\" _on" +
				"Top=\"0\" Compass=\"South\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGr" +
				"ay\" Pattern=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\"" +
				" Pattern=\"Dash\" /><Text /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor=\"" +
				"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" _onTop=\"0\" Co" +
				"mpass=\"North\"><GridMajor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Patter" +
				"n=\"Dash\" /><GridMinor AutoSpace=\"True\" Thickness=\"1\" Color=\"LightGray\" Pattern=\"" +
				"Dash\" /><Text /></Axis></Axes><Header Compass=\"North\"><Text>Header</Text></Heade" +
				"r><ChartGroupsCollection><ChartGroup><Polar>Degrees=True,PiRatioAnnotations=True" +
				",Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><Stacked>False</" +
				"Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=False,ShowClos" +
				"e=True,ShowOpen=True</HiLoData><ChartType>Bar</ChartType><Bubble>EncodingMethod=" +
				"Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group1</Name><DataSerializer" +
				" DefaultSet=\"True\"><DataSeriesCollection><DataSeriesSerializer><Y>6;15</Y><LineS" +
				"tyle Thickness=\"1\" Color=\"Red\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Box\" Color=" +
				"\"Coral\" /><SeriesLabel>Alpha</SeriesLabel><DataTypes>Single;Single;Single;Single" +
				";Single</DataTypes><Y1 /><X>1;2</X><Y3 /><Y2 /></DataSeriesSerializer><DataSerie" +
				"sSerializer><Y>15;7</Y><LineStyle Thickness=\"1\" Color=\"Tan\" Pattern=\"Solid\" /><S" +
				"ymbolStyle Shape=\"Dot\" Color=\"CornflowerBlue\" /><SeriesLabel>Beta</SeriesLabel><" +
				"DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2</X><Y3 /><Y" +
				"2 /></DataSeriesSerializer><DataSeriesSerializer><Y>24.2;11</Y><LineStyle Thickn" +
				"ess=\"1\" Color=\"LimeGreen\" Pattern=\"Solid\" /><SymbolStyle Shape=\"Tri\" Color=\"Corn" +
				"silk\" /><SeriesLabel>Gamma</SeriesLabel><DataTypes>Single;Single;Single;Single;S" +
				"ingle</DataTypes><Y1 /><X>1;2</X><Y3 /><Y2 /></DataSeriesSerializer><DataSeriesS" +
				"erializer><Y>4.6;15.1</Y><LineStyle Thickness=\"1\" Color=\"MediumTurquoise\" Patter" +
				"n=\"Solid\" /><SymbolStyle Shape=\"Diamond\" Color=\"Crimson\" /><SeriesLabel>Delta</S" +
				"eriesLabel><DataTypes>Single;Single;Single;Single;Single</DataTypes><Y1 /><X>1;2" +
				"</X><Y3 /><Y2 /></DataSeriesSerializer></DataSeriesCollection></DataSerializer><" +
				"ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterWidth=90</Bar><Pie>Ot" +
				"herOffset=0,Start=0</Pie></ChartGroup><ChartGroup><Polar>Degrees=True,PiRatioAnn" +
				"otations=True,Start=0</Polar><Radar>Degrees=True,Filled=False,Start=0</Radar><St" +
				"acked>False</Stacked><HiLoData>FillFalling=True,FillTransparent=True,FullWidth=F" +
				"alse,ShowClose=True,ShowOpen=True</HiLoData><ChartType>XYPlot</ChartType><Bubble" +
				">EncodingMethod=Diameter,MaximumSize=20,MinimumSize=5</Bubble><Name>Group2</Name" +
				"><DataSerializer /><ShowOutline>True</ShowOutline><Bar>ClusterOverlap=0,ClusterW" +
				"idth=50</Bar><Pie>OtherOffset=0,Start=0</Pie></ChartGroup></ChartGroupsCollectio" +
				"n><StyleCollection><NamedStyle><Name>PlotArea</Name><ParentName>Area</ParentName" +
				"><StyleData>Border=Solid,ControlText,1;BackColor=AliceBlue;</StyleData></NamedSt" +
				"yle><NamedStyle><Name>Legend</Name><ParentName>Legend.default</ParentName><Style" +
				"Data>Border=RaisedBevel,LightYellow,2;AlignHorz=Center;BackColor=LightYellow;Fon" +
				"t=Microsoft Sans Serif, 12pt, style=Bold;</StyleData></NamedStyle><NamedStyle><N" +
				"ame>Footer</Name><ParentName>Control</ParentName><StyleData>ForeColor=Bisque;Bor" +
				"der=None,LightSlateGray,1;Font=Microsoft Sans Serif, 12pt, style=Bold;</StyleDat" +
				"a></NamedStyle><NamedStyle><Name>Area</Name><ParentName>Area.default</ParentName" +
				"><StyleData>Border=RaisedBevel,LightSteelBlue,2;BackColor=LightSteelBlue;</Style" +
				"Data></NamedStyle><NamedStyle><Name>Control</Name><ParentName>Control.default</P" +
				"arentName><StyleData>BackColor=LightSlateGray;</StyleData></NamedStyle><NamedSty" +
				"le><Name>AxisX</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate270;" +
				"Border=None,LightSteelBlue,1;AlignHorz=Near;BackColor=Transparent;Font=Microsoft" +
				" Sans Serif, 12pt;AlignVert=Center;</StyleData></NamedStyle><NamedStyle><Name>Ax" +
				"isY</Name><ParentName>Area</ParentName><StyleData>Rotation=Rotate0;Border=None,L" +
				"ightSteelBlue,1;AlignHorz=Center;BackColor=Transparent;AlignVert=Bottom;</StyleD" +
				"ata></NamedStyle><NamedStyle><Name>LabelStyleDefault</Name><ParentName>LabelStyl" +
				"eDefault.default</ParentName><StyleData /></NamedStyle><NamedStyle><Name>Legend." +
				"default</Name><ParentName>Control</ParentName><StyleData>Border=None,LightYellow" +
				",1;Wrap=False;AlignVert=Top;</StyleData></NamedStyle><NamedStyle><Name>LabelStyl" +
				"eDefault.default</Name><ParentName>Control</ParentName><StyleData>Border=None,Co" +
				"ntrol,1;BackColor=Transparent;</StyleData></NamedStyle><NamedStyle><Name>Header<" +
				"/Name><ParentName>Control</ParentName><StyleData>Border=RaisedBevel,Bisque,2;Bac" +
				"kColor=Bisque;Font=Microsoft Sans Serif, 12pt, style=Bold;</StyleData></NamedSty" +
				"le><NamedStyle><Name>Control.default</Name><ParentName /><StyleData>ForeColor=Co" +
				"ntrolText;Border=None,LightSlateGray,1;BackColor=Control;</StyleData></NamedStyl" +
				"e><NamedStyle><Name>AxisY2</Name><ParentName>Area</ParentName><StyleData>Rotatio" +
				"n=Rotate0;Border=None,Transparent,1;AlignHorz=Center;BackColor=Transparent;Align" +
				"Vert=Top;</StyleData></NamedStyle><NamedStyle><Name>Area.default</Name><ParentNa" +
				"me>Control</ParentName><StyleData>Border=None,LightSteelBlue,1;AlignVert=Top;</S" +
				"tyleData></NamedStyle></StyleCollection><Footer Compass=\"South\"><Text>Total # of" +
				" ChartLabels: </Text></Footer><Legend Compass=\"East\" Visible=\"True\"><Text /></Le" +
				"gend><ChartArea Inverted=\"True\" /></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(480, 256);
			this.c1Chart1.TabIndex = 2;
			this.c1Chart1.DragDrop += new System.Windows.Forms.DragEventHandler(this.c1Chart1_DragDrop);
			this.c1Chart1.DragOver += new System.Windows.Forms.DragEventHandler(this.c1Chart1_DragOver);
			this.c1Chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseMove);
			this.c1Chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.c1Chart1_MouseDown);
			// 
			// menuHelpMoreInfo
			// 
			this.menuHelpMoreInfo.Index = 0;
			this.menuHelpMoreInfo.Text = "More Info...";
			this.menuHelpMoreInfo.Click += new System.EventHandler(this.menuHelpMoreInfo_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(488, 353);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.c1Chart1,
																		  this.grpLabels,
																		  this.buttonClearLabels});
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Chart Labels Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpLabels.ResumeLayout(false);
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

		private void menuHelpMoreInfo_Click(object sender, System.EventArgs e)
		{
			string msg = "Wander about the chart elements with the cursor,\n" +
				"and the elements will be described as you pass over them.\n\n" +
				"As you move over the bars of the chart, the value of each\n" +
				"bar is given.\n\n" +
				"If the left mouse button is clicked at a new bar level, the\n" +
				"bar will change it's value to match the new level.\n\n" +
				"Dragging a label onto a bar, will label the bar.";

			MessageBox.Show( this, msg, "More Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuHelpAbout_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show(this, this.Text, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void menuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		string baseFooterString = null;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// center the form
			this.CenterToParent();

			// final chart setup
			c1Chart1.Top = grpLabels.Bottom+1;
			c1Chart1.Left = 0;
			c1Chart1.Size = new Size(ClientSize.Width, ClientSize.Height - c1Chart1.Top);
			c1Chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;//!!VBPassThru

			c1Chart1.Header.Text = " Drag and drop one of the above \n labels onto a chart bar. ";
			c1Chart1.Header.Style.HorizontalAlignment = AlignHorzEnum.Center;

			// save the footer string and use it later
			baseFooterString = c1Chart1.Footer.Text;
		}

		private Color objectBackColor = Color.Empty;
		private Style highlightedObjectStyle = null;
		private object highlightedObject = null;
		private const string labName = "highLightLabel";

		private void UpdateFooter()
		{
			int labCount = c1Chart1.ChartLabels.LabelsCollection.Count;
			c1Chart1.Footer.Text = baseFooterString + labCount.ToString() + " ";
		}

		private void HighlightObject(object obj)
		{
			// do nothing if still same object
			if(obj != null)
			{
				if(obj.Equals(highlightedObject))
					return;
			}

			// since they are different, clear the original
			// object if it's not null
			highlightedObject = null;
			if(highlightedObjectStyle != null)
			{
				highlightedObjectStyle.BackColor = objectBackColor;
				objectBackColor = Color.Empty;
				highlightedObjectStyle = null;
			}

			C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels[labName];
			if(lab != null)
				c1Chart1.ChartLabels.LabelsCollection.Remove(lab);

			if(obj == null)
			{
				UpdateFooter();
				return;
			}

			// handle the changes for the new object highlighting
			string describe = null;
			Point atPoint = Point.Empty;
			LabelCompassEnum cp = LabelCompassEnum.NorthWest;
	
			if(obj is Legend)
			{
				Legend leg = (Legend)obj;
				describe = " This is the Legend! ";
				atPoint = leg.Location;
				highlightedObjectStyle = leg.Style;
			}
			else if(obj is Title)
			{
				Title t = (Title)obj;
				highlightedObjectStyle = t.Style;
				if(highlightedObjectStyle.Border.BorderStyle.Equals(BorderStyleEnum.None))
				{
					describe = " This is the Footer! ";
					atPoint = t.Location;
					atPoint.X += t.Size.Width;
					cp = LabelCompassEnum.NorthEast;
				}
				else
				{
					describe = " This is the \nHeader! ";
					atPoint = t.Location;
					atPoint.X += t.Size.Width;
					atPoint.Y += t.Size.Height;
					cp = LabelCompassEnum.SouthEast;
				}
			}

			if(!atPoint.IsEmpty)
			{
				C1.Win.C1Chart.Label nl = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
				nl.Compass = cp;
				nl.Name = labName;
				nl.Connected = true;
				nl.Offset = 10;
				nl.AttachMethod = AttachMethodEnum.Coordinate;
				nl.AttachMethodData.X = atPoint.X;
				nl.AttachMethodData.Y = atPoint.Y;
				nl.Style.BackColor = Color.RosyBrown;
				nl.Style.Border.BorderStyle = BorderStyleEnum.Solid;
				nl.Style.Border.Thickness = 2;
				nl.Style.Font = new Font(nl.Style.Font.Name, 10, FontStyle.Bold);
				nl.Style.HorizontalAlignment = AlignHorzEnum.Center;
				nl.Text = describe;
				nl.Visible = true;

				objectBackColor = highlightedObjectStyle.BackColor;
				highlightedObjectStyle.BackColor = Color.RosyBrown;
				highlightedObject = obj;
			}

			UpdateFooter();
		}

		private int oldSeries = -1, oldPoint = -1;

		private void AddBarValueLabel(int x, int y, bool leftButtonDown)
		{
			const string labName = "barValueLabel";
			C1.Win.C1Chart.Label lab = null;

			if(x < 0 || y < 0)
			{
				lab = c1Chart1.ChartLabels[labName];
				if(lab != null)
				{
					c1Chart1.ChartLabels.LabelsCollection.Remove(lab);
					UpdateFooter();
				}
				oldSeries = -1;
				oldPoint = -1;
				return;
			}

			int s = -1, p = -1, d = -1;
			ChartGroup grp = c1Chart1.ChartGroups[0];
			if(grp.CoordToDataIndex(x, y, CoordinateFocusEnum.XCoord, ref s, ref p, ref d))
			{
				if(s >= 0 && p >= 0 && d == 0)
				{
					if(leftButtonDown)
					{
						// if the left mouse button is down, then
						// change the data point Y value at s & p
						float newx=0f, newy=0f;
						if(grp.CoordToDataCoord(x, y, ref newx, ref newy))
							grp.ChartData[s].Y[p] = newy;
					}
					else
					{
						// see if it's the same as the last call.
						if(s == oldSeries && p == oldPoint)
							return;
					}

					lab = c1Chart1.ChartLabels[labName];
					if(lab == null)
					{
						lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
						lab.Name = labName;
						lab.Style.Border.BorderStyle = BorderStyleEnum.None;
						lab.Style.BackColor = Color.Transparent;
						lab.Compass = LabelCompassEnum.West;
						lab.Connected = false;
						lab.Offset = 10;
						lab.AttachMethod = AttachMethodEnum.DataIndex;
						lab.AttachMethodData.GroupIndex = 0;
						lab.AttachMethodData.SeriesIndex = s;
						lab.AttachMethodData.PointIndex = p;
						lab.Text = ((float)(grp.ChartData[s].Y[p])).ToString("0.##");
						lab.Visible = true;

						UpdateFooter();
					}
					else
					{
						lab.AttachMethodData.SeriesIndex = s;
						lab.AttachMethodData.PointIndex = p;
						lab.Text = ((float)(grp.ChartData[s].Y[p])).ToString("0.##");
					}
					return;
				}
			}

			AddBarValueLabel(-1, -1, false);
		}

		private bool inMouseMove = false;
		private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// eliminate recursive calls.
			if(inMouseMove)
				return;

			inMouseMove = true;

			ChartRegionEnum region = c1Chart1.ChartRegionFromCoord(e.X, e.Y);
			switch(region)
			{
				case ChartRegionEnum.Legend:				
					AddBarValueLabel(-1, -1, false);
					HighlightObject(c1Chart1.Legend);
					break;

				case ChartRegionEnum.Header:
					AddBarValueLabel(-1, -1, false);
					HighlightObject(c1Chart1.Header);
					break;
				
				case ChartRegionEnum.Footer:
					AddBarValueLabel(-1, -1, false);
					HighlightObject(c1Chart1.Footer);
					break;
				
				case ChartRegionEnum.ChartArea:
				case ChartRegionEnum.ChartLabel:
				case ChartRegionEnum.PlotArea:
					HighlightObject(null);
					AddBarValueLabel(e.X, e.Y, e.Button.Equals(MouseButtons.Left));
					break;
				
				default:
					AddBarValueLabel(-1, -1, false);
					HighlightObject(null);
					break;
			}

			inMouseMove = false;
		}

		private void c1Chart1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(e.Button.Equals(MouseButtons.Left))
				c1Chart1_MouseMove(sender, e);
		}

		private void buttonClearLabels_Click(object sender, System.EventArgs e)
		{
			c1Chart1.ChartLabels.LabelsCollection.Clear();
			UpdateFooter();
		}

		private void DragLabels_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			System.Windows.Forms.Label wlab = (System.Windows.Forms.Label)sender;
			wlab.DoDragDrop(wlab.Text, DragDropEffects.Copy);
		}

		private void c1Chart1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string newLabText = e.Data.GetData(DataFormats.Text).ToString();
			if(newLabText != null && newLabText.Length > 0)
			{
				// convert the event screen coords to client coords
				// of the chart object.
				Point pnt = c1Chart1.PointToClient(new Point(e.X, e.Y));
				ChartGroup grp = c1Chart1.ChartGroups[0];
				int s = -1, p = -1, d = -1;

				// the cursor MUST be on a bar.
				if(grp.CoordToDataIndex(pnt.X, pnt.Y, CoordinateFocusEnum.XandYCoord, ref s, ref p, ref d))
				{
					if(s >= 0 && p >= 0 && d == 0)
					{
						// create the label name
						string labName = "barLabel_" + s.ToString() + "_" + p.ToString();

						// now get the existing label or create it if necessary
						C1.Win.C1Chart.Label lab = c1Chart1.ChartLabels[labName];
						if(lab == null)
						{
							// create the label
							lab = c1Chart1.ChartLabels.LabelsCollection.AddNewLabel();
							lab.Name = labName;
							lab.Compass = LabelCompassEnum.East;
							lab.Connected = true;
							lab.Offset = 10;
							lab.AttachMethod = AttachMethodEnum.DataIndex;
							lab.AttachMethodData.GroupIndex = 0;
							lab.AttachMethodData.SeriesIndex = s;
							lab.AttachMethodData.PointIndex = p;
							lab.Style.BackColor = Color.Transparent;
						}
						lab.Text = newLabText;
						lab.Visible = true;
					}
				}
			}
		}

		private void c1Chart1_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = DragDropEffects.None;
			if(!e.Data.GetDataPresent(DataFormats.Text))
				return;

			// convert the event screen coords to client coords
			// of the chart object.
			Point pnt = c1Chart1.PointToClient(new Point(e.X, e.Y));
			ChartGroup grp = c1Chart1.ChartGroups[0];
			int s = -1, p = -1, d = -1;

			// the cursor MUST be on a bar.
			if(grp.CoordToDataIndex(pnt.X, pnt.Y, CoordinateFocusEnum.XandYCoord, ref s, ref p, ref d))
			{
				if(s >= 0 && p >= 0 && d == 0)
					e.Effect = DragDropEffects.Copy;
			}
		}
	}
}
