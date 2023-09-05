//----------------------------------------------------------------------------
// PreviewForm.cs
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

namespace SqlBuilder
{
	/// <summary>
	/// Summary description for PreviewForm.
	/// </summary>
	public class PreviewForm : System.Windows.Forms.Form
	{
		public C1.Win.C1FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.StatusBar _status;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PreviewForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this._status = new System.Windows.Forms.StatusBar();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.AllowEditing = false;
			this._flex.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}\t";
			this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.ShowCursor = true;
			this._flex.Size = new System.Drawing.Size(552, 295);
			this._flex.TabIndex = 0;
			// 
			// _status
			// 
			this._status.Location = new System.Drawing.Point(0, 295);
			this._status.Name = "_status";
			this._status.Size = new System.Drawing.Size(552, 22);
			this._status.TabIndex = 1;
			// 
			// PreviewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(552, 317);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._flex,
																		  this._status});
			this.Name = "PreviewForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Preview Data";
			this.Load += new System.EventHandler(this.PreviewForm_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void PreviewForm_Load(object sender, System.EventArgs e)
		{
			int cnt = _flex.Rows.Count - _flex.Rows.Fixed;
			_status.Text = string.Format(FlexReportDesignerApp.Strings.PreviewForm.StatusFmt, cnt);
		}
	}
}
