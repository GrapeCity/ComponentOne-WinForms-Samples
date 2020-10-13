using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.C1Chart;

namespace Tooltip
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1Chart.C1Chart c1Chart1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbTooltip;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbActivation;
		private System.Windows.Forms.ComboBox cbPlotElement;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.tbTooltip = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.cbActivation = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbPlotElement = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Chart1
			// 
			this.c1Chart1.DataSource = null;
			this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Chart1.Location = new System.Drawing.Point(168, 0);
			this.c1Chart1.Name = "c1Chart1";
			this.c1Chart1.PropBag = "<?xml version=\"1.0\"?><Chart2DPropBag Version=\"\"><StyleCollection><NamedStyle Name" +
				"=\"PlotArea\" ParentName=\"Area\" StyleData=\"Border=Solid,ControlText,1;BackColor=Wh" +
				"iteSmoke;\" /><NamedStyle Name=\"Legend\" ParentName=\"Legend.default\" /><NamedStyle" +
				" Name=\"Footer\" ParentName=\"Control\" StyleData=\"Border=Solid,RoyalBlue,2;Font=Mic" +
				"rosoft Sans Serif, 16pt;\" /><NamedStyle Name=\"Area\" ParentName=\"Area.default\" />" +
				"<NamedStyle Name=\"Control\" ParentName=\"Control.default\" StyleData=\"Border=Raised" +
				",Transparent,1;\" /><NamedStyle Name=\"AxisX\" ParentName=\"Area\" StyleData=\"Rotatio" +
				"n=Rotate0;AlignHorz=Center;AlignVert=Bottom;\" /><NamedStyle Name=\"AxisY\" ParentN" +
				"ame=\"Area\" StyleData=\"Rotation=Rotate270;AlignHorz=Near;AlignVert=Center;\" /><Na" +
				"medStyle Name=\"LabelStyleDefault\" ParentName=\"LabelStyleDefault.default\" /><Name" +
				"dStyle Name=\"Legend.default\" ParentName=\"Control\" StyleData=\"Border=None,Black,1" +
				";Wrap=False;AlignVert=Top;\" /><NamedStyle Name=\"LabelStyleDefault.default\" Paren" +
				"tName=\"Control\" StyleData=\"Border=None,Black,1;BackColor=Transparent;\" /><NamedS" +
				"tyle Name=\"Header\" ParentName=\"Control\" StyleData=\"Border=Solid,RoyalBlue,2;Font" +
				"=Microsoft Sans Serif, 16pt;\" /><NamedStyle Name=\"Control.default\" ParentName=\"\"" +
				" StyleData=\"ForeColor=ControlText;Border=None,Black,1;BackColor=Control;\" /><Nam" +
				"edStyle Name=\"AxisY2\" ParentName=\"Area\" StyleData=\"Rotation=Rotate90;AlignHorz=F" +
				"ar;AlignVert=Center;\" /><NamedStyle Name=\"Area.default\" ParentName=\"Control\" Sty" +
				"leData=\"Border=None,Black,1;AlignVert=Top;\" /></StyleCollection><ChartGroupsColl" +
				"ection><ChartGroup Name=\"Group1\" Use3D=\"False\"><DataSerializer DefaultSet=\"True\"" +
				"><DataSeriesCollection><DataSeriesSerializer><LineStyle Color=\"ForestGreen\" /><S" +
				"ymbolStyle Size=\"7\" Color=\"DarkSeaGreen\" OutlineColor=\"DarkGreen\" Shape=\"Box\" />" +
				"<SeriesLabel>series 0</SeriesLabel><X>1;2;3;4;5</X><Y>20;22;19;24;25</Y><DataTyp" +
				"es>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFields><F" +
				"illStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"RoyalB" +
				"lue\" /><SymbolStyle Size=\"7\" Color=\"CornflowerBlue\" OutlineColor=\"Navy\" Shape=\"D" +
				"ot\" /><SeriesLabel>series 1</SeriesLabel><X>1;2;3;4;5</X><Y>8;12;10;12;15</Y><Da" +
				"taTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFiel" +
				"ds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"D" +
				"arkViolet\" /><SymbolStyle Size=\"7\" Color=\"Violet\" OutlineColor=\"Indigo\" Shape=\"T" +
				"ri\" /><SeriesLabel>series 2</SeriesLabel><X>1;2;3;4;5</X><Y>10;16;17;15;23</Y><D" +
				"ataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</DataFie" +
				"lds><FillStyle /></DataSeriesSerializer><DataSeriesSerializer><LineStyle Color=\"" +
				"Firebrick\" /><SymbolStyle Size=\"7\" Color=\"Pink\" OutlineColor=\"DarkRed\" Shape=\"Di" +
				"amond\" /><SeriesLabel>series 3</SeriesLabel><X>1;2;3;4;5</X><Y>16;19;15;22;18</Y" +
				"><DataTypes>Single;Single;Double;Double;Double</DataTypes><DataFields>;;;;</Data" +
				"Fields><FillStyle /></DataSeriesSerializer></DataSeriesCollection></DataSerializ" +
				"er></ChartGroup><ChartGroup Name=\"Group2\"><DataSerializer /></ChartGroup></Chart" +
				"GroupsCollection><Header Compass=\"North\"><Text>Chart Header</Text></Header><Foot" +
				"er Compass=\"South\"><Text>Footer</Text></Footer><Legend Compass=\"East\" Visible=\"F" +
				"alse\" /><ChartArea /><Axes><Axis Max=\"5\" Min=\"1\" UnitMajor=\"1\" UnitMinor=\"0.5\" A" +
				"utoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"South\"><" +
				"GridMajor /><GridMinor /></Axis><Axis Max=\"26\" Min=\"8\" UnitMajor=\"2\" UnitMinor=\"" +
				"1\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"West" +
				"\"><GridMajor /><GridMinor /></Axis><Axis Max=\"0\" Min=\"0\" UnitMajor=\"0\" UnitMinor" +
				"=\"0\" AutoMajor=\"True\" AutoMinor=\"True\" AutoMax=\"True\" AutoMin=\"True\" Compass=\"Ea" +
				"st\"><GridMajor /><GridMinor /></Axis></Axes></Chart2DPropBag>";
			this.c1Chart1.Size = new System.Drawing.Size(464, 453);
			this.c1Chart1.TabIndex = 0;
			this.c1Chart1.ShowTooltip += new C1.Win.C1Chart.ShowTooltipEventHandler(this.c1Chart1_ShowTooltip);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Header",
														   "Footer",
														   "X-axis",
														   "Y-axis",
														   "DataSeries"});
			this.comboBox1.Location = new System.Drawing.Point(8, 32);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(152, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// tbTooltip
			// 
			this.tbTooltip.BackColor = System.Drawing.SystemColors.Control;
			this.tbTooltip.Location = new System.Drawing.Point(8, 96);
			this.tbTooltip.Multiline = true;
			this.tbTooltip.Name = "tbTooltip";
			this.tbTooltip.Size = new System.Drawing.Size(152, 96);
			this.tbTooltip.TabIndex = 2;
			this.tbTooltip.Text = "";
			this.tbTooltip.TextChanged += new System.EventHandler(this.tbTooltip_TextChanged);
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Chart element";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tooltip";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Location = new System.Drawing.Point(0, 208);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 4);
			this.panel1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label3.Location = new System.Drawing.Point(8, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(152, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "Activation";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbActivation
			// 
			this.cbActivation.BackColor = System.Drawing.SystemColors.Control;
			this.cbActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbActivation.Items.AddRange(new object[] {
															  "MouseOver",
															  "MouseClick"});
			this.cbActivation.Location = new System.Drawing.Point(8, 256);
			this.cbActivation.Name = "cbActivation";
			this.cbActivation.Size = new System.Drawing.Size(152, 21);
			this.cbActivation.TabIndex = 6;
			this.cbActivation.SelectedIndexChanged += new System.EventHandler(this.cbActivation_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Location = new System.Drawing.Point(8, 296);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Plot element";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbPlotElement
			// 
			this.cbPlotElement.BackColor = System.Drawing.SystemColors.Control;
			this.cbPlotElement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPlotElement.Items.AddRange(new object[] {
															   "Points",
															   "Series"});
			this.cbPlotElement.Location = new System.Drawing.Point(8, 320);
			this.cbPlotElement.Name = "cbPlotElement";
			this.cbPlotElement.Size = new System.Drawing.Size(152, 21);
			this.cbPlotElement.TabIndex = 8;
			this.cbPlotElement.SelectedIndexChanged += new System.EventHandler(this.cbPlotElement_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label4,
																		  this.cbPlotElement,
																		  this.label3,
																		  this.cbActivation,
																		  this.panel1,
																		  this.label2,
																		  this.label1,
																		  this.tbTooltip,
																		  this.comboBox1,
																		  this.c1Chart1});
			this.DockPadding.Left = 168;
			this.Name = "Form1";
			this.Text = "ComponentOne Chart.Net 2D - Chart Tooltip Demo";
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

		bool _canTooltipChange = false;
		string _dstt = "";

		string DataSeriesTooltipText
		{
			get{ return _dstt;}
			set
			{
				if( _dstt!=value)
				{
					_dstt = value;

					// Set tooltip for all series
					foreach( ChartDataSeries ds in c1Chart1.ChartGroups[0].ChartData.SeriesList)
						ds.TooltipText = _dstt;
				}
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			tbTooltip.Enabled = true;

			bool prev = _canTooltipChange;
			_canTooltipChange = false;

			// Put corresponding tootip text into textbox
			string s = comboBox1.SelectedItem.ToString();
			switch( s)
			{
				case "Header":
					tbTooltip.Text = c1Chart1.Header.TooltipText;
					break;
				case "Footer":
					tbTooltip.Text = c1Chart1.Footer.TooltipText;
					break;
				case "X-axis":
					tbTooltip.Text = c1Chart1.ChartArea.AxisX.TooltipText;
					break;
				case "Y-axis":
					tbTooltip.Text = c1Chart1.ChartArea.AxisY.TooltipText;
					break;
				case "DataSeries":
					if( c1Chart1.ToolTip.PlotElement == PlotElementEnum.Points)
						tbTooltip.Text = DataSeriesTooltipText;
					else
					{
						tbTooltip.Text = "Tooltip text is changing in ShowTooltip event";
						tbTooltip.Enabled = false;
					}
					break;
				default:
					break;
			}

			_canTooltipChange = prev;
		}

		private void tbTooltip_TextChanged(object sender, System.EventArgs e)
		{
			if( !_canTooltipChange)
				return;

			// Change tooltip for coresponding chart element
			string s = comboBox1.SelectedItem.ToString();
			switch( s)
			{
				case "Header":
					c1Chart1.Header.TooltipText = tbTooltip.Text;
					break;
				case "Footer":
					c1Chart1.Footer.TooltipText = tbTooltip.Text;
					break;
				case "X-axis":
					c1Chart1.ChartArea.AxisX.TooltipText = tbTooltip.Text;
					break;
				case "Y-axis":
					c1Chart1.ChartArea.AxisY.TooltipText = tbTooltip.Text;
					break;
				case "DataSeries":
					if( c1Chart1.ToolTip.PlotElement == PlotElementEnum.Points)
						DataSeriesTooltipText = tbTooltip.Text;
					break;
				default:
					break;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// Set default tooltips
			DataSeriesTooltipText = "Series: {#TEXT}\r\nx = {#XVAL}\r\ny = {#YVAL}";
			c1Chart1.Header.TooltipText = "This is header tooltip.\r\nSecond line.";
			c1Chart1.Footer.TooltipText = "This is footer tooltip.\r\nSecond line.";

			c1Chart1.ChartArea.AxisX.TooltipText = "X-Axis";
			c1Chart1.ChartArea.AxisY.TooltipText = "Y-Axis";

			// Set default values
			comboBox1.SelectedItem = "Header";
			cbActivation.SelectedItem = "MouseOver";
			cbPlotElement.SelectedItem = "Points";

			_canTooltipChange = true;

			// Enable tooltip
			c1Chart1.ToolTip.Enabled = true;
		}

		private void c1Chart1_ShowTooltip(object sender, C1.Win.C1Chart.ShowTooltipEventArgs e)
		{
			// Select item in combobox
			if( sender.Equals(c1Chart1.Header))
			{
				comboBox1.SelectedItem = "Header";
			}
			else if( sender.Equals(c1Chart1.Footer))
			{
				comboBox1.SelectedItem = "Footer";
			}
			else if( sender.Equals(c1Chart1.ChartArea.AxisX))
			{
				comboBox1.SelectedItem = "X-axis";
			}
			else if( sender.Equals(c1Chart1.ChartArea.AxisY))
			{
				comboBox1.SelectedItem = "Y-axis";
			}
			else if( sender is ChartDataSeries)
			{
				// Create new tooltip text
				if( c1Chart1.ToolTip.PlotElement == PlotElementEnum.Series)
				{
					ChartDataSeries ds = (ChartDataSeries)sender;

					Point p = Control.MousePosition;
					p = c1Chart1.PointToClient( p);

					double x = 0, y = 0;

					// Callculate data coordinates
					if( ds.Group.CoordToDataCoord( p.X, p.Y, ref x, ref y))
						e.TooltipText = string.Format( "{0}\nx = {1:#.##}\ny = {2:#.##}", ds.Label, x, y);
					else
						e.TooltipText = "";
				}
				
				comboBox1.SelectedItem = "DataSeries";
			}
		}

		private void cbActivation_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if( cbActivation.SelectedItem.ToString() == "MouseOver")
				c1Chart1.ToolTip.SelectAction = SelectActionEnum.MouseOver;
			else
				c1Chart1.ToolTip.SelectAction = SelectActionEnum.Click;
		}

		private void cbPlotElement_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// Default values
			SymbolShapeEnum ss = SymbolShapeEnum.Dot;
			int thickness = 1;

			if( cbPlotElement.SelectedItem.ToString() == "Points")
				c1Chart1.ToolTip.PlotElement = PlotElementEnum.Points;
			else
			{
				// Hide symbols and increase thickness
				ss = SymbolShapeEnum.None;
				thickness = 3;
				c1Chart1.ToolTip.PlotElement = PlotElementEnum.Series;
			}

			// Change appearance of series
			foreach( ChartDataSeries ds in c1Chart1.ChartGroups[0].ChartData.SeriesList)
			{
				ds.SymbolStyle.Shape = ss;
				ds.LineStyle.Thickness = thickness;
			}
		}
	}
}
