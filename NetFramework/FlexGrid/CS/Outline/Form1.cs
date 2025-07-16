using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Outline
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button button1;
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
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(408, 240);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 256);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(176, 32);
			this.button1.TabIndex = 1;
			this.button1.Text = "Build Outline";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(424, 293);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Outlining";
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// configure grid
			_flex.Cols.Count = 2;
			_flex.Cols.Fixed = 0;
			_flex.Rows.Count = 1;
			
			C1.Win.FlexGrid.CellStyle s = _flex.Styles[C1.Win.FlexGrid.CellStyleEnum.Subtotal0];
			s.BackColor = _flex.Styles.Normal.BackColor;
			s.ForeColor = _flex.Styles.Normal.ForeColor;

			// populate grid
			_flex[0,0] = "Type";
			_flex[0,1] = "Item";
			_flex.AddItem("Fruit\tApple");
			_flex.AddItem("Fruit\tBanana");
			_flex.AddItem("Fruit\tOrange");
			_flex.AddItem("Fruit\tGrape");
			_flex.AddItem("Meat\tSteak");
			_flex.AddItem("Meat\tHamburger");
			_flex.AddItem("Meat\tRib");
			_flex.AddItem("Meat\tPot Roast");
			_flex.AddItem("Salad\tGreen");
			_flex.AddItem("Salad\tCaesar");
			_flex.AddItem("Salad\tGreek");
			_flex.AddItem("Salad\tSpinach");
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// hide column(s) you don't want to show
			_flex.Cols[0].Visible = false;

			// move outline tree to first visible column
			_flex.Tree.Column = 1;
			_flex.Tree.Style = C1.Win.FlexGrid.TreeStyleFlags.SimpleLeaf;

			// build the outline
			_flex.Subtotal(C1.Win.FlexGrid.AggregateEnum.Clear);
			_flex.Subtotal(C1.Win.FlexGrid.AggregateEnum.None, 0, 0, 0, "{0}");
		}
	}
}
