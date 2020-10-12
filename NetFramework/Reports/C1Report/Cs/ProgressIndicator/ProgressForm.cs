using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using C1.C1Report;

namespace ProgressIndicator
{
	/// <summary>
	/// Summary description for ProgressForm.
	/// </summary>
	public class ProgressForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ProgressBar _progress;
		private System.Windows.Forms.Label _lblPage;
		private System.Windows.Forms.Button _btnCancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ProgressForm()
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
			this._progress = new System.Windows.Forms.ProgressBar();
			this._lblPage = new System.Windows.Forms.Label();
			this._btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _progress
			// 
			this._progress.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._progress.Location = new System.Drawing.Point(16, 40);
			this._progress.Name = "_progress";
			this._progress.Size = new System.Drawing.Size(258, 16);
			this._progress.TabIndex = 0;
			// 
			// _lblPage
			// 
			this._lblPage.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._lblPage.Location = new System.Drawing.Point(16, 16);
			this._lblPage.Name = "_lblPage";
			this._lblPage.Size = new System.Drawing.Size(258, 24);
			this._lblPage.TabIndex = 1;
			this._lblPage.Text = "Rendering Report...";
			this._lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// _btnCancel
			// 
			this._btnCancel.Location = new System.Drawing.Point(100, 64);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(88, 24);
			this._btnCancel.TabIndex = 2;
			this._btnCancel.Text = "Cancel";
			this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
			// 
			// ProgressForm
			// 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 140);
			this.ControlBox = false;
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._btnCancel,
																		  this._lblPage,
																		  this._progress});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProgressForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Rendering Report...";
			this.TopMost = true;
			this.Closed += new System.EventHandler(this.ProgressForm_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		// ** fields
		private C1Report	_report;
		private Form		_parent;
		private int			_pageCount;

		// ** ctor
		public ProgressForm(Form parent, C1Report report, int pageCount)
		{
			// initialize as usual
			InitializeComponent();

			// store values
			_parent = parent;
			_report = report;
			_pageCount = pageCount;

			// hook up events
			report.EndReport += new System.EventHandler(_report_EndReport);
            report.StartPage += new C1.C1Report.ReportEventHandler(_report_StartPage);

			// position form over parent
			Rectangle rc = parent.Bounds;
			rc.X += (rc.Width - this.Width) / 2;
			Location = rc.Location;

			// show progress indicator form
			Show();
		}
		private void ProgressForm_Closed(object sender, System.EventArgs e)
		{
			// unhook events
			_report.EndReport -= new System.EventHandler(_report_EndReport);
            _report.StartPage -= new C1.C1Report.ReportEventHandler(_report_StartPage);
		}
		private void _btnCancel_Click(object sender, System.EventArgs e)
		{
			_report.Cancel = true;
			Close();
		}
		private void _report_EndReport(object sender, System.EventArgs e)
		{
			Close();
		}
        private void _report_StartPage(object sender, C1.C1Report.ReportEventArgs e)
		{
			// get report name
			string reportName = _report.ReportName;
			if (reportName == null || reportName.Length == 0)
				reportName = "Report";

			// get current progress
			int progress = (int)((_report.Page  * 100) / _pageCount);

			// correct if caller underestimated page count
			while (progress > 100)
			{
				_pageCount = (_pageCount * 130) / 100;
				progress = (int)((_report.Page  * 100) / _pageCount);
			}

			// update progress on new page
			_lblPage.Text = string.Format("Rendering page {0} of '{1}'...",
				_report.Page, _report.ReportName);
			_progress.Value = progress;
		}
	}
}
