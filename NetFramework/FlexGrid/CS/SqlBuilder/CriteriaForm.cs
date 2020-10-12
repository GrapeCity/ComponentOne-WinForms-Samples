//----------------------------------------------------------------------------
// C1\SqlBuilder\CriteriaForm.cs
//
// This is a part of the C1ReportDesigner package.
// Copyright (C) 2002 - 2005 ComponentOne LLC
// All rights reserved.
//
// This source code is intended as a supplement to the C1ReportDesigner 
// control and related documentation provided with the product.
//
// See these sources for detailed information regarding the
// C1ReportDesigner product.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SqlBuilder
{
	/// <summary>
	/// Summary description for CriteriaForm.
	/// </summary>
	public class CriteriaForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox _cmbOperator;
		private System.Windows.Forms.TextBox _txtValue;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox _txtFrom;
		private System.Windows.Forms.TextBox _txtTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _btnOK;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.Label _value;
		private System.Windows.Forms.Button _btnClear;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public CriteriaForm()
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
			this._cmbOperator = new System.Windows.Forms.ComboBox();
			this._value = new System.Windows.Forms.Label();
			this._txtValue = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this._txtFrom = new System.Windows.Forms.TextBox();
			this._txtTo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._btnOK = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this._btnClear = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// _cmbOperator
			// 
			this._cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._cmbOperator.Items.AddRange(new object[] {
															  "=",
															  ">",
															  ">=",
															  "<",
															  "<=",
															  "<>"});
			this._cmbOperator.Location = new System.Drawing.Point(16, 24);
			this._cmbOperator.Name = "_cmbOperator";
			this._cmbOperator.Size = new System.Drawing.Size(56, 21);
			this._cmbOperator.TabIndex = 2;
			this._cmbOperator.SelectedIndexChanged += new System.EventHandler(this._cmbOperator_SelectedIndexChanged);
			// 
			// _value
			// 
			this._value.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._value.Location = new System.Drawing.Point(8, 8);
			this._value.Name = "_value";
			this._value.Size = new System.Drawing.Size(426, 21);
			this._value.TabIndex = 0;
			this._value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _txtValue
			// 
			this._txtValue.Location = new System.Drawing.Point(88, 24);
			this._txtValue.Name = "_txtValue";
			this._txtValue.Size = new System.Drawing.Size(80, 20);
			this._txtValue.TabIndex = 3;
			this._txtValue.Text = "";
			this._txtValue.TextChanged += new System.EventHandler(this._txtValue_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this._cmbOperator,
																					this._txtValue});
			this.groupBox1.Location = new System.Drawing.Point(8, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 56);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Single value criteria";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.groupBox2.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.label2,
																					this._txtFrom,
																					this._txtTo,
																					this.label3});
			this.groupBox2.Location = new System.Drawing.Point(8, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(296, 56);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Interval criteria";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Between";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _txtFrom
			// 
			this._txtFrom.Location = new System.Drawing.Point(88, 24);
			this._txtFrom.Name = "_txtFrom";
			this._txtFrom.Size = new System.Drawing.Size(80, 20);
			this._txtFrom.TabIndex = 6;
			this._txtFrom.Text = "";
			this._txtFrom.TextChanged += new System.EventHandler(this._txtFrom_TextChanged);
			// 
			// _txtTo
			// 
			this._txtTo.Location = new System.Drawing.Point(208, 24);
			this._txtTo.Name = "_txtTo";
			this._txtTo.Size = new System.Drawing.Size(80, 20);
			this._txtTo.TabIndex = 8;
			this._txtTo.Text = "";
			this._txtTo.TextChanged += new System.EventHandler(this._txtTo_TextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(176, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "and";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _btnOK
			// 
			this._btnOK.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnOK.Location = new System.Drawing.Point(250, 177);
			this._btnOK.Name = "_btnOK";
			this._btnOK.Size = new System.Drawing.Size(88, 24);
			this._btnOK.TabIndex = 9;
			this._btnOK.Text = "OK";
			// 
			// _btnCancel
			// 
			this._btnCancel.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnCancel.Location = new System.Drawing.Point(346, 177);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(88, 24);
			this._btnCancel.TabIndex = 10;
			this._btnCancel.Text = "Cancel";
			// 
			// _btnClear
			// 
			this._btnClear.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this._btnClear.Location = new System.Drawing.Point(8, 176);
			this._btnClear.Name = "_btnClear";
			this._btnClear.Size = new System.Drawing.Size(88, 24);
			this._btnClear.TabIndex = 10;
			this._btnClear.Text = "Clear";
			this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.groupBox3.Location = new System.Drawing.Point(0, 169);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(442, 2);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label1.Location = new System.Drawing.Point(200, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 48);
			this.label1.TabIndex = 13;
			this.label1.Text = "Tips: use 0 or 1 instead of True and False; remember to enclose string and date c" +
				"onstants in single quotes.";
			// 
			// CriteriaForm
			// 
			this.AcceptButton = this._btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(442, 207);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label1,
																		  this.groupBox3,
																		  this._btnOK,
																		  this.groupBox1,
																		  this._value,
																		  this.groupBox2,
																		  this._btnCancel,
																		  this._btnClear});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "CriteriaForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CriteriaForm";
			this.Activated += new System.EventHandler(this.CriteriaForm_Activated);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		// ** fields
		private QueryField _qf;
		private static Regex _rx1 = new Regex(@"^([^<>=]*)\s*(<|>|=|<>|<=|>=)\s*([^<>=]+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
		private static Regex _rx2 = new Regex(@"^([^<>=]*)\s*BETWEEN\s+(.+)\s+AND\s+(.+)$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

		// ** public
		public QueryField QueryField
		{
			get { return _qf; }
			set
			{
				// save qeury field
				_qf = value; 

				// initialize value
				string crit = _qf.Criteria;
				_value.Text = crit;

				// initialize fields
				if (crit.Length > 0)
				{
					Match m = _rx1.Match(crit);
					if (m.Success)
					{
						_cmbOperator.Text = m.Groups[2].Value;
						_txtValue.Text    = m.Groups[3].Value;
					}
					m = _rx2.Match(crit);
					if (m.Success)
					{
						_txtFrom.Text = m.Groups[2].Value;
						_txtTo.Text   = m.Groups[3].Value;
					}
				}
			}
		}
		public string Value
		{
			get { return _value.Text; }
			set { _value.Text = value; }
		}

		// ** private stuff
		private void UpdateSimple()
		{
			if (_cmbOperator.SelectedIndex > -1 && _txtValue.Text.Length > 0)
			{
				_value.Text = string.Format("{0} {1}", _cmbOperator.Text, _txtValue.Text);
			}
		}
		private void UpdateBetween()
		{
			if (_txtFrom.Text.Length > 0 && _txtTo.Text.Length > 0)
			{
				_value.Text = string.Format("BETWEEN {0} AND {1}", _txtFrom.Text, _txtTo.Text);
			}
		}

		// ** event handlers
		private void _cmbOperator_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateSimple();
		}
		private void _txtValue_TextChanged(object sender, System.EventArgs e)
		{
			UpdateSimple();
		}
		private void _txtFrom_TextChanged(object sender, System.EventArgs e)
		{
			UpdateBetween();
		}
		private void _txtTo_TextChanged(object sender, System.EventArgs e)
		{
			UpdateBetween();
		}
		private void _btnClear_Click(object sender, System.EventArgs e)
		{
			_cmbOperator.SelectedIndex = -1;
			_txtValue.Text = string.Empty;
			_txtFrom.Text  = string.Empty;
			_txtTo.Text    = string.Empty;
			_value.Text    = string.Empty;
		}
		private void CriteriaForm_Activated(object sender, System.EventArgs e)
		{
			if (_txtValue.Text.Length > 0)		
			{
				_txtValue.Focus();
				_txtValue.SelectAll();
			}
			else if (_txtFrom.Text.Length > 0)
			{
				_txtFrom.Focus();
				_txtFrom.SelectAll();
			}
		}
	}
}
