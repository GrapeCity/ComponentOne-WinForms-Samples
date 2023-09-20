//----------------------------------------------------------------------------
// DataSourceForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Util
{
    partial class DataSourceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourceForm));
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._cmbDataSourceName = new System.Windows.Forms.ComboBox();
            this._dspMain = new FlexReportDesignerApp.Util.DataSourcePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnOK.Location = new System.Drawing.Point(305, 8);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 0;
            this._btnOK.Text = "&OK";
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnCancel.Location = new System.Drawing.Point(386, 8);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "&Cancel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._btnCancel);
            this.panel1.Controls.Add(this._btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 38);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source:";
            // 
            // _cmbDataSourceName
            // 
            this._cmbDataSourceName.FormattingEnabled = true;
            this._cmbDataSourceName.Location = new System.Drawing.Point(88, 11);
            this._cmbDataSourceName.Name = "_cmbDataSourceName";
            this._cmbDataSourceName.Size = new System.Drawing.Size(228, 21);
            this._cmbDataSourceName.TabIndex = 1;
            this._cmbDataSourceName.DropDown += new System.EventHandler(this._cmbDataSourceName_DropDown);
            this._cmbDataSourceName.SelectedIndexChanged += new System.EventHandler(this._cmbDataSourceName_SelectedIndexChanged);
            this._cmbDataSourceName.KeyDown += new System.Windows.Forms.KeyEventHandler(this._cmbDataSourceName_KeyDown);
            this._cmbDataSourceName.Leave += new System.EventHandler(this._cmbDataSourceName_Leave);
            this._cmbDataSourceName.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this._cmbDataSourceName_PreviewKeyDown);
            // 
            // _dspMain
            // 
            this._dspMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dspMain.DataSource = null;
            this._dspMain.DesignerHostServices = null;
            this._dspMain.Location = new System.Drawing.Point(0, 38);
            this._dspMain.Name = "_dspMain";
            this._dspMain.Size = new System.Drawing.Size(464, 245);
            this._dspMain.TabIndex = 2;
            // 
            // DataSourceForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this._cmbDataSourceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._dspMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "DataSourceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Sources";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataSourceForm_FormClosing);
            this.Load += new System.EventHandler(this.DataSourceForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DataSourcePicker _dspMain;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _cmbDataSourceName;

    }
}
