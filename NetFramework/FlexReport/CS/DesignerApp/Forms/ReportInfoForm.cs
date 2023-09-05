//----------------------------------------------------------------------------
// ReportInfoForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
	/// <summary>
	/// Summary description for ReportInfoForm.
	/// </summary>
	public partial class ReportInfoForm : System.Windows.Forms.Form
	{
		public ReportInfoForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            //
            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;
		}

		private ReportInfo _reportInfo;
		public ReportInfo ReportInfo
		{
			get { return _reportInfo; }
		}

        public bool ApplyToAll
		{
			get { return _chkApplyToAll.Checked; }
		}
		
        public DialogResult ShowDialog(C1FlexReport rpt)
		{
			_reportInfo = rpt.ReportInfo.Clone();

			_txtTitle.DataBindings.Add   (new Binding("Text", ReportInfo, "Title"));
			_txtAuthor.DataBindings.Add  (new Binding("Text", ReportInfo, "Author"));
			_txtSubject.DataBindings.Add (new Binding("Text", ReportInfo, "Subject"));
			_txtCreator.DataBindings.Add (new Binding("Text", ReportInfo, "Creator"));
			_txtKeywords.DataBindings.Add(new Binding("Text", ReportInfo, "Keywords"));
 
			return base.ShowDialog();
		}
	}
}
