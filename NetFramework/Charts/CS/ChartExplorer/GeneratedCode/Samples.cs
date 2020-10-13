using System;
using System.Data;
using System.Drawing;
namespace SampleCenter
{
//<Info>
//Shows chart NewSample.
//</Info>
public class NewSample: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//CS NewSample sample.
		c1chart1.Reset();
		c1chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Groove;
		c1chart1.Style.BackColor = Color.Azure;
		c1chart1.Style.BackColor2 = Color.Navy;
		c1chart1.Style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.FromCenter;
//</CodeSnippet>
	}
}

//<Info>
//Demonstrates creating different variations of bar chart.
//</Info>
public class Bar: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Inverted";
				cb2.CheckedChanged += new EventHandler(CheckBoxInverted_CheckChanged);

				System.Windows.Forms.ComboBox cb3 = new System.Windows.Forms.ComboBox();
				cb3.BackColor = System.Drawing.SystemColors.Control;
				cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb3.Items.AddRange(new object[] {"Normal","Stacked","100% Stacked"});
				cb3.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb3.Text = "Normal";
				cb3.SelectedIndexChanged += new EventHandler(ComboBoxStacked_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb3};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Data
		string[] items = new string[] { "Item1", "Item2", "Item3"};
		int[] sales2002 = new int[] { 800, 1500, 2000};
		int[] sales2003 = new int[] { 1000, 1200, 1400};
		
		//RtfNormal
		// Create first series
		C1.Win.C1Chart.ChartDataSeries ds2002 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2002.Label = "2002";
		ds2002.FillStyle.Color1 = Palette.Light1;
		ds2002.X.CopyDataIn( items);
		ds2002.Y.CopyDataIn( sales2002);
			
		// Create second series
		C1.Win.C1Chart.ChartDataSeries ds2003 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2003.Label = "2003";
		ds2003.FillStyle.Color1 = Palette.Light2;
		ds2003.AutoEnumerate = true;

		// Copy data into chart
		ds2003.Y.CopyDataIn( sales2003);

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfGray
		// Set x-axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
		c1chart1.ChartArea.AxisX.OnTop = true;
		c1chart1.ChartArea.AxisY.OnTop = true;
		// Show legend
		c1chart1.Legend.Visible = true;

//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
		CheckBoxInverted_CheckChanged( _controls[1], EventArgs.Empty);
		ComboBoxStacked_SelectedIndexChanged( _controls[2], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 15;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
			c1chart1.ChartArea.PlotArea.Boxed = true;
		}
		else
		{
			c1chart1.ChartGroups[0].Use3D = false;
			c1chart1.ChartArea.PlotArea.Boxed = false;
		}
	}

	// handler for check box
	private void CheckBoxInverted_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		c1chart1.ChartArea.Inverted = cb.Checked;
	}

	// handler for combo box
	private void ComboBoxStacked_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Normal":
				c1chart1.ChartGroups[0].Stacked = false;
				c1chart1.ChartGroups[0].Is100Percent = false;
				break;
			case "Stacked":
				c1chart1.ChartGroups[0].Stacked = true;
				c1chart1.ChartGroups[0].Is100Percent = false;
				break;
			case "100% Stacked":
				c1chart1.ChartGroups[0].Stacked = true;
				c1chart1.ChartGroups[0].Is100Percent = true;
				break;
		}
	}

//</CodeSnippet>
}
//<Info>
//Create simple line(ribbon) chart.
//</Info>
public class Line: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data		
		int n = 20;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		//RtfNormal		
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;
		ds.LineStyle.Color = Palette.Dark1;
		ds.LineStyle.Thickness = 2;
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);
			
		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfGray
		// Set x-axis limits
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// Handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 15;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
			c1chart1.ChartArea.PlotArea.Boxed = true;
		}
		else
		{
			c1chart1.ChartGroups[0].Use3D = false;
			c1chart1.ChartArea.PlotArea.Boxed = false;
		}
	}
//</CodeSnippet>

}

//<Info>
//Create simple scatter chart.
//</Info>
public class Scatter: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data		
		int n = 40;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = 2*(rnd.NextDouble()-0.5);
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";

		// Setup data visual appearance
		ds.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Box;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfGray
		// Set axes limits
		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
	}
}

//<Info>
//Create step chart.
//</Info>
public class Step: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1};
			}

			return _controls;
		}
	}


	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data		
		int n = 10;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";

		// Setup data visual appearance
		ds.LineStyle.Color = Palette.Dark1;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Box;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Step;

		//RtfGray
		// Set y-axis
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);

		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// Handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 15;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
		}
		else
			c1chart1.ChartGroups[0].Use3D = false;
	}
//</CodeSnippet>
}

//<Info>
//Create pie chart.
//</Info>
public class Pie: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Offset";
				cb2.CheckedChanged += new EventHandler(CheckBoxOffset_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		//RtfGray
		// Sample data
		int[] sales2002 = new int[] { 800, 1500};
		int[] sales2003 = new int[] { 1000, 1200};

		//RtfNormal		
		// Create first series
		C1.Win.C1Chart.ChartDataSeries ds2002 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2002.Label = "2002";
		ds2002.FillStyle.Color1 = Palette.Light1;
		ds2002.AutoEnumerate = true;
		ds2002.Y.CopyDataIn( sales2002);
			
		// Create second series
		C1.Win.C1Chart.ChartDataSeries ds2003 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2003.Label = "2003";
		ds2003.FillStyle.Color1 = Palette.Light2;
		ds2003.AutoEnumerate = true;
		ds2003.Y.CopyDataIn( sales2003);

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie;

		//RtfGray
		// Show legend
		c1chart1.Legend.Visible = true;

//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
		CheckBoxOffset_CheckChanged( _controls[1], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 25;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 30;
			c1chart1.ChartArea.PlotArea.Boxed = true;
		}
		else
		{
			c1chart1.ChartGroups[0].Use3D = false;
			c1chart1.ChartArea.PlotArea.Boxed = false;
		}
	}

	// handler for check box
	private void CheckBoxOffset_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
		{
			if( cb.Checked)
				ds.Offset = 20;
			else
				ds.Offset = 0;
		}
	}
//</CodeSnippet>
}

//<Info>
// Shows Doughnut chart and parameters.
//</Info>
public class Doughnut: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	const bool initial3D = true;
	const int initialDepth = 20;
	const int initialElevation = 45;
	const int initialInnerRadius = 30;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.Checked = initial3D;
				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);
				// 
				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right+5, 0);
				cb2.Width = 50;
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Alpha";
				cb2.CheckedChanged += new EventHandler(CheckBox_CheckChanged);
				cb2.Checked = true;
				//
				System.Windows.Forms.CheckBox cb3 = new System.Windows.Forms.CheckBox();
				cb3.Location = new System.Drawing.Point( cb2.Right+5, 0);
				cb3.Width = 70;
				cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb3.Text = "Anti-Alias";
				cb3.CheckedChanged += new EventHandler(CheckBox_CheckChanged);
				//
				System.Windows.Forms.Label lab1 = new System.Windows.Forms.Label();
				lab1.Location = new System.Drawing.Point(cb3.Right+5, 0);
				lab1.Name = "lab1";
				lab1.Width = 40;
				lab1.Text = "Depth";
				lab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				System.Windows.Forms.NumericUpDown nud1 = new System.Windows.Forms.NumericUpDown();
				nud1.Location = new System.Drawing.Point(lab1.Right, 0);
				nud1.Name = "nudDepth";
				nud1.Width = 40;
				nud1.Minimum = 0;
				nud1.Maximum = 45;
				nud1.Enabled = initial3D;
				nud1.Value = initialDepth;
				nud1.Increment = 5;
				nud1.ValueChanged += new System.EventHandler(UpDown_ValueChanged);
				// 
				System.Windows.Forms.Label lab2 = new System.Windows.Forms.Label();
				lab2.Location = new System.Drawing.Point(nud1.Right+5, 0);
				lab2.Width = 55;
				lab2.Text = "Elevation";
				lab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				System.Windows.Forms.NumericUpDown nud2 = new System.Windows.Forms.NumericUpDown();
				nud2.Location = new System.Drawing.Point(lab2.Right, 0);
				nud2.Name = "nudElevation";
				nud2.Width = 40;
				nud2.Minimum = 0;
				nud2.Maximum = 45;
				nud2.Enabled = initial3D;
				nud2.Value = initialElevation;
				nud2.Increment = 5;
				nud2.ValueChanged += new System.EventHandler(UpDown_ValueChanged);
				// 
				System.Windows.Forms.Label lab3 = new System.Windows.Forms.Label();
				lab3.Location = new System.Drawing.Point(nud2.Right+5, 0);
				lab3.Width = 70;
				lab3.Text = "Inner Radius";
				lab3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				System.Windows.Forms.NumericUpDown nud3 = new System.Windows.Forms.NumericUpDown();
				nud3.Location = new System.Drawing.Point(lab3.Right, 0);
				nud3.Name = "nudInnerRadius";
				nud3.Width = 40;
				nud3.Minimum = 0;
				nud3.Maximum = 90;
				nud3.Increment = 5;
				nud3.Value = initialInnerRadius;
				nud3.Increment = 5;
				nud3.ValueChanged += new System.EventHandler(UpDown_ValueChanged);
				// 
				System.Windows.Forms.Label lab4 = new System.Windows.Forms.Label();
				lab4.Location = new System.Drawing.Point(nud3.Right+5, 0);
				lab4.Width = 70;
				lab4.Text = "Start Angle";
				lab4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				// 
				System.Windows.Forms.NumericUpDown nud4 = new System.Windows.Forms.NumericUpDown();
				nud4.Location = new System.Drawing.Point(lab4.Right, 0);
				nud4.Name = "nudStartAngle";
				nud4.Width = 50;
				nud4.Minimum = int.MinValue;
				nud4.Maximum = int.MaxValue;
				nud4.Increment = 5;
				nud4.ValueChanged += new System.EventHandler(UpDown_ValueChanged);

				_controls = new System.Windows.Forms.Control[]{cb1,cb2,cb3,lab1,nud1,lab2,nud2,lab3,nud3,lab4,nud4};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		c1Chart1.Reset();

//<CodeSnippet>
		// Set the Chart to Pie type.
		c1Chart1.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie;

		// Set the Pie object InnerRadius property to provide the doughnut hole.
		c1chart1.ChartGroups.Group0.Pie.InnerRadius = initialInnerRadius;

		// Create a new series for each slice.  Since only a single Doughnut
		// is desired, each series has a single data point.  Note that AddNewSeries
		// returns a ChartDataSeries object, so the return value can be used to
		// manipulate each series.
		
		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = c1Chart1.ChartGroups[0].ChartData.SeriesList;

		// Add the first series and data
		C1.Win.C1Chart.ChartDataSeries cds = cdsc.AddNewSeries();
		cds.Y.CopyDataIn(new double[] {20});

		// Add the remaining series data directly.
		cdsc.AddNewSeries().Y.CopyDataIn(new double[] {16});	// series 1
		cdsc.AddNewSeries().Y.CopyDataIn(new double[] {10});	// series 2
		cdsc.AddNewSeries().Y.CopyDataIn(new double[] {08});	// series 3

		// Set the intial 3D parameters
		c1Chart1.ChartGroups.Group0.Use3D = false;
		c1Chart1.ChartArea.PlotArea.View3D.Depth = initialDepth;
		c1Chart1.ChartArea.PlotArea.View3D.Elevation = initialElevation;

		// Set up a mouse move handler to reset the offset of each slice.
		c1Chart1.Header.Text = "Left-click a slice to modify the offset.";
		c1Chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(Chart_MouseDown);

//</CodeSnippet>

		// set the alpha blending values.
		CheckBox_CheckChanged(_controls[0], new System.EventArgs());	// 3D values
		CheckBox_CheckChanged(_controls[1], new System.EventArgs());	// Alpha values
	}

	public override void Unload(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		c1Chart1.MouseDown -= new System.Windows.Forms.MouseEventHandler(Chart_MouseDown);
		base.Unload(c1Chart1);
	}

	//---------------------------------------------------------------------
//<CodeSnippet>

	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		if(cb.Text == "3D")
		{
			c1chart1.ChartGroups[0].Use3D = cb.Checked;
			c1chart1.ChartArea.PlotArea.Boxed = cb.Checked;

			foreach(System.Windows.Forms.Control cntrl in Controls)
			{
				if(cntrl.Name == "nudDepth" || cntrl.Name == "nudElevation")
					cntrl.Enabled = cb.Checked;
			}
		}
		else if(cb.Text == "Alpha")
		{
			byte alpha = (byte)(cb.Checked ? 64 : 255);
			C1.Win.C1Chart.ChartDataSeriesCollection cdsc = null;
			cdsc = c1chart1.ChartGroups.Group0.ChartData.SeriesList;

			foreach(C1.Win.C1Chart.ChartDataSeries cds in cdsc)
				cds.FillStyle.Alpha = alpha;
		}
		else if(cb.Text == "Anti-Alias")
		{
			c1chart1.UseAntiAliasedGraphics = cb.Checked;
		}
	}

	// handler for NumericUpDown ValueChanged
	private void UpDown_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown nud = (System.Windows.Forms.NumericUpDown)sender;

		if(nud.Name == "nudDepth")
			c1chart1.ChartArea.PlotArea.View3D.Depth = (int)nud.Value;

		else if(nud.Name == "nudElevation")
			c1chart1.ChartArea.PlotArea.View3D.Elevation = (int)nud.Value;

		else if(nud.Name == "nudInnerRadius")
			c1chart1.ChartGroups.Group0.Pie.InnerRadius = (int)nud.Value;

		else if(nud.Name == "nudStartAngle")
		{
			int val = (int)nud.Value % 360;
			if(val < 360) val += 360;
			c1chart1.ChartGroups.Group0.Pie.Start = val;
		}
	}

	// Handler for Chart MouseDown events to toggle Slice Offsets.
	private void Chart_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		// Only operate on Left mouse button.
		if(e.Button == System.Windows.Forms.MouseButtons.Left)
		{
			C1.Win.C1Chart.C1Chart chart = (C1.Win.C1Chart.C1Chart)sender;

			// Can only be a slice, if the mouse down in the PlotArea
			if(chart.ChartRegionFromCoord(e.X,e.Y) == C1.Win.C1Chart.ChartRegionEnum.PlotArea)
			{
				int seriesIndex = -1, pointIndex = -1, distance = -1;

				chart.ChartGroups.Group0.CoordToDataIndex(e.X,e.Y,C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord,
					ref seriesIndex, ref pointIndex, ref distance);

				// toggle the slice offset when clicked.
				if(distance == 0 && seriesIndex >= 0)
				{
					C1.Win.C1Chart.ChartDataSeries cds;
					cds = chart.ChartGroups.Group0.ChartData.SeriesList[seriesIndex];
					
					if(cds.Offset > 0)
						cds.Offset = 0;
					else
						cds.Offset = 20;
				}
			}
		}
	}

//</CodeSnippet>
}

//<Info>
//Create area chart.
//</Info>
public class Area: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				System.Windows.Forms.ComboBox cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb2.Items.AddRange(new object[] {"Normal","Stacked","100% Stacked"});
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Text = "Normal";
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxStacked_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Sample data
		double[] x = new double[] { 1, 2, 3};
		double[] y1 = new double[] { 1200, 1500, 2000};
		double[] y2 = new double[] { 700, 1200, 1400};
		
		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.FillStyle.Color1 = Palette.Light1;
		ds1.X.CopyDataIn( x);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "Series 2";
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.X.CopyDataIn( x);
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Area;

		//RtfGray
		// Set y-axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
		ComboBoxStacked_SelectedIndexChanged( _controls[1], EventArgs.Empty);
	}

	// handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 15;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
			c1chart1.ChartArea.PlotArea.Boxed = true;
		}
		else
		{
			c1chart1.ChartGroups[0].Use3D = false;
			c1chart1.ChartArea.PlotArea.Boxed = false;
		}
	}

	// handler for combo box
	private void ComboBoxStacked_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Normal":
				c1chart1.ChartGroups[0].Stacked = false;
				c1chart1.ChartGroups[0].Is100Percent = false;
				break;
			case "Stacked":
				c1chart1.ChartGroups[0].Stacked = true;
				c1chart1.ChartGroups[0].Is100Percent = false;
				break;
			case "100% Stacked":
				c1chart1.ChartGroups[0].Stacked = true;
				c1chart1.ChartGroups[0].Is100Percent = true;
				break;
		}
	}

}

//<Info>
//Create spline chart.
//</Info>
public class Spline: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 20;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark1;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Set spline fit
		ds.FitType = C1.Win.C1Chart.FitTypeEnum.Spline;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfGray
		// Set axes limits
		c1chart1.ChartArea.AxisY.SetMinMax( -1.1, 1.1);
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
	}
}

//<Info>
//Create polar chart.
//</Info>
public class Polar: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Sample data
		double[] x = new double[] { 0, 45, 90, 135, 180, 225, 270, 315};
		double[] y1 = new double[] { 1, 2, 3, 4, 5, 6, 7, 8};
		double[] y2 = new double[] { 8, 7, 6, 5, 4, 3, 2, 1};

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.LineStyle.Color = Palette.Light1;
		ds1.LineStyle.Thickness = 2;
		ds1.X.CopyDataIn( x);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "Series 2";
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.LineStyle.Color = Palette.Light2;
		ds2.LineStyle.Thickness = 2;
		ds2.X.CopyDataIn( x);
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Polar;

		//RtfGray
		// Set plot area color
		c1chart1.ChartArea.PlotArea.BackColor = Color.White;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Create radar chart.
//</Info>
public class Radar: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 60;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "Filled";
				cb1.CheckedChanged += new EventHandler(CheckBoxFilled_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Stacked";
				cb2.CheckedChanged += new EventHandler(CheckBoxStacked_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Sample data
		string[] items = new string[] { "Item1", "Item2", "Item3", "Item4"};
		int[] sales2002 = new int[] { 8, 4, 2, 1};
		int[] sales2003 = new int[] { 1, 2, 4, 8};

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "2002";
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.LineStyle.Color = Palette.Light1;
		ds1.LineStyle.Thickness = 2;
		ds1.X.CopyDataIn( items);
		ds1.Y.CopyDataIn( sales2002);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "2003";
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.LineStyle.Color = Palette.Light2;
		ds2.LineStyle.Thickness = 2;
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( sales2003);

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Radar;

		//RtfGray
		// Set y-axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
		c1chart1.ChartArea.AxisX.Thickness = 1;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
		CheckBoxFilled_CheckChanged( _controls[0], EventArgs.Empty);
		CheckBoxStacked_CheckChanged( _controls[1], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// handler for check box
	private void CheckBoxFilled_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		c1chart1.ChartGroups[0].Radar.Filled = cb.Checked;
	}

	// handler for check box
	private void CheckBoxStacked_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		c1chart1.ChartGroups[0].Stacked = cb.Checked;
	}
//</CodeSnippet>
}
//<Info>
//Create hi-lo chart.
//</Info>
public class HiLo: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Sample data
		DateTime[] dates = new DateTime[]
		{
			new DateTime(2005,5,17),
			new DateTime(2005,5,18),
			new DateTime(2005,5,19),
			new DateTime(2005,5,20),
			new DateTime(2005,5,21),
			new DateTime(2005,5,22)
		};
		int[] hi_values = new int[] { 23, 22, 27, 29, 30, 29};
		int[] low_values = new int[] { 12, 13, 13, 16, 19, 18};

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";
		ds.LineStyle.Color = Palette.Light1;
		ds.LineStyle.Thickness = 10;
		ds.X.CopyDataIn( dates);
		ds.Y.CopyDataIn( hi_values);
		ds.Y1.CopyDataIn( low_values);

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLo;

		// Set axis label format
		c1chart1.ChartArea.AxisX.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateShort;
		c1chart1.ChartArea.AxisX.SetMinMax( dates[0].AddDays(-0.5), dates[dates.Length-1].AddDays(0.5));

		//RtfGray
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Create hi-lo-open-close chart.
//</Info>
public class HiLoOpenClose: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";
		ds.LineStyle.Color = Palette.Dark1;
		ds.LineStyle.Thickness = 1;
		ds.SymbolStyle.Size = 3;
		ds.X.DataType = typeof(DateTime);

		// Read data from resource which has the following scheme
		// Date       Open    High    Low     Close   Volume
		// 2005-04-18	1.29135	1.30455	1.28775	1.30145	8320	1.297
		System.IO.StreamReader sr = new System.IO.StreamReader( System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("eur_usd.txt"));
		sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		while (sr.Peek() > -1 && ds.X.Length < 20) 
		{
			string line = sr.ReadLine();
			string[] fields = line.Split( null);

			ds.X.Add( DateTime.Parse( fields[0], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y.Add( double.Parse( fields[2], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y1.Add( double.Parse( fields[3], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y2.Add( double.Parse( fields[1], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y3.Add( double.Parse( fields[4], System.Globalization.CultureInfo.InvariantCulture));
		}
		sr.Close();

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose;

		//RtfGray
		// Set axis label format
		c1chart1.ChartArea.AxisX.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateShort;
		// Set y-axis text
		c1chart1.ChartArea.AxisY.Text = "Eur/Usd";
//</CodeSnippet>
	}
}
//<Info>
//Create candle chart.
//</Info>
public class Candle: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";
		ds.LineStyle.Color = Palette.Dark2;
		ds.LineStyle.Thickness = 1;
		ds.X.DataType = typeof(DateTime);

		// Read data from resource which has the following scheme
		// Date       Open    High    Low     Close   Volume
		// 2005-04-18	1.29135	1.30455	1.28775	1.30145	8320	1.297
		System.IO.StreamReader sr = new System.IO.StreamReader( System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("eur_usd.txt"));
		sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		while (sr.Peek() > -1 && ds.X.Length < 20) 
		{
			string line = sr.ReadLine();
			string[] fields = line.Split( null);

			ds.X.Add( DateTime.Parse( fields[0], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y.Add( double.Parse( fields[2], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y1.Add( double.Parse( fields[3], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y2.Add( double.Parse( fields[1], System.Globalization.CultureInfo.InvariantCulture));
			ds.Y3.Add( double.Parse( fields[4], System.Globalization.CultureInfo.InvariantCulture));
		}
		sr.Close();

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle;

		//RtfGray
		// Set axis label format
		c1chart1.ChartArea.AxisX.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateShort;
//</CodeSnippet>
	}
}
//<Info>
//Create complex hi-lo-open-close and bar chart.
//</Info>
public class HLOC_Volume: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		//RtfNormal
		// Create Group1 data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Color = Palette.Dark1;
		ds1.LineStyle.Thickness = 1;
		ds1.SymbolStyle.Size = 3;
		ds1.X.DataType = typeof(DateTime);

		// Create Group2 data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[1].ChartData.SeriesList.AddNewSeries();
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.X.DataType = typeof(DateTime);

		// Read data from resource which has the following scheme
		// Date       Open    High    Low     Close   Volume
		// 2005-04-18	1.29135	1.30455	1.28775	1.30145	8320	1.297
		System.IO.StreamReader sr = new System.IO.StreamReader( System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("eur_usd.txt"));
		sr.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
		while (sr.Peek() > -1) 
		{
			string line = sr.ReadLine();
			string[] fields = line.Split( null);

			ds1.X.Add( DateTime.Parse( fields[0], System.Globalization.CultureInfo.InvariantCulture));
			ds1.Y.Add( double.Parse( fields[2], System.Globalization.CultureInfo.InvariantCulture));
			ds1.Y1.Add( double.Parse( fields[3], System.Globalization.CultureInfo.InvariantCulture));
			ds1.Y2.Add( double.Parse( fields[1], System.Globalization.CultureInfo.InvariantCulture));
			ds1.Y3.Add( double.Parse( fields[4], System.Globalization.CultureInfo.InvariantCulture));

			ds2.X.Add( DateTime.Parse( fields[0], System.Globalization.CultureInfo.InvariantCulture));
			ds2.Y.Add( double.Parse( fields[5], System.Globalization.CultureInfo.InvariantCulture));
		}
		sr.Close();

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose;

		c1chart1.ChartGroups[1].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfGray
		// Set axis label format
		c1chart1.ChartArea.AxisX.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateShort;
		// Set y-axis text
		c1chart1.ChartArea.AxisY.Text = "Eur/Usd";

		c1chart1.ChartArea.AxisY2.SetMinMax( 0, ds2.MaxY * 2);
//</CodeSnippet>
	}
}
//<Info>
//Create bubble chart.
//</Info>
public class Bubble: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Colors
		Color[] clrs1 = new Color[]{ Palette.Light1, Palette.Light2, Palette.Light3};
		Color[] clrs2 = new Color[]{ Palette.Dark1, Palette.Dark2, Palette.Dark3};

		// Sample data
		double[] x = new double[] { 1, 2, 3};
		double[] y = new double[] { 2, 3, 1};
		double[] size = new double[] { 10, 50, 30};

		//RtfNormal		
		for( int i=0; i<x.Length; i++)
		{
			// Create data series
			C1.Win.C1Chart.ChartDataSeries ds =
				c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			ds.Label = "Series" + i.ToString();
			ds.X.Add( x[i]);
			ds.Y.Add( y[i]);
			ds.Y1.Add( size[i]);
			ds.SymbolStyle.Color = clrs1[i];
			ds.SymbolStyle.OutlineColor = clrs2[i];
			ds.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		}

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bubble;

		// Set size of symbols
		c1chart1.ChartGroups[0].Bubble.MaximumSize = 50;
		c1chart1.ChartGroups[0].Bubble.MinimumSize = 10;

		//RtfGray
		// Set axis limits
		c1chart1.ChartArea.AxisX.SetMinMax( 0, 4);
		c1chart1.ChartArea.AxisY.SetMinMax( 0, 4);
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Create combimation of bar and line charts.
//</Info>
public class ComplexChart: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D(Group 1)";
				cb1.CheckedChanged += new EventHandler(CheckBox3D1_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "3D(Group 2)";
				cb2.CheckedChanged += new EventHandler(CheckBox3D2_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}


	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Sample data
		float[] x = new float[] { 1, 2, 3};
		int[] y1 = new int[] { 8, 15, 20};
		int[] y2 = new int[] { 1000, 1200, 1400};

		//RtfNormal		
        	// Create line chart data series	
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "DataSeries(Group1)";
		ds1.LineStyle.Color = Palette.Dark1;
		ds1.LineStyle.Thickness = 2;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x);
		ds1.Y.CopyDataIn( y1);

        	// Create bar chart data series				
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[1].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "DataSeries(Group2)";
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.X.CopyDataIn( x);
		ds2.Y.CopyDataIn( y2);

		// Set chart types
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;
		c1chart1.ChartGroups[1].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfGray
		// Set axis minimum
		c1chart1.ChartArea.AxisY2.Min = 0;

		// Show legent at the bottom
		c1chart1.Legend.Visible = true;
		c1chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South;

		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
		CheckBox3D1_CheckChanged( _controls[0], EventArgs.Empty);
		CheckBox3D2_CheckChanged( _controls[1], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	void Set3D( C1.Win.C1Chart.ChartGroup grp, bool is3D)
	{
		grp.Use3D = is3D;

		if( is3D)
		{
			c1chart1.ChartArea.PlotArea.View3D.Depth = 10;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
		}
	}

	// Handler for check box
	private void CheckBox3D1_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		Set3D( c1chart1.ChartGroups[0], cb.Checked);
	}

	// Handler for check box
	private void CheckBox3D2_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		Set3D( c1chart1.ChartGroups[1], cb.Checked);
	}
//</CodeSnippet>
}

//<Info>
//Create gantt chart.
//</Info>
public class Gantt: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox3D_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1};
			}

			return _controls;
		}
	}


	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Colors
		Color[] clrs = new Color[]{ Palette.Light1, Palette.Light2, Palette.Light3};

		// Sample data
		DateTime[] start_dates = new DateTime[]
		{
			new DateTime(2003,1,1),
			new DateTime(2003,1,2),
			new DateTime(2003,1,3)
		};
		DateTime[] end_dates = new DateTime[]
		{
			new DateTime(2003,1,5),
			new DateTime(2003,1,4),
			new DateTime(2003,1,7)
		};

		//RtfNormal
		for( int i=0; i<start_dates.Length; i++)
		{
			// Create data series
			C1.Win.C1Chart.ChartDataSeries ds =
				c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
			ds.Label = "Task " + i.ToString();
			ds.Y.Add( start_dates[i]);
			ds.Y1.Add( end_dates[i]);
			ds.FillStyle.Color1 = clrs[i];
		}
		
		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Gantt;
		// Invert chart area
		c1chart1.ChartArea.Inverted = true;

		//RtfGray
		// Setup axis appearance
		c1chart1.ChartArea.AxisY.AnnoFormat = C1.Win.C1Chart.FormatEnum.DateShort;
		c1chart1.ChartArea.AxisX.TickMinor = C1.Win.C1Chart.TickMarksEnum.None;
		c1chart1.ChartArea.AxisX.OnTop = true;

		// Set axis limits
		c1chart1.ChartArea.AxisX.Min = -0.5;
		c1chart1.ChartArea.AxisX.Max = 2.5;
//</CodeSnippet>
		CheckBox3D_CheckChanged( _controls[0], EventArgs.Empty);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// Handler for check box
	private void CheckBox3D_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if( cb.Checked)
		{
			// Setup 3D appearance
			c1chart1.ChartGroups[0].Use3D = true;
			c1chart1.ChartArea.PlotArea.View3D.Depth = 10;
			c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
			c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
			c1chart1.ChartArea.PlotArea.Boxed = true;
		}
		else
		{
			// Set "flat" view
			c1chart1.ChartGroups[0].Use3D = false;
			c1chart1.ChartArea.PlotArea.Boxed = false;
		}
	}
//</CodeSnippet>
}

//<Info>
//Create and setup chart header.
//</Info>
public class Header: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		// Set font
		c1chart1.Header.Style.Font = new System.Drawing.Font("Arial",12,FontStyle.Underline);
		// Create hearder text
		c1chart1.Header.Text = string.Format( "{0} chart with {1} data series",
		  c1chart1.ChartGroups[0].ChartType.ToString(),
		  c1chart1.ChartGroups[0].ChartData.SeriesList.Count);
		// Show header
		c1chart1.Header.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Create and setup 2-line chart footer.
//</Info>
public class Footer: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Create border
		C1.Win.C1Chart.Border b = c1chart1.Footer.Style.Border;
		b.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
		b.Color = Palette.Back2;
		b.Rounding.LeftTop = 10;
		b.Rounding.RightTop = 10;

		//RtfNormal
		// Set footer text
		c1chart1.Footer.Text = string.Format("Created: {0}\nC1Chart version: {1}",
		  DateTime.Now, c1chart1.ProductVersion);
		
		// Show footer
		c1chart1.Footer.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Create chart footer with RTF.
//</Info>
public class Rtf: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		c1chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.None;

		System.Drawing.Font font = c1chart1.Footer.Style.Font;
		System.Windows.Forms.HorizontalAlignment align = System.Windows.Forms.HorizontalAlignment.Center;
		c1chart1.Footer.Rtf = "";
		c1chart1.Footer.Visible = true;
		c1chart1.Footer.AppendRtfText( "Red\n", System.Drawing.Color.Red, font, align);
		c1chart1.Footer.AppendRtfText( "Green\n", System.Drawing.Color.Green, font, align);
		c1chart1.Footer.AppendRtfText( "Blue", System.Drawing.Color.Blue, font, align);
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Footer.Rtf = "";
	}
}

//<Info>
//Shows different axis positions.
//</Info>
public class Position: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
				lbl1.Location = new System.Drawing.Point( 10, 0);
				lbl1.Width = 35;
				lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				lbl1.Text = "X axis";

				System.Windows.Forms.ComboBox cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb2.Items.AddRange(new object[] {"Not Visible","North","South"});
				cb2.Location = new System.Drawing.Point( lbl1.Right + 5, 0);
				cb2.Width = 60;
				cb2.Text = "North";
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxX_SelectedIndexChanged);

				System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
				lbl3.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				lbl3.Width = 35;
				lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				lbl3.Text = "Y axis";

				System.Windows.Forms.ComboBox cb4 = new System.Windows.Forms.ComboBox();
				cb4.BackColor = System.Drawing.SystemColors.Control;
				cb4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb4.Items.AddRange(new object[] {"Not Visible","West","East"});
				cb4.Location = new System.Drawing.Point( lbl3.Right + 5, 0);
				cb4.Width = 60;
				cb4.Text = "East";
				cb4.SelectedIndexChanged += new EventHandler(ComboBoxY_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ lbl1, cb2, lbl3, cb4};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// clear previous settings
		c1chart1.Reset();

		// create sample data		
		int n = 10;
		double[] x1 = new double[n], x2 = new double[n];
		double[] y1 = new double[n], y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		// Show legend
		c1chart1.Legend.Visible = true;

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Show plot area border
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set plot area color
		c1chart1.ChartArea.PlotArea.BackColor = Palette.Back3;

		//RtfNormal
		// setup axes
		c1chart1.ChartArea.AxisX.Text = "X-axis";
		c1chart1.ChartArea.AxisX.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisX.Compass = C1.Win.C1Chart.CompassEnum.North;

		c1chart1.ChartArea.AxisY.Text = "Y-axis";
		c1chart1.ChartArea.AxisY.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisY.Compass = C1.Win.C1Chart.CompassEnum.East;
//</CodeSnippet>
		ComboBoxX_SelectedIndexChanged( _controls[1], EventArgs.Empty);
		ComboBoxY_SelectedIndexChanged( _controls[3], EventArgs.Empty);
	}

//<CodeSnippet>
	// handler for combo box
	private void ComboBoxX_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Not Visible":
				c1chart1.ChartArea.AxisX.Visible = false;
				break;
			case "North":
				c1chart1.ChartArea.AxisX.Compass = C1.Win.C1Chart.CompassEnum.North;
				c1chart1.ChartArea.AxisX.Visible = true;
				break;
			case "South":
				c1chart1.ChartArea.AxisX.Compass = C1.Win.C1Chart.CompassEnum.South;
				c1chart1.ChartArea.AxisX.Visible = true;
				break;
		}
	}

	// handler for combo box
	private void ComboBoxY_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Not Visible":
				c1chart1.ChartArea.AxisY.Visible = false;
				break;
			case "West":
				c1chart1.ChartArea.AxisY.Compass = C1.Win.C1Chart.CompassEnum.West;
				c1chart1.ChartArea.AxisY.Visible = true;
				break;
			case "East":
				c1chart1.ChartArea.AxisY.Compass = C1.Win.C1Chart.CompassEnum.East;
				c1chart1.ChartArea.AxisY.Visible = true;
				break;
		}
	}
//</CodeSnippet>
}
//<Info>
//Shows using axis Origin property.
//</Info>
public class Origin: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
				lbl1.Location = new System.Drawing.Point( 10, 0);
				lbl1.Width = 35;
				lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				lbl1.Text = "X axis";

				System.Windows.Forms.TrackBar tb2 = new System.Windows.Forms.TrackBar();
				tb2.BackColor = System.Drawing.SystemColors.Control;
				tb2.Location = new System.Drawing.Point( lbl1.Right + 5, 0);
				tb2.Width = 100;
				tb2.Minimum = -10;
				tb2.Maximum = 10;
				tb2.TickStyle = System.Windows.Forms.TickStyle.None;
				tb2.SmallChange = 2;
				tb2.Value = 0;
				tb2.ValueChanged += new EventHandler(TrackBarX_ValueChanged);

				System.Windows.Forms.Label lbl3 = new System.Windows.Forms.Label();
				lbl3.Location = new System.Drawing.Point( tb2.Right + 10, 0);
				lbl3.Width = 35;
				lbl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				lbl3.Text = "Y axis";

				System.Windows.Forms.TrackBar tb4 = new System.Windows.Forms.TrackBar();
				tb4.BackColor = System.Drawing.SystemColors.Control;
				tb4.Location = new System.Drawing.Point( lbl3.Right + 5, 0);
				tb4.Width = 100;
				tb4.Minimum = -10;
				tb4.Maximum = 10;
				tb4.TickStyle = System.Windows.Forms.TickStyle.None;
				tb4.SmallChange = 2;
				tb4.Value = 0;
				tb4.ValueChanged += new EventHandler(TrackBarY_ValueChanged);

				_controls = new System.Windows.Forms.Control[]{ lbl1, tb2, lbl3, tb4};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// clear previous settings
		c1chart1.Reset();

		// create sample data		
		int n = 10;
		double[] x1 = new double[n], x2 = new double[n];
		double[] y1 = new double[n], y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		// Show legend
		c1chart1.Legend.Visible = true;

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Create chart area border
		C1.Win.C1Chart.Border b = c1chart1.ChartArea.Style.Border;
		b.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		// Set chart area color
		c1chart1.ChartArea.Style.BackColor = Palette.Back3;

		//RtfNormal
		// setup axes
		c1chart1.ChartArea.AxisX.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisX.Origin = 0;

		c1chart1.ChartArea.AxisY.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisY.Origin = 0;
//</CodeSnippet>
		TrackBarX_ValueChanged( _controls[1], EventArgs.Empty);
		TrackBarY_ValueChanged( _controls[3], EventArgs.Empty);
	}
//<CodeSnippet>
	// handler for track bar
	private void TrackBarX_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.TrackBar tb = (System.Windows.Forms.TrackBar)sender;
		
		c1chart1.ChartArea.AxisX.Origin = tb.Value * 0.1;
	}

	// handler for track bar
	private void TrackBarY_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.TrackBar tb = (System.Windows.Forms.TrackBar)sender;
		
		c1chart1.ChartArea.AxisY.Origin = tb.Value  * 0.1;
	}
//</CodeSnippet>

}
//<Info>
//Shows gridlines over plot area.
//</Info>
public class Gridlines: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 60;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "X Major";
				cb1.Checked = true;
				cb1.CheckedChanged += new EventHandler(CheckBoxXMajor_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Width = 60;
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "X Minor";
				cb2.Checked = true;
				cb2.CheckedChanged += new EventHandler(CheckBoxXMinor_CheckChanged);

				System.Windows.Forms.CheckBox cb3 = new System.Windows.Forms.CheckBox();
				cb3.Width = 60;
				cb3.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb3.Text = "Y Major";
				cb3.Checked = true;
				cb3.CheckedChanged += new EventHandler(CheckBoxYMajor_CheckChanged);

				System.Windows.Forms.CheckBox cb4 = new System.Windows.Forms.CheckBox();
				cb4.Width = 60;
				cb4.Location = new System.Drawing.Point( cb3.Right + 10, 0);
				cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb4.Text = "Y Minor";
				cb4.Checked = true;
				cb4.CheckedChanged += new EventHandler(CheckBoxYMinor_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb3, cb4};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// clear previous settings
		c1chart1.Reset();

		// create sample data		
		int n = 10;
		double[] x1 = new double[n], x2 = new double[n];
		double[] y1 = new double[n], y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		// Show legend
		c1chart1.Legend.Visible = true;

		// Set plot area color
		c1chart1.ChartArea.PlotArea.BackColor = Palette.Back3;

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// setup axes
		c1chart1.ChartArea.AxisX.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisX.GridMajor.Visible = true;
		c1chart1.ChartArea.AxisX.GridMajor.Color = Color.Black;
		c1chart1.ChartArea.AxisX.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
		c1chart1.ChartArea.AxisX.GridMinor.Visible = true;
		c1chart1.ChartArea.AxisX.GridMinor.Color = Color.Gray;

		c1chart1.ChartArea.AxisY.SetMinMax(-1, 1);
		c1chart1.ChartArea.AxisY.GridMajor.Visible = true;
		c1chart1.ChartArea.AxisY.GridMajor.Color = Color.Black;
		c1chart1.ChartArea.AxisY.GridMajor.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
		c1chart1.ChartArea.AxisY.GridMinor.Visible = true;
		c1chart1.ChartArea.AxisY.GridMinor.Color = Color.Gray;
//</CodeSnippet>
		CheckBoxXMajor_CheckChanged( _controls[0], EventArgs.Empty);
		CheckBoxXMinor_CheckChanged( _controls[1], EventArgs.Empty);
		CheckBoxYMajor_CheckChanged( _controls[2], EventArgs.Empty);
		CheckBoxYMinor_CheckChanged( _controls[3], EventArgs.Empty);
	}
//<CodeSnippet>
	// handler for check box
	private void CheckBoxXMajor_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		c1chart1.ChartArea.AxisX.GridMajor.Visible = cb.Checked;
	}

	// handler for check box
	private void CheckBoxXMinor_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		c1chart1.ChartArea.AxisX.GridMinor.Visible = cb.Checked;
	}

	// handler for check box
	private void CheckBoxYMajor_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		c1chart1.ChartArea.AxisY.GridMajor.Visible = cb.Checked;
	}

	// handler for check box
	private void CheckBoxYMinor_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		c1chart1.ChartArea.AxisY.GridMinor.Visible = cb.Checked;
	}
//</CodeSnippet>
}
//<Info>
//Create chart with logarithmic axes.
//</Info>
public class Logarithmic: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// clear previous settings
		c1chart1.Reset();

		// create sample data		
		int n = 10;
		double[] x1 = new double[n], x2 = new double[n];
		double[] y1 = new double[n], y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = rnd.NextDouble()*10;
			y1[i] = rnd.NextDouble()*10;
			x2[i] = rnd.NextDouble();
			y2[i] = rnd.NextDouble();
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Set plot area color
		c1chart1.ChartArea.PlotArea.BackColor = Palette.Back3;

		//RtfNormal
		// setup axes
		c1chart1.ChartArea.AxisX.SetMinMax(0.1, 10);
		c1chart1.ChartArea.AxisX.GridMajor.Visible = true;
		c1chart1.ChartArea.AxisX.GridMajor.Color = Color.Black;
		c1chart1.ChartArea.AxisX.GridMinor.Visible = true;
		c1chart1.ChartArea.AxisX.GridMinor.Color = Color.Black;
		c1chart1.ChartArea.AxisX.IsLogarithmic = true;

		c1chart1.ChartArea.AxisY.SetMinMax(0.1, 10);
		c1chart1.ChartArea.AxisY.GridMajor.Visible = true;
		c1chart1.ChartArea.AxisY.GridMajor.Color = Color.Black;
		c1chart1.ChartArea.AxisY.GridMinor.Visible = true;
		c1chart1.ChartArea.AxisY.GridMinor.Color = Color.Black;
		c1chart1.ChartArea.AxisY.IsLogarithmic = true;
//</CodeSnippet>
	}
}

//<Info>
//Creates value labels annotation.
//</Info>
public class ValueLabels: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Data
		float[] data1 = new float[] { 800, 1500, 2000, 100};
		float[] data2 = new float[] { 1000, 1200, 1400, 200};
		
		// Create first series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.FillStyle.Color1 = Palette.Light1;
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( data1);
			
		// Create second series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( data2);

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfNormal
		string[] labels = new string[] { "Winter", "Spring", "Summer", "Autumn"};
		Color[] clrs = new Color[] { Color.Blue, Color.Green, Color.Orange, Color.Red};

		for( int i= 0; i< labels.Length; i++)
		{
			C1.Win.C1Chart.ValueLabel vl = c1chart1.ChartArea.AxisX.ValueLabels.AddNewLabel();
			vl.NumericValue = i;
			vl.Text = labels[i];
			vl.Color = clrs[i];
		}

		// Change anno method
		c1chart1.ChartArea.AxisX.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.ValueLabels;
		

		//RtfGray
		// Set x-axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
		c1chart1.ChartArea.AxisX.OnTop = true;
		c1chart1.ChartArea.AxisY.OnTop = true;
		// Show legend
		// c1chart1.Legend.Visible = true;
//</CodeSnippet>
	}
}
//<Info>
//Shows using value labels as markers.
//</Info>
public class Markers: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();
		
		// Create sample data
		int n = 10;
		double[] x1 = new double[n];
		double[] x2 = new double[n];
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*rnd.NextDouble() - 1;
			y1[i] = 2*rnd.NextDouble() - 1;
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "Series 2";
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		c1chart1.ChartArea.AxisX.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.Mixed;

		C1.Win.C1Chart.ValueLabel markerX = c1chart1.ChartArea.AxisX.ValueLabels.AddNewLabel();
		markerX.NumericValue = 0;
		markerX.Moveable = true;
		markerX.MarkerSize = 15;
		markerX.GridLine = true;
		markerX.Color = Palette.Dark1;
		markerX.Appearance = C1.Win.C1Chart.ValueLabelAppearanceEnum.ArrowMarker;

		c1chart1.ChartArea.AxisY.AnnoMethod = C1.Win.C1Chart.AnnotationMethodEnum.Mixed;
		C1.Win.C1Chart.ValueLabel markerY = c1chart1.ChartArea.AxisY.ValueLabels.AddNewLabel();
		markerY.NumericValue = 0;
		markerY.Moveable = true;
		markerY.MarkerSize = 15;
		markerY.GridLine = true;
		markerY.Color = Palette.Dark1;
		markerY.Appearance = C1.Win.C1Chart.ValueLabelAppearanceEnum.ArrowMarker;
//</CodeSnippet>
	}
}

//<Info>
//Shows different data fill styles.
//</Info>
public class FillStyle: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox cb1, cb2;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] { C1.Win.C1Chart.FillTypeEnum.SolidColor,
																					C1.Win.C1Chart.FillTypeEnum.Gradient,
																					C1.Win.C1Chart.FillTypeEnum.Hatch});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = cb1.Items[0].ToString();
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxFillType_SelectedIndexChanged);

				cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				FillComboBox( cb2, typeof(C1.Win.C1Chart.GradientStyleEnum));
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Text = cb2.Items[0].ToString();
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxFillSubtype_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 5;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = rnd.NextDouble()*10;
			y2[i] = rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds1.FillStyle.Color2 = Palette.Dark1;
		ds1.FillStyle.Color1 = Palette.Light1;

		// Copy data into chart
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds2.FillStyle.Color2 = Palette.Dark2;
		ds2.FillStyle.Color1 = Palette.Light2;

		// Copy data into chart
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfNormal

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
		ComboBoxFillType_SelectedIndexChanged( _controls[0], EventArgs.Empty);
		ComboBoxFillSubtype_SelectedIndexChanged( _controls[1], EventArgs.Empty);
	}

//<CodeSnippet>

	//RtfNormal
	void SetFillType( C1.Win.C1Chart.FillTypeEnum ft)
	{
		C1.Win.C1Chart.GradientStyleEnum gs = C1.Win.C1Chart.GradientStyleEnum.None;
		C1.Win.C1Chart.HatchStyleEnum hs = C1.Win.C1Chart.HatchStyleEnum.None;
		C1.Win.C1Chart.ChartData data =	c1chart1.ChartGroups[0].ChartData;

		foreach( C1.Win.C1Chart.ChartDataSeries ds in data.SeriesList)
		{
			ds.FillStyle.FillType = ft;
			gs = ds.FillStyle.GradientStyle;
			hs = ds.FillStyle.HatchStyle;
		}

		switch( ft)
		{
			case C1.Win.C1Chart.FillTypeEnum.SolidColor:
				cb2.Items.Clear();
				cb2.Enabled = false;
				break;
			case C1.Win.C1Chart.FillTypeEnum.Gradient:
				FillComboBox( cb2, typeof(C1.Win.C1Chart.GradientStyleEnum));;
				cb2.Enabled = true;
				cb2.SelectedItem = gs;
				break;
			case C1.Win.C1Chart.FillTypeEnum.Hatch:
				FillComboBox( cb2, typeof(C1.Win.C1Chart.HatchStyleEnum));
				cb2.Enabled = true;
				cb2.SelectedItem = hs;
				break;
		}
	}

	void SetFillGradientStyle( C1.Win.C1Chart.GradientStyleEnum gs)
	{
		C1.Win.C1Chart.ChartData data =	c1chart1.ChartGroups[0].ChartData;

		foreach( C1.Win.C1Chart.ChartDataSeries ds in data.SeriesList)
			ds.FillStyle.GradientStyle = gs;
	}

	void SetFillHatchStyle( C1.Win.C1Chart.HatchStyleEnum hs)
	{
		C1.Win.C1Chart.ChartData data =	c1chart1.ChartGroups[0].ChartData;

		foreach( C1.Win.C1Chart.ChartDataSeries ds in data.SeriesList)
			ds.FillStyle.HatchStyle = hs;
	}

	//RtfGray
	// handler for combo box
	private void ComboBoxFillType_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( cb.SelectedItem is C1.Win.C1Chart.FillTypeEnum)
			SetFillType( (C1.Win.C1Chart.FillTypeEnum) cb.SelectedItem);
	}

	// handler for combo box
	private void ComboBoxFillSubtype_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		if( cb.SelectedItem is C1.Win.C1Chart.GradientStyleEnum )
			SetFillGradientStyle( (C1.Win.C1Chart.GradientStyleEnum) cb.SelectedItem);
		if( cb.SelectedItem is C1.Win.C1Chart.HatchStyleEnum )
			SetFillHatchStyle( (C1.Win.C1Chart.HatchStyleEnum) cb.SelectedItem);
	}
//</CodeSnippet>

}
//<Info>
//Show texture data fill style.
//</Info>
public class Texture: ChartSample
{
	System.Drawing.Image _img1, _img2;

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 3;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = rnd.NextDouble()*10;
			y2[i] = rnd.NextDouble()*10;
		}

		//RtfNormal
		// load images from resource
		if( _img1 == null)
			_img1  = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly()
			.GetManifestResourceStream("images.texture1.jpg"));

		if( _img2 == null)
			_img2  = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly()
			.GetManifestResourceStream("images.texture2.jpg"));

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds1.FillStyle.FillType = C1.Win.C1Chart.FillTypeEnum.Texture;
		ds1.FillStyle.Image = _img1;

		// Copy data into chart
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds2.FillStyle.FillType = C1.Win.C1Chart.FillTypeEnum.Texture;
		ds2.FillStyle.Image = _img2;

		// Copy data into chart
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		//RtfGray
		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
	}
}

//<Info>
//Shows using labels with various attachment.
//</Info>
public class Labels: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// clear previous settings
		c1chart1.Reset();

		// create sample data		
		int n = 10;
		double[] x1 = new double[n], x2 = new double[n];
		double[] y1 = new double[n], y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		// Show legend
		c1chart1.Legend.Visible = true;

		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Show plot area border
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set plot area color
		c1chart1.ChartArea.PlotArea.BackColor = Palette.Back3;

		c1chart1.ChartArea.Margins.Top = 20;
		
		//RtfNormal
		// Set label appearance
      		c1chart1.ChartLabels.DefaultLabelStyle.BackColor = Color.FromArgb( 128, Palette.Back2);
		c1chart1.ChartLabels.DefaultLabelStyle.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
		c1chart1.ChartLabels.DefaultLabelStyle.Border.Rounding.All = 5;
	
		// Create label attached by coordinates
		C1.Win.C1Chart.Label lbl1 = c1chart1.ChartLabels.LabelsCollection.AddNewLabel();
		lbl1.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.Coordinate;
		lbl1.AttachMethodData.X = 10;
		lbl1.AttachMethodData.Y = 10;
		lbl1.Compass = C1.Win.C1Chart.LabelCompassEnum.SouthEast;
		lbl1.Text = "x=10,y=10";
		lbl1.Visible = true;

		// Create label attached by data coordinate
		C1.Win.C1Chart.Label lbl2 = c1chart1.ChartLabels.LabelsCollection.AddNewLabel();
		lbl2.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.DataCoordinate;
		lbl2.AttachMethodData.GroupIndex = 0;
		lbl2.AttachMethodData.X = 0;
		lbl2.AttachMethodData.Y = 0;
		lbl2.Compass = C1.Win.C1Chart.LabelCompassEnum.NorthEast;
		lbl2.Offset = 10;
		lbl2.Connected = true;
		lbl2.Text = "dx=0,dy=0";
		lbl2.Visible = true;

		// Create label attached by data index
		C1.Win.C1Chart.Label lbl3 = c1chart1.ChartLabels.LabelsCollection.AddNewLabel();
		lbl3.AttachMethod = C1.Win.C1Chart.AttachMethodEnum.DataIndex;
		lbl3.AttachMethodData.GroupIndex = 0;
		lbl3.AttachMethodData.SeriesIndex = 0;
		lbl3.AttachMethodData.PointIndex = 0;
		lbl3.Offset = 10;
		lbl3.Connected = true;
		lbl3.Compass = C1.Win.C1Chart.LabelCompassEnum.North;
		lbl3.Text = "si=0,pi=0";
		lbl3.Visible = true;
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.ChartLabels.LabelsCollection.Clear();
		base.Unload( c1chart1);
	}
}

//<Info>
//Show using automatic data labelling.
//</Info>
public class DataLabels: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.ComboBox cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"XYPlot","Bar","Pie"});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = "XYPlot";
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxChartType_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 4;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = rnd.NextDouble()*10;
			y2[i] = 10 + rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds1.LineStyle.Color = Palette.Light3;
		ds1.FillStyle.Color1 = Palette.Light3;
		ds1.LineStyle.Thickness = 2;
		ds1.SymbolStyle.Color = Palette.Light3;
		ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds1.SymbolStyle.OutlineColor = Palette.Dark3;

 		// Copy data into chart
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds2.LineStyle.Color = Palette.Light2;
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.LineStyle.Thickness = 2;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Diamond;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Add space for labels
		c1chart1.ChartGroups[0].Pie.OtherOffset = 25;

		//RtfNormal
		// Setup data labels

		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
		{
			ds.DataLabel.Text = "{#YVAL:0.0}";
			ds.DataLabel.Visible = true;
			ds.DataLabel.Offset = 5;
			ds.DataLabel.Connected = true;
			ds.DataLabel.Style.BackColor = Palette.Back3;
			ds.DataLabel.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Raised;
		}

		//RtfGray
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
		ComboBoxChartType_SelectedIndexChanged( _controls[0], EventArgs.Empty);
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
			ds.DataLabel.Visible = false;
		base.Unload( c1chart1);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// handler for combo box
	private void ComboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "XYPlot":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;
				foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
					ds.DataLabel.Compass = C1.Win.C1Chart.LabelCompassEnum.NorthEast;
				break;
			case "Bar":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;
				foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
					ds.DataLabel.Compass = C1.Win.C1Chart.LabelCompassEnum.North;
				break;
			case "Pie":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie;
				foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
					ds.DataLabel.Compass = C1.Win.C1Chart.LabelCompassEnum.Orthogonal;
				break;
		}
	}
//</CodeSnippet>

}
//<Info>
//Shows using colors for basic chart elements.
//</Info>
public class Colors: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox cb1 = null, cb2 = null, cb3 = null;
	System.Windows.Forms.Button btn1 = null, btn2 = null, btn3 = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"Chart", "ChartArea", "Header","Footer","Legend"});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = "Chart";
				cb1.Width = 75;
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxChartElement_SelectedIndexChanged);

				cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb2.Items.AddRange(new object[] {"Solid", "Gradient", "Hatched"});
				cb2.Width = 65;
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxFill_SelectedIndexChanged);

				cb3 = new System.Windows.Forms.ComboBox();
				cb3.BackColor = System.Drawing.SystemColors.Control;
				cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb3.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb3.Width = 100;
				cb3.SelectedIndexChanged += new EventHandler(ComboBoxType_SelectedIndexChanged);

				btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( cb3.Right + 10, 0);
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Width = 30;
				btn1.Height = 21;
				btn1.Text = "B";
				btn1.Click += new EventHandler(ButtonColor_Click);
				btn1.BackColorChanged += new EventHandler(ButtonColor_BackColorChanged);

				btn2 = new System.Windows.Forms.Button();
				btn2.Location = new System.Drawing.Point( btn1.Right, 0);
				btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn2.Width = 30;
				btn2.Height = 21;
				btn2.Text = "B2";
				btn2.Click += new EventHandler(ButtonColor_Click);
				btn2.BackColorChanged += new EventHandler(ButtonColor_BackColorChanged);
				btn2.EnabledChanged += new EventHandler(ButtonColor_EnabledChanged);

				btn3 = new System.Windows.Forms.Button();
				btn3.Location = new System.Drawing.Point( btn2.Right + 10, 0);
				btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn3.Width = 60;
				btn3.Height = 21;
				btn3.Text = "F";
				btn3.Click += new EventHandler(ButtonColor_Click);
				btn3.BackColorChanged += new EventHandler(ButtonColor_BackColorChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb3, btn1, btn2, btn3};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);

		c1chart1.ChartArea.PlotArea.Opaque = false;
		c1chart1.Legend.Visible = true;
		c1chart1.Legend.Text = "Legend";

		c1chart1.Header.Visible = true;
		c1chart1.Header.Text = "Header";

		c1chart1.Footer.Visible = true;
		c1chart1.Footer.Text = "Footer";

		c1chart1.Style.BackColor = Palette.Back;

		ComboBoxChartElement_SelectedIndexChanged( _controls[0], EventArgs.Empty);
	}
//<CodeSnippet>
	C1.Win.C1Chart.Style _style = null;

	private void ComboBoxChartElement_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Chart":
				_style = c1chart1.Style;
				break;
			case "ChartArea":
				_style = c1chart1.ChartArea.Style;
				break;
			case "Legend":
				_style = c1chart1.Legend.Style;
				break;
			case "Header":
				_style = c1chart1.Header.Style;
				break;
			case "Footer":
				_style = c1chart1.Footer.Style;
				break;
		}
		if( _style!=null)
		{
			if( _style.GradientStyle != C1.Win.C1Chart.GradientStyleEnum.None)
				cb2.Text = "Gradient";
			else if( _style.HatchStyle != C1.Win.C1Chart.HatchStyleEnum.None)
				cb2.Text = "Hatched";
			else
				cb2.Text = "Solid";
			
			btn1.BackColor = _style.BackColor;
			if( _style.BackColor2.IsEmpty || _style.BackColor2.Equals(_style.BackColor))
			{
				_style.BackColor2 = Palette.Back2;
				btn2.BackColor = _style.BackColor2;
			}
			else
				btn2.BackColor = _style.BackColor2;
			btn3.BackColor = _style.ForeColor;
		}
	}

	private void ComboBoxFill_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( _style!=null)
		{
			switch( cb.Text)
			{
				case "Solid":
					cb3.Items.Clear();
					cb3.Enabled = false;
					btn2.Enabled = false;
					_style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.None;
					_style.HatchStyle = C1.Win.C1Chart.HatchStyleEnum.None;
					break;
				case "Gradient":
					FillComboBox( cb3, typeof(C1.Win.C1Chart.GradientStyleEnum));;
					cb3.Items.Remove( C1.Win.C1Chart.GradientStyleEnum.None);
					cb3.Enabled = true;
					btn2.Enabled = true;
					_style.HatchStyle = C1.Win.C1Chart.HatchStyleEnum.None;
					if( _style.GradientStyle == C1.Win.C1Chart.GradientStyleEnum.None)
						_style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.Horizontal;
					cb3.SelectedItem = _style.GradientStyle;
					break;
				case "Hatched":
					FillComboBox( cb3, typeof(C1.Win.C1Chart.HatchStyleEnum));
					cb3.Items.Remove( C1.Win.C1Chart.HatchStyleEnum.None);
					cb3.Enabled = true;
					btn2.Enabled = true;
					_style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.None;
					if( _style.HatchStyle == C1.Win.C1Chart.HatchStyleEnum.None)
						_style.HatchStyle = C1.Win.C1Chart.HatchStyleEnum.Horizontal;
					cb3.SelectedItem = _style.HatchStyle;
					break;
			}
		}
	}

	private void ComboBoxType_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( _style!=null)
		{
			if( cb.SelectedItem is C1.Win.C1Chart.GradientStyleEnum )
				_style.GradientStyle = (C1.Win.C1Chart.GradientStyleEnum) cb.SelectedItem;
			if( cb.SelectedItem is C1.Win.C1Chart.HatchStyleEnum )
				_style.HatchStyle = (C1.Win.C1Chart.HatchStyleEnum) cb.SelectedItem;

		}
	}

	private void ButtonColor_Click(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

		System.Windows.Forms.ColorDialog dlg = new System.Windows.Forms.ColorDialog();
		dlg.Color = btn.BackColor ;
		if( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
		{
			btn.BackColor = dlg.Color;
		
			if( _style!=null)
			{
				switch( btn.Text)
				{
					case "B":
						_style.BackColor = btn.BackColor;
						break;
					case "B2":
						_style.BackColor2 = btn.BackColor;
						break;
					case "F":
						_style.ForeColor = btn.BackColor;
						break;
				}
			}
		}
	}

	//RtfGray
	private void ButtonColor_BackColorChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

		// Set contrast fore color
		if( btn.BackColor.GetBrightness() < 0.5)
			btn.ForeColor = Color.White;
		else
			btn.ForeColor = Color.Black;
	}

	private void ButtonColor_EnabledChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

		if( btn.Enabled)
			btn1.Width = 30;
		else
			btn1.Width = 60;
	}

//</CodeSnippet>
}
//<Info>
//Shows using borders for basic chart elements.
//</Info>
public class Borders: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox cb1 = null, cb2 = null;
	System.Windows.Forms.NumericUpDown ud1 = null, ud2 = null;
	System.Windows.Forms.Button btn1 = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"ChartArea", "Header","Footer","Legend"});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = "ChartArea";
				cb1.Width = 75;
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxChartElement_SelectedIndexChanged);

				cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				FillComboBox( cb2, typeof(C1.Win.C1Chart.BorderStyleEnum));
				cb2.Items.Remove( C1.Win.C1Chart.BorderStyleEnum.NotSet);
				cb2.Width = 85;
				cb2.Location = new System.Drawing.Point( cb1.Right + 5, 0);
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxBorder_SelectedIndexChanged);

				btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( cb2.Right + 5, 0);
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Width = 45;
				btn1.Height = 21;
				btn1.Text = "Color";
				btn1.Click += new EventHandler(ButtonColor_Click);
				btn1.BackColorChanged += new EventHandler(ButtonColor_BackColorChanged);

				System.Windows.Forms.Label lbl1 = new System.Windows.Forms.Label();
				lbl1.Location = new System.Drawing.Point( btn1.Right + 5, 0);
				lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				lbl1.Text = "Thickness";
				lbl1.Width = 55;

				ud1 = new System.Windows.Forms.NumericUpDown();
				ud1.Location = new System.Drawing.Point( lbl1.Right + 2, 2);
				ud1.Width = 35;
				ud1.BackColor = System.Drawing.SystemColors.Control;
				ud1.Minimum = 1;
				ud1.Maximum = 10;
				ud1.ValueChanged += new EventHandler(Thickness_ValueChanged);

				System.Windows.Forms.Label lbl2 = new System.Windows.Forms.Label();
				lbl2.Location = new System.Drawing.Point( ud1.Right + 5, 0);
				lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
				lbl2.Text = "Rounding";
				lbl2.Width = 55;

				ud2 = new System.Windows.Forms.NumericUpDown();
				ud2.Location = new System.Drawing.Point( lbl2.Right + 2, 2);
				ud2.Width = 35;
				ud2.BackColor = System.Drawing.SystemColors.Control;
				ud2.Minimum = 0;
				ud2.Maximum = 20;
				ud2.ValueChanged += new EventHandler(Rounding_ValueChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, btn1, lbl1, ud1, lbl2, ud2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);

		c1chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1chart1.Legend.Visible = true;
		c1chart1.Legend.Text = "Legend";
		c1chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1chart1.Header.Visible = true;
		c1chart1.Header.Text = "Header";
		c1chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1chart1.Footer.Visible = true;
		c1chart1.Footer.Text = "Footer";
		c1chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		ComboBoxChartElement_SelectedIndexChanged( _controls[0], EventArgs.Empty);
	}
//<CodeSnippet>
	// Border of selected chart element
	C1.Win.C1Chart.Border _border = null;

	private void ComboBoxChartElement_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "ChartArea":
				_border = c1chart1.ChartArea.Style.Border;
				break;
			case "Legend":
				_border = c1chart1.Legend.Style.Border;
				break;
			case "Header":
				_border = c1chart1.Header.Style.Border;
				break;
			case "Footer":
				_border = c1chart1.Footer.Style.Border;
				break;
		}
		if( _border!=null)
		{
			if( _border.Color.IsEmpty || _border.Color.Equals( System.Drawing.Color.Transparent))
				_border.Color = Palette.Fore;
			btn1.BackColor = _border.Color;
			ud1.Value = _border.Thickness;
			ud2.Value = _border.Rounding.All;

			cb2.SelectedItem = _border.BorderStyle;
		}
	}

	private void ComboBoxBorder_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( _border!=null && cb.SelectedItem!=null)
		{
			_border.BorderStyle = (C1.Win.C1Chart.BorderStyleEnum) cb.SelectedItem;
			_border.Color = btn1.BackColor;
		}
	}

	private void ButtonColor_Click(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

		System.Windows.Forms.ColorDialog dlg = new System.Windows.Forms.ColorDialog();
		dlg.Color = btn.BackColor ;
		if( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
		{
			btn.BackColor = dlg.Color;
		
			if( _border!=null)
				_border.Color = btn.BackColor;
		}
	}

	private void Thickness_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown ud = (System.Windows.Forms.NumericUpDown)sender;

		if( _border!=null)
			_border.Thickness = (int)ud.Value;
	}


	private void Rounding_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown ud = (System.Windows.Forms.NumericUpDown)sender;

		if( _border!=null)
			_border.Rounding.All = (int)ud.Value;
	}

	//RtfGray
	private void ButtonColor_BackColorChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

		// Set contrast fore color
		if( btn.BackColor.GetBrightness() < 0.5)
			btn.ForeColor = Color.White;
		else
			btn.ForeColor = Color.Black;
	}
//</CodeSnippet>
}
//<Info>
//Shows using fonts for basic chart elements.
//</Info>
public class Fonts: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox cb1 = null, cb2 = null, cb3 = null;
	System.Windows.Forms.CheckBox cb4 = null, cb5 = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"Header","Footer","Legend"});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = "Header";
				cb1.Width = 60;
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxChartElement_SelectedIndexChanged);

				cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				System.Drawing.FontFamily[] families = System.Drawing.FontFamily.Families;
				string[] fnames = new string[families.Length];
				for( int i= 0; i< fnames.Length; i++)
					fnames[i] = families[i].Name;
				cb2.Items.AddRange(fnames);
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxFont_SelectedIndexChanged);

				cb3 = new System.Windows.Forms.ComboBox();
				cb3.BackColor = System.Drawing.SystemColors.Control;
				cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb3.Items.AddRange(new object[]{ 8, 10, 12, 16, 20, 24, 32});
				cb3.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb3.Width = 40;
				cb3.SelectedIndexChanged += new EventHandler(ComboBoxSize_SelectedIndexChanged);

				cb4 = new System.Windows.Forms.CheckBox();
				cb4.Location = new System.Drawing.Point( cb3.Right + 10, 0);
				cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb4.Width = 45;
				cb4.Text = "Bold";
				cb4.CheckedChanged += new EventHandler(CheckBoxBold_CheckChanged);

				cb5 = new System.Windows.Forms.CheckBox();
				cb5.Location = new System.Drawing.Point( cb4.Right + 10, 0);
				cb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb5.Text = "Italic";
				cb5.CheckedChanged += new EventHandler(CheckBoxItalic_CheckChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb3, cb4, cb5};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
		c1chart1.Legend.Visible = true;
		c1chart1.Legend.Text = "Legend";

		c1chart1.Header.Visible = true;
		c1chart1.Header.Text = "Header";

		c1chart1.Footer.Visible = true;
		c1chart1.Footer.Text = "Footer";

		ComboBoxChartElement_SelectedIndexChanged( _controls[0], EventArgs.Empty);
	}
//<CodeSnippet>
	C1.Win.C1Chart.Style _style = null;

	private void ComboBoxChartElement_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Legend":
				_style = c1chart1.Legend.Style;
				break;
			case "Header":
				_style = c1chart1.Header.Style;
				break;
			case "Footer":
				_style = c1chart1.Footer.Style;
				break;
		}
		if( _style!=null)
		{
			if( cb2.Text != _style.Font.Name)
					cb2.Text = _style.Font.Name;
			if( cb3.SelectedItem == null || (int)cb3.SelectedItem != _style.Font.Size)
				cb3.SelectedItem = (int)_style.Font.Size;
			cb4.Checked = (_style.Font.Style & System.Drawing.FontStyle.Bold) > 0;
			cb5.Checked = (_style.Font.Style & System.Drawing.FontStyle.Italic) > 0;
		}
	}

	private void ComboBoxFont_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( _style!=null && _style.Font.Name != cb.Text)
		{
			System.Drawing.Font font = _style.Font;
			System.Drawing.Font new_font = new System.Drawing.Font( cb.Text, font.Size, font.Style);
			_style.Font = new_font;
		}
	}

	private void ComboBoxSize_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;

		if( _style!=null)
		{
			System.Drawing.Font font = _style.Font;
			System.Drawing.Font new_font = new System.Drawing.Font( font.Name, (int)cb.SelectedItem, font.Style);
			_style.Font = new_font;
		}
	}

	private void SetFontStyle( System.Drawing.FontStyle fs, bool enable)
	{
		if( _style!=null)
		{
			System.Drawing.Font font = _style.Font;

			System.Drawing.FontStyle fstyle = font.Style;
			if( enable)
				fstyle |= fs;
			else
				fstyle &= ~fs;

			if( fstyle != font.Style)
			{
				System.Drawing.Font new_font = new System.Drawing.Font( font.Name, font.Size, fstyle);
				_style.Font = new_font;
			}
		}
	}

	private void CheckBoxBold_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		SetFontStyle( System.Drawing.FontStyle.Bold, cb.Checked);
	}

	private void CheckBoxItalic_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		SetFontStyle( System.Drawing.FontStyle.Italic, cb.Checked);
	}
//</CodeSnippet>
}
//<Info>
// Shows Color Alpha-Blending methods of the chart.
//</Info>
public class AlphaBlending: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	const int initialElevation = 45;
	const int initialRotation = 45;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.ComboBox cbox1 = new System.Windows.Forms.ComboBox();
				cbox1.Location = new System.Drawing.Point( 10, 0);
				cbox1.Width = 70;
				cbox1.Name = "cboxChartType";
				cbox1.Items.AddRange( new object[]{
					C1.Win.C1Chart.Chart2DTypeEnum.XYPlot,
					C1.Win.C1Chart.Chart2DTypeEnum.Pie,
					C1.Win.C1Chart.Chart2DTypeEnum.Bar,
					C1.Win.C1Chart.Chart2DTypeEnum.Area,
					C1.Win.C1Chart.Chart2DTypeEnum.Radar,
					C1.Win.C1Chart.Chart2DTypeEnum.Step});

				cbox1.Text = "XYPlot";
				cbox1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point(cbox1.Right + 10, 0);
				cb1.Width = 90;
				cb1.Text = "Alpha Blend";
				cb1.Click += new EventHandler(CheckBox_Clicked);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point(cb1.Right + 10, 0);
				cb2.Width = 100;
				cb2.Text = "FillStyle Alpha";
				cb2.Enabled = false;
				cb2.Click += new EventHandler(CheckBox_Clicked);

				System.Windows.Forms.Label lab1 = new System.Windows.Forms.Label();
				lab1.Location = new System.Drawing.Point(cb2.Right + 10, 0);
				lab1.Width = 55;
				lab1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				lab1.Text = "Elevation";

				System.Windows.Forms.NumericUpDown nud1 = new System.Windows.Forms.NumericUpDown();
				nud1.Location = new System.Drawing.Point(lab1.Right, 0);
				nud1.Width = 40;
				nud1.Name = "nudElevation";
				nud1.Minimum = -45;
				nud1.Maximum = 45;
				nud1.Increment = 5;
				nud1.Value = initialElevation;
				nud1.ValueChanged += new System.EventHandler(UpDown_ValueChanged);

				System.Windows.Forms.Label lab2 = new System.Windows.Forms.Label();
				lab2.Location = new System.Drawing.Point(nud1.Right + 10, 0);
				lab2.Width = 50;
				lab2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				lab2.Text = "Rotation";

				System.Windows.Forms.NumericUpDown nud2 = new System.Windows.Forms.NumericUpDown();
				nud2.Location = new System.Drawing.Point(lab2.Right, 0);
				nud2.Width = 40;
				nud2.Name = "nudRotation";
				nud2.Minimum = -45;
				nud2.Maximum = 45;
				nud2.Increment = 5;
				nud2.Value = initialRotation;
				nud2.ValueChanged += new System.EventHandler(UpDown_ValueChanged);

				_controls = new System.Windows.Forms.Control[]{cbox1, cb1, cb2, lab1, nud1, lab2, nud2};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		SetChartData(c1Chart1);

		// set the intial 3D appearance values.
		c1Chart1.ChartArea.PlotArea.View3D.Depth = 45;
		c1Chart1.ChartArea.PlotArea.View3D.Rotation = initialRotation;
		c1Chart1.ChartArea.PlotArea.View3D.Elevation = initialElevation;

		c1Chart1.ChartGroups.Group0.Radar.Filled = true;
		c1Chart1.ChartArea.AxisY.Min = 5;
		c1Chart1.ChartArea.AxisY.Max = 30;

		System.Drawing.Image img = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly()
			.GetManifestResourceStream("images.texture1.jpg"));

		c1Chart1.BackgroundImage = img;
		c1Chart1.Style.ImageAlignment = C1.Win.C1Chart.AlignImageEnum.Tile;
		
//<CodeSnippet>
		// Alpha Blending of Color can be applied anywhere a color is normally
		// used, in any element of the chart.  Alpha blending is a very effective
		// means of revealing aspects of a chart that might otherwise be hidden.
		// This is especially true of charts with 3D effects.
		//
		// In this sample, the chart background image has been set to
		// demonstrate the transparent qualities of each of the chart elements.
		//

		// Show the various chart elements with alpha blending color, allowing
		// the underlying image to show through.
		Color chartElementBackColor = Color.FromArgb(96, Color.Violet);

		c1Chart1.Header.Style.BackColor = chartElementBackColor;
		c1Chart1.Footer.Style.BackColor = chartElementBackColor;
		c1chart1.Legend.Style.BackColor = chartElementBackColor;
		c1Chart1.ChartArea.Style.BackColor = chartElementBackColor;
		c1Chart1.ChartArea.PlotArea.BackColor = Color.FromArgb(64, Color.Blue);

		// Set some other properties to clarify each element.
		c1Chart1.Header.Text = "Header\r\n-- An Alpha Blending Sample --";
		c1Chart1.Header.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1Chart1.Footer.Text = "Footer\r\n-- An Alpha Blending Sample --";
		c1Chart1.Footer.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1Chart1.Legend.Visible = true;
		c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;

		c1Chart1.ChartArea.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
		c1Chart1.ChartArea.PlotArea.Boxed = true;

//</CodeSnippet>

	}

	public void SetChartData(C1.Win.C1Chart.C1Chart chart)
	{
		chart.Reset();
		double [][] data = new double[][]
		{
			new double[] {1,2,3,4,5},	// x data
			new double[] {20,22,19,24,25},
			new double[] {16,19,15,22,18},
			new double[] {10,16,17,15,23},
			new double[] {8,12,10,12,15},
		};
		
		System.Drawing.Color[] colors = new System.Drawing.Color[] { Color.Red, Color.Blue, Color.Green, Color.Yellow };
		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
		for(int s = 1; s <= 4; s++)
		{
			C1.Win.C1Chart.ChartDataSeries cds = cdsc.AddNewSeries();
			cds.X.CopyDataIn(data[0]);
			cds.Y.CopyDataIn(data[s]);
			cds.LineStyle.Color = colors[s-1];
		}
	}

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		if(cb.Name == "cboxChartType")
		{
			C1.Win.C1Chart.Chart2DTypeEnum o = (C1.Win.C1Chart.Chart2DTypeEnum)cb.SelectedItem;
			c1chart1.ChartGroups.Group0.ChartType = o;

			int depth = 45;
			bool fillstyleEnabled = true;
			switch((C1.Win.C1Chart.Chart2DTypeEnum)o)
			{
				case C1.Win.C1Chart.Chart2DTypeEnum.Bar:
					depth = 10;
					break;

				case C1.Win.C1Chart.Chart2DTypeEnum.Step:
				case C1.Win.C1Chart.Chart2DTypeEnum.XYPlot:
					fillstyleEnabled = false;
					break;
			}
			
			c1chart1.ChartArea.PlotArea.View3D.Depth = depth;
			_controls[2].Enabled = fillstyleEnabled;
		}
	}

//<CodeSnippet>

	// For data elements, alpha blending can be specified by using
	// alpha blended colors for the appropriate style color.  For
	// charts with surfaces, this involves the LineStyle.Color.
	//
	// Some charts, usually those with surfaces, provide a simpler
	// mechanism for alpha blending using the FillStyle.Alpha property.
	//
	// Following are the event handlers for the color and 3D effect
	// related controls of this sample.
	//

	// handler for CheckBoxes
	private void CheckBox_Clicked(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = null;
		cdsc = c1chart1.ChartGroups.Group0.ChartData.SeriesList;

		if(cb.Text == "Alpha Blend")
		{
			int alphaValue = (cb.Checked) ? 64 : 255;
			foreach(C1.Win.C1Chart.ChartDataSeries cds in cdsc)
				cds.LineStyle.Color = Color.FromArgb((byte)alphaValue, cds.LineStyle.Color);
		}

		else if(cb.Text == "FillStyle Alpha")
		{
			int alphaValue = (cb.Checked) ? 128 : 255;
			foreach(C1.Win.C1Chart.ChartDataSeries cds in cdsc)
				cds.FillStyle.Alpha = (byte)alphaValue;
		}
	}

	// handler for Elevation and Rotation settings
	private void UpDown_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown nud = (System.Windows.Forms.NumericUpDown)sender;
		int nudValue = (int)nud.Value;

		if(nud.Name == "nudElevation")
			c1chart1.ChartArea.PlotArea.View3D.Elevation = nudValue;

		else if(nud.Name == "nudRotation")
			c1chart1.ChartArea.PlotArea.View3D.Rotation = nudValue;
	}

//</CodeSnippet>
}

//<Info>
//Shows scrolling through chart with mouse.
//</Info>
public class Translate: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Button btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( 10, 0);
				btn1.Width = 60;
				btn1.Height = 20;
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Text = "Reset";
				btn1.Click += new EventHandler(ButtonReset_Clicked);

				_controls = new System.Windows.Forms.Control[]{ btn1};
			}                                                    

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 20;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark1;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup interaction

		// Disable all action
		foreach( C1.Win.C1Chart.Action action in c1chart1.Interaction.Actions)
			action.MouseButton = System.Windows.Forms.MouseButtons.None;

		// Enable only translation
		c1chart1.Interaction.Actions["Translate"].MouseButton = System.Windows.Forms.MouseButtons.Left;
		c1chart1.Interaction.Actions["Translate"].Modifier = System.Windows.Forms.Keys.None;
		c1chart1.Interaction.Enabled = true;

		//RtfGray
		// Set axes limits
		c1chart1.ChartArea.AxisX.SetMinMax( 5, 15);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);

		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set header text
		c1chart1.Header.Text = "Drag left mouse button to scroll the plot";
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Interaction.Enabled = false;
		base.Unload( c1chart1);
	}

//<CodeSnippet>
// Click event handler
private void ButtonReset_Clicked(object sender, EventArgs e)
{
	// Set axes limits
	c1chart1.ChartArea.AxisX.SetMinMax( 5, 15);
	c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
}
//</CodeSnippet>
}

//<Info>
//Shows changing chart scale with mouse.
//</Info>
public class Scale: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Button btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( 10, 0);
				btn1.Width = 60;
				btn1.Height = 20;
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Text = "Reset";
				btn1.Click += new EventHandler(ButtonReset_Clicked);

				_controls = new System.Windows.Forms.Control[]{ btn1};
			}                                                    

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 50;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark2;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light2;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup interaction

		// Disable all action
		foreach( C1.Win.C1Chart.Action action in c1chart1.Interaction.Actions)
			action.MouseButton = System.Windows.Forms.MouseButtons.None;

		// Enable only translation
		c1chart1.Interaction.Actions["Scale"].MouseButton = System.Windows.Forms.MouseButtons.Left;
		c1chart1.Interaction.Actions["Scale"].Modifier = System.Windows.Forms.Keys.None;

		// Use only x-axis
		c1chart1.Interaction.Actions["Scale"].Axis = C1.Win.C1Chart.AxisFlagEnum.AxisX;
		c1chart1.Interaction.Enabled = true;

		//RtfGray
		// Set axes limits
		c1chart1.ChartArea.AxisX.SetMinMax( 15, 35);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);

		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set header text
		c1chart1.Header.Text = "Drag mouse in vertical direction to scale the plot along x-axis";
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Interaction.Enabled = false;
		base.Unload( c1chart1);
	}

//<CodeSnippet>

// Click event handler
private void ButtonReset_Clicked(object sender, EventArgs e)
{
	// Set axes limits
	c1chart1.ChartArea.AxisX.SetMinMax( 15, 35);
	c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
}
//</CodeSnippet>
}

//<Info>
//Shows zooming using mouse.
//</Info>
public class Zoom : ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Button btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( 10, 0);
				btn1.Width = 60;
				btn1.Height = 20;
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Text = "Reset";
				btn1.Click += new EventHandler(ButtonReset_Clicked);

				_controls = new System.Windows.Forms.Control[]{ btn1};
			}                                                    

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 50;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = 2*(rnd.NextDouble()-0.5);
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark2;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light2;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup interaction

		// Disable all action
		foreach( C1.Win.C1Chart.Action action in c1chart1.Interaction.Actions)
			action.MouseButton = System.Windows.Forms.MouseButtons.None;

		// Enable only translation
		c1chart1.Interaction.Actions["Zoom"].MouseButton = System.Windows.Forms.MouseButtons.Left;
		c1chart1.Interaction.Actions["Zoom"].Modifier = System.Windows.Forms.Keys.None;
		c1chart1.Interaction.Enabled = true;

		//RtfGray
		// Set axes limits
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);

		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set header text
		c1chart1.Header.Text = "Use mouse to select plot range";
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Interaction.Enabled = false;
		base.Unload( c1chart1);
	}

//<CodeSnippet>

// Click event handler
private void ButtonReset_Clicked(object sender, EventArgs e)
{
	// Reset axes limits
	c1chart1.ChartArea.AxisX.AutoMin = true;
	c1chart1.ChartArea.AxisX.AutoMax = true;
	c1chart1.ChartArea.AxisY.AutoMin = true;
	c1chart1.ChartArea.AxisY.AutoMax = true;
}
//</CodeSnippet>
}

//<Info>
//Shows rotation of chart with 3D-effects using mouse.
//</Info>
public class Rotate3D : ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		int[] y1 = new int[] { 800, 1500, 2000};
		int[] y2 = new int[] { 1000, 1200, 1400};
		
		// Create first series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.FillStyle.Color1 = Palette.Light1;
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);
			
		// Create second series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		// Set 3D effect
		c1chart1.ChartArea.PlotArea.View3D.Depth = 15;
		c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
		c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfNormal
		// Setup interaction

		// Disable all action
		foreach( C1.Win.C1Chart.Action action in c1chart1.Interaction.Actions)
			action.MouseButton = System.Windows.Forms.MouseButtons.None;

		// Enable only translation
		c1chart1.Interaction.Actions["Rotate"].MouseButton = System.Windows.Forms.MouseButtons.Left;
		c1chart1.Interaction.Actions["Rotate"].Modifier = System.Windows.Forms.Keys.None;
		c1chart1.Interaction.Enabled = true;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

		// Set x-axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
                
		// Set header text
		c1chart1.Header.Text = "Drag mouse to change 3D view rotation.";
//</CodeSnippet>
	}
	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Interaction.Enabled = false;
		base.Unload( c1chart1);
	}

}

//<Info>
//Create xy-chart with x-axis scrollbar.
//</Info>
public class Simple: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 50;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark1;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup axes scrollbars
		C1.Win.C1Chart.AxisScrollBar xsb = c1chart1.ChartArea.AxisX.ScrollBar;
		xsb.Appearance = C1.Win.C1Chart.ScrollBarAppearanceEnum.Flat;
		xsb.Buttons = C1.Win.C1Chart.AxisScrollBarButtonFlags.ScrollButtons;
		xsb.Min = ds.MinX;
		xsb.Max = ds.MaxX;
		xsb.Scale = 0.2;
		xsb.Visible = true;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
	}
}
//<Info>
//Create xy-chart with x-axis scrollbar with scale button.
//</Info>
public class WithScale: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 100;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark2;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light2;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup axes scrollbars
		C1.Win.C1Chart.AxisScrollBar xsb = c1chart1.ChartArea.AxisX.ScrollBar;
		xsb.Appearance = C1.Win.C1Chart.ScrollBarAppearanceEnum.XP;
		xsb.Buttons = C1.Win.C1Chart.AxisScrollBarButtonFlags.ScaleAndScrollButtons;
		xsb.Min = ds.MinX;
		xsb.Max = ds.MaxX;
		xsb.ScaleMenuItems.Clear();
		xsb.ScaleMenuItems.Add( 1, "100 %");
		xsb.ScaleMenuItems.Add( 0.5, "50 %");
		xsb.ScaleMenuItems.Add( 0.1, "10 %");
		xsb.ScaleMenuItems.Add( 0.05, "5 %");
		xsb.Visible = true;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
	}
}
//<Info>
//Create xy-chart with x-axis scrollbar with custom scale menu.
//</Info>
public class CustomMenu: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 100;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds.LineStyle.Color = Palette.Dark2;
		ds.LineStyle.Thickness = 2;
		ds.SymbolStyle.Color = Palette.Light2;
		ds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup axes scrollbars
		C1.Win.C1Chart.AxisScrollBar xsb = c1chart1.ChartArea.AxisX.ScrollBar;
		xsb.Appearance = C1.Win.C1Chart.ScrollBarAppearanceEnum.XP;
		xsb.Buttons = C1.Win.C1Chart.AxisScrollBarButtonFlags.ScaleAndScrollButtons;
		xsb.Min = ds.MinX;
		xsb.Max = ds.MaxX;
		xsb.Scale = 0.2;
		xsb.Visible = true;

		if( contextMenu == null)
		{
			System.Windows.Forms.MenuItem[] menuItems = 
				new System.Windows.Forms.MenuItem[]{ new System.Windows.Forms.MenuItem("Save position", new EventHandler(Menu_OnClick)),
																						 new System.Windows.Forms.MenuItem("Restore position", new EventHandler(Menu_OnClick))};
			contextMenu = new System.Windows.Forms.ContextMenu(menuItems);
		}
		xsb.ScaleMenu = contextMenu;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
//</CodeSnippet>
	}

//<CodeSnippet>
	System.Windows.Forms.ContextMenu contextMenu = null;
	double scrollbar_value = 0;
	// Menu click event handler
	private void Menu_OnClick(object sender, System.EventArgs e)
	{
		System.Windows.Forms.MenuItem mi = (System.Windows.Forms.MenuItem)sender;

		if( mi.Text == "Save position")
			scrollbar_value = c1chart1.ChartArea.AxisX.ScrollBar.Value;
		else
			c1chart1.ChartArea.AxisX.ScrollBar.Value = scrollbar_value;
	}
//</CodeSnippet>
}

//<Info>
//Show highlight with different chart types.
//</Info>
public class MouseOver: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.ComboBox cb1 = new System.Windows.Forms.ComboBox();
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"XYPlot","Bar","Pie"});
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Text = "XYPlot";
				cb1.SelectedIndexChanged += new EventHandler(ComboBoxChartType_SelectedIndexChanged);

				System.Windows.Forms.ComboBox cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb2.Items.AddRange(new object[] {"Points","Series"});
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Text = "Points";
				cb2.SelectedIndexChanged += new EventHandler(ComboBoxChartElement_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 5;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = rnd.NextDouble()*10;
			y2[i] = rnd.NextDouble()*10;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds1.LineStyle.Color = Palette.Light3;
		ds1.FillStyle.Color1 = Palette.Light3;
		ds1.LineStyle.Thickness = 2;
		ds1.SymbolStyle.Color = Palette.Light3;
		ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		ds1.SymbolStyle.OutlineColor = Palette.Dark3;

		// Copy data into chart
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds2.LineStyle.Color = Palette.Light2;
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.LineStyle.Thickness = 2;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Diamond;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;

		// Copy data into chart
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup data highlight
		c1chart1.ChartGroups[0].ChartData.HighLight.Activation = C1.Win.C1Chart.HighlightActivationEnum.MouseOver;
		c1chart1.ChartGroups[0].ChartData.HighLight.Appearance = C1.Win.C1Chart.DataAppearanceEnum.Fill |
			C1.Win.C1Chart.DataAppearanceEnum.Line | C1.Win.C1Chart.DataAppearanceEnum.SymbolColor | 
			C1.Win.C1Chart.DataAppearanceEnum.SymbolOutlineColor | C1.Win.C1Chart.DataAppearanceEnum.SymbolOutlineWidth |
			C1.Win.C1Chart.DataAppearanceEnum.SymbolSize;
		c1chart1.ChartGroups[0].ChartData.HighLight.FillStyle.Color1 = Palette.Light1;
		c1chart1.ChartGroups[0].ChartData.HighLight.FillStyle.FillType = C1.Win.C1Chart.FillTypeEnum.SolidColor;
		c1chart1.ChartGroups[0].ChartData.HighLight.SymbolStyle.Size = 15;
		c1chart1.ChartGroups[0].ChartData.HighLight.SymbolStyle.Color = Palette.Light1;
		c1chart1.ChartGroups[0].ChartData.HighLight.SymbolStyle.OutlineColor = Palette.Dark1; 
		c1chart1.ChartGroups[0].ChartData.HighLight.SymbolStyle.OutlineWidth = 2;
		c1chart1.ChartGroups[0].ChartData.HighLight.LineStyle.Thickness = 3;
		c1chart1.ChartGroups[0].ChartData.HighLight.LineStyle.Color = Palette.Light1;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
//</CodeSnippet>
		ComboBoxChartType_SelectedIndexChanged( _controls[0], EventArgs.Empty);
		ComboBoxChartElement_SelectedIndexChanged( _controls[1], EventArgs.Empty);
	}

//<CodeSnippet>
	// handler for combo box
	private void ComboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "XYPlot":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;
				break;
			case "Bar":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;
				break;
			case "Pie":
				c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Pie;
				break;
		}
	}

	// handler for combo box
	private void ComboBoxChartElement_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		
		switch( cb.Text)
		{
			case "Points":
				c1chart1.ChartGroups[0].ChartData.HighLight.PlotElement = C1.Win.C1Chart.PlotElementEnum.Points;
				break;
			case "Series":
				c1chart1.ChartGroups[0].ChartData.HighLight.PlotElement = C1.Win.C1Chart.PlotElementEnum.Series;
				break;
		}
	}
//</CodeSnippet>

}
//<Info>
//Show data highlighting of xy-plot and using HighlightChanged event.
//</Info>
public class ActiveSeries: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 50;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = rnd.NextDouble()*15;
			y2[i] = rnd.NextDouble()*5;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds1.LineStyle.Color = Palette.Dark2;
		ds1.LineStyle.Thickness = 1;
		ds1.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;

		// Copy data into chart
		ds1.AutoEnumerate = true;
		ds1.Y.CopyDataIn( y1);

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		// Set data visual appearence
		ds2.LineStyle.Color = Palette.Dark3;
		ds2.LineStyle.Thickness = 1;
		ds2.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;

		// Copy data into chart
		ds2.AutoEnumerate = true;
		ds2.Y.CopyDataIn( y2);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		//RtfNormal
		// Setup data highlight
		c1chart1.ChartGroups[0].ChartData.HighLight.PlotElement = C1.Win.C1Chart.PlotElementEnum.Series;
		c1chart1.ChartGroups[0].ChartData.HighLight.Activation = C1.Win.C1Chart.HighlightActivationEnum.Click;
		c1chart1.ChartGroups[0].ChartData.HighLight.LineStyle.Color = Palette.Dark1;
		c1chart1.ChartGroups[0].ChartData.HighLight.LineStyle.Thickness = 2;

		// Add handler
		c1chart1.HighlightChanged += new C1.Win.C1Chart.HighlightChangedEventHandler( Chart_HighlightChanged);

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
		c1chart1.Footer.Text = "No active series";
		c1chart1.Header.Visible = true;
		c1chart1.Header.Text = "Click on the chart to select series";
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.HighlightChanged -= new C1.Win.C1Chart.HighlightChangedEventHandler( Chart_HighlightChanged);
	}

//<CodeSnippet>
	private void Chart_HighlightChanged( object sender, C1.Win.C1Chart.HighlightChangedEventArgs e)
	{
		C1.Win.C1Chart.ChartDataSeries ds = e.Series;
		if( ds!=null)
		{
			c1chart1.Footer.Text = string.Format( "{0} ({1:0.##} - {2:0.##})", ds.Label, ds.MinY, ds.MaxY);
		}
		else
		{
			c1chart1.Footer.Text = "No active series";
		}
	}
//</CodeSnippet>
}

//<Info>
//Show custom highlighting.
//</Info>
public class CustomHighlight : ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 3;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		double[] y3 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = 2 + rnd.NextDouble()*10;
			y2[i] = 2 + rnd.NextDouble()*5;
			y3[i] = 2 + rnd.NextDouble()*8;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		C1.Win.C1Chart.ChartDataSeries ds3 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
		{
			ds.AutoEnumerate = true;
			ds.FillStyle.Alpha = 160;
		}

		// Set data visual appearence
		ds1.FillStyle.Color1 = Palette.Light1;
		ds1.FillStyle.Color2 = Palette.Dark1;
		
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.FillStyle.Color2 = Palette.Dark2;

		ds3.FillStyle.Color1 = Palette.Light3;
		ds3.FillStyle.Color2 = Palette.Dark3;

		// Copy data into chart
		ds1.Y.CopyDataIn( y1);
		ds2.Y.CopyDataIn( y2);
		ds3.Y.CopyDataIn( y3);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfNormal
		// Setup data highlight
		c1chart1.ChartGroups[0].ChartData.HighLight.Activation = C1.Win.C1Chart.HighlightActivationEnum.MouseOver;
		c1chart1.ChartGroups[0].ChartData.HighLight.FillStyle.FillType = C1.Win.C1Chart.FillTypeEnum.Gradient;
		c1chart1.ChartGroups[0].ChartData.HighLight.FillStyle.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.Radial;
		c1chart1.ChartGroups[0].ChartData.HighLight.FillStyle.Alpha = 255;

		c1chart1.ChartGroups[0].ChartData.HighLight.Appearance = C1.Win.C1Chart.DataAppearanceEnum.FillGradientStyle
			| C1.Win.C1Chart.DataAppearanceEnum.FillType | C1.Win.C1Chart.DataAppearanceEnum.FillAlpha;
		c1chart1.HighlightChanged += new C1.Win.C1Chart.HighlightChangedEventHandler( Chart_HighlightChanged);

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
		// Set axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.HighlightChanged -= new C1.Win.C1Chart.HighlightChangedEventHandler( Chart_HighlightChanged);
		c1chart1.ChartGroups[0].ChartData.HighLight.Activation = C1.Win.C1Chart.HighlightActivationEnum.Disabled;
	}

//<CodeSnippet>
	void Chart_HighlightChanged( object sender, C1.Win.C1Chart.HighlightChangedEventArgs e)
	{
		byte alpha = 255;
		if( e.Series!=null)
		{
			alpha = 128;
			c1chart1.Cursor = System.Windows.Forms.Cursors.Hand;
		}
		else
			c1chart1.Cursor = System.Windows.Forms.Cursors.Default;

		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
		{
			if( ds == e.Series)
				ds.FillStyle.Alpha = 255;
			else
				ds.FillStyle.Alpha = alpha;
		}
	}
//</CodeSnippet>
}

//<Info>
//Show using built-in tooltips for plotted data.
//</Info>
public class Tooltips : ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data
		int n = 4;
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		double[] y3 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			y1[i] = 2 + rnd.NextDouble()*10;
			y2[i] = 2 + rnd.NextDouble()*5;
			y3[i] = 2 + rnd.NextDouble()*8;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		C1.Win.C1Chart.ChartDataSeries ds3 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();

		foreach( C1.Win.C1Chart.ChartDataSeries ds in c1chart1.ChartGroups[0].ChartData.SeriesList)
		{
			ds.AutoEnumerate = true;
			ds.FillStyle.FillType = C1.Win.C1Chart.FillTypeEnum.Gradient;
			ds.FillStyle.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.VerticalCenter;
	
			//RtfNormal
			// Set tooltip text for data series
			ds.TooltipText = "{#TEXT}\ny={#YVAL:0.00}";
			//RtfGray
		}

		// Set data visual appearence
		ds1.FillStyle.Color2 = Palette.Light1;
		ds1.FillStyle.Color1 = Palette.Dark1;
		
		ds2.FillStyle.Color2 = Palette.Light2;
		ds2.FillStyle.Color1 = Palette.Dark2;

		ds3.FillStyle.Color2 = Palette.Light3;
		ds3.FillStyle.Color1 = Palette.Dark3;

		// Copy data into chart
		ds1.Y.CopyDataIn( y1);
		ds2.Y.CopyDataIn( y2);
		ds3.Y.CopyDataIn( y3);

		// Set chart type			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;

		//RtfNormal
		// Enable tooltips
		c1chart1.ToolTip.Enabled = true;

		//RtfGray
		// Show frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;
		// Show legend
		c1chart1.Legend.Visible = true;
		// Set axis minimum
		c1chart1.ChartArea.AxisY.Min = 0;
//</CodeSnippet>
	}
}

//<Info>
//Displays properties and wizard dialogs at runtime.
//</Info>
public class Dialog: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Button btn1 = new System.Windows.Forms.Button();
				btn1.Location = new System.Drawing.Point( 10, 0);
				btn1.Width = 80;
				btn1.Height = 21;
				btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn1.Text = "Properties";
				btn1.Click += new EventHandler(ButtonProperties_Click);

				System.Windows.Forms.Button btn2 = new System.Windows.Forms.Button();
				btn2.Location = new System.Drawing.Point( btn1.Right + 20, 0);
				btn2.Width = 80;
				btn2.Height = 21;
				btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btn2.Text = "Wizard";
				btn2.Click += new EventHandler(ButtonWizard_Click);

				_controls = new System.Windows.Forms.Control[]{ btn1, btn2};
			}

			return _controls;
		}
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
	}

//<CodeSnippet>
// Click event handler
private void ButtonProperties_Click(object sender, System.EventArgs e)
{
	c1chart1.ShowProperties();
}

// Click event handler
private void ButtonWizard_Click(object sender, System.EventArgs e)
{
	c1chart1.ShowWizard();
}
//</CodeSnippet>
}
//<Info>
// Shows basic AlarmZone shapes added to an existing chart.
//</Info>
public class BasicShapes: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Width = 70;
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Inverted";
				cb2.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb4 = new System.Windows.Forms.CheckBox();
				cb4.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb4.Width = 85;
				cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb4.Text = "Alpha Blend";
				cb4.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.ComboBox cb3 = new System.Windows.Forms.ComboBox();
				cb3.BackColor = System.Drawing.SystemColors.Control;
				cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb3.Items.AddRange(new object[] {"XYPlot","Bar","Step","Area"});
				cb3.Location = new System.Drawing.Point( cb4.Right + 10, 0);
				cb3.Width = 60;
				cb3.Text = "XYPlot";
				cb3.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

				System.Windows.Forms.Label lab = new System.Windows.Forms.Label();
				lab.Location = new System.Drawing.Point(cb3.Right + 15, 0);
				lab.Width = 40;
				lab.Text = "Depth";
				lab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

				System.Windows.Forms.NumericUpDown nud = new System.Windows.Forms.NumericUpDown();
				nud.Location = new System.Drawing.Point(lab.Right + 2, 0);
				nud.Width = 40;
				nud.Minimum = 0;
				nud.Maximum = 25;
				nud.Value = 5;
				nud.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb4, cb3, lab, nud};
			}

			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);

		// setup the chart data
		SetChartData(c1chart1);

//<CodeSnippet>
		// Create AlarmZones.  AlarmZones are backdrop areas in the
		// PlotArea typically defined by data coordinate values used
		// to flag areas of interest with in the data space.

		// Get the Chart AlarmZoneCollect Collection.
		C1.Win.C1Chart.AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;

		// Add a rectanglular AlarmZone.  The boundaries are defined
		// by data coordinate values, so the zone expands and contracts
		// as the chart plotarea is resized or rescaled.
		C1.Win.C1Chart.AlarmZone az = azs.AddNewZone();
		az.Name = "Rectangle-Data";
		az.BackColor = Color.FromArgb(100,Color.Red);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Rectangle;
		az.UpperExtent = 16;
		az.LowerExtent = 12;
		az.FarExtent = 2.5;
		az.NearExtent = 1.5;
		az.Visible = true;

		// Add an elliptical AlarmZone.  The boundaries are defined
		// by a circumscribing rectangle expressed in data coordinate
		// values, so the zone expands and contracts as the chart
		// plotarea is resized or rescaled.
		az = azs.AddNewZone();
		az.BackColor = Color.FromArgb(100,Color.Blue);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Ellipse;
		az.Name = "Ellipse";
		az.UpperExtent = 18;
		az.LowerExtent = 10;
		az.FarExtent = 4.5;
		az.NearExtent = 3;
		az.Visible = true;

		// Add a fixed size rectanglular AlarmZone.  The position of
		// the AlarmZone is specified by the extents.  The MinHeight
		// and MinWidth values specify the minimum Height and Width
		// of the AlarmZone in pixels.  This zone remains fixed in
		// size regardless of data coordinate sizing and scaling.
		az = azs.AddNewZone();
		az.BackColor = Color.FromArgb(100,Color.Yellow);
		az.PatternStyle = System.Drawing.Drawing2D.HatchStyle.DiagonalBrick;
		az.PatternVisible = true;
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Rectangle;
		az.Name = "Rectangle-Fixed";
		az.UpperExtent = 20;
		az.LowerExtent = 20;
		az.FarExtent = 3;
		az.NearExtent = 3;
		az.MinHeight = 32;
		az.MinWidth = 32;
		az.Visible = true;			
//</CodeSnippet>
	}

	public void SetChartData(C1.Win.C1Chart.C1Chart chart)
	{
		chart.Reset();
		double [][] data = new double[][]
		{
			new double[] {1,2,3,4,5},	// x data
			new double[] {20,22,19,24,25},
			new double[] {16,19,15,22,18},
			new double[] {10,16,17,15,23},
			new double[] {8,12,10,12,15},
		};

		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
		C1.Win.C1Chart.ChartDataSeries cds = null;
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[1]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[2]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[3]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[4]);

		chart.ChartArea.AxisX.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisX.GridMajor.Visible = true;
		chart.ChartArea.AxisY.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisY.GridMajor.Visible = true;
	}

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if(cb.Text == "3D")
		{
			if( cb.Checked)
			{
				System.Windows.Forms.NumericUpDown nud =
					(System.Windows.Forms.NumericUpDown)_controls[_controls.Length-1];
				
				c1chart1.ChartGroups[0].Use3D = true;
				c1chart1.ChartArea.PlotArea.View3D.Depth = (int)nud.Value;
				c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
				c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
				c1chart1.ChartArea.PlotArea.Boxed = true;
			}
			else
			{
				c1chart1.ChartGroups[0].Use3D = false;
				c1chart1.ChartArea.PlotArea.Boxed = false;
			}
		}
		else if(cb.Text == "Inverted")
		{
			c1chart1.ChartArea.Inverted = cb.Checked;
		}
		else if(cb.Text == "Alpha Blend")
		{
			int alpha = cb.Checked ? 64 : 255;
			foreach(C1.Win.C1Chart.ChartDataSeries cds in c1chart1.ChartGroups.Group0.ChartData.SeriesList)
				cds.LineStyle.Color = Color.FromArgb(alpha, cds.LineStyle.Color);
		}
	}

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		C1.Win.C1Chart.Chart2DTypeEnum ct = (C1.Win.C1Chart.Chart2DTypeEnum)
			Enum.Parse(typeof(C1.Win.C1Chart.Chart2DTypeEnum),cb.Text);
		c1chart1.ChartGroups.Group0.ChartType = ct;
	}

	// handler for numeric update down value changed.
	private void NumericUpDown_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown nud = (System.Windows.Forms.NumericUpDown)sender;
		c1chart1.ChartArea.PlotArea.View3D.Depth = (int)nud.Value;
	}
}

//<Info>
// Shows AlarmZones for Polar charts.
//</Info>
public class PolarShapes: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Label lab = new System.Windows.Forms.Label();
				lab.Location = new System.Drawing.Point( 10, 0);
				lab.Width = 50;
				lab.Text = "Rotation";
				lab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

				System.Windows.Forms.ComboBox cb2 = new System.Windows.Forms.ComboBox();
				cb2.BackColor = System.Drawing.SystemColors.Control;
				cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb2.Items.AddRange(new object[] {"0","15","30","60","120","240"});
				cb2.Location = new System.Drawing.Point( lab.Right + 2, 0);
				cb2.Width = 50;
				cb2.Text = "0";
				cb2.Tag = "rotation";
				cb2.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ lab, cb2};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		SetChartData(c1Chart1);

//<CodeSnippet>
		// Create AlarmZones.  AlarmZones are backdrop areas in the
		// PlotArea typically defined by data coordinate values used
		// to flag areas of interest with in the data space.
		//
		// For Polar charts zones form arcs because arcs are defined
		// by the data coordinates.

		// Get the Chart AlarmZoneCollect Collection.
		C1.Win.C1Chart.AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;

		// Add a rectangular AlarmZone.  The boundaries are defined
		// by data coordinate values, so the zone expands and contracts
		// as the chart plotarea is resized or rescaled.
		C1.Win.C1Chart.AlarmZone az = azs.AddNewZone();
		az.Name = "Rectangle-Data";
		az.BackColor = Color.FromArgb(100,Color.Red);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Rectangle;
		az.UpperExtent = 19;
		az.LowerExtent = 12;
		az.FarExtent = 145;
		az.NearExtent = 45;
		az.Visible = true;

		// Add an elliptical AlarmZone.  For Polar charts, elliptical
		// zones are treated the same as rectangular zones
		az = azs.AddNewZone();
		az.BackColor = Color.FromArgb(100,Color.Blue);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Ellipse;
		az.Name = "Ellipse";
		az.UpperExtent = 18;
		az.LowerExtent = 10;
		az.FarExtent = 210;
		az.NearExtent = 160;
		az.Visible = true;
//</CodeSnippet>
	}

	public void SetChartData(C1.Win.C1Chart.C1Chart chart)
	{
		chart.Reset();
		double [][] data = new double[][]
		{
			new double[] {  0, 45, 90,135,180,225,270,315,360},		// x data
			new double[] {  8, 12, 10, 12, 15},
			new double[] {  5, 50, 95,140,185,230,275,320,365},		// x data
			new double[] { 10, 16, 17, 15, 23},
			new double[] {  0, 45, 90,135,180,225,270,315,360},		// x data
			new double[] { 16, 19, 15, 22, 18, 13, 12, 15, 21},
			new double[] {  5, 50, 95,140,185,230,275,320,365},		// x data
			new double[] { 20, 22, 19, 24, 25, 22, 17, 18, 15},
		};

		chart.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Polar;

		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
		C1.Win.C1Chart.ChartDataSeries cds = null;
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[1]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[2]); cds.Y.CopyDataIn(data[3]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[4]); cds.Y.CopyDataIn(data[5]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[6]); cds.Y.CopyDataIn(data[7]);
	}

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		int rot = Int32.Parse(cb.Text);
		c1chart1.ChartGroups.Group0.Polar.Start = rot;
	}
}

//<Info>
// Shows Polygon AlarmZone behavior with hit testing.
//</Info>
public class Polygons: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 40;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "3D";
				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cb2.Width = 70;
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "Inverted";
				cb2.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb4 = new System.Windows.Forms.CheckBox();
				cb4.Location = new System.Drawing.Point( cb2.Right + 10, 0);
				cb4.Width = 85;
				cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb4.Text = "Alpha Blend";
				cb4.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.ComboBox cb3 = new System.Windows.Forms.ComboBox();
				cb3.BackColor = System.Drawing.SystemColors.Control;
				cb3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb3.Items.AddRange(new object[] {"XYPlot","Bar","Step","Area"});
				cb3.Location = new System.Drawing.Point( cb4.Right + 10, 0);
				cb3.Width = 60;
				cb3.Text = "XYPlot";
				cb3.SelectedIndexChanged += new EventHandler(ComboBoxChartType_SelectedIndexChanged);

				System.Windows.Forms.Label lab = new System.Windows.Forms.Label();
				lab.Location = new System.Drawing.Point(cb3.Right + 15, 0);
				lab.Width = 40;
				lab.Text = "Depth";
				lab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

				System.Windows.Forms.NumericUpDown nud = new System.Windows.Forms.NumericUpDown();
				nud.Location = new System.Drawing.Point(lab.Right + 2, 0);
				nud.Width = 40;
				nud.Minimum = 0;
				nud.Maximum = 25;
				nud.Value = 5;
				nud.ValueChanged += new EventHandler(NumericUpDown_ValueChanged);
				
				System.Windows.Forms.Label labx = new System.Windows.Forms.Label();
				labx.Location = new System.Drawing.Point(nud.Right + 15, 0);
				labx.Width = 45;
				labx.Text = "Extents";
				labx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

				System.Windows.Forms.ComboBox cb5 = new System.Windows.Forms.ComboBox();
				cb5.BackColor = System.Drawing.SystemColors.Control;
				cb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb5.Items.AddRange(new object[]
					{
						"Near=0, Far=0, Upper=0, Lower=0",
						"Near=2, Far=0, Upper=0, Lower=0",
						"Near=0, Far=4, Upper=0, Lower=0",
						"Near=0, Far=0, Upper=18, Lower=0",
						"Near=0, Far=0, Upper=0, Lower=14",
						"Near=2, Far=4, Upper=0, Lower=0",
						"Near=0, Far=0, Upper=18, Lower=14",
						"Near=2, Far=4, Upper=18, Lower=14",
					}
				);
				cb5.Location = new System.Drawing.Point( labx.Right + 2, 0);
				cb5.Width = 200;
				cb5.Text = cb5.Items[0].ToString();
				cb5.SelectedIndexChanged += new EventHandler(ComboBoxExtents_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb4, cb3, lab, nud, labx, cb5};
			}

			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);

		// setup the chart data
		SetChartData(c1chart1);

//<CodeSnippet>
		// Create AlarmZones.  AlarmZones are backdrop areas in the
		// PlotArea typically defined by data coordinate values used
		// to flag areas of interest with in the data space.

		// Get the Chart AlarmZoneCollect Collection.
		C1.Win.C1Chart.AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;

		// Add a triangular AlarmZone.
		//
		// The boundaries are defined by data coordinate values, so the zone
		// expands and contracts as the chart plotarea is resized or rescaled.
		//
		// For Polygons, the extents form a rectangle that limits the
		// boundaries of a specified polygon.
		//
		C1.Win.C1Chart.AlarmZone az = azs.AddNewZone();
		az.Name = "Triangle";
		az.BackColor = Color.FromArgb(100,Color.Red);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Polygon;

		PointF [] triPointData = new PointF[]
		{ new PointF(1.5f,20f), new PointF(4f, 17f),
		  new PointF(3f, 12f), new PointF(1.5f,20f)
		};
		az.PolygonData.PointData.CopyDataIn(triPointData);

		// Extents that are all zero indicate that the entire PlotArea
		// forms the extents.
		az.NearExtent = 0;
		az.FarExtent = 0;
		az.UpperExtent = 0;
		az.LowerExtent = 0;
		az.Visible = true;

		// Add a trapazoidal AlarmZone.
		//
		// The boundaries are defined by a circumscribing rectangle
		// expressed in data coordinate values, so the zone expands
		// and contracts as the chart plotarea is resized or rescaled.
		az = azs.AddNewZone();
		az.Name = "Trapzoid";
		az.BackColor = Color.FromArgb(100,Color.Blue);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Polygon;

		PointF [] trapPointData = new PointF[]
		{ new PointF(1.5f,13f), new PointF(2.5f, 21f),
		  new PointF(4.5f,21f), new PointF(4.8f, 13f),
		  new PointF(1.5f,13f)
		};
		az.PolygonData.PointData.CopyDataIn(trapPointData);

		// Extents that are all zero indicate that the entire PlotArea
		// forms the extents.
		az.NearExtent = 0;
		az.FarExtent = 0;
		az.UpperExtent = 0;
		az.LowerExtent = 0;
		az.Visible = true;

//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.MouseMove -= new System.Windows.Forms.MouseEventHandler(c1Chart1_MouseMove);
		base.Unload(c1chart1);
	}

	public void SetChartData(C1.Win.C1Chart.C1Chart chart)
	{
		chart.Reset();
		double [][] data = new double[][]
		{
			new double[] {1,2,3,4,5},	// x data
			new double[] {20,22,19,24,25},
			new double[] {16,19,15,22,18},
			new double[] {10,16,17,15,23},
			new double[] {8,12,10,12,15},
		};

		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
		C1.Win.C1Chart.ChartDataSeries cds = null;
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[1]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[2]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[3]);
		cds = cdsc.AddNewSeries(); 	cds.X.CopyDataIn(data[0]); cds.Y.CopyDataIn(data[4]);

		chart.ChartArea.AxisX.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisX.GridMajor.Visible = true;
		chart.ChartArea.AxisY.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisY.GridMajor.Visible = true;

		chart.Footer.Text = "Mouse not over an AlarmZone";
		chart.Footer.Visible = true;

		chart.MouseMove += new System.Windows.Forms.MouseEventHandler(c1Chart1_MouseMove);
	}

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;

		if(cb.Text == "3D")
		{
			if( cb.Checked)
			{
				System.Windows.Forms.NumericUpDown nud =
					(System.Windows.Forms.NumericUpDown)_controls[5];
				
				c1chart1.ChartGroups[0].Use3D = true;
				c1chart1.ChartArea.PlotArea.View3D.Depth = (int)nud.Value;
				c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
				c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
				c1chart1.ChartArea.PlotArea.Boxed = true;
			}
			else
			{
				c1chart1.ChartGroups[0].Use3D = false;
				c1chart1.ChartArea.PlotArea.Boxed = false;
			}
		}
		else if(cb.Text == "Inverted")
		{
			c1chart1.ChartArea.Inverted = cb.Checked;
		}
		else if(cb.Text == "Alpha Blend")
		{
			int alpha = cb.Checked ? 64 : 255;
			foreach(C1.Win.C1Chart.ChartDataSeries cds in c1chart1.ChartGroups.Group0.ChartData.SeriesList)
				cds.LineStyle.Color = Color.FromArgb(alpha, cds.LineStyle.Color);
		}
	}

	// handler for ChartType ComboBox
	private void ComboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		C1.Win.C1Chart.Chart2DTypeEnum ct = (C1.Win.C1Chart.Chart2DTypeEnum)
			Enum.Parse(typeof(C1.Win.C1Chart.Chart2DTypeEnum),cb.Text);
		c1chart1.ChartGroups.Group0.ChartType = ct;
	}

//<CodeSnippet>

	// handler for Extents ComboBox
	private void ComboBoxExtents_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		string [] extents = cb.Text.Split(new char[] {'=',','});
		if(extents != null && extents.Length == 8)
		{
			double near = double.Parse(extents[1]);
			double far = double.Parse(extents[3]);
			double upper = double.Parse(extents[5]);
			double lower = double.Parse(extents[7]);

			C1.Win.C1Chart.AlarmZonesCollection azc = c1chart1.ChartArea.PlotArea.AlarmZones;
			foreach(C1.Win.C1Chart.AlarmZone az in azc)
			{
				az.NearExtent = near;
				az.FarExtent = far;
				az.UpperExtent = upper;
				az.LowerExtent = lower;
			}
		}
	}

//</CodeSnippet>

	// handler for numeric update down value changed.
	private void NumericUpDown_ValueChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.NumericUpDown nud = (System.Windows.Forms.NumericUpDown)sender;
		c1chart1.ChartArea.PlotArea.View3D.Depth = (int)nud.Value;
	}

//<CodeSnippet>

	// handler for AlarmZone hit testing
	private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		if(e.Button == System.Windows.Forms.MouseButtons.None)
		{
			C1.Win.C1Chart.C1Chart chart = sender as C1.Win.C1Chart.C1Chart;
			C1.Win.C1Chart.AlarmZone az =
				chart.ChartArea.PlotArea.AlarmZones.AlarmZoneAtCoord(e.X,e.Y);

			if(az != null)
				chart.Footer.Text = "Hovering over AlarmZone " + az.Name;
			else
				chart.Footer.Text = "Mouse not over an AlarmZone";
		}
	}

//</CodeSnippet>
}

//<Info>
// Shows DataSeries AlarmZone behavior with hit testing.
//</Info>
public class DataSeries: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 112;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "DataSeries 0 AlarmZone Visible";
				cb1.Checked = true;

				// calculate the necessary height.
				System.Drawing.Graphics g = cb1.CreateGraphics();
				System.Drawing.SizeF szf = g.MeasureString(cb1.Text,cb1.Font, cb1.Width);
				g.Dispose();
				cb1.Height = (int)szf.Height;

				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb2 = new System.Windows.Forms.CheckBox();
				cb2.Location = new System.Drawing.Point( cb1.Right + 5, 0);
				cb2.Width = 112;
				cb2.Height = cb1.Height;
				cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb2.Text = "DataSeries 1 AlarmZone Visible";
				cb2.Checked = true;
				cb2.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.CheckBox cb3 = new System.Windows.Forms.CheckBox();
				cb3.Location = new System.Drawing.Point( cb2.Right + 5, 0);
				cb3.Width = 65;
				cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb3.Text = "Inverted";
				cb3.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.Label labx = new System.Windows.Forms.Label();
				labx.Location = new System.Drawing.Point(cb3.Right + 10, 0);
				labx.Width = 45;
				labx.Text = "Extents";
				labx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

				System.Windows.Forms.ComboBox cb5 = new System.Windows.Forms.ComboBox();
				cb5.BackColor = System.Drawing.SystemColors.Control;
				cb5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb5.Items.AddRange(new object[]
					{
						"Near=0, Far=0, Upper=0, Lower=0",
						"Near=4, Far=0, Upper=0, Lower=0",
						"Near=0, Far=10, Upper=0, Lower=0",
						"Near=0, Far=0, Upper=0.5, Lower=-0.5",
						"Near=0, Far=0, Upper=0, Lower=-0.5",
						"Near=4, Far=10, Upper=0, Lower=0",
						"Near=0, Far=0, Upper=0.5, Lower=-0.5",
						"Near=4, Far=10, Upper=0.5, Lower=-0.5",
					}
				);
				cb5.Location = new System.Drawing.Point( labx.Right + 2, 0);
				cb5.Width = 200;
				cb5.Text = cb5.Items[0].ToString();
				cb5.SelectedIndexChanged += new EventHandler(ComboBoxExtents_SelectedIndexChanged);

				_controls = new System.Windows.Forms.Control[]{ cb1, cb2, cb3, labx, cb5};
			}

			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);

		// setup the chart data
		SetChartData(c1chart1);

//<CodeSnippet>
		// Create AlarmZones.  AlarmZones are backdrop areas in the
		// PlotArea typically defined by data coordinate values used
		// to flag areas of interest with in the data space.

		// Get the Chart AlarmZoneCollect Collection.
		C1.Win.C1Chart.AlarmZonesCollection azs = c1Chart1.ChartArea.PlotArea.AlarmZones;

		// Add a DataSeries specified AlarmZone.  The DataSeries is specified
		// by the PolygonData object associated with Polygon AlarmZones.
		//
		// The boundaries are defined by data coordinate values, so the zone
		// expands and contracts as the chart plotarea is resized or rescaled.
		//
		// For Polygons, the extents form a rectangle that limits the
		// boundaries of a specified polygon.
		//
		C1.Win.C1Chart.AlarmZone az = azs.AddNewZone();
		az.Name = "DataSeries 0 AlarmZone";
		az.BackColor = Color.FromArgb(100,Color.Red);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Polygon;

		az.GroupIndex = 0;					// ChartGroup containing the data
		az.PolygonData.SeriesIndex = 0;		// DataSeries containing the data
		az.PolygonData.PolygonSource = C1.Win.C1Chart.PolygonSourceEnum.DataSeries;

		// Extents that are all zero indicate that the entire PlotArea
		// forms the extents.
		az.NearExtent = 0;
		az.FarExtent = 0;
		az.UpperExtent = 0;
		az.LowerExtent = 0;
		az.Visible = true;

		
		// Add an AlarmZone of using array data obtained from a ChartDataSeries.
		// This is done through the ChartDataCoord type that are part of the
		// PolygonData object.
		az = azs.AddNewZone();
		az.Name = "DataSeries 1 AlarmZone";
		az.BackColor = Color.FromArgb(100,Color.Blue);
		az.Shape = C1.Win.C1Chart.AlarmZoneShapeEnum.Polygon;

		// Specify the polygon data source as arrays.
		az.PolygonData.PolygonSource = C1.Win.C1Chart.PolygonSourceEnum.Arrays;

		// Get the appropriate chart data series.
		C1.Win.C1Chart.ChartDataSeries cds = c1Chart1.ChartGroups.Group0.ChartData[1];
		az.PolygonData.X.CopyDataIn(cds.X.CopyDataOut());
		az.PolygonData.Y.CopyDataIn(cds.Y.CopyDataOut());

		// Extents that are all zero indicate that the entire PlotArea
		// forms the extents.
		az.NearExtent = 0;
		az.FarExtent = 0;
		az.UpperExtent = 0;
		az.LowerExtent = 0;
		az.Visible = true;
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.MouseMove -= new System.Windows.Forms.MouseEventHandler(c1Chart1_MouseMove);
		base.Unload(c1chart1);
	}

	public void SetChartData(C1.Win.C1Chart.C1Chart chart)
	{
		chart.Reset();
		double [] x = new double[101];
		double [] y = new double[101];

		// 2 cycles of 2 * PI
		double factor = 2.0 * 2.0 *Math.PI / ( x.Length - 1);
		Random rnd = new Random();

		int i;
		for(i=0; i < x.Length; i++)
		{
			x[i] = factor * i;
			y[i] = Math.Sin(x[i]) * rnd.NextDouble();
		}

		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = chart.ChartGroups[0].ChartData.SeriesList;
		C1.Win.C1Chart.ChartDataSeries cds = null;
		cds = cdsc.AddNewSeries();

		cds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;
		cds.LineStyle.Color = System.Drawing.Color.Black;

		cds.X.CopyDataIn(x);
		cds.Y.CopyDataIn(y);

		y[0] = y[x.Length-1] = 0.0;
		for(i=1; i < x.Length-1; i++)
		{
			y[i] = Math.Cos(x[i]) * rnd.NextDouble();
		}

		cds = cdsc.AddNewSeries();
		cds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.None;
		cds.LineStyle.Color = System.Drawing.Color.Blue;

		cds.X.CopyDataIn(x);
		cds.Y.CopyDataIn(y);

		chart.ChartArea.AxisX.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisX.GridMajor.Visible = true;
		chart.ChartArea.AxisY.GridMajor.Color = Color.DarkGray;
		chart.ChartArea.AxisY.GridMajor.Visible = true;

		chart.Legend.Visible = true;

		chart.Footer.Text = "Mouse not over an AlarmZone";
		chart.Footer.Visible = true;

		chart.MouseMove += new System.Windows.Forms.MouseEventHandler(c1Chart1_MouseMove);
	}

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		if(cb.Text.StartsWith("DataSeries "))
		{
			string zname = cb.Text.Replace(" Visible","");
			c1chart1.ChartArea.PlotArea.AlarmZones[zname].Visible = cb.Checked;
		}
		else if(cb.Text == "Inverted")
		{
			c1chart1.ChartArea.Inverted = cb.Checked;
		}
	}

//<CodeSnippet>

	// handler for Extents ComboBox
	private void ComboBoxExtents_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		string [] extents = cb.Text.Split(new char[] {'=',','});
		if(extents != null && extents.Length == 8)
		{
			double near = double.Parse(extents[1]);
			double far = double.Parse(extents[3]);
			double upper = double.Parse(extents[5]);
			double lower = double.Parse(extents[7]);

			C1.Win.C1Chart.AlarmZonesCollection azc = c1chart1.ChartArea.PlotArea.AlarmZones;
			foreach(C1.Win.C1Chart.AlarmZone az in azc)
			{
				az.NearExtent = near;
				az.FarExtent = far;
				az.UpperExtent = upper;
				az.LowerExtent = lower;
			}
		}
	}

	// handler for AlarmZone hit testing
	private void c1Chart1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		if(e.Button == System.Windows.Forms.MouseButtons.None)
		{
			C1.Win.C1Chart.C1Chart chart = sender as C1.Win.C1Chart.C1Chart;
			C1.Win.C1Chart.AlarmZone az =
				chart.ChartArea.PlotArea.AlarmZones.AlarmZoneAtCoord(e.X,e.Y);

			if(az != null)
				chart.Footer.Text = "Hovering over AlarmZone " + az.Name;
			else
				chart.Footer.Text = "Mouse not over an AlarmZone";
		}
	}

//</CodeSnippet>
}

//<Info>
//Shows using chart paint event.
//</Info>
public class Paint: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();
		
		// Create sample data
		int n = 10;
		double[] x1 = new double[n];
		double[] x2 = new double[n];
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "Series 2";
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		// Add paint handler
		c1chart1.Paint += new System.Windows.Forms.PaintEventHandler(Chart_Paint);
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.Paint -= new System.Windows.Forms.PaintEventHandler(Chart_Paint);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// Paint event handler
	private void Chart_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		C1.Win.C1Chart.C1Chart chart = (C1.Win.C1Chart.C1Chart)sender;
		int x1 = 0, y1 = 0, x2 = 0, y2 = 0;

		// Transform coordinates
		chart.ChartGroups[0].DataCoordToCoord( -0.75, -0.75, ref x1, ref y1);
		chart.ChartGroups[0].DataCoordToCoord( 0.75, 0.75, ref x2, ref y2);
		
		// Fill ellipse with semi-transparent brush
		SolidBrush brush = new SolidBrush( Color.FromArgb( 64, Palette.Light2));
		e.Graphics.FillEllipse( brush, x1, y2, x2 - x1, y1 - y2);
		brush.Dispose();

		// Draw ellipse
		Pen pen = new Pen( Palette.Light2);
		e.Graphics.DrawEllipse( pen, x1, y2, x2 - x1, y1 - y2);
		pen.Dispose();
	}
//</CodeSnippet>
}

//<Info>
//Shows using chart PaintPlotArea event.
//</Info>
public class Paint_plot_area: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		c1chart1.Reset();
		
		int n = 10;

		double[] x1 = new double[n];
		double[] x2 = new double[n];
		double[] y1 = new double[n];
		double[] y2 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
			x2[i] = rnd.NextDouble() - 0.5;
			y2[i] = rnd.NextDouble() - 0.5;
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light1;
		ds1.SymbolStyle.OutlineColor = Palette.Dark1;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		C1.Win.C1Chart.ChartDataSeries ds2 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "Series 2";
		ds2.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds2.SymbolStyle.Color = Palette.Light2;
		ds2.SymbolStyle.OutlineColor = Palette.Dark2;
		ds2.X.CopyDataIn( x2);
		ds2.Y.CopyDataIn( y2);

		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		c1chart1.PaintPlotArea += new System.Windows.Forms.PaintEventHandler(Chart_Paint);
//</CodeSnippet>
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.PaintPlotArea -= new System.Windows.Forms.PaintEventHandler(Chart_Paint);
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// Paint event handler
	Bitmap bm = null;
	private void Chart_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		// load image from resource
		if( bm == null)
			bm  = new Bitmap(System.Reflection.Assembly.GetExecutingAssembly()
			.GetManifestResourceStream("images.C1Chart.jpg"));

		C1.Win.C1Chart.PlotArea pa = (C1.Win.C1Chart.PlotArea)sender;

		System.Drawing.Rectangle r = new System.Drawing.Rectangle( 0,	0, bm.Width, bm.Height);
		int new_width = (pa.Size.Width * 3) / 4;
		
		if( r.Width > new_width)
		{
			float ratio = (float)new_width / r.Width;
			r.Width = new_width;
			r.Height = (int)( r.Height * ratio);
		}

		System.Drawing.Point pt = new System.Drawing.Point();
		pt.X = pa.Location.X + pa.Size.Width - r.Width;
		pt.Y = pa.Location.Y + pa.Size.Height - r.Height;
		r.Location = pt;

		// draw semi-transparent logo
		System.Drawing.Imaging.ColorMatrix cm = new System.Drawing.Imaging.ColorMatrix();
		cm.Matrix00 = 1.00f;
		cm.Matrix11 = 1.00f;
		cm.Matrix22 = 1.00f;
		cm.Matrix33 = 0.2f;
		cm.Matrix44 = 1.00f; 

		System.Drawing.Imaging.ImageAttributes ia = new System.Drawing.Imaging.ImageAttributes();
		ia.SetColorMatrix( cm);

		e.Graphics.DrawImage( bm, r, 0, 0, bm.Width, bm.Height, System.Drawing.GraphicsUnit.Pixel, ia);
	}
//</CodeSnippet>
}

//<Info>
//Shows using point styles to mark maximum and minimum data values.
//</Info>
public class MinMax: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample data		
		int n = 25;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = 2*rnd.NextDouble() - 1;
			y[i] = 2*rnd.NextDouble() - 1;
		}
		
		// Add data series
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.Label = "Series 1";
		ds.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds.SymbolStyle.Color = Palette.Light3;
		ds.SymbolStyle.OutlineColor = Palette.Dark3;
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);
			
		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		// Create point style for y-max
		C1.Win.C1Chart.PointStyle ps = c1chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
		ps.Selection = C1.Win.C1Chart.PointStyleSelectionEnum.SeriesMaxY;
		ps.SeriesIndex = 0;
		ps.SymbolStyle.Color = Palette.Light1;
		ps.SymbolStyle.OutlineColor = Palette.Dark1;
		ps.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ps.Label = "Max";
		ps.LegendEntry = true;

		// Create point style for y-min
		ps = c1chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
		ps.Selection = C1.Win.C1Chart.PointStyleSelectionEnum.SeriesMinY;
		ps.SeriesIndex = 0;
		ps.SymbolStyle.Color = Palette.Light2;
		ps.SymbolStyle.OutlineColor = Palette.Dark2;
		ps.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ps.Label = "Min";
		ps.LegendEntry = true;
//</CodeSnippet>
	}
}

//<Info>
//Shows using custom point styles.
//</Info>
public class Custom_point_style: ChartSample
{
	C1.Win.C1Chart.C1Chart _c1chart1;

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		_c1chart1 = c1chart1;
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();
		
		// Create sample data
		int n = 100;
		double[] x = new double[n];
		double[] y = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x[i] = i;
			y[i] = Math.Sin( 0.25*i);
		}
		
		C1.Win.C1Chart.ChartDataSeries ds =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.X.CopyDataIn( x);
		ds.Y.CopyDataIn( y);
		ds.LineStyle.Color = Color.Gray;
			
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		// Create point style
		C1.Win.C1Chart.PointStyle ps = c1chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
		ps.Selection = C1.Win.C1Chart.PointStyleSelectionEnum.Custom;
		ps.SymbolStyle.Size = 4;
		ps.Select += new C1.Win.C1Chart.PointStyleSelectEventHandler(PointStyle_Select);
//</CodeSnippet>
	}

//<CodeSnippet>
	//---------------------------------------------------------------------
	// PointStyleSelect event handler
	void PointStyle_Select( object sender, C1.Win.C1Chart.PointStyleSelectEventArgs e)
	{
		// Current y-value
		double yval = Convert.ToDouble(_c1chart1.ChartGroups[0].ChartData[e.SeriesIndex].Y[e.PointIndex]);

		double maxy = _c1chart1.ChartGroups[0].ChartData.MaxY;
		double miny = _c1chart1.ChartGroups[0].ChartData.MinY;

		C1.Win.C1Chart.ChartDataSeries ds = _c1chart1.ChartGroups[0].ChartData[e.SeriesIndex];

		C1.Win.C1Chart.PointStyle ps = (C1.Win.C1Chart.PointStyle)sender;

		// Change color according to y-value
		if( yval>0)
		{
			Color clr = Color.FromArgb( (int)(255 * ( 1 - (maxy -yval) / maxy)), Palette.Dark1);
			ps.SymbolStyle.Color = clr;
		}
		else
		{
			yval = Math.Abs(yval);
			miny = Math.Abs( miny);
			Color clr = Color.FromArgb( (int)(255 * ( 1 - (miny -yval) / miny)), Palette.Dark2);
			ps.SymbolStyle.Color = clr;
		}

		// This hanlder process all data points
		e.Selected = true;
	}
//</CodeSnippet>
}

//<Info>
//Shows using coordinate conversion methods.
//</Info>
public class DataCoordinates: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.TextBox tb1 = null;

	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				tb1 = new System.Windows.Forms.TextBox();
				tb1.Location = new System.Drawing.Point( 10, 0);
				tb1.Width = 100;
				tb1.ReadOnly = true;
				tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                                _controls = new System.Windows.Forms.Control[]{ tb1};
			}

			return _controls;
		}
	}

	public override void Unload( C1.Win.C1Chart.C1Chart c1chart1)
	{
		c1chart1.MouseMove -= new System.Windows.Forms.MouseEventHandler(Chart_MouseMove);
		base.Unload( c1chart1);
	}

	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
		base.Load( c1chart1);
//<CodeSnippet>
		//RtfGray
		c1chart1.Reset();
		
		int n = 20;

		double[] x1 = new double[n];
		double[] y1 = new double[n];
		Random rnd = new Random();
		for( int i=0; i<n; i++)
		{
			x1[i] = 2*(rnd.NextDouble()-0.5);
			y1[i] = 2*(rnd.NextDouble()-0.5);
		}
		
		C1.Win.C1Chart.ChartDataSeries ds1 =
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "Series 1";
		ds1.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		ds1.SymbolStyle.Color = Palette.Light2;
		ds1.SymbolStyle.OutlineColor = Palette.Dark2;
		ds1.X.CopyDataIn( x1);
		ds1.Y.CopyDataIn( y1);
			
		c1chart1.Legend.Visible = true;
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.XYPlot;

		// Create point style
		C1.Win.C1Chart.PointStyle ps = c1chart1.ChartGroups[0].ChartData.PointStylesList.AddNewPointStyle();
		ps.SymbolStyle.Color = Palette.Light1;
		ps.SymbolStyle.OutlineColor = Palette.Dark1;
		ps.SymbolStyle.Size = 10;
		ps.SeriesIndex = -1;
		ps.PointIndex = -1;

		// Set axis limits
		c1chart1.ChartArea.AxisX.SetMinMax( -1, 1);
		c1chart1.ChartArea.AxisY.SetMinMax( -1, 1);

		// Create frame around plot area
		c1chart1.ChartArea.PlotArea.Boxed = true;

		//RtfNormal
		c1chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(Chart_MouseMove);
//</CodeSnippet>
	}

//<CodeSnippet>
	// --------------------------------------------------------------------
	// Mouse move event handler
	private void Chart_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		C1.Win.C1Chart.C1Chart chart = (C1.Win.C1Chart.C1Chart)sender;

		// Get plot area rectangle
		System.Drawing.Rectangle r = new Rectangle( chart.ChartArea.PlotArea.Location,
			chart.ChartArea.PlotArea.Size);

		C1.Win.C1Chart.PointStyle ps = c1chart1.ChartGroups[0].ChartData.PointStylesList[0];

		if( r.Contains( e.X, e.Y)) // Inside plot area
		{
			// Set cursor
			chart.Cursor = System.Windows.Forms.Cursors.Cross;

			// Find cursor data coordinates
			double x = 0, y = 0;
			chart.ChartGroups[0].CoordToDataCoord( e.X, e.Y, ref x, ref y);
			tb1.Text = string.Format( "x = {0:0.00}, y = {1:0.00}", x, y);

			// Find the closest data point 
			int si = -1, pi = -1, d = -1;
			chart.ChartGroups[0].CoordToDataIndex( e.X, e.Y,
				C1.Win.C1Chart.CoordinateFocusEnum.XandYCoord, ref si, ref pi, ref d);

			// Highlight the closest point
			ps.SeriesIndex = si;
			ps.PointIndex = pi;
		}
		else
		{
			// Restore cursor
			chart.Cursor = System.Windows.Forms.Cursors.Default;

			// Clear text
			tb1.Text = "";

			// Clear highlighted point
			ps.SeriesIndex = -1;
			ps.PointIndex = -1;
		}
	}
//</CodeSnippet>
}

//<Info>
//Shows chart data binding using simple data table as data source.
//</Info>
public class Data_table: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();

		// Create sample table
		DataTable dt = new DataTable("dt");
		DataColumn colX = new DataColumn("x",Type.GetType("System.Double"));
		DataColumn colY = new DataColumn("y",Type.GetType("System.Double"));
		dt.Columns.Add(colX);	dt.Columns.Add(colY);

		// Fill table
		DataRow nr;
		for(int i = 0; i <7; i++)
		{
			nr = dt.NewRow();
			nr["x"] = i; nr["y"] = i*i;
			dt.Rows.Add(nr);
		}
		dt.AcceptChanges();

		//RtfNormal
		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds = 
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds.LineStyle.Color = Palette.Dark2;
		ds.SymbolStyle.Color = Palette.Light1;
		ds.SymbolStyle.OutlineColor = Palette.Dark1;

		// Bind to chart
		c1chart1.DataSource = dt;
		ds.X.DataField = "x";
		ds.Y.DataField = "y";
//</CodeSnippet>
	}
}

//<Info>
//Shows chart data binding using NorthWind database as data source.
//</Info>
public class NorthWindDB: ChartSample
{
	public override void Load( C1.Win.C1Chart.C1Chart c1chart1)
	{
//<CodeSnippet>
		//RtfGray
		// Clear previous settings
		c1chart1.Reset();
		System.Data.DataTable dt = null;

		// Connect to database
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
						  "\\ComponentOne Samples\\Common\\C1NWind.mdb";

			string conn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path + ";Mode=Share Deny None;";
			string select = "SELECT CategoryID, ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel FROM Products ORDER BY UnitsInStock DESC";

			System.Data.OleDb.OleDbDataAdapter adapter = 
				new System.Data.OleDb.OleDbDataAdapter( select, conn);

			dt = new System.Data.DataTable();
			adapter.Fill( dt);
		}
		catch (Exception e)
		{
			c1chart1.Header.Visible = true;
			c1chart1.Header.Text = e.ToString();
			c1chart1.Header.Style.ForeColor = Color.Red;
       			return;
		}

		// Create data series
		C1.Win.C1Chart.ChartDataSeries ds1 = 
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds1.Label = "In Stock";
		ds1.FillStyle.Color1 = Palette.Light1;

                C1.Win.C1Chart.ChartDataSeries ds2 = 
			c1chart1.ChartGroups[0].ChartData.SeriesList.AddNewSeries();
		ds2.Label = "On Order";
		ds2.FillStyle.Color1 = Palette.Light2;
		ds2.AutoEnumerate = true;

		//RtfNormal
		c1chart1.DataSource = dt.DefaultView;

		// Bind to chart
		ds1.X.DataField = "ProductName";
		ds1.Y.DataField = "UnitsInStock";
		ds2.Y.DataField = "UnitsOnOrder";

		//RtfGray
		// Set chart type
		c1chart1.ChartGroups[0].ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Bar;
		c1chart1.ChartGroups[0].Bar.ClusterWidth = 75;
		c1chart1.ChartArea.Inverted = true;

		// Setup appearance
		c1chart1.ChartArea.Margins.SetMargins( 0, 0, 0, 0);

		c1chart1.ChartArea.AxisX.ScrollBar.Visible = true;
		c1chart1.ChartArea.AxisX.ScrollBar.Min = -0.5;
		c1chart1.ChartArea.AxisX.ScrollBar.Max = dt.Rows.Count - 0.5;
		c1chart1.ChartArea.AxisX.ScrollBar.Scale = 0.1;
		c1chart1.ChartArea.AxisX.ScrollBar.Appearance = C1.Win.C1Chart.ScrollBarAppearanceEnum.Flat;

		c1chart1.ChartArea.AxisX.OnTop = true;
		c1chart1.ChartArea.AxisY.OnTop = true;

		c1chart1.Legend.Visible = true;
		c1chart1.Legend.Text = "Units";
//</CodeSnippet>
	}
}

//<Info>
// Shows the use of Formula type Y-Functions in the chart.
//</Info>
public class YFormula: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox ComboBoxWithFormula = null;
	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 130;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "Append Functions";
				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.ComboBox cbox1 = new System.Windows.Forms.ComboBox();
				cbox1.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cbox1.Width = 120;

				object [] yfuncs = new object[]
				{
					"Math.Sin(x)", "Math.Cos(x)", "Math.Exp(x)",
					"x+1", "x*x-2*x+1", "x*x*x-3*x*x-3*x+1",
					"BadFunction(x)",
				};
				cbox1.Items.AddRange(yfuncs);
				cbox1.SelectedIndex = 0;
				cbox1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
				ComboBoxWithFormula = cbox1;

				_controls = new System.Windows.Forms.Control[]{cb1, cbox1};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		//c1Chart1.Reset();

//<CodeSnippet>
		// Create chart with YFunctions through code.
		//
		// Although a chart can consist entirely of YFunctions as is demonstrated
		// in this sample, functions typically used to enhance understanding of
		// empirical data added to the chart in the usual manner.
		//
		c1Chart1.Reset();

		// Turn on the legend.
		c1Chart1.Legend.Visible = true;

		// Use the ComboBox handler to specify the YFunction to be charted.
		ComboBox_SelectedIndexChanged(ComboBoxWithFormula, new System.EventArgs());

//</CodeSnippet>
	}

//<CodeSnippet>

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		if(cb.Text == "Append Functions")
		{
			AppendFunctions = cb.Checked;
		}
	}


	bool AppendFunctions = false;

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		string functionText = (string)cb.SelectedItem;

		// The text of the formula, placed in functionText above, is dynmaically
		// compiled by the chart YFunction object and executed upon demand for each
		// point of the function.  In this case, the formula text is the text of
		// each entry of the combo box.

		Color [] clrs = new Color []
			{ Color.Red, Color.Orange, Color.Green, Color.Blue, Color.Brown, Color.Violet, Color.Black};

		Color selectedColor = clrs[cb.SelectedIndex % clrs.Length];

		C1.Win.C1Chart.FunctionsCollection funcs = c1chart1.ChartGroups.Group0.ChartData.FunctionsList;
		if(!AppendFunctions) funcs.Clear();	// remove existing functions

		// create the new function and add it to the functions collection.
		C1.Win.C1Chart.YFunction func = new C1.Win.C1Chart.YFunction();
		func.CodeLanguage = C1.Win.C1Chart.FunctionCodeLanguageEnum.CSharp;
		func.CodeText = functionText;
		func.CodeType = C1.Win.C1Chart.FunctionCodeTypeEnum.Formula;
		func.MaxX = 2.0 * Math.PI;
		func.MinX = 0;
		func.Label = functionText;
		func.LegendEntry = true;
		func.LineStyle.Color = selectedColor;

		// use as many x values as there are pixels
		func.PlotNumPoints = c1chart1.ChartArea.PlotArea.Size.Width;

		// if an error occurs compiling the code, pop up a message box.
		if(!func.CodeValid)
		{
			string [] errs = func.CodeErrors;

			string msg = "Formula \"" + functionText + "\" does not compile correctly.\\r\\n";
			foreach(string err in errs) msg += "\\r\\n" + err;

			System.Windows.Forms.MessageBox.Show(msg);
			func.Dispose();
			return;
		}
		func.Visible = true;
		funcs.Add(func);
	}

//</CodeSnippet>
}


//<Info>
// Shows the use of Method type Y-Functions in the chart.
//</Info>
public class YMethod: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	System.Windows.Forms.ComboBox ComboBoxWithFormula = null;
	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				cb1.Location = new System.Drawing.Point( 10, 0);
				cb1.Width = 130;
				cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				cb1.Text = "Append Functions";
				cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);

				System.Windows.Forms.ComboBox cbox1 = new System.Windows.Forms.ComboBox();
				cbox1.Location = new System.Drawing.Point( cb1.Right + 10, 0);
				cbox1.Width = 120;

				object [] yfuncs = (object[])Array.CreateInstance(typeof(object), FunctionNames.Length);
				for(int i=0; i < yfuncs.Length; i++)
					yfuncs[i] = FunctionNames[i];

				cbox1.Items.AddRange(yfuncs);
				cbox1.SelectedIndex = 0;
				cbox1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
				ComboBoxWithFormula = cbox1;

				_controls = new System.Windows.Forms.Control[]{cb1, cbox1};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		//c1Chart1.Reset();

//<CodeSnippet>
		// Create chart with YFunctions through code.
		//
		// Although a chart can consist entirely of YFunctions as is demonstrated
		// in this sample, functions typically used to enhance understanding of
		// empirical data added to the chart in the usual manner.
		//
		c1Chart1.Reset();

		// Turn on the legend.
		c1Chart1.Legend.Visible = true;

		// Use the ComboBox handler to specify the YFunction to be charted.
		ComboBox_SelectedIndexChanged(ComboBoxWithFormula, new System.EventArgs());

//</CodeSnippet>
	}

//<CodeSnippet>

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		if(cb.Text == "Append Functions")
		{
			AppendFunctions = cb.Checked;
		}
	}


	bool AppendFunctions = false;

	string [] FunctionNames = new string[]
		{
			"Delta(x-3)",
			"Factorial(x)",
			"CircleArea(r)",
			"CirclePerimeter(r)",
			"BadFunction(x)"
		};

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		string functionText = "return BadFunction(x);";

		// The text of the method, placed in the function CodeText property, is
		// wrapped with a function definition, then dynamically compiled by the chart
		// YFunction object and executed upon demand for each point of the function.
		//
		// In this case, the function text is the text defined for each each entry below.
		// Note that the text must indicate a return value for all paths.

		switch(cb.Text)
		{
			case "Delta(x-3)":
				functionText =
					"if(x < 3)	" +
					"  return 0;	" +
					"else			" +
					"  return 1;	";
				break;

			case "Factorial(x)":
				functionText =
					"int ix = (int)Math.Floor(x);	" +
					"if(ix < 1) return 1;		" +
					"int prod = 1;					" +
					"while(ix > 1)				" +
					"{								" +
					"  prod *= ix;					" +
					"  ix--;						" +
					"}								" +
					"return prod;					";
				break;

			case "CircleArea(r)":
				functionText = "return Math.PI * x * x;";
				break;
			case "CirclePerimeter(r)":
				functionText = "return Math.PI * 2.0 * x;";
				break;

			case "BadFunction(x)":
			default:
				break;
		}

		Color [] clrs = new Color []
			{
				Color.Red, Color.Orange, Color.Green, Color.Blue,
				Color.Brown, Color.Violet, Color.Black
			};

		Color selectedColor = clrs[cb.SelectedIndex % clrs.Length];

		C1.Win.C1Chart.FunctionsCollection funcs = c1chart1.ChartGroups.Group0.ChartData.FunctionsList;
		if(!AppendFunctions) funcs.Clear();	// remove existing functions

		// create the new function and add it to the functions collection.
		C1.Win.C1Chart.YFunction func = new C1.Win.C1Chart.YFunction();
		func.CodeLanguage = C1.Win.C1Chart.FunctionCodeLanguageEnum.CSharp;
		func.CodeType = C1.Win.C1Chart.FunctionCodeTypeEnum.Method;

		// Y Functions of type Method use code text that returns the Y
		// values as would be returned from a function.
		func.CodeText = functionText;

		func.MaxX = 2.0 * Math.PI;
		func.MinX = 0;
		func.Label = cb.Text;
		func.LegendEntry = true;
		func.LineStyle.Color = selectedColor;

		// use as many x values as there are pixels
		func.PlotNumPoints = c1chart1.ChartArea.PlotArea.Size.Width;

		// if an error occurs compiling the code, pop up a message box.
		if(!func.CodeValid)
		{
			string [] errs = func.CodeErrors;

			string msg = "Formula \"" + functionText + "\" does not compile correctly.\\r\\n";
			foreach(string err in errs) msg += "\\r\\n" + err;

			System.Windows.Forms.MessageBox.Show(msg);

			// since there is an error, return from this event without
			// adding the new function to the function collection.
			func.Dispose();
			return;
		}
		func.Visible = true;
		funcs.Add(func);
	}

//</CodeSnippet>
}


//<Info>
// Shows the use of Unit type Y-Functions in the chart.
//</Info>
public class YUnit: ChartSample
{
	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);

//<CodeSnippet>
		// Create chart with YFunctions through code.
		//
		// Although a chart can consist entirely of YFunctions as is demonstrated
		// in this sample, functions typically used to enhance understanding of
		// empirical data added to the chart in the usual manner.
		//
		c1Chart1.Reset();
		c1Chart1.Repaint = false;		// turn off paint operations

		c1Chart1.Header.Text = "Area between a circle of a given\\r\\n" +
			"diameter and a circumscribing square.";

		c1Chart1.ChartArea.AxisX.Text = "Circle Diameter";
		c1Chart1.ChartArea.AxisY.Text = "Circle Area";

		C1.Win.C1Chart.FunctionsCollection funcs = c1Chart1.ChartGroups.Group0.ChartData.FunctionsList;

		// create the new function and add it to the functions collection.
		C1.Win.C1Chart.YFunction func = new C1.Win.C1Chart.YFunction();
		func.CodeLanguage = C1.Win.C1Chart.FunctionCodeLanguageEnum.CSharp;
		func.CodeType = C1.Win.C1Chart.FunctionCodeTypeEnum.Unit;

		// A YFunction of type Unit, allows you to create an entire compile
		// unit with multiple functions and classes necessary to obtain a return
		// value.  The Unit must have a namespace of UserFunction, a Calculator
		// class which derives from ISimpleFunction, and a public function named
		// Calculate which returns a double, and takes a single double parameter.

		func.CodeText =
			"namespace UserFunction" +
			"{" +
			"  class Calculator : ISimpleFunction" +
			"  {" +
			"    public double Calculate(double x)" +
			"    {" +
			"       return SquareArea(x) - CircleArea(x/2.0);" +
			"    }" +
			"    public double CircleArea(double r)" +
			"    {" +
			"       return System.Math.PI * r * r;" +
			"    }" +
			"    public double SquareArea(double x)" +
			"    {" +
			"       return x * x;" +
			"    }" +
			"  }" +
			"}";
			
		func.MaxX = 10;
		func.MinX = 2;
		func.LineStyle.Color = Color.Blue;

		// use as many x values as there are pixels
		func.PlotNumPoints = c1Chart1.ChartArea.PlotArea.Size.Width;

		// if an error occurs compiling the code, pop up a message box.
		if(!func.CodeValid)
		{
			string [] errs = func.CodeErrors;

			string msg = "Unit does not compile correctly.\\r\\n";
			if(errs != null)
				foreach(string err in errs) msg += "\\r\\n" + err;

			System.Windows.Forms.MessageBox.Show(msg);

			// since there is an error, return from this event without
			// adding the new function to the function collection.
			func.Dispose();
			return;
		}
		func.Visible = true;
		funcs.Add(func);

		c1Chart1.PaintPlotArea += new System.Windows.Forms.PaintEventHandler(DrawSample);
		c1Chart1.Repaint = true;		// restore paint operations

//</CodeSnippet>
	}

	public override void Unload(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		c1Chart1.PaintPlotArea -= new System.Windows.Forms.PaintEventHandler(DrawSample);
	}

//<CodeSnippet>

	// Chart PaintPlotArea Event Handler
	private void DrawSample(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		Rectangle r = e.ClipRectangle;
		r.X += r.Width/8;
		r.Y += r.Height/8;
		if(r.Width > r.Height)
		{
			r.Height /= 2;
			r.Width = r.Height;
		}
		else
		{
			r.Width /= 2;
			r.Height = r.Width;
		}

		// save the existing clip region.
		System.Drawing.Region regSave = e.Graphics.Clip;

		// create a region of the circle area and exclude it from
		// the graphics clipping region.  This forms a hole.
		System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
		gp.AddEllipse(r);

		System.Drawing.Region reg = new System.Drawing.Region(gp);
		e.Graphics.ExcludeClip(reg);
		reg.Dispose();
		gp.Dispose();

		// draw the rectangle.
		e.Graphics.FillRectangle(System.Drawing.Brushes.SteelBlue, r);

		// restore the clipping area.
		e.Graphics.Clip = regSave;
		regSave.Dispose();
	}

//</CodeSnippet>
}


//<Info>
// Shows the use of Formula type ParametricFunctions in the chart.
//</Info>
public class ParaFormula: ChartSample
{
	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);

//<CodeSnippet>
		// Create chart with ParametricFunctions through code.
		//
		// Although a chart can consist entirely of ParametricFunctions as is
		// demonstrated in this sample, functions are typically used to enhance
		// understanding of empirical data added to the chart in the usual manner.
		//
		c1Chart1.Reset();

		c1Chart1.Header.Text =
			"4 Leaf Rose\\r\\n\\r\\n" +
			"x = sin(2*t)*sin(t)\\r\\n" +
			"y = sin(2*t)*cos(t)";

		C1.Win.C1Chart.FunctionsCollection funcs = c1Chart1.ChartGroups.Group0.ChartData.FunctionsList;

		// create the new function and add it to the functions collection.
		C1.Win.C1Chart.ParametricFunction func = new C1.Win.C1Chart.ParametricFunction();
		func.CodeLanguage = C1.Win.C1Chart.FunctionCodeLanguageEnum.CSharp;
		func.CodeType = C1.Win.C1Chart.FunctionCodeTypeEnum.Formula;

		// Like YFunctions, ParametricFunctions may be of 3 types, including
		// Formula, Method and Unit.  The simplest, Formula, is demonstrated
		// here.  In this case, each of the X and Y values must be defined as
		// a function of an independent variable, t.

		func.CodeTextX = "Math.Sin(2*t) * Math.Sin(t)";
		func.CodeTextY = "Math.Sin(2*t) * Math.Cos(t)";
			
		func.MaxT = Math.PI * 2;
		func.MinT = 0;
		func.LineStyle.Color = Color.Red;

		// use as many x values as there are pixels
		func.PlotNumPoints = c1Chart1.ChartArea.PlotArea.Size.Width;

		// if an error occurs compiling the code, pop up a message box.
		if(!func.CodeValid)
		{
			string [] errs = func.CodeErrors;

			string msg = "Unit does not compile correctly.\\r\\n";
			if(errs != null)
				foreach(string err in errs) msg += "\\r\\n" + err;

			System.Windows.Forms.MessageBox.Show(msg);

			// since there is an error, return from this event without
			// adding the new function to the function collection.
			func.Dispose();
			return;
		}
		func.Visible = true;
		funcs.Add(func);

//</CodeSnippet>
	}
}


//<Info>
// Shows use of Trend functions in the chart.
//</Info>
public class Polynomial: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				System.Windows.Forms.Label lab = new System.Windows.Forms.Label();
				lab.Location = new System.Drawing.Point(10, 0);
				lab.Width = 88;
				lab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
				lab.Text = "Polynomial Type";

				System.Windows.Forms.ComboBox cb1 = new System.Windows.Forms.ComboBox();
				cb1.Location = new System.Drawing.Point( lab.Right + 2, 0);
				cb1.Width = 100;
				cb1.BackColor = System.Drawing.SystemColors.Control;
				cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
				cb1.Items.AddRange(new object[] {"Linear","Quadratic","Cubic","4th-order","5th-order"});
				cb1.Text = "Linear";
				cb1.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

				System.Windows.Forms.Button btnRegen = new System.Windows.Forms.Button();
				btnRegen.Location = new System.Drawing.Point(cb1.Right + 20, 0);
				btnRegen.Width = 160;
				btnRegen.Text = "Generate New Data";
				btnRegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				btnRegen.Click += new EventHandler(Button_Clicked);

				_controls = new System.Windows.Forms.Control[]{lab, cb1, btnRegen};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		c1Chart1.Reset();

//<CodeSnippet>

		// Show a legend
		c1Chart1.Legend.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Solid;
		c1Chart1.Legend.Orientation = C1.Win.C1Chart.LegendOrientationEnum.Horizontal;
		c1Chart1.Legend.Compass = C1.Win.C1Chart.CompassEnum.South;
		c1Chart1.Legend.Visible = true;

		// Get the ChartData
		C1.Win.C1Chart.ChartData cdata = c1Chart1.ChartGroups.Group0.ChartData;

		// Create a new ChartDataSeries
		C1.Win.C1Chart.ChartDataSeriesCollection cdsc = cdata.SeriesList;
		C1.Win.C1Chart.ChartDataSeries cds = cdsc.AddNewSeries();

		// Adjust the series styles for scatter data
		cds.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.None;
		cds.SymbolStyle.Shape = C1.Win.C1Chart.SymbolShapeEnum.Dot;
		cds.SymbolStyle.Color = System.Drawing.Color.LightCoral;
		cds.SymbolStyle.OutlineColor = System.Drawing.Color.DarkRed;
		cds.SymbolStyle.OutlineWidth = 1;
		cds.SymbolStyle.Size = 12;

		// Create and add the data
		GenerateData(cds, 25);

		// Add a Linear Trendline to start
		C1.Win.C1Chart.TrendLine trend = cdata.TrendsList.AddNewTrendLine();
		trend.LineStyle.Pattern = C1.Win.C1Chart.LinePatternEnum.Solid;
		trend.LineStyle.Color = System.Drawing.Color.Blue;
		trend.SeriesIndex = 0;
		trend.RegressionOptions.NumTerms = 2;
		trend.TrendLineType = C1.Win.C1Chart.TrendLineTypeEnum.Polynom;

//</CodeSnippet>
	}

//<CodeSnippet>

	private void GenerateData(C1.Win.C1Chart.ChartDataSeries chartSeries, int numberOfPoints)
	{
		double [] x = new double[numberOfPoints];
		double [] y = new double[numberOfPoints];
		
		System.Random rnd = new System.Random();

		for(int i=0; i < numberOfPoints; i++)
		{
			x[i] = i;
			y[i] = rnd.NextDouble() * 100;
		}

		chartSeries.X.CopyDataIn(x);
		chartSeries.Y.CopyDataIn(y);
	}

	//---------------------------------------------------------------------
	// handler for button

	private void Button_Clicked(object sender, System.EventArgs e)
	{
		GenerateData(c1chart1.ChartGroups.Group0.ChartData.SeriesList[0], 25);
	}

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
		int PolynomialOrder = 1;

		switch(cb.Text)
		{
			case "Linear":
				PolynomialOrder = 1;
				break;
			case "Quadratic":
				PolynomialOrder = 2;
				break;
			case "Cubic":
				PolynomialOrder = 3;
				break;
			case "4th-order":
				PolynomialOrder = 4;
				break;
			case "5th-order":
				PolynomialOrder = 5;
				break;
		}

		// trending polynomial has one more term that its order
		C1.Win.C1Chart.TrendLine tl = c1chart1.ChartGroups.Group0.ChartData.TrendsList[0];
		tl.LegendEntry = true;
		tl.Text = cb.Text;
		tl.RegressionOptions.NumTerms = PolynomialOrder + 1;
	}

//</CodeSnippet>

}

public class ChartSamples
{
public static IChartSample[] Samples = new IChartSample[]
{
new NewSample(),
new Bar(),
new Line(),
new Scatter(),
new Step(),
new Pie(),
new Doughnut(),
new Area(),
new Spline(),
new Polar(),
new Radar(),
new HiLo(),
new HiLoOpenClose(),
new Candle(),
new HLOC_Volume(),
new Bubble(),
new ComplexChart(),
new Gantt(),
new Header(),
new Footer(),
new Rtf(),
new Position(),
new Origin(),
new Gridlines(),
new Logarithmic(),
new ValueLabels(),
new Markers(),
new FillStyle(),
new Texture(),
new Labels(),
new DataLabels(),
new Colors(),
new Borders(),
new Fonts(),
new AlphaBlending(),
new Translate(),
new Scale(),
new Zoom(),
new Rotate3D(),
new Simple(),
new WithScale(),
new CustomMenu(),
new MouseOver(),
new ActiveSeries(),
new CustomHighlight(),
new Tooltips(),
new Dialog(),
new BasicShapes(),
new PolarShapes(),
new Polygons(),
new DataSeries(),
new Paint(),
new Paint_plot_area(),
new MinMax(),
new Custom_point_style(),
new DataCoordinates(),
new Data_table(),
new NorthWindDB(),
new YFormula(),
new YMethod(),
new YUnit(),
new ParaFormula(),
new Polynomial(),
};
}}
