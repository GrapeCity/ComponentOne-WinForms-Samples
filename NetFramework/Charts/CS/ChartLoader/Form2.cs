using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ChartLoader
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class frmPropGrid : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PropertyGrid propertyGrid1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmPropGrid()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )//!!VBReplace-Overrides-Overloads Overrides-
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.CommandsVisibleIfAvailable = true;
			this.propertyGrid1.LargeButtons = false;
			this.propertyGrid1.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(320, 424);
			this.propertyGrid1.TabIndex = 0;
			this.propertyGrid1.Text = "propertyGrid1";
			this.propertyGrid1.ViewBackColor = System.Drawing.SystemColors.Window;
			this.propertyGrid1.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// frmPropGrid
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(400, 533);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.propertyGrid1});
			this.Name = "frmPropGrid";
			this.Text = "Chart Properties";
			this.Resize += new System.EventHandler(this.frmPropGrid_Resize);
			this.Load += new System.EventHandler(this.frmPropGrid_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void frmPropGrid_Load(object sender, System.EventArgs e)
		{
			propertyGrid1.Location = new Point(0);
			propertyGrid1.Size = this.ClientSize;
			propertyGrid1.ToolbarVisible = true;
			propertyGrid1.Refresh();
		}

		private void frmPropGrid_Resize(object sender, System.EventArgs e)
		{
			propertyGrid1.Size = this.ClientSize;
		}

		public object ChartObject
		{
			get { return propertyGrid1.SelectedObject; }
			set { propertyGrid1.SelectedObject = value; }
		}
	}
}
