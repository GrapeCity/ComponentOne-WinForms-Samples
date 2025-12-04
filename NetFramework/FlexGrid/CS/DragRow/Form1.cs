using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace DragRow
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.FlexGrid.C1FlexGrid _flexLeft;
        private C1.Win.FlexGrid.C1FlexGrid _flexRight;
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
            this._flexLeft = new C1.Win.FlexGrid.C1FlexGrid();
            this._flexRight = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flexLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexRight)).BeginInit();
            this.SuspendLayout();
            // 
            // _flexLeft
            // 
            this._flexLeft.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flexLeft.Location = new System.Drawing.Point(13, 13);
            this._flexLeft.Name = "_flexLeft";
            this._flexLeft.Size = new System.Drawing.Size(600, 409);
            this._flexLeft.StyleInfo = resources.GetString("_flexLeft.StyleInfo");
            this._flexLeft.TabIndex = 0;
            this._flexLeft.UseCompatibleTextRendering = true;
            this._flexLeft.BeforeMouseDown += new C1.Win.FlexGrid.BeforeMouseDownEventHandler(this._flex_BeforeMouseDown);
            this._flexLeft.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
            this._flexLeft.DragOver += new System.Windows.Forms.DragEventHandler(this._flex_DragOver);
            // 
            // _flexRight
            // 
            this._flexRight.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this._flexRight.Location = new System.Drawing.Point(627, 13);
            this._flexRight.Name = "_flexRight";
            this._flexRight.Size = new System.Drawing.Size(600, 409);
            this._flexRight.StyleInfo = resources.GetString("_flexRight.StyleInfo");
            this._flexRight.TabIndex = 0;
            this._flexRight.UseCompatibleTextRendering = true;
            this._flexRight.BeforeMouseDown += new C1.Win.FlexGrid.BeforeMouseDownEventHandler(this._flex_BeforeMouseDown);
            this._flexRight.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
            this._flexRight.DragOver += new System.Windows.Forms.DragEventHandler(this._flex_DragOver);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(744, 274);
            this.Controls.Add(this._flexLeft);
            this.Controls.Add(this._flexRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "C1FlexGrid: Drag and Drop Rows between grids";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flexLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexRight)).EndInit();
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
            // populate grids
            _flexLeft.Rows.Count = 5;
            for (int r = 1; r < _flexLeft.Rows.Count; r++)
            {
                _flexLeft[r, 0] = "Left";
                _flexLeft[r, 1] = r;
            }
            _flexRight.Rows.Count = 5;
            for (int r = 1; r < _flexRight.Rows.Count; r++)
            {
                _flexRight[r, 0] = "Right";
                _flexRight[r, 1] = r;
            }

            // both are OLE drag sources
            _flexLeft.DragMode = DragModeEnum.Manual;
            _flexRight.DragMode = DragModeEnum.Manual;

            // both are OLE drop targets
            _flexLeft.DropMode = DropModeEnum.Manual;
            _flexRight.DropMode = DropModeEnum.Manual;
        }

        C1FlexGrid _src = null;
        private void _flex_BeforeMouseDown(object sender, C1.Win.FlexGrid.BeforeMouseDownEventArgs e)
        {
            // start dragging when the user clicks the row headers
            C1FlexGrid flex = sender as C1FlexGrid;
            HitTestInfo hti = flex.HitTest(e.X, e.Y);
            if (hti.Type == HitTestTypeEnum.RowHeader)
            {
                // select the row
                int index = hti.Row;
                flex.Select(index, 0, index, flex.Cols.Count-1, false);

                // save info for target
                _src = flex;

                // do drag drop
                DragDropEffects dd = flex.DoDragDrop(flex.Clip, DragDropEffects.Move);

                // if it worked, delete row from source (it's a move)
                if (dd == DragDropEffects.Move)
                    flex.Rows.Remove(index);

                // done, reset info
                _src = null;
            }
        }

        private void _flex_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // check whether we can drop here:

            // we must have a source object, and it should be the other grid
            // (this sample allows dragging from one to the other grid only)
            if (_src != null && !_src.Equals(sender))
            {
                // check that we have the type of data we want
                if (e.Data.GetDataPresent(typeof(string)))
                    e.Effect = DragDropEffects.Move;
            }
        }

        private void _flex_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
        {
            // find the drop position
            C1FlexGrid flex = sender as C1FlexGrid;
            Point pt = flex.PointToClient(new Point(e.X, e.Y));
            HitTestInfo hti = flex.HitTest(pt.X, pt.Y);
            int index = hti.Row;
            if (index < 0) index = flex.Rows.Count; // append
            if (index < 1) index = 1;               // after fixed row

            // insert a new row at the drop position
            flex.Rows.Insert(index);

            // copy data from source row
            flex.Select(index, 0, index, flex.Cols.Count-1, false);
            flex.Clip = (string)e.Data.GetData(typeof(string));
        }
	}
}
