using System;
using System.Xml;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Report;

namespace XMLData
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
        private C1.C1Report.C1Report _c1r;
		private C1.Win.C1Preview.C1PreviewPane _ppv;
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
            this.button1 = new System.Windows.Forms.Button();
            this._c1r = new C1.C1Report.C1Report();
            this._ppv = new C1.Win.C1Preview.C1PreviewPane();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select XML file";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "c1Report1";
            // 
            // _ppv
            // 
            this._ppv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._ppv.Location = new System.Drawing.Point(0, 45);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(567, 540);
            this._ppv.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(567, 578);
            this.Controls.Add(this._ppv);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: XML data sources";
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
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

		private void button1_Click(object sender, System.EventArgs e)
		{
			// select XML file to use as a data source
			// (in this sample, should be a report definition file)
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.FileName = "*.xml";
			if (dlg.ShowDialog() != DialogResult.OK) return;

			// load XML document
			XmlDocument doc = new XmlDocument();
			doc.Load(dlg.FileName);

			// create dummy report definition with a single field (report names)
			_c1r.Clear();
			Section s = _c1r.Sections[SectionTypeEnum.Detail];
			s.Visible = true;
			s.Height = 400;
			Field f = s.Fields.Add("fld", "Name", 0, 0, 6000, 300);
			f.Calculated = true;

			// create custom data source using XPath
			// in this case, the data source will have one 'record' per report definition
			// in the file, and each record will contain the report information
			XmlDataSource xds = new XmlDataSource(doc.SelectNodes("Reports/Report"));

			// assign custom data source to report control and show the report
			_c1r.DataSource.Recordset = xds;
			_ppv.Document = _c1r;
		}
	}

	/// <summary>
	/// XmlDataSource
	/// 
	/// custom RecordSource object used to parse XML documents into 
	/// report data.
	/// 
	/// </summary>
    public class XmlDataSource : C1.C1Report.IC1ReportRecordset 
	{
		XmlNodeList _nodes;
		int			_index = 0;
		string[]	_fieldNames;
		Type[]		_fieldTypes;
		
		// ** ctor

		public XmlDataSource(XmlNodeList nodes)
		{
			// store reference to XML node list
			_nodes = nodes;

			// inspect XML and build field lists (name/type)
			// uses first node on the list as a template, 
			// maps each child node into a string field
			XmlNodeList children = nodes[0].ChildNodes;
			_fieldNames = new string[children.Count];
			_fieldTypes = new Type[children.Count];
			for (int i = 0; i < children.Count; i++)
			{
				_fieldNames[i] = children[i].Name;
				_fieldTypes[i] = typeof(string);
			}
		}

		// ** IC1ReportRecordset implementation

		bool		IC1ReportRecordset.BOF()					{ return _index == 0; }
		bool		IC1ReportRecordset.EOF()					{ return _index >= _nodes.Count; }
		void		IC1ReportRecordset.MoveFirst()				{ _index = 0; }
		void		IC1ReportRecordset.MoveLast()				{ _index = _nodes.Count-1; }
		void		IC1ReportRecordset.MoveNext()				{ _index++; }
		void		IC1ReportRecordset.MovePrevious()			{ _index--; }
		int			IC1ReportRecordset.GetBookmark()			{ return _index; }
		void		IC1ReportRecordset.SetBookmark(int bkmk)	{ _index = bkmk; }
		string[]	IC1ReportRecordset.GetFieldNames()			{ return _fieldNames; }
		Type[]		IC1ReportRecordset.GetFieldTypes()			{ return _fieldTypes; }

		// field data is its InnerText property (could be attribute)
		object		IC1ReportRecordset.GetFieldValue(int fieldIndex)
		{
			return _nodes[_index].ChildNodes[fieldIndex].InnerText;
		}

		// not supported

		void	IC1ReportRecordset.ApplyFilter(string filter) {}
		void	IC1ReportRecordset.ApplySort(string sort) {}
	}
}
