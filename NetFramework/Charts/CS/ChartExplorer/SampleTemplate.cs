
// this file is for storage purposes only, and should not be
// included in the project.  It is only used by the debug version
// of the code.


//<FullChartSampleTemplate>
public class ChartSample
{
	// class simulating ChartSample behavior in ChartExplorer
	public C1.Win.C1Chart.C1Chart c1chart1;
	protected virtual System.Windows.Forms.Control[] Controls {get {return null;}}
	public virtual void Load(C1.Win.C1Chart.C1Chart chart)
	{ 
		c1chart1 = chart;
		if(c1chart1 != null && c1chart1.Parent != null && this.Controls != null)
			c1chart1.Parent.Controls.AddRange(this.Controls);
	}
	public virtual void Unload(C1.Win.C1Chart.C1Chart chart)
	{
	}
	protected void FillComboBox( ComboBox cb, Type type)
	{
		cb.Items.Clear();
		Array objs = Enum.GetValues( type);
		foreach( object obj in objs)
			cb.Items.Add( obj);
	}
}

//<CodeCS>
//<Info>
// Shows NewSample chart.
//</Info>
public class NewSample: ChartSample
{
	System.Windows.Forms.Control[] _controls = null;
	protected override System.Windows.Forms.Control[] Controls
	{
		get
		{
			if( _controls == null)
			{
				//System.Windows.Forms.CheckBox cb1 = new System.Windows.Forms.CheckBox();
				//cb1.Location = new System.Drawing.Point( 10, 0);
				//cb1.Width = 40;
				//cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				//cb1.Text = "3D";
				//cb1.CheckedChanged += new EventHandler(CheckBox_CheckChanged);
				//_controls = new System.Windows.Forms.Control[]{cb1};
			}
			return _controls;
		}
	}

	public override void Load(C1.Win.C1Chart.C1Chart c1Chart1)
	{
		base.Load(c1Chart1);
		SetChartData(c1Chart1);

//<CodeSnippet>
		// Create chart through code.
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
	}

	//---------------------------------------------------------------------
	// handler for check boxes
	private void CheckBox_CheckChanged(object sender, System.EventArgs e)
	{
		//System.Windows.Forms.CheckBox cb = (System.Windows.Forms.CheckBox)sender;
		//if(cb.Text == "3D")
		//{
		//	if( cb.Checked)
		//	{
		//		c1chart1.ChartGroups[0].Use3D = true;
		//		c1chart1.ChartArea.PlotArea.View3D.Depth = 3;
		//		c1chart1.ChartArea.PlotArea.View3D.Rotation = 45;
		//		c1chart1.ChartArea.PlotArea.View3D.Elevation = 45;
		//		c1chart1.ChartArea.PlotArea.Boxed = true;
		//	}
		//	else
		//	{
		//		c1chart1.ChartGroups[0].Use3D = false;
		//		c1chart1.ChartArea.PlotArea.Boxed = false;
		//	}
		//}
	}

	// handler for combo box
	private void ComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
	{
		//System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)sender;
	}
}
//</CodeCS>
//</FullChartSampleTemplate>


//<PartialCSSampleTemplate>
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
//</PartialCSSampleTemplate>

/*

//<PartialVBSampleTemplate>
'<Info>
'Shows chart NewSample.
'</Info>\r\n" +
Public Class NewSample
	Inherits ChartSample

	Public Overrides Sub Load( C1.Win.C1Chart.C1Chart C1Chart1)
'<CodeSnippet>
		'VB NewSample sample.
		C1Chart1.Reset()
		C1Chart1.Style.Border.BorderStyle = C1.Win.C1Chart.BorderStyleEnum.Groove
		C1Chart1.Style.BackColor = Color.Azure
		C1Chart1.Style.BackColor2 = Color.Navy
		C1Chart1.Style.GradientStyle = C1.Win.C1Chart.GradientStyleEnum.FromCenter
'</CodeSnippet>
	End Sub 'Load
End Class
//</PartialVBSampleTemplate>

*/
