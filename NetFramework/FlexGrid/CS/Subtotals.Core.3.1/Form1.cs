using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;

namespace Subtotals
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.C1Themes.C1ThemeController _themeController;

		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.CheckBox _chkAbove;
		private System.Windows.Forms.CheckBox _chkGrand;
		private System.Windows.Forms.CheckBox _chkDirection;
		private System.Windows.Forms.CheckBox _chkRegion;
		private System.Windows.Forms.Button _btnPrint;
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
            _themeController = new C1ThemeController();
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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._chkAbove = new System.Windows.Forms.CheckBox();
			this._chkGrand = new System.Windows.Forms.CheckBox();
			this._chkDirection = new System.Windows.Forms.CheckBox();
			this._chkRegion = new System.Windows.Forms.CheckBox();
			this._btnPrint = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 32);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(536, 280);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _chkAbove
			// 
			this._chkAbove.Checked = true;
			this._chkAbove.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkAbove.Location = new System.Drawing.Point(8, 8);
			this._chkAbove.Name = "_chkAbove";
			this._chkAbove.Size = new System.Drawing.Size(144, 16);
			this._chkAbove.TabIndex = 1;
			this._chkAbove.Text = "Subtotals Above Data";
			this._chkAbove.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
			// 
			// _chkGrand
			// 
			this._chkGrand.Checked = true;
			this._chkGrand.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkGrand.Location = new System.Drawing.Point(168, 8);
			this._chkGrand.Name = "_chkGrand";
			this._chkGrand.Size = new System.Drawing.Size(72, 16);
			this._chkGrand.TabIndex = 1;
			this._chkGrand.Text = "Grand";
			this._chkGrand.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
			// 
			// _chkDirection
			// 
			this._chkDirection.Checked = true;
			this._chkDirection.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkDirection.Location = new System.Drawing.Point(256, 8);
			this._chkDirection.Name = "_chkDirection";
			this._chkDirection.Size = new System.Drawing.Size(72, 16);
			this._chkDirection.TabIndex = 1;
			this._chkDirection.Text = "Direction";
			this._chkDirection.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
			// 
			// _chkRegion
			// 
			this._chkRegion.Checked = true;
			this._chkRegion.CheckState = System.Windows.Forms.CheckState.Checked;
			this._chkRegion.Location = new System.Drawing.Point(336, 8);
			this._chkRegion.Name = "_chkRegion";
			this._chkRegion.Size = new System.Drawing.Size(80, 16);
			this._chkRegion.TabIndex = 1;
			this._chkRegion.Text = "Region";
			this._chkRegion.CheckedChanged += new System.EventHandler(this._chk_CheckedChanged);
			// 
			// _btnPrint
			// 
			this._btnPrint.Location = new System.Drawing.Point(424, 8);
			this._btnPrint.Name = "_btnPrint";
			this._btnPrint.Size = new System.Drawing.Size(72, 20);
			this._btnPrint.TabIndex = 2;
			this._btnPrint.Text = "&Print";
			this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 317);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnPrint,
																		  this._chkAbove,
																		  this._flex,
																		  this._chkGrand,
																		  this._chkDirection,
																		  this._chkRegion});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Subtotals";
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
			// populate grid
			Random rnd = new Random();
			_flex.Rows.Count = 14;
			_flex[0,1] = "Direction";
			_flex[0,2] = "Region";
			CellRange rg = _flex.GetCellRange(0,3,0,_flex.Cols.Count-1);
			rg.Data = "Rnd";
			for (int r = 1; r < _flex.Rows.Count; r++)
			{
				_flex[r,0] = r;
				_flex[r,1] = (r < 7)? "Inbound": "Outbound";
				_flex[r,2] = (r < 3)? "North": (r < 7)? "South": (r < 10)? "East": "West";
				for (int c = 3; c < _flex.Cols.Count; c++)
				{
					_flex[r,c] = rnd.Next(1000);
					_flex.Cols[c].Format = "#,###";
				}
			}

			// set up styles
			CellStyle s = _flex.Styles[CellStyleEnum.Subtotal0];
				s.BackColor = Color.Black;
				s.ForeColor = Color.White;
				s.Font = new Font(_flex.Font, FontStyle.Bold);
			s = _flex.Styles[CellStyleEnum.Subtotal1];
				s.BackColor = Color.DarkBlue;
				s.ForeColor = Color.White;
			s = _flex.Styles[CellStyleEnum.Subtotal2];
				s.BackColor = Color.DarkRed;
				s.ForeColor = Color.White;

			// more setup
			_flex.AllowDragging = AllowDraggingEnum.None;
			_flex.AllowEditing = false;
			_flex.Cols[0].WidthDisplay /= 3;
			_flex.Tree.Column = 1;

			// show totals
			UpdateTotals();

                //C1.Win.C1Themes.C1ThemeController.ApplicationTheme = "Office2016White";
			_themeController.SetTheme(_flex, "Office2016Green");
		}
		private void UpdateTotals()
		{
			// clear existing totals
			_flex.Subtotal(AggregateEnum.Clear);

			// calculate subtotals (three levels, totals on every column)
			for (int c = 3; c < _flex.Cols.Count; c++)
			{
				if (_chkGrand.Checked)
					_flex.Subtotal(AggregateEnum.Sum, 0, -1, c, "Grand Total");
				if (_chkDirection.Checked)
					_flex.Subtotal(AggregateEnum.Sum, 1, 1, c, "Total for {0}");
				if (_chkRegion.Checked)
					_flex.Subtotal(AggregateEnum.Sum, 2, 2, c, "Total for {0}");
			}

			// done, autosize columns to finish
			_flex.AutoSizeCols();
		}

		private void _chk_CheckedChanged(object sender, System.EventArgs e)
		{
			// set subtotal position
			_flex.SubtotalPosition = (_chkAbove.Checked)
				? SubtotalPositionEnum.AboveData
				: SubtotalPositionEnum.BelowData;

			// and update totals
			UpdateTotals();
		}

		private void _btnPrint_Click(object sender, System.EventArgs e)
		{
			PrintDocument pd = _flex.PrintParameters.PrintDocument;
			pd.DefaultPageSettings.Landscape = true;
			Margins m = pd.DefaultPageSettings.Margins;
			m.Left = 25;
			m.Right = 25;
			m.Top = 25;
			m.Bottom = 25;
			_flex.PrintGrid("Subtotals", 
				PrintGridFlags.ShowPreviewDialog |
				PrintGridFlags.FitToPage);
		}
	}
}
