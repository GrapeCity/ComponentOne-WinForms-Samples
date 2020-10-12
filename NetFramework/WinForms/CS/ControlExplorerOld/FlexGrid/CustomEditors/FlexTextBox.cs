using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid.CustomEditors
{
	/// <summary>
	/// FlexTextBox is a resizable multiline textbox written to display as an editor in C1FlexGrid.
	/// 
	/// It was modeled after the CellNote editor from the CellNotes demo
	/// </summary>
	public class FlexTextBox : TextBox
	{
		private System.Windows.Forms.Label _lblGrip;
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor.
		/// </summary>
		public FlexTextBox()
		{
			InitializeComponent();
            
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		//------------------------------------------------------------------------------------------------------
		#region ** Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexTextBox));
            this._lblGrip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblGrip
            // 
            this._lblGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._lblGrip.BackColor = System.Drawing.Color.Transparent;
            this._lblGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._lblGrip.Image = ((System.Drawing.Image)(resources.GetObject("_lblGrip.Image")));
            this._lblGrip.Location = new System.Drawing.Point(100, 0);
            this._lblGrip.Name = "_lblGrip";
            this._lblGrip.Size = new System.Drawing.Size(16, 16);
            this._lblGrip.TabIndex = 1;
            this._lblGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this._lblGrip_MouseMove);
            this._lblGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this._lblGrip_MouseDown);
            // 
            // TextBox
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this._lblGrip);
            this.Size = new System.Drawing.Size(120, 20);
            this.MinimumSize = new System.Drawing.Size(120, 20);
            this.Multiline = true;
            this.ResumeLayout(false);

		}
		#endregion	

		//------------------------------------------------------------------------------------------------------
		#region ** overrides/event handlers

		// handle resizing the textbox
		private Point _ptDown;
		private Size  _szDown;
		private void _lblGrip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			_ptDown = Control.MousePosition;
			_szDown = Size;
		}
		private void _lblGrip_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) != 0)
			{
				Point p = Control.MousePosition;
				Size = new Size(
					_szDown.Width  + (p.X - _ptDown.X),
					_szDown.Height + (p.Y - _ptDown.Y));
			}
		}

		#endregion
	}
}
