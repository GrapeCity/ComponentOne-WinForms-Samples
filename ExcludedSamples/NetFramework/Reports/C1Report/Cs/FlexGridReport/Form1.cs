using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.C1Report;
using C1.Win.C1FlexGrid;

namespace FlexGridReport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.Button _btnRender;
		private C1.C1Report.C1Report _c1r;
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
			this._btnRender = new System.Windows.Forms.Button();
			this._c1r = new C1.C1Report.C1Report();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(440, 248);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// _btnRender
			// 
			this._btnRender.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._btnRender.Location = new System.Drawing.Point(8, 264);
			this._btnRender.Name = "_btnRender";
			this._btnRender.Size = new System.Drawing.Size(128, 32);
			this._btnRender.TabIndex = 1;
			this._btnRender.Text = "Render Report";
			this._btnRender.Click += new System.EventHandler(this._btnRender_Click);
			// 
			// _c1r
			// 
			this._c1r.ReportName = "c1Report1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnRender,
																		  this._flex});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Using C1FlexGrid as a DataSource";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // populate grid
            string mdbFile =
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\C1NWIND.MDB";
            string conn = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + mdbFile + ";";
            string rs = "select * from customers";
            OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _flex.DataSource = dt;
            _flex.Cols[0].Width = _flex.Rows[0].HeightDisplay;
            _flex.ShowCursor = true;

            // build report definition based on grid
            BuildReportDefinition();
        }

		// build report to show all fields in a flex control
		private void BuildReportDefinition()
		{
			// initialize report
			_c1r.Clear();
			_c1r.Layout.Orientation = OrientationEnum.Landscape;
			_c1r.Layout.MarginLeft = 500;

			// add header section
			Section s = _c1r.Sections[SectionTypeEnum.Header];
			s.Visible = true;
			s.Height = 700;
			Field f = s.Fields.Add("fldTitle", "Flex-based report", 0, 0, 4000, 700);
			f.Font = new Font("Tahoma", 14, FontStyle.Bold);

			// add page header and detail sections
			Section sHdr = _c1r.Sections[SectionTypeEnum.PageHeader];
			sHdr.Visible = true;
			sHdr.Height = 400;

			Section sDtl = _c1r.Sections[SectionTypeEnum.Detail];
			sDtl.Visible = true;
			sDtl.Height = 100;
			sDtl.CanGrow = true;

			// populate header and detail sections
			Font fntHdr = new Font("Tahoma", 8, FontStyle.Bold | FontStyle.Underline);
			Font fntDtl = new Font("Tahoma", 8, FontStyle.Regular);
			Rectangle rc = new Rectangle(0, 0, (int)sDtl.Height, 0);
			foreach (Column col in _flex.Cols)
			{
				// calculate field rectangle in twips
				rc.Width = col.WidthDisplay * 1440 / 96 + 200;

				// create field in page header section
				rc.Height = (int)sHdr.Height;
				f = sHdr.Fields.Add("fh" + col.Name, col.Name, rc);
				f.Font = fntHdr;
				f.ForeColor = Color.Navy;
				f.Align = FieldAlignEnum.LeftBottom;

				// create field in detail section
				rc.Height = (int)sDtl.Height;
				f = sDtl.Fields.Add("fd" + col.Name, col.Name, rc);
				f.Font = fntDtl;
				f.Calculated = true;
				f.CanGrow = true;
				f.Format = col.Format;

				// move on to next field
				rc.Offset(rc.Width, 0);
				if (rc.Left > 10 * 1440) break;
			}

			// assign data source
			_c1r.DataSource.Recordset = new FlexDataSource(_flex);
		}

		// show report
		private void _btnRender_Click(object sender, System.EventArgs e)
		{
			// render the report
			_c1r.DoEvents = false;
			_c1r.Render();

			// and show it
            C1.Win.C1Preview.C1PrintPreviewDialog pd = new C1.Win.C1Preview.C1PrintPreviewDialog();
			pd.Document = _c1r;
			pd.ShowDialog();
		}
	}

	/// <summary>
	/// FlexDataSource
	/// Implements the IC1ReportRecordset to provide data to a c1report control
	/// from a c1flexgrid control.
	/// </summary>
	public class FlexDataSource : IC1ReportRecordset
	{
		// ** fields
		private C1FlexGrid _flex;
		private int _row;

		// ** ctor
		public FlexDataSource(C1FlexGrid flex)
		{
			_flex = flex;
			_row  = 0;
		}

		// ** IC1ReportRecordset
		//
		//    any object that implements this interface can be used as a 
		//    data source for the c1report component.
		//
		void IC1ReportRecordset.ApplyFilter(string filter)	{ /* not implemented */}
		void IC1ReportRecordset.ApplySort(string sort)		{ /* not implemented */}
		bool IC1ReportRecordset.BOF()						{ return _row == 0; }
		bool IC1ReportRecordset.EOF()						{ return _row >= _flex.Rows.Count - _flex.Rows.Fixed; }
		int	 IC1ReportRecordset.GetBookmark()				{ return _row; }
		void IC1ReportRecordset.SetBookmark(int bkmk)		{ _row = bkmk; }
		void IC1ReportRecordset.MoveFirst()					{ _row = 0; }
		void IC1ReportRecordset.MoveLast()					{ _row = _flex.Rows.Count - _flex.Rows.Fixed - 1;}
		void IC1ReportRecordset.MoveNext()					{ _row++; }
		void IC1ReportRecordset.MovePrevious()				{ _row--; }
		string[] IC1ReportRecordset.GetFieldNames()
		{
			int count = _flex.Cols.Count - _flex.Cols.Fixed;
			string[] fieldNames = new string[count];
			for (int i = 0; i < count; i++)
				fieldNames[i] = _flex.Cols[i + _flex.Cols.Fixed].Name;
			return fieldNames;
		}
		Type[] IC1ReportRecordset.GetFieldTypes() 
		{
			int count = _flex.Cols.Count - _flex.Cols.Fixed;
			Type[] fieldTypes = new Type[count];
			for (int i = 0; i < count; i++)
				fieldTypes[i] = _flex.Cols[i + _flex.Cols.Fixed].DataType;
			return fieldTypes;
		}
		object IC1ReportRecordset.GetFieldValue(int fieldIndex) 
		{
			return _flex[_row + _flex.Rows.Fixed, fieldIndex + _flex.Cols.Fixed];
		}
	}
}
