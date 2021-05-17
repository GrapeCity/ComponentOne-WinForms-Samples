using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CustomMerge
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
	{
		//private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private FlexSchedule _flex;

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
            this._flex = new CustomMerge.FlexSchedule();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:33;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(431, 231);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(431, 231);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Merging";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// don't change the TV schedule
			_flex.AllowEditing = false;
			_flex.AllowDragging = AllowDraggingEnum.None;
			_flex.AllowResizing = AllowResizingEnum.None;

			// create header row (weekdays)
			_flex.Cols.Count = 8;
			_flex.Rows.Count = 0;
			_flex.AddItem("\tMonday\tTuesday\tWednesday\tThursday\tFriday\tSaturday\tSunday");
			_flex.Rows.Fixed = 1;

			// add the schedule
			_flex.AddItem("12:00\tWalker\tMorning Show\tMorning Show\tSport\tWeather\tN/A\tN/A");
			_flex.AddItem("13:00\tToday Show\tToday Show\tSesame Street\tFootball\tMarket Watch\tN/A\tN/A");
			_flex.AddItem("14:00\tToday Show\tToday Show\tKid Zone\tFootball\tSoap Opera\tN/A\tN/A");
			_flex.AddItem("15:00\tNews\tNews\tNews\tNews\tNews\tN/A\tN/A");
			_flex.AddItem("16:00\tNews\tNews\tNews\tNews\tNews\tN/A\tN/A");

			// add some formatting
			_flex.Styles.Normal.Border.Style = BorderStyleEnum.Double;
			_flex.Styles.Normal.TextAlign = TextAlignEnum.CenterCenter;
			_flex.Cols[0].Width = 50;
			_flex.Rows.MinSize = 40;
			for (int i = 1; i < _flex.Cols.Count; i++)
				_flex.Cols[i].Width = 100;

			// allow merging (that's the whole point)
			_flex.AllowMerging = AllowMergingEnum.Free;
			for (int i = 1; i < _flex.Cols.Count; i++)
				_flex.Cols[i].AllowMerging = true;
			for (int i = 1; i < _flex.Rows.Count; i++)
				_flex.Rows[i].AllowMerging = true;
		}
	}

	/// <summary>
	/// FlexSchedule
	/// 
	/// Inherits from C1FlexGrid and implements custom cell merging by
	/// overriding the GetMergedRange virtual method.
	/// 
	/// The control calls this function internally, to determine row
	/// and column spans.
	/// 
	/// Note: This is a critical function. It should be as fast as 
	/// possible, and always return consistent ranges. Otherwise the 
	/// control will slow down or paint in really strange ways.
	/// 
	/// </summary>
	public class FlexSchedule : C1.Win.FlexGrid.C1FlexGrid
	{
		override public CellRange GetMergedRange(int row, int col, bool clip)
		{
			// create basic cell range
			CellRange rg = GetCellRange(row, col);

			// expand left/right
			int i;
			int cnt = Cols.Count;
			int ifx = Cols.Fixed;
			for (i = rg.c1; i < cnt-1; i++)
			{
				if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i+1)) break;
				rg.c2 = i+1;
			}
			for (i = rg.c1; i > ifx; i--)
			{
				if (GetDataDisplay(rg.r1, i) != GetDataDisplay(rg.r1, i-1)) break;
				rg.c1 = i-1;
			}

			// expand up/down
			cnt = Rows.Count;
			ifx = Rows.Fixed;
			for (i = rg.r1; i < cnt-1; i++)
			{
				if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i+1, rg.c1)) break;
				rg.r2 = i+1;
			}
			for (i = rg.r1; i > ifx; i--)
			{
				if (GetDataDisplay(i, rg.c1) != GetDataDisplay(i-1, rg.c1)) break;
				rg.r1 = i-1;
			}

			// done
			return rg;
		}
	}
}