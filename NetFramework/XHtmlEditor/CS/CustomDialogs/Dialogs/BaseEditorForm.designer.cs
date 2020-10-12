namespace CustomDialogs
{
#pragma warning disable 3008
#pragma warning disable 1591
    partial class BaseEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
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
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnAplly = new System.Windows.Forms.Button();
            this._containerMain = new System.Windows.Forms.GroupBox();
            this._containerMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.Location = new System.Drawing.Point(280, 286);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(91, 25);
            this._btnOK.TabIndex = 1;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(377, 286);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(91, 25);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _btnAplly
            // 
            this._btnAplly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAplly.Location = new System.Drawing.Point(474, 286);
            this._btnAplly.Name = "_btnAplly";
            this._btnAplly.Size = new System.Drawing.Size(91, 25);
            this._btnAplly.TabIndex = 3;
            this._btnAplly.Text = "Apply";
            this._btnAplly.UseVisualStyleBackColor = true;
            this._btnAplly.Click += new System.EventHandler(this.ApllyClick);
            // 
            // _splitContainerMain
            // 
            this._containerMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._containerMain.Cursor = System.Windows.Forms.Cursors.Default;
            this._containerMain.Location = new System.Drawing.Point(12, 12);
            this._containerMain.Name = "_containerMain";
            this._containerMain.Size = new System.Drawing.Size(553, 268);
            this._containerMain.TabIndex = 0;
            // 
            // BaseEditorForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(577, 323);
            this.Controls.Add(this._btnAplly);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._containerMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(415, 174);
            this.Name = "BaseEditorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BaseEditorForm";
            this._containerMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button _btnOK;
        protected System.Windows.Forms.Button _btnCancel;
        protected System.Windows.Forms.Button _btnAplly;
        protected System.Windows.Forms.GroupBox _containerMain;



    }
#pragma warning restore 3008 
#pragma warning restore 1591
}