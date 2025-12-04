using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoSizeEdit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid flex;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.flex = new C1.Win.FlexGrid.C1FlexGrid();
			((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
			this.SuspendLayout();
			// 
			// flex
			// 
			this.flex.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
			this.flex.BackColor = System.Drawing.SystemColors.Window;
			this.flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flex.Name = "flex";
			this.flex.Size = new System.Drawing.Size(432, 273);
			this.flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.flex.TabIndex = 0;
			this.flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageCollapsed")));
			this.flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageExpanded")));
			this.flex.ChangeEdit += new System.EventHandler(this.flex_ChangeEdit);
			this.flex.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this.flex_AfterEdit);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.flex});
			this.Name = "Form1";
			this.Text = "C1FlexGrid: AutoSize rows as you type";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
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
			flex.Styles.Normal.WordWrap = true;
		}
		private void flex_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			flex.AutoSizeRow(e.Row);		
		}
		private void flex_ChangeEdit(object sender, System.EventArgs e)
		{
			using (Graphics g = flex.CreateGraphics())
			{
				// measure text height
				StringFormat sf = new StringFormat();
				int wid     = flex.Cols[flex.Col].WidthDisplay - 2;
				string text = flex.Editor.Text;
				SizeF sz    = g.MeasureString(text, flex.Font, wid, sf);

				// adjust row height if necessary
				C1.Win.FlexGrid.Row row = flex.Rows[flex.Row];
				if (sz.Height + 4 > row.HeightDisplay)
					row.HeightDisplay = (int)sz.Height + 4;
			}
		}
	}
}
