using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.C1Report;
using C1.C1Report.Util;

namespace DynamicFormat
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
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
            this._c1r = new C1.C1Report.C1Report();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportName = "c1Report1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(288, 32);
			this.button1.TabIndex = 0;
			this.button1.Text = "Create Report, format with Script";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 64);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(288, 32);
			this.button2.TabIndex = 0;
			this.button2.Text = "Create Report, format with Events";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(320, 109);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this.button2});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report Demo: Dynamic Formatting";
			((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
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

		// format with script or events
		private bool _script = false;

		private void button1_Click(object sender, System.EventArgs e)
		{
			// format with script
			_script = true;
			_c1r.PrintSection -= new ReportEventHandler(_c1r_PrintSection);

			// create report
			CreateReport("Formatted with Script");

			// render it
			Cursor = Cursors.WaitCursor;
			_c1r.Render();
			Cursor = Cursors.Default;

			// and show it to the user
            C1.Win.C1Preview.C1PrintPreviewDialog ppv = new C1.Win.C1Preview.C1PrintPreviewDialog();
			ppv.Document = _c1r;
			ppv.ShowDialog();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// format with events
			_script = false;
			_c1r.PrintSection += new ReportEventHandler(_c1r_PrintSection);

			// create report
			CreateReport("Formatted with Events");

			// render it
			Cursor = Cursors.WaitCursor;
			_c1r.Render();
			Cursor = Cursors.Default;

			// and show it to the user
            C1.Win.C1Preview.C1PrintPreviewDialog ppv = new C1.Win.C1Preview.C1PrintPreviewDialog();
            ppv.Document = _c1r;
            ppv.ShowDialog();
        }

		// The PrintSection event gets fired after the fields in the section have been 
		// evaluated, and before they are rendered. it's a good place to change colors,
		// fonts, etc. based on values read from the database.
		//
        private void _c1r_PrintSection(object sender, C1.C1Report.ReportEventArgs e)
		{
			if (e.Section == SectionTypeEnum.Detail)
			{
				foreach (Field f in _c1r.Sections[SectionTypeEnum.Detail].Fields)
				{
					if (f.Value is int)
					{
						int i = (int)f.Value;

						int min = 300;
						int max = 700;

						if (i < min)	  f.ForeColor = Color.DarkRed;
						else if (i > max) f.ForeColor = Color.DarkBlue;
						else			  f.ForeColor = Color.Black;
					}
				}
			}
		}

		private void CreateReport(string reportTitle)
		{
			// clear any existing reports
			//
			_c1r.Clear();

			// set new report name
			//
			_c1r.ReportName = reportTitle;

			// initialize layout
			//
			_c1r.Layout.Orientation = OrientationEnum.Landscape;

			// create data source object and assign it to new report
			// (in this case, the DataSource is a DataView object)
			//
			DataView dv = CreateDataSource(8, 200);
			_c1r.DataSource.Recordset = dv;

			// add a group 
			// (sort data by region)
			//
			_c1r.Groups.Add("Region Group", "Region", SortEnum.Ascending);

			// initialize group header section
			//
			Section ghdr = _c1r.Sections[SectionTypeEnum.GroupHeader1];
			ghdr.Height = 600;					// twips
			ghdr.Visible = true;				// make new section visible
			ghdr.BackColor = Color.DarkBlue;	// give section a solid background
			ghdr.Repeat = true;					// repeat after page breaks

			// add group header fields
			//
			_c1r.Font = new Font("Arial", 12, FontStyle.Bold);
			Field f = ghdr.Fields.Add("grpHdr", "Region & \" Region Data\"", new Rectangle(50,0,4000,600));
			f.Calculated = true;
			f.ForeColor = Color.White;
			f.Align = FieldAlignEnum.LeftBottom;

			// initialize page header section
			//
			Section shdr = _c1r.Sections[SectionTypeEnum.PageHeader];
			shdr.Height = 1200;					// twips
			shdr.Visible = true;				// make new section visible

			// add page header fields
			//

			// report title
			_c1r.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
			shdr.Fields.Add("rptName", _c1r.ReportName, new Rectangle(0,0,8000,400));

			// page number
			_c1r.Font = new Font("Arial", 9, FontStyle.Bold);
			f = shdr.Fields.Add("pgNum", "\"Page \" & Page", new Rectangle(9000,0,1000,300));
			f.Calculated = true;

			// initialize detail section
			//
			Section sdtl = _c1r.Sections[SectionTypeEnum.Detail];
			sdtl.Height = 300;
			sdtl.Visible = true;

			// initialize script
			// (data values are between 100 and 1000)
			//
			string script = "", scriptFmt = "";
			if (_script)
			{
				script = "MinVal = 300\nMaxVal = 700\n";
				scriptFmt = 
					"{0}.ForeColor = rgb(50,0,0)\n" + 
					"if {0}.Value < MinVal then {0}.ForeColor = rgb(150,0,0)\n" + 
					"if {0}.Value > MaxVal then {0}.ForeColor = rgb(0,150,0)\n";
			}

			// create report fields
			//
			int fldCtr   = 0;
			Rectangle rc = new Rectangle(0, 0, 1000, 300);
			foreach (DataColumn col in dv.Table.Columns)
			{
				// add page header labels
				rc.Height = (int)shdr.Height;
				_c1r.Font = new Font("Arial", 10, FontStyle.Bold);
				f = shdr.Fields.Add(col.ColumnName + "Hdr", col.ColumnName, rc);
				f.Calculated = false;
				f.ForeColor = Color.LightGray;
				f.Align = (col.DataType == typeof(int))
					? FieldAlignEnum.RightBottom
					: FieldAlignEnum.LeftBottom;

				// add detail field (note square brackets since field names have spaces)
				rc.Height = (int)sdtl.Height;
				_c1r.Font = new Font("Arial", 9);
				string fldName = string.Format("fld{0}", fldCtr++);
				f = sdtl.Fields.Add(fldName, "[" + col.ColumnName + "]", rc);
				f.Calculated = true;

				// if this field is numeric, add script
				if (_script)
				{
					if (col.DataType == typeof(int))
						script += string.Format(scriptFmt, fldName);
				}

				// move on to the next field
				rc.Offset(rc.Width, 0);
			}

			// assign script to detail section OnPrint event
			// (after fields have been evaluated)
			//
			if (_script)
				sdtl.OnPrint = script;

			// save report definition (for debugging only)
			//
			// _c1r.Save(@"c:\test.xml");
		}

		// create data source for the report
		private DataView CreateDataSource(int cols, int rows)
		{
			// create table
			DataTable dt = new DataTable("test");

			// add region column
			dt.Columns.Add("Region", typeof(string));

			// add data columns
			for (int c = 1; c < cols; c++)
				dt.Columns.Add("Col " + c.ToString(), typeof(int));

			// add rows
			Random rnd = new Random();
			string[] region = { "North", "South", "East", "West" };
			object[] values = (object[])Array.CreateInstance(typeof(object), cols);
			for (int r = 0; r < rows; r++)
			{
				values[0] = region[rnd.Next(3)];
				for (int c = 1; c < cols; c++)
					values[c] = rnd.Next(100, 1000);
				dt.Rows.Add(values);
			}

			// done
			return dt.DefaultView;
		}
	}
}
