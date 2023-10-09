//----------------------------------------------------------------------------
// DataSourcePicker.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Util
{
    partial class DataSourcePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSourcePicker));
            this._tcMain = new System.Windows.Forms.TabControl();
            this._tpDataObjects = new System.Windows.Forms.TabPage();
            this._tvDataObjects = new System.Windows.Forms.TreeView();
            this._tpConnection = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this._btnEditConnection = new System.Windows.Forms.Button();
            this._cbConnectionString = new System.Windows.Forms.ComboBox();
            this._cbDataProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._tcConnection = new System.Windows.Forms.TabControl();
            this._tpDataSource = new System.Windows.Forms.TabPage();
            this._btnDataSourceProperties = new System.Windows.Forms.Button();
            this._tvDataSource = new System.Windows.Forms.TreeView();
            this._ilMain = new System.Windows.Forms.ImageList(this.components);
            this._tpSql = new System.Windows.Forms.TabPage();
            this._btnQueryBuilder = new System.Windows.Forms.Button();
            this._cbWordWrap = new System.Windows.Forms.CheckBox();
            this._tbSql = new System.Windows.Forms.TextBox();
            this._tpCalculatedFields = new System.Windows.Forms.TabPage();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._lvCalculatedFields = new System.Windows.Forms.ListView();
            this._propGrid = new System.Windows.Forms.PropertyGrid();
            this._ttMain = new System.Windows.Forms.ToolTip(this.components);
            this._tcMain.SuspendLayout();
            this._tpDataObjects.SuspendLayout();
            this._tpConnection.SuspendLayout();
            this._tcConnection.SuspendLayout();
            this._tpDataSource.SuspendLayout();
            this._tpSql.SuspendLayout();
            this._tpCalculatedFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tcMain
            // 
            this._tcMain.Controls.Add(this._tpDataObjects);
            this._tcMain.Controls.Add(this._tpConnection);
            this._tcMain.Controls.Add(this._tpCalculatedFields);
            this._tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tcMain.Location = new System.Drawing.Point(0, 0);
            this._tcMain.Name = "_tcMain";
            this._tcMain.SelectedIndex = 0;
            this._tcMain.Size = new System.Drawing.Size(445, 381);
            this._tcMain.TabIndex = 0;
            this._tcMain.SelectedIndexChanged += new System.EventHandler(this._tcMain_SelectedIndexChanged);
            // 
            // _tpDataObjects
            // 
            this._tpDataObjects.Controls.Add(this._tvDataObjects);
            this._tpDataObjects.Location = new System.Drawing.Point(4, 22);
            this._tpDataObjects.Name = "_tpDataObjects";
            this._tpDataObjects.Padding = new System.Windows.Forms.Padding(3);
            this._tpDataObjects.Size = new System.Drawing.Size(437, 355);
            this._tpDataObjects.TabIndex = 0;
            this._tpDataObjects.Text = "Data Objects";
            this._tpDataObjects.UseVisualStyleBackColor = true;
            // 
            // _tvDataObjects
            // 
            this._tvDataObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvDataObjects.HideSelection = false;
            this._tvDataObjects.Location = new System.Drawing.Point(6, 6);
            this._tvDataObjects.Name = "_tvDataObjects";
            this._tvDataObjects.Size = new System.Drawing.Size(425, 343);
            this._tvDataObjects.TabIndex = 0;
            // 
            // _tpConnection
            // 
            this._tpConnection.Controls.Add(this.label2);
            this._tpConnection.Controls.Add(this._btnEditConnection);
            this._tpConnection.Controls.Add(this._cbConnectionString);
            this._tpConnection.Controls.Add(this._cbDataProvider);
            this._tpConnection.Controls.Add(this.label1);
            this._tpConnection.Controls.Add(this._tcConnection);
            this._tpConnection.Location = new System.Drawing.Point(4, 22);
            this._tpConnection.Name = "_tpConnection";
            this._tpConnection.Padding = new System.Windows.Forms.Padding(3);
            this._tpConnection.Size = new System.Drawing.Size(437, 355);
            this._tpConnection.TabIndex = 1;
            this._tpConnection.Text = "Connection";
            this._tpConnection.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection string:";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // _btnEditConnection
            // 
            this._btnEditConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnEditConnection.Location = new System.Drawing.Point(405, 33);
            this._btnEditConnection.Name = "_btnEditConnection";
            this._btnEditConnection.Size = new System.Drawing.Size(26, 21);
            this._btnEditConnection.TabIndex = 3;
            this._btnEditConnection.Text = "...";
            this._btnEditConnection.UseVisualStyleBackColor = true;
            this._btnEditConnection.Click += new System.EventHandler(this._btnEditConnection_Click);
            // 
            // _cbConnectionString
            // 
            this._cbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._cbConnectionString.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cbConnectionString.FormattingEnabled = true;
            this._cbConnectionString.ItemHeight = 15;
            this._cbConnectionString.Location = new System.Drawing.Point(107, 33);
            this._cbConnectionString.Name = "_cbConnectionString";
            this._cbConnectionString.Size = new System.Drawing.Size(292, 21);
            this._cbConnectionString.TabIndex = 2;
            this._cbConnectionString.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._cbConnectionString_DrawItem);
            this._cbConnectionString.SelectedIndexChanged += new System.EventHandler(this._cbConnectionString_SelectedIndexChanged);
            this._cbConnectionString.Enter += new System.EventHandler(this._cbConnectionString_Enter);
            this._cbConnectionString.Leave += new System.EventHandler(this._cbConnectionString_Leave);
            // 
            // _cbDataProvider
            // 
            this._cbDataProvider.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._cbDataProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbDataProvider.FormattingEnabled = true;
            this._cbDataProvider.Location = new System.Drawing.Point(107, 6);
            this._cbDataProvider.Name = "_cbDataProvider";
            this._cbDataProvider.Size = new System.Drawing.Size(291, 21);
            this._cbDataProvider.TabIndex = 0;
            this._cbDataProvider.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this._cbDataProvider_DrawItem);
            this._cbDataProvider.SelectedIndexChanged += new System.EventHandler(this._cbDataProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data provider:";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // _tcConnection
            // 
            this._tcConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tcConnection.Controls.Add(this._tpDataSource);
            this._tcConnection.Controls.Add(this._tpSql);
            this._tcConnection.Location = new System.Drawing.Point(6, 60);
            this._tcConnection.Name = "_tcConnection";
            this._tcConnection.SelectedIndex = 0;
            this._tcConnection.Size = new System.Drawing.Size(425, 289);
            this._tcConnection.TabIndex = 4;
            // 
            // _tpDataSource
            // 
            this._tpDataSource.Controls.Add(this._btnDataSourceProperties);
            this._tpDataSource.Controls.Add(this._tvDataSource);
            this._tpDataSource.Location = new System.Drawing.Point(4, 22);
            this._tpDataSource.Name = "_tpDataSource";
            this._tpDataSource.Padding = new System.Windows.Forms.Padding(3);
            this._tpDataSource.Size = new System.Drawing.Size(417, 263);
            this._tpDataSource.TabIndex = 0;
            this._tpDataSource.Text = "Data source";
            this._tpDataSource.UseVisualStyleBackColor = true;
            // 
            // _btnDataSourceProperties
            // 
            this._btnDataSourceProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnDataSourceProperties.Location = new System.Drawing.Point(336, 231);
            this._btnDataSourceProperties.Name = "_btnDataSourceProperties";
            this._btnDataSourceProperties.Size = new System.Drawing.Size(75, 23);
            this._btnDataSourceProperties.TabIndex = 1;
            this._btnDataSourceProperties.Text = "Properties...";
            this._btnDataSourceProperties.UseVisualStyleBackColor = true;
            this._btnDataSourceProperties.Click += new System.EventHandler(this._btnDataSourceProperties_Click);
            // 
            // _tvDataSource
            // 
            this._tvDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tvDataSource.HideSelection = false;
            this._tvDataSource.ImageIndex = 0;
            this._tvDataSource.ImageList = this._ilMain;
            this._tvDataSource.Location = new System.Drawing.Point(6, 6);
            this._tvDataSource.Name = "_tvDataSource";
            this._tvDataSource.SelectedImageIndex = 0;
            this._tvDataSource.Size = new System.Drawing.Size(405, 222);
            this._tvDataSource.TabIndex = 0;
            this._tvDataSource.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this._tvDataSource_AfterSelect);
            // 
            // _ilMain
            // 
            this._ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilMain.ImageStream")));
            this._ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this._ilMain.Images.SetKeyName(0, "Folder.png");
            this._ilMain.Images.SetKeyName(1, "Table.png");
            this._ilMain.Images.SetKeyName(2, "View.png");
            this._ilMain.Images.SetKeyName(3, "StoredProcedure.png");
            this._ilMain.Images.SetKeyName(4, "ExternalRecordset.png");
            // 
            // _tpSql
            // 
            this._tpSql.Controls.Add(this._btnQueryBuilder);
            this._tpSql.Controls.Add(this._cbWordWrap);
            this._tpSql.Controls.Add(this._tbSql);
            this._tpSql.Location = new System.Drawing.Point(4, 22);
            this._tpSql.Name = "_tpSql";
            this._tpSql.Padding = new System.Windows.Forms.Padding(3);
            this._tpSql.Size = new System.Drawing.Size(518, 364);
            this._tpSql.TabIndex = 1;
            this._tpSql.Text = "Sql statement";
            this._tpSql.UseVisualStyleBackColor = true;
            // 
            // _btnQueryBuilder
            // 
            this._btnQueryBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnQueryBuilder.Location = new System.Drawing.Point(402, 332);
            this._btnQueryBuilder.Name = "_btnQueryBuilder";
            this._btnQueryBuilder.Size = new System.Drawing.Size(110, 23);
            this._btnQueryBuilder.TabIndex = 2;
            this._btnQueryBuilder.Text = "Query builder...";
            this._btnQueryBuilder.UseVisualStyleBackColor = true;
            this._btnQueryBuilder.Click += new System.EventHandler(this._btnQueryBuilder_Click);
            // 
            // _cbWordWrap
            // 
            this._cbWordWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._cbWordWrap.AutoSize = true;
            this._cbWordWrap.Location = new System.Drawing.Point(6, 335);
            this._cbWordWrap.Name = "_cbWordWrap";
            this._cbWordWrap.Size = new System.Drawing.Size(78, 17);
            this._cbWordWrap.TabIndex = 1;
            this._cbWordWrap.Text = "Word wrap";
            this._cbWordWrap.UseVisualStyleBackColor = true;
            this._cbWordWrap.CheckedChanged += new System.EventHandler(this._cbWordWrap_CheckedChanged);
            // 
            // _tbSql
            // 
            this._tbSql.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSql.Location = new System.Drawing.Point(6, 6);
            this._tbSql.MaxLength = 500000;
            this._tbSql.Multiline = true;
            this._tbSql.Name = "_tbSql";
            this._tbSql.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._tbSql.Size = new System.Drawing.Size(506, 323);
            this._tbSql.TabIndex = 0;
            this._tbSql.WordWrap = false;
            // 
            // _tpCalculatedFields
            // 
            this._tpCalculatedFields.Controls.Add(this._btnRemove);
            this._tpCalculatedFields.Controls.Add(this._btnAdd);
            this._tpCalculatedFields.Controls.Add(this.splitContainer1);
            this._tpCalculatedFields.Location = new System.Drawing.Point(4, 22);
            this._tpCalculatedFields.Name = "_tpCalculatedFields";
            this._tpCalculatedFields.Padding = new System.Windows.Forms.Padding(3);
            this._tpCalculatedFields.Size = new System.Drawing.Size(437, 355);
            this._tpCalculatedFields.TabIndex = 2;
            this._tpCalculatedFields.Text = "Calculated Fields";
            this._tpCalculatedFields.UseVisualStyleBackColor = true;
            // 
            // _btnRemove
            // 
            this._btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnRemove.Location = new System.Drawing.Point(87, 326);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(75, 23);
            this._btnRemove.TabIndex = 1;
            this._btnRemove.Text = "Remove";
            this._btnRemove.UseVisualStyleBackColor = true;
            this._btnRemove.Click += new System.EventHandler(this._btnRemove_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnAdd.Location = new System.Drawing.Point(6, 326);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(75, 23);
            this._btnAdd.TabIndex = 0;
            this._btnAdd.Text = "Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._lvCalculatedFields);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._propGrid);
            this.splitContainer1.Size = new System.Drawing.Size(425, 314);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 0;
            // 
            // _lvCalculatedFields
            // 
            this._lvCalculatedFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lvCalculatedFields.Location = new System.Drawing.Point(0, 0);
            this._lvCalculatedFields.MultiSelect = false;
            this._lvCalculatedFields.Name = "_lvCalculatedFields";
            this._lvCalculatedFields.Size = new System.Drawing.Size(141, 314);
            this._lvCalculatedFields.TabIndex = 0;
            this._lvCalculatedFields.UseCompatibleStateImageBehavior = false;
            this._lvCalculatedFields.View = System.Windows.Forms.View.List;
            this._lvCalculatedFields.SelectedIndexChanged += new System.EventHandler(this._lvCalculatedFields_SelectedIndexChanged);
            // 
            // _propGrid
            // 
            this._propGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._propGrid.Location = new System.Drawing.Point(0, 0);
            this._propGrid.Name = "_propGrid";
            this._propGrid.Size = new System.Drawing.Size(280, 314);
            this._propGrid.TabIndex = 0;
            // 
            // DataSourcePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tcMain);
            this.Name = "DataSourcePicker";
            this.Size = new System.Drawing.Size(445, 381);
            this._tcMain.ResumeLayout(false);
            this._tpDataObjects.ResumeLayout(false);
            this._tpConnection.ResumeLayout(false);
            this._tpConnection.PerformLayout();
            this._tcConnection.ResumeLayout(false);
            this._tpDataSource.ResumeLayout(false);
            this._tpSql.ResumeLayout(false);
            this._tpSql.PerformLayout();
            this._tpCalculatedFields.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tcMain;
        private System.Windows.Forms.TabPage _tpDataObjects;
        private System.Windows.Forms.TabPage _tpConnection;
        private System.Windows.Forms.TreeView _tvDataObjects;
        private System.Windows.Forms.TabControl _tcConnection;
        private System.Windows.Forms.TabPage _tpDataSource;
        private System.Windows.Forms.TabPage _tpSql;
        private System.Windows.Forms.Button _btnDataSourceProperties;
        private System.Windows.Forms.TreeView _tvDataSource;
        private System.Windows.Forms.TextBox _tbSql;
        private System.Windows.Forms.CheckBox _cbWordWrap;
        private System.Windows.Forms.Button _btnQueryBuilder;
        private System.Windows.Forms.ToolTip _ttMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnEditConnection;
        private System.Windows.Forms.ComboBox _cbConnectionString;
        private System.Windows.Forms.ComboBox _cbDataProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList _ilMain;
        private System.Windows.Forms.TabPage _tpCalculatedFields;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView _lvCalculatedFields;
        private System.Windows.Forms.PropertyGrid _propGrid;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnAdd;
    }
}
