using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CustomDataMap
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
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:33;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(292, 273);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	EmptyRegion{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	");
			this._flex.TabIndex = 0;
			this._flex.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_BeforeEdit);
			this._flex.SetupEditor += new C1.Win.C1FlexGrid.RowColEventHandler(this._flex_SetupEditor);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Custom DataMap";
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

		enum RegionEnum
		{
			North, South, East, West
		}

		enum JobEnum
		{
			Director, Manager, Accountant, Engineer, Sales, Clerical
		}

		Hashtable _jobsPerRegion;
		ListDictionary _mapJobs;
		ListDictionary _mapRegions;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create table to select which jobs exist in each region
			_jobsPerRegion = new Hashtable();
			_jobsPerRegion.Add(RegionEnum.North, new JobEnum[] { JobEnum.Director, JobEnum.Manager, JobEnum.Accountant, JobEnum.Engineer, JobEnum.Sales, JobEnum.Clerical });
			_jobsPerRegion.Add(RegionEnum.South, new JobEnum[] { JobEnum.Manager, JobEnum.Accountant, JobEnum.Sales });
			_jobsPerRegion.Add(RegionEnum.East,  new JobEnum[] { JobEnum.Manager, JobEnum.Engineer, JobEnum.Clerical });
			_jobsPerRegion.Add(RegionEnum.West,  new JobEnum[] { JobEnum.Accountant, JobEnum.Sales, JobEnum.Clerical });

			// create DataMaps (not needed for enums, but this is a sample...)
			_mapRegions = new ListDictionary();
			foreach (RegionEnum region in Enum.GetValues(typeof(RegionEnum)))
				_mapRegions.Add(region, Enum.GetName(typeof(RegionEnum), region));

			_mapJobs = new ListDictionary();
			foreach (JobEnum job in Enum.GetValues(typeof(JobEnum)))
				_mapJobs.Add(job, Enum.GetName(typeof(JobEnum), job));

			// assign data maps to grid columns
			_flex.Cols[1].DataMap = _mapRegions;
			_flex.Cols[1].Name = _flex.Cols[1].Caption = "Region";

			_flex.Cols[2].DataMap = _mapJobs;
			_flex.Cols[2].Name = _flex.Cols[2].Caption = "Job";
		}

		private void _flex_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			// can't edit job if there's no region
            if (_flex.Cols[e.Col].Name == "Job")
            {
                if (string.IsNullOrEmpty(_flex.GetDataDisplay(e.Row, "Region")))
                {
                    e.Cancel = true;
                }
            }
		}
		private void _flex_SetupEditor(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			// before editing the job, remove items that don't apply to the current region
			if (_flex.Cols[e.Col].Name == "Job")
			{
				ComboBox cb = _flex.Editor as ComboBox;
                if (cb != null)
                {
                    // get current region
                    RegionEnum region = (RegionEnum)_flex[e.Row, "Region"];

                    // get jobs that exist for this region
                    JobEnum[] jobs = (JobEnum[])_jobsPerRegion[region];

                    // populate list with jobs that apply to the current region
                    cb.Items.Clear();
                    foreach (JobEnum job in jobs)
                    {
                        cb.Items.Add(Enum.GetName(typeof(JobEnum), job));
                    }
                }
			}
		}
	}
}
