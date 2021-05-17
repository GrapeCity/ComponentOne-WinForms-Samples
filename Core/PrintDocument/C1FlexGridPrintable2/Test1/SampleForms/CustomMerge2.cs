using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CustomMerge2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
        private CustomMergeFlex _flex;
		private System.Windows.Forms.ComboBox _cmb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox _chkRows;
		private System.Windows.Forms.CheckBox _chkCols;
		private System.Windows.Forms.CheckBox _chkCustom;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new CustomMerge2.CustomMergeFlex();
            this._cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._chkRows = new System.Windows.Forms.CheckBox();
            this._chkCols = new System.Windows.Forms.CheckBox();
            this._chkCustom = new System.Windows.Forms.CheckBox();
            this._btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.AllowFreezing = C1.Win.FlexGrid.AllowFreezingEnum.Both;
            this._flex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this._flex.CustomMerging = false;
            this._flex.Location = new System.Drawing.Point(8, 40);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(529, 257);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // _cmb
            // 
            this._cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmb.Location = new System.Drawing.Point(88, 8);
            this._cmb.Name = "_cmb";
            this._cmb.Size = new System.Drawing.Size(112, 21);
            this._cmb.TabIndex = 1;
            this._cmb.SelectedIndexChanged += new System.EventHandler(this._cmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "AllowMerging";
            // 
            // _chkRows
            // 
            this._chkRows.Checked = true;
            this._chkRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkRows.Location = new System.Drawing.Point(216, 6);
            this._chkRows.Name = "_chkRows";
            this._chkRows.Size = new System.Drawing.Size(56, 24);
            this._chkRows.TabIndex = 3;
            this._chkRows.Text = "&Rows";
            this._chkRows.CheckedChanged += new System.EventHandler(this._chkRowsCols_CheckedChanged);
            // 
            // _chkCols
            // 
            this._chkCols.Checked = true;
            this._chkCols.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkCols.Location = new System.Drawing.Point(280, 6);
            this._chkCols.Name = "_chkCols";
            this._chkCols.Size = new System.Drawing.Size(80, 24);
            this._chkCols.TabIndex = 3;
            this._chkCols.Text = "&Columns";
            this._chkCols.CheckedChanged += new System.EventHandler(this._chkRowsCols_CheckedChanged);
            // 
            // _chkCustom
            // 
            this._chkCustom.Location = new System.Drawing.Point(368, 6);
            this._chkCustom.Name = "_chkCustom";
            this._chkCustom.Size = new System.Drawing.Size(72, 24);
            this._chkCustom.TabIndex = 3;
            this._chkCustom.Text = "Custo&m";
            this._chkCustom.CheckedChanged += new System.EventHandler(this._chkCustom_CheckedChanged);
            // 
            // _btnPrint
            // 
            this._btnPrint.Location = new System.Drawing.Point(448, 8);
            this._btnPrint.Name = "_btnPrint";
            this._btnPrint.Size = new System.Drawing.Size(72, 24);
            this._btnPrint.TabIndex = 4;
            this._btnPrint.Text = "&Print";
            this._btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(545, 302);
            this.Controls.Add(this._btnPrint);
            this.Controls.Add(this._chkRows);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._cmb);
            this.Controls.Add(this._flex);
            this.Controls.Add(this._chkCols);
            this.Controls.Add(this._chkCustom);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Merging with override";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// set up the grid
			_flex.Rows.Count = 5;
			_flex.Rows.Fixed = 2;
			_flex.Cols.Count = 6;
			_flex.Cols.Fixed = 0;

			// populate header cells
			_flex[0,0]=_flex[1,0]="1998";
			_flex[0,1]=_flex[0,2]=_flex[0,3]=_flex[0,4]="1999";
			_flex[0,5]=_flex[1,5]="2000";
			for (int i = 1; i <= 4; i++)
				_flex[1,i] = string.Format("Q{0} 1999", i);

			// populate data cells
			foreach (Column col in _flex.Cols)
				col.DataType = typeof(string);
			_flex[2,0] = _flex[3,0] = _flex[4,0] = 100; 
			_flex[2,1] = _flex[3,1] = 100; _flex[4,1] = 1; 
			_flex[2,2] = 100; _flex[3,2] = 9; _flex[4,2] = 2; 
			_flex[2,3] = 100; _flex[3,3] = 9; _flex[4,3] = 3; 
			_flex[2,4] = 9; _flex[3,4] = 9; _flex[4,4] = 3; 
			_flex[2,5] = 9; _flex[3,5] = 9; _flex[4,5] = 5; 

			// populate combo
			foreach (AllowMergingEnum v in Enum.GetValues(typeof(AllowMergingEnum)))
				_cmb.Items.Add(v);

			// fake event to initialize
			_chkRowsCols_CheckedChanged(this, EventArgs.Empty);
		}

		private void _cmb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			_flex.AllowMerging = (AllowMergingEnum)_cmb.SelectedItem;
		}

		private void _chkRowsCols_CheckedChanged(object sender, System.EventArgs e)
		{
            foreach (Column col in _flex.Cols)
            {
                col.AllowMerging = _chkCols.Checked;
            }

            foreach (Row row in _flex.Rows)
            {
                row.AllowMerging = _chkRows.Checked;
            }
		}

		private void _chkCustom_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.CustomMerging = _chkCustom.Checked;
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
			_flex.PrintGrid("Hello", PrintGridFlags.ShowPreviewDialog);
		}
	}

	/// <summary>
	/// CustomMergeFlex
	/// Inherits from C1FlexGrid to provide custom merging logic.
	/// Set the CustomMerging to true and the grid will merge the
	/// header cells using custom logic. the default behavior is 
	/// used for the rest of the grid.
	/// </summary>
	public class CustomMergeFlex : C1FlexGrid
	{
		// ** ctor

		public CustomMergeFlex() {}

		// ** custom merging property

		protected bool _customMerging;
		public bool CustomMerging
		{
			get { return _customMerging; }
			set 
			{
				_customMerging = value;
				Invalidate();
			}
		}

		// ** override merging logic

		override public CellRange GetMergedRange(int row, int col, bool clip)
		{
			// use custom merging for fixed rows
			if (_customMerging && row < Rows.Fixed)
			{
				if (col == 0 || col == 5)
					return GetCellRange(0, col, 1, col);
				if (row == 0 && col > 0 && col < 5)
					return GetCellRange(0, 1, 0, 4);
			}

			// use default implementation
			return base.GetMergedRange(row, col, clip);
		}
	}
}
