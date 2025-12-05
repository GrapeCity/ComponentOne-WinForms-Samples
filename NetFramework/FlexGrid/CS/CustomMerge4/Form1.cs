using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

// based on original sample by Mike Hoeffner.
// 
namespace CustomMergeLogic
{
	public class Form1 : System.Windows.Forms.Form
	{
		private CustomMergeLogic.Form1.CustomMergeFlex _flex;
		private System.Windows.Forms.CheckBox _chkMerge;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

			// create data table
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(string));
			dt.Columns.Add("Start", typeof(DateTime));
			dt.Columns.Add("Finish", typeof(DateTime));
			dt.Columns.Add("Description", typeof(string));
			dt.Columns.Add("Name", typeof(string));
			dt.Columns.Add("CreatedBy", typeof(string));

			// populate data table
			dt.Rows.Add(new object[] { "123123123", new DateTime(2003, 1, 1), new DateTime(2003, 1, 10), "Talk about contract", "Pedro", "Marc" });
			dt.Rows.Add(new object[] { "111111111", new DateTime(2003, 1, 1), new DateTime(2003, 1, 10), "Talk about contract", "Johnny", "Marc" });
			dt.Rows.Add(new object[] { "111111111", new DateTime(2003, 1, 1), new DateTime(2003, 1, 10), "Talk about contract", "Pedro", "Marc" });
			dt.Rows.Add(new object[] { "321321321", new DateTime(2003, 1, 1), new DateTime(2003, 1, 10), "View property", "Johnny", "Marc" });

			// assign data table to grid
			_flex.DataSource = dt;

			// initialize merging
			_flex.AllowMerging = AllowMergingEnum.Free;
            foreach (C1.Win.FlexGrid.Column c in _flex.Cols)
            {
                c.AllowMerging = true;
            }
		}

		// toggle merging
		private void _chkMerge_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.AllowMerging = _chkMerge.Checked
				? AllowMergingEnum.Free
				: AllowMergingEnum.None;
		}

		/// <summary>
		/// CustomMergeFlex
		/// derives from the C1FlexGrid to override merging logic
		/// </summary>
		[LicenseProvider(typeof(LicenseProvider))]
		public class CustomMergeFlex : C1FlexGrid
		{
			private bool _doingMerge = false;
			private int  _colIndex;

			public override CellRange GetMergedRange(int row, int col, bool clip)
			{
				// save index of ID column to use in merging logic
				_colIndex = Cols.IndexOf("ID");

				// set flag to use custom data when merging
				_doingMerge = true;

				// call base class merging logic (will retrieve data using GetData method)
				CellRange cellRange = base.GetMergedRange(row, col, clip);

				// reset flag so GetData behaves as usual
				_doingMerge = false;

				// return the merged range
				return cellRange;
			}

			public override Object GetData(int row, int col)
			{
				// getting data to determine merging range:
				// append content of ID column to avoid merging cells in rows with different IDs
                if (_doingMerge && _colIndex > -1 && col != _colIndex)
                {
                    return base.GetDataDisplay(row, col) + base.GetDataDisplay(row, _colIndex);
                }

				// getting data to display, measure, edit etc.
				// let base class handle it as usual
				return base.GetData(row, col);
			}
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new CustomMergeLogic.Form1.CustomMergeFlex();
            this._chkMerge = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this._flex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this._flex.Location = new System.Drawing.Point(17, 51);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 21;
            this._flex.Size = new System.Drawing.Size(491, 207);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // _chkMerge
            // 
            this._chkMerge.Checked = true;
            this._chkMerge.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkMerge.Location = new System.Drawing.Point(17, 0);
            this._chkMerge.Name = "_chkMerge";
            this._chkMerge.Size = new System.Drawing.Size(263, 45);
            this._chkMerge.TabIndex = 1;
            this._chkMerge.Text = "Merge Cells";
            this._chkMerge.CheckedChanged += new System.EventHandler(this._chkMerge_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(531, 271);
            this.Controls.Add(this._flex);
            this.Controls.Add(this._chkMerge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C1FlexGrid: Custom Merging Logic";
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
