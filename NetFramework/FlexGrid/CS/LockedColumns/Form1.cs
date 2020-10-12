using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.C1FlexGrid;

namespace LockedColumns
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Label label2;
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
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.Size = new System.Drawing.Size(600, 325);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.BeforeSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this._flex_BeforeSelChange);
			this._flex.BeforeDoubleClick += new C1.Win.C1FlexGrid.BeforeMouseDownEventHandler(this._flex_BeforeDoubleClick);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 288);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 16);
			this.label2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(600, 325);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this.label2});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Lock columns to prevent selection";
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

		// list of locked (non-selectable) columns
		ArrayList _lockedCols = new ArrayList();

		// set up the grid
		void Form1_Load(object sender, System.EventArgs e)
		{
			// add some data to the grid
			string sql = "select * from products";
			string conn = GetConnectionString();
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flex.DataSource = dt;

			// lock some columns
			_lockedCols.Add(2);
			_lockedCols.Add(5);
			_lockedCols.Add(6);

			// show that they're locked
			CellStyle locked = _flex.Styles.Add("locked");
			locked.BackColor = Color.Beige;
			foreach (int c in _lockedCols)
				_flex.Cols[c].Style = locked;
			_flex.Cols[0].Width = 20;
		}

		// prevent selecting the locked columns
		void _flex_BeforeSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			// check if the new selection contains any bad columns
			int badCol = -1;
			for (int c = e.NewRange.LeftCol; c <= e.NewRange.RightCol; c++)
			{
				if (_lockedCols.Contains(c))
				{
					badCol = c;
					break;
				}
			}

			// if so, cancel the selection and skip over the locked columns
			if (badCol > -1)
			{
				// cancel the selection
				e.Cancel = true;

				// try skipping over to the right
				if (_flex.Col < badCol)
				{
					for (int c = badCol + 1; c < _flex.Cols.Count; c++)
					{
						if (!_lockedCols.Contains(c))
						{
							_flex.Select(e.NewRange.TopRow, c);
							break;
						}
					}
					return;
				}

				// try skipping to the left
				if (_flex.Col > badCol)
				{
					for (int c = badCol - 1; c >= _flex.Cols.Fixed; c--)
					{
						if (!_lockedCols.Contains(c))
						{
							_flex.Select(e.NewRange.TopRow, c);
							break;
						}
					}
					return;
				}
			}
		}

		// prevent editing the locked columns as well
		void _flex_BeforeDoubleClick(object sender, C1.Win.C1FlexGrid.BeforeMouseDownEventArgs e)
		{
			if (_lockedCols.Contains(_flex.MouseCol))
			{
				e.Cancel = true;
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
