using System.Windows.Forms;
using C1.Win.Sizer;

namespace SizerExplorer.Samples
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public partial class AddControls : UserControl
	{
		public AddControls()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create the grid
			Grid grid = c1Sizer1.Grid;
			int rowCount = grid.Rows.Count = 8;
			int colCount = grid.Columns.Count = 5;

			// add some controls to it
			for (int r = 0; r < rowCount; r++)
			{
				for (int c = 0; c < colCount; c++)
				{
					// create a new button
					Button btn = new Button();
					btn.Text = "Button " + c1Sizer1.Controls.Count.ToString();

					// add it to the sizer
					c1Sizer1.AddControl(btn, r, c);
				}
			}
		}
	}
}