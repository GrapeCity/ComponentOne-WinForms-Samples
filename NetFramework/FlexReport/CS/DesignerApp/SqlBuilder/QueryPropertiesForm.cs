//----------------------------------------------------------------------------
// QueryPropertiesForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
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
	/// Summary description for PropertiesForm.
	/// </summary>
	public class QueryPropertiesForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button _btnClose;
		private System.Windows.Forms.TextBox _txtTop;
		private System.Windows.Forms.CheckBox _chkDistinct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _cmbGroupBy;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public QueryPropertiesForm()
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._txtTop = new System.Windows.Forms.TextBox();
            this._chkDistinct = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this._cmbGroupBy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(0, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 2);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnClose.Location = new System.Drawing.Point(171, 146);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 5;
            this._btnClose.Text = "Close";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Top:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _txtTop
            // 
            this._txtTop.Location = new System.Drawing.Point(144, 14);
            this._txtTop.Name = "_txtTop";
            this._txtTop.Size = new System.Drawing.Size(96, 20);
            this._txtTop.TabIndex = 1;
            this._txtTop.Text = "0";
            // 
            // _chkDistinct
            // 
            this._chkDistinct.Location = new System.Drawing.Point(16, 88);
            this._chkDistinct.Name = "_chkDistinct";
            this._chkDistinct.Size = new System.Drawing.Size(128, 16);
            this._chkDistinct.TabIndex = 4;
            this._chkDistinct.Text = "DISTINCT &values";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Group By Extension:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cmbGroupBy
            // 
            this._cmbGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbGroupBy.Location = new System.Drawing.Point(144, 48);
            this._cmbGroupBy.Name = "_cmbGroupBy";
            this._cmbGroupBy.Size = new System.Drawing.Size(96, 21);
            this._cmbGroupBy.TabIndex = 3;
            // 
            // QueryPropertiesForm
            // 
            this.AcceptButton = this._btnClose;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(258, 176);
            this.Controls.Add(this._cmbGroupBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._txtTop);
            this.Controls.Add(this._chkDistinct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryPropertiesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		// ** fields
		private QueryBuilder _qb;

		// ** object model
		public QueryBuilder QueryBuilder 
		{
			get { return _qb; }
			set 
			{
				_qb = value; 
				_txtTop.DataBindings.Add("Text", _qb, "Top");
				_chkDistinct.DataBindings.Add("Checked", _qb, "Distinct");
				_cmbGroupBy.Enabled = _qb.GroupBy;
				if (_qb.GroupBy)
				{
					foreach (GroupByExtension gbx in Enum.GetValues(typeof(GroupByExtension)))
					{
						_cmbGroupBy.Items.Add(gbx);
					}
					_cmbGroupBy.DataBindings.Add("SelectedItem", _qb, "GroupByExtension");
				}
			}
		}
	}
}
