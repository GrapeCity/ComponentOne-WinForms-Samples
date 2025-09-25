namespace InputPanelExplorer.Samples
{
    partial class QueryBuilder
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilder));
            c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            hdrQueryBuilder = new C1.Win.InputPanel.InputGroupHeader();
            btnAddNew = new C1.Win.InputPanel.InputButton();
            btnSubmit = new C1.Win.InputPanel.InputButton();
            inputSeparator1 = new C1.Win.InputPanel.InputSeparator();
            lblAndOr = new C1.Win.InputPanel.InputLabel();
            lblPropertyName = new C1.Win.InputPanel.InputLabel();
            lblOperator = new C1.Win.InputPanel.InputLabel();
            lblValue = new C1.Win.InputPanel.InputLabel();
            lblPlaceHolder = new C1.Win.InputPanel.InputLabel();
            hdrSqlText = new C1.Win.InputPanel.InputGroupHeader();
            txtSqlText = new C1.Win.InputPanel.InputTextBox();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            imageList1 = new System.Windows.Forms.ImageList(components);
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)c1InputPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // c1InputPanel1
            // 
            c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1InputPanel1.DesignScaleFactor = 1.79487181F;
            c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            c1InputPanel1.Items.Add(hdrQueryBuilder);
            c1InputPanel1.Items.Add(btnAddNew);
            c1InputPanel1.Items.Add(btnSubmit);
            c1InputPanel1.Items.Add(inputSeparator1);
            c1InputPanel1.Items.Add(lblAndOr);
            c1InputPanel1.Items.Add(lblPropertyName);
            c1InputPanel1.Items.Add(lblOperator);
            c1InputPanel1.Items.Add(lblValue);
            c1InputPanel1.Items.Add(lblPlaceHolder);
            c1InputPanel1.Items.Add(hdrSqlText);
            c1InputPanel1.Items.Add(txtSqlText);
            c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            c1InputPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1InputPanel1.Name = "c1InputPanel1";
            c1InputPanel1.Size = new System.Drawing.Size(1903, 536);
            c1InputPanel1.TabIndex = 0;
            // 
            // hdrQueryBuilder
            // 
            hdrQueryBuilder.Collapsible = true;
            hdrQueryBuilder.Name = "hdrQueryBuilder";
            hdrQueryBuilder.Text = "Query Builder";
            // 
            // btnAddNew
            // 
            btnAddNew.Break = C1.Win.InputPanel.BreakType.None;
            btnAddNew.Image = (System.Drawing.Image)resources.GetObject("btnAddNew.Image");
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Text = "Add Condition";
            btnAddNew.ToolTipText = "Add New Condition Row";
            btnAddNew.Click += AddNewRow;
            // 
            // btnSubmit
            // 
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Text = "Execute Query";
            btnSubmit.Width = 114;
            btnSubmit.Click += SubmitButton;
            // 
            // inputSeparator1
            // 
            inputSeparator1.Name = "inputSeparator1";
            inputSeparator1.Width = 357;
            // 
            // lblAndOr
            // 
            lblAndOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblAndOr.FontPadding = true;
            lblAndOr.Name = "lblAndOr";
            lblAndOr.Text = "And/Or";
            lblAndOr.Width = 50;
            // 
            // lblPropertyName
            // 
            lblPropertyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPropertyName.FontPadding = true;
            lblPropertyName.Name = "lblPropertyName";
            lblPropertyName.Text = "Field Name";
            lblPropertyName.Width = 100;
            // 
            // lblOperator
            // 
            lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblOperator.FontPadding = true;
            lblOperator.Name = "lblOperator";
            lblOperator.Text = "Operator";
            lblOperator.Width = 100;
            // 
            // lblValue
            // 
            lblValue.Break = C1.Win.InputPanel.BreakType.Row;
            lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblValue.FontPadding = true;
            lblValue.Name = "lblValue";
            lblValue.Text = "Value";
            lblValue.Width = 100;
            // 
            // lblPlaceHolder
            // 
            lblPlaceHolder.Name = "lblPlaceHolder";
            lblPlaceHolder.Width = 50;
            // 
            // hdrSqlText
            // 
            hdrSqlText.Collapsible = true;
            hdrSqlText.Name = "hdrSqlText";
            hdrSqlText.Text = "SQL Text";
            // 
            // txtSqlText
            // 
            txtSqlText.Height = 63;
            txtSqlText.Multiline = true;
            txtSqlText.Name = "txtSqlText";
            txtSqlText.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Spread;
            txtSqlText.Width = 365;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            c1FlexGrid1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new System.Drawing.Size(1903, 660);
            c1FlexGrid1.TabIndex = 2;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "Remove_2.png");
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(c1InputPanel1);
            splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(c1FlexGrid1);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new System.Drawing.Size(1903, 1204);
            splitContainer1.SplitterDistance = 536;
            splitContainer1.SplitterWidth = 8;
            splitContainer1.TabIndex = 3;
            // 
            // QueryBuilder
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "QueryBuilder";
            Size = new System.Drawing.Size(1903, 1204);
            Load += QueryBuilder_Load;
            ((System.ComponentModel.ISupportInitialize)c1InputPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.InputPanel.InputGroupHeader hdrQueryBuilder;
        private C1.Win.InputPanel.InputLabel lblAndOr;
        private C1.Win.InputPanel.InputLabel lblPropertyName;
        private C1.Win.InputPanel.InputLabel lblOperator;
        private C1.Win.InputPanel.InputLabel lblValue;
        private C1.Win.InputPanel.InputSeparator inputSeparator1;
        private C1.Win.InputPanel.InputButton btnSubmit;
        private C1.Win.InputPanel.InputButton btnAddNew;
        private C1.Win.InputPanel.InputLabel lblPlaceHolder;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.InputPanel.InputGroupHeader hdrSqlText;
        private C1.Win.InputPanel.InputTextBox txtSqlText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ImageList imageList1;

    }

}
