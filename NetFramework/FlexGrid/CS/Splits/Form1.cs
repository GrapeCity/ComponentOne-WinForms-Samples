using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;

namespace Splits
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private C1.Win.FlexGrid.C1FlexGrid _flexTL;
		private System.Windows.Forms.Splitter _splitterTop;
		private C1.Win.FlexGrid.C1FlexGrid _flexTR;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.FlexGrid.C1FlexGrid _flexBR;
		private System.Windows.Forms.Splitter _splitterBottom;
		private C1.Win.FlexGrid.C1FlexGrid _flexBL;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter3;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this._flexTR = new C1.Win.FlexGrid.C1FlexGrid();
			this._splitterTop = new System.Windows.Forms.Splitter();
			this._flexTL = new C1.Win.FlexGrid.C1FlexGrid();
			this.panel2 = new System.Windows.Forms.Panel();
			this._flexBR = new C1.Win.FlexGrid.C1FlexGrid();
			this._splitterBottom = new System.Windows.Forms.Splitter();
			this._flexBL = new C1.Win.FlexGrid.C1FlexGrid();
			this.panel3 = new System.Windows.Forms.Panel();
			this.splitter3 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._flexTR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexTL)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._flexBR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexBL)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this._flexTR,
																				 this._splitterTop,
																				 this._flexTL});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(532, 152);
			this.panel1.TabIndex = 0;
			// 
			// _flexTR
			// 
			this._flexTR.BackColor = System.Drawing.SystemColors.Window;
			this._flexTR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this._flexTR.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexTR.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flexTR.Location = new System.Drawing.Point(182, 0);
			this._flexTR.Name = "_flexTR";
			this._flexTR.Size = new System.Drawing.Size(350, 152);
			this._flexTR.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexTR.TabIndex = 2;
			this._flexTR.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
			// 
			// _splitterTop
			// 
			this._splitterTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this._splitterTop.Location = new System.Drawing.Point(176, 0);
			this._splitterTop.Name = "_splitterTop";
			this._splitterTop.Size = new System.Drawing.Size(6, 152);
			this._splitterTop.TabIndex = 1;
			this._splitterTop.TabStop = false;
			this._splitterTop.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this._splitterTop_SplitterMoved);
			// 
			// _flexTL
			// 
			this._flexTL.BackColor = System.Drawing.SystemColors.Window;
			this._flexTL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this._flexTL.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexTL.Dock = System.Windows.Forms.DockStyle.Left;
			this._flexTL.Name = "_flexTL";
			this._flexTL.Size = new System.Drawing.Size(176, 152);
			this._flexTL.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexTL.TabIndex = 0;
			this._flexTL.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
			// 
			// panel2
			// 
			this.panel2.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this._flexBR,
																				 this._splitterBottom,
																				 this._flexBL});
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 158);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(532, 211);
			this.panel2.TabIndex = 0;
			// 
			// _flexBR
			// 
			this._flexBR.BackColor = System.Drawing.SystemColors.Window;
			this._flexBR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this._flexBR.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexBR.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flexBR.Location = new System.Drawing.Point(182, 0);
			this._flexBR.Name = "_flexBR";
			this._flexBR.Size = new System.Drawing.Size(350, 211);
			this._flexBR.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexBR.TabIndex = 2;
			this._flexBR.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
			// 
			// _splitterBottom
			// 
			this._splitterBottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this._splitterBottom.Location = new System.Drawing.Point(176, 0);
			this._splitterBottom.Name = "_splitterBottom";
			this._splitterBottom.Size = new System.Drawing.Size(6, 211);
			this._splitterBottom.TabIndex = 1;
			this._splitterBottom.TabStop = false;
			this._splitterBottom.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this._splitterBottom_SplitterMoved);
			// 
			// _flexBL
			// 
			this._flexBL.BackColor = System.Drawing.SystemColors.Window;
			this._flexBL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
			this._flexBL.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flexBL.Dock = System.Windows.Forms.DockStyle.Left;
			this._flexBL.Name = "_flexBL";
			this._flexBL.Size = new System.Drawing.Size(176, 211);
			this._flexBL.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flexBL.TabIndex = 0;
			this._flexBL.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.panel2,
																				 this.splitter3,
																				 this.panel1});
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(536, 373);
			this.panel3.TabIndex = 1;
			// 
			// splitter3
			// 
			this.splitter3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter3.Location = new System.Drawing.Point(0, 152);
			this.splitter3.Name = "splitter3";
			this.splitter3.Size = new System.Drawing.Size(532, 6);
			this.splitter3.TabIndex = 1;
			this.splitter3.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(536, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.panel3});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Splits";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._flexTR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexTL)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._flexBR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexBL)).EndInit();
			this.panel3.ResumeLayout(false);
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

		// set up the splits
		void Form1_Load(object sender, System.EventArgs e)
		{
			// bind subordinate splits to 'master' split
			// (all subordinate splits use master as a DataSource)
			_flexBL.DataSource = 
			_flexBR.DataSource = 
			_flexTR.DataSource = _flexTL;

			// adjust scrollbars
			_flexTL.ScrollBars = ScrollBars.None;
			_flexTR.ScrollBars = ScrollBars.Vertical;
			_flexBL.ScrollBars = ScrollBars.Horizontal;
			_flexBR.ScrollBars = ScrollBars.Both;

			// cosmetic
			_flexTL.Cols[0].Width = _flexTL.Rows[0].HeightDisplay;
			_flexTL.ShowCursor = _flexTR.ShowCursor = _flexBL.ShowCursor = _flexBR.ShowCursor = true;

			// bind main grid to a data source
			string conn = GetConnectionString();
			string rs = "select * from Customers;";
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flexTL.DataSource = dt;
		}

		// keep vertical splitters in synch
		void _splitterTop_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			_flexBL.Width = _flexTL.Width;
		}
		void _splitterBottom_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			_flexTL.Width = _flexBL.Width;
		}

		// synchronize grid scrolling
		bool _synchronizing = false;
		void _flex_AfterScroll(object sender, C1.Win.FlexGrid.RangeEventArgs e)
		{
			if (!_synchronizing)
			{
				// avoid reentrant calls
				_synchronizing = true;

				// get new scrollposition for sender control
				C1FlexGrid src = sender as C1FlexGrid;
				src.Update();
				Point pt = src.ScrollPosition;

				// apply to others
				if (src.Equals(this._flexTL))
				{
					_flexTR.ScrollPosition = new Point(_flexTR.ScrollPosition.X, pt.Y);
					_flexBL.ScrollPosition = new Point(pt.X, _flexBL.ScrollPosition.Y);
				}
				else if (src.Equals(this._flexTR))
				{
					_flexTL.ScrollPosition = new Point(_flexTL.ScrollPosition.X, pt.Y);
					_flexBR.ScrollPosition = new Point(pt.X, _flexBR.ScrollPosition.Y);
				}
				else if (src.Equals(this._flexBL))
				{
					_flexTL.ScrollPosition = new Point(pt.X, _flexTL.ScrollPosition.Y);
					_flexBR.ScrollPosition = new Point(_flexBR.ScrollPosition.X, pt.Y);
				}
				else if (src.Equals(this._flexBR))
				{
					_flexBL.ScrollPosition = new Point(_flexBL.ScrollPosition.X, pt.Y);
					_flexTR.ScrollPosition = new Point(pt.X, _flexTR.ScrollPosition.Y);
				}

				// done
				_synchronizing = false;
			}
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
