using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using C1.C1Report;

namespace Images
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.C1Report.C1Report _c1r;
		private System.Windows.Forms.Button button1;
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
			this._c1r = new C1.C1Report.C1Report();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
			this.SuspendLayout();
			// 
			// _c1r
			// 
			this._c1r.ReportName = "c1Report1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(256, 40);
			this.button1.TabIndex = 0;
			this.button1.Text = "Show Report";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 61);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1Report: Reports with Images";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
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

		DataTable _dt;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data source
			DataTable dt = new DataTable();
			dt.Columns.Add("ID", typeof(int));
			dt.Columns.Add("FileName", typeof(string));
			dt.Columns.Add("Image", typeof(Image));
			dt.Columns["ID"].AutoIncrement = true;

			// populate data source
			string path = Application.ExecutablePath;
			path = path.Substring(0, path.IndexOf(@"\bin\")) + @"\Images";
			foreach (string fileName in Directory.GetFiles(path, "*.jpg"))
			{
				DataRow dr = dt.NewRow();
				dr["FileName"] = fileName;
				dr["Image"]    = Image.FromFile(fileName);
				dt.Rows.Add(dr);
			}

			// save in global member
			_dt = dt;
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			// clear report
			_c1r.Clear();
			_c1r.ReportName = "Images";
			_c1r.Font = new Font("Tahoma", 9);
			_c1r.Layout.MarginLeft = 600;

			// configure detail section
			Section section = _c1r.Sections[SectionTypeEnum.Detail];
			Rectangle rc = new Rectangle(0, 0, 1600, 1200);
			section.Height = rc.Height;
			section.Visible = true;
			section.CanGrow = true;

			// add fields
			FieldCollection fc = section.Fields;

			// create ID field 
			Field f = fc.Add("fldID", "ID", rc);
			f.Align = FieldAlignEnum.LeftTop;
			f.Calculated = true;
			f.BorderStyle = BorderStyleEnum.Solid;
			
			// create file name field 
			rc.Offset(rc.Width + 100, 0);
			f = fc.Add("fldFileName", "FileName", rc);
			f.Align = FieldAlignEnum.LeftTop;
			f.WordWrap = true;
			f.Calculated = true;
			f.BorderStyle = BorderStyleEnum.Solid;

			// create 1st image field (directly from db)
			rc.Offset(rc.Width + 100, 0);
			rc.Width  = 4000;
			rc.Height = 4000;
			f = fc.Add("fldImage", "Image", rc);
			f.Picture = "Image";
			f.PictureAlign = PictureAlignEnum.Zoom;
			f.BorderStyle = BorderStyleEnum.Solid;

			// create 2nd image field (laoded from file at render time)
			rc.Offset(rc.Width + 100, 0);
			f = fc.Add("fldFileImage", "", rc);
			f.PictureAlign = PictureAlignEnum.Zoom;
			f.BorderStyle = BorderStyleEnum.Solid;

			// use script to set Picture property at render time:
			// this takes the iamge filename from the 'fldFileName' calculated field.
			section.OnPrint = "fldFileImage.Picture = fldFileName";

			// set data source
			_c1r.DataSource.Recordset = _dt;

			// show it
            C1.Win.C1Preview.C1PrintPreviewDialog dlg = new C1.Win.C1Preview.C1PrintPreviewDialog();
			dlg.Document = _c1r;
			dlg.ShowDialog();
		}
	}
}
