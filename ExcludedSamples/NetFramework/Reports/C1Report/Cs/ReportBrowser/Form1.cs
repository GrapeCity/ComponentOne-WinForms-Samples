//----------------------------------------------------------------------
//
// ReportTest.cs
//
// Test application for the C1Report object.
//
//----------------------------------------------------------------------
using System;
using System.Xml;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

using C1.C1Report;

namespace ReportTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuOpen;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuExit;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListBox lstReports;
        private C1.C1Report.C1Report c1Report1;
		private System.Windows.Forms.StatusBar stat;
		private System.Windows.Forms.ToolBar toolBar1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolBarButton tbActual;
		private System.Windows.Forms.ToolBarButton tbTwo;
		private System.Windows.Forms.ToolBarButton tbPage;
		private System.Windows.Forms.ToolBarButton toolBarButton4;
		private System.Windows.Forms.ToolBarButton tbFirst;
		private System.Windows.Forms.ToolBarButton tbPrev;
		private System.Windows.Forms.ToolBarButton tbNext;
		private System.Windows.Forms.ToolBarButton tbLast;
		private System.Windows.Forms.ToolBarButton tbPreview;
		private System.Windows.Forms.ToolBarButton toolBarButton1;
		private System.Windows.Forms.ToolBarButton tbPrint;
		private System.Windows.Forms.ToolBarButton tbInfo;
		private System.Windows.Forms.ToolBarButton tbScript;
		private System.Windows.Forms.ToolBarButton tbOpen;
		private System.Windows.Forms.MenuItem menuSave;
		private System.Windows.Forms.ToolBarButton tbSave;
		private System.Windows.Forms.MenuItem menuSaveAll;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuExport;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.Panel panel1;
		// private System.Windows.Forms.PrintPreviewControl ppv;
        private C1.Win.C1Preview.C1PreviewPane ppv;
		private System.Windows.Forms.MenuItem menuPreview;

        private string CorrectConnectionString(string cs)
        {
            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return cs;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return cs;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return cs;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            //
            return cs;
        }

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //
            // Prepare XML files in Sample dir
            //
            string[] files = Directory.GetFiles(Application.StartupPath + @"\..\..\Sample", "*.xml");
            XmlDocument xmlDoc = new XmlDocument();
            bool corrected = false;
            foreach (string file in files)
            {
                try
                {
                    xmlDoc.Load(file);
                    // select all ConnectionString nodes
                    XmlNodeList nodes = xmlDoc.SelectNodes("Reports/Report/DataSource/ConnectionString");
                    if (nodes != null && nodes.Count > 0)
                        foreach (XmlNode node in nodes)
                        {
                            string cs = CorrectConnectionString(node.InnerText);
                            if (string.Compare(cs, node.InnerText, true) != 0)
                            {
                                node.InnerText = cs;
                                corrected = true;
                            }
                        }
                    if (corrected)
                    {
                        xmlDoc.Save(file);
                    }
                }
                catch
                {
                }
            }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuSaveAll = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuExport = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuPreview = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.c1Report1 = new C1.C1Report.C1Report();
            this.stat = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.tbOpen = new System.Windows.Forms.ToolBarButton();
            this.tbSave = new System.Windows.Forms.ToolBarButton();
            this.tbPreview = new System.Windows.Forms.ToolBarButton();
            this.tbPrint = new System.Windows.Forms.ToolBarButton();
            this.tbInfo = new System.Windows.Forms.ToolBarButton();
            this.tbScript = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
            this.tbActual = new System.Windows.Forms.ToolBarButton();
            this.tbPage = new System.Windows.Forms.ToolBarButton();
            this.tbTwo = new System.Windows.Forms.ToolBarButton();
            this.toolBarButton4 = new System.Windows.Forms.ToolBarButton();
            this.tbFirst = new System.Windows.Forms.ToolBarButton();
            this.tbPrev = new System.Windows.Forms.ToolBarButton();
            this.tbNext = new System.Windows.Forms.ToolBarButton();
            this.tbLast = new System.Windows.Forms.ToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ppv = new C1.Win.C1Preview.C1PreviewPane();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ppv)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuSaveAll,
            this.menuItem2,
            this.menuExport,
            this.menuItem3,
            this.menuPreview,
            this.menuItem4,
            this.menuItem5,
            this.menuExit});
            this.menuItem1.Text = "&File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Text = "&Open...";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Index = 1;
            this.menuSave.Text = "&Save Current...";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAll
            // 
            this.menuSaveAll.Index = 2;
            this.menuSaveAll.Text = "Save &All...";
            this.menuSaveAll.Click += new System.EventHandler(this.menuSaveAll_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // menuExport
            // 
            this.menuExport.Index = 4;
            this.menuExport.Text = "Export...";
            this.menuExport.Click += new System.EventHandler(this.menuExport_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 5;
            this.menuItem3.Text = "-";
            // 
            // menuPreview
            // 
            this.menuPreview.Index = 6;
            this.menuPreview.Text = "Pre&view...";
            this.menuPreview.Click += new System.EventHandler(this.menuPreview_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 7;
            this.menuItem4.Text = "&Print";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 8;
            this.menuItem5.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 9;
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // lstReports
            // 
            this.lstReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstReports.IntegralHeight = false;
            this.lstReports.Location = new System.Drawing.Point(0, 28);
            this.lstReports.Name = "lstReports";
            this.lstReports.Size = new System.Drawing.Size(196, 526);
            this.lstReports.TabIndex = 0;
            this.lstReports.DoubleClick += new System.EventHandler(this.lstReports_DoubleClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(196, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 526);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // c1Report1
            // 
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.NoData += new System.EventHandler(this.c1Report1_NoData);
            this.c1Report1.StartReport += new System.EventHandler(this.c1Report1_StartReport);
            this.c1Report1.ReportError += new C1.C1Report.ReportEventHandler(this.c1Report1_ReportError);
            this.c1Report1.EndReport += new System.EventHandler(this.c1Report1_EndReport);
            this.c1Report1.StartPage += new C1.C1Report.ReportEventHandler(this.c1Report1_StartPage);
            // 
            // stat
            // 
            this.stat.Location = new System.Drawing.Point(0, 554);
            this.stat.Name = "stat";
            this.stat.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.stat.ShowPanels = true;
            this.stat.Size = new System.Drawing.Size(720, 23);
            this.stat.TabIndex = 2;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Width = 703;
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.tbOpen,
            this.tbSave,
            this.tbPreview,
            this.tbPrint,
            this.tbInfo,
            this.tbScript,
            this.toolBarButton1,
            this.tbActual,
            this.tbPage,
            this.tbTwo,
            this.toolBarButton4,
            this.tbFirst,
            this.tbPrev,
            this.tbNext,
            this.tbLast});
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.ImageList = this.imageList1;
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(720, 28);
            this.toolBar1.TabIndex = 4;
            this.toolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // tbOpen
            // 
            this.tbOpen.ImageIndex = 8;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.ToolTipText = "Open report definition file";
            // 
            // tbSave
            // 
            this.tbSave.ImageIndex = 12;
            this.tbSave.Name = "tbSave";
            this.tbSave.ToolTipText = "Save Report Definition file";
            // 
            // tbPreview
            // 
            this.tbPreview.ImageIndex = 9;
            this.tbPreview.Name = "tbPreview";
            this.tbPreview.ToolTipText = "Preview report in dialog";
            // 
            // tbPrint
            // 
            this.tbPrint.ImageIndex = 10;
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.ToolTipText = "Print report";
            // 
            // tbInfo
            // 
            this.tbInfo.ImageIndex = 7;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.ToolTipText = "Show report information";
            // 
            // tbScript
            // 
            this.tbScript.ImageIndex = 11;
            this.tbScript.Name = "tbScript";
            this.tbScript.ToolTipText = "Test scripting engine";
            // 
            // toolBarButton1
            // 
            this.toolBarButton1.Name = "toolBarButton1";
            this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbActual
            // 
            this.tbActual.ImageIndex = 0;
            this.tbActual.Name = "tbActual";
            this.tbActual.ToolTipText = "Zoom to actual page";
            // 
            // tbPage
            // 
            this.tbPage.ImageIndex = 2;
            this.tbPage.Name = "tbPage";
            this.tbPage.ToolTipText = "Zoom to whole page";
            // 
            // tbTwo
            // 
            this.tbTwo.ImageIndex = 1;
            this.tbTwo.Name = "tbTwo";
            this.tbTwo.ToolTipText = "Zoom to two pages";
            // 
            // toolBarButton4
            // 
            this.toolBarButton4.Name = "toolBarButton4";
            this.toolBarButton4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // tbFirst
            // 
            this.tbFirst.ImageIndex = 3;
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.ToolTipText = "Show first page";
            // 
            // tbPrev
            // 
            this.tbPrev.ImageIndex = 6;
            this.tbPrev.Name = "tbPrev";
            this.tbPrev.ToolTipText = "Show previous page";
            // 
            // tbNext
            // 
            this.tbNext.ImageIndex = 5;
            this.tbNext.Name = "tbNext";
            this.tbNext.ToolTipText = "Show next page";
            // 
            // tbLast
            // 
            this.tbLast.ImageIndex = 4;
            this.tbLast.Name = "tbLast";
            this.tbLast.ToolTipText = "Show last page";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ppv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(202, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 526);
            this.panel1.TabIndex = 5;
            // 
            // ppv
            // 
            this.ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ppv.Location = new System.Drawing.Point(0, 0);
            this.ppv.Name = "ppv";
            this.ppv.Size = new System.Drawing.Size(514, 522);
            this.ppv.TabIndex = 0;
            this.ppv.ZoomFactor = 0.3;
            this.ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.Custom;
            // 
            // frmMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(720, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lstReports);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.toolBar1);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Report Test Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ppv)).EndInit();
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
			Application.Run(new frmMain());
		}

		// current report definition file
		private string m_ReportFile;

		// last type of file exported
		private int m_FilterIndex;

		// for benchmarking
		private long m_Ticks;

		// open a new report definition file
		private void OpenReportDefinitionFile()
		{
			OpenFileDialog of = new OpenFileDialog();
			of.Filter = "Report Definition Files (*.xml)|*.xml";
			if (of.ShowDialog() == DialogResult.OK)
				SetReportDefinitionFile(of.FileName);
		}

		// save a report definition file containing the current report
		// or all reports in the current file
		private void SaveReportDefinitionFile(bool all)
		{
			// get file name
			SaveFileDialog sf = new SaveFileDialog();
			sf.Filter = "Report Definition Files (*.xml)|*.xml";
			sf.FileName = (all)
				? Path.GetFileName(m_ReportFile)
				: lstReports.Text + ".xml";
			if (sf.ShowDialog() != DialogResult.OK) return;

			// save a single report
			if (!all)
			{
				if (!LoadReport()) return;
				c1Report1.Save(sf.FileName);
				return;
			}

			// open xml file
			XmlTextWriter writer = new XmlTextWriter(sf.FileName, System.Text.Encoding.Default);
			writer.Formatting = Formatting.Indented;
			writer.Indentation = 2;
			writer.WriteStartDocument();
			writer.WriteStartElement("Reports");

			// save each report
			for (int i = 0; i < lstReports.Items.Count; i++)
			{
				lstReports.SelectedIndex = i;
				LoadReport();
				ShowStatus(string.Format("[{0}]: Saving...", lstReports.Text));
				c1Report1.Save(writer);
			}

			// close xml file
			writer.WriteEndElement(); // </Reports>
			writer.Close();
			ShowStatus("Ready");
		}

		// populate the listbox with a list of all reports available 
		// in the selected file, save file name to open them later
		private bool SetReportDefinitionFile(string xmlFile)
		{
			// get list of reports in the file
			string[] reports;
			ShowStatus(string.Format("[{0}]: Opening...", lstReports.Text));
			try
			{
				reports = c1Report1.GetReportInfo(xmlFile);
			}
			catch
			{
				MessageBox.Show("Failed to open the report definition file.");
				return false;
			}
			ShowStatus("Ready");

			// populate listbox with report names
			lstReports.Items.Clear();
			foreach (string report in reports)
				lstReports.Items.Add(report);

			// select first report
			if (lstReports.Items.Count > 0)
				lstReports.SelectedIndex = 0;

			// save file name to load reports later
			m_ReportFile = xmlFile;
			Text = "C1Report for .NET - " + xmlFile;

			// done
			return true;
		}

		// load the report that is currently selected in the listbox
		private bool LoadReport()
		{
			if (lstReports.Text.Length == 0)
				return false;

			bool retval = true;
			ShowStatus(string.Format("[{0}]: Loading...", lstReports.Text));
			Cursor = Cursors.WaitCursor;
			try
			{
				c1Report1.Load(m_ReportFile, lstReports.Text);
			}
			catch (Exception x)
			{
				MessageBox.Show("Failed to load the report:\r\n" + x.Message);
				retval = false;
			}

			Cursor = Cursors.Default;
			ShowStatus("Ready");
			return retval;
		}

		// render the report that is currently selected in the listbox
		private bool RenderReport()
		{
			// load report
			if (!LoadReport()) return false;

			// render report into ppv control
			ppv.StartPageIdx = 0;
			ppv.Rows = 1;
			ppv.Cols = 1;
            ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
            ppv.Document = c1Report1;

			// done
			return true;
		}

		// print the report that is currently selected in the listbox
		private bool PrintReport()
		{
			// load report
			if (!LoadReport()) return false;

			// show print dialog
			PrintDocument pDoc = c1Report1.Document;
			PrintDialog pDlg = new PrintDialog();
			pDlg.Document = pDoc;
			DialogResult dr = pDlg.ShowDialog();

			// print the document
			if (dr == DialogResult.OK)
			{
				pDoc.Print();
				return true;
			}

			// canceled
			return false;
		}
        
		// print the report that is currently selected
		private bool PreviewReport()
		{
			if (lstReports.SelectedIndex < 0)
			{
				MessageBox.Show("Please select a report to preview.");
				return false;
			}
			try
			{
				// load report
				if (!LoadReport()) return false;

				// show the dialog
				PrintPreviewDialog dlg = new PrintPreviewDialog();
				dlg.Document = c1Report1.Document;
				dlg.ShowDialog();
			}
			catch (Exception x)
			{
				MessageBox.Show("Error previewing report: " + x.Message);
				return false;
			}
			return true;
		}

		// show what we're doing
		internal void ShowStatus(string msg)
		{
			stat.Panels[0].Text = msg;
		}

		// ** event handlers

		// load default file on startup
		private void frmMain_Load(object sender, System.EventArgs e)
		{
			// if we loaded a design-time report, render it
			if (c1Report1.Fields.Count > 0)
				ppv.Document = c1Report1;

			// get application path
			string path = Path.GetDirectoryName(Application.ExecutablePath).ToLower();
			int i = path.IndexOf("/bin/");
			if (i < 0) i = path.IndexOf("\\bin\\");
			if (i > 0) path = path.Remove(i, path.Length - i);

			// get the names of all reports available in the file
			SetReportDefinitionFile(path + "\\Sample\\NWind.xml");
		}
		private void frmMain_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 27 && c1Report1.IsBusy)
				c1Report1.Cancel = true;
		}

		private void menuOpen_Click(object sender, System.EventArgs e)
		{
			OpenReportDefinitionFile();
		}
		private void menuSave_Click(object sender, System.EventArgs e)
		{
			SaveReportDefinitionFile(false);
		}
		private void menuSaveAll_Click(object sender, System.EventArgs e)
		{
			SaveReportDefinitionFile(true);
		}
		private void menuExport_Click(object sender, System.EventArgs e)
		{
			// make sure we have a report loaded
			if (!LoadReport()) return;

			// show dialog
			ShowStatus(string.Format("[{0}] Ready to Export.", lstReports.Text));
			SaveFileDialog sf = new SaveFileDialog();
			sf.Filter = "Plain HTML (*.htm)|*.htm|" + 
				"Paged HTML (*htm)|*.htm|" + 
				"Drill down HTML (*.htm)|*.htm|" +
				"Portable Document Format (*.pdf)|*.pdf|" +
				"Plain text (*.txt)|*.txt";
			sf.FileName = lstReports.Text;
			sf.AddExtension = true;
			sf.FilterIndex = m_FilterIndex;
			if (sf.ShowDialog() != DialogResult.OK) return;
			m_FilterIndex = sf.FilterIndex;

			// select file format
			FileFormatEnum fmt = FileFormatEnum.HTML;
			string ext = Path.GetExtension(sf.FileName);
			switch (ext)
			{
				case ".htm":
				switch (sf.FilterIndex)
				{
					case 1: fmt = FileFormatEnum.HTML; break;
					case 2: fmt = FileFormatEnum.HTMLPaged; break;
					case 3: fmt = FileFormatEnum.HTMLDrillDown; break;
				}
					break;
				case ".pdf":
					fmt = FileFormatEnum.PDF;
					break;
				case ".txt":
					fmt = FileFormatEnum.Text;
					break;
			}

			// render the report
			c1Report1.RenderToFile(sf.FileName, fmt);
		}
		private void menuPreview_Click(object sender, System.EventArgs e)
		{
			PreviewReport();
		}
		private void menuPrint_Click(object sender, System.EventArgs e)
		{
			PrintReport();
		}
		private void menuExit_Click(object sender, System.EventArgs e)
		{
			Close();
			Application.Exit();
		}

		private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// load a new report
			if (e.Button == tbOpen)
			{
				OpenReportDefinitionFile();
				return;
			}

			// save current report to a file
			if (e.Button == tbSave)
			{
				SaveReportDefinitionFile(false);
				return;
			}

			// preview report
			if (e.Button == tbPreview)
			{
				PreviewReport();
				return;
			}

			// print report
			if (e.Button == tbPrint)
			{
				PrintReport();
				return;
			}

			// show report info
			if (e.Button == tbInfo)
			{
				if (!LoadReport()) return;

				// build report info string
				string info = string.Format("Report [{0}]: {1} Groups, {2} Sections, {3} Fields\r\n",
					c1Report1.ReportName, 
					c1Report1.Groups.Count, 
					c1Report1.Sections.Count, 
					c1Report1.Fields.Count);

				info += "** Groups\r\n";
				for (int group = 0; group < c1Report1.Groups.Count; group++)
				{
					Group g = c1Report1.Groups[group] as Group;
					info += string.Format("  Group {0}: '{1}'\r\n", group, g.Name);
				}

				info += "** Sections\r\n";
				for (int sec = 0; sec < c1Report1.Sections.Count; sec++)
				{
					Section s = c1Report1.Sections[sec] as Section;
					info += string.Format("  Section {0}: '{1}'\r\n", sec, s.Name);
				}

				// show report info
				MessageBox.Show(info, c1Report1.ReportName);
				return;
			}

			// try script engine
			if (e.Button == tbScript)
			{
				if (!LoadReport()) return;

				MessageBox.Show("This option writes to the Console. The results can be seen only if you are tracing through the code.");
				Console.WriteLine("*** Testing C1Report script engine");

				string exp = "2 + 2";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));
            
				exp = "Report.ReportName";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));

				exp = "report.reportname";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));

				exp = "Page";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));

				exp = "Report.Layout.MarginLeft";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));

				exp = ((Field)c1Report1.Fields[0]).Name + ".BackColor";
				Console.WriteLine("  {0} = {1}", exp, c1Report1.Evaluate(exp));
				return;
			}

			// handle preview buttons
			int cnt = c1Report1.PageImages.Count;
			if (e.Button == tbFirst)
			{
				ppv.StartPageIdx = 0;
			}
			if (e.Button == tbLast)
			{
                ppv.StartPageIdx = cnt;
			}
			if (e.Button == tbPrev)
			{
                ppv.StartPageIdx--;
			}
			if (e.Button == tbNext)
			{
                ppv.StartPageIdx++;
			}
			if (e.Button == tbActual)
			{
				ppv.Cols = 1;
				ppv.ZoomFactor = 1;
			}
			if (e.Button == tbPage)
			{
				ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
				ppv.Cols = 1;
			}
			if (e.Button == tbTwo)
			{
                ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
                ppv.Cols = 2;
			}
			ShowStatus(string.Format("Page {0} of {1}", ppv.StartPageIdx+1, cnt));
		}

		// render the report that is currently selected in the listbox
		private void lstReports_DoubleClick(object sender, System.EventArgs e)
		{
			RenderReport();     
		}

		// feedback while rendering report
		private void c1Report1_StartReport(object sender, System.EventArgs e)
		{
			ShowStatus(string.Format("[{0}]: Rendering", c1Report1.ReportName));
			m_Ticks = DateTime.Now.Ticks;
		}
		private void c1Report1_EndReport(object sender, System.EventArgs e)
		{
			m_Ticks = DateTime.Now.Ticks - m_Ticks;
			double seconds = m_Ticks / (double)TimeSpan.TicksPerSecond;
			ShowStatus(string.Format("[{0}]: Ready, {1} pages in {2:0.00} seconds",
				c1Report1.ReportName,
				c1Report1.PageImages.Count,
				seconds));
		}
        private void c1Report1_StartPage(object sender, C1.C1Report.ReportEventArgs e)
		{
			ShowStatus(string.Format("[{0}]: Rendering page {1}", c1Report1.ReportName, e.Page));
		}
		private void c1Report1_NoData(object sender, System.EventArgs e)
		{
			MessageBox.Show("No data is available for this report.", "Report Cancelled");
			c1Report1.Cancel = true;
		}

		// trace errors
        private void c1Report1_ReportError(object sender, C1.C1Report.ReportEventArgs e)
		{
			Console.WriteLine("** error: {0}", e.Exception.Message);
		}
	}
}

