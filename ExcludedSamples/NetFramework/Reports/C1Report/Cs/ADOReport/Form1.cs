using System;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Report;
using C1.Win.C1Preview;

namespace ADOReport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
        private Button button2;
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
            this._c1r = new C1.C1Report.C1Report();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Customer Labels";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Render report using ADO Recordset as data source";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 56);
            this.button2.TabIndex = 0;
            this.button2.Text = "Render report using ADO Recordset as data source\r\nin C1PrintPreviewDialog";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(322, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: ADODB Recordsets";
            this.Load += new System.EventHandler(this.Form1_Load);
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

		string _rsFileName;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// copy recordset from resources to file in the bin directory
			_rsFileName = Application.StartupPath + @"\\rs.xml";
			Assembly asm = Assembly.GetExecutingAssembly();
			foreach (string resName in asm.GetManifestResourceNames())
			{
				if (resName.EndsWith("rs.xml"))
				{
					using (StreamReader sr = new StreamReader(asm.GetManifestResourceStream(resName)))
					using (StreamWriter sw = new StreamWriter(_rsFileName))
					{
						sw.Write(sr.ReadToEnd());
						break;
					}
				}
			}
		}

        private void LoadADO()
		{
			// load ADO recordset from file
			ADODB.Recordset rs = new ADODB.RecordsetClass();
			rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient;
			rs.Open(_rsFileName, "Provider=MSPersist;", ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic, 0);

			// use ADO recordset as report data source
			_c1r.DataSource.Recordset = new ADOReportSource(rs);
		}

        private void button1_Click(object sender, System.EventArgs e)
        {
            LoadADO();

            // show the report
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = _c1r.Document;
            dlg.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            LoadADO();

            // show the report
            C1PrintPreviewDialog dlg = new C1PrintPreviewDialog();
            dlg.Document = _c1r;
            dlg.ShowDialog();
        }
    }

	/// <summary>
	/// Wrapper for ADODB.Recordset object that implements the IC1ReportRecordset interface and
	/// allows it to be used as a C1Report data source.
	/// </summary>
	public class ADOReportSource : IC1ReportRecordset
	{
		// ** field
		ADODB.Recordset _rs;

		// ** ctor
		public ADOReportSource(ADODB.Recordset rs)
		{
			_rs = rs;
		}

		// ** IC1ReportRecordset interface implementation
		void   IC1ReportRecordset.ApplyFilter(string filter)	{ _rs.Filter = filter; }
		void   IC1ReportRecordset.ApplySort(string sort)		{ _rs.Sort = sort; }
		bool   IC1ReportRecordset.BOF()							{ return _rs.BOF; }
		bool   IC1ReportRecordset.EOF()							{ return _rs.EOF; }
		void   IC1ReportRecordset.MoveFirst()					{ _rs.MoveFirst(); }
		void   IC1ReportRecordset.MoveLast()					{ _rs.MoveLast(); }
		void   IC1ReportRecordset.MoveNext()					{ _rs.MoveNext(); }
		void   IC1ReportRecordset.MovePrevious()				{ _rs.MovePrevious(); }
		object IC1ReportRecordset.GetFieldValue(int index)		{ return _rs.Fields[index].Value; }
		int    IC1ReportRecordset.GetBookmark()				
		{
			return (_rs.EOF)? -1: (int)(double)_rs.Bookmark; 
		}
		void   IC1ReportRecordset.SetBookmark(int bkmk)		
		{
			if (bkmk == -1) 
			{
				_rs.MoveLast();
				_rs.MoveNext();
			}
			else
			{
				_rs.Bookmark = (double)bkmk; 
			}
		}
		string[] IC1ReportRecordset.GetFieldNames()
		{
			string[] arr = new string[_rs.Fields.Count];
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = _rs.Fields[i].Name;
			}
			return arr;
		}
		Type[]   IC1ReportRecordset.GetFieldTypes()
		{
			Type[] arr = new Type[_rs.Fields.Count];
			for (int i = 0; i < arr.Length; i++)
			{
				Type t = typeof(object);
				switch (_rs.Fields[i].Type)
				{
					case ADODB.DataTypeEnum.adBigInt:
						t = typeof(long);
						break;
					case ADODB.DataTypeEnum.adBoolean:
						t = typeof(bool);
						break;
					case ADODB.DataTypeEnum.adBSTR:
					case ADODB.DataTypeEnum.adLongVarChar:
					case ADODB.DataTypeEnum.adLongVarWChar:
						t = typeof(string);
						break;
					case ADODB.DataTypeEnum.adChar:
						t = typeof(char);
						break;
					case ADODB.DataTypeEnum.adCurrency:
					case ADODB.DataTypeEnum.adDecimal:
					case ADODB.DataTypeEnum.adNumeric:
						t = typeof(decimal);
						break;
					case ADODB.DataTypeEnum.adDate:
					case ADODB.DataTypeEnum.adDBDate:
					case ADODB.DataTypeEnum.adDBTime:
					case ADODB.DataTypeEnum.adDBTimeStamp:
					case ADODB.DataTypeEnum.adFileTime:
						t = typeof(DateTime);
						break;
					case ADODB.DataTypeEnum.adDouble:
						t = typeof(double);
						break;
					case ADODB.DataTypeEnum.adInteger:
						t = typeof(int);
						break;
					case ADODB.DataTypeEnum.adLongVarBinary:
						t = typeof(byte[]);
							break;
					case ADODB.DataTypeEnum.adSingle:
						t = typeof(float);
						break;
					case ADODB.DataTypeEnum.adSmallInt:
						t = typeof(short);
						break;
					case ADODB.DataTypeEnum.adUnsignedTinyInt:
					case ADODB.DataTypeEnum.adTinyInt:
						t = typeof(byte);
						break;
					case ADODB.DataTypeEnum.adUnsignedBigInt:
						t = typeof(ulong);
						break;
					case ADODB.DataTypeEnum.adUnsignedInt:
						t = typeof(uint);
						break;
					case ADODB.DataTypeEnum.adUnsignedSmallInt:
						t = typeof(ushort);
						break;
				}
				arr[i] = t;
			}
			return arr;
		}
	}
}
