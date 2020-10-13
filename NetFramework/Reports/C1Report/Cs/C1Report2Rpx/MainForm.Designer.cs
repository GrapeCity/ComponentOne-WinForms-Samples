namespace C1Report2Rpx
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveConverted = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRunARDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRunARPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbC1ReportFile = new System.Windows.Forms.ToolStripComboBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.dgvcReport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcRpxFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcConvertingResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsReports = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmtsmiSaveConverted = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtsmiRunARDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.cmtsmiRunARPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.dgvcLogLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLogMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcLogSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsLog = new System.Windows.Forms.ToolStrip();
            this.tsbHideShowLog = new System.Windows.Forms.ToolStripButton();
            this.tslLogTitle = new System.Windows.Forms.ToolStripLabel();
            this.tssC1ReportName = new System.Windows.Forms.ToolStripSeparator();
            this.tslC1ReportName = new System.Windows.Forms.ToolStripLabel();
            this.ofdC1ReportFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdARFile = new System.Windows.Forms.SaveFileDialog();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.cmsReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.tsLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiActions,
            this.tsmiHelp,
            this.tscbC1ReportFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMain.ShowItemToolTips = true;
            this.msMain.Size = new System.Drawing.Size(844, 27);
            this.msMain.TabIndex = 4;
            this.msMain.Text = "menuStrip1";
            this.msMain.Resize += new System.EventHandler(this.msMain_Resize);
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 23);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiOpen.Size = new System.Drawing.Size(280, 22);
            this.tsmiOpen.Text = "&Open C1Report definition file...";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(280, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaveConverted,
            this.tsmiRunARDesigner,
            this.tsmiRunARPreview});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(59, 23);
            this.tsmiActions.Text = "&Actions";
            this.tsmiActions.DropDownOpening += new System.EventHandler(this.tsmiActions_DropDownOpening);
            // 
            // tsmiSaveConverted
            // 
            this.tsmiSaveConverted.Name = "tsmiSaveConverted";
            this.tsmiSaveConverted.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmiSaveConverted.Size = new System.Drawing.Size(294, 22);
            this.tsmiSaveConverted.Text = "Save ActiveReports definition file...";
            this.tsmiSaveConverted.Click += new System.EventHandler(this.tsmiSaveConverted_Click);
            // 
            // tsmiRunARDesigner
            // 
            this.tsmiRunARDesigner.Name = "tsmiRunARDesigner";
            this.tsmiRunARDesigner.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.tsmiRunARDesigner.Size = new System.Drawing.Size(294, 22);
            this.tsmiRunARDesigner.Text = "ActiveReports Designer...";
            this.tsmiRunARDesigner.Click += new System.EventHandler(this.tsmiRunARDesigner_Click);
            // 
            // tsmiRunARPreview
            // 
            this.tsmiRunARPreview.Name = "tsmiRunARPreview";
            this.tsmiRunARPreview.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmiRunARPreview.Size = new System.Drawing.Size(294, 22);
            this.tsmiRunARPreview.Text = "ActiveReports Preview...";
            this.tsmiRunARPreview.Click += new System.EventHandler(this.tsmiRunARPreview_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 23);
            this.tsmiHelp.Text = "&Help";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "&About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tscbC1ReportFile
            // 
            this.tscbC1ReportFile.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbC1ReportFile.AutoSize = false;
            this.tscbC1ReportFile.Name = "tscbC1ReportFile";
            this.tscbC1ReportFile.Size = new System.Drawing.Size(400, 23);
            this.tscbC1ReportFile.ToolTipText = "C1Report XML file (Ctrl+O)";
            this.tscbC1ReportFile.SelectedIndexChanged += new System.EventHandler(this.tscbC1ReportFile_SelectedIndexChanged);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 27);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dgvReports);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvLog);
            this.scMain.Panel2.Controls.Add(this.tsLog);
            this.scMain.Size = new System.Drawing.Size(844, 539);
            this.scMain.SplitterDistance = 319;
            this.scMain.TabIndex = 5;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AllowUserToResizeRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcReport,
            this.dgvcRpxFileName,
            this.dgvcConvertingResult});
            this.dgvReports.ContextMenuStrip = this.cmsReports;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(0, 0);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.Size = new System.Drawing.Size(844, 319);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.VirtualMode = true;
            this.dgvReports.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvReports_CellPainting);
            this.dgvReports.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvReports_CellValueNeeded);
            this.dgvReports.CurrentCellChanged += new System.EventHandler(this.dgvReports_CurrentCellChanged);
            // 
            // dgvcReport
            // 
            this.dgvcReport.HeaderText = "Report";
            this.dgvcReport.Name = "dgvcReport";
            // 
            // dgvcRpxFileName
            // 
            this.dgvcRpxFileName.HeaderText = "RPX file name";
            this.dgvcRpxFileName.Name = "dgvcRpxFileName";
            // 
            // dgvcConvertingResult
            // 
            this.dgvcConvertingResult.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvcConvertingResult.HeaderText = "Converting status";
            this.dgvcConvertingResult.Name = "dgvcConvertingResult";
            this.dgvcConvertingResult.ReadOnly = true;
            this.dgvcConvertingResult.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcConvertingResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvcConvertingResult.Width = 150;
            // 
            // cmsReports
            // 
            this.cmsReports.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmtsmiSaveConverted,
            this.cmtsmiRunARDesigner,
            this.cmtsmiRunARPreview});
            this.cmsReports.Name = "cmsReports";
            this.cmsReports.Size = new System.Drawing.Size(295, 92);
            this.cmsReports.Opening += new System.ComponentModel.CancelEventHandler(this.cmsReports_Opening);
            // 
            // cmtsmiSaveConverted
            // 
            this.cmtsmiSaveConverted.Name = "cmtsmiSaveConverted";
            this.cmtsmiSaveConverted.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cmtsmiSaveConverted.Size = new System.Drawing.Size(294, 22);
            this.cmtsmiSaveConverted.Text = "Save ActiveReports definition file...";
            this.cmtsmiSaveConverted.Click += new System.EventHandler(this.tsmiSaveConverted_Click);
            // 
            // cmtsmiRunARDesigner
            // 
            this.cmtsmiRunARDesigner.Name = "cmtsmiRunARDesigner";
            this.cmtsmiRunARDesigner.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.cmtsmiRunARDesigner.Size = new System.Drawing.Size(294, 22);
            this.cmtsmiRunARDesigner.Text = "ActiveReports Designer...";
            this.cmtsmiRunARDesigner.Click += new System.EventHandler(this.tsmiRunARDesigner_Click);
            // 
            // cmtsmiRunARPreview
            // 
            this.cmtsmiRunARPreview.Name = "cmtsmiRunARPreview";
            this.cmtsmiRunARPreview.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmtsmiRunARPreview.Size = new System.Drawing.Size(294, 22);
            this.cmtsmiRunARPreview.Text = "ActiveReports Preview...";
            this.cmtsmiRunARPreview.Click += new System.EventHandler(this.tsmiRunARPreview_Click);
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AllowUserToResizeRows = false;
            this.dgvLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLog.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcLogLevel,
            this.dgvcIndex,
            this.dgvcLogMessage,
            this.dgvcLogSource});
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(0, 25);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.RowHeadersVisible = false;
            this.dgvLog.Size = new System.Drawing.Size(844, 191);
            this.dgvLog.TabIndex = 4;
            this.dgvLog.VirtualMode = true;
            this.dgvLog.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvLog_CellPainting);
            this.dgvLog.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvLog_CellValueNeeded);
            // 
            // dgvcLogLevel
            // 
            this.dgvcLogLevel.HeaderText = "";
            this.dgvcLogLevel.Name = "dgvcLogLevel";
            this.dgvcLogLevel.ReadOnly = true;
            this.dgvcLogLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcLogLevel.Width = 25;
            // 
            // dgvcIndex
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvcIndex.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcIndex.HeaderText = "";
            this.dgvcIndex.Name = "dgvcIndex";
            this.dgvcIndex.ReadOnly = true;
            this.dgvcIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcIndex.Width = 60;
            // 
            // dgvcLogMessage
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcLogMessage.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcLogMessage.HeaderText = "Message";
            this.dgvcLogMessage.Name = "dgvcLogMessage";
            this.dgvcLogMessage.Width = 500;
            // 
            // dgvcLogSource
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcLogSource.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcLogSource.HeaderText = "Source";
            this.dgvcLogSource.Name = "dgvcLogSource";
            this.dgvcLogSource.Width = 200;
            // 
            // tsLog
            // 
            this.tsLog.BackColor = System.Drawing.SystemColors.Window;
            this.tsLog.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHideShowLog,
            this.tslLogTitle,
            this.tssC1ReportName,
            this.tslC1ReportName});
            this.tsLog.Location = new System.Drawing.Point(0, 0);
            this.tsLog.Name = "tsLog";
            this.tsLog.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tsLog.Size = new System.Drawing.Size(844, 25);
            this.tsLog.TabIndex = 3;
            this.tsLog.Text = "toolStrip1";
            // 
            // tsbHideShowLog
            // 
            this.tsbHideShowLog.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbHideShowLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbHideShowLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHideShowLog.Name = "tsbHideShowLog";
            this.tsbHideShowLog.Size = new System.Drawing.Size(23, 22);
            this.tsbHideShowLog.Text = "toolStripButton1";
            this.tsbHideShowLog.ToolTipText = "Toggle the visibility of update log";
            this.tsbHideShowLog.Click += new System.EventHandler(this.tsbHideShowLog_Click);
            // 
            // tslLogTitle
            // 
            this.tslLogTitle.Name = "tslLogTitle";
            this.tslLogTitle.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tslLogTitle.Size = new System.Drawing.Size(92, 22);
            this.tslLogTitle.Text = "Converting Log:";
            this.tslLogTitle.Click += new System.EventHandler(this.tslLogTitle_Click);
            // 
            // tssC1ReportName
            // 
            this.tssC1ReportName.Name = "tssC1ReportName";
            this.tssC1ReportName.Size = new System.Drawing.Size(6, 25);
            // 
            // tslC1ReportName
            // 
            this.tslC1ReportName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslC1ReportName.Name = "tslC1ReportName";
            this.tslC1ReportName.Size = new System.Drawing.Size(117, 22);
            this.tslC1ReportName.Text = "C1Report definition";
            // 
            // ofdC1ReportFile
            // 
            this.ofdC1ReportFile.Filter = "C1Report definition (*.xml)|*.xml|All files (*.*)|*.*";
            this.ofdC1ReportFile.Title = "Select C1Report definition";
            // 
            // sfdARFile
            // 
            this.sfdARFile.Filter = "ActiveReports definition (*.rpx)|*.rpx|All files (*.*)|*.*";
            this.sfdARFile.Title = "Select ActiveReports file";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 566);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.msMain);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ComponentOne C1Report to ActiveReports converter";
            this.Load += new System.EventHandler(this.MainForm2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm2_KeyDown);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.cmsReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.tsLog.ResumeLayout(false);
            this.tsLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveConverted;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunARDesigner;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripComboBox tscbC1ReportFile;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ToolStrip tsLog;
        private System.Windows.Forms.ToolStripButton tsbHideShowLog;
        private System.Windows.Forms.ToolStripLabel tslLogTitle;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.OpenFileDialog ofdC1ReportFile;
        private System.Windows.Forms.ToolStripLabel tslC1ReportName;
        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcRpxFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcConvertingResult;
        private System.Windows.Forms.ToolStripSeparator tssC1ReportName;
        private System.Windows.Forms.SaveFileDialog sfdARFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLogLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLogMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcLogSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiRunARPreview;
        private System.Windows.Forms.ContextMenuStrip cmsReports;
        private System.Windows.Forms.ToolStripMenuItem cmtsmiSaveConverted;
        private System.Windows.Forms.ToolStripMenuItem cmtsmiRunARDesigner;
        private System.Windows.Forms.ToolStripMenuItem cmtsmiRunARPreview;

    }
}