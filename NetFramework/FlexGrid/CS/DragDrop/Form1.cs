using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace DragDrop
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:22;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.DragMode = C1.Win.FlexGrid.DragModeEnum.Automatic;
			this._flex.DropMode = C1.Win.FlexGrid.DropModeEnum.Automatic;
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(384, 253);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			this._flex.DragOver += new System.Windows.Forms.DragEventHandler(this._flex_DragOver);
			this._flex.DragEnter += new System.Windows.Forms.DragEventHandler(this._flex_DragEnter);
			this._flex.DragLeave += new System.EventHandler(this._flex_DragLeave);
			this._flex.DragDrop += new System.Windows.Forms.DragEventHandler(this._flex_DragDrop);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 253);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: Customized Drag Drop";
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

		// data is being dragged over the grid for the first time
		//
		// Customization #1:
		// handle this to make sure only numbers can be dropped.
		// (anything can be dragged, perhaps to drop into another app). 
		//
        bool _validData;
		private void _flex_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			// get the data
			string str = e.Data.GetData(typeof(string)) as string;

			// no empty data
			if (str == null || str.Length == 0)
			{
                _validData = false;
                return;
			}

			// check for numbers
			if (str != null)
			{
				double d;
				string[] cells = str.Split('\t', '\n', '\r');
				foreach (string cell in cells)
				{
                    // not a number? bail
					if (cell.Length > 0 && !double.TryParse(cell, System.Globalization.NumberStyles.Any, null, out d))
					{
                        _validData = false;
                        return;
					}
				}
			}

            // data is valid
            Console.WriteLine("good data");
            _validData = true;
        }

		// data is being dragged over the grid
		//
		// Customization #2:
		// only allow copying (not moving).
		// 
		private void _flex_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			e.Effect = (_validData)? DragDropEffects.Copy: DragDropEffects.None;
		}

		// data is being dragged over the grid for the last time
		private void _flex_DragLeave(object sender, System.EventArgs e)
		{
			Console.WriteLine("_flex_DragLeave");
		}

		// some data was dropped on the grid
		private void _flex_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			Console.WriteLine("_flex_DragDrop");
		}
	}
}
