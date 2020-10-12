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
		private C1.Win.C1FlexGrid.C1FlexGrid _flex;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.DragMode = C1.Win.C1FlexGrid.DragModeEnum.Automatic;
			this._flex.DropMode = C1.Win.C1FlexGrid.DropModeEnum.Manual;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(568, 334);
			this._flex.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:232, 232, 216;ForeColor:0, 0, 0;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:48, 104, 192;ForeColor:248, 252, 248;}	Search{BackColor:48, 104, 192;ForeColor:248, 252, 248;}	Frozen{BackColor:240, 244, 216;}	EmptyArea{BackColor:128, 128, 128;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:0, 0, 0;ForeColor:248, 252, 248;}	Subtotal0{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	Subtotal1{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	Subtotal2{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	Subtotal3{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	Subtotal4{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	Subtotal5{BackColor:112, 108, 96;ForeColor:248, 252, 248;}	");
			this._flex.TabIndex = 0;
			this._flex.StartDrag += new System.Windows.Forms.DragEventHandler(this._flex_StartDrag);
			this._flex.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
			this._flex.DragEnter += new System.Windows.Forms.DragEventHandler(this._flex_DragEnter);
			// 
			// _imgList
			// 
			this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._imgList.ImageSize = new System.Drawing.Size(16, 15);
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Red;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(568, 334);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
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
