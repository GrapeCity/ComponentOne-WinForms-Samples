namespace CustomDialogs
{
    partial class BookmarkEditorForm
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
            this._panelProperties = new System.Windows.Forms.Panel();
            this._tbName = new System.Windows.Forms.TextBox();
            this._lblName = new System.Windows.Forms.Label();
            this._gbBookmarks = new System.Windows.Forms.GroupBox();
            this._panel = new System.Windows.Forms.Panel();
            this._tree = new System.Windows.Forms.TreeView();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._btnRemove = new System.Windows.Forms.ToolStripButton();
            this._btnGoTo = new System.Windows.Forms.ToolStripButton();
            this._containerMain.SuspendLayout();
            this._panelProperties.SuspendLayout();
            this._gbBookmarks.SuspendLayout();
            this._panel.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(216, 289);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(313, 289);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(410, 289);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._gbBookmarks);
            this._containerMain.Controls.Add(this._panelProperties);
            this._containerMain.Size = new System.Drawing.Size(489, 274);
            // 
            // _panelProperties
            // 
            this._panelProperties.Controls.Add(this._tbName);
            this._panelProperties.Controls.Add(this._lblName);
            this._panelProperties.Dock = System.Windows.Forms.DockStyle.Top;
            this._panelProperties.Location = new System.Drawing.Point(3, 17);
            this._panelProperties.Name = "_panelProperties";
            this._panelProperties.Size = new System.Drawing.Size(483, 38);
            this._panelProperties.TabIndex = 0;
            // 
            // _tbName
            // 
            this._tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbName.Location = new System.Drawing.Point(64, 9);
            this._tbName.Name = "_tbName";
            this._tbName.Size = new System.Drawing.Size(412, 21);
            this._tbName.TabIndex = 1;
            // 
            // _lblName
            // 
            this._lblName.AutoSize = true;
            this._lblName.Location = new System.Drawing.Point(7, 12);
            this._lblName.Name = "_lblName";
            this._lblName.Size = new System.Drawing.Size(38, 13);
            this._lblName.TabIndex = 0;
            this._lblName.Text = "&Name:";
            // 
            // _gbBookmarks
            // 
            this._gbBookmarks.Controls.Add(this._panel);
            this._gbBookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gbBookmarks.Location = new System.Drawing.Point(3, 55);
            this._gbBookmarks.Name = "_gbBookmarks";
            this._gbBookmarks.Padding = new System.Windows.Forms.Padding(6);
            this._gbBookmarks.Size = new System.Drawing.Size(483, 216);
            this._gbBookmarks.TabIndex = 1;
            this._gbBookmarks.TabStop = false;
            this._gbBookmarks.Text = "Other &bookmarks in this document";
            // 
            // _panel
            // 
            this._panel.Controls.Add(this._tree);
            this._panel.Controls.Add(this._toolStrip);
            this._panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._panel.Location = new System.Drawing.Point(6, 20);
            this._panel.Name = "_panel";
            this._panel.Padding = new System.Windows.Forms.Padding(1);
            this._panel.Size = new System.Drawing.Size(471, 190);
            this._panel.TabIndex = 1;
            // 
            // _tree
            // 
            this._tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tree.Location = new System.Drawing.Point(1, 26);
            this._tree.Name = "_tree";
            this._tree.Size = new System.Drawing.Size(469, 163);
            this._tree.TabIndex = 1;
            // 
            // _toolStrip
            // 
            this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btnRemove,
            this._btnGoTo});
            this._toolStrip.Location = new System.Drawing.Point(1, 1);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(469, 25);
            this._toolStrip.TabIndex = 0;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _btnRemove
            // 
            this._btnRemove.Image = global::CustomDialogs.Properties.Resources.remove;
            this._btnRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(115, 22);
            this._btnRemove.Text = "&Remove Bookmark";
            // 
            // _btnGoTo
            // 
            this._btnGoTo.Image = global::CustomDialogs.Properties.Resources.gotoright;
            this._btnGoTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnGoTo.Name = "_btnGoTo";
            this._btnGoTo.Size = new System.Drawing.Size(104, 22);
            this._btnGoTo.Text = "&Go To Bookmark";
            // 
            // BookmarkEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 326);
            this.MinimumSize = new System.Drawing.Size(521, 174);
            this.Name = "BookmarkEditorForm";
            this.Text = "Bookmark Properties";
            this._containerMain.ResumeLayout(false);
            this._panelProperties.ResumeLayout(false);
            this._panelProperties.PerformLayout();
            this._gbBookmarks.ResumeLayout(false);
            this._panel.ResumeLayout(false);
            this._panel.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbBookmarks;
        private System.Windows.Forms.Panel _panelProperties;
        private System.Windows.Forms.TextBox _tbName;
        private System.Windows.Forms.Label _lblName;
        private System.Windows.Forms.Panel _panel;
        private System.Windows.Forms.TreeView _tree;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _btnRemove;
        private System.Windows.Forms.ToolStripButton _btnGoTo;



    }
}
