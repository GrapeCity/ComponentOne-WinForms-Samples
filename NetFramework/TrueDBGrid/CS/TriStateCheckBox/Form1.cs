using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TriStateCheckBox
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
		private System.Windows.Forms.CheckBox checkBox1;
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
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowRowSelect = false;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(16, 24);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(460, 178);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(496, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show CheckBoxes";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(624, 214);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			int maxrows = 100;
			System.Data.DataTable dt = new System.Data.DataTable("testdatatable");

			System.Data.DataColumn dc;
			System.Data.DataRow dr;

			// row number
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.Int32");
			dc.ColumnName = "RowNum";
			dt.Columns.Add(dc);

			// set up an integer column - this will be our checkbox column
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.Int32");
			dc.ColumnName = "Integer";
			dt.Columns.Add(dc);

			// string column
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.String");
			dc.ColumnName = "String";
			dt.Columns.Add(dc);

			// date
			dc = new DataColumn();
			dc.DataType = System.Type.GetType("System.DateTime");
			dc.ColumnName = "Date";
			dt.Columns.Add(dc);

			System.Random random = new System.Random();
			for(int i = 0; i < maxrows; i++)
			{
				dr = dt.NewRow();
				dr[0] = i;
				// the "Integer" column has 3 values corresponding to the 3 states the checkbox can have
				dr[1] = (int) (random.NextDouble() * 3.0);
				dr[2] = "Row: " + i.ToString();
				dr[3] = System.DateTime.Now;
				dt.Rows.Add(dr);
			}
			this.c1TrueDBGrid1.SetDataBinding(dt, "", true);
			this.c1TrueDBGrid1.Splits[0].ExtendRightColumn = true;
		}

		// configures the "Integer" column as a tri-state checkbox
		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			C1.Win.TrueDBGrid.ValueItems items = this.c1TrueDBGrid1.Columns["Integer"].ValueItems;

			if( this.checkBox1.Checked )
			{
				// we're going to translate values - the datasource needs to hold at least 3 states
				items.Translate = true;
				// each click will cycle thru the various checkbox states
				items.CycleOnClick = true;
				// display the cell as a checkbox
				items.Presentation = C1.Win.TrueDBGrid.PresentationEnum.CheckBox;
				// now associate underlying db values with the checked state
				items.Values.Clear();
				items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("0", false)); // unchecked
				items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("1", true));  // checked
				items.Values.Add(new C1.Win.TrueDBGrid.ValueItem("2","INDETERMINATE")); // indeterminate state
			}
			else
			{
				items.Translate = false;
				items.CycleOnClick = false;
				items.Presentation = C1.Win.TrueDBGrid.PresentationEnum.Normal;
			}
            this.c1TrueDBGrid1.Refresh();
		}
	}
}
