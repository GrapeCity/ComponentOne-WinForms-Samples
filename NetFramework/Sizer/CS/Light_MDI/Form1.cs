using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Mdi
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem mnuCascade;
		private System.Windows.Forms.MenuItem mnuHorizontal;
		private System.Windows.Forms.MenuItem mnuVertical;
		private System.Windows.Forms.MenuItem mnuArrangeIcons;
		private System.Windows.Forms.MenuItem mnuAddChild;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.mnuAddChild = new System.Windows.Forms.MenuItem();
			this.mnuArrangeIcons = new System.Windows.Forms.MenuItem();
			this.mnuCascade = new System.Windows.Forms.MenuItem();
			this.mnuHorizontal = new System.Windows.Forms.MenuItem();
			this.mnuVertical = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.mnuAddChild,
																					  this.mnuArrangeIcons,
																					  this.mnuCascade,
																					  this.mnuHorizontal,
																					  this.mnuVertical});
			this.menuItem1.Text = "Child Forms";
			// 
			// mnuAddChild
			// 
			this.mnuAddChild.Index = 0;
			this.mnuAddChild.Text = "Add Child";
			this.mnuAddChild.Click += new System.EventHandler(this.mnuAddChild_Click);
			// 
			// mnuArrangeIcons
			// 
			this.mnuArrangeIcons.Index = 1;
			this.mnuArrangeIcons.Text = "Arrange Icons";
			this.mnuArrangeIcons.Click += new System.EventHandler(this.mnuArrangeIcons_Click);
			// 
			// mnuCascade
			// 
			this.mnuCascade.Index = 2;
			this.mnuCascade.Text = "Cascade";
			this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
			// 
			// mnuHorizontal
			// 
			this.mnuHorizontal.Index = 3;
			this.mnuHorizontal.Text = "Tile Horizontal";
			this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
			// 
			// mnuVertical
			// 
			this.mnuVertical.Index = 4;
			this.mnuVertical.Text = "Tile Vertical";
			this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(616, 337);
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1SizerLight: In MDI Forms";
			this.Load += new System.EventHandler(this.Form1_Load);

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

		// layout child forms
		private void mnuArrangeIcons_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.ArrangeIcons);
		}
		private void mnuCascade_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.Cascade);
		}
		private void mnuHorizontal_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
		private void mnuVertical_Click(object sender, System.EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		// create a new child form
		int _cnt = 1;
		private void mnuAddChild_Click(object sender, System.EventArgs e)
		{
			ChildForm cf = new ChildForm();
			cf.Name = cf.Text = string.Format("C1SizerLight {0}", _cnt++);
			cf.MdiParent = this;
			cf.Show();
		}

		// start with 2 child forms
		private void Form1_Load(object sender, System.EventArgs e)
		{
			for (int i = 0; i < 2; i++)
				mnuAddChild_Click(this, EventArgs.Empty);
			LayoutMdi(MdiLayout.TileVertical);
		}
	}
}
