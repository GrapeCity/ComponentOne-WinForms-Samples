namespace SizerExplorer.Samples
{
    partial class AddControls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.c1Sizer1 = new C1.Win.Sizer.C1Sizer();
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Sizer1
			// 
			this.c1Sizer1.AllowDrop = true;
			this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Sizer1.GridDefinition = "97.21254355400697:False:False;\t97.75280898876404:False:False;";
			this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
			this.c1Sizer1.Name = "c1Sizer1";
			this.c1Sizer1.Size = new System.Drawing.Size(356, 287);
			this.c1Sizer1.TabIndex = 0;
			this.c1Sizer1.TabStop = false;
			// 
			// Form1
			// 
			this.Controls.Add(this.c1Sizer1);
			this.Name = "Form1";
			this.Size = new System.Drawing.Size(356, 287);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private C1.Win.Sizer.C1Sizer c1Sizer1;
    }
}