using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.IO;
using C1.Win.FlexGrid;

namespace RTFGrid
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGridPrintable2 _flex;
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

            #region C1FlexGridPrinter
			//
			// NOTE: because RTF in this sample is rendered via OwnerDraw cells, simply
            // using a C1FlexGridPrintable2 would render RTF exactly as they are rendered
            // in the grid. BUT, using a C1.C1Preview.RenderRichText enables a number of
            // other features as the generated C1PrintDocument will "know" that the cell's
            // content is actually RTF, and treat it as such. E.g. automatic row heights
            // adjustment will accommodate all text etc. Hence this.
			//
            _flex.PrintCell += new C1FlexGridPrintable2.PrintCellEventHandler(_flex_PrintCell);
            #endregion
        }

        #region C1FlexGridPrinter
        void _flex_PrintCell(object sender, C1FlexGridPrintable2.PrintCellEventArgs e)
        {
            string rtfText = _flex.GetDataDisplay(e.Row, e.Col);
            if (rtfText.StartsWith(@"{\rtf"))
            {
                C1.C1Preview.RenderRichText rtf = new C1.C1Preview.RenderRichText(rtfText);
                e.TableCell.RenderObject = rtf;
            }
        }
        #endregion

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
            this._flex = new C1.Win.FlexGrid.C1FlexGridPrintable2();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:23;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(567, 330);
            this._flex.TabIndex = 0;
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(567, 330);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.Text = "C1FlexGrid: RTF in cells";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		void Form1_Load(object sender, System.EventArgs e)
		{
			// set up grid
			_flex.AutoResize = false;
			_flex.AllowResizing = AllowResizingEnum.Both;
			_flex.DrawMode = DrawModeEnum.OwnerDraw;
			_flex.Rows.DefaultSize = 80;
			_flex.Rows[0].Height   = 20;
			_flex.Cols[0].Width    = 20;
			_flex.ShowCursor = true;

			// load DataSet with Employees table and RTF
            DataSet ds = new DataSet();
            ds.ReadXml(new StringReader(C1FlexGridPrinterTest.Properties.Resources.RtfDataSet));

            // bind grid
			_flex.DataSource = ds.Tables[0];

			// make Notes field conspicuous
			Column colNotes = _flex.Cols["Notes"];
			colNotes.Width = 5 * colNotes.WidthDisplay;
			_flex.Cols.Move(colNotes.Index, 3);

            // use RTF class to edit values in the "Notes" column
            colNotes.Editor = new RTF();

			// use a different backcolor
            colNotes.StyleNew.BackColor = Color.LightGoldenrodYellow;
			_flex.Styles.Normal.BackColor = Color.Bisque;
		}

        // use this RTF control to render RTF cells
		RTF _rtf = new RTF();
		void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
            #region C1FlexGridPrinter
            // printing RTF text is handled by _flex_PrintCell handler:
            if (_flex.IsPrinting)
                return;
            #endregion

            // check whether the cell contains RTF
			string rtfText = _flex.GetDataDisplay(e.Row, e.Col);
			if (rtfText.StartsWith(@"{\rtf"))
			{
				// it does, so draw background
				e.DrawCell(DrawCellFlags.Background);
				
				// draw the RTF text
				if (e.Bounds.Width > 0 && e.Bounds.Height > 0)
				{
					_rtf.Rtf = rtfText;
					_rtf.ForeColor = e.Style.ForeColor;
					_rtf.BackColor = e.Style.BackColor;
					_rtf.Render(e.Graphics, e.Bounds);
				}

				// and draw border last
				e.DrawCell(DrawCellFlags.Border);

				// we're done with this cell
				e.Handled = true;
			}
		}
	}
}
