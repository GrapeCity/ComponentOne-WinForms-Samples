using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.FlexGrid;
using C1.Win;

namespace Splits
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form, C1FlexGridPrinterTest.IFlexSample
    {
        #region C1FlexGridPrinter
        private int _currPrintedGrid = 0; // used to track the grid currently being printed, for better progress display
        private LongOperationEventHandler _callerLongOperation = null;

        public C1.C1Preview.C1PrintDocument MakeDoc(C1FlexGridPrintInfo printInfo, LongOperationEventHandler longOperation)
        {
            _callerLongOperation = longOperation;
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();
            // there are many ways to skin a cat, or to render the four splits.
            // here, we use a master table with two rows and two columns,
            // rendering each grid in its own cell:
            C1.C1Preview.RenderTable table = new C1.C1Preview.RenderTable();
            C1FlexGridPrinter prnTL = new C1FlexGridPrinter(_flexTL);
            prnTL.PrintInfo = printInfo;
            prnTL.LongOperation += new LongOperationEventHandler(print_LongOperation);
            C1FlexGridPrinter prnTR = new C1FlexGridPrinter(_flexTR);
            prnTR.PrintInfo = printInfo;
            prnTR.LongOperation += new LongOperationEventHandler(print_LongOperation);
            C1FlexGridPrinter prnBL = new C1FlexGridPrinter(_flexBL);
            prnBL.PrintInfo = printInfo;
            prnBL.LongOperation += new LongOperationEventHandler(print_LongOperation);
            C1FlexGridPrinter prnBR = new C1FlexGridPrinter(_flexBR);
            prnBR.PrintInfo = printInfo;
            prnBR.LongOperation += new LongOperationEventHandler(print_LongOperation);
            _currPrintedGrid = 0;
            table.Cells[0, 0].RenderObject = prnTL.MakeGridTable(doc);
            _currPrintedGrid = 1;
            table.Cells[0, 1].RenderObject = prnTR.MakeGridTable(doc);
            _currPrintedGrid = 2;
            table.Cells[1, 0].RenderObject = prnBL.MakeGridTable(doc);
            _currPrintedGrid = 3;
            table.Cells[1, 1].RenderObject = prnBR.MakeGridTable(doc);
            // by default, a table's width is set to 100% of its parent (here, page).
            // so we set it to auto, and enable horizontal page breaks:
            table.Width = "auto";
            table.SplitHorzBehavior = C1.C1Preview.SplitBehaviorEnum.SplitIfNeeded;
            // by default, table rows and columns do not split; enable it here:
            table.Rows[0].SplitBehavior = C1.C1Preview.SplitBehaviorEnum.SplitIfNeeded;
            table.Rows[1].SplitBehavior = C1.C1Preview.SplitBehaviorEnum.SplitIfNeeded;
            table.Cols[0].SplitBehavior = C1.C1Preview.SplitBehaviorEnum.SplitIfNeeded;
            table.Cols[1].SplitBehavior = C1.C1Preview.SplitBehaviorEnum.SplitIfNeeded;
            // add thick blue gridlines between the splits:
            table.Style.GridLines.All = new C1.C1Preview.LineDef("2pt", Color.Blue);
            // the table with four splits is ready - add it to the documment:
            doc.Body.Children.Add(table);
            // use page headers from the top left grid:
            doc.PageLayout.PageHeader = prnTL.MakePageHeader(doc);
            doc.PageLayout.PageFooter = prnTL.MakePageFooter(doc);
            // done:
            return doc;
        }

        void print_LongOperation(object sender, LongOperationEventArgs e)
        {
            if (_callerLongOperation != null)
            {
                double complete = (_currPrintedGrid + e.Complete) / 4;
                LongOperationEventArgs earg = new LongOperationEventArgs(complete, e.CanCancel);
                _callerLongOperation(sender, earg);
            }
        }
        #endregion

		private System.Windows.Forms.Panel panel1;
		private C1.Win.FlexGrid.C1FlexGrid _flexTL;
		private System.Windows.Forms.Splitter _splitterTop;
		private C1.Win.FlexGrid.C1FlexGrid _flexTR;
		private System.Windows.Forms.Panel panel2;
		private C1.Win.FlexGrid.C1FlexGrid _flexBR;
		private System.Windows.Forms.Splitter _splitterBottom;
		private C1.Win.FlexGrid.C1FlexGrid _flexBL;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter3;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._flexTR = new C1.Win.FlexGrid.C1FlexGrid();
            this._splitterTop = new System.Windows.Forms.Splitter();
            this._flexTL = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this._flexBR = new C1.Win.FlexGrid.C1FlexGrid();
            this._splitterBottom = new System.Windows.Forms.Splitter();
            this._flexBL = new C1.Win.FlexGrid.C1FlexGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexTL)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexBR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexBL)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._flexTR);
            this.panel1.Controls.Add(this._splitterTop);
            this.panel1.Controls.Add(this._flexTL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 152);
            this.panel1.TabIndex = 0;
            // 
            // _flexTR
            // 
            this._flexTR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flexTR.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flexTR.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexTR.Location = new System.Drawing.Point(182, 0);
            this._flexTR.Name = "_flexTR";
            this._flexTR.Size = new System.Drawing.Size(357, 152);
            this._flexTR.StyleInfo = resources.GetString("_flexTR.StyleInfo");
            this._flexTR.TabIndex = 2;
            this._flexTR.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            // 
            // _splitterTop
            // 
            this._splitterTop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._splitterTop.Location = new System.Drawing.Point(176, 0);
            this._splitterTop.Name = "_splitterTop";
            this._splitterTop.Size = new System.Drawing.Size(6, 152);
            this._splitterTop.TabIndex = 1;
            this._splitterTop.TabStop = false;
            this._splitterTop.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this._splitterTop_SplitterMoved);
            // 
            // _flexTL
            // 
            this._flexTL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flexTL.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flexTL.Dock = System.Windows.Forms.DockStyle.Left;
            this._flexTL.Location = new System.Drawing.Point(0, 0);
            this._flexTL.Name = "_flexTL";
            this._flexTL.Size = new System.Drawing.Size(176, 152);
            this._flexTL.StyleInfo = resources.GetString("_flexTL.StyleInfo");
            this._flexTL.TabIndex = 0;
            this._flexTL.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._flexBR);
            this.panel2.Controls.Add(this._splitterBottom);
            this.panel2.Controls.Add(this._flexBL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 207);
            this.panel2.TabIndex = 0;
            // 
            // _flexBR
            // 
            this._flexBR.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flexBR.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flexBR.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexBR.Location = new System.Drawing.Point(182, 0);
            this._flexBR.Name = "_flexBR";
            this._flexBR.Size = new System.Drawing.Size(357, 207);
            this._flexBR.StyleInfo = resources.GetString("_flexBR.StyleInfo");
            this._flexBR.TabIndex = 2;
            this._flexBR.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            // 
            // _splitterBottom
            // 
            this._splitterBottom.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._splitterBottom.Location = new System.Drawing.Point(176, 0);
            this._splitterBottom.Name = "_splitterBottom";
            this._splitterBottom.Size = new System.Drawing.Size(6, 207);
            this._splitterBottom.TabIndex = 1;
            this._splitterBottom.TabStop = false;
            this._splitterBottom.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this._splitterBottom_SplitterMoved);
            // 
            // _flexBL
            // 
            this._flexBL.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this._flexBL.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flexBL.Dock = System.Windows.Forms.DockStyle.Left;
            this._flexBL.Location = new System.Drawing.Point(0, 0);
            this._flexBL.Name = "_flexBL";
            this._flexBL.Size = new System.Drawing.Size(176, 207);
            this._flexBL.StyleInfo = resources.GetString("_flexBL.StyleInfo");
            this._flexBL.TabIndex = 0;
            this._flexBL.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.splitter3);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(543, 369);
            this.panel3.TabIndex = 1;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 152);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(539, 6);
            this.splitter3.TabIndex = 1;
            this.splitter3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(543, 369);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Splits";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexTL)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexBR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexBL)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		// set up the splits
		void Form1_Load(object sender, System.EventArgs e)
		{
			// bind subordinate splits to 'master' split
			// (all subordinate splits use master as a DataSource)
			_flexBL.DataSource = 
			_flexBR.DataSource = 
			_flexTR.DataSource = _flexTL;

			// adjust scrollbars
			_flexTL.ScrollBars = ScrollBars.None;
			_flexTR.ScrollBars = ScrollBars.Vertical;
			_flexBL.ScrollBars = ScrollBars.Horizontal;
			_flexBR.ScrollBars = ScrollBars.Both;

			// cosmetic
			_flexTL.Cols[0].Width = _flexTL.Rows[0].HeightDisplay;
			_flexTL.ShowCursor = _flexTR.ShowCursor = _flexBL.ShowCursor = _flexBR.ShowCursor = true;

			// bind main grid to a data source
			string conn = GetConnectionString();
			string rs = "select * from Customers;";
			OleDbDataAdapter da = new OleDbDataAdapter(rs, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			_flexTL.DataSource = dt;
		}

		// keep vertical splitters in synch
		void _splitterTop_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			_flexBL.Width = _flexTL.Width;
		}
		void _splitterBottom_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
			_flexTL.Width = _flexBL.Width;
		}

		// synchronize grid scrolling
		bool _synchronizing = false;
		void _flex_AfterScroll(object sender, C1.Win.FlexGrid.RangeEventArgs e)
		{
			if (!_synchronizing)
			{
				// avoid reentrant calls
				_synchronizing = true;

				// get new scrollposition for sender control
				C1FlexGrid src = sender as C1FlexGrid;
				src.Update();
				Point pt = src.ScrollPosition;

				// apply to others
				if (src.Equals(this._flexTL))
				{
					_flexTR.ScrollPosition = new Point(_flexTR.ScrollPosition.X, pt.Y);
					_flexBL.ScrollPosition = new Point(pt.X, _flexBL.ScrollPosition.Y);
				}
				else if (src.Equals(this._flexTR))
				{
					_flexTL.ScrollPosition = new Point(_flexTL.ScrollPosition.X, pt.Y);
					_flexBR.ScrollPosition = new Point(pt.X, _flexBR.ScrollPosition.Y);
				}
				else if (src.Equals(this._flexBL))
				{
					_flexTL.ScrollPosition = new Point(pt.X, _flexTL.ScrollPosition.Y);
					_flexBR.ScrollPosition = new Point(_flexBR.ScrollPosition.X, pt.Y);
				}
				else if (src.Equals(this._flexBR))
				{
					_flexBL.ScrollPosition = new Point(_flexBL.ScrollPosition.X, pt.Y);
					_flexTR.ScrollPosition = new Point(pt.X, _flexTR.ScrollPosition.Y);
				}

				// done
				_synchronizing = false;
			}
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
