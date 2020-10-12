namespace TestSchedule
{
	partial class SeriesDialog
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
			this._lblMessage = new System.Windows.Forms.Label();
			this._rbOccurrence = new System.Windows.Forms.RadioButton();
			this._rbSeries = new System.Windows.Forms.RadioButton();
			this._btnOk = new System.Windows.Forms.Button();
			this._btnCancel = new System.Windows.Forms.Button();
			this._pBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._pBox)).BeginInit();
			this.SuspendLayout();
			// 
			// _lblMessage
			// 
			this._lblMessage.Location = new System.Drawing.Point(48, 9);
			this._lblMessage.Name = "_lblMessage";
			this._lblMessage.Size = new System.Drawing.Size(222, 58);
			this._lblMessage.TabIndex = 0;
			this._lblMessage.Text = "\"{0}\" is recurring appointment. Do you want to open only this occurrence or the s" +
				"eries?";
			// 
			// _rbOccurrence
			// 
			this._rbOccurrence.AutoSize = true;
			this._rbOccurrence.Checked = true;
			this._rbOccurrence.Location = new System.Drawing.Point(51, 70);
			this._rbOccurrence.Name = "_rbOccurrence";
			this._rbOccurrence.Size = new System.Drawing.Size(130, 17);
			this._rbOccurrence.TabIndex = 1;
			this._rbOccurrence.TabStop = true;
			this._rbOccurrence.Text = "Open &this occurrence.";
			this._rbOccurrence.UseVisualStyleBackColor = true;
			// 
			// _rbSeries
			// 
			this._rbSeries.AutoSize = true;
			this._rbSeries.Location = new System.Drawing.Point(51, 105);
			this._rbSeries.Name = "_rbSeries";
			this._rbSeries.Size = new System.Drawing.Size(102, 17);
			this._rbSeries.TabIndex = 2;
			this._rbSeries.Text = "Open the &series.";
			this._rbSeries.UseVisualStyleBackColor = true;
			// 
			// _btnOk
			// 
			this._btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._btnOk.Location = new System.Drawing.Point(51, 143);
			this._btnOk.Name = "_btnOk";
			this._btnOk.Size = new System.Drawing.Size(75, 23);
			this._btnOk.TabIndex = 3;
			this._btnOk.Text = "&OK";
			this._btnOk.UseVisualStyleBackColor = true;
			// 
			// _btnCancel
			// 
			this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._btnCancel.Location = new System.Drawing.Point(145, 143);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(75, 23);
			this._btnCancel.TabIndex = 4;
			this._btnCancel.Text = "&Cancel";
			this._btnCancel.UseVisualStyleBackColor = true;
			// 
			// _pBox
			// 
			this._pBox.Location = new System.Drawing.Point(10, 9);
			this._pBox.Name = "_pBox";
			this._pBox.Size = new System.Drawing.Size(32, 32);
			this._pBox.TabIndex = 5;
			this._pBox.TabStop = false;
			// 
			// SeriesDialog
			// 
			this.AcceptButton = this._btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.CancelButton = this._btnCancel;
			this.ClientSize = new System.Drawing.Size(280, 175);
			this.Controls.Add(this._pBox);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._btnOk);
			this.Controls.Add(this._rbSeries);
			this.Controls.Add(this._rbOccurrence);
			this.Controls.Add(this._lblMessage);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SeriesDialog";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SeriesDialog";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this._pBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label _lblMessage;
		private System.Windows.Forms.RadioButton _rbOccurrence;
		private System.Windows.Forms.RadioButton _rbSeries;
		private System.Windows.Forms.Button _btnOk;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.PictureBox _pBox;
	}
}