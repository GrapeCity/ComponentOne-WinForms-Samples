using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.Data.OleDb;
using System.IO;
using C1.C1Report;
using C1.Win.C1Preview;
using C1.Win.C1Chart;

namespace Chart
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		// private System.Windows.Forms.PrintPreviewControl _ppv;
        private C1.Win.C1Preview.C1PreviewPane _ppv;
		private System.Windows.Forms.ToolBar _tbPreview;
		private System.Windows.Forms.ToolBarButton _btnFirst;
		private System.Windows.Forms.ToolBarButton _btnPrev;
		private System.Windows.Forms.ToolBarButton _btnNext;
		private System.Windows.Forms.ToolBarButton _btnLast;
		private System.Windows.Forms.ToolBarButton _btnSep2;
		private System.Windows.Forms.ToolBarButton _btnActual;
		private System.Windows.Forms.ToolBarButton _btnOnePage;
		private System.Windows.Forms.ToolBarButton _btnTwoPages;
		private System.Windows.Forms.ImageList _imgList;
		private System.Windows.Forms.ToolBarButton _btnRenderReport;
		private System.Windows.Forms.ToolBarButton _btnSep1;
		private System.Windows.Forms.ContextMenu _previewMenu;
		private System.Windows.Forms.MenuItem _mn50;
		private System.Windows.Forms.MenuItem _mn100;
		private System.Windows.Forms.MenuItem _mn150;
		private System.Windows.Forms.MenuItem _mn200;
		private System.Windows.Forms.MenuItem _mn400;
		private System.Windows.Forms.ToolBarButton _btnSep3;
		private System.Windows.Forms.ComboBox _chartType;
		private C1.Win.C1Chart.C1Chart _chart;
		private System.Windows.Forms.ToolBarButton _btnPrintReport;
		private System.ComponentModel.IContainer components;

        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;

            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            rep.DataSource.ConnectionString = cs;

            //
            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null)
                    CorrectConnectionString(field.Subreport);
        }

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            CorrectConnectionString(_c1r);
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
            this._ppv = new C1.Win.C1Preview.C1PreviewPane();
            this._tbPreview = new System.Windows.Forms.ToolBar();
            this._btnRenderReport = new System.Windows.Forms.ToolBarButton();
            this._btnPrintReport = new System.Windows.Forms.ToolBarButton();
            this._btnSep1 = new System.Windows.Forms.ToolBarButton();
            this._btnFirst = new System.Windows.Forms.ToolBarButton();
            this._btnPrev = new System.Windows.Forms.ToolBarButton();
            this._btnNext = new System.Windows.Forms.ToolBarButton();
            this._btnLast = new System.Windows.Forms.ToolBarButton();
            this._btnSep2 = new System.Windows.Forms.ToolBarButton();
            this._btnActual = new System.Windows.Forms.ToolBarButton();
            this._previewMenu = new System.Windows.Forms.ContextMenu();
            this._mn50 = new System.Windows.Forms.MenuItem();
            this._mn100 = new System.Windows.Forms.MenuItem();
            this._mn150 = new System.Windows.Forms.MenuItem();
            this._mn200 = new System.Windows.Forms.MenuItem();
            this._mn400 = new System.Windows.Forms.MenuItem();
            this._btnOnePage = new System.Windows.Forms.ToolBarButton();
            this._btnTwoPages = new System.Windows.Forms.ToolBarButton();
            this._btnSep3 = new System.Windows.Forms.ToolBarButton();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            this._chartType = new System.Windows.Forms.ComboBox();
            this._chart = new C1.Win.C1Chart.C1Chart();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chart)).BeginInit();
            this.SuspendLayout();
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "Sales by Category";
            this._c1r.PrintSection += new C1.C1Report.ReportEventHandler(this._c1r_PrintSection);
            // 
            // _ppv
            // 
            this._ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppv.Location = new System.Drawing.Point(0, 27);
            this._ppv.Name = "_ppv";
            this._ppv.Size = new System.Drawing.Size(542, 365);
            this._ppv.TabIndex = 2;
            // 
            // _tbPreview
            // 
            this._tbPreview.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._tbPreview.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this._btnRenderReport,
            this._btnPrintReport,
            this._btnSep1,
            this._btnFirst,
            this._btnPrev,
            this._btnNext,
            this._btnLast,
            this._btnSep2,
            this._btnActual,
            this._btnOnePage,
            this._btnTwoPages,
            this._btnSep3});
            this._tbPreview.DropDownArrows = true;
            this._tbPreview.ImageList = this._imgList;
            this._tbPreview.Location = new System.Drawing.Point(0, 0);
            this._tbPreview.Name = "_tbPreview";
            this._tbPreview.ShowToolTips = true;
            this._tbPreview.Size = new System.Drawing.Size(542, 27);
            this._tbPreview.TabIndex = 11;
            this._tbPreview.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._tbPreview_ButtonClick);
            // 
            // _btnRenderReport
            // 
            this._btnRenderReport.ImageIndex = 0;
            this._btnRenderReport.Name = "_btnRenderReport";
            this._btnRenderReport.ToolTipText = "Render the Report";
            // 
            // _btnPrintReport
            // 
            this._btnPrintReport.ImageIndex = 1;
            this._btnPrintReport.Name = "_btnPrintReport";
            this._btnPrintReport.ToolTipText = "Print the Report";
            // 
            // _btnSep1
            // 
            this._btnSep1.Name = "_btnSep1";
            this._btnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnFirst
            // 
            this._btnFirst.ImageIndex = 2;
            this._btnFirst.Name = "_btnFirst";
            this._btnFirst.ToolTipText = "First page";
            // 
            // _btnPrev
            // 
            this._btnPrev.ImageIndex = 3;
            this._btnPrev.Name = "_btnPrev";
            this._btnPrev.ToolTipText = "Previous page";
            // 
            // _btnNext
            // 
            this._btnNext.ImageIndex = 4;
            this._btnNext.Name = "_btnNext";
            this._btnNext.ToolTipText = "Next page";
            // 
            // _btnLast
            // 
            this._btnLast.ImageIndex = 5;
            this._btnLast.Name = "_btnLast";
            this._btnLast.ToolTipText = "Last page";
            // 
            // _btnSep2
            // 
            this._btnSep2.Name = "_btnSep2";
            this._btnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnActual
            // 
            this._btnActual.DropDownMenu = this._previewMenu;
            this._btnActual.ImageIndex = 6;
            this._btnActual.Name = "_btnActual";
            this._btnActual.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton;
            this._btnActual.ToolTipText = "Actual Size";
            // 
            // _previewMenu
            // 
            this._previewMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this._mn50,
            this._mn100,
            this._mn150,
            this._mn200,
            this._mn400});
            // 
            // _mn50
            // 
            this._mn50.Index = 0;
            this._mn50.Text = "50%";
            this._mn50.Click += new System.EventHandler(this._mnZoom_Click);
            // 
            // _mn100
            // 
            this._mn100.Index = 1;
            this._mn100.Text = "100%";
            this._mn100.Click += new System.EventHandler(this._mnZoom_Click);
            // 
            // _mn150
            // 
            this._mn150.Index = 2;
            this._mn150.Text = "150%";
            this._mn150.Click += new System.EventHandler(this._mnZoom_Click);
            // 
            // _mn200
            // 
            this._mn200.Index = 3;
            this._mn200.Text = "200%";
            this._mn200.Click += new System.EventHandler(this._mnZoom_Click);
            // 
            // _mn400
            // 
            this._mn400.Index = 4;
            this._mn400.Text = "400%";
            this._mn400.Click += new System.EventHandler(this._mnZoom_Click);
            // 
            // _btnOnePage
            // 
            this._btnOnePage.ImageIndex = 7;
            this._btnOnePage.Name = "_btnOnePage";
            this._btnOnePage.ToolTipText = "One page";
            // 
            // _btnTwoPages
            // 
            this._btnTwoPages.ImageIndex = 8;
            this._btnTwoPages.Name = "_btnTwoPages";
            this._btnTwoPages.ToolTipText = "Two pages";
            // 
            // _btnSep3
            // 
            this._btnSep3.Name = "_btnSep3";
            this._btnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _imgList
            // 
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Red;
            this._imgList.Images.SetKeyName(0, "Preview.bmp");
            this._imgList.Images.SetKeyName(1, "Print.bmp");
            this._imgList.Images.SetKeyName(2, "PreviewFirst.bmp");
            this._imgList.Images.SetKeyName(3, "PreviewPrevious.bmp");
            this._imgList.Images.SetKeyName(4, "PreviewNext.bmp");
            this._imgList.Images.SetKeyName(5, "PreviewLast.bmp");
            this._imgList.Images.SetKeyName(6, "FitWidth.bmp");
            this._imgList.Images.SetKeyName(7, "FitPage.bmp");
            this._imgList.Images.SetKeyName(8, "FitTwoPages.bmp");
            // 
            // _chartType
            // 
            this._chartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._chartType.Items.AddRange(new object[] {
            "Bar",
            "Line",
            "Area"});
            this._chartType.Location = new System.Drawing.Point(256, 2);
            this._chartType.Name = "_chartType";
            this._chartType.Size = new System.Drawing.Size(121, 21);
            this._chartType.TabIndex = 13;
            this._chartType.SelectedIndexChanged += new System.EventHandler(this._chartType_SelectedIndexChanged);
            // 
            // _chart
            // 
            this._chart.BackColor = System.Drawing.Color.White;
            this._chart.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this._chart.Location = new System.Drawing.Point(64, 40);
            this._chart.Name = "_chart";
            this._chart.PropBag = resources.GetString("_chart.PropBag");
            this._chart.Size = new System.Drawing.Size(408, 312);
            this._chart.TabIndex = 14;
            this._chart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(542, 392);
            this.Controls.Add(this._chart);
            this.Controls.Add(this._chartType);
            this.Controls.Add(this._ppv);
            this.Controls.Add(this._tbPreview);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report Sample: Report with embedded charts (C1Chart)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chart)).EndInit();
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

		// data table containing the report data
		// we load this only once, when the app starts
		DataTable _dataTable = new DataTable();

		// show report when the form loads
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// load data
			string rs = "select * from [" + _c1r.DataSource.RecordSource + "]";
			string conn = _c1r.DataSource.ConnectionString;
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			Cursor = Cursors.WaitCursor;
			da.Fill(_dataTable);
			Cursor = Cursors.Default;

			// assign data source to report
			// (this is not strictly necessary, but it makes the application 
			// faster because the control doesn't have to re-fetch the data 
			// each time it renders the report)
			_c1r.DataSource.Recordset = _dataTable;

			// select first chart type
			_chartType.SelectedIndex = 0;
		}

		// show report when the user selects a new chart type
		private void _chartType_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			RenderReport();
		}

		// create report with charts
		private void RenderReport()
		{
			// prevent reentrant calls
		    if (_c1r.IsBusy) return;

			// render report with chart
			_c1r.Render();
			_ppv.Document = _c1r;
		}

		private void _c1r_PrintSection(object sender, C1.C1Report.ReportEventArgs e)
		{
			// get the field we want
			Field theField = _c1r.Fields["SalesChart"];
    
			// make sure this is the section we want
			if (e.Section != theField.Section) return;

			// create chart image for this section
			using (DataView chartData = new DataView(_dataTable))
			{
				// filter chart data for the current category
				chartData.RowFilter = "CategoryName = '" + _c1r.Evaluate("CategoryName") + "'";
    
				// create chart 
				Image img = BuildChart(chartData);

				// add chart image to field
				theField.Picture = img;
				theField.Text = string.Empty;
			}
		}
		internal Image BuildChart(DataView data)
		{
			// select chart type
			ChartGroup cg = _chart.ChartGroups.Group0;
			Area ca = _chart.ChartArea;
			switch (_chartType.Text)
			{
				case "Area":
					cg.ChartType = Chart2DTypeEnum.Area;
					ca.Inverted = false;
					ca.AxisX.AnnotationRotation = 45;
					break;
				case "Bar":
					cg.ChartType = Chart2DTypeEnum.Bar;
					ca.Inverted = true;
					ca.AxisX.AnnotationRotation = 0;
					break;
				default:
					cg.ChartType = Chart2DTypeEnum.XYPlot;
					ca.Inverted = false;
					ca.AxisX.AnnotationRotation = 45;
					break;
			}

			// add data to the chart
			PointF[] points = new PointF[data.Count];
			for (int i = 0; i < data.Count; i++)
			{
				points[i].X = i;
				points[i].Y = float.Parse(data[i]["ProductSales"].ToString());
			}
			cg.ChartData.SeriesList[0].PointData.CopyDataIn(points);

			// add X labels to the chart
			Axis ax = _chart.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			for (int i = 0; i < data.Count; i++)
				ax.ValueLabels.Add(i, data[i]["ProductName"].ToString());
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;

			// get chart image
			return _chart.GetImage(ImageFormat.Emf);
		}

		private void _tbPreview_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// render report
			if (e.Button == this._btnRenderReport)
				RenderReport();

			// print report
			else if (e.Button == _btnPrintReport)
				_c1r.Document.Print();

			// navigate
            else if (e.Button == _btnFirst)
                _ppv.StartPageIdx = 0;
            else if (e.Button == _btnLast)
                _ppv.StartPageIdx = 100000;
            else if (e.Button == _btnPrev)
                _ppv.StartPageIdx--;
            else if (e.Button == _btnNext)
                _ppv.StartPageIdx++;

			// zoom
            else if (e.Button == _btnActual)
			{
				_ppv.ZoomFactor = 1;
				_ppv.Rows = 1;
				_ppv.Cols = 1;
			}
            else if (e.Button == _btnOnePage)
			{
				_ppv.ZoomMode = ZoomModeEnum.WholePage;
				_ppv.Rows = 1;
                _ppv.Cols = 1;
			}
            else if (e.Button == _btnTwoPages)
			{
                _ppv.ZoomMode = ZoomModeEnum.WholePage;
				_ppv.Rows = 1;
                _ppv.Cols = 2;
			}
		}
		private void _mnZoom_Click(object sender, System.EventArgs e)
		{
			_ppv.Rows = _ppv.Cols = 1;
			string zoom = ((MenuItem)sender).Text.Replace("%", "");
			_ppv.ZoomFactor = double.Parse(zoom) / 100.0;
		}
	}
}
