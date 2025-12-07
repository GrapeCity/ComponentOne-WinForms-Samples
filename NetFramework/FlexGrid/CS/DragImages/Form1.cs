using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DragImages
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.ImageList _imgList;
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
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.DragMode = C1.Win.FlexGrid.DragModeEnum.Automatic;
            this._flex.DropMode = C1.Win.FlexGrid.DropModeEnum.Manual;
            this._flex.Location = new System.Drawing.Point(0, 0);
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(568, 334);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 0;
            this._flex.UseCompatibleTextRendering = true;
            this._flex.StartDrag += new System.Windows.Forms.DragEventHandler(this._flex_StartDrag);
            this._flex.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
            this._flex.DragEnter += new System.Windows.Forms.DragEventHandler(this._flex_DragEnter);
            // 
            // _imgList
            // 
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Red;
            this._imgList.Images.SetKeyName(0, "");
            this._imgList.Images.SetKeyName(1, "");
            this._imgList.Images.SetKeyName(2, "");
            this._imgList.Images.SetKeyName(3, "");
            this._imgList.Images.SetKeyName(4, "");
            this._imgList.Images.SetKeyName(5, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(568, 334);
            this.Controls.Add(this._flex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Drag and Drop Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
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
			for (int r = 0; r < _flex.Rows.Count; r++)
			{
				_flex.SetCellImage(r, 1, this._imgList.Images[r % _imgList.Images.Count]);
			}
		}

		// store image to drag in Data object
		private void _flex_StartDrag(object sender, System.Windows.Forms.DragEventArgs e)
		{
			int row = _flex.MouseRow;
			int col = _flex.MouseCol;
			if (row > -1 && col > -1)
			{
				Image img = _flex.GetCellImage(row, col);
				if (img != null)
				{
					e.Data.SetData(img);
				}
			}
		}

		// allow dropping on grid
		private void _flex_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			int row = _flex.MouseRow;
			int col = _flex.MouseCol;
			if (row > -1 && col > -1)
			{
				Image img = e.Data.GetData(typeof(Bitmap)) as Image;
				if (img != null)
				{
					e.Effect = DragDropEffects.Copy | DragDropEffects.Move;
				}
			}
		}

		// apply image to cell
		private void _flex_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			int row = _flex.MouseRow;
			int col = _flex.MouseCol;
			if (row > -1 && col > -1)
			{
				Image img = e.Data.GetData(typeof(Bitmap)) as Image;
				if (img != null)
				{
					_flex.SetCellImage(row, col, img);
					_flex.Select(row, col);
				}
			}
		}
	}
}
