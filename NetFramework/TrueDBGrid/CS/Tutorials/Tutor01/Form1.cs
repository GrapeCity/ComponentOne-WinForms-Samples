using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Tutorial_1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private TDBGDemoDataSet tDBGDemoDataSet;
        private BindingSource ComposerBindingSource;
        private Tutorial_1.TDBGDemoDataSetTableAdapters.ComposerTableAdapter composerTableAdapter;
        private IContainer components;

		public Form1()
		{
			Application.EnableVisualStyles();
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
            this.c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            this.tDBGDemoDataSet = new Tutorial_1.TDBGDemoDataSet();
            this.ComposerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.composerTableAdapter = new Tutorial_1.TDBGDemoDataSetTableAdapters.ComposerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBGDemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.Caption = "C1TrueDBGrid.Net";
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.DataSource = this.ComposerBindingSource;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(8, 8);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.TrueDBGrid.MarqueeEnum.DottedCellBorder;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RecordSelectorWidth = 17;
            this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid1.RowHeight = 15;
            this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(384, 184);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // tDBGDemoDataSet
            // 
            this.tDBGDemoDataSet.DataSetName = "TDBGDemoDataSet";
            // 
            // ComposerBindingSource
            // 
            this.ComposerBindingSource.DataMember = "Composer";
            this.ComposerBindingSource.DataSource = this.tDBGDemoDataSet;
            // 
            // composerTableAdapter
            // 
            this.composerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(416, 214);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "Form1";
            this.Text = "Tutorial 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDBGDemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComposerBindingSource)).EndInit();
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
            this.composerTableAdapter.Connection.ConnectionString = GetModifiedConnectionString(this.composerTableAdapter.Connection.ConnectionString);
            // TODO: This line of code loads data into the 'tDBGDemoDataSet.Composer' table. You can move, or remove it, as needed.
            this.composerTableAdapter.Fill(this.tDBGDemoDataSet.Composer);
		}

        private string GetModifiedConnectionString(string connstring)
        {
            return String.Format(@"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;", Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common");
        }

	}
}
