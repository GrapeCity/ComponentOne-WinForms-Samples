using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CellDataType
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
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
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(256, 325);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(256, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Cells & DataTypes";
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
			// set up grid
			_flex.Cols.Count = 2;
			_flex.Rows.Count = 7;
			_flex.Cols[0].Caption = "Item";
			_flex.Cols[1].Caption = "Value";
			_flex.Styles.Fixed.BackColor = Color.DarkGray;
			_flex.Styles.Fixed.ForeColor = Color.White;

			// create styles with data types, formats, etc
			CellStyle cs = _flex.Styles.Add("emp");
			cs.DataType = typeof(string);
			cs.ComboList = "|Tom|Dick|Harry";
			cs.ForeColor = Color.Navy;
			cs.Font = new Font(Font, FontStyle.Bold);

			cs = _flex.Styles.Add("date");
			cs.DataType = typeof(DateTime);
			cs.Format = "dd-MMM-yy";
			cs.ForeColor = Color.DarkGoldenrod;

			cs = _flex.Styles.Add("curr");
			cs.DataType = typeof(decimal);
			cs.Format = "c";
			cs.ForeColor = Color.DarkGreen;
			cs.Font = new Font(Font, FontStyle.Bold);

			cs = _flex.Styles.Add("bool");
			cs.DataType = typeof(bool);
			cs.ImageAlign = ImageAlignEnum.CenterCenter;

			// show captions
			_flex[1,0] = "Employee";
			_flex[2,0] = "Start";
			_flex[3,0] = "End";
			_flex[4,0] = "Amount";
			_flex[5,0] = "Discount";
			_flex[6,0] = "Active";

			// assign styles to editable cells
			CellRange rg = _flex.GetCellRange(1,1);
			rg.Style = _flex.Styles["emp"];

			rg = _flex.GetCellRange(2,1,3,1);
			rg.Style = _flex.Styles["date"];

			rg = _flex.GetCellRange(4,1,5,1);
			rg.Style = _flex.Styles["curr"];

			rg = _flex.GetCellRange(6,1);
			rg.Style = _flex.Styles["bool"];
		}
	}
}
