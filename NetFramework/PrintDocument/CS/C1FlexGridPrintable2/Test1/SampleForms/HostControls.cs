using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace HostControls
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.FlexGrid.C1FlexGridPrintable2 _flex;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
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
            #region C1FlexGridPrinter
            _flex.PrintCell += new C1FlexGridPrintable2.PrintCellEventHandler(_flex_PrintCell);
            #endregion
        }

        #region C1FlexGridPrinter
        void _flex_PrintCell(object sender, C1FlexGridPrintable2.PrintCellEventArgs e)
        {
            // find a HostedControl matching the current cell
            // (NOTE: this only fits a small sample; for real life cells most probably
            // will need to hold references to their controls for direct access.)
            foreach (HostedControl hc in _al)
            {
                if (hc._row.Index == e.Row && hc._col.Index == e.Col)
                {
                    C1.C1Preview.RenderImage ri = new C1.C1Preview.RenderImage();
                    ri.Control = hc._ctl;
                    e.TableCell.RenderObject = ri;
                    break;
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGridPrintable2();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,1,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Rows.Frozen = 2;
            this._flex.Size = new System.Drawing.Size(632, 328);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.Paint += new System.Windows.Forms.PaintEventHandler(this._flex_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(376, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(208, 112);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 86);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 86);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(200, 86);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._flex);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Host controls in grid cells";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

    }
		#endregion

		ArrayList _al = new ArrayList();

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// allow user to resize rows/cols (hosted controls will resize automatically)
			_flex.AllowResizing = AllowResizingEnum.Both;

			// create some new controls
			Button btn1 = new Button();
			btn1.BackColor = SystemColors.Control;
			btn1.Text = "Hosted Button 1";

			Button btn2 = new Button();
			btn2.BackColor = SystemColors.Control;
			btn2.Text = "Hosted Button 2";

			TextBox tbx = new TextBox();
			tbx.Multiline = true; // << need this to be able to set TextBox.Height
			tbx.Text = "Hosted TextBox";

			C1FlexGrid grd = new C1FlexGrid();
			grd[0,0] = grd[1,1] = "Hosted grid";

			// host them in the C1FlexGrid
			_al.Add(new HostedControl(_flex, btn1, 1, 1));
			_al.Add(new HostedControl(_flex, btn2, 5, 1));
			_al.Add(new HostedControl(_flex, tbx,  3, 2));
			_al.Add(new HostedControl(_flex, grd,  4, 3));

			// and host the index tab that was created at design time as well
			_al.Add(new HostedControl(_flex, tabControl1, 5, 4));

			// increase row heights and column widths to show the hosted controls
			_flex.Rows[4].Height = 150;
			_flex.Rows[5].Height = 150;
			_flex.Cols[3].Width  = 150;
			_flex.Cols[4].Width  = 150;
		}

		// update all hosted controls when the grid changes in any way
		private void _flex_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			foreach (HostedControl hosted in _al)
				hosted.UpdatePosition();
		}
	}

	/// <summary>
	/// HostedControl
	/// helper class that contains a control hosted within a C1FlexGrid
	/// </summary>
	internal class HostedControl
	{
		internal C1FlexGrid	_flex;
		internal Control	_ctl;
		internal Row		_row;
		internal Column		_col;

		internal HostedControl(C1FlexGrid flex, Control hosted, int row, int col)
		{
			// save info
			_flex = flex;
			_ctl  = hosted;
			_row  = flex.Rows[row];
			_col  = flex.Cols[col];

			// insert hosted control into grid
			_flex.Controls.Add(_ctl);
		}
		internal bool UpdatePosition()
		{
			// get row/col indices
			int r = _row.Index;
			int c = _col.Index;
			if (r < 0 || c < 0) return false;

			// get cell rect
			Rectangle rc = _flex.GetCellRect(r, c, false);

			// hide control if out of range
			if (rc.Width <= 0 || rc.Height <= 0 || !rc.IntersectsWith(_flex.ClientRectangle))
			{
				_ctl.Visible = false;
				return true;
			}

			// move the control and show it
			_ctl.Bounds = rc;
			_ctl.Visible = true;

			// done
			return true;
		}
	}
}
