using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using C1.Win.C1FlexGrid;

namespace RTFGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:23;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(552, 325);
			this._flex.TabIndex = 0;
			this._flex.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: RTF in cells";
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

		void Form1_Load(object sender, System.EventArgs e)
		{
			// set up grid
			_flex.AutoResize = false;
			_flex.AllowResizing = AllowResizingEnum.Both;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.Rows.DefaultSize = 80;
			_flex.Rows[0].Height   = 20;
			_flex.Cols[0].Width    = 20;
			_flex.ShowCursor = true;

			// load DataSet with Employees table and RTF
            DataSet ds = new DataSet();
            ds.ReadXml(new StringReader(Properties.Resources.RtfDataSet));

            // bind grid
			_flex.DataSource = ds.Tables[0];

			// make Notes field conspicuous
			Column colNotes = _flex.Cols["Notes"];
			colNotes.Width = 5 * colNotes.WidthDisplay;
			_flex.Cols.Move(colNotes.Index, 3);

            // use RTF class to edit values in the "Notes" column
            colNotes.Editor = new RTF();

			// use a different backcolor
            colNotes.StyleNew.BackColor = Color.LightGoldenrodYellow;
			_flex.Styles.Normal.BackColor = Color.Bisque;
		}

        // use this RTF control to render RTF cells
		RTF _rtf = new RTF();
		void _flex_OwnerDrawCell(object sender, C1.Win.C1FlexGrid.OwnerDrawCellEventArgs e)
		{
			// check whether the cell contains RTF
			string rtfText = _flex.GetDataDisplay(e.Row, e.Col);
			if (rtfText.StartsWith(@"{\rtf"))
			{
				// it does, so draw background
				e.DrawCell(DrawCellFlags.Background);
				
				// draw the RTF text
				if (e.Bounds.Width > 0 && e.Bounds.Height > 0)
				{
					_rtf.Rtf = rtfText;
					_rtf.ForeColor = e.Style.ForeColor;
					_rtf.BackColor = e.Style.BackColor;
					_rtf.Render(e.Graphics, e.Bounds);
				}

				// and draw border last
				e.DrawCell(DrawCellFlags.Border);

				// we're done with this cell
				e.Handled = true;
			}
		}
	}
}
