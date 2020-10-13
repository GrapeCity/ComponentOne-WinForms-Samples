using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Function2D
{
	/// <summary>
	/// Summary description for FuncForm.
	/// </summary>
	public class FuncForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbCode;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox tbMinX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown udN;
		private System.Windows.Forms.TextBox tbMaxX;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		Engine m_engine = null;

		public FuncForm( Engine engine)
		{
			InitializeComponent();
			m_engine = engine;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) //!!VBReplace-Overrides-Overloads Overrides-
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

		public string Code
		{
			get
			{
				return tbCode.Text;
			}
			set
			{
				tbCode.Text = value;
			}
		}

		public float MinX
		{
			get
			{
				return float.Parse( tbMinX.Text);
			}
			set
			{
				tbMinX.Text = value.ToString();
			}
		}

		public float MaxX
		{
			get
			{
				return float.Parse( tbMaxX.Text);
			}
			set
			{
				tbMaxX.Text = value.ToString();
			}
		}

		public int NPts
		{
			get
			{
				return (int)udN.Value;
			}
			set
			{
				udN.Value = value;
			}
		}


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbCode = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.udN = new System.Windows.Forms.NumericUpDown();
			this.tbMaxX = new System.Windows.Forms.TextBox();
			this.tbMinX = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
			((System.ComponentModel.ISupportInitialize)(this.udN)).BeginInit();
			this.SuspendLayout();
			// 
			// tbCode
			// 
			this.tbCode.Location = new System.Drawing.Point(16, 16);
			this.tbCode.Name = "tbCode";
			this.tbCode.Size = new System.Drawing.Size(272, 20);
			this.tbCode.TabIndex = 0;
			this.tbCode.Text = "x";
			this.tbCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbCode_Validating);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(120, 104);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 20);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "OK";
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(216, 104);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 20);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			// 
			// udN
			// 
			this.udN.Location = new System.Drawing.Point(192, 64);
			this.udN.Minimum = new System.Decimal(new int[] {
																												2,
																												0,
																												0,
																												0});
			this.udN.Name = "udN";
			this.udN.Size = new System.Drawing.Size(56, 20);
			this.udN.TabIndex = 3;
			this.udN.Value = new System.Decimal(new int[] {
																											20,
																											0,
																											0,
																											0});
			// 
			// tbMaxX
			// 
			this.tbMaxX.Location = new System.Drawing.Point(104, 64);
			this.tbMaxX.Name = "tbMaxX";
			this.tbMaxX.Size = new System.Drawing.Size(56, 20);
			this.tbMaxX.TabIndex = 2;
			this.tbMaxX.Text = "10";
			this.tbMaxX.Validating += new System.ComponentModel.CancelEventHandler(this.tbFloat_Validating);
			// 
			// tbMinX
			// 
			this.tbMinX.Location = new System.Drawing.Point(16, 64);
			this.tbMinX.Name = "tbMinX";
			this.tbMinX.Size = new System.Drawing.Size(56, 20);
			this.tbMinX.TabIndex = 1;
			this.tbMinX.Text = "0";
			this.tbMinX.Validating += new System.ComponentModel.CancelEventHandler(this.tbFloat_Validating);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(192, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Number of points";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Min X";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 8;
			this.label2.Text = "Max X";
			// 
			// FuncForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(306, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																																	this.label2,
																																	this.label1,
																																	this.btnCancel,
																																	this.btnOK,
																																	this.tbCode,
																																	this.tbMinX,
																																	this.tbMaxX,
																																	this.udN,
																																	this.label3});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FuncForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Edit Function";
			((System.ComponentModel.ISupportInitialize)(this.udN)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void tbFloat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			TextBox tb = (TextBox) sender;
			try
			{
				float.Parse( tb.Text);
				errorProvider1.SetError( tb, null);
			}
			catch( Exception ex)
			{
				e.Cancel = true;
				errorProvider1.SetError( tb, ex.Message);
			}
		}

		private void tbCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if( !m_engine.Compile( tbCode.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError( tbCode, m_engine.Errors[0]);
			}
			else
				errorProvider1.SetError( tbCode, null);
		}
	}
}
