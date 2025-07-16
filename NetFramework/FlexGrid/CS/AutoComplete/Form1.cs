using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoComplete
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
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
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.Size = new System.Drawing.Size(520, 326);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.Tree.NodeImageCollapsed = null;
			this._flex.Tree.NodeImageExpanded = null;
			this._flex.KeyUpEdit += new C1.Win.FlexGrid.KeyEditEventHandler(this._flex_KeyUpEdit);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(520, 326);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: AutoComplete";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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

		private C1.Win.FlexGrid.C1FlexGrid _flex;

		// core method

		private void AutoComplete()
		{
			// get editor
			TextBox tb = _flex.Editor as TextBox;
			if (tb == null) return;

			// get current editor content
			string strEdit = tb.Text;
			int len = strEdit.Length;
        
			// autocomplete only at the end of the text
			if (tb.SelectionStart < len) return;

			// look for match on the same column
			int row = _flex.FindRow(strEdit, _flex.Rows.Fixed, _flex.Col, false, false, false);
        
			// if a match was found, handle it
			if (row > -1 && row != _flex.Row)
			{
				// get matching text
				string match = _flex.GetDataDisplay(row, _flex.Col);
            
				// put matching text in editor
				if (tb.Text != match)
					tb.Text = match;
            
				// select part that was guessed (not typed)
				tb.Select(len, match.Length - len);
			}
		}

		// event handlers 

		private void _flex_KeyUpEdit(object sender, C1.Win.FlexGrid.KeyEditEventArgs e)
		{
			if (e.KeyCode == Keys.Space ||
				e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.Divide ||
				e.KeyCode >= Keys.OemSemicolon && e.KeyCode <= Keys.OemBackslash)
				AutoComplete();
		}
		private void Form1_Load(object sender, System.EventArgs e)
		{
			_flex[1, 1] = "Austin";
			_flex[2, 1] = "Boston";
			_flex[3, 1] = "Chicago";
			_flex[4, 1] = "Denver";
			_flex[5, 1] = "Emeryville";
			_flex[6, 1] = "Miami";
			_flex[7, 1] = "New York";
			_flex[8, 1] = "Orlando";
			_flex[9, 1] = "Pittsburgh";
        
			_flex[1, 2] = "Strange";
			_flex[2, 2] = "Strawberry";
			_flex[3, 2] = "Street";
			_flex[4, 2] = "Stellar";
			_flex[5, 2] = "Stop it!";
    
			_flex[1, 3] = "Swell";
			_flex[2, 3] = "Sweet";
			_flex[3, 3] = "Swatch";
			_flex[4, 3] = "Sweat";
			_flex[5, 3] = "Swing";
		}
	}
}
