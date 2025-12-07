using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ColumnEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private UserControl1 _myControl;
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
            this._myControl = new ColumnEditor.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this._myControl)).BeginInit();
            this.SuspendLayout();
            // 
            // _myControl
            // 
            this._myControl.BackColor = System.Drawing.SystemColors.Desktop;
            this._myControl.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:21;}\t1{Width:20;}\t2{Width:20;}\t3{Width:20;}\t4{Width" +
    ":20;}\t5{Width:20;}\t6{Width:20;}\t7{Width:20;}\t8{Width:20;}\t9{Width:20;}\t";
            this._myControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._myControl.Location = new System.Drawing.Point(6, 6);
            this._myControl.Name = "_myControl";
            this._myControl.Padding = new System.Windows.Forms.Padding(5);
            this._myControl.Size = new System.Drawing.Size(551, 389);
            this._myControl.TabIndex = 2;
            this._myControl.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 24);
            this.ClientSize = new System.Drawing.Size(563, 401);
            this.Controls.Add(this._myControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Column editor in UserControls";
            ((System.ComponentModel.ISupportInitialize)(this._myControl)).EndInit();
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
	}
}
