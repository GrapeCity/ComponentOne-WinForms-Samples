using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.C1Report;
using C1.Win.C1Preview;

namespace WindowsApplication1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.ToolBar _tb;
		private System.Windows.Forms.ImageList _il;
		private System.Windows.Forms.ToolBarButton _tbFirst;
		private System.Windows.Forms.ToolBarButton _tbPrev;
		private System.Windows.Forms.ToolBarButton _tbNext;
		private System.Windows.Forms.ToolBarButton _tbLast;
		private System.Windows.Forms.ToolBarButton _tbSep;
		private System.Windows.Forms.ToolBarButton _tbActual;
		private System.Windows.Forms.ToolBarButton _tbPage;
		private System.Windows.Forms.ToolBarButton _tbTwoPages;
        private System.Windows.Forms.StatusBar _status;
        private C1PreviewPane _ppv;
		private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._c1r = new C1.C1Report.C1Report();
            this._tb = new System.Windows.Forms.ToolBar();
            this._tbFirst = new System.Windows.Forms.ToolBarButton();
            this._tbPrev = new System.Windows.Forms.ToolBarButton();
            this._tbNext = new System.Windows.Forms.ToolBarButton();
            this._tbLast = new System.Windows.Forms.ToolBarButton();
            this._tbSep = new System.Windows.Forms.ToolBarButton();
            this._tbActual = new System.Windows.Forms.ToolBarButton();
            this._tbPage = new System.Windows.Forms.ToolBarButton();
            this._tbTwoPages = new System.Windows.Forms.ToolBarButton();
            this._il = new System.Windows.Forms.ImageList(this.components);
            this._status = new System.Windows.Forms.StatusBar();
            this._ppv = new C1.Win.C1Preview.C1PreviewPane();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.EndReport += new System.EventHandler(this._c1r_EndReport);
            this._c1r.StartPage += new C1.C1Report.ReportEventHandler(this._c1r_StartPage);
            // 
            // _tb
            // 
            this._tb.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._tb.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this._tbFirst,
            this._tbPrev,
            this._tbNext,
            this._tbLast,
            this._tbSep,
            this._tbActual,
            this._tbPage,
            this._tbTwoPages});
            this._tb.DropDownArrows = true;
            this._tb.ImageList = this._il;
            this._tb.Location = new System.Drawing.Point(0, 0);
            this._tb.Name = "_tb";
            this._tb.ShowToolTips = true;
            this._tb.Size = new System.Drawing.Size(738, 28);
            this._tb.TabIndex = 2;
            this._tb.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._tb_ButtonClick);
            // 
            // _tbFirst
            // 
            this._tbFirst.ImageIndex = 0;
            this._tbFirst.Name = "_tbFirst";
            this._tbFirst.ToolTipText = "First Page";
            // 
            // _tbPrev
            // 
            this._tbPrev.ImageIndex = 1;
            this._tbPrev.Name = "_tbPrev";
            this._tbPrev.ToolTipText = "Previous Page";
            // 
            // _tbNext
            // 
            this._tbNext.ImageIndex = 2;
            this._tbNext.Name = "_tbNext";
            this._tbNext.ToolTipText = "Next Page";
            // 
            // _tbLast
            // 
            this._tbLast.ImageIndex = 3;
            this._tbLast.Name = "_tbLast";
            this._tbLast.ToolTipText = "Last Page";
            // 
            // _tbSep
            // 
            this._tbSep.Name = "_tbSep";
            this._tbSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _tbActual
            // 
            this._tbActual.ImageIndex = 4;
            this._tbActual.Name = "_tbActual";
            this._tbActual.ToolTipText = "Actual Size";
            // 
            // _tbPage
            // 
            this._tbPage.ImageIndex = 5;
            this._tbPage.Name = "_tbPage";
            this._tbPage.ToolTipText = "Whole Page";
            // 
            // _tbTwoPages
            // 
            this._tbTwoPages.ImageIndex = 6;
            this._tbTwoPages.Name = "_tbTwoPages";
            this._tbTwoPages.ToolTipText = "Two Pages";
            // 
            // _il
            // 
            this._il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_il.ImageStream")));
            this._il.TransparentColor = System.Drawing.Color.Red;
            this._il.Images.SetKeyName(0, "");
            this._il.Images.SetKeyName(1, "");
            this._il.Images.SetKeyName(2, "");
            this._il.Images.SetKeyName(3, "");
            this._il.Images.SetKeyName(4, "");
            this._il.Images.SetKeyName(5, "");
            this._il.Images.SetKeyName(6, "");
            // 
            // _status
            // 
            this._status.Location = new System.Drawing.Point(0, 551);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(738, 19);
            this._status.TabIndex = 3;
            // 
            // _ppv
            // 
            this._ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppv.Location = new System.Drawing.Point(0, 28);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(738, 523);
            this._ppv.TabIndex = 0;
            this._ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.ActualSize;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(738, 570);
            this.Controls.Add(this._ppv);
            this.Controls.Add(this._tb);
            this.Controls.Add(this._status);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report: Bind to Hierarchical Dataset";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

        // connect a DataSet to a report, using the relations defined
        // in the DataSet to link the subreports.
		private void ConnectDataSet(DataSet ds, C1Report c1r)
		{
			// get table for this report
			DataTable dtParent = null;
			string rs = c1r.DataSource.RecordSource;
			if (ds.Tables.Contains(rs))
			{
				dtParent = ds.Tables[rs];
				c1r.DataSource.Recordset = new DataView(dtParent);
			}

			// hook up subreports
			foreach (Field f in c1r.Fields)
			{
				// only interested in subreport fields
				C1Report sr = f.Subreport;
				if (sr == null) continue;

				// connect subreport
				ConnectDataSet(ds, sr);

				// build filter expression
				string rsChild = sr.DataSource.RecordSource;
				if (ds.Tables.Contains(rsChild) && dtParent != null)
				{
					DataTable dtChild = ds.Tables[rsChild];
					foreach (DataRelation dr in dtParent.ChildRelations)
					{
						if (dr.ParentTable == dtParent && dr.ChildTable == dtChild)
						{
							string filter = string.Format("\"[{0}] = '\" & {1} & \"'\"",
								dr.ParentColumns[0].ColumnName, dr.ChildColumns[0].ColumnName);
							f.Text = filter;
							break;
						}
					}
				}
			}
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            // make sure the form is shown before the report loads
            Timer t = new Timer();
            t.Interval = 100;
            t.Tick += new EventHandler(t_Tick);
            t.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Stop();
            ((Timer)sender).Dispose();
            Render();
        }

        // load report, data, bind, render
        private void Render()
        {
            // get application path
			string path = Application.StartupPath;
			int pos = path.IndexOf(@"\bin");
			if (pos > -1) path = path.Substring(0, pos);
			
			// load report into control
			string reportFile = path + @"\hierReport.xml";
			_c1r.Load(reportFile, "Customers");

			// load data into DataSet
			DataSet ds = new DataSet();
			string dataFile = path + @"\hierData.xml";
			ds.ReadXml(dataFile);

			// connect data set to report (and subreports)
			ConnectDataSet(ds, _c1r);

			// go show report
			Cursor = Cursors.WaitCursor;
			_ppv.ZoomFactor = 1;
            _ppv.Document = _c1r;
			Cursor = Cursors.Default;
		}

        // handle toolbar
		private void _tb_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			if (e.Button == _tbFirst)
                _ppv.StartPageIdx = 1;
			else if (e.Button == _tbPrev)
                _ppv.StartPageIdx--;
			else if (e.Button == _tbNext)
                _ppv.StartPageIdx++;
			else if (e.Button == _tbLast)
                _ppv.StartPageIdx = 32000;
			else if (e.Button == _tbActual)
			{
				_ppv.Cols = 1;
				// _ppv.AutoZoom = false;
				_ppv.ZoomFactor = 1;
			}
			else if (e.Button == _tbPage)
			{
				_ppv.Cols = 1;
                _ppv.ZoomMode = ZoomModeEnum.WholePage;
			}
			else if (e.Button == _tbTwoPages)
			{
				_ppv.Cols = 2;
                _ppv.ZoomMode = ZoomModeEnum.WholePage;
			}
            ShowStatus();
        }

        // update UI
        private void _c1r_StartPage(object sender, C1.C1Report.ReportEventArgs e)
        {
            _status.Text = string.Format("Rendering page {0}", _c1r.Page);        
        }
        int _pageCount = 0;
        private void _c1r_EndReport(object sender, System.EventArgs e)
        {
            _pageCount = _c1r.PageImages.Count;
            ShowStatus();
        }
        private void ShowStatus()
        {
            _status.Text = string.Format("Page {0} of {1}", _ppv.StartPageIdx + 1, _pageCount);
        }
	}
}
