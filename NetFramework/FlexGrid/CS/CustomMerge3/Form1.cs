using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;

// based on original sample by Mike Hoeffner.
// 
namespace CustomMergeLogic
{
	// Demonstrates how to based merging on a cell attribute other than the displayed text
	// (in this example, the UserData attribute is used).

	public class Form1 : System.Windows.Forms.Form
	{
		private CustomMergeLogic.Form1.CustomMergeFlex _flex;
		private System.Windows.Forms.CheckBox _chkCustom;
		private System.Windows.Forms.CheckBox _chkMerge;
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

			_flex.Rows.Fixed = 0;
			_flex.Cols.Fixed = 0;
			_flex.Styles.Normal.Border.Color = Color.Red;
			_flex.Styles.Normal.Border.Width = 2;
			_flex.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
			_flex.SelectionMode = SelectionModeEnum.Row;

			_flex.AllowMerging = AllowMergingEnum.RestrictCols;

			LoadFlex(false, 6, new String[] {

				"A", "A", "B", "B", "C", "C",
				"D", "D", "D", "D", "D", "D",
				"E", "E", "F", "F", "G", "G"
			});
	
			LoadFlex(true, 6, new String[] {

				"A", "A", "B", "B", "C", "C",
				"D 1", "D 1", "D 2", "D 2", "D 3", "D 3",
				"E", "E", "F", "F", "G", "G"
			});		
		}

		private void LoadFlex(bool forUserData, int colCount, String[] data)
		{
			int len = data.Length;

			for (int i = 0; i < len; i++)
			{
				int rowLoc = i / colCount;
				int colLoc = i % colCount;

				_flex.Rows[rowLoc].AllowMerging = true;
				_flex.Cols[colLoc].AllowMerging = true;

				if (forUserData)
				{
					CellRange cellRange = _flex.GetCellRange(rowLoc, colLoc);
					cellRange.UserData = data[i];
				}
				else
				{
					_flex[rowLoc, colLoc] = data[i];
				}

				if (i == len - 1)
				{
					_flex.Rows.Count = rowLoc + 1;
					_flex.Cols.Count = colLoc + 1;
				}
			}
		}

		private void _chkCustom_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.SetUseOverrides(_chkCustom.Checked);
		}
		private void _chkMerge_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.AllowMerging = (_chkMerge.Checked)
				? AllowMergingEnum.RestrictCols
				: AllowMergingEnum.None;
		}

		// based on http://www.apexsc.com/cgi-bin/dnewsweb.exe?cmd=article&group=component1.public.net.flexgrid&item=2326&utag=
		public class CustomMergeFlex : C1FlexGrid
		{
			private bool _doingMerge = false;
			private bool _useOverrides = false;

			public void SetUseOverrides(bool useOverrides)
			{
				_useOverrides = useOverrides;
				Invalidate();
			}

			public override CellRange GetMergedRange(int row, int col, bool clip)
			{
				_doingMerge = true;
				CellRange cellRange = base.GetMergedRange(row, col, clip);
				_doingMerge = false;
				return cellRange;
			}

			public override Object GetData(int row, int col)
			{
				if (_useOverrides && _doingMerge)
				{
					CellRange cellRange = GetCellRange(row, col);
					return cellRange.UserData;					
				}
				else
				{
					return base.GetData(row, col);
				}
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
			this._flex = new CustomMergeLogic.Form1.CustomMergeFlex();
			this._chkCustom = new System.Windows.Forms.CheckBox();
			this._chkMerge = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 28);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(480, 84);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _chkCustom
			// 
			this._chkCustom.Location = new System.Drawing.Point(160, 0);
			this._chkCustom.Name = "_chkCustom";
			this._chkCustom.Size = new System.Drawing.Size(132, 24);
			this._chkCustom.TabIndex = 1;
			this._chkCustom.Text = "Use Logic Overrides";
			this._chkCustom.CheckedChanged += new System.EventHandler(this._chkCustom_CheckedChanged);
			// 
			// _chkMerge
			// 
			this._chkMerge.Location = new System.Drawing.Point(8, 0);
			this._chkMerge.Name = "_chkMerge";
			this._chkMerge.Size = new System.Drawing.Size(132, 24);
			this._chkMerge.TabIndex = 1;
			this._chkMerge.Text = "Merge Cells";
			this._chkMerge.Checked = true;
			this._chkMerge.CheckedChanged += new System.EventHandler(this._chkMerge_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(500, 121);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._chkCustom,
																		  this._flex,
																		  this._chkMerge});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
