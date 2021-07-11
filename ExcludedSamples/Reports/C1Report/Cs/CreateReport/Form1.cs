using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;

using C1.C1Report;
using C1.Win.C1Preview;

namespace CreateReport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Button btnCustomers;
		internal System.Windows.Forms.Button btnEmployees;
		internal System.Windows.Forms.Button btnSave;
		internal System.Windows.Forms.Panel Panel1;
		internal C1.Win.C1Preview.C1PreviewPane _ppv;
		internal System.Windows.Forms.ToolBar _toolBar;
		internal System.Windows.Forms.ToolBarButton tbbtnFirst;
		internal System.Windows.Forms.ToolBarButton tbbtnPrev;
		internal System.Windows.Forms.ToolBarButton tbbtnNext;
		internal System.Windows.Forms.ToolBarButton tbbtnLast;
		internal System.Windows.Forms.ToolBarButton tbbtnSep;
		internal System.Windows.Forms.ToolBarButton tbbtnZoom;
		internal System.Windows.Forms.CheckBox chkGroup;
		internal System.Windows.Forms.Button _btnCustomers;
		internal System.Windows.Forms.Button _btnEmployees;
		internal System.Windows.Forms.Button _btnSave;
		internal System.Windows.Forms.ContextMenu mnuZoom;
		internal System.Windows.Forms.MenuItem _mz100;
		internal System.Windows.Forms.MenuItem _mzPage;
		internal System.Windows.Forms.MenuItem _mzTwoPages;
		internal System.Windows.Forms.MenuItem _mzThumbnails;
		private C1.C1Report.C1Report c1r;
		internal System.Windows.Forms.StatusBar status;
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
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this._ppv = new C1.Win.C1Preview.C1PreviewPane();
            this._toolBar = new System.Windows.Forms.ToolBar();
            this.tbbtnFirst = new System.Windows.Forms.ToolBarButton();
            this.tbbtnPrev = new System.Windows.Forms.ToolBarButton();
            this.tbbtnNext = new System.Windows.Forms.ToolBarButton();
            this.tbbtnLast = new System.Windows.Forms.ToolBarButton();
            this.tbbtnSep = new System.Windows.Forms.ToolBarButton();
            this.tbbtnZoom = new System.Windows.Forms.ToolBarButton();
            this.mnuZoom = new System.Windows.Forms.ContextMenu();
            this._mz100 = new System.Windows.Forms.MenuItem();
            this._mzPage = new System.Windows.Forms.MenuItem();
            this._mzTwoPages = new System.Windows.Forms.MenuItem();
            this._mzThumbnails = new System.Windows.Forms.MenuItem();
            this.chkGroup = new System.Windows.Forms.CheckBox();
            this._btnCustomers = new System.Windows.Forms.Button();
            this._btnEmployees = new System.Windows.Forms.Button();
            this._btnSave = new System.Windows.Forms.Button();
            this.c1r = new C1.C1Report.C1Report();
            this.status = new System.Windows.Forms.StatusBar();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(26, -64);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(80, 29);
            this.btnCustomers.TabIndex = 7;
            this.btnCustomers.Text = "Customers";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(-62, -64);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(80, 29);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "Employees";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, -64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel1.Controls.Add(this._ppv);
            this.Panel1.Controls.Add(this._toolBar);
            this.Panel1.Location = new System.Drawing.Point(8, 40);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(489, 351);
            this.Panel1.TabIndex = 8;
            // 
            // _ppv
            // 
            this._ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppv.Location = new System.Drawing.Point(0, 36);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(485, 311);
            this._ppv.TabIndex = 6;
            this._ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize;
            // 
            // _toolBar
            // 
            this._toolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbbtnFirst,
            this.tbbtnPrev,
            this.tbbtnNext,
            this.tbbtnLast,
            this.tbbtnSep,
            this.tbbtnZoom});
            this._toolBar.ButtonSize = new System.Drawing.Size(0, 22);
            this._toolBar.DropDownArrows = true;
            this._toolBar.Location = new System.Drawing.Point(0, 0);
            this._toolBar.Name = "_toolBar";
            this._toolBar.ShowToolTips = true;
            this._toolBar.Size = new System.Drawing.Size(485, 36);
            this._toolBar.TabIndex = 5;
            this._toolBar.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this._toolBar.Wrappable = false;
            this._toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._toolBar_ButtonClick);
            // 
            // tbbtnFirst
            // 
            this.tbbtnFirst.Name = "tbbtnFirst";
            this.tbbtnFirst.Text = "<<";
            // 
            // tbbtnPrev
            // 
            this.tbbtnPrev.Name = "tbbtnPrev";
            this.tbbtnPrev.Text = "<";
            // 
            // tbbtnNext
            // 
            this.tbbtnNext.Name = "tbbtnNext";
            this.tbbtnNext.Text = ">";
            // 
            // tbbtnLast
            // 
            this.tbbtnLast.Name = "tbbtnLast";
            this.tbbtnLast.Text = ">>";
            // 
            // tbbtnSep
            // 
            this.tbbtnSep.Name = "tbbtnSep";
            this.tbbtnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbbtnZoom
            // 
            this.tbbtnZoom.DropDownMenu = this.mnuZoom;
            this.tbbtnZoom.Name = "tbbtnZoom";
            this.tbbtnZoom.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this.tbbtnZoom.Text = "Zoom";
            // 
            // mnuZoom
            // 
            this.mnuZoom.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._mz100,
            this._mzPage,
            this._mzTwoPages,
            this._mzThumbnails});
            // 
            // _mz100
            // 
            this._mz100.Index = 0;
            this._mz100.Text = "100%";
            this._mz100.Click += new System.EventHandler(this._zoom_Click);
            // 
            // _mzPage
            // 
            this._mzPage.Index = 1;
            this._mzPage.Text = "Full Page";
            this._mzPage.Click += new System.EventHandler(this._zoom_Click);
            // 
            // _mzTwoPages
            // 
            this._mzTwoPages.Index = 2;
            this._mzTwoPages.Text = "Two Pages";
            this._mzTwoPages.Click += new System.EventHandler(this._zoom_Click);
            // 
            // _mzThumbnails
            // 
            this._mzThumbnails.Index = 3;
            this._mzThumbnails.Text = "Thumbnails";
            this._mzThumbnails.Click += new System.EventHandler(this._zoom_Click);
            // 
            // chkGroup
            // 
            this.chkGroup.Location = new System.Drawing.Point(200, 12);
            this.chkGroup.Name = "chkGroup";
            this.chkGroup.Size = new System.Drawing.Size(96, 16);
            this.chkGroup.TabIndex = 12;
            this.chkGroup.Text = "Add Groups";
            // 
            // _btnCustomers
            // 
            this._btnCustomers.Location = new System.Drawing.Point(96, 8);
            this._btnCustomers.Name = "_btnCustomers";
            this._btnCustomers.Size = new System.Drawing.Size(80, 24);
            this._btnCustomers.TabIndex = 11;
            this._btnCustomers.Text = "Customers";
            this._btnCustomers.Click += new System.EventHandler(this._btnCustomers_Click);
            // 
            // _btnEmployees
            // 
            this._btnEmployees.Location = new System.Drawing.Point(8, 8);
            this._btnEmployees.Name = "_btnEmployees";
            this._btnEmployees.Size = new System.Drawing.Size(80, 24);
            this._btnEmployees.TabIndex = 9;
            this._btnEmployees.Text = "Employees";
            this._btnEmployees.Click += new System.EventHandler(this._btnEmployees_Click);
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(304, 8);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(80, 24);
            this._btnSave.TabIndex = 10;
            this._btnSave.Text = "Save";
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // c1r
            // 
            this.c1r.ReportDefinition = resources.GetString("c1r.ReportDefinition");
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(0, 398);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(505, 22);
            this.status.TabIndex = 13;
            this.status.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(505, 420);
            this.Controls.Add(this.status);
            this.Controls.Add(this.chkGroup);
            this.Controls.Add(this._btnCustomers);
            this.Controls.Add(this._btnEmployees);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: On-the-fly Reports";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1r)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private void RenderEmployees()
		{
			Field f;

			// prevent reentrant calls
			if (c1r.IsBusy) return;

			// initialize control
			c1r.Clear();                // clear any existing fields
			c1r.Font.Name = "Tahoma";   // set default font for all controls
			c1r.Font.Size = 9;
			c1r.ReportName = "Employees";

			// initialize DataSource
			DataSource ds = c1r.DataSource;
            ds.ConnectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb";
			ds.RecordSource = "Employees";

			// initialize Layout
			Layout l = c1r.Layout;
			l.Orientation = OrientationEnum.Portrait;
			l.Width = 6.5 * 1440; // 8.5 - margins

			// create a report header
			Section s = c1r.Sections[SectionTypeEnum.Header];
			s.Height = 1440;
			s.Visible = true;
			s.BackColor = Color.FromArgb(200, 200, 200);
			f = s.Fields.Add("FldTitle", "Employees Report", 0, 0, 8000, 1440);
			f.Font.Size = 24;
			f.Font.Bold = true;
			f.ForeColor = Color.FromArgb(0, 0, 100);

			// create a page footer
			s = c1r.Sections[SectionTypeEnum.PageFooter];
			s.Height = 500;
			s.Visible = true;
			f = s.Fields.Add("FldFtrLeft", @"""Employees: Printed on "" & Now", 0, 0, 4000, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldFtrRight", @"""Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300);
			f.Calculated = true;
			f.Align = FieldAlignEnum.RightTop;
			f.Width = c1r.Layout.Width - f.Left;
			f = s.Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20);
			f.LineSlant = LineSlantEnum.NoSlant;
			f.BorderStyle = BorderStyleEnum.Solid;
			f.BorderColor = Color.FromArgb(0, 0, 100);

			// create a page header with field labels
			s = c1r.Sections[SectionTypeEnum.PageHeader];
			s.Height = 500;
			s.Visible = true;
			c1r.Font.Bold = true;
			f = s.Fields.Add("LblID", "ID", 0, 50, 400, 300);
			f.Align = FieldAlignEnum.RightTop;
			f = s.Fields.Add("LblFirstName", "First", 500, 50, 900, 300);
			f = s.Fields.Add("LblLastName", "Last", 1500, 50, 900, 300);
			f = s.Fields.Add("LblTitle", "Title", 2500, 50, 2400, 300);
			f = s.Fields.Add("LblTitle", "Notes", 5000, 50, 8000, 300);
			c1r.Font.Bold = false;
			f = s.Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20);
			f.LineSlant = LineSlantEnum.NoSlant;
			f.LineWidth = 50;
			f.BorderStyle = BorderStyleEnum.Solid;
			f.BorderColor = Color.FromArgb(100, 100, 100);

			// create the detail section
			s = c1r.Sections[SectionTypeEnum.Detail];
			s.Height = 330;
			s.Visible = true;
			f = s.Fields.Add("FldID", "EmployeeID", 0, 0, 400, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldFirstName", "FirstName", 500, 0, 900, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldLastName", "LastName", 1500, 0, 900, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldTitle", "Title", 2500, 0, 2400, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldNotes", "Notes", 5000, 0, 8000, 300);
			f.Width = c1r.Layout.Width - f.Left;
			f.Calculated = true;
			f.CanGrow = true;
			f.Font.Size = 6;
			f.Align = FieldAlignEnum.JustTop;
			f = s.Fields.Add("FldLine", "", 0, 310, c1r.Layout.Width, 20);
			f.LineSlant = LineSlantEnum.NoSlant;
			f.BorderStyle = BorderStyleEnum.Solid;
			f.BorderColor = Color.FromArgb(100, 100, 100);

			if (chkGroup.Checked)
			{
				// group employees by country, in ascending order
				Group grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending);
				s = grp.SectionHeader;
				s.Height = 500;
				s.Visible = true;
				f = s.Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500);
				f.Calculated = true;
				f.Align = FieldAlignEnum.LeftMiddle;
				f.Font.Bold = true;
				f.Font.Size = 12;
				f.BorderStyle = BorderStyleEnum.Solid;
				f.BorderColor = Color.FromArgb(0, 0, 150);
				f.BackStyle = BackStyleEnum.Opaque;
				f.BackColor = Color.FromArgb(150, 150, 220);
				f.MarginLeft = 100;

				// sort employees by first name within each country
				c1r.Groups.Add("GrpName", "FirstName", SortEnum.Ascending);
			}

			// render the report into the PrintPreviewControl
			_ppv.Document = c1r;
            // _ppv.InvalidatePreview(); -- no need to render if shown in C1 preview control
		}

		private void RenderCustomers()
		{
			Field f;

			// prevent reentrant calls
			if (c1r.IsBusy) return;

			// initialize control
			c1r.Clear();                 // clear any existing fields
			c1r.Font.Name = "Tahoma";    // set default font for all controls
			c1r.Font.Size = 8;
			c1r.ReportName = "Customers";

			// initialize DataSource
			DataSource ds = c1r.DataSource;
            ds.ConnectionString =
                @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\c1nwind.mdb";
			ds.RecordSource = "Customers";

			// initialize Layout
			Layout l = c1r.Layout;
			l.Orientation = OrientationEnum.Portrait;
			l.Width = 6.5 * 1440; // 8.5 - margins

			// create a report header
			Section s = c1r.Sections[SectionTypeEnum.Header];
			s.Height = 1440;
			s.Visible = true;
			s.BackColor = Color.FromArgb(200, 200, 200);
			f = s.Fields.Add("FldTitle", "Customer Report", 0, 0, 8000, 1440);
			f.Font.Size = 24;
			f.Font.Bold = true;
			f.ForeColor = Color.FromArgb(100, 0, 0);

			// create a page footer
			s = c1r.Sections[SectionTypeEnum.PageFooter];
			s.Height = 500;
			s.Visible = true;
			f = s.Fields.Add("FldFtrLeft", @"""Customers: Printed on "" & Now", 0, 0, 4000, 300);
			f.Calculated = true;
			f = s.Fields.Add("FldFtrRight", @"""Page "" & Page & "" of "" & Pages", 4000, 0, 4000, 300);
			f.Calculated = true;
			f.Align = FieldAlignEnum.RightTop;
			f.Width = c1r.Layout.Width - f.Left;
			f = s.Fields.Add("FldLine", "", 0, 0, c1r.Layout.Width, 20);
			f.LineSlant = LineSlantEnum.NoSlant;
			f.BorderStyle = BorderStyleEnum.Solid;
			f.BorderColor = Color.FromArgb(0, 0, 100);

			// create a page header with field labels
			s = c1r.Sections[SectionTypeEnum.PageHeader];
			s.Height = 500;
			s.Visible = true;
			c1r.Font.Bold = true;
			f = s.Fields.Add("LblID", "Company", 0, 100, 3400, 300);
			f = s.Fields.Add("LblFirstName", "Contact", 3500, 100, 1900, 300);
			f = s.Fields.Add("LblFirstName", "Contact Title", 5500, 100, 1900, 300);
			f = s.Fields.Add("LblLastName", "Phone", 7500, 100, 1200, 300);
			c1r.Font.Bold = false;
			f = s.Fields.Add("FldLine", "", 0, 400, c1r.Layout.Width, 20);
			f.LineSlant = LineSlantEnum.NoSlant;
			f.LineWidth = 50;
			f.BorderStyle = BorderStyleEnum.Solid;
			f.BorderColor = Color.FromArgb(100, 100, 100);

			// create the detail section
			s = c1r.Sections[SectionTypeEnum.Detail];
			s.Height = 250;
			s.Visible = true;
			f = s.Fields.Add("FldID", "CompanyName", 0, 0, 3400, 250);
			f.Calculated = true;
			f = s.Fields.Add("FldFirstName", "ContactName", 3500, 0, 1900, 250);
			f.Calculated = true;
			f = s.Fields.Add("FldFirstName", "ContactTitle", 5500, 0, 1900, 250);
			f.Calculated = true;
			f = s.Fields.Add("FldLastName", "Phone", 7500, 0, 1200, 250);
			f.Calculated = true;

			if (chkGroup.Checked)
			{
				// group customers by country, in ascending order
				Group grp = c1r.Groups.Add("GrpCountry", "Country", SortEnum.Ascending);
				s = grp.SectionHeader;
				s.Height = 500;
				s.Visible = true;
				f = s.Fields.Add("CtlCountry", "Country", 0, 0, c1r.Layout.Width, 500);
				f.Calculated = true;
				f.Align = FieldAlignEnum.LeftMiddle;
				f.Font.Bold = true;
				f.Font.Size = 12;
				f.BorderStyle = BorderStyleEnum.Solid;
				f.BorderColor = Color.FromArgb(0, 0, 150);
				f.BackStyle = BackStyleEnum.Opaque;
				f.BackColor = Color.FromArgb(150, 150, 220);
				f.MarginLeft = 100;

				// sort customers by name within each country
				c1r.Groups.Add("GrpName", "CompanyName", SortEnum.Ascending);
			}

			// render the report into the PrintPreviewControl
			_ppv.Document = c1r;
            // _ppv.InvalidatePreview(); -- no need to render if shown in C1 preview control
        }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		// render employees
		private void _btnEmployees_Click(object sender, System.EventArgs e)
		{
			try
			{
				status.Text = "Rendering Employees";
				Cursor = Cursors.WaitCursor;
				RenderEmployees();
			}
			finally
			{
				Cursor = Cursors.Default;
				status.Text = "Ready";
			}
		}

		// render customers
		private void _btnCustomers_Click(object sender, System.EventArgs e)
		{
			try
			{
				status.Text = "Rendering Customers";
				Cursor = Cursors.WaitCursor;
				RenderCustomers();
			}
			finally
			{
				Cursor = Cursors.Default;
				status.Text = "Ready";
			}
		}

		// save reports
		private void _btnSave_Click(object sender, System.EventArgs e)
		{
			// open xml file
			string fileName = Path.GetDirectoryName(Application.ExecutablePath) + 
								@"\MyReports.xml";
			XmlTextWriter writer = new XmlTextWriter(fileName, System.Text.Encoding.Default);

			// initialize xml file
			writer.Formatting = Formatting.Indented;
			writer.Indentation = 2;
			writer.WriteStartDocument();
			writer.WriteStartElement("Reports");

			// save Customers report
			RenderCustomers();
			c1r.ReportName = "Customers";
			c1r.Save(writer);

			// save Employees report
			RenderEmployees();
			c1r.ReportName = "Employees";
			c1r.Save(writer);

			// close xml file
			writer.WriteEndElement();
			writer.Close();
		}

		// handle preview toolbar
		private void _toolBar_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button == tbbtnFirst)
				_ppv.StartPageIdx = 0;
			else if (e.Button == tbbtnLast)
                _ppv.StartPageIdx = 10000;
			else if (e.Button == tbbtnPrev)
                --_ppv.StartPageIdx;
			else if (e.Button == tbbtnNext)
                ++_ppv.StartPageIdx;
			else if (e.Button == tbbtnZoom)
			{
				_ppv.Rows = 1;
				_ppv.Cols = 1;
                if (_ppv.ZoomFactor == 1)
                    _ppv.ZoomMode = ZoomModeEnum.WholePage;
                else
                    _ppv.ZoomFactor = 1;
			}
		}
		private void _zoom_Click(object sender, System.EventArgs e)
		{
			if (sender.Equals(_mz100))
			{
				_ppv.ZoomFactor = 1;
			}
			if (sender.Equals(_mzPage))		
			{
				_ppv.Rows = _ppv.Cols = 1;
                _ppv.ZoomMode = ZoomModeEnum.WholePage;
			}
			if (sender.Equals(_mzThumbnails))		
			{
				_ppv.Rows = _ppv.Cols = 3;
				_ppv.ZoomMode = ZoomModeEnum.WholePage;
			}
			if (sender.Equals(_mzTwoPages))		
			{
				_ppv.Rows = 1;
				_ppv.Cols = 2;
				_ppv.ZoomMode = ZoomModeEnum.WholePage;
			}
		}
	}
}
