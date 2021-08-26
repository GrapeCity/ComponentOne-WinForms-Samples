//
// Licensing.cs
//
// This is a dummy form. It contains a C1Chart control and forces the necessary 
// licensing information to be embedded into the CustomFields dll.
//
// The form itself is never instantiated.
//
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace C1.Win.C1Report.CustomFields
{
	/// <summary>
	/// Summary description for Licensing.
	/// </summary>
	public class Licensing : System.Windows.Forms.Form
	{
        private C1.Win.C1Chart.C1Chart c1Chart1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Licensing()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licensing));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(0, 0);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(280, 245);
            this.c1Chart1.TabIndex = 0;
            this.c1Chart1.Load += new System.EventHandler(this.c1Chart1_Load);
            // 
            // Licensing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(280, 245);
            this.Controls.Add(this.c1Chart1);
            this.Name = "Licensing";
            this.Text = "Licensing";
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Licensing());
        }

        private void c1Chart1_Load(object sender, EventArgs e)
        {

        }
	}
}
